Imports System.ComponentModel.Design
Imports System.Data.Common
Imports System.Data.Odbc
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Drawing.Imaging
Imports System.Dynamic
Imports System.Threading
Imports System.Windows.Input
Imports Microsoft.Office.Interop
Imports Microsoft.VisualBasic.ApplicationServices
Imports TheArtOfDevHtmlRenderer.Adapters.RGraphicsPath
Imports System.Configuration
Imports System
Imports System.ComponentModel
Imports System.Net
Imports System.Net.Mail
Imports System.Net.Mime
Imports System.IO
Imports System.Collections.ObjectModel
Module Query_Module
    'Data Source=BTMESSQLQA03;Initial Catalog=TSG_ProjectMonitoringSystem;Persist Security Info=True;User ID=mesph;Password=PHFuse;TrustServerCertificate=True
    'Data Source=BTMESSQLDEV03;Initial Catalog=TSG_ProjectMonitoringSystem;Persist Security Info=True;User ID=mesph;Password=PHFuse;TrustServerCertificate=True

    Public SQLconnString As String = "Data Source=BTMESSQLQA03;Initial Catalog=TSG_ProjectMonitoringSystem;Persist Security Info=True;User ID=mesph;Password=PHFuse;TrustServerCertificate=True"
    Public SQLDbconnection As New SqlConnection(SQLconnString)

    Sub ConOpen()
        If SQLDbconnection.State = ConnectionState.Closed Then
            SQLDbconnection.Open()
        End If
    End Sub

    Sub ConClose()
        If SQLDbconnection.State = ConnectionState.Open Then
            SQLDbconnection.Close()
        End If
    End Sub

    Public Firstname As String
    Public Lastname As String
    Public AccLevel As String
    Public LFEmail As String

    '******************** FOR LogIn_Form ********************
    Sub getName()

        Try
            Dim MyData As String
            Dim cmd As New SqlCommand
            Dim Data As New DataTable
            Dim adap As New SqlDataAdapter
            'SQLDbconnection.Open()

            MyData = "SELECT * From Password_tb WHERE Username = '" & LogIn_Form.txtUser.Text & "'"
            cmd.Connection = SQLDbconnection
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
            'SQLDbconnection.Close()
            ConClose()
        End Try
    End Sub

    Public User As String

    Sub Login()
        getName()
        User = Firstname & " " & Lastname

        If LogIn_Form.txtUser.Text = "" Or LogIn_Form.txtPass.Text = "" Or LogIn_Form.txtUser.Text = "Username" Or LogIn_Form.txtPass.Text = "Password" Then
            MsgBox("Enter username or password", MessageBoxIcon.Error)
        Else

            Try

                Dim sql As String = ("SELECT * FROM Password_tb WHERE Username = '" & LogIn_Form.txtUser.Text & "' AND Pass = '" & LogIn_Form.txtPass.Text & "'")
                Dim sqlCom As New System.Data.SqlClient.SqlCommand(sql)

                sqlCom.Connection = SQLDbconnection
                'SQLDbconnection.Open()
                ConOpen()

                Dim sqlRead As System.Data.SqlClient.SqlDataReader = sqlCom.ExecuteReader()

                If sqlRead.Read() Then

                    'getName()
                    'User = Firstname & " " & Lastname
                    Main_Form.lblName.Text = "Hello, " & User
                    sqlRead.Close()
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

                    LogIn_Form.txtUser.Text = "Employee number"
                    LogIn_Form.txtUser.ForeColor = Color.FromArgb(87, 96, 111)

                    LogIn_Form.txtUser.Focus()
                    'SQLDbconnection.Close()
                    ConClose()
                End If

            Catch ex As Exception
                MsgBox(ex.Message, MessageBoxIcon.Error)
            Finally

            End Try
        End If
    End Sub


    '******************** FOR MyRequest_Form ********************
    Sub Show_MyRequestData()
        Dim command As New SqlCommand("", SQLDbconnection)
        Dim table As New DataTable

        'SQLDbconnection.Open()
        ConOpen()

        If SQLDbconnection.State = ConnectionState.Open Then
            command.Connection = SQLDbconnection
            command.CommandText = "Select ID, Title, Owner, Department, TSG_Support, Status, Start_date, Due_Date From Project_tb WHERE Owner = '" & User & "' ORDER BY Due_Date DESC"

            Dim rdr As SqlDataReader = command.ExecuteReader

            table.Load(rdr)

            MyRequest_Form.DataGridView1.DataSource = table

            ' Bold the header cells
            For Each column As DataGridViewColumn In MyRequest_Form.DataGridView1.Columns
                column.HeaderCell.Style.Font = New Font("MS Reference Sans Serif", 11, FontStyle.Bold)
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                column.DefaultCellStyle.Font = New Font("MS Reference Sans Serif", 9)
            Next


            MyRequest_Form.DataGridView1.Columns("ID").HeaderText = "Project ID"
            MyRequest_Form.DataGridView1.Columns("TSG_Support").HeaderText = "TSG Support"
            MyRequest_Form.DataGridView1.Columns("Start_date").HeaderText = "Start Date"
            MyRequest_Form.DataGridView1.Columns("Due_Date").HeaderText = "Due Date"

            MyRequest_Form.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(223, 228, 234)
            MyRequest_Form.DataGridView1.DefaultCellStyle.SelectionBackColor = Color.MediumSeaGreen
            MyRequest_Form.DataGridView1.DefaultCellStyle.SelectionForeColor = Color.White

            MyRequest_Form.DataGridView1.EnableHeadersVisualStyles = False
            MyRequest_Form.DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGreen
        End If
        'SQLDbconnection.Close()
        ConClose()
    End Sub

    Sub MyRequest_cell2click()
        Try
            ' Disable editing for task-related fields
            With Task_Form
                .btnSave.Visible = False

                .txtTask1.ReadOnly = True
                .txtTask2.ReadOnly = True
                .txtTask3.ReadOnly = True
                .txtTask4.ReadOnly = True
                .txtTask5.ReadOnly = True

                .txtTask1_Owner.ReadOnly = True
                .txtTask2_Owner.ReadOnly = True
                .txtTask3_Owner.ReadOnly = True
                .txtTask4_Owner.ReadOnly = True
                .txtTask5_Owner.ReadOnly = True

                .DateTimePicker1.Enabled = False
                .DateTimePicker2.Enabled = False
                .DateTimePicker3.Enabled = False
                .DateTimePicker4.Enabled = False
                .DateTimePicker5.Enabled = False
            End With

            ' Check if at least one cell is selected
            If MyRequest_Form.DataGridView1.SelectedCells.Count > 0 Then
                Dim selectedRowIndex As Integer = MyRequest_Form.DataGridView1.SelectedCells(0).RowIndex

                ' Ensure row index is valid
                If selectedRowIndex >= 0 Then
                    ' Assuming "Title" is in column index 1 (adjust if needed)
                    Dim titleColumnIndex As Integer = 1
                    Dim selectedRow As DataGridViewRow = MyRequest_Form.DataGridView1.Rows(selectedRowIndex)

                    ' Retrieve the project title from the specified column
                    Dim val As String = selectedRow.Cells(titleColumnIndex).Value?.ToString()

                    ' Ensure value is not empty
                    If Not String.IsNullOrEmpty(val) Then
                        Dim command As New SqlCommand
                        Dim data As New DataTable
                        Dim adap As New SqlDataAdapter

                        ' Open database connection
                        ConOpen()

                        ' Use parameterized query to prevent SQL injection
                        Dim mydata As String = "SELECT * FROM ProActivity_tb WHERE Title = @Title"
                        command.Connection = SQLDbconnection
                        command.CommandText = mydata
                        command.Parameters.AddWithValue("@Title", val)
                        adap.SelectCommand = command

                        ' Fill the DataTable
                        adap.Fill(data)

                        ' If data is found, populate the form fields
                        If data.Rows.Count > 0 Then
                            'With Task_Form
                            '    .txtTask1.Text = data.Rows(0).Item("Task1").ToString()
                            '    .txtTask1_Owner.Text = data.Rows(0).Item("Task1_Owner").ToString()
                            '    SetDatePickerValue(.DateTimePicker1, data.Rows(0).Item("Task1_Due"))

                            '    .txtTask2.Text = data.Rows(0).Item("Task2").ToString()
                            '    .txtTask2_Owner.Text = data.Rows(0).Item("Task2_Owner").ToString()
                            '    SetDatePickerValue(.DateTimePicker2, data.Rows(0).Item("Task2_Due"))

                            '    .txtTask3.Text = data.Rows(0).Item("Task3").ToString()
                            '    .txtTask3_Owner.Text = data.Rows(0).Item("Task3_Owner").ToString()
                            '    SetDatePickerValue(.DateTimePicker3, data.Rows(0).Item("Task3_Due"))

                            '    .txtTask4.Text = data.Rows(0).Item("Task4").ToString()
                            '    .txtTask4_Owner.Text = data.Rows(0).Item("Task4_Owner").ToString()
                            '    SetDatePickerValue(.DateTimePicker4, data.Rows(0).Item("Task4_Due"))

                            '    .txtTask5.Text = data.Rows(0).Item("Task5").ToString()
                            '    .txtTask5_Owner.Text = data.Rows(0).Item("Task5_Owner").ToString()
                            '    SetDatePickerValue(.DateTimePicker5, data.Rows(0).Item("Task5_Due"))

                            '    .GroupBoxProj.Text = val ' Set the group box title
                            'End With

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
                    End If
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Close the database connection
            ConClose()
        End Try
    End Sub

    Sub MyRequest_TextSearch()
        Try
            Dim Data As New DataTable
            Dim adap As New SqlDataAdapter
            Dim query As String

            If MyRequest_Form.txtSearch.Text = "" Or MyRequest_Form.txtSearch.Text = "Search Project" Then
                query = "Select ID, Title, Owner, Department, TSG_Support, Status, Start_date, Due_Date From Project_tb WHERE Owner = '" & User & "' ORDER BY Due_Date DESC"
            Else
                query = "Select ID, Title, Owner, Department, TSG_Support, Status, Start_date, Due_Date From Project_tb 
                         WHERE Title LIKE @searchText AND Owner = '" & User & "' "

                '"SELECT Part_Number, Qty FROM LineData_tb WHERE Part_Number LIKE @searchText"

            End If

            adap = New SqlDataAdapter(query, SQLDbconnection)

            If MyRequest_Form.txtSearch.Text <> "" Then
                adap.SelectCommand.Parameters.AddWithValue("@searchText", "%" & MyRequest_Form.txtSearch.Text & "%")
            End If

            'SQLDbconnection.Open()
            ConOpen()
            adap.Fill(Data)
            'SQLDbconnection.Close()
            ConClose()

            MyRequest_Form.DataGridView1.DataSource = Data


            ' Bold the header cells
            For Each column As DataGridViewColumn In MyRequest_Form.DataGridView1.Columns
                column.HeaderCell.Style.Font = New Font("MS Reference Sans Serif", 11, FontStyle.Bold)
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                column.DefaultCellStyle.Font = New Font("MS Reference Sans Serif", 9)
            Next

            MyRequest_Form.DataGridView1.Columns("ID").HeaderText = "Project ID"
            MyRequest_Form.DataGridView1.Columns("TSG_Support").HeaderText = "TSG Support"
            MyRequest_Form.DataGridView1.Columns("Start_date").HeaderText = "Start Date"
            MyRequest_Form.DataGridView1.Columns("Due_Date").HeaderText = "Due Date"

        Catch ex As Exception
            'MsgBox(ex.Message, vbCritical)
        Finally
            If SQLDbconnection.State = ConnectionState.Open Then
                SQLDbconnection.Close()
            End If
        End Try
    End Sub

    Public User_Val As String

    Sub MyRequest_Populate()
        Try
            ' Ensure at least one cell is selected
            If MyRequest_Form.DataGridView1.SelectedCells.Count > 0 Then
                Dim selectedRowIndex As Integer = MyRequest_Form.DataGridView1.SelectedCells(0).RowIndex

                ' Ensure row index is valid
                If selectedRowIndex >= 0 Then
                    ' Assuming "Title" is in column index 1 (adjust if needed)
                    Dim titleColumnIndex As Integer = 1
                    Dim selectedRow As DataGridViewRow = MyRequest_Form.DataGridView1.Rows(selectedRowIndex)

                    ' Retrieve the project title from the specified column
                    Dim User_Val As String = selectedRow.Cells(titleColumnIndex).Value?.ToString()

                    ' Ensure value is not empty
                    If Not String.IsNullOrEmpty(User_Val) Then
                        Dim query As String = "SELECT FileName FROM Project_tb WHERE Title = @Title"

                        ' Open database connection
                        ConOpen()

                        ' Use "Using" to properly dispose of objects
                        Using command As New SqlCommand(query, SQLDbconnection)
                            command.Parameters.AddWithValue("@Title", User_Val)

                            Using adapter As New SqlDataAdapter(command)
                                Using data As New DataTable()
                                    adapter.Fill(data)

                                    ' If data is found, populate the filename text field
                                    If data.Rows.Count > 0 Then
                                        MyRequest_Form.txtFileName.Text = data.Rows(0).Item("FileName").ToString()
                                    End If
                                End Using
                            End Using
                        End Using
                    End If
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Close the database connection
            ConClose()
        End Try

    End Sub

    Sub MyRequest_DownloadA3()
        Dim outputFilePath As String = MyRequest_Form.txtLocation.Text
        Dim name As String = MyRequest_Form.txtFileName.Text

        Try

            'SQLDbconnection.Open()
            ConOpen()

            Using command As New SqlCommand("SELECT FileName, A3 FROM Project_tb WHERE FileName = @Name", SQLDbconnection)
                command.Parameters.AddWithValue("@Name", name) ' Change the ID to the appropriate value
                Using reader As SqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        Dim fileName As String = reader("FileName").ToString()
                        Dim fileData As Byte() = CType(reader("A3"), Byte())

                        File.WriteAllBytes(Path.Combine(outputFilePath, fileName), fileData)
                    End If
                End Using
            End Using
            'SQLDbconnection.Close()
            ConClose()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
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
            Dim cmd As New SqlCommand
            Dim Data As New DataTable
            Dim adap As New SqlDataAdapter
            'SQLDbconnection.Open()
            ConOpen()

            ' Define the SQL query with a parameter placeholder
            MyData = "SELECT * From Project_tb WHERE Token LIKE @ProjectToken"
            cmd.Connection = SQLDbconnection
            cmd.CommandText = MyData

            ' Add the parameter value with wildcard characters
            cmd.Parameters.AddWithValue("@ProjectToken", "%" & NewProj_Token & "%")

            adap.SelectCommand = cmd
            adap.Fill(Data)

            If Data.Rows.Count > 0 Then

                Dim TokenStatus As String

                TokenStatus = Data.Rows(0).Item("TokenStatus").ToString

                If TokenStatus = "Used" Then
                    MsgBox("Token already used!", MsgBoxStyle.Critical)
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
                'SQLDbconnection.Close()
                ConClose()
                Click_MyRequestButton()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            'SQLDbconnection.Close()
            ConClose()
        End Try

    End Sub

    Sub Get_ProjectDetails()
        Try
            Dim MyData As String
            Dim cmd As New SqlCommand
            Dim Data As New DataTable
            Dim adap As New SqlDataAdapter
            'SQLDbconnection.Open()
            ConOpen()

            MyData = "SELECT * From Project_tb WHERE Token = '" & NewProj_Token & "'"
            cmd.Connection = SQLDbconnection
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
            'SQLDbconnection.Close()
            ConClose()
        End Try
    End Sub

    Sub Update_ProjectAct_Title()
        Try

            Dim Token As String = NewProj_Token
            Dim Project_Title As String = Request_Form.txtProjTitle.Text
            Dim query As String = "UPDATE ProActivity_tb 
                                        SET Title = @ProjectTit
                                        WHERE Token = @proTitle"

            Using command As New SqlCommand(query, SQLDbconnection)
                command.Parameters.AddWithValue("@ProjectTit", Project_Title)
                command.Parameters.AddWithValue("@proTitle", Token)
                'SQLDbconnection.Open()
                ConOpen()
                command.ExecuteNonQuery()
                'SQLDbconnection.Close()
                ConClose()
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
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

        ElseIf Request_Form.txtA3name.Text = "" Then
            MsgBox("A3 is required!", MsgBoxStyle.Critical)
            Request_Form.btnBrowse.Focus()

        Else
            Try

                SaveA3() 'Save A3 file to database

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
                                        SET Title = @ProjectTit, Description = @Desc, Owner = @Owner, Email = @ManEmail, Member = @Mem, 
                                        Member_Emails = @MemEmails, Department = @Dept,  Start_date = @start, 
                                        Due_date = @Duedate, TokenStatus = @TokenStatus
                                        WHERE Token = @proTitle"

                Using command As New SqlCommand(query, SQLDbconnection)
                    command.Parameters.AddWithValue("@ProjectTit", Project_Title)
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
                    'SQLDbconnection.Open()
                    ConOpen()
                    command.ExecuteNonQuery()
                    'SQLDbconnection.Close()
                    ConClose()
                End Using

                'ShowDataTable()
                Update_ProjectAct_Title()

                MsgBox("New project request sent successfully!")

                Click_MyRequestButton()
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical)
            End Try
        End If
    End Sub

    Sub Get_TSG_Support_Due()
        Dim command As New SqlCommand("", SQLDbconnection)
        Dim table As New DataTable

        'SQLDbconnection.Open()
        ConOpen()

        If SQLDbconnection.State = ConnectionState.Open Then
            command.Connection = SQLDbconnection
            command.CommandText = "SELECT TSG_Support, MAX(Due_Date) AS MAX_DUE
                                    FROM Project_tb 
                                    GROUP BY TSG_Support
                                    ORDER BY MAX_DUE DESC;"

            Dim rdr As SqlDataReader = command.ExecuteReader

            table.Load(rdr)

            StartDate_Form.DataGridView1.DataSource = table

            ' Bold the header cells
            For Each column As DataGridViewColumn In StartDate_Form.DataGridView1.Columns
                column.HeaderCell.Style.Font = New Font("MS Reference Sans Serif", 11, FontStyle.Bold)
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                column.DefaultCellStyle.Font = New Font("MS Reference Sans Serif", 9)
            Next

            StartDate_Form.DataGridView1.Columns("TSG_Support").HeaderText = "TSG Support"
            StartDate_Form.DataGridView1.Columns("MAX_DUE").HeaderText = "Available Date"

            StartDate_Form.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(223, 228, 234)
            StartDate_Form.DataGridView1.DefaultCellStyle.SelectionBackColor = Color.MediumSeaGreen
            StartDate_Form.DataGridView1.DefaultCellStyle.SelectionForeColor = Color.White
            StartDate_Form.DataGridView1.DefaultCellStyle.ForeColor = Color.Black

            StartDate_Form.DataGridView1.EnableHeadersVisualStyles = False
            StartDate_Form.DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGreen

        End If
        'SQLDbconnection.Close()
        ConClose()
    End Sub

    Sub StartDate_Populate()
        Try
            Dim mydata As String
            Dim command As New SqlCommand
            Dim data As New DataTable
            Dim adap As New SqlDataAdapter
            Dim val As String

            'SQLDbconnection.Open()
            ConOpen()

            val = StartDate_Form.DataGridView1.SelectedCells.Item(0).Value.ToString()

            mydata = "SELECT TSG_Support, MAX(Due_Date) AS MAX_DUE
                      FROM Project_tb 
                      WHERE TSG_Support = @val
                       GROUP BY TSG_Support"
            command.Connection = SQLDbconnection
            command.CommandText = mydata
            command.Parameters.AddWithValue("@val", val)
            adap.SelectCommand = command

            adap.Fill(data)

            If data.Rows.Count > 0 Then

                Dim maxDueDate As Date = Date.Parse(data.Rows(0).Item("MAX_DUE").ToString())
                StartDate_Form.txtStartDate.Text = maxDueDate.ToString("MM/dd/yyyy")
                Project_StartDate = maxDueDate.ToString("MM/dd/yyyy")
            End If
        Catch ex As Exception

        Finally
            'SQLDbconnection.Close()
            ConClose()
        End Try
    End Sub

    Public Project_StartDate As String

    Sub Get_LastProjectDate()

        Dim query As String = "SELECT MAX(Due_Date) AS LatestDate FROM Project_tb"

        Dim latestDate As DateTime

        Dim command As New SqlCommand(query, SQLDbconnection)

        'SQLDbconnection.Open()
        ConOpen()

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

        'SQLDbconnection.Close()
        ConClose()
    End Sub

    Sub SaveA3()
        Dim Token As String = NewProj_Token
        Dim filePath As String = Request_Form.txtA3name.Text
        Dim fileName As String = Path.GetFileName(filePath)
        Dim fileData As Byte() = File.ReadAllBytes(filePath)
        Try
            'SQLDbconnection.Open()
            ConOpen()

            Using command As New SqlCommand("UPDATE Project_tb SET FileName = @FileName, A3 = @FileData 
                                                WHERE Token = @proToken", SQLDbconnection)
                command.Parameters.AddWithValue("@FileName", fileName)
                command.Parameters.AddWithValue("@FileData", fileData)
                command.Parameters.AddWithValue("@proToken", Token)
                command.ExecuteNonQuery()
            End Using
            'SQLDbconnection.Close()
            ConClose()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try

    End Sub


    '******************** FOR AdminAddProject_Form *******************

    ' Function to generate a random 3-character alphanumeric token
    Public Function GenerateRandomToken() As String
        Dim chars As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789,./[]\;'-="
        Dim rand As New Random()
        Return New String(Enumerable.Repeat(chars, 3).
                          Select(Function(s) s(rand.Next(s.Length))).ToArray())
    End Function

    ' Function to check if a token already exists
    Public Function IsTokenExists(token As String) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM Project_tb WHERE Token = @Token"
        Dim cmd As New SqlCommand(query, SQLDbconnection)
        cmd.Parameters.AddWithValue("@Token", token)

        ConOpen()
        Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
        ConClose()

        Return count > 0
    End Function

    ' Function to generate and set a unique token
    Sub SetUniqueToken()
        Dim uniqueToken As String = GenerateRandomToken()

        ' Keep generating new tokens until a unique one is found
        While IsTokenExists(uniqueToken)
            uniqueToken = GenerateRandomToken()
        End While

        ' Display the unique token in the textbox
        AdminAddProject_Form.txtToken.Text = uniqueToken
    End Sub

    Sub CheckToken()
        If AdminAddProject_Form.txtProjectTitle.Text = "" Then
            MsgBox("Please enter the project title.")
            AdminAddProject_Form.txtProjectTitle.Focus()

        ElseIf AdminAddProject_Form.txtToken.Text = "" Then
            MsgBox("Please enter a token.")
            AdminAddProject_Form.txtToken.Focus()

        ElseIf AdminAddProject_Form.cboTSG_Support.Text = "" Then
            MsgBox("Please enter the name of TSG support.")
            AdminAddProject_Form.txtTSGSupport.Focus()

        ElseIf AdminAddProject_Form.txtEmail.Text = "" Then
            MsgBox("Please enter the email of project owner.")
            AdminAddProject_Form.txtEmail.Focus()

        Else

            Dim Token As String = AdminAddProject_Form.txtToken.Text

            Try
                Dim MyData As String
                Dim cmd As New SqlCommand
                Dim Data As New DataTable
                Dim adap As New SqlDataAdapter
                'SQLDbconnection.Open()
                ConOpen()

                ' Define the SQL query with a parameter placeholder
                MyData = "SELECT * From Project_tb WHERE Token LIKE @ProjectToken"
                cmd.Connection = SQLDbconnection
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
                    SendToken_toProjectOwner()
                    Clicked_ProjectList()
                End If
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical)
            Finally
                'SQLDbconnection.Close()
                ConClose()
            End Try

        End If
    End Sub

    Sub Add_ProjectToken()
        Dim mycommand As String

        Dim NewToken As String = AdminAddProject_Form.txtToken.Text
        Dim NewProject As String = AdminAddProject_Form.txtProjectTitle.Text
        Dim Support As String = AdminAddProject_Form.cboTSG_Support.Text
        Dim TokenStatus As String = "Unused"
        Dim ProjectStatus As String = "Not Started"

        Try
            'SQLDbconnection.Open()
            mycommand = "INSERT INTO [Project_tb] ([Token],[Title], [TSG_Support], [Status], [TokenStatus]) 
                                VALUES (@Token, @ProjTitle, @Support, @Status, @TokenStat)"
            Using command As New SqlCommand(mycommand, SQLDbconnection)
                command.Parameters.AddWithValue("@Token", NewToken)
                command.Parameters.AddWithValue("@ProjTitle", NewProject)
                command.Parameters.AddWithValue("@Support", Support)
                command.Parameters.AddWithValue("@Status", ProjectStatus)
                command.Parameters.AddWithValue("@TokenStat", TokenStatus)
                command.ExecuteNonQuery()
            End Using
            'SQLDbconnection.Close()

            MsgBox("A new project has been successfully added.", MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try

    End Sub

    Sub Add_TitleForTask()
        Dim mycommand As String

        Dim NewToken As String = AdminAddProject_Form.txtToken.Text
        Dim NewProject As String = AdminAddProject_Form.txtProjectTitle.Text

        Try
            'SQLDbconnection.Open()
            mycommand = "INSERT INTO [ProActivity_tb] ([Token],[Title]) 
                                VALUES (@Token, @ProjTitle)"
            Using command As New SqlCommand(mycommand, SQLDbconnection)
                command.Parameters.AddWithValue("@Token", NewToken)
                command.Parameters.AddWithValue("@ProjTitle", NewProject)
                command.ExecuteNonQuery()
            End Using
            'SQLDbconnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Public ProID As String


    Sub Get_Project_ID()
        Dim NewToken As String = AdminAddProject_Form.txtToken.Text
        Try
            Dim MyData As String
            Dim cmd As New SqlCommand
            Dim Data As New DataTable
            Dim adap As New SqlDataAdapter
            'SQLDbconnection.Open()
            ConOpen()

            MyData = "SELECT * From Project_tb WHERE Token = '" & NewToken & "'"
            cmd.Connection = SQLDbconnection
            cmd.CommandText = MyData
            adap.SelectCommand = cmd

            adap.Fill(Data)

            If Data.Rows.Count > 0 Then

                ProID = Data.Rows(0).Item("ID").ToString
            End If
        Catch ex As Exception
            'MsgBox(ex.Message, vbCritical)
        Finally
            'SQLDbconnection.Close()
            ConClose()
        End Try
    End Sub


    Sub SendToken_toProjectOwner()

        Get_Project_ID()
        Try
            Dim EmailAdd As String = AdminAddProject_Form.txtEmail.Text
            Dim Recipients As String() = EmailAdd.Split(";"c)

            Dim CCEmailAdd As String = LFEmail
            Dim CCRecipients As String() = CCEmailAdd.Split(";"c)

            Dim SMTP As New SmtpClient

            Email = New MailMessage

            For Each Reciever As String In Recipients
                Email.To.Add(New MailAddress(Reciever.ToString()))
            Next

            ' Add CC recipients
            For Each CCReciever As String In CCRecipients
                If Not String.IsNullOrWhiteSpace(CCReciever) Then
                    Email.CC.Add(New MailAddress(CCReciever.ToString()))
                End If
            Next

            Email.From = New MailAddress("TSG_SoftwareProjectMS@littelfuse.com")
            Email.Subject = "New Project Request Token"
            Email.Body = "<div style='font-family: Arial, sans-serif; font-size: 12pt;'>Good day,<br><br>
                                        This is the token to add the details of your new project request. 
                                       <br><br> <b> Token: " & AdminAddProject_Form.txtToken.Text &
                                       "<br>Project ID: " & ProID &
                                       "</b> <br><br>If you don't have Software Project Management System App, please open then link below and click launch.<br><br>
                                        <b>Link:</b> <i> file://btwebdev01/Websites/WindowsAppUpdater/TSG_Shared/TSG%20Software%20Project%20Management%20System/Installer.htm</i> <br><br>
                                        If you don't have an account please sign up. <br>
                                        Thank you.</div>
                                        <br> <small style='color:Gray;'><i> This is a system generated mail. Please do not reply.</i></small>"
            Email.IsBodyHtml = True

            'AddHandler SMTP.SendCompleted, AddressOf SendCompletedCallback

            SMTP.Host = "mailrelay.america.littelfuse.com"
            SMTP.SendAsync(Email, Nothing)

            AdminAddProject_Form.txtProjectTitle.Clear()
            AdminAddProject_Form.txtToken.Clear()
            AdminAddProject_Form.txtTSGSupport.Clear()
            AdminAddProject_Form.txtEmail.Clear()

        Catch ex As Exception

            Console.WriteLine("An error occurred: " & ex.Message)
        End Try
    End Sub

    '******************** FOR AdminProjectList_Form *******************

    Public Sub HighlightDelayedProjects()
        Dim todayDate As Date = Date.Today

        ' Ensure the DataGridView is refreshed
        AdminProjectList_Form.DataGridView1.Refresh()
        Application.DoEvents()

        ' Iterate through each row
        For Each row As DataGridViewRow In AdminProjectList_Form.DataGridView1.Rows
            If Not row.IsNewRow Then
                Try
                    ' Ensure Due_Date and Status are not NULL
                    If Not IsDBNull(row.Cells("Due_Date").Value) AndAlso Not IsDBNull(row.Cells("Status").Value) Then
                        Dim dueDate As Date
                        Dim status As String = row.Cells("Status").Value.ToString().Trim()

                        ' Parse Due_Date to ensure it's a valid date
                        If Date.TryParse(row.Cells("Due_Date").Value.ToString(), dueDate) Then
                            ' Debugging Output
                            Debug.Print("Status: " & status & " | Due Date: " & dueDate.ToString("MM/dd/yyyy") & " | Today: " & todayDate.ToString("MM/dd/yyyy"))

                            ' Condition: If Status is "On-going" and Due_Date is before today
                            If status = "On-going" AndAlso dueDate < todayDate Then
                                row.Cells("Title").Style.BackColor = Color.Red
                                row.Cells("Title").Style.ForeColor = Color.White
                            End If
                        End If
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error processing row: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        Next
    End Sub

    Sub Show_AdminProjectList()
        Dim command As New SqlCommand("", SQLDbconnection)
        Dim table As New DataTable

        ' Open SQL connection
        ConOpen()

        If SQLDbconnection.State = ConnectionState.Open Then
            command.Connection = SQLDbconnection
            command.CommandText = "SELECT ID, Title, Owner, Department, Start_date, Due_Date, TSG_Support, Status, TokenStatus, Done_date " &
                              "FROM Project_tb ORDER BY Due_Date DESC"

            Dim rdr As SqlDataReader = command.ExecuteReader()
            table.Load(rdr)

            ' Bind data to DataGridView
            AdminProjectList_Form.DataGridView1.DataSource = table

            ' Format DataGridView
            For Each column As DataGridViewColumn In AdminProjectList_Form.DataGridView1.Columns
                column.HeaderCell.Style.Font = New Font("MS Reference Sans Serif", 11, FontStyle.Bold)
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                column.DefaultCellStyle.Font = New Font("MS Reference Sans Serif", 9)
            Next

            ' Adjust column widths
            AdminProjectList_Form.DataGridView1.Columns("ID").Width = 80
            AdminProjectList_Form.DataGridView1.Columns("Title").Width = 500
            AdminProjectList_Form.DataGridView1.Columns("Owner").Width = 200

            ' Rename column headers
            AdminProjectList_Form.DataGridView1.Columns("ID").HeaderText = "Project ID"
            AdminProjectList_Form.DataGridView1.Columns("TSG_Support").HeaderText = "TSG Support"
            AdminProjectList_Form.DataGridView1.Columns("Due_date").HeaderText = "Due Date"
            AdminProjectList_Form.DataGridView1.Columns("Start_date").HeaderText = "Start Date"
            AdminProjectList_Form.DataGridView1.Columns("TokenStatus").HeaderText = "Token Status"
            AdminProjectList_Form.DataGridView1.Columns("Done_date").HeaderText = "Done Date"

            ' Style alternating row colors
            AdminProjectList_Form.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(223, 228, 234)
            AdminProjectList_Form.DataGridView1.DefaultCellStyle.SelectionBackColor = Color.MediumSeaGreen
            AdminProjectList_Form.DataGridView1.DefaultCellStyle.SelectionForeColor = Color.White
            AdminProjectList_Form.DataGridView1.EnableHeadersVisualStyles = False
            AdminProjectList_Form.DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGreen

            ' Apply overdue highlighting
            HighlightDelayedProjects()

        End If

        ' Close connection
        ConClose()
    End Sub

    Sub Show_SupportProjects()
        ' Open the database connection
        ConOpen()

        If SQLDbconnection.State = ConnectionState.Open Then
            ' Use a parameterized query to prevent SQL injection
            Dim query As String = "SELECT ID, Title, Owner, Department, Start_date, Due_Date, TSG_Support, Status, TokenStatus, Done_date " &
                                  "FROM Project_tb " &
                                  "WHERE TSG_Support LIKE @TSGSupport " &
                                  "ORDER BY Due_Date DESC"

            ' Declare and initialize the command
            Using command As New SqlCommand(query, SQLDbconnection)
                ' Add the parameter
                command.Parameters.AddWithValue("@TSGSupport", "%" & AdminProjectList_Form.cboTSG_Support.Text & "%")

                ' Declare a DataTable to hold query results
                Dim table As New DataTable()

                ' Execute the query and load the results
                Using rdr As SqlDataReader = command.ExecuteReader()
                    table.Load(rdr)
                End Using

                ' Bind the results to the DataGridView
                AdminProjectList_Form.DataGridView1.DataSource = table

                ' Format the DataGridView
                For Each column As DataGridViewColumn In AdminProjectList_Form.DataGridView1.Columns
                    column.HeaderCell.Style.Font = New Font("MS Reference Sans Serif", 11, FontStyle.Bold)
                    column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    column.DefaultCellStyle.Font = New Font("MS Reference Sans Serif", 9)
                Next

                ' Adjust specific column headers
                AdminProjectList_Form.DataGridView1.Columns("ID").HeaderText = "Project ID"
                AdminProjectList_Form.DataGridView1.Columns("TSG_Support").HeaderText = "TSG Support"
                AdminProjectList_Form.DataGridView1.Columns("Due_date").HeaderText = "Due Date"
                AdminProjectList_Form.DataGridView1.Columns("Start_date").HeaderText = "Start Date"
                AdminProjectList_Form.DataGridView1.Columns("TokenStatus").HeaderText = "Token Status"
                AdminProjectList_Form.DataGridView1.Columns("Done_date").HeaderText = "Done Date"

                ' Set alternating row colors and selection styles
                AdminProjectList_Form.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(223, 228, 234)
                AdminProjectList_Form.DataGridView1.DefaultCellStyle.SelectionBackColor = Color.MediumSeaGreen
                AdminProjectList_Form.DataGridView1.DefaultCellStyle.SelectionForeColor = Color.White

                ' Disable default header styles and apply custom styles
                AdminProjectList_Form.DataGridView1.EnableHeadersVisualStyles = False
                AdminProjectList_Form.DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGreen
            End Using

            HighlightDelayedProjects()
        End If

        ' Close the database connection
        ConClose()

    End Sub

    Sub AdminProjectList_PopulateEdit()
        Try

            Dim mydata As String
            Dim command As New SqlCommand
            Dim data As New DataTable
            Dim adap As New SqlDataAdapter
            Dim val As String

            'SQLDbconnection.Open()
            ConOpen()

            val = AdminProjectList_Form.DataGridView1.SelectedCells.Item(0).Value.ToString()

            mydata = "SELECT * From Project_tb WHERE Title = '" & val & "'"
            command.Connection = SQLDbconnection
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
                'AdminProjectList_Form.txtA3name.Text = data.Rows(0).Item("FileName").ToString


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
            'SQLDbconnection.Close()
            ConClose()
        End Try
    End Sub

    Sub AdminProDetails_Form_Populate()
        Try
            ' Check if a row is selected in the DataGridView
            If AdminProjectList_Form.DataGridView1.SelectedCells.Count > 0 Then
                Dim selectedRowIndex As Integer = AdminProjectList_Form.DataGridView1.SelectedCells(0).RowIndex

                ' Ensure the row index is valid
                If selectedRowIndex >= 0 Then
                    ' Assuming "Title" is in column index 1 (adjust if needed)
                    Dim titleColumnIndex As Integer = 1
                    Dim selectedRow As DataGridViewRow = AdminProjectList_Form.DataGridView1.Rows(selectedRowIndex)

                    ' Get the title value from the specific column
                    Dim val As String = selectedRow.Cells(titleColumnIndex).Value?.ToString()

                    ' Ensure the value is not null or empty
                    If Not String.IsNullOrEmpty(val) Then
                        Dim command As New SqlCommand
                        Dim data As New DataTable
                        Dim adap As New SqlDataAdapter

                        ' Open the database connection
                        ConOpen()

                        ' Use parameterized query to prevent SQL Injection
                        Dim mydata As String = "SELECT * FROM Project_tb WHERE Title = @Title"
                        command.Connection = SQLDbconnection
                        command.CommandText = mydata
                        command.Parameters.AddWithValue("@Title", val)
                        adap.SelectCommand = command

                        ' Fill the DataTable with query results
                        adap.Fill(data)

                        ' If there is a matching record, populate the fields
                        If data.Rows.Count > 0 Then
                            With AdminProDetail_Form
                                .txtToken.Text = data.Rows(0).Item("Token").ToString()
                                .txtTitle.Text = data.Rows(0).Item("Title").ToString()
                                .txtDescr.Text = data.Rows(0).Item("Description").ToString()
                                .txtOwner.Text = data.Rows(0).Item("Owner").ToString()
                                .txtOwnersEmail.Text = data.Rows(0).Item("Email").ToString()
                                .txtMember.Text = data.Rows(0).Item("Member").ToString()
                                .txtMemEmails.Text = data.Rows(0).Item("Member_Emails").ToString()
                                .txtDept.Text = data.Rows(0).Item("Department").ToString()
                                .txtSupport.Text = data.Rows(0).Item("TSG_Support").ToString()
                                .cboStat.Text = data.Rows(0).Item("Status").ToString()
                                .dtpStartDate.Text = data.Rows(0).Item("Start_date").ToString()
                                .dtpDue.Text = data.Rows(0).Item("Due_date").ToString()
                                .cboTokenStat.Text = data.Rows(0).Item("TokenStatus").ToString()
                                .txtRemarks.Text = data.Rows(0).Item("Remarks").ToString()

                                ' Handle Due Date formatting
                                Dim due As Object = data.Rows(0).Item("Due_date")
                                If due Is DBNull.Value OrElse String.IsNullOrWhiteSpace(due.ToString()) Then
                                    .dtpDue.Format = DateTimePickerFormat.Custom
                                    .dtpDue.CustomFormat = " "
                                Else
                                    .dtpDue.Format = DateTimePickerFormat.Short
                                    .dtpDue.CustomFormat = due.ToString()
                                End If

                                ' Handle Start Date formatting
                                Dim start As Object = data.Rows(0).Item("Start_date")
                                If start Is DBNull.Value OrElse String.IsNullOrWhiteSpace(start.ToString()) Then
                                    .dtpStartDate.Format = DateTimePickerFormat.Custom
                                    .dtpStartDate.CustomFormat = " "
                                Else
                                    .dtpStartDate.Format = DateTimePickerFormat.Short
                                    .dtpStartDate.CustomFormat = start.ToString()
                                End If
                            End With
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Close the database connection
            ConClose()
        End Try
    End Sub

    Sub AdminProjetList_TextSearch()
        Try
            Dim Data As New DataTable
            Dim adap As New SqlDataAdapter
            Dim query As String

            If AdminProjectList_Form.txtSearch.Text = "" Or AdminProjectList_Form.txtSearch.Text = "Search Project" Then
                query = "Select ID, Title, Owner, Department, Start_date, Due_Date, TSG_Support, Status, TokenStatus, Done_date 
                        From Project_tb ORDER BY Due_Date DESC"
            Else
                query = "Select ID, Title, Owner, Department, Start_date, Due_Date, TSG_Support, Status, TokenStatus, Done_date From Project_tb 
                         WHERE Title LIKE @searchText ORDER BY Due_Date DESC"

                '"SELECT Part_Number, Qty FROM LineData_tb WHERE Part_Number LIKE @searchText"

            End If

            adap = New SqlDataAdapter(query, SQLDbconnection)

            If AdminProjectList_Form.txtSearch.Text <> "" Then
                adap.SelectCommand.Parameters.AddWithValue("@searchText", "%" & AdminProjectList_Form.txtSearch.Text & "%")
            End If

            'SQLDbconnection.Open()
            ConOpen()
            adap.Fill(Data)
            'SQLDbconnection.Close()
            ConClose()

            AdminProjectList_Form.DataGridView1.DataSource = Data


            ' Format the DataGridView
            For Each column As DataGridViewColumn In AdminProjectList_Form.DataGridView1.Columns
                column.HeaderCell.Style.Font = New Font("MS Reference Sans Serif", 11, FontStyle.Bold)
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                column.DefaultCellStyle.Font = New Font("MS Reference Sans Serif", 9)
            Next

            AdminProjectList_Form.DataGridView1.Columns("ID").HeaderText = "Project ID"
            AdminProjectList_Form.DataGridView1.Columns("TSG_Support").HeaderText = "TSG Support"
            AdminProjectList_Form.DataGridView1.Columns("Due_date").HeaderText = "Due Date"
            AdminProjectList_Form.DataGridView1.Columns("Due_date").HeaderText = "Due Date"
            AdminProjectList_Form.DataGridView1.Columns("TokenStatus").HeaderText = "Token Status"
            AdminProjectList_Form.DataGridView1.Columns("Done_date").HeaderText = "Done Date"
            'AdminProjectList_Form.DataGridView1.Columns("Member_Emails").HeaderText = "Member Emails"

            HighlightDelayedProjects()

        Catch ex As Exception
            'MsgBox(ex.Message, vbCritical)
        Finally
            If SQLDbconnection.State = ConnectionState.Open Then
                SQLDbconnection.Close()
            End If
        End Try
    End Sub

    Sub AdminProjectList_ShowTask()
        Try
            ' Enable editing for task-related fields
            With Task_Form
                .btnSave.Visible = True

                .txtTask1.ReadOnly = False
                .txtTask2.ReadOnly = False
                .txtTask3.ReadOnly = False
                .txtTask4.ReadOnly = False
                .txtTask5.ReadOnly = False

                .txtTask1_Owner.ReadOnly = False
                .txtTask2_Owner.ReadOnly = False
                .txtTask3_Owner.ReadOnly = False
                .txtTask4_Owner.ReadOnly = False
                .txtTask5_Owner.ReadOnly = False

                .DateTimePicker1.Enabled = True
                .DateTimePicker2.Enabled = True
                .DateTimePicker3.Enabled = True
                .DateTimePicker4.Enabled = True
                .DateTimePicker5.Enabled = True
            End With

            ' Check if at least one cell is selected
            If AdminProjectList_Form.DataGridView1.SelectedCells.Count > 0 Then
                Dim selectedRowIndex As Integer = AdminProjectList_Form.DataGridView1.SelectedCells(0).RowIndex

                ' Ensure row index is valid
                If selectedRowIndex >= 0 Then
                    ' Assuming "Title" is in column index 1 (adjust if needed)
                    Dim titleColumnIndex As Integer = 1
                    Dim selectedRow As DataGridViewRow = AdminProjectList_Form.DataGridView1.Rows(selectedRowIndex)

                    ' Retrieve the project title from the specified column
                    Dim val As String = selectedRow.Cells(titleColumnIndex).Value?.ToString()

                    ' Ensure value is not empty
                    If Not String.IsNullOrEmpty(val) Then
                        Dim command As New SqlCommand
                        Dim data As New DataTable
                        Dim adap As New SqlDataAdapter

                        ' Open database connection
                        ConOpen()

                        ' Use parameterized query to prevent SQL injection
                        Dim mydata As String = "SELECT * FROM ProActivity_tb WHERE Title = @Title"
                        command.Connection = SQLDbconnection
                        command.CommandText = mydata
                        command.Parameters.AddWithValue("@Title", val)
                        adap.SelectCommand = command

                        ' Fill the DataTable
                        adap.Fill(data)

                        ' If data is found, populate the form fields
                        If data.Rows.Count > 0 Then
                            'With Task_Form
                            '    .txtTask1.Text = data.Rows(0).Item("Task1").ToString()
                            '    .txtTask1_Owner.Text = data.Rows(0).Item("Task1_Owner").ToString()
                            '    SetDatePickerValue(.DateTimePicker1, data.Rows(0).Item("Task1_Due"))

                            '    .txtTask2.Text = data.Rows(0).Item("Task2").ToString()
                            '    .txtTask2_Owner.Text = data.Rows(0).Item("Task2_Owner").ToString()
                            '    SetDatePickerValue(.DateTimePicker2, data.Rows(0).Item("Task2_Due"))

                            '    .txtTask3.Text = data.Rows(0).Item("Task3").ToString()
                            '    .txtTask3_Owner.Text = data.Rows(0).Item("Task3_Owner").ToString()
                            '    SetDatePickerValue(.DateTimePicker3, data.Rows(0).Item("Task3_Due"))

                            '    .txtTask4.Text = data.Rows(0).Item("Task4").ToString()
                            '    .txtTask4_Owner.Text = data.Rows(0).Item("Task4_Owner").ToString()
                            '    SetDatePickerValue(.DateTimePicker4, data.Rows(0).Item("Task4_Due"))

                            '    .txtTask5.Text = data.Rows(0).Item("Task5").ToString()
                            '    .txtTask5_Owner.Text = data.Rows(0).Item("Task5_Owner").ToString()
                            '    SetDatePickerValue(.DateTimePicker5, data.Rows(0).Item("Task5_Due"))

                            '    .GroupBoxProj.Text = val ' Set the group box title
                            'End With


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
                    End If
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Close the database connection
            ConClose()
        End Try
    End Sub

    Sub SetDatePickerValue(dtp As DateTimePicker, value As Object)
        If value Is DBNull.Value OrElse String.IsNullOrWhiteSpace(value.ToString()) Then
            dtp.Format = DateTimePickerFormat.Custom
            dtp.CustomFormat = " "
        Else
            dtp.Format = DateTimePickerFormat.Short
            dtp.CustomFormat = value.ToString()
        End If
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

                '' Save File
                'If Not String.IsNullOrEmpty(AdminProjectList_Form.txtA3name.Text) Then
                '    Dim filePath As String = AdminProjectList_Form.txtA3name.Text
                '    Dim fileName As String = Path.GetFileName(filePath)
                '    Dim fileData As Byte() = File.ReadAllBytes(filePath)
                '    Try
                '        'SQLDbconnection.Open()
                '        ConOpen()

                '        Using command As New sqlCommand("UPDATE Project_tb SET FileName = @FileName, A3 = @FileData 
                '                                WHERE Token = @proToken", SQLDbconnection)
                '            command.Parameters.AddWithValue("@FileName", fileName)
                '            command.Parameters.AddWithValue("@FileData", fileData)
                '            command.Parameters.AddWithValue("@proToken", Token)
                '            command.ExecuteNonQuery()
                '        End Using
                '        'SQLDbconnection.Close()
                '        ConClose()

                '    Catch ex As Exception
                '        MsgBox(ex.Message, vbCritical)
                '    End Try
                'End If

                Using command As New SqlCommand(query, SQLDbconnection)
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
                    'SQLDbconnection.Open()
                    ConOpen()
                    command.ExecuteNonQuery()
                    'SQLDbconnection.Close()
                End Using

                Dim query2 As String = "UPDATE ProActivity_tb SET Title = @Project_Title WHERE Token = @proTitle"

                Using command2 As New SqlCommand(query2, SQLDbconnection)
                    command2.Parameters.AddWithValue("@Project_Title", Title)
                    command2.Parameters.AddWithValue("@proTitle", Token)
                    'SQLDbconnection.Open()
                    command2.ExecuteNonQuery()
                    'SQLDbconnection.Close()
                    ConClose()
                End Using


                Show_AdminProjectList()
                MsgBox("Changes were successfully saved", MessageBoxIcon.Information)

            Catch ex As Exception
                MsgBox(ex.Message, vbCritical)
            End Try
        End If
    End Sub

    Sub AdminProDetails_Form_Update()
        If AdminProDetail_Form.txtTitle.Text = "" Then
            MsgBox("Please the title of project!", MsgBoxStyle.Critical)
            AdminProDetail_Form.txtTitle.Focus()

        ElseIf AdminProDetail_Form.txtDescr.Text = "" Then
            MsgBox("Please enter project description!", MsgBoxStyle.Critical)
            AdminProDetail_Form.txtDescr.Focus()

        ElseIf AdminProDetail_Form.txtOwner.Text = "" Then
            MsgBox("Please enter the name of project owner!", MsgBoxStyle.Critical)
            AdminProDetail_Form.txtOwner.Focus()

        ElseIf AdminProDetail_Form.txtOwnersEmail.Text = "" Then
            MsgBox("Please enter the email of project owner!", MsgBoxStyle.Critical)
            AdminProDetail_Form.txtOwnersEmail.Focus()

        ElseIf AdminProDetail_Form.txtMember.Text = "" Then
            MsgBox("Please enter name of member!", MsgBoxStyle.Critical)
            AdminProDetail_Form.txtMember.Focus()

        ElseIf AdminProDetail_Form.txtMemEmails.Text = "" Then
            MsgBox("Please enter the email(s) of member!", MsgBoxStyle.Critical)
            AdminProDetail_Form.txtMemEmails.Focus()

        ElseIf AdminProDetail_Form.txtDept.Text = "" Then
            MsgBox("Please enter the department!", MsgBoxStyle.Critical)
            AdminProDetail_Form.txtDept.Focus()

        ElseIf AdminProDetail_Form.txtSupport.Text = "" Then
            MsgBox("Please enter name of support!", MsgBoxStyle.Critical)
            AdminProDetail_Form.txtSupport.Focus()

        Else
            If AdminProDetail_Form.cboStat.Text = "Done" Then
                Try

                    Dim done As Date = Date.Now.ToString("MM/dd/yyyy")

                    Dim Token As String = AdminProDetail_Form.txtToken.Text

                    Dim Title As String = AdminProDetail_Form.txtTitle.Text
                    Dim Description As String = AdminProDetail_Form.txtDescr.Text
                    Dim Project_Owner As String = AdminProDetail_Form.txtOwner.Text
                    Dim Owners_Email As String = AdminProDetail_Form.txtOwnersEmail.Text
                    Dim Member As String = AdminProDetail_Form.txtMember.Text
                    Dim Member_Email As String = AdminProDetail_Form.txtMemEmails.Text
                    Dim Department As String = AdminProDetail_Form.txtDept.Text
                    Dim Support As String = AdminProDetail_Form.txtSupport.Text
                    Dim Stats As String = AdminProDetail_Form.cboStat.Text
                    Dim TokenStats As String = AdminProDetail_Form.cboTokenStat.Text
                    Dim Start As String = AdminProDetail_Form.dtpStartDate.Text
                    Dim Due As String = AdminProDetail_Form.dtpDue.Text
                    Dim Remarks As String = AdminProDetail_Form.txtRemarks.Text

                    Dim query As String = "UPDATE Project_tb 
                                        SET Title = @Title, Description = @Desc, Owner = @Owner, Email = @ManEmail, Member = @Mem, 
                                        Member_Emails = @MemEmails, Department = @Dept, TSG_Support = @Support, 
                                        Status = @Stat, TokenStatus = @TokenStats, Start_date = @start, Due_date = @Duedate, Done_date = @Done, Remarks = @rem 
                                        WHERE Token = @proTitle"

                    '' Save File
                    'If Not String.IsNullOrEmpty(AdminProDetail_Form.txtA3name.Text) Then
                    '    Dim filePath As String = AdminProDetail_Form.txtA3name.Text
                    '    Dim fileName As String = Path.GetFileName(filePath)
                    '    Dim fileData As Byte() = File.ReadAllBytes(filePath)
                    '    Try
                    '        'SQLDbconnection.Open()
                    '        ConOpen()

                    '        Using command As New sqlCommand("UPDATE Project_tb SET FileName = @FileName, A3 = @FileData 
                    '                                WHERE Token = @proToken", SQLDbconnection)
                    '            command.Parameters.AddWithValue("@FileName", fileName)
                    '            command.Parameters.AddWithValue("@FileData", fileData)
                    '            command.Parameters.AddWithValue("@proToken", Token)
                    '            command.ExecuteNonQuery()
                    '        End Using
                    '        'SQLDbconnection.Close()
                    '        ConClose()

                    '    Catch ex As Exception
                    '        MsgBox(ex.Message, vbCritical)
                    '    End Try
                    'End If

                    Using command As New SqlCommand(query, SQLDbconnection)
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
                        command.Parameters.AddWithValue("@Done", done)
                        command.Parameters.AddWithValue("@rem", Remarks)
                        command.Parameters.AddWithValue("@proTitle", Token)
                        'SQLDbconnection.Open()
                        ConOpen()
                        command.ExecuteNonQuery()
                        'SQLDbconnection.Close()
                    End Using

                    Dim query2 As String = "UPDATE ProActivity_tb SET Title = @Project_Title WHERE Token = @proTitle"

                    Using command2 As New SqlCommand(query2, SQLDbconnection)
                        command2.Parameters.AddWithValue("@Project_Title", Title)
                        command2.Parameters.AddWithValue("@proTitle", Token)
                        'SQLDbconnection.Open()
                        command2.ExecuteNonQuery()
                        'SQLDbconnection.Close()
                        ConClose()
                    End Using

                    If AdminProjectList_Form.cboTSG_Support.Text = Nothing Or AdminProjectList_Form.cboTSG_Support.Text = "All" Then
                        Show_AdminProjectList()
                        MsgBox("Changes were successfully saved", MessageBoxIcon.Information)
                        AdminProDetail_Form.Close()
                    Else
                        Show_SupportProjects()
                        MsgBox("Changes were successfully saved", MessageBoxIcon.Information)
                        AdminProDetail_Form.Close()
                    End If

                Catch ex As Exception
                    MsgBox(ex.Message, vbCritical)
                End Try

            ElseIf AdminProDetail_Form.cboStat.Text = "Canceled" Then

                Dim ProTok As String = AdminProDetail_Form.txtToken.Text
                CopyData_to_Canceledtb(ProTok)
                DeleteProject(ProTok)
                DeleteProject_Task(ProTok)

            Else
                Try
                    Dim Token As String = AdminProDetail_Form.txtToken.Text

                    Dim Title As String = AdminProDetail_Form.txtTitle.Text
                    Dim Description As String = AdminProDetail_Form.txtDescr.Text
                    Dim Project_Owner As String = AdminProDetail_Form.txtOwner.Text
                    Dim Owners_Email As String = AdminProDetail_Form.txtOwnersEmail.Text
                    Dim Member As String = AdminProDetail_Form.txtMember.Text
                    Dim Member_Email As String = AdminProDetail_Form.txtMemEmails.Text
                    Dim Department As String = AdminProDetail_Form.txtDept.Text
                    Dim Support As String = AdminProDetail_Form.txtSupport.Text
                    Dim Stats As String = AdminProDetail_Form.cboStat.Text
                    Dim TokenStats As String = AdminProDetail_Form.cboTokenStat.Text
                    Dim Start As String = AdminProDetail_Form.dtpStartDate.Text
                    Dim Due As String = AdminProDetail_Form.dtpDue.Text
                    Dim Remarks As String = AdminProDetail_Form.txtRemarks.Text

                    Dim query As String = "UPDATE Project_tb 
                                        SET Title = @Title, Description = @Desc, Owner = @Owner, Email = @ManEmail, Member = @Mem, 
                                        Member_Emails = @MemEmails, Department = @Dept, TSG_Support = @Support,
                                        Status = @Stat, TokenStatus = @TokenStats, Start_date = @start, Due_date = @Duedate, Remarks = @rem 
                                        WHERE Token = @proTitle"

                    '' Save File
                    'If Not String.IsNullOrEmpty(AdminProDetail_Form.txtA3name.Text) Then
                    '    Dim filePath As String = AdminProDetail_Form.txtA3name.Text
                    '    Dim fileName As String = Path.GetFileName(filePath)
                    '    Dim fileData As Byte() = File.ReadAllBytes(filePath)
                    '    Try
                    '        'SQLDbconnection.Open()
                    '        ConOpen()

                    '        Using command As New sqlCommand("UPDATE Project_tb SET FileName = @FileName, A3 = @FileData 
                    '                                WHERE Token = @proToken", SQLDbconnection)
                    '            command.Parameters.AddWithValue("@FileName", fileName)
                    '            command.Parameters.AddWithValue("@FileData", fileData)
                    '            command.Parameters.AddWithValue("@proToken", Token)
                    '            command.ExecuteNonQuery()
                    '        End Using
                    '        'SQLDbconnection.Close()
                    '        ConClose()

                    '    Catch ex As Exception
                    '        MsgBox(ex.Message, vbCritical)
                    '    End Try
                    'End If

                    Using command As New SqlCommand(query, SQLDbconnection)
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
                        command.Parameters.AddWithValue("@rem", Remarks)
                        command.Parameters.AddWithValue("@proTitle", Token)
                        'SQLDbconnection.Open()
                        ConOpen()
                        command.ExecuteNonQuery()
                        'SQLDbconnection.Close()
                    End Using

                    Dim query2 As String = "UPDATE ProActivity_tb SET Title = @Project_Title WHERE Token = @proTitle"

                    Using command2 As New SqlCommand(query2, SQLDbconnection)
                        command2.Parameters.AddWithValue("@Project_Title", Title)
                        command2.Parameters.AddWithValue("@proTitle", Token)
                        'SQLDbconnection.Open()
                        command2.ExecuteNonQuery()
                        'SQLDbconnection.Close()
                        ConClose()
                    End Using


                    If AdminProjectList_Form.cboTSG_Support.Text = Nothing Or AdminProjectList_Form.cboTSG_Support.Text = "All" Then
                        Show_AdminProjectList()
                        MsgBox("Changes were successfully saved", MessageBoxIcon.Information)
                        AdminProDetail_Form.Close()
                    Else
                        Show_SupportProjects()
                        MsgBox("Changes were successfully saved", MessageBoxIcon.Information)
                        AdminProDetail_Form.Close()
                    End If

                Catch ex As Exception
                    MsgBox(ex.Message, vbCritical)
                End Try

            End If
        End If

    End Sub

    Sub TaskTitleChanged()
        Try
            Dim Token As String = AdminProjectList_Form.txtToken.Text
            Dim Title As String = AdminProjectList_Form.txtTitle.Text

            Dim query As String = "UPDATE ProActivity_tb SET Title = @Project_Title WHERE Token = @proTitle"

            Using command As New SqlCommand(query, SQLDbconnection)
                command.Parameters.AddWithValue("@Project_Title", Title)
                command.Parameters.AddWithValue("@proTitle", Token)
                'SQLDbconnection.Open()
                ConOpen()
                command.ExecuteNonQuery()
                'SQLDbconnection.Close()
                ConClose()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Sub CopyData_to_Canceledtb(ProTok As String)
        Try
            ConOpen()

            ' Explicitly specify all columns except ID
            Dim query As String = "INSERT INTO CanceledProject_tb (Token, Title, Description, Owner, Email, " &
                              "Department, Member, Member_Emails, TSG_Support, Status, Start_date, Due_date, TokenStatus, " &
                              "FileName, A3, Done_date, Remarks)" &
                              "SELECT Token, Title, Description, Owner, Email, " &
                              "Department, Member, Member_Emails, TSG_Support, Status, Start_date, Due_date, TokenStatus, " &
                              "FileName, A3, Done_date, Remarks " &
                              "FROM Project_tb WHERE Token = @token"

            Using cmd As New SqlCommand(query, SQLDbconnection)
                cmd.Parameters.AddWithValue("@token", ProTok)
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    Console.WriteLine(rowsAffected.ToString() & " record(s) copied successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    Console.WriteLine("No records found with the given Token.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ConClose()
        End Try
    End Sub

    Sub DeleteProject(ProTok As String)
        Try
            ConOpen()

            Dim sql As String = "DELETE FROM Project_tb WHERE Token = @Token"

            Using cmd As New SqlCommand(sql, SQLDbconnection)
                cmd.Parameters.AddWithValue("@Token", ProTok)

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                Console.WriteLine(rowsAffected & " records deleted from Project_tb.")
            End Using

            ConClose()

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbCritical, "Database Error")
        End Try
    End Sub

    Sub DeleteProject_Task(ProTok As String)
        Try
            ConOpen()

            Dim sql As String = "DELETE FROM ProActivity_tb WHERE Token = @Token"

            Using cmd As New SqlCommand(sql, SQLDbconnection)
                cmd.Parameters.AddWithValue("@Token", ProTok)

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                Console.WriteLine(rowsAffected & " records deleted from ProActivity_tb.")
            End Using

            ConClose()

            If AdminProjectList_Form.cboTSG_Support.Text = Nothing Or AdminProjectList_Form.cboTSG_Support.Text = "All" Then
                Show_AdminProjectList()
                MsgBox("Changes were successfully saved", MessageBoxIcon.Information)
                AdminProDetail_Form.Close()
            Else
                Show_SupportProjects()
                MsgBox("Changes were successfully saved", MessageBoxIcon.Information)
                AdminProDetail_Form.Close()
            End If

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbCritical, "Database Error")
        End Try
    End Sub


    Sub Aadmin_Count_TotalPro()

        Dim totalQuery As String = "SELECT COUNT(*) FROM Project_tb"
        Dim statusQuery As String = "
        SELECT 
            SUM(CASE WHEN Status = 'Done' THEN 1 ELSE 0 END) AS DoneCount,
            SUM(CASE WHEN Status = 'On Hold' THEN 1 ELSE 0 END) AS OnHoldCount,
            SUM(CASE WHEN Status = 'On-going' THEN 1 ELSE 0 END) AS OnGoingCount,
            SUM(CASE WHEN Status = 'Not Started' THEN 1 ELSE 0 END) AS NotStartedCount
        FROM Project_tb"

        ConOpen()

        ' Get total count
        Using command As New SqlCommand(totalQuery, SQLDbconnection)
            Dim rowCount As Integer = CInt(command.ExecuteScalar())
            AdminProjectList_Form.lblTotal.Text = rowCount
        End Using

        ' Get status-wise count
        Using command As New SqlCommand(statusQuery, SQLDbconnection)
            Using reader As SqlDataReader = command.ExecuteReader()
                If reader.Read() Then
                    AdminProjectList_Form.lblDone.Text = reader("DoneCount").ToString()
                    AdminProjectList_Form.lblOnHold.Text = reader("OnHoldCount").ToString()
                    AdminProjectList_Form.lblOnGoing.Text = reader("OnGoingCount").ToString()
                    AdminProjectList_Form.lblNotStarted.Text = reader("NotStartedCount").ToString()
                End If
            End Using
        End Using

        ConClose()
    End Sub

    Sub Count_TotalProjects()

        Dim count_query As String = "SELECT COUNT(*) FROM Project_tb"

        ConOpen()

        Using command As New SqlCommand(count_query, SQLDbconnection)
            Dim rowCount As Integer = CInt(command.ExecuteScalar())
            'Console.WriteLine(rowCount)
            AdminProjectList_Form.lblTotal.Text = rowCount
        End Using
        ConClose()
    End Sub

    Sub Admin_Count_Projects_Support()

        Dim selectedSupport As String = AdminProjectList_Form.cboTSG_Support.Text

        Dim totalQuery As String = "SELECT COUNT(*) FROM Project_tb WHERE TSG_Support = @Support"
        Dim statusQuery As String = "
        SELECT 
            SUM(CASE WHEN Status = 'Done' THEN 1 ELSE 0 END) AS DoneCount,
            SUM(CASE WHEN Status = 'On Hold' THEN 1 ELSE 0 END) AS OnHoldCount,
            SUM(CASE WHEN Status = 'On-going' THEN 1 ELSE 0 END) AS OnGoingCount,
            SUM(CASE WHEN Status = 'Not Started' THEN 1 ELSE 0 END) AS NotStartedCount
        FROM Project_tb
        WHERE TSG_Support = @Support"

        ConOpen()

        ' Get total count
        Using command As New SqlCommand(totalQuery, SQLDbconnection)
            command.Parameters.AddWithValue("@Support", selectedSupport)
            Dim rowCount As Integer = CInt(command.ExecuteScalar())
            AdminProjectList_Form.lblTotal.Text = rowCount
        End Using

        ' Get status-wise count
        Using command As New SqlCommand(statusQuery, SQLDbconnection)
            command.Parameters.AddWithValue("@Support", selectedSupport)
            Using reader As SqlDataReader = command.ExecuteReader()
                If reader.Read() Then
                    AdminProjectList_Form.lblDone.Text = reader("DoneCount").ToString()
                    AdminProjectList_Form.lblOnHold.Text = reader("OnHoldCount").ToString()
                    AdminProjectList_Form.lblOnGoing.Text = reader("OnGoingCount").ToString()
                    AdminProjectList_Form.lblNotStarted.Text = reader("NotStartedCount").ToString()
                End If
            End Using
        End Using

        ConClose()
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

            Using command As New SqlCommand(query, SQLDbconnection)

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
                'SQLDbconnection.Open()
                ConOpen()
                command.ExecuteNonQuery()
                'SQLDbconnection.Close()
                ConClose()
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
                'SQLDbconnection.Open()
                ConOpen()
                mycommand = "INSERT INTO [Password_tb] ([Username],[Firstname], [Lastname], [AccessLevel], [Pass], [Email]) 
                                VALUES (@Uname, @Fname, @Lname, @Acclvl, @PW, @LFemail)"
                Using command As New SqlCommand(mycommand, SQLDbconnection)
                    command.Parameters.AddWithValue("@Uname", Uname)
                    command.Parameters.AddWithValue("@Fname", Fname)
                    command.Parameters.AddWithValue("@Lname", Lname)
                    command.Parameters.AddWithValue("@Acclvl", AccessLVL)
                    command.Parameters.AddWithValue("@PW", ConfirmPW)
                    command.Parameters.AddWithValue("@LFemail", LFEmail)
                    command.ExecuteNonQuery()
                End Using
                'SQLDbconnection.Close()
                ConClose()

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
            Dim cmd As New SqlCommand
            Dim Data As New DataTable
            Dim adap As New SqlDataAdapter
            'SQLDbconnection.Open()
            ConOpen()

            ' Define the SQL query with a parameter placeholder
            MyData = "SELECT * From Password_tb WHERE Username LIKE @USERnm"
            cmd.Connection = SQLDbconnection
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
            'SQLDbconnection.Close()
            ConClose()
        End Try
    End Sub

    Sub Check_UserNameKeyUp()
        Dim Username As String = SignUp_Form.txtUsername.Text

        Try
            Dim MyData As String
            Dim cmd As New SqlCommand
            Dim Data As New DataTable
            Dim adap As New SqlDataAdapter
            'SQLDbconnection.Open()
            ConOpen()

            ' Define the SQL query with a parameter placeholder
            MyData = "SELECT * From Password_tb WHERE Username LIKE @USERnm"
            cmd.Connection = SQLDbconnection
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
            'SQLDbconnection.Close()
            ConClose()
        End Try
    End Sub


    '******************** Checking if PROJECT is DELAY *******************
    Private Email As MailMessage

    Sub CheckDelay()
        Dim query As String = "SELECT Title, Owner, Email FROM Project_tb WHERE Due_date < @Today AND Status <> 'Done'"

        ' Get today's date
        Dim today As Date = Date.Now.ToString("MM/dd/yyyy")

        Dim command As New SqlCommand(query, SQLDbconnection)
        command.Parameters.AddWithValue("@Today", today)

        Try
            'SQLDbconnection.Open()
            Dim reader As SqlDataReader = command.ExecuteReader()

            If reader.HasRows Then

                Console.WriteLine("The following tasks have a due date greater than today and status not 'Done':")
                While reader.Read()
                    Dim title As String = reader("Title").ToString()
                    Dim Manager As String = reader("Owner").ToString()
                    Dim OwnerEmail As String = reader("Email").ToString()
                    Console.WriteLine("Title: " & title)
                    Console.WriteLine("Owner: " & Manager)
                    Console.WriteLine("Email: " & OwnerEmail)
                    Console.WriteLine()

                    Try
                        Dim EmailAdd As String = OwnerEmail
                        Dim Recipients As String() = EmailAdd.Split(";"c)

                        Dim CCEmailAdd As String = "gcatapang@littelfuse.com; ibayer@littelfuse.com; mroxas2@littelfuse.com; bmanalo@littelfuse.com"
                        Dim CCRecipients As String() = CCEmailAdd.Split(";"c)

                        Dim SMTP As New SmtpClient

                        Email = New MailMessage

                        For Each Reciever As String In Recipients
                            Email.To.Add(New MailAddress(Reciever.ToString()))
                        Next

                        ' Add CC recipients
                        For Each CCReciever As String In CCRecipients
                            If Not String.IsNullOrWhiteSpace(CCReciever) Then
                                Email.CC.Add(New MailAddress(CCReciever.ToString()))
                            End If
                        Next


                        Email.From = New MailAddress("TSG_SoftwareProjectMS@littelfuse.com")
                        Email.Subject = "Software Project Delay Notification"
                        Email.Body = "<div style='font-family: Arial, sans-serif; font-size: 12pt;'>Hi " & Manager &
                                                    ",<br><br>Your project titled " & title & " is delayed. <br>
                                                   Kindly visit Project Management System to view your requested projects. 
                                                    <br><br>Thank you. </div>
                                                    <br> <small style='color:Gray;'><i> This is a system generated mail. Please do not reply.</i></small>"


                        Email.IsBodyHtml = True

                        'AddHandler SMTP.SendCompleted, AddressOf SendCompletedCallback

                        SMTP.Host = "mailrelay.america.littelfuse.com"
                        SMTP.SendAsync(Email, Nothing)

                    Catch ex As Exception
                        Console.WriteLine("An error occurred: " & ex.Message)
                    End Try

                End While

                'SQLDbconnection.Close()
                ConClose()
                'Update_DateToday() 'app.config
                Update_Ydate() 'database

            Else
                'SQLDbconnection.Close()
                ConClose()
                'Update_DateToday() 'app.config
                Update_Ydate() 'database
                Console.WriteLine("All tasks are either due today or earlier, or are marked as 'Done'.")
            End If
            reader.Close()
        Catch ex As Exception

            Console.WriteLine("An error occurred: " & ex.Message)
        End Try
    End Sub
    Public LastDateCheck As String
    Sub CheckLastDate()
        Try

            Dim ystd As String = "_Yesterdate"

            Dim MyData As String
            Dim cmd As New SqlCommand
            Dim Data As New DataTable
            Dim adap As New SqlDataAdapter
            'SQLDbconnection.Open()
            ConOpen()

            ' Define the SQL query with a parameter placeholder
            MyData = "SELECT * From SentChecker_tb WHERE Sent_Ver LIKE @LastDtSaved"
            cmd.Connection = SQLDbconnection
            cmd.CommandText = MyData

            ' Add the parameter value with wildcard characters
            cmd.Parameters.AddWithValue("@LastDtSaved", "%" & ystd & "%")

            adap.SelectCommand = cmd
            adap.Fill(Data)

            If Data.Rows.Count > 0 Then

                Dim date_ystdy As String
                Dim date_now As String = Date.Now.ToString("MM/dd/yyyy")

                date_ystdy = Data.Rows(0).Item("Ydate").ToString
                LastDateCheck = Data.Rows(0).Item("Ydate").ToString
                Console.WriteLine(date_ystdy)
                Console.WriteLine(date_now)

                If date_ystdy = date_now Then
                Else
                    CheckDelay()
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            'SQLDbconnection.Close()
            ConClose()
        End Try
    End Sub

    Sub Update_Ydate()
        Try
            Dim ystd As String = "_Yesterdate"
            Dim date_now As String = Date.Now.ToString("MM/dd/yyyy")

            Dim query As String = "UPDATE SentChecker_tb SET Ydate = @datenow WHERE Sent_Ver = @Ystday"

            Using command As New SqlCommand(query, SQLDbconnection)
                command.Parameters.AddWithValue("@datenow", date_now)
                command.Parameters.AddWithValue("@Ystday", ystd)
                'SQLDbconnection.Open()
                ConOpen()
                command.ExecuteNonQuery()
                'SQLDbconnection.Close()
                ConClose()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub


    '******************** FOR AdminDLA3_Form *******************

    Sub Show_A3List()
        Dim command As New SqlCommand("", SQLDbconnection)
        Dim table As New DataTable

        'SQLDbconnection.Open()
        ConOpen()

        If SQLDbconnection.State = ConnectionState.Open Then
            command.Connection = SQLDbconnection
            command.CommandText = "Select ID, Title, TSG_Support, FileName From Project_tb ORDER BY Due_Date DESC"

            '"Select Title, Description, Owner, Email, Member, 
            '                       Member_Emails, Department, Due_Date, TSG_Support, Status, TokenStatus From Project_tb"

            Dim rdr As SqlDataReader = command.ExecuteReader

            table.Load(rdr)

            AdminDLA3_Form.DataGridView1.DataSource = table

            ' Bold the header cells
            For Each column As DataGridViewColumn In AdminDLA3_Form.DataGridView1.Columns
                column.HeaderCell.Style.Font = New Font("MS Reference Sans Serif", 11, FontStyle.Bold)
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                column.DefaultCellStyle.Font = New Font("MS Reference Sans Serif", 9)
            Next

            AdminDLA3_Form.DataGridView1.Columns("ID").Width = 80
            AdminDLA3_Form.DataGridView1.Columns("TSG_Support").Width = 200
            AdminDLA3_Form.DataGridView1.Columns("FileName").Width = 400
            AdminDLA3_Form.DataGridView1.Columns("ID").HeaderText = "Project ID"
            AdminDLA3_Form.DataGridView1.Columns("FileName").HeaderText = "A3 file name"
            AdminDLA3_Form.DataGridView1.Columns("TSG_Support").HeaderText = "TSG Support"

            AdminDLA3_Form.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(223, 228, 234)
            AdminDLA3_Form.DataGridView1.DefaultCellStyle.SelectionBackColor = Color.MediumSeaGreen
            AdminDLA3_Form.DataGridView1.DefaultCellStyle.SelectionForeColor = Color.White

            AdminDLA3_Form.DataGridView1.EnableHeadersVisualStyles = False
            AdminDLA3_Form.DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGreen
        End If
        'SQLDbconnection.Close()
        ConClose()
    End Sub

    Public Admin_Val_A3 As String

    Sub AdminDLA3_Populate()
        Try
            ' Ensure at least one cell is selected
            If AdminDLA3_Form.DataGridView1.SelectedCells.Count > 0 Then
                Dim selectedRowIndex As Integer = AdminDLA3_Form.DataGridView1.SelectedCells(0).RowIndex

                ' Ensure row index is valid
                If selectedRowIndex >= 0 Then
                    ' Assuming "Title" is in column index 1 (adjust if needed)
                    Dim titleColumnIndex As Integer = 1
                    Dim selectedRow As DataGridViewRow = AdminDLA3_Form.DataGridView1.Rows(selectedRowIndex)

                    ' Retrieve the project title from the specified column
                    Dim Admin_Val_A3 As String = selectedRow.Cells(titleColumnIndex).Value?.ToString()

                    ' Ensure value is not empty
                    If Not String.IsNullOrEmpty(Admin_Val_A3) Then
                        Dim query As String = "SELECT FileName FROM Project_tb WHERE Title = @Title"

                        ' Open database connection
                        ConOpen()

                        ' Use "Using" to properly dispose of objects
                        Using command As New SqlCommand(query, SQLDbconnection)
                            command.Parameters.AddWithValue("@Title", Admin_Val_A3)

                            Using adapter As New SqlDataAdapter(command)
                                Using data As New DataTable()
                                    adapter.Fill(data)

                                    ' If data is found, populate the filename text field
                                    If data.Rows.Count > 0 Then
                                        AdminDLA3_Form.txtFileName.Text = data.Rows(0).Item("FileName").ToString()
                                    End If
                                End Using
                            End Using
                        End Using
                    End If
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Close the database connection
            ConClose()
        End Try

    End Sub

    Sub AdminDLA3_txtSearch()
        Try
            Dim Data As New DataTable
            Dim adap As New SqlDataAdapter
            Dim query As String

            If AdminDLA3_Form.txtSearch.Text = "" Or AdminDLA3_Form.txtSearch.Text = "Search Project" Then
                query = "Select ID, Title, TSG_Support, FileName From Project_tb ORDER BY Due_Date DESC"
            Else
                query = "Select ID, Title, TSG_Support, FileName From Project_tb WHERE Title LIKE @searchText ORDER BY Due_Date DESC"

                '"SELECT Part_Number, Qty FROM LineData_tb WHERE Part_Number LIKE @searchText"

            End If

            adap = New SqlDataAdapter(query, SQLDbconnection)

            If AdminDLA3_Form.txtSearch.Text <> "" Then
                adap.SelectCommand.Parameters.AddWithValue("@searchText", "%" & AdminDLA3_Form.txtSearch.Text & "%")
            End If

            'SQLDbconnection.Open()
            ConOpen()
            adap.Fill(Data)
            'SQLDbconnection.Close()
            ConClose()

            AdminDLA3_Form.DataGridView1.DataSource = Data

            ' Bold the header cells
            For Each column As DataGridViewColumn In AdminDLA3_Form.DataGridView1.Columns
                column.HeaderCell.Style.Font = New Font("MS Reference Sans Serif", 11, FontStyle.Bold)
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                column.DefaultCellStyle.Font = New Font("MS Reference Sans Serif", 9)
            Next

            AdminDLA3_Form.DataGridView1.Columns("ID").HeaderText = "Project ID"
            AdminDLA3_Form.DataGridView1.Columns("FileName").HeaderText = "A3 file name"
            AdminDLA3_Form.DataGridView1.Columns("TSG_Support").HeaderText = "TSG Support"

            AdminDLA3_Form.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(223, 228, 234)
            AdminDLA3_Form.DataGridView1.DefaultCellStyle.SelectionBackColor = Color.MediumSeaGreen
            AdminDLA3_Form.DataGridView1.DefaultCellStyle.SelectionForeColor = Color.White

            AdminDLA3_Form.DataGridView1.EnableHeadersVisualStyles = False
            AdminDLA3_Form.DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGreen

        Catch ex As Exception
            'MsgBox(ex.Message, vbCritical)
        Finally
            If SQLDbconnection.State = ConnectionState.Open Then
                SQLDbconnection.Close()
            End If
        End Try
    End Sub

    Sub DownloadA3()
        Dim outputFilePath As String = AdminDLA3_Form.txtLocation.Text
        Dim name As String = AdminDLA3_Form.txtFileName.Text

        Try

            'SQLDbconnection.Open()
            ConOpen()

            Using command As New SqlCommand("SELECT FileName, A3 FROM Project_tb WHERE FileName = @Name", SQLDbconnection)
                command.Parameters.AddWithValue("@Name", name) ' Change the ID to the appropriate value
                Using reader As SqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        Dim fileName As String = reader("FileName").ToString()
                        Dim fileData As Byte() = CType(reader("A3"), Byte())

                        File.WriteAllBytes(Path.Combine(outputFilePath, fileName), fileData)
                    End If
                End Using
            End Using
            'SQLDbconnection.Close()
            ConClose()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try

    End Sub

    Sub UpdateA3()
        Dim Tit As String = Admin_Val_A3
        Dim filePath As String = UpdateA3_Form.txtA3name.Text
        Dim fileName As String = Path.GetFileName(filePath)
        Dim fileData As Byte() = File.ReadAllBytes(filePath)
        Try
            'SQLDbconnection.Open()
            ConOpen()

            Using command As New SqlCommand("UPDATE Project_tb SET FileName = @FileName, A3 = @FileData 
                                                WHERE Title = @proTit", SQLDbconnection)
                command.Parameters.AddWithValue("@FileName", fileName)
                command.Parameters.AddWithValue("@FileData", fileData)
                command.Parameters.AddWithValue("@proTit", Tit)
                command.ExecuteNonQuery()
            End Using
            'SQLDbconnection.Close()
            ConClose()

            AdminDLA3_Form.Admin_UpdateA3 = False

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try

    End Sub

    Sub UpdateA3_ForUser()
        Dim Tit As String = User_Val
        Dim filePath As String = UpdateA3_Form.txtA3name.Text
        Dim fileName As String = Path.GetFileName(filePath)
        Dim fileData As Byte() = File.ReadAllBytes(filePath)
        Try
            'SQLDbconnection.Open()
            ConOpen()

            Using command As New SqlCommand("UPDATE Project_tb SET FileName = @FileName, A3 = @FileData 
                                                WHERE Title = @proTit", SQLDbconnection)
                command.Parameters.AddWithValue("@FileName", fileName)
                command.Parameters.AddWithValue("@FileData", fileData)
                command.Parameters.AddWithValue("@proTit", Tit)
                command.ExecuteNonQuery()
            End Using
            'SQLDbconnection.Close()
            ConClose()

            AdminDLA3_Form.Admin_UpdateA3 = False

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try

    End Sub

    Sub Show_Support_DLA3()
        ' Open the database connection
        ConOpen()

        If SQLDbconnection.State = ConnectionState.Open Then
            ' Use a parameterized query to prevent SQL injection
            Dim query As String = "SELECT Title, TSG_Support, FileName " &
                                  "FROM Project_tb " &
                                  "WHERE TSG_Support LIKE @TSGSupport " &
                                  "ORDER BY Due_Date DESC"

            ' Declare and initialize the command
            Using command As New SqlCommand(query, SQLDbconnection)
                ' Add the parameter
                command.Parameters.AddWithValue("@TSGSupport", "%" & AdminDLA3_Form.cboTSG_Support.Text & "%")

                ' Declare a DataTable to hold query results
                Dim table As New DataTable()

                ' Execute the query and load the results
                Using rdr As SqlDataReader = command.ExecuteReader()
                    table.Load(rdr)
                End Using

                ' Bind the results to the DataGridView
                AdminDLA3_Form.DataGridView1.DataSource = table


                ' Bold the header cells
                For Each column As DataGridViewColumn In AdminDLA3_Form.DataGridView1.Columns
                    column.HeaderCell.Style.Font = New Font("MS Reference Sans Serif", 11, FontStyle.Bold)
                    column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    column.DefaultCellStyle.Font = New Font("MS Reference Sans Serif", 9)
                Next

                AdminDLA3_Form.DataGridView1.Columns("FileName").HeaderText = "A3 file name"
                AdminDLA3_Form.DataGridView1.Columns("TSG_Support").HeaderText = "TSG Support"

                AdminDLA3_Form.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(223, 228, 234)
                AdminDLA3_Form.DataGridView1.DefaultCellStyle.SelectionBackColor = Color.MediumSeaGreen
                AdminDLA3_Form.DataGridView1.DefaultCellStyle.SelectionForeColor = Color.White

                AdminDLA3_Form.DataGridView1.EnableHeadersVisualStyles = False
                AdminDLA3_Form.DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGreen
            End Using
        End If

        ' Close the database connection
        ConClose()

    End Sub

    '===================< FOR AdminCanceled_Form >=====================

    Sub Show_AdminCanceledList()
        Dim command As New SqlCommand("", SQLDbconnection)
        Dim table As New DataTable

        ' Open SQL connection
        ConOpen()

        If SQLDbconnection.State = ConnectionState.Open Then
            command.Connection = SQLDbconnection
            command.CommandText = "SELECT Token, Title, Owner, Department, Start_date, Due_Date, TSG_Support, Status, TokenStatus, Done_date " &
                              "FROM CanceledProject_tb ORDER BY Due_Date DESC"

            Dim rdr As SqlDataReader = command.ExecuteReader()
            table.Load(rdr)

            ' Bind data to DataGridView
            AdminCanceled_Form.DataGridView1.DataSource = table

            ' Format DataGridView
            For Each column As DataGridViewColumn In AdminCanceled_Form.DataGridView1.Columns
                column.HeaderCell.Style.Font = New Font("MS Reference Sans Serif", 11, FontStyle.Bold)
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                column.DefaultCellStyle.Font = New Font("MS Reference Sans Serif", 9)
            Next

            ' Adjust column widths
            'AdminCanceled_Form.DataGridView1.Columns("ID").Width = 80
            AdminCanceled_Form.DataGridView1.Columns("Title").Width = 500
            AdminCanceled_Form.DataGridView1.Columns("Owner").Width = 200

            ' Rename column headers
            'AdminCanceled_Form.DataGridView1.Columns("ID").HeaderText = "Project ID"
            AdminCanceled_Form.DataGridView1.Columns("TSG_Support").HeaderText = "TSG Support"
            AdminCanceled_Form.DataGridView1.Columns("Due_date").HeaderText = "Due Date"
            AdminCanceled_Form.DataGridView1.Columns("Start_date").HeaderText = "Start Date"
            AdminCanceled_Form.DataGridView1.Columns("TokenStatus").HeaderText = "Token Status"
            AdminCanceled_Form.DataGridView1.Columns("Done_date").HeaderText = "Done Date"

            ' Style alternating row colors
            AdminCanceled_Form.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(223, 228, 234)
            AdminCanceled_Form.DataGridView1.DefaultCellStyle.SelectionBackColor = Color.MediumSeaGreen
            AdminCanceled_Form.DataGridView1.DefaultCellStyle.SelectionForeColor = Color.White
            AdminCanceled_Form.DataGridView1.EnableHeadersVisualStyles = False
            AdminCanceled_Form.DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGreen

        End If

        ' Close connection
        ConClose()
    End Sub

    Sub Show_SupportCanceledProjects()
        ' Open the database connection
        ConOpen()

        If SQLDbconnection.State = ConnectionState.Open Then
            ' Use a parameterized query to prevent SQL injection
            Dim query As String = "SELECT Token, Title, Owner, Department, Start_date, Due_Date, TSG_Support, Status, TokenStatus, Done_date " &
                                  "FROM CanceledProject_tb " &
                                  "WHERE TSG_Support LIKE @TSGSupport " &
                                  "ORDER BY Due_Date DESC"

            ' Declare and initialize the command
            Using command As New SqlCommand(query, SQLDbconnection)
                ' Add the parameter
                command.Parameters.AddWithValue("@TSGSupport", "%" & AdminCanceled_Form.cboTSG_Support.Text & "%")

                ' Declare a DataTable to hold query results
                Dim table As New DataTable()

                ' Execute the query and load the results
                Using rdr As SqlDataReader = command.ExecuteReader()
                    table.Load(rdr)
                End Using

                ' Bind the results to the DataGridView
                AdminCanceled_Form.DataGridView1.DataSource = table

                ' Format the DataGridView
                For Each column As DataGridViewColumn In AdminCanceled_Form.DataGridView1.Columns
                    column.HeaderCell.Style.Font = New Font("MS Reference Sans Serif", 11, FontStyle.Bold)
                    column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    column.DefaultCellStyle.Font = New Font("MS Reference Sans Serif", 9)
                Next

                ' Adjust specific column headers
                'AdminCanceled_Form.DataGridView1.Columns("ID").HeaderText = "Project ID"
                AdminCanceled_Form.DataGridView1.Columns("TSG_Support").HeaderText = "TSG Support"
                AdminCanceled_Form.DataGridView1.Columns("Due_date").HeaderText = "Due Date"
                AdminCanceled_Form.DataGridView1.Columns("Start_date").HeaderText = "Start Date"
                AdminCanceled_Form.DataGridView1.Columns("TokenStatus").HeaderText = "Token Status"
                AdminCanceled_Form.DataGridView1.Columns("Done_date").HeaderText = "Done Date"

                ' Set alternating row colors and selection styles
                AdminCanceled_Form.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(223, 228, 234)
                AdminCanceled_Form.DataGridView1.DefaultCellStyle.SelectionBackColor = Color.MediumSeaGreen
                AdminCanceled_Form.DataGridView1.DefaultCellStyle.SelectionForeColor = Color.White

                ' Disable default header styles and apply custom styles
                AdminCanceled_Form.DataGridView1.EnableHeadersVisualStyles = False
                AdminCanceled_Form.DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGreen
            End Using
        End If

        ' Close the database connection
        ConClose()

    End Sub

End Module