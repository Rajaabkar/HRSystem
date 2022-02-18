Public Class FormNewEmployee
    Private Sub BtnSubmut_Click(sender As Object, e As EventArgs) Handles btnSubmut.Click
        Try
            createee("INSERT INTO table_employee(EMPLOYEEID,FIRSTNAME,LASTNAME)VALUES('" & EMPLOYEEID.Text & "','" & FIRSTNAME.Text & "','" & LASTNAME.Text & "')")
        Catch ex As Exception

        End Try
    End Sub
End Class