Public Class Activity_Form
    Dim dtp As DateTimePicker = New DateTimePicker
    Dim rect As Rectangle

    Public ViewReq As Boolean = False

    Private Sub Activity_Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        If AccLevel = "Admin" Then
            GroupBoxProj.Text = AdminProDetail_Form.txtTitle.Text

            If ViewReq = False Then 'true
                ViewReq = True
                With DataGridView1
                    .Columns("Task").Width = 400
                    .Columns("Remarks").Width = 200
                    .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

                    .Columns("Task").DefaultCellStyle.WrapMode = DataGridViewTriState.True
                    .Columns("Remarks").DefaultCellStyle.WrapMode = DataGridViewTriState.True
                End With
            End If

        Else
            GroupBoxProj.Text = MyReq_Title_val
        End If

        'DataGridView1.Controls.Add(dtp)
        'dtp.Format = DateTimePickerFormat.Custom
        'dtp.Visible = False
        'AddHandler dtp.TextChanged, AddressOf dtp_TextChange

        'Highligh_Activity()

        'For Each col As DataGridViewColumn In DataGridView1.Columns
        '    col.SortMode = DataGridViewColumnSortMode.NotSortable
        'Next
    End Sub

    'Private Sub dtp_TextChange(ByVal sender As Object, ByVal e As EventArgs)
    '    'DataGridView1.CurrentCell.Value = dtp.Text.ToString

    '    If DataGridView1.CurrentCell IsNot Nothing Then
    '        Try
    '            DataGridView1.CurrentCell.Value = dtp.Value.Date
    '        Catch ex As Exception
    '            MessageBox.Show("Invalid date selected: " & ex.Message, "Date Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        End Try
    '    End If
    'End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If AccLevel = "Admin" Then

            Activity_Update()
            Me.Close()

            Admin_Form.btnAddProject.Enabled = True
            Admin_Form.btnList.Enabled = True
            Admin_Form.btnDLA3.Enabled = True
            Admin_Form.btnProdSupport.Enabled = True
            Admin_Form.btnCancel.Enabled = True

            Main_Form.btnHome.Enabled = True
            Main_Form.btnAdmin.Enabled = True
            Main_Form.btnMyReq.Enabled = True


            AdminProDetail_Form.ShowDialog()
        Else

            Main_Form.btnHome.Enabled = True
            Main_Form.btnMyReq.Enabled = True

            MyRequest_Form.Close()

            Me.Close()

            Click_MyRequestButton()
            Highligh_MyRequest_NoData()

        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Activity_Update()
    End Sub

    'Private Sub DataGridView1_CellClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
    '    If AccLevel = "Admin" Then
    '        Select Case DataGridView1.Columns(e.ColumnIndex).Name
    '            Case "Start", "Due", "Completion"
    '                rect = DataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, True)
    '                dtp.Size = New Size(rect.Width, rect.Height)
    '                dtp.Location = New Point(rect.X, rect.Y)
    '                dtp.Visible = True

    '                ' Check if cell has a valid date
    '                Dim cellValue = DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
    '                If cellValue IsNot Nothing AndAlso IsDate(cellValue) Then
    '                    dtp.Value = Convert.ToDateTime(cellValue)
    '                Else
    '                    dtp.Value = DateTime.Now
    '                End If
    '        End Select
    '    End If
    'End Sub

    Private Sub DataGridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles DataGridView1.KeyDown
        If AccLevel = "Admin" Then
            If e.KeyCode = Keys.Delete OrElse e.KeyCode = Keys.Back Then
                Dim colName As String = DataGridView1.CurrentCell.OwningColumn.Name
                If colName = "Start" OrElse colName = "Due" OrElse colName = "Completion" Then
                    DataGridView1.CurrentCell.Value = DBNull.Value
                    dtp.Visible = False
                End If
            End If
        End If
    End Sub

End Class