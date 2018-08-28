Imports System.Data.Entity
Imports ArchitectureVbNet.Data.Maps.EventSourcing
Imports ArchitectureVbNet.Domain

Public Class EventSourcingContext
    Inherits DbContext
    Public Sub New()
        MyBase.New("ArchitectureVbNet")
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        modelBuilder.Conventions.Add(new StoreEventMap())
    End Sub
End Class
