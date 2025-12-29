Public Class FrmCalculadora
    Dim Opera1 As Double
    Dim Opera2 As Double
    Dim operadores As Char
    ' Detectamos qué símbolo usa tu PC para decimales (coma o punto)
    Dim SeparadorDecimal As String = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator

    Private Sub Btt1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btt1.Click
        MostrarNumeros(sender)
    End Sub

    ' --- Botones Numéricos (Btt2 al Btt0) ---
    Private Sub Btt2_Click(sender As Object, e As EventArgs) Handles Btt2.Click
        MostrarNumeros(sender) : End Sub
    Private Sub Btt3_Click(sender As Object, e As EventArgs) Handles Btt3.Click
        MostrarNumeros(sender) : End Sub
    Private Sub Btt4_Click(sender As Object, e As EventArgs) Handles Btt4.Click
        MostrarNumeros(sender) : End Sub
    Private Sub Btt5_Click(sender As Object, e As EventArgs) Handles Btt5.Click
        MostrarNumeros(sender) : End Sub
    Private Sub Btt6_Click(sender As Object, e As EventArgs) Handles Btt6.Click
        MostrarNumeros(sender) : End Sub
    Private Sub Btt7_Click(sender As Object, e As EventArgs) Handles Btt7.Click
        MostrarNumeros(sender) : End Sub
    Private Sub Btt8_Click(sender As Object, e As EventArgs) Handles Btt8.Click
        MostrarNumeros(sender) : End Sub
    Private Sub Btt9_Click(sender As Object, e As EventArgs) Handles Btt9.Click
        MostrarNumeros(sender) : End Sub
    Private Sub Btt0_Click(sender As Object, e As EventArgs) Handles Btt0.Click
        MostrarNumeros(sender) : End Sub

    Private Sub MostrarNumeros(ByVal Boton As System.Windows.Forms.Button)
        ' Corregido: Si hay un 0 solo, lo reemplaza. PERO si es "0." (decimal), concatena.
        If TxtNumeros.Text = "0" Then
            TxtNumeros.Text = Boton.Text
        ElseIf TxtNumeros.Text.Length < 15 Then
            TxtNumeros.Text = TxtNumeros.Text & Boton.Text
        Else
            MessageBox.Show("No se admiten más números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub BttC_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BttC.Click
        TxtNumeros.Text = "0"
        Opera1 = 0
        Opera2 = 0
    End Sub

    ' --- Operaciones ---
    ' Nota: CDbl convierte el texto a número respetando comas o puntos según tu Windows

    Private Sub BttSuma_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BttSuma.Click
        If TxtNumeros.Text <> "" Then Opera1 = CDbl(TxtNumeros.Text)
        TxtNumeros.Text = "0"
        operadores = "+"
    End Sub

    Private Sub BttResta_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BttResta.Click
        If TxtNumeros.Text <> "" Then Opera1 = CDbl(TxtNumeros.Text)
        TxtNumeros.Text = "0"
        operadores = "-"
    End Sub

    Private Sub BttPor_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BttPor.Click
        If TxtNumeros.Text <> "" Then Opera1 = CDbl(TxtNumeros.Text)
        TxtNumeros.Text = "0"
        operadores = "*"
    End Sub

    Private Sub BttDiv_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BttDiv.Click
        If TxtNumeros.Text <> "" Then Opera1 = CDbl(TxtNumeros.Text)
        TxtNumeros.Text = "0"
        operadores = "/"
    End Sub

    Private Sub BttResto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttResto.Click
        If TxtNumeros.Text <> "" Then Opera1 = CDbl(TxtNumeros.Text)
        TxtNumeros.Text = "0"
        operadores = "R"
    End Sub

    Private Sub BttPotencia_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BttPotencia.Click
        If TxtNumeros.Text <> "" Then Opera1 = CDbl(TxtNumeros.Text)
        TxtNumeros.Text = "0"
        operadores = "P"
    End Sub

    ' --- Botón IGUAL ---
    Private Sub BttIgual_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BttIgual.Click
        ' Evitamos error si la caja está vacía
        If TxtNumeros.Text = "" Then Exit Sub

        Dim ValorActual As Double = CDbl(TxtNumeros.Text) ' Usamos CDbl en lugar de Val

        Select Case operadores
            Case "+"
                Opera2 = Opera1 + ValorActual
            Case "-"
                Opera2 = Opera1 - ValorActual
            Case "*"
                Opera2 = Opera1 * ValorActual
            Case "/"
                If ValorActual <> 0 Then
                    Opera2 = Opera1 / ValorActual
                Else
                    TxtNumeros.Text = "Error"
                    Exit Sub
                End If
            Case "R"
                Opera2 = Opera1 Mod ValorActual
            Case "P"
                Opera2 = Math.Pow(Opera1, ValorActual)
        End Select

        ' Mostramos el resultado. Al ser Opera2 un Double, Windows pondrá la coma o punto automáticamente
        TxtNumeros.Text = Opera2.ToString()
    End Sub

    ' --- Botón DECIMAL (Punto o Coma) ---
    Private Sub Btn_Dot(sender As Object, e As EventArgs) Handles BtnDot.Click
        ' Verificamos si ya existe el separador decimal en el texto
        If InStr(TxtNumeros.Text, SeparadorDecimal) = 0 Then
            ' Si no existe, lo añadimos
            ' Usamos la variable SeparadorDecimal para que ponga "," o "." según corresponda
            TxtNumeros.Text = TxtNumeros.Text & SeparadorDecimal
        End If
    End Sub

    ' --- Control de Teclado ---
    Private Sub TxtNumeros_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNumeros.KeyPress
        ' Permitir: Números y Tecla de Borrado (Ascii 8)
        If Not IsNumeric(e.KeyChar) AndAlso Asc(e.KeyChar) <> 8 Then
            ' Si es un signo de puntuación (punto o coma), validamos si es el correcto
            If e.KeyChar = "."c Or e.KeyChar = ","c Then
                ' Si ya hay un separador, bloqueamos
                If TxtNumeros.Text.Contains(SeparadorDecimal) Then
                    e.Handled = True
                Else
                    ' Si presionó punto pero el sistema usa coma (o viceversa), lo corregimos al vuelo
                    e.KeyChar = Convert.ToChar(SeparadorDecimal)
                End If
            Else
                e.Handled = True ' Bloquear cualquier otra tecla
            End If
        End If
    End Sub

    ' --- Otras Funciones Científicas ---
    Private Sub BttRaiz_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BttRaiz.Click
        If TxtNumeros.Text <> "" Then
            ' Usamos CDbl para leer decimales correctamente
            Dim valor As Double = CDbl(TxtNumeros.Text)
            If valor >= 0 Then
                TxtNumeros.Text = Math.Sqrt(valor).ToString()
            Else
                TxtNumeros.Text = "Error"
            End If
        End If
    End Sub

    ' --- Menús y Estilos (Sin cambios mayores, solo ordenado) ---
    Private Sub BttCientifica_Click(sender As Object, e As EventArgs) Handles BttCientifica.Click
        Cientifica() : End Sub
    Private Sub BttEstandar_Click(sender As Object, e As EventArgs) Handles BttEstandar.Click
        Estandar() : End Sub
    Private Sub MnuEstandar_Click(sender As Object, e As EventArgs) Handles MnuEstandar.Click
        Estandar() : End Sub
    Private Sub MnuCientifica_Click(sender As Object, e As EventArgs) Handles MnuCientifica.Click
        Cientifica() : End Sub
    Private Sub MnuSalir_Click(sender As Object, e As EventArgs) Handles MnuSalir.Click
        Me.Close() : End Sub

    Private Sub Estandar()
        Me.Size = New Point(291, 390)
        BttCientifica.Enabled = True
        BttEstandar.Enabled = False
        MnuEstandar.Enabled = False
        MnuCientifica.Enabled = True
    End Sub

    Private Sub Cientifica()
        Me.Size = New Point(372, 390)
        BttEstandar.Enabled = True
        MnuEstandar.Enabled = True
        BttCientifica.Enabled = False
        MnuCientifica.Enabled = False
    End Sub

    Private Sub FrmCalculadora_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("¿Desea Salir?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    ' --- Código extra que tenías fuera de la lógica principal ---
    Private Sub BttOperacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttOperacion.Click
        Dim Texto1 As String = TxtUno.Text
        Dim texto2 As String = TxtDos.Text
        Txtresul.Text = texto2.IndexOf(Texto1)
        If Txtresul.Text = -1 Then
            Txtresul.Text = "No existe el caracter"
        End If
    End Sub

End Class