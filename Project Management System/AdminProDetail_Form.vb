Public Class AdminProDetail_Form
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        AdminProDetails_Form_Update()
    End Sub

    Private Sub AdminProDetail_Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        AdminProDetails_Form_Populate()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        AdminProjectList_ShowTask()
        Task_Form.ShowDialog()
    End Sub
End Class