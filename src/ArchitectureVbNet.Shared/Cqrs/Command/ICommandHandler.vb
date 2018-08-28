Namespace Cqrs.Command
    Public Interface ICommandHandler(Of TCommand As IRequest)
        Sub Handle(command As TCommand)
    End Interface
End NameSpace