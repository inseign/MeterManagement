Imports MySql.Data.MySqlClient

Public Class Tenants

    Dim mySQLConn As MySqlConnection
    Dim dataAdapter As New MySqlDataAdapter
    Dim dbDataSet As New DataSet
    Dim bSource As New BindingSource
    Dim cmdbl As New MySqlCommandBuilder

    Private Sub LoadTable()
        mySQLConn = New MySqlConnection
        Dim currentSV As String = SplashScreen.TxtServer.Text
        Dim currentDB As String = SplashScreen.TxtDatabase.Text
        Dim currentUN As String = SplashScreen.TxtUserName.Text
        Dim currentPW As String = SplashScreen.TxtPassword.Text

        mySQLConn.ConnectionString = "Server=" & currentSV & ";" _
                                    & "Database=" & currentDB & ";" _
                                    & "Uid=" & currentUN & ";" _
                                    & "Pwd=" & currentPW & ";"

        Dim query1 As String

        query1 = "SELECT * " _
               & "FROM history_meta_tenants;"

        Using cmd As New MySqlCommand(query1, mySQLConn)
            Try
                'first fill table with data
                mySQLConn.Open()
                dataAdapter.SelectCommand = cmd
                dataAdapter.Fill(dbDataSet, "Details")
                bSource.DataSource = dbDataSet.Tables(0)
                DataGridView1.DataSource = bSource
                'dataAdapter.Update(dbDataSet.Tables(0))
                DataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End Using
    End Sub


    Private Sub Tenants_Close(sender As Object, e As EventArgs) Handles MyBase.Closed
        Application.Exit()
    End Sub

    Private Sub Tenants_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTable()
    End Sub

    Private Sub BtnBack_Click_1(sender As Object, e As EventArgs) Handles BtnBack.Click
        SplashScreen.Show()
        Me.Hide()
    End Sub

    Private Sub TxtUpdateDB_Click(sender As Object, e As EventArgs) Handles TxtUpdateDB.Click
        Try
            cmdbl = New MySqlCommandBuilder(dataAdapter)
            dataAdapter.Update(dbDataSet, "Details")
            MessageBox.Show("Data Updated")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub WriteTable()

        mySQLConn = New MySqlConnection
        Dim currentSV As String = SplashScreen.TxtServer.Text
        Dim currentDB As String = SplashScreen.TxtDatabase.Text
        Dim currentUN As String = SplashScreen.TxtUserName.Text
        Dim currentPW As String = SplashScreen.TxtPassword.Text

        mySQLConn.ConnectionString = "Server=" & currentSV & ";" _
                                    & "Database=" & currentDB & ";" _
                                    & "Uid=" & currentUN & ";" _
                                    & "Pwd=" & currentPW & ";"
        Dim dataAdapter As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource
        Dim query1 As String

        query1 = "SELECT history_meta_tenants.TenantCode, history_meta_tenants.TenantName " _
               & "FROM history_meta_tenants;"

        Using cmd As New MySqlCommand(query1, mySQLConn)
            Try
                'first fill table with data
                mySQLConn.Open()


                mySQLConn.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End Using
    End Sub
End Class