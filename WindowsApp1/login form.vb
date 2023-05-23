Imports MySql.Data.MySqlClient

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With Me
            Call Connecting_to_DB()
            Dim username = TextBox1.Text
            Dim password = TextBox2.Text

            strSQL = $"SELECT * FROM sampledb.users where username = '{username}' and password = '{password}' limit 1;"


            Dim cmd As New MySqlCommand
            cmd.Connection = myconn
            cmd.CommandText = strSQL

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.HasRows Then
                MessageBox.Show("Success Login", "Welcome")
                Form2.Show()
                Hide()

            Else
                MessageBox.Show("Invalid Email or Password", "Login Error")
            End If
            Call Disconnecting_to_DB()
        End With
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class

