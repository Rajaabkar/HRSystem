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
        LoginToolStripMenuItem.Text = "Login"
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

    Private Sub PrintLeaveOfAbsenceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintLeaveOfAbsenceToolStripMenuItem.Click
        With frmreports
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub PrintAllEmployeesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintAllEmployeesToolStripMenuItem.Click
        frmPrints.Show()
        frmPrints.Focus()
        sql = "SELECT  e.`EMPID`, concat( `emp_fname`,' ', `emp_lname`,' ', `emp_mname`) as 'Name' ,`emp_sex`,(`d_rate` * 14) as 'TwooWeeksSalary', `position`, `DEPARTMENT` FROM `employee` e ,`employee_workinfo` we  WHERE e.`EMPID`=we.`EMPID`"
        Reports(sql, "allemployees", frmPrints.CrystalReportViewer1)
    End Sub

    Private Sub PrintEmployeesDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintEmployeesDetailsToolStripMenuItem.Click
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
        With New Manageuser
            .ShowDialog()
        End With
    End Sub

    Private Sub BtnApplication_Click(sender As Object, e As EventArgs) Handles btnApplication.Click
        With frmleave
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub BtnReg_Click(sender As Object, e As EventArgs) Handles btnReg.Click
        With New frmemployee
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub BtnList_Click(sender As Object, e As EventArgs) Handles btnList.Click
        With frmlistemployee
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub BtnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        With FrmLeaveAbsence
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Attend_form.ShowDialog()
    End Sub

    Private Sub RrrrrrrrToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RrrrrrrrToolStripMenuItem.Click
        Attend_form.ShowDialog()
    End Sub
End Class
