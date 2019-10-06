Imports System
Imports Entidades
Module LoroTest
    Sub Main(args As String())

        Dim lorito As Loro
        lorito = New Loro()

        lorito.Nombre = "pepe"
        lorito.FechaNacimiento = "1 / 11 / 2010"

        'Escuchar x3'
        lorito.Escuchar("papita ")
        lorito.Escuchar("pa el loro ")
        lorito.Escuchar("juan")

        'Hablar x4
        Console.WriteLine(lorito.Hablar())
        Console.WriteLine(lorito.Hablar())
        Console.WriteLine(lorito.Hablar())
        Console.WriteLine(lorito.Hablar())

        Console.WriteLine("Nombre ToString():" & lorito.ToString())
        Console.WriteLine("La edad es: {0} años", lorito.Edad)


    End Sub

End Module
