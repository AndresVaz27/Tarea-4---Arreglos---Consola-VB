Imports System
Imports Tarea_4___Arreglos___Consola_VB.Tarea_2___Segundo_Semestre

Module Program
    Sub Main(args As String())
        Dim cantidadContactos = 0
        Dim siguienteIndex = 0
        Dim contactos As Contacto()
        Dim contactoList As List(Of Contacto)
        contactoList = New List(Of Contacto)()

        While cantidadContactos = 0
            Try
                Console.WriteLine("Cuantos contactos deseas agregar?")
                cantidadContactos = Integer.Parse(Console.ReadLine())
            Catch e As Exception
                Console.WriteLine("El formato no es correcto, ingrese números enteros únicamente, por favor.")
            End Try
        End While

        contactos = New Contacto(cantidadContactos - 1) {}

        While siguienteIndex < contactos.Length
            Dim nuevo As Contacto = New Contacto()
            Console.WriteLine("Nombre: ")
            nuevo.Nombre_ = Console.ReadLine()
            Console.Clear()
            Console.WriteLine("Telefono: ")
            nuevo.Telefono_ = Console.ReadLine()
            Console.Clear()
            Console.WriteLine("Fecha de Nacimiento (dd/mm/aaaa): ")
            While nuevo.FechaNacimiento_ Is Nothing
                Try
                    nuevo.FechaNacimiento_ = Date.Parse(Console.ReadLine())
                Catch __unusedException1__ As Exception
                    Console.WriteLine("El formato de la fecha debe de ser dd/mm/aaaa.")
                End Try
            End While

            Console.Clear()
            Console.WriteLine("Correo: ")
            nuevo.Correo_ = Console.ReadLine()
            Console.Clear()

            contactos(siguienteIndex) = nuevo
            siguienteIndex += 1
        End While

        For i = 0 To contactos.Length - 1
            Console.WriteLine(contactos(i).ToString())
        Next

        Console.WriteLine("La cantidad de contactos por agregar ha sido completada. Presiona cualquier tecla para cerrar el programa.")
    End Sub
End Module
