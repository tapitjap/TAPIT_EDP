﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BackupButton = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button5
        '
        Me.Button5.Image = Global.WindowsApp1.My.Resources.Resources.office_building
        Me.Button5.Location = New System.Drawing.Point(624, 62)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(146, 155)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Offices"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(201, 232)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 23)
        Me.Button8.TabIndex = 7
        Me.Button8.Text = "Log Out"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Image = Global.WindowsApp1.My.Resources.Resources.tapi5
        Me.Button4.Location = New System.Drawing.Point(472, 62)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(146, 155)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Customers"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Image = Global.WindowsApp1.My.Resources.Resources.clipboard
        Me.Button3.Location = New System.Drawing.Point(320, 62)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(146, 155)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Orders"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = Global.WindowsApp1.My.Resources.Resources.tapi3
        Me.Button2.Location = New System.Drawing.Point(168, 62)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(146, 155)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Products"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = Global.WindowsApp1.My.Resources.Resources.tapi2
        Me.Button1.Location = New System.Drawing.Point(12, 62)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(146, 155)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Employees"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BackupButton
        '
        Me.BackupButton.Location = New System.Drawing.Point(499, 232)
        Me.BackupButton.Name = "BackupButton"
        Me.BackupButton.Size = New System.Drawing.Size(75, 23)
        Me.BackupButton.TabIndex = 9
        Me.BackupButton.Text = "backup"
        Me.BackupButton.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(355, 232)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 10
        Me.Button6.Text = "upload data"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 267)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.BackupButton)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form2"
        Me.Text = "Main UI"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents BackupButton As Button
    Friend WithEvents Button6 As Button
End Class
