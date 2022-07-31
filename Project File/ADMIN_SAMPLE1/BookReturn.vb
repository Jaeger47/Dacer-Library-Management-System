Imports MySql.Data.MySqlClient
Public Class BookReturn
    Dim str As String = "server=localhost; uid=root; password=; database=db_new_lms"
    Dim con As New MySqlConnection(str)

    Dim day_today As Integer
    Dim day_borrow As Integer
    Dim Fines As Integer
    Dim returns As Integer
    Dim cmd As MySqlCommand
    Dim reader As MySqlDataReader
    Private Sub BookReturn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        day_today = Date.Now.ToString("dd")


    End Sub

    Private Sub BunifuThinButton22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuThinButton22.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Dim Query As String

        Dim cmd As MySqlCommand

        Dim read As MySqlDataReader

        Try
            con.Open()
            Query = "SELECT * FROM issue WHERE Issue_ID = " & TextBox1.Text & " "
            cmd = New MySqlCommand(Query, con)
            read = cmd.ExecuteReader

            While read.Read
                'TextBox1.Text = read.GetString("Issue_ID")
                BunifuMetroTextbox1.Text = read.GetString("Book_ID")
                BunifuMetroTextbox2.Text = read.GetString("Student_ID")
                day_borrow = read.GetString("Day")
                returns = read.GetString("day_return")
            End While
            con.Close()

            Dim TestNumber1 As Integer
            TestNumber1 = Convert.ToInt32(TextBox1.Text)
            var_del = TestNumber1


        Catch ex As Exception
            con.Close()
        End Try

        If returns = day_today And returns Then
            BunifuMetroTextbox3.Text = "0"
        Else
            Fines = (day_today - day_borrow) * 5 - 5
            BunifuMetroTextbox3.Text = Fines
        End If

        If Fines < 0 Then
            BunifuMetroTextbox3.Text = 0
        Else

        End If

        

    End Sub

    Private Sub BunifuMetroTextbox3_OnValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuMetroTextbox3.OnValueChanged

    End Sub

    Private Sub BunifuThinButton21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuThinButton21.Click
        If TextBox1.Text = Nothing Or BunifuMetroTextbox1.Text = Nothing Or BunifuMetroTextbox2.Text = Nothing Or BunifuMetroTextbox3.Text = Nothing Then
            MsgBox("Fill all fields", MsgBoxStyle.Information, "Note")
        Else

            Dim Queryer As String
            Dim var As Integer
            Try
                con.Open()
                Queryer = "SELECT * FROM books WHERE Book_ID = " & BunifuMetroTextbox1.Text & " "
                cmd = New MySqlCommand(Queryer, con)
                reader = cmd.ExecuteReader
                Dim var_add As String
                Dim var_min As Integer


                While reader.Read
                    var_add = reader.GetString("Number_of_Copies")
                    Convert.ToInt32(var_add)
                    var_min = 1
                    'Convert.ToInt32(var_min)
                    var = var_add + var_min
                    Convert.ToString(var)

                End While
                con.Close()


                If var < 0 Then
                    MsgBox("Invalid Value", MsgBoxStyle.Exclamation, "Note")
                    con.Close()
                Else
                    Try
                        con.Open()
                        cmd = con.CreateCommand()
                        cmd.CommandText = "update books set Number_of_Copies='" & var & "' where Book_ID='" & BunifuMetroTextbox1.Text & "'"
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
            con.Close()
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''



            Dim cmder As MySqlCommand
            con.Open()
            Try
                cmder = con.CreateCommand()
                cmder.CommandText = "delete from issue where Issue_ID=@Issue_ID;"
                cmder.Parameters.AddWithValue("@Issue_ID", var_del)
                cmder.ExecuteNonQuery()
                con.Close()
                MsgBox("Book Returned!", vbInformation, "Note")
                Me.Dispose()
            Catch ex As Exception
                MsgBox("Not Found", vbInformation, "Note")
            End Try


            Me.Close()
            'BookReturnCon.ShowDialog()

        End If
    End Sub

    Private Sub BunifuMetroTextbox1_OnValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuMetroTextbox1.OnValueChanged

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class