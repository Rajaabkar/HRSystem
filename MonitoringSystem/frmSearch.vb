Public Class FrmSearch
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        sql = "SELECT  e.`EMPID`, `emp_fname`, `emp_lname`, `emp_mname`,`address`, `contact`, `status`, `emp_sex`, round( ((DATEDIFF( NOW( ) ,  `birth_date` ) /12) /31))  AS 'Age',`d_rate`, `position`, `d_hired`,(`d_rate` * 15) as 'Salary', `DEPARTMENT`, `REMAININGLEAVE`, `DEFAULTLEAVE`  ,w_type  FROM  `employee` e,  `employee_workinfo` w  WHERE e.EMPID = w.EMPID  AND e.EMPID='" & txtEmpID.Text & "'"
        Reports(sql, "selectedemployee", frmPrints.CrystalReportViewer1)
        frmPrints.Show()
        frmPrints.Focus()
        Me.Close()
    End Sub

    Private Sub txtEmpID_TextChanged(sender As Object, e As EventArgs) Handles txtEmpID.TextChanged

    End Sub
End Class