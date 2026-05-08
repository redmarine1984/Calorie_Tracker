''Imports System.IO
''Imports Telerik.WinControls.UI
''Imports Telerik.WinControls.VistaAeroTheme

''Public Class Calorie_Tracker
''    ' Variables to store totals
''    Dim totalCalories As Integer = 0
''    Dim totalWater As Integer = 0
''    Dim totalBurned As Integer = 0

''    Public userId As Integer
''    Public id As Integer

''    Public Sub New()
''        InitializeComponent()
''    End Sub

''    Private Sub Calorie_Tracker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
''        LoadCalorieTracker()
''    End Sub

''    Private Sub LoadCalorieTracker()
''        Dim meal As String
''        Dim calories As Integer
''        Dim water As Integer
''        Dim exercise As String
''        Dim burned As Integer

''        Dim dtExercise As New DataTable
''        Dim dtWater As New DataTable
''        Dim dtMeal As New DataTable

''        dtExercise.Columns.Add("Id", GetType(Integer))
''        dtExercise.Columns.Add("UserId", GetType(Integer))
''        dtExercise.Columns.Add("ExerciseName", GetType(String))
''        dtExercise.Columns.Add("CaloriesBurned", GetType(Integer))

''        dtMeal.Columns.Add("Id", GetType(Integer))
''        dtMeal.Columns.Add("UserId", GetType(Integer))
''        dtMeal.Columns.Add("MealName", GetType(String))
''        dtMeal.Columns.Add("Calories", GetType(Integer))

''        dtWater.Columns.Add("Id", GetType(Integer))
''        dtWater.Columns.Add("UserId", GetType(Integer))
''        dtWater.Columns.Add("AmountMl", GetType(Integer))

''        totalCalories = 0
''        totalWater = 0
''        totalBurned = 0

''        rgvMeal.Rows.Clear()
''        rgvExercise.Rows.Clear()
''        rgvWater.Rows.Clear()

''        dtMeal = DBHelper.SelectMeals(userId, Now)
''        For Each row In dtMeal.Rows
''            id = row.item("Id")
''            meal = row.item("MealName")
''            calories = row.item("Calories")
''            rgvMeal.Rows.Add(id, userId, meal, calories)

''            totalCalories += calories
''        Next

''        dtWater = DBHelper.SelectWater(userId, Now)
''        For Each row In dtWater.Rows
''            id = row.item("Id")
''            water = row.item("AmountMl")
''            rgvWater.Rows.Add(id, userId, water)

''            totalWater += water
''        Next

''        dtExercise = DBHelper.SelectExercise(userId, Now)
''        For Each row In dtExercise.Rows
''            id = row.item("Id")
''            exercise = row.item("Exercise")
''            burned = row.item("Calories Burned")
''            rgvExercise.Rows.Add(id, userId, exercise, burned)

''            totalBurned += burned
''        Next

''        lblTotalCalories.Text = "Total Calories: " & totalCalories & " kcal"
''        lblTotalWater.Text = "Total Water: " & totalWater & " ml"
''        lblTotalBurned.Text = "Total Burned: " & totalBurned & " kcal"
''    End Sub

''    ' ===== MEAL ENTRY =====
''    Private Sub btnAddMeal_Click(sender As Object, e As EventArgs) Handles btnAddMeal.Click
''        Dim meal As String = txtMeal.Text
''        Dim calories As Integer
''        Dim dtMeal As New DataTable
''        rgvMeal.Rows.Clear()
''        lblTotalCalories.Text = ""
''        totalCalories = 0

''        If Integer.TryParse(txtCalories.Text, calories) AndAlso meal <> "" Then
''            DBHelper.AddMeal(userId, meal, calories)
''            dtMeal = DBHelper.SelectMeals(userId, Now)
''            For Each row In dtMeal.Rows
''                meal = row.item("MealName")
''                calories = row.item("Calories")
''                rgvMeal.Rows.Add(id, userId, meal, calories)
''                'lstMeals.Items.Add(meal & " - " & calories & " kcal")

''                totalCalories += calories
''            Next
''            lblTotalCalories.Text = "Total Calories: " & totalCalories & " kcal"
''            txtMeal.Clear()
''            txtCalories.Clear()
''        Else
''            MessageBox.Show("Enter valid meal and calorie value.")
''        End If
''    End Sub

''    ' ===== WATER INTAKE =====
''    Private Sub btnAddWater_Click(sender As Object, e As EventArgs) Handles btnAddWater.Click
''        Dim water As Integer
''        Dim dtWater As New DataTable
''        rgvWater.Rows.Clear()
''        lblTotalWater.Text = ""
''        totalWater = 0

''        If Integer.TryParse(txtWater.Text, water) Then
''            DBHelper.AddWater(userId, water)
''            dtWater = DBHelper.SelectWater(userId, Now)
''            For Each row In dtWater.Rows
''                water = row.item("AmountMl")
''                rgvWater.Rows.Add(id, userId, water)
''                'lstWater.Items.Add("Consumed: " & water & " ml")

