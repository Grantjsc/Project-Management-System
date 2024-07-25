Public Class SignUp_Form
    Private Sub SignUp_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PanelSignUp.BackColor = Color.FromArgb(180, 0, 0, 0)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Load_LogInForm()
        Me.Close()
    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        Check_UserName_Duplicate()
    End Sub

    Private Sub txtFirstName_Enter(sender As Object, e As EventArgs) Handles txtFirstName.Enter
        If txtFirstName.Text = "First name" Then

            txtFirstName.Text = ""
            txtFirstName.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtFirstName_KeyUp(sender As Object, e As KeyEventArgs) Handles txtFirstName.KeyUp
        If e.KeyCode = Keys.Enter Then
            txtLastName.Focus()
        End If
    End Sub

    Private Sub txtFirstName_Leave(sender As Object, e As EventArgs) Handles txtFirstName.Leave
        If txtFirstName.Text = "" Then

            txtFirstName.Text = "First name"
            txtFirstName.ForeColor = Color.FromArgb(87, 96, 111)
        End If
    End Sub

    Private Sub txtLastName_Enter(sender As Object, e As EventArgs) Handles txtLastName.Enter
        If txtLastName.Text = "Last name" Then

            txtLastName.Text = ""
            txtLastName.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtLastName_KeyUp(sender As Object, e As KeyEventArgs) Handles txtLastName.KeyUp
        If e.KeyCode = Keys.Enter Then
            txtUsername.Focus()
        End If
    End Sub

    Private Sub txtLastName_Leave(sender As Object, e As EventArgs) Handles txtLastName.Leave
        If txtLastName.Text = "" Then

            txtLastName.Text = "Last name"
            txtLastName.ForeColor = Color.FromArgb(87, 96, 111)
        End If
    End Sub

    Private Sub txtLFEmail_Enter(sender As Object, e As EventArgs) Handles txtLFEmail.Enter
        If txtLFEmail.Text = "Littelfuse email" Then

            txtLFEmail.Text = ""
            txtLFEmail.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtLFEmail_KeyUp(sender As Object, e As KeyEventArgs) Handles txtLFEmail.KeyUp
        If e.KeyCode = Keys.Enter Then
            txtSignUpPass.Focus()
        End If
    End Sub

    Private Sub txtLFEmail_Leave(sender As Object, e As EventArgs) Handles txtLFEmail.Leave
        If txtLFEmail.Text = "" Then

            txtLFEmail.Text = "Littelfuse email"
            txtLFEmail.ForeColor = Color.FromArgb(87, 96, 111)
        End If
    End Sub

    Private Sub txtSignUpPass_Enter(sender As Object, e As EventArgs) Handles txtSignUpPass.Enter
        If txtSignUpPass.Text = "Password" Then

            txtSignUpPass.Text = ""
            txtSignUpPass.PasswordChar = "*"
            txtSignUpPass.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtSignUpPass_KeyUp(sender As Object, e As KeyEventArgs) Handles txtSignUpPass.KeyUp
        If e.KeyCode = Keys.Enter Then
            txtConfirmPass.Focus()
        End If
    End Sub

    Private Sub txtSignUpPass_Leave(sender As Object, e As EventArgs) Handles txtSignUpPass.Leave
        If txtSignUpPass.Text = "" Then

            txtSignUpPass.Text = "Password"
            txtSignUpPass.PasswordChar = ""
            txtSignUpPass.ForeColor = Color.FromArgb(87, 96, 111)
        End If
    End Sub

    Private Sub txtConfirmPass_Enter(sender As Object, e As EventArgs) Handles txtConfirmPass.Enter
        If txtConfirmPass.Text = "Confirm Password" Then

            txtConfirmPass.Text = ""
            txtConfirmPass.PasswordChar = "*"
            txtConfirmPass.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtConfirmPass_KeyUp(sender As Object, e As KeyEventArgs) Handles txtConfirmPass.KeyUp
        If e.KeyCode = Keys.Enter Then
            Check_UserName_Duplicate()
        End If
    End Sub

    Private Sub txtConfirmPass_Leave(sender As Object, e As EventArgs) Handles txtConfirmPass.Leave
        If txtConfirmPass.Text = "" Then

            txtConfirmPass.Text = "Confirm Password"
            txtConfirmPass.PasswordChar = ""
            txtConfirmPass.ForeColor = Color.FromArgb(87, 96, 111)
        End If
    End Sub

    Private Sub txtUsername_Enter(sender As Object, e As EventArgs) Handles txtUsername.Enter
        If txtUsername.Text = "User name" Then

            txtUsername.Text = ""
            txtUsername.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtUsername_KeyUp(sender As Object, e As KeyEventArgs) Handles txtUsername.KeyUp
        If e.KeyCode = Keys.Enter Then
            Check_UserNameKeyUp()
        End If
    End Sub

    Private Sub txtUsername_Leave(sender As Object, e As EventArgs) Handles txtUsername.Leave
        If txtUsername.Text = "" Then

            txtUsername.Text = "User name"
            txtUsername.ForeColor = Color.FromArgb(87, 96, 111)
        End If
    End Sub
End Class