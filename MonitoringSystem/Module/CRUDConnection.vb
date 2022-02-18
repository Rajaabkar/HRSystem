Imports MySql.Data.MySqlClient
Module CRUDConnection

    Public RESULTT As String
    Public cmdd As New MySqlCommand
    Public dda As New MySqlDataAdapter
    Public ddt As New DataTable
    Public dds As New DataSet
    Private strcon As Object

    Public Sub Createee(ByVal sql As String)
        Try
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql

                result = cmd.ExecuteNonQuery

                If result = 0 Then
                    MessageBox.Show("Data fiailed to insert", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    MessageBox.Show("Data has been successfully inserted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If
            End With
        Catch ex As Exception
        Finally

            strcon.Close()
        End Try
    End Sub

    Public Sub Reload(ByVal sqln As String)
        Try
            strcon.Open()
            ddt = New DataTable

            With cmd
                .Connection = strcon
                .CommandText = sql
            End With
            dda.SelectCommand = cmd
            dda.Fill(ddt)
        Catch ex As Exception
        Finally
            strcon.Close()
            dda.Dispose()
        End Try
    End Sub
End Module
