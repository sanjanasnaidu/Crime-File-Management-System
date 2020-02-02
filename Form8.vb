Imports System.Data.SqlClient
Public Class Form8
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            cmd.CommandType = System.Data.CommandType.Text
            cmd.CommandText = "Insert Into COMPLAINT Values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & DateTimePicker1.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "','" & TextBox9.Text & "','" & TextBox10.Text & "')"
            cmd.Connection = con
            con.Open()
            cmd.ExecuteNonQuery()
            MsgBox("SUCCESSFULLY SAVED", MsgBoxStyle.Information, "ADD")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        con.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim FeetValue As Decimal = 0
        If Decimal.TryParse(TextBox1.Text, FeetValue) Then
            'Okay to use TextBox1.Text
        Else
            MessageBox.Show("Enter only numbers")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        DateTimePicker1.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
    End Sub
End Class