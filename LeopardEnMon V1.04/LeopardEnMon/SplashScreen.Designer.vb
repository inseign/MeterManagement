<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SplashScreen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SplashScreen))
        Me.BtnChkConn = New System.Windows.Forms.Button()
        Me.chkbxAdmin = New System.Windows.Forms.CheckBox()
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.txtPW = New System.Windows.Forms.TextBox()
        Me.labelPW = New System.Windows.Forms.Label()
        Me.TxtServer = New System.Windows.Forms.TextBox()
        Me.lblServer = New System.Windows.Forms.Label()
        Me.lblDatabase = New System.Windows.Forms.Label()
        Me.TxtDatabase = New System.Windows.Forms.TextBox()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.TxtUserName = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.BtnUpdateTenants = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnChkConn
        '
        Me.BtnChkConn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnChkConn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnChkConn.Location = New System.Drawing.Point(322, 367)
        Me.BtnChkConn.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnChkConn.Name = "BtnChkConn"
        Me.BtnChkConn.Size = New System.Drawing.Size(161, 46)
        Me.BtnChkConn.TabIndex = 0
        Me.BtnChkConn.Text = "Check Connection"
        Me.BtnChkConn.UseVisualStyleBackColor = True
        Me.BtnChkConn.Visible = False
        '
        'chkbxAdmin
        '
        Me.chkbxAdmin.AutoSize = True
        Me.chkbxAdmin.BackColor = System.Drawing.Color.Transparent
        Me.chkbxAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkbxAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkbxAdmin.Location = New System.Drawing.Point(553, 330)
        Me.chkbxAdmin.Margin = New System.Windows.Forms.Padding(2)
        Me.chkbxAdmin.Name = "chkbxAdmin"
        Me.chkbxAdmin.Size = New System.Drawing.Size(169, 21)
        Me.chkbxAdmin.TabIndex = 1
        Me.chkbxAdmin.Text = "Log in as Administrator"
        Me.chkbxAdmin.UseVisualStyleBackColor = False
        '
        'BtnLogin
        '
        Me.BtnLogin.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogin.Location = New System.Drawing.Point(553, 354)
        Me.BtnLogin.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(174, 34)
        Me.BtnLogin.TabIndex = 2
        Me.BtnLogin.Text = "Login"
        Me.BtnLogin.UseVisualStyleBackColor = True
        '
        'txtPW
        '
        Me.txtPW.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPW.Location = New System.Drawing.Point(630, 393)
        Me.txtPW.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPW.Name = "txtPW"
        Me.txtPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPW.Size = New System.Drawing.Size(98, 23)
        Me.txtPW.TabIndex = 3
        Me.txtPW.Visible = False
        '
        'labelPW
        '
        Me.labelPW.AutoSize = True
        Me.labelPW.BackColor = System.Drawing.Color.Transparent
        Me.labelPW.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.labelPW.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelPW.Location = New System.Drawing.Point(550, 396)
        Me.labelPW.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labelPW.Name = "labelPW"
        Me.labelPW.Size = New System.Drawing.Size(73, 17)
        Me.labelPW.TabIndex = 4
        Me.labelPW.Text = "Password:"
        Me.labelPW.Visible = False
        '
        'TxtServer
        '
        Me.TxtServer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtServer.Location = New System.Drawing.Point(127, 302)
        Me.TxtServer.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtServer.Name = "TxtServer"
        Me.TxtServer.Size = New System.Drawing.Size(183, 26)
        Me.TxtServer.TabIndex = 5
        Me.TxtServer.Visible = False
        '
        'lblServer
        '
        Me.lblServer.AutoSize = True
        Me.lblServer.BackColor = System.Drawing.Color.Transparent
        Me.lblServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblServer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServer.Location = New System.Drawing.Point(32, 305)
        Me.lblServer.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblServer.Name = "lblServer"
        Me.lblServer.Size = New System.Drawing.Size(59, 20)
        Me.lblServer.TabIndex = 6
        Me.lblServer.Text = "Server:"
        Me.lblServer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblServer.Visible = False
        '
        'lblDatabase
        '
        Me.lblDatabase.AutoSize = True
        Me.lblDatabase.BackColor = System.Drawing.Color.Transparent
        Me.lblDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblDatabase.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDatabase.Location = New System.Drawing.Point(32, 334)
        Me.lblDatabase.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDatabase.Name = "lblDatabase"
        Me.lblDatabase.Size = New System.Drawing.Size(83, 20)
        Me.lblDatabase.TabIndex = 8
        Me.lblDatabase.Text = "Database:"
        Me.lblDatabase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblDatabase.Visible = False
        '
        'TxtDatabase
        '
        Me.TxtDatabase.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDatabase.Location = New System.Drawing.Point(127, 332)
        Me.TxtDatabase.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtDatabase.Name = "TxtDatabase"
        Me.TxtDatabase.Size = New System.Drawing.Size(183, 26)
        Me.TxtDatabase.TabIndex = 7
        Me.TxtDatabase.Visible = False
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.BackColor = System.Drawing.Color.Transparent
        Me.lblUserName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.Location = New System.Drawing.Point(32, 363)
        Me.lblUserName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(93, 20)
        Me.lblUserName.TabIndex = 10
        Me.lblUserName.Text = "User Name:"
        Me.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblUserName.Visible = False
        '
        'TxtUserName
        '
        Me.TxtUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUserName.Location = New System.Drawing.Point(127, 361)
        Me.TxtUserName.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtUserName.Name = "TxtUserName"
        Me.TxtUserName.Size = New System.Drawing.Size(183, 26)
        Me.TxtUserName.TabIndex = 9
        Me.TxtUserName.Visible = False
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(32, 392)
        Me.lblPassword.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(82, 20)
        Me.lblPassword.TabIndex = 12
        Me.lblPassword.Text = "Password:"
        Me.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblPassword.Visible = False
        '
        'TxtPassword
        '
        Me.TxtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPassword.Location = New System.Drawing.Point(127, 390)
        Me.TxtPassword.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPassword.Size = New System.Drawing.Size(183, 26)
        Me.TxtPassword.TabIndex = 11
        Me.TxtPassword.Visible = False
        '
        'BtnUpdateTenants
        '
        Me.BtnUpdateTenants.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnUpdateTenants.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdateTenants.Location = New System.Drawing.Point(322, 312)
        Me.BtnUpdateTenants.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnUpdateTenants.Name = "BtnUpdateTenants"
        Me.BtnUpdateTenants.Size = New System.Drawing.Size(161, 46)
        Me.BtnUpdateTenants.TabIndex = 13
        Me.BtnUpdateTenants.Text = "Update Tenants"
        Me.BtnUpdateTenants.UseVisualStyleBackColor = True
        Me.BtnUpdateTenants.Visible = False
        '
        'SplashScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(789, 454)
        Me.Controls.Add(Me.BtnUpdateTenants)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.TxtUserName)
        Me.Controls.Add(Me.lblDatabase)
        Me.Controls.Add(Me.TxtDatabase)
        Me.Controls.Add(Me.lblServer)
        Me.Controls.Add(Me.TxtServer)
        Me.Controls.Add(Me.labelPW)
        Me.Controls.Add(Me.txtPW)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.chkbxAdmin)
        Me.Controls.Add(Me.BtnChkConn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "SplashScreen"
        Me.Text = "Leopard Energy Monitoring"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnChkConn As Button
    Friend WithEvents chkbxAdmin As CheckBox
    Friend WithEvents BtnLogin As Button
    Friend WithEvents txtPW As TextBox
    Friend WithEvents labelPW As Label
    Friend WithEvents TxtServer As TextBox
    Friend WithEvents lblServer As Label
    Friend WithEvents lblDatabase As Label
    Friend WithEvents TxtDatabase As TextBox
    Friend WithEvents lblUserName As Label
    Friend WithEvents TxtUserName As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents BtnUpdateTenants As Button
End Class
