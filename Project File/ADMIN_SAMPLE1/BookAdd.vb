
Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic
Public Class BookAdd
    Dim str As String = "server=localhost; uid=root; password=; database=db_new_lms"
    Dim con As New MySqlConnection(str)
    Private Sub BookAdd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BunifuThinButton22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuThinButton22.Click
        Me.Dispose()
    End Sub

    Private Sub BunifuThinButton21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuThinButton21.Click
        If BunifuMetroTextbox1.Text = Nothing And BunifuMetroTextbox2.Text = Nothing And BunifuMetroTextbox3.Text = Nothing And BunifuMetroTextbox4.Text = Nothing And BunifuMetroTextbox5.Text = Nothing And BunifuMetroTextbox7.Text = Nothing And BunifuMetroTextbox8.Text = Nothing Then
            MsgBox("Fill all fields", MsgBoxStyle.Information, "Note")
        Else
            Dim cmd As MySqlCommand
            Try
                con.Open()
                cmd = con.CreateCommand()
                cmd.CommandText = "Insert into books(Book_ID,Book_Subject,Book_Title,Book_Author,Book_Publisher,Edition_Number,Number_of_Copies,Shelf_No)values(@Book_ID,@Book_Subject,@Book_Title,@Book_Author,@Book_Publisher,@Edition_Number,@Number_of_Copies,@Shelf_No);"
                cmd.Parameters.AddWithValue("@Book_ID", BunifuMetroTextbox1.Text)
                cmd.Parameters.AddWithValue("@Book_Subject", BunifuMetroTextbox2.Text)
                cmd.Parameters.AddWithValue("@Book_Title", BunifuMetroTextbox3.Text)
                cmd.Parameters.AddWithValue("@Book_Author", BunifuMetroTextbox4.Text)
                cmd.Parameters.AddWithValue("@Book_Publisher", BunifuMetroTextbox5.Text)
                cmd.Parameters.AddWithValue("@Edition_Number", BunifuMetroTextbox6.Text)
                cmd.Parameters.AddWithValue("@Number_of_Copies", BunifuMetroTextbox7.Text)
                cmd.Parameters.AddWithValue("@Shelf_No", BunifuMetroTextbox8.Text)
                cmd.ExecuteNonQuery()
                con.Close()
                Me.Dispose()

            Catch ex As Exception
                MsgBox("Encountered Error", MsgBoxStyle.Critical, "Error")
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

    Private Sub BunifuMetroTextbox6_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles BunifuMetroTextbox6.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 _
                AndAlso Asc(e.KeyChar) <> 46 And Not IsNumeric(e.KeyChar) Then

            e.Handled = True
        End If
    End Sub

    Private Sub BunifuMetroTextbox7_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles BunifuMetroTextbox7.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 _
                AndAlso Asc(e.KeyChar) <> 46 And Not IsNumeric(e.KeyChar) Then

            e.Handled = True
        End If
    End Sub

    Private Sub BunifuMetroTextbox8_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles BunifuMetroTextbox8.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 _
                AndAlso Asc(e.KeyChar) <> 46 And Not IsNumeric(e.KeyChar) Then

            e.Handled = True
        End If
    End Sub


End Class