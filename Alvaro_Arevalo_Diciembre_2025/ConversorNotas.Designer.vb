<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConversorNotas
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
        Me.BtnConvertir = New System.Windows.Forms.Button()
        Me.TxtNum = New System.Windows.Forms.TextBox()
        Me.LblConverter = New System.Windows.Forms.Label()
        Me.LblTitulo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnConvertir
        '
        Me.BtnConvertir.Location = New System.Drawing.Point(208, 47)
        Me.BtnConvertir.Name = "BtnConvertir"
        Me.BtnConvertir.Size = New System.Drawing.Size(121, 70)
        Me.BtnConvertir.TabIndex = 0
        Me.BtnConvertir.Text = "Convertir"
        Me.BtnConvertir.UseVisualStyleBackColor = True
        '
        'TxtNum
        '
        Me.TxtNum.Location = New System.Drawing.Point(12, 73)
        Me.TxtNum.Name = "TxtNum"
        Me.TxtNum.Size = New System.Drawing.Size(168, 20)
        Me.TxtNum.TabIndex = 1
        '
        'LblConverter
        '
        Me.LblConverter.AutoSize = True
        Me.LblConverter.Location = New System.Drawing.Point(354, 69)
        Me.LblConverter.Name = "LblConverter"
        Me.LblConverter.Size = New System.Drawing.Size(19, 13)
        Me.LblConverter.TabIndex = 2
        Me.LblConverter.Text = "----"
        '
        'LblTitulo
        '
        Me.LblTitulo.AutoSize = True
        Me.LblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo.Location = New System.Drawing.Point(12, 20)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(193, 24)
        Me.LblTitulo.TabIndex = 3
        Me.LblTitulo.Text = "Conversor de notas"
        '
        'ConversorNotas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 167)
        Me.Controls.Add(Me.LblTitulo)
        Me.Controls.Add(Me.LblConverter)
        Me.Controls.Add(Me.TxtNum)
        Me.Controls.Add(Me.BtnConvertir)
        Me.Name = "ConversorNotas"
        Me.Text = "ConversorNotas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnConvertir As Button
    Friend WithEvents TxtNum As TextBox
    Friend WithEvents LblConverter As Label
    Friend WithEvents LblTitulo As Label
End Class
