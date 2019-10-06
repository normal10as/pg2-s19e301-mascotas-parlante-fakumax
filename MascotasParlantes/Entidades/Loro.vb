Public Class Loro

    '---Campos---
    Private memoria As Queue(Of String)
    Private _edad As Short
    Private _fechaNacimiento As Date
    Private _nombre As String
    Private _frase As String
    '---Fin Campos---

    '---Constructor---
    Sub New()
        Me.memoria = New Queue(Of String)
        Me.FechaNacimiento = _fechaNacimiento
        Nombre = ""

    End Sub
    '--- Fin Constructor---

    '---Propiedades---
    Public ReadOnly Property Edad As Short
        Get
            Return CalcularEdad(FechaNacimiento)
        End Get
    End Property
    Public Property FechaNacimiento As Date
        Get
            Return _fechaNacimiento
        End Get
        Set(value As Date)
            _fechaNacimiento = value
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
    Public Property Frase As String
        Get
            Return _frase
        End Get
        Set(value As String)
            _frase = value
        End Set
    End Property
    '---Fin Propiedades---

    '---Metodos---
    Private Function CalcularEdad(fechaNacimiento As Date) As UShort
        'Return DateDiff(DateInterval.Year, FechaNacimiento, Now)
        If DateTime.Now.Month >= fechaNacimiento.Month And DateTime.Now.Day >= fechaNacimiento.Day Then
            Return DateTime.Now.Year - fechaNacimiento.Year
        Else
            Return DateTime.Now.Year - (fechaNacimiento.Year + 1)
        End If
    End Function
    Public Sub Escuchar(frase As String)
        memoria.Enqueue(frase)
    End Sub
    Public Function Hablar() As String
        If memoria.Count > 0 Then
            Frase += memoria.Dequeue
            Return Frase
        End If
        Return Frase
    End Function
    Public Overrides Function ToString() As String
        Return Nombre
    End Function
    '---Fin Metodos---

End Class
