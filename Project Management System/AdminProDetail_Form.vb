Public Class AdminProDetail_Form
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        AdminProDetails_Form_Update()
    End Sub

    Private Sub AdminProDetail_Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        AdminProDetails_Form_Populate()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        'AdminProjectList_ShowTask()
        'Task_Form.ShowDialog()

        Activity_Show()
        Highligh_Activity()
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
End Class