Imports ArchitectureVbNet.Shared.Cqrs.Query

Namespace Query.Customer
    Public Class GetCustomersIndex 
        Implements IQuery(Of IReadOnlyList(Of CustomerIndex))
        'TODO: Properties Pagination
    End Class
End NameSpace