Imports System.ComponentModel.Design
Imports System.Data.Common
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Drawing.Imaging
Imports System.Dynamic
Imports System.Threading
Imports System.Windows.Input
Imports Microsoft.VisualBasic.ApplicationServices

Module Login_Module

    Sub Load_LogInForm()

        With LogIn_Form
            .TopLevel = False
            Form1.MasterPanel.Controls.Add(LogIn_Form)
            .WindowState = FormWindowState.Maximized
            .BringToFront()
            .Show()
        End With

    End Sub

End Module

Module SignUp_Module

    Sub Load_SignUpForm()

        LogIn_Form.Close()

        With SignUp_Form
            .TopLevel = False
            Form1.MasterPanel.Controls.Add(SignUp_Form)
            .WindowState = FormWindowState.Maximized
            .BringToFront()
            .Show()
        End With

    End Sub

End Module

Module MainForm_Module

    Sub Load_MainForm()

        If AccLevel = "Admin" Then
            Main_Form.btnAdmin.Visible = True
            Main_Form.btnMyReq.Visible = False
            Main_Form.btnRequest.Visible = False
        End If

        With Main_Form
            .TopLevel = False
            Form1.MasterPanel.Controls.Add(Main_Form)
            .WindowState = FormWindowState.Maximized
            .BringToFront()
            .Show()
        End With

        Click_HomeButton()

    End Sub

    Sub Click_HomeButton()
        MyRequest_Form.Close()
        Request_Form.Close()
        Admin_Form.Close()

        With Home_Form
            .TopLevel = False
            Main_Form.Panel.Controls.Add(Home_Form)
            .WindowState = FormWindowState.Maximized
            .BringToFront()
            .Show()
            Main_Form.btnHome.BackColor = Color.Orange
            Main_Form.btnMyReq.BackColor = Color.Transparent
            Main_Form.btnRequest.BackColor = Color.Transparent
            Main_Form.btnAdmin.BackColor = Color.Transparent
        End With
    End Sub

    Sub Click_MyRequestButton()
        Home_Form.Close()
        Request_Form.Close()
        Admin_Form.Close()

        With MyRequest_Form
            .TopLevel = False
            Main_Form.Panel.Controls.Add(MyRequest_Form)
            .WindowState = FormWindowState.Maximized
            .BringToFront()
            .Show()
            Main_Form.btnHome.BackColor = Color.Transparent
            Main_Form.btnMyReq.BackColor = Color.Orange
            Main_Form.btnRequest.BackColor = Color.Transparent
            Main_Form.btnAdmin.BackColor = Color.Transparent
        End With
    End Sub

    Sub Click_RequestButton()

        Get_LastProjectDate()

        With StartDate_Form
            .TopLevel = False
            Main_Form.Panel.Controls.Add(StartDate_Form)
            .WindowState = FormWindowState.Maximized
            .BringToFront()
            .Show()
            Main_Form.btnHome.BackColor = Color.Transparent
            Main_Form.btnMyReq.BackColor = Color.Transparent
            Main_Form.btnRequest.BackColor = Color.Orange
            Main_Form.btnAdmin.BackColor = Color.Transparent
            .lblMessage.Text = ("The estimated start date for your new project request is " & Project_StartDate & ". Will you accept this start date?")
        End With

        ''Token_Form.ShowDialog()
        'Home_Form.Close()
        'MyRequest_Form.Close()
        'Admin_Form.Close()

        'With Token_Form
        '    .TopLevel = False
        '    Main_Form.Panel.Controls.Add(Token_Form)
        '    .WindowState = FormWindowState.Maximized
        '    .BringToFront()
        '    .Show()
        '    Main_Form.btnHome.BackColor = Color.Transparent
        '    Main_Form.btnMyReq.BackColor = Color.Transparent
        '    Main_Form.btnRequest.BackColor = Color.Orange
        '    Main_Form.btnAdmin.BackColor = Color.Transparent
        'End With
    End Sub

    Sub Click_AdminButton()
        With Admin_Form
            .TopLevel = False
            Main_Form.Panel.Controls.Add(Admin_Form)
            .WindowState = FormWindowState.Maximized
            .BringToFront()
            .Show()
            Main_Form.btnHome.BackColor = Color.Transparent
            Main_Form.btnMyReq.BackColor = Color.Transparent
            Main_Form.btnRequest.BackColor = Color.Transparent
            Main_Form.btnAdmin.BackColor = Color.Orange
        End With

        Clicked_AddProject()
    End Sub

End Module

Module AdminForm_Module
    Sub Clicked_AddProject()
        AdminProjectList_Form.Close()

        With AdminAddProject_Form
            .TopLevel = False
            Admin_Form.Panel_Admin.Controls.Add(AdminAddProject_Form)
            .WindowState = FormWindowState.Maximized
            .BringToFront()
            .Show()
        End With

        Admin_Form.btnAddProject.BackColor = Color.WhiteSmoke
        Admin_Form.btnList.BackColor = Color.Transparent

        Admin_Form.btnAddProject.ForeColor = Color.Orange
        Admin_Form.btnList.ForeColor = Color.White
    End Sub

    Sub Clicked_ProjectList()
        AdminAddProject_Form.Close()

        With AdminProjectList_Form
            .TopLevel = False
            Admin_Form.Panel_Admin.Controls.Add(AdminProjectList_Form)
            .WindowState = FormWindowState.Maximized
            .BringToFront()
            .Show()
        End With

        Admin_Form.btnAddProject.BackColor = Color.Transparent
        Admin_Form.btnList.BackColor = Color.White

        Admin_Form.btnAddProject.ForeColor = Color.White
        Admin_Form.btnList.ForeColor = Color.Orange
    End Sub
End Module

