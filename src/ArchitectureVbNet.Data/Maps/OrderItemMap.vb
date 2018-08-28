Imports System.Data.Entity.ModelConfiguration
Imports ArchitectureVbNet.Domain

Namespace Maps
    Public Class OrderItemMap
        Inherits EntityTypeConfiguration(Of OrderItem)

        Public Sub New()
            HasRequired(Function(oi) oi.Product)
        End Sub
        
    End Class
End NameSpace