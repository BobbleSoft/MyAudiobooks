Public Class MainForm

    Private Sub ShowAboutBox()
        Dim myForm As New AboutBox
        AboutBox.ShowDialog()
    End Sub

    Private Sub ShowLicense()
        Dim myForm As New LicenseForm
        myForm.ShowDialog()
    End Sub

#Region "Form Controls"
    Private Sub SetRootFolderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetRootFolderToolStripMenuItem.Click

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click

    End Sub

    Private Sub SaveWindowLayoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveWindowLayoutToolStripMenuItem.Click

    End Sub

    Private Sub ConfirmOnExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfirmOnExitToolStripMenuItem.Click

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        ShowAboutBox()
    End Sub

    Private Sub ShowLicenseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowLicenseToolStripMenuItem.Click
        ShowLicense()
    End Sub
#End Region

End Class
