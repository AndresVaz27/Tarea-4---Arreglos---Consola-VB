Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace Tarea_2___Segundo_Semestre
    Friend Class Contacto
        Inherits Persona

        Private telefono As String
        Private correo As String

        Public Property Correo_ As String
            Get
                Return correo
            End Get
            Set(ByVal value As String)
                correo = value.Replace(" ", "").ToLower()
            End Set
        End Property

        Public Property Telefono_ As String
            Get
                Return telefono
            End Get
            Set(ByVal value As String)
                telefono = value.Replace(" ", "").Replace("-", "")
            End Set
        End Property

        Public Sub New()
            MyBase.New()
            telefono = String.Empty
        End Sub

        Public Sub New(ByVal nombre As String, ByVal fechaNacimiento As DateTime?, ByVal telefono As String)
            MyBase.New(nombre, fechaNacimiento)
            Me.telefono = telefono
        End Sub

        Public Overrides Function ToString() As String
            Return MyBase.ToString() & " " & "---" & " TELEFONO: " & telefono & " " & "---" & " CORREO: " & correo.ToUpper()
        End Function
    End Class
End Namespace