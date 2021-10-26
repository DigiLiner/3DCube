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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        Me.HScrollBar1 = New System.Windows.Forms.HScrollBar()
        Me.VScrollBar2 = New System.Windows.Forms.VScrollBar()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global._3DCube.My.Resources.Resources.Adsız
        Me.PictureBox1.Location = New System.Drawing.Point(3, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(731, 392)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(820, 46)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(79, 34)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Up"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(786, 89)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(50, 35)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Left"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(842, 89)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(56, 35)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Down"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(904, 89)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(49, 35)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Right"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(802, 130)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "Fwd"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(884, 129)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(51, 23)
        Me.Button6.TabIndex = 6
        Me.Button6.Text = "Back"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'VScrollBar1
        '
        Me.VScrollBar1.Location = New System.Drawing.Point(717, 12)
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(16, 392)
        Me.VScrollBar1.TabIndex = 7
        '
        'HScrollBar1
        '
        Me.HScrollBar1.Location = New System.Drawing.Point(19, 388)
        Me.HScrollBar1.Name = "HScrollBar1"
        Me.HScrollBar1.Size = New System.Drawing.Size(698, 16)
        Me.HScrollBar1.TabIndex = 8
        '
        'VScrollBar2
        '
        Me.VScrollBar2.Location = New System.Drawing.Point(3, 12)
        Me.VScrollBar2.Name = "VScrollBar2"
        Me.VScrollBar2.Size = New System.Drawing.Size(16, 392)
        Me.VScrollBar2.TabIndex = 9
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(811, 182)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(66, 20)
        Me.TextBox1.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(983, 416)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.VScrollBar2)
        Me.Controls.Add(Me.HScrollBar1)
        Me.Controls.Add(Me.VScrollBar1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents VScrollBar1 As System.Windows.Forms.VScrollBar
    Friend WithEvents HScrollBar1 As System.Windows.Forms.HScrollBar
    Friend WithEvents VScrollBar2 As System.Windows.Forms.VScrollBar
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox

End Class
