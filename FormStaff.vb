Public Class FormStaff
    Dim mysqlconn As New MySql.Data.MySqlClient.MySqlConnection
    Dim COMMAND As MySql.Data.MySqlClient.MySqlCommand


    Private Sub FormStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mysqlconn = New MySql.Data.MySqlClient.MySqlConnection
        mysqlconn.ConnectionString = "server=localhost;userid=root;password=Lancelot@28m;database=class1"
        Dim SDA As New MySql.Data.MySqlClient.MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource
        Try
            mysqlconn.Open()
            Dim Query As String
            Query = "select * from employeestatustimeview"
            COMMAND = New MySql.Data.MySqlClient.MySqlCommand(Query, mysqlconn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbdataset)
            bsource.DataSource = dbdataset
            DataGridViewstuff.DataSource = bsource
            SDA.Update(dbdataset)

            mysqlconn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ' Handle DataGridView cell click event
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewstuff.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            DisplaySelectedRowData(e.RowIndex)
        End If
    End Sub

    ' Method to display selected row data in textboxes
    Private Sub DisplaySelectedRowData(rowIndex As Integer)
        If rowIndex >= 0 AndAlso rowIndex < DataGridViewstuff.Rows.Count Then
            Dim selectedRow As DataGridViewRow = DataGridViewstuff.Rows(rowIndex)

            ' Display data in textboxes
            lblemID.Text = selectedRow.Cells("employee_id").Value?.ToString()
            lblfname.Text = selectedRow.Cells("first_name").Value?.ToString()
            lblsurname.Text = selectedRow.Cells("last_name").Value?.ToString()
            lblRole.Text = selectedRow.Cells("position").Value?.ToString()
            lblStatus.Text = selectedRow.Cells("status").Value?.ToString()

            ' Update the labels as shown in your screenshot
            UpdateEmployeeLabels(selectedRow)
        End If
    End Sub


    ' Method to update the employee information labels
    Private Sub UpdateEmployeeLabels(selectedRow As DataGridViewRow)
        ' Update Label4 with employee name
        lblfname.Text = selectedRow.Cells("first_name").Value?.ToString() & " " &
                      selectedRow.Cells("last_name").Value?.ToString()

        ' Update role label
        lblRole.Text = selectedRow.Cells("position").Value?.ToString()

        ' Update status label
        lblStatus.Text = selectedRow.Cells("status").Value?.ToString()

        ' Change status label color based on status
        If selectedRow.Cells("status").Value?.ToString().ToLower() = "Booked" Then
            lblStatus.ForeColor = Color.Red
        Else
            lblStatus.ForeColor = Color.Green
        End If
    End Sub

    Private Sub lblStatus_Click(sender As Object, e As EventArgs) Handles lblStatus.Click

    End Sub

    Private Sub DataGridViewstuff_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewstuff.CellContentClick

    End Sub
End Class