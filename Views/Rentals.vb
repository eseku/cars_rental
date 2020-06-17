Imports System.Data.SqlClient
Public Class Rentals
    Dim connection As SqlConnection = New SqlConnection("Data Source=DESKTOP-4QAKJBG; Database=CarsRental; Integrated Security=True;")
    Public Adapter As New SqlDataAdapter
    Dim ds As DataSet
    Dim currentId As String
    Dim carId As String

    Public Sub GetRecords()
        ds = New DataSet
        Adapter = New SqlDataAdapter("select * from tbl_rentals", connection)
        Adapter.Fill(ds, "tbl_rentals")

        RentDataGrid.DataSource = ds
        RentDataGrid.DataMember = "tbl_rentals"
    End Sub
    Private Sub Rentals_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        GetRecords()
        returndatepicker.CustomFormat = ""
        duedatepicker.CustomFormat = ""
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        CustomerPicker.ShowDialog()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CarPicker.ShowDialog()
    End Sub

    Private Sub Addrental_Click(sender As Object, e As EventArgs) Handles addrental.Click
        Dim rental As Rental = New Rental(issuedatepicker.Value, duedatepicker.Value, returndatepicker.Value, False, car.Text, customer.Text)
        Dim command As SqlCommand

        ds = New DataSet
        Adapter = New SqlDataAdapter("insert into tbl_rentals ( issuedate, duedate, returndate, returnstatus, carid, custid) values ('" & rental.IssueDate & "',
                                    '" & duedatepicker.Value & "', '" & DBNull.Value & "', '" & Convert.ToInt32(False) & "', '" & car.Text & "', '" & customer.Text & "')", connection)
        Try
            connection.Open()
            command = connection.CreateCommand()
            command.CommandText = "update tbl_cars set rented = '" & Convert.ToInt32(True) & "' where id = '" & car.Text & "' "
            command.ExecuteNonQuery()
            connection.Close()
            Adapter.Fill(ds, "tbl_customers")
        Catch Ex As SqlException
            MsgBox(Ex.Message)

        Finally
            issuedatepicker.CustomFormat = ""
            duedatepicker.CustomFormat = ""
            returndatepicker.CustomFormat = ""
            car.Clear()
            customer.Clear()
            GetRecords()
        End Try
    End Sub

    Private Sub Deleterental_Click(sender As Object, e As EventArgs) Handles deleterental.Click
        Dim i As Integer
        i = RentDataGrid.CurrentRow.Index

        currentId = RentDataGrid.Item(0, i).Value.ToString()
        carId = RentDataGrid.Item(4, i).Value.ToString()
        Dim command As SqlCommand

        ds = New DataSet
        Adapter = New SqlDataAdapter("delete from tbl_rentals where id = '" & currentId & "'", connection)

        Try
            Adapter.Fill(ds, "tbl_rentals")
            connection.Open()
            Command = connection.CreateCommand()
            command.CommandText = "update tbl_cars set rented = '" & Convert.ToInt32(False) & "' where id = '" & carId & "' "
            command.ExecuteNonQuery()
            connection.Close()
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            GetRecords()
        End Try
    End Sub

    Private Sub Editrental_Click(sender As Object, e As EventArgs) Handles editrental.Click

        addrental.Enabled = False
        Dim i As Integer
        i = RentDataGrid.CurrentRow.Index
        currentId = RentDataGrid.Item(0, i).Value.ToString()

        issuedatepicker.Value = Convert.ToDateTime(RentDataGrid.Item(1, i).Value.ToString())

        returned.Checked = Convert.ToBoolean(RentDataGrid.Item(2, i).Value.ToString())
        customer.Text = RentDataGrid.Item(3, i).Value.ToString()
        car.Text = RentDataGrid.Item(4, i).Value.ToString()
        returndatepicker.Value = Convert.ToDateTime(RentDataGrid.Item(5, i).Value.ToString())
        duedatepicker.Value = Convert.ToDateTime(RentDataGrid.Item(6, i).Value.ToString())



    End Sub

    Private Sub Updaterental_Click(sender As Object, e As EventArgs) Handles updaterental.Click
        ds = New DataSet
        Adapter = New SqlDataAdapter("update tbl_rentals set issuedate = '" & issuedatepicker.Value & "', returnstatus = '" & Convert.ToInt32(returned.Checked) & "',
                                    custid = '" & customer.Text & "', carid = '" & car.Text & "', returndate = '" & returndatepicker.Value & "',
                                    duedate = '" & duedatepicker.Value & "' ", connection)
        Dim command As SqlCommand

        Try
            Adapter.Fill(ds, "tbl_rentals")
            connection.Open()
            command = connection.CreateCommand()

            If returned.Checked = True Then
                command.CommandText = "update tbl_cars set rented = '" & Convert.ToInt32(False) & "' where id = '" & car.Text & "' "
            ElseIf returned.Checked = False Then
                command.CommandText = "update tbl_cars set rented = '" & Convert.ToInt32(True) & "' where id = '" & car.Text & "' "
            End If
            command.ExecuteNonQuery()

            connection.Close()
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            issuedatepicker.CustomFormat = ""
            duedatepicker.CustomFormat = ""
            returndatepicker.CustomFormat = ""
            car.Clear()
            customer.Clear()
            GetRecords()
            addrental.Enabled = True

        End Try
    End Sub
End Class