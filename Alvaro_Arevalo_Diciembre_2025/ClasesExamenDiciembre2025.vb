Namespace ClasesExamenDiciembre2025
    Public Class Alumno
        Private _nmat As Integer
        Private _dni As String
        Private _nombre As String
        Private _apellido1 As String
        Private _apellido2 As String
        Private _domicilio As String
        Private _telefono As String
        Private _fechaNacimiento As Date

        Public Sub New()
        End Sub

        ' Modificamos IntroducirDatos para incluir los nuevos campos
        Public Sub IntroducirDatos(NewDni As String, NewNmat As Integer, NewName As String, NewApellido1 As String, NewApellido2 As String, NewDomicilio As String, NewTelefono As String, NewFechNacimiento As Date)
            _dni = NewDni
            If String.IsNullOrWhiteSpace(_dni) Then _dni = "00000000A"

            _nmat = NewNmat
            If _nmat = 0 Then _nmat = -1

            _nombre = NewName
            If String.IsNullOrWhiteSpace(_nombre) Then _nombre = "Sin Nombre"

            _apellido1 = NewApellido1
            If String.IsNullOrWhiteSpace(_apellido1) Then _apellido1 = "Sin Apellido1"

            _apellido2 = NewApellido2
            If String.IsNullOrWhiteSpace(_apellido2) Then _apellido2 = "Sin Apellido2"

            _domicilio = NewDomicilio
            If String.IsNullOrWhiteSpace(_domicilio) Then _domicilio = "Sin Domicilio"

            _telefono = NewTelefono
            If String.IsNullOrWhiteSpace(_telefono) Then _telefono = "000000000"

            _fechaNacimiento = NewFechNacimiento
            If _fechaNacimiento = Nothing Then _fechaNacimiento = Date.Today
        End Sub

        Public Property NMat As Integer
            Get
                Return _nmat
            End Get
            Set(value As Integer)
                _nmat = value
            End Set
        End Property

        Public Property DNI As String
            Get
                Return _dni
            End Get
            Set(value As String)
                _dni = value
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

        Public Property Apellido1 As String
            Get
                Return _apellido1
            End Get
            Set(value As String)
                _apellido1 = value
            End Set
        End Property

        Public Property Apellido2 As String
            Get
                Return _apellido2
            End Get
            Set(value As String)
                _apellido2 = value
            End Set
        End Property

        Public Property Domicilio As String
            Get
                Return _domicilio
            End Get
            Set(value As String)
                _domicilio = value
            End Set
        End Property

        Public Property Telefono As String
            Get
                Return _telefono
            End Get
            Set(value As String)
                _telefono = value
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

        Public Function CalcularEdad() As Integer
            Dim hoy As Date = Date.Today
            Dim edad As Integer = hoy.Year - _fechaNacimiento.Year
            If _fechaNacimiento.Date > hoy.AddYears(-edad) Then
                edad -= 1
            End If
            Return edad
        End Function

        Public Function ObtenerNombreCompleto() As String
            Return $"{_apellido1} {_apellido2}, {_nombre}"
        End Function

        Public Overrides Function ToString() As String
            Return $"[DNI: {_dni}] {ObtenerNombreCompleto()} - Tel: {_telefono}"
        End Function

        Public Function GuardarAlumno() As Boolean
            Dim carpeta As String = "Ficheros"
            Dim rutaFichero As String = System.IO.Path.Combine(carpeta, "alumnos.txt")
            Dim datosAlumno As String

            Try
                If Not System.IO.Directory.Exists(carpeta) Then System.IO.Directory.CreateDirectory(carpeta)

                ' Formato con los nuevos campos separados
                datosAlumno = $"{Me.DNI}|{Me.NMat}|{Me.Nombre}|{Me.Apellido1}|{Me.Apellido2}|{Me.Domicilio}|{Me.Telefono}|{Me.FechaNacimiento.ToShortDateString()}" & Environment.NewLine

                ' Usamos AppendAllText para guardar uno debajo de otro
                System.IO.File.AppendAllText(rutaFichero, datosAlumno)
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
                ' Ahora esperamos 8 campos
                If campos.Length = 8 Then
                    Me.DNI = campos(0)
                    Me.NMat = Integer.Parse(campos(1))
                    Me.Nombre = campos(2)
                    Me.Apellido1 = campos(3)
                    Me.Apellido2 = campos(4)
                    Me.Domicilio = campos(5)
                    Me.Telefono = campos(6)
                    Me.FechaNacimiento = Date.Parse(campos(7))
                End If
            Catch ex As Exception
                Console.WriteLine($"Error al cargar alumno: {ex.Message}")
            End Try
        End Sub
    End Class

    ' Clase Academico HEREDA de Alumno y tiene ArrayList de Asignaturas
    Public Class Academico
        Inherits Alumno

        Private _asignaturas As System.Collections.ArrayList

        Public Sub New()
            MyBase.New()
            _asignaturas = New System.Collections.ArrayList()
        End Sub

        Public Sub AgregarAsignatura(asignatura As String)
            If Not String.IsNullOrWhiteSpace(asignatura) Then
                _asignaturas.Add(asignatura)
            End If
        End Sub

        Public Property ListaAsignaturas As System.Collections.ArrayList
            Get
                Return _asignaturas
            End Get
            Set(value As System.Collections.ArrayList)
                _asignaturas = value
            End Set
        End Property

        ' Método auxiliar para obtener asignaturas como array de strings si se necesita compatibilidad
        Public Function GetAsignaturasArray() As String()
            Return CType(_asignaturas.ToArray(GetType(String)), String())
        End Function
    End Class

    Public Class Notas
        Inherits Alumno
        Private _nombreCurso As String
        Private _notasParciales As Double()
        Private _notaFinalOrdinaria As Double
        Private _notaFinalExtraordinaria As Double

        Public Sub New()
            ' Inicializar array vacío para no afectar la media con un 0 inicial
            ReDim _notasParciales(-1)
        End Sub

        Public Sub IntroducirDatosCurso(NewNombre As String)
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
                _notasParciales(i) = nota
            Else
                MessageBox.Show("La nota debe estar entre 0 y 10")
            End If
        End Sub

        Public Function CalcularMediaParciales() As Double
            If _notasParciales.Length = 0 Then Return 0.0
            Dim suma As Double = 0
            For Each n In _notasParciales
                suma += n
            Next
            Return suma / _notasParciales.Length
        End Function

        Public Function GuardarNota() As Boolean
            Dim carpeta As String = "Ficheros"
            Dim rutaFichero As String = System.IO.Path.Combine(carpeta, "notas.txt")

            Try
                If Not System.IO.Directory.Exists(carpeta) Then System.IO.Directory.CreateDirectory(carpeta)

                ' Se guarda asociado al curso. Nota: Al heredar de Alumno, idealmente guardariamos DNI tambien, 
                ' pero mantengo logica simple anterior si no se exige cambio especifico en persistencia de notas.
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

                If campos.Length >= 4 Then
                    Me.NombreCurso = campos(0)
                    Dim parcialesStr As String = campos(1)
                    Me.NotaFinalOrdinaria = Double.Parse(campos(2))
                    Me.NotaFinalExtraordinaria = Double.Parse(campos(3))

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

        Public Sub IntroducirDatosRecibo(NewId As String, NewConcepto As String, NewImporte As Double)
            _idRecibo = NewId
            If String.IsNullOrWhiteSpace(_idRecibo) Then _idRecibo = "000AA"

            _concepto = NewConcepto
            If String.IsNullOrWhiteSpace(_concepto) Then _concepto = "Varios"

            _importe = NewImporte
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

        Public Property Importe As Double
            Get
                Return _importe
            End Get
            Set(value As Double)
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

                If campos.Length >= 5 Then
                    Me._idRecibo = campos(0)
                    Me._concepto = campos(1)
                    Me._importe = Double.Parse(campos(2))
                    Me.Pagado = Boolean.Parse(campos(3))
                    Dim fec As Date = Date.Parse(campos(4))
                    If Me.Pagado Then Me._fechaPago = fec
                End If
            Catch ex As Exception
                Console.WriteLine("Error al cargar recibo")
            End Try
        End Sub
    End Class
End Namespace