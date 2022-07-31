Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic
Public Class BookRemoveCopyCon
    Dim str As String = "server=localhost; uid=root; password=; database=db_new_lms"
    Dim con As New MySqlConnection(str)
    Dim cmd As MySqlCommand
    Dim command As MySqlCommand


    Private Sub BookRemoveCopyCon_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BunifuThinButton22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuThinButton22.Click
        Me.Close()
    End Sub

    Private Sub BunifuThinButton21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuThinButton21.Click
        Try
            con.Open()
            cmd = con.CreateCommand()
            cmd.CommandText = "update books set Number_of_Copies='" & var_book_add & "' where Book_ID='" & vars_id & "'"
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox("Book Copies Removed!", vbInformation, "Note")
            Me.Dispose()
        Catch ex As Exception
            MsgBox("Encountered Error", MsgBoxStyle.Critical, "Error")
            con.Close()
        End Try

    End Sub
End Class