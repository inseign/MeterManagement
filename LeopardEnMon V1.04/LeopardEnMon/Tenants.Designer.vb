<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Tenants
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.TxtUpdateDB = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(13, 13)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(765, 325)
        Me.DataGridView1.TabIndex = 0
        '
        'BtnBack
        '
        Me.BtnBack.Cursor = System.Windows.Forms.Cursors.PanWest
        Me.BtnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBack.Location = New System.Drawing.Point(650, 409)
        Me.BtnBack.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(128, 34)
        Me.BtnBack.TabIndex = 11
        Me.BtnBack.Text = "Back"
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'TxtUpdateDB
        '
        Me.TxtUpdateDB.Cursor = System.Windows.Forms.Cursors.PanWest
        Me.TxtUpdateDB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUpdateDB.Location = New System.Drawing.Point(327, 358)
        Me.TxtUpdateDB.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtUpdateDB.Name = "TxtUpdateDB"
        Me.TxtUpdateDB.Size = New System.Drawing.Size(128, 34)
        Me.TxtUpdateDB.TabIndex = 12
        Me.TxtUpdateDB.Text = "Update"
        Me.TxtUpdateDB.UseVisualStyleBackColor = True
        '
        'Tenants
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(789, 454)
        Me.Controls.Add(Me.TxtUpdateDB)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Tenants"
        Me.Text = "Tenants"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BtnBack As Button
    Friend WithEvents TxtUpdateDB As Button
End Class
