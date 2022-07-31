Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic


Public Class MemberRemove
    Dim str As String = "server=localhost; uid=root; password=; database=db_new_lms"
    Dim con As New MySqlConnection(Str)

    Private Sub MemberRemove_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BunifuThinButton22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuThinButton22.Click
        Me.Dispose()
    End Sub

    Private Sub BunifuThinButton21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuThinButton21.Click
        If BunifuMetroTextbox1.Text = Nothing Then
            MsgBox("Fill all fields", MsgBoxStyle.Information, "Note")
        Else

            Dim cmd As MySqlCommand
            con.Open()
            Try
                cmd = con.CreateCommand()
                cmd.CommandText = "delete from profile where Student_ID=@Student_ID;"
                cmd.Parameters.AddWithValue("@Student_ID", BunifuMetroTextbox1.Text)
                cmd.ExecuteNonQuery()
                con.Close()
                MsgBox("Student Removed", vbInformation, "Note")
                Me.Dispose()
            Catch ex As Exception
                MsgBox("Not Found", vbInformation, "Note")
                con.Close()
            End Try
        End If
    End Sub

    Private Sub BunifuMetroTextbox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles BunifuMetroTextbox1.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 _
                AndAlso Asc(e.KeyChar) <> 46 And Not IsNumeric(e.KeyChar) Then

            e.Handled = True
        End If
    End Sub

End Class