''                totalWater += water
''            Next
''            lblTotalWater.Text = "Total Water: " & totalWater & " ml"
''            txtWater.Clear()
''        Else
''            MessageBox.Show("Enter a valid water amount in ml.")
''        End If
''    End Sub

''    ' ===== EXERCISE ENTRY =====
''    Private Sub btnAddExercise_Click(sender As Object, e As EventArgs) Handles btnAddExercise.Click
''        Dim exercise As String = txtExercise.Text
''        Dim burned As Integer
''        Dim dtExercise As New DataTable
''        rgvExercise.Rows.Clear()
''        lblTotalBurned.Text = ""
''        totalBurned = 0

''        If Integer.TryParse(txtCaloriesBurned.Text, burned) AndAlso exercise <> "" Then
''            DBHelper.AddExercise(userId, exercise, burned)
''            dtExercise = DBHelper.SelectExercise(userId, Now)
''            For Each row In dtExercise.Rows
''                exercise = row.item("Exercise")
''                burned = row.item("Calories Burned")
''                rgvExercise.Rows.Add(id, userId, exercise, burned)
''                'lstExercise.Items.Add(exercise & " - " & burned & " kcal burned")

''                totalBurned += burned
''            Next
''            lblTotalBurned.Text = "Total Burned: " & totalBurned & " kcal"
''            txtExercise.Clear()
''            txtCaloriesBurned.Clear()
''        Else
''            MessageBox.Show("Enter valid exercise and calories burned.")
''        End If
''    End Sub


''    Private Sub Calorie_Tracker_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
''        LoginForm.Close()
''    End Sub

''    Private Sub rgvExercise_UserDeletingRow(sender As Object, e As GridViewRowCancelEventArgs) Handles rgvExercise.UserDeletingRow
''        Dim Id As Integer = e.Rows(0).Cells(0).Value
''        Dim UserId As Integer = e.Rows(0).Cells(1).Value
''        DBHelper.DeleteExercise(UserId, Id)
''        LoadCalorieTracker()
''    End Sub

''    Private Sub rgvMeal_UserDeletingRow(sender As Object, e As GridViewRowCancelEventArgs) Handles rgvMeal.UserDeletingRow
''        Dim Id As Integer = e.Rows(0).Cells(0).Value
''        Dim UserId As Integer = e.Rows(0).Cells(1).Value
''        DBHelper.DeleteMeals(UserId, Id)
''        LoadCalorieTracker()
''    End Sub

''    Private Sub rgvWater_UserDeletingRow(sender As Object, e As GridViewRowCancelEventArgs) Handles rgvWater.UserDeletingRow
''        Dim Id As Integer = e.Rows(0).Cells(0).Value
''        Dim UserId As Integer = e.Rows(0).Cells(1).Value
''        DBHelper.DeleteWater(UserId, Id)
''        LoadCalorieTracker()
''    End Sub
''End Class

'Imports System.Drawing
'Imports Telerik.WinControls.UI

'Public Class Calorie_Tracker
'    ' Variables to store today's totals
'    Private totalCalories As Integer = 0
'    Private totalWater As Integer = 0
'    Private totalBurned As Integer = 0

'    Public userId As Integer

'    Private ReadOnly rgvDailyTotals As New RadGridView()
'    Private ReadOnly lblDailyHistoryTitle As New Label()
'    Private ReadOnly lblNetCalories As New Label()
'    Private ReadOnly lblMealSection As New Label()
'    Private ReadOnly lblWaterSection As New Label()
'    Private ReadOnly lblExerciseSection As New Label()

'    Public Sub New()
'        InitializeComponent()
'    End Sub

'    Private Sub Calorie_Tracker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        ConfigureProfessionalLayout()
'        LoadCalorieTracker()
'    End Sub

'    Private Sub ConfigureProfessionalLayout()
'        Me.Text = "Calorie Tracker Dashboard"
'        Me.ClientSize = New Size(1180, 720)
'        Me.MinimumSize = New Size(1100, 700)
'        Me.BackColor = Color.FromArgb(245, 247, 250)
'        Me.BackgroundImage = Nothing
'        Me.Font = New Font("Segoe UI", 9.0!, FontStyle.Regular)

'        rlabTitle.Text = "Calorie Tracker Dashboard"
'        rlabTitle.Font = New Font("Segoe UI Semibold", 22.0!, FontStyle.Bold)
'        rlabTitle.ForeColor = Color.FromArgb(31, 41, 55)
'        rlabTitle.Location = New Point(24, 18)
'        rlabTitle.AutoSize = True

'        lblMealSection.Text = "Meals"
'        lblWaterSection.Text = "Water Intake"
'        lblExerciseSection.Text = "Exercise"

'        ConfigureSectionLabel(lblMealSection, New Point(24, 76))
'        ConfigureSectionLabel(lblWaterSection, New Point(24, 272))
'        ConfigureSectionLabel(lblExerciseSection, New Point(24, 458))

