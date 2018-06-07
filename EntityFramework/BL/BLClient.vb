Public Class BLClient
    ' Insertar, Modificar, Consultar y Eliminar 
    'Cédula, Nombre, Apellido, Correo Electrónico -validar formato correcto- y teléfono

    Property idNumber As Integer
    Property Name As String
    Property LastName As String
    Property Email As String
    Property Telephone As Integer

    Sub New()

    End Sub

    Sub New(idnumber As Integer, name As String, lastName As String, email As String, phone As Integer)
        Me.idNumber = idnumber
        Me.Name = name
        Me.LastName = lastName


    End Sub
End Class
