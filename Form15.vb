

Public Class Form15
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles cmdexit.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox2.Text = Encrypt(TextBox1.Text, Len(TextBox1.Text))
    End Sub

    Public Function Encrypt(Name As String, Key As Long) As String
        Dim v As Long, c1 As String, z As String
        For v = 1 To Len(Name)
            c1 = Asc(Mid(Name, v, 1))
            c1 = Chr(c1 + Key)
            z = z & c1
        Next v
        Encrypt = z
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox2.Text = Decrypt(TextBox2.Text, Len(TextBox1.Text))
        TextBox1.Text = ""
    End Sub

    Public Function Decrypt(Name As String, Key As Long) As String
        Dim v As Long, c1 As String, z As String
        For v = 1 To Len(Name)
            c1 = Asc(Mid(Name, v, 1))
            c1 = Chr(c1 - Key)
            z = z & c1
        Next v
        Decrypt = z
    End Function

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub
End Class