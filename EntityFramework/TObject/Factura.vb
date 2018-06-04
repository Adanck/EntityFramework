Public Class Factura
    'Facturación: Debe permitir al usuario crear facturas. Para esto, se selecciona un cliente existente
    'en la base de datos y se procede a agregar una serie de líneas de detalle (Producto, cantidad, 
    'precio unitario, sub total). Al finalizar la factura, toda esta información debe guardarse en la 
    'base de datos junto con la fecha y hora de la creación de la factura (La fecha y hora se toman 
    'del servidor de bases de datos). Los saldos de los productos deben quedar actualizados en la 
    'base de datos.
    Public Property producto As String
    Public Property cantidad As Integer
    Public Property precio As Double
    Public Property subTotal As Double

    Sub New()

    End Sub


End Class
