Imports ArchitectureVbNet.CqrsClient.Command.Customer
Imports ArchitectureVbNet.CqrsClient.Command.Product
Imports ArchitectureVbNet.Shared.Cqrs.Command

Namespace Handlers.Product
    Public Class ProductCommandHandler 
        Implements ICommandHandler(Of CreateProduct),
                   ICommandHandler(Of UpdateProduct),
                   ICommandHandler(Of DeleteProduct)
        Private ReadOnly _context As ArchitectureVbNetContext

        Sub New(context As ArchitectureVbNetContext)
            _context = context
        End Sub


        Public Sub Handle(command As CreateProduct) Implements ICommandHandler(Of CreateProduct).Handle
            Throw New NotImplementedException
        End Sub

        Public Sub Handle(command As UpdateProduct) Implements ICommandHandler(Of UpdateProduct).Handle
            Throw New NotImplementedException
        End Sub

        Public Sub Handle(command As DeleteProduct) Implements ICommandHandler(Of DeleteProduct).Handle
            Throw New NotImplementedException
        End Sub
    End Class
End NameSpace