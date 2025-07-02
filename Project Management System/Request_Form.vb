Imports System.IO

Public Class Request_Form
    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        If dtpCompletion.Value <= dtpStartDate.Value Then
            MsgBox("Please select another due date! It overlaps with the last project due date.", MsgBoxStyle.Critical)
        Else

            'If Not String.IsNullOrEmpty(txtA3name.Text) Then
            '    SaveA3()
            'End If

            Update_ProjectDetails()
        End If

    End Sub

    Private Sub Request_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'dtpCompletion.Text = Date.Now
        'dtpCompletion.Value = dtpStartDate.Value.AddDays(14)
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
        Highligh_MyRequest_NoData()
    End Sub

    Private Sub btmBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        'OpenFileDialog1.FileName = ""
        'OpenFileDialog1.ShowDialog()
        'txtA3name.Text = OpenFileDialog1.FileName

        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            ' Get the selected file path
            Dim filePath As String = OpenFileDialog1.FileName
            Dim fileInfo As New FileInfo(filePath)

            Dim maxFileSize As Long = 2.5 * 1024 * 1024


            If fileInfo.Length > maxFileSize Then
                MsgBox("The file size exceeds the 2.5 MB limit. Please select a smaller file.", vbCritical)
            Else

                txtA3name.Text = filePath
            End If
        End If
    End Sub

    Private Sub cboDepartments_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDepartments.SelectedIndexChanged
        txtDept.Text = cboDepartments.Text
    End Sub
End Class