Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.WindowState = FormWindowState.Maximized
        Bounds = Screen.PrimaryScreen.WorkingArea

        'User = "Grant Jonathan Catapang"
        Load_LogInForm()
        'Load_MainForm()
    End Sub
End Class
