<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageUsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeveloperToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageEmployeesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LeaveOfAbsenceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewLeaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListOfApprovedLeavesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageDepartmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeesPosistionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ByPositionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ByDepartmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintAllEmployeesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnHistory = New System.Windows.Forms.Button()
        Me.Button_Staff = New System.Windows.Forms.Button()
        Me.btnApplication = New System.Windows.Forms.Button()
        Me.btnReg = New System.Windows.Forms.Button()
        Me.btnList = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ManageEmployeesToolStripMenuItem, Me.LeaveOfAbsenceToolStripMenuItem, Me.ManageDepartmentToolStripMenuItem, Me.EmployeesPosistionToolStripMenuItem, Me.SearchEmployeeToolStripMenuItem, Me.ReportsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1370, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManageUsersToolStripMenuItem, Me.LoginToolStripMenuItem, Me.DeveloperToolStripMenuItem})
        Me.FileToolStripMenuItem.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(61, 24)
        Me.FileToolStripMenuItem.Text = "Settings"
        '
        'ManageUsersToolStripMenuItem
        '
        Me.ManageUsersToolStripMenuItem.Name = "ManageUsersToolStripMenuItem"
        Me.ManageUsersToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.ManageUsersToolStripMenuItem.Text = "Manage Users"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'DeveloperToolStripMenuItem
        '
        Me.DeveloperToolStripMenuItem.Name = "DeveloperToolStripMenuItem"
        Me.DeveloperToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.DeveloperToolStripMenuItem.Text = "Developer"
        '
        'ManageEmployeesToolStripMenuItem
        '
        Me.ManageEmployeesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem, Me.ListToolStripMenuItem})
        Me.ManageEmployeesToolStripMenuItem.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManageEmployeesToolStripMenuItem.Name = "ManageEmployeesToolStripMenuItem"
        Me.ManageEmployeesToolStripMenuItem.Size = New System.Drawing.Size(57, 24)
        Me.ManageEmployeesToolStripMenuItem.Text = "Faculty"
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(163, 24)
        Me.AddToolStripMenuItem.Text = "Add New Faculty"
        '
        'ListToolStripMenuItem
        '
        Me.ListToolStripMenuItem.Name = "ListToolStripMenuItem"
        Me.ListToolStripMenuItem.Size = New System.Drawing.Size(163, 24)
        Me.ListToolStripMenuItem.Text = "List of All Faculty"
        '
        'LeaveOfAbsenceToolStripMenuItem
        '
        Me.LeaveOfAbsenceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewLeaveToolStripMenuItem, Me.ListOfApprovedLeavesToolStripMenuItem})
        Me.LeaveOfAbsenceToolStripMenuItem.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LeaveOfAbsenceToolStripMenuItem.Name = "LeaveOfAbsenceToolStripMenuItem"
        Me.LeaveOfAbsenceToolStripMenuItem.Size = New System.Drawing.Size(90, 24)
        Me.LeaveOfAbsenceToolStripMenuItem.Text = "Faculty Leave"
        '
        'AddNewLeaveToolStripMenuItem
        '
        Me.AddNewLeaveToolStripMenuItem.Name = "AddNewLeaveToolStripMenuItem"
        Me.AddNewLeaveToolStripMenuItem.Size = New System.Drawing.Size(198, 24)
        Me.AddNewLeaveToolStripMenuItem.Text = "Application Form"
        '
        'ListOfApprovedLeavesToolStripMenuItem
        '
        Me.ListOfApprovedLeavesToolStripMenuItem.Name = "ListOfApprovedLeavesToolStripMenuItem"
        Me.ListOfApprovedLeavesToolStripMenuItem.Size = New System.Drawing.Size(198, 24)
        Me.ListOfApprovedLeavesToolStripMenuItem.Text = "List of Approved Leaves"
        '
        'ManageDepartmentToolStripMenuItem
        '
        Me.ManageDepartmentToolStripMenuItem.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManageDepartmentToolStripMenuItem.Name = "ManageDepartmentToolStripMenuItem"
        Me.ManageDepartmentToolStripMenuItem.Size = New System.Drawing.Size(104, 24)
        Me.ManageDepartmentToolStripMenuItem.Text = "Subject Handled "
        '
        'EmployeesPosistionToolStripMenuItem
        '
        Me.EmployeesPosistionToolStripMenuItem.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeesPosistionToolStripMenuItem.Name = "EmployeesPosistionToolStripMenuItem"
        Me.EmployeesPosistionToolStripMenuItem.Size = New System.Drawing.Size(106, 24)
        Me.EmployeesPosistionToolStripMenuItem.Text = "Faculty Posistion"
        '
        'SearchEmployeeToolStripMenuItem
        '
        Me.SearchEmployeeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ByPositionToolStripMenuItem, Me.ByDepartmentToolStripMenuItem})
        Me.SearchEmployeeToolStripMenuItem.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchEmployeeToolStripMenuItem.Name = "SearchEmployeeToolStripMenuItem"
        Me.SearchEmployeeToolStripMenuItem.Size = New System.Drawing.Size(96, 24)
        Me.SearchEmployeeToolStripMenuItem.Text = "Search Faculty"
        '
        'ByPositionToolStripMenuItem
        '
        Me.ByPositionToolStripMenuItem.Name = "ByPositionToolStripMenuItem"
        Me.ByPositionToolStripMenuItem.Size = New System.Drawing.Size(175, 24)
        Me.ByPositionToolStripMenuItem.Text = "By Faculty Position"
        '
        'ByDepartmentToolStripMenuItem
        '
        Me.ByDepartmentToolStripMenuItem.Name = "ByDepartmentToolStripMenuItem"
        Me.ByDepartmentToolStripMenuItem.Size = New System.Drawing.Size(175, 24)
        Me.ByDepartmentToolStripMenuItem.Text = "By Subject Handled"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintAllEmployeesToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(99, 24)
        Me.ReportsToolStripMenuItem.Text = "Faculty Reports"
        '
        'PrintAllEmployeesToolStripMenuItem
        '
        Me.PrintAllEmployeesToolStripMenuItem.Name = "PrintAllEmployeesToolStripMenuItem"
        Me.PrintAllEmployeesToolStripMenuItem.Size = New System.Drawing.Size(141, 24)
        Me.PrintAllEmployeesToolStripMenuItem.Text = "Print Faculty"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnHistory)
        Me.Panel1.Controls.Add(Me.Button_Staff)
        Me.Panel1.Controls.Add(Me.btnApplication)
        Me.Panel1.Controls.Add(Me.btnReg)
        Me.Panel1.Controls.Add(Me.btnList)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1370, 189)
        Me.Panel1.TabIndex = 7
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 212)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1370, 537)
        Me.Panel2.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Perpetua Titling MT", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(0, 493)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(1700, 44)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "DEPARTMENT OF HOSPITALITY  MANAGEMENT AND INDUSTRIAL TECHNOLOGY       "
        '
        'Timer1
        '
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.MonitoringSystem.My.Resources.Resources.download__4_
        Me.PictureBox2.Location = New System.Drawing.Point(15, 17)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(129, 120)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.PictureBox1.Image = Global.MonitoringSystem.My.Resources.Resources.employees_management_software_760x530
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1370, 537)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnHistory
        '
        Me.btnHistory.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnHistory.FlatAppearance.BorderSize = 0
        Me.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHistory.ForeColor = System.Drawing.Color.Black
        Me.btnHistory.Image = Global.MonitoringSystem.My.Resources.Resources.accept__1_
        Me.btnHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHistory.Location = New System.Drawing.Point(288, 68)
        Me.btnHistory.Name = "btnHistory"
        Me.btnHistory.Size = New System.Drawing.Size(250, 42)
        Me.btnHistory.TabIndex = 4
        Me.btnHistory.Text = "Applied Leaves History"
        Me.btnHistory.UseVisualStyleBackColor = False
        '
        'Button_Staff
        '
        Me.Button_Staff.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button_Staff.FlatAppearance.BorderSize = 0
        Me.Button_Staff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Staff.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Staff.ForeColor = System.Drawing.Color.Black
        Me.Button_Staff.Image = Global.MonitoringSystem.My.Resources.Resources.folder_add
        Me.Button_Staff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_Staff.Location = New System.Drawing.Point(1097, 68)
        Me.Button_Staff.Name = "Button_Staff"
        Me.Button_Staff.Size = New System.Drawing.Size(250, 42)
        Me.Button_Staff.TabIndex = 6
        Me.Button_Staff.Text = "Faculty 2O1 Files"
        Me.Button_Staff.UseVisualStyleBackColor = False
        '
        'btnApplication
        '
        Me.btnApplication.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnApplication.FlatAppearance.BorderSize = 0
        Me.btnApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApplication.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApplication.ForeColor = System.Drawing.Color.Black
        Me.btnApplication.Image = Global.MonitoringSystem.My.Resources.Resources.Logout__1_
        Me.btnApplication.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnApplication.Location = New System.Drawing.Point(18, 68)
        Me.btnApplication.Name = "btnApplication"
        Me.btnApplication.Size = New System.Drawing.Size(250, 42)
        Me.btnApplication.TabIndex = 2
        Me.btnApplication.Text = "Leave Application"
        Me.btnApplication.UseVisualStyleBackColor = False
        '
        'btnReg
        '
        Me.btnReg.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnReg.FlatAppearance.BorderSize = 0
        Me.btnReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReg.ForeColor = System.Drawing.Color.Black
        Me.btnReg.Image = Global.MonitoringSystem.My.Resources.Resources.Add_User1
        Me.btnReg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReg.Location = New System.Drawing.Point(562, 68)
        Me.btnReg.Name = "btnReg"
        Me.btnReg.Size = New System.Drawing.Size(250, 42)
        Me.btnReg.TabIndex = 3
        Me.btnReg.Text = "Register New Faculty"
        Me.btnReg.UseVisualStyleBackColor = False
        '
        'btnList
        '
        Me.btnList.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnList.FlatAppearance.BorderSize = 0
        Me.btnList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnList.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnList.ForeColor = System.Drawing.Color.Black
        Me.btnList.Image = Global.MonitoringSystem.My.Resources.Resources.Category1
        Me.btnList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnList.Location = New System.Drawing.Point(831, 68)
        Me.btnList.Name = "btnList"
        Me.btnList.Size = New System.Drawing.Size(250, 42)
        Me.btnList.TabIndex = 5
        Me.btnList.Text = "List of Faculty"
        Me.btnList.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageUsersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageEmployeesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LeaveOfAbsenceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageDepartmentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmployeesPosistionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchEmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ByPositionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ByDepartmentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintAllEmployeesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddNewLeaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListOfApprovedLeavesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnApplication As Button
    Friend WithEvents btnReg As Button
    Friend WithEvents btnHistory As Button
    Friend WithEvents btnList As Button
    Friend WithEvents Button_Staff As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents DeveloperToolStripMenuItem As ToolStripMenuItem
End Class
