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

            'SendingEmail_Condition() 'Checking using app.config
            'CheckLastDate() 'Checking using database

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
        StartDate_Form.Close()
        Token_Form.Close()

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
        StartDate_Form.Close()
        Token_Form.Close()

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

        'Get_LastProjectDate()

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
        AdminDLA3_Form.Close()

        With AdminAddProject_Form
            .TopLevel = False
            Admin_Form.Panel_Admin.Controls.Add(AdminAddProject_Form)
            .WindowState = FormWindowState.Maximized
            .BringToFront()
            .Show()
        End With

        Admin_Form.btnAddProject.BackColor = Color.WhiteSmoke
        Admin_Form.btnList.BackColor = Color.Transparent
        Admin_Form.btnDLA3.BackColor = Color.Transparent
        Admin_Form.btnCancel.BackColor = Color.Transparent

        Admin_Form.btnAddProject.ForeColor = Color.Orange
        Admin_Form.btnList.ForeColor = Color.White
        Admin_Form.btnDLA3.ForeColor = Color.White
        Admin_Form.btnCancel.ForeColor = Color.White

    End Sub

    Sub Clicked_ProjectList()
        AdminAddProject_Form.Close()
        AdminDLA3_Form.Close()

        With AdminProjectList_Form
            .TopLevel = False
            Admin_Form.Panel_Admin.Controls.Add(AdminProjectList_Form)
            .WindowState = FormWindowState.Maximized
            .BringToFront()
            .Show()
        End With

        Admin_Form.btnAddProject.BackColor = Color.Transparent
        Admin_Form.btnList.BackColor = Color.WhiteSmoke
        Admin_Form.btnDLA3.BackColor = Color.Transparent
        Admin_Form.btnCancel.BackColor = Color.Transparent

        Admin_Form.btnAddProject.ForeColor = Color.White
        Admin_Form.btnList.ForeColor = Color.Orange
        Admin_Form.btnDLA3.ForeColor = Color.White
        Admin_Form.btnCancel.ForeColor = Color.White
    End Sub

    Sub Clicked_DownloadA3()
        AdminAddProject_Form.Close()
        AdminProjectList_Form.Close()

        With AdminDLA3_Form
            .TopLevel = False
            Admin_Form.Panel_Admin.Controls.Add(AdminDLA3_Form)
            .WindowState = FormWindowState.Maximized
            .BringToFront()
            .Show()
        End With

        Admin_Form.btnAddProject.BackColor = Color.Transparent
        Admin_Form.btnList.BackColor = Color.Transparent
        Admin_Form.btnDLA3.BackColor = Color.WhiteSmoke
        Admin_Form.btnCancel.BackColor = Color.Transparent

        Admin_Form.btnAddProject.ForeColor = Color.White
        Admin_Form.btnList.ForeColor = Color.White
        Admin_Form.btnDLA3.ForeColor = Color.Orange
        Admin_Form.btnCancel.ForeColor = Color.White
    End Sub

    Sub Clicked_CancledProject()
        AdminAddProject_Form.Close()
        AdminProjectList_Form.Close()
        AdminDLA3_Form.Close()

        With AdminCanceled_Form
            .TopLevel = False
            Admin_Form.Panel_Admin.Controls.Add(AdminCanceled_Form)
            .WindowState = FormWindowState.Maximized
            .BringToFront()
            .Show()
        End With

        Admin_Form.btnAddProject.BackColor = Color.Transparent
        Admin_Form.btnList.BackColor = Color.Transparent
        Admin_Form.btnDLA3.BackColor = Color.Transparent
        Admin_Form.btnCancel.BackColor = Color.WhiteSmoke

        Admin_Form.btnAddProject.ForeColor = Color.White
        Admin_Form.btnList.ForeColor = Color.White
        Admin_Form.btnDLA3.ForeColor = Color.White
        Admin_Form.btnCancel.ForeColor = Color.Orange
    End Sub
End Module

Module AppConfig_Module

    Public config As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)

    Public LastDate As String
    Sub GetDateYesterday()
        Dim Yest As String = System.Configuration.ConfigurationManager.AppSettings("Yesterday")
        Console.WriteLine(Yest)

        LastDate = Yest
    End Sub

    Sub Update_DateToday()
        Dim dt As String = Date.Now.ToString("MM/dd/yyyy")

        config.AppSettings.Settings("Yesterday").Value = dt ' Rewrite
        config.Save(ConfigurationSaveMode.Modified) ' save the new value

        ConfigurationManager.RefreshSection("appSettings") 'refresh
    End Sub

    '******************** Sending Email condition *******************
    Sub SendingEmail_Condition()
        GetDateYesterday()

        CheckLastDate()
        Dim date_now As String = Date.Now.ToString("MM/dd/yyyy")

        'If date_now = LastDate Then
        '    GetDateYesterday()
        'Else
        '    CheckDelay()
        'End If

        If date_now <> LastDateCheck Then
            CheckDelay()
        End If

    End Sub

End Module