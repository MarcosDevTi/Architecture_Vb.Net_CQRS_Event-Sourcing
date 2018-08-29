Imports ArchitectureVbNet.Shared.Cqrs.Command

Namespace Command.Product
    Public Class CreateProduct 
        Inherits ProductCommand

        Public Overrides Function IsValid() As Boolean
            Throw New NotImplementedException
        End Function
    End Class
End NameSpace