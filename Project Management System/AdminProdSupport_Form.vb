Public Class AdminProdSupport_Form

    Private Sub AdminProdSupport_Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        dtpStart.Format = DateTimePickerFormat.Custom
        dtpStart.CustomFormat = "hh:mm tt"  ' Or use "hh:mm tt" for 12-hour format
        dtpStart.ShowUpDown = True       ' Hides the calendar and shows up/down buttons

        dtpEnd.Format = DateTimePickerFormat.Custom
        dtpEnd.CustomFormat = "hh:mm tt"  ' Or use "hh:mm tt" for 12-hour format
        dtpEnd.ShowUpDown = True       ' Hides the calendar and shows up/down buttons

        Show_Addmin_ProdSuppor()

        dtpSupportDate.Value = Date.Now
    End Sub

    Private Sub cboName_MouseClick(sender As Object, e As MouseEventArgs) Handles cboName.MouseClick
        cboName.Items.Clear()
        Get_Support_Addmin_ProdSupport()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Add_ProdSupport_Action()
    End Sub
End Class