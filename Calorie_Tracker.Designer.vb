<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calorie_Tracker
    Inherits Telerik.WinControls.UI.RadForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim GridViewTextBoxColumn1 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn2 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn3 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim GridViewTextBoxColumn4 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn5 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn6 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn7 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim TableViewDefinition2 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim GridViewTextBoxColumn8 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn9 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn10 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn11 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim SortDescriptor1 As Telerik.WinControls.Data.SortDescriptor = New Telerik.WinControls.Data.SortDescriptor()
        Dim TableViewDefinition3 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Calorie_Tracker))
        Me.rlabTitle = New Telerik.WinControls.UI.RadLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTotalCalories = New System.Windows.Forms.Label()
        Me.txtMeal = New System.Windows.Forms.TextBox()
        Me.txtCalories = New System.Windows.Forms.TextBox()
        Me.btnAddMeal = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblTotalWater = New System.Windows.Forms.Label()
        Me.btnAddWater = New System.Windows.Forms.Button()
        Me.txtWater = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblTotalBurned = New System.Windows.Forms.Label()
        Me.btnAddExercise = New System.Windows.Forms.Button()
        Me.txtExercise = New System.Windows.Forms.TextBox()
        Me.txtCaloriesBurned = New System.Windows.Forms.TextBox()
        Me.rgvWater = New Telerik.WinControls.UI.RadGridView()
        Me.rgvExercise = New Telerik.WinControls.UI.RadGridView()
        Me.rgvMeal = New Telerik.WinControls.UI.RadGridView()
        CType(Me.rlabTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvWater, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvWater.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvExercise, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvExercise.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvMeal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvMeal.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rlabTitle
        '
        Me.rlabTitle.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rlabTitle.Location = New System.Drawing.Point(190, 12)
        Me.rlabTitle.Name = "rlabTitle"
        Me.rlabTitle.Size = New System.Drawing.Size(184, 30)
        Me.rlabTitle.TabIndex = 0
        Me.rlabTitle.Text = "Daily Fitness Tracker"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Meal Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Calories:"
        '
        'lblTotalCalories
        '
        Me.lblTotalCalories.AutoSize = True
        Me.lblTotalCalories.Location = New System.Drawing.Point(317, 192)
        Me.lblTotalCalories.Name = "lblTotalCalories"
        Me.lblTotalCalories.Size = New System.Drawing.Size(116, 17)
        Me.lblTotalCalories.TabIndex = 3
        Me.lblTotalCalories.Text = "Total Calories: kcal"
        '
        'txtMeal
        '
        Me.txtMeal.Location = New System.Drawing.Point(131, 81)
        Me.txtMeal.Name = "txtMeal"
        Me.txtMeal.Size = New System.Drawing.Size(100, 20)
        Me.txtMeal.TabIndex = 4
        '
        'txtCalories
        '
        Me.txtCalories.Location = New System.Drawing.Point(131, 117)
        Me.txtCalories.Name = "txtCalories"
        Me.txtCalories.Size = New System.Drawing.Size(100, 20)
        Me.txtCalories.TabIndex = 5
        '
        'btnAddMeal
        '
        Me.btnAddMeal.Location = New System.Drawing.Point(131, 154)
        Me.btnAddMeal.Name = "btnAddMeal"
        Me.btnAddMeal.Size = New System.Drawing.Size(98, 23)
        Me.btnAddMeal.TabIndex = 7
        Me.btnAddMeal.Text = "Add Meal"
        Me.btnAddMeal.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 279)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Water Intake (ml)"
        '
        'lblTotalWater
        '
        Me.lblTotalWater.AutoSize = True
        Me.lblTotalWater.Location = New System.Drawing.Point(323, 390)
        Me.lblTotalWater.Name = "lblTotalWater"
        Me.lblTotalWater.Size = New System.Drawing.Size(110, 17)
        Me.lblTotalWater.TabIndex = 10
        Me.lblTotalWater.Text = "Total Water : 0 ml"
        '
        'btnAddWater
        '
        Me.btnAddWater.Location = New System.Drawing.Point(135, 324)
        Me.btnAddWater.Name = "btnAddWater"
        Me.btnAddWater.Size = New System.Drawing.Size(97, 23)
        Me.btnAddWater.TabIndex = 11
        Me.btnAddWater.Text = "Add Water"
        Me.btnAddWater.UseVisualStyleBackColor = True
        '
        'txtWater
        '
        Me.txtWater.Location = New System.Drawing.Point(132, 279)
        Me.txtWater.Name = "txtWater"
        Me.txtWater.Size = New System.Drawing.Size(100, 20)
        Me.txtWater.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(65, 468)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 17)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Exercise"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 503)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 17)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Calories Burned"
        '
        'lblTotalBurned
        '
        Me.lblTotalBurned.AutoSize = True
        Me.lblTotalBurned.Location = New System.Drawing.Point(308, 579)
        Me.lblTotalBurned.Name = "lblTotalBurned"
        Me.lblTotalBurned.Size = New System.Drawing.Size(125, 17)
        Me.lblTotalBurned.TabIndex = 18
        Me.lblTotalBurned.Text = "Total Burned : 0 kcal"
        '
        'btnAddExercise
        '
        Me.btnAddExercise.Location = New System.Drawing.Point(116, 550)
        Me.btnAddExercise.Name = "btnAddExercise"
        Me.btnAddExercise.Size = New System.Drawing.Size(127, 23)
        Me.btnAddExercise.TabIndex = 19
        Me.btnAddExercise.Text = "Add Exercise"
        Me.btnAddExercise.UseVisualStyleBackColor = True
        '
        'txtExercise
        '
        Me.txtExercise.Location = New System.Drawing.Point(132, 465)
        Me.txtExercise.Name = "txtExercise"
        Me.txtExercise.Size = New System.Drawing.Size(100, 20)
        Me.txtExercise.TabIndex = 20
        '
        'txtCaloriesBurned
        '
        Me.txtCaloriesBurned.Location = New System.Drawing.Point(132, 503)
        Me.txtCaloriesBurned.Name = "txtCaloriesBurned"
        Me.txtCaloriesBurned.Size = New System.Drawing.Size(100, 20)
        Me.txtCaloriesBurned.TabIndex = 21
        '
        'rgvWater
        '
        Me.rgvWater.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.rgvWater.Cursor = System.Windows.Forms.Cursors.Default
        Me.rgvWater.EnableGestures = False
        Me.rgvWater.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.rgvWater.ForeColor = System.Drawing.Color.Black
        Me.rgvWater.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rgvWater.Location = New System.Drawing.Point(276, 257)
        '
        '
        '
        Me.rgvWater.MasterTemplate.AllowAddNewRow = False
        Me.rgvWater.MasterTemplate.AllowColumnReorder = False
        Me.rgvWater.MasterTemplate.AllowColumnResize = False
        Me.rgvWater.MasterTemplate.AllowEditRow = False
        Me.rgvWater.MasterTemplate.AllowRowResize = False
        Me.rgvWater.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
        GridViewTextBoxColumn1.EnableExpressionEditor = False
        GridViewTextBoxColumn1.HeaderText = "Id"
        GridViewTextBoxColumn1.IsVisible = False
        GridViewTextBoxColumn1.Name = "colId"
        GridViewTextBoxColumn1.VisibleInColumnChooser = False
        GridViewTextBoxColumn1.Width = 47
        GridViewTextBoxColumn2.EnableExpressionEditor = False
        GridViewTextBoxColumn2.HeaderText = "UserId"
        GridViewTextBoxColumn2.IsVisible = False
        GridViewTextBoxColumn2.Name = "colUserId"
        GridViewTextBoxColumn2.VisibleInColumnChooser = False
        GridViewTextBoxColumn2.Width = 46
        GridViewTextBoxColumn3.EnableExpressionEditor = False
        GridViewTextBoxColumn3.HeaderText = "Amount"
        GridViewTextBoxColumn3.Name = "colWater"
        GridViewTextBoxColumn3.Width = 245
        Me.rgvWater.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn1, GridViewTextBoxColumn2, GridViewTextBoxColumn3})
        Me.rgvWater.MasterTemplate.EnableGrouping = False
        Me.rgvWater.MasterTemplate.EnableSorting = False
        Me.rgvWater.MasterTemplate.ShowFilteringRow = False
        Me.rgvWater.MasterTemplate.ShowRowHeaderColumn = False
        Me.rgvWater.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.rgvWater.Name = "rgvWater"
        Me.rgvWater.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rgvWater.ShowGroupPanel = False
        Me.rgvWater.Size = New System.Drawing.Size(247, 130)
        Me.rgvWater.TabIndex = 26
        '
        'rgvExercise
        '
        Me.rgvExercise.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.rgvExercise.Cursor = System.Windows.Forms.Cursors.Default
        Me.rgvExercise.EnableGestures = False
        Me.rgvExercise.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.rgvExercise.ForeColor = System.Drawing.Color.Black
        Me.rgvExercise.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rgvExercise.Location = New System.Drawing.Point(276, 446)
        '
        '
        '
        Me.rgvExercise.MasterTemplate.AllowAddNewRow = False
        Me.rgvExercise.MasterTemplate.AllowColumnReorder = False
        Me.rgvExercise.MasterTemplate.AllowColumnResize = False
        Me.rgvExercise.MasterTemplate.AllowEditRow = False
        Me.rgvExercise.MasterTemplate.AllowRowResize = False
        Me.rgvExercise.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
        GridViewTextBoxColumn4.EnableExpressionEditor = False
        GridViewTextBoxColumn4.HeaderText = "Id"
        GridViewTextBoxColumn4.IsVisible = False
        GridViewTextBoxColumn4.Name = "colId"
        GridViewTextBoxColumn4.VisibleInColumnChooser = False
        GridViewTextBoxColumn4.Width = 46
        GridViewTextBoxColumn5.EnableExpressionEditor = False
        GridViewTextBoxColumn5.HeaderText = "UserId"
        GridViewTextBoxColumn5.IsVisible = False
        GridViewTextBoxColumn5.Name = "colUserId"
        GridViewTextBoxColumn5.VisibleInColumnChooser = False
        GridViewTextBoxColumn5.Width = 46
        GridViewTextBoxColumn6.EnableExpressionEditor = False
        GridViewTextBoxColumn6.HeaderText = "Exercise"
        GridViewTextBoxColumn6.Name = "colExercise"
        GridViewTextBoxColumn6.Width = 136
        GridViewTextBoxColumn7.EnableExpressionEditor = False
        GridViewTextBoxColumn7.HeaderText = "Calories Burned"
        GridViewTextBoxColumn7.Name = "colCaloriesBurned"
        GridViewTextBoxColumn7.Width = 109
        Me.rgvExercise.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn4, GridViewTextBoxColumn5, GridViewTextBoxColumn6, GridViewTextBoxColumn7})
        Me.rgvExercise.MasterTemplate.EnableGrouping = False
        Me.rgvExercise.MasterTemplate.EnableSorting = False
        Me.rgvExercise.MasterTemplate.ShowFilteringRow = False
        Me.rgvExercise.MasterTemplate.ShowRowHeaderColumn = False
        Me.rgvExercise.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.rgvExercise.Name = "rgvExercise"
        Me.rgvExercise.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rgvExercise.ShowGroupPanel = False
        Me.rgvExercise.Size = New System.Drawing.Size(247, 130)
        Me.rgvExercise.TabIndex = 27
        '
        'rgvMeal
        '
        Me.rgvMeal.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.rgvMeal.Cursor = System.Windows.Forms.Cursors.Default
        Me.rgvMeal.EnableGestures = False
        Me.rgvMeal.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.rgvMeal.ForeColor = System.Drawing.Color.Black
        Me.rgvMeal.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rgvMeal.Location = New System.Drawing.Point(276, 59)
        '
        '
        '
        Me.rgvMeal.MasterTemplate.AllowAddNewRow = False
        Me.rgvMeal.MasterTemplate.AllowColumnReorder = False
        Me.rgvMeal.MasterTemplate.AllowColumnResize = False
        Me.rgvMeal.MasterTemplate.AllowEditRow = False
        Me.rgvMeal.MasterTemplate.AllowRowResize = False
        Me.rgvMeal.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
        GridViewTextBoxColumn8.EnableExpressionEditor = False
        GridViewTextBoxColumn8.HeaderText = "ID"
        GridViewTextBoxColumn8.IsVisible = False
        GridViewTextBoxColumn8.Name = "colID"
        GridViewTextBoxColumn8.VisibleInColumnChooser = False
        GridViewTextBoxColumn8.Width = 46
        GridViewTextBoxColumn9.EnableExpressionEditor = False
        GridViewTextBoxColumn9.HeaderText = "UserId"
        GridViewTextBoxColumn9.IsVisible = False
        GridViewTextBoxColumn9.Name = "colUserId"
        GridViewTextBoxColumn9.VisibleInColumnChooser = False
        GridViewTextBoxColumn9.Width = 46
        GridViewTextBoxColumn10.EnableExpressionEditor = False
        GridViewTextBoxColumn10.HeaderText = "Meal"
        GridViewTextBoxColumn10.Name = "colMeal"
        GridViewTextBoxColumn10.Width = 156
        GridViewTextBoxColumn11.EnableExpressionEditor = False
        GridViewTextBoxColumn11.HeaderText = "Calories"
        GridViewTextBoxColumn11.Name = "colCalories"
        GridViewTextBoxColumn11.Width = 89
        Me.rgvMeal.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn8, GridViewTextBoxColumn9, GridViewTextBoxColumn10, GridViewTextBoxColumn11})
        Me.rgvMeal.MasterTemplate.EnableGrouping = False
        Me.rgvMeal.MasterTemplate.EnableSorting = False
        Me.rgvMeal.MasterTemplate.ShowFilteringRow = False
        Me.rgvMeal.MasterTemplate.ShowRowHeaderColumn = False
        SortDescriptor1.PropertyName = "column1"
        Me.rgvMeal.MasterTemplate.SortDescriptors.AddRange(New Telerik.WinControls.Data.SortDescriptor() {SortDescriptor1})
        Me.rgvMeal.MasterTemplate.ViewDefinition = TableViewDefinition3
        Me.rgvMeal.Name = "rgvMeal"
        Me.rgvMeal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rgvMeal.ShowGroupPanel = False
        Me.rgvMeal.Size = New System.Drawing.Size(247, 130)
        Me.rgvMeal.TabIndex = 28
        '
        'Calorie_Tracker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(537, 613)
        Me.Controls.Add(Me.rgvMeal)
        Me.Controls.Add(Me.rgvExercise)
        Me.Controls.Add(Me.rgvWater)
        Me.Controls.Add(Me.txtCaloriesBurned)
        Me.Controls.Add(Me.txtExercise)
        Me.Controls.Add(Me.btnAddExercise)
        Me.Controls.Add(Me.lblTotalBurned)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtWater)
        Me.Controls.Add(Me.btnAddWater)
        Me.Controls.Add(Me.lblTotalWater)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnAddMeal)
        Me.Controls.Add(Me.txtCalories)
        Me.Controls.Add(Me.txtMeal)
        Me.Controls.Add(Me.lblTotalCalories)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rlabTitle)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Calorie_Tracker"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Daily Fitness Tracker"
        CType(Me.rlabTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvWater.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvWater, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvExercise.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvExercise, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvMeal.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvMeal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rlabTitle As Telerik.WinControls.UI.RadLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTotalCalories As Label
    Friend WithEvents txtMeal As TextBox
    Friend WithEvents txtCalories As TextBox
    Friend WithEvents btnAddMeal As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents lblTotalWater As Label
    Friend WithEvents btnAddWater As Button
    Friend WithEvents txtWater As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblTotalBurned As Label
    Friend WithEvents btnAddExercise As Button
    Friend WithEvents txtExercise As TextBox
    Friend WithEvents txtCaloriesBurned As TextBox
    Friend WithEvents rgvWater As Telerik.WinControls.UI.RadGridView
    Friend WithEvents rgvExercise As Telerik.WinControls.UI.RadGridView
    Friend WithEvents rgvMeal As Telerik.WinControls.UI.RadGridView
End Class
