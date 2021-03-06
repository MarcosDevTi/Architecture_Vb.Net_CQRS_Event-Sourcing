﻿Imports System.Web.Mvc
Imports ArchitectureVbNet.CqrsClient.Query.Product
Imports ArchitectureVbNet.Shared.Cqrs

Namespace Controllers
    Public Class ProductController
        Inherits Controller
        private ReadOnly _processor As IProcessor

        Sub New(processor As IProcessor)
            _processor = processor
        End Sub
        
        Function Index() As ActionResult
            Dim products = _processor.Process(new GetProductsIndex())
            Return View(products)
        End Function
    End Class
End Namespace