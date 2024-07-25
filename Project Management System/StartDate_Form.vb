Public Class StartDate_Form
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'MsgBox("Please coordinate with TSG if you have concerns about your project timeline.", MessageBoxIcon.Information)
        Me.Close()
        Click_MyRequestButton()
    End Sub

    Private Sub btnOkay_Click(sender As Object, e As EventArgs) Handles btnOkay.Click
        'Token_Form.ShowDialog()
        Home_Form.Close()
        MyRequest_Form.Close()
        Admin_Form.Close()

        With Token_Form
            .TopLevel = False
            Main_Form.Panel.Controls.Add(Token_Form)
            .WindowState = FormWindowState.Maximized
            .BringToFront()
            .Show()
            Main_Form.btnHome.BackColor = Color.Transparent
            Main_Form.btnMyReq.BackColor = Color.Transparent
            Main_Form.btnRequest.BackColor = Color.Orange
            Main_Form.btnAdmin.BackColor = Color.Transparent
        End With
    End Sub
End Class