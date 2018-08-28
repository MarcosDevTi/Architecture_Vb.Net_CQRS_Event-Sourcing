Namespace Cqrs.Command
    Public Class Message
        Implements IRequest

        Public Sub New()
            MessageType = [GetType]().Name
        End Sub
        
        public Property MessageType As String
        Public Property AggregateId As Guid
    End Class
End NameSpace