<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Task_Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Task_Form))
        Me.GroupBoxProj = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DateTimePicker5 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker4 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTask1 = New System.Windows.Forms.TextBox()
        Me.txtTask1_Owner = New System.Windows.Forms.TextBox()
        Me.txtTask2 = New System.Windows.Forms.TextBox()
        Me.txtTask2_Owner = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTask3 = New System.Windows.Forms.TextBox()
        Me.txtTask5_Owner = New System.Windows.Forms.TextBox()
        Me.txtTask3_Owner = New System.Windows.Forms.TextBox()
        Me.txtTask5 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTask4_Owner = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTask4 = New System.Windows.Forms.TextBox()
        Me.btnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.GroupBoxProj.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxProj
        '
        Me.GroupBoxProj.AutoScroll = True
        Me.GroupBoxProj.BorderColor = System.Drawing.Color.Black
        Me.GroupBoxProj.BorderRadius = 10
        Me.GroupBoxProj.Controls.Add(Me.Panel1)
        Me.GroupBoxProj.Controls.Add(Me.btnClose)
        Me.GroupBoxProj.Controls.Add(Me.btnSave)
        Me.GroupBoxProj.CustomBorderColor = System.Drawing.Color.SeaGreen
        Me.GroupBoxProj.CustomBorderThickness = New System.Windows.Forms.Padding(3, 40, 3, 3)
        Me.GroupBoxProj.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBoxProj.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxProj.ForeColor = System.Drawing.Color.White
        Me.GroupBoxProj.Location = New System.Drawing.Point(0, 0)
        Me.GroupBoxProj.Name = "GroupBoxProj"
        Me.GroupBoxProj.Size = New System.Drawing.Size(1170, 807)
        Me.GroupBoxProj.TabIndex = 2
        Me.GroupBoxProj.Text = "Project Title"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DateTimePicker5)
        Me.Panel1.Controls.Add(Me.DateTimePicker4)
        Me.Panel1.Controls.Add(Me.DateTimePicker3)
        Me.Panel1.Controls.Add(Me.DateTimePicker2)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.txtTask1)
        Me.Panel1.Controls.Add(Me.txtTask1_Owner)
        Me.Panel1.Controls.Add(Me.txtTask2)
        Me.Panel1.Controls.Add(Me.txtTask2_Owner)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtTask3)
        Me.Panel1.Controls.Add(Me.txtTask5_Owner)
        Me.Panel1.Controls.Add(Me.txtTask3_Owner)
        Me.Panel1.Controls.Add(Me.txtTask5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtTask4_Owner)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtTask4)
        Me.Panel1.Location = New System.Drawing.Point(100, 84)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(967, 583)
        Me.Panel1.TabIndex = 37
        '
        'DateTimePicker5
        '
        Me.DateTimePicker5.Enabled = False
        Me.DateTimePicker5.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker5.Location = New System.Drawing.Point(764, 489)
        Me.DateTimePicker5.Name = "DateTimePicker5"
        Me.DateTimePicker5.Size = New System.Drawing.Size(161, 29)
        Me.DateTimePicker5.TabIndex = 43
        Me.DateTimePicker5.Value = New Date(2024, 7, 16, 13, 44, 33, 0)
        '
        'DateTimePicker4
        '
        Me.DateTimePicker4.Enabled = False
        Me.DateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker4.Location = New System.Drawing.Point(764, 393)
        Me.DateTimePicker4.Name = "DateTimePicker4"
        Me.DateTimePicker4.Size = New System.Drawing.Size(161, 29)
        Me.DateTimePicker4.TabIndex = 42
        Me.DateTimePicker4.Value = New Date(2024, 7, 16, 13, 44, 33, 0)
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.Enabled = False
        Me.DateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker3.Location = New System.Drawing.Point(764, 288)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(161, 29)
        Me.DateTimePicker3.TabIndex = 41
        Me.DateTimePicker3.Value = New Date(2024, 7, 16, 13, 44, 33, 0)
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Enabled = False
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(764, 190)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(161, 29)
        Me.DateTimePicker2.TabIndex = 40
        Me.DateTimePicker2.Value = New Date(2024, 7, 16, 13, 44, 33, 0)
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(764, 91)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(161, 29)
        Me.DateTimePicker1.TabIndex = 39
        Me.DateTimePicker1.Value = New Date(2024, 7, 16, 13, 44, 33, 0)
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(967, 49)
        Me.Panel2.TabIndex = 38
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(783, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(103, 30)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Due Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(27, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 30)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Item"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(608, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 30)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Owner"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(274, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 30)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Task"
        '
        'txtTask1
        '
        Me.txtTask1.BackColor = System.Drawing.SystemColors.Window
        Me.txtTask1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTask1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTask1.Location = New System.Drawing.Point(112, 68)
        Me.txtTask1.Multiline = True
        Me.txtTask1.Name = "txtTask1"
        Me.txtTask1.ReadOnly = True
        Me.txtTask1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtTask1.Size = New System.Drawing.Size(426, 75)
        Me.txtTask1.TabIndex = 3
        '
        'txtTask1_Owner
        '
        Me.txtTask1_Owner.BackColor = System.Drawing.SystemColors.Window
        Me.txtTask1_Owner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTask1_Owner.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTask1_Owner.Location = New System.Drawing.Point(579, 91)
        Me.txtTask1_Owner.Name = "txtTask1_Owner"
        Me.txtTask1_Owner.ReadOnly = True
        Me.txtTask1_Owner.Size = New System.Drawing.Size(137, 29)
        Me.txtTask1_Owner.TabIndex = 6
        Me.txtTask1_Owner.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTask2
        '
        Me.txtTask2.BackColor = System.Drawing.SystemColors.Window
        Me.txtTask2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTask2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTask2.Location = New System.Drawing.Point(112, 167)
        Me.txtTask2.Multiline = True
        Me.txtTask2.Name = "txtTask2"
        Me.txtTask2.ReadOnly = True
        Me.txtTask2.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtTask2.Size = New System.Drawing.Size(426, 75)
        Me.txtTask2.TabIndex = 17
        '
        'txtTask2_Owner
        '
        Me.txtTask2_Owner.BackColor = System.Drawing.SystemColors.Window
        Me.txtTask2_Owner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTask2_Owner.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTask2_Owner.Location = New System.Drawing.Point(579, 190)
        Me.txtTask2_Owner.Name = "txtTask2_Owner"
        Me.txtTask2_Owner.ReadOnly = True
        Me.txtTask2_Owner.Size = New System.Drawing.Size(137, 29)
        Me.txtTask2_Owner.TabIndex = 18
        Me.txtTask2_Owner.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(31, 478)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 37)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "5."
        '
        'txtTask3
        '
        Me.txtTask3.BackColor = System.Drawing.SystemColors.Window
        Me.txtTask3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTask3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTask3.Location = New System.Drawing.Point(112, 268)
        Me.txtTask3.Multiline = True
        Me.txtTask3.Name = "txtTask3"
        Me.txtTask3.ReadOnly = True
        Me.txtTask3.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtTask3.Size = New System.Drawing.Size(426, 75)
        Me.txtTask3.TabIndex = 19
        '
        'txtTask5_Owner
        '
        Me.txtTask5_Owner.BackColor = System.Drawing.SystemColors.Window
        Me.txtTask5_Owner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTask5_Owner.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTask5_Owner.Location = New System.Drawing.Point(579, 489)
        Me.txtTask5_Owner.Name = "txtTask5_Owner"
        Me.txtTask5_Owner.ReadOnly = True
        Me.txtTask5_Owner.Size = New System.Drawing.Size(137, 29)
        Me.txtTask5_Owner.TabIndex = 29
        Me.txtTask5_Owner.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTask3_Owner
        '
        Me.txtTask3_Owner.BackColor = System.Drawing.SystemColors.Window
        Me.txtTask3_Owner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTask3_Owner.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTask3_Owner.Location = New System.Drawing.Point(579, 291)
        Me.txtTask3_Owner.Name = "txtTask3_Owner"
        Me.txtTask3_Owner.ReadOnly = True
        Me.txtTask3_Owner.Size = New System.Drawing.Size(137, 29)
        Me.txtTask3_Owner.TabIndex = 20
        Me.txtTask3_Owner.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTask5
        '
        Me.txtTask5.BackColor = System.Drawing.SystemColors.Window
        Me.txtTask5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTask5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTask5.Location = New System.Drawing.Point(112, 466)
        Me.txtTask5.Multiline = True
        Me.txtTask5.Name = "txtTask5"
        Me.txtTask5.ReadOnly = True
        Me.txtTask5.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtTask5.Size = New System.Drawing.Size(426, 75)
        Me.txtTask5.TabIndex = 28
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(31, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 37)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "1."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(31, 382)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 37)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "4."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(31, 179)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 37)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "2."
        '
        'txtTask4_Owner
        '
        Me.txtTask4_Owner.BackColor = System.Drawing.SystemColors.Window
        Me.txtTask4_Owner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTask4_Owner.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTask4_Owner.Location = New System.Drawing.Point(579, 393)
        Me.txtTask4_Owner.Name = "txtTask4_Owner"
        Me.txtTask4_Owner.ReadOnly = True
        Me.txtTask4_Owner.Size = New System.Drawing.Size(137, 29)
        Me.txtTask4_Owner.TabIndex = 26
        Me.txtTask4_Owner.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(31, 280)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 37)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "3."
        '
        'txtTask4
        '
        Me.txtTask4.BackColor = System.Drawing.SystemColors.Window
        Me.txtTask4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTask4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTask4.Location = New System.Drawing.Point(112, 370)
        Me.txtTask4.Multiline = True
        Me.txtTask4.Name = "txtTask4"
        Me.txtTask4.ReadOnly = True
        Me.txtTask4.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtTask4.Size = New System.Drawing.Size(426, 75)
        Me.txtTask4.TabIndex = 25
        '
        'btnClose
        '
        Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.BorderRadius = 10
        Me.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnClose.FillColor = System.Drawing.Color.Transparent
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.HoverState.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageOffset = New System.Drawing.Point(1, 0)
        Me.btnClose.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnClose.Location = New System.Drawing.Point(1120, 5)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(26, 28)
        Me.btnClose.TabIndex = 16
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnSave.BackColor = System.Drawing.Color.Transparent
        Me.btnSave.BorderRadius = 10
        Me.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(503, 703)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(140, 45)
        Me.btnSave.TabIndex = 15
        Me.btnSave.Text = "Save changes"
        Me.btnSave.Visible = False
        '
        'Task_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1170, 807)
        Me.Controls.Add(Me.GroupBoxProj)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Task_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Task_Form"
        Me.GroupBoxProj.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBoxProj As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents txtTask1 As TextBox
    Friend WithEvents txtTask1_Owner As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTask3_Owner As TextBox
    Friend WithEvents txtTask3 As TextBox
    Friend WithEvents txtTask2_Owner As TextBox
    Friend WithEvents txtTask2 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtTask5_Owner As TextBox
    Friend WithEvents txtTask5 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtTask4_Owner As TextBox
    Friend WithEvents txtTask4 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker5 As DateTimePicker
    Friend WithEvents DateTimePicker4 As DateTimePicker
    Friend WithEvents DateTimePicker3 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
End Class
