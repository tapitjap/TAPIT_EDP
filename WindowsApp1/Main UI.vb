Imports MySql.Data.MySqlClient

Public Class Form2
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Hide()
        Form3.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Hide()
        Products.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Hide()
        Orders.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Hide()
        Customers.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Hide()
        Offices.Show()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Hide()
        Form4.Show()
    End Sub

    Private Sub BackupButton_Click(sender As Object, e As EventArgs) Handles BackupButton.Click
        Dim backup As New SaveFileDialog
        backup.InitialDirectory = "C:\"
        backup.Title = "Database Backup"
        backup.CheckFileExists = False
        backup.CheckPathExists = False
        backup.DefaultExt = "sql"
        backup.Filter = "sql files (.sql)|.sql|All files (.)|*.*"
        backup.RestoreDirectory = True

        If backup.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim myconn As MySqlConnection = New MySqlConnection("Server=localhost;uid=root;pwd=admin;database=sampledb")
            Dim cmd As MySqlCommand = New MySqlCommand
            cmd.Connection = myconn
            myconn.Open()
            Dim mb As MySqlBackup = New MySqlBackup(cmd)
            mb.ExportToFile(backup.FileName)
            myconn.Close()
            MessageBox.Show("Database Successfully Backup!", "BACKUP", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf backup.ShowDialog = Windows.Forms.DialogResult.Cancel Then
            Return
        End If
    End Sub
End Class