Module Query_Module
    Public connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\LF Database\TSG Project Monitoring System.accdb;Persist Security Info=True;Jet OLEDB:Database Password=lfpromonitoring"
    Public Dbconnection As New OleDbConnection(connString)


    Public Firstname As String
    Public Lastname As String
    Public AccLevel As String
    Public LFEmail As String

    '******************** FOR LogIn_Form ********************
    Sub getName()

        Try
            Dim MyData As String
            Dim cmd As New OleDbCommand
            Dim Data As New DataTable
            Dim adap As New OleDbDataAdapter
            'Dbconnection.Open()

            MyData = "SELECT * From Password_tb WHERE Username = '" & LogIn_Form.txtUser.Text & "'"
            cmd.Connection = Dbconnection
            cmd.CommandText = MyData
            adap.SelectCommand = cmd
            adap.Fill(Data)

            If Data.Rows.Count > 0 Then
                'UserN = Data.Rows(0).Item("Username").ToString
                Firstname = Data.Rows(0).Item("Firstname").ToString
                Lastname = Data.Rows(0).Item("Lastname").ToString
                AccLevel = Data.Rows(0).Item("AccessLevel").ToString
                LFEmail = Data.Rows(0).Item("Email").ToString

            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            Dbconnection.Close()

        End Try
    End Sub

    Public User As String

    Sub Login()
        If LogIn_Form.txtUser.Text = "" Or LogIn_Form.txtPass.Text = "" Or LogIn_Form.txtUser.Text = "Username" Or LogIn_Form.txtPass.Text = "Password" Then
            MsgBox("Enter username or password", MessageBoxIcon.Error)
        Else

            Try

                Dim sql As String = ("SELECT * FROM Password_tb WHERE Username = '" & LogIn_Form.txtUser.Text & "' AND Pass = '" & LogIn_Form.txtPass.Text & "'")
                Dim sqlCom As New System.Data.OleDb.OleDbCommand(sql)

                sqlCom.Connection = Dbconnection
                Dbconnection.Open()

                Dim sqlRead As System.Data.OleDb.OleDbDataReader = sqlCom.ExecuteReader()
                If sqlRead.Read() Then

                    getName()
                    User = Firstname & " " & Lastname
                    Main_Form.lblName.Text = "Hello, " & User
                    Load_MainForm()
                    LogIn_Form.Close()

                    'txtPass.Text = "Password"
                    'txtPass.PasswordChar = ""
                    'txtPass.ForeColor = Color.FromArgb(87, 96, 111)

                    'txtUser.Text = "Username"
                    'txtUser.ForeColor = Color.FromArgb(87, 96, 111)
                Else
                    MessageBox.Show("Wrong username or password", "Authentication Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    LogIn_Form.txtPass.Text = "Password"
                    LogIn_Form.txtPass.PasswordChar = ""
                    LogIn_Form.txtPass.ForeColor = Color.FromArgb(87, 96, 111)

                    LogIn_Form.txtUser.Text = "Username"
                    LogIn_Form.txtUser.ForeColor = Color.FromArgb(87, 96, 111)

                    LogIn_Form.txtUser.Focus()
                    Dbconnection.Close()
                End If

            Catch ex As Exception
                MsgBox(ex.Message, MessageBoxIcon.Error)
            Finally

            End Try
        End If
    End Sub


    '******************** FOR MyRequest_Form ********************
    Sub Show_MyRequestData()
        Dim command As New OleDbCommand("", Dbconnection)
        Dim table As New DataTable

        Dbconnection.Open()

        If Dbconnection.State = ConnectionState.Open Then
            command.Connection = Dbconnection
            command.CommandText = "Select Title, Owner, Department, TSG_Support, Status, Start_date, Due_Date From Project_tb WHERE Owner = '" & User & "' ORDER BY Due_Date DESC"

            Dim rdr As OleDbDataReader = command.ExecuteReader

            table.Load(rdr)

            MyRequest_Form.DataGridView1.DataSource = table

            ' Bold the header cells
            For Each column As DataGridViewColumn In MyRequest_Form.DataGridView1.Columns
                column.HeaderCell.Style.Font = New Font("MS Reference Sans Serif", 11, FontStyle.Bold)
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                column.DefaultCellStyle.Font = New Font("MS Reference Sans Serif", 9)
            Next

            MyRequest_Form.DataGridView1.Columns("TSG_Support").HeaderText = "TSG Support"
            MyRequest_Form.DataGridView1.Columns("Due_Date").HeaderText = "Due Date"

            MyRequest_Form.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(223, 228, 234)
            MyRequest_Form.DataGridView1.DefaultCellStyle.SelectionBackColor = Color.MediumSeaGreen
            MyRequest_Form.DataGridView1.DefaultCellStyle.SelectionForeColor = Color.White

            MyRequest_Form.DataGridView1.EnableHeadersVisualStyles = False
            MyRequest_Form.DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGreen
        End If
        Dbconnection.Close()
    End Sub

    Sub MyRequest_cell2click()

        Task_Form.btnSave.Visible = False

        Task_Form.txtTask1.ReadOnly = True
        Task_Form.txtTask2.ReadOnly = True
        Task_Form.txtTask3.ReadOnly = True
        Task_Form.txtTask4.ReadOnly = True
        Task_Form.txtTask5.ReadOnly = True

        Task_Form.txtTask1_Owner.ReadOnly = True
        Task_Form.txtTask2_Owner.ReadOnly = True
        Task_Form.txtTask3_Owner.ReadOnly = True
        Task_Form.txtTask4_Owner.ReadOnly = True
        Task_Form.txtTask5_Owner.ReadOnly = True

        Task_Form.DateTimePicker1.Enabled = False
        Task_Form.DateTimePicker2.Enabled = False
        Task_Form.DateTimePicker3.Enabled = False
        Task_Form.DateTimePicker4.Enabled = False
        Task_Form.DateTimePicker5.Enabled = False

        Try
            Dim mydata As String
            Dim command As New OleDbCommand
            Dim data As New DataTable
            Dim adap As New OleDbDataAdapter
            Dim val As String

            Dbconnection.Open()

            val = MyRequest_Form.DataGridView1.SelectedCells.Item(0).Value.ToString()

            mydata = "SELECT * From ProActivity_tb WHERE Title = '" & val & "'"
            command.Connection = Dbconnection
            command.CommandText = mydata
            adap.SelectCommand = command

            adap.Fill(data)

            If data.Rows.Count > 0 Then

                Dim Date1 As String
                Dim Date2 As String
                Dim Date3 As String
                Dim Date4 As String
                Dim Date5 As String

                Task_Form.txtTask1.Text = data.Rows(0).Item("Task1").ToString
                Task_Form.txtTask1_Owner.Text = data.Rows(0).Item("Task1_Owner").ToString
                Date1 = data.Rows(0).Item("Task1_Due").ToString
                If Date1 = Nothing Then
                    Task_Form.DateTimePicker1.Format = DateTimePickerFormat.Custom
                    Task_Form.DateTimePicker1.CustomFormat = " "
                Else
                    Task_Form.DateTimePicker1.Format = DateTimePickerFormat.Custom
                    Task_Form.DateTimePicker1.CustomFormat = Date1
                End If

                Task_Form.txtTask2.Text = data.Rows(0).Item("Task2").ToString
                Task_Form.txtTask2_Owner.Text = data.Rows(0).Item("Task2_Owner").ToString
                Date2 = data.Rows(0).Item("Task2_Due").ToString
                If Date2 = Nothing Then
                    Task_Form.DateTimePicker2.Format = DateTimePickerFormat.Custom
                    Task_Form.DateTimePicker2.CustomFormat = " "
                Else
                    Task_Form.DateTimePicker2.Format = DateTimePickerFormat.Custom
                    Task_Form.DateTimePicker2.CustomFormat = Date2
                End If

                Task_Form.txtTask3.Text = data.Rows(0).Item("Task3").ToString
                Task_Form.txtTask3_Owner.Text = data.Rows(0).Item("Task3_Owner").ToString
                Date3 = data.Rows(0).Item("Task3_Due").ToString
                If Date3 = Nothing Then
                    Task_Form.DateTimePicker3.Format = DateTimePickerFormat.Custom
                    Task_Form.DateTimePicker3.CustomFormat = " "
                Else
                    Task_Form.DateTimePicker3.Format = DateTimePickerFormat.Custom
                    Task_Form.DateTimePicker3.CustomFormat = Date3
                End If

                Task_Form.txtTask4.Text = data.Rows(0).Item("Task4").ToString
                Task_Form.txtTask4_Owner.Text = data.Rows(0).Item("Task4_Owner").ToString
                Date4 = data.Rows(0).Item("Task4_Due").ToString
                If Date4 = Nothing Then
                    Task_Form.DateTimePicker4.Format = DateTimePickerFormat.Custom
                    Task_Form.DateTimePicker4.CustomFormat = " "
                Else
                    Task_Form.DateTimePicker4.Format = DateTimePickerFormat.Custom
                    Task_Form.DateTimePicker4.CustomFormat = Date4
                End If

                Task_Form.txtTask5.Text = data.Rows(0).Item("Task5").ToString
                Task_Form.txtTask5_Owner.Text = data.Rows(0).Item("Task5_Owner").ToString
                Date5 = data.Rows(0).Item("Task5_Due").ToString
                If Date5 = Nothing Then
                    Task_Form.DateTimePicker5.Format = DateTimePickerFormat.Custom
                    Task_Form.DateTimePicker5.CustomFormat = " "
                Else
                    Task_Form.DateTimePicker5.Format = DateTimePickerFormat.Custom
                    Task_Form.DateTimePicker5.CustomFormat = Date5
                End If

                Task_Form.GroupBoxProj.Text = val
            End If
        Catch ex As Exception

        Finally
            Dbconnection.Close()
        End Try
    End Sub

    Sub MyRequest_TextSearch()
        Try
            Dim Data As New DataTable
            Dim adap As New OleDbDataAdapter
            Dim query As String

            If MyRequest_Form.txtSearch.Text = "" Or MyRequest_Form.txtSearch.Text = "Search Project" Then
                query = "Select Title, Owner, Department, TSG_Support, Status, Due_Date From Project_tb WHERE Owner = '" & User & "' ORDER BY Due_Date DESC"
            Else
                query = "Select Title, Owner, Department, TSG_Support, Status, Due_Date From Project_tb 
                         WHERE Title LIKE @searchText AND Owner = '" & User & "' "

                '"SELECT Part_Number, Qty FROM LineData_tb WHERE Part_Number LIKE @searchText"

            End If

            adap = New OleDbDataAdapter(query, Dbconnection)

            If MyRequest_Form.txtSearch.Text <> "" Then
                adap.SelectCommand.Parameters.AddWithValue("@searchText", "%" & MyRequest_Form.txtSearch.Text & "%")
            End If

            Dbconnection.Open()
            adap.Fill(Data)
            Dbconnection.Close()

            MyRequest_Form.DataGridView1.DataSource = Data


            ' Bold the header cells
            For Each column As DataGridViewColumn In MyRequest_Form.DataGridView1.Columns
                column.HeaderCell.Style.Font = New Font(MyRequest_Form.DataGridView1.Font, FontStyle.Bold)
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Next

            MyRequest_Form.DataGridView1.Columns("TSG_Support").HeaderText = "TSG Support"
            MyRequest_Form.DataGridView1.Columns("Due_Date").HeaderText = "Due Date"

        Catch ex As Exception
            'MsgBox(ex.Message, vbCritical)
        Finally
            If Dbconnection.State = ConnectionState.Open Then
                Dbconnection.Close()
            End If
        End Try
    End Sub


    '******************** FOR Request_Form *******************
    Public NewProj_Token As String

    Sub SearchToken()

        Dim Token1 As String = Token_Form.TextBox1.Text
        Dim Token2 As String = Token_Form.TextBox2.Text
        Dim Token3 As String = Token_Form.TextBox3.Text

        NewProj_Token = Token1 & Token2 & Token3

        Try
            Dim MyData As String
            Dim cmd As New OleDbCommand
            Dim Data As New DataTable
            Dim adap As New OleDbDataAdapter
            Dbconnection.Open()

            ' Define the SQL query with a parameter placeholder
            MyData = "SELECT * From Project_tb WHERE Token LIKE @ProjectToken"
            cmd.Connection = Dbconnection
            cmd.CommandText = MyData

            ' Add the parameter value with wildcard characters
            cmd.Parameters.AddWithValue("@ProjectToken", "%" & NewProj_Token & "%")

            adap.SelectCommand = cmd
            adap.Fill(Data)

            If Data.Rows.Count > 0 Then

                Dim TokenStatus As String

                TokenStatus = Data.Rows(0).Item("TokenStatus").ToString

                If TokenStatus = "Used" Then
                    MsgBox("You already used this taken!", MsgBoxStyle.Critical)
                    Token_Form.TextBox1.Clear()
                    Token_Form.TextBox2.Clear()
                    Token_Form.TextBox3.Clear()

                    Token_Form.TextBox1.Focus()
                    Token_Form.TextBox2.FillColor = Color.FromArgb(192, 255, 192)
                    Token_Form.TextBox3.FillColor = Color.FromArgb(192, 255, 192)
                Else

                    'Get_ProjectDetails()
                    Request_Form.dtpStartDate.Text = Project_StartDate

                    Home_Form.Close()
                    MyRequest_Form.Close()
                    Token_Form.Close()
                    Admin_Form.Close()

                    With Request_Form
                        .TopLevel = False
                        Main_Form.Panel.Controls.Add(Request_Form)
                        .WindowState = FormWindowState.Maximized
                        .BringToFront()
                        .Show()
                        Main_Form.btnHome.BackColor = Color.Transparent
                        Main_Form.btnMyReq.BackColor = Color.Transparent
                        Main_Form.btnRequest.BackColor = Color.Orange
                        Main_Form.btnAdmin.BackColor = Color.Transparent
                    End With
                End If

            Else
                MsgBox("This token doesn't exist.", MsgBoxStyle.Critical)
                Token_Form.Close()
                Dbconnection.Close()
                Click_MyRequestButton()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            Dbconnection.Close()
        End Try

    End Sub

    Sub Get_ProjectDetails()
        Try
            Dim MyData As String
            Dim cmd As New OleDbCommand
            Dim Data As New DataTable
            Dim adap As New OleDbDataAdapter
            Dbconnection.Open()

            MyData = "SELECT * From Project_tb WHERE Token = '" & NewProj_Token & "'"
            cmd.Connection = Dbconnection
            cmd.CommandText = MyData
            adap.SelectCommand = cmd

            adap.Fill(Data)

            If Data.Rows.Count > 0 Then

                Request_Form.txtName.Text = User
                Request_Form.txtManagerEmail.Text = LFEmail
                Request_Form.txtProjTitle.Text = Data.Rows(0).Item("Title").ToString

                Request_Form.txtMember.Focus()
            Else
                MsgBox("This token doesn't exist.", MsgBoxStyle.Critical)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            Dbconnection.Close()
        End Try
    End Sub

    Sub Update_ProjectDetails()
        If Request_Form.txtManagerEmail.Text = "" Then
            MsgBox("Please enter your emial!", MsgBoxStyle.Critical)
            Request_Form.txtManagerEmail.Focus()

        ElseIf Request_Form.txtMember.Text = "" Then
            MsgBox("Please enter project member!", MsgBoxStyle.Critical)
            Request_Form.txtMember.Focus()

        ElseIf Request_Form.txtMemEmail.Text = "" Then
            MsgBox("Please enter the emails of project member!", MsgBoxStyle.Critical)
            Request_Form.txtMemEmail.Focus()

        ElseIf Request_Form.txtDept.Text = "" Then
            MsgBox("Please enter department!", MsgBoxStyle.Critical)
            Request_Form.txtDept.Focus()

        ElseIf Request_Form.txtDescription.Text = "" Then
            MsgBox("Please enter the project description!", MsgBoxStyle.Critical)
            Request_Form.txtDescription.Focus()

        Else
            Try
                Dim Token As String = NewProj_Token
                Dim Description As String = Request_Form.txtDescription.Text
                Dim Project_Manager As String = Request_Form.txtName.Text
                Dim Manager_Email As String = Request_Form.txtManagerEmail.Text
                Dim Member As String = Request_Form.txtMember.Text
                Dim Member_Email As String = Request_Form.txtMemEmail.Text
                Dim Department As String = Request_Form.txtDept.Text
                Dim Start As String = Request_Form.dtpStartDate.Text
                Dim Due As String = Request_Form.dtpCompletion.Text
                Dim TokenStatus As String = "Used"

                Dim Project_Title As String = Request_Form.txtProjTitle.Text
                Dim query As String = "UPDATE Project_tb 
                                        SET Description = @Desc, Owner = @Owner, Email = @ManEmail, Member = @Mem, 
                                        Member_Emails = @MemEmails, Department = @Dept,  Start_date = @start, 
                                        Due_date = @Duedate, TokenStatus = @TokenStatus
                                        WHERE Token = @proTitle"

                Using command As New OleDbCommand(query, Dbconnection)
                    command.Parameters.AddWithValue("@Desc", Description)
                    command.Parameters.AddWithValue("@Owner", Project_Manager)
                    command.Parameters.AddWithValue("@ManEmail", Manager_Email)
                    command.Parameters.AddWithValue("@Mem", Member)
                    command.Parameters.AddWithValue("@MemEmails", Member_Email)
                    command.Parameters.AddWithValue("@Dept", Department)
                    command.Parameters.AddWithValue("@start", Start)
                    command.Parameters.AddWithValue("@DueDate", Due)
                    command.Parameters.AddWithValue("@TokenStatus", TokenStatus)
                    command.Parameters.AddWithValue("@proTitle", Token)
                    Dbconnection.Open()
                    command.ExecuteNonQuery()
                    Dbconnection.Close()
                End Using

                'ShowDataTable()

                MsgBox("New project request sent successfully!")

                Click_MyRequestButton()
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical)
            End Try
        End If
    End Sub

    Public Project_StartDate As String
    Sub Get_LastProjectDate()

        Dim query As String = "SELECT MAX(Due_Date) AS LatestDate FROM Project_tb"

        Dim latestDate As DateTime

        Dim command As New OleDbCommand(query, Dbconnection)

        Dbconnection.Open()

        ' Execute the query and retrieve the result
        Dim result As Object = command.ExecuteScalar()

        If result IsNot DBNull.Value Then
            latestDate = Convert.ToDateTime(result)

            ' Format the date as m/dd/yyyy
            Project_StartDate = latestDate.ToString("MM/dd/yyyy")

            'MsgBox("The latest date is: " & Project_StartDate)
        Else
            MsgBox("No dates found in the table.", MsgBoxStyle.Critical)
        End If

        Dbconnection.Close()
    End Sub


    '******************** FOR AdminAddProject_Form *******************

    Sub CheckToken()
        If AdminAddProject_Form.txtProjectTitle.Text = "" Then
            MsgBox("Please enter the project title.")
            AdminAddProject_Form.txtProjectTitle.Focus()

        ElseIf AdminAddProject_Form.txtToken.Text = "" Then
            MsgBox("Please enter a token.")
            AdminAddProject_Form.txtToken.Focus()

        ElseIf AdminAddProject_Form.txtTSGSupport.Text = "" Then
            MsgBox("Please enter the name of TSG support.")
            AdminAddProject_Form.txtTSGSupport.Focus()

        Else

            Dim Token As String = AdminAddProject_Form.txtToken.Text

            Try
                Dim MyData As String
                Dim cmd As New OleDbCommand
                Dim Data As New DataTable
                Dim adap As New OleDbDataAdapter
                Dbconnection.Open()

                ' Define the SQL query with a parameter placeholder
                MyData = "SELECT * From Project_tb WHERE Token LIKE @ProjectToken"
                cmd.Connection = Dbconnection
                cmd.CommandText = MyData

                ' Add the parameter value with wildcard characters
                cmd.Parameters.AddWithValue("@ProjectToken", "%" & Token & "%")

                adap.SelectCommand = cmd
                adap.Fill(Data)

                If Data.Rows.Count > 0 Then
                    MsgBox("This token is already used.", MsgBoxStyle.Critical)
                    AdminAddProject_Form.txtToken.Clear()
                    AdminAddProject_Form.txtToken.Focus()
                Else
                    Add_TitleForTask()
                    Add_ProjectToken()
                    Clicked_ProjectList()
                End If
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical)
            Finally
                Dbconnection.Close()
            End Try

        End If
    End Sub

    Sub Add_ProjectToken()
        Dim mycommand As String

        Dim NewToken As String = AdminAddProject_Form.txtToken.Text
        Dim NewProject As String = AdminAddProject_Form.txtProjectTitle.Text
        Dim Support As String = AdminAddProject_Form.txtTSGSupport.Text
        Dim TokenStatus As String = "Unused"
        Dim ProjectStatus As String = "Not Started"

        Try
            'Dbconnection.Open()
            mycommand = "INSERT INTO [Project_tb] ([Token],[Title], [TSG_Support], [Status], [TokenStatus]) 
                                VALUES (@Token, @ProjTitle, @Support, @Status, @TokenStat)"
            Using command As New OleDbCommand(mycommand, Dbconnection)
                command.Parameters.AddWithValue("@Token", NewToken)
                command.Parameters.AddWithValue("@ProjTitle", NewProject)
                command.Parameters.AddWithValue("@Support", Support)
                command.Parameters.AddWithValue("@Status", ProjectStatus)
                command.Parameters.AddWithValue("@TokenStat", TokenStatus)
                command.ExecuteNonQuery()
            End Using
            'Dbconnection.Close()

            MsgBox("A new project has been successfully added." & vbNewLine &
                   "You can now give the token to the project owner.", MessageBoxIcon.Information)

            AdminAddProject_Form.txtProjectTitle.Clear()
            AdminAddProject_Form.txtToken.Clear()
            AdminAddProject_Form.txtTSGSupport.Clear()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try

    End Sub

    Sub Add_TitleForTask()
        Dim mycommand As String

        Dim NewToken As String = AdminAddProject_Form.txtToken.Text
        Dim NewProject As String = AdminAddProject_Form.txtProjectTitle.Text

        Try
            'Dbconnection.Open()
            mycommand = "INSERT INTO [ProActivity_tb] ([Token],[Title]) 
                                VALUES (@Token, @ProjTitle)"
            Using command As New OleDbCommand(mycommand, Dbconnection)
                command.Parameters.AddWithValue("@Token", NewToken)
                command.Parameters.AddWithValue("@ProjTitle", NewProject)
                command.ExecuteNonQuery()
            End Using
            'Dbconnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try

    End Sub


    '******************** FOR AdminProjectList_Form *******************

    Sub Show_AdminProjectList()
        Dim command As New OleDbCommand("", Dbconnection)
        Dim table As New DataTable

        Dbconnection.Open()

        If Dbconnection.State = ConnectionState.Open Then
            command.Connection = Dbconnection
            command.CommandText = "Select Title, Owner, Department, Start_date, Due_Date, TSG_Support, Status, TokenStatus From Project_tb ORDER BY Due_Date DESC"

            '"Select Title, Description, Owner, Email, Member, 
            '                       Member_Emails, Department, Due_Date, TSG_Support, Status, TokenStatus From Project_tb"

            Dim rdr As OleDbDataReader = command.ExecuteReader

            table.Load(rdr)

            AdminProjectList_Form.DataGridView1.DataSource = table

            ' Bold the header cells
            For Each column As DataGridViewColumn In AdminProjectList_Form.DataGridView1.Columns
                column.HeaderCell.Style.Font = New Font("MS Reference Sans Serif", 11, FontStyle.Bold)
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                column.DefaultCellStyle.Font = New Font("MS Reference Sans Serif", 9)
            Next

            AdminProjectList_Form.DataGridView1.Columns("TSG_Support").HeaderText = "TSG Support"
            AdminProjectList_Form.DataGridView1.Columns("Due_date").HeaderText = "Due Date"
            AdminProjectList_Form.DataGridView1.Columns("Start_date").HeaderText = "Start Date"
            'AdminProjectList_Form.DataGridView1.Columns("Member_Emails").HeaderText = "Member Emails"

            AdminProjectList_Form.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(223, 228, 234)
            AdminProjectList_Form.DataGridView1.DefaultCellStyle.SelectionBackColor = Color.MediumSeaGreen
            AdminProjectList_Form.DataGridView1.DefaultCellStyle.SelectionForeColor = Color.White

            MyRequest_Form.DataGridView1.EnableHeadersVisualStyles = False
            MyRequest_Form.DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGreen
        End If
        Dbconnection.Close()
    End Sub

    Sub AdminProjectList_PopulateEdit()
        Try
            Dim mydata As String
            Dim command As New OleDbCommand
            Dim data As New DataTable
            Dim adap As New OleDbDataAdapter
            Dim val As String

            Dbconnection.Open()

            val = AdminProjectList_Form.DataGridView1.SelectedCells.Item(0).Value.ToString()

            mydata = "SELECT * From Project_tb WHERE Title = '" & val & "'"
            command.Connection = Dbconnection
            command.CommandText = mydata
            adap.SelectCommand = command

            adap.Fill(data)

            If data.Rows.Count > 0 Then

                Dim Due As String
                Dim Start As String

                AdminProjectList_Form.txtToken.Text = data.Rows(0).Item("Token").ToString
                AdminProjectList_Form.txtTitle.Text = data.Rows(0).Item("Title").ToString
                AdminProjectList_Form.txtDescr.Text = data.Rows(0).Item("Description").ToString
                AdminProjectList_Form.txtOwner.Text = data.Rows(0).Item("Owner").ToString
                AdminProjectList_Form.txtOwnersEmail.Text = data.Rows(0).Item("Email").ToString
                AdminProjectList_Form.txtMember.Text = data.Rows(0).Item("Member").ToString
                AdminProjectList_Form.txtMemEmails.Text = data.Rows(0).Item("Member_Emails").ToString
                AdminProjectList_Form.txtDept.Text = data.Rows(0).Item("Department").ToString
                AdminProjectList_Form.txtSupport.Text = data.Rows(0).Item("TSG_Support").ToString
                AdminProjectList_Form.cboStat.Text = data.Rows(0).Item("Status").ToString
                AdminProjectList_Form.dtpStartDate.Text = data.Rows(0).Item("Start_date").ToString
                AdminProjectList_Form.dtpDue.Text = data.Rows(0).Item("Due_date").ToString
                AdminProjectList_Form.cboTokenStat.Text = data.Rows(0).Item("TokenStatus").ToString


                Due = data.Rows(0).Item("Due_Date").ToString
                If Due = Nothing Then
                    AdminProjectList_Form.dtpDue.Format = DateTimePickerFormat.Custom
                    AdminProjectList_Form.dtpDue.CustomFormat = " "
                Else
                    AdminProjectList_Form.dtpDue.Format = DateTimePickerFormat.Short
                    AdminProjectList_Form.dtpDue.CustomFormat = Due
                End If

                Start = data.Rows(0).Item("Start_Date").ToString
                If Start = Nothing Then
                    AdminProjectList_Form.dtpStartDate.Format = DateTimePickerFormat.Custom
                    AdminProjectList_Form.dtpStartDate.CustomFormat = " "
                Else
                    AdminProjectList_Form.dtpStartDate.Format = DateTimePickerFormat.Short
                    AdminProjectList_Form.dtpStartDate.CustomFormat = Start
                End If

            End If
        Catch ex As Exception

        Finally
            Dbconnection.Close()
        End Try
    End Sub

    Sub AdminProjetList_TextSearch()
        Try
            Dim Data As New DataTable
            Dim adap As New OleDbDataAdapter
            Dim query As String

            If AdminProjectList_Form.txtSearch.Text = "" Or AdminProjectList_Form.txtSearch.Text = "Search Project" Then
                query = "Select Title, Owner, Department, Start_date, Due_Date, TSG_Support, Status, TokenStatus 
                        From Project_tb ORDER BY Due_Date DESC"
            Else
                query = "Select Title, Owner, Department, Start_date, Due_Date, TSG_Support, Status, TokenStatus From Project_tb 
                         WHERE Title LIKE @searchText ORDER BY Due_Date DESC"

                '"SELECT Part_Number, Qty FROM LineData_tb WHERE Part_Number LIKE @searchText"

            End If

            adap = New OleDbDataAdapter(query, Dbconnection)

            If AdminProjectList_Form.txtSearch.Text <> "" Then
                adap.SelectCommand.Parameters.AddWithValue("@searchText", "%" & AdminProjectList_Form.txtSearch.Text & "%")
            End If

            Dbconnection.Open()
            adap.Fill(Data)
            Dbconnection.Close()

            AdminProjectList_Form.DataGridView1.DataSource = Data


            ' Bold the header cells
            For Each column As DataGridViewColumn In AdminProjectList_Form.DataGridView1.Columns
                column.HeaderCell.Style.Font = New Font(AdminProjectList_Form.DataGridView1.Font, FontStyle.Bold)
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Next

            AdminProjectList_Form.DataGridView1.Columns("TSG_Support").HeaderText = "TSG Support"
            AdminProjectList_Form.DataGridView1.Columns("Due_date").HeaderText = "Due Date"
            AdminProjectList_Form.DataGridView1.Columns("Due_date").HeaderText = "Due Date"
            'AdminProjectList_Form.DataGridView1.Columns("Member_Emails").HeaderText = "Member Emails"

        Catch ex As Exception
            'MsgBox(ex.Message, vbCritical)
        Finally
            If Dbconnection.State = ConnectionState.Open Then
                Dbconnection.Close()
            End If
        End Try
    End Sub

    Sub AdminProjectList_ShowTask()
        'If AccLevel = "Admin" Then
        Task_Form.btnSave.Visible = True

        Task_Form.txtTask1.ReadOnly = False
        Task_Form.txtTask2.ReadOnly = False
        Task_Form.txtTask3.ReadOnly = False
        Task_Form.txtTask4.ReadOnly = False
        Task_Form.txtTask5.ReadOnly = False

        Task_Form.txtTask1_Owner.ReadOnly = False
        Task_Form.txtTask2_Owner.ReadOnly = False
        Task_Form.txtTask3_Owner.ReadOnly = False
        Task_Form.txtTask4_Owner.ReadOnly = False
        Task_Form.txtTask5_Owner.ReadOnly = False

        Task_Form.DateTimePicker1.Enabled = True
        Task_Form.DateTimePicker2.Enabled = True
        Task_Form.DateTimePicker3.Enabled = True
        Task_Form.DateTimePicker4.Enabled = True
        Task_Form.DateTimePicker5.Enabled = True
        'End If

        Try
            Dim mydata As String
            Dim command As New OleDbCommand
            Dim data As New DataTable
            Dim adap As New OleDbDataAdapter
            Dim val As String

            Dbconnection.Open()

            val = AdminProjectList_Form.DataGridView1.SelectedCells.Item(0).Value.ToString()

            mydata = "SELECT * From ProActivity_tb WHERE Title = '" & val & "'"
            command.Connection = Dbconnection
            command.CommandText = mydata
            adap.SelectCommand = command

            adap.Fill(data)

            If data.Rows.Count > 0 Then

                Dim Date1 As String
                Dim Date2 As String
                Dim Date3 As String
                Dim Date4 As String
                Dim Date5 As String

                Task_Form.txtTask1.Text = data.Rows(0).Item("Task1").ToString
                Task_Form.txtTask1_Owner.Text = data.Rows(0).Item("Task1_Owner").ToString
                Date1 = data.Rows(0).Item("Task1_Due").ToString
                If Date1 = Nothing Then
                    Task_Form.DateTimePicker1.Format = DateTimePickerFormat.Custom
                    Task_Form.DateTimePicker1.CustomFormat = " "
                Else
                    Task_Form.DateTimePicker1.Format = DateTimePickerFormat.Custom
                    Task_Form.DateTimePicker1.CustomFormat = Date1
                End If

                Task_Form.txtTask2.Text = data.Rows(0).Item("Task2").ToString
                Task_Form.txtTask2_Owner.Text = data.Rows(0).Item("Task2_Owner").ToString
                Date2 = data.Rows(0).Item("Task2_Due").ToString
                If Date2 = Nothing Then
                    Task_Form.DateTimePicker2.Format = DateTimePickerFormat.Custom
                    Task_Form.DateTimePicker2.CustomFormat = " "
                Else
                    Task_Form.DateTimePicker2.Format = DateTimePickerFormat.Custom
                    Task_Form.DateTimePicker2.CustomFormat = Date2
                End If

                Task_Form.txtTask3.Text = data.Rows(0).Item("Task3").ToString
                Task_Form.txtTask3_Owner.Text = data.Rows(0).Item("Task3_Owner").ToString
                Date3 = data.Rows(0).Item("Task3_Due").ToString
                If Date3 = Nothing Then
                    Task_Form.DateTimePicker3.Format = DateTimePickerFormat.Custom
                    Task_Form.DateTimePicker3.CustomFormat = " "
                Else
                    Task_Form.DateTimePicker3.Format = DateTimePickerFormat.Custom
                    Task_Form.DateTimePicker3.CustomFormat = Date3
                End If

                Task_Form.txtTask4.Text = data.Rows(0).Item("Task4").ToString
                Task_Form.txtTask4_Owner.Text = data.Rows(0).Item("Task4_Owner").ToString
                Date4 = data.Rows(0).Item("Task4_Due").ToString
                If Date4 = Nothing Then
                    Task_Form.DateTimePicker4.Format = DateTimePickerFormat.Custom
                    Task_Form.DateTimePicker4.CustomFormat = " "
                Else
                    Task_Form.DateTimePicker4.Format = DateTimePickerFormat.Custom
                    Task_Form.DateTimePicker4.CustomFormat = Date4
                End If

                Task_Form.txtTask5.Text = data.Rows(0).Item("Task5").ToString
                Task_Form.txtTask5_Owner.Text = data.Rows(0).Item("Task5_Owner").ToString
                Date5 = data.Rows(0).Item("Task5_Due").ToString
                If Date5 = Nothing Then
                    Task_Form.DateTimePicker5.Format = DateTimePickerFormat.Custom
                    Task_Form.DateTimePicker5.CustomFormat = " "
                Else
                    Task_Form.DateTimePicker5.Format = DateTimePickerFormat.Custom
                    Task_Form.DateTimePicker5.CustomFormat = Date5
                End If

                Task_Form.GroupBoxProj.Text = val
            End If
        Catch ex As Exception

        Finally
            Dbconnection.Close()
        End Try
    End Sub

    Sub AdminProjectList_UpdateDetails()
        If AdminProjectList_Form.txtTitle.Text = "" Then
            MsgBox("Please the title of project!", MsgBoxStyle.Critical)
            AdminProjectList_Form.txtTitle.Focus()

        ElseIf AdminProjectList_Form.txtDescr.Text = "" Then
            MsgBox("Please enter project description!", MsgBoxStyle.Critical)
            AdminProjectList_Form.txtDescr.Focus()

        ElseIf AdminProjectList_Form.txtOwner.Text = "" Then
            MsgBox("Please enter the name of project owner!", MsgBoxStyle.Critical)
            AdminProjectList_Form.txtOwner.Focus()

        ElseIf AdminProjectList_Form.txtOwnersEmail.Text = "" Then
            MsgBox("Please enter the email of project owner!", MsgBoxStyle.Critical)
            AdminProjectList_Form.txtOwnersEmail.Focus()

        ElseIf AdminProjectList_Form.txtMember.Text = "" Then
            MsgBox("Please enter name of member!", MsgBoxStyle.Critical)
            AdminProjectList_Form.txtMember.Focus()

        ElseIf AdminProjectList_Form.txtMemEmails.Text = "" Then
            MsgBox("Please enter the email(s) of member!", MsgBoxStyle.Critical)
            AdminProjectList_Form.txtMemEmails.Focus()

        ElseIf AdminProjectList_Form.txtDept.Text = "" Then
            MsgBox("Please enter the department!", MsgBoxStyle.Critical)
            AdminProjectList_Form.txtDept.Focus()

        ElseIf AdminProjectList_Form.txtSupport.Text = "" Then
            MsgBox("Please enter name of support!", MsgBoxStyle.Critical)
            AdminProjectList_Form.txtSupport.Focus()

        Else
            Try
                Dim Token As String = AdminProjectList_Form.txtToken.Text

                Dim Title As String = AdminProjectList_Form.txtTitle.Text
                Dim Description As String = AdminProjectList_Form.txtDescr.Text
                Dim Project_Owner As String = AdminProjectList_Form.txtOwner.Text
                Dim Owners_Email As String = AdminProjectList_Form.txtOwnersEmail.Text
                Dim Member As String = AdminProjectList_Form.txtMember.Text
                Dim Member_Email As String = AdminProjectList_Form.txtMemEmails.Text
                Dim Department As String = AdminProjectList_Form.txtDept.Text
                Dim Support As String = AdminProjectList_Form.txtSupport.Text
                Dim Stats As String = AdminProjectList_Form.cboStat.Text
                Dim TokenStats As String = AdminProjectList_Form.cboTokenStat.Text
                Dim Start As String = AdminProjectList_Form.dtpStartDate.Text
                Dim Due As String = AdminProjectList_Form.dtpDue.Text
                Dim query As String = "UPDATE Project_tb 
                                        SET Title = @Title, Description = @Desc, Owner = @Owner, Email = @ManEmail, Member = @Mem, 
                                        Member_Emails = @MemEmails, Department = @Dept, TSG_Support = @Support,
                                        Status = @Stat, TokenStatus = @TokenStats, Start_date = @start, Due_date = @Duedate
                                        WHERE Token = @proTitle"

                Using command As New OleDbCommand(query, Dbconnection)
                    command.Parameters.AddWithValue("@Title", Title)
                    command.Parameters.AddWithValue("@Desc", Description)
                    command.Parameters.AddWithValue("@Owner", Project_Owner)
                    command.Parameters.AddWithValue("@ManEmail", Owners_Email)
                    command.Parameters.AddWithValue("@Mem", Member)
                    command.Parameters.AddWithValue("@MemEmails", Member_Email)
                    command.Parameters.AddWithValue("@Dept", Department)
                    command.Parameters.AddWithValue("@Support", Support)
                    command.Parameters.AddWithValue("@Stat", Stats)
                    command.Parameters.AddWithValue("@TokenStats", TokenStats)
                    command.Parameters.AddWithValue("@start", Start)
                    command.Parameters.AddWithValue("@DueDate", Due)
                    command.Parameters.AddWithValue("@proTitle", Token)
                    Dbconnection.Open()
                    command.ExecuteNonQuery()
                    'Dbconnection.Close()
                End Using

                Dim query2 As String = "UPDATE ProActivity_tb SET Title = @Project_Title WHERE Token = @proTitle"

                Using command2 As New OleDbCommand(query2, Dbconnection)
                    command2.Parameters.AddWithValue("@Project_Title", Title)
                    command2.Parameters.AddWithValue("@proTitle", Token)
                    'Dbconnection.Open()
                    command2.ExecuteNonQuery()
                    Dbconnection.Close()
                End Using


                Show_AdminProjectList()
                MsgBox("Changes were successfully saved", MessageBoxIcon.Information)

            Catch ex As Exception
                MsgBox(ex.Message, vbCritical)
            End Try
        End If
    End Sub

    Sub TaskTitleChanged()
        Try
            Dim Token As String = AdminProjectList_Form.txtToken.Text
            Dim Title As String = AdminProjectList_Form.txtTitle.Text

            Dim query As String = "UPDATE ProActivity_tb SET Title = @Project_Title WHERE Token = @proTitle"

            Using command As New OleDbCommand(query, Dbconnection)
                command.Parameters.AddWithValue("@Project_Title", Title)
                command.Parameters.AddWithValue("@proTitle", Token)
                Dbconnection.Open()
                command.ExecuteNonQuery()
                Dbconnection.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub


    '******************** FOR Task_form UPDATE *******************

    Sub Update_ProjectTask()

        Try
            Dim Title As String = Task_Form.GroupBoxProj.Text

            Dim Task1 As String = Task_Form.txtTask1.Text
            Dim Task2 As String = Task_Form.txtTask2.Text
            Dim Task3 As String = Task_Form.txtTask3.Text
            Dim Task4 As String = Task_Form.txtTask4.Text
            Dim Task5 As String = Task_Form.txtTask5.Text

            Dim Task1_Owner As String = Task_Form.txtTask1_Owner.Text
            Dim Task2_Owner As String = Task_Form.txtTask2_Owner.Text
            Dim Task3_Owner As String = Task_Form.txtTask3_Owner.Text
            Dim Task4_Owner As String = Task_Form.txtTask4_Owner.Text
            Dim Task5_Owner As String = Task_Form.txtTask5_Owner.Text

            Dim Task_Due1 As String = Task_Form.DateTimePicker1.Text
            Dim Task_Due2 As String = Task_Form.DateTimePicker2.Text
            Dim Task_Due3 As String = Task_Form.DateTimePicker3.Text
            Dim Task_Due4 As String = Task_Form.DateTimePicker4.Text
            Dim Task_Due5 As String = Task_Form.DateTimePicker5.Text

            Dim Project_Title As String = Request_Form.txtProjTitle.Text
            Dim query As String = "UPDATE ProActivity_tb 
                                SET Task1 = @Task1, Task2 = @Task2, Task3 = @Task3, Task4 = @Task4, Task5 = @Task5,
                                Task1_Owner = @Task1_Owner, Task2_Owner = @Task2_Owner, Task3_Owner = @Task3_Owner, Task4_Owner = @Task4_Owner, Task5_Owner = @Task5_Owner,
                                Task1_Due = @Task_Due1, Task2_Due = @Task_Due2, Task3_Due = @Task_Due3, Task4_Due = @Task_Due4, Task5_Due = @Task_Due5
                                WHERE Title = @proTitle"

            Using command As New OleDbCommand(query, Dbconnection)

                command.Parameters.AddWithValue("@Task1", Task1)
                command.Parameters.AddWithValue("@Task2", Task2)
                command.Parameters.AddWithValue("@Task3", Task3)
                command.Parameters.AddWithValue("@Task4", Task4)
                command.Parameters.AddWithValue("@Task5", Task5)

                command.Parameters.AddWithValue("@Task1_Owner", Task1_Owner)
                command.Parameters.AddWithValue("@Task2_Owner", Task2_Owner)
                command.Parameters.AddWithValue("@Task3_Owner", Task3_Owner)
                command.Parameters.AddWithValue("@Task4_Owner", Task4_Owner)
                command.Parameters.AddWithValue("@Task5_Owner", Task5_Owner)

                command.Parameters.AddWithValue("@Task_Due1", Task_Due1)
                command.Parameters.AddWithValue("@Task_Due2", Task_Due2)
                command.Parameters.AddWithValue("@Task_Due3", Task_Due3)
                command.Parameters.AddWithValue("@Task_Due4", Task_Due4)
                command.Parameters.AddWithValue("@Task_Due5", Task_Due5)

                command.Parameters.AddWithValue("@proTitle", Title)
                Dbconnection.Open()
                command.ExecuteNonQuery()
                Dbconnection.Close()
            End Using

            'ShowDataTable()

            MsgBox("Task Saved")
            Task_Form.Close()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub


    '******************** FOR SignUp_Form *******************

    Sub Save_SignUp()
        Dim mycommand As String

        Dim Fname As String = SignUp_Form.txtFirstName.Text
        Dim Lname As String = SignUp_Form.txtLastName.Text
        Dim Uname As String = SignUp_Form.txtUsername.Text
        Dim LFEmail As String = SignUp_Form.txtLFEmail.Text
        Dim PW As String = SignUp_Form.txtSignUpPass.Text
        Dim ConfirmPW As String = SignUp_Form.txtConfirmPass.Text
        Dim AccessLVL As String = "User"

        If SignUp_Form.txtFirstName.Text = "" Or SignUp_Form.txtFirstName.Text = "First name" Then
            MsgBox("Please enter your first name!", MsgBoxStyle.Critical)
            SignUp_Form.txtFirstName.Focus()

        ElseIf SignUp_Form.txtLastName.Text = "" Or SignUp_Form.txtLastName.Text = "Last name" Then
            MsgBox("Please enter your last name!", MsgBoxStyle.Critical)
            SignUp_Form.txtLastName.Focus()

        ElseIf SignUp_Form.txtUsername.Text = "" Or SignUp_Form.txtUsername.Text = "User name" Then
            MsgBox("Please enter your user name!", MsgBoxStyle.Critical)
            SignUp_Form.txtUsername.Focus()

        ElseIf SignUp_Form.txtLFEmail.Text = "" Or SignUp_Form.txtLFEmail.Text = "Littelfuse email" Then
            MsgBox("Please enter your email!", MsgBoxStyle.Critical)
            SignUp_Form.txtLFEmail.Focus()

        ElseIf SignUp_Form.txtSignUpPass.Text = "" Or SignUp_Form.txtSignUpPass.Text = "Password" Then
            MsgBox("Please emter your password", MsgBoxStyle.Critical)
            SignUp_Form.txtSignUpPass.Focus()

        ElseIf SignUp_Form.txtConfirmPass.Text = "" Or SignUp_Form.txtConfirmPass.Text = "Confirm Password" Then
            MsgBox("Please emter your password confirmation", MsgBoxStyle.Critical)
            SignUp_Form.txtConfirmPass.Focus()

        ElseIf SignUp_Form.txtSignUpPass.Text <> SignUp_Form.txtConfirmPass.Text Then
            MsgBox("Password does not match!" & vbNewLine & "Please re-type your password", MsgBoxStyle.Critical)
            SignUp_Form.txtSignUpPass.Clear()
            SignUp_Form.txtConfirmPass.Clear()
            SignUp_Form.txtSignUpPass.Focus()

        Else

            Try
                Dbconnection.Open()
                mycommand = "INSERT INTO [Password_tb] ([Username],[Firstname], [Lastname], [AccessLevel], [Pass], [Email]) 
                                VALUES (@Uname, @Fname, @Lname, @Acclvl, @PW, @LFemail)"
                Using command As New OleDbCommand(mycommand, Dbconnection)
                    command.Parameters.AddWithValue("@Uname", Uname)
                    command.Parameters.AddWithValue("@Fname", Fname)
                    command.Parameters.AddWithValue("@Lname", Lname)
                    command.Parameters.AddWithValue("@Acclvl", AccessLVL)
                    command.Parameters.AddWithValue("@PW", ConfirmPW)
                    command.Parameters.AddWithValue("@LFemail", LFEmail)
                    command.ExecuteNonQuery()
                End Using
                Dbconnection.Close()

                MsgBox("Thank you for signing up")

                SignUp_Form.Close()
                Load_LogInForm()
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical)
            End Try

        End If

    End Sub

    Sub Check_UserName_Duplicate()
        Dim Username As String = SignUp_Form.txtUsername.Text

        Try
            Dim MyData As String
            Dim cmd As New OleDbCommand
            Dim Data As New DataTable
            Dim adap As New OleDbDataAdapter
            Dbconnection.Open()

            ' Define the SQL query with a parameter placeholder
            MyData = "SELECT * From Password_tb WHERE Username LIKE @USERnm"
            cmd.Connection = Dbconnection
            cmd.CommandText = MyData

            ' Add the parameter value with wildcard characters
            cmd.Parameters.AddWithValue("@USERnm", "%" & Username & "%")

            adap.SelectCommand = cmd
            adap.Fill(Data)

            If Data.Rows.Count > 0 Then
                MsgBox("User name already used!" & vbNewLine & "Please type a different user name.", MsgBoxStyle.Critical)
                SignUp_Form.txtUsername.Clear()
                SignUp_Form.txtUsername.Focus()
            Else
                Save_SignUp()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            Dbconnection.Close()
        End Try
    End Sub

    Sub Check_UserNameKeyUp()
        Dim Username As String = SignUp_Form.txtUsername.Text

        Try
            Dim MyData As String
            Dim cmd As New OleDbCommand
            Dim Data As New DataTable
            Dim adap As New OleDbDataAdapter
            Dbconnection.Open()

            ' Define the SQL query with a parameter placeholder
            MyData = "SELECT * From Password_tb WHERE Username LIKE @USERnm"
            cmd.Connection = Dbconnection
            cmd.CommandText = MyData

            ' Add the parameter value with wildcard characters
            cmd.Parameters.AddWithValue("@USERnm", "%" & Username & "%")

            adap.SelectCommand = cmd
            adap.Fill(Data)

            If Data.Rows.Count > 0 Then
                MsgBox("User name already used!" & vbNewLine & "Please type a different user name.", MsgBoxStyle.Critical)
                SignUp_Form.txtUsername.Clear()
                SignUp_Form.txtUsername.Focus()
            Else
                SignUp_Form.txtLFEmail.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            Dbconnection.Close()
        End Try
    End Sub

End Module