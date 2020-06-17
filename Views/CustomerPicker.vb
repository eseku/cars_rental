Imports System.Data.SqlClient

Public Class CustomerPicker
    Dim connection As SqlConnection = New SqlConnection("Data Source=DESKTOP-4QAKJBG; Database=CarsRental; Integrated Security=True;")
    Public Adapter As New SqlDataAdapter
    Dim ds As DataSet
    Dim currentId As String
    Public Selected As Integer


    Private Sub Picker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        GetRecords()

    End Sub

    Public Sub GetRecords()
        ds = New DataSet
        Adapter = New SqlDataAdapter("select * from tbl_customers", connection)
        Try
            Adapter.Fill(ds, "tbl_customers")
            PickerGrid.DataSource = ds
            PickerGrid.DataMember = "tbl_customers"
        Catch ex As SqlException
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub Confirm_Click(sender As Object, e As EventArgs) Handles confirm.Click
        Dim i As Integer
        i = PickerGrid.CurrentRow.Index
        currentId = PickerGrid.Item(0, i).Value.ToString()
        Selected = currentId
        Me.Hide()
        Rentals.customer.Text = Selected
    End Sub
End Class