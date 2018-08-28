Imports System.Runtime.CompilerServices
Imports ArchitectureVbNet.Shared.Cqrs.Command
Imports ArchitectureVbNet.Shared.Cqrs.Query
Imports SimpleInjector

Namespace Extentions
    Public Module CqrsExtentions
        <Extension>
        Public Sub AddCqrs(Of T)(container As Container)
            Dim handlers() As Type = {GetType(IQueryHandler(Of,)), GetType(ICommandHandler(Of ))}

            Dim target = GetType(T).Assembly
            Dim assemblies = target.ExportedTypes

            Dim types = From tp In assemblies
                        From i In tp.GetInterfaces()
                        Where i.IsConstructedGenericType
                        Where Not tp.IsAbstract And Not tp.IsInterface
                        Where handlers.Contains(i.GetGenericTypeDefinition())
                        Select New With {i, tp}

            For Each type In types
                container.Register(type.i, type.tp)
            Next

        End Sub
    End Module
End Namespace