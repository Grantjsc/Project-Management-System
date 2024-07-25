Public Class Main_Form
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Click_HomeButton()
    End Sub

    Private Sub btnMyReq_Click(sender As Object, e As EventArgs) Handles btnMyReq.Click
        Click_MyRequestButton()
    End Sub

    Private Sub btnRequest_Click(sender As Object, e As EventArgs) Handles btnRequest.Click
        Click_RequestButton()
    End Sub

    Private Sub btnLogOff_Click(sender As Object, e As EventArgs) Handles btnLogOff.Click
        Me.Close()
        Load_LogInForm()
    End Sub

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        Click_AdminButton()
    End Sub

End Class