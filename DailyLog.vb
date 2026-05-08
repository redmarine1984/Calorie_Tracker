Imports Calorie_Tracker.Calorie_Tracker
Imports System.Data.SqlClient

''' <summary>
''' Handles daily calorie, water, and net-calorie totals.
''' </summary>
Public Class DailyLog
    Public Property LogDate As Date
    Public Property CaloriesIn As Integer
    Public Property CaloriesBurned As Integer
    Public Property NetCalories As Integer
    Public Property WaterMl As Integer



    Public Shared Sub AddWater(userId As Integer, amountMl As Integer)
        Using conn As New SqlConnection(DBHelper.connectionString)
            conn.Open()
            Using cmd As New SqlCommand("INSERT INTO WaterIntake (UserId, AmountMl) VALUES (@uid, @amount)", conn)
                cmd.Parameters.AddWithValue("@uid", userId)
                cmd.Parameters.AddWithValue("@amount", amountMl)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Shared Function GetWaterForDay(userId As Integer, selectedDate As Date) As DataTable
        Dim sql As String = "SELECT Id, UserId, AmountMl " &
                            "FROM WaterIntake " &
                            "WHERE CreatedAt >= @startDate AND CreatedAt < @endDate AND UserId = @userId " &
                            "ORDER BY CreatedAt, Id"

        Return DBHelper.GetDataTableFromSql(sql,
                                            New SqlParameter("@startDate", selectedDate.Date),
                                            New SqlParameter("@endDate", selectedDate.Date.AddDays(1)),
                                            New SqlParameter("@userId", userId))
    End Function

    Public Shared Sub DeleteWater(userId As Integer, waterId As Integer)
        Using conn As New SqlConnection(DBHelper.connectionString)
            conn.Open()
            Using cmd As New SqlCommand("DELETE FROM WaterIntake WHERE UserId = @user AND Id = @Id", conn)
                cmd.Parameters.AddWithValue("@user", userId)
                cmd.Parameters.AddWithValue("@Id", waterId)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Shared Function GetDailyTotals(userId As Integer) As DataTable
        Dim sql As String = "WITH LogDates AS (" &
                            "    SELECT CAST(CreatedAt AS date) AS LogDate FROM Meals WHERE UserId = @userId " &
                            "    UNION " &
                            "    SELECT CAST(CreatedAt AS date) AS LogDate FROM WaterIntake WHERE UserId = @userId " &
                            "    UNION " &
                            "    SELECT CAST(CreatedAt AS date) AS LogDate FROM Exercises WHERE UserId = @userId " &
                            ") " &
                            "SELECT d.LogDate, " &
                            "       ISNULL(m.CaloriesIn, 0) AS CaloriesIn, " &
                            "       ISNULL(w.WaterMl, 0) AS WaterMl, " &
                            "       ISNULL(e.CaloriesBurned, 0) AS CaloriesBurned, " &
                            "       ISNULL(m.CaloriesIn, 0) - ISNULL(e.CaloriesBurned, 0) AS NetCalories " &
                            "FROM LogDates d " &
                            "LEFT JOIN (SELECT CAST(CreatedAt AS date) AS LogDate, SUM(Calories) AS CaloriesIn FROM Meals WHERE UserId = @userId GROUP BY CAST(CreatedAt AS date)) m ON d.LogDate = m.LogDate " &
                            "LEFT JOIN (SELECT CAST(CreatedAt AS date) AS LogDate, SUM(AmountMl) AS WaterMl FROM WaterIntake WHERE UserId = @userId GROUP BY CAST(CreatedAt AS date)) w ON d.LogDate = w.LogDate " &
                            "LEFT JOIN (SELECT CAST(CreatedAt AS date) AS LogDate, SUM(CaloriesBurned) AS CaloriesBurned FROM Exercises WHERE UserId = @userId GROUP BY CAST(CreatedAt AS date)) e ON d.LogDate = e.LogDate " &
                            "ORDER BY d.LogDate ASC"

        Return DBHelper.GetDataTableFromSql(sql, New SqlParameter("@userId", userId))
    End Function
End Class