'        ConfigureLabel(Label1, "Meal name", New Point(24, 112))
'        ConfigureLabel(Label2, "Calories", New Point(24, 148))
'        ConfigureLabel(Label4, "Water (ml)", New Point(24, 308))
'        ConfigureLabel(Label6, "Exercise", New Point(24, 494))
'        ConfigureLabel(Label7, "Calories burned", New Point(24, 530))

'        ConfigureTextBox(txtMeal, New Point(142, 108), 180)
'        ConfigureTextBox(txtCalories, New Point(142, 144), 180)
'        ConfigureTextBox(txtWater, New Point(142, 304), 180)
'        ConfigureTextBox(txtExercise, New Point(142, 490), 180)
'        ConfigureTextBox(txtCaloriesBurned, New Point(142, 526), 180)

'        ConfigureButton(btnAddMeal, "Add Meal", New Point(142, 180), 180)
'        ConfigureButton(btnAddWater, "Add Water", New Point(142, 340), 180)
'        ConfigureButton(btnAddExercise, "Add Exercise", New Point(142, 562), 180)

'        ConfigureSummaryLabel(lblTotalCalories, New Point(360, 82))
'        ConfigureSummaryLabel(lblTotalWater, New Point(360, 278))
'        ConfigureSummaryLabel(lblTotalBurned, New Point(360, 464))
'        ConfigureSummaryLabel(lblNetCalories, New Point(360, 624))

'        ConfigureGrid(rgvMeal, New Point(360, 112), New Size(350, 142))
'        ConfigureGrid(rgvWater, New Point(360, 308), New Size(350, 120))
'        ConfigureGrid(rgvExercise, New Point(360, 494), New Size(350, 120))

'        lblDailyHistoryTitle.Text = "Daily Calorie Totals - Past to Present"
'        lblDailyHistoryTitle.Font = New Font("Segoe UI Semibold", 13.0!, FontStyle.Bold)
'        lblDailyHistoryTitle.ForeColor = Color.FromArgb(31, 41, 55)
'        lblDailyHistoryTitle.AutoSize = True
'        lblDailyHistoryTitle.Location = New Point(750, 82)

'        ConfigureDailyTotalsGrid()

'        If Not Me.Controls.Contains(lblMealSection) Then Me.Controls.Add(lblMealSection)
'        If Not Me.Controls.Contains(lblWaterSection) Then Me.Controls.Add(lblWaterSection)
'        If Not Me.Controls.Contains(lblExerciseSection) Then Me.Controls.Add(lblExerciseSection)
'        If Not Me.Controls.Contains(lblNetCalories) Then Me.Controls.Add(lblNetCalories)
'        If Not Me.Controls.Contains(lblDailyHistoryTitle) Then Me.Controls.Add(lblDailyHistoryTitle)
'        If Not Me.Controls.Contains(rgvDailyTotals) Then Me.Controls.Add(rgvDailyTotals)

'        rgvDailyTotals.BringToFront()
'        lblDailyHistoryTitle.BringToFront()
'    End Sub

'    Private Sub ConfigureSectionLabel(label As Label, location As Point)
'        label.Font = New Font("Segoe UI Semibold", 12.0!, FontStyle.Bold)
'        label.ForeColor = Color.FromArgb(37, 99, 235)
'        label.AutoSize = True
'        label.Location = location
'    End Sub

'    Private Sub ConfigureLabel(label As Label, text As String, location As Point)
'        label.Text = text
'        label.Font = New Font("Segoe UI", 9.5!, FontStyle.Regular)
'        label.ForeColor = Color.FromArgb(75, 85, 99)
'        label.AutoSize = True
'        label.Location = location
'    End Sub

'    Private Sub ConfigureTextBox(textBox As TextBox, location As Point, width As Integer)
'        textBox.Location = location
'        textBox.Size = New Size(width, 26)
'        textBox.Font = New Font("Segoe UI", 9.5!, FontStyle.Regular)
'        textBox.BorderStyle = BorderStyle.FixedSingle
'    End Sub

'    Private Sub ConfigureButton(button As Button, text As String, location As Point, width As Integer)
'        button.Text = text
'        button.Location = location
'        button.Size = New Size(width, 32)
'        button.FlatStyle = FlatStyle.Flat
'        button.FlatAppearance.BorderSize = 0
'        button.BackColor = Color.FromArgb(37, 99, 235)
'        button.ForeColor = Color.White
'        button.Font = New Font("Segoe UI Semibold", 9.5!, FontStyle.Bold)
'        button.Cursor = Cursors.Hand
'    End Sub

'    Private Sub ConfigureSummaryLabel(label As Label, location As Point)
'        label.Location = location
'        label.AutoSize = True
'        label.Font = New Font("Segoe UI Semibold", 10.5!, FontStyle.Bold)
'        label.ForeColor = Color.FromArgb(17, 24, 39)
'        label.BackColor = Color.Transparent
'    End Sub

'    Private Sub ConfigureGrid(grid As RadGridView, location As Point, size As Size)
'        grid.Location = location
'        grid.Size = size
'        grid.Font = New Font("Segoe UI", 9.0!, FontStyle.Regular)
'        grid.BackColor = Color.White
'        grid.ForeColor = Color.FromArgb(31, 41, 55)
'        grid.ShowGroupPanel = False
'        grid.MasterTemplate.EnableGrouping = False
'        grid.MasterTemplate.AllowAddNewRow = False
'        grid.MasterTemplate.AllowEditRow = False
'        grid.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
'    End Sub

