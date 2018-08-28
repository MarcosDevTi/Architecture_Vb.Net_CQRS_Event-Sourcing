Imports System.Data.Entity
Imports ArchitectureVbNet.Domain

Public Class EventSourcingContext
    Inherits DbContext
    Public Sub New()
        MyBase.New("ArchitectureVbNet")
    End Sub
    public Property Customers As DbSet(Of Customer)
    Public Property Products As DbSet(Of Product)
    Public Property OrderItems As DbSet(Of OrderItem)
    Public Property Orders As DbSet(Of Order)
End Class
