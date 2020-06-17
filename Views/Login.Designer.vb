<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.usernamelogin = New System.Windows.Forms.TextBox()
        Me.passwordlogin = New System.Windows.Forms.TextBox()
        Me.loginbutton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(608, 178)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(290, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Turkson Cars Rental Login"
        '
        'usernamelogin
        '
        Me.usernamelogin.Font = New System.Drawing.Font("Microsoft Tai Le", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usernamelogin.Location = New System.Drawing.Point(588, 262)
        Me.usernamelogin.Name = "usernamelogin"
        Me.usernamelogin.Size = New System.Drawing.Size(333, 37)
        Me.usernamelogin.TabIndex = 1
        '
        'passwordlogin
        '
        Me.passwordlogin.Font = New System.Drawing.Font("Microsoft Tai Le", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordlogin.Location = New System.Drawing.Point(588, 341)
        Me.passwordlogin.Name = "passwordlogin"
        Me.passwordlogin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passwordlogin.Size = New System.Drawing.Size(333, 37)
        Me.passwordlogin.TabIndex = 2
        '
        'loginbutton
        '
        Me.loginbutton.BackColor = System.Drawing.Color.LightBlue
        Me.loginbutton.Font = New System.Drawing.Font("Microsoft Tai Le", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginbutton.Location = New System.Drawing.Point(588, 414)
        Me.loginbutton.Name = "loginbutton"
        Me.loginbutton.Size = New System.Drawing.Size(333, 39)
        Me.loginbutton.TabIndex = 3
        Me.loginbutton.Text = "Log In"
        Me.loginbutton.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(473, 269)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 30)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Email"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Tai Le", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(432, 350)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 30)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Password"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(1459, 652)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.loginbutton)
        Me.Controls.Add(Me.passwordlogin)
        Me.Controls.Add(Me.usernamelogin)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Login"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents usernamelogin As TextBox
    Friend WithEvents passwordlogin As TextBox
    Friend WithEvents loginbutton As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
