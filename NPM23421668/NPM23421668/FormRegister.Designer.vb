<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRegister
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
        Me.lblKirim = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPasswordUlang = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.pbProfile = New System.Windows.Forms.PictureBox()
        CType(Me.pbProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblKirim
        '
        Me.lblKirim.AutoSize = True
        Me.lblKirim.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKirim.Location = New System.Drawing.Point(265, 275)
        Me.lblKirim.Name = "lblKirim"
        Me.lblKirim.Size = New System.Drawing.Size(86, 17)
        Me.lblKirim.TabIndex = 23
        Me.lblKirim.Text = "Kirim Ulang"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(71, 275)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(159, 17)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Belum dapat kode OTP ?"
        '
        'btnRegister
        '
        Me.btnRegister.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnRegister.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegister.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.ForeColor = System.Drawing.Color.White
        Me.btnRegister.Location = New System.Drawing.Point(0, 337)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(453, 45)
        Me.btnRegister.TabIndex = 4
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(172, 173)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(230, 24)
        Me.txtPassword.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 17)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Passwod"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(172, 141)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(230, 24)
        Me.txtEmail.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 17)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Email"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(34, 94)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(368, 1)
        Me.Panel1.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(239, 17)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Isikan informasi anda dengan lengkap." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 27)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Register"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(172, 109)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(230, 24)
        Me.txtUsername.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(30, 112)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 17)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Username"
        '
        'txtPasswordUlang
        '
        Me.txtPasswordUlang.Location = New System.Drawing.Point(172, 205)
        Me.txtPasswordUlang.Name = "txtPasswordUlang"
        Me.txtPasswordUlang.Size = New System.Drawing.Size(230, 24)
        Me.txtPasswordUlang.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(30, 208)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(109, 17)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Passwod (Ulang)"
        '
        'pbProfile
        '
        Me.pbProfile.Image = Global.NPM23421668.My.Resources.Resources.profile
        Me.pbProfile.Location = New System.Drawing.Point(343, 27)
        Me.pbProfile.Name = "pbProfile"
        Me.pbProfile.Size = New System.Drawing.Size(50, 50)
        Me.pbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbProfile.TabIndex = 29
        Me.pbProfile.TabStop = False
        '
        'FormRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(453, 382)
        Me.Controls.Add(Me.pbProfile)
        Me.Controls.Add(Me.txtPasswordUlang)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblKirim)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FormRegister"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormRegister"
        CType(Me.pbProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblKirim As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnRegister As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPasswordUlang As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents pbProfile As PictureBox
End Class
