Public Class FrmLeaveAbsence
    Dim empid As String = ""
    Dim reason As String = ""
    Dim leavid As Integer = 0
    Private Sub FrmLeaveAbsence_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = "SELECT  e.`EMPID` as 'Employee Id', concat( `emp_fname`,' ', `emp_lname`) as 'Name',`LEAVEFORMAT` as 'Status', `LEAVEAPPLIED` as 'Applied Leave', TIME(`DATEFROM`) as 'From', TIME(`DATETO`) as 'To' ,DATE(`LEAVEDATE`) as 'Start of Date Leave', DATE(LEAVEENDDATE) as 'End of Date Leave',`NODAYS` as 'No. Days', `REASON` as 'Reasons'  FROM `employee` e,`leave` l  WHERE  e.`EMPID`=l.`EMPID`"
        reloadDtg(sql, dtgapprovedlist)

        'dtgemplist.Columns.Clear()
        ''set a variable as a checkbox column in the DataGridView
        'Dim chkbox As New DataGridViewCheckBoxColumn
        ''set the width of the column in the DataGridView
        'With chkbox
        '    .Width = 40
        'End With

        'With dtgemplist
        '    'Adding the checkbox column in the DataGridView
        '    .Columns.Add(chkbox)
        '    'set the rows header to invisible
        '    .RowHeadersVisible = False
        'End With
        'sql = "SELECT  `LEAVEID`,`LEAVECODE`,e.`EMPID` as 'Employee Id', concat( `emp_fname`,' ', `emp_lname`) as 'Name',`LEAVEFORMAT` as 'Status', `LEAVEAPPLIED` as 'Applied Leave', TIME(`DATEFROM`) as 'From', TIME(`DATETO`) as 'To' ,DATE(`LEAVEDATE`) as 'Start of Date Leave', DATE(LEAVEENDDATE) as 'End of Date Leave',`NODAYS` as 'No. Days', `REASON` as 'Reasons', `DAYOFFSCHEDULE` as 'Dayoff Schedule', `REMARKS` as 'Remarks'  FROM `employee` e,`leave` l  WHERE  l.`REMARKS`='Pending' AND e.`EMPID`=l.`EMPID`"
        'reloadDtg(sql, dtgemplist)
        'addchk(dtgemplist)
        'dtgemplist.Columns(1).Visible = False
        'dtgemplist.Columns(2).Visible = False
        '----------------------------------------second option
        'dtgemplist.Columns(0).Visible = False
        'dtgemplist.Columns(1).Visible = False
        '----------------------------------approved list.
        'sql = "SELECT `LEAVECODE`, e.`EMPID` as 'Employee Id', concat( `emp_fname`,' ', `emp_lname`) as 'Name',`LEAVEFORMAT` as 'Status', `LEAVEAPPLIED` as 'Applied Leave', TIME(`DATEFROM`) as 'From', TIME(`DATETO`) as 'To' , DATE(`LEAVEDATE`) as 'Date of Leave', DATE(LEAVEENDDATE) as 'End Leave', `NODAYS` as 'No. Days', `REASON` as 'Reasons', `DAYOFFSCHEDULE` as 'Dayoff Schedule', `REMARKS` as 'Remarks'  FROM `employee` e,`leave` l  WHERE l.`REMARKS`='Approved' AND e.`EMPID`=l.`EMPID`"
        'reloadDtg(sql, dtgapprovedlist)
        'dtgapprovedlist.Columns(0).Visible = False
    End Sub

    Private Sub Txtempsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtempsearch.TextChanged

        sql = "SELECT  `LEAVEID`,`LEAVECODE`,e.`EMPID` as 'Employee Id', concat( `emp_fname`,' ', `emp_lname`) as 'Name',`LEAVEFORMAT` as 'Status', `LEAVEAPPLIED` as 'Applied Leave', TIME(`DATEFROM`) as 'From', TIME(`DATETO`) as 'To' , DATE(`LEAVEDATE`) as 'Date of Leave', `NODAYS` as 'No. Days', `REASON` as 'Reasons', `DAYOFFSCHEDULE` as 'Dayoff Schedule', `REMARKS` as 'Remarks'  FROM `employee` e,`leave` l  WHERE e.`EMPID`=l.`EMPID`" &
        " AND `REMARKS`='Pending' AND (e.`EMPID` LIKE '%" & txtempsearch.Text & "%' OR concat( `emp_fname`,' ', `emp_lname`) LIKE '%" & txtempsearch.Text & "%')"
        reloadDtg(sql, dtgemplist)

    End Sub

    Private Sub BtnApprove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApprove.Click




        For Each row As DataGridViewRow In dtgemplist.Rows
            'If dtgemplist.Columns(0).CellTyp = False Then
            '    MsgBox("Please select the pending leaves enable to perform an action", MsgBoxStyle.Exclamation)
            '    Exit Sub
            'End If
            ''

            If row.Cells(0).FormattedValue = True Then
                sql = "UPDATE `leave` SET  `REMARKS` =  'Approved' WHERE   `LEAVEID` ='" _
                            & CStr(row.Cells(1).FormattedValue) & "'"
                createNoMsg(sql)
                '-------------------------------------------FIRS OPTION LIST
                sql = "INSERT INTO `tblapproveleave` (`LEAVEID`,`LEAVECODE`,`EMPID`, `NODAYSAPPROVE`, `user_id`, `STATUS`) " _
                & " VALUES ('" & row.Cells(1).FormattedValue & "','" & row.Cells(2).FormattedValue & "','" & row.Cells(3).FormattedValue & "','" _
                & row.Cells(10).FormattedValue & "','" & USERID & "','APPROVE')"
                createNoMsg(sql)
                'sql = "UPDATE  `tblempleaveinfo` SET `LEAVEDAYS` = `LEAVEDAYS` - '" & row.Cells(9).FormattedValue & "' WHERE `EMPID` = '" & row.Cells(3).FormattedValue & _
                '"' AND `RESONS` ='" & row.Cells(5).FormattedValue & "'"
                'createNoMsg(sql)

                'Else
                '    MsgBox("Please select the pending leaves enable to perform an action", MsgBoxStyle.Exclamation)
                '    Exit Sub
            End If
        Next
        'For i As Integer = 0 To dtgemplist.Rows.Count - 1
        '    If dtgemplist.Rows(i).Cells(0).Value = False Then
        '        MsgBox("Please select the pending leaves enable to perform an action", MsgBoxStyle.Exclamation)
        '        Exit For
        '    End If

        'Next


        ''--------------------------------------------SECOND OPTION
        'sql = "INSERT INTO `tblapproveleave` (`LEAVEID`, `EMPID`, `NODAYSAPPROVE`, `user_id`, `STATUS`) " _
        '   & " VALUES ('" & dtgemplist.Rows(0).Cells(0).Value & "','" & empid & "','" _
        '   & txtnodaysapplied.Text & "','" & USERID & "','APPROVE')"
        'createNoMsg(sql)

        'sql = "UPDATE  `tblempleaveinfo` SET `LEAVEDAYS` = `LEAVEDAYS` - '" & txtnodaysapplied.Text & "' WHERE `EMPID` = '" & empid & _
        '"' AND `RESONS` ='" & reason & "'"
        'createNoMsg(sql)
        MsgBox("Employees Leave of Absence has been approved.")
        Call FrmLeaveAbsence_Load(sender, e)

    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        For Each row As DataGridViewRow In dtgemplist.Rows
            If row.Cells(0).FormattedValue = True Then
                sql = "UPDATE `leave` SET  `REMARKS` =  'Cancelled' WHERE   `LEAVEID` ='" _
                            & CStr(row.Cells(1).FormattedValue) & "'"
                createNoMsg(sql)
                'sql = "UPDATE `tblempleaveinfo`  SET `LEAVEDAYS` =`LEAVEDAYS` + '" & CStr(row.Cells(9).FormattedValue) & "' WHERE `EMPID`='" & CStr(row.Cells(3).FormattedValue) & "' AND `RESONS` ='" & CStr(row.Cells(5).FormattedValue) & "' "
                'createNoMsg(sql)
                '------------------------------------------
                sql = "UPDATE `employee` SET `ONLEAVE`=0,`REMAININGLEAVE`=`REMAININGLEAVE` + '" & CStr(row.Cells(9).FormattedValue) & "' WHERE `EMPID`='" & row.Cells(3).Value & "'"
                createNoMsg(sql)
                '-----------------

                'Else
                '    MsgBox("Please select the pending leaves to perform an action", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
        Next
        MsgBox("Employee's Leave of Absence has been cancelled.")
        Call FrmLeaveAbsence_Load(sender, e)
    End Sub



    Private Sub Dtgemplist_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgemplist.DoubleClick
        Try

            'sql = "SELECT e.`EMPID`,CONCAT(`emp_fname`, `emp_lname`) ,  `LEAVEDAYS`, `RESONS` " & _
            '" FROM `employee` e, `tblempleaveinfo` l WHERE  " _
            '& "e.`EMPID`=l.`EMPID` AND `RESONS`='" & dtgemplist.CurrentRow.Cells(4).Value & _
            '"' AND l.`EMPID`= '" & dtgemplist.CurrentRow.Cells(1).Value & "'"
            'reloadtxt(sql)
            'If dt.Rows.Count > 0 Then
            '    With dt.Rows(0)
            '        empid = .Item(0)
            '        txtempname.Text = .Item(1)
            '        txtbalanceleave.Text = .Item(2)
            '        reason = .Item(3)
            '    End With

            ' End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Txtnodaysapplied_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnodaysapplied.TextChanged
        Try
            txtremainingdays.Text = Val(txtbalanceleave.Text) + Val(txtnodaysapplied.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Txtapprovesearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtapprovesearch.TextChanged
        Try
            '----------------------------------approved list.
            sql = "SELECT  e.`EMPID` as 'Employee Id', concat( `emp_fname`,' ', `emp_lname`) as 'Name',`LEAVEFORMAT` as 'Status', `LEAVEAPPLIED` as 'Applied Leave', TIME(`DATEFROM`) as 'From', TIME(`DATETO`) as 'To' , DATE(`LEAVEDATE`) as 'Start of Date Leave',`LEAVEENDDATE` as 'End of Date Leave', `NODAYS` as 'No. Days', `REASON` as 'Reasons'   FROM `employee` e,`leave` l  WHERE e.`EMPID`=l.`EMPID` " &
        " AND (e.`EMPID` LIKE '%" & txtapprovesearch.Text & "%' OR concat( `emp_fname`,' ', `emp_lname`) LIKE '%" & txtapprovesearch.Text & "%')"
            reloadDtg(sql, dtgapprovedlist)
            'sql = "SELECT LEAVECODE, e.`EMPID` as 'Employee Id', concat( `emp_fname`,' ', `emp_lname`) as 'Name',`LEAVEFORMAT` as 'Status', `LEAVEAPPLIED` as 'Applied Leave', TIME(`DATEFROM`) as 'From', TIME(`DATETO`) as 'To' , DATE(`LEAVEDATE`) as 'Date of Leave', `NODAYS` as 'No. Days', `REASON` as 'Reasons', `DAYOFFSCHEDULE` as 'Dayoff Schedule'   FROM `employee` e,`leave` l  WHERE   AND e.`EMPID`=l.`EMPID`" & _
            '" AND (e.`EMPID` LIKE '%" & txtapprovesearch.Text & "%' OR concat( `emp_fname`,' ', `emp_lname`) LIKE '%" & txtapprovesearch.Text & "%')"
            'reloadDtg(sql, dtgapprovedlist)
            'dtgapprovedlist.Columns(0).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Btnview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnview.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmleave.Show()
        frmleave.Focus()
        Me.Close()
    End Sub

    Private Sub Dtgemplist_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgemplist.CellContentClick

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        'With frmprint_emp
        '    .Show()
        '    .Focus()
        'End With
        'sql = "SELECT  e.`EMPID`, concat( `emp_fname`,' ', `emp_lname`,' ', `emp_mname`) as 'Name' ,`emp_sex`,(`d_rate` * 14) as 'TwooWeeksSalary', `position`, `DEPARTMENT` FROM `employee` e ,`employee_workinfo` we  WHERE e.`EMPID`=we.`EMPID`"
        'reports(sql, "allemployees", frmprint_emp.CrystalReportViewer1)


    End Sub
End Class