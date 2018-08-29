Imports ArchitectureVbNet.CqrsClient.Query.Customer
Imports ArchitectureVbNet.Shared.Cqrs.Query
Imports AutoMapper.QueryableExtensions

Namespace Handlers.Customer
    Public Class CustomerQueryHandler
        Implements IQueryHandler(Of GetCustomersIndex, IReadOnlyList(Of CustomerIndex)),
                   IQueryHandler(Of GetCustomerDetails, CustomerDetails)

        private ReadOnly _context As ArchitectureVbNetContext

        Sub New(context As ArchitectureVbNetContext)
            _context = context
        End Sub

        Public Function Handle(query As GetCustomersIndex) As IReadOnlyList(Of CustomerIndex) _
                 Implements IQueryHandler(Of GetCustomersIndex, IReadOnlyList(Of CustomerIndex)).Handle
            Return _context.Customers.ProjectTo(Of CustomerIndex).ToList()
        End Function

        Public Function Handle(query As GetCustomerDetails) As CustomerDetails Implements IQueryHandler(Of GetCustomerDetails, CustomerDetails).Handle
            Dim customer = _context.Customers.Find(query.Id)
            Return New CustomerDetails With{
                .Name = customer.Name, 
                .Email = customer.Email, 
                .BirthDate = customer.BirthDate}
        End Function
    End Class
End Namespace