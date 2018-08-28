Imports System.Data.Entity.ModelConfiguration
Imports ArchitectureVbNet.Domain

Namespace Maps
    Public Class OrderMap
        Inherits EntityTypeConfiguration(Of Order)

        Public Sub New()
           HasMany(Function(o) o.OrderItems)
        End Sub
        
    End Class
End NameSpace