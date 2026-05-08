Imports System.Data.SqlClient

''' <summary>
''' Handles exercise data for the calorie tracker.
''' </summary>
Public Class ExerciseEntry
    Public Property Id As Integer
    Public Property UserId As Integer
    Public Property ExerciseName As String
    Public Property CaloriesBurned As Integer
    Public Property CreatedAt As Date

    Public Sub New()
    End Sub

    Public Sub New(userId As Integer, exerciseName As String, caloriesBurned As Integer)
        Me.UserId = userId
        Me.ExerciseName = exerciseName
        Me.CaloriesBurned = caloriesBurned
        Me.CreatedAt = Date.Now
    End Sub

    Public Shared Function IsValid(exerciseName As String, caloriesBurnedText As String, ByRef caloriesBurned As Integer) As Boolean
        Return Not String.IsNullOrWhiteSpace(exerciseName) AndAlso
               Integer.TryParse(caloriesBurnedText.Trim(), caloriesBurned) AndAlso
               caloriesBurned >= 0
    End Function

    Public Shared Sub Add(userId As Integer, exerciseName As String, caloriesBurned As Integer)
        Using conn As New SqlConnection(DBHelper.connectionString)
            conn.Open()
            Using cmd As New SqlCommand("INSERT INTO Exercises (UserId, ExerciseName, CaloriesBurned) VALUES (@uid, @name, @burned)", conn)
                cmd.Parameters.AddWithValue("@uid", userId)
                cmd.Parameters.AddWithValue("@name", exerciseName)
                cmd.Parameters.AddWithValue("@burned", caloriesBurned)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Shared Function GetForDay(userId As Integer, selectedDate As Date) As DataTable
        Dim sql As String = "SELECT Id, UserId, ExerciseName AS Exercise, CaloriesBurned AS [Calories Burned] " &
                            "FROM Exercises " &
                            "WHERE CreatedAt >= @startDate AND CreatedAt < @endDate AND UserId = @userId " &
                            "ORDER BY CreatedAt, Id"

        Return DBHelper.GetDataTableFromSql(sql,
                                            New SqlParameter("@startDate", selectedDate.Date),
                                            New SqlParameter("@endDate", selectedDate.Date.AddDays(1)),
                                            New SqlParameter("@userId", userId))
    End Function

    Public Shared Sub Delete(userId As Integer, exerciseId As Integer)
        Using conn As New SqlConnection(DBHelper.connectionString)
            conn.Open()
            Using cmd As New SqlCommand("DELETE FROM Exercises WHERE UserId = @user AND Id = @Id", conn)
                cmd.Parameters.AddWithValue("@user", userId)
                cmd.Parameters.AddWithValue("@Id", exerciseId)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub
End Class
