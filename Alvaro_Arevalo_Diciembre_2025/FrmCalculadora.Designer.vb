<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCalculadora
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
        Btt1 = New Button()
        Btt2 = New Button()
        Btt3 = New Button()
        Btt6 = New Button()
        Btt5 = New Button()
        Btt4 = New Button()
        Btt9 = New Button()
        Btt8 = New Button()
        Btt7 = New Button()
        Btt0 = New Button()
        BttC = New Button()
        BttResta = New Button()
        BttSuma = New Button()
        BttDiv = New Button()
        BttPor = New Button()
        BttResto = New Button()
        BttIgual = New Button()
        BttCientifica = New Button()
        BttEstandar = New Button()
        BttRaiz = New Button()
        BttPotencia = New Button()
        Label1 = New Label()
        Texto2 = New Label()
        Label2 = New Label()
        TxtUno = New TextBox()
        TxtDos = New TextBox()
        Txtresul = New TextBox()
        BttOperacion = New Button()
        TxtNumeros = New TextBox()
        MenuStrip1 = New MenuStrip()
        MnuVer = New ToolStripMenuItem()
        MnuEstandar = New ToolStripMenuItem()
        MnuCientifica = New ToolStripMenuItem()
        MnuSalir = New ToolStripMenuItem()
        BtnDot = New Button()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Btt1
        ' 
        Btt1.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Btt1.Location = New Point(21, 157)
        Btt1.Margin = New Padding(3, 2, 3, 2)
        Btt1.Name = "Btt1"
        Btt1.Size = New Size(70, 60)
        Btt1.TabIndex = 1
        Btt1.Text = "1"
        Btt1.UseVisualStyleBackColor = False
        ' 
        ' Btt2
        ' 
        Btt2.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Btt2.Location = New Point(116, 157)
        Btt2.Margin = New Padding(3, 2, 3, 2)
        Btt2.Name = "Btt2"
        Btt2.Size = New Size(70, 60)
        Btt2.TabIndex = 2
        Btt2.Text = "2"
        Btt2.UseVisualStyleBackColor = False
        ' 
        ' Btt3
        ' 
        Btt3.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Btt3.Location = New Point(209, 157)
        Btt3.Margin = New Padding(3, 2, 3, 2)
        Btt3.Name = "Btt3"
        Btt3.Size = New Size(70, 60)
        Btt3.TabIndex = 3
        Btt3.Text = "3"
        Btt3.UseVisualStyleBackColor = False
        ' 
        ' Btt6
        ' 
        Btt6.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Btt6.Location = New Point(209, 232)
        Btt6.Margin = New Padding(3, 2, 3, 2)
        Btt6.Name = "Btt6"
        Btt6.Size = New Size(70, 60)
        Btt6.TabIndex = 6
        Btt6.Text = "6"
        Btt6.UseVisualStyleBackColor = False
        ' 
        ' Btt5
        ' 
        Btt5.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Btt5.Location = New Point(116, 232)
        Btt5.Margin = New Padding(3, 2, 3, 2)
        Btt5.Name = "Btt5"
        Btt5.Size = New Size(70, 60)
        Btt5.TabIndex = 5
        Btt5.Text = "5"
        Btt5.UseVisualStyleBackColor = False
        ' 
        ' Btt4
        ' 
        Btt4.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Btt4.Location = New Point(21, 232)
        Btt4.Margin = New Padding(3, 2, 3, 2)
        Btt4.Name = "Btt4"
        Btt4.Size = New Size(70, 60)
        Btt4.TabIndex = 4
        Btt4.Text = "4"
        Btt4.UseVisualStyleBackColor = False
        ' 
        ' Btt9
        ' 
        Btt9.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Btt9.Location = New Point(209, 306)
        Btt9.Margin = New Padding(3, 2, 3, 2)
        Btt9.Name = "Btt9"
        Btt9.Size = New Size(70, 60)
        Btt9.TabIndex = 9
        Btt9.Text = "9"
        Btt9.UseVisualStyleBackColor = False
        ' 
        ' Btt8
        ' 
        Btt8.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Btt8.Location = New Point(116, 306)
        Btt8.Margin = New Padding(3, 2, 3, 2)
        Btt8.Name = "Btt8"
        Btt8.Size = New Size(70, 60)
        Btt8.TabIndex = 8
        Btt8.Text = "8"
        Btt8.UseVisualStyleBackColor = False
        ' 
        ' Btt7
        ' 
        Btt7.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Btt7.Location = New Point(21, 306)
        Btt7.Margin = New Padding(3, 2, 3, 2)
        Btt7.Name = "Btt7"
        Btt7.Size = New Size(70, 60)
        Btt7.TabIndex = 7
        Btt7.Text = "7"
        Btt7.UseVisualStyleBackColor = False
        ' 
        ' Btt0
        ' 
        Btt0.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Btt0.Location = New Point(21, 385)
        Btt0.Margin = New Padding(3, 2, 3, 2)
        Btt0.Name = "Btt0"
        Btt0.Size = New Size(165, 60)
        Btt0.TabIndex = 10
        Btt0.Text = "0"
        Btt0.UseVisualStyleBackColor = False
        ' 
        ' BttC
        ' 
        BttC.BackColor = Color.Cyan
        BttC.Font = New Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BttC.Location = New Point(310, 157)
        BttC.Margin = New Padding(3, 2, 3, 2)
        BttC.Name = "BttC"
        BttC.Size = New Size(164, 60)
        BttC.TabIndex = 11
        BttC.Text = "C"
        BttC.UseVisualStyleBackColor = False
        ' 
        ' BttResta
        ' 
        BttResta.BackColor = Color.LightGray
        BttResta.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold)
        BttResta.Location = New Point(394, 232)
        BttResta.Margin = New Padding(3, 2, 3, 2)
        BttResta.Name = "BttResta"
        BttResta.Size = New Size(70, 60)
        BttResta.TabIndex = 13
        BttResta.Text = "-"
        BttResta.UseVisualStyleBackColor = False
        ' 
        ' BttSuma
        ' 
        BttSuma.BackColor = Color.LightGray
        BttSuma.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold)
        BttSuma.Location = New Point(318, 232)
        BttSuma.Margin = New Padding(3, 2, 3, 2)
        BttSuma.Name = "BttSuma"
        BttSuma.Size = New Size(70, 60)
        BttSuma.TabIndex = 12
        BttSuma.Text = "+"
        BttSuma.UseVisualStyleBackColor = False
        ' 
        ' BttDiv
        ' 
        BttDiv.BackColor = Color.LightGray
        BttDiv.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold)
        BttDiv.Location = New Point(394, 306)
        BttDiv.Margin = New Padding(3, 2, 3, 2)
        BttDiv.Name = "BttDiv"
        BttDiv.Size = New Size(70, 60)
        BttDiv.TabIndex = 15
        BttDiv.Text = "/"
        BttDiv.UseVisualStyleBackColor = False
        ' 
        ' BttPor
        ' 
        BttPor.BackColor = Color.LightGray
        BttPor.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold)
        BttPor.Location = New Point(318, 306)
        BttPor.Margin = New Padding(3, 2, 3, 2)
        BttPor.Name = "BttPor"
        BttPor.Size = New Size(70, 60)
        BttPor.TabIndex = 14
        BttPor.Text = "*"
        BttPor.UseVisualStyleBackColor = False
        ' 
        ' BttResto
        ' 
        BttResto.BackColor = Color.LightGray
        BttResto.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BttResto.Location = New Point(394, 385)
        BttResto.Margin = New Padding(3, 2, 3, 2)
        BttResto.Name = "BttResto"
        BttResto.Size = New Size(70, 60)
        BttResto.TabIndex = 17
        BttResto.Text = "Mod"
        BttResto.UseVisualStyleBackColor = False
        ' 
        ' BttIgual
        ' 
        BttIgual.BackColor = Color.LightGray
        BttIgual.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold)
        BttIgual.Location = New Point(318, 385)
        BttIgual.Margin = New Padding(3, 2, 3, 2)
        BttIgual.Name = "BttIgual"
        BttIgual.Size = New Size(70, 60)
        BttIgual.TabIndex = 16
        BttIgual.Text = "="
        BttIgual.UseVisualStyleBackColor = False
        ' 
        ' BttCientifica
        ' 
        BttCientifica.BackColor = Color.LightGray
        BttCientifica.Location = New Point(49, 462)
        BttCientifica.Margin = New Padding(3, 2, 3, 2)
        BttCientifica.Name = "BttCientifica"
        BttCientifica.Size = New Size(114, 26)
        BttCientifica.TabIndex = 18
        BttCientifica.Text = "Cientifica"
        BttCientifica.UseVisualStyleBackColor = False
        ' 
        ' BttEstandar
        ' 
        BttEstandar.BackColor = Color.LightGray
        BttEstandar.Location = New Point(333, 462)
        BttEstandar.Margin = New Padding(3, 2, 3, 2)
        BttEstandar.Name = "BttEstandar"
        BttEstandar.Size = New Size(114, 26)
        BttEstandar.TabIndex = 19
        BttEstandar.Text = "Estandar"
        BttEstandar.UseVisualStyleBackColor = False
        ' 
        ' BttRaiz
        ' 
        BttRaiz.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        BttRaiz.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        BttRaiz.Location = New Point(490, 232)
        BttRaiz.Margin = New Padding(3, 2, 3, 2)
        BttRaiz.Name = "BttRaiz"
        BttRaiz.Size = New Size(96, 26)
        BttRaiz.TabIndex = 20
        BttRaiz.Text = "Raiz"
        BttRaiz.UseVisualStyleBackColor = False
        ' 
        ' BttPotencia
        ' 
        BttPotencia.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        BttPotencia.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        BttPotencia.Location = New Point(490, 306)
        BttPotencia.Margin = New Padding(3, 2, 3, 2)
        BttPotencia.Name = "BttPotencia"
        BttPotencia.Size = New Size(96, 26)
        BttPotencia.TabIndex = 21
        BttPotencia.Text = "Potencia"
        BttPotencia.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label1.Location = New Point(64, 523)
        Label1.Name = "Label1"
        Label1.Size = New Size(61, 21)
        Label1.TabIndex = 22
        Label1.Text = "Texto1"
        ' 
        ' Texto2
        ' 
        Texto2.AutoSize = True
        Texto2.BackColor = Color.Transparent
        Texto2.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Texto2.Location = New Point(64, 555)
        Texto2.Name = "Texto2"
        Texto2.Size = New Size(61, 21)
        Texto2.TabIndex = 23
        Texto2.Text = "Texto2"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label2.Location = New Point(64, 586)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 21)
        Label2.TabIndex = 24
        Label2.Text = "Resultado"
        ' 
        ' TxtUno
        ' 
        TxtUno.Location = New Point(226, 520)
        TxtUno.Margin = New Padding(3, 2, 3, 2)
        TxtUno.Name = "TxtUno"
        TxtUno.Size = New Size(238, 23)
        TxtUno.TabIndex = 26
        ' 
        ' TxtDos
        ' 
        TxtDos.Location = New Point(226, 555)
        TxtDos.Margin = New Padding(3, 2, 3, 2)
        TxtDos.Name = "TxtDos"
        TxtDos.Size = New Size(238, 23)
        TxtDos.TabIndex = 27
        ' 
        ' Txtresul
        ' 
        Txtresul.Location = New Point(226, 586)
        Txtresul.Margin = New Padding(3, 2, 3, 2)
        Txtresul.Name = "Txtresul"
        Txtresul.Size = New Size(238, 23)
        Txtresul.TabIndex = 28
        ' 
        ' BttOperacion
        ' 
        BttOperacion.BackColor = Color.Silver
        BttOperacion.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BttOperacion.ForeColor = Color.Red
        BttOperacion.Location = New Point(226, 619)
        BttOperacion.Margin = New Padding(3, 2, 3, 2)
        BttOperacion.Name = "BttOperacion"
        BttOperacion.Size = New Size(238, 47)
        BttOperacion.TabIndex = 29
        BttOperacion.Text = "Operacion"
        BttOperacion.UseVisualStyleBackColor = False
        ' 
        ' TxtNumeros
        ' 
        TxtNumeros.Location = New Point(-1, 122)
        TxtNumeros.Margin = New Padding(3, 2, 3, 2)
        TxtNumeros.Name = "TxtNumeros"
        TxtNumeros.Size = New Size(654, 23)
        TxtNumeros.TabIndex = 30
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {MnuVer, MnuSalir})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(5, 2, 0, 2)
        MenuStrip1.Size = New Size(654, 24)
        MenuStrip1.TabIndex = 31
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' MnuVer
        ' 
        MnuVer.DropDownItems.AddRange(New ToolStripItem() {MnuEstandar, MnuCientifica})
        MnuVer.Name = "MnuVer"
        MnuVer.Size = New Size(35, 20)
        MnuVer.Text = "Ver"
        ' 
        ' MnuEstandar
        ' 
        MnuEstandar.Name = "MnuEstandar"
        MnuEstandar.Size = New Size(124, 22)
        MnuEstandar.Text = "Estandar"
        ' 
        ' MnuCientifica
        ' 
        MnuCientifica.Name = "MnuCientifica"
        MnuCientifica.Size = New Size(124, 22)
        MnuCientifica.Text = "Cientifica"
        ' 
        ' MnuSalir
        ' 
        MnuSalir.Name = "MnuSalir"
        MnuSalir.Size = New Size(41, 20)
        MnuSalir.Text = "Salir"
        ' 
        ' BtnDot
        ' 
        BtnDot.Font = New Font("Segoe UI", 20F)
        BtnDot.Location = New Point(209, 385)
        BtnDot.Name = "BtnDot"
        BtnDot.Size = New Size(70, 60)
        BtnDot.TabIndex = 32
        BtnDot.Text = "."
        BtnDot.UseVisualStyleBackColor = True
        ' 
        ' FrmCalculadora
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(654, 718)
        Controls.Add(BtnDot)
        Controls.Add(TxtNumeros)
        Controls.Add(BttOperacion)
        Controls.Add(Txtresul)
        Controls.Add(TxtDos)
        Controls.Add(TxtUno)
        Controls.Add(Label2)
        Controls.Add(Texto2)
        Controls.Add(Label1)
        Controls.Add(BttPotencia)
        Controls.Add(BttRaiz)
        Controls.Add(BttEstandar)
        Controls.Add(BttCientifica)
        Controls.Add(BttResto)
        Controls.Add(BttIgual)
        Controls.Add(BttDiv)
        Controls.Add(BttPor)
        Controls.Add(BttResta)
        Controls.Add(BttSuma)
        Controls.Add(BttC)
        Controls.Add(Btt0)
        Controls.Add(Btt9)
        Controls.Add(Btt8)
        Controls.Add(Btt7)
        Controls.Add(Btt6)
        Controls.Add(Btt5)
        Controls.Add(Btt4)
        Controls.Add(Btt3)
        Controls.Add(Btt2)
        Controls.Add(Btt1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Margin = New Padding(3, 2, 3, 2)
        Name = "FrmCalculadora"
        Text = "Calculadora"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Btt1 As Button
    Friend WithEvents Btt2 As Button
    Friend WithEvents Btt3 As Button
    Friend WithEvents Btt6 As Button
    Friend WithEvents Btt5 As Button
    Friend WithEvents Btt4 As Button
    Friend WithEvents Btt9 As Button
    Friend WithEvents Btt8 As Button
    Friend WithEvents Btt7 As Button
    Friend WithEvents Btt0 As Button
    Friend WithEvents BttC As Button
    Friend WithEvents BttResta As Button
    Friend WithEvents BttSuma As Button
    Friend WithEvents BttDiv As Button
    Friend WithEvents BttPor As Button
    Friend WithEvents BttResto As Button
    Friend WithEvents BttIgual As Button
    Friend WithEvents BttCientifica As Button
    Friend WithEvents BttEstandar As Button
    Friend WithEvents BttRaiz As Button
    Friend WithEvents BttPotencia As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Texto2 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtUno As TextBox
    Friend WithEvents TxtDos As TextBox
    Friend WithEvents Txtresul As TextBox
    Friend WithEvents BttOperacion As Button
    Friend WithEvents TxtNumeros As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MnuVer As ToolStripMenuItem
    Friend WithEvents MnuSalir As ToolStripMenuItem
    Friend WithEvents MnuEstandar As ToolStripMenuItem
    Friend WithEvents MnuCientifica As ToolStripMenuItem
    Friend WithEvents BtnDot As Button

End Class
