Public Class SQHAPhome
    Private Sub SQHAPhome_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnArtists_Click(sender As Object, e As EventArgs) Handles btnArtists.Click
        Dim aForm As New frmArtists
        aForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnArtwork_Click(sender As Object, e As EventArgs) Handles btnArtwork.Click
        Dim aForm As New frmArtwork
        aForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnMaintenance_Click(sender As Object, e As EventArgs) Handles btnMaintenance.Click
        Dim aForm As New frmMaintenance
        aForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnEvents_Click(sender As Object, e As EventArgs) Handles btnEvents.Click
        Dim aForm As New frmEvents
        aForm.Show()
        Me.Hide()
    End Sub
End Class
