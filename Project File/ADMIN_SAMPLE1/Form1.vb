Imports MySql.Data.MySqlClient
Public Class Form1
    Dim str As String = "server=localhost; uid=root; password=; database=db_new_lms"
    Dim con As New MySqlConnection(str)

    Public mylist As New ListBooks
    Public mylistMember As New ListMembers
    Public mylistIssue As New ListIssue

    Public Sub loader()

        Dim query As String = "select Issue_ID,Book_ID,Book_Title,Book_Author,Student_ID,Day_Of_Borrow,Day_Of_Return from issue"
        Dim adpt As New MySqlDataAdapter(query, con)
        Dim ds As New DataSet()
        adpt.Fill(ds, "Emp")
        mylistIssue.DataGridView1.DataSource = ds.Tables(0)
        con.Close()
    End Sub


    Public Sub loader2()

        Dim query As String = "select Book_ID, Book_Subject, Book_Title, Book_Author, Book_Publisher, Edition_Number, Number_of_Copies, Shelf_No from books"
        Dim adpt As New MySqlDataAdapter(query, con)
        Dim ds As New DataSet()
        adpt.Fill(ds, "Emp")
        mylist.DataGridView1.DataSource = ds.Tables(0)
        con.Close()
    End Sub

    Public Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mylist = New ListBooks
        mylistMember = New ListMembers
        mylistIssue = New ListIssue

        mylist.TopLevel = False
        mylistMember.TopLevel = False
        mylistIssue.TopLevel = False

        mylist.Visible = True
        mylistMember.Visible = False
        mylistIssue.Visible = False

        workAreaPanel.Controls.Add(mylist)
        workAreaPanel.Controls.Add(mylistMember)
        workAreaPanel.Controls.Add(mylistIssue)

    End Sub

    Private Sub BunifuImageButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuImageButton1.Click
        End
    End Sub

    Public Sub btnListBook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListBook.Click
        loader2()
        mylist.TopLevel = False
        mylistMember.TopLevel = False
        mylistIssue.TopLevel = False

        mylist.Visible = True
        mylistMember.Visible = False
        mylistIssue.Visible = False

        workAreaPanel.Controls.Add(mylist)
        workAreaPanel.Controls.Add(mylistMember)
        workAreaPanel.Controls.Add(mylistIssue)
    End Sub


    Public Sub btnListMember_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListMember.Click
        mylist.TopLevel = False
        mylistMember.TopLevel = False
        mylistIssue.TopLevel = False

        mylist.Visible = False
        mylistMember.Visible = True
        mylistIssue.Visible = False

        workAreaPanel.Controls.Add(mylist)
        workAreaPanel.Controls.Add(mylistMember)
        workAreaPanel.Controls.Add(mylistIssue)
    End Sub

    Public Sub btnListIssue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListIssue.Click
        loader()
        mylist.TopLevel = False
        mylistMember.TopLevel = False
        mylistIssue.TopLevel = False

        mylist.Visible = False
        mylistMember.Visible = False
        mylistIssue.Visible = True

        workAreaPanel.Controls.Add(mylist)
        workAreaPanel.Controls.Add(mylistMember)
        workAreaPanel.Controls.Add(mylistIssue)
    End Sub

    Private Sub workAreaPanel_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles workAreaPanel.Paint

    End Sub

    Private Sub Panel4_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class
