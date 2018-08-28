Imports AutoMapper

Namespace AutoMapper
    Public Module AutoMapperConfig
        Sub LoadMapsFromAssemblies(Of T)()
            Dim assemblieTypes = GetType(T).Assembly.ExportedTypes
            Mapper.Initialize(
                Sub(cfg)
                    LoadCustom(cfg, assemblieTypes)
                    LoadMapFrom(cfg, assemblieTypes)
                    LoadMapTo(cfg, assemblieTypes)
                End Sub)
        End Sub

        Private Sub LoadMapFrom(mapperConfigurationExpression As IMapperConfigurationExpression, assemblieTypes As IEnumerable(Of Type))
            Throw New NotImplementedException
        End Sub

        Private Sub LoadMapTo(mapperConfigurationExpression As IMapperConfigurationExpression, assemblieTypes As IEnumerable(Of Type))
            Throw New NotImplementedException
        End Sub

        Private Sub LoadCustom(cfg As IMapperConfigurationExpression, assemblieTypes As IEnumerable(Of Type))
            Dim maps = (From t In assemblieTypes From i In t.GetInterfaces()
                        Where GetType(ICustomMap).IsAssignableFrom(t) AndAlso 
                              Not t.IsAbstract AndAlso Not t.IsInterface
                        Select CType(Activator.CreateInstance(t), ICustomMap)).ToArray()

            For Each map In maps
                map.CreateMaps(cfg)
            Next
        End Sub
    End Module
End Namespace