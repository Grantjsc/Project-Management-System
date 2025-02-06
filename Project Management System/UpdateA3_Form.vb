Imports System.IO

Public Class UpdateA3_Form
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        AdminDLA3_Form.Admin_UpdateA3 = False
        Me.Close()
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
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

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If String.IsNullOrEmpty(txtA3name.Text) Then
            MsgBox("Please browse the file to update!", MsgBoxStyle.Critical)
        Else
            Dim DResult As DialogResult
            DResult = MsgBox("This action will overwrite the previous file." & vbCrLf & "Do you want to update A3?", MsgBoxStyle.YesNo)
            If DResult = DialogResult.Yes Then
                If AdminDLA3_Form.Admin_UpdateA3 = True Then
                    UpdateA3()
                    Show_A3List()

                    MsgBox("A3 is now updated!", MsgBoxStyle.Information)
                    Me.Close()
                Else
                    UpdateA3_ForUser()
                    Show_MyRequestData()

                    MsgBox("A3 is now updated!", MsgBoxStyle.Information)
                    Me.Close()
                End If
            End If
        End If
    End Sub

    Private Sub UpdateA3_Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtA3name.Clear()
    End Sub
End Class