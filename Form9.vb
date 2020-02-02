Imports System.Data.SqlClient
Public Class Form9
    Dim con As New SqlConnection("Data Source=LAPTOP-QKB5KSRK;Initial Catalog=crime_file;Integrated Security=True")
    Dim cmd As New SqlCommand
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            cmd.CommandType = System.Data.CommandType.Text
            cmd.CommandText = "Insert Into POSTMORTEM Values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & DateTimePicker1.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "')"
            cmd.Connection = con
            con.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Successfully Saved", MsgBoxStyle.Information, "add")
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

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Dim FeetValue As Decimal = 0
        If Decimal.TryParse(TextBox2.Text, FeetValue) Then
            'Okay to use TextBox2.Text
        Else
            MessageBox.Show("Enter only numbers")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        DateTimePicker1.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
    End Sub

    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class