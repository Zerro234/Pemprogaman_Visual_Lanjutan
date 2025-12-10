Public Class PnComment

    Private ID_Comment_ As String = ""
    Public Property ID_Comment As String
        Set(value As String)
            ID_Comment_ = value

            Dim sql As SQL
            sql = New SQL()

            Dim dt As DataTable
            dt = sql.Execute($"SELECT *FROM TBL_COMMENT WHERE ID_COMMENT = '{ID_Comment_}'")

            If (dt.Rows.Count > 0) Then
                Dim dr As DataRow
                dr = dt.DefaultView(0).Row
                'Me.ID_Status = dr("ID_STATUS").ToString()
                Me.ID_User = dr("ID_USER").ToString()
                Me.Caption = dr("CAPTION").ToString()
            End If
        End Set
        Get
            Return ID_Comment_
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
                pbProfile.Image = util.LoadImageSafely($"{ID_User_}.png")
                lblNama.Text = dr("Username").ToString()
            End If
        End Set
        Get
            Return ID_User_
        End Get
    End Property


    Private Caption_ As String = "..."
    Public Property Caption As String
        Set(value As String)
            Caption_ = value
            lblCaption.Text = Caption_
        End Set
        Get
            Return Caption_
        End Get
    End Property
End Class