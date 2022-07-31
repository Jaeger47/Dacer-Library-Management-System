Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic
Public Class ListMembers
    Dim str As String = "server=localhost; uid=root; password=; database=db_new_lms"
    Dim con As New MySqlConnection(Str)
    Dim Setting As New My.MySettings()
    Dim ID As String

    Public Sub load()

        Dim query As String = "select Student_ID, College, Course, Year, Gender, Civil_Status, First_Name, Last_Name, Middle_Name, Email, Contact_Number from profile"
        Dim adpt As New MySqlDataAdapter(query, con)
        Dim ds As New DataSet()
        adpt.Fill(ds, "Emp")
        DataGridView1.DataSource = ds.Tables(0)
        con.Close()
    End Sub
    Private Sub ListMembers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        load()
    End Sub

    Private Sub BunifuTileButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuTileButton1.Click
        MemberAdd.ShowDialog()
        load()
    End Sub

    Private Sub BunifuTileButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'MemberUpdate.ShowDialog()
        load()
    End Sub

    Private Sub BunifuTileButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuTileButton2.Click
        MemberRemove.ShowDialog()
        load()
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        Try
            var_id = row.Cells(0).Value.ToString
            MemberView.ShowDialog()
            load()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub BunifuTileButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MemberUpdate.ShowDialog()
    End Sub

    Private Sub BunifuTileButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim obj As New MemberView
            Dim row As DataGridViewRow
            row = Me.DataGridView1.Rows(e.RowIndex)
            ID = row.Cells("Student_ID").Value.ToString
            obj.yes = ID

        End If
    End Sub

    Private Sub BunifuTileButton3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        load()
    End Sub

    Private Sub BunifuMaterialTextbox1_OnValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Dim adapter As MySqlDataAdapter
        Dim ds As New DataSet

        If ComboBox1.Text = "ID Number" Then
            Try
                con.Open()
                adapter = New MySqlDataAdapter("select * from profile where Student_ID like '%" & TextBox1.Text & "%'", con)
                adapter.Fill(ds)
                DataGridView1.DataSource = ds.Tables(0)
                con.Close()

            Catch ex As Exception

            End Try

        ElseIf ComboBox1.Text = "Last Name" Then
            Try
                con.Open()
                adapter = New MySqlDataAdapter("select * from profile where Last_Name like '%" & TextBox1.Text & "%'", con)
                adapter.Fill(ds)
                DataGridView1.DataSource = ds.Tables(0)
                con.Close()

            Catch ex As Exception

            End Try

        ElseIf ComboBox1.Text = "First Name" Then
            Try
                con.Open()
                adapter = New MySqlDataAdapter("select * from profile where First_Name like '%" & TextBox1.Text & "%'", con)
                adapter.Fill(ds)
                DataGridView1.DataSource = ds.Tables(0)
                con.Close()

            Catch ex As Exception

            End Try

        ElseIf ComboBox1.Text = "Middle Name" Then
            Try
                con.Open()
                adapter = New MySqlDataAdapter("select * from profile where Middle_Name like '%" & TextBox1.Text & "%'", con)
                adapter.Fill(ds)
                DataGridView1.DataSource = ds.Tables(0)
                con.Close()

            Catch ex As Exception

            End Try

        End If

    End Sub
End Class