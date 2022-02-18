Public Class frmemployee
    Public empid As String = ""
    Private Sub Btnempsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnempsave.Click
        Try
            'loadautonumber("employee", txtcode)
            For Each ctrl As Control In GroupBox9.Controls
                If ctrl.GetType Is GetType(TextBox) Then
                    If ctrl.Text = "" Then
                        MsgBox("One of the box is empty. It needed to be filled up.", MsgBoxStyle.Exclamation)
                        Return
                    End If
                End If
                If ctrl.GetType Is GetType(ComboBox) Then
                    If ctrl.Text = "----Select-----" Then
                        MsgBox("You have to set the correct information.", MsgBoxStyle.Exclamation)
                        Return
                    End If
                End If
            Next

            For Each ctrl As Control In GroupBox10.Controls
                If ctrl.GetType Is GetType(ComboBox) Then
                    If ctrl.Text = "----Select-----" Then
                        MsgBox("You have to set the correct information.", MsgBoxStyle.Exclamation)
                        Return
                    End If
                End If

                If ctrl.GetType Is GetType(TextBox) Then
                    If ctrl.Text = "" Then
                        MsgBox("One of the box is empty. It needs to be filled up.", MsgBoxStyle.Exclamation)
                        Return
                    End If
                End If
            Next

            Dim bdate As Integer = Math.Round(DateDiff(DateInterval.DayOfYear, dtpdbirth.Value, Now) / 12 / 31)
            If bdate < 18 Then
                MsgBox("Invalid birth of date.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If


            '---------------------------------------------------------
            Dim rdo As String = ""
            sql = "SELECT * FROM `employee` e, `employee_workinfo` ew " _
                & " WHERE e.`EMPID`=ew.`EMPID` AND e.EMPID ='" & txtcode.Text & "'"
            reloadtxt(sql)
            If dt.Rows.Count > 0 Then
                '-------------------update
                If rdomale.Checked = True Then
                    rdo = "MALE"
                Else
                    rdo = "FEMALE"
                End If

                sql = "UPDATE `employee_workinfo` SET  `d_rate`='" & txtdrate.Text _
                                 & "', `p_method`='" & txtpmethod.Text & "', `position`='" & txtposition.Text _
                                 & "', `d_hired`='" & Format(dtpdhired.Value, "yyyy-MM-dd") &
                                 "', `DEPARTMENT`='" & cbodeaprtment.Text &
                                 "',`w_type`='" & cbowtype.Text & "' WHERE `EMPID`='" & txtcode.Text & "'"
                createNoMsg(sql)

                sql = "UPDATE `employee` SET  `emp_fname`='" & txtfname.Text _
                & "', `emp_lname`='" & txtlname.Text & "', `emp_mname`='" & txtmname.Text _
                & "', `address`='" & txtaddress.Text & "', `contact`='" & txtcontact.Text & "', `status`='" & txtstatus.Text _
                & "', `birth_date`='" & Format(dtpdbirth.Value, "yyyy-MM-dd") & "', `birth_place`='" & txtbplace.Text & "', `emp_sex`='" & rdo _
                & "' , `emerg_contct`='" & txtemerg.Text _
                & "'  WHERE `EMPID`='" & txtcode.Text & "'"
                updates(sql, txtlname.Text)



                '--------------end update
            Else
                '------------------insert
                If rdomale.Checked = True Then
                    rdo = "MALE"
                Else
                    rdo = "FEMALE"
                End If
                sql = "INSERT INTO `employee_workinfo` (`EMPID`, `d_rate`, `p_method`, `position`,   `d_hired`,DEPARTMENT,w_type)" _
                        & " VALUES ('" & txtcode.Text & "','" & txtdrate.Text & "','" & txtpmethod.Text & "','" & txtposition.Text _
                        & "', '" & Format(dtpdhired.Value, "yyyy-MM-dd") & "','" & cbodeaprtment.Text & "','" & cbowtype.Text & "')"
                createNoMsg(sql)
                '------------------------------------------------------------------------------
                sql = "INSERT INTO `employee` (`EMPID`, `emp_fname`, `emp_lname`, `emp_mname`" _
                & ", `address`, `contact`, `status`, `birth_date`, `birth_place`, `emp_sex`" _
                & ", `emerg_contct`,`REMAININGLEAVE`,`DEFAULTLEAVE`) VALUES ('" & txtcode.Text & "','" & txtfname.Text & "','" & txtlname.Text _
                & "','" & txtmname.Text & "','" & txtaddress.Text & "','" & txtcontact.Text & "','" & txtstatus.Text _
                & "','" & Format(dtpdbirth.Value, "yyyy-MM-dd") & "','" & txtbplace.Text & "','" & rdo & "','" & txtemerg.Text & "',30,30)"
                create(sql, txtfname.Text & " " & txtlname.Text)
                ''-----------------------------------------------
                sql = "INSERT INTO `tblleaveinfo`  (`EMPID`, `LEAVEDAYS`, `REASONS`)" _
                & " VALUES ('" & txtcode.Text & "',15,'SICK'),('" & txtcode.Text & "',15,'Vacation')"
                createNoMsg(sql)
                '--------------------------------------------------
                Updateautonumber("employee")
                '---------------end insert


                cleartext(GroupBox9)
                cleartext(GroupBox10)

                Loadautonumber("employee", txtcode)
            End If



        Catch ex As Exception
            MsgBox(ex.Message & " btnempsave_Click", MsgBoxStyle.Exclamation)
        End Try
    End Sub



    Private Sub Frmemployee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Fillcbo("SELECT * FROM `tblsettings` WHERE  `FORTHE`='Position'", txtposition)
        cleartext(GroupBox9)
        cleartext(GroupBox10)
        Fillcbo("SELECT `DEPARTMENT` FROM `tbldepartment` ", cbodeaprtment)
        If empid = "" Then
            Loadautonumber("employee", txtcode)
        Else
            txtcode.Text = empid
        End If


    End Sub

    Private Sub Btnempnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnempnew.Click
        cleartext(GroupBox9)
        cleartext(GroupBox10)
        Loadautonumber("employee", txtcode)
        emptitle.Text = "Register New Employee"

    End Sub

    Private Sub Btnempupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmlistemployee.Show()
        frmlistemployee.Focus()
        Me.Close()

        'Try
        '    For Each ctrl As Control In GroupBox9.Controls
        '        If ctrl.GetType Is GetType(TextBox) Then
        '            If ctrl.Text = "" Then
        '                MsgBox("One of the box is empty. It needed to be filled up.", MsgBoxStyle.Exclamation)
        '                Return
        '            End If
        '        End If
        '        If ctrl.GetType Is GetType(ComboBox) Then
        '            If ctrl.Text = "----Select-----" Then
        '                MsgBox("You have to set the correct information.", MsgBoxStyle.Exclamation)
        '                Return
        '            End If
        '        End If
        '    Next

        '    For Each ctrl As Control In GroupBox10.Controls
        '        If ctrl.GetType Is GetType(ComboBox) Then
        '            If ctrl.Text = "----Select-----" Then
        '                MsgBox("You have to set the correct information.", MsgBoxStyle.Exclamation)
        '                Return
        '            End If
        '        End If

        '        If ctrl.GetType Is GetType(TextBox) Then
        '            If ctrl.Text = "" Then
        '                MsgBox("One of the box is empty. It needed to be filled up.", MsgBoxStyle.Exclamation)
        '                Return
        '            End If
        '        End If
        '    Next

        '    Dim rdo As String = ""
        '    If rdomale.Checked = True Then
        '        rdo = "MALE"
        '    Else
        '        rdo = "FEMALE"
        '    End If
        '    sql = "UPDATE `employee_workinfo` SET  `d_rate`='" & txtdrate.Text _
        '            & "', `p_method`='" & txtpmethod.Text & "', `position`='" & txtposition.Text _
        '            & "', `d_hired`='" & dtpdhired.Text & _
        '            "', `DEPARTMENT`='" & cbodeaprtment.Text & "' WHERE `EMPID`='" & txtcode.Text & "'"
        '    createNoMsg(sql)

        '    sql = "UPDATE `employee` SET  `emp_fname`='" & txtfname.Text _
        '    & "', `emp_lname`='" & txtlname.Text & "', `emp_mname`='" & txtmname.Text _
        '    & "', `address`='" & txtaddress.Text & "', `contact`='" & txtcontact.Text & "', `status`='" & txtstatus.Text _
        '    & "', `birth_date`='" & dtpdbirth.Text & "', `birth_place`='" & txtbplace.Text & "', `emp_sex`='" & rdo _
        '    & "', `emp_age`='" & txtage.Text & "', `emerg_contct`='" & txtcontact.Text _
        '    & "' WHERE `EMPID`='" & txtcode.Text & "'"
        '    updates(sql, txtlname.Text)
        '    cleartext(GroupBox9)
        '    cleartext(GroupBox10)
        '    loadautonumber("employee", txtcode)
        'Catch ex As Exception
        '    MsgBox(ex.Message & " btnempupdate_Click", MsgBoxStyle.Exclamation)
        'End Try
    End Sub
    Public empcode As String



    Private Sub Txtcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcode.TextChanged
        Try

            sql = "SELECT * FROM `employee` e, `employee_workinfo` ew " _
                 & " WHERE e.`EMPID`=ew.`EMPID` AND e.EMPID ='" & txtcode.Text & "'"
            reloadtxt(sql)

            If dt.Rows.Count > 0 Then





                txtdrate.Text = dt.Rows(0).Item("d_rate")
                txtpmethod.Text = dt.Rows(0).Item("p_method")
                txtposition.Text = dt.Rows(0).Item("position")
                dtpdhired.Value = dt.Rows(0).Item("d_hired")

                txtfname.Text = dt.Rows(0).Item("emp_fname")
                txtlname.Text = dt.Rows(0).Item("emp_lname")
                txtmname.Text = dt.Rows(0).Item("emp_mname")
                txtaddress.Text = dt.Rows(0).Item("address")
                txtcontact.Text = dt.Rows(0).Item("contact")
                txtstatus.Text = dt.Rows(0).Item("status")
                dtpdbirth.Value = dt.Rows(0).Item("birth_date")
                txtbplace.Text = dt.Rows(0).Item("birth_place")
                If dt.Rows(0).Item("emp_sex") = "MALE" Then
                    rdomale.Checked = True
                Else
                    rdofemale.Checked = True
                End If
                txtemerg.Text = dt.Rows(0).Item("emerg_contct")
                cbodeaprtment.Text = dt.Rows(0).Item("DEPARTMENT")
                cbowtype.Text = dt.Rows(0).Item("w_type")
                'Else
                '    cleartext(GroupBox10)
                '    cleartext(GroupBox9)

            End If
            'aloadautonumber("employee", txtcode)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub Btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub Txtcontact_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcontact.TextChanged
        If IsNumeric(txtcontact.Text) = False Then
            txtcontact.Clear()

        End If
    End Sub

    Private Sub Txtemerg_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtemerg.TextChanged
        If IsNumeric(txtemerg.Text) = False Then
            txtemerg.Clear()
        End If
    End Sub

    Private Sub Rdofemale_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdofemale.CheckedChanged

    End Sub
End Class