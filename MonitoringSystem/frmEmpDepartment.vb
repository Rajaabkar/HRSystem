Public Class FrmEmpDepartment
    Private Sub Frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Fillcbo("SELECT `DEPARTMENT` FROM `tbldepartment` ", ComboBox1)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        sql = "SELECT e.`EMPID` AS 'Employee Id',`emp_fname` as 'First Name', `emp_lname` as 'Last Name',`emp_mname` AS 'Middle Name'" _
           & ", round( ((DATEDIFF( NOW( ) ,  `birth_date` ) /12) /31))  AS 'Age', `emp_sex` AS 'Gender', `status` AS 'Status', `address` AS 'ADDRESS'" _
           & ", `contact` AS 'CONTACT'  FROM `employee` e, `employee_workinfo` w  WHERE e.EMPID=w.EMPID AND  Department LIKE '%" & ComboBox1.Text & "%'"
        reloadDtg(sql, dtgemplist)
    End Sub
End Class