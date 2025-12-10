Public Class FormComment

    Private ID_User_ As String = ""
    Public Property ID_User As String
        Set(value As String)
            ID_User_ = value
        End Set
        Get
            Return ID_User_
        End Get
    End Property

    Private ID_Status_ As String = ""
    Public Property ID_Status As String
        Set(value As String)
            ID_Status_ = value
            PnStatus1.ID_Status = ID_Status_

            Me.RefreshComment()
        End Set
        Get
            Return ID_Status_
        End Get
    End Property

    Dim rand As New Random()
    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles BtnSend.Click
        Dim sql As SQL
        sql = New SQL()

        Dim id_comment As String
        id_comment = rand.Next(0, 99999).ToString("00000")

        Dim caption As String
        caption = txtComment.Text.Trim()

        Dim text As String
        text = $"INSERT INTO TBL_COMMENT (ID_COMMENT, ID_STATUS, ID_USER, CAPTION) " +
              $"VALUES ('{id_comment}','{ID_Status}', '{ID_User}', '{caption}')"

        sql.Execute(text)

        RefreshComment()
    End Sub

    Private Sub RefreshComment()

        Dim sql As SQL
        Dim dt As DataTable

        sql = New SQL()

        Dim text As String
        text = $"SELECT * FROM TBL_COMMENT WHERE ID_STATUS = '{PnStatus1.ID_Status}'"

        dt = sql.Execute(text)

        pnComments.Controls.Clear()
        Dim i As Integer
        For i = 0 To dt.Rows.Count - 1
            Dim dr As DataRow
            dr = dt.DefaultView(i).Row

            Dim pn As PnComment
            pn = New PnComment()
            pn.ID_Comment = dr("ID_Comment").ToString()
            pn.Dock = DockStyle.Top

            pnComments.Controls.Add(pn)
        Next
    End Sub
End Class