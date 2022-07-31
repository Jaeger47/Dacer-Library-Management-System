Imports MySql.Data.MySqlClient
Public Class BookBorrow
    Dim str As String = "server=localhost; uid=root; password=; database=db_new_lms"
    Dim con As New MySqlConnection(str)
    Dim cmd As MySqlCommand

    Dim Date_borrow As String
    Dim Date_return As String

    Dim book_t As String
    Dim book_a As String
    Dim book_total As Integer

    

    Private Sub BookBorrow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim day_today As Integer
        Dim month_today As Integer
        Dim year_today As Integer
        day_today = Date.Now.ToString("dd")
        month_today = Date.Now.ToString("MM")
        year_today = Date.Now.ToString("yyyy")
        ComboBox1.Text = day_today
        ComboBox2.Text = month_today
        ComboBox3.Text = year_today
    End Sub

    Private Sub BunifuThinButton22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuThinButton22.Click
        Me.Close()
    End Sub

    Private Sub BunifuThinButton21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuThinButton21.Click
        If BunifuMetroTextbox1.Text = Nothing Or BunifuMetroTextbox2.Text = Nothing Or ComboBox1.Text = Nothing Or ComboBox2.Text = Nothing Or ComboBox3.Text = Nothing Or TextBox4.Text = Nothing Or TextBox5.Text = Nothing Or TextBox6.Text = Nothing Then
            MsgBox("Fill all fields", MsgBoxStyle.Information, "Note")
        Else

            Dim return_day As Integer
            return_day = TextBox4.Text
            Dim cmd1 As New MySqlCommand("SELECT * FROM books WHERE Book_ID = '" & BunifuMetroTextbox1.Text & "'", con)
            Dim cmd2 As New MySqlCommand("SELECT * FROM profile WHERE Student_ID = '" & BunifuMetroTextbox2.Text & "'", con)
            Dim Read As MySqlDataReader
            '''''''''''''''''''''''''''''''''''

            Dim Queryers As String
            Try
                con.Open()
                Queryers = "SELECT * FROM books WHERE Book_ID = " & BunifuMetroTextbox1.Text & " "
                cmd = New MySqlCommand(Queryers, con)
                Read = cmd.ExecuteReader

                While Read.Read
                    book_total = Read.GetString("Number_of_Copies")
                    Convert.ToInt32(book_total)
                End While
                Read.Close()
                con.Close()
            Catch ex As Exception
                MsgBox("Encountered Error", MsgBoxStyle.Exclamation, "Error")
                con.Close()
            End Try


            ''''''''''''''''''''''''''''''''''''
            If book_total < 0 Then

                MsgBox("No more book copies", MsgBoxStyle.Information, "Note")
                '''''''''''''''''''''''''''''''''''
            Else
                con.Open()
                Read = cmd1.ExecuteReader
                If Read.HasRows Then
                    con.Close()
                    con.Open()
                    Read = cmd2.ExecuteReader
                    If Read.HasRows Then
                        Date_borrow = ComboBox1.Text + "-" + ComboBox2.Text + "-" + ComboBox3.Text

                        Date_return = TextBox4.Text + "-" + TextBox5.Text + "-" + TextBox6.Text

                        bor_id = BunifuMetroTextbox2.Text
                        bor_book_id = BunifuMetroTextbox1.Text
                        bor_b = Date_borrow
                        bor_r = Date_return
                        'BookBorrowCon.ShowDialog()
                        Me.Dispose()
                    Else
                        MsgBox("Book or User Not Fount", MsgBoxStyle.Information, "Note")

                    End If
                Else
                    MsgBox("Book or User Not Fount", MsgBoxStyle.Information, "Note")
                End If
                con.Close()

                '''''''''''''''''''''''''''''''''''''''''
                Dim Query As String
                Try
                    con.Open()
                    Query = "SELECT * FROM books WHERE Book_ID = " & bor_book_id & " "
                    cmd = New MySqlCommand(Query, con)
                    Read = cmd.ExecuteReader

                    While Read.Read
                        book_t = Read.GetString("Book_Title")
                        book_a = Read.GetString("Book_Author")
                    End While
                    Read.Close()
                    con.Close()
                Catch ex As Exception
                    MsgBox("Encountered Error", MsgBoxStyle.Exclamation, "Error")
                    con.Close()
                End Try
                '''''''''''''''''''''''''''''''''''''''''

                'Dim cmd As MySqlCommand
                ' Dim ran As Integer
                '  ran = CInt(Math.Ceiling(Rnd() * 255)) + 1
                Try
                    con.Open()
                    cmd = con.CreateCommand()
                    cmd.CommandText = "Insert into issue(Book_ID,Student_ID,Day_Of_Borrow,Day_Of_Return,Book_Title,Book_Author,Day,day_return)values(@Book_ID,@Student_ID,@Day_Of_Borrow,@Day_Of_Return,@Book_Title,@Book_Author,@Day,@day_return);"
                    cmd.Parameters.AddWithValue("@Book_ID", bor_book_id)
                    cmd.Parameters.AddWithValue("@Student_ID", bor_id)
                    cmd.Parameters.AddWithValue("@Day_Of_Borrow", bor_b)
                    cmd.Parameters.AddWithValue("@Day_Of_Return", bor_r)
                    cmd.Parameters.AddWithValue("@Book_Title", book_t)
                    cmd.Parameters.AddWithValue("@Book_Author", book_a)
                    cmd.Parameters.AddWithValue("@Day", ComboBox1.SelectedItem)
                    cmd.Parameters.AddWithValue("@day_return", return_day)




                    cmd.ExecuteNonQuery()
                    ListIssue.load()
                    MsgBox("Book Borrowed!", vbInformation, "Note")
                    con.Close()
                    Me.Dispose()

                Catch ex As Exception
                    MsgBox("Encountered Error", MsgBoxStyle.Critical, "Error")
                    con.Close()
                End Try
                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                Dim Queryer As String
                Dim var As Integer
                Try
                    con.Open()
                    Queryer = "SELECT * FROM books WHERE Book_ID = " & bor_book_id & " "
                    cmd = New MySqlCommand(Queryer, con)
                    Read = cmd.ExecuteReader
                    Dim var_add As String
                    Dim var_min As String


                    While Read.Read
                        var_add = Read.GetString("Number_of_Copies")
                        Convert.ToInt32(var_add)
                        var_min = 1
                        Convert.ToInt32(var_min)
                        var = var_add - var_min
                        Convert.ToString(var)

                    End While
                    con.Close()
                    var_book_add = var

                    If var < 0 Then
                        MsgBox("Invalid Value", MsgBoxStyle.Exclamation, "Note")
                        con.Close()
                    Else
                        Try
                            con.Open()
                            cmd = con.CreateCommand()
                            cmd.CommandText = "update books set Number_of_Copies='" & var_book_add & "' where Book_ID='" & bor_book_id & "'"
                            cmd.ExecuteNonQuery()
                            con.Close()
                            Me.Dispose()
                        Catch ex As Exception
                            MsgBox("Encountered Error", MsgBoxStyle.Critical, "Error")
                            con.Close()
                        End Try
                        con.Close()
                        Me.Dispose()
                    End If

                Catch ex As Exception
                    MsgBox("Encountered Error", MsgBoxStyle.Exclamation, "Error")
                    con.Close()

                End Try
                '''''''''''''''''''''''''''''''''
                '''''''''''''''''''''''''''''''''


                ''''''''''''''''''''''''''''''''''''
                ''''''''''''''''''''''''''''''''''''
            End If
        End If
        Convert.ToInt32(ComboBox1.SelectedItem)

        var_days_fines = ComboBox1.SelectedItem
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



    Private Sub ComboBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        var_days = ComboBox1.Text + 1
        TextBox4.Text = var_days
        Dim temp_day As String = TextBox4.Text
        Convert.ToInt32(temp_day)
        If var_days = 31 Then
            temp_day = temp_day - 30
            TextBox4.Text = temp_day
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        var_months = ComboBox2.Text
        TextBox5.Text = var_months
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        var_years = ComboBox3.Text
        TextBox6.Text = var_years
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class