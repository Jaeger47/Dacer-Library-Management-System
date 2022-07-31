
Public Class removemain



    Private Sub removemain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BunifuThinButton22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuThinButton22.Click
        Me.Close()
    End Sub

    Private Sub BunifuThinButton21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuThinButton21.Click
        BookRemovecopy.ShowDialog()
        Me.Dispose()
    End Sub

    Private Sub BunifuThinButton23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuThinButton23.Click

        BookRemove.ShowDialog()
        Me.Dispose()
    End Sub
End Class