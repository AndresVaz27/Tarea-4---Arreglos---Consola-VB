Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace Tarea_2___Segundo_Semestre
    Friend Class Persona
        Protected nombre As String
        Protected fechaNacimiento As DateTime?

        Public Property Nombre_ As String
            Get
                Return nombre
            End Get
            Set(ByVal value As String)
                nombre = value
            End Set
        End Property

        Public Property FechaNacimiento_ As DateTime?
            Get
                Return fechaNacimiento
            End Get
            Set(ByVal value As DateTime?)
                fechaNacimiento = value
            End Set
        End Property

        Public ReadOnly Property Edad_ As Integer
            Get
                Dim edad As Integer
                edad = (DateTime.Now.Year - fechaNacimiento.Value.Year)

                If fechaNacimiento.Value.Month >= DateTime.Now.Month Then
                    edad -= 1
                End If

                Return edad
            End Get
        End Property

        Public Sub New()
            nombre = String.Empty
            fechaNacimiento = Nothing
        End Sub

        Public Sub New(ByVal nombre As String, ByVal fechaNacimiento As DateTime?)
            Me.nombre = nombre
            Me.fechaNacimiento = fechaNacimiento
        End Sub

        Public Overrides Function ToString() As String
            Return "NOMBRE: " & nombre.ToUpper() & " " & "---" & " EDAD: " & Edad_
        End Function
    End Class
End Namespace
Public Class Persona

End Class
