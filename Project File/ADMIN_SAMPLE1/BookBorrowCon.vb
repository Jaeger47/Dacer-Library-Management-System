Imports MySql.Data.MySqlClient
Public Class BookBorrowCon
    Dim str As String = "server=localhost; uid=root; password=; database=db_new_lms"
    Dim con As New MySqlConnection(str)

    Private Sub BookBorrowCon_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BunifuThinButton22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuThinButton22.Click
        Me.Dispose()
    End Sub

    Private Sub BunifuThinButton21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuThinButton21.Click
        Dim cmd As MySqlCommand
        Try
            con.Open()
            cmd = con.CreateCommand()
            cmd.CommandText = "Insert into issue(Book_ID,Student_ID,Day_Of_Borrow,Day_Of_Return)values(@Book_ID,@Student_ID,@Day_Of_Borrow,@Day_Of_Return);"
            cmd.Parameters.AddWithValue("@Book_ID", bor_book_id)
            cmd.Parameters.AddWithValue("@Student_ID", bor_id)
            cmd.Parameters.AddWithValue("@Day_Of_Borrow", bor_b)
            cmd.Parameters.AddWithValue("@Day_Of_Return", bor_r)
            cmd.ExecuteNonQuery()
            ListIssue.load()
            con.Close()
            Me.Dispose()

        Catch ex As Exception
            MsgBox("Encountered Error", MsgBoxStyle.Critical, "Error")
            con.Close()
        End Try
    End Sub


End Class