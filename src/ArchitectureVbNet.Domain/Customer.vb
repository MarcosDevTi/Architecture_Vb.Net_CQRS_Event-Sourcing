
Imports ArchitectureVbNet.DomainCore.Models

Public Class Customer
    Inherits Entity
    Protected Sub New()
    End Sub

    Public Sub New(
                   name As String,
                   email As String,
                   birthDate As Date,
                   orders As ICollection(Of Order))
        Me.Name = name
        Me.Email = email
        Me.BirthDate = birthDate
        Me.Orders = orders
    End Sub

    Public Property Name As String
    Public Property Email As String
    Public Property BirthDate As DateTime
    Public Property Orders As ICollection(Of Order)
End Class
