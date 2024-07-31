Public Class Request_Form
    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        If dtpCompletion.Value <= dtpStartDate.Value Then
            MsgBox("Please select another due date! It overlaps with the last project due date.", MsgBoxStyle.Critical)
        Else

            If Not String.IsNullOrEmpty(txtA3name.Text) Then
                SaveA3()
            End If

            Update_ProjectDetails()
        End If

    End Sub

    Private Sub Request_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtManagerEmail_KeyUp(sender As Object, e As KeyEventArgs) Handles txtManagerEmail.KeyUp
        If e.KeyCode = Keys.Enter Then
            txtMember.Focus()
        End If
    End Sub

    Private Sub txtDept_KeyUp(sender As Object, e As KeyEventArgs) Handles txtDept.KeyUp
        If e.KeyCode = Keys.Enter Then
            dtpCompletion.Focus()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        Click_MyRequestButton()
    End Sub

    Private Sub btmBrowse_Click(sender As Object, e As EventArgs) Handles btmBrowse.Click
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.ShowDialog()
        txtA3name.Text = OpenFileDialog1.FileName
    End Sub
End Class