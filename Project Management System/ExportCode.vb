Imports System.ComponentModel
Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms
Imports OfficeOpenXml
Imports OfficeOpenXml.Style

Module ExportToExcel_Module
    Public Sub ExportSummary(dgv As DataGridView, filePath As String)

        ExcelPackage.LicenseContext = LicenseContext.NonCommercial

        Using package As New ExcelPackage()
            Dim ws = package.Workbook.Worksheets.Add("Summary")

            ' --- Step 1: Selected columns ---
            Dim selectedCols_Summary = {
            "P1_DateTime", "P1_DelType", "P1_Supplier", "P1_Category", "P1_Origin",
            "P1_DocPO", "P1_InvoiceNum", "P1_DRnum", "P1_PEZA", "P1_AWBBL",
            "P1_ReceiverEmail", "P1_ReceivedBy", "P1_EnteredBy", "P1_Remarks",
            "P2_DateTime", "P2_TotalTime", "P2_PickupBy", "P2_EndorseBy", "P2_Status", "P2_Remarks",
            "P3_SAPDocNum_1", "P3_POnum_1", "P3_Remarks_1", "P3_DateTime_1", "P3_HoldCode_1",
            "P3_BuyersEmail_1", "P3_HC_Remarks_1", "P3_Status_1", "P3_SAP_Total_Hrs_1", "P3_CompletedBy_1",
            "P4_DateTime_1", "P4_ReceivedDate_1", "P4_POnum_1", "P4_Response_1", "P4_Response_Total_Hrs_1",
            "P3_SAPDocNum_2", "P3_POnum_2", "P3_Remarks_2", "P3_DateTime_2", "P3_HoldCode_2",
            "P3_BuyersEmail_2", "P3_HC_Remarks_2", "P3_Status_2", "P3_SAP_Total_Hrs_2", "P3_CompletedBy_2",
            "P4_DateTime_2", "P4_ReceivedDate_2", "P4_POnum_2", "P4_Response_2", "P4_Response_Total_Hrs_2",
            "P3_SAPDocNum_3", "P3_POnum_3", "P3_Remarks_3", "P3_DateTime_3", "P3_HoldCode_3",
            "P3_BuyersEmail_3", "P3_HC_Remarks_3", "P3_Status_3", "P3_SAP_Total_Hrs_3", "P3_CompletedBy_3",
            "P4_DateTime_3", "P4_ReceivedDate_3", "P4_POnum_3", "P4_Response_3", "P4_Response_Total_Hrs_3",
            "Pro2_Finance_RecDate", "Pro2_Finance_Total_Hrs", "Pro2_Finance_Status",
            "Pro2_Finance_Receiver", "Pro2_Finance_Remarks",
            "Pro2_Logistics_RecDate", "Pro2_Logistics_Total_Hrs", "Pro2_Logistics_Status",
            "Pro2_Logistics_Receiver", "Pro2_Logistics_Remarks"
        }

            ' --- Step 2: Write column headers ---
            Dim colIndex As Integer = 1
            For Each colName In selectedCols_Summary
                If dgv.Columns.Contains(colName) Then
                    ws.Cells(1, colIndex).Value = dgv.Columns(colName).HeaderText
                    ws.Cells(1, colIndex).Style.Font.Bold = True
                    ws.Cells(1, colIndex).Style.Fill.PatternType = ExcelFillStyle.Solid
                    ws.Cells(1, colIndex).Style.Fill.BackgroundColor.SetColor(Color.LightGray)
                    colIndex += 1
                End If
            Next

            ' --- Step 3: Write data rows ---
            Dim rowIndex As Integer = 2
            For Each row As DataGridViewRow In dgv.Rows
                If Not row.IsNewRow Then
                    colIndex = 1
                    For Each colName In selectedCols_Summary
                        If dgv.Columns.Contains(colName) Then
                            Dim cellValue = row.Cells(colName).Value

                            If colName.ToLower().Contains("date") AndAlso cellValue IsNot Nothing AndAlso Not IsDBNull(cellValue) Then
                                Dim dt As DateTime
                                If TypeOf cellValue Is DateTime Then
                                    dt = CType(cellValue, DateTime)
                                ElseIf IsNumeric(cellValue) Then
                                    dt = DateTime.FromOADate(Convert.ToDouble(cellValue))
                                Else
                                    DateTime.TryParse(cellValue.ToString(), dt)
                                End If

                                ws.Cells(rowIndex, colIndex).Value = dt
                                ws.Cells(rowIndex, colIndex).Style.Numberformat.Format = "MM/dd/yyyy hh:mm AM/PM"
                            Else
                                ws.Cells(rowIndex, colIndex).Value = cellValue
                            End If

                            colIndex += 1
                        End If
                    Next
                    rowIndex += 1
                End If
            Next

            ' --- Step 4: Auto-fit columns (safe check) ---
            If ws.Dimension IsNot Nothing Then
                ws.Cells(ws.Dimension.Address).AutoFitColumns()
            End If

            ' --- Step 5: Save file ---
            Dim fileInfo As New FileInfo(filePath)
            package.SaveAs(fileInfo)
        End Using
    End Sub
End Module