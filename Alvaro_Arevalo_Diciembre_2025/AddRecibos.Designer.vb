<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddRecibos
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.TxtConcepto = New System.Windows.Forms.TextBox()
        Me.TxtImporte = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id recibo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Concepto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Importe"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(46, 122)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(143, 50)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Introducir Datos"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TxtId
        '
        Me.TxtId.Location = New System.Drawing.Point(86, 25)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(177, 20)
        Me.TxtId.TabIndex = 5
        '
        'TxtConcepto
        '
        Me.TxtConcepto.Location = New System.Drawing.Point(86, 51)
        Me.TxtConcepto.Name = "TxtConcepto"
        Me.TxtConcepto.Size = New System.Drawing.Size(177, 20)
        Me.TxtConcepto.TabIndex = 6
        '
        'TxtImporte
        '
        Me.TxtImporte.Location = New System.Drawing.Point(86, 83)
        Me.TxtImporte.Name = "TxtImporte"
        Me.TxtImporte.Size = New System.Drawing.Size(177, 20)
        Me.TxtImporte.TabIndex = 7
        '
        'AddRecibos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(285, 206)
        Me.Controls.Add(Me.TxtImporte)
        Me.Controls.Add(Me.TxtConcepto)
        Me.Controls.Add(Me.TxtId)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AddRecibos"
        Me.Text = "AddRecibos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TxtId As TextBox
    Friend WithEvents TxtConcepto As TextBox
    Friend WithEvents TxtImporte As TextBox
End Class
