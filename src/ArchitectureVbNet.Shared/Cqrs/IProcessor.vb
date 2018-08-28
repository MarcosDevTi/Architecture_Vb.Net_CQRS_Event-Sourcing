Imports ArchitectureVbNet.Shared.Cqrs.Query

Namespace Cqrs
    Public Interface IProcessor
        Sub Send(Of TCommand As Command.CommandRequest)(command As TCommand)
        Function Process(Of TResult)(query As IQuery(Of TResult)) As TResult
    End Interface
End NameSpace