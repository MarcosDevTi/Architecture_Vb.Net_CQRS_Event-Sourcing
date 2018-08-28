Imports ArchitectureVbNet.Shared.Cqrs
Imports ArchitectureVbNet.Shared.Cqrs.Command
Imports ArchitectureVbNet.Shared.Cqrs.Query
Imports SimpleInjector

Public Class Processor 
    Implements IProcessor
    Private ReadOnly _container As Container

    Sub New(container As Container)
        _container = container
    End Sub

    Public Sub Send (Of TCommand As CommandRequest)(command As TCommand) Implements IProcessor.Send
        GetHandle(GetType(ICommandHandler (Of )), command.GetType()).Handle(command)
    End Sub

    Public Function Process (Of TResult)(query As IQuery(Of TResult)) As TResult Implements IProcessor.Process
        Return GetHandle(GetType(IQueryHandler(Of ,)), query.GetType(), GetType(TResult)).Handle(query)
    End Function

    public Function GetHandle(handle As Type,ParamArray types As Type())
        Return _container.GetInstance(handle.MakeGenericType(types))
    End Function
End Class
