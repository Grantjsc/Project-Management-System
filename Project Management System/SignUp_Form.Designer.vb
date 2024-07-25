<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SignUp_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SignUp_Form))
        Me.PanelSignUp = New System.Windows.Forms.Panel()
        Me.txtUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtConfirmPass = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtLastName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtLFEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnSignUp = New Guna.UI2.WinForms.Guna2Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSignUpPass = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtFirstName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PanelSignUp.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelSignUp
        '
        Me.PanelSignUp.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PanelSignUp.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PanelSignUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PanelSignUp.Controls.Add(Me.txtUsername)
        Me.PanelSignUp.Controls.Add(Me.btnCancel)
        Me.PanelSignUp.Controls.Add(Me.PictureBox1)
        Me.PanelSignUp.Controls.Add(Me.txtConfirmPass)
        Me.PanelSignUp.Controls.Add(Me.txtLastName)
        Me.PanelSignUp.Controls.Add(Me.txtLFEmail)
        Me.PanelSignUp.Controls.Add(Me.btnSignUp)
        Me.PanelSignUp.Controls.Add(Me.Label3)
        Me.PanelSignUp.Controls.Add(Me.txtSignUpPass)
        Me.PanelSignUp.Controls.Add(Me.txtFirstName)
        Me.PanelSignUp.Location = New System.Drawing.Point(652, 76)
        Me.PanelSignUp.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelSignUp.Name = "PanelSignUp"
        Me.PanelSignUp.Size = New System.Drawing.Size(590, 835)
        Me.PanelSignUp.TabIndex = 4
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.Transparent
        Me.txtUsername.BorderRadius = 15
        Me.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsername.DefaultText = "User name"
        Me.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsername.IconLeftOffset = New System.Drawing.Point(10, 0)
        Me.txtUsername.Location = New System.Drawing.Point(22, 437)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsername.PlaceholderText = ""
        Me.txtUsername.SelectedText = ""
        Me.txtUsername.Size = New System.Drawing.Size(542, 58)
        Me.txtUsername.TabIndex = 11
        Me.txtUsername.TextOffset = New System.Drawing.Point(10, 0)
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.BorderColor = System.Drawing.Color.Transparent
        Me.btnCancel.BorderRadius = 18
        Me.btnCancel.BorderThickness = 3
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCancel.FillColor = System.Drawing.Color.Transparent
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.HoverState.BorderColor = System.Drawing.Color.Transparent
        Me.btnCancel.HoverState.CustomBorderColor = System.Drawing.Color.Transparent
        Me.btnCancel.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.btnCancel.HoverState.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCancel.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnCancel.Location = New System.Drawing.Point(316, 733)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.PressedColor = System.Drawing.Color.Transparent
        Me.btnCancel.ShadowDecoration.BorderRadius = 0
        Me.btnCancel.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCancel.ShadowDecoration.Depth = 0
        Me.btnCancel.ShadowDecoration.Enabled = True
        Me.btnCancel.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(8)
        Me.btnCancel.Size = New System.Drawing.Size(180, 53)
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.Text = "Cancel"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(171, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(263, 250)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'txtConfirmPass
        '
        Me.txtConfirmPass.BackColor = System.Drawing.Color.Transparent
        Me.txtConfirmPass.BorderRadius = 15
        Me.txtConfirmPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConfirmPass.DefaultText = "Confirm Password"
        Me.txtConfirmPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtConfirmPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtConfirmPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtConfirmPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtConfirmPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtConfirmPass.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmPass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.txtConfirmPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtConfirmPass.IconLeft = CType(resources.GetObject("txtConfirmPass.IconLeft"), System.Drawing.Image)
        Me.txtConfirmPass.IconLeftOffset = New System.Drawing.Point(10, 0)
        Me.txtConfirmPass.Location = New System.Drawing.Point(22, 641)
        Me.txtConfirmPass.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txtConfirmPass.Name = "txtConfirmPass"
        Me.txtConfirmPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtConfirmPass.PlaceholderText = ""
        Me.txtConfirmPass.SelectedText = ""
        Me.txtConfirmPass.Size = New System.Drawing.Size(542, 58)
        Me.txtConfirmPass.TabIndex = 8
        Me.txtConfirmPass.TextOffset = New System.Drawing.Point(10, 0)
        '
        'txtLastName
        '
        Me.txtLastName.BackColor = System.Drawing.Color.Transparent
        Me.txtLastName.BorderRadius = 15
        Me.txtLastName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLastName.DefaultText = "Last name"
        Me.txtLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLastName.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.txtLastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLastName.IconLeftOffset = New System.Drawing.Point(10, 0)
        Me.txtLastName.Location = New System.Drawing.Point(302, 370)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLastName.PlaceholderText = ""
        Me.txtLastName.SelectedText = ""
        Me.txtLastName.Size = New System.Drawing.Size(262, 58)
        Me.txtLastName.TabIndex = 7
        Me.txtLastName.TextOffset = New System.Drawing.Point(10, 0)
        '
        'txtLFEmail
        '
        Me.txtLFEmail.BackColor = System.Drawing.Color.Transparent
        Me.txtLFEmail.BorderRadius = 15
        Me.txtLFEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLFEmail.DefaultText = "Littelfuse email"
        Me.txtLFEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtLFEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtLFEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLFEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLFEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLFEmail.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLFEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.txtLFEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLFEmail.IconLeft = CType(resources.GetObject("txtLFEmail.IconLeft"), System.Drawing.Image)
        Me.txtLFEmail.IconLeftOffset = New System.Drawing.Point(10, 0)
        Me.txtLFEmail.Location = New System.Drawing.Point(22, 505)
        Me.txtLFEmail.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txtLFEmail.Name = "txtLFEmail"
        Me.txtLFEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLFEmail.PlaceholderText = ""
        Me.txtLFEmail.SelectedText = ""
        Me.txtLFEmail.Size = New System.Drawing.Size(542, 58)
        Me.txtLFEmail.TabIndex = 6
        Me.txtLFEmail.TextOffset = New System.Drawing.Point(10, 0)
        '
        'btnSignUp
        '
        Me.btnSignUp.BackColor = System.Drawing.Color.Transparent
        Me.btnSignUp.BorderColor = System.Drawing.Color.Transparent
        Me.btnSignUp.BorderRadius = 18
        Me.btnSignUp.BorderThickness = 3
        Me.btnSignUp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSignUp.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSignUp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSignUp.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSignUp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSignUp.FillColor = System.Drawing.Color.Transparent
        Me.btnSignUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignUp.ForeColor = System.Drawing.Color.White
        Me.btnSignUp.HoverState.BorderColor = System.Drawing.Color.Transparent
        Me.btnSignUp.HoverState.CustomBorderColor = System.Drawing.Color.Transparent
        Me.btnSignUp.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.btnSignUp.HoverState.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignUp.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSignUp.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnSignUp.Location = New System.Drawing.Point(109, 733)
        Me.btnSignUp.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSignUp.Name = "btnSignUp"
        Me.btnSignUp.PressedColor = System.Drawing.Color.Transparent
        Me.btnSignUp.ShadowDecoration.BorderRadius = 0
        Me.btnSignUp.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSignUp.ShadowDecoration.Depth = 0
        Me.btnSignUp.ShadowDecoration.Enabled = True
        Me.btnSignUp.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(8)
        Me.btnSignUp.Size = New System.Drawing.Size(180, 53)
        Me.btnSignUp.TabIndex = 0
        Me.btnSignUp.Text = "Sign Up"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Lucida Bright", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(168, 277)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(275, 72)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Sign Up"
        '
        'txtSignUpPass
        '
        Me.txtSignUpPass.BackColor = System.Drawing.Color.Transparent
        Me.txtSignUpPass.BorderRadius = 15
        Me.txtSignUpPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSignUpPass.DefaultText = "Password"
        Me.txtSignUpPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSignUpPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSignUpPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSignUpPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSignUpPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSignUpPass.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSignUpPass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.txtSignUpPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSignUpPass.IconLeft = CType(resources.GetObject("txtSignUpPass.IconLeft"), System.Drawing.Image)
        Me.txtSignUpPass.IconLeftOffset = New System.Drawing.Point(10, 0)
        Me.txtSignUpPass.Location = New System.Drawing.Point(22, 573)
        Me.txtSignUpPass.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txtSignUpPass.Name = "txtSignUpPass"
        Me.txtSignUpPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSignUpPass.PlaceholderText = ""
        Me.txtSignUpPass.SelectedText = ""
        Me.txtSignUpPass.Size = New System.Drawing.Size(542, 58)
        Me.txtSignUpPass.TabIndex = 2
        Me.txtSignUpPass.TextOffset = New System.Drawing.Point(10, 0)
        '
        'txtFirstName
        '
        Me.txtFirstName.BackColor = System.Drawing.Color.Transparent
        Me.txtFirstName.BorderRadius = 15
        Me.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFirstName.DefaultText = "First name"
        Me.txtFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFirstName.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.txtFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFirstName.IconLeftOffset = New System.Drawing.Point(10, 0)
        Me.txtFirstName.Location = New System.Drawing.Point(22, 370)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFirstName.PlaceholderText = ""
        Me.txtFirstName.SelectedText = ""
        Me.txtFirstName.Size = New System.Drawing.Size(274, 58)
        Me.txtFirstName.TabIndex = 1
        Me.txtFirstName.TextOffset = New System.Drawing.Point(10, 0)
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(12, 399)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(612, 221)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        '
        'SignUp_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1264, 985)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PanelSignUp)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SignUp_Form"
        Me.Opacity = 0.4R
        Me.Text = "SignUp_Form"
        Me.TransparencyKey = System.Drawing.Color.White
        Me.PanelSignUp.ResumeLayout(False)
        Me.PanelSignUp.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelSignUp As Panel
    Friend WithEvents btnSignUp As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSignUpPass As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtFirstName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtLFEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtLastName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtConfirmPass As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents txtUsername As Guna.UI2.WinForms.Guna2TextBox
End Class
