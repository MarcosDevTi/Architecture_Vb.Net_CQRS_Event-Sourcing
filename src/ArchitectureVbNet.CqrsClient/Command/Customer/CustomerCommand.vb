
Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports ArchitectureVbNet.CqrsClient.Command.Customer.Validation
Imports ArchitectureVbNet.Shared.Cqrs.Command

Namespace Command.Customer
    Public MustInherit Class CustomerCommand
        Inherits CommandRequest

        Public Property Id As Guid?
        <Required(ErrorMessage:="The Name is Required")>
        <MinLength(2)>
        <MaxLength(100)>
        <DisplayName("Name")>
        Public Property Name As String
        <Required(ErrorMessage:="The E-mail is Required")>
        <EmailAddress>
        <DisplayName("E-mail")>
        Public Property Email As String
        <Required(ErrorMessage:="The BirthDate is Required")>
        <DisplayFormat(ApplyFormatInEditMode:=True, DataFormatString:="{0:yyyy-MM-dd}")>
        <DataType(DataType.Date, ErrorMessage:="Data em formato inválido")>
        <DisplayName("Birth Date")>
        Public Property BirthDate As DateTime

    End Class
End Namespace