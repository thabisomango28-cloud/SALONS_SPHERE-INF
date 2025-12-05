Imports MySql.Data.MySqlClient

Public Class adminstock

    Private connectionString As String = "server=localhost;userid=root;password=Lancelot@28m;database=class1"
    Private currentItemId As Integer = 0 ' To track selected item for updat

    Private Sub InsertItem()
        If String.IsNullOrWhiteSpace(txtItemName.Text) OrElse
           String.IsNullOrWhiteSpace(txtCategory.Text) OrElse
           String.IsNullOrWhiteSpace(txtquantity.Text) OrElse
           String.IsNullOrWhiteSpace(txtReorder.Text) OrElse
           String.IsNullOrWhiteSpace(txtPrice.Text) Then
            MessageBox.Show("Please fill all fields", "Validation Error")
            Return
        End If
        Dim price As Decimal
        If Not Decimal.TryParse(txtPrice.Text, price) Then
            MessageBox.Show("Please enter a valid price", "Validation Error")
            Return
        End If

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Dim sql As String = "INSERT INTO item (item_name, category,quantity,reorder_level, price) VALUES (@ItemName, @Category,@quantity,@reorder_level, @Price)"

                Using command As New MySqlCommand(sql, connection)
                    command.Parameters.AddWithValue("@ItemName", txtItemName.Text.Trim())
                    command.Parameters.AddWithValue("@Category", txtCategory.Text.Trim())
                    command.Parameters.AddWithValue("@quantity", txtquantity.Text.Trim())
                    command.Parameters.AddWithValue("@reorder_level", txtReorder.Text.Trim())
                    command.Parameters.AddWithValue("@Price", price)

                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Item added successfully!", "Success")
                        ClearFields()
                    Else
                        MessageBox.Show("Failed to add item", "Error")
                    End If
                End Using
            End Using

        Catch ex As MySqlException
            MessageBox.Show($"MySQL Error: {ex.Message}", "Database Error")
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error")
        End Try
    End Sub

    Private Sub ClearFields()
        txtItemName.Clear()
        txtCategory.Clear()
        txtPrice.Clear()
        txtquantity.Clear()
        txtReorder.Clear()
    End Sub
    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        InsertItem()
        LoadItemsToDataGridView()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub
    Private Sub adminstock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadItemsToDataGridView()
    End Sub


    ' Method to load items from database to DataGridView
    Private Sub LoadItemsToDataGridView()
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' SQL SELECT statement to get all items
                Dim sql As String = "SELECT item_id, item_name, category,Quantity,reorder_level, price FROM item ORDER BY item_id"

                Using command As New MySqlCommand(sql, connection)
                    Using adapter As New MySqlDataAdapter(command)
                        Dim dataTable As New DataTable()
                        adapter.Fill(dataTable)

                        ' Bind DataTable to DataGridView
                        DataGridViewstock.DataSource = dataTable

                        ' Optional: Format column headers
                        FormatDataGridView()
                    End Using
                End Using
            End Using

        Catch ex As MySqlException
            MessageBox.Show($"Database error: {ex.Message}", "Database Error")
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error")
        End Try
    End Sub

    ' Method to format DataGridView appearance
    Private Sub FormatDataGridView()
        If DataGridViewstock.Columns.Count > 0 Then
            ' Set column headers text
            DataGridViewstock.Columns("item_id").HeaderText = "Item ID"
            DataGridViewstock.Columns("item_name").HeaderText = "Item Name"
            DataGridViewstock.Columns("category").HeaderText = "Category"
            DataGridViewstock.Columns("quantity").HeaderText = "quantity"
            DataGridViewstock.Columns("reorder_level").HeaderText = "Reorder Level"
            DataGridViewstock.Columns("price").HeaderText = "Price"

            ' Format price column as currency
            DataGridViewstock.Columns("price").DefaultCellStyle.Format = "C2"
            DataGridViewstock.Columns("price").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            ' Auto-size columns to fit content
            DataGridViewstock.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)

            ' Optional: Set alternating row colors
            DataGridViewstock.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray

            ' Make the grid read-only
            DataGridViewstock.ReadOnly = True

            ' Enable row headers but make them not visible
            DataGridViewstock.RowHeadersVisible = False

            ' Set selection mode
            DataGridViewstock.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        End If
    End Sub
    ' Double-click event on DataGridView to populate fields for editing
    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridViewstock.DoubleClick
        If DataGridViewstock.CurrentRow IsNot Nothing AndAlso DataGridViewstock.CurrentRow.Index >= 0 Then
            Dim selectedRow As DataGridViewRow = DataGridViewstock.CurrentRow

            ' Populate text fields with selected row data
            txtItemName.Text = selectedRow.Cells("item_name").Value.ToString()
            txtCategory.Text = selectedRow.Cells("category").Value.ToString()
            txtquantity.Text = selectedRow.Cells("quantity").Value.ToString()
            txtReorder.Text = selectedRow.Cells("reorder_level").Value.ToString()
            txtPrice.Text = selectedRow.Cells("price").Value.ToString()
        End If
    End Sub

    Private Sub DeleteItem()
        If currentItemId = 0 Then
            MessageBox.Show("Please select an item to delete", "Info")
            Return
        End If
        If MessageBox.Show("Are you sure you want to delete this item?", "Confirm Delete",
                          MessageBoxButtons.YesNo) = DialogResult.Yes Then

            Try
                Using connection As New MySqlConnection(connectionString)
                    connection.Open()

                    Dim sql As String = "DELETE FROM item WHERE item_id = @ItemId"

                    Using command As New MySqlCommand(sql, connection)
                        command.Parameters.AddWithValue("@ItemId", currentItemId)

                        If command.ExecuteNonQuery() > 0 Then
                            MessageBox.Show("Item deleted successfully!", "Success")
                            ClearFields()
                            LoadItemsToDataGridView()
                        End If
                    End Using
                End Using

            Catch ex As Exception
                MessageBox.Show($"Error deleting item: {ex.Message}", "Error")
            End Try
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DeleteItem()
        LoadItemsToDataGridView()
    End Sub
End Class