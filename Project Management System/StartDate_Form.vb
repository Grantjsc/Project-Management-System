Public Class StartDate_Form
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'MsgBox("Please coordinate with TSG if you have concerns about your project timeline.", MessageBoxIcon.Information)
        Me.Close()
        Click_MyRequestButton()
        Highligh_MyRequest_NoData()
    End Sub

    Private Sub btnOkay_Click(sender As Object, e As EventArgs) Handles btnOkay.Click
        ''Token_Form.ShowDialog()
        'Home_Form.Close()
        'MyRequest_Form.Close()
        'Admin_Form.Close()
        'Me.Close()

        'With Token_Form
        '    .TopLevel = False
        '    Main_Form.Panel.Controls.Add(Token_Form)
        '    .WindowState = FormWindowState.Maximized
        '    .BringToFront()
        '    .Show()
        '    Main_Form.btnHome.BackColor = Color.Transparent
        '    Main_Form.btnMyReq.BackColor = Color.Transparent
        '    Main_Form.btnRequest.BackColor = Color.Orange
        '    Main_Form.btnAdmin.BackColor = Color.Transparent
        'End With

        '=====< New Flow >====
        MyReq_SearchToken()
        MyReq_Get_ProjectDetails()
    End Sub

    Private Sub StartDate_Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Get_TSG_Support_Due()
    End Sub

    Private Sub DataGridView1_CellStateChanged(sender As Object, e As DataGridViewCellStateChangedEventArgs) Handles DataGridView1.CellStateChanged
        StartDate_Populate()
    End Sub
End Class