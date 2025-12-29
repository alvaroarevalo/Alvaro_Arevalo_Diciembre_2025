<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddDatosPersonales
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtNumeroMatricula = New System.Windows.Forms.TextBox()
        Me.DateNacimineto = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TxtApellidos = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id Alumno"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Num Matricula"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Fecha nacimiento"
        '
        'TxtId
        '
        Me.TxtId.Location = New System.Drawing.Point(151, 30)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(173, 20)
        Me.TxtId.TabIndex = 4
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(151, 65)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(173, 20)
        Me.TxtNombre.TabIndex = 5
        '
        'TxtNumeroMatricula
        '
        Me.TxtNumeroMatricula.Location = New System.Drawing.Point(151, 127)
        Me.TxtNumeroMatricula.Name = "TxtNumeroMatricula"
        Me.TxtNumeroMatricula.Size = New System.Drawing.Size(173, 20)
        Me.TxtNumeroMatricula.TabIndex = 6
        '
        'DateNacimineto
        '
        Me.DateNacimineto.Location = New System.Drawing.Point(151, 159)
        Me.DateNacimineto.Name = "DateNacimineto"
        Me.DateNacimineto.Size = New System.Drawing.Size(170, 20)
        Me.DateNacimineto.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(109, 194)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 51)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Introducir Datos"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TxtApellidos
        '
        Me.TxtApellidos.Location = New System.Drawing.Point(151, 97)
        Me.TxtApellidos.Name = "TxtApellidos"
        Me.TxtApellidos.Size = New System.Drawing.Size(173, 20)
        Me.TxtApellidos.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Apellidos"
        '
        'AddDatosPersonales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 381)
        Me.Controls.Add(Me.TxtApellidos)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DateNacimineto)
        Me.Controls.Add(Me.TxtNumeroMatricula)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.TxtId)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AddDatosPersonales"
        Me.Text = "AddDatosPersonales"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtId As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtNumeroMatricula As TextBox
    Friend WithEvents DateNacimineto As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents TxtApellidos As TextBox
    Friend WithEvents Label5 As Label
End Class
