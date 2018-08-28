Imports ArchitectureVbNet.CqrsClient.Command.Customer.Validation

Namespace Command.Customer
    Public Class DeleteCustomer
        Inherits CustomerCommand

        Public Sub New(id As Guid)
            Me.Id = id
        End Sub
        Public Overrides Function IsValid() As Boolean
            ValidationResult = new DeleteCustomerValidation().Validate(Me)
            return ValidationResult.IsValid
        End Function
    End Class
End NameSpace