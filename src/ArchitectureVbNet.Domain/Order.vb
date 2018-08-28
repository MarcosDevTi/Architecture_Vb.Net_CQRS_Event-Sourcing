Imports ArchitectureVbNet.DomainCore.Models

Public Class Order
    Inherits Entity
    Public Sub New()
        'Ctor EF
    End Sub
    public Property Customer As Customer
    Public Property OrderItems As ICollection(Of OrderItem)
    Public Property Closed As Boolean

End Class
