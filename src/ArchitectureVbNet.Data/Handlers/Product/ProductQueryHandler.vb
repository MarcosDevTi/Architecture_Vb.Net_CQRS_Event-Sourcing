Imports ArchitectureVbNet.CqrsClient.Query.Customer
Imports ArchitectureVbNet.CqrsClient.Query.Product
Imports ArchitectureVbNet.Shared.Cqrs.Query
Imports AutoMapper.QueryableExtensions

Namespace Handlers.Product
    Public Class ProductQueryHandler
        Implements IQueryHandler(Of GetProductsIndex, IReadOnlyList(Of ProductIndex))
        Private ReadOnly _context As ArchitectureVbNetContext

        Sub New(context As ArchitectureVbNetContext)
            _context = context
        End Sub

        Public Function Handle(query As GetProductsIndex) As IReadOnlyList(Of ProductIndex) Implements IQueryHandler(Of GetProductsIndex, IReadOnlyList(Of ProductIndex)).Handle
            Return _context.Products.ProjectTo(Of ProductIndex).ToList()
        End Function
    End Class
End Namespace