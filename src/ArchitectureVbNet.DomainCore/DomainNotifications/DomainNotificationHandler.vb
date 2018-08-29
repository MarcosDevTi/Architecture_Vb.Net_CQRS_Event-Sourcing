Namespace DomainNotifications
    Public Class DomainNotificationHandler
        Implements IDomainNotification

        Private _notifications As List(Of DomainNotification)

        Sub New()
            _notifications = New List(Of DomainNotification)()
        End Sub

        Public Sub Add(domainNotification As DomainNotification) Implements IDomainNotification.Add
            _notifications.Add(domainNotification)
        End Sub

        Public Function GetNotifications() As List(Of DomainNotification) Implements IDomainNotification.GetNotifications
            Return _notifications
        End Function

        Public Function HasNotifications() As Boolean Implements IDomainNotification.HasNotifications
            Return GetNotifications().Any()
        End Function

        Public Sub Dispose() Implements IDomainNotification.Dispose
            _notifications = New List(Of DomainNotification)()
        End Sub
    End Class
End Namespace