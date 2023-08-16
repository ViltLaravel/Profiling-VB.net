Imports MySql.Data.MySqlClient
Public Class Dashboard
    Public con As MySqlConnection = mysqldb()
    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        With Form1
            .Show()
            .Focus()

        End With
    End Sub

    Private Sub PDSToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PDSToolStripMenuItem1.Click
        Switch(PDS)

    End Sub

    Sub Switch(ByVal panel As Form)
        Panel1.Controls.Clear()
        panel.TopLevel = False
        Panel1.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub PDFToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PDFToolStripMenuItem1.Click
        Switch(PDF_1)
    End Sub

    Private Sub APPOINTMENTToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles APPOINTMENTToolStripMenuItem1.Click
        Switch(Appointment)
    End Sub

    Private Sub TORToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TORToolStripMenuItem1.Click
        Switch(TOR)
    End Sub

    Private Sub ILIGIBILITYToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ILIGIBILITYToolStripMenuItem1.Click
        Switch(Eligibility)
    End Sub

    Private Sub SERVICERECORDSToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SERVICERECORDSToolStripMenuItem1.Click
        Switch(Service_Records)
    End Sub

    Private Sub DESIGNATIONToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DESIGNATIONToolStripMenuItem1.Click
        Switch(Designation)
    End Sub

    Private Sub SUBJECTLOADINGToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SUBJECTLOADINGToolStripMenuItem1.Click
        Switch(Subject_Loading)
    End Sub

    Private Sub TRAININGSEMINARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TRAININGSEMINARToolStripMenuItem.Click
        Switch(Trainings__Seminar)
    End Sub

    Private Sub CERTIFICATESToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CERTIFICATESToolStripMenuItem1.Click
        Switch(Certificates)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class