Imports System.Data.SqlClient
Public Class Dashboard
    Dim connection As SqlConnection = New SqlConnection("Data Source=DESKTOP-4QAKJBG; Database=CarsRental; Integrated Security=True;")
    Public Adapter As New SqlDataAdapter
    Dim ds As DataSet

    Public Sub GetRecords()
        ds = New DataSet
        Adapter = New SqlDataAdapter("select r.id, r.issuedate as 'Issue', r.returndate as 'Return Date',
                                                r.returnstatus as 'Return Status', c.make as 'Car Make', c.Model as 'Car Model',
                                                u.firstname as 'Customer First Name', u.lastname as 'Customer Last Name', u.email as 'Email'
                                                from tbl_rentals r, tbl_cars c, tbl_customers u
                                                where r.custid = u.id and r.carid = c.id", connection)
        Adapter.Fill(ds, "tbl_rentals")
        RentalsDataGridView.DataSource = ds
        RentalsDataGridView.DataMember = "tbl_rentals"
    End Sub


    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        GetRecords()
    End Sub

    Private Sub Newcarmenustrip_Click(sender As Object, e As EventArgs) Handles newcarmenustrip.Click
        NewCar.ShowDialog()

    End Sub

    Private Sub Newcustomermenustrip_Click(sender As Object, e As EventArgs) Handles newcustomermenustrip.Click
        NewCustomer.ShowDialog()
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        Rentals.ShowDialog()
    End Sub

    Private Sub Dashboard_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        GetRecords()
    End Sub
End Class