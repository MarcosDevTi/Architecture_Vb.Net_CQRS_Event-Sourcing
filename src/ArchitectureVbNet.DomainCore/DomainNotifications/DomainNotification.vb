Imports ArchitectureVbNet.Shared.Cqrs.Command

Namespace DomainNotifications
    Public Class DomainNotification
        Inherits CommandEvent

        Public Sub New(key As String, value As String)
            DomainNotificationId = Guid.NewGuid()
            Key = key
            Value = value
            Vertion = 1
        End Sub
        
        public DomainNotificationId as Guid
        public Key As String
        public Value As String
        public Vertion As Integer
    End Class
End NameSpace