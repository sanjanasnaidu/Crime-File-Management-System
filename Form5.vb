Public Class Form5

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim opf As New OpenFileDialog

        opf.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif"

        If opf.ShowDialog = DialogResult.OK Then

            PictureBox2.Image = Image.FromFile(opf.FileName)

        End If
    End Sub

        Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
            Dim opf As New OpenFileDialog

            opf.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif"

            If opf.ShowDialog = DialogResult.OK Then

            PictureBox3.Image = Image.FromFile(opf.FileName)

            End If
        End Sub

        Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim a As Boolean = AreSameImage(PictureBox2.Image, PictureBox3.Image)
        If a Then
            MsgBox("IDENTICAL")
        Else
            MsgBox("NOT IDENTICAL")
        End If

    End Sub
    Public Function AreSameImage(ByVal I1 As Image, ByVal I2 As Image) As Boolean
        Dim BM1 As Bitmap = I1
        Dim BM2 As Bitmap = I2
        For x = 0 To BM1.Width - 1
            For y = 0 To BM2.Height - 1
                If BM1.GetPixel(x, y) <> BM2.GetPixel(x, y) Then
                    Return False
                End If
            Next
        Next
        Return True
    End Function
        Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
            Me.Close()
        End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub
End Class