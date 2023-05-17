Imports MySql.Data.MySqlClient

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With Me
            Call Connecting_to_DB()
            Dim mycmd As New MySqlCommand
            Dim myreader As MySqlDataReader


            strSQL = "Select * from users where username = '" _
                & .TextBox1.Text & "' and password = '" _
                & .TextBox2.Text & "'"
            'MsgBox(strSQL)
            mycmd.CommandText = strSQL
            mycmd.Connection = myconn

            myreader = mycmd.ExecuteReader
            If myreader.HasRows Then
                .Hide()
                Form2.Show()
            Else
                MessageBox.Show("Invalid username or password")
            End If
            Call Disconnecting_to_DB()
        End With
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox2.UseSystemPasswordChar = False
        Else
            TextBox2.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class

