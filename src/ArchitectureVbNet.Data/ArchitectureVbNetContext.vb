Imports System.Data.Entity
Imports ArchitectureVbNet.Data.Maps
Imports ArchitectureVbNet.Domain

Public Class ArchitectureVbNetContext
    Inherits DbContext
    Public Sub New()
        MyBase.New("ArchitectureVbNet")
    End Sub
    public Property Customers As DbSet(Of Customer)
    Public Property Products As DbSet(Of Product)
    Public Property OrderItems As DbSet(Of OrderItem)
    Public Property Orders As DbSet(Of Order)

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        'modelBuilder.Conventions.Add(new ProductMap())
        'modelBuilder.Conventions.Add(new OrderItemMap())
        'modelBuilder.Conventions.Add(new OrderMap())
        'modelBuilder.Conventions.Add(new CustomerMap())
        'MyBase.OnModelCreating(modelBuilder)
    End Sub
End Class