'    Private Sub ConfigureDailyTotalsGrid()
'        rgvDailyTotals.Location = New Point(750, 112)
'        rgvDailyTotals.Size = New Size(390, 502)
'        rgvDailyTotals.Font = New Font("Segoe UI", 9.0!, FontStyle.Regular)
'        rgvDailyTotals.BackColor = Color.White
'        rgvDailyTotals.ForeColor = Color.FromArgb(31, 41, 55)
'        rgvDailyTotals.ShowGroupPanel = False
'        rgvDailyTotals.MasterTemplate.EnableGrouping = False
'        rgvDailyTotals.MasterTemplate.AllowAddNewRow = False
'        rgvDailyTotals.MasterTemplate.AllowEditRow = False
'        rgvDailyTotals.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
'        rgvDailyTotals.MasterTemplate.Columns.Clear()
'        AddDailyTotalsColumn("Date", "colDate")
'        AddDailyTotalsColumn("Calories In", "colCaloriesIn")
'        AddDailyTotalsColumn("Burned", "colBurned")
'        AddDailyTotalsColumn("Net", "colNet")
'        AddDailyTotalsColumn("Water ml", "colWater")
'    End Sub


'    Private Sub AddDailyTotalsColumn(headerText As String, columnName As String)
'        Dim column As New GridViewTextBoxColumn()
'        column.HeaderText = headerText
'        column.Name = columnName
'        rgvDailyTotals.MasterTemplate.Columns.Add(column)
'    End Sub

'    Private Sub LoadCalorieTracker()
'        totalCalories = 0
'        totalWater = 0
'        totalBurned = 0

'        LoadMeals()
'        LoadWater()
'        LoadExercises()
'        RefreshTodaySummary()
'        LoadDailyTotals()
'    End Sub

'    Private Sub LoadMeals()
'        rgvMeal.Rows.Clear()
'        Dim dtMeal As DataTable = DBHelper.SelectMeals(userId, Date.Today)
'        If dtMeal Is Nothing Then Return

'        For Each row As DataRow In dtMeal.Rows
'            Dim mealId As Integer = Convert.ToInt32(row.Item("Id"))
'            Dim meal As String = Convert.ToString(row.Item("MealName"))
'            Dim calories As Integer = Convert.ToInt32(row.Item("Calories"))
'            rgvMeal.Rows.Add(mealId, userId, meal, calories)
'            totalCalories += calories
'        Next
'    End Sub

'    Private Sub LoadWater()
'        rgvWater.Rows.Clear()
'        Dim dtWater As DataTable = DBHelper.SelectWater(userId, Date.Today)
'        If dtWater Is Nothing Then Return

'        For Each row As DataRow In dtWater.Rows
'            Dim waterId As Integer = Convert.ToInt32(row.Item("Id"))
'            Dim water As Integer = Convert.ToInt32(row.Item("AmountMl"))
'            rgvWater.Rows.Add(waterId, userId, water)
'            totalWater += water
'        Next
'    End Sub

'    Private Sub LoadExercises()
'        rgvExercise.Rows.Clear()
'        Dim dtExercise As DataTable = DBHelper.SelectExercise(userId, Date.Today)
'        If dtExercise Is Nothing Then Return

'        For Each row As DataRow In dtExercise.Rows
'            Dim exerciseId As Integer = Convert.ToInt32(row.Item("Id"))
'            Dim exercise As String = Convert.ToString(row.Item("Exercise"))
'            Dim burned As Integer = Convert.ToInt32(row.Item("Calories Burned"))
'            rgvExercise.Rows.Add(exerciseId, userId, exercise, burned)
'            totalBurned += burned
'        Next
'    End Sub

'    Private Sub RefreshTodaySummary()
'        Dim netCalories As Integer = totalCalories - totalBurned
'        lblTotalCalories.Text = "Today's Calories In: " & totalCalories.ToString("N0") & " kcal"
'        lblTotalWater.Text = "Today's Water: " & totalWater.ToString("N0") & " ml"
'        lblTotalBurned.Text = "Today's Calories Burned: " & totalBurned.ToString("N0") & " kcal"
'        lblNetCalories.Text = "Today's Net Calories: " & netCalories.ToString("N0") & " kcal"
'    End Sub

'    Private Sub LoadDailyTotals()
'        rgvDailyTotals.Rows.Clear()
'        Dim dtTotals As DataTable = DBHelper.SelectDailyTotals(userId)
'        If dtTotals Is Nothing Then Return

