Imports System.Data.Entity.Migrations
Imports ArchitectureVbNet.CqrsClient.Command.Customer
Imports ArchitectureVbNet.Shared.Cqrs.Command

Namespace Handlers.Customer
    Public Class CustomerCommandHandler
        Implements ICommandHandler(Of CreateCustomer),
                   ICommandHandler(Of UpdateCustomer),
                   ICommandHandler(Of DeleteCustomer)
        Private ReadOnly _context As ArchitectureVbNetContext

        Sub New(context As ArchitectureVbNetContext)
            _context = context
        End Sub

        Public Sub Handle(command As CreateCustomer) Implements ICommandHandler(Of CreateCustomer).Handle
            _context.Customers.Add(New Domain.Customer(command.Name, command.Email, command.BirthDate))
            _context.SaveChanges()
        End Sub

        Public Sub Handle(command As UpdateCustomer) Implements ICommandHandler(Of UpdateCustomer).Handle
            _context.Customers.AddOrUpdate(New Domain.Customer(command.Name, command.Email, command.BirthDate, command.Id))
            _context.SaveChanges()
        End Sub

        Public Sub Handle(command As DeleteCustomer) Implements ICommandHandler(Of DeleteCustomer).Handle
            Dim customer = _context.Customers.Find(command.Id)
            _context.Customers.Remove(customer)
            _context.SaveChanges()
        End Sub
    End Class
End Namespace