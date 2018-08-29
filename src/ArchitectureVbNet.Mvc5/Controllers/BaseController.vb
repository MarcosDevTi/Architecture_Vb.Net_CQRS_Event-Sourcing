Imports ArchitectureVbNet.DomainCore.DomainNotifications

Namespace Controllers
    Public Class BaseController
        Inherits Controller
        Private ReadOnly _notifications As IDomainNotification

        Sub New (notifications As IDomainNotification)
            _notifications = notifications
        End Sub

        Function IsValidOperation() As Boolean
            return Not _notifications.HasNotifications()
        End Function
    End Class
End NameSpace