Imports FluentValidation.Results

Namespace Cqrs.Command
    Public MustInherit Class Command
        Inherits Message
        Protected Sub New()
           Timestamp = DateTime.Now
        End Sub      
        public Property Timestamp As DateTime
        Public Property ValidationResult As ValidationResult
        Public MustOverride Function IsValid() As Boolean
    End Class
End NameSpace