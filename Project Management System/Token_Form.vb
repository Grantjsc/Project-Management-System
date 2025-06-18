Imports System.Net.Security

Public Class Token_Form
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        Click_MyRequestButton()
    End Sub

    Private Sub TextBox1_Enter(sender As Object, e As EventArgs) Handles TextBox1.Enter
        If TextBox1.Text = "" Then
            TextBox1.FillColor = Color.White
        End If
    End Sub

    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles TextBox1.Leave
        If TextBox1.Text = "" Then
            TextBox1.FillColor = Color.FromArgb(192, 255, 192)
        End If
    End Sub

    Private Sub TextBox1_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyUp
        ' Skip if a modifier key itself was released
        If e.KeyCode = Keys.ControlKey OrElse
           e.KeyCode = Keys.ShiftKey OrElse
            e.KeyCode = Keys.CapsLock OrElse
             e.KeyCode = Keys.Left OrElse
           e.KeyCode = Keys.Menu Then
            Exit Sub
        End If

        ' Only focus TextBox2 if:
        ' - Released key is NOT Backspace
        ' - No modifier keys are currently held down
        If e.KeyCode <> Keys.Back AndAlso
           (Control.ModifierKeys And (Keys.Control Or Keys.Shift Or Keys.Alt)) = 0 Then

            TextBox2.Focus()
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        '    ' Only focus TextBox2 if:
        '    ' - The pressed key is NOT Backspace
        '    ' - Ctrl is NOT held
        '    ' - Shift is NOT held
        '    If e.KeyChar <> ChrW(Keys.Back) AndAlso
        '       (Control.ModifierKeys And Keys.Control) <> Keys.Control AndAlso
        '       (Control.ModifierKeys And Keys.Shift) <> Keys.Shift Then

        '        TextBox2.Focus()
        '    End If
    End Sub

    '***************** TEXTBOX 2 *********************
    Private Sub TextBox2_Enter(sender As Object, e As EventArgs) Handles TextBox2.Enter
        If TextBox2.Text = "" Then
            TextBox2.FillColor = Color.White
        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        '' Check if Backspace was pressed
        'If e.KeyChar <> ChrW(Keys.Back) Then
        '    ' Only focus TextBox3 if neither Ctrl nor Shift is pressed
        '    If (Control.ModifierKeys And Keys.Control) <> Keys.Control AndAlso
        '       (Control.ModifierKeys And Keys.Shift) <> Keys.Shift Then
        '        TextBox3.Focus()
        '    End If
        'Else
        '    TextBox1.Focus()
        'End If
    End Sub

    Private Sub TextBox2_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyUp
        ' Ignore if a modifier key was released
        If e.KeyCode = Keys.ControlKey OrElse e.KeyCode = Keys.ShiftKey OrElse e.KeyCode = Keys.CapsLock OrElse e.KeyCode = Keys.Menu Then
            Exit Sub
        End If

        ' If Backspace was released
        If e.KeyCode = Keys.Back Then
            TextBox1.Focus()

            ' If Left Arrow was released
        ElseIf e.KeyCode = Keys.Left Then
            TextBox1.Focus()

            ' If Right Arrow was released
        ElseIf e.KeyCode = Keys.Right Then
            TextBox3.Focus()

            ' For other keys, only move focus if no Ctrl, Shift, or Alt is held down
        ElseIf (Control.ModifierKeys And (Keys.Control Or Keys.Shift Or Keys.Alt)) = 0 Then
            TextBox3.Focus()
        End If

    End Sub

    Private Sub TextBox2_Leave(sender As Object, e As EventArgs) Handles TextBox2.Leave
        If TextBox2.Text = "" Then
            TextBox2.FillColor = Color.FromArgb(192, 255, 192)
        End If
    End Sub

    '********************* TEXTBOX 3 ******************
    Private Sub TextBox3_Enter(sender As Object, e As EventArgs) Handles TextBox3.Enter
        If TextBox3.Text = "" Then
            TextBox3.FillColor = Color.White
        End If
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        '' Ignore if Ctrl or Shift is held
        'If (Control.ModifierKeys And Keys.Control) = Keys.Control OrElse
        '   (Control.ModifierKeys And Keys.Shift) = Keys.Shift Then
        '    Exit Sub
        'End If

        '' Handle Enter key
        'If e.KeyChar = ChrW(Keys.Enter) Then
        '    If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
        '        MsgBox("Please input your token", MsgBoxStyle.Critical)
        '        TextBox1.Clear()
        '        TextBox2.Clear()
        '        TextBox3.Clear()
        '        TextBox1.Focus()
        '    Else
        '        SearchToken()
        '        Get_ProjectDetails()
        '    End If
        'End If
    End Sub

    Private Sub TextBox3_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox3.KeyUp
        ' Move to TextBox2 ONLY if:
        ' - Backspace was pressed OR Left Arrow was pressed
        ' - No Ctrl, Shift, or Alt are currently held
        If (e.KeyCode = Keys.Back OrElse e.KeyCode = Keys.Left) Then
            If (Control.ModifierKeys And (Keys.Control Or Keys.Shift Or Keys.Alt)) = 0 Then
                TextBox2.Focus()
            End If
        End If

        ' Handle Enter key — ONLY if no modifiers are held
        If e.KeyCode = Keys.Enter Then
            If (Control.ModifierKeys And (Keys.Control Or Keys.Shift Or Keys.Alt)) = 0 Then
                If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
                    MsgBox("Please input your token", MsgBoxStyle.Critical)
                    TextBox1.Clear()
                    TextBox2.Clear()
                    TextBox3.Clear()
                    TextBox1.Focus()
                Else
                    SearchToken()
                    Get_ProjectDetails()
                End If
            End If
        End If

    End Sub

    Private Sub TextBox3_Leave(sender As Object, e As EventArgs) Handles TextBox3.Leave
        If TextBox3.Text = "" Then
            TextBox3.FillColor = Color.FromArgb(192, 255, 192)
        End If
    End Sub

End Class