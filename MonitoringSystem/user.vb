Imports MySql.Data.MySqlClient
Module user
    Public con As MySqlConnection = Mysqldb()
    Public USERID As Integer = 0
    Public Sub Login(ByVal username As Object, ByVal pass As Object)
        Try

            con.Open()
            reloadtxt("SELECT * FROM tbluser WHERE username= '" & username & "' and pass = sha1('" & pass & "')")



            If dt.Rows.Count > 0 Then
                USERID = dt.Rows(0).Item("user_id")
                If dt.Rows(0).Item("type") = "Administrator" Then
                    MsgBox("Welcome " & dt.Rows(0).Item("type"))
                    With Form1
                        .ManageEmployeesToolStripMenuItem.Enabled = True
                        .LeaveOfAbsenceToolStripMenuItem.Enabled = True
                        .ManageDepartmentToolStripMenuItem.Enabled = True
                        .EmployeesPosistionToolStripMenuItem.Enabled = True
                        .ReportsToolStripMenuItem.Enabled = True
                        .ManageUsersToolStripMenuItem.Enabled = True
                        .SearchEmployeeToolStripMenuItem.Enabled = True
                        .btnApplication.Enabled = True
                        .btnHistory.Enabled = True
                        .btnList.Enabled = True
                        .btnReg.Enabled = True
                        .LoginToolStripMenuItem.Text = "Logout"


                        .Text = "Today's user : " & dt.Rows(0).Item("name") & "/" & dt.Rows(0).Item("type")
                    End With
                    LoginForm1.Close()

                ElseIf dt.Rows(0).Item("type") = "HR Personnel" Then
                    MsgBox("Welcome " & dt.Rows(0).Item("type"))
                    With Form1
                        .ManageEmployeesToolStripMenuItem.Visible = True
                        .LeaveOfAbsenceToolStripMenuItem.Visible = True
                        .ManageDepartmentToolStripMenuItem.Visible = True
                        .EmployeesPosistionToolStripMenuItem.Visible = True
                        .ReportsToolStripMenuItem.Visible = True
                        .ManageUsersToolStripMenuItem.Visible = True
                        .LoginToolStripMenuItem.Text = "Logout"
                        .Text = "Today's user : " & dt.Rows(0).Item("name") & "/ " & dt.Rows(0).Item("type")
                    End With
                    LoginForm1.Close()
                End If

            Else
                MsgBox("Acount doest not exits!", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()
        da.Dispose()
    End Sub
    Public Sub Append(ByVal sql As String, ByVal field As String, ByVal txt As Object)
        Reloadtxt(sql)
        Try
            Dim r As DataRow
            txt.AutoCompleteCustomSource.Clear()
            For Each r In dt.Rows
                txt.AutoCompleteCustomSource.Add(r.Item(field).ToString)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
End Module

