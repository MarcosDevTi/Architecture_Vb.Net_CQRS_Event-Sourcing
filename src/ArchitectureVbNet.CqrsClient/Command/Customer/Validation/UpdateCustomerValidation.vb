Namespace Command.Customer.Validation
    Public Class UpdateCustomerValidation
        Inherits CustomerCommandValidation(Of UpdateCustomer)

        Public Sub New()
            ValidateId()
            ValidateName()
            ValidateBirthDate()
            ValidateEmail()
        End Sub
    End Class
End NameSpace