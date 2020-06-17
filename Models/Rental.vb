Public Class Rental
    Public Id As String
    Public IssueDate As Date
    Public ReturnDate As Date
    Public ReturnStatus As Boolean
    Public DueDate As Date
    Public CarId As String
    Public CustId As String


    Public Sub New(IssueDateArg As Date, DueDateArg As Date, ReturnDateArg As Date, StatusArg As Boolean, CarIdArg As String, CustIdArg As String)
        Dim r As Random = New Random

        DueDate = DueDateArg
        IssueDate = IssueDateArg
        ReturnDate = ReturnDateArg
        ReturnStatus = StatusArg
        CarId = CarIdArg
        CustId = CustIdArg
    End Sub

End Class
