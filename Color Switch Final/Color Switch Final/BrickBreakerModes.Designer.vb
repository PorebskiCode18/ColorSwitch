﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BrickBreakerModes
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
        Me.btnLevel5 = New System.Windows.Forms.Button()
        Me.btnLevel4 = New System.Windows.Forms.Button()
        Me.btnLevel3 = New System.Windows.Forms.Button()
        Me.btnLevel2 = New System.Windows.Forms.Button()
        Me.btnLevel1 = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnLevel5
        '
        Me.btnLevel5.Enabled = False
        Me.btnLevel5.Location = New System.Drawing.Point(235, 150)
        Me.btnLevel5.Name = "btnLevel5"
        Me.btnLevel5.Size = New System.Drawing.Size(71, 61)
        Me.btnLevel5.TabIndex = 19
        Me.btnLevel5.Text = "Level 5"
        Me.btnLevel5.UseVisualStyleBackColor = True
        '
        'btnLevel4
        '
        Me.btnLevel4.Enabled = False
        Me.btnLevel4.Location = New System.Drawing.Point(495, 74)
        Me.btnLevel4.Name = "btnLevel4"
        Me.btnLevel4.Size = New System.Drawing.Size(71, 61)
        Me.btnLevel4.TabIndex = 18
        Me.btnLevel4.Text = "Level 4"
        Me.btnLevel4.UseVisualStyleBackColor = True
        '
        'btnLevel3
        '
        Me.btnLevel3.Enabled = False
        Me.btnLevel3.Location = New System.Drawing.Point(409, 74)
        Me.btnLevel3.Name = "btnLevel3"
        Me.btnLevel3.Size = New System.Drawing.Size(71, 61)
        Me.btnLevel3.TabIndex = 17
        Me.btnLevel3.Text = "Level 3"
        Me.btnLevel3.UseVisualStyleBackColor = True
        '
        'btnLevel2
        '
        Me.btnLevel2.Enabled = False
        Me.btnLevel2.Location = New System.Drawing.Point(322, 74)
        Me.btnLevel2.Name = "btnLevel2"
        Me.btnLevel2.Size = New System.Drawing.Size(71, 61)
        Me.btnLevel2.TabIndex = 16
        Me.btnLevel2.Text = "Level 2"
        Me.btnLevel2.UseVisualStyleBackColor = True
        '
        'btnLevel1
        '
        Me.btnLevel1.Location = New System.Drawing.Point(235, 74)
        Me.btnLevel1.Name = "btnLevel1"
        Me.btnLevel1.Size = New System.Drawing.Size(71, 61)
        Me.btnLevel1.TabIndex = 15
        Me.btnLevel1.Text = "Level 1"
        Me.btnLevel1.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(235, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(71, 43)
        Me.btnBack.TabIndex = 14
        Me.btnBack.Text = "←"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(228, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(348, 62)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "        Brick Breaker"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(225, -14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(351, 479)
        Me.Label1.TabIndex = 12
        '
        'BrickBreakerModes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnLevel5)
        Me.Controls.Add(Me.btnLevel4)
        Me.Controls.Add(Me.btnLevel3)
        Me.Controls.Add(Me.btnLevel2)
        Me.Controls.Add(Me.btnLevel1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "BrickBreakerModes"
        Me.Text = "BrickBreakerModes"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnLevel5 As Button
    Friend WithEvents btnLevel4 As Button
    Friend WithEvents btnLevel3 As Button
    Friend WithEvents btnLevel2 As Button
    Friend WithEvents btnLevel1 As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
