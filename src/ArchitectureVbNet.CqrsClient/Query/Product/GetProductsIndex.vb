Imports ArchitectureVbNet.Shared.Cqrs.Query

Namespace Query.Product
    Public Class GetProductsIndex 
        Implements IQuery(Of IReadOnlyList(Of ProductIndex))
    End Class
End NameSpace