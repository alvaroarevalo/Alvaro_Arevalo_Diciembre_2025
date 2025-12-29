<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListadoAsignaturas
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
        Me.LblTitulo = New System.Windows.Forms.Label()
        Me.TxtAsignaturas = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LblTitulo
        '
        Me.LblTitulo.AutoSize = True
        Me.LblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo.Location = New System.Drawing.Point(12, 46)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(280, 31)
        Me.LblTitulo.TabIndex = 0
        Me.LblTitulo.Text = "Lista de Asignaturas"
        '
        'TxtAsignaturas
        '
        Me.TxtAsignaturas.Enabled = False
        Me.TxtAsignaturas.Location = New System.Drawing.Point(10, 100)
        Me.TxtAsignaturas.Name = "TxtAsignaturas"
        Me.TxtAsignaturas.Size = New System.Drawing.Size(866, 20)
        Me.TxtAsignaturas.TabIndex = 1
        '
        'ListadoAsignaturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(888, 153)
        Me.Controls.Add(Me.TxtAsignaturas)
        Me.Controls.Add(Me.LblTitulo)
        Me.Name = "ListadoAsignaturas"
        Me.Text = "ListadoAsignaturas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblTitulo As Label
    Friend WithEvents TxtAsignaturas As TextBox
End Class
