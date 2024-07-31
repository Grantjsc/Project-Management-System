Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.WindowState = FormWindowState.Maximized
        Bounds = Screen.PrimaryScreen.WorkingArea

        'User = "Grant Jonathan Catapang"
        Load_LogInForm()
        'Load_MainForm()
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Dbconnection.State = ConnectionState.Open Then
            Dbconnection.Close()
        End If
        Application.ExitThread()
    End Sub
End Class
