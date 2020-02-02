Imports System.Data.SqlClient
Public Class Form3
    Dim conn As New SqlConnection
    Dim mycommand As SqlCommand = New SqlCommand()
    Public Sub ExecuteQuery(query As String)

        Dim connection As New SqlConnection("Data Source=LAPTOP-QKB5KSRK;Initial Catalog=crime_file;Integrated Security=True")
        Dim command As New SqlCommand(query, connection)
        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)
        Dim FeetValue As Decimal = 0
        If Decimal.TryParse(TextBox2.Text, FeetValue) Then
            'Okay to use TextBox2.Text
        Else
            MessageBox.Show("Enter only numbers")
        End If
    End Sub
    Private Sub DateTimePicker1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        MDIParent1.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Dim conn As New SqlConnection("Data Source=LAPTOP-QKB5KSRK;Initial Catalog=crime_file;Integrated Security=True")
        con.Open()
        Dim query As String
        query = "delete from FIR where [FIRNUMBER]=" & ComboBox1.Text
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
        str = "update FIR set ACT='" & TextBox2.Text & "',DISTRICT='" & TextBox3.Text & "',[DATE OF REGISTRATION]='" & DateTimePicker2.Text & "',[NAME OF INFORMER]='" & TextBox4.Text & "',[ADDRESS OF INFORMER]='" & TextBox5.Text & "',[PLACE OF INCIDENT]='" & TextBox6.Text & "',[FIR DETAILS]='" & TextBox7.Text & "',[NAME OF CRIMINAL]='" & TextBox8.Text & "',[ADDRESS OF CRIMINAL]='" & TextBox9.Text & "'WHERE [FIRNUMBER]='" & ComboBox1.Text & "'"
        cmd = New SqlCommand(str, conn)
        Try
            conn.Open()
            cmd.ExecuteNonQuery()
            MsgBox("SUCCESSFULLY UPDATED")
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
        conn.Close()
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim datareader As SqlDataReader = Nothing
        conn.ConnectionString = "Data Source=LAPTOP-QKB5KSRK;Initial Catalog=crime_file;Integrated Security=True"
        conn.Open()
        Dim query As String
        query = "select ACT,DISTRICT,[DATE OF REGISTRATION],[NAME OF INFORMER],[ADDRESS OF INFORMER],[PLACE OF INCIDENT],[FIR DETAILS],[NAME OF CRIMINAL],[ADDRESS OF CRIMINAL] FROM FIR WHERE [FIRNUMBER]='" & ComboBox1.Text & "'"
        mycommand = New SqlCommand(query, conn)
        datareader = mycommand.ExecuteReader()
        If datareader.Read Then
            TextBox2.Text = datareader.Item("ACT")
            TextBox3.Text = datareader.Item("DISTRICT")
            DateTimePicker2.Value = datareader.Item("DATE OF REGISTRATION")
            TextBox4.Text = datareader.Item("NAME OF INFORMER")
            TextBox5.Text = datareader.Item("ADDRESS OF INFORMER")
            TextBox6.Text = datareader.Item("PLACE OF INCIDENT")
            TextBox7.Text = datareader.Item("FIR DETAILS")
            TextBox8.Text = datareader.Item("NAME OF CRIMINAL")
            TextBox9.Text = datareader.Item("ADDRESS OF CRIMINAL")
        Else
            MessageBox.Show("DATA DOES NOT EXIST")
        End If
        conn.Close()
    End Sub
    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        ComboBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        DateTimePicker2.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conn.ConnectionString = "Data Source=LAPTOP-QKB5KSRK;Initial Catalog=crime_file;Integrated Security=True"
        Dim adapter As New SqlDataAdapter("select * from FIR", conn)
        Dim table As New DataTable()
        adapter.Fill(table)
        ComboBox1.DataSource = table
        ComboBox1.ValueMember = "FIRNUMBER"
        ComboBox1.DisplayMember = "01"

    End Sub
End Class