Imports System.Data.SqlClient
Public Class Form7
    Dim conn As New SqlConnection("Data Source=LAPTOP-QKB5KSRK;Initial Catalog=crime_file;Integrated Security=True")

    Public Sub ExecuteQuery(query As String)
        Dim connection As New SqlConnection("Data Source=LAPTOP-QKB5KSRK;Initial Catalog=crime_file;Integrated Security=True")
        Dim command As New SqlCommand(query, connection)
        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conn As New SqlConnection
        Dim mycommand As SqlCommand = New SqlCommand()
        Dim datareader As SqlDataReader = Nothing
        conn.ConnectionString = "Data Source=LAPTOP-QKB5KSRK;Initial Catalog=crime_file;Integrated Security=True"
        conn.Open()
        Dim query As String
        query = "select DISTRICT,[DATE OF REGISTRATION],[NAME OF COMPLAINANT],[ADDRESS OF COMPLAINANT],[PLACE OF INCIDENT],[CASE DETAILS],[NAME OF CRIMINAL],[ADDRESS OF CRIMINAL],[NAME OF WITNESS],[ADDRESS OF WITNESS] FROM COMPLAINT WHERE [CASENUMBER]='" & ComboBox1.Text & "'"
        mycommand = New SqlCommand(query, conn)
        datareader = mycommand.ExecuteReader()
        If datareader.Read Then
            TextBox2.Text = datareader.Item("DISTRICT")
            DateTimePicker1.Value = datareader.Item("DATE OF REGISTRATION")
            TextBox3.Text = datareader.Item("NAME OF COMPLAINANT")
            TextBox4.Text = datareader.Item("ADDRESS OF COMPLAINANT")
            TextBox5.Text = datareader.Item("PLACE OF INCIDENT")
            TextBox6.Text = datareader.Item("CASE DETAILS")
            TextBox7.Text = datareader.Item("NAME OF CRIMINAL")
            TextBox8.Text = datareader.Item("ADDRESS OF CRIMINAL")
            TextBox9.Text = datareader.Item("NAME OF WITNESS")
            TextBox10.Text = datareader.Item("ADDRESS OF WITNESS")
        Else
            MessageBox.Show("DATA DOES NOT EXIST")
        End If
        conn.Close()
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Dim conn As New SqlConnection("Data Source=LAPTOP-QKB5KSRK;Initial Catalog=crime_file;Integrated Security=True")
        con.Open()
        Dim query As String
        query = "delete from COMPLAINT where [CASENUMBER]=" & ComboBox1.Text
        Dim cmd As SqlCommand = New SqlCommand(query, con)
        Dim i As Integer = cmd.ExecuteNonQuery()
        If (i > 0) Then
            MessageBox.Show("DATA DELETED")
        Else
            MessageBox.Show("DATA NOT FOUND")
        End If
        con.Close()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Dim str As String
        str = "update COMPLAINT set DISTRICT='" & TextBox2.Text & "',[DATE OF REGISTRATION]='" & DateTimePicker1.Text & "',[NAME OF COMPLAINANT]='" & TextBox3.Text & "',[ADDRESS OF COMPLAINANT]='" & TextBox4.Text & "',[PLACE OF INCIDENT]='" & TextBox5.Text & "',[CASE DETAILS]='" & TextBox6.Text & "',[NAME OF CRIMINAL]='" & TextBox7.Text & "',[ADDRESS OF CRIMINAL]='" & TextBox8.Text & "',[NAME OF WITNESS]='" & TextBox9.Text & "',[ADDRESS OF WITNESS]='" & TextBox10.Text & "' FROM COMPLAINT WHERE [CASENUMBER]='" & ComboBox1.Text & "'"
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

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        ComboBox1.Text = ""
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MDIParent1.Show()
        Me.Close()


    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Data Source=LAPTOP-QKB5KSRK;Initial Catalog=crime_file;Integrated Security=True"
        Dim adapter As New SqlDataAdapter("select * from COMPLAINT", conn)
        Dim table As New DataTable()
        adapter.Fill(table)
        ComboBox1.DataSource = table
        ComboBox1.ValueMember = "CASENUMBER"
    End Sub
End Class