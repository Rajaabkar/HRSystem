Public Class Frmautonumber
    Dim ID = 0
    Private Sub Btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        sql = "INSERT INTO tblautonumber (STRT,END,INCREMENT,DESCRIPTION)" &
        " VALUES ('" & txtstart.Text & "','" & txtend.Text & "','" & txtincrement.Text & "','" & txtdescription.Text & "')"
        create(sql, "New Autonumber")
        Call Frmautonumber_Load(sender, e)
    End Sub

    Private Sub Btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        sql = "UPDATE tblautonumber SET STRT= '" & txtstart.Text & "',END='" & txtend.Text & "',INCREMENT='" & txtincrement.Text &
        "',DESCRIPTION='" & txtdescription.Text & "' WHERE ID = '" & ID & "'"
        updates(sql, "Autonumber")
        Call Frmautonumber_Load(sender, e)
    End Sub

    Private Sub Btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        sql = "DELETE FROM tblautonumber WHERE ID = '" & dtglist.CurrentRow.Cells(0).Value & "'"
        deletes(sql, "Autonumber")
        Call Frmautonumber_Load(sender, e)
    End Sub

    Private Sub Dtglist_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtglist.DoubleClick
        ID = dtglist.CurrentRow.Cells(0).Value
        txtend.Text = dtglist.CurrentRow.Cells(2).Value
        txtstart.Text = dtglist.CurrentRow.Cells(1).Value
        txtincrement.Text = dtglist.CurrentRow.Cells(3).Value
        txtdescription.Text = dtglist.CurrentRow.Cells(4).Value
    End Sub

    Private Sub Frmautonumber_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = "SELECT * FROM tblautonumber"
        reloadDtg(sql, dtglist)
        cleartext(Me)
    End Sub
End Class