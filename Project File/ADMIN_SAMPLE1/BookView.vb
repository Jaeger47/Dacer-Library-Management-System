
Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic
Public Class BookView
    Dim str As String = "server=localhost; uid=root; password=; database=db_new_lms"
    Dim con As New MySqlConnection(str)
    Dim cmd As MySqlCommand
    Private Sub BookAdd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BunifuThinButton22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuThinButton22.Click
        Me.Close()
    End Sub

    Private Sub BunifuThinButton21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuThinButton21.Click
        If BunifuMetroTextbox1.Text = Nothing Or BunifuMetroTextbox2.Text = Nothing Or BunifuMetroTextbox3.Text = Nothing Or BunifuMetroTextbox4.Text = Nothing Or BunifuMetroTextbox5.Text = Nothing Or BunifuMetroTextbox6.Text = Nothing Or BunifuMetroTextbox7.Text = Nothing Or BunifuMetroTextbox8.Text = Nothing Then
            MsgBox("Fill all fields", MsgBoxStyle.Information, "Note")
        Else

            Dim read As MySqlDataReader

            Try
                con.Open()
                Dim Query As String
                Query = "update books set Book_Subject='" & BunifuMetroTextbox2.Text & "',Book_Title='" & BunifuMetroTextbox3.Text & "',Book_Author='" & BunifuMetroTextbox4.Text & "',Book_Publisher='" & BunifuMetroTextbox5.Text & "',Edition_Number='" & BunifuMetroTextbox6.Text & "',Number_of_Copies='" & BunifuMetroTextbox7.Text & "',Shelf_No='" & BunifuMetroTextbox8.Text & "' where Book_ID='" & BunifuMetroTextbox1.Text & "'"
                cmd = New MySqlCommand(Query, con)
                read = cmd.ExecuteReader
                MsgBox("Data Updated!", vbInformation, "Note")
                Me.Dispose()
            Catch ex As Exception
                MsgBox("Error")
            End Try
        End If
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint
        
    End Sub

    Private Sub Bookview_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Query As String

        Dim read As MySqlDataReader
        Try
            con.Open()
            Query = "SELECT * FROM books WHERE Book_ID = " & var_book_id & " "
            cmd = New MySqlCommand(Query, con)
            read = cmd.ExecuteReader
            Dim vars As String

            While read.Read
                vars = read.GetString("Book_ID")
                Convert.ToInt32(vars)
                BunifuMetroTextbox1.Text = vars
                BunifuMetroTextbox2.Text = read.GetString("Book_Subject")
                BunifuMetroTextbox3.Text = read.GetString("Book_Title")
                BunifuMetroTextbox4.Text = read.GetString("Book_Author")

                BunifuMetroTextbox5.Text = read.GetString("Book_Publisher")
                BunifuMetroTextbox6.Text = read.GetString("Edition_Number")
                BunifuMetroTextbox7.Text = read.GetString("Number_of_Copies")
                BunifuMetroTextbox8.Text = read.GetString("Shelf_No")



            End While
            con.Close()
        Catch ex As Exception
            MsgBox("Encountered Error", MsgBoxStyle.Exclamation, "Error")
        End Try
    End Sub


End Class