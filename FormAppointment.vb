Imports MySql.Data.MySqlClient


Public Class FormAppointment
    Private connectionString As String = "server=localhost;userid=root;password=Lancelot@28m;database=class1"


    Private Sub DataGridAppointView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridAppointView.CellContentClick

    End Sub

    ' Method to load data from the view
    Private Sub LoadEmployeeAvailabilityView()
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' SQL to select from the view
                Dim sql As String = "SELECT * FROM employee_availability_corrected"

                Using command As New MySqlCommand(sql, connection)
                    Using adapter As New MySqlDataAdapter(command)
                        Dim dataTable As New DataTable()
                        adapter.Fill(dataTable)

                        ' Bind to DataGridView
                        DataGridAppointView.DataSource = dataTable

                        ' Format the grid
                        FormatEmployeeGrid()


                    End Using
                End Using
            End Using

        Catch ex As MySqlException
            MessageBox.Show($"Database error: {ex.Message}", "Database Error")
        Catch ex As Exception
            MessageBox.Show($"Error loading view: {ex.Message}", "Error")
        End Try
    End Sub

    Private Sub FormatEmployeeGrid()
        If DataGridAppointView.Columns.Count > 0 Then
            ' Set column headers
            DataGridAppointView.Columns("employee_id").HeaderText = "ID"
            DataGridAppointView.Columns("first_name").HeaderText = "First Name"
            DataGridAppointView.Columns("last_name").HeaderText = "Last Name"
            DataGridAppointView.Columns("position").HeaderText = "Position"
            DataGridAppointView.Columns("status").HeaderText = "Status"
            DataGridAppointView.Columns("availability_status").HeaderText = "Availability"
            DataGridAppointView.Columns("next_appointment_time").HeaderText = "Next Appointment"

            ' Hide additional columns if they exist (from alternative version)
            If DataGridAppointView.Columns.Contains("next_appointment_date") Then
                DataGridAppointView.Columns("next_appointment_date").HeaderText = "Next Date"
            End If
            If DataGridAppointView.Columns.Contains("today_appointment_count") Then
                DataGridAppointView.Columns("today_appointment_count").HeaderText = "Today"
            End If

            If DataGridAppointView.Columns.Contains("total_future_appointments") Then
                DataGridAppointView.Columns("total_future_appointments").HeaderText = "Future Apps"
            End If

            ' Color code availability status with more detailed colors
            For Each row As DataGridViewRow In DataGridAppointView.Rows
                If row.IsNewRow Then Continue For

                Dim availabilityCell As DataGridViewCell = row.Cells("availability_status")
                If availabilityCell.Value IsNot Nothing Then
                    Select Case availabilityCell.Value.ToString().ToLower()
                        Case "busy"
                            availabilityCell.Style.BackColor = Color.LightCoral
                            availabilityCell.Style.ForeColor = Color.DarkRed
                            row.DefaultCellStyle.BackColor = Color.MistyRose
                        Case "available (booked today)"
                            availabilityCell.Style.BackColor = Color.LightYellow
                            availabilityCell.Style.ForeColor = Color.Orange
                        Case "available (future bookings)"
                            availabilityCell.Style.BackColor = Color.LightBlue
                            availabilityCell.Style.ForeColor = Color.DarkBlue
                        Case "available"
                            availabilityCell.Style.BackColor = Color.LightGreen
                            availabilityCell.Style.ForeColor = Color.DarkGreen
                        Case Else
                            availabilityCell.Style.BackColor = Color.LightGray
                            availabilityCell.Style.ForeColor = Color.DarkGray
                    End Select
                End If
            Next

            ' Auto-size columns
            DataGridAppointView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)

            ' Make grid read-only
            DataGridAppointView.ReadOnly = True
            DataGridAppointView.RowHeadersVisible = False
            DataGridAppointView.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        End If
    End Sub

    Private Sub FormAppointment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadEmployeeAvailabilityView()
    End Sub
End Class