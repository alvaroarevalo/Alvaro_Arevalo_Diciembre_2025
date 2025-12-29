Namespace Colegio
    Public Class Alumno
        Private _nmat As Integer
        Private _nombre As String
        Private _apellidos As String
        Private _fechaNacimiento As Date
        Private _idAlumno As String
        Private _asignaturas As String()

        Public Sub New()
            ReDim _asignaturas(0)
        End Sub

        Public Sub IntroducirDatos(NewId As String, NewNmat As Integer, NewName As String, NewSurname As String, NewFechNacimiento As Date)
            _idAlumno = NewId
            If String.IsNullOrWhiteSpace(_idAlumno) Then _idAlumno = "000AA"

            Dim sMat As String = NewNmat
            If String.IsNullOrWhiteSpace(sMat) Then _nmat = -1 Else _nmat = Integer.Parse(sMat)

            _nombre = NewName
            If String.IsNullOrWhiteSpace(_nombre) Then _nombre = "Sin Nombre"

            _apellidos = NewSurname
            If String.IsNullOrWhiteSpace(_apellidos) Then _apellidos = "Sin Apellidos"

            Dim sFecha As String = NewFechNacimiento
            If String.IsNullOrWhiteSpace(sFecha) Then _fechaNacimiento = Date.Today Else _fechaNacimiento = Date.Parse(sFecha)
        End Sub

        Public Sub IntroducirAsignaturas(NewAsignatura)
            Dim i As Integer
            i = UBound(_asignaturas) + 1
            ReDim Preserve _asignaturas(i)
            _asignaturas(UBound(_asignaturas)) = NewAsignatura
        End Sub

        Public Property NMat As Integer
            Get
                Return _nmat
            End Get
            Set(value As Integer)
                _nmat = value
            End Set
        End Property

        Public Property Nombre As String
            Get
                Return _nombre
            End Get
            Set(value As String)
                _nombre = value
            End Set
        End Property

        Public Property Apellidos As String
            Get
                Return _apellidos
            End Get
            Set(value As String)
                _apellidos = value
            End Set
        End Property

        Public Property FechaNacimiento As Date
            Get
                Return _fechaNacimiento
            End Get
            Set(value As Date)
                _fechaNacimiento = value
            End Set
        End Property

        Public Property IdAlumno As String
            Get
                Return _idAlumno
            End Get
            Set(value As String)
                _idAlumno = value
            End Set
        End Property
        Public Property Asignaturas As String()
            Get
                Return _asignaturas
            End Get
            Set(value As String())
                _asignaturas = value
            End Set
        End Property

        Public Function CalcularEdad() As Integer
            Dim hoy As Date = Date.Today
            Dim edad As Integer = hoy.Year - _fechaNacimiento.Year
            If _fechaNacimiento.Date > hoy.AddYears(-edad) Then
                edad -= 1
            End If
            Return edad
        End Function

        Public Function ObtenerNombreCompleto() As String
            Return $"{_apellidos}, {_nombre}"
        End Function

        Public Overrides Function ToString() As String
            Return $"[ID: {_idAlumno}] {ObtenerNombreCompleto()} - Edad: {CalcularEdad()}"
        End Function

        Public Function GuardarAlumno() As Boolean
            Dim carpeta As String = "Ficheros"
            Dim rutaFichero As String = System.IO.Path.Combine(carpeta, "alumnos.txt")
            Dim datosAlumno As String

            Try
                If Not System.IO.Directory.Exists(carpeta) Then System.IO.Directory.CreateDirectory(carpeta)

                datosAlumno = $"{Me.IdAlumno}|{Me.NMat}|{Me.Nombre}|{Me.Apellidos}|{Me.FechaNacimiento.ToShortDateString()}"

                System.IO.File.WriteAllText(rutaFichero, datosAlumno)
                Return True
            Catch ex As Exception
                Console.WriteLine($"Error al guardar alumno: {ex.Message}")
                Return False
            End Try
        End Function

        Public Sub CargarAlumno()
            Dim rutaFichero As String = "Ficheros\alumnos.txt"

            If Not System.IO.File.Exists(rutaFichero) Then
                Console.WriteLine("No existe el fichero de alumnos.")
                Exit Sub
            End If

            Try
                Dim linea As String = System.IO.File.ReadAllText(rutaFichero)

                If String.IsNullOrWhiteSpace(linea) Then Exit Sub
                linea = linea.Trim()

                Dim campos() As String = linea.Split("|"c)
                If campos.Length = 5 Then
                    Me.IdAlumno = Integer.Parse(campos(0))
                    Me.NMat = Integer.Parse(campos(1))
                    Me.Nombre = campos(2)
                    Me.Apellidos = campos(3)
                    Me.FechaNacimiento = Date.Parse(campos(4))
                End If
            Catch ex As Exception
                Console.WriteLine($"Error al cargar alumno: {ex.Message}")
            End Try
        End Sub
    End Class

    Public Class Notas
        Inherits Alumno
        Private _nombreCurso As String
        Private _notasParciales As Double()
        Private _notaFinalOrdinaria As Double
        Private _notaFinalExtraordinaria As Double

        Public Sub New()
            ReDim _notasParciales(0)
        End Sub

        Public Sub IntroducirDatos(NewNombre As String)
            _nombreCurso = NewNombre
            If String.IsNullOrWhiteSpace(_nombreCurso) Then _nombreCurso = "DAM"
        End Sub

        Public Property NombreCurso As String
            Get
                Return _nombreCurso
            End Get
            Set(value As String)
                _nombreCurso = value
            End Set
        End Property

        Public Property NotaFinalOrdinaria As Double
            Get
                Return _notaFinalOrdinaria
            End Get
            Set(value As Double)
                _notaFinalOrdinaria = value
            End Set
        End Property

        Public Property NotaFinalExtraordinaria As Double
            Get
                Return _notaFinalExtraordinaria
            End Get
            Set(value As Double)
                _notaFinalExtraordinaria = value
            End Set
        End Property

        Public ReadOnly Property NotasParciales As Double()
            Get
                Return _notasParciales
            End Get
        End Property

        Public Sub AgregarNotaParcial(nota As Double)
            If nota >= 0 AndAlso nota <= 10 Then
                Dim i As Integer
                i = UBound(_notasParciales) + 1
                ReDim Preserve _notasParciales(i)
                _notasParciales(UBound(_notasParciales)) = nota
            Else
                MessageBox.Show("La nota debe estar entre 0 y 10")
            End If
        End Sub

        Public Function CalcularMediaParciales() As Double
            If _notasParciales.Count = 0 Then Return 0.0
            Dim suma As Double = 0
            For Each n In _notasParciales
                suma += n
            Next
            Return suma / _notasParciales.Count
        End Function

        Public Function GuardarNota() As Boolean
            Dim carpeta As String = "Ficheros"
            Dim rutaFichero As String = System.IO.Path.Combine(carpeta, "notas.txt")

            Try
                If Not System.IO.Directory.Exists(carpeta) Then System.IO.Directory.CreateDirectory(carpeta)

                Dim strParciales As String = String.Join("-", _notasParciales)
                Dim linea As String = $"{_nombreCurso}|{strParciales}|{_notaFinalOrdinaria}|{_notaFinalExtraordinaria}"

                System.IO.File.WriteAllText(rutaFichero, linea)
                Return True
            Catch ex As Exception
                Console.WriteLine($"Error guardando nota: {ex.Message}")
                Return False
            End Try
        End Function

        Public Sub CargarNota()
            Dim rutaFichero As String = "Ficheros\notas.txt"
            If Not System.IO.File.Exists(rutaFichero) Then Exit Sub

            Try
                Dim linea As String = System.IO.File.ReadAllText(rutaFichero)
                If String.IsNullOrWhiteSpace(linea) Then Exit Sub
                linea = linea.Trim()

                Dim campos() As String = linea.Split("|"c)

                If campos.Length >= 5 Then
                    Me.NombreCurso = campos(1)
                    Dim parcialesStr As String = campos(2)
                    Me.NotaFinalOrdinaria = Double.Parse(campos(3))
                    Me.NotaFinalExtraordinaria = Double.Parse(campos(4))

                    If Not String.IsNullOrEmpty(parcialesStr) Then
                        For Each p In parcialesStr.Split("-"c)
                            Dim valor As Double
                            If Double.TryParse(p, valor) Then Me.AgregarNotaParcial(valor)
                        Next
                    End If
                End If
            Catch ex As Exception
                Console.WriteLine($"Error cargando notas: {ex.Message}")
            End Try
        End Sub
    End Class

    Public Class Recibos
        Inherits Alumno
        Private _idRecibo As String
        Private _concepto As String
        Private _importe As Double
        Private _pagado As Boolean
        Private _fechaPago As Date

        Public Sub New()
        End Sub

        Public Sub IntroducirDatos(NewId As String, NewConcepto As String, NewImporte As Double)
            _idRecibo = NewId
            If String.IsNullOrWhiteSpace(_idRecibo) Then _idRecibo = "000AA"

            _concepto = NewConcepto
            If String.IsNullOrWhiteSpace(_concepto) Then _concepto = "Varios"

            Dim sImp As String = NewImporte
            If String.IsNullOrWhiteSpace(sImp) Then _importe = 0.0 Else _importe = Double.Parse(sImp)

            _pagado = False
        End Sub

        Public Property Pagado As Boolean
            Get
                Return _pagado
            End Get
            Set(value As Boolean)
                _pagado = value
            End Set
        End Property

        Public Property IdRecibo As String
            Get
                Return _idRecibo
            End Get
            Set(value As String)
                _idRecibo = value
            End Set
        End Property

        Public Property Concepto As String
            Get
                Return _concepto
            End Get
            Set(value As String)
                _concepto = value
            End Set
        End Property

        Public Property Importe As String
            Get
                Return _importe
            End Get
            Set(value As String)
                _importe = value
            End Set
        End Property

        Public Property FechaPago As Date
            Get
                Return _fechaPago
            End Get
            Set(value As Date)
                _fechaPago = value
            End Set
        End Property


        Public Sub PagarRecibo()
            If Not _pagado Then
                _pagado = True
                _fechaPago = Date.Now
            End If
        End Sub

        Public Overrides Function ToString() As String
            Dim estado As String = If(_pagado, $"PAGADO el {_fechaPago.ToShortDateString()}", "PENDIENTE")
            Return $"Recibo #{_idRecibo} ({_concepto} : {_importe:C} [{estado}]"
        End Function

        Public Function GuardarRecibo() As Boolean
            Dim carpeta As String = "Ficheros"
            Dim rutaFichero As String = System.IO.Path.Combine(carpeta, "recibos.txt")
            Try
                If Not System.IO.Directory.Exists(carpeta) Then System.IO.Directory.CreateDirectory(carpeta)

                Dim linea As String = $"{_idRecibo}|{_concepto}|{_importe}|{_pagado}|{_fechaPago}"
                System.IO.File.WriteAllText(rutaFichero, linea)
                Return True
            Catch ex As Exception
                Console.WriteLine($"Error guardando recibo: {ex.Message}")
                Return False
            End Try
        End Function

        Public Sub CargarRecibo()
            Dim rutaFichero As String = "Ficheros\recibos.txt"
            If Not System.IO.File.Exists(rutaFichero) Then Exit Sub

            Try
                Dim linea As String = System.IO.File.ReadAllText(rutaFichero)
                If String.IsNullOrWhiteSpace(linea) Then Exit Sub
                linea = linea.Trim()

                Dim campos() As String = linea.Split("|"c)

                If campos.Length >= 6 Then
                    Me._idRecibo = Integer.Parse(campos(0))
                    Me._concepto = campos(2)
                    Me._importe = Double.Parse(campos(3))
                    Me.Pagado = Boolean.Parse(campos(4))
                    Dim fec As Date = Date.Parse(campos(5))
                    If Me.Pagado Then Me._fechaPago = fec
                End If
            Catch ex As Exception
                Console.WriteLine("Error al cargar recibo")
            End Try
        End Sub
    End Class
End Namespace