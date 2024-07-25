Public Class LogIn_Form
    Private Sub LogIn_Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Panel1.BackColor = Color.FromArgb(180, 0, 0, 0)
    End Sub

    Private Sub txtUser_Enter(sender As Object, e As EventArgs) Handles txtUser.Enter
        If txtUser.Text = "Username" Then

            txtUser.Text = ""
            txtUser.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtUser_Leave(sender As Object, e As EventArgs) Handles txtUser.Leave
        If txtUser.Text = "" Then

            txtUser.Text = "Username"
            txtUser.ForeColor = Color.FromArgb(87, 96, 111)
        End If
    End Sub

    Private Sub txtUser_KeyUp(sender As Object, e As KeyEventArgs) Handles txtUser.KeyUp
        If e.KeyCode = Keys.Enter Then
            txtPass.Focus()
        End If
    End Sub

    Private Sub txtPass_Enter(sender As Object, e As EventArgs) Handles txtPass.Enter
        If txtPass.Text = "Password" Then

            txtPass.Text = ""
            txtPass.PasswordChar = "*"
            txtPass.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtPass_Leave(sender As Object, e As EventArgs) Handles txtPass.Leave
        If txtPass.Text = "" Then

            txtPass.Text = "Password"
            txtPass.PasswordChar = ""
            txtPass.ForeColor = Color.FromArgb(87, 96, 111)
        End If
    End Sub

    Private Sub txtPass_KeyUp(sender As Object, e As KeyEventArgs) Handles txtPass.KeyUp
        If e.KeyCode = Keys.Enter Then
            Login()
        End If
    End Sub

    Private Sub chkShow_CheckedChanged(sender As Object, e As EventArgs) Handles chkShow.CheckedChanged
        If chkShow.Checked = True Then
            txtPass.PasswordChar = ""
        Else
            If txtPass.Text = "Password" Then

            Else
                txtPass.PasswordChar = "*"
            End If
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Login()
    End Sub

    Private Sub LinklblSignUp_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinklblSignUp.LinkClicked
        Load_SignUpForm()
    End Sub
End Class