<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Admin_Form
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
        Me.Panel_Admin = New System.Windows.Forms.Panel()
        Me.Guna2CustomGradientPanel2 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.btnDLA3 = New Guna.UI2.WinForms.Guna2Button()
        Me.btnList = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAddProject = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2CustomGradientPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel_Admin
        '
        Me.Panel_Admin.AutoScroll = True
        Me.Panel_Admin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Admin.Location = New System.Drawing.Point(109, 0)
        Me.Panel_Admin.Name = "Panel_Admin"
        Me.Panel_Admin.Size = New System.Drawing.Size(1155, 847)
        Me.Panel_Admin.TabIndex = 1
        '
        'Guna2CustomGradientPanel2
        '
        Me.Guna2CustomGradientPanel2.Controls.Add(Me.btnDLA3)
        Me.Guna2CustomGradientPanel2.Controls.Add(Me.btnList)
        Me.Guna2CustomGradientPanel2.Controls.Add(Me.btnAddProject)
        Me.Guna2CustomGradientPanel2.Controls.Add(Me.Guna2Button1)
        Me.Guna2CustomGradientPanel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2CustomGradientPanel2.FillColor = System.Drawing.Color.DarkGreen
        Me.Guna2CustomGradientPanel2.FillColor2 = System.Drawing.Color.DarkGreen
        Me.Guna2CustomGradientPanel2.FillColor3 = System.Drawing.Color.LimeGreen
        Me.Guna2CustomGradientPanel2.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.Guna2CustomGradientPanel2.Location = New System.Drawing.Point(0, 0)
        Me.Guna2CustomGradientPanel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2CustomGradientPanel2.Name = "Guna2CustomGradientPanel2"
        Me.Guna2CustomGradientPanel2.Size = New System.Drawing.Size(109, 847)
        Me.Guna2CustomGradientPanel2.TabIndex = 11
        '
        'btnDLA3
        '
        Me.btnDLA3.BackColor = System.Drawing.Color.Transparent
        Me.btnDLA3.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDLA3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnDLA3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDLA3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnDLA3.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDLA3.FillColor = System.Drawing.Color.Transparent
        Me.btnDLA3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDLA3.ForeColor = System.Drawing.Color.White
        Me.btnDLA3.HoverState.FillColor = System.Drawing.Color.Orange
        Me.btnDLA3.Location = New System.Drawing.Point(0, 171)
        Me.btnDLA3.Name = "btnDLA3"
        Me.btnDLA3.Size = New System.Drawing.Size(109, 56)
        Me.btnDLA3.TabIndex = 12
        Me.btnDLA3.Text = "Download A3"
        '
        'btnList
        '
        Me.btnList.BackColor = System.Drawing.Color.Transparent
        Me.btnList.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnList.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnList.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnList.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnList.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnList.FillColor = System.Drawing.Color.Transparent
        Me.btnList.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnList.ForeColor = System.Drawing.Color.White
        Me.btnList.HoverState.FillColor = System.Drawing.Color.Orange
        Me.btnList.Location = New System.Drawing.Point(0, 115)
        Me.btnList.Name = "btnList"
        Me.btnList.Size = New System.Drawing.Size(109, 56)
        Me.btnList.TabIndex = 11
        Me.btnList.Text = "Project List"
        '
        'btnAddProject
        '
        Me.btnAddProject.BackColor = System.Drawing.Color.Transparent
        Me.btnAddProject.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAddProject.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAddProject.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAddProject.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAddProject.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAddProject.FillColor = System.Drawing.Color.Transparent
        Me.btnAddProject.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddProject.ForeColor = System.Drawing.Color.White
        Me.btnAddProject.HoverState.FillColor = System.Drawing.Color.Orange
        Me.btnAddProject.Location = New System.Drawing.Point(0, 59)
        Me.btnAddProject.Name = "btnAddProject"
        Me.btnAddProject.Size = New System.Drawing.Size(109, 56)
        Me.btnAddProject.TabIndex = 9
        Me.btnAddProject.Text = "Add Project"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Button1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.FillColor = System.Drawing.Color.Orange
        Me.Guna2Button1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(109, 59)
        Me.Guna2Button1.TabIndex = 10
        '
        'Admin_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1264, 847)
        Me.Controls.Add(Me.Panel_Admin)
        Me.Controls.Add(Me.Guna2CustomGradientPanel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Admin_Form"
        Me.Text = "Admin_Form"
        Me.Guna2CustomGradientPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel_Admin As Panel
    Friend WithEvents Guna2CustomGradientPanel2 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents btnList As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAddProject As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDLA3 As Guna.UI2.WinForms.Guna2Button
End Class
