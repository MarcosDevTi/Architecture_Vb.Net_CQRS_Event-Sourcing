Namespace Command.Customer.Validation
    Public Class DeleteCustomerValidation
        Inherits CustomerCommandValidation(Of DeleteCustomer)

        Public Sub New()
           ValidateId()
        End Sub
        
    End Class
End NameSpace