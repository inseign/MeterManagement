' NEW DB TOOL FOR LEOPARD CONTROLS CUSTOM BUILT TO ALLOW CLIENTS TO GET DATA IN A USABLE FORM
'================= VERSION 1.02 ========================
'================= AUTHOR TERRY GITTOS =================
'
Imports MySql.Data.MySqlClient

Public Class SplashScreen
    Dim mySQLConn As MySqlConnection

    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtServer.Text = "localhost"
        TxtDatabase.Text = "niagaradb" '"niagaratest2" ' ' 
        TxtUserName.Text = "root"
        TxtPassword.Text = "Leopard5367"
    End Sub

    Private Sub BtnChkConn_Click(sender As Object, e As EventArgs) Handles BtnChkConn.Click
        mySQLConn = New MySqlConnection
        mySQLConn.ConnectionString = "Server=" & TxtServer.Text & ";Database=" & TxtDatabase.Text & ";Uid=" & TxtUserName.Text & ";Pwd=" & TxtPassword.Text & ";"

        Try
            mySQLConn.Open()
            MessageBox.Show("Connection Successful!")
            mySQLConn.Close()
            Main.Show()
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            mySQLConn.Dispose()
        End Try


    End Sub

    Private Sub ChkbxAdmin_CheckedChanged(sender As Object, e As EventArgs) Handles chkbxAdmin.CheckedChanged
        If chkbxAdmin.Checked = True Then
            txtPW.Visible = True
            labelPW.Visible = True
        Else
            txtPW.Visible = False
            labelPW.Visible = False
            BtnChkConn.Visible = False
            BtnUpdateTenants.Visible = False
            TxtDatabase.Visible = False
            TxtServer.Visible = False
            TxtUserName.Visible = False
            TxtPassword.Visible = False
            lblServer.Visible = False
            lblDatabase.Visible = False
            lblUserName.Visible = False
            lblPassword.Visible = False
        End If
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        If chkbxAdmin.Checked = True Then
            If txtPW.Text = "Leopard5367" Then
                BtnChkConn.Visible = True
                BtnUpdateTenants.Visible = True
                TxtDatabase.Visible = True
                TxtServer.Visible = True
                TxtUserName.Visible = True
                TxtPassword.Visible = True
                lblServer.Visible = True
                lblDatabase.Visible = True
                lblUserName.Visible = True
                lblPassword.Visible = True
            Else
                MessageBox.Show("Password is incorrect!")
            End If
        Else
            Main.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub SplashScreen_Close(sender As Object, e As EventArgs) Handles MyBase.Closed
        Application.Exit()
    End Sub

    Private Sub BtnUpdateTenants_Click(sender As Object, e As EventArgs) Handles BtnUpdateTenants.Click
        Tenants.Show()
        Me.Hide()
    End Sub
End Class
