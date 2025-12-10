Public Class FormHome

    Private Rand As New Random()
    Private Sub lblPost_Click(sender As Object, e As EventArgs) Handles lblPost.Click
        Dim frm As FormCreate
        frm = New FormCreate()
        frm.ID_User = ID_User
        frm.Size = Me.Size
        If (frm.ShowDialog() = DialogResult.OK) Then
            Try
                Dim pn As PnStatus = frm.PnStatus1
                Dim id_status, caption As String
                Dim r, g, b, totalimage As Integer

                id_status = Rand.Next(0, 99999).ToString("00000")
                caption = frm.PnStatus1.Caption
                totalimage = frm.PnStatus1.Images.Count

                r = 0
                g = 0
                b = 0

                Dim captionbackcolor As Color = frm.PnStatus1.CaptionBackColor
                If (captionbackcolor <> Color.Transparent) Then
                    r = captionbackcolor.R
                    g = captionbackcolor.G
                    b = captionbackcolor.B
                End If

                Dim util As Util
                util = New Util()

                Dim i As Integer
                For i = 0 To pn.Images.Count - 1
                    Dim filename As String
                    filename = pn.Images(i)

                    Dim image As Image
                    image = Image.FromFile(filename)
                    util.SaveImageSafely(image, $"{id_status}_{i + 1}.png")
                Next

                Dim text As String
                text = $"INSERT INTO TBL_STATUS (ID_STATUS,ID_USER,CAPTION,R,G,B,TOTALIMAGE) " +
                       $"VALUES ('{id_status}','{ID_User}','{caption}',{r},{g},{b},{totalimage})"

                Dim dt As DataTable
                Dim sql As SQL
                sql = New SQL()
                dt = sql.Execute(text)

                If (dt Is Nothing) Then
                    Throw New Exception("Save gagal !")
                End If

                Me.RefreshStatus(False)
            Catch ex As Exception
                MessageBox.Show($"Update status gagal ! {ex.Message}")
            End Try

        End If
    End Sub

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
                pbProfile.Image = util.LoadImageSafely($"{ID_User_}.png")
                lblPost.Text = $"What's on your mind, {dr("Username").ToString()} ?"
            End If
        End Set
        Get
            Return ID_User_
        End Get
    End Property

    Private Sub RefreshStatus(isforced As Boolean)
        Me.IWait = 0
        Me.tWait.Stop()

        Dim text As String
        If (isforced) Then
            pnBody.Controls.Clear()
            text = $"SELECT *FROM TBL_STATUS ORDER BY TANGGAL ASC"
        Else
            text = $"SELECT *FROM TBL_STATUS WHERE (TANGGAL > '{Me.LastRead.ToString("yyyy/MM/dd HH:mm:ss:fff")}') ORDER BY TANGGAL ASC"
        End If

        Dim dt As DataTable
        Dim sql As SQL
        sql = New SQL()
        dt = sql.Execute(text)

        Dim i As Integer
        For i = 0 To dt.Rows.Count - 1
            Dim dr As DataRow
            dr = dt.DefaultView(i).Row

            Dim pn As PnStatus
            pn = New PnStatus()
            pn.Dock = DockStyle.Top
            pn.ID_Status = dr("ID_STATUS").ToString()
            pn.Login = Me.ID_User_
            pnBody.Controls.Add(pn)

            LastRead = pn.Tanggal
        Next

        Me.tWait.Start()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Me.RefreshStatus(True)
    End Sub

    Private Sub FormHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.RefreshStatus(True)
    End Sub


    Private IWait As Integer = 0

    Private LastRead As DateTime = DateTime.Now()

    Private Sub tWait_Tick(sender As Object, e As EventArgs) Handles tWait.Tick
        IWait = IWait + 1
        If (IWait >= 5) Then
            Me.RefreshStatus(False)
        End If
    End Sub

End Class