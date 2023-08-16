Imports MySql.Data.MySqlClient
'CONNECTOR MUST ADD TO REFERENCE

Public Class Certificates

    'CONNECCTION MUST INITIALIZE
    Public con As MySqlConnection = mysqldb()

    'ALL FUNCTION NEEDED
    'TO LOAD ALL THE DATA FROM DATABASE
    Public Sub Dashboard()

        Try
            con.Open()
            sql = "SELECT * FROM tblcertificates"
            cmd = New MySqlCommand
            With cmd
                .Connection = con
                .CommandText = sql
            End With
            da = New MySqlDataAdapter
            dt = New DataTable
            da.SelectCommand = cmd
            da.Fill(dt)

            DataGridView1.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            da.Dispose()
            con.Close()
        End Try
    End Sub

    'TO VIEW ALL DATA FROM DATABASE TO THE GRID
    Public Sub view()
        Try
            con.Open()
            sql = "SELECT * FROM tblcertificates WHERE File_ID=" & DataGridView1.CurrentRow.Cells(0).Value
            cmd = New MySqlCommand
            With cmd
                .Connection = con
                .CommandText = sql
            End With
            da = New MySqlDataAdapter
            dt = New DataTable
            da.SelectCommand = cmd
            da.Fill(dt)

            With pdf
                .Show()
                .Focus()
                .AxAcroPDF1.src = Application.StartupPath & "\PDF_Files\" & dt.Rows(0).Item("FileName")
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            da.Dispose()
            con.Close()
        End Try

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            OpenFileDialog1.Filter = "PDF | *.pdf"
            If OpenFileDialog1.ShowDialog = DialogResult.OK Then
                TextBox1.Text = OpenFileDialog1.FileName
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Certificates_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dashboard()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            ProgressBar1.Value += 1
            If ProgressBar1.Value = 100 Then
                Timer1.Stop()

                con.Open()
                sql = "INSERT INTO `tblcertificates` (`FileName`) VALUES ('" & System.IO.Path.GetFileName(TextBox1.Text) & "')"

                cmd = New MySqlCommand
                With cmd
                    .Connection = con
                    .CommandText = sql
                    .ExecuteNonQuery()
                End With

                If TextBox1.Text <> "" Then
                    System.IO.File.Copy(TextBox1.Text, Application.StartupPath & "\PDF_Files\" & System.IO.Path.GetFileName(TextBox1.Text), True)
                End If
                MsgBox("Scanned file uploaded successfully.")


                TextBox1.Clear()
                ProgressBar1.Value = 0
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
        'call to retrieve file
        Call Certificates_Load(sender, e)
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        sql = "SELECT `File_ID` AS 'File Id',`FileName` AS 'filename' FROM `tblcertificates` WHERE `File_ID` LIKE '%" & TextBox2.Text & "%'" _
& " OR FileName LIKE '%" & TextBox2.Text & "%'"
        reloadDtg(sql, DataGridView1)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        sql = "DELETE FROM tblcertificates WHERE File_ID = '" & DataGridView1.CurrentRow.Cells(0).Value & "'"
        deletes(sql, DataGridView1.CurrentRow.Cells(1).Value)

        sql = "SELECT `File_ID` AS 'File Id', `FileName` AS 'File Name' FROM `tblcertificates`"
        reloadDtg(sql, DataGridView1)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        view()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Start()
    End Sub
End Class