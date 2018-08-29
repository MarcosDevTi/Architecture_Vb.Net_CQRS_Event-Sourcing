Namespace DomainNotifications
    Public Interface IDomainNotification

        Sub Add(domainNotification As DomainNotification)
        Function GetNotifications() As List(Of DomainNotification)
        Function HasNotifications() As Boolean
        Sub Dispose()

    End Interface
End NameSpace