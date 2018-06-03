Public Class Product

    Sub New()

    End Sub

    Sub New(code As String, description As String, price As Double, amount As Integer)
        Me.Code = code
        Me.Description = description
        Me.Price = price
        Me.Amount = amount

    End Sub
    Public Property Code As String
    Public Property Description As String
    Public Property Price As Double
    Public Property Amount As Integer


End Class
