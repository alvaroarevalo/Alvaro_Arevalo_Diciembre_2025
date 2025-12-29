<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListarAlumno
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtApellidos = New System.Windows.Forms.TextBox()
        Me.TxtMatricula = New System.Windows.Forms.TextBox()
        Me.TxtNacimineto = New System.Windows.Forms.TextBox()
        Me.TxtEdad = New System.Windows.Forms.TextBox()
        Me.LabelApellido2 = New System.Windows.Forms.Label()
        Me.TxtApellido2 = New System.Windows.Forms.TextBox()
        Me.LabelDomicilio = New System.Windows.Forms.Label()
        Me.TxtDomicilio = New System.Windows.Forms.TextBox()
        Me.LabelTelefono = New System.Windows.Forms.Label()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Apellido 1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "DNI"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 260)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Num Matricula"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 287)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Fecha Nacimiento"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 318)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Edad"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(105, 360)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Cerrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TxtId
        '
        Me.TxtId.Enabled = False
        Me.TxtId.Location = New System.Drawing.Point(105, 57)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(186, 20)
        Me.TxtId.TabIndex = 7
        '
        'TxtNombre
        '
        Me.TxtNombre.Enabled = False
        Me.TxtNombre.Location = New System.Drawing.Point(105, 86)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(186, 20)
        Me.TxtNombre.TabIndex = 8
        '
        'TxtApellidos
        '
        Me.TxtApellidos.Enabled = False
        Me.TxtApellidos.Location = New System.Drawing.Point(105, 117)
        Me.TxtApellidos.Name = "TxtApellidos"
        Me.TxtApellidos.Size = New System.Drawing.Size(186, 20)
        Me.TxtApellidos.TabIndex = 9
        '
        'TxtMatricula
        '
        Me.TxtMatricula.Enabled = False
        Me.TxtMatricula.Location = New System.Drawing.Point(105, 253)
        Me.TxtMatricula.Name = "TxtMatricula"
        Me.TxtMatricula.Size = New System.Drawing.Size(186, 20)
        Me.TxtMatricula.TabIndex = 10
        '
        'TxtNacimineto
        '
        Me.TxtNacimineto.Enabled = False
        Me.TxtNacimineto.Location = New System.Drawing.Point(105, 280)
        Me.TxtNacimineto.Name = "TxtNacimineto"
        Me.TxtNacimineto.Size = New System.Drawing.Size(186, 20)
        Me.TxtNacimineto.TabIndex = 11
        '
        'TxtEdad
        '
        Me.TxtEdad.Enabled = False
        Me.TxtEdad.Location = New System.Drawing.Point(105, 311)
        Me.TxtEdad.Name = "TxtEdad"
        Me.TxtEdad.Size = New System.Drawing.Size(186, 20)
        Me.TxtEdad.TabIndex = 12
        '
        'LabelApellido2
        '
        Me.LabelApellido2.AutoSize = True
        Me.LabelApellido2.Location = New System.Drawing.Point(12, 147)
        Me.LabelApellido2.Name = "LabelApellido2"
        Me.LabelApellido2.Size = New System.Drawing.Size(49, 13)
        Me.LabelApellido2.TabIndex = 14
        Me.LabelApellido2.Text = "Apellido 2"
        '
        'TxtApellido2
        '
        Me.TxtApellido2.Enabled = False
        Me.TxtApellido2.Location = New System.Drawing.Point(105, 144)
        Me.TxtApellido2.Name = "TxtApellido2"
        Me.TxtApellido2.Size = New System.Drawing.Size(186, 20)
        Me.TxtApellido2.TabIndex = 15
        '
        'LabelDomicilio
        '
        Me.LabelDomicilio.AutoSize = True
        Me.LabelDomicilio.Location = New System.Drawing.Point(12, 177)
        Me.LabelDomicilio.Name = "LabelDomicilio"
        Me.LabelDomicilio.Size = New System.Drawing.Size(49, 13)
        Me.LabelDomicilio.TabIndex = 16
        Me.LabelDomicilio.Text = "Domicilio"
        '
        'TxtDomicilio
        '
        Me.TxtDomicilio.Enabled = False
        Me.TxtDomicilio.Location = New System.Drawing.Point(105, 174)
        Me.TxtDomicilio.Name = "TxtDomicilio"
        Me.TxtDomicilio.Size = New System.Drawing.Size(186, 20)
        Me.TxtDomicilio.TabIndex = 17
        '
        'LabelTelefono
        '
        Me.LabelTelefono.AutoSize = True
        Me.LabelTelefono.Location = New System.Drawing.Point(12, 207)
        Me.LabelTelefono.Name = "LabelTelefono"
        Me.LabelTelefono.Size = New System.Drawing.Size(49, 13)
        Me.LabelTelefono.TabIndex = 18
        Me.LabelTelefono.Text = "Telefono"
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Enabled = False
        Me.TxtTelefono.Location = New System.Drawing.Point(105, 204)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(186, 20)
        Me.TxtTelefono.TabIndex = 19
        '
        'ListarAlumno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(320, 420)
        Me.Controls.Add(Me.LabelTelefono)
        Me.Controls.Add(Me.TxtTelefono)
        Me.Controls.Add(Me.LabelDomicilio)
        Me.Controls.Add(Me.TxtDomicilio)
        Me.Controls.Add(Me.LabelApellido2)
        Me.Controls.Add(Me.TxtApellido2)
        Me.Controls.Add(Me.TxtEdad)
        Me.Controls.Add(Me.TxtNacimineto)
        Me.Controls.Add(Me.TxtMatricula)
        Me.Controls.Add(Me.TxtApellidos)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.TxtId)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ListarAlumno"
        Me.Text = "ListarAlumno"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TxtId As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtApellidos As TextBox
    Friend WithEvents TxtMatricula As TextBox
    Friend WithEvents TxtNacimineto As TextBox
    Friend WithEvents TxtEdad As TextBox
    Friend WithEvents LabelApellido2 As Label
    Friend WithEvents TxtApellido2 As TextBox
    Friend WithEvents LabelDomicilio As Label
    Friend WithEvents TxtDomicilio As TextBox
    Friend WithEvents LabelTelefono As Label
    Friend WithEvents TxtTelefono As TextBox
End Class
