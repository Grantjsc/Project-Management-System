Public Class Task_Form
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'txtTask1.Clear()
        'txtTask1_Owner.Clear()
        'DateTimePicker1.Format = DateTimePickerFormat.Custom
        'DateTimePicker1.CustomFormat = " "

        'txtTask2.Clear()
        'txtTask2_Owner.Clear()
        'DateTimePicker2.Format = DateTimePickerFormat.Custom
        'DateTimePicker2.CustomFormat = " "

        'txtTask3.Clear()
        'txtTask3_Owner.Clear()
        'DateTimePicker3.Format = DateTimePickerFormat.Custom
        'DateTimePicker3.CustomFormat = " "

        'txtTask4.Clear()
        'txtTask4_Owner.Clear()
        'DateTimePicker4.Format = DateTimePickerFormat.Custom
        'DateTimePicker4.CustomFormat = " "

        'txtTask5.Clear()
        'txtTask5_Owner.Clear()
        'DateTimePicker5.Format = DateTimePickerFormat.Custom
        'DateTimePicker5.CustomFormat = " "
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Update_ProjectTask()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        DateTimePicker1.Format = DateTimePickerFormat.Short
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        DateTimePicker2.Format = DateTimePickerFormat.Short
    End Sub

    Private Sub DateTimePicker3_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker3.ValueChanged
        DateTimePicker3.Format = DateTimePickerFormat.Short
    End Sub

    Private Sub DateTimePicker4_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker4.ValueChanged
        DateTimePicker4.Format = DateTimePickerFormat.Short
    End Sub

    Private Sub DateTimePicker5_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker5.ValueChanged
        DateTimePicker5.Format = DateTimePickerFormat.Short
    End Sub
End Class