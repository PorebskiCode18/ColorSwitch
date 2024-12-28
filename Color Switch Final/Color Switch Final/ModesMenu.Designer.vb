<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModesMenu
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnClassic = New System.Windows.Forms.Button()
        Me.btnBreaker = New System.Windows.Forms.Button()
        Me.btnFlappy = New System.Windows.Forms.Button()
        Me.btnBlack = New System.Windows.Forms.Button()
        Me.lblClassicPerc = New System.Windows.Forms.Label()
        Me.lblBreakerPerc = New System.Windows.Forms.Label()
        Me.lblFlappyPerc = New System.Windows.Forms.Label()
        Me.lblBlackPerc = New System.Windows.Forms.Label()
        Me.lblClassicComplete = New System.Windows.Forms.Label()
        Me.lblFlappyComplete = New System.Windows.Forms.Label()
        Me.lblBreakerComplete = New System.Windows.Forms.Label()
        Me.lblBlackComplete = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(215, -14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(351, 479)
        Me.Label1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(218, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(348, 62)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "         Game Modes"
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(230, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(71, 43)
        Me.btnBack.TabIndex = 3
        Me.btnBack.Text = "←"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnClassic
        '
        Me.btnClassic.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnClassic.Location = New System.Drawing.Point(225, 75)
        Me.btnClassic.Name = "btnClassic"
        Me.btnClassic.Size = New System.Drawing.Size(260, 50)
        Me.btnClassic.TabIndex = 4
        Me.btnClassic.Text = "Classic"
        Me.btnClassic.UseVisualStyleBackColor = False
        '
        'btnBreaker
        '
        Me.btnBreaker.BackColor = System.Drawing.Color.PaleGreen
        Me.btnBreaker.Enabled = False
        Me.btnBreaker.Location = New System.Drawing.Point(225, 131)
        Me.btnBreaker.Name = "btnBreaker"
        Me.btnBreaker.Size = New System.Drawing.Size(260, 50)
        Me.btnBreaker.TabIndex = 5
        Me.btnBreaker.Text = "Under Development"
        Me.btnBreaker.UseVisualStyleBackColor = False
        '
        'btnFlappy
        '
        Me.btnFlappy.BackColor = System.Drawing.Color.Khaki
        Me.btnFlappy.Enabled = False
        Me.btnFlappy.Location = New System.Drawing.Point(225, 187)
        Me.btnFlappy.Name = "btnFlappy"
        Me.btnFlappy.Size = New System.Drawing.Size(260, 50)
        Me.btnFlappy.TabIndex = 6
        Me.btnFlappy.Text = "Under Development"
        Me.btnFlappy.UseVisualStyleBackColor = False
        '
        'btnBlack
        '
        Me.btnBlack.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnBlack.Enabled = False
        Me.btnBlack.Location = New System.Drawing.Point(225, 243)
        Me.btnBlack.Name = "btnBlack"
        Me.btnBlack.Size = New System.Drawing.Size(260, 50)
        Me.btnBlack.TabIndex = 7
        Me.btnBlack.Text = "Under Development"
        Me.btnBlack.UseVisualStyleBackColor = False
        '
        'lblClassicPerc
        '
        Me.lblClassicPerc.AutoSize = True
        Me.lblClassicPerc.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblClassicPerc.Font = New System.Drawing.Font("Microsoft YaHei", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClassicPerc.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblClassicPerc.Location = New System.Drawing.Point(491, 75)
        Me.lblClassicPerc.Name = "lblClassicPerc"
        Me.lblClassicPerc.Size = New System.Drawing.Size(43, 28)
        Me.lblClassicPerc.TabIndex = 8
        Me.lblClassicPerc.Text = "0%"
        '
        'lblBreakerPerc
        '
        Me.lblBreakerPerc.AutoSize = True
        Me.lblBreakerPerc.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblBreakerPerc.Font = New System.Drawing.Font("Microsoft YaHei", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBreakerPerc.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblBreakerPerc.Location = New System.Drawing.Point(491, 131)
        Me.lblBreakerPerc.Name = "lblBreakerPerc"
        Me.lblBreakerPerc.Size = New System.Drawing.Size(43, 28)
        Me.lblBreakerPerc.TabIndex = 9
        Me.lblBreakerPerc.Text = "0%"
        '
        'lblFlappyPerc
        '
        Me.lblFlappyPerc.AutoSize = True
        Me.lblFlappyPerc.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblFlappyPerc.Font = New System.Drawing.Font("Microsoft YaHei", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFlappyPerc.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblFlappyPerc.Location = New System.Drawing.Point(491, 187)
        Me.lblFlappyPerc.Name = "lblFlappyPerc"
        Me.lblFlappyPerc.Size = New System.Drawing.Size(43, 28)
        Me.lblFlappyPerc.TabIndex = 10
        Me.lblFlappyPerc.Text = "0%"
        '
        'lblBlackPerc
        '
        Me.lblBlackPerc.AutoSize = True
        Me.lblBlackPerc.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblBlackPerc.Font = New System.Drawing.Font("Microsoft YaHei", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBlackPerc.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblBlackPerc.Location = New System.Drawing.Point(491, 243)
        Me.lblBlackPerc.Name = "lblBlackPerc"
        Me.lblBlackPerc.Size = New System.Drawing.Size(43, 28)
        Me.lblBlackPerc.TabIndex = 11
        Me.lblBlackPerc.Text = "0%"
        '
        'lblClassicComplete
        '
        Me.lblClassicComplete.AutoSize = True
        Me.lblClassicComplete.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblClassicComplete.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClassicComplete.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblClassicComplete.Location = New System.Drawing.Point(491, 103)
        Me.lblClassicComplete.Name = "lblClassicComplete"
        Me.lblClassicComplete.Size = New System.Drawing.Size(35, 21)
        Me.lblClassicComplete.TabIndex = 12
        Me.lblClassicComplete.Text = "0/5"
        '
        'lblFlappyComplete
        '
        Me.lblFlappyComplete.AutoSize = True
        Me.lblFlappyComplete.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblFlappyComplete.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFlappyComplete.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblFlappyComplete.Location = New System.Drawing.Point(492, 215)
        Me.lblFlappyComplete.Name = "lblFlappyComplete"
        Me.lblFlappyComplete.Size = New System.Drawing.Size(35, 21)
        Me.lblFlappyComplete.TabIndex = 13
        Me.lblFlappyComplete.Text = "0/5"
        '
        'lblBreakerComplete
        '
        Me.lblBreakerComplete.AutoSize = True
        Me.lblBreakerComplete.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblBreakerComplete.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBreakerComplete.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblBreakerComplete.Location = New System.Drawing.Point(492, 159)
        Me.lblBreakerComplete.Name = "lblBreakerComplete"
        Me.lblBreakerComplete.Size = New System.Drawing.Size(35, 21)
        Me.lblBreakerComplete.TabIndex = 14
        Me.lblBreakerComplete.Text = "0/5"
        '
        'lblBlackComplete
        '
        Me.lblBlackComplete.AutoSize = True
        Me.lblBlackComplete.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblBlackComplete.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBlackComplete.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblBlackComplete.Location = New System.Drawing.Point(491, 272)
        Me.lblBlackComplete.Name = "lblBlackComplete"
        Me.lblBlackComplete.Size = New System.Drawing.Size(35, 21)
        Me.lblBlackComplete.TabIndex = 15
        Me.lblBlackComplete.Text = "0/5"
        '
        'ModesMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblBlackComplete)
        Me.Controls.Add(Me.lblBreakerComplete)
        Me.Controls.Add(Me.lblFlappyComplete)
        Me.Controls.Add(Me.lblClassicComplete)
        Me.Controls.Add(Me.lblBlackPerc)
        Me.Controls.Add(Me.lblFlappyPerc)
        Me.Controls.Add(Me.lblBreakerPerc)
        Me.Controls.Add(Me.lblClassicPerc)
        Me.Controls.Add(Me.btnBlack)
        Me.Controls.Add(Me.btnFlappy)
        Me.Controls.Add(Me.btnBreaker)
        Me.Controls.Add(Me.btnClassic)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ModesMenu"
        Me.Text = "ModesMenu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents btnClassic As Button
    Friend WithEvents btnBreaker As Button
    Friend WithEvents btnFlappy As Button
    Friend WithEvents btnBlack As Button
    Friend WithEvents lblClassicPerc As Label
    Friend WithEvents lblBreakerPerc As Label
    Friend WithEvents lblFlappyPerc As Label
    Friend WithEvents lblBlackPerc As Label
    Friend WithEvents lblClassicComplete As Label
    Friend WithEvents lblFlappyComplete As Label
    Friend WithEvents lblBreakerComplete As Label
    Friend WithEvents lblBlackComplete As Label
End Class
