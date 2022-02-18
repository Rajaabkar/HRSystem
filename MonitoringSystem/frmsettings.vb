Public Class Frmsettings
    Dim positionID As Integer = 0
    ' Dim Departmentid As Integer = 0
    Private Sub Npositionsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles npositionsave.Click
        Try
            sql = "INSERT INTO `tblsettings` (`DESCRIPTION`, `FORTHE`) VALUES ('" & txtposition.Text & "','Position')"
            Create(sql, "New Position")
            Call Btnpositionload_Click(sender, e)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Btnpositionload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpositionload.Click
        Try
            sql = "SELECT ID,`DESCRIPTION` as Position FROM `tblsettings` WHERE `FORTHE`='Position'"
            reloadDtg(sql, dtglistposition)
            txtposition.Clear()
            dtglistposition.Columns(0).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Npositionupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles npositionupdate.Click
        sql = "UPDATE `tblsettings` SET `DESCRIPTION`='" & txtposition.Text & "' WHERE  `ID`=" & positionID
        updates(sql, "Position")
        Call Btnpositionload_Click(sender, e)
    End Sub

    Private Sub Npositiondelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles npositiondelete.Click
        sql = "DELETE FROM `tblsettings` WHERE `ID`=" & dtglistposition.CurrentRow.Cells(0).Value
        Deletes(sql, "Position")
        Call Btnpositionload_Click(sender, e)
    End Sub

    Private Sub Dtglistposition_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtglistposition.DoubleClick
        Try
            positionID = dtglistposition.CurrentRow.Cells(0).Value
            txtposition.Text = dtglistposition.CurrentRow.Cells(1).Value
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    ''' <summary>
    ''' for the departments
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>


    Private Sub Frmsettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class