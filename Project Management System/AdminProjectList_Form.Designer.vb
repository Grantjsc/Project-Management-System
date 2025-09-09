<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminProjectList_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminProjectList_Form))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dtpStartDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.cboStat = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cboTokenStat = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtSupport = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dtpDue = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtDept = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtMemEmails = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtMember = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtOwnersEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtOwner = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDescr = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTitle = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtToken = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cboTSG_Support = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblNotStarted = New System.Windows.Forms.Label()
        Me.lblOnGoing = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lblDone = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lblOnHold = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.cboStatus = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cboDept = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Guna2GroupBox2 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Guna2CirclePictureBox3 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Guna2CirclePictureBox2 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.Guna2GroupBox2.SuspendLayout()
        CType(Me.Guna2CirclePictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2CirclePictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(20, 147)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1123, 581)
        Me.DataGridView1.TabIndex = 0
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Guna2GroupBox1.AutoScroll = True
        Me.Guna2GroupBox1.BorderColor = System.Drawing.Color.Black
        Me.Guna2GroupBox1.BorderRadius = 10
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2TextBox1)
        Me.Guna2GroupBox1.Controls.Add(Me.Label14)
        Me.Guna2GroupBox1.Controls.Add(Me.dtpStartDate)
        Me.Guna2GroupBox1.Controls.Add(Me.cboStat)
        Me.Guna2GroupBox1.Controls.Add(Me.cboTokenStat)
        Me.Guna2GroupBox1.Controls.Add(Me.Label13)
        Me.Guna2GroupBox1.Controls.Add(Me.Label12)
        Me.Guna2GroupBox1.Controls.Add(Me.txtSupport)
        Me.Guna2GroupBox1.Controls.Add(Me.Label11)
        Me.Guna2GroupBox1.Controls.Add(Me.dtpDue)
        Me.Guna2GroupBox1.Controls.Add(Me.Label10)
        Me.Guna2GroupBox1.Controls.Add(Me.txtDept)
        Me.Guna2GroupBox1.Controls.Add(Me.Label9)
        Me.Guna2GroupBox1.Controls.Add(Me.txtMemEmails)
        Me.Guna2GroupBox1.Controls.Add(Me.Label8)
        Me.Guna2GroupBox1.Controls.Add(Me.txtMember)
        Me.Guna2GroupBox1.Controls.Add(Me.Label7)
        Me.Guna2GroupBox1.Controls.Add(Me.txtOwnersEmail)
        Me.Guna2GroupBox1.Controls.Add(Me.Label5)
        Me.Guna2GroupBox1.Controls.Add(Me.txtOwner)
        Me.Guna2GroupBox1.Controls.Add(Me.Label3)
        Me.Guna2GroupBox1.Controls.Add(Me.txtDescr)
        Me.Guna2GroupBox1.Controls.Add(Me.Label2)
        Me.Guna2GroupBox1.Controls.Add(Me.txtTitle)
        Me.Guna2GroupBox1.Controls.Add(Me.Label1)
        Me.Guna2GroupBox1.Controls.Add(Me.txtToken)
        Me.Guna2GroupBox1.Controls.Add(Me.Label4)
        Me.Guna2GroupBox1.Controls.Add(Me.btnSave)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.SeaGreen
        Me.Guna2GroupBox1.CustomBorderThickness = New System.Windows.Forms.Padding(3)
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.SeaGreen
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(23, 159)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.BorderRadius = 20
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(1093, 513)
        Me.Guna2GroupBox1.TabIndex = 6
        Me.Guna2GroupBox1.Text = "Edit"
        Me.Guna2GroupBox1.Visible = False
        '
        'Guna2TextBox1
        '
        Me.Guna2TextBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2TextBox1.BorderColor = System.Drawing.Color.Black
        Me.Guna2TextBox1.BorderRadius = 20
        Me.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox1.DefaultText = ""
        Me.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2TextBox1.ForeColor = System.Drawing.Color.Black
        Me.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.Location = New System.Drawing.Point(1027, 27)
        Me.Guna2TextBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.Guna2TextBox1.Multiline = True
        Me.Guna2TextBox1.Name = "Guna2TextBox1"
        Me.Guna2TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox1.PlaceholderText = ""
        Me.Guna2TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.Guna2TextBox1.SelectedText = ""
        Me.Guna2TextBox1.ShadowDecoration.BorderRadius = 20
        Me.Guna2TextBox1.ShadowDecoration.Depth = 15
        Me.Guna2TextBox1.ShadowDecoration.Enabled = True
        Me.Guna2TextBox1.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 10, 10)
        Me.Guna2TextBox1.Size = New System.Drawing.Size(54, 80)
        Me.Guna2TextBox1.TabIndex = 43
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label14.Location = New System.Drawing.Point(570, 381)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(54, 26)
        Me.Label14.TabIndex = 42
        Me.Label14.Text = "Start"
        '
        'dtpStartDate
        '
        Me.dtpStartDate.BackColor = System.Drawing.Color.Transparent
        Me.dtpStartDate.BorderRadius = 10
        Me.dtpStartDate.Checked = True
        Me.dtpStartDate.FillColor = System.Drawing.Color.SeaGreen
        Me.dtpStartDate.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.dtpStartDate.ForeColor = System.Drawing.Color.White
        Me.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpStartDate.Location = New System.Drawing.Point(632, 379)
        Me.dtpStartDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpStartDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(153, 36)
        Me.dtpStartDate.TabIndex = 11
        Me.dtpStartDate.Value = New Date(2024, 7, 18, 15, 24, 7, 891)
        '
        'cboStat
        '
        Me.cboStat.BackColor = System.Drawing.Color.Transparent
        Me.cboStat.BorderRadius = 20
        Me.cboStat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboStat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStat.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboStat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboStat.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cboStat.ForeColor = System.Drawing.Color.Black
        Me.cboStat.ItemHeight = 30
        Me.cboStat.Items.AddRange(New Object() {"Done", "On-going", "Not Started"})
        Me.cboStat.Location = New System.Drawing.Point(629, 310)
        Me.cboStat.Name = "cboStat"
        Me.cboStat.ShadowDecoration.BorderRadius = 20
        Me.cboStat.ShadowDecoration.Depth = 15
        Me.cboStat.ShadowDecoration.Enabled = True
        Me.cboStat.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 10, 10)
        Me.cboStat.Size = New System.Drawing.Size(147, 36)
        Me.cboStat.TabIndex = 9
        '
        'cboTokenStat
        '
        Me.cboTokenStat.BackColor = System.Drawing.Color.Transparent
        Me.cboTokenStat.BorderRadius = 20
        Me.cboTokenStat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboTokenStat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTokenStat.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboTokenStat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboTokenStat.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTokenStat.ForeColor = System.Drawing.Color.Black
        Me.cboTokenStat.ItemHeight = 30
        Me.cboTokenStat.Items.AddRange(New Object() {"Unused", "Used"})
        Me.cboTokenStat.Location = New System.Drawing.Point(861, 310)
        Me.cboTokenStat.Name = "cboTokenStat"
        Me.cboTokenStat.ShadowDecoration.BorderRadius = 20
        Me.cboTokenStat.ShadowDecoration.Depth = 15
        Me.cboTokenStat.ShadowDecoration.Enabled = True
        Me.cboTokenStat.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 10, 10)
        Me.cboTokenStat.Size = New System.Drawing.Size(147, 36)
        Me.cboTokenStat.TabIndex = 10
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label13.Location = New System.Drawing.Point(795, 305)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(61, 46)
        Me.Label13.TabIndex = 35
        Me.Label13.Text = "Token " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Status"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label12.Location = New System.Drawing.Point(557, 315)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 26)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = "Status"
        '
        'txtSupport
        '
        Me.txtSupport.BackColor = System.Drawing.Color.Transparent
        Me.txtSupport.BorderColor = System.Drawing.Color.Black
        Me.txtSupport.BorderRadius = 20
        Me.txtSupport.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSupport.DefaultText = ""
        Me.txtSupport.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSupport.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSupport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSupport.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSupport.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSupport.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSupport.ForeColor = System.Drawing.Color.Black
        Me.txtSupport.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSupport.Location = New System.Drawing.Point(861, 237)
        Me.txtSupport.Margin = New System.Windows.Forms.Padding(6)
        Me.txtSupport.Multiline = True
        Me.txtSupport.Name = "txtSupport"
        Me.txtSupport.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSupport.PlaceholderText = ""
        Me.txtSupport.SelectedText = ""
        Me.txtSupport.ShadowDecoration.BorderRadius = 20
        Me.txtSupport.ShadowDecoration.Depth = 15
        Me.txtSupport.ShadowDecoration.Enabled = True
        Me.txtSupport.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 10, 10)
        Me.txtSupport.Size = New System.Drawing.Size(147, 43)
        Me.txtSupport.TabIndex = 8
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label11.Location = New System.Drawing.Point(783, 237)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 46)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "    TSG" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Support"
        '
        'dtpDue
        '
        Me.dtpDue.BackColor = System.Drawing.Color.Transparent
        Me.dtpDue.BorderRadius = 10
        Me.dtpDue.Checked = True
        Me.dtpDue.FillColor = System.Drawing.Color.SeaGreen
        Me.dtpDue.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDue.ForeColor = System.Drawing.Color.White
        Me.dtpDue.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDue.Location = New System.Drawing.Point(861, 379)
        Me.dtpDue.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpDue.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpDue.Name = "dtpDue"
        Me.dtpDue.Size = New System.Drawing.Size(153, 36)
        Me.dtpDue.TabIndex = 12
        Me.dtpDue.Value = New Date(2024, 7, 18, 15, 24, 7, 891)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label10.Location = New System.Drawing.Point(810, 382)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 26)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Due"
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
        Me.txtDept.Location = New System.Drawing.Point(632, 237)
        Me.txtDept.Margin = New System.Windows.Forms.Padding(6)
        Me.txtDept.Name = "txtDept"
        Me.txtDept.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDept.PlaceholderText = ""
        Me.txtDept.SelectedText = ""
        Me.txtDept.ShadowDecoration.BorderRadius = 20
        Me.txtDept.ShadowDecoration.Depth = 15
        Me.txtDept.ShadowDecoration.Enabled = True
        Me.txtDept.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 10, 10)
        Me.txtDept.Size = New System.Drawing.Size(132, 43)
        Me.txtDept.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label9.Location = New System.Drawing.Point(572, 247)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 26)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Dept"
        '
        'txtMemEmails
        '
        Me.txtMemEmails.BackColor = System.Drawing.Color.Transparent
        Me.txtMemEmails.BorderColor = System.Drawing.Color.Black
        Me.txtMemEmails.BorderRadius = 20
        Me.txtMemEmails.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMemEmails.DefaultText = ""
        Me.txtMemEmails.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtMemEmails.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtMemEmails.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMemEmails.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMemEmails.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMemEmails.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMemEmails.ForeColor = System.Drawing.Color.Black
        Me.txtMemEmails.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMemEmails.Location = New System.Drawing.Point(647, 127)
        Me.txtMemEmails.Margin = New System.Windows.Forms.Padding(6)
        Me.txtMemEmails.Multiline = True
        Me.txtMemEmails.Name = "txtMemEmails"
        Me.txtMemEmails.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMemEmails.PlaceholderText = ""
        Me.txtMemEmails.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtMemEmails.SelectedText = ""
        Me.txtMemEmails.ShadowDecoration.BorderRadius = 20
        Me.txtMemEmails.ShadowDecoration.Depth = 15
        Me.txtMemEmails.ShadowDecoration.Enabled = True
        Me.txtMemEmails.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 10, 10)
        Me.txtMemEmails.Size = New System.Drawing.Size(338, 82)
        Me.txtMemEmails.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label8.Location = New System.Drawing.Point(572, 140)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 26)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Emails"
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
        Me.txtMember.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMember.ForeColor = System.Drawing.Color.Black
        Me.txtMember.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMember.Location = New System.Drawing.Point(647, 37)
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
        Me.txtMember.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 10, 10)
        Me.txtMember.Size = New System.Drawing.Size(338, 82)
        Me.txtMember.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label7.Location = New System.Drawing.Point(556, 44)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 26)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Member"
        '
        'txtOwnersEmail
        '
        Me.txtOwnersEmail.BackColor = System.Drawing.Color.Transparent
        Me.txtOwnersEmail.BorderColor = System.Drawing.Color.Black
        Me.txtOwnersEmail.BorderRadius = 20
        Me.txtOwnersEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtOwnersEmail.DefaultText = ""
        Me.txtOwnersEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtOwnersEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtOwnersEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtOwnersEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtOwnersEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtOwnersEmail.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOwnersEmail.ForeColor = System.Drawing.Color.Black
        Me.txtOwnersEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtOwnersEmail.Location = New System.Drawing.Point(143, 325)
        Me.txtOwnersEmail.Margin = New System.Windows.Forms.Padding(6)
        Me.txtOwnersEmail.Name = "txtOwnersEmail"
        Me.txtOwnersEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtOwnersEmail.PlaceholderText = ""
        Me.txtOwnersEmail.SelectedText = ""
        Me.txtOwnersEmail.ShadowDecoration.BorderRadius = 20
        Me.txtOwnersEmail.ShadowDecoration.Depth = 15
        Me.txtOwnersEmail.ShadowDecoration.Enabled = True
        Me.txtOwnersEmail.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 10, 10)
        Me.txtOwnersEmail.Size = New System.Drawing.Size(338, 43)
        Me.txtOwnersEmail.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label5.Location = New System.Drawing.Point(78, 335)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 26)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Email"
        '
        'txtOwner
        '
        Me.txtOwner.BackColor = System.Drawing.Color.Transparent
        Me.txtOwner.BorderColor = System.Drawing.Color.Black
        Me.txtOwner.BorderRadius = 20
        Me.txtOwner.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtOwner.DefaultText = ""
        Me.txtOwner.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtOwner.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtOwner.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtOwner.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtOwner.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtOwner.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOwner.ForeColor = System.Drawing.Color.Black
        Me.txtOwner.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtOwner.Location = New System.Drawing.Point(143, 259)
        Me.txtOwner.Margin = New System.Windows.Forms.Padding(6)
        Me.txtOwner.Name = "txtOwner"
        Me.txtOwner.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtOwner.PlaceholderText = ""
        Me.txtOwner.SelectedText = ""
        Me.txtOwner.ShadowDecoration.BorderRadius = 20
        Me.txtOwner.ShadowDecoration.Depth = 15
        Me.txtOwner.ShadowDecoration.Enabled = True
        Me.txtOwner.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 10, 10)
        Me.txtOwner.Size = New System.Drawing.Size(338, 43)
        Me.txtOwner.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label3.Location = New System.Drawing.Point(69, 267)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 26)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Owner"
        '
        'txtDescr
        '
        Me.txtDescr.BackColor = System.Drawing.Color.Transparent
        Me.txtDescr.BorderColor = System.Drawing.Color.Black
        Me.txtDescr.BorderRadius = 20
        Me.txtDescr.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDescr.DefaultText = ""
        Me.txtDescr.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtDescr.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtDescr.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDescr.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDescr.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDescr.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescr.ForeColor = System.Drawing.Color.Black
        Me.txtDescr.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDescr.Location = New System.Drawing.Point(143, 163)
        Me.txtDescr.Margin = New System.Windows.Forms.Padding(6)
        Me.txtDescr.Multiline = True
        Me.txtDescr.Name = "txtDescr"
        Me.txtDescr.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescr.PlaceholderText = ""
        Me.txtDescr.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtDescr.SelectedText = ""
        Me.txtDescr.ShadowDecoration.BorderRadius = 20
        Me.txtDescr.ShadowDecoration.Depth = 15
        Me.txtDescr.ShadowDecoration.Enabled = True
        Me.txtDescr.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 10, 10)
        Me.txtDescr.Size = New System.Drawing.Size(338, 72)
        Me.txtDescr.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label2.Location = New System.Drawing.Point(72, 172)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 26)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Descr"
        '
        'txtTitle
        '
        Me.txtTitle.BackColor = System.Drawing.Color.Transparent
        Me.txtTitle.BorderColor = System.Drawing.Color.Black
        Me.txtTitle.BorderRadius = 20
        Me.txtTitle.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTitle.DefaultText = ""
        Me.txtTitle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtTitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtTitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTitle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTitle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle.ForeColor = System.Drawing.Color.Black
        Me.txtTitle.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTitle.Location = New System.Drawing.Point(143, 98)
        Me.txtTitle.Margin = New System.Windows.Forms.Padding(6)
        Me.txtTitle.Multiline = True
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTitle.PlaceholderText = ""
        Me.txtTitle.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtTitle.SelectedText = ""
        Me.txtTitle.ShadowDecoration.BorderRadius = 20
        Me.txtTitle.ShadowDecoration.Depth = 15
        Me.txtTitle.ShadowDecoration.Enabled = True
        Me.txtTitle.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 10, 10)
        Me.txtTitle.Size = New System.Drawing.Size(338, 43)
        Me.txtTitle.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label1.Location = New System.Drawing.Point(86, 106)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 26)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Title"
        '
        'txtToken
        '
        Me.txtToken.BackColor = System.Drawing.Color.Transparent
        Me.txtToken.BorderColor = System.Drawing.Color.Black
        Me.txtToken.BorderRadius = 20
        Me.txtToken.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtToken.DefaultText = ""
        Me.txtToken.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtToken.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtToken.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtToken.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtToken.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtToken.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtToken.ForeColor = System.Drawing.Color.Black
        Me.txtToken.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtToken.Location = New System.Drawing.Point(143, 37)
        Me.txtToken.Margin = New System.Windows.Forms.Padding(6)
        Me.txtToken.MaxLength = 3
        Me.txtToken.Name = "txtToken"
        Me.txtToken.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtToken.PlaceholderText = ""
        Me.txtToken.ReadOnly = True
        Me.txtToken.SelectedText = ""
        Me.txtToken.ShadowDecoration.BorderRadius = 20
        Me.txtToken.ShadowDecoration.Depth = 15
        Me.txtToken.ShadowDecoration.Enabled = True
        Me.txtToken.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 10, 10)
        Me.txtToken.Size = New System.Drawing.Size(338, 43)
        Me.txtToken.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label4.Location = New System.Drawing.Point(70, 44)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 26)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Token"
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
        Me.btnSave.Location = New System.Drawing.Point(466, 435)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(131, 45)
        Me.btnSave.TabIndex = 13
        Me.btnSave.Text = "Save Changes"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(291, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(293, 17)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Note: (doble-click on the project row to edit details)"
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.Transparent
        Me.txtSearch.BorderColor = System.Drawing.Color.Black
        Me.txtSearch.BorderRadius = 15
        Me.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearch.DefaultText = "Search Project"
        Me.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.HoverState.BorderColor = System.Drawing.Color.LightGray
        Me.txtSearch.IconLeft = CType(resources.GetObject("txtSearch.IconLeft"), System.Drawing.Image)
        Me.txtSearch.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtSearch.Location = New System.Drawing.Point(311, 9)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.PlaceholderText = ""
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.Size = New System.Drawing.Size(454, 28)
        Me.txtSearch.TabIndex = 1
        Me.txtSearch.TextOffset = New System.Drawing.Point(10, 0)
        Me.txtSearch.Visible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Impact", 18.0!)
        Me.Label15.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label15.Location = New System.Drawing.Point(796, 8)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(90, 29)
        Me.Label15.TabIndex = 113
        Me.Label15.Text = "Support"
        '
        'cboTSG_Support
        '
        Me.cboTSG_Support.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboTSG_Support.BackColor = System.Drawing.Color.Transparent
        Me.cboTSG_Support.BorderColor = System.Drawing.Color.Black
        Me.cboTSG_Support.BorderRadius = 15
        Me.cboTSG_Support.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboTSG_Support.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTSG_Support.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboTSG_Support.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboTSG_Support.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cboTSG_Support.ForeColor = System.Drawing.Color.DimGray
        Me.cboTSG_Support.ItemHeight = 30
        Me.cboTSG_Support.Location = New System.Drawing.Point(891, 6)
        Me.cboTSG_Support.Name = "cboTSG_Support"
        Me.cboTSG_Support.ShadowDecoration.BorderRadius = 20
        Me.cboTSG_Support.ShadowDecoration.Depth = 15
        Me.cboTSG_Support.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 10, 10)
        Me.cboTSG_Support.Size = New System.Drawing.Size(252, 36)
        Me.cboTSG_Support.TabIndex = 2
        '
        'lblCount
        '
        Me.lblCount.BackColor = System.Drawing.Color.Transparent
        Me.lblCount.Font = New System.Drawing.Font("Impact", 20.0!)
        Me.lblCount.ForeColor = System.Drawing.Color.SeaGreen
        Me.lblCount.Location = New System.Drawing.Point(12, 9)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(192, 36)
        Me.lblCount.TabIndex = 187
        Me.lblCount.Text = "Total Project(s):"
        Me.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Impact", 15.0!)
        Me.Label16.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label16.Location = New System.Drawing.Point(409, 48)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(154, 32)
        Me.Label16.TabIndex = 188
        Me.Label16.Text = "To be started:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblTotal.Font = New System.Drawing.Font("Impact", 25.0!)
        Me.lblTotal.ForeColor = System.Drawing.Color.DimGray
        Me.lblTotal.Location = New System.Drawing.Point(195, 5)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(162, 45)
        Me.lblTotal.TabIndex = 0
        Me.lblTotal.Text = "0"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNotStarted
        '
        Me.lblNotStarted.BackColor = System.Drawing.Color.Transparent
        Me.lblNotStarted.Font = New System.Drawing.Font("Impact", 18.0!)
        Me.lblNotStarted.ForeColor = System.Drawing.Color.DimGray
        Me.lblNotStarted.Location = New System.Drawing.Point(531, 49)
        Me.lblNotStarted.Name = "lblNotStarted"
        Me.lblNotStarted.Size = New System.Drawing.Size(98, 31)
        Me.lblNotStarted.TabIndex = 190
        Me.lblNotStarted.Text = "0"
        Me.lblNotStarted.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblOnGoing
        '
        Me.lblOnGoing.BackColor = System.Drawing.Color.Transparent
        Me.lblOnGoing.Font = New System.Drawing.Font("Impact", 18.0!)
        Me.lblOnGoing.ForeColor = System.Drawing.Color.DimGray
        Me.lblOnGoing.Location = New System.Drawing.Point(304, 51)
        Me.lblOnGoing.Name = "lblOnGoing"
        Me.lblOnGoing.Size = New System.Drawing.Size(102, 31)
        Me.lblOnGoing.TabIndex = 192
        Me.lblOnGoing.Text = "0"
        Me.lblOnGoing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Impact", 15.0!)
        Me.Label20.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label20.Location = New System.Drawing.Point(195, 48)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(137, 32)
        Me.Label20.TabIndex = 191
        Me.Label20.Text = "In Progress:"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDone
        '
        Me.lblDone.BackColor = System.Drawing.Color.Transparent
        Me.lblDone.Font = New System.Drawing.Font("Impact", 18.0!)
        Me.lblDone.ForeColor = System.Drawing.Color.DimGray
        Me.lblDone.Location = New System.Drawing.Point(104, 50)
        Me.lblDone.Name = "lblDone"
        Me.lblDone.Size = New System.Drawing.Size(88, 31)
        Me.lblDone.TabIndex = 194
        Me.lblDone.Text = "0"
        Me.lblDone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Impact", 15.0!)
        Me.Label22.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label22.Location = New System.Drawing.Point(47, 49)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(85, 32)
        Me.Label22.TabIndex = 193
        Me.Label22.Text = "Done:"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblOnHold
        '
        Me.lblOnHold.BackColor = System.Drawing.Color.Transparent
        Me.lblOnHold.Font = New System.Drawing.Font("Impact", 18.0!)
        Me.lblOnHold.ForeColor = System.Drawing.Color.DimGray
        Me.lblOnHold.Location = New System.Drawing.Point(709, 49)
        Me.lblOnHold.Name = "lblOnHold"
        Me.lblOnHold.Size = New System.Drawing.Size(99, 31)
        Me.lblOnHold.TabIndex = 196
        Me.lblOnHold.Text = "0"
        Me.lblOnHold.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Impact", 15.0!)
        Me.Label24.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label24.Location = New System.Drawing.Point(631, 48)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(123, 32)
        Me.Label24.TabIndex = 195
        Me.Label24.Text = "On-hold:"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboStatus
        '
        Me.cboStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboStatus.BackColor = System.Drawing.Color.Transparent
        Me.cboStatus.BorderColor = System.Drawing.Color.Black
        Me.cboStatus.BorderRadius = 15
        Me.cboStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatus.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboStatus.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cboStatus.ForeColor = System.Drawing.Color.DimGray
        Me.cboStatus.ItemHeight = 30
        Me.cboStatus.Items.AddRange(New Object() {"Open Status", "To be started", "In Progress", "Done", "On Hold", "All"})
        Me.cboStatus.Location = New System.Drawing.Point(891, 48)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.ShadowDecoration.BorderRadius = 20
        Me.cboStatus.ShadowDecoration.Depth = 15
        Me.cboStatus.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 10, 10)
        Me.cboStatus.Size = New System.Drawing.Size(252, 36)
        Me.cboStatus.TabIndex = 197
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Impact", 18.0!)
        Me.Label17.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label17.Location = New System.Drawing.Point(824, 94)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(62, 29)
        Me.Label17.TabIndex = 198
        Me.Label17.Text = "Dept."
        '
        'cboDept
        '
        Me.cboDept.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboDept.BackColor = System.Drawing.Color.Transparent
        Me.cboDept.BorderColor = System.Drawing.Color.Black
        Me.cboDept.BorderRadius = 15
        Me.cboDept.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboDept.DropDownHeight = 250
        Me.cboDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDept.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboDept.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboDept.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cboDept.ForeColor = System.Drawing.Color.DimGray
        Me.cboDept.IntegralHeight = False
        Me.cboDept.ItemHeight = 30
        Me.cboDept.Items.AddRange(New Object() {"All", "AUTOMOTIVE", "CERAMIC FUSE", "CSR", "EBU-APD", "ELECTRONICS LEAN", "ELSS", "EHS", "FACILITIES", "FINANCE", "GLOBAL EHS", "GLOBAL LOGISTICS AND SCHEDULING", "GLOBAL PEC", "GLOBAL PLM", "GLOBAL PMO", "HI-RELIABILITY", "HR", "IT", "LTC", "MARKETING SERVICES", "PHILIPPINE INTERNAL AUDIT", "PICO/SMF/BARRIER", "PLANT ADMIN", "PLANT QUALITY", "PRODUCT DEVELOPMENT-EBU", "PRODUCT MANAGEMENT-EBU", "REED SWITCH", "SBU", "SBU-GLOBAL PLANNING", "SQUARE NANO", "SUPPLIER DEVELOPMENT ENGINEERING", "SUPPLY CHAIN", "TECHNICAL SUPPORT - TSG", "THIN FILM", "TR/TE"})
        Me.cboDept.Location = New System.Drawing.Point(891, 90)
        Me.cboDept.Name = "cboDept"
        Me.cboDept.ShadowDecoration.BorderRadius = 20
        Me.cboDept.ShadowDecoration.Depth = 15
        Me.cboDept.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 10, 10)
        Me.cboDept.Size = New System.Drawing.Size(252, 36)
        Me.cboDept.TabIndex = 199
        '
        'Label18
        '
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Impact", 18.0!)
        Me.Label18.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label18.Location = New System.Drawing.Point(811, 52)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(75, 29)
        Me.Label18.TabIndex = 200
        Me.Label18.Text = "Status"
        '
        'Guna2GroupBox2
        '
        Me.Guna2GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox2.BorderColor = System.Drawing.Color.Black
        Me.Guna2GroupBox2.BorderRadius = 5
        Me.Guna2GroupBox2.BorderThickness = 5
        Me.Guna2GroupBox2.Controls.Add(Me.Label19)
        Me.Guna2GroupBox2.Controls.Add(Me.Guna2CirclePictureBox3)
        Me.Guna2GroupBox2.Controls.Add(Me.Label21)
        Me.Guna2GroupBox2.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.Guna2GroupBox2.Controls.Add(Me.Label23)
        Me.Guna2GroupBox2.Controls.Add(Me.Guna2CirclePictureBox2)
        Me.Guna2GroupBox2.CustomBorderThickness = New System.Windows.Forms.Padding(0)
        Me.Guna2GroupBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox2.ForeColor = System.Drawing.Color.Green
        Me.Guna2GroupBox2.Location = New System.Drawing.Point(23, 100)
        Me.Guna2GroupBox2.Name = "Guna2GroupBox2"
        Me.Guna2GroupBox2.Size = New System.Drawing.Size(262, 41)
        Me.Guna2GroupBox2.TabIndex = 201
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(200, 15)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(44, 13)
        Me.Label19.TabIndex = 7
        Me.Label19.Text = "- Delay"
        '
        'Guna2CirclePictureBox3
        '
        Me.Guna2CirclePictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CirclePictureBox3.FillColor = System.Drawing.Color.Red
        Me.Guna2CirclePictureBox3.ImageRotate = 0!
        Me.Guna2CirclePictureBox3.Location = New System.Drawing.Point(179, 12)
        Me.Guna2CirclePictureBox3.Name = "Guna2CirclePictureBox3"
        Me.Guna2CirclePictureBox3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox3.Size = New System.Drawing.Size(18, 18)
        Me.Guna2CirclePictureBox3.TabIndex = 6
        Me.Guna2CirclePictureBox3.TabStop = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(132, 15)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(41, 13)
        Me.Label21.TabIndex = 5
        Me.Label21.Text = "- Done"
        '
        'Guna2CirclePictureBox1
        '
        Me.Guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CirclePictureBox1.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.Guna2CirclePictureBox1.ImageRotate = 0!
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(111, 12)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(18, 18)
        Me.Guna2CirclePictureBox1.TabIndex = 4
        Me.Guna2CirclePictureBox1.TabStop = False
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Segoe UI", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(34, 15)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(71, 13)
        Me.Label23.TabIndex = 3
        Me.Label23.Text = "- In Progress"
        '
        'Guna2CirclePictureBox2
        '
        Me.Guna2CirclePictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CirclePictureBox2.FillColor = System.Drawing.Color.Gold
        Me.Guna2CirclePictureBox2.ImageRotate = 0!
        Me.Guna2CirclePictureBox2.Location = New System.Drawing.Point(13, 12)
        Me.Guna2CirclePictureBox2.Name = "Guna2CirclePictureBox2"
        Me.Guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox2.Size = New System.Drawing.Size(18, 18)
        Me.Guna2CirclePictureBox2.TabIndex = 1
        Me.Guna2CirclePictureBox2.TabStop = False
        '
        'AdminProjectList_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1155, 740)
        Me.Controls.Add(Me.Guna2GroupBox2)
        Me.Controls.Add(Me.cboDept)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.cboStatus)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.lblOnHold)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.lblDone)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.lblOnGoing)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.lblNotStarted)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.cboTSG_Support)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AdminProjectList_Form"
        Me.Text = "AdminProjectList_Form"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.Guna2GroupBox2.ResumeLayout(False)
        Me.Guna2GroupBox2.PerformLayout()
        CType(Me.Guna2CirclePictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2CirclePictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents txtToken As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtDescr As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTitle As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtOwnersEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtOwner As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpDue As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents txtDept As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtMemEmails As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtMember As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtSupport As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cboTokenStat As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents cboStat As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents dtpStartDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label15 As Label
    Friend WithEvents cboTSG_Support As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblCount As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblNotStarted As Label
    Friend WithEvents lblOnGoing As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents lblDone As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents lblOnHold As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents cboStatus As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents cboDept As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Guna2GroupBox2 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Guna2CirclePictureBox3 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Guna2CirclePictureBox2 As Guna.UI2.WinForms.Guna2CirclePictureBox
End Class
