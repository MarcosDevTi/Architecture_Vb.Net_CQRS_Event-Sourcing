Namespace Cqrs.Command
    Public Class CommandEvent
        Inherits Message
        Protected Sub New()
            TimeStamp = DateTime.Now
        End Sub
        public Property TimeStamp As DateTime
    End Class
End NameSpace