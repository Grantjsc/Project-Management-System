Public Class MyRequest_Form
    Private Sub MyRequest_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Show_MyRequestData()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        MyRequest_cell2click()
        Task_Form.ShowDialog()
    End Sub

    Private Sub txtSearch_Enter(sender As Object, e As EventArgs) Handles txtSearch.Enter
        If txtSearch.Text = "Search Project" Then

            txtSearch.Text = ""
            txtSearch.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtSearch_Leave(sender As Object, e As EventArgs) Handles txtSearch.Leave
        If txtSearch.Text = "" Then

            txtSearch.Text = "Search Project"
            txtSearch.ForeColor = Color.FromArgb(125, 137, 149)
        End If
    End Sub

    Private Sub txtSearch_KeyUp(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyUp
        If e.KeyCode = Keys.Enter Then

        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        MyRequest_TextSearch()
    End Sub

    Private Sub btmBrowse_Click(sender As Object, e As EventArgs) Handles btmBrowse.Click
        FolderBrowserDialog1.Description = "Select download location"
        FolderBrowserDialog1.ShowDialog()
        txtLocation.Text = FolderBrowserDialog1.SelectedPath.ToString
    End Sub

    Private Sub btnDownload_Click(sender As Object, e As EventArgs) Handles btnDownload.Click
        If txtFileName.Text = "" Then
            MsgBox("There is no A3 provided for this project.", MsgBoxStyle.Critical)
        ElseIf txtLocation.Text = "" Then
            MsgBox("Please choose a download location.", MsgBoxStyle.Critical)
        Else
            MyRequest_DownloadA3()
            MsgBox("File has been downloaded successfully!")
            txtLocation.Clear()
        End If
    End Sub

    Private Sub DataGridView1_CellStateChanged(sender As Object, e As DataGridViewCellStateChangedEventArgs) Handles DataGridView1.CellStateChanged
        MyRequest_Populate()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        AdminDLA3_Form.Admin_UpdateA3 = False
        UpdateA3_Form.ShowDialog()
    End Sub

End Class