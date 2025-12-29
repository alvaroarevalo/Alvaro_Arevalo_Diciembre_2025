<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ex_Diciembre
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AlumnoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearAlumnoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IntroducirDatosPersonalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IntroducirAsignaturasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IntroducirDatosBancariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IntroducirNotasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarDatosPersonalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarAsignaturasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarDatosBancariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarNotasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HerramientasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculadoraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConversorNotasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlumnoToolStripMenuItem, Me.ListadosToolStripMenuItem, Me.HerramientasToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AlumnoToolStripMenuItem
        '
        Me.AlumnoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CrearAlumnoToolStripMenuItem, Me.IntroducirDatosPersonalesToolStripMenuItem, Me.IntroducirAsignaturasToolStripMenuItem, Me.IntroducirDatosBancariosToolStripMenuItem, Me.IntroducirNotasToolStripMenuItem})
        Me.AlumnoToolStripMenuItem.Name = "AlumnoToolStripMenuItem"
        Me.AlumnoToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.AlumnoToolStripMenuItem.Text = "Alumno"
        '
        'CrearAlumnoToolStripMenuItem
        '
        Me.CrearAlumnoToolStripMenuItem.Name = "CrearAlumnoToolStripMenuItem"
        Me.CrearAlumnoToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.CrearAlumnoToolStripMenuItem.Text = "Crear Alumno"
        '
        'IntroducirDatosPersonalesToolStripMenuItem
        '
        Me.IntroducirDatosPersonalesToolStripMenuItem.Name = "IntroducirDatosPersonalesToolStripMenuItem"
        Me.IntroducirDatosPersonalesToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.IntroducirDatosPersonalesToolStripMenuItem.Text = "Introducir Datos Personales"
        '
        'IntroducirAsignaturasToolStripMenuItem
        '
        Me.IntroducirAsignaturasToolStripMenuItem.Name = "IntroducirAsignaturasToolStripMenuItem"
        Me.IntroducirAsignaturasToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.IntroducirAsignaturasToolStripMenuItem.Text = "Introducir Asignaturas"
        '
        'IntroducirDatosBancariosToolStripMenuItem
        '
        Me.IntroducirDatosBancariosToolStripMenuItem.Name = "IntroducirDatosBancariosToolStripMenuItem"
        Me.IntroducirDatosBancariosToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.IntroducirDatosBancariosToolStripMenuItem.Text = "Introducir Datos Bancarios"
        '
        'IntroducirNotasToolStripMenuItem
        '
        Me.IntroducirNotasToolStripMenuItem.Name = "IntroducirNotasToolStripMenuItem"
        Me.IntroducirNotasToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.IntroducirNotasToolStripMenuItem.Text = "Introducir Notas"
        '
        'ListadosToolStripMenuItem
        '
        Me.ListadosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListarDatosPersonalesToolStripMenuItem, Me.ListarAsignaturasToolStripMenuItem, Me.ListarDatosBancariosToolStripMenuItem, Me.ListarNotasToolStripMenuItem})
        Me.ListadosToolStripMenuItem.Name = "ListadosToolStripMenuItem"
        Me.ListadosToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.ListadosToolStripMenuItem.Text = "Listados"
        '
        'ListarDatosPersonalesToolStripMenuItem
        '
        Me.ListarDatosPersonalesToolStripMenuItem.Name = "ListarDatosPersonalesToolStripMenuItem"
        Me.ListarDatosPersonalesToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.ListarDatosPersonalesToolStripMenuItem.Text = "Listar Datos Personales"
        '
        'ListarAsignaturasToolStripMenuItem
        '
        Me.ListarAsignaturasToolStripMenuItem.Name = "ListarAsignaturasToolStripMenuItem"
        Me.ListarAsignaturasToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.ListarAsignaturasToolStripMenuItem.Text = "Listar Asignaturas"
        '
        'ListarDatosBancariosToolStripMenuItem
        '
        Me.ListarDatosBancariosToolStripMenuItem.Name = "ListarDatosBancariosToolStripMenuItem"
        Me.ListarDatosBancariosToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.ListarDatosBancariosToolStripMenuItem.Text = "Listar Datos Bancarios"
        '
        'ListarNotasToolStripMenuItem
        '
        Me.ListarNotasToolStripMenuItem.Name = "ListarNotasToolStripMenuItem"
        Me.ListarNotasToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.ListarNotasToolStripMenuItem.Text = "Listar Notas"
        '
        'HerramientasToolStripMenuItem
        '
        Me.HerramientasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculadoraToolStripMenuItem, Me.ConversorNotasToolStripMenuItem})
        Me.HerramientasToolStripMenuItem.Name = "HerramientasToolStripMenuItem"
        Me.HerramientasToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.HerramientasToolStripMenuItem.Text = "Herramientas"
        '
        'CalculadoraToolStripMenuItem
        '
        Me.CalculadoraToolStripMenuItem.Name = "CalculadoraToolStripMenuItem"
        Me.CalculadoraToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.CalculadoraToolStripMenuItem.Text = "Calculadora"
        '
        'ConversorNotasToolStripMenuItem
        '
        Me.ConversorNotasToolStripMenuItem.Name = "ConversorNotasToolStripMenuItem"
        Me.ConversorNotasToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.ConversorNotasToolStripMenuItem.Text = "Conversor Notas"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Ex_Diciembre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Ex_Diciembre"
        Me.Text = "Examen Diciembre Alvaro"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AlumnoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CrearAlumnoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IntroducirDatosPersonalesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IntroducirAsignaturasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IntroducirDatosBancariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IntroducirNotasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListarDatosPersonalesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListarAsignaturasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListarDatosBancariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListarNotasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HerramientasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalculadoraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConversorNotasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
End Class
