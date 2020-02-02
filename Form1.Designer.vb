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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.text2 = New System.Windows.Forms.TextBox()
        Me.PASSWORD = New System.Windows.Forms.Label()
        Me.USERNAME = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.text1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.Location = New System.Drawing.Point(627, 669)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(209, 41)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "LOGIN"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'text2
        '
        Me.text2.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.text2.Location = New System.Drawing.Point(862, 559)
        Me.text2.Margin = New System.Windows.Forms.Padding(4)
        Me.text2.Multiline = True
        Me.text2.Name = "text2"
        Me.text2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.text2.Size = New System.Drawing.Size(249, 42)
        Me.text2.TabIndex = 20
        '
        'PASSWORD
        '
        Me.PASSWORD.AutoSize = True
        Me.PASSWORD.BackColor = System.Drawing.Color.Transparent
        Me.PASSWORD.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PASSWORD.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PASSWORD.Location = New System.Drawing.Point(625, 576)
        Me.PASSWORD.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PASSWORD.Name = "PASSWORD"
        Me.PASSWORD.Size = New System.Drawing.Size(131, 29)
        Me.PASSWORD.TabIndex = 18
        Me.PASSWORD.Text = "PASSWORD"
        '
        'USERNAME
        '
        Me.USERNAME.AutoSize = True
        Me.USERNAME.BackColor = System.Drawing.Color.Transparent
        Me.USERNAME.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.USERNAME.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.USERNAME.Location = New System.Drawing.Point(625, 497)
        Me.USERNAME.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.USERNAME.Name = "USERNAME"
        Me.USERNAME.Size = New System.Drawing.Size(128, 29)
        Me.USERNAME.TabIndex = 17
        Me.USERNAME.Text = "USERNAME"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Button2.Location = New System.Drawing.Point(893, 668)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(208, 41)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "EXIT"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'text1
        '
        Me.text1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.text1.Location = New System.Drawing.Point(862, 497)
        Me.text1.Margin = New System.Windows.Forms.Padding(4)
        Me.text1.Multiline = True
        Me.text1.Name = "text1"
        Me.text1.Size = New System.Drawing.Size(249, 40)
        Me.text1.TabIndex = 25
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.logo3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1407, 771)
        Me.Controls.Add(Me.text1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.text2)
        Me.Controls.Add(Me.PASSWORD)
        Me.Controls.Add(Me.USERNAME)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.ShowInTaskbar = False
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents text2 As System.Windows.Forms.TextBox
    Friend WithEvents PASSWORD As System.Windows.Forms.Label
    Friend WithEvents USERNAME As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents text1 As System.Windows.Forms.TextBox

End Class
