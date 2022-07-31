Imports MySql.Data.MySqlClient
Public Class ListIssue
    Dim str As String = "server=localhost; uid=root; password=; database=db_new_lms"
    Dim con As New MySqlConnection(str)
    Public mylist As New ListBooks
    Public Sub load()

        Dim query As String = "select Issue_ID,Book_ID,Book_Title,Book_Author,Student_ID,Day_Of_Borrow,Day_Of_Return from issue"
        Dim adpt As New MySqlDataAdapter(query, con)
        Dim ds As New DataSet()
        adpt.Fill(ds, "Emp")
        DataGridView1.DataSource = ds.Tables(0)
        con.Close()
    End Sub


    Private Sub ListIssue_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        load()
    End Sub

    Private Sub BunifuTileButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuTileButton5.Click
        BookReturn.ShowDialog()
        load()

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Dim adapter As MySqlDataAdapter
        Dim ds As New DataSet

        If ComboBox1.Text = "Issue ID" Then
            Try
                con.Open()
                adapter = New MySqlDataAdapter("select Issue_ID,Book_ID,Book_Title,Book_Author,Student_ID,Day_Of_Borrow,Day_Of_Return from issue where Issue_ID like '%" & TextBox1.Text & "%'", con)
                adapter.Fill(ds)
                DataGridView1.DataSource = ds.Tables(0)
                con.Close()

            Catch ex As Exception

            End Try
        ElseIf ComboBox1.Text = "Book ID" Then
            Try
                con.Open()
                adapter = New MySqlDataAdapter("select Issue_ID,Book_ID,Book_Title,Book_Author,Student_ID,Day_Of_Borrow,Day_Of_Return from issue where Book_ID like '%" & TextBox1.Text & "%'", con)
                adapter.Fill(ds)
                DataGridView1.DataSource = ds.Tables(0)
                con.Close()

            Catch ex As Exception

            End Try

        ElseIf ComboBox1.Text = "Student ID" Then
            Try
                con.Open()
                adapter = New MySqlDataAdapter("select Issue_ID,Book_ID,Book_Title,Book_Author,Student_ID,Day_Of_Borrow,Day_Of_Return from issue where Student_ID like '%" & TextBox1.Text & "%'", con)
                adapter.Fill(ds)
                DataGridView1.DataSource = ds.Tables(0)
                con.Close()

            Catch ex As Exception

            End Try

        ElseIf ComboBox1.Text = "Book Title" Then
            Try
                con.Open()
                adapter = New MySqlDataAdapter("select Issue_ID,Book_ID,Book_Title,Book_Author,Student_ID,Day_Of_Borrow,Day_Of_Return from issue where Book_Title like '%" & TextBox1.Text & "%'", con)
                adapter.Fill(ds)
                DataGridView1.DataSource = ds.Tables(0)
                con.Close()

            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class