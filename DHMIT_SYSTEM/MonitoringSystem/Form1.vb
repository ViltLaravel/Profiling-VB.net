Public Class Form1




    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        If LoginToolStripMenuItem.Text = "Login" Then
            With LoginForm1
                .Show()
                .Focus()
            End With
        Else
            ManageEmployeesToolStripMenuItem.Enabled = False
            LeaveOfAbsenceToolStripMenuItem.Enabled = False
            ManageDepartmentToolStripMenuItem.Enabled = False
            EmployeesPosistionToolStripMenuItem.Enabled = False
            ReportsToolStripMenuItem.Enabled = False
            ManageUsersToolStripMenuItem.Enabled = False
            SearchEmployeeToolStripMenuItem.Enabled = False
            btnApplication.Enabled = False
            btnHistory.Enabled = False
            btnList.Enabled = False
            btnReg.Enabled = False
            Button_Staff.Enabled = False
            LoginToolStripMenuItem.Text = "Login"
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ManageEmployeesToolStripMenuItem.Enabled = False
        LeaveOfAbsenceToolStripMenuItem.Enabled = False
        ManageDepartmentToolStripMenuItem.Enabled = False
        EmployeesPosistionToolStripMenuItem.Enabled = False
        ReportsToolStripMenuItem.Enabled = False
        ManageUsersToolStripMenuItem.Enabled = False
        SearchEmployeeToolStripMenuItem.Enabled = False
        btnApplication.Enabled = False
        btnHistory.Enabled = False
        btnList.Enabled = False
        btnReg.Enabled = False
        Button_Staff.Enabled = False
        LoginToolStripMenuItem.Text = "Login"
        Timer1.Enabled = True
    End Sub

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        With frmemployee
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub ListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListToolStripMenuItem.Click
        With frmlistemployee
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub AddNewLeaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewLeaveToolStripMenuItem.Click
        With frmleave
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub ListOfApprovedLeavesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListOfApprovedLeavesToolStripMenuItem.Click
        With frmLeaveAbsence
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub ManageDepartmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageDepartmentToolStripMenuItem.Click
        With frmdepartment
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub EmployeesPosistionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeesPosistionToolStripMenuItem.Click
        With frmsettings
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub PrintLeaveOfAbsenceToolStripMenuItem_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub PrintAllEmployeesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintAllEmployeesToolStripMenuItem.Click
        With Form2
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub PrintEmployeesDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs)
        With frmSearch
            .ShowDialog()
        End With
    End Sub

    Private Sub ByPositionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ByPositionToolStripMenuItem.Click

        With frmSearchList
            .ShowDialog()
        End With
    End Sub

    Private Sub ByDepartmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ByDepartmentToolStripMenuItem.Click

        With frmEmpDepartment
            .ShowDialog()
        End With
    End Sub

    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ManageUsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageUsersToolStripMenuItem.Click
        With New manageuser
            .ShowDialog()
        End With
    End Sub

    Private Sub btnApplication_Click(sender As Object, e As EventArgs) Handles btnApplication.Click
        With frmleave
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub btnReg_Click(sender As Object, e As EventArgs) Handles btnReg.Click
        With New frmemployee
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub btnList_Click(sender As Object, e As EventArgs) Handles btnList.Click
        With frmlistemployee
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        With frmLeaveAbsence
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub Button_Staff_Click(sender As Object, e As EventArgs) Handles Button_Staff.Click
        With Dashboard
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Label4.Location.Y + Label4.Width < 0 Then
            Label4.Location = New Point(Me.Width, Label4.Location.Y)
        Else
            Label4.Location = New Point(Label4.Location.X - 1, Label4.Location.Y)
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub ReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportsToolStripMenuItem.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub DeveloperToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeveloperToolStripMenuItem.Click
        developer.Show()

    End Sub
End Class
