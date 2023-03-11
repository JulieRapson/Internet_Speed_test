<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSpeed
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnSpeed = New System.Windows.Forms.Button()
        Me.lstBoxSpeed = New System.Windows.Forms.ListBox()
        Me.lblAvgSpeed = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(343, 66)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(387, 33)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Internet Speed Test Survey"
        '
        'btnSpeed
        '
        Me.btnSpeed.BackColor = System.Drawing.Color.DarkKhaki
        Me.btnSpeed.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSpeed.ForeColor = System.Drawing.Color.Black
        Me.btnSpeed.Location = New System.Drawing.Point(384, 128)
        Me.btnSpeed.Name = "btnSpeed"
        Me.btnSpeed.Size = New System.Drawing.Size(291, 42)
        Me.btnSpeed.TabIndex = 1
        Me.btnSpeed.Text = "Enter Internet Speed"
        Me.btnSpeed.UseVisualStyleBackColor = False
        '
        'lstBoxSpeed
        '
        Me.lstBoxSpeed.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstBoxSpeed.FormattingEnabled = True
        Me.lstBoxSpeed.ItemHeight = 18
        Me.lstBoxSpeed.Location = New System.Drawing.Point(761, 109)
        Me.lstBoxSpeed.Name = "lstBoxSpeed"
        Me.lstBoxSpeed.Size = New System.Drawing.Size(80, 148)
        Me.lstBoxSpeed.TabIndex = 2
        '
        'lblAvgSpeed
        '
        Me.lblAvgSpeed.AutoSize = True
        Me.lblAvgSpeed.BackColor = System.Drawing.Color.Transparent
        Me.lblAvgSpeed.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvgSpeed.Location = New System.Drawing.Point(491, 485)
        Me.lblAvgSpeed.Name = "lblAvgSpeed"
        Me.lblAvgSpeed.Size = New System.Drawing.Size(77, 24)
        Me.lblAvgSpeed.TabIndex = 3
        Me.lblAvgSpeed.Text = "Label1"
        Me.lblAvgSpeed.Visible = False
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(579, 564)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'frmSpeed
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.InternetSpeedTest.My.Resources.Resources.speed
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(908, 599)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblAvgSpeed)
        Me.Controls.Add(Me.lstBoxSpeed)
        Me.Controls.Add(Me.btnSpeed)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmSpeed"
        Me.Text = "Internet Speed Test Survey for Home Users"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents btnSpeed As Button
    Friend WithEvents lstBoxSpeed As ListBox
    Friend WithEvents lblAvgSpeed As Label
    Friend WithEvents btnClear As Button
End Class
