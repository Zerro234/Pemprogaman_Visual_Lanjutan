<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormHome
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
        Me.components = New System.ComponentModel.Container()
        Me.pnHeader = New System.Windows.Forms.Panel()
        Me.btnRefresh = New System.Windows.Forms.PictureBox()
        Me.lblPost = New System.Windows.Forms.Label()
        Me.pbProfile = New System.Windows.Forms.PictureBox()
        Me.pnBody = New System.Windows.Forms.Panel()
        Me.tWait = New System.Windows.Forms.Timer(Me.components)
        Me.pnHeader.SuspendLayout()
        CType(Me.btnRefresh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnHeader
        '
        Me.pnHeader.Controls.Add(Me.btnRefresh)
        Me.pnHeader.Controls.Add(Me.lblPost)
        Me.pnHeader.Controls.Add(Me.pbProfile)
        Me.pnHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnHeader.Name = "pnHeader"
        Me.pnHeader.Padding = New System.Windows.Forms.Padding(10)
        Me.pnHeader.Size = New System.Drawing.Size(453, 70)
        Me.pnHeader.TabIndex = 0
        '
        'btnRefresh
        '
        Me.btnRefresh.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnRefresh.Image = Global.NPM23421668.My.Resources.Resources.image
        Me.btnRefresh.Location = New System.Drawing.Point(393, 10)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(50, 50)
        Me.btnRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnRefresh.TabIndex = 3
        Me.btnRefresh.TabStop = False
        '
        'lblPost
        '
        Me.lblPost.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPost.Location = New System.Drawing.Point(60, 10)
        Me.lblPost.Name = "lblPost"
        Me.lblPost.Padding = New System.Windows.Forms.Padding(5)
        Me.lblPost.Size = New System.Drawing.Size(383, 50)
        Me.lblPost.TabIndex = 2
        Me.lblPost.Text = "What's on your mind?"
        Me.lblPost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pbProfile
        '
        Me.pbProfile.Dock = System.Windows.Forms.DockStyle.Left
        Me.pbProfile.Image = Global.NPM23421668.My.Resources.Resources.profile
        Me.pbProfile.Location = New System.Drawing.Point(10, 10)
        Me.pbProfile.Name = "pbProfile"
        Me.pbProfile.Size = New System.Drawing.Size(50, 50)
        Me.pbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbProfile.TabIndex = 1
        Me.pbProfile.TabStop = False
        '
        'pnBody
        '
        Me.pnBody.AutoScroll = True
        Me.pnBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnBody.Location = New System.Drawing.Point(0, 70)
        Me.pnBody.Name = "pnBody"
        Me.pnBody.Size = New System.Drawing.Size(453, 766)
        Me.pnBody.TabIndex = 1
        '
        'tWait
        '
        Me.tWait.Interval = 1000
        '
        'FormHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(453, 836)
        Me.Controls.Add(Me.pnBody)
        Me.Controls.Add(Me.pnHeader)
        Me.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FormHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NPM23421668"
        Me.pnHeader.ResumeLayout(False)
        CType(Me.btnRefresh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnHeader As Panel
    Friend WithEvents pnBody As Panel
    Friend WithEvents pbProfile As PictureBox
    Friend WithEvents btnRefresh As PictureBox
    Friend WithEvents lblPost As Label
    Friend WithEvents tWait As Timer
    'Friend WithEvents PnStatus2 As PnStatus
    'Friend WithEvents PnStatus1 As PnStatus
End Class
