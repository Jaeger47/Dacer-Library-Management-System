Imports MySql.Data.MySqlClient
Public Class BookReturnCon
    Dim str As String = "server=localhost; uid=root; password=; database=db_new_lms"
    Dim con As New MySqlConnection(str)


    Private Sub BookReturnCon_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



    End Sub

    Private Sub BunifuThinButton22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuThinButton22.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BunifuMetroTextbox3_OnValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BunifuThinButton21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuThinButton21.Click
        MsgBox(var_del)
        Dim cmd As MySqlCommand
        con.Open()
        Try
            cmd = con.CreateCommand()
            cmd.CommandText = "delete from issue where Issue_ID=@Issue_ID;"
            cmd.Parameters.AddWithValue("@Issue_ID", var_del)
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox("Book Returned!", vbInformation, "Note")
            Me.Dispose()
        Catch ex As Exception
            MsgBox("Not Found", vbInformation, "Note")
        End Try
    End Sub


    Private Sub BunifuMetroTextbox1_OnValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class