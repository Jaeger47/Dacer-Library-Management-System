Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic
Public Class MemberAdd
    Dim str As String = "server=localhost; uid=root; password=; database=db_new_lms"
    Dim con As New MySqlConnection(str)

    Private Sub MemberAdd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
   

    Private Sub BunifuThinButton22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuThinButton22.Click
        Me.Dispose()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BunifuThinButton21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuThinButton21.Click
        If BunifuMetroTextbox1.Text = Nothing Or BunifuMetroTextbox5.Text = Nothing Or BunifuMetroTextbox9.Text = Nothing Or BunifuMetroTextbox10.Text = Nothing Or ComboBox1.Text = Nothing Or ComboBox2.Text = Nothing Or ComboBox3.Text = Nothing Or ComboBox4.Text = Nothing Or ComboBox5.Text = Nothing Or BunifuMetroTextbox11.Text = Nothing Or BunifuMetroTextbox12.Text = Nothing Or BunifuMetroTextbox13.Text = Nothing Or BunifuMetroTextbox14.Text = Nothing Or BunifuMetroTextbox15.Text = Nothing Or BunifuMetroTextbox16.Text = Nothing Or BunifuMetroTextbox17.Text = Nothing Or BunifuMetroTextbox18.Text = Nothing Or BunifuMetroTextbox19.Text = Nothing Or BunifuMetroTextbox20.Text = Nothing Or BunifuMetroTextbox21.Text = Nothing Or BunifuMetroTextbox22.Text = Nothing Then

            MsgBox("Fill all fields", MsgBoxStyle.Information, "Note")
        Else

            Dim cmd As MySqlCommand

            Try
                con.Open()
                cmd = con.CreateCommand()
                cmd.CommandText = "Insert into profile(Student_ID,College,Course,Year,Gender,Civil_Status,First_Name,Last_Name,Middle_Name,Email,Contact_Number,str1,bar1,ct1,pro1,zip1,str2,bar2,ct2,pro2,zip2,image)values(@Student_ID,@College,@Course,@Year,@Gender,@Civil_Status,@First_Name,@Last_Name,@Middle_Name,@Email,@Contact_Number,@str1,@bar1,@ct1,@pro1,@zip1,@str2,@bar2,@ct2,@pro2,@zip2,@image);"
                cmd.Parameters.AddWithValue("@Student_ID", BunifuMetroTextbox1.Text)
                cmd.Parameters.AddWithValue("@College", ComboBox1.Text)
                cmd.Parameters.AddWithValue("@Course", ComboBox2.Text)
                cmd.Parameters.AddWithValue("@Year", ComboBox3.Text)
                cmd.Parameters.AddWithValue("@Gender", ComboBox4.Text)
                cmd.Parameters.AddWithValue("@Civil_Status", ComboBox5.Text)
                cmd.Parameters.AddWithValue("@First_Name", BunifuMetroTextbox5.Text)
                cmd.Parameters.AddWithValue("@Last_Name", BunifuMetroTextbox9.Text)
                cmd.Parameters.AddWithValue("@Middle_Name", BunifuMetroTextbox10.Text)
                cmd.Parameters.AddWithValue("@Email", BunifuMetroTextbox12.Text)
                cmd.Parameters.AddWithValue("@Contact_Number", BunifuMetroTextbox11.Text)
                cmd.Parameters.AddWithValue("@str1", BunifuMetroTextbox13.Text)
                cmd.Parameters.AddWithValue("@bar1", BunifuMetroTextbox14.Text)
                cmd.Parameters.AddWithValue("@ct1", BunifuMetroTextbox15.Text)
                cmd.Parameters.AddWithValue("@pro1", BunifuMetroTextbox16.Text)
                cmd.Parameters.AddWithValue("@zip1", BunifuMetroTextbox17.Text)
                cmd.Parameters.AddWithValue("@str2", BunifuMetroTextbox18.Text)
                cmd.Parameters.AddWithValue("@bar2", BunifuMetroTextbox19.Text)
                cmd.Parameters.AddWithValue("@ct2", BunifuMetroTextbox20.Text)
                cmd.Parameters.AddWithValue("@pro2", BunifuMetroTextbox21.Text)
                cmd.Parameters.AddWithValue("@zip2", BunifuMetroTextbox22.Text)
                cmd.Parameters.AddWithValue("@image", IO.File.ReadAllBytes(OpenFileDialog1.FileName))
                cmd.ExecuteNonQuery()
                con.Close()
                MsgBox("Data Added!", vbInformation, "Note")
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

    Private Sub BunifuMetroTextbox5KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles BunifuMetroTextbox5.KeyPress
        If (Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 And Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122) And Not Asc(e.KeyChar) = "8" And Not Asc(e.KeyChar) = "32" Then
            e.Handled = True
        End If
    End Sub

    Private Sub BunifuMetroTextbox9KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 And Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122) And Not Asc(e.KeyChar) = "8" And Not Asc(e.KeyChar) = "32" Then
            e.Handled = True
        End If
    End Sub

    Private Sub BunifuMetroTextbox10KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles BunifuMetroTextbox10.KeyPress
        If (Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 And Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122) And Not Asc(e.KeyChar) = "8" And Not Asc(e.KeyChar) = "32" Then
            e.Handled = True
        End If
    End Sub

    Private Sub BunifuMetroTextbox11KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles BunifuMetroTextbox11.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 _
                AndAlso Asc(e.KeyChar) <> 46 And Not IsNumeric(e.KeyChar) Then

            e.Handled = True
        End If
    End Sub

    Private Sub BunifuMetroTextbox17_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles BunifuMetroTextbox17.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 _
                AndAlso Asc(e.KeyChar) <> 46 And Not IsNumeric(e.KeyChar) Then

            e.Handled = True
        End If
    End Sub

    Private Sub BunifuMetroTextbox18_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles BunifuMetroTextbox18.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 _
                AndAlso Asc(e.KeyChar) <> 46 And Not IsNumeric(e.KeyChar) Then

            e.Handled = True
        End If
    End Sub

    Sub BunifuThinButton23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub

    Private Sub BunifuMetroTextbox8_OnValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.ImageLocation = OpenFileDialog1.FileName
        End If
    End Sub
End Class

