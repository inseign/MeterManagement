Imports MySql.Data.MySqlClient
Imports System.Data.Odbc
Imports Microsoft.Office.Interop

Public Class Main
    Dim mySQLConn As New MySqlConnection
    Dim clientData(,) As String
    Dim totalclientrows As Integer

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim currentSV As String = SplashScreen.TxtServer.Text
        Dim currentDB As String = SplashScreen.TxtDatabase.Text
        Dim currentUN As String = SplashScreen.TxtUserName.Text
        Dim currentPW As String = SplashScreen.TxtPassword.Text
        mySQLConn.ConnectionString = "Server=" & currentSV & ";" _
                                    & "Database=" & currentDB & ";" _
                                    & "Uid=" & currentUN & ";" _
                                    & "Pwd=" & currentPW & ";"
        'Declaration
        Dim selectQuery As String
        Dim dataAdptr As New MySqlDataAdapter
        Dim clientDataTable As New DataTable

        'Open Odbc Connection
        Try
            mySQLConn.Open()

            ' fill datatable using cmd / adapters
            selectQuery = "SELECT history_meta_meters.TableName, history_meta_meters.MeterCategory, history_meta_tenants.TenantCode, history_meta_tenants.TenantName FROM niagaradb.history_meta_meters JOIN niagaradb.history_meta_tenants ON history_meta_meters.TenantId = history_meta_tenants.Id WHERE history_meta_meters.USED='YES' ORDER BY history_meta_tenants.TenantCode"
            Dim cmd As New MySqlCommand(selectQuery, mySQLConn)
            dataAdptr.SelectCommand = cmd
            dataAdptr.Fill(clientDataTable)

            totalclientrows = 0
            CboTable.Items.Clear()

            'create combo box for all tables and array to be used holding the tabledata
            ReDim clientData(3, clientDataTable.Rows.Count)
            While totalclientrows < clientDataTable.Rows.Count
                CboTable.Items.Add(clientDataTable.Rows(totalclientrows)(0).ToString())
                clientData(0, totalclientrows) = ISNULL(clientDataTable.Rows(totalclientrows)(0).ToString(), "") 'Tables
                clientData(1, totalclientrows) = ISNULL(clientDataTable.Rows(totalclientrows)(1).ToString(), "") 'MeterCategory
                clientData(2, totalclientrows) = ISNULL(clientDataTable.Rows(totalclientrows)(2).ToString(), "") 'Tenant Code
                clientData(3, totalclientrows) = ISNULL(clientDataTable.Rows(totalclientrows)(3).ToString(), "") 'Tenant Name
                totalclientrows = totalclientrows + 1
            End While

            CboStartDate.Items.Clear()
            CboFinishDate.Items.Clear()
            Dim refDate As DateTime = "15/06/2016"
            Do Until refDate >= FormatDateTime(Today(), DateFormat.ShortDate)
                CboStartDate.Items.Add(refDate)
                CboFinishDate.Items.Add(refDate)
                refDate = refDate.AddDays(1)
            Loop

            mySQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ' convert null/empty inputs to string as determined
    Public Function ISNULL(ByVal input1 As Object, input2 As String) As String
        Dim output1 As String

        If (input1 Is Nothing) Or String.IsNullOrEmpty(input1) Then
            output1 = input2
        Else
            output1 = input1
        End If

        Return output1
    End Function

    ' function to convert between unixtimestamp and datetime. No longer used as SQL has conversion when called.
    Public Function UnixToDateTime(ByVal strUnixTime As String) As DateTime

        Dim nTimestamp As Double = strUnixTime
        nTimestamp = nTimestamp / 1000
        Dim nDateTime As System.DateTime = New System.DateTime(1970, 1, 1, 0, 0, 0, 0)
        nDateTime = nDateTime.AddSeconds(nTimestamp)

        Return nDateTime

    End Function

    Private Sub CboTable_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboTable.SelectedIndexChanged

        'reset start/finish dates
        CboStartDate.SelectedIndex = -1
        CboFinishDate.SelectedIndex = -1

        'load table
        Cursor = Cursors.WaitCursor
        LoadTable()
        Cursor = Cursors.Default

    End Sub

    Private Sub CboFinishDate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboFinishDate.SelectedIndexChanged
        If CboStartDate.SelectedItem >= CboFinishDate.SelectedItem And CboStartDate.SelectedIndex > -1 And CboFinishDate.SelectedIndex > -1 Then
            MsgBox("Finish Date Must be after the Start Date ..")
            CboFinishDate.SelectedIndex = -1
        End If
        If CboTable.SelectedIndex > -1 Then
            Cursor = Cursors.WaitCursor
            LoadTable()
            Cursor = Cursors.Default
        End If
    End Sub

    Private Sub CboStartDate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboStartDate.SelectedIndexChanged
        If CboStartDate.SelectedItem >= CboFinishDate.SelectedItem And CboStartDate.SelectedIndex > -1 And CboFinishDate.SelectedIndex > -1 Then
            MsgBox("Start Date must be before the Finish Date ..")
            CboStartDate.SelectedIndex = -1
        End If
        If CboTable.SelectedIndex > -1 Then
            Cursor = Cursors.WaitCursor
            LoadTable()
            Cursor = Cursors.Default
        End If
    End Sub

    Private Sub LoadTable()

        Dim currentTB As String = CboTable.Text
        Dim currentSD As String = CboStartDate.Text
        Dim currentFD As String = CboFinishDate.Text
        'Dim dayAfterFD As Date
        'If currentFD <> "" Then
        '    dayAfterFD = CboFinishDate.Text
        '    dayAfterFD = dayAfterFD.AddDays(1)
        '    currentFD = dayAfterFD.ToString()
        'End If


        Dim dataAdapter As New MySqlDataAdapter
        Dim reader As MySqlDataReader
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource
        Dim query1 As String
        If CboStartDate.SelectedIndex = -1 And CboFinishDate.SelectedIndex = -1 Then
            query1 = "SELECT FROM_UNIXTIME(TIMESTAMP/1000) as sTime, VALUE as sValue " _
                    & "FROM " & currentTB & " " _
                    & "WHERE VALUE > 0 " _
                    & "ORDER BY TIMESTAMP;"
        ElseIf CboStartDate.SelectedIndex > -1 And CboFinishDate.SelectedIndex = -1 Then
            query1 = "SELECT FROM_UNIXTIME(TIMESTAMP/1000) as sTime, VALUE as sValue " _
                    & "FROM " & currentTB _
                    & " WHERE TIMESTAMP/1000 >= UNIX_TIMESTAMP(STR_TO_DATE('" & currentSD & "', '%d/%m/%Y %T')) " _
                    & "AND VALUE > 0 " _
                    & "ORDER BY TIMESTAMP;"
        ElseIf CboStartDate.SelectedIndex = -1 And CboFinishDate.SelectedIndex > -1 Then
            query1 = "SELECT FROM_UNIXTIME(TIMESTAMP/1000) as sTime, VALUE as sValue " _
                    & "FROM " & currentTB _
                    & " WHERE TIMESTAMP/1000 <= UNIX_TIMESTAMP(STR_TO_DATE('" & currentFD & "', '%d/%m/%Y %T')) " _
                    & "AND VALUE > 0 " _
                    & "ORDER BY TIMESTAMP;"
        Else
            query1 = "SELECT FROM_UNIXTIME(TIMESTAMP/1000) as sTime, VALUE as sValue " _
                    & "FROM " & currentTB _
                    & " WHERE VALUE > 0 AND (TIMESTAMP/1000 BETWEEN UNIX_TIMESTAMP(STR_TO_DATE('" & currentSD & "', '%d/%m/%Y %T')) " _
                    & "AND UNIX_TIMESTAMP(STR_TO_DATE('" & currentFD & "', '%d/%m/%Y %T'))) " _
                    & "ORDER BY TIMESTAMP;"
        End If

        Using cmd As New MySqlCommand(query1, mySQLConn)
            Try
                'first fill table with data
                mySQLConn.Open()
                dataAdapter.SelectCommand = cmd
                dataAdapter.Fill(dbDataSet)
                bSource.DataSource = dbDataSet
                DataGridView1.DataSource = bSource
                dataAdapter.Update(dbDataSet)
                DataGridView1.Columns(0).Width = 200
                DataGridView1.Columns(1).Width = 200

                'next create a differential for power consumption
                reader = cmd.ExecuteReader
                Dim bCounter As Int32 = 0
                Dim startValue As Double = 0.0
                Dim finishValue As Double = 0.0
                Dim dayNightSwitch As String = "Start"
                Dim dayStartValue As Double = 0.0
                Dim dayFinishValue As Double = 0.0
                Dim nightStartValue As Double = 0.0
                Dim nightFinishValue As Double = 0.0
                Dim dayTotal As Double = 0.0
                Dim nightTotal As Double = 0.0
                Dim tempPercent As Double = 0.0
                Dim lastValue As Double = 0.0
                Dim currentTime As DateTime

                While reader.Read
                    currentTime = reader.GetDateTime("sTime").ToString("hh:mm:ss tt")
                    If Convert.ToDouble(reader.GetString("sValue")) > 0 Then
                        'Calculate daynight usage starting with day or night starttime
                        If dayNightSwitch = "Start" And (currentTime >= #8:00 AM# And currentTime <= #10:00 PM#) Then
                            dayStartValue = Convert.ToDouble(reader.GetString("sValue"))
                            dayNightSwitch = "Day"
                        ElseIf dayNightSwitch = "Start" And (currentTime < #8:00 AM# Or currentTime > #10:00 PM#) Then
                            nightStartValue = Convert.ToDouble(reader.GetString("sValue"))
                            dayNightSwitch = "Night"
                        End If

                        'now catch the finishtime and the start time for the next period
                        If dayNightSwitch = "Day" And (currentTime < #8:00 AM# Or currentTime > #10:00 PM#) Then
                            dayFinishValue = Convert.ToDouble(reader.GetString("sValue"))
                            dayNightSwitch = "Night"
                            If (dayFinishValue - dayStartValue) >= 0 Then
                                dayTotal = dayTotal + (dayFinishValue - dayStartValue)
                                nightStartValue = dayFinishValue
                            End If
                        ElseIf dayNightSwitch = "Night" And (currentTime >= #8:00 AM# And currentTime <= #10:00 PM#) Then
                            nightFinishValue = Convert.ToDouble(reader.GetString("sValue"))
                            dayNightSwitch = "Day"
                            If (nightFinishValue - nightStartValue) >= 0 Then
                                nightTotal = nightTotal + (nightFinishValue - nightStartValue)
                                dayStartValue = nightFinishValue
                            End If
                        End If

                        'Calculate overall usage over time period
                        If bCounter = 0 Then
                            startValue = Convert.ToDouble(reader.GetString("sValue"))
                        Else
                            finishValue = Convert.ToDouble(reader.GetString("sValue"))
                        End If
                        bCounter = bCounter + 1
                        lastValue = Convert.ToDouble(reader.GetString("sValue"))
                    End If
                End While

                'tidy up the final loose end time after 6pm or 6am
                If dayNightSwitch = "Day" Then
                    If (lastValue - dayStartValue) >= 0 Then
                        dayTotal = dayTotal + (lastValue - dayStartValue)
                    End If
                Else
                    If (lastValue - nightStartValue) >= 0 Then
                        nightTotal = nightTotal + (lastValue - nightStartValue)
                    End If
                End If

                'write calculated values to front panel
                txtStartReading.Text = startValue
                txtFinishReading.Text = finishValue
                txtDifferential.Text = (finishValue - startValue)
                txtDayUse.Text = dayTotal
                txtDayPercent.Text = Strings.Left((dayTotal / (finishValue - startValue) * 100), 5) & "%"
                txtNightUse.Text = nightTotal
                txtNightPercent.Text = Strings.Left((nightTotal / (finishValue - startValue) * 100), 5) & "%"
                mySQLConn.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim likeOpen1 As MsgBoxResult
        likeOpen1 = MsgBox("This process can take more than a few minutes, are you sure??", MsgBoxStyle.YesNo)
        If (likeOpen1 = MsgBoxResult.Yes) Then

            Cursor = Cursors.WaitCursor
            CreateMasterTable()
            Cursor = Cursors.Default

            Dim strStartDate As String = Replace(CboStartDate.Text, "/", "")
            Dim strFinishDate As String = Replace(CboFinishDate.Text, "/", "")
            If strStartDate = "" Then
                strStartDate = "15062016"
            End If
            If strFinishDate = "" Then
                strFinishDate = Today.ToString("ddMMyyyy")
            End If
            Dim strToday As String = DateTime.Today.ToString("yyyyMMdd")

            Dim likeOpen2 As MsgBoxResult
            likeOpen2 = MsgBox("Would you like to open the file??", MsgBoxStyle.YesNo)
            If (likeOpen2 = MsgBoxResult.Yes) Then
                Try
                    Process.Start("E:\Niagara\Data\" & strToday & "_Start" & strStartDate & "_Finish" & strFinishDate & "_MeterData.xlsx")
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If

        End If
    End Sub



    Public Sub CreateMasterTable()

        ' using clientData(0, totalclientrows) created when tables were loaded
        Dim resultArray(10, totalclientrows + 2) As String
        Dim returnArray(8) As String ' what comes back from LoadManyTables
        Dim strStartDate As String = CboStartDate.Text
        Dim strFinishDate As String = CboFinishDate.Text
        If strStartDate = "" Then
            strStartDate = "15/06/2016"
        End If
        If strFinishDate = "" Then
            strFinishDate = Today.ToString("dd/MM/yyyy")
        End If


        ' Organise Headings
        resultArray(0, 0) = "Lakeside Joondalup Service Meter Readings"
        resultArray(0, 1) = "Table Name"
        resultArray(1, 1) = "Meter Type"
        resultArray(2, 1) = "Tenant Code"
        resultArray(3, 1) = "Tenant Name"
        resultArray(4, 1) = "Start Reading"
        resultArray(5, 1) = "Finish Reading"
        resultArray(6, 1) = "Total Usage Between Period"
        resultArray(7, 1) = "Peak"
        resultArray(8, 1) = "Peak %"
        resultArray(9, 1) = "Off-Peak"
        resultArray(10, 1) = "Off-Peak %"
        resultArray(4, 2) = " " & strStartDate & " "
        resultArray(5, 2) = " " & strFinishDate & " "
        resultArray(6, 2) = strStartDate & " - " & strFinishDate

        strStartDate = Replace(strStartDate, "/", "")
        strFinishDate = Replace(strFinishDate, "/", "")

        ProgressBar1.Maximum = totalclientrows - 1
        ProgressBar1.Value = 0
        For i = 0 To totalclientrows - 1

            returnArray = LoadManyTables(clientData(0, i))

            resultArray(0, i + 3) = clientData(0, i)
            resultArray(1, i + 3) = clientData(1, i)
            resultArray(2, i + 3) = clientData(2, i)
            resultArray(3, i + 3) = clientData(3, i)
            resultArray(4, i + 3) = returnArray(0).ToString
            resultArray(5, i + 3) = returnArray(2).ToString
            resultArray(6, i + 3) = returnArray(4).ToString
            resultArray(7, i + 3) = returnArray(5).ToString
            resultArray(8, i + 3) = returnArray(6).ToString
            resultArray(9, i + 3) = returnArray(7).ToString
            resultArray(10, i + 3) = returnArray(8).ToString

            ProgressBar1.Value = i
        Next
        Try

            'create Excel to display for client
            Dim xlApp As New Excel.Application
            Dim xlWorkbook As Excel.Workbook = xlApp.Workbooks.Add()
            Dim xlWorksheet As Excel.Worksheet = CType(xlWorkbook.Sheets("Sheet1"), Excel.Worksheet)

            For i = 0 To totalclientrows + 2
                For j = 0 To 10
                    xlWorksheet.Cells(i + 1, j + 1) = resultArray(j, i)
                Next
            Next

            'Formating the Excel
            xlWorksheet.Range("A1:K3").Font.Bold = True
            xlWorksheet.Range("A1:K3").Font.Size = 13
            xlWorksheet.Range("A1:K3").HorizontalAlignment = Excel.Constants.xlCenter
            xlWorksheet.Range("A:K").Borders.LineStyle = Excel.XlLineStyle.xlContinuous '(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin, Excel.XlColorIndex.xlColorIndexAutomatic, Excel.XlColorIndex.xlColorIndexAutomatic)
            xlWorksheet.Range("A:K").Borders.Weight = Excel.XlBorderWeight.xlThin
            xlWorksheet.Range("A1:K3").Rows.RowHeight = 20
            xlWorksheet.Range("A1:K1").Merge()
            xlWorksheet.Columns.AutoFit()

            If Not IO.Directory.Exists("E:\Niagara\Data") Then
                MkDir("E:\Niagara\Data")
            End If

            Dim strToday As String = DateTime.Today.ToString("yyyyMMdd")
            xlWorksheet.SaveAs("E:\Niagara\Data\" & strToday & "_Start" & strStartDate & "_Finish" & strFinishDate & "_MeterData.xlsx")
            xlWorkbook.Close()
            xlApp.Quit()

            xlApp = Nothing
            xlWorkbook = Nothing
            xlWorksheet = Nothing

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Declare Function SetProcessWorkingSetSize Lib "kernel32.dll" (ByVal hProcess As IntPtr, ByVal dwMinimumWorkingSetSize As Int32, ByVal dwMaximumWorkingSetSize As Int32) As Int32

    ' Function to reset the any memory that may be gummed up
    Friend Sub ReleaseMemory()
        Try
            GC.Collect()
            GC.WaitForPendingFinalizers()
            If Environment.OSVersion.Platform = PlatformID.Win32NT Then
                SetProcessWorkingSetSize(Process.GetCurrentProcess().Handle, -1, -1)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    ' main reader which generates values for client
    Public Function LoadManyTables(ByVal tablename As String) As String()

        Dim currentTB As String = tablename
        Dim currentSD As String = CboStartDate.Text
        Dim currentFD As String = CboFinishDate.Text
        Dim reader As MySqlDataReader
        Dim query1 As String

        If CboStartDate.SelectedIndex = -1 And CboFinishDate.SelectedIndex = -1 Then
            query1 = "SELECT FROM_UNIXTIME(TIMESTAMP/1000) as sTime, VALUE as sValue " _
                    & "FROM " & currentTB & " " _
                    & "WHERE VALUE > 0 " _
                    & "ORDER BY TIMESTAMP;"
        ElseIf CboStartDate.SelectedIndex > -1 And CboFinishDate.SelectedIndex = -1 Then
            query1 = "SELECT FROM_UNIXTIME(TIMESTAMP/1000) as sTime, VALUE as sValue " _
                    & "FROM " & currentTB _
                    & " WHERE VALUE > 0 AND TIMESTAMP/1000 >= UNIX_TIMESTAMP(STR_TO_DATE('" & currentSD & "', '%d/%m/%Y %T')) " _
                    & "ORDER BY TIMESTAMP;"
        ElseIf CboStartDate.SelectedIndex = -1 And CboFinishDate.SelectedIndex > -1 Then
            query1 = "SELECT FROM_UNIXTIME(TIMESTAMP/1000) as sTime, VALUE as sValue " _
                    & "FROM " & currentTB _
                    & " WHERE VALUE > 0 AND TIMESTAMP/1000 <= UNIX_TIMESTAMP(STR_TO_DATE('" & currentFD & "', '%d/%m/%Y %T')) " _
                    & "ORDER BY TIMESTAMP;"
        Else
            query1 = "SELECT FROM_UNIXTIME(TIMESTAMP/1000) as sTime, VALUE as sValue " _
                    & "FROM " & currentTB _
                    & " WHERE VALUE > 0 AND (TIMESTAMP/1000 BETWEEN UNIX_TIMESTAMP(STR_TO_DATE('" & currentSD & "', '%d/%m/%Y %T')) " _
                    & "AND UNIX_TIMESTAMP(STR_TO_DATE('" & currentFD & "', '%d/%m/%Y %T'))) " _
                    & "ORDER BY TIMESTAMP;"
        End If

        Using cmd As New MySqlCommand(query1, mySQLConn)
            Try
                'first open conn
                mySQLConn.Open()
                'next create a differential for power consumption
                reader = cmd.ExecuteReader
                Dim bCounter As Int32 = 0
                Dim startValue As Double = 0.0
                Dim finishValue As Double = 0.0
                Dim dayNightSwitch As String = "Start"
                Dim dayStartValue As Double = 0.0
                Dim dayFinishValue As Double = 0.0
                Dim nightStartValue As Double = 0.0
                Dim nightFinishValue As Double = 0.0
                Dim dayTotal As Double = 0.0
                Dim nightTotal As Double = 0.0
                Dim tempPercent As Double = 0.0
                Dim currentTime As DateTime
                Dim currentDate As Date
                Dim startDate As Date = "1/01/2100"
                Dim finishDate As Date = "1/01/2000"
                Dim returnArray(8) As String
                Dim lastValue As Double = 0.0

                While reader.Read

                    currentTime = reader.GetDateTime("sTime").ToString("hh:mm:ss tt")

                    'new code establish start and finish dates
                    currentDate = reader.GetDateTime("sTime").ToString("dd/MM/yyyy")
                    If currentDate < startDate Then
                        startDate = currentDate
                    End If
                    If currentDate > finishDate Then
                        finishDate = currentDate
                    End If

                    If Convert.ToDouble(reader.GetString("sValue")) > 0 Then
                        'Calculate daynight usage starting with day or night starttime
                        If dayNightSwitch = "Start" And (currentTime >= #8:00 AM# And currentTime <= #10:00 PM#) Then
                            dayStartValue = Convert.ToDouble(reader.GetString("sValue"))
                            dayNightSwitch = "Day"
                        ElseIf dayNightSwitch = "Start" And (currentTime < #8:00 AM# Or currentTime > #10:00 PM#) Then
                            nightStartValue = Convert.ToDouble(reader.GetString("sValue"))
                            dayNightSwitch = "Night"
                        End If

                        'now catch the finishtime and the start time for the next period
                        If dayNightSwitch = "Day" And (currentTime < #8:00 AM# Or currentTime > #10:00 PM#) Then
                            dayFinishValue = Convert.ToDouble(reader.GetString("sValue"))
                            dayNightSwitch = "Night"
                            If (dayFinishValue - dayStartValue) >= 0 Then
                                dayTotal = dayTotal + (dayFinishValue - dayStartValue)
                                nightStartValue = dayFinishValue
                            End If
                        ElseIf dayNightSwitch = "Night" And (currentTime >= #8:00 AM# And currentTime <= #10:00 PM#) Then
                            nightFinishValue = Convert.ToDouble(reader.GetString("sValue"))
                            dayNightSwitch = "Day"
                            If (nightFinishValue - nightStartValue) >= 0 Then
                                nightTotal = nightTotal + (nightFinishValue - nightStartValue)
                                dayStartValue = nightFinishValue
                            End If
                        End If

                        'Calculate overall usage over time period
                        If bCounter = 0 Then
                            startValue = Convert.ToDouble(reader.GetString("sValue"))
                        Else
                            finishValue = Convert.ToDouble(reader.GetString("sValue"))
                        End If
                        bCounter = bCounter + 1

                        lastValue = Convert.ToDouble(reader.GetString("sValue"))
                    End If
                End While

                'tidy up the final loose end time after 10pm or 8am
                If dayNightSwitch = "Day" Then
                    If (lastValue - dayStartValue) >= 0 Then
                        dayTotal = dayTotal + (lastValue - dayStartValue)
                    End If
                Else
                    If (lastValue - nightStartValue) >= 0 Then
                        nightTotal = nightTotal + (lastValue - nightStartValue)
                    End If
                End If


                'write calculated values to reference array
                returnArray(0) = startValue
                returnArray(1) = startDate
                returnArray(2) = finishValue
                returnArray(3) = finishDate
                returnArray(4) = (finishValue - startValue)
                returnArray(5) = dayTotal
                returnArray(6) = Strings.Left((dayTotal / (finishValue - startValue) * 100), 5) & "%"
                returnArray(7) = nightTotal
                returnArray(8) = Strings.Left((nightTotal / (finishValue - startValue) * 100), 5) & "%"

                reader.Dispose()
                mySQLConn.Close()
                ReleaseMemory()

                'send array back up
                Return returnArray

            Catch ex As Exception
                Return {"", "", "", "", "", "", "", "", ""}
                MsgBox(ex.ToString)
            End Try
        End Using

    End Function


    Private Sub Main_Close(sender As Object, e As EventArgs) Handles MyBase.Closed
        Application.Exit()
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        SplashScreen.Show()
        Me.Hide()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class

