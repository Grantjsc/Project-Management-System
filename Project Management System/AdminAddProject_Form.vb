Public Class AdminAddProject_Form
    Private Sub txtToken_KeyUp(sender As Object, e As KeyEventArgs) Handles txtToken.KeyUp
        If e.KeyCode = Keys.Enter Then
            txtTSGSupport.Focus()
        End If
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        CheckToken()
    End Sub
End Class