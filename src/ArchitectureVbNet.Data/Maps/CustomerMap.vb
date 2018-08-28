Imports System.Data.Entity.ModelConfiguration
Imports ArchitectureVbNet.Domain

Namespace Maps
    Public Class CustomerMap
        Inherits EntityTypeConfiguration(Of Customer)
        public Sub New ()
            HasKey(Function(c) c.Id)
            [Property](Function(c) c.Name).HasMaxLength(50)
            [Property](Function(c) c.Email).HasMaxLength(80)
            HasMany(Function(c) c.Orders).WithRequired(Function(o) o.Customer)
        End Sub
    End Class
End NameSpace