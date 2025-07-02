Imports System.Data.OleDb
Imports System.Threading

Public Class AdminProjectList_Form

    Public Load_Trig As Boolean = False
    Private Sub AdminProjectList_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Show_AdminProjectList()
        'Aadmin_Count_TotalPro()
        'HighlightDelayedProjects()

        Load_Trig = False

        Get_Support_AddminProject()

        cboTSG_Support.SelectedItem = "All"
        cboDept.SelectedItem = "All"

        Load_Trig = True

        cboStatus.SelectedItem = "Open Status"
    End Sub

    'Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
    '    'AdminProjectList_PopulateEdit()
    '    'AdminProDetails_Form_Populate()
    '    AdminProDetail_Form.ShowDialog()
    'End Sub

    Private Sub DataGridView1_CellStateChanged(sender As Object, e As DataGridViewCellStateChangedEventArgs) Handles DataGridView1.CellStateChanged
        'AdminProjectList_PopulateEdit()
    End Sub

    Private Sub txtSearch_Enter(sender As Object, e As EventArgs) Handles txtSearch.Enter
        If txtSearch.Text = "Search Project" Then

            txtSearch.Text = ""
            txtSearch.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtSearch_Leave(sender As Object, e As EventArgs) Handles txtSearch.Leave
        If txtSearch.Text = "" Then

            txtSearch.Text = "Search Project"
            txtSearch.ForeColor = Color.FromArgb(125, 137, 149)
        End If
    End Sub

    Private Sub txtSearch_KeyUp(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyUp
        If e.KeyCode = Keys.Enter Then

        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        AdminProjetList_TextSearch()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        'AdminProjectList_PopulateEdit()
        'AdminProDetails_Form_Populate()
        AdminProDetail_Form.ShowDialog()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        AdminProjectList_UpdateDetails()
        'TaskTitleChanged()
    End Sub

    Private Sub dtpDue_ValueChanged(sender As Object, e As EventArgs) Handles dtpDue.ValueChanged
        dtpDue.Format = DateTimePickerFormat.Short
    End Sub

    Private Sub txtOwner_KeyUp(sender As Object, e As KeyEventArgs) Handles txtOwner.KeyUp
        If e.KeyCode = Keys.Enter Then
            txtOwnersEmail.Focus()
        End If
    End Sub

    Private Sub txtOwnersEmail_KeyUp(sender As Object, e As KeyEventArgs) Handles txtOwnersEmail.KeyUp
        If e.KeyCode = Keys.Enter Then
            txtMember.Focus()
        End If
    End Sub

    Private Sub txtDept_KeyUp(sender As Object, e As KeyEventArgs) Handles txtDept.KeyUp
        If e.KeyCode = Keys.Enter Then
            txtSupport.Focus()
        End If
    End Sub

    Private Sub dtpStartDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpStartDate.ValueChanged
        dtpStartDate.Format = DateTimePickerFormat.Short
    End Sub

    Private Sub cboTSG_Support_MouseClick(sender As Object, e As MouseEventArgs) Handles cboTSG_Support.MouseClick

        cboTSG_Support.Items.Clear()
        Get_Support_AddminProject()
    End Sub

    Private Sub cboTSG_Support_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboTSG_Support.SelectedValueChanged

        If Not Load_Trig = False Then

            If Not String.IsNullOrEmpty(cboTSG_Support.Text) And cboStatus.Text = "" And cboDept.Text = "" Then
                '1) ===< Support only >===
                Show_SupportProjects()
                Admin_Count_Projects_Support()
            End If

            If Not String.IsNullOrEmpty(cboTSG_Support.Text) AndAlso Not String.IsNullOrEmpty(cboStatus.Text) AndAlso cboDept.Text = "" Then
                '2) ===< Support and Status only >===
                Show_Projects_ByTwoCbo_Function(cboTSG_Support.Text, "TSG_Support", cboStatus.Text, "Status")
                Admin_Count_Projects_ByTwoCbo_Funtion(cboTSG_Support.Text, "TSG_Support", cboStatus.Text, "Status")
            End If

            If Not String.IsNullOrEmpty(cboTSG_Support.Text) AndAlso cboStatus.Text = "" AndAlso Not String.IsNullOrEmpty(cboDept.Text) Then
                '3) ===< Support and Department only >===
                Show_Projects_ByTwoCbo_Function(cboTSG_Support.Text, "TSG_Support", cboDept.Text, "Department")
                Admin_Count_Projects_ByTwoCbo_Funtion(cboTSG_Support.Text, "TSG_Support", cboDept.Text, "Department")
            End If

            If Not String.IsNullOrEmpty(cboTSG_Support.Text) AndAlso Not String.IsNullOrEmpty(cboStatus.Text) AndAlso Not String.IsNullOrEmpty(cboDept.Text) Then
                '4) ===< Support Status Department >===
                Show_Projects_ByThreeCbo_Function(cboTSG_Support.Text, "TSG_Support", cboStatus.Text, "Status", cboDept.Text, "Department")
                Admin_Count_Projects_ByThreeCbo_Funtion(cboTSG_Support.Text, "TSG_Support", cboStatus.Text, "Status", cboDept.Text, "Department")
            End If

            If cboTSG_Support.Text = "All" And cboStatus.Text = "" And cboDept.Text = "" Then
                '5) ===< All Blank Blank >===
                Show_AdminProjectList()
                Aadmin_Count_TotalPro()
            End If

            If Not String.IsNullOrEmpty(cboTSG_Support.Text) AndAlso cboStatus.Text = "All" AndAlso Not String.IsNullOrEmpty(cboDept.Text) Then
                '6) ===< Support All Department >===
                Show_Projects_ByTwoCbo_Function(cboTSG_Support.Text, "TSG_Support", cboDept.Text, "Department")
                Admin_Count_Projects_ByTwoCbo_Funtion(cboTSG_Support.Text, "TSG_Support", cboDept.Text, "Department")
            End If

            If Not String.IsNullOrEmpty(cboTSG_Support.Text) AndAlso Not String.IsNullOrEmpty(cboStatus.Text) AndAlso cboDept.Text = "All" Then
                '7) ===< Support Status All >===
                Show_Projects_ByTwoCbo_Function(cboTSG_Support.Text, "TSG_Support", cboStatus.Text, "Status")
                Admin_Count_Projects_ByTwoCbo_Funtion(cboTSG_Support.Text, "TSG_Support", cboStatus.Text, "Status")
            End If

            If Not String.IsNullOrEmpty(cboTSG_Support.Text) AndAlso cboStatus.Text = "All" AndAlso cboDept.Text = "All" Then
                '8) ===< Support All All >===
                Show_SupportProjects()
                Admin_Count_Projects_Support()
            End If

            If cboTSG_Support.Text = "All" AndAlso Not String.IsNullOrEmpty(cboStatus.Text) AndAlso cboDept.Text = "" Then
                '10) ===< All Status Blank >===
                Show_Projects_ByCbo_Function(cboStatus.Text, "Status")
                Admin_Count_Projects_ByCbo_Funtion(cboStatus.Text, "Status")
            End If

            If cboTSG_Support.Text = "All" AndAlso cboStatus.Text = "" AndAlso Not String.IsNullOrEmpty(cboDept.Text) Then
                '11) ===< All Blank Department >===
                Show_Projects_ByCbo_Function(cboDept.Text, "Department")
                Admin_Count_Projects_ByCbo_Funtion(cboDept.Text, "Department")
            End If

            If cboTSG_Support.Text = "All" AndAlso Not String.IsNullOrEmpty(cboStatus.Text) AndAlso Not String.IsNullOrEmpty(cboDept.Text) Then
                '12) ===< All Status Department >===
                Show_Projects_ByTwoCbo_Function(cboStatus.Text, "Status", cboDept.Text, "Department")
                Admin_Count_Projects_ByTwoCbo_Funtion(cboStatus.Text, "Status", cboDept.Text, "Department")
            End If

            If cboTSG_Support.Text = "All" AndAlso String.IsNullOrEmpty(cboStatus.Text) AndAlso cboDept.Text = "All" Then
                '14) ===< All Blank All >===
                Show_AdminProjectList()
                Aadmin_Count_TotalPro()
            End If

            If cboTSG_Support.Text = "All" AndAlso Not String.IsNullOrEmpty(cboStatus.Text) AndAlso cboDept.Text = "All" Then
                '15) ===< All Status All >===
                Show_Projects_ByCbo_Function(cboStatus.Text, "Status")
                Admin_Count_Projects_ByCbo_Funtion(cboStatus.Text, "Status")
            End If

            If cboTSG_Support.Text = "All" AndAlso cboStatus.Text = "All" AndAlso Not String.IsNullOrEmpty(cboDept.Text) Then
                '16) ===< All All Department >===
                Show_Projects_ByCbo_Function(cboDept.Text, "Department")
                Admin_Count_Projects_ByCbo_Funtion(cboDept.Text, "Department")
            End If

            If Not String.IsNullOrEmpty(cboTSG_Support.Text) AndAlso cboStatus.Text = "All" AndAlso String.IsNullOrEmpty(cboDept.Text) Then
                '17) ===< Support All Blank >===
                Show_SupportProjects()
                Admin_Count_Projects_Support()
            End If

            If cboTSG_Support.Text = "All" AndAlso cboStatus.Text = "All" AndAlso String.IsNullOrEmpty(cboDept.Text) Then
                '13) ===< All All Blank >===
                Show_AdminProjectList()
                Aadmin_Count_TotalPro()
            End If

            If Not String.IsNullOrEmpty(cboTSG_Support.Text) AndAlso cboStatus.Text = "Open Status" AndAlso Not String.IsNullOrEmpty(cboDept.Text) Then
                '20) ===< Support Open Status Department >===
                Show_Projects_ByTwoCbo_Function_OpenStatus(cboTSG_Support.Text, "TSG_Support", cboDept.Text, "Department")
                Admin_Count_Projects_ByTwoCbo_Funtion(cboTSG_Support.Text, "TSG_Support", cboDept.Text, "Department")
            End If

            If Not String.IsNullOrEmpty(cboTSG_Support.Text) AndAlso cboStatus.Text = "Open Status" AndAlso cboDept.Text = "All" Then
                '19)
                Show_SupportProjects_OpenStatus()
                Admin_Count_Projects_Support()
            End If

            If cboTSG_Support.Text = "All" AndAlso cboStatus.Text = "Open Status" AndAlso Not String.IsNullOrEmpty(cboDept.Text) Then
                '21) ===< All Open Status Department >===
                Show_Projects_ByCbo_Function_OpenStatus(cboDept.Text, "Department")
                Admin_Count_Projects_ByCbo_Funtion(cboDept.Text, "Department")
            End If

            If cboTSG_Support.Text = "All" AndAlso cboStatus.Text = "Open Status" AndAlso cboDept.Text = "All" Then
                '18) 
                Show_AdminProjectList_OpenStatus()
                Aadmin_Count_TotalPro()
            End If

            If cboTSG_Support.Text = "All" AndAlso cboStatus.Text = "All" AndAlso cboDept.Text = "All" Then
                '9) ===< All All All >===
                Show_AdminProjectList()
                Aadmin_Count_TotalPro()
            End If

        End If


    End Sub

    Private Sub cboStatus_Click(sender As Object, e As EventArgs) Handles cboStatus.Click

    End Sub

    Private Sub cboStatus_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboStatus.SelectedValueChanged

        If Not Load_Trig = False Then

            If cboTSG_Support.Text = "" AndAlso cboStatus.Text <> "" AndAlso cboDept.Text = "" Then
                '1) ===< Status only >===
                Show_Projects_ByCbo_Function(cboStatus.Text, "Status")
                Admin_Count_Projects_ByCbo_Funtion(cboStatus.Text, "Status")
            End If

            If cboTSG_Support.Text <> "" AndAlso cboStatus.Text <> "" AndAlso cboDept.Text = "" Then
                '2) ===< Support and Status only >===
                Show_Projects_ByTwoCbo_Function(cboTSG_Support.Text, "TSG_Support", cboStatus.Text, "Status")
                Admin_Count_Projects_ByTwoCbo_Funtion(cboTSG_Support.Text, "TSG_Support", cboStatus.Text, "Status")
            End If

            If cboTSG_Support.Text = "" AndAlso cboStatus.Text <> "" AndAlso cboDept.Text <> "" Then
                '3) ===< Status and Department only >===
                Show_Projects_ByTwoCbo_Function(cboStatus.Text, "Status", cboDept.Text, "Department")
                Admin_Count_Projects_ByTwoCbo_Funtion(cboStatus.Text, "Status", cboDept.Text, "Department")
            End If

            If cboTSG_Support.Text <> "" AndAlso cboStatus.Text <> "" AndAlso cboDept.Text <> "" Then
                '4) ===< Support Status Department >===
                Show_Projects_ByThreeCbo_Function(cboTSG_Support.Text, "TSG_Support", cboStatus.Text, "Status", cboDept.Text, "Department")
                Admin_Count_Projects_ByThreeCbo_Funtion(cboTSG_Support.Text, "TSG_Support", cboStatus.Text, "Status", cboDept.Text, "Department")
            End If

            If cboTSG_Support.Text = "" AndAlso cboStatus.Text = "All" AndAlso cboDept.Text = "" Then
                '5) ===< Blank All Blank >===
                Show_AdminProjectList()
                Aadmin_Count_TotalPro()
            End If

            If cboTSG_Support.Text = "All" AndAlso cboStatus.Text <> "" AndAlso cboDept.Text <> "" Then
                '6) ===< All Status Department >===
                Show_Projects_ByTwoCbo_Function(cboStatus.Text, "Status", cboDept.Text, "Department")
                Admin_Count_Projects_ByTwoCbo_Funtion(cboStatus.Text, "Status", cboDept.Text, "Department")
            End If

            If cboTSG_Support.Text <> "" AndAlso cboStatus.Text <> "" AndAlso cboDept.Text = "All" Then
                '7) ===< Support Status All >===
                Show_Projects_ByTwoCbo_Function(cboTSG_Support.Text, "TSG_Support", cboStatus.Text, "Status")
                Admin_Count_Projects_ByTwoCbo_Funtion(cboTSG_Support.Text, "TSG_Support", cboStatus.Text, "Status")
            End If

            If cboTSG_Support.Text = "All" AndAlso cboStatus.Text <> "" AndAlso cboDept.Text = "All" Then
                '8) ===< All Status All >===
                Show_Projects_ByCbo_Function(cboStatus.Text, "Status")
                Admin_Count_Projects_ByCbo_Funtion(cboStatus.Text, "Status")
            End If

            If cboTSG_Support.Text <> "" AndAlso cboStatus.Text = "All" AndAlso cboDept.Text = "" Then
                '10) ===< Support All Blank >===
                Show_SupportProjects()
                Admin_Count_Projects_Support()
            End If

            If cboTSG_Support.Text = "" AndAlso cboStatus.Text = "All" AndAlso cboDept.Text <> "" Then
                '11) ===< Blank All Department >===
                Show_Projects_ByCbo_Function(cboDept.Text, "Department")
                Admin_Count_Projects_ByCbo_Funtion(cboDept.Text, "Department")
            End If

            If cboTSG_Support.Text <> "" AndAlso cboStatus.Text = "All" AndAlso cboDept.Text <> "" Then
                '12) ===< Support All Department >===
                Show_Projects_ByTwoCbo_Function(cboTSG_Support.Text, "TSG_Support", cboDept.Text, "Department")
                Admin_Count_Projects_ByTwoCbo_Funtion(cboTSG_Support.Text, "TSG_Support", cboDept.Text, "Department")
            End If

            If String.IsNullOrEmpty(cboTSG_Support.Text) AndAlso cboStatus.Text = "All" AndAlso cboDept.Text = "All" Then
                '14) ===< Blank All All >===
                Show_AdminProjectList()
                Aadmin_Count_TotalPro()
            End If

            If Not String.IsNullOrEmpty(cboTSG_Support.Text) AndAlso cboStatus.Text = "All" AndAlso cboDept.Text = "All" Then
                '15) ===< Support All All >===
                Show_SupportProjects()
                Admin_Count_Projects_Support()
            End If

            If cboTSG_Support.Text = "All" AndAlso cboStatus.Text = "All" AndAlso Not String.IsNullOrEmpty(cboDept.Text) Then
                '16) ===< All All Department >===
                Show_Projects_ByCbo_Function(cboDept.Text, "Department")
                Admin_Count_Projects_ByCbo_Funtion(cboDept.Text, "Department")
            End If

            If cboTSG_Support.Text = "All" AndAlso Not String.IsNullOrEmpty(cboStatus.Text) AndAlso String.IsNullOrEmpty(cboDept.Text) Then
                '17) ===< All Status Blank >===
                Show_Projects_ByCbo_Function(cboStatus.Text, "Status")
                Admin_Count_Projects_ByCbo_Funtion(cboStatus.Text, "Status")
            End If

            If cboTSG_Support.Text = "All" AndAlso cboStatus.Text = "All" AndAlso String.IsNullOrEmpty(cboDept.Text) Then
                '13) ===< All All Blank >===
                Show_AdminProjectList()
                Aadmin_Count_TotalPro()
            End If

            If Not String.IsNullOrEmpty(cboTSG_Support.Text) AndAlso cboStatus.Text = "Open Status" AndAlso Not String.IsNullOrEmpty(cboDept.Text) Then
                '20) ===< Support Open Status Department >===
                Show_Projects_ByTwoCbo_Function_OpenStatus(cboTSG_Support.Text, "TSG_Support", cboDept.Text, "Department")
                Admin_Count_Projects_ByTwoCbo_Funtion(cboTSG_Support.Text, "TSG_Support", cboDept.Text, "Department")
            End If

            If Not String.IsNullOrEmpty(cboTSG_Support.Text) AndAlso cboStatus.Text = "Open Status" AndAlso cboDept.Text = "All" Then
                '19)
                Show_SupportProjects_OpenStatus()
                Admin_Count_Projects_Support()
            End If

            If cboTSG_Support.Text = "All" AndAlso cboStatus.Text = "Open Status" AndAlso Not String.IsNullOrEmpty(cboDept.Text) Then
                '21) ===< All Open Status Department >===
                Show_Projects_ByCbo_Function_OpenStatus(cboDept.Text, "Department")
                Admin_Count_Projects_ByCbo_Funtion(cboDept.Text, "Department")
            End If

            If cboTSG_Support.Text = "All" AndAlso cboStatus.Text = "Open Status" AndAlso cboDept.Text = "All" Then
                '18)
                Show_AdminProjectList_OpenStatus()
                Aadmin_Count_TotalPro()
            End If

            If cboTSG_Support.Text = "All" AndAlso cboStatus.Text = "All" AndAlso cboDept.Text = "All" Then
                '9) ===< All All All >===
                Show_AdminProjectList()
                Aadmin_Count_TotalPro()
            End If
        End If

    End Sub

    Private Sub cboDept_Click(sender As Object, e As EventArgs) Handles cboDept.Click

    End Sub

    Private Sub cboDept_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboDept.SelectedValueChanged
        If Not Load_Trig = False Then
            If String.IsNullOrEmpty(cboTSG_Support.Text) AndAlso Not String.IsNullOrEmpty(cboStatus.Text) AndAlso String.IsNullOrEmpty(cboDept.Text) Then
                '1) ===< Department only >===
                Show_Projects_ByCbo_Function(cboDept.Text, "Department")
                Admin_Count_Projects_ByCbo_Funtion(cboDept.Text, "Department")
            End If

            If String.IsNullOrEmpty(cboTSG_Support.Text) AndAlso Not String.IsNullOrEmpty(cboStatus.Text) AndAlso Not String.IsNullOrEmpty(cboDept.Text) Then
                '2) ===< Department and Status only >===
                Show_Projects_ByTwoCbo_Function(cboDept.Text, "Department", cboStatus.Text, "Status")
                Admin_Count_Projects_ByTwoCbo_Funtion(cboDept.Text, "Department", cboStatus.Text, "Status")
            End If

            If Not String.IsNullOrEmpty(cboTSG_Support.Text) AndAlso String.IsNullOrEmpty(cboStatus.Text) AndAlso Not String.IsNullOrEmpty(cboDept.Text) Then
                '3) ===< Department and Support only >===
                Show_Projects_ByTwoCbo_Function(cboTSG_Support.Text, "TSG_Support", cboDept.Text, "Department")
                Admin_Count_Projects_ByTwoCbo_Funtion(cboTSG_Support.Text, "TSG_Support", cboDept.Text, "Department")
            End If

            If Not String.IsNullOrEmpty(cboTSG_Support.Text) AndAlso Not String.IsNullOrEmpty(cboStatus.Text) AndAlso Not String.IsNullOrEmpty(cboDept.Text) Then
                '4) ===< Support Status Department  >===
                Show_Projects_ByThreeCbo_Function(cboTSG_Support.Text, "TSG_Support", cboStatus.Text, "Status", cboDept.Text, "Department")
                Admin_Count_Projects_ByThreeCbo_Funtion(cboTSG_Support.Text, "TSG_Support", cboStatus.Text, "Status", cboDept.Text, "Department")
            End If

            If String.IsNullOrEmpty(cboTSG_Support.Text) AndAlso String.IsNullOrEmpty(cboStatus.Text) AndAlso cboDept.Text = "All" Then
                '5) ===< Blank Blank All  >===
                Show_AdminProjectList()
                Aadmin_Count_TotalPro()
            End If

            If Not String.IsNullOrEmpty(cboTSG_Support.Text) AndAlso cboStatus.Text = "All" AndAlso Not String.IsNullOrEmpty(cboDept.Text) Then
                '6) ===< Support All Department >===
                Show_Projects_ByTwoCbo_Function(cboTSG_Support.Text, "TSG_Support", cboDept.Text, "Department")
                Admin_Count_Projects_ByTwoCbo_Funtion(cboTSG_Support.Text, "TSG_Support", cboDept.Text, "Department")
            End If

            If cboTSG_Support.Text = "All" AndAlso Not String.IsNullOrEmpty(cboStatus.Text) AndAlso Not String.IsNullOrEmpty(cboDept.Text) Then
                '7) ===< All Status Department >===
                Show_Projects_ByTwoCbo_Function(cboStatus.Text, "Status", cboDept.Text, "Department")
                Admin_Count_Projects_ByTwoCbo_Funtion(cboStatus.Text, "Status", cboDept.Text, "Department")
            End If

            If cboTSG_Support.Text = "All" AndAlso cboStatus.Text = "All" AndAlso Not String.IsNullOrEmpty(cboDept.Text) Then
                '8) ===< All All Department >===
                Show_Projects_ByCbo_Function(cboDept.Text, "Department")
                Admin_Count_Projects_ByCbo_Funtion(cboDept.Text, "Department")
            End If

            If String.IsNullOrEmpty(cboTSG_Support.Text) AndAlso Not String.IsNullOrEmpty(cboStatus.Text) AndAlso cboDept.Text = "All" Then
                '10) ===< Blank Status All >===
                Show_Projects_ByCbo_Function(cboStatus.Text, "Status")
                Admin_Count_Projects_ByCbo_Funtion(cboStatus.Text, "Status")
            End If

            If Not String.IsNullOrEmpty(cboTSG_Support.Text) AndAlso String.IsNullOrEmpty(cboStatus.Text) AndAlso cboDept.Text = "All" Then
                '11) ===< Support Blank All >===
                Show_SupportProjects()
                Admin_Count_Projects_Support()
            End If

            If Not String.IsNullOrEmpty(cboTSG_Support.Text) AndAlso Not String.IsNullOrEmpty(cboStatus.Text) AndAlso cboDept.Text = "All" Then
                '12) ===< Support Status All >===
                Show_Projects_ByTwoCbo_Function(cboTSG_Support.Text, "TSG_Support", cboStatus.Text, "Status")
                Admin_Count_Projects_ByTwoCbo_Funtion(cboTSG_Support.Text, "TSG_Support", cboStatus.Text, "Status")
            End If

            If cboTSG_Support.Text = "All" AndAlso String.IsNullOrEmpty(cboStatus.Text) AndAlso cboDept.Text = "All" Then
                '14) ===< All Blank All >===
                Show_AdminProjectList()
                Aadmin_Count_TotalPro()
            End If

            If cboTSG_Support.Text = "All" AndAlso Not String.IsNullOrEmpty(cboStatus.Text) AndAlso cboDept.Text = "All" Then
                '15) ===< All Status All >===
                Show_Projects_ByCbo_Function(cboStatus.Text, "Status")
                Admin_Count_Projects_ByCbo_Funtion(cboStatus.Text, "Status")
            End If

            If Not String.IsNullOrEmpty(cboTSG_Support.Text) AndAlso cboStatus.Text = "All" AndAlso cboDept.Text = "All" Then
                '16) ===< Support All All >===
                Show_SupportProjects()
                Admin_Count_Projects_Support()
            End If

            If String.IsNullOrEmpty(cboTSG_Support.Text) AndAlso cboStatus.Text = "All" AndAlso Not String.IsNullOrEmpty(cboDept.Text) Then
                '17) ===< Blank All Department >===
                Show_Projects_ByCbo_Function(cboDept.Text, "Department")
                Admin_Count_Projects_ByCbo_Funtion(cboDept.Text, "Department")
            End If


            If String.IsNullOrEmpty(cboTSG_Support.Text) AndAlso cboStatus.Text = "All" AndAlso cboDept.Text = "All" Then
                '13) ===< Blank All All >===
                Show_AdminProjectList()
                Aadmin_Count_TotalPro()
            End If

            If Not String.IsNullOrEmpty(cboTSG_Support.Text) AndAlso cboStatus.Text = "Open Status" AndAlso Not String.IsNullOrEmpty(cboDept.Text) Then
                '20) ===< Support Open Status Department >===
                Show_Projects_ByTwoCbo_Function_OpenStatus(cboTSG_Support.Text, "TSG_Support", cboDept.Text, "Department")
                Admin_Count_Projects_ByTwoCbo_Funtion(cboTSG_Support.Text, "TSG_Support", cboDept.Text, "Department")
            End If

            If Not String.IsNullOrEmpty(cboTSG_Support.Text) AndAlso cboStatus.Text = "Open Status" AndAlso cboDept.Text = "All" Then
                '19)
                Show_SupportProjects_OpenStatus()
                Admin_Count_Projects_Support()
            End If

            If cboTSG_Support.Text = "All" AndAlso cboStatus.Text = "Open Status" AndAlso Not String.IsNullOrEmpty(cboDept.Text) Then
                '21) ===< All Open Status Department >===
                Show_Projects_ByCbo_Function_OpenStatus(cboDept.Text, "Department")
                Admin_Count_Projects_ByCbo_Funtion(cboDept.Text, "Department")
            End If

            If cboTSG_Support.Text = "All" AndAlso cboStatus.Text = "Open Status" AndAlso cboDept.Text = "All" Then
                '18)
                Show_AdminProjectList_OpenStatus()
                Aadmin_Count_TotalPro()
            End If


            If cboTSG_Support.Text = "All" AndAlso cboStatus.Text = "All" AndAlso cboDept.Text = "All" Then
                '9) ===< All All All >===
                Show_AdminProjectList()
                Aadmin_Count_TotalPro()
            End If
        End If
    End Sub
End Class