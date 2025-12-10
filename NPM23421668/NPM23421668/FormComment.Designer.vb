<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormComment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormComment))
        Me.txtComment = New System.Windows.Forms.TextBox()
        Me.BtnSend = New System.Windows.Forms.Button()
        Me.pnComments = New System.Windows.Forms.Panel()
        Me.PnStatus1 = New NPM23421668.PnStatus()
        Me.SuspendLayout()
        '
        'txtComment
        '
        Me.txtComment.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtComment.Location = New System.Drawing.Point(0, 605)
        Me.txtComment.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtComment.Name = "txtComment"
        Me.txtComment.Size = New System.Drawing.Size(344, 28)
        Me.txtComment.TabIndex = 11
        '
        'BtnSend
        '
        Me.BtnSend.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnSend.Location = New System.Drawing.Point(344, 603)
        Me.BtnSend.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnSend.Name = "BtnSend"
        Me.BtnSend.Size = New System.Drawing.Size(84, 30)
        Me.BtnSend.TabIndex = 12
        Me.BtnSend.Text = "Send"
        Me.BtnSend.UseVisualStyleBackColor = True
        '
        'pnComments
        '
        Me.pnComments.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnComments.Location = New System.Drawing.Point(0, 204)
        Me.pnComments.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnComments.Name = "pnComments"
        Me.pnComments.Size = New System.Drawing.Size(428, 399)
        Me.pnComments.TabIndex = 13
        '
        'PnStatus1
        '
        Me.PnStatus1.AutoSize = True
        Me.PnStatus1.Caption = "..."
        Me.PnStatus1.CaptionBackColor = System.Drawing.Color.Transparent
        Me.PnStatus1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnStatus1.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PnStatus1.ID_Status = ""
        Me.PnStatus1.ID_User = ""
        Me.PnStatus1.Images = New String(-1) {}
        Me.PnStatus1.Location = New System.Drawing.Point(0, 0)
        Me.PnStatus1.Login = ""
        Me.PnStatus1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.PnStatus1.Nama = "Bung Choi"
        Me.PnStatus1.Name = "PnStatus1"
        Me.PnStatus1.Padding = New System.Windows.Forms.Padding(11, 13, 11, 13)
        Me.PnStatus1.Profile = CType(resources.GetObject("PnStatus1.Profile"), System.Drawing.Image)
        Me.PnStatus1.Reaction = NPM23421668.PnStatus.ReactionState.NotSet
        Me.PnStatus1.Size = New System.Drawing.Size(428, 204)
        Me.PnStatus1.TabIndex = 10
        Me.PnStatus1.Tanggal = New Date(2025, 12, 10, 16, 6, 23, 778)
        Me.PnStatus1.TotalAngry = 0
        Me.PnStatus1.TotalComment = 0
        Me.PnStatus1.TotalHaha = 0
        Me.PnStatus1.TotalLike = 0
        Me.PnStatus1.TotalLove = 0
        Me.PnStatus1.TotalSad = 0
        Me.PnStatus1.TotalWow = 0
        '
        'FormComment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 633)
        Me.Controls.Add(Me.txtComment)
        Me.Controls.Add(Me.BtnSend)
        Me.Controls.Add(Me.pnComments)
        Me.Controls.Add(Me.PnStatus1)
        Me.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FormComment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormComment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PnStatus1 As PnStatus
    Friend WithEvents txtComment As TextBox
    Friend WithEvents BtnSend As Button
    Friend WithEvents pnComments As Panel
End Class
