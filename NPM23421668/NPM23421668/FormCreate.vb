Public Class FormCreate
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
            dt = sql.Execute(text)
            If (dt.Rows.Count > 0) Then
                Dim dr As DataRow
                dr = dt.DefaultView(0).Row

                Dim util As Util
                util = New Util()
                pbProfile.Image = util.LoadImageSafely($"{ID_User_}.png")
                lblNama.Text = dr("Username").ToString()
                PnStatus1.ID_User = ID_User_
            End If
        End Set
        Get
            Return ID_User_
        End Get
    End Property

    Private Sub btnPost_Click(sender As Object, e As EventArgs) Handles btnPost.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub txtCaption_TextChanged(sender As Object, e As EventArgs) Handles txtCaption.TextChanged
        PnStatus1.Caption = txtCaption.Text
    End Sub

    Private Sub pnColor1_Click(sender As Object, e As EventArgs) Handles pnColor1.Click
        PnStatus1.CaptionBackColor = Color.Transparent
    End Sub

    Private Sub pnColor_Click(sender As Object, e As EventArgs) Handles pnColor8.Click, pnColor7.Click, pnColor6.Click, pnColor5.Click, pnColor4.Click, pnColor3.Click, pnColor2.Click
        Dim pn As Panel
        pn = DirectCast(sender, Panel)
        PnStatus1.CaptionBackColor = pn.BackColor
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click

        Dim frm As OpenFileDialog
        frm = New OpenFileDialog()
        frm.Multiselect = True

        If (frm.ShowDialog() = DialogResult.OK) Then
            PnStatus1.Images = frm.FileNames
        End If

    End Sub
End Class