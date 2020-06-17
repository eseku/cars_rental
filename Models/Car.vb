Public Class Car
    Public Id As String
    Public Make As String
    Public ModelYear As String
    Public Model As String
    Public Rented As Boolean
    Public Doors As Integer
    Public Transmission As String
    Public Plate As String
    Public BodyType As String
    Public CostPerDay As Double

    Public Sub New(makeArg As String, makeyearArg As String, modelArg As String, doorsArg As Integer, transmissionArg As String, plateArg As String, bodyTypeArg As String, costArg As Double)
        Dim r As Random = New Random

        Id = CInt(r.Next(100000000, 999999989))
        Make = makeArg
        ModelYear = makeyearArg
        Model = modelArg
        Doors = doorsArg
        Rented = False
        Transmission = transmissionArg
        Plate = plateArg
        BodyType = bodyTypeArg
        CostPerDay = costArg


    End Sub

    Public Sub ToggleRent()
        Rented = Not Rented
    End Sub


End Class
