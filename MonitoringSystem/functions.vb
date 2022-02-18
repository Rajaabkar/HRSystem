Module functions
    Public Sub cleartext(ByVal obj As Object)
        For Each ctrl As Control In obj.Controls
            If ctrl.GetType Is GetType(TextBox) Then
                ctrl.Text = Nothing
            End If
        Next
        For Each ctrl As Control In obj.Controls
            If ctrl.GetType Is GetType(RichTextBox) Then
                ctrl.Text = Nothing
            End If
        Next
        For Each ctrl As Control In obj.Controls
            If ctrl.GetType Is GetType(ComboBox) Then
                ctrl.Text = "----Select-----"
            End If
        Next
        For Each ctrl As Control In obj.Controls
            If ctrl.GetType Is GetType(DateTimePicker) Then
                ctrl.Text = Now
            End If
        Next

        For Each ctrl As Control In obj.Controls
            If ctrl.GetType Is GetType(RadioButton) Then
                ctrl.Controls.Clear()
            End If
        Next
    End Sub 
    Public checkh As New DataGridViewCheckBoxColumn
    Public ckBox As New CheckBox()
    Public Sub addchk(ByVal dtg As DataGridView)

        Try
            ckBox = New CheckBox()
            checkh = New DataGridViewCheckBoxColumn
            With dtg
                .Columns.Insert(0, checkh)
                .Columns(0).Width = 20
                .Columns(1).Width = 20
                .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            End With


            'Get the column header cell bounds
            Dim rect = dtg.GetCellDisplayRectangle(0, -1, True)
            ckBox.Size = New Size(20, 20)
            'Change the location of the CheckBox to make it stay on the header
            ckBox.Location = rect.Location

            AddHandler ckBox.CheckedChanged, AddressOf ckBox_CheckedChanged

            'Add the CheckBox into the DataGridView
            dtg.Controls.Add(ckBox)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub ckBox_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        Try
            For Each row As DataGridViewRow In frmLeaveAbsence.dtgemplist.Rows
                If ckBox.CheckState = CheckState.Checked Then
                    row.Cells(0).Value = True
                Else
                    row.Cells(0).Value = False
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Module
