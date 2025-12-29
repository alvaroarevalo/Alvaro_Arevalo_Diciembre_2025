<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListadoNotas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.TxtNotas = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtMedia = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(23, 43)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(194, 31)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Listado Notas"
        '
        'TxtNotas
        '
        Me.TxtNotas.Enabled = False
        Me.TxtNotas.Location = New System.Drawing.Point(12, 92)
        Me.TxtNotas.Name = "TxtNotas"
        Me.TxtNotas.Size = New System.Drawing.Size(654, 20)
        Me.TxtNotas.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 161)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nota Media"
        '
        'TxtMedia
        '
        Me.TxtMedia.Enabled = False
        Me.TxtMedia.Location = New System.Drawing.Point(12, 198)
        Me.TxtMedia.Name = "TxtMedia"
        Me.TxtMedia.Size = New System.Drawing.Size(199, 20)
        Me.TxtMedia.TabIndex = 4
        '
        'ListadoNotas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 266)
        Me.Controls.Add(Me.TxtMedia)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtNotas)
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "ListadoNotas"
        Me.Text = "ListadoNotas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents TxtNotas As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtMedia As TextBox
End Class
