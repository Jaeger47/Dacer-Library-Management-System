Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic
Public Class ListBooks
    Dim str As String = "server=localhost; uid=root; password=; database=db_new_lms"
    Dim con As New MySqlConnection(str)
    Dim Book_ID As String
    Public Sub loads()

        Dim query As String = "select Book_ID, Book_Subject, Book_Title, Book_Author, Book_Publisher, Edition_Number, Number_of_Copies, Shelf_No from books"
        Dim adpt As New MySqlDataAdapter(query, con)
        Dim ds As New DataSet()
        adpt.Fill(ds, "Emp")
        DataGridView1.DataSource = ds.Tables(0)
        con.Close()
    End Sub

    Private Sub BunifuTileButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuTileButton1.Click
        BookAdd.ShowDialog()
        loads()
    End Sub

    Private Sub BunifuTileButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuTileButton2.Click
        removemain.ShowDialog()
        loads()
    End Sub

    Private Sub BunifuTileButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BookUpdate.ShowDialog()
        loads()
    End Sub

    Private Sub BunifuTileButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuTileButton4.Click
        BookBorrow.ShowDialog()
        loads()
        Form1.loader()
    End Sub

    Private Sub BunifuTileButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BookReturn.ShowDialog()
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
       
    End Sub
    Private Sub ListBooks_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loads()


    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Dim adapter As MySqlDataAdapter
        Dim ds As New DataSet

        If ComboBox1.Text = "ID Number" Then
            Try
                con.Open()
                adapter = New MySqlDataAdapter("select * from books where Book_ID like '%" & TextBox1.Text & "%'", con)
                adapter.Fill(ds)
                DataGridView1.DataSource = ds.Tables(0)
                con.Close()

            Catch ex As Exception

            End Try

        ElseIf ComboBox1.Text = "Subject" Then
            Try
                con.Open()
                adapter = New MySqlDataAdapter("select * from books where Book_Subject like '%" & TextBox1.Text & "%'", con)
                adapter.Fill(ds)
                DataGridView1.DataSource = ds.Tables(0)
                con.Close()

            Catch ex As Exception

            End Try

        ElseIf ComboBox1.Text = "Name" Then
            Try
                con.Open()
                adapter = New MySqlDataAdapter("select * from books where Book_Title like '%" & TextBox1.Text & "%'", con)
                adapter.Fill(ds)
                DataGridView1.DataSource = ds.Tables(0)
                con.Close()

            Catch ex As Exception

            End Try
        End If

    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        Try
            var_book_id = row.Cells(0).Value.ToString
            BookView.ShowDialog()
            loads()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class