<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminProdSupport_Form
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpEnd = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpStart = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpSupportDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.cboName = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cboDepartments = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtAction = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAdd = New Guna.UI2.WinForms.Guna2Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Guna2GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Guna2GroupBox1.BorderColor = System.Drawing.Color.Black
        Me.Guna2GroupBox1.BorderRadius = 10
        Me.Guna2GroupBox1.Controls.Add(Me.DataGridView1)
        Me.Guna2GroupBox1.Controls.Add(Me.GroupBox2)
        Me.Guna2GroupBox1.Controls.Add(Me.Label6)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.SeaGreen
        Me.Guna2GroupBox1.CustomBorderThickness = New System.Windows.Forms.Padding(3, 40, 3, 3)
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(55, 22)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.BorderRadius = 20
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(1147, 785)
        Me.Guna2GroupBox1.TabIndex = 8
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(47, 416)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1059, 353)
        Me.DataGridView1.TabIndex = 21
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.dtpEnd)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.dtpStart)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.dtpSupportDate)
        Me.GroupBox2.Controls.Add(Me.cboName)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.cboDepartments)
        Me.GroupBox2.Controls.Add(Me.txtAction)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.btnAdd)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(47, 59)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1059, 321)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Add new support provided"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(598, 198)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 20)
        Me.Label5.TabIndex = 56
        Me.Label5.Text = "End Time:"
        '
        'dtpEnd
        '
        Me.dtpEnd.BorderRadius = 10
        Me.dtpEnd.Checked = True
        Me.dtpEnd.CustomFormat = ""
        Me.dtpEnd.FillColor = System.Drawing.Color.SeaGreen
        Me.dtpEnd.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEnd.ForeColor = System.Drawing.Color.White
        Me.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpEnd.Location = New System.Drawing.Point(613, 223)
        Me.dtpEnd.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpEnd.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpEnd.Name = "dtpEnd"
        Me.dtpEnd.Size = New System.Drawing.Size(143, 36)
        Me.dtpEnd.TabIndex = 55
        Me.dtpEnd.Value = New Date(2025, 6, 26, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(420, 198)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 20)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "Start Time:"
        '
        'dtpStart
        '
        Me.dtpStart.BorderRadius = 10
        Me.dtpStart.Checked = True
        Me.dtpStart.CustomFormat = ""
        Me.dtpStart.FillColor = System.Drawing.Color.SeaGreen
        Me.dtpStart.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpStart.ForeColor = System.Drawing.Color.White
        Me.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpStart.Location = New System.Drawing.Point(435, 223)
        Me.dtpStart.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpStart.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpStart.Name = "dtpStart"
        Me.dtpStart.ShowUpDown = True
        Me.dtpStart.Size = New System.Drawing.Size(143, 36)
        Me.dtpStart.TabIndex = 53
        Me.dtpStart.Value = New Date(2025, 6, 26, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(39, 198)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 20)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Date:"
        '
        'dtpSupportDate
        '
        Me.dtpSupportDate.BorderRadius = 10
        Me.dtpSupportDate.Checked = True
        Me.dtpSupportDate.FillColor = System.Drawing.Color.SeaGreen
        Me.dtpSupportDate.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpSupportDate.ForeColor = System.Drawing.Color.White
        Me.dtpSupportDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpSupportDate.Location = New System.Drawing.Point(54, 223)
        Me.dtpSupportDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpSupportDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpSupportDate.Name = "dtpSupportDate"
        Me.dtpSupportDate.Size = New System.Drawing.Size(143, 36)
        Me.dtpSupportDate.TabIndex = 51
        Me.dtpSupportDate.Value = New Date(2025, 6, 26, 0, 0, 0, 0)
        '
        'cboName
        '
        Me.cboName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboName.BackColor = System.Drawing.Color.Transparent
        Me.cboName.BorderColor = System.Drawing.Color.Black
        Me.cboName.BorderRadius = 15
        Me.cboName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboName.DropDownHeight = 200
        Me.cboName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboName.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboName.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cboName.ForeColor = System.Drawing.Color.Black
        Me.cboName.IntegralHeight = False
        Me.cboName.ItemHeight = 30
        Me.cboName.Location = New System.Drawing.Point(54, 71)
        Me.cboName.Name = "cboName"
        Me.cboName.ShadowDecoration.BorderRadius = 20
        Me.cboName.ShadowDecoration.Depth = 15
        Me.cboName.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 10, 10)
        Me.cboName.Size = New System.Drawing.Size(336, 36)
        Me.cboName.TabIndex = 50
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(39, 117)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(95, 20)
        Me.Label13.TabIndex = 49
        Me.Label13.Text = "Department:"
        '
        'cboDepartments
        '
        Me.cboDepartments.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboDepartments.BackColor = System.Drawing.Color.Transparent
        Me.cboDepartments.BorderColor = System.Drawing.Color.Black
        Me.cboDepartments.BorderRadius = 15
        Me.cboDepartments.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboDepartments.DropDownHeight = 200
        Me.cboDepartments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDepartments.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboDepartments.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboDepartments.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cboDepartments.ForeColor = System.Drawing.Color.Black
        Me.cboDepartments.IntegralHeight = False
        Me.cboDepartments.ItemHeight = 30
        Me.cboDepartments.Items.AddRange(New Object() {"AUTOMOTIVE", "CERAMIC FUSE", "CSR", "EBU-APD", "ELECTRONICS LEAN", "ELSS", "EHS", "FACILITIES", "FINANCE", "GLOBAL EHS", "GLOBAL LOGISTICS AND SCHEDULING", "GLOBAL PEC", "GLOBAL PLM", "GLOBAL PMO", "HI-RELIABILITY", "HR", "IT", "LTC", "MARKETING SERVICES", "PHILIPPINE INTERNAL AUDIT", "PICO/SMF/BARRIER", "PLANT ADMIN", "PLANT QUALITY", "PRODUCT DEVELOPMENT-EBU", "PRODUCT MANAGEMENT-EBU", "REED SWITCH", "SBU", "SBU-GLOBAL PLANNING", "SQUARE NANO", "SUPPLIER DEVELOPMENT ENGINEERING", "SUPPLY CHAIN", "TECHNICAL SUPPORT - TSG", "THIN FILM", "TR/TE"})
        Me.cboDepartments.Location = New System.Drawing.Point(54, 142)
        Me.cboDepartments.Name = "cboDepartments"
        Me.cboDepartments.ShadowDecoration.BorderRadius = 20
        Me.cboDepartments.ShadowDecoration.Depth = 15
        Me.cboDepartments.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 10, 10)
        Me.cboDepartments.Size = New System.Drawing.Size(336, 36)
        Me.cboDepartments.TabIndex = 47
        '
        'txtAction
        '
        Me.txtAction.BackColor = System.Drawing.Color.Transparent
        Me.txtAction.BorderColor = System.Drawing.Color.Black
        Me.txtAction.BorderRadius = 20
        Me.txtAction.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAction.DefaultText = ""
        Me.txtAction.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAction.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAction.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAction.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAction.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAction.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtAction.ForeColor = System.Drawing.Color.Black
        Me.txtAction.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAction.Location = New System.Drawing.Point(424, 66)
        Me.txtAction.Margin = New System.Windows.Forms.Padding(6)
        Me.txtAction.Multiline = True
        Me.txtAction.Name = "txtAction"
        Me.txtAction.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAction.PlaceholderText = ""
        Me.txtAction.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtAction.SelectedText = ""
        Me.txtAction.ShadowDecoration.BorderRadius = 20
        Me.txtAction.ShadowDecoration.Depth = 15
        Me.txtAction.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 15, 15)
        Me.txtAction.Size = New System.Drawing.Size(583, 112)
        Me.txtAction.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(420, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(292, 21)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Please specify the assistance provided:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(39, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Names:"
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnAdd.BackColor = System.Drawing.Color.Transparent
        Me.btnAdd.BorderRadius = 10
        Me.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(905, 258)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(131, 45)
        Me.btnAdd.TabIndex = 11
        Me.btnAdd.Text = "Add"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Italic)
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(43, 393)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(163, 20)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "List of Support Provided:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'AdminProdSupport_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1264, 834)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AdminProdSupport_Form"
        Me.Text = "ProdSupport_Form"
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtAction As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cboName As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents cboDepartments As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents dtpStart As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpSupportDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dtpEnd As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents DataGridView1 As DataGridView
End Class
