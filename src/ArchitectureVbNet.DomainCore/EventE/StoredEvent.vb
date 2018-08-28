Imports ArchitectureVbNet.Shared.Cqrs.Command
Imports Newtonsoft.Json

Namespace EventE
    Public Class StoredEvent
        Inherits CommandEvent
        Protected Sub New
            'Ctor EF
        End Sub

        public Sub New (theEvent As CommandEvent, user As String)
            dim jsonEvent = JsonConvert.SerializeObject(theEvent)
            Id = Guid.NewGuid()
            AggregateId = theEvent.AggregateId
            MessageType = theEvent.MessageType
            Data = jsonEvent
            Me.User = user
        End Sub
        public Id As Guid
        public Data As String
        public User as String
    End Class
End NameSpace