Imports MySql.Data.MySqlClient
Public Class MemberUpdate
    Dim MySqlConn As MySqlConnection
    Dim cmd As MySqlCommand
    Private Sub MemberUpdate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BunifuThinButton22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuThinButton22.Click
        Me.Close()
    End Sub

    Private Sub BunifuThinButton21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuThinButton21.Click

        'If BunifuMetroTextbox1.Text = Nothing Or ComboBox1.Text = Nothing Or ComboBox2.Text = Nothing Or ComboBox3.Text = Nothing Or ComboBox4.Text = Nothing Or ComboBox5.Text = Nothing Or BunifuMetroTextbox8.Text = Nothing Or BunifuMetroTextbox9.Text = Nothing Or BunifuMetroTextbox10.Text = Nothing Or BunifuMetroTextbox11.Text = Nothing Or BunifuMetroTextbox12.Text = Nothing Or BunifuMetroTextbox13.Text = Nothing Or BunifuMetroTextbox14.Text = Nothing Or BunifuMetroTextbox15.Text = Nothing Or BunifuMetroTextbox16.Text = Nothing Or BunifuMetroTextbox17.Text = Nothing Or BunifuMetroTextbox18.Text = Nothing Or BunifuMetroTextbox19.Text = Nothing Or BunifuMetroTextbox20.Text = Nothing Or BunifuMetroTextbox21.Text = Nothing Or BunifuMetroTextbox22.Text = Nothing Or BunifuMetroTextbox23.Text = Nothing Then
        'MsgBox("Please Input All Fields", MsgBoxStyle.Information, "Note")
        ' Else
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "Server=localhost;userid=root;password=;database=db_new_lms"
        Dim read As MySqlDataReader

        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "update profile set College='" & ComboBox1.Text & "',Course='" & ComboBox2.Text & "',Year='" & ComboBox3.Text & "',Gender='" & ComboBox4.Text & "',Civil_Status='" & ComboBox5.Text & "',First_Name='" & BunifuMetroTextbox8.Text & "',Last_Name='" & BunifuMetroTextbox9.Text & "',Middle_Name='" & BunifuMetroTextbox10.Text & "',Contact_Number='" & BunifuMetroTextbox11.Text & "',Email='" & BunifuMetroTextbox12.Text & "',str1='" & BunifuMetroTextbox13.Text & "',bar1='" & BunifuMetroTextbox14.Text & "',ct1='" & BunifuMetroTextbox15.Text & "',pro1='" & BunifuMetroTextbox16.Text & "',zip1='" & BunifuMetroTextbox17.Text & "',str2='" & BunifuMetroTextbox22.Text & "',bar2='" & BunifuMetroTextbox21.Text & "',ct2='" & BunifuMetroTextbox20.Text & "',pro2='" & BunifuMetroTextbox19.Text & "',zip2='" & BunifuMetroTextbox18.Text & "' where Student_ID='" & BunifuMetroTextbox1.Text & "'"
            cmd = New MySqlCommand(Query, MySqlConn)
            read = cmd.ExecuteReader
            Me.Dispose()
        Catch ex As Exception
            MsgBox("Error")
        End Try
        ' End If
    End Sub
End Class