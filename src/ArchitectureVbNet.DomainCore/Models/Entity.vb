Imports FluentValidation
Imports FluentValidation.Results

Namespace Models
    Public MustInherit Class Entity
        Public Property Id As Guid

        Public Overrides Function Equals(obj As Object) As Boolean
            Dim compareTo = TryCast(obj, Entity)
            If ReferenceEquals(Me, compareTo) Then Return True
            If ReferenceEquals(Nothing, compareTo) Then Return False
            Return Id.Equals(compareTo.Id)
        End Function

        Public Shared Operator =(a As Entity, b As Entity) As Boolean
            If ReferenceEquals(a, Nothing) AndAlso ReferenceEquals(b, Nothing) Then Return True
            If ReferenceEquals(a, Nothing) OrElse ReferenceEquals(b, Nothing) Then Return False
            Return a.Equals(b)
        End Operator

        Public Shared Operator <>(a As Entity, b As Entity) As Boolean
            Return Not (a = b)
        End Operator

        Public Overrides Function GetHashCode() As Integer
            Return ([GetType]().GetHashCode() * 907) + Id.GetHashCode()
        End Function

        Public Overrides Function ToString() As String
            Return [GetType]().Name & " [Id=" & Id.ToString() & "]"
        End Function
    End Class

End NameSpace