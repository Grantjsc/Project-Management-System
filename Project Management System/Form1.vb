Imports System.Data.Common

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim secondaryMonitor = Screen.AllScreens.FirstOrDefault(Function(x) Not x.Primary)

        If secondaryMonitor IsNot Nothing Then
            ' Set the form's start position to manual
            Me.StartPosition = FormStartPosition.Manual
            ' Set the location of the form to the top-left corner of the secondary monitor
            Me.Location = secondaryMonitor.Bounds.Location
            Me.WindowState = FormWindowState.Maximized
            Me.Show()
        Else
            Me.WindowState = FormWindowState.Maximized
            'Bounds = Screen.PrimaryScreen.WorkingArea
        End If

        'User = "Grant Jonathan Catapang"
        Load_LogInForm()
        'Load_MainForm()
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'If Dbconnection.State = ConnectionState.Open Then
        '    Dbconnection.Close()
        'End If

        If SQLDbconnection.State = ConnectionState.Open Then
            SQLDbconnection.Close()
        End If
        Application.ExitThread()
    End Sub
End Class
