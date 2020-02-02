Option Strict On
Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Public Class Form1
    Dim crimesysconnectionstring As Object
    Dim attempt As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conn As New SqlConnection
        Dim connstring = crimesysconnectionstring
        Dim command As New SqlCommand
        Dim rd As SqlDataReader

        command.Connection = conn
        conn.ConnectionString = "Data Source=LAPTOP-QKB5KSRK;Initial Catalog=crime_file;Integrated Security=True"
        conn.Open()
        command.CommandText = "select * from REGISTER2 where USERNAME='" & text1.Text & "' and PASSWORD='" & text2.Text & "'"
        rd = command.ExecuteReader
        If rd.HasRows Then
            MDIParent1.Show()
            Me.Close()
            MessageBox.Show("LOGIN SUCESSFULL")
        ElseIf attempt = 2 Then
            MsgBox("You have exceeded maximum number of attempts.....Program will now close")
            Close()
        Else
            MsgBox("Invalid USERNAME and PASSWORD,please re-enter,you have only 3 attempts.")
            attempt = attempt + 1
            text1.Text = ""
            text2.Text = ""
            text1.Focus()
        End If
        text1.Text = ""
        text2.Text = ""
        conn.Close()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub text1_Enter(sender As Object, e As EventArgs) Handles text1.Enter
        If text1.Text = "Enter the USERNAME" Then
            text1.Text = ""
            text1.ForeColor = Color.Black
        End If
    End Sub
    Private Sub text1_Leave(sender As Object, e As EventArgs) Handles text1.Leave
        If text1.Text = "" Then
            text1.Text = "Enter the USERNAME"
            text1.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class


