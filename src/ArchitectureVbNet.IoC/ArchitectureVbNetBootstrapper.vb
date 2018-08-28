Imports System.Web.Mvc
Imports ArchitectureVbNet.CqrsClient.Command.Customer
Imports ArchitectureVbNet.Data.Handlers.Customer
Imports ArchitectureVbNet.IoC.Extentions
Imports ArchitectureVbNet.Shared.AutoMapper
Imports ArchitectureVbNet.Shared.Cqrs
Imports SimpleInjector
Imports SimpleInjector.Integration.Web.Mvc

Public Module ArchitectureVbNetBootstrapper
    Public Sub Register()
        Dim container = New Container()
        Register(container)
        DependencyResolver.SetResolver(New SimpleInjectorDependencyResolver(container))
    End Sub

    Private Sub Register(container As Container)
        AutoMapperConfig.LoadMapsFromAssemblies(Of CreateCustomer)
        container.AddCqrs(Of CustomerQueryHandler)
        container.Register(Of IProcessor, Processor)
    End Sub
End Module
