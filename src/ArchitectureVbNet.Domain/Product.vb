Imports ArchitectureVbNet.DomainCore.Models

Public Class Product
    Inherits Entity

    Protected Sub New()
        'Ctor EF
    End Sub

    Public Sub New(
                   name As String,
                   description As String,
                   price As Decimal,
                   Optional id As Guid? = Nothing)

        Me.Id = If(id Is Nothing, Guid.NewGuid(), Me.Id)
        Me.Name = name
        Me.DescriptionProduct = description
        Me.Price = price
    End Sub

    Public Property Name As String
    Public Property DescriptionProduct As String
    Public Property Price As Decimal
End Class
