<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetRootFolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveWindowLayoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfirmOnExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tvFolderList = New System.Windows.Forms.TreeView()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblDateRead = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ShowLicenseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.OptionsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(756, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SetRootFolderToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'SetRootFolderToolStripMenuItem
        '
        Me.SetRootFolderToolStripMenuItem.Name = "SetRootFolderToolStripMenuItem"
        Me.SetRootFolderToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.SetRootFolderToolStripMenuItem.Text = "Set Root &Folder..."
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveWindowLayoutToolStripMenuItem, Me.ConfirmOnExitToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.OptionsToolStripMenuItem.Text = "&Options"
        '
        'SaveWindowLayoutToolStripMenuItem
        '
        Me.SaveWindowLayoutToolStripMenuItem.Checked = True
        Me.SaveWindowLayoutToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.SaveWindowLayoutToolStripMenuItem.Name = "SaveWindowLayoutToolStripMenuItem"
        Me.SaveWindowLayoutToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.SaveWindowLayoutToolStripMenuItem.Text = "Save &Window Layout"
        '
        'ConfirmOnExitToolStripMenuItem
        '
        Me.ConfirmOnExitToolStripMenuItem.Checked = True
        Me.ConfirmOnExitToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ConfirmOnExitToolStripMenuItem.Name = "ConfirmOnExitToolStripMenuItem"
        Me.ConfirmOnExitToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.ConfirmOnExitToolStripMenuItem.Text = "Confirm on E&xit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowLicenseToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'tvFolderList
        '
        Me.tvFolderList.FullRowSelect = True
        Me.tvFolderList.Location = New System.Drawing.Point(13, 28)
        Me.tvFolderList.Name = "tvFolderList"
        Me.tvFolderList.Size = New System.Drawing.Size(349, 410)
        Me.tvFolderList.TabIndex = 1
        '
        'lblDescription
        '
        Me.lblDescription.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDescription.Location = New System.Drawing.Point(389, 28)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(349, 371)
        Me.lblDescription.TabIndex = 2
        Me.lblDescription.Text = "This label will contain the contents of the DESCRIPTION.HTML file as the user tra" &
    "verses the audiobook listing."
        '
        'lblDateRead
        '
        Me.lblDateRead.AutoSize = True
        Me.lblDateRead.Location = New System.Drawing.Point(389, 418)
        Me.lblDateRead.Name = "lblDateRead"
        Me.lblDateRead.Size = New System.Drawing.Size(62, 13)
        Me.lblDateRead.TabIndex = 3
        Me.lblDateRead.Text = "Date Read:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(457, 418)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(77, 20)
        Me.TextBox1.TabIndex = 4
        Me.TextBox1.Text = "0000-00-00"
        '
        'ShowLicenseToolStripMenuItem
        '
        Me.ShowLicenseToolStripMenuItem.Name = "ShowLicenseToolStripMenuItem"
        Me.ShowLicenseToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ShowLicenseToolStripMenuItem.Text = "Show &License"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(756, 450)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblDateRead)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.tvFolderList)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.Text = "My Audiobooks"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveWindowLayoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tvFolderList As TreeView
    Friend WithEvents SetRootFolderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblDescription As Label
    Friend WithEvents lblDateRead As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ConfirmOnExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShowLicenseToolStripMenuItem As ToolStripMenuItem
End Class
