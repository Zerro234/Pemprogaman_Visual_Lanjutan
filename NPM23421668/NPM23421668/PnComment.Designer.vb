<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PnComment
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.pbProfile = New System.Windows.Forms.PictureBox()
        Me.lblCaption = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.pbProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.pbProfile)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(530, 66)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblCaption)
        Me.Panel2.Controls.Add(Me.lblNama)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(56, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(474, 66)
        Me.Panel2.TabIndex = 1
        '
        'lblNama
        '
        Me.lblNama.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblNama.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNama.Location = New System.Drawing.Point(0, 0)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(474, 35)
        Me.lblNama.TabIndex = 0
        Me.lblNama.Text = "Nama"
        Me.lblNama.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'pbProfile
        '
        Me.pbProfile.Dock = System.Windows.Forms.DockStyle.Left
        Me.pbProfile.Image = Global.NPM23421668.My.Resources.Resources.profile
        Me.pbProfile.Location = New System.Drawing.Point(0, 0)
        Me.pbProfile.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pbProfile.Name = "pbProfile"
        Me.pbProfile.Size = New System.Drawing.Size(56, 66)
        Me.pbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbProfile.TabIndex = 0
        Me.pbProfile.TabStop = False
        '
        'lblCaption
        '
        Me.lblCaption.AutoSize = True
        Me.lblCaption.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaption.Location = New System.Drawing.Point(9, 39)
        Me.lblCaption.Name = "lblCaption"
        Me.lblCaption.Size = New System.Drawing.Size(19, 16)
        Me.lblCaption.TabIndex = 1
        Me.lblCaption.Text = "..."
        '
        'PnComment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "PnComment"
        Me.Size = New System.Drawing.Size(530, 66)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.pbProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblNama As Label
    Friend WithEvents pbProfile As PictureBox
    Friend WithEvents lblCaption As Label
End Class
