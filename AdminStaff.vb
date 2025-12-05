Imports System.IO
Imports MySql.Data.MySqlClient

Public Class AdminStaff
    Private photoFilePath As String = String.Empty
    Dim connectionString As String = "server=localhost;userid=root;password=Lancelot@28m;database=class1"
    Private currentEmployeeid As Integer = 0 ' To track selected item for updat
    Dim mysqlconn As New MySql.Data.MySqlClient.MySqlConnection
    Private COMMAND As MySql.Data.MySqlClient.MySqlCommand
    Private lblPhotoPath As Object

    Private Sub AdminStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadEmployeesToDataGridView()
    End Sub

    Private Sub LoadEmployeesToDataGridView()
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' SQL SELECT statement based on your table structure from screenshot
                Dim sql As String = "SELECT employee_id, first_name, last_name, position, status, photo_path FROM employee ORDER BY employee_id"

                Using command As New MySqlCommand(sql, connection)
                    Using adapter As New MySqlDataAdapter(command)
                        Dim dataTable As New DataTable()
                        adapter.Fill(dataTable)

                        ' Bind DataTable to DataGridView
                        DataGridViewstuff.DataSource = dataTable

                        ' Format column headers
                        FormatEmployeeDataGridView()
                    End Using
                End Using
            End Using

        Catch ex As MySqlException
            MessageBox.Show($"Database error: {ex.Message}", "Database Error")
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error")
        End Try
    End Sub



    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If ValidateForm() Then
            InsertEmployeeWithPhoto()
        End If
    End Sub

    Private Function ValidateForm() As Boolean
        If String.IsNullOrEmpty(txtFname.Text) Then
            MessageBox.Show("Please enter first name", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtFname.Focus()
            Return False
        End If

        If String.IsNullOrEmpty(txtLastname.Text) Then
            MessageBox.Show("Please enter last name", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtLastname.Focus()
            Return False
        End If

        If String.IsNullOrEmpty(txtPosition.Text) Then
            MessageBox.Show("Please enter position", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPosition.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub InsertEmployeeWithPhoto()
        Dim connectionString As String = "server=localhost;userid=root;password=Lancelot@28m;database=class1"

        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Dim photoPathInDb As String = String.Empty

                ' If photo was selected, save it and get the path
                If Not String.IsNullOrEmpty(photoFilePath) Then
                    photoPathInDb = SaveEmployeePhoto()
                End If

                ' SQL query to insert employee data
                Dim query As String = "INSERT INTO employee (first_name, last_name, position, status, photo_path) " &
                                      "VALUES (@firstName, @lastName, @position, @status, @photoPath)"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@firstName", txtFname.Text.Trim())
                    cmd.Parameters.AddWithValue("@lastName", txtLastname.Text.Trim())
                    cmd.Parameters.AddWithValue("@position", txtPosition.Text.Trim())
                    cmd.Parameters.AddWithValue("@status", "Available")
                    cmd.Parameters.AddWithValue("@photoPath", If(String.IsNullOrEmpty(photoPathInDb), DBNull.Value, photoPathInDb))

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Employee added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ClearForm()
                    Else
                        MessageBox.Show("Failed to add employee", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function SaveEmployeePhoto() As String
        Try
            ' Create uploads directory if it doesn't exist
            Dim uploadsDir As String = Application.StartupPath & "\uploads\employees\"
            If Not Directory.Exists(uploadsDir) Then
                Directory.CreateDirectory(uploadsDir)
            End If

            ' Generate unique filename
            Dim fileExtension As String = Path.GetExtension(photoFilePath)
            Dim newFileName As String = $"emp_{DateTime.Now:yyyyMMddHHmmssfff}{fileExtension}"
            Dim newFilePath As String = Path.Combine(uploadsDir, newFileName)

            ' Copy file to uploads directory
            File.Copy(photoFilePath, newFilePath, True)

            ' Return relative path for database storage
            Return $"uploads/employees/{newFileName}"

        Catch ex As Exception
            MessageBox.Show("Error saving photo: " & ex.Message, "Photo Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return String.Empty
        End Try
    End Function

    Private Sub ClearForm()
        txtFname.Clear()
        txtLastname.Clear()
        txtPosition.Clear()
        photoFilePath = String.Empty
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Using OpenFileDialog As New OpenFileDialog()
            OpenFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp"
            OpenFileDialog.Title = "Select Employee Photo"
            OpenFileDialog.Multiselect = False

            If OpenFileDialog.ShowDialog() = DialogResult.OK Then
                photoFilePath = OpenFileDialog.FileName
                MessageBox.Show("Photo selected: " & Path.GetFileName(photoFilePath), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End Using
    End Sub

    Private Sub DataGridViewstuff_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewstuff.CellContentClick

    End Sub

    Private Function GetCommand() As MySqlCommand
        Return COMMAND
    End Function



    ' Method to format DataGridView appearance for Employees
    Private Sub FormatEmployeeDataGridView()
        If DataGridViewstuff.Columns.Count > 0 Then
            ' Set column headers text based on your table structure
            DataGridViewstuff.Columns("employee_id").HeaderText = "Employee ID"
            DataGridViewstuff.Columns("first_name").HeaderText = "First Name"
            DataGridViewstuff.Columns("last_name").HeaderText = "Last Name"
            DataGridViewstuff.Columns("position").HeaderText = "Position"
            DataGridViewstuff.Columns("status").HeaderText = "Status"
            DataGridViewstuff.Columns("photo_path").HeaderText = "Photo Path"



            ' Auto-size columns to fit content
            DataGridViewstuff.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)

            ' Optional: Set alternating row colors
            DataGridViewstuff.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray

            ' Make the grid read-only
            DataGridViewstuff.ReadOnly = True

            ' Enable row headers but make them not visible
            DataGridViewstuff.RowHeadersVisible = False

            ' Set selection mode
            DataGridViewstuff.SelectionMode = DataGridViewSelectionMode.FullRowSelect

            ' Optional: Color code status column
            ColorCodeStatusColumn()
        End If
    End Sub

    ' Method to color code the status column
    Private Sub ColorCodeStatusColumn()
        For Each row As DataGridViewRow In DataGridViewstuff.Rows
            If row.IsNewRow Then Continue For

            Dim statusCell As DataGridViewCell = row.Cells("status")
            If statusCell.Value IsNot Nothing Then
                Select Case statusCell.Value.ToString().ToLower()
                    Case "available"
                        statusCell.Style.BackColor = Color.LightGreen
                        statusCell.Style.ForeColor = Color.DarkGreen
                    Case "busy"
                        statusCell.Style.BackColor = Color.LightCoral
                        statusCell.Style.ForeColor = Color.DarkRed
                    Case "away"
                        statusCell.Style.BackColor = Color.LightYellow
                        statusCell.Style.ForeColor = Color.Orange
                    Case Else
                        statusCell.Style.BackColor = Color.LightGray
                        statusCell.Style.ForeColor = Color.DarkGray
                End Select
            End If
        Next
    End Sub


    ' Double-click event on DataGridView to populate fields for editing
    Private Sub DataGridViewstuff_DoubleClick(sender As Object, e As EventArgs) Handles DataGridViewstuff.DoubleClick
        If DataGridViewstuff.CurrentRow IsNot Nothing AndAlso DataGridViewstuff.CurrentRow.Index >= 0 Then

        End If
        Dim selectedRow As DataGridViewRow = DataGridViewstuff.CurrentRow

        ' Populate text fields with selected row data

        txtFname.Text = selectedRow.Cells("first_name").Value.ToString()
        txtLastname.Text = selectedRow.Cells("last_name").Value.ToString()
        txtPosition.Text = selectedRow.Cells("position").Value.ToString()



        ' Display photo path if available
        If selectedRow.Cells("photo_path").Value IsNot Nothing AndAlso
       Not String.IsNullOrEmpty(selectedRow.Cells("photo_path").Value.ToString()) Then
            lblPhotoPath.Text = "Photo: " & selectedRow.Cells("photo_path").Value.ToString()
        Else
            lblPhotoPath.Text = "No photo available"
        End If

    End Sub

    ' Method to search employees
    Private Sub SearchEmployees(searchTerm As String)
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Dim sql As String = "SELECT employee_id, first_name, last_name, position, service_rate, status, photo_path 
                               FROM employee 
                               WHERE first_name LIKE @SearchTerm OR last_name LIKE @SearchTerm 
                               OR position LIKE @SearchTerm OR status LIKE @SearchTerm
                               ORDER BY employee_id"

                Using command As New MySqlCommand(sql, connection)
                    command.Parameters.AddWithValue("@SearchTerm", "%" & searchTerm & "%")

                    Using adapter As New MySqlDataAdapter(command)
                        Dim dataTable As New DataTable()
                        adapter.Fill(dataTable)
                        DataGridViewstuff.DataSource = dataTable
                        FormatEmployeeDataGridView()
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show($"Error searching employee: {ex.Message}", "Error")
        End Try
    End Sub



    ' Method to clear employee fields
    Private Sub ClearEmployeeFields()
        currentEmployeeId = 0

    End Sub

    ' Method to search employees

    ' Search button click event



    ' Click event on DataGridView to set currentEmployeeId
    Private Sub DataGridViewstuff_Click(sender As Object, e As EventArgs) Handles DataGridViewstuff.Click
        If DataGridViewstuff.CurrentRow IsNot Nothing Then
            Dim selectedRow As DataGridViewRow = DataGridViewstuff.CurrentRow
            currentEmployeeId = Integer.Parse(selectedRow.Cells("employee_id").Value.ToString())
        End If
    End Sub


End Class

' Clear photo selection



