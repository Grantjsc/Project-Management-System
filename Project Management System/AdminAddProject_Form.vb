Public Class AdminAddProject_Form
    Private Sub txtToken_KeyUp(sender As Object, e As KeyEventArgs) Handles txtToken.KeyUp
        If e.KeyCode = Keys.Enter Then
            cboTSG_Support.Focus()
        End If
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        CheckToken()
    End Sub

    Private Sub txtTSGSupport_KeyUp(sender As Object, e As KeyEventArgs) Handles txtTSGSupport.KeyUp
        If e.KeyCode = Keys.Enter Then
            txtEmail.Focus()
        End If
    End Sub

    Private Sub AdminAddProject_Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetUniqueToken()
        dtpCompletion.Text = Date.Now
    End Sub

    Private Sub cboTSG_Support_MouseClick(sender As Object, e As MouseEventArgs) Handles cboTSG_Support.MouseClick
        cboTSG_Support.Items.Clear()
        Get_Support_AddminAdd()
        cboTSG_Support.Items.Remove("All")
    End Sub

    Private Sub cboTSG_Support_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTSG_Support.SelectedIndexChanged
        'If Not cboTSG_Support.Text = Nothing Then
        '    Get_Support_AddminAdd()
        'End If
    End Sub

    Private Sub cboTSG_Support_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboTSG_Support.SelectedValueChanged
        AddProject_GetSupport_Last_Date()
    End Sub
End Class