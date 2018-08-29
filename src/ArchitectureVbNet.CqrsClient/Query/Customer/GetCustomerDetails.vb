Imports ArchitectureVbNet.Shared.Cqrs.Query

Namespace Query.Customer
    Public Class GetCustomerDetails
        Implements IQuery(Of CustomerDetails)

        Public Id As Guid

    End Class
End Namespace