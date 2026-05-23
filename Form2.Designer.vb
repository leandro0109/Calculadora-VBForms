<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        rtbCalculos = New RichTextBox()
        SuspendLayout()
        ' 
        ' rtbCalculos
        ' 
        rtbCalculos.Font = New Font("Segoe UI", 16F)
        rtbCalculos.Location = New Point(12, 12)
        rtbCalculos.Name = "rtbCalculos"
        rtbCalculos.Size = New Size(384, 325)
        rtbCalculos.TabIndex = 0
        rtbCalculos.Text = ""
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightGray
        ClientSize = New Size(408, 349)
        Controls.Add(rtbCalculos)
        Name = "Form2"
        Text = "Hitórico De Operações"
        ResumeLayout(False)
    End Sub

    Friend WithEvents rtbCalculos As RichTextBox
End Class
