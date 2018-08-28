Imports ArchitectureVbNet.DomainCore.Models

Public Class OrderItem
    Inherits Entity
    Protected Sub New()
        'Ctor EF
    End Sub

    Public Sub New(product As Product, qtd As Short)
        Me.Product = product
        Me.Qtd = qtd
    End Sub
    
    public Property Product As Product
    Public Property Qtd as Int16
End Class
