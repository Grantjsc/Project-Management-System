Imports Org.BouncyCastle.Asn1.Cmp

Public Class AdminProDetail_Form
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        AdminProDetails_Form_Update()

        Dim selectedText As String = AdminProjectList_Form.cboStatus.Text

        If AdminProjectList_Form.cboStatus.Items.Contains(selectedText) Then
            AdminProjectList_Form.cboStatus.SelectedItem = selectedText
            Call AdminProjectList_Form.cboStatus_SelectedValueChanged(AdminProjectList_Form.cboStatus, EventArgs.Empty)
        End If

    End Sub

    Private Sub AdminProDetail_Form_Load(sender As Object, e As EventArgs) Handles Me.Load

        cboCategory.Items.Clear()
        Get_CategoryList()

        AdminProDetails_Form_Populate()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        'AdminProjectList_ShowTask()
        'Task_Form.ShowDialog()

        Activity_Show()
        'Highligh_Activity()
        'Activity_Form.ShowDialog()

        Me.Hide()

        Admin_Form.btnAddProject.Enabled = False
        Admin_Form.btnList.Enabled = False
        Admin_Form.btnDLA3.Enabled = False
        Admin_Form.btnProdSupport.Enabled = False
        Admin_Form.btnCancel.Enabled = False

        Main_Form.btnHome.Enabled = False
        Main_Form.btnAdmin.Enabled = False

        With Activity_Form
            .TopLevel = False
            Admin_Form.Panel_Admin.Controls.Add(Activity_Form)
            .WindowState = FormWindowState.Maximized
            .BringToFront()
            .Show()
        End With

    End Sub

    Private Sub cboDepartments_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboDepartments.SelectedValueChanged
        txtDept.Text = cboDepartments.Text
    End Sub

    Private Sub txtPercent_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPercent.KeyPress
        Dim allowedChars As String = "0123456789."

        If Not Char.IsControl(e.KeyChar) AndAlso Not allowedChars.Contains(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub cboCategory_MouseClick(sender As Object, e As MouseEventArgs) Handles cboCategory.MouseClick
        cboCategory.Items.Clear()
        Get_CategoryList()
    End Sub

    Private Sub dtpStartDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpStartDate.ValueChanged
        dtpStartDate.Format = DateTimePickerFormat.Short
    End Sub

    Private Sub dtpDue_ValueChanged(sender As Object, e As EventArgs) Handles dtpDue.ValueChanged
        dtpDue.Format = DateTimePickerFormat.Short
    End Sub
End Class