'        For Each row As DataRow In dtTotals.Rows
'            Dim logDate As Date = Convert.ToDateTime(row.Item("LogDate"))
'            Dim caloriesIn As Integer = Convert.ToInt32(row.Item("CaloriesIn"))
'            Dim waterMl As Integer = Convert.ToInt32(row.Item("WaterMl"))
'            Dim caloriesBurned As Integer = Convert.ToInt32(row.Item("CaloriesBurned"))
'            Dim netCalories As Integer = Convert.ToInt32(row.Item("NetCalories"))
'            rgvDailyTotals.Rows.Add(logDate.ToString("MM/dd/yyyy"), caloriesIn, caloriesBurned, netCalories, waterMl)
'        Next
'    End Sub

'    ' ===== MEAL ENTRY =====
'    Private Sub btnAddMeal_Click(sender As Object, e As EventArgs) Handles btnAddMeal.Click
'        Dim meal As String = txtMeal.Text.Trim()
'        Dim calories As Integer

'        If Integer.TryParse(txtCalories.Text.Trim(), calories) AndAlso meal <> "" AndAlso calories >= 0 Then
'            DBHelper.AddMeal(userId, meal, calories)
'            txtMeal.Clear()
'            txtCalories.Clear()
'            LoadCalorieTracker()
'        Else
'            MessageBox.Show("Enter a valid meal name and calorie value.", "Invalid Meal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
'        End If
'    End Sub

'    ' ===== WATER INTAKE =====
'    Private Sub btnAddWater_Click(sender As Object, e As EventArgs) Handles btnAddWater.Click
'        Dim water As Integer

'        If Integer.TryParse(txtWater.Text.Trim(), water) AndAlso water >= 0 Then
'            DBHelper.AddWater(userId, water)
'            txtWater.Clear()
'            LoadCalorieTracker()
'        Else
'            MessageBox.Show("Enter a valid water amount in ml.", "Invalid Water Intake", MessageBoxButtons.OK, MessageBoxIcon.Warning)
'        End If
'    End Sub

'    ' ===== EXERCISE ENTRY =====
'    Private Sub btnAddExercise_Click(sender As Object, e As EventArgs) Handles btnAddExercise.Click
'        Dim exercise As String = txtExercise.Text.Trim()
'        Dim burned As Integer

'        If Integer.TryParse(txtCaloriesBurned.Text.Trim(), burned) AndAlso exercise <> "" AndAlso burned >= 0 Then
'            DBHelper.AddExercise(userId, exercise, burned)
'            txtExercise.Clear()
'            txtCaloriesBurned.Clear()
'            LoadCalorieTracker()
'        Else
'            MessageBox.Show("Enter a valid exercise and calories burned.", "Invalid Exercise", MessageBoxButtons.OK, MessageBoxIcon.Warning)
'        End If
'    End Sub

'    Private Sub Calorie_Tracker_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
'        LoginForm.Close()
'    End Sub

'    Private Sub rgvExercise_UserDeletingRow(sender As Object, e As GridViewRowCancelEventArgs) Handles rgvExercise.UserDeletingRow
'        Dim exerciseId As Integer = Convert.ToInt32(e.Rows(0).Cells(0).Value)
'        Dim exerciseUserId As Integer = Convert.ToInt32(e.Rows(0).Cells(1).Value)
'        DBHelper.DeleteExercise(exerciseUserId, exerciseId)
'        LoadCalorieTracker()
'    End Sub

'    Private Sub rgvMeal_UserDeletingRow(sender As Object, e As GridViewRowCancelEventArgs) Handles rgvMeal.UserDeletingRow
'        Dim mealId As Integer = Convert.ToInt32(e.Rows(0).Cells(0).Value)
'        Dim mealUserId As Integer = Convert.ToInt32(e.Rows(0).Cells(1).Value)
'        DBHelper.DeleteMeals(mealUserId, mealId)
'        LoadCalorieTracker()
'    End Sub

'    Private Sub rgvWater_UserDeletingRow(sender As Object, e As GridViewRowCancelEventArgs) Handles rgvWater.UserDeletingRow
'        Dim waterId As Integer = Convert.ToInt32(e.Rows(0).Cells(0).Value)
'        Dim waterUserId As Integer = Convert.ToInt32(e.Rows(0).Cells(1).Value)
'        DBHelper.DeleteWater(waterUserId, waterId)
'        LoadCalorieTracker()
'    End Sub
'End Class
Imports System.Drawing
Imports System.Windows.Forms.DataVisualization.Charting
Imports Telerik.WinControls.UI

Public Class Calorie_Tracker
    ' Variables to store today's totals
    Private totalCalories As Integer = 0
    Private totalWater As Integer = 0
    Private totalBurned As Integer = 0

    Public userId As Integer

    Private ReadOnly dailyTotalsChart As New Chart()
    Private ReadOnly lblDailyHistoryTitle As New Label()
    Private ReadOnly lblNetCalories As New Label()
    Private ReadOnly lblMealSection As New Label()
    Private ReadOnly lblWaterSection As New Label()
    Private ReadOnly lblExerciseSection As New Label()

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Calorie_Tracker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfigureProfessionalLayout()
        LoadCalorieTracker()
    End Sub

    Private Sub ConfigureProfessionalLayout()
        Me.Text = "Calorie Tracker Dashboard"
        Me.ClientSize = New Size(1180, 720)
        Me.MinimumSize = New Size(1100, 700)
        Me.BackColor = Color.FromArgb(245, 247, 250)
        Me.BackgroundImage = Nothing
        Me.Font = New Font("Segoe UI", 9.0!, FontStyle.Regular)

        rlabTitle.Text = "Calorie Tracker Dashboard"
        rlabTitle.Font = New Font("Segoe UI Semibold", 22.0!, FontStyle.Bold)
        rlabTitle.ForeColor = Color.FromArgb(31, 41, 55)
        rlabTitle.Location = New Point(24, 18)
        rlabTitle.AutoSize = True

        lblMealSection.Text = "Meals"
        lblWaterSection.Text = "Water Intake"
        lblExerciseSection.Text = "Exercise"

        ConfigureSectionLabel(lblMealSection, New Point(24, 76))
        ConfigureSectionLabel(lblWaterSection, New Point(24, 272))
        ConfigureSectionLabel(lblExerciseSection, New Point(24, 458))

        ConfigureLabel(Label1, "Meal name", New Point(24, 112))
        ConfigureLabel(Label2, "Calories", New Point(24, 148))
        ConfigureLabel(Label4, "Water (ml)", New Point(24, 308))
        ConfigureLabel(Label6, "Exercise", New Point(24, 494))
        ConfigureLabel(Label7, "Calories burned", New Point(24, 530))

        ConfigureTextBox(txtMeal, New Point(142, 108), 180)
        ConfigureTextBox(txtCalories, New Point(142, 144), 180)
        ConfigureTextBox(txtWater, New Point(142, 304), 180)
        ConfigureTextBox(txtExercise, New Point(142, 490), 180)
        ConfigureTextBox(txtCaloriesBurned, New Point(142, 526), 180)

        ConfigureButton(btnAddMeal, "Add Meal", New Point(142, 180), 180)
        ConfigureButton(btnAddWater, "Add Water", New Point(142, 340), 180)
        ConfigureButton(btnAddExercise, "Add Exercise", New Point(142, 562), 180)

        ConfigureSummaryLabel(lblTotalCalories, New Point(360, 82))
        ConfigureSummaryLabel(lblTotalWater, New Point(360, 278))
        ConfigureSummaryLabel(lblTotalBurned, New Point(360, 464))
        ConfigureSummaryLabel(lblNetCalories, New Point(360, 624))

        ConfigureGrid(rgvMeal, New Point(360, 112), New Size(350, 142))
        ConfigureGrid(rgvWater, New Point(360, 308), New Size(350, 120))
        ConfigureGrid(rgvExercise, New Point(360, 494), New Size(350, 120))

        lblDailyHistoryTitle.Text = "Daily Calorie Totals - Past to Present"
        lblDailyHistoryTitle.Font = New Font("Segoe UI Semibold", 13.0!, FontStyle.Bold)
        lblDailyHistoryTitle.ForeColor = Color.FromArgb(31, 41, 55)
        lblDailyHistoryTitle.AutoSize = True
        lblDailyHistoryTitle.Location = New Point(750, 82)

        ConfigureDailyTotalsChart()

        If Not Me.Controls.Contains(lblMealSection) Then Me.Controls.Add(lblMealSection)
        If Not Me.Controls.Contains(lblWaterSection) Then Me.Controls.Add(lblWaterSection)
        If Not Me.Controls.Contains(lblExerciseSection) Then Me.Controls.Add(lblExerciseSection)
        If Not Me.Controls.Contains(lblNetCalories) Then Me.Controls.Add(lblNetCalories)
        If Not Me.Controls.Contains(lblDailyHistoryTitle) Then Me.Controls.Add(lblDailyHistoryTitle)
        If Not Me.Controls.Contains(dailyTotalsChart) Then Me.Controls.Add(dailyTotalsChart)

        dailyTotalsChart.BringToFront()
        lblDailyHistoryTitle.BringToFront()
    End Sub

    Private Sub ConfigureSectionLabel(label As Label, location As Point)
        label.Font = New Font("Segoe UI Semibold", 12.0!, FontStyle.Bold)
        label.ForeColor = Color.FromArgb(37, 99, 235)
        label.AutoSize = True
        label.Location = location
    End Sub

    Private Sub ConfigureLabel(label As Label, text As String, location As Point)
        label.Text = text
        label.Font = New Font("Segoe UI", 9.5!, FontStyle.Regular)
        label.ForeColor = Color.FromArgb(75, 85, 99)
        label.AutoSize = True
        label.Location = location
    End Sub

    Private Sub ConfigureTextBox(textBox As TextBox, location As Point, width As Integer)
        textBox.Location = location
        textBox.Size = New Size(width, 26)
        textBox.Font = New Font("Segoe UI", 9.5!, FontStyle.Regular)
        textBox.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub ConfigureButton(button As Button, text As String, location As Point, width As Integer)
        button.Text = text
        button.Location = location
        button.Size = New Size(width, 32)
        button.FlatStyle = FlatStyle.Flat
        button.FlatAppearance.BorderSize = 0
        button.BackColor = Color.FromArgb(37, 99, 235)
        button.ForeColor = Color.White
        button.Font = New Font("Segoe UI Semibold", 9.5!, FontStyle.Bold)
        button.Cursor = Cursors.Hand
    End Sub

    Private Sub ConfigureSummaryLabel(label As Label, location As Point)
        label.Location = location
        label.AutoSize = True
        label.Font = New Font("Segoe UI Semibold", 10.5!, FontStyle.Bold)
        label.ForeColor = Color.FromArgb(17, 24, 39)
        label.BackColor = Color.Transparent
    End Sub

    Private Sub ConfigureGrid(grid As RadGridView, location As Point, size As Size)
        grid.Location = location
        grid.Size = size
        grid.Font = New Font("Segoe UI", 9.0!, FontStyle.Regular)
        grid.BackColor = Color.White
        grid.ForeColor = Color.FromArgb(31, 41, 55)
        grid.ShowGroupPanel = False
        grid.MasterTemplate.EnableGrouping = False
        grid.MasterTemplate.AllowAddNewRow = False
        grid.MasterTemplate.AllowEditRow = False
        grid.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub ConfigureDailyTotalsChart()
        dailyTotalsChart.Location = New Point(750, 112)
        dailyTotalsChart.Size = New Size(390, 502)
        dailyTotalsChart.BackColor = Color.White
        dailyTotalsChart.BorderlineColor = Color.FromArgb(229, 231, 235)
        dailyTotalsChart.BorderlineDashStyle = ChartDashStyle.Solid
        dailyTotalsChart.BorderlineWidth = 1
        dailyTotalsChart.ChartAreas.Clear()
        dailyTotalsChart.Series.Clear()
        dailyTotalsChart.Legends.Clear()

        Dim chartArea As New ChartArea("DailyTotalsArea")
        chartArea.BackColor = Color.White
        chartArea.AxisX.Title = "Date"
        chartArea.AxisX.LabelStyle.Format = "MM/dd"
        chartArea.AxisX.MajorGrid.LineColor = Color.FromArgb(229, 231, 235)
        chartArea.AxisX.IntervalAutoMode = IntervalAutoMode.VariableCount
        chartArea.AxisY.Title = "Calories"
        chartArea.AxisY.MajorGrid.LineColor = Color.FromArgb(229, 231, 235)
        dailyTotalsChart.ChartAreas.Add(chartArea)

        Dim legend As New Legend("DailyTotalsLegend")
        legend.Docking = Docking.Top
        legend.Alignment = StringAlignment.Center
        dailyTotalsChart.Legends.Add(legend)

        AddLineSeries("Calories In")
        AddLineSeries("Calories Burned")
        AddLineSeries("Net Calories")
    End Sub

    Private Sub AddLineSeries(seriesName As String)
        Dim series As New Series(seriesName)
        series.ChartType = SeriesChartType.Line
        series.BorderWidth = 3
        series.MarkerStyle = MarkerStyle.Circle
        series.MarkerSize = 7
        series.XValueType = ChartValueType.DateTime
        series.ChartArea = "DailyTotalsArea"
        series.Legend = "DailyTotalsLegend"
        dailyTotalsChart.Series.Add(series)
    End Sub

    Private Sub LoadCalorieTracker()
        totalCalories = 0
        totalWater = 0
        totalBurned = 0

        LoadMeals()
        LoadWater()
        LoadExercises()
        RefreshTodaySummary()
        LoadDailyTotalsChart()
    End Sub

    Private Sub LoadMeals()
        rgvMeal.Rows.Clear()
        Dim dtMeal As DataTable = FoodEntry.GetForDay(userId, Date.Today)
        If dtMeal Is Nothing Then Return

        For Each row As DataRow In dtMeal.Rows
            Dim mealId As Integer = Convert.ToInt32(row.Item("Id"))
            Dim meal As String = Convert.ToString(row.Item("MealName"))
            Dim calories As Integer = Convert.ToInt32(row.Item("Calories"))
            rgvMeal.Rows.Add(mealId, userId, meal, calories)
            totalCalories += calories
        Next
    End Sub

    Private Sub LoadWater()
        rgvWater.Rows.Clear()
        Dim dtWater As DataTable = DailyLog.GetWaterForDay(userId, Date.Today)
        If dtWater Is Nothing Then Return

        For Each row As DataRow In dtWater.Rows
            Dim waterId As Integer = Convert.ToInt32(row.Item("Id"))
            Dim water As Integer = Convert.ToInt32(row.Item("AmountMl"))
            rgvWater.Rows.Add(waterId, userId, water)
            totalWater += water
        Next
    End Sub

    Private Sub LoadExercises()
        rgvExercise.Rows.Clear()
        Dim dtExercise As DataTable = ExerciseEntry.GetForDay(userId, Date.Today)
        If dtExercise Is Nothing Then Return

        For Each row As DataRow In dtExercise.Rows
            Dim exerciseId As Integer = Convert.ToInt32(row.Item("Id"))
            Dim exercise As String = Convert.ToString(row.Item("Exercise"))
            Dim burned As Integer = Convert.ToInt32(row.Item("Calories Burned"))
            rgvExercise.Rows.Add(exerciseId, userId, exercise, burned)
            totalBurned += burned
        Next
    End Sub

    Private Sub RefreshTodaySummary()
        Dim netCalories As Integer = totalCalories - totalBurned
        lblTotalCalories.Text = "Today's Calories In: " & totalCalories.ToString("N0") & " kcal"
        lblTotalWater.Text = "Today's Water: " & totalWater.ToString("N0") & " ml"
        lblTotalBurned.Text = "Today's Calories Burned: " & totalBurned.ToString("N0") & " kcal"
        lblNetCalories.Text = "Today's Net Calories: " & netCalories.ToString("N0") & " kcal"
    End Sub

    Private Sub LoadDailyTotalsChart()
        For Each series As Series In dailyTotalsChart.Series
            series.Points.Clear()
        Next

        Dim dtTotals As DataTable = DailyLog.GetDailyTotals(userId)
        If dtTotals Is Nothing Then Return

        For Each row As DataRow In dtTotals.Rows
            Dim logDate As Date = Convert.ToDateTime(row.Item("LogDate"))
            Dim caloriesIn As Integer = Convert.ToInt32(row.Item("CaloriesIn"))
            Dim caloriesBurned As Integer = Convert.ToInt32(row.Item("CaloriesBurned"))
            Dim netCalories As Integer = Convert.ToInt32(row.Item("NetCalories"))

            dailyTotalsChart.Series("Calories In").Points.AddXY(logDate, caloriesIn)
            dailyTotalsChart.Series("Calories Burned").Points.AddXY(logDate, caloriesBurned)
            dailyTotalsChart.Series("Net Calories").Points.AddXY(logDate, netCalories)
        Next

        If dtTotals.Rows.Count = 1 Then
            dailyTotalsChart.ChartAreas("DailyTotalsArea").AxisX.Interval = 1
        End If
    End Sub

    ' ===== MEAL ENTRY =====
    Private Sub btnAddMeal_Click(sender As Object, e As EventArgs) Handles btnAddMeal.Click
        Dim meal As String = txtMeal.Text.Trim()
        Dim calories As Integer

        If FoodEntry.IsValid(meal, txtCalories.Text, calories) Then
            FoodEntry.Add(userId, meal, calories)
            txtMeal.Clear()
            txtCalories.Clear()
            LoadCalorieTracker()
        Else
            MessageBox.Show("Enter a valid meal name and calorie value.", "Invalid Meal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' ===== WATER INTAKE =====
    Private Sub btnAddWater_Click(sender As Object, e As EventArgs) Handles btnAddWater.Click
        Dim water As Integer

        If Integer.TryParse(txtWater.Text.Trim(), water) AndAlso water >= 0 Then
            DailyLog.AddWater(userId, water)
            txtWater.Clear()
            LoadCalorieTracker()
        Else
            MessageBox.Show("Enter a valid water amount in ml.", "Invalid Water Intake", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' ===== EXERCISE ENTRY =====
    Private Sub btnAddExercise_Click(sender As Object, e As EventArgs) Handles btnAddExercise.Click
        Dim exercise As String = txtExercise.Text.Trim()
        Dim burned As Integer

        If ExerciseEntry.IsValid(exercise, txtCaloriesBurned.Text, burned) Then
            ExerciseEntry.Add(userId, exercise, burned)
            txtExercise.Clear()
            txtCaloriesBurned.Clear()
            LoadCalorieTracker()
        Else
            MessageBox.Show("Enter a valid exercise and calories burned.", "Invalid Exercise", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub Calorie_Tracker_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        LoginForm.Close()
    End Sub

    Private Sub rgvExercise_UserDeletingRow(sender As Object, e As GridViewRowCancelEventArgs) Handles rgvExercise.UserDeletingRow
        Dim exerciseId As Integer = Convert.ToInt32(e.Rows(0).Cells(0).Value)
        Dim exerciseUserId As Integer = Convert.ToInt32(e.Rows(0).Cells(1).Value)
        ExerciseEntry.Delete(exerciseUserId, exerciseId)
        LoadCalorieTracker()
    End Sub

    Private Sub rgvMeal_UserDeletingRow(sender As Object, e As GridViewRowCancelEventArgs) Handles rgvMeal.UserDeletingRow
        Dim mealId As Integer = Convert.ToInt32(e.Rows(0).Cells(0).Value)
        Dim mealUserId As Integer = Convert.ToInt32(e.Rows(0).Cells(1).Value)
        FoodEntry.Delete(mealUserId, mealId)
        LoadCalorieTracker()
    End Sub

    Private Sub rgvWater_UserDeletingRow(sender As Object, e As GridViewRowCancelEventArgs) Handles rgvWater.UserDeletingRow
        Dim waterId As Integer = Convert.ToInt32(e.Rows(0).Cells(0).Value)
        Dim waterUserId As Integer = Convert.ToInt32(e.Rows(0).Cells(1).Value)
        DailyLog.DeleteWater(waterUserId, waterId)
        LoadCalorieTracker()
    End Sub
End Class


