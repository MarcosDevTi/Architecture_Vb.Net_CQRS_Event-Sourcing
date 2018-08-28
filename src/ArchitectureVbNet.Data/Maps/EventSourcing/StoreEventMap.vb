Imports System.Data.Entity.ModelConfiguration
Imports ArchitectureVbNet.DomainCore.EventE

Namespace Maps.EventSourcing
    Public Class StoreEventMap
        Inherits EntityTypeConfiguration(Of StoredEvent)
        public Sub New ()
            [Property](Function(e)e.TimeStamp).HasColumnName("CreationDate")
            [Property](Function(e) e.MessageType).HasColumnName("Action").HasMaxLength(100)
        End Sub
    End Class
End NameSpace