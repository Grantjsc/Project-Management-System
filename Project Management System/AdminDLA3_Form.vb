Public Class AdminDLA3_Form
    Private Sub AdminDLA3_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Show_A3List()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        AdminDLA3_Populate()
    End Sub

    Private Sub DataGridView1_CellStateChanged(sender As Object, e As DataGridViewCellStateChangedEventArgs) Handles DataGridView1.CellStateChanged
        AdminDLA3_Populate()
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

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        AdminDLA3_txtSearch()
    End Sub

    Private Sub btmBrowse_Click(sender As Object, e As EventArgs) Handles btmBrowse.Click
        FolderBrowserDialog1.ShowDialog()
        txtLocation.Text = FolderBrowserDialog1.SelectedPath.ToString
    End Sub

    Private Sub btnDownload_Click(sender As Object, e As EventArgs) Handles btnDownload.Click
        If txtFileName.Text = "" Then
            MsgBox("There is no A3 provided for this project.", MsgBoxStyle.Critical)
        ElseIf txtLocation.Text = "" Then
            MsgBox("Please choose a download location.", MsgBoxStyle.Critical)
        Else
            DownloadA3()
            MsgBox("File has been downloaded successfully!")
            txtLocation.Clear()
        End If
    End Sub
End Class