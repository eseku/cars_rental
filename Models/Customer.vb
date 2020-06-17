Public Class Customer

    Public Id As String
    Public FirstName As String
    Public LastName As String
    Public Email As String


    Public Sub New(firstnameArg As String, lastNameArg As String, emailArg As String)
        Dim r As Random = New Random

        Id = CStr(r.Next(100000000, 999999989))
        FirstName = firstnameArg
        LastName = lastNameArg
        Email = emailArg
    End Sub



End Class
