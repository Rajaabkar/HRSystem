<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageUsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.PrintEmployeesDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintLeaveOfAbsenceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnApplication = New System.Windows.Forms.Button()
        Me.btnHistory = New System.Windows.Forms.Button()
        Me.btnList = New System.Windows.Forms.Button()
        Me.btnReg = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.RrrrrrrrToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ManageEmployeesToolStripMenuItem, Me.LeaveOfAbsenceToolStripMenuItem, Me.ManageDepartmentToolStripMenuItem, Me.EmployeesPosistionToolStripMenuItem, Me.SearchEmployeeToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.RrrrrrrrToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(9, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1477, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManageUsersToolStripMenuItem, Me.LoginToolStripMenuItem})
        Me.FileToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(47, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ManageUsersToolStripMenuItem
        '
        Me.ManageUsersToolStripMenuItem.Name = "ManageUsersToolStripMenuItem"
        Me.ManageUsersToolStripMenuItem.Size = New System.Drawing.Size(191, 26)
        Me.ManageUsersToolStripMenuItem.Text = "Manage Users"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(191, 26)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'ManageEmployeesToolStripMenuItem
        '
        Me.ManageEmployeesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem, Me.ListToolStripMenuItem})
        Me.ManageEmployeesToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ManageEmployeesToolStripMenuItem.Name = "ManageEmployeesToolStripMenuItem"
        Me.ManageEmployeesToolStripMenuItem.Size = New System.Drawing.Size(98, 24)
        Me.ManageEmployeesToolStripMenuItem.Text = "Employees"
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(121, 26)
        Me.AddToolStripMenuItem.Text = "Add"
        '
        'ListToolStripMenuItem
        '
        Me.ListToolStripMenuItem.Name = "ListToolStripMenuItem"
        Me.ListToolStripMenuItem.Size = New System.Drawing.Size(121, 26)
        Me.ListToolStripMenuItem.Text = "List"
        '
        'LeaveOfAbsenceToolStripMenuItem
        '
        Me.LeaveOfAbsenceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewLeaveToolStripMenuItem, Me.ListOfApprovedLeavesToolStripMenuItem})
        Me.LeaveOfAbsenceToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LeaveOfAbsenceToolStripMenuItem.Name = "LeaveOfAbsenceToolStripMenuItem"
        Me.LeaveOfAbsenceToolStripMenuItem.Size = New System.Drawing.Size(145, 24)
        Me.LeaveOfAbsenceToolStripMenuItem.Text = "Leave of Absence"
        '
        'AddNewLeaveToolStripMenuItem
        '
        Me.AddNewLeaveToolStripMenuItem.Name = "AddNewLeaveToolStripMenuItem"
        Me.AddNewLeaveToolStripMenuItem.Size = New System.Drawing.Size(260, 26)
        Me.AddNewLeaveToolStripMenuItem.Text = "Application Form"
        '
        'ListOfApprovedLeavesToolStripMenuItem
        '
        Me.ListOfApprovedLeavesToolStripMenuItem.Name = "ListOfApprovedLeavesToolStripMenuItem"
        Me.ListOfApprovedLeavesToolStripMenuItem.Size = New System.Drawing.Size(260, 26)
        Me.ListOfApprovedLeavesToolStripMenuItem.Text = "List of Approved Leaves"
        '
        'ManageDepartmentToolStripMenuItem
        '
        Me.ManageDepartmentToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ManageDepartmentToolStripMenuItem.Name = "ManageDepartmentToolStripMenuItem"
        Me.ManageDepartmentToolStripMenuItem.Size = New System.Drawing.Size(168, 24)
        Me.ManageDepartmentToolStripMenuItem.Text = "Manage Department"
        '
        'EmployeesPosistionToolStripMenuItem
        '
        Me.EmployeesPosistionToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.EmployeesPosistionToolStripMenuItem.Name = "EmployeesPosistionToolStripMenuItem"
        Me.EmployeesPosistionToolStripMenuItem.Size = New System.Drawing.Size(168, 24)
        Me.EmployeesPosistionToolStripMenuItem.Text = "Employee's Posistion"
        '
        'SearchEmployeeToolStripMenuItem
        '
        Me.SearchEmployeeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ByPositionToolStripMenuItem, Me.ByDepartmentToolStripMenuItem})
        Me.SearchEmployeeToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.SearchEmployeeToolStripMenuItem.Name = "SearchEmployeeToolStripMenuItem"
        Me.SearchEmployeeToolStripMenuItem.Size = New System.Drawing.Size(141, 24)
        Me.SearchEmployeeToolStripMenuItem.Text = "Search Employee"
        '
        'ByPositionToolStripMenuItem
        '
        Me.ByPositionToolStripMenuItem.Name = "ByPositionToolStripMenuItem"
        Me.ByPositionToolStripMenuItem.Size = New System.Drawing.Size(199, 26)
        Me.ByPositionToolStripMenuItem.Text = "By Position"
        '
        'ByDepartmentToolStripMenuItem
        '
        Me.ByDepartmentToolStripMenuItem.Name = "ByDepartmentToolStripMenuItem"
        Me.ByDepartmentToolStripMenuItem.Size = New System.Drawing.Size(199, 26)
        Me.ByDepartmentToolStripMenuItem.Text = "By Department"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintAllEmployeesToolStripMenuItem, Me.PrintEmployeesDetailsToolStripMenuItem, Me.PrintLeaveOfAbsenceToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(78, 24)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'PrintAllEmployeesToolStripMenuItem
        '
        Me.PrintAllEmployeesToolStripMenuItem.Name = "PrintAllEmployeesToolStripMenuItem"
        Me.PrintAllEmployeesToolStripMenuItem.Size = New System.Drawing.Size(259, 26)
        Me.PrintAllEmployeesToolStripMenuItem.Text = "Print All Employee's"
        '
        'PrintEmployeesDetailsToolStripMenuItem
        '
        Me.PrintEmployeesDetailsToolStripMenuItem.Name = "PrintEmployeesDetailsToolStripMenuItem"
        Me.PrintEmployeesDetailsToolStripMenuItem.Size = New System.Drawing.Size(259, 26)
        Me.PrintEmployeesDetailsToolStripMenuItem.Text = "Print Employee's Details"
        '
        'PrintLeaveOfAbsenceToolStripMenuItem
        '
        Me.PrintLeaveOfAbsenceToolStripMenuItem.Name = "PrintLeaveOfAbsenceToolStripMenuItem"
        Me.PrintLeaveOfAbsenceToolStripMenuItem.Size = New System.Drawing.Size(259, 26)
        Me.PrintLeaveOfAbsenceToolStripMenuItem.Text = "Print Leave of Absence"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = Global.MonitoringSystem.My.Resources.Resources.comex
        Me.Panel1.Controls.Add(Me.btnApplication)
        Me.Panel1.Controls.Add(Me.btnHistory)
        Me.Panel1.Controls.Add(Me.btnList)
        Me.Panel1.Controls.Add(Me.btnReg)
        Me.Panel1.Location = New System.Drawing.Point(673, 267)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(779, 342)
        Me.Panel1.TabIndex = 6
        '
        'btnApplication
        '
        Me.btnApplication.BackColor = System.Drawing.Color.SkyBlue
        Me.btnApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApplication.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApplication.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnApplication.Image = CType(resources.GetObject("btnApplication.Image"), System.Drawing.Image)
        Me.btnApplication.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnApplication.Location = New System.Drawing.Point(397, 172)
        Me.btnApplication.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.btnApplication.Name = "btnApplication"
        Me.btnApplication.Size = New System.Drawing.Size(380, 164)
        Me.btnApplication.TabIndex = 2
        Me.btnApplication.Text = "Leave Application"
        Me.btnApplication.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnApplication.UseVisualStyleBackColor = False
        '
        'btnHistory
        '
        Me.btnHistory.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHistory.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnHistory.Image = CType(resources.GetObject("btnHistory.Image"), System.Drawing.Image)
        Me.btnHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHistory.Location = New System.Drawing.Point(6, 172)
        Me.btnHistory.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.btnHistory.Name = "btnHistory"
        Me.btnHistory.Size = New System.Drawing.Size(387, 164)
        Me.btnHistory.TabIndex = 4
        Me.btnHistory.Text = "Applied Leaves History"
        Me.btnHistory.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnHistory.UseVisualStyleBackColor = False
        '
        'btnList
        '
        Me.btnList.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnList.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnList.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnList.Image = CType(resources.GetObject("btnList.Image"), System.Drawing.Image)
        Me.btnList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnList.Location = New System.Drawing.Point(399, 3)
        Me.btnList.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.btnList.Name = "btnList"
        Me.btnList.Size = New System.Drawing.Size(372, 164)
        Me.btnList.TabIndex = 5
        Me.btnList.Text = "List of Employee's"
        Me.btnList.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnList.UseVisualStyleBackColor = False
        '
        'btnReg
        '
        Me.btnReg.BackColor = System.Drawing.Color.SkyBlue
        Me.btnReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReg.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReg.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnReg.Image = CType(resources.GetObject("btnReg.Image"), System.Drawing.Image)
        Me.btnReg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReg.Location = New System.Drawing.Point(6, 4)
        Me.btnReg.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.btnReg.Name = "btnReg"
        Me.btnReg.Size = New System.Drawing.Size(389, 164)
        Me.btnReg.TabIndex = 3
        Me.btnReg.Text = "Register New Employee"
        Me.btnReg.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnReg.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(0, 28)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1477, 630)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Global.MonitoringSystem.My.Resources.Resources.comex
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(12, 31)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(202, 263)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'RrrrrrrrToolStripMenuItem
        '
        Me.RrrrrrrrToolStripMenuItem.Name = "RrrrrrrrToolStripMenuItem"
        Me.RrrrrrrrToolStripMenuItem.Size = New System.Drawing.Size(63, 24)
        Me.RrrrrrrrToolStripMenuItem.Text = "rrrrrrrr"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1477, 658)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        Me.TransparencyKey = System.Drawing.Color.Transparent
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PrintEmployeesDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintLeaveOfAbsenceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnApplication As Button
    Friend WithEvents btnReg As Button
    Friend WithEvents btnHistory As Button
    Friend WithEvents btnList As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents RrrrrrrrToolStripMenuItem As ToolStripMenuItem
End Class
