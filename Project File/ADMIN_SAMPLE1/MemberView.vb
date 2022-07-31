Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports System.IO

Public Class MemberView
    Public Property yes As Integer
    Dim str As String = "server=localhost; uid=root; password=; database=db_new_lms"
    Dim con As New MySqlConnection(str)
    Dim cmd As MySqlCommand
    Dim image_counter As Integer

   

    Private Sub MemberAdd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Query As String

        Dim read As MySqlDataReader
        Try
            con.Open()
            Query = "SELECT * FROM profile WHERE Student_ID = " & var_id & " "
            cmd = New MySqlCommand(Query, con)
            read = cmd.ExecuteReader

            While read.Read
                BunifuMetroTextbox1.Text = read.GetString("Student_ID")
                ComboBox1.Text = read.GetString("College")
                ComboBox2.Text = read.GetString("Course")
                ComboBox3.Text = read.GetString("Year")
                ComboBox4.Text = read.GetString("Gender")
                ComboBox5.Text = read.GetString("Civil_Status")
                BunifuMetroTextbox8.Text = read.GetString("First_Name")
                BunifuMetroTextbox9.Text = read.GetString("Last_Name")
                BunifuMetroTextbox10.Text = read.GetString("Middle_Name")
                BunifuMetroTextbox12.Text = read.GetString("Email")
                BunifuMetroTextbox11.Text = read.GetString("Contact_Number")

                BunifuMetroTextbox13.Text = read.GetString("str1")
                BunifuMetroTextbox14.Text = read.GetString("bar1")
                BunifuMetroTextbox15.Text = read.GetString("ct1")
                BunifuMetroTextbox16.Text = read.GetString("pro1")
                BunifuMetroTextbox17.Text = read.GetString("zip1")

                BunifuMetroTextbox22.Text = read.GetString("zip2")
                BunifuMetroTextbox21.Text = read.GetString("pro2")
                BunifuMetroTextbox20.Text = read.GetString("ct2")
                BunifuMetroTextbox19.Text = read.GetString("bar2")
                BunifuMetroTextbox18.Text = read.GetString("str2")
                Dim data As Byte() = DirectCast(read("image"), Byte())
                Dim ms As New MemoryStream(data)
                PictureBox1.Image = Image.FromStream(ms)
            End While
            read.Close()
            con.Close()
        Catch ex As Exception
            MsgBox("Encountered Error", MsgBoxStyle.Exclamation, "Error")
        End Try
    End Sub

    Private Sub BunifuThinButton22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuThinButton22.Click
        Me.Close()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BunifuThinButton21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuThinButton21.Click
        Dim cmd As MySqlCommand
        If BunifuMetroTextbox1.Text = Nothing And BunifuMetroTextbox8.Text = Nothing And BunifuMetroTextbox9.Text = Nothing And BunifuMetroTextbox10.Text = Nothing And ComboBox1.Text = Nothing And ComboBox2.Text = Nothing And ComboBox3.Text = Nothing And ComboBox4.Text = Nothing And ComboBox5.Text = Nothing And BunifuMetroTextbox11.Text = Nothing And BunifuMetroTextbox12.Text = Nothing And BunifuMetroTextbox13.Text = Nothing And BunifuMetroTextbox14.Text = Nothing And BunifuMetroTextbox15.Text = Nothing And BunifuMetroTextbox16.Text = Nothing And BunifuMetroTextbox17.Text = Nothing And BunifuMetroTextbox18.Text = Nothing And BunifuMetroTextbox19.Text = Nothing And BunifuMetroTextbox20.Text = Nothing And BunifuMetroTextbox21.Text = Nothing And BunifuMetroTextbox22.Text = Nothing Then
            MsgBox("Fill all fields", MsgBoxStyle.Information, "Note")
        Else
            If image_counter = 1 Then
                Try
                    con.Open()
                    cmd = con.CreateCommand()
                    cmd.CommandText = "update profile set College=@College, Course=@Course, Year=@Year, Civil_Status=@Civil_Status, First_Name=@First_Name, Last_Name=@Last_Name, Middle_Name=@Middle_Name, Contact_Number=@Contact_Number, Email=@Email, str1=@str1, bar1=@bar1, ct1=@ct1, pro1=@pro1, zip1=@zip1, str2=@str2, bar2=@bar2, ct2=@ct2, pro2=@pro2, zip2=@zip2, image=@image where Student_ID=@Student_ID;"
                    cmd.Parameters.AddWithValue("@Student_ID", BunifuMetroTextbox1.Text)
                    cmd.Parameters.AddWithValue("@College", ComboBox1.Text)
                    cmd.Parameters.AddWithValue("@Course", ComboBox2.Text)
                    cmd.Parameters.AddWithValue("@Year", ComboBox3.Text)
                    cmd.Parameters.AddWithValue("@Gender", ComboBox4.Text)
                    cmd.Parameters.AddWithValue("@Civil_Status", ComboBox5.Text)
                    cmd.Parameters.AddWithValue("@First_Name", BunifuMetroTextbox8.Text)
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
                    MsgBox("Data Updated!", vbInformation, "Note")
                    Me.Dispose()
                Catch ex As Exception
                    MsgBox("Encountered Error", MsgBoxStyle.Critical, "Error")
                    con.Close()
                End Try
                
            Else
                Try
                    con.Open()
                    cmd = con.CreateCommand()
                    cmd.CommandText = "update profile set College=@College, Course=@Course, Year=@Year, Civil_Status=@Civil_Status, First_Name=@First_Name, Last_Name=@Last_Name, Middle_Name=@Middle_Name, Contact_Number=@Contact_Number, Email=@Email, str1=@str1, bar1=@bar1, ct1=@ct1, pro1=@pro1, zip1=@zip1, str2=@str2, bar2=@bar2, ct2=@ct2, pro2=@pro2, zip2=@zip2 where Student_ID=@Student_ID;"
                    cmd.Parameters.AddWithValue("@Student_ID", BunifuMetroTextbox1.Text)
                    cmd.Parameters.AddWithValue("@College", ComboBox1.Text)
                    cmd.Parameters.AddWithValue("@Course", ComboBox2.Text)
                    cmd.Parameters.AddWithValue("@Year", ComboBox3.Text)
                    cmd.Parameters.AddWithValue("@Gender", ComboBox4.Text)
                    cmd.Parameters.AddWithValue("@Civil_Status", ComboBox5.Text)
                    cmd.Parameters.AddWithValue("@First_Name", BunifuMetroTextbox8.Text)
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
                    cmd.ExecuteNonQuery()
                    con.Close()
                    Me.Dispose()
                Catch ex As Exception
                    MsgBox("Encountered Error", MsgBoxStyle.Critical, "Error")
                    con.Close()
                End Try
            End If
        End If
        image_counter = 0
    End Sub

    Private Sub BunifuMetroTextbox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles BunifuMetroTextbox1.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 _
                AndAlso Asc(e.KeyChar) <> 46 And Not IsNumeric(e.KeyChar) Then

            e.Handled = True
        End If
    End Sub

    Private Sub BunifuMetroTextbox8KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles BunifuMetroTextbox8.KeyPress
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

   



    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub BunifuMetroTextbox1_OnValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuMetroTextbox1.OnValueChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            image_counter = 1
            PictureBox1.ImageLocation = OpenFileDialog1.FileName
        End If
    End Sub
End Class

