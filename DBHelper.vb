Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class DBHelper
    Public Shared connectionString As String = "Server=localhost;Database=CalorieTrackerDB;Trusted_Connection=True;"

    Public Shared Function AuthenticateUser(username As String, password As String) As Integer
        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Dim cmd As New SqlCommand("SELECT Id FROM Users WHERE Username=@username AND Password=@password", conn)
            cmd.Parameters.AddWithValue("@username", username)
            cmd.Parameters.AddWithValue("@password", password)
            Dim result = cmd.ExecuteScalar()
            If result IsNot Nothing Then
                Return Convert.ToInt32(result)
            End If
        End Using
        Return -1 ' Invalid
    End Function

    Private Shared Function GetDataTableFromSql(sqlQuery As String) As DataTable
        Dim dt As New DataTable()

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(sqlQuery, connection)
                Using adapter As New SqlDataAdapter(command)
                    Try
                        connection.Open()
                        adapter.Fill(dt)
                    Catch ex As Exception
                        ' Handle the exception (e.g., log it, display an error message)
                        Console.WriteLine("Error retrieving data: " & ex.Message)
                        Return Nothing ' Or throw the exception
                    End Try
                End Using
            End Using
        End Using

        Return dt
    End Function

#Region "Inserts"
    Public Sub AddUser(userName As String, Password As String)
        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Dim cmd As New SqlCommand("INSERT INTO Users (UserName, Password) VALUES (@user, @pass)", conn)
            cmd.Parameters.AddWithValue("@user", userName)
            cmd.Parameters.AddWithValue("@pass", Password)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Public Shared Sub AddMeal(userId As Integer, meal As String, calories As Integer)
        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Dim cmd As New SqlCommand("INSERT INTO Meals (UserId, MealName, Calories) VALUES (@uid, @meal, @cal)", conn)
            cmd.Parameters.AddWithValue("@uid", userId)
            cmd.Parameters.AddWithValue("@meal", meal)
            cmd.Parameters.AddWithValue("@cal", calories)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Public Shared Sub AddWater(userId As Integer, amount As Integer)
        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Dim cmd As New SqlCommand("INSERT INTO WaterIntake (UserId, AmountMl) VALUES (@uid, @amount)", conn)
            cmd.Parameters.AddWithValue("@uid", userId)
            cmd.Parameters.AddWithValue("@amount", amount)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Public Shared Sub AddExercise(userId As Integer, name As String, burned As Integer)
        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Dim cmd As New SqlCommand("INSERT INTO Exercises (UserId, ExerciseName, CaloriesBurned) VALUES (@uid, @name, @burned)", conn)
            cmd.Parameters.AddWithValue("@uid", userId)
            cmd.Parameters.AddWithValue("@name", name)
            cmd.Parameters.AddWithValue("@burned", burned)
            cmd.ExecuteNonQuery()
        End Using
    End Sub
#End Region

#Region "Selects"
    Public Shared Function SelectMeals(userId As Integer, Today As Date) As DataTable
        Dim sql As String
        sql = "SELECT Id,UserId,MealName,Calories FROM Meals WHERE CreatedAt >= '" + Format(Today, "yyy-MM-dd 00:00:00.000") + "' and UserId = '" + userId.ToString + "'"

        SelectMeals = GetDataTableFromSql(sql)
        Return SelectMeals
    End Function

    Public Shared Function SelectWater(userId As Integer, Today As Date) As DataTable
        Dim sql As String
        sql = "SELECT Id,UserId,AmountMl FROM WaterIntake WHERE CreatedAt >= '" + Format(Today, "yyy-MM-dd 00:00:00.000") + "' and UserId = '" + userId.ToString + "'"

        SelectWater = GetDataTableFromSql(sql)
        Return SelectWater
    End Function

    Public Shared Function SelectExercise(userId As Integer, Today As Date) As DataTable
        Dim sql As String
        sql = "SELECT Id,UserId,ExerciseName as Exercise,CaloriesBurned as [Calories Burned] FROM Exercises WHERE CreatedAt >= '" + Format(Today, "yyy-MM-dd 00:00:00.000") + "' and UserId = '" + userId.ToString + "'"

        SelectExercise = GetDataTableFromSql(sql)
        Return SelectExercise
    End Function
#End Region

#Region "Deletes"
    Public Shared Sub DeleteMeals(userId As Integer, Id As Integer)
        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Dim cmd As New SqlCommand("DELETE FROM Meals WHERE UserId = @user and Id = @Id", conn)
            cmd.Parameters.AddWithValue("@user", userId)
            cmd.Parameters.AddWithValue("@Id", Id)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Public Shared Sub DeleteWater(userId As Integer, Id As Integer)
        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Dim cmd As New SqlCommand("DELETE FROM WaterIntake WHERE UserId = @user and Id = @Id", conn)
            cmd.Parameters.AddWithValue("@user", userId)
            cmd.Parameters.AddWithValue("@Id", Id)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Public Shared Sub DeleteExercise(userId As Integer, Id As Integer)
        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Dim cmd As New SqlCommand("DELETE FROM Exercises WHERE UserId = @user and Id = @Id", conn)
            cmd.Parameters.AddWithValue("@user", userId)
            cmd.Parameters.AddWithValue("@Id", Id)
            cmd.ExecuteNonQuery()
        End Using
    End Sub
#End Region

End Class
