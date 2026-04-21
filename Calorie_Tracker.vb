Imports System.IO
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.VistaAeroTheme

Public Class Calorie_Tracker
    ' Variables to store totals
    Dim totalCalories As Integer = 0
    Dim totalWater As Integer = 0
    Dim totalBurned As Integer = 0

    Public userId As Integer
    Public id As Integer

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Calorie_Tracker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCalorieTracker()
    End Sub

    Private Sub LoadCalorieTracker()
        Dim meal As String
        Dim calories As Integer
        Dim water As Integer
        Dim exercise As String
        Dim burned As Integer

        Dim dtExercise As New DataTable
        Dim dtWater As New DataTable
        Dim dtMeal As New DataTable

        dtExercise.Columns.Add("Id", GetType(Integer))
        dtExercise.Columns.Add("UserId", GetType(Integer))
        dtExercise.Columns.Add("ExerciseName", GetType(String))
        dtExercise.Columns.Add("CaloriesBurned", GetType(Integer))

        dtMeal.Columns.Add("Id", GetType(Integer))
        dtMeal.Columns.Add("UserId", GetType(Integer))
        dtMeal.Columns.Add("MealName", GetType(String))
        dtMeal.Columns.Add("Calories", GetType(Integer))

        dtWater.Columns.Add("Id", GetType(Integer))
        dtWater.Columns.Add("UserId", GetType(Integer))
        dtWater.Columns.Add("AmountMl", GetType(Integer))

        totalCalories = 0
        totalWater = 0
        totalBurned = 0

        rgvMeal.Rows.Clear()
        rgvExercise.Rows.Clear()
        rgvWater.Rows.Clear()

        dtMeal = DBHelper.SelectMeals(userId, Now)
        For Each row In dtMeal.Rows
            id = row.item("Id")
            meal = row.item("MealName")
            calories = row.item("Calories")
            rgvMeal.Rows.Add(id, userId, meal, calories)

            totalCalories += calories
        Next

        dtWater = DBHelper.SelectWater(userId, Now)
        For Each row In dtWater.Rows
            id = row.item("Id")
            water = row.item("AmountMl")
            rgvWater.Rows.Add(id, userId, water)

            totalWater += water
        Next

        dtExercise = DBHelper.SelectExercise(userId, Now)
        For Each row In dtExercise.Rows
            id = row.item("Id")
            exercise = row.item("Exercise")
            burned = row.item("Calories Burned")
            rgvExercise.Rows.Add(id, userId, exercise, burned)

            totalBurned += burned
        Next

        lblTotalCalories.Text = "Total Calories: " & totalCalories & " kcal"
        lblTotalWater.Text = "Total Water: " & totalWater & " ml"
        lblTotalBurned.Text = "Total Burned: " & totalBurned & " kcal"
    End Sub

    ' ===== MEAL ENTRY =====
    Private Sub btnAddMeal_Click(sender As Object, e As EventArgs) Handles btnAddMeal.Click
        Dim meal As String = txtMeal.Text
        Dim calories As Integer
        Dim dtMeal As New DataTable
        rgvMeal.Rows.Clear()
        lblTotalCalories.Text = ""
        totalCalories = 0

        If Integer.TryParse(txtCalories.Text, calories) AndAlso meal <> "" Then
            DBHelper.AddMeal(userId, meal, calories)
            dtMeal = DBHelper.SelectMeals(userId, Now)
            For Each row In dtMeal.Rows
                meal = row.item("MealName")
                calories = row.item("Calories")
                rgvMeal.Rows.Add(id, userId, meal, calories)
                'lstMeals.Items.Add(meal & " - " & calories & " kcal")

                totalCalories += calories
            Next
            lblTotalCalories.Text = "Total Calories: " & totalCalories & " kcal"
            txtMeal.Clear()
            txtCalories.Clear()
        Else
            MessageBox.Show("Enter valid meal and calorie value.")
        End If
    End Sub

    ' ===== WATER INTAKE =====
    Private Sub btnAddWater_Click(sender As Object, e As EventArgs) Handles btnAddWater.Click
        Dim water As Integer
        Dim dtWater As New DataTable
        rgvWater.Rows.Clear()
        lblTotalWater.Text = ""
        totalWater = 0

        If Integer.TryParse(txtWater.Text, water) Then
            DBHelper.AddWater(userId, water)
            dtWater = DBHelper.SelectWater(userId, Now)
            For Each row In dtWater.Rows
                water = row.item("AmountMl")
                rgvWater.Rows.Add(id, userId, water)
                'lstWater.Items.Add("Consumed: " & water & " ml")

                totalWater += water
            Next
            lblTotalWater.Text = "Total Water: " & totalWater & " ml"
            txtWater.Clear()
        Else
            MessageBox.Show("Enter a valid water amount in ml.")
        End If
    End Sub

    ' ===== EXERCISE ENTRY =====
    Private Sub btnAddExercise_Click(sender As Object, e As EventArgs) Handles btnAddExercise.Click
        Dim exercise As String = txtExercise.Text
        Dim burned As Integer
        Dim dtExercise As New DataTable
        rgvExercise.Rows.Clear()
        lblTotalBurned.Text = ""
        totalBurned = 0

        If Integer.TryParse(txtCaloriesBurned.Text, burned) AndAlso exercise <> "" Then
            DBHelper.AddExercise(userId, exercise, burned)
            dtExercise = DBHelper.SelectExercise(userId, Now)
            For Each row In dtExercise.Rows
                exercise = row.item("Exercise")
                burned = row.item("Calories Burned")
                rgvExercise.Rows.Add(id, userId, exercise, burned)
                'lstExercise.Items.Add(exercise & " - " & burned & " kcal burned")

                totalBurned += burned
            Next
            lblTotalBurned.Text = "Total Burned: " & totalBurned & " kcal"
            txtExercise.Clear()
            txtCaloriesBurned.Clear()
        Else
            MessageBox.Show("Enter valid exercise and calories burned.")
        End If
    End Sub


    Private Sub Calorie_Tracker_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        LoginForm.Close()
    End Sub

    Private Sub rgvExercise_UserDeletingRow(sender As Object, e As GridViewRowCancelEventArgs) Handles rgvExercise.UserDeletingRow
        Dim Id As Integer = e.Rows(0).Cells(0).Value
        Dim UserId As Integer = e.Rows(0).Cells(1).Value
        DBHelper.DeleteExercise(UserId, Id)
        LoadCalorieTracker()
    End Sub

    Private Sub rgvMeal_UserDeletingRow(sender As Object, e As GridViewRowCancelEventArgs) Handles rgvMeal.UserDeletingRow
        Dim Id As Integer = e.Rows(0).Cells(0).Value
        Dim UserId As Integer = e.Rows(0).Cells(1).Value
        DBHelper.DeleteMeals(UserId, Id)
        LoadCalorieTracker()
    End Sub

    Private Sub rgvWater_UserDeletingRow(sender As Object, e As GridViewRowCancelEventArgs) Handles rgvWater.UserDeletingRow
        Dim Id As Integer = e.Rows(0).Cells(0).Value
        Dim UserId As Integer = e.Rows(0).Cells(1).Value
        DBHelper.DeleteWater(UserId, Id)
        LoadCalorieTracker()
    End Sub
End Class
