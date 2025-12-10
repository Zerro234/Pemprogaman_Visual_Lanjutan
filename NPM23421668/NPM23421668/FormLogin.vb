Public Class FormLogin
    Private Sub lblRegister_Click(sender As Object, e As EventArgs) Handles lblRegister.Click
        Dim frm As FormRegister
        frm = New FormRegister()
        frm.ShowDialog()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim email, password As String
        email = txtEmail.Text.Trim()
        password = txtPassword.Text.Trim()

        Dim text As String
        text = $"Select * From TBL_USER where EMAIL = '{email}' and PASSWORD = '{password}'"

        Dim dt As DataTable

        Dim sql As SQL
        sql = New SQL()
        dt = sql.Execute(text)

        If (dt.Rows.Count = 0) Then
            MessageBox.Show("Login Gagal!!!")
        Else
            Dim id_user As String
            id_user = dt.Rows(0).Item("ID_User").ToString()
            Dim frm As FormHome
            frm = New FormHome()
            frm.ID_User = id_user
            frm.ShowDialog()
        End If


    End Sub
End Class