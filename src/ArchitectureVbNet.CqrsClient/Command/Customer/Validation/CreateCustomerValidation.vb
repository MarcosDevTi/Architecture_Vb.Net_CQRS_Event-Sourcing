Namespace Command.Customer.Validation
    Public Class CreateCustomerValidation
        Inherits CustomerCommandValidation(Of CreateCustomer)

        Public Sub New()
            ValidateName()
            ValidateBirthDate()
            ValidateEmail()
        End Sub

    End Class
End NameSpace