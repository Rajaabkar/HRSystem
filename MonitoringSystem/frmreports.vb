Public Class Frmreports

    Private Sub Frmreports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = "SELECT `EMPID` as 'Employee Id' , concat(`emp_fname`, ' ',`emp_lname`) as 'Name' FROM `employee`  "
        reloadDtg(sql, dtglist)
        field = "EMPID"
    End Sub

    Private Sub Dtglist_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtglist.CellClick
        Try

            sql = "SELECT concat(`emp_fname`, ' ',`emp_lname`),`LEAVEAPPLIED`,`LEAVEDATE`,`LEAVEENDDATE`, `NODAYS` ,`REMAININGLEAVE`,  `DEFAULTLEAVE`  FROM `employee` e,`leave` l WHERE e.`EMPID`=l.`EMPID`" _
            & " AND e.EMPID='" & dtglist.CurrentRow.Cells(0).Value & "'"
            'sql = "SELECT  e.`EMPID`, `emp_fname`, `emp_lname`, `emp_mname`,`address`, `contact`, `status`, `emp_sex`, round( ((DATEDIFF( NOW( ) ,  `birth_date` ) /12) /31))  AS 'Age',`d_rate`, `position`, `d_hired`,(`d_rate` * 15) as 'Salary', `DEPARTMENT`, `REMAININGLEAVE`, `DEFAULTLEAVE`  ,w_type" & _
            '        " FROM  `employee` e,  `employee_workinfo` w " & _
            '        " WHERE e.EMPID = w.EMPID  AND e.EMPID='" & dtglist.CurrentRow.Cells(0).Value & "'"
            Reports(sql, "categ", CrystalReportViewer1)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged

        sql = "SELECT `EMPID` as 'Employee Id' , concat(`emp_fname`, ' ',`emp_lname`) as 'Name' FROM `employee` WHERE  " & field & " LIKE '%" & txtsearch.Text & "%' "
        reloadDtg(sql, dtglist)

    End Sub
    Dim field As String = ""

    Private Sub CboCategory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCategory.SelectedIndexChanged
        If cboCategory.Text = "Id" Then
            field = "EMPID"
        ElseIf cboCategory.Text = "First Name" Then
            field = "emp_fname"
        ElseIf cboCategory.Text = "Last Name" Then
            field = "emp_lname"
        End If
    End Sub
End Class