Imports MySql.Data.MySqlClient
Public Class Form2
    Public con As MySqlConnection = mysqldb()



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dt.Clear()
        con = New MySqlConnection("server=localhost;user id=root;password=;database=leavedb")
        Dim reports As New Myreport
        viewdata()
        reports.Database.Tables("employee").SetDataSource(dt)
        CrystalReportViewer1.ReportSource = Nothing
        CrystalReportViewer1.ReportSource = reports

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        dt.Clear()
        con = New MySqlConnection("server=localhost;user id=root;password=;database=leavedb")
        Dim report As New leave
        views()
        report.Database.Tables("leave").SetDataSource(dt)
        CrystalReportViewer1.ReportSource = Nothing
        CrystalReportViewer1.ReportSource = report
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        dt.Clear()
        con = New MySqlConnection("server=localhost;user id=root;password=;database=leavedb")
        Dim reportz As New CrystalReport1
        view()
        reportz.Database.Tables("leave").SetDataSource(dt)
        CrystalReportViewer1.ReportSource = Nothing
        CrystalReportViewer1.ReportSource = reportz
    End Sub
End Class