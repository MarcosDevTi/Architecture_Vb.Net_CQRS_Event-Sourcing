﻿Imports ArchitectureVbNet.Shared.AutoMapper
Imports AutoMapper

Namespace Query.Product
    Public Class ProductIndex
        Implements ICustomMap
        public Property Id As Guid
        Public Property Name As String
        Public Property Description As String
        Public Property Price As Decimal

        Public Sub CreateMaps(cfg As IMapperConfigurationExpression) Implements ICustomMap.CreateMaps
            cfg.CreateMap(Of Domain.Product, ProductIndex)
        End Sub
    End Class
End NameSpace