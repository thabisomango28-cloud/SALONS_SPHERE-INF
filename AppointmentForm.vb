Imports MySql.Data.MySqlClient

Public Class AppointmentForm

    Private ConnectionString As String = "server=localhost;userid=root;password=Lancelot@28m;database=class1;CharSet=utf8mb4;"
    Public Sub SetCustomerData(customerId As String)
        ' Set the customer ID in the textbox
        txtcustID.Text = customerId
    End Sub

    ' Helper class for combobox items
    Public Class ComboboxItem
        Public Property Text As String
        Public Property Value As Object

        Public Sub New(text As String, value As Object)
            Me.Text = text
            Me.Value = value
        End Sub

        Public Overrides Function ToString() As String
            Return Text
        End Function
    End Class

    Private Sub AppointmentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAppointments()
        LoadServices()
        ' Don't load employees here - wait for service selection
    End Sub

    Private Sub LoadAppointments()
        Using connection As New MySqlConnection(ConnectionString)
            Try
                connection.Open()
                Dim query As String = "SELECT * FROM appointmentsss"
                Dim SDA As New MySqlDataAdapter(query, connection)
                Dim dbdataset As New DataTable
                SDA.Fill(dbdataset)

                DataGridAppointView.DataSource = dbdataset

            Catch ex As Exception
                MessageBox.Show("Error loading appointments: " & ex.Message)
            End Try
        End Using
    End Sub

    ' This method loads available employees filtered by service type
    Private Sub LoadAvailableEmployees(appointmentDate As Date, startTime As String, serviceType As String)
        Using connection As New MySqlConnection(ConnectionString)
            Try
                connection.Open()

                Dim endTime As String = CalculateEndTime(startTime, serviceType)
                Dim servicePosition As String = GetPositionFromService(serviceType)

                Dim query As String = "SELECT employee_id, first_name, last_name FROM employee " &
                                      "WHERE status = 'Available' " &
                                      "AND position = @position " &
                                      "AND employee_id NOT IN (" &
                                      "    SELECT employee_id FROM appointmentsss " &
                                      "    WHERE appointment_date = @appointment_date " &
                                      "    AND NOT (end_time <= @start_time OR start_time >= @end_time)" &
                                      ")"

                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@position", servicePosition)
                    command.Parameters.AddWithValue("@appointment_date", appointmentDate.ToString("yyyy-MM-dd"))
                    command.Parameters.AddWithValue("@start_time", startTime)
                    command.Parameters.AddWithValue("@end_time", endTime)

                    Dim reader As MySqlDataReader = command.ExecuteReader()

                    cmbEmployee.Items.Clear()
                    cmbEmployee.Items.Add("Select an employee")

                    While reader.Read()
                        Dim employeeId As Integer = reader.GetInt32("employee_id")
                        Dim firstName As String = reader.GetString("first_name")
                        Dim lastName As String = reader.GetString("last_name")
                        Dim displayName As String = $"{firstName} {lastName}"

                        cmbEmployee.Items.Add(New ComboboxItem(displayName, employeeId))
                    End While
                    reader.Close()

                    If cmbEmployee.Items.Count > 1 Then
                        cmbEmployee.SelectedIndex = 0
                    Else
                        cmbEmployee.Text = "No available " & serviceType.ToLower() & "s"
                    End If
                End Using

            Catch ex As Exception
                MessageBox.Show("Error loading employees: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Map service type to employee position
    Private Function GetPositionFromService(serviceType As String) As String
        Select Case serviceType.ToLower()
            Case "nails" : Return "Nail Technician"
            Case "stylist" : Return "Stylist"
            Case "barber" : Return "Barber"
            Case Else : Return "Stylist"
        End Select
    End Function

    ' This method triggers when date/time/service changes
    Private Sub RefreshAvailableEmployees()
        If DATETIME.Value >= Date.Today AndAlso
           Not String.IsNullOrEmpty(txttime.Text) AndAlso
           cboservicetype.SelectedItem IsNot Nothing Then

            LoadAvailableEmployees(DATETIME.Value, txttime.Text, cboservicetype.SelectedItem.ToString())
        End If
    End Sub

    ' Event handlers that call RefreshAvailableEmployees
    Private Sub DateTime_ValueChanged(sender As Object, e As EventArgs) Handles DATETIME.ValueChanged
        RefreshAvailableEmployees()
    End Sub

    Private Sub txttime_TextChanged(sender As Object, e As EventArgs) Handles txttime.TextChanged
        RefreshAvailableEmployees()
    End Sub

    Private Sub cboservicetype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboservicetype.SelectedIndexChanged
        ' Clear employee list when service type changes
        cmbEmployee.Items.Clear()
        cmbEmployee.Items.Add("Select an employee")
        cmbEmployee.SelectedIndex = 0

        RefreshAvailableEmployees()

        ' Update end time display
        If Not String.IsNullOrEmpty(txttime.Text) AndAlso cboservicetype.SelectedItem IsNot Nothing Then
            Dim endTime As String = CalculateEndTime(txttime.Text, cboservicetype.SelectedItem.ToString())
            lblendtime.Text = "End Time: " & endTime
        End If
    End Sub

    Private Function GetServiceId(serviceName As String) As Integer
        Select Case serviceName.ToLower()
            Case "nails" : Return 1
            Case "stylist" : Return 2
            Case "barber" : Return 3
            Case Else : Return 1
        End Select
    End Function

    ' Remove the UpdateEmployeeStatus method - we won't set status to busy immediately

    Private Sub LoadServices()
        cboservicetype.Items.Clear()
        cboservicetype.Items.Add("Nails")
        cboservicetype.Items.Add("Stylist")
        cboservicetype.Items.Add("Barber")
    End Sub

    Private Function CalculateEndTime(startTime As String, serviceType As String) As String
        Dim durationMinutes As Integer = 0

        Select Case serviceType.ToLower()
            Case "nails" : durationMinutes = 60
            Case "stylist" : durationMinutes = 180
            Case "barber" : durationMinutes = 40
        End Select

        Dim start As TimeSpan
        If TimeSpan.TryParse(startTime, start) Then
            Dim endTime As TimeSpan = start.Add(TimeSpan.FromMinutes(durationMinutes))
            Return endTime.ToString("hh\:mm\:ss")
        End If

        Return "00:00:00"
    End Function

    Private Sub btnBook_Click(sender As Object, e As EventArgs) Handles btnBook.Click
        ' Validate inputs first
        If String.IsNullOrEmpty(txtcustID.Text) OrElse
           String.IsNullOrEmpty(txttime.Text) OrElse
           cboservicetype.SelectedItem Is Nothing OrElse
           cmbEmployee.SelectedItem Is Nothing OrElse
           cmbEmployee.SelectedIndex = 0 Then

            MessageBox.Show("Please fill all fields and select an employee")
            Return
        End If

        ' Check if appointment date is in the future
        If DATETIME.Value < Date.Today Then
            MessageBox.Show("Appointment date cannot be in the past")
            Return
        End If

        Using connection As New MySqlConnection(ConnectionString)
            Try
                connection.Open()

                ' Calculate end time first
                Dim endTime As String = CalculateEndTime(txttime.Text, cboservicetype.SelectedItem.ToString())

                ' Get selected employee ID
                Dim selectedEmployeeId As Integer = 0
                If TypeOf cmbEmployee.SelectedItem Is ComboboxItem Then
                    Dim selectedItem As ComboboxItem = CType(cmbEmployee.SelectedItem, ComboboxItem)
                    selectedEmployeeId = CInt(selectedItem.Value)
                Else
                    MessageBox.Show("Please select a valid employee")
                    Return
                End If

                ' Check if employee is already booked for this time slot
                If IsEmployeeBooked(selectedEmployeeId, DATETIME.Value, txttime.Text, endTime) Then
                    MessageBox.Show("This employee is already booked for the selected time slot. Please choose another time or employee.")
                    Return
                End If

                ' Use INSERT into your original table name
                Dim query As String = "INSERT INTO appointmentsss (customer_id, employee_id, appointment_date, start_time, end_time, service_name, status) " &
                                      "VALUES (@customer_id, @employee_id, @appointment_date, @start_time, @end_time, @service_name, 'Scheduled')"

                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@customer_id", txtcustID.Text)
                    command.Parameters.AddWithValue("@employee_id", selectedEmployeeId)
                    command.Parameters.AddWithValue("@appointment_date", DATETIME.Value.ToString("yyyy-MM-dd"))
                    command.Parameters.AddWithValue("@start_time", txttime.Text)
                    command.Parameters.AddWithValue("@end_time", endTime)
                    command.Parameters.AddWithValue("@service_name", cboservicetype.SelectedItem.ToString())

                    command.ExecuteNonQuery()
                    MessageBox.Show("Appointment booked successfully for " & DATETIME.Value.ToString("MMM dd, yyyy"))

                    ' Refresh the grid and employee list
                    LoadAppointments()
                    RefreshAvailableEmployees() ' Reload available employees

                    ' Clear form
                    ClearForm()
                End Using

            Catch ex As Exception
                MessageBox.Show("Error saving data: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Check if employee is already booked for the time slot
    Private Function IsEmployeeBooked(employeeId As Integer, appointmentDate As Date, startTime As String, endTime As String) As Boolean
        Using connection As New MySqlConnection(ConnectionString)
            Try
                connection.Open()

                Dim query As String = "SELECT COUNT(*) FROM appointmentsss " &
                                      "WHERE employee_id = @employee_id " &
                                      "AND appointment_date = @appointment_date " &
                                      "AND NOT (end_time <= @start_time OR start_time >= @end_time) " &
                                      "AND status != 'Cancelled'"

                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@employee_id", employeeId)
                    command.Parameters.AddWithValue("@appointment_date", appointmentDate.ToString("yyyy-MM-dd"))
                    command.Parameters.AddWithValue("@start_time", startTime)
                    command.Parameters.AddWithValue("@end_time", endTime)

                    Dim count As Integer = CInt(command.ExecuteScalar())
                    Return count > 0
                End Using

            Catch ex As Exception
                MessageBox.Show("Error checking employee availability: " & ex.Message)
                Return True ' Assume booked if there's an error
            End Try
        End Using
    End Function

    Private Sub ClearForm()
        txtcustID.Clear()
        txttime.Clear()
        cboservicetype.SelectedIndex = -1
        cmbEmployee.Items.Clear()
        cmbEmployee.Items.Add("Select an employee")
        cmbEmployee.SelectedIndex = 0
        lblendtime.Text = "End Time: "
        DATETIME.Value = Date.Today
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        ' Add any additional functionality needed for btnadd
    End Sub

    ' Additional method to handle employee combobox selection
    Private Sub cmbEmployee_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEmployee.SelectedIndexChanged
        If cmbEmployee.SelectedIndex > 0 AndAlso Not String.IsNullOrEmpty(txttime.Text) AndAlso cboservicetype.SelectedItem IsNot Nothing Then
            Dim endTime As String = CalculateEndTime(txttime.Text, cboservicetype.SelectedItem.ToString())
            lblendtime.Text = "End Time: " & endTime
        End If
    End Sub

    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles IconButton4.Click
        Me.Close()
    End Sub
End Class