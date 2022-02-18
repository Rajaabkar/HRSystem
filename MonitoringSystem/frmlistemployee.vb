Public Class Frmlistemployee

    Private Sub Frmlistemployee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = "SELECT `EMPID` AS 'Employee Id',`emp_fname` as 'First Name', `emp_lname` as 'Last Name',`emp_mname` AS 'Middle Name'" _
            & ",round( ((DATEDIFF( NOW( ) ,  `birth_date` ) /12) /31))  AS 'Age', `emp_sex` AS 'Gender', `status` AS 'Status', `address` AS 'Address', `contact` AS 'Contact Number'  FROM `employee`"
        reloadDtg(sql, dtgemplist)
    End Sub


    Private Sub Btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        sql = "DELETE FROM employee WHERE EMPID = '" & dtgemplist.CurrentRow.Cells(0).Value & "'"
        createNoMsg(sql)
        sql = "DELETE FROM employee_workinfo WHERE EMPID = '" & dtgemplist.CurrentRow.Cells(0).Value & "'"
        deletes(sql, dtgemplist.CurrentRow.Cells(1).Value)

        sql = "SELECT `EMPID` AS 'Employee Id',`emp_fname` as 'First Name', `emp_lname` as 'Last Name',`emp_mname` AS 'Middle Name'" _
        & ",round( ((DATEDIFF( NOW( ) ,  `birth_date` ) /12) /31))  AS 'Age', `emp_sex` AS 'Gender', `status` AS 'Status', `address` AS 'Address', `contact` AS 'Contact Number'  FROM `employee`"
        reloadDtg(sql, dtgemplist)
    End Sub

    Private Sub Txtempsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtempsearch.TextChanged
        sql = "SELECT `EMPID` AS 'Employee Id',`emp_fname` as 'First Name', `emp_lname` as 'Last Name',`emp_mname` AS 'Middle Name'" _
           & ", round( ((DATEDIFF( NOW( ) ,  `birth_date` ) /12) /31))  AS 'Age', `emp_sex` AS 'Gender', `status` AS 'Status', `address` AS 'ADDRESS'" _
           & ", `contact` AS 'CONTACT'  FROM `employee` WHERE `EMPID` LIKE '%" & txtempsearch.Text & "%'" _
           & " OR emp_fname LIKE '%" & txtempsearch.Text & "%' OR emp_lname LIKE '%" & txtempsearch.Text & "%'"
        reloadDtg(sql, dtgemplist)

    End Sub

    Private Sub Btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub
    Private Sub Dtgemplist_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgemplist.CellClick

        ''Try
        ''    sql = "SELECT e.`EMPID` AS  'Employee Id', CONCAT(  `emp_fname` ,  ' ',  `emp_lname` ) AS  'Name',`d_rate`, `position`, `DEPARTMENT` from employee e , `employee_workinfo` we  WHERE  e.`EMPID`=we.`EMPID` AND e.`EMPID`='" & dtgemplist.CurrentRow.Cells(0).Value & "'"
        ''    reloadtxt(sql)
        ''    If dt.Rows.Count > 0 Then
        ''        'txtremain_name.Text = dt.Rows(0).Item(1)
        ''        'txtremain_position.Text = dt.Rows(0).Item(3)
        ''        'txtremain_department.Text = dt.Rows(0).Item(4)
        ''        'txtremain_salary.Text = dt.Rows(0).Item(2)
        ''        '---------------------------------------

        ''        sql = "SELECT `LEAVEDAYS` as 'Remaining Days of Leave' , `REASONS`  as 'Reasons' FROM `tblempleaveinfo` WHERE  `EMPID`='" & dt.Rows(0).Item(0) & "'"
        ''        reloadDtg(sql, dtgremain_List)

        ''        dtgremain_List.SelectAll()
        ''        dtgremain_List.Enabled = False
        ''    End If

        ''Catch ex As Exception
        ''    MsgBox(ex.Message)
        ''End Try

    End Sub



    Private Sub BtnpreviewAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Me.Close()
        frmprint_emp.Show()
        frmprint_emp.Focus()
        sql = "SELECT  e.`EMPID`, concat( `emp_fname`,' ', `emp_lname`,' ', `emp_mname`) as 'Name' ,`emp_sex`,(`d_rate` * 14) as 'TwooWeeksSalary', `position`, `DEPARTMENT` FROM `employee` e ,`employee_workinfo` we  WHERE e.`EMPID`=we.`EMPID`"
        Reports(sql, "allemployees", frmprint_emp.CrystalReportViewer1)

    End Sub

    Private Sub BtnpreviewSelected_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        frmprint_emp.Show()
        frmprint_emp.Focus()
        sql = "SELECT  e.`EMPID`, `emp_fname`, `emp_lname`, `emp_mname`,`address`, `contact`, `status`, `emp_sex`, round( ((DATEDIFF( NOW( ) ,  `birth_date` ) /12) /31))  AS 'Age',`d_rate`, `position`, `d_hired`,(`d_rate` * 15) as 'Salary', `DEPARTMENT`, `REMAININGLEAVE`, `DEFAULTLEAVE`  ,w_type" &
            " FROM  `employee` e,  `employee_workinfo` w " &
            " WHERE e.EMPID = w.EMPID AND e.EMPID='" & dtgemplist.CurrentRow.Cells(0).Value & "'"
        Reports(sql, "selectedemployee", frmprint_emp.CrystalReportViewer1)
        'Me.Close()

    End Sub

    Private Sub Btnaddnewemp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        frmemployee.emptitle.Text = "Add New Employee"
        frmemployee.Show()
        frmemployee.Focus()
        Me.Close()
    End Sub

    Private Sub Btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        Try
            frmemployee.emptitle.Text = "Update Employee"
            frmemployee.empid = dtgemplist.CurrentRow.Cells(0).Value
            frmemployee.Show()
            frmemployee.Focus()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Dtgemplist_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgemplist.DoubleClick
        Try
            frmleave.txtemid.Text = dtgemplist.CurrentRow.Cells(0).Value
            frmleave.Show()
            frmleave.Focus()
        Catch ex As Exception

        End Try
    End Sub
End Class