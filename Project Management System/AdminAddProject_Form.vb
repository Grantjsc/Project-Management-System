Public Class AdminAddProject_Form
    Private Sub txtToken_KeyUp(sender As Object, e As KeyEventArgs) Handles txtToken.KeyUp
        If e.KeyCode = Keys.Enter Then
            txtTSGSupport.Focus()
        End If
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        CheckToken()
    End Sub

    Private Sub txtTSGSupport_KeyUp(sender As Object, e As KeyEventArgs) Handles txtTSGSupport.KeyUp
        If e.KeyCode = Keys.Enter Then
            txtEmail.Focus()
        End If
    End Sub
End Class