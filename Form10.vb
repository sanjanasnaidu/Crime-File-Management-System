Imports System.Data.SqlClient
Public Class Form10
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form4.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            cmd.CommandType = System.Data.CommandType.Text
            cmd.CommandText = "Insert Into REGISTER2 Values('" & TextBox1.Text & "','" & TextBox3.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "')"
            cmd.Connection = con
            con.Open()
            cmd.ExecuteNonQuery()
            MsgBox("REGISTERED SAVED", MsgBoxStyle.Information, "ADD")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        con.Close()
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)
        Dim FeetValue As Decimal = 0
        If Decimal.TryParse(TextBox1.Text, FeetValue) Then
            'Okay to use TextBox1.Text
        Else
            MessageBox.Show("Enter only numbers")
        End If
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs)
        Dim FeetValue As Decimal = 0
        If Decimal.TryParse(TextBox6.Text, FeetValue) Then
            'Okay to use TextBox6.Text
        Else
            MessageBox.Show("Enter only numbers")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Close()

    End Sub
End Class