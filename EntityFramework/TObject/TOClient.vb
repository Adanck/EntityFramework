Public Class TOClient

    Sub New()

    End Sub

    Sub New(id As Integer, name As String, lastName As String, email As String, phoneNumber As Integer)
        Me.Id = id
        Me.Name = name
        Me.LastName = lastName
        Me.Email = email
        Me.PhoneNumber = phoneNumber
    End Sub

    Public Property Id As Integer
    Public Property Name As String
    Public Property LastName As String
    Public Property Email As String
    Public Property PhoneNumber As Integer

End Class
