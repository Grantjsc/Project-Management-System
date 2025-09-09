Public Class AdminCanceled_Form
    Private Sub AdminCanceled_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Show_AdminCanceledList()

        For Each col As DataGridViewColumn In DataGridView1.Columns
            col.SortMode = DataGridViewColumnSortMode.NotSortable
        Next
    End Sub

    Private Sub cboTSG_Support_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTSG_Support.SelectedIndexChanged

        'If Not cboTSG_Support.Text = Nothing Then
        '    Get_Support_AdminCanceled()
        'End If

        If cboTSG_Support.Text = "All" Then
            Show_AdminCanceledList()
        Else
            Show_SupportCanceledProjects()
        End If
    End Sub

    Private Sub cboTSG_Support_MouseClick(sender As Object, e As MouseEventArgs) Handles cboTSG_Support.MouseClick
        cboTSG_Support.Items.Clear()
        Get_Support_AdminCanceled()
    End Sub
End Class