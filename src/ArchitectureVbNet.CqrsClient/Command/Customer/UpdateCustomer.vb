Imports ArchitectureVbNet.CqrsClient.Command.Customer.Validation
Imports FluentValidation.Results

Namespace Command.Customer
    Public Class UpdateCustomer
        Inherits CustomerCommand
        Protected Sub New()
            'Ctor AutoMapper Reflection Registrations
        End Sub

        Protected Sub New(
                          id As Guid,
                          name As String,
                          email As String,
                          birthDate As Date)
            Me.Id = id
            Me.Name = name
            Me.Email = email
            Me.BirthDate = birthDate
        End Sub

        Public Overrides Function IsValid() As Boolean
            ValidationResult = New UpdateCustomerValidation().Validate(Me)
            Return ValidationResult.IsValid
        End Function
    End Class
End NameSpace