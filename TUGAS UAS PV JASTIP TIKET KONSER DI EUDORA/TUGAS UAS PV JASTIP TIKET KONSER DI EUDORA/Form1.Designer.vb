<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblJudul = New System.Windows.Forms.Label()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.dgvJastip = New System.Windows.Forms.DataGridView()
        Me.btnBaca = New System.Windows.Forms.Button()
        CType(Me.dgvJastip, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblJudul
        '
        Me.lblJudul.AutoSize = True
        Me.lblJudul.BackColor = System.Drawing.Color.AliceBlue
        Me.lblJudul.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudul.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblJudul.Location = New System.Drawing.Point(219, 17)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(351, 30)
        Me.lblJudul.TabIndex = 0
        Me.lblJudul.Text = "JASTIP TIKET KONSER DI EUDORA"
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.BackColor = System.Drawing.Color.AliceBlue
        Me.lblInfo.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblInfo.Location = New System.Drawing.Point(3, 369)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(68, 25)
        Me.lblInfo.TabIndex = 1
        Me.lblInfo.Text = "TOTAL"
        '
        'dgvJastip
        '
        Me.dgvJastip.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.dgvJastip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvJastip.Location = New System.Drawing.Point(1, 72)
        Me.dgvJastip.Name = "dgvJastip"
        Me.dgvJastip.Size = New System.Drawing.Size(804, 267)
        Me.dgvJastip.TabIndex = 2
        '
        'btnBaca
        '
        Me.btnBaca.BackColor = System.Drawing.Color.AliceBlue
        Me.btnBaca.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBaca.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnBaca.Location = New System.Drawing.Point(614, 345)
        Me.btnBaca.Name = "btnBaca"
        Me.btnBaca.Size = New System.Drawing.Size(191, 29)
        Me.btnBaca.TabIndex = 3
        Me.btnBaca.Text = "BACA DATA JASTIP"
        Me.btnBaca.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnBaca)
        Me.Controls.Add(Me.dgvJastip)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.lblJudul)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgvJastip, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblJudul As Label
    Friend WithEvents lblInfo As Label
    Friend WithEvents dgvJastip As DataGridView
    Friend WithEvents btnBaca As Button
End Class
