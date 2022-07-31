Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic
Public Class BookRemove
    Dim str As String = "server=localhost; uid=root; password=; database=db_new_lms"
    Dim con As New MySqlConnection(str)
    Dim cmd As MySqlCommand
    Dim command As MySqlCommand


    Private Sub BookRemove_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BunifuThinButton22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuThinButton22.Click
        Me.Close()
    End Sub

    Private Sub BunifuThinButton21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuThinButton21.Click
        If BunifuMetroTextbox1.Text = Nothing Or BunifuMetroTextbox2.Text = Nothing Then
            MsgBox("Fill all fields", MsgBoxStyle.Information, "Note")
        Else

            Dim Query As String
            Dim var As Integer
            Dim read As MySqlDataReader
            Try
                con.Open()
                Query = "SELECT * FROM books WHERE Book_ID = " & BunifuMetroTextbox1.Text & " "
                cmd = New MySqlCommand(Query, con)
                read = cmd.ExecuteReader
                Dim var_add As String
                Dim var_min As String


                While read.Read
                    var_add = read.GetString("Number_of_Copies")
                    Convert.ToInt32(var_add)
                    var_min = BunifuMetroTextbox2.Text
                    Convert.ToInt32(var_min)
                    var = var_add - var_min
                    Convert.ToString(var)

                End While
                var_book_add = var
                vars_id = BunifuMetroTextbox1.Text
                If var < 0 Then
                    MsgBox("Invalid Value", MsgBoxStyle.Exclamation, "Note")
                    con.Close()
                Else
                    BookRemoveCopyCon.ShowDialog()
                    con.Close()
                    Me.Dispose()
                End If

            Catch ex As Exception
                MsgBox("Encountered Error", MsgBoxStyle.Exclamation, "Error")
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

    Private Sub BunifuMetroTextbox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles BunifuMetroTextbox2.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 _
                AndAlso Asc(e.KeyChar) <> 46 And Not IsNumeric(e.KeyChar) Then

            e.Handled = True
        End If
    End Sub

    Private Sub BunifuMetroTextbox1_OnValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuMetroTextbox1.OnValueChanged

    End Sub
End Class