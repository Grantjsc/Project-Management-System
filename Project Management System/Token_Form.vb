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
        If Not e.KeyCode = Keys.Back Then
            TextBox2.Focus()
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        'If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
        '    e.Handled = True
        'End If
    End Sub

    '***************** TEXTBOX 2 *********************
    Private Sub TextBox2_Enter(sender As Object, e As EventArgs) Handles TextBox2.Enter
        If TextBox2.Text = "" Then
            TextBox2.FillColor = Color.White
        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        'If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
        '    e.Handled = True
        'End If
    End Sub

    Private Sub TextBox2_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyUp
        If Not e.KeyCode = Keys.Back Then
            TextBox3.Focus()
        Else
            TextBox1.Focus()
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
        'If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
        '    e.Handled = True
        'End If
    End Sub

    Private Sub TextBox3_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox3.KeyUp
        If Not e.KeyCode = Keys.Back Then

        Else
            TextBox2.Focus()
        End If

        If e.KeyCode = Keys.Enter Then
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

    End Sub

    Private Sub TextBox3_Leave(sender As Object, e As EventArgs) Handles TextBox3.Leave
        If TextBox3.Text = "" Then
            TextBox3.FillColor = Color.FromArgb(192, 255, 192)
        End If
    End Sub

End Class