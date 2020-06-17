Imports System.Data.SqlClient

Public Class NewCar
    Dim connection As SqlConnection = New SqlConnection("Data Source=DESKTOP-4QAKJBG; Database=CarsRental; Integrated Security=True;")
    Public Adapter As New SqlDataAdapter
    Dim ds As DataSet
    Dim currentId As String

    Public Sub GetRecords()
        ds = New DataSet
        Adapter = New SqlDataAdapter("select * from tbl_cars", connection)
        Adapter.Fill(ds, "tbl_cars")

        CarDataGridView.DataSource = ds
        CarDataGridView.DataMember = "tbl_cars"
    End Sub

    Private Sub ClearVal()
        makeinput.Clear()
        modelinput.Clear()
        plateinput.Clear()
        yearofmakeinput.Clear()
        doorscombo.SelectedIndex = -1
        transcombo.SelectedIndex = -1
        doorscombo.SelectedIndex = -1
        cpd.Clear()
        bodytypecombo.SelectedIndex = -1
    End Sub
    Private Sub NewCar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        GetRecords()
    End Sub

    Private Sub Editcar_Click(sender As Object, e As EventArgs) Handles editcar.Click
        addcar.Enabled = False
        Dim i As Integer
        i = CarDataGridView.CurrentRow.Index
        currentId = CarDataGridView.Item(0, i).Value.ToString()
        modelinput.Text = CarDataGridView.Item(1, i).Value.ToString()
        makeinput.Text = CarDataGridView.Item(2, i).Value.ToString()
        transcombo.SelectedText = CarDataGridView.Item(4, i).Value.ToString()
        doorscombo.SelectedText = CarDataGridView.Item(5, i).Value.ToString()
        bodytypecombo.SelectedText = CarDataGridView.Item(6, i).Value.ToString()
        plateinput.Text = CarDataGridView.Item(7, i).Value.ToString()
        yearofmakeinput.Text = CarDataGridView.Item(8, i).Value.ToString()
        cpd.Text = CarDataGridView.Item(9, i).Value.ToString()


    End Sub

    Private Sub Addcar_Click(sender As Object, e As EventArgs) Handles addcar.Click
        Dim car As Car = New Car(makeinput.Text, yearofmakeinput.Text, modelinput.Text, CInt(doorscombo.SelectedItem), transcombo.Text, plateinput.Text, bodytypecombo.Text, Convert.ToDouble(cpd.Text))
        ds = New DataSet
        Adapter = New SqlDataAdapter("insert into tbl_cars ( model, make, rented, modelyear, transmission, numberofdoors, plate, bodytype, cpd) values 
                                       ('" & car.Model & "','" & car.Make & "','" & Convert.ToInt32(car.Rented) & "',
                                        '" & car.ModelYear & "','" & car.Transmission & "','" & car.Doors & "','" & car.Plate & "','" & car.BodyType & "',
                                       '" & car.CostPerDay & "')", connection)

        Try
            Adapter.Fill(ds, "tbl_cars")
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            ClearVal()
            GetRecords()
        End Try

    End Sub

    Private Sub Deletecar_Click(sender As Object, e As EventArgs) Handles deletecar.Click
        Dim i As Integer = CarDataGridView.CurrentRow.Index
        currentId = CarDataGridView.Item(0, i).Value.ToString()

        ds = New DataSet
        Adapter = New SqlDataAdapter("delete from tbl_cars where id = '" & currentId & "'", connection)

        Try
            Adapter.Fill(ds, "tbl_cars")
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            GetRecords()
        End Try
    End Sub

    Private Sub Updatecar_Click(sender As Object, e As EventArgs) Handles updatecar.Click
        ds = New DataSet
        Adapter = New SqlDataAdapter("update tbl_cars set plate='" & plateinput.Text & "', make='" & makeinput.Text & "',
                                    model='" & modelinput.Text & "', modelyear='" & yearofmakeinput.Text & "', transmission='" & transcombo.Text & "',
                                    numberofdoors='" & CInt(doorscombo.SelectedItem) & "', bodytype= '" & bodytypecombo.SelectedItem & "', cpd='" & Convert.ToDouble(cpd.Text) & "'
                                    where id = '" & currentId & "'", connection)

        Try
            Adapter.Fill(ds, "tbl_cars")
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            addcar.Enabled = True
            ClearVal()
            GetRecords()
        End Try
    End Sub
End Class