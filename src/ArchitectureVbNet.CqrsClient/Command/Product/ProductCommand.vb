Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports ArchitectureVbNet.Shared.Cqrs.Command

Namespace Command.Product
    Public MustInherit Class ProductCommand
        Inherits CommandRequest

       public Id As Guid?
       <Required(ErrorMessage:="The Name is Required")>
       <MinLength(2)>
       <MaxLength(100)>
       <DisplayName("Name")>
       Public Property Name As String
       <Required(ErrorMessage:="The Description is Required")>
       <MinLength(2)>
       <MaxLength(100)>
       <DisplayName("Description")>
       Public Property Description As String
       Public Property Price As Decimal
    End Class
End NameSpace