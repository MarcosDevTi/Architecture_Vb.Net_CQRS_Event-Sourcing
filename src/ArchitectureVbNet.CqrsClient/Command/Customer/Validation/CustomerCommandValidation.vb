Imports FluentValidation

Namespace Command.Customer.Validation
    Public Class CustomerCommandValidation (Of T As CustomerCommand) 
        Inherits AbstractValidator(Of T)
        Protected Sub ValidateId()
            Call RuleFor(Function(x) x.Id).NotEqual(Guid.Empty)
            Return
        End Sub

        Protected Sub ValidateName()
            Call RuleFor(Function(x) x.Name).NotEmpty().WithMessage("Please easure you have entered the Name") _
            .Length(2, 40).WithMessage("The Name must have between 2 and 40 characters")
        End Sub

        Protected Sub ValidateBirthDate()
            Call RuleFor(Function(c) c.BirthDate).NotEmpty().Must(AddressOf HaveMinimumAge) _
                .WithMessage("The customer must have 18 years or more")
        End Sub

        Protected Function HaveMinimumAge(birthDate As DateTime) As Boolean
            Return birthDate <= DateTime.Now.AddYears(-18)
        End Function

        Protected Sub ValidateEmail()
            Call RuleFor(Function(x) x.Email).NotEmpty().EmailAddress()
        End Sub
    End Class
End NameSpace