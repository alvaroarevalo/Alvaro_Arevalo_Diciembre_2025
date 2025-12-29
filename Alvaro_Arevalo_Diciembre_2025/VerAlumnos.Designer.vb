<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerAlumnos
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LstAlumnos = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LstAlumnos
        '
        Me.LstAlumnos.FormattingEnabled = True
        Me.LstAlumnos.Location = New System.Drawing.Point(12, 38)
        Me.LstAlumnos.Name = "LstAlumnos"
        Me.LstAlumnos.Size = New System.Drawing.Size(360, 251)
        Me.LstAlumnos.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Listado de Alumnos"
        '
        'VerAlumnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 311)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LstAlumnos)
        Me.Name = "VerAlumnos"
        Me.Text = "Ver Alumnos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LstAlumnos As ListBox
    Friend WithEvents Label1 As Label
End Class
