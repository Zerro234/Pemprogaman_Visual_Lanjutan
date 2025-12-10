Imports System.IO

Public Class Util
    Private FolderServer As String = "C:\Users\frans\OneDrive\Desktop\Juni\Visual Lanjutan\NPM23421668\P Profile\"

    Function SaveImageSafely(image As Image, filename As String) As Boolean
        Try

            Dim fullpath As String = Path.Combine(FolderServer, filename)

            Using fs As New FileStream(fullpath, FileMode.CreateNew, FileAccess.Write, FileShare.None)
                image.Save(fs, System.Drawing.Imaging.ImageFormat.Png)
            End Using
            Return True
        Catch ex As IOException
            MessageBox.Show($"Save image gagal ! {ex.Message}")
            Return False
        End Try
    End Function
    Function LoadImageSafely(filename As String) As Image
        Try

            Dim fullpath As String = Path.Combine(FolderServer, filename)

            Using fs As New FileStream(fullpath, FileMode.Open, FileAccess.Read, FileShare.Read)

                Dim ms As New MemoryStream()
                fs.CopyTo(ms)
                ms.Position = 0
                Dim img As Image = Image.FromStream(ms)
                Return img
            End Using
        Catch ex As IOException

            Return Nothing
        End Try
    End Function

End Class
