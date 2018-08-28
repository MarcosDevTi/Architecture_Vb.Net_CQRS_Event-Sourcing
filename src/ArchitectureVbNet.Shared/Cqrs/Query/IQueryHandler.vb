Namespace Cqrs.Query
    Public Interface IQueryHandler(Of in TQuery As IQuery(Of TResult), out TResult)
        Function Handle (query As TQuery) As TResult
    End Interface
End NameSpace