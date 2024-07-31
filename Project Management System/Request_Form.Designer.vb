<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Request_Form
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
        Me.Guna2GroupBox2 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSend = New Guna.UI2.WinForms.Guna2Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btmBrowse = New Guna.UI2.WinForms.Guna2Button()
        Me.txtA3name = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDescription = New Guna.UI2.WinForms.Guna2TextBox()
        Me.dtpStartDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpCompletion = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.txtDept = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtProjTitle = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtMemEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtMember = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtManagerEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Guna2GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2GroupBox2
        '
        Me.Guna2GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Guna2GroupBox2.BorderColor = System.Drawing.Color.Black
        Me.Guna2GroupBox2.BorderRadius = 10
        Me.Guna2GroupBox2.Controls.Add(Me.btnCancel)
        Me.Guna2GroupBox2.Controls.Add(Me.btnSend)
        Me.Guna2GroupBox2.Controls.Add(Me.GroupBox3)
        Me.Guna2GroupBox2.Controls.Add(Me.GroupBox2)
        Me.Guna2GroupBox2.Controls.Add(Me.GroupBox1)
        Me.Guna2GroupBox2.CustomBorderColor = System.Drawing.Color.SeaGreen
        Me.Guna2GroupBox2.CustomBorderThickness = New System.Windows.Forms.Padding(3, 40, 3, 3)
        Me.Guna2GroupBox2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox2.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox2.Location = New System.Drawing.Point(52, 28)
        Me.Guna2GroupBox2.Name = "Guna2GroupBox2"
        Me.Guna2GroupBox2.Size = New System.Drawing.Size(1147, 785)
        Me.Guna2GroupBox2.TabIndex = 2
        Me.Guna2GroupBox2.Text = "Project Details"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.BorderRadius = 10
        Me.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(596, 716)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(140, 45)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "Cancel"
        '
        'btnSend
        '
        Me.btnSend.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnSend.BackColor = System.Drawing.Color.Transparent
        Me.btnSend.BorderRadius = 10
        Me.btnSend.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSend.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSend.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSend.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSend.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSend.ForeColor = System.Drawing.Color.White
        Me.btnSend.Location = New System.Drawing.Point(400, 716)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(140, 45)
        Me.btnSend.TabIndex = 0
        Me.btnSend.Text = "Send Request"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.MenuBar
        Me.GroupBox3.Controls.Add(Me.btmBrowse)
        Me.GroupBox3.Controls.Add(Me.txtA3name)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.txtDescription)
        Me.GroupBox3.Controls.Add(Me.dtpStartDate)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.dtpCompletion)
        Me.GroupBox3.Controls.Add(Me.txtDept)
        Me.GroupBox3.Controls.Add(Me.txtProjTitle)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Location = New System.Drawing.Point(596, 64)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(499, 630)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Other Details"
        '
        'btmBrowse
        '
        Me.btmBrowse.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btmBrowse.BackColor = System.Drawing.Color.Transparent
        Me.btmBrowse.BorderRadius = 5
        Me.btmBrowse.BorderThickness = 1
        Me.btmBrowse.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btmBrowse.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btmBrowse.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btmBrowse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btmBrowse.FillColor = System.Drawing.SystemColors.Control
        Me.btmBrowse.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btmBrowse.ForeColor = System.Drawing.Color.Black
        Me.btmBrowse.Location = New System.Drawing.Point(364, 534)
        Me.btmBrowse.Name = "btmBrowse"
        Me.btmBrowse.Size = New System.Drawing.Size(110, 35)
        Me.btmBrowse.TabIndex = 16
        Me.btmBrowse.Text = "Browse"
        '
        'txtA3name
        '
        Me.txtA3name.BackColor = System.Drawing.Color.Transparent
        Me.txtA3name.BorderColor = System.Drawing.Color.Black
        Me.txtA3name.BorderRadius = 20
        Me.txtA3name.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtA3name.DefaultText = ""
        Me.txtA3name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtA3name.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtA3name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtA3name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtA3name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtA3name.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtA3name.ForeColor = System.Drawing.Color.Black
        Me.txtA3name.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtA3name.Location = New System.Drawing.Point(44, 525)
        Me.txtA3name.Margin = New System.Windows.Forms.Padding(6)
        Me.txtA3name.Name = "txtA3name"
        Me.txtA3name.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtA3name.PlaceholderText = ""
        Me.txtA3name.ReadOnly = True
        Me.txtA3name.SelectedText = ""
        Me.txtA3name.ShadowDecoration.BorderRadius = 20
        Me.txtA3name.ShadowDecoration.Depth = 15
        Me.txtA3name.ShadowDecoration.Enabled = True
        Me.txtA3name.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 15, 15)
        Me.txtA3name.Size = New System.Drawing.Size(298, 44)
        Me.txtA3name.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(21, 498)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 21)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "A3 File"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(21, 151)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(150, 21)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Project Description"
        '
        'txtDescription
        '
        Me.txtDescription.BackColor = System.Drawing.Color.Transparent
        Me.txtDescription.BorderColor = System.Drawing.Color.Black
        Me.txtDescription.BorderRadius = 20
        Me.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDescription.DefaultText = ""
        Me.txtDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDescription.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtDescription.ForeColor = System.Drawing.Color.Black
        Me.txtDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDescription.Location = New System.Drawing.Point(44, 178)
        Me.txtDescription.Margin = New System.Windows.Forms.Padding(6)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescription.PlaceholderText = ""
        Me.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtDescription.SelectedText = ""
        Me.txtDescription.ShadowDecoration.BorderRadius = 20
        Me.txtDescription.ShadowDecoration.Depth = 15
        Me.txtDescription.ShadowDecoration.Enabled = True
        Me.txtDescription.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 15, 15)
        Me.txtDescription.Size = New System.Drawing.Size(419, 111)
        Me.txtDescription.TabIndex = 0
        '
        'dtpStartDate
        '
        Me.dtpStartDate.BorderRadius = 10
        Me.dtpStartDate.Checked = True
        Me.dtpStartDate.Enabled = False
        Me.dtpStartDate.FillColor = System.Drawing.Color.SeaGreen
        Me.dtpStartDate.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpStartDate.Location = New System.Drawing.Point(44, 434)
        Me.dtpStartDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpStartDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(153, 36)
        Me.dtpStartDate.TabIndex = 5
        Me.dtpStartDate.Value = New Date(2024, 7, 18, 15, 24, 7, 891)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(21, 410)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 21)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Start Date:"
        '
        'dtpCompletion
        '
        Me.dtpCompletion.BorderRadius = 10
        Me.dtpCompletion.Checked = True
        Me.dtpCompletion.FillColor = System.Drawing.Color.SeaGreen
        Me.dtpCompletion.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpCompletion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpCompletion.Location = New System.Drawing.Point(285, 434)
        Me.dtpCompletion.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpCompletion.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpCompletion.Name = "dtpCompletion"
        Me.dtpCompletion.Size = New System.Drawing.Size(153, 36)
        Me.dtpCompletion.TabIndex = 2
        Me.dtpCompletion.Value = New Date(2024, 7, 18, 15, 24, 7, 891)
        '
        'txtDept
        '
        Me.txtDept.BackColor = System.Drawing.Color.Transparent
        Me.txtDept.BorderColor = System.Drawing.Color.Black
        Me.txtDept.BorderRadius = 20
        Me.txtDept.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDept.DefaultText = ""
        Me.txtDept.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtDept.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtDept.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDept.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDept.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDept.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDept.ForeColor = System.Drawing.Color.Black
        Me.txtDept.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDept.Location = New System.Drawing.Point(44, 348)
        Me.txtDept.Margin = New System.Windows.Forms.Padding(6)
        Me.txtDept.Name = "txtDept"
        Me.txtDept.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDept.PlaceholderText = ""
        Me.txtDept.SelectedText = ""
        Me.txtDept.ShadowDecoration.BorderRadius = 20
        Me.txtDept.ShadowDecoration.Depth = 15
        Me.txtDept.ShadowDecoration.Enabled = True
        Me.txtDept.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 15, 15)
        Me.txtDept.Size = New System.Drawing.Size(419, 44)
        Me.txtDept.TabIndex = 1
        '
        'txtProjTitle
        '
        Me.txtProjTitle.BackColor = System.Drawing.Color.Transparent
        Me.txtProjTitle.BorderColor = System.Drawing.Color.Black
        Me.txtProjTitle.BorderRadius = 20
        Me.txtProjTitle.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtProjTitle.DefaultText = ""
        Me.txtProjTitle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtProjTitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtProjTitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtProjTitle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtProjTitle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtProjTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtProjTitle.ForeColor = System.Drawing.Color.Black
        Me.txtProjTitle.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtProjTitle.Location = New System.Drawing.Point(44, 52)
        Me.txtProjTitle.Margin = New System.Windows.Forms.Padding(6)
        Me.txtProjTitle.Multiline = True
        Me.txtProjTitle.Name = "txtProjTitle"
        Me.txtProjTitle.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtProjTitle.PlaceholderText = ""
        Me.txtProjTitle.ReadOnly = True
        Me.txtProjTitle.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtProjTitle.SelectedText = ""
        Me.txtProjTitle.ShadowDecoration.BorderRadius = 20
        Me.txtProjTitle.ShadowDecoration.Depth = 15
        Me.txtProjTitle.ShadowDecoration.Enabled = True
        Me.txtProjTitle.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 15, 15)
        Me.txtProjTitle.Size = New System.Drawing.Size(419, 69)
        Me.txtProjTitle.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(262, 410)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(138, 21)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Completion Date:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(21, 321)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 21)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Department"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(21, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 21)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Project Title"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.MenuBar
        Me.GroupBox2.Controls.Add(Me.txtMemEmail)
        Me.GroupBox2.Controls.Add(Me.txtMember)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(54, 266)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(486, 428)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Members"
        '
        'txtMemEmail
        '
        Me.txtMemEmail.BackColor = System.Drawing.Color.Transparent
        Me.txtMemEmail.BorderColor = System.Drawing.Color.Black
        Me.txtMemEmail.BorderRadius = 20
        Me.txtMemEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMemEmail.DefaultText = ""
        Me.txtMemEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtMemEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtMemEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMemEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMemEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMemEmail.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtMemEmail.ForeColor = System.Drawing.Color.Black
        Me.txtMemEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMemEmail.Location = New System.Drawing.Point(104, 243)
        Me.txtMemEmail.Margin = New System.Windows.Forms.Padding(6)
        Me.txtMemEmail.Multiline = True
        Me.txtMemEmail.Name = "txtMemEmail"
        Me.txtMemEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMemEmail.PlaceholderText = ""
        Me.txtMemEmail.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtMemEmail.SelectedText = ""
        Me.txtMemEmail.ShadowDecoration.BorderRadius = 20
        Me.txtMemEmail.ShadowDecoration.Depth = 15
        Me.txtMemEmail.ShadowDecoration.Enabled = True
        Me.txtMemEmail.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 15, 15)
        Me.txtMemEmail.Size = New System.Drawing.Size(352, 147)
        Me.txtMemEmail.TabIndex = 1
        '
        'txtMember
        '
        Me.txtMember.BackColor = System.Drawing.Color.Transparent
        Me.txtMember.BorderColor = System.Drawing.Color.Black
        Me.txtMember.BorderRadius = 20
        Me.txtMember.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMember.DefaultText = ""
        Me.txtMember.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtMember.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtMember.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMember.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMember.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMember.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtMember.ForeColor = System.Drawing.Color.Black
        Me.txtMember.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMember.Location = New System.Drawing.Point(102, 43)
        Me.txtMember.Margin = New System.Windows.Forms.Padding(6)
        Me.txtMember.Multiline = True
        Me.txtMember.Name = "txtMember"
        Me.txtMember.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMember.PlaceholderText = ""
        Me.txtMember.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtMember.SelectedText = ""
        Me.txtMember.ShadowDecoration.BorderRadius = 20
        Me.txtMember.ShadowDecoration.Depth = 15
        Me.txtMember.ShadowDecoration.Enabled = True
        Me.txtMember.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 15, 15)
        Me.txtMember.Size = New System.Drawing.Size(352, 147)
        Me.txtMember.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(36, 243)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 21)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Emails:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(29, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 21)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Names:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.MenuBar
        Me.GroupBox1.Controls.Add(Me.txtManagerEmail)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(54, 64)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(486, 180)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Project Manager"
        '
        'txtManagerEmail
        '
        Me.txtManagerEmail.BackColor = System.Drawing.Color.Transparent
        Me.txtManagerEmail.BorderColor = System.Drawing.Color.Black
        Me.txtManagerEmail.BorderRadius = 20
        Me.txtManagerEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtManagerEmail.DefaultText = ""
        Me.txtManagerEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtManagerEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtManagerEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtManagerEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtManagerEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtManagerEmail.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtManagerEmail.ForeColor = System.Drawing.Color.Black
        Me.txtManagerEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtManagerEmail.Location = New System.Drawing.Point(105, 110)
        Me.txtManagerEmail.Margin = New System.Windows.Forms.Padding(6)
        Me.txtManagerEmail.Name = "txtManagerEmail"
        Me.txtManagerEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtManagerEmail.PlaceholderText = ""
        Me.txtManagerEmail.ReadOnly = True
        Me.txtManagerEmail.SelectedText = ""
        Me.txtManagerEmail.ShadowDecoration.BorderRadius = 20
        Me.txtManagerEmail.ShadowDecoration.Depth = 15
        Me.txtManagerEmail.ShadowDecoration.Enabled = True
        Me.txtManagerEmail.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 15, 15)
        Me.txtManagerEmail.Size = New System.Drawing.Size(354, 44)
        Me.txtManagerEmail.TabIndex = 1
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.Transparent
        Me.txtName.BorderColor = System.Drawing.Color.Black
        Me.txtName.BorderRadius = 20
        Me.txtName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtName.DefaultText = ""
        Me.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.ForeColor = System.Drawing.Color.Black
        Me.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtName.Location = New System.Drawing.Point(102, 41)
        Me.txtName.Margin = New System.Windows.Forms.Padding(6)
        Me.txtName.Name = "txtName"
        Me.txtName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtName.PlaceholderText = ""
        Me.txtName.ReadOnly = True
        Me.txtName.SelectedText = ""
        Me.txtName.ShadowDecoration.BorderRadius = 20
        Me.txtName.ShadowDecoration.Depth = 15
        Me.txtName.ShadowDecoration.Enabled = True
        Me.txtName.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 15, 15)
        Me.txtName.Size = New System.Drawing.Size(354, 44)
        Me.txtName.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(44, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Email:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(39, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name:"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Request_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1264, 834)
        Me.Controls.Add(Me.Guna2GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Request_Form"
        Me.Text = "Request_Form"
        Me.Guna2GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2GroupBox2 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnSend As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtManagerEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtDept As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtProjTitle As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtMemEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtMember As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtDescription As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents dtpCompletion As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents dtpStartDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label9 As Label
    Friend WithEvents txtA3name As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btmBrowse As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
