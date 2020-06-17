Public Class User
    Public Id As String
    Public FirstName As String
    Public LastName As String
    Public Email As String
    Public Password As String

    Public Sub New(firstnameArg As String, lastnameArg As String, emailArg As String, passwordArg As String)
        Dim r As Random = New Random

        Id = CStr(r.Next(100000000, 999999989))
        FirstName = firstnameArg
        LastName = lastnameArg
        Email = emailArg
        Password = passwordArg

    End Sub
End Class
