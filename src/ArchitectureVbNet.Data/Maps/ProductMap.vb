Imports System.Data.Entity.ModelConfiguration
Imports ArchitectureVbNet.Domain

Namespace Maps
    Public Class ProductMap
        Inherits EntityTypeConfiguration(Of Product)

        Public Sub New()
            ToTable("Products")
            HasKey(Function(p) p.Id)
            [Property](Function(p) p.Name).HasMaxLength(30).IsRequired()
            [Property](Function(p) p.DescriptionProduct).HasMaxLength(150)
        End Sub
        
    End Class
End NameSpace