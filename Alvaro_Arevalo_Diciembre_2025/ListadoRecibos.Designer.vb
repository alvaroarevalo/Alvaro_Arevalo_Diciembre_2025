<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListadoRecibos
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
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.TxtConcepto = New System.Windows.Forms.TextBox()
        Me.TxtImporte = New System.Windows.Forms.TextBox()
        Me.TxtFechaPago = New System.Windows.Forms.TextBox()
        Me.ChPagado = New System.Windows.Forms.CheckBox()
        Me.LblTitulo = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id Recibo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Concepto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Importe"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Pagado"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(33, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Fecha Pago"
        '
        'TxtId
        '
        Me.TxtId.Enabled = False
        Me.TxtId.Location = New System.Drawing.Point(108, 49)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(177, 20)
        Me.TxtId.TabIndex = 5
        '
        'TxtConcepto
        '
        Me.TxtConcepto.Enabled = False
        Me.TxtConcepto.Location = New System.Drawing.Point(108, 79)
        Me.TxtConcepto.Name = "TxtConcepto"
        Me.TxtConcepto.Size = New System.Drawing.Size(177, 20)
        Me.TxtConcepto.TabIndex = 6
        '
        'TxtImporte
        '
        Me.TxtImporte.Enabled = False
        Me.TxtImporte.Location = New System.Drawing.Point(108, 109)
        Me.TxtImporte.Name = "TxtImporte"
        Me.TxtImporte.Size = New System.Drawing.Size(177, 20)
        Me.TxtImporte.TabIndex = 7
        '
        'TxtFechaPago
        '
        Me.TxtFechaPago.Enabled = False
        Me.TxtFechaPago.Location = New System.Drawing.Point(108, 177)
        Me.TxtFechaPago.Name = "TxtFechaPago"
        Me.TxtFechaPago.Size = New System.Drawing.Size(177, 20)
        Me.TxtFechaPago.TabIndex = 9
        '
        'ChPagado
        '
        Me.ChPagado.AutoSize = True
        Me.ChPagado.Enabled = False
        Me.ChPagado.Location = New System.Drawing.Point(108, 146)
        Me.ChPagado.Name = "ChPagado"
        Me.ChPagado.Size = New System.Drawing.Size(15, 14)
        Me.ChPagado.TabIndex = 10
        Me.ChPagado.UseVisualStyleBackColor = True
        '
        'LblTitulo
        '
        Me.LblTitulo.AutoSize = True
        Me.LblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo.Location = New System.Drawing.Point(12, 9)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(168, 31)
        Me.LblTitulo.TabIndex = 11
        Me.LblTitulo.Text = "Recibos de "
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(68, 216)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(160, 36)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Pagar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListadoRecibos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(341, 264)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LblTitulo)
        Me.Controls.Add(Me.ChPagado)
        Me.Controls.Add(Me.TxtFechaPago)
        Me.Controls.Add(Me.TxtImporte)
        Me.Controls.Add(Me.TxtConcepto)
        Me.Controls.Add(Me.TxtId)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ListadoRecibos"
        Me.Text = "ListadoRecibos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtId As TextBox
    Friend WithEvents TxtConcepto As TextBox
    Friend WithEvents TxtImporte As TextBox
    Friend WithEvents TxtFechaPago As TextBox
    Friend WithEvents ChPagado As CheckBox
    Friend WithEvents LblTitulo As Label
    Friend WithEvents Button1 As Button
End Class
