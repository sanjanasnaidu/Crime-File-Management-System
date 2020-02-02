Imports System.Data.SqlClient
Public Class Form12
    Dim conn As New SqlConnection("Data Source=LAPTOP-QKB5KSRK;Initial Catalog=crime_file;Integrated Security=True")
    Public Sub ExecuteQuery(query As String)

        Dim connection As New SqlConnection("Data Source=LAPTOP-QKB5KSRK;Initial Catalog=crime_file;Integrated Security=True")
        Dim command As New SqlCommand(query, connection)
        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        Dim conn As New SqlConnection("Data Source=LAPTOP-QKB5KSRK;Initial Catalog=crime_file;Integrated Security=True")
        con.Open()
        Dim query As String
        query = "delete from CRIMINAL where [CRIMINAL REPORT NUMBER]=" & ComboBox1.Text
        Dim cmd As SqlCommand = New SqlCommand(query, con)
        Dim i As Integer = cmd.ExecuteNonQuery()
        If (i > 0) Then
            MessageBox.Show("DATA DELETED")
        Else
            MessageBox.Show("DATA NOT FOUND")
        End If
        con.Close()
    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        Dim conn As New SqlConnection("Data Source=LAPTOP-QKB5KSRK;Initial Catalog=crime_file;Integrated Security=True")
        Dim cmd As New SqlCommand
        Dim str As String
        str = "update CRIMINAL set [DATE OF ARREST]='" & DateTimePicker1.Text & "',[NAME OF CRIMINAL]='" & TextBox2.Text & "',[ADDRESS OF CRIMINAL]='" & TextBox3.Text & "',[OFFENCE OF CRIMINAL]='" & TextBox4.Text & "',[DESCRIPTION OF CRIMINAL]='" & TextBox5.Text & "',[CONFESSION OF CRIMINAL]='" & TextBox6.Text & "',[ACTION AGAINST CRIMINAL]='" & TextBox7.Text & "' WHERE [CRIMINAL REPORT NUMBER]='" & ComboBox1.Text & "'"
        cmd = New SqlCommand(str, conn)
        Try
            conn.Open()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
        MsgBox("SUCCESSFULLY UPDATED")
        conn.Close()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Dim conn As New SqlConnection
        Dim mycommand As SqlCommand = New SqlCommand()
        Dim datareader As SqlDataReader = Nothing
        conn.ConnectionString = "Data Source=LAPTOP-QKB5KSRK;Initial Catalog=crime_file;Integrated Security=True"
        conn.Open()
        Dim query As String
        query = "select * from CRIMINAL where [CRIMINAL REPORT NUMBER]='" & ComboBox1.Text & "'"
        mycommand = New SqlCommand(query, conn)
        datareader = mycommand.ExecuteReader()
        If datareader.Read Then
            DateTimePicker1.Value = datareader.Item("DATE OF ARREST")
            TextBox2.Text = datareader.Item("NAME OF CRIMINAL")
            TextBox3.Text = datareader.Item("ADDRESS OF CRIMINAL")
            TextBox4.Text = datareader.Item("OFFENCE OF CRIMINAL")
            TextBox5.Text = datareader.Item("DESCRIPTION OF CRIMINAL")
            TextBox6.Text = datareader.Item("CONFESSION OF CRIMINAL")
            TextBox7.Text = datareader.Item("ACTION AGAINST CRIMINAL")
        Else
            MsgBox("DATA DOES NOT EXSIT")
        End If
        conn.Close()
    End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles Button7.Click
        ComboBox1.Text = ""
        DateTimePicker1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        MDIParent1.Show()
        Me.Close()

    End Sub

    Private Sub Form12_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Data Source=LAPTOP-QKB5KSRK;Initial Catalog=crime_file;Integrated Security=True"
        Dim adapter As New SqlDataAdapter("select * from CRIMINAL", conn)
        Dim table As New DataTable()
        adapter.Fill(table)
        ComboBox1.DataSource = table
        ComboBox1.ValueMember = "CRIMINAL REPORT NUMBER"
    End Sub
End Class