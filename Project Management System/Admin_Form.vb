Public Class Admin_Form
    Private Sub btnAddProject_Click(sender As Object, e As EventArgs) Handles btnAddProject.Click
        Clicked_AddProject()
    End Sub

    Private Sub btnList_Click(sender As Object, e As EventArgs) Handles btnList.Click
        Clicked_ProjectList()
    End Sub

    Private Sub btnDLA3_Click(sender As Object, e As EventArgs) Handles btnDLA3.Click
        Clicked_DownloadA3()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Clicked_CancledProject()
    End Sub

    Private Sub btnProdSupport_Click(sender As Object, e As EventArgs) Handles btnProdSupport.Click
        Clicked_ProductionSupport()
    End Sub
End Class