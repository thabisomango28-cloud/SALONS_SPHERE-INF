Imports FontAwesome.Sharp
Imports MySql.Data.MySqlClient

Public Class FormClients
    'fields
    Private currentbtn As IconButton
    Private leftBoarderBtn As Panel
    Private currentChildForam As Form

    ' Constructor that accepts main form reference
    Public Sub New(parentForm As Form1)
        InitializeComponent()
        mainForm = parentForm
    End Sub



    Dim mysqlconn As New MySql.Data.MySqlClient.MySqlConnection
    Dim COMMAND As MySql.Data.MySqlClient.MySqlCommand
    Private custId As Object
    Public ReadOnly Property mainForm As Form1

    Private Sub FormClients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mysqlconn = New MySql.Data.MySqlClient.MySqlConnection
        mysqlconn.ConnectionString = "server=localhost;userid=root;password=Lancelot@28m;database=class1"
        Dim SDA As New MySql.Data.MySqlClient.MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource
        Try
            mysqlconn.Open()
            Dim Query As String
            Query = "select * from customer"
            COMMAND = New MySql.Data.MySqlClient.MySqlCommand(Query, mysqlconn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbdataset)
            bsource.DataSource = dbdataset
            DataGridViewclients.DataSource = bsource
            SDA.Update(dbdataset)

            mysqlconn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub InsertCustomer()
        Using mysqlconn As New MySqlConnection("server=localhost;userid=root;password=Lancelot@28m;database=class1")
            Try
                mysqlconn.Open()

                Dim Query As String = "INSERT INTO customer (first_name, last_Name, Phone, Email, join_date) " &
                                "VALUES (@firstName, @lastName, @phone, @email, @joinDate)"

                Using COMMAND As New MySqlCommand(Query, mysqlconn)
                    ' Use parameters to prevent SQL injection
                    COMMAND.Parameters.AddWithValue("@firstName", txtFname.Text)
                    COMMAND.Parameters.AddWithValue("@lastName", txtLname.Text)
                    COMMAND.Parameters.AddWithValue("@phone", txtCellno.Text)
                    COMMAND.Parameters.AddWithValue("@email", txtEmail.Text)
                    COMMAND.Parameters.AddWithValue("@joinDate", DateTime.Today.ToString("yyyy-MM-dd")) ' Proper date format

                    COMMAND.ExecuteNonQuery()
                    MessageBox.Show("Data Saved successfully")

                    ' Clear the form after successful insert
                    ClearForm()
                End Using

            Catch ex As Exception
                MessageBox.Show("Error saving data: " & ex.Message) ' Show actual error
            End Try
        End Using ' Connection automatically closes here
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        ' First validate input
        If ValidateInput() Then
            InsertCustomer()
        End If

        FormClients_Load(sender, e) ' Refresh the data grid


    End Sub

    Private Function ValidateInput() As Boolean
        If String.IsNullOrWhiteSpace(txtFname.Text) Then
            MessageBox.Show("Please enter first name")
            txtFname.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtLname.Text) Then
            MessageBox.Show("Please enter last name")
            txtLname.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtCellno.Text) Then
            MessageBox.Show("Please enter phone number")
            txtCellno.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtEmail.Text) Then
            MessageBox.Show("Please enter email address")
            txtEmail.Focus()
            Return False
        End If

        ' Optional: Basic email validation
        If Not txtEmail.Text.Contains("@") Then
            MessageBox.Show("Please enter a valid email address")
            txtEmail.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub ClearForm()
        txtFname.Clear()
        txtLname.Clear()
        txtCellno.Clear()
        txtEmail.Clear()
        txtFname.Focus()
    End Sub


    Private Sub DataGridViewclients_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewclients.CellContentClick
        ' Make sure the click is on a valid row
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridViewclients.Rows(e.RowIndex)

            ' Populate textboxes with values from the row
            txtFname.Text = row.Cells("first_name").Value.ToString()
            txtLname.Text = row.Cells("last_name").Value.ToString()
            txtCellno.Text = row.Cells("phone").Value.ToString()
            txtEmail.Text = row.Cells("email").Value.ToString()
            lblLoyalty.Text = row.Cells("loyaltyPoints").Value.ToString()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



        ' Check if a row is selected
        If DataGridViewclients.CurrentRow IsNot Nothing Then
            ' Get the customer_id from the selected row
            Dim custId As String = DataGridViewclients.CurrentRow.Cells("customer_id").Value.ToString()

            ' Open the AppointmentForm and pass the ID
            AppointmentForm.txtcustID.Text = custId
            AppointmentForm.Show()
            AppointmentForm.BringToFront()
        Else
            MessageBox.Show("Please select a customer first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If


        ' GetOrCreateAppointmentForm().txtcustID.Text = If(DataGridViewclients.CurrentRow IsNot Nothing, DataGridViewclients.CurrentRow.Cells("customer_id").Value.ToString(), String.Empty)
    End Sub

    Private Function GetOrCreateAppointmentForm() As AppointmentForm
        For Each form As Form In Application.OpenForms
            If TypeOf form Is AppointmentForm Then
                Return DirectCast(form, AppointmentForm)
            End If
        Next
        Return New AppointmentForm()
    End Function
End Class