Public Class PnStatus

    Private CaptionBackColor_ As Color = Color.Transparent
    Public Property CaptionBackColor As Color
        Set(value As Color)
            CaptionBackColor_ = value
            lblCaption.BackColor = CaptionBackColor_

            If (CaptionBackColor_ = Color.Transparent) Then
                lblCaption.MaximumSize = New Size(380, 0)
                lblCaption.AutoSize = True
                lblCaption.Size = New Size(0, 0)
                lblCaption.Padding = New Padding(0)
                lblCaption.TextAlign = ContentAlignment.TopLeft
                lblCaption.ForeColor = Color.Black
                lblCaption.Font = New Font("Tahoma", 10, FontStyle.Regular)
            Else
                lblCaption.MaximumSize = New Size(0, 0)
                lblCaption.AutoSize = False
                lblCaption.Size = New Size(400, 200)
                lblCaption.Padding = New Padding(5)
                lblCaption.TextAlign = ContentAlignment.MiddleCenter
                lblCaption.ForeColor = Color.White
                lblCaption.Font = New Font("Tahoma", 14, FontStyle.Bold)
            End If

            Me.RefreshFooter()
        End Set
        Get
            Return CaptionBackColor_
        End Get
    End Property

    Private Caption_ As String = "..."
    Public Property Caption As String
        Set(value As String)
            Caption_ = value
            lblCaption.Text = Caption_

            Me.RefreshFooter()
        End Set
        Get
            Return Caption_
        End Get
    End Property

    Private Images_ As String() = {}
    Public Property Images As String()
        Set(value As String())
            Images_ = value

            Dim count As Integer
            count = Images_.Count

            Dim util As Util
            util = New Util()

            pnImage.Visible = False
            If (count > 0) Then
                pnImage.Visible = True

                If (count = 1) Then
                    Me.pnImage1.Visible = True
                    Me.pnImage2.Visible = False
                    Me.pnImage3.Visible = False

                    pbImage1.Image = util.LoadImageSafely(Images_(0))
                ElseIf (count = 2) Then
                    Me.pnImage1.Visible = True
                    Me.pnImage2.Visible = True
                    Me.pnImage3.Visible = False
                    Me.pnImage2.Size = New Size(pnImage.Width / 2, 0)

                    pbImage1.Image = util.LoadImageSafely(Images_(0))
                    pbImage2.Image = util.LoadImageSafely(Images_(1))

                ElseIf (count >= 3) Then
                    Me.pnImage1.Visible = True
                    Me.pnImage2.Visible = False
                    Me.pnImage3.Visible = True
                    Me.pnImage3.Size = New Size(pnImage.Width / 2, 0)

                    pbImage2.Image = util.LoadImageSafely(Images_(0))
                    pbImage31.Image = util.LoadImageSafely(Images_(1))
                    pbImage32.Image = util.LoadImageSafely(Images_(2))

                    If (count > 3) Then
                        lblCount.Visible = True
                        lblCount.Text = $"+{count - 3}"
                    End If
                End If
            End If
            Me.RefreshFooter()
        End Set
        Get
            Return Images_
        End Get
    End Property

    Private Nama_ As String = "Fabianwinata Sandar"
    Public Property Nama As String
        Set(value As String)
            Nama_ = value
            lblNama.Text = Nama_
        End Set
        Get
            Return Nama_
        End Get
    End Property

    Private Profile_ As Image = Global.NPM23421668.My.Resources.Resources.profile
    Public Property Profile As Image
        Set(value As Image)
            Profile_ = value
            pbProfile.Image = Profile_
        End Set
        Get
            Return Profile_
        End Get
    End Property

    Private TotalComment_ As Integer = 0
    Public Property TotalComment As Integer
        Set(value As Integer)
            TotalComment_ = value

            Dim text As String = ""
            If (TotalComment_ >= 1000000) Then
                text = $"{(TotalComment_ / 1000000).ToString("#,##0.#")}M"
            ElseIf (TotalComment_ > 1000) Then
                text = $"{(TotalComment_ / 1000).ToString("#,##0.#")}K"
            Else
                text = TotalComment_.ToString("#,##0.#")
            End If
            lblTotalComment.Text = $"{text} comments"
        End Set
        Get
            Return TotalComment_
        End Get
    End Property

    Private TotalReaction_ As Integer = 0
    Private Property TotalReaction As Integer
        Set(value As Integer)
            TotalReaction_ = value

            lblTotalReaction.Visible = False
            If (TotalReaction_ > 0) Then
                lblTotalReaction.Visible = True
            End If

            Dim text As String = ""
            If (TotalReaction_ >= 1000000) Then
                text = $"{(TotalReaction_ / 1000000).ToString("#,##0.#")}M"
            ElseIf (TotalReaction_ > 1000) Then
                text = $"{(TotalReaction_ / 1000).ToString("#,##0.#")}K"
            Else
                text = TotalReaction_.ToString("#,##0.#")
            End If
            lblTotalReaction.Text = text
        End Set
        Get
            Return TotalReaction_
        End Get
    End Property


    Private TotalLike_ As Integer = 0
    Public Property TotalLike As Integer
        Set(value As Integer)
            TotalLike_ = value

            Dim isvisible As Boolean
            If (TotalLike_ > 0) Then
                isvisible = True
            Else
                isvisible = False
            End If

            pbLike.Visible = isvisible
            CalculateReaction()
        End Set
        Get
            Return TotalLike_
        End Get
    End Property


    Private TotalLove_ As Integer = 0
    Public Property TotalLove As Integer
        Set(value As Integer)
            TotalLove_ = value

            Dim isvisible As Boolean
            If (TotalLove_ > 0) Then
                isvisible = True
            Else
                isvisible = False
            End If

            pbLove.Visible = isvisible
            CalculateReaction()
        End Set
        Get
            Return TotalLove_
        End Get
    End Property


    Private TotalHaha_ As Integer = 0
    Public Property TotalHaha As Integer
        Set(value As Integer)
            TotalHaha_ = value

            Dim isvisible As Boolean
            If (TotalHaha_ > 0) Then
                isvisible = True
            Else
                isvisible = False
            End If

            pbHaha.Visible = isvisible
            CalculateReaction()

        End Set
        Get
            Return TotalHaha_
        End Get
    End Property

    Private TotalWow_ As Integer = 0
    Public Property TotalWow As Integer
        Set(value As Integer)
            TotalWow_ = value

            Dim isvisible As Boolean
            If (TotalWow_ > 0) Then
                isvisible = True
            Else
                isvisible = False
            End If

            pbWow.Visible = isvisible
            CalculateReaction()

        End Set
        Get
            Return TotalWow_
        End Get
    End Property

    Private TotalSad_ As Integer = 0
    Public Property TotalSad As Integer
        Set(value As Integer)
            TotalSad_ = value

            Dim isvisible As Boolean
            If (TotalSad_ > 0) Then
                isvisible = True
            Else
                isvisible = False
            End If

            pbSad.Visible = isvisible
            CalculateReaction()

        End Set
        Get
            Return TotalSad_
        End Get
    End Property

    Private TotalAngry_ As Integer = 0
    Public Property TotalAngry As Integer
        Set(value As Integer)
            TotalAngry_ = value

            Dim isvisible As Boolean
            If (TotalAngry_ > 0) Then
                isvisible = True
            Else
                isvisible = False
            End If

            pbAngry.Visible = isvisible
            CalculateReaction()

        End Set
        Get
            Return TotalAngry_
        End Get
    End Property

    Private Sub CalculateReaction()
        TotalReaction = TotalLike + TotalLove + TotalHaha + TotalWow + TotalSad + TotalAngry
    End Sub

    Public Enum ReactionState
        Likee
        Love
        Haha
        Wow
        Sad
        Angry
        NotSet
    End Enum

    Private Reaction_ As ReactionState = ReactionState.NotSet
    Public Property Reaction As ReactionState
        Set(value As ReactionState)

            If (Reaction_ = ReactionState.Likee) Then
                TotalLike = TotalLike - 1
            ElseIf (Reaction_ = ReactionState.Love) Then
                TotalLove = TotalLove - 1
            ElseIf (Reaction_ = ReactionState.Wow) Then
                TotalWow = TotalWow - 1
            ElseIf (Reaction_ = ReactionState.Haha) Then
                TotalHaha = TotalHaha - 1
            ElseIf (Reaction_ = ReactionState.Sad) Then
                TotalSad = TotalSad - 1
            ElseIf (Reaction_ = ReactionState.Angry) Then
                TotalAngry = TotalAngry - 1
            End If

            Reaction_ = value

            Dim image As Image
            Dim text As String

            If (Reaction_ = ReactionState.Likee) Then
                image = pbLike.Image
                text = "Like"
                TotalLike = TotalLike + 1
            ElseIf (Reaction_ = ReactionState.Love) Then
                image = pbLove.Image
                text = "Love"
                TotalLove = TotalLove + 1
            ElseIf (Reaction_ = ReactionState.Wow) Then
                image = pbWow.Image
                text = "Wow"
                TotalWow = TotalWow + 1
            ElseIf (Reaction_ = ReactionState.Haha) Then
                image = pbHaha.Image
                text = "Haha"
                TotalHaha = TotalHaha + 1
            ElseIf (Reaction_ = ReactionState.Sad) Then
                image = pbSad.Image
                text = "Sad"
                TotalSad = TotalSad + 1
            ElseIf (Reaction_ = ReactionState.Angry) Then
                image = pbAngry.Image
                text = "Angry"
                TotalAngry = TotalAngry + 1
            Else
                image = Global.NPM23421668.My.Resources.Resources.Like1
                text = "Like"
            End If

            pbReaction.Image = image
            lblReaction.Text = text

        End Set
        Get
            Return Reaction_
        End Get
    End Property

    Private Sub ChangeReaction(reaction As ReactionState)
        Me.Reaction = reaction
        Me.pnReactions.Visible = False
    End Sub

    Private Sub pbReaction_Click(sender As Object, e As EventArgs) Handles pbReaction.Click, lblReaction.Click
        pnReactions.Visible = True
    End Sub

    Private Sub pbLike__Click(sender As Object, e As EventArgs) Handles pbLike_.Click
        Me.ChangeReaction(ReactionState.Likee)
    End Sub

    Private Sub pbLove__Click(sender As Object, e As EventArgs) Handles pbLove_.Click
        Me.ChangeReaction(ReactionState.Love)
    End Sub

    Private Sub pbHaha__Click(sender As Object, e As EventArgs) Handles pbHaha_.Click
        Me.ChangeReaction(ReactionState.Haha)
    End Sub

    Private Sub pbWow__Click(sender As Object, e As EventArgs) Handles pbWow_.Click
        Me.ChangeReaction(ReactionState.Wow)
    End Sub

    Private Sub pbSad__Click(sender As Object, e As EventArgs) Handles pbSad_.Click
        Me.ChangeReaction(ReactionState.Sad)
    End Sub

    Private Sub pbAngry__Click(sender As Object, e As EventArgs) Handles pbAngry_.Click
        Me.ChangeReaction(ReactionState.Angry)
    End Sub

    Private ID_Status_ As String = ""
    Public Property ID_Status As String
        Set(value As String)
            ID_Status_ = value

            Dim dt As DataTable
            Dim sql As SQL
            sql = New SQL()
            dt = sql.Execute($"SELECT *FROM TBL_STATUS WHERE ID_STATUS = '{ID_Status_}'")
            If (dt.Rows.Count > 0) Then
                Dim dr As DataRow
                dr = dt.DefaultView(0).Row

                Dim id_user, caption As String
                Dim r, g, b, totalimage As Integer
                Dim tanggal As DateTime
                Dim captionbackcolor As Color = Color.Transparent

                id_user = dr("ID_USER").ToString()
                caption = dr("CAPTION").ToString()
                tanggal = Convert.ToDateTime(dr("TANGGAL"))
                r = Convert.ToInt16(dr("R"))
                g = Convert.ToInt16(dr("G"))
                b = Convert.ToInt16(dr("B"))
                totalimage = Convert.ToInt16(dr("TOTALIMAGE"))

                If (r <> 0 Or g <> 0 Or b <> 0) Then
                    captionbackcolor = Color.FromArgb(r, g, b)
                End If

                Dim list As New List(Of String)
                Dim i As Integer
                For i = 1 To totalimage
                    list.Add($"{ID_Status_}_{i.ToString()}.png")
                Next


                Me.ID_User = id_user
                Me.Tanggal = tanggal
                Me.Caption = caption
                Me.CaptionBackColor = captionbackcolor
                Me.Images = list.ToArray()
            End If
        End Set
        Get
            Return ID_Status_
        End Get
    End Property

    Private ID_User_ As String = ""
    Public Property ID_User As String
        Set(value As String)
            ID_User_ = value

            Dim text As String
            text = $"SELECT TOP 1* FROM TBL_USER WHERE ID_USER = '{ID_User_}'"

            Dim dt As DataTable
            Dim sql As SQL
            sql = New SQL()
            dt = sql.Execute(text)
            If (dt.Rows.Count > 0) Then
                Dim dr As DataRow
                dr = dt.DefaultView(0).Row

                Dim util As Util
                util = New Util()
                Me.Profile = util.LoadImageSafely($"{ID_User_}.png")
                Me.Nama = dr("Username").ToString()
            End If
        End Set
        Get
            Return ID_User_
        End Get
    End Property

    Private Tanggal_ As DateTime = DateTime.Now()
    Public Property Tanggal As DateTime
        Set(value As DateTime)
            Tanggal_ = value

            Dim totalmenit As Integer
            totalmenit = (DateTime.Now() - Tanggal_).TotalMinutes

            Dim text As String = ""
            If (totalmenit >= 1440) Then
                text = $"{Convert.ToInt32(totalmenit / 1440)} hari yang lalu."
            ElseIf (totalmenit >= 60) Then
                text = $"{Convert.ToInt32(totalmenit / 60)} jam yang lalu."
            ElseIf (totalmenit >= 1) Then
                text = $"{totalmenit} menit yang lalu."
            Else
                text = $"Just Now"
            End If

            lblTanggal.Text = text
        End Set
        Get
            Return Tanggal_
        End Get
    End Property


    Private Login_ As String = ""
    Public Property Login As String
        Set(value As String)
            Login_ = value
        End Set
        Get
            Return Login_
        End Get
    End Property



    Private Sub RefreshFooter()
        pnImage.Location = New Point(10, lblCaption.Location.Y + lblCaption.Height + 10)

        If (Me.Images.Count > 0) Then
            pnFooter.Location = New Point(10, pnImage.Location.Y + pnImage.Height + 10)
        Else
            pnFooter.Location = New Point(10, lblCaption.Location.Y + lblCaption.Height + 10)
        End If
    End Sub

    Private Sub lblComment_Click(sender As Object, e As EventArgs) Handles lblComment.Click
        Dim frm As FormComment
        frm = New FormComment()
        frm.ID_Status = ID_Status
        frm.ID_User = Me.Login
        frm.ShowDialog()
    End Sub
End Class
