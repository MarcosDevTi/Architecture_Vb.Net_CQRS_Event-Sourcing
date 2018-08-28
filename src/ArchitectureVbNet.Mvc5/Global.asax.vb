Imports System.Web.Optimization
Imports ArchitectureVbNet.IoC

Public Class MvcApplication
    Inherits System.Web.HttpApplication

    Sub Application_Start()
        ArchitectureVbNetBootstrapper.Register()
        AreaRegistration.RegisterAllAreas()
        FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters)
        RouteConfig.RegisterRoutes(RouteTable.Routes)
        BundleConfig.RegisterBundles(BundleTable.Bundles)
    End Sub
End Class
