Public Class AdminCanceled_Form
    Private Sub AdminCanceled_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Show_AdminCanceledList()
    End Sub

    Private Sub cboTSG_Support_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTSG_Support.SelectedIndexChanged
        If cboTSG_Support.Text = "All" Then
            Show_AdminCanceledList()
        Else
            Show_SupportCanceledProjects()
        End If
    End Sub
End Class