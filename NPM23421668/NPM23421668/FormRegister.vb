Imports System.IO

Public Class FormRegister

    Private Rand As New Random()
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

        Dim id_user, username, email, password, passwordulang As String
        id_user = Rand.Next(0, 99999).ToString("00000")
        username = txtUsername.Text.Trim()
        email = txtEmail.Text.Trim()
        password = txtPassword.Text.Trim()
        passwordulang = txtPasswordUlang.Text.Trim()


        If (username = "") Then
            txtUsername.Focus()
            Return
        ElseIf (email = "") Then
            txtEmail.Focus()
            Return
        ElseIf (password = "") Then
            txtPassword.Focus()
            Return
        ElseIf (passwordulang = "") Then
            txtPasswordUlang.Focus()
            Return
        ElseIf (password <> passwordulang) Then
            MessageBox.Show("Password (Ulang) tidak valid !!")
            txtPasswordUlang.Text = ""
            txtPasswordUlang.Focus()
            Return
        ElseIf (pbProfile.Image Is Nothing) Then
            MessageBox.Show("Gambar profile tidak boleh kosong !!")
            pbProfile_Click(Nothing, Nothing)
            Return
        End If

        Dim text As String
        text = $"INSERT INTO TBL_USER (ID_USER,USERNAME,EMAIL,PASSWORD,PASSWORDULANG ) " +
               $"VALUES ('{id_user}','{username}','{email}','{password}','{passwordulang}')"

        Dim sql As SQL
        sql = New SQL()
        sql.Execute(text)

        Dim util As Util
        util = New Util()
        util.SaveImageSafely(pbProfile.Image, $"{id_user}.png")

        MessageBox.Show("Register berhasil !")
        Me.Close()
    End Sub

    Private Sub pbProfile_Click(sender As Object, e As EventArgs) Handles pbProfile.Click

        Dim frm As OpenFileDialog
        frm = New OpenFileDialog()
        If (frm.ShowDialog() = DialogResult.OK) Then
            pbProfile.Image = Image.FromFile(frm.FileName)
        End If
    End Sub
End Class