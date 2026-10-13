<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        check = New Button()
        number = New TextBox()
        SuspendLayout()
        ' 
        ' check
        ' 
        check.Location = New Point(378, 233)
        check.Name = "check"
        check.Size = New Size(75, 23)
        check.TabIndex = 0
        check.Text = "check"
        check.UseVisualStyleBackColor = True
        ' 
        ' number
        ' 
        number.Location = New Point(364, 170)
        number.Name = "number"
        number.Size = New Size(100, 23)
        number.TabIndex = 1
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(841, 406)
        Controls.Add(number)
        Controls.Add(check)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents check As Button
    Friend WithEvents number As TextBox

End Class
