<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LicenseForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LicenseForm))
        Me.rtbLicense = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'rtbLicense
        '
        Me.rtbLicense.Location = New System.Drawing.Point(13, 13)
        Me.rtbLicense.Name = "rtbLicense"
        Me.rtbLicense.ReadOnly = True
        Me.rtbLicense.Size = New System.Drawing.Size(716, 366)
        Me.rtbLicense.TabIndex = 0
        Me.rtbLicense.Text = resources.GetString("rtbLicense.Text")
        '
        'LicenseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(741, 391)
        Me.Controls.Add(Me.rtbLicense)
        Me.Name = "LicenseForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "End User License Agreement"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rtbLicense As RichTextBox
End Class
