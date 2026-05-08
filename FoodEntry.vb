Imports System.Data.SqlClient

''' <summary>
''' Handles meal/food data for the calorie tracker.
''' </summary>
Public Class FoodEntry
    Public Property Id As Integer
    Public Property UserId As Integer
    Public Property FoodName As String
    Public Property Calories As Integer
    Public Property CreatedAt As Date

    Public Sub New()
    End Sub

    Public Sub New(userId As Integer, foodName As String, calories As Integer)
        Me.UserId = userId
        Me.FoodName = foodName
        Me.Calories = calories
        Me.CreatedAt = Date.Now
    End Sub

    Public Shared Function IsValid(foodName As String, caloriesText As String, ByRef calories As Integer) As Boolean
        Return Not String.IsNullOrWhiteSpace(foodName) AndAlso
               Integer.TryParse(caloriesText.Trim(), calories) AndAlso
               calories >= 0
    End Function

    Public Shared Sub Add(userId As Integer, foodName As String, calories As Integer)
        Using conn As New SqlConnection(DBHelper.connectionString)
            conn.Open()
            Using cmd As New SqlCommand("INSERT INTO Meals (UserId, MealName, Calories) VALUES (@uid, @meal, @cal)", conn)
                cmd.Parameters.AddWithValue("@uid", userId)
                cmd.Parameters.AddWithValue("@meal", foodName)
                cmd.Parameters.AddWithValue("@cal", calories)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Shared Function GetForDay(userId As Integer, selectedDate As Date) As DataTable
        Dim sql As String = "SELECT Id, UserId, MealName, Calories " &
                            "FROM Meals " &
                            "WHERE CreatedAt >= @startDate AND CreatedAt < @endDate AND UserId = @userId " &
                            "ORDER BY CreatedAt, Id"

        Return DBHelper.GetDataTableFromSql(sql,
                                            New SqlParameter("@startDate", selectedDate.Date),
                                            New SqlParameter("@endDate", selectedDate.Date.AddDays(1)),
                                            New SqlParameter("@userId", userId))
    End Function

    Public Shared Sub Delete(userId As Integer, mealId As Integer)
        Using conn As New SqlConnection(DBHelper.connectionString)
            conn.Open()
            Using cmd As New SqlCommand("DELETE FROM Meals WHERE UserId = @user AND Id = @Id", conn)
                cmd.Parameters.AddWithValue("@user", userId)
                cmd.Parameters.AddWithValue("@Id", mealId)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub
End Class
