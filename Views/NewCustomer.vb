Imports System.Data.SqlClient
Public Class NewCustomer
    Dim connection As SqlConnection = New SqlConnection("Data Source=DESKTOP-4QAKJBG; Database=CarsRental; Integrated Security=True;")
    Public Adapter As New SqlDataAdapter
    Dim ds As DataSet
    Dim currentId As String


    Private Sub NewCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        GetRecords()
    End Sub

    Public Sub GetRecords()
        ds = New DataSet
        Adapter = New SqlDataAdapter("select * from tbl_customers", connection)
        Adapter.Fill(ds, "tbl_customers")

        CustomerDataGrid.DataSource = ds
        CustomerDataGrid.DataMember = "tbl_customers"
    End Sub

    Private Sub ClearVal()
        firstnamesignup.Clear()
        lastnamesignup.Clear()
        emailsignup.Clear()
    End Sub

    Private Sub Addcustomer_Click(sender As Object, e As EventArgs) Handles addcustomer.Click
        Dim customer As Customer = New Customer(firstnamesignup.Text, lastnamesignup.Text, emailsignup.Text)

        ds = New DataSet
        Adapter = New SqlDataAdapter("insert into tbl_customers ( firstname, lastname, email ) values ('" & customer.FirstName & "', '" & customer.LastName & "', '" & customer.Email & "')", connection)


        Try
            Adapter.Fill(ds, "tbl_customers")
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            ClearVal()
            GetRecords()
        End Try

    End Sub

    Private Sub Deletecustomer_Click(sender As Object, e As EventArgs) Handles deletecustomer.Click
        Dim i As Integer
        i = CustomerDataGrid.CurrentRow.Index
        currentId = CustomerDataGrid.Item(0, i).Value.ToString()

        ds = New DataSet
        Adapter = New SqlDataAdapter("delete from tbl_customers where id = '" & currentId & "'", connection)

        Try
            Adapter.Fill(ds, "tbl_customers")
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            GetRecords()
        End Try



    End Sub

    Private Sub Editcustomer_Click(sender As Object, e As EventArgs) Handles editcustomer.Click
        addcustomer.Enabled = False
        Dim i As Integer
        i = CustomerDataGrid.CurrentRow.Index
        currentId = CustomerDataGrid.Item(0, i).Value.ToString()

        firstnamesignup.Text = CustomerDataGrid.Item(1, i).Value.ToString()
        lastnamesignup.Text = CustomerDataGrid.Item(2, i).Value.ToString()
        emailsignup.Text = CustomerDataGrid.Item(3, i).Value.ToString()
    End Sub

    Private Sub Updatecustomer_Click(sender As Object, e As EventArgs) Handles updatecustomer.Click
        ds = New DataSet
        Adapter = New SqlDataAdapter("update tbl_customers set firstname='" & firstnamesignup.Text & "', lastname='" & lastnamesignup.Text & "',
                                    email='" & emailsignup.Text & "' where id = '" & currentId & "'", connection)

        Try
            Adapter.Fill(ds, "tbl_customers")
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            addcustomer.Enabled = True
            ClearVal()
            GetRecords()
        End Try

    End Sub
End Class