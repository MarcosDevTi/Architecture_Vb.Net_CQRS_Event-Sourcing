Imports System.Web.Mvc
Imports System.Web.UI.WebControls.Expressions
Imports ArchitectureVbNet.CqrsClient.Command.Customer
Imports ArchitectureVbNet.CqrsClient.Query.Customer
Imports ArchitectureVbNet.DomainCore.DomainNotifications
Imports ArchitectureVbNet.Shared.Cqrs

Namespace Controllers
    Public Class CustomerController
        Inherits BaseController
        Private ReadOnly _processor As IProcessor

        Public Sub New(
                       notifications As IDomainNotification,
                       processor As IProcessor)
            MyBase.New(notifications)

            _processor = processor
        End Sub

        Function Index() As ActionResult
            Dim customerIndex = _processor.Process(New GetCustomersIndex())
            Return View(customerIndex)
        End Function

        <HttpGet>
        Function Create() As ActionResult
            Return View()
        End Function

        <HttpPost>
        Function Create(customer As CreateCustomer) As ActionResult
            If Not ModelState.IsValid Then Return View(customer) 
            _processor.Send(customer)

            If not IsValidOperation() Then ViewBag.Sucesso = "Customer Registered!"
                Return View(customer)
        End Function



    End Class
End Namespace