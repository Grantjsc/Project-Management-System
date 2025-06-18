Imports System.DirectoryServices.AccountManagement
Imports System.Runtime.InteropServices
Imports System.Security.Principal

Module login_user
    ' Import the LogonUser function from Windows API
    <DllImport("advapi32.dll", SetLastError:=True, CharSet:=CharSet.Auto)>
    Private Function LogonUser(lpUsername As String, lpDomain As String, lpPassword As String,
                               dwLogonType As Integer, dwLogonProvider As Integer, ByRef phToken As IntPtr) As Boolean
    End Function

    ' Corrected: CloseHandle is in kernel32.dll
    <DllImport("kernel32.dll", SetLastError:=True, CharSet:=CharSet.Auto)>
    Private Function CloseHandle(hObject As IntPtr) As Boolean
    End Function

    Private Const LOGON32_LOGON_INTERACTIVE As Integer = 2
    Private Const LOGON32_PROVIDER_DEFAULT As Integer = 0

    ' Function to authenticate a user
    Public Function AuthenticateUser(username As String, domain As String, password As String) As Boolean
        Dim token As IntPtr = IntPtr.Zero
        Dim success As Boolean = LogonUser(username, domain, password,
                                           LOGON32_LOGON_INTERACTIVE, LOGON32_PROVIDER_DEFAULT, token)

        If success Then CloseHandle(token) ' Clean up the token handle
        Return success ' True if credentials are valid, False otherwise
    End Function

    ' Function to check if a specific user has admin privileges
    Public Function IsUserAdmin(username As String, domain As String, password As String) As Boolean
        Dim token As IntPtr = IntPtr.Zero

        ' Try logging in as the entered user
        If LogonUser(username, domain, password, LOGON32_LOGON_INTERACTIVE, LOGON32_PROVIDER_DEFAULT, token) Then
            ' Get the Windows Identity for the logged-in user
            Dim identity As New WindowsIdentity(token)
            Dim principal As New WindowsPrincipal(identity)

            ' Check if the user belongs to the Administrators group
            Dim isAdmin As Boolean = principal.IsInRole(WindowsBuiltInRole.Administrator)

            ' Clean up the token handle
            CloseHandle(token)

            Return isAdmin
        Else
            Return False ' Failed to log in, so cannot check admin status
        End If
    End Function



End Module

Module getfullname
    Function GetLoggedInUserFullName() As String
        Try
            Dim username As String = Environment.UserName ' Get current username
            Dim domain As String = Environment.UserDomainName ' Get domain

            Using context As New PrincipalContext(ContextType.Domain, domain)
                Dim user As UserPrincipal = UserPrincipal.FindByIdentity(context, username)

                If user IsNot Nothing AndAlso Not String.IsNullOrEmpty(user.DisplayName) Then
                    Return user.DisplayName ' Full name from Active Directory
                Else
                    Return "Full name not found"
                End If
            End Using
        Catch ex As Exception
            Return "Error: " & ex.Message
        End Try
    End Function
End Module