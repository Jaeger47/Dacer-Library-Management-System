Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic
Public Class BookRemovecopy
    Dim str As String = "server=localhost; uid=root; password=; database=db_new_lms"
    Dim con As New MySqlConnection(Str)
    Private Sub BookRemovecopy_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BunifuThinButton22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuThinButton22.Click
        Me.Close()
    End Sub

    Private Sub BunifuThinButton21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuThinButton21.Click
        If BunifuMetroTextbox1.Text = Nothing Then
            MsgBox("Fill all fields", MsgBoxStyle.Information, "Note")
        Else

            Dim cmd As MySqlCommand
            con.Open()
            Try
                cmd = con.CreateCommand()
                cmd.CommandText = "delete from books where Book_ID=@Book_ID;"
                cmd.Parameters.AddWithValue("@Book_ID", BunifuMetroTextbox1.Text)
                cmd.ExecuteNonQuery()
                con.Close()
                MsgBox("Book Removed!", vbInformation, "Note")
                Me.Dispose()
            Catch ex As Exception
                MsgBox("Not Found", vbInformation, "Note")
            End Try
        End If
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class