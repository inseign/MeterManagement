<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CboStartDate = New System.Windows.Forms.ComboBox()
        Me.startDate = New System.Windows.Forms.Label()
        Me.finishDate = New System.Windows.Forms.Label()
        Me.CboFinishDate = New System.Windows.Forms.ComboBox()
        Me.table = New System.Windows.Forms.Label()
        Me.CboTable = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtDifferential = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDayUse = New System.Windows.Forms.TextBox()
        Me.txtDayPercent = New System.Windows.Forms.TextBox()
        Me.txtNightPercent = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNightUse = New System.Windows.Forms.TextBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtStartReading = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtFinishReading = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(620, 14)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 46)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Generate Excel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CboStartDate
        '
        Me.CboStartDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboStartDate.FormattingEnabled = True
        Me.CboStartDate.Location = New System.Drawing.Point(334, 32)
        Me.CboStartDate.Margin = New System.Windows.Forms.Padding(2)
        Me.CboStartDate.Name = "CboStartDate"
        Me.CboStartDate.Size = New System.Drawing.Size(122, 28)
        Me.CboStartDate.TabIndex = 1
        '
        'startDate
        '
        Me.startDate.AutoSize = True
        Me.startDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.startDate.Location = New System.Drawing.Point(337, 14)
        Me.startDate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.startDate.Name = "startDate"
        Me.startDate.Size = New System.Drawing.Size(87, 17)
        Me.startDate.TabIndex = 2
        Me.startDate.Text = "Start Date:"
        '
        'finishDate
        '
        Me.finishDate.AutoSize = True
        Me.finishDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.finishDate.Location = New System.Drawing.Point(470, 14)
        Me.finishDate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.finishDate.Name = "finishDate"
        Me.finishDate.Size = New System.Drawing.Size(95, 17)
        Me.finishDate.TabIndex = 4
        Me.finishDate.Text = "Finish Date:"
        '
        'CboFinishDate
        '
        Me.CboFinishDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboFinishDate.FormattingEnabled = True
        Me.CboFinishDate.Location = New System.Drawing.Point(467, 32)
        Me.CboFinishDate.Margin = New System.Windows.Forms.Padding(2)
        Me.CboFinishDate.Name = "CboFinishDate"
        Me.CboFinishDate.Size = New System.Drawing.Size(122, 28)
        Me.CboFinishDate.TabIndex = 3
        '
        'table
        '
        Me.table.AutoSize = True
        Me.table.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.table.Location = New System.Drawing.Point(27, 14)
        Me.table.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.table.Name = "table"
        Me.table.Size = New System.Drawing.Size(54, 17)
        Me.table.TabIndex = 6
        Me.table.Text = "Table:"
        '
        'CboTable
        '
        Me.CboTable.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboTable.FormattingEnabled = True
        Me.CboTable.Location = New System.Drawing.Point(25, 32)
        Me.CboTable.Margin = New System.Windows.Forms.Padding(2)
        Me.CboTable.Name = "CboTable"
        Me.CboTable.Size = New System.Drawing.Size(293, 28)
        Me.CboTable.TabIndex = 5
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(9, 92)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(533, 353)
        Me.DataGridView1.TabIndex = 7
        '
        'txtDifferential
        '
        Me.txtDifferential.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDifferential.Location = New System.Drawing.Point(563, 255)
        Me.txtDifferential.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDifferential.Name = "txtDifferential"
        Me.txtDifferential.ReadOnly = True
        Me.txtDifferential.Size = New System.Drawing.Size(207, 26)
        Me.txtDifferential.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(565, 232)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Total Usage"
        '
        'BtnBack
        '
        Me.BtnBack.Cursor = System.Windows.Forms.Cursors.PanWest
        Me.BtnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBack.Location = New System.Drawing.Point(641, 410)
        Me.BtnBack.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(128, 34)
        Me.BtnBack.TabIndex = 10
        Me.BtnBack.Text = "Back"
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(564, 283)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 20)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Peak Usage"
        '
        'txtDayUse
        '
        Me.txtDayUse.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDayUse.Location = New System.Drawing.Point(562, 307)
        Me.txtDayUse.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDayUse.Name = "txtDayUse"
        Me.txtDayUse.ReadOnly = True
        Me.txtDayUse.Size = New System.Drawing.Size(120, 26)
        Me.txtDayUse.TabIndex = 11
        '
        'txtDayPercent
        '
        Me.txtDayPercent.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDayPercent.Location = New System.Drawing.Point(699, 307)
        Me.txtDayPercent.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDayPercent.Name = "txtDayPercent"
        Me.txtDayPercent.ReadOnly = True
        Me.txtDayPercent.Size = New System.Drawing.Size(70, 26)
        Me.txtDayPercent.TabIndex = 13
        '
        'txtNightPercent
        '
        Me.txtNightPercent.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNightPercent.Location = New System.Drawing.Point(700, 359)
        Me.txtNightPercent.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNightPercent.Name = "txtNightPercent"
        Me.txtNightPercent.ReadOnly = True
        Me.txtNightPercent.Size = New System.Drawing.Size(70, 26)
        Me.txtNightPercent.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(562, 335)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 20)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Off-Peak Usage"
        '
        'txtNightUse
        '
        Me.txtNightUse.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNightUse.Location = New System.Drawing.Point(563, 359)
        Me.txtNightUse.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNightUse.Name = "txtNightUse"
        Me.txtNightUse.ReadOnly = True
        Me.txtNightUse.Size = New System.Drawing.Size(120, 26)
        Me.txtNightUse.TabIndex = 14
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(563, 92)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(207, 23)
        Me.ProgressBar1.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(565, 69)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 20)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Progress ..."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(565, 130)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 20)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Start Reading"
        '
        'txtStartReading
        '
        Me.txtStartReading.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStartReading.Location = New System.Drawing.Point(563, 153)
        Me.txtStartReading.Margin = New System.Windows.Forms.Padding(2)
        Me.txtStartReading.Name = "txtStartReading"
        Me.txtStartReading.ReadOnly = True
        Me.txtStartReading.Size = New System.Drawing.Size(207, 26)
        Me.txtStartReading.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(565, 181)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(129, 20)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Finish Reading"
        '
        'txtFinishReading
        '
        Me.txtFinishReading.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFinishReading.Location = New System.Drawing.Point(563, 204)
        Me.txtFinishReading.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFinishReading.Name = "txtFinishReading"
        Me.txtFinishReading.ReadOnly = True
        Me.txtFinishReading.Size = New System.Drawing.Size(207, 26)
        Me.txtFinishReading.TabIndex = 21
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(789, 454)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtFinishReading)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtStartReading)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.txtNightPercent)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNightUse)
        Me.Controls.Add(Me.txtDayPercent)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDayUse)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDifferential)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.table)
        Me.Controls.Add(Me.CboTable)
        Me.Controls.Add(Me.finishDate)
        Me.Controls.Add(Me.CboFinishDate)
        Me.Controls.Add(Me.startDate)
        Me.Controls.Add(Me.CboStartDate)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Main"
        Me.Text = "Leopard Energry Monitoring"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents CboStartDate As ComboBox
    Friend WithEvents startDate As Label
    Friend WithEvents finishDate As Label
    Friend WithEvents CboFinishDate As ComboBox
    Friend WithEvents table As Label
    Friend WithEvents CboTable As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtDifferential As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnBack As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDayUse As TextBox
    Friend WithEvents txtDayPercent As TextBox
    Friend WithEvents txtNightPercent As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNightUse As TextBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtStartReading As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtFinishReading As TextBox
End Class
