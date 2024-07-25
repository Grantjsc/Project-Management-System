Imports System.Data.OleDb
Imports System.Threading

Public Class AdminProjectList_Form
    Private Sub AdminProjectList_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Show_AdminProjectList()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        AdminProjectList_PopulateEdit()
    End Sub

    Private Sub DataGridView1_CellStateChanged(sender As Object, e As DataGridViewCellStateChangedEventArgs) Handles DataGridView1.CellStateChanged
        AdminProjectList_PopulateEdit()
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
        AdminProjetList_TextSearch()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        AdminProjectList_ShowTask()
        Task_Form.ShowDialog()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        AdminProjectList_UpdateDetails()
        'TaskTitleChanged()
    End Sub

    Private Sub dtpDue_ValueChanged(sender As Object, e As EventArgs) Handles dtpDue.ValueChanged
        dtpDue.Format = DateTimePickerFormat.Short
    End Sub

    Private Sub txtOwner_KeyUp(sender As Object, e As KeyEventArgs) Handles txtOwner.KeyUp
        If e.KeyCode = Keys.Enter Then
            txtOwnersEmail.Focus()
        End If
    End Sub

    Private Sub txtOwnersEmail_KeyUp(sender As Object, e As KeyEventArgs) Handles txtOwnersEmail.KeyUp
        If e.KeyCode = Keys.Enter Then
            txtMember.Focus()
        End If
    End Sub

    Private Sub txtDept_KeyUp(sender As Object, e As KeyEventArgs) Handles txtDept.KeyUp
        If e.KeyCode = Keys.Enter Then
            txtSupport.Focus()
        End If
    End Sub

    Private Sub dtpStartDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpStartDate.ValueChanged
        dtpStartDate.Format = DateTimePickerFormat.Short
    End Sub
End Class