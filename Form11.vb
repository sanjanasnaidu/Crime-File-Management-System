Imports System.Data.SqlClient
Public Class Form11
    Dim con As New SqlConnection("Data Source=LAPTOP-QKB5KSRK;Initial Catalog=crime_file;Integrated Security=True")
    Dim cmd As New SqlCommand



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim m As New IO.MemoryStream
        Try
            cmd.CommandType = System.Data.CommandType.Text
            cmd.CommandText = "Insert Into CRIMINAL Values('" & TextBox1.Text & "','" & DateTimePicker1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "')"
            cmd.Connection = con
            con.Open()
            cmd.ExecuteNonQuery()
            MsgBox("SUCCESSFULLY SAVED", MsgBoxStyle.Information, "ADD")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        con.Close()
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim FeetValue As Decimal = 0
        If Decimal.TryParse(TextBox1.Text, FeetValue) Then
            'Okay to use TextBox1.Text
        Else
            MessageBox.Show("Enter only numbers")
        End If
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        DateTimePicker1.Text = ""
    End Sub
End Class