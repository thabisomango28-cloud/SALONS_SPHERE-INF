Imports System.Text
Imports MySql.Data.MySqlClient

Public Class FormServices
    Dim mysqlconn As New MySql.Data.MySqlClient.MySqlConnection
    Dim COMMAND As MySql.Data.MySqlClient.MySqlCommand


    Private ConnectionString As String = "server=localhost;userid=root;password=Lancelot@28m;database=class1;CharSet=utf8mb4;"
    Private cartItems As New DataTable()

    Private Sub LoadInventory()
        Using connection As New MySqlConnection(ConnectionString)
            Try
                connection.Open()
                Dim query As String = "SELECT item_id, item_name, category, quantity, price FROM item WHERE quantity > 0"
                Dim adapter As New MySqlDataAdapter(query, connection)
                Dim dt As New DataTable()
                adapter.Fill(dt)

                ' Bind directly to DataTable instead of BindingSource
                DataGridViewService.DataSource = dt

            Catch ex As Exception
                MessageBox.Show("Error loading inventory: " & ex.Message)
            End Try
        End Using

    End Sub

    Private Sub FormServices_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadInventory()
        InitializeCart()
        LoadComboBoxes()
        LoadPaymentTypes()
    End Sub

    Private Sub LoadPaymentTypes()
        cmbPaymentType.Items.Clear()
        cmbPaymentType.Items.Add("Cash")
        cmbPaymentType.Items.Add("Card")
        cmbPaymentType.Items.Add("EFT")
    End Sub

    Private Sub InitializeCart()
        ' Create cart table structure
        cartItems.Columns.Add("ProductID", GetType(Integer))
        cartItems.Columns.Add("ProductName", GetType(String))
        cartItems.Columns.Add("Category", GetType(String))
        cartItems.Columns.Add("Price", GetType(Decimal))
        cartItems.Columns.Add("Quantity", GetType(Integer))
        cartItems.Columns.Add("Subtotal", GetType(Decimal))

        DataGridView2.DataSource = cartItems
        CalculateTotal()
    End Sub

    Private Sub LoadComboBoxes()
        Using connection As New MySqlConnection(ConnectionString)
            Try
                connection.Open()

                ' Load Product IDs
                Dim idQuery As String = "SELECT item_id FROM item WHERE quantity > 0 ORDER BY item_id"
                Dim idAdapter As New MySqlDataAdapter(idQuery, connection)
                Dim idTable As New DataTable()
                idAdapter.Fill(idTable)
                cmbProductID.DataSource = idTable
                cmbProductID.DisplayMember = "item_id"
                cmbProductID.ValueMember = "item_id"

                ' Load Categories
                Dim catQuery As String = "SELECT DISTINCT category FROM item WHERE quantity > 0 ORDER BY category"
                Dim catAdapter As New MySqlDataAdapter(catQuery, connection)
                Dim catTable As New DataTable()
                catAdapter.Fill(catTable)
                cmbType.DataSource = catTable
                cmbType.DisplayMember = "category"
                cmbType.ValueMember = "category"

            Catch ex As Exception
                MessageBox.Show("Error loading combo boxes: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub cmbProductID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProductID.SelectedIndexChanged
        If cmbProductID.SelectedValue IsNot Nothing Then
            LoadProductDetails(cmbProductID.SelectedValue.ToString())
        End If
    End Sub

    Private Sub cmbType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbType.SelectedIndexChanged
        FilterInventoryByCategory()
    End Sub


    Private Sub LoadProductDetails(productId As String)
        Using connection As New MySqlConnection(ConnectionString)
            Try
                connection.Open()
                Dim query As String = "SELECT item_name, category, price, quantity FROM item WHERE item_id = @item_id"

                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@item_id", productId)

                    Using reader As MySqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            txtProductName.Text = reader.GetString("item_name")
                            cmbType.Text = reader.GetString("category")
                            lblPrice.Text = reader.GetDecimal("price").ToString("C")
                            lblStock.Text = reader.GetInt32("quantity").ToString() & " in stock"
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading product details: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub FilterInventoryByCategory()
        If cmbType.SelectedValue IsNot Nothing Then
            Dim category As String = cmbType.SelectedValue.ToString()
            Dim dv As DataView = DirectCast(DataGridViewService.DataSource, DataTable).DefaultView

            If category = "All" Then
                dv.RowFilter = ""
            Else
                dv.RowFilter = $"category = '{category.Replace("'", "''")}'"
            End If
        End If
    End Sub

    Private Function ValidateAddToCart() As Boolean
        If cmbProductID.SelectedValue Is Nothing Then
            MessageBox.Show("Please select a product")
            Return False
        End If
        If String.IsNullOrEmpty(txtQuantity.Text) OrElse Not Integer.TryParse(txtQuantity.Text, Nothing) Then
            MessageBox.Show("Please enter a valid quantity")
            txtQuantity.Focus()
            Return False
        End If

        Dim quantity As Integer = Integer.Parse(txtQuantity.Text)
        If quantity <= 0 Then
            MessageBox.Show("Quantity must be greater than 0")
            txtQuantity.Focus()
            Return False
        End If

        ' Check stock availability
        If quantity > GetAvailableStock(cmbProductID.SelectedValue.ToString()) Then
            MessageBox.Show("Insufficient stock available")
            txtQuantity.Focus()
            Return False
        End If

        Return True

    End Function

    Private Function GetAvailableStock(productId As String) As Integer
        Using connection As New MySqlConnection(ConnectionString)
            Try
                connection.Open()
                Dim query As String = "SELECT quantity FROM item WHERE item_id = @item_id"

                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@item_id", productId)
                    Return CInt(command.ExecuteScalar())
                End Using
            Catch ex As Exception
                Return 0
            End Try
        End Using
    End Function

    Private Sub AddItemToCart()
        Try
            Dim productId As Integer = Integer.Parse(cmbProductID.SelectedValue.ToString())
            Dim productName As String = txtProductName.Text
            Dim category As String = cmbType.Text
            Dim price As Decimal = Decimal.Parse(lblPrice.Text.Replace("$", "").Replace("R", "").Trim())
            Dim quantity As Integer = Integer.Parse(txtQuantity.Text)
            Dim subtotal As Decimal = price * quantity

            ' DEBUG: Check what's in the cart before adding
            MessageBox.Show($"Adding: {productName} x {quantity} - Cart currently has {cartItems.Rows.Count} items")

            ' Check if item already exists in cart - FIXED LOGIC
            Dim existingRows() As DataRow = cartItems.Select($"ProductID = {productId}")

            If existingRows.Length > 0 Then
                ' Update existing item quantity - FIXED: Use the correct row reference
                Dim existingRow As DataRow = existingRows(0)
                Dim currentQuantity As Integer = CInt(existingRow("Quantity"))
                Dim newQuantity As Integer = currentQuantity + quantity
                existingRow("Quantity") = newQuantity
                existingRow("Subtotal") = price * newQuantity
                MessageBox.Show($"Updated existing item: {productName} from {currentQuantity} to {newQuantity}")
            Else
                ' Add new item to cart
                Dim newRow As DataRow = cartItems.NewRow()
                newRow("ProductID") = productId
                newRow("ProductName") = productName
                newRow("Category") = category
                newRow("Price") = price
                newRow("Quantity") = quantity
                newRow("Subtotal") = subtotal
                cartItems.Rows.Add(newRow)
                MessageBox.Show($"Added new item: {productName} x {quantity}")
            End If

            ' Refresh the DataGridView
            DataGridView2.Refresh()
            CalculateTotal()
            ClearProductFields()

        Catch ex As Exception
            MessageBox.Show("Error adding to cart: " & ex.Message)
        End Try

        CalculateTotal()
        ClearProductFields()
    End Sub

    Private Sub CalculateTotal()
        Dim subtotal As Decimal = 0

        For Each row As DataRow In cartItems.Rows
            subtotal += CDec(row("Subtotal"))
        Next



        ' Calculate grand total
        Dim grandTotal As Decimal = subtotal
        lblGrandTotal.Text = grandTotal.ToString("C")
    End Sub

    Private Sub ClearProductFields()
        txtQuantity.Clear()
        If cmbProductID.Items.Count > 0 Then
            cmbProductID.SelectedIndex = 0
        End If
    End Sub




    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewService.CellContentClick
        If e.RowIndex >= 0 Then ' Ensure a valid row is clicked (not header)
            Try
                Dim selectedRow As DataGridViewRow = DataGridViewService.Rows(e.RowIndex)

                ' Get the values from the clicked row
                Dim itemId As String = selectedRow.Cells("item_id").Value.ToString()
                Dim itemName As String = selectedRow.Cells("item_name").Value.ToString()
                Dim category As String = selectedRow.Cells("category").Value.ToString()
                Dim price As Decimal = Convert.ToDecimal(selectedRow.Cells("price").Value)
                Dim stockQuantity As Integer = Convert.ToInt32(selectedRow.Cells("quantity").Value)

                ' Auto-fill the form fields
                cmbProductID.SelectedValue = itemId
                txtProductName.Text = itemName
                cmbType.Text = category
                lblPrice.Text = price.ToString("C")
                lblstock.Text = stockQuantity.ToString() & " in stock"

                ' Auto-focus on quantity field for quick entry
                txtQuantity.Focus()
                txtQuantity.SelectAll()

            Catch ex As Exception
                MessageBox.Show("Error selecting product: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ValidateAddToCart() Then
            AddItemToCart()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        cartItems.Rows.Clear()
        CalculateTotal()
        ClearProductFields()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If DataGridView2.CurrentRow IsNot Nothing Then
            Dim selectedIndex As Integer = DataGridView2.CurrentRow.Index
            If selectedIndex >= 0 AndAlso selectedIndex < cartItems.Rows.Count Then
                cartItems.Rows.RemoveAt(selectedIndex)
                CalculateTotal()
            End If
        Else
            MessageBox.Show("Please select an item to remove")
        End If
    End Sub

    Private Sub btnProcessPayment_Click(sender As Object, e As EventArgs) Handles btnProcessPayment.Click
        If cartItems.Rows.Count = 0 Then
            MessageBox.Show("Cart is empty. Please add items first.")
            Return
        End If

        If cmbPaymentType.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a payment type")
            cmbPaymentType.Focus()
            Return
        End If

        If String.IsNullOrEmpty(txtAmountPaid.Text) OrElse Not Decimal.TryParse(txtAmountPaid.Text, Nothing) Then
            MessageBox.Show("Please enter a valid amount paid")
            txtAmountPaid.Focus()
            Return
        End If

        Dim amountPaid As Decimal = Decimal.Parse(txtAmountPaid.Text)
        Dim grandTotal As Decimal = Decimal.Parse(lblGrandTotal.Text.Replace("R", "").Replace("$", "").Trim())

        If amountPaid < grandTotal Then
            MessageBox.Show("Amount paid is less than the total amount due")
            txtAmountPaid.Focus()
            Return
        End If

        Dim change As Decimal = amountPaid - grandTotal
        lblChange.Text = change.ToString("C")

        ' Ask for confirmation
        Dim result As DialogResult = MessageBox.Show($"Total: {grandTotal:C}" & Environment.NewLine &
                                               $"Amount Paid: {amountPaid:C}" & Environment.NewLine &
                                               $"Change: {change:C}" & Environment.NewLine &
                                               $"Payment Type: {cmbPaymentType.SelectedItem}" & Environment.NewLine &
                                               "Confirm payment?", "Confirm Payment", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            If ProcessSale() Then
                MessageBox.Show("Sale processed successfully! Change: " & change.ToString("C"))
                GenerateReceipt()
                ResetForm()
            Else
                MessageBox.Show("Error processing sale. Please try again.")
            End If
        End If
    End Sub


    Private Function ProcessSale() As Boolean
        Using connection As New MySqlConnection(ConnectionString)
            Try
                connection.Open()

                ' Start transaction
                Using transaction As MySqlTransaction = connection.BeginTransaction()
                    Try
                        ' Insert sale record
                        Dim saleQuery As String = "INSERT INTO sales (sale_date, total_amount, payment_type) VALUES (@sale_date, @total_amount, @payment_type); SELECT LAST_INSERT_ID();"

                        Using saleCommand As New MySqlCommand(saleQuery, connection, transaction)
                            saleCommand.Parameters.AddWithValue("@sale_date", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))
                            saleCommand.Parameters.AddWithValue("@total_amount", Decimal.Parse(lblGrandTotal.Text.Replace("$", "").Replace("R", "").Trim()))
                            saleCommand.Parameters.AddWithValue("@payment_type", cmbPaymentType.SelectedItem.ToString())

                            Dim saleId As Integer = CInt(saleCommand.ExecuteScalar())

                            ' Insert sale items and update inventory
                            For Each row As DataRow In cartItems.Rows
                                Dim productId As Integer = CInt(row("ProductID"))
                                Dim quantity As Integer = CInt(row("Quantity"))

                                ' Insert sale item
                                Dim itemQuery As String = "INSERT INTO sale_items (sale_id, item_id, quantity, unit_price) VALUES (@sale_id, @item_id, @quantity, @unit_price)"

                                Using itemCommand As New MySqlCommand(itemQuery, connection, transaction)
                                    itemCommand.Parameters.AddWithValue("@sale_id", saleId)
                                    itemCommand.Parameters.AddWithValue("@item_id", productId)
                                    itemCommand.Parameters.AddWithValue("@quantity", quantity)
                                    itemCommand.Parameters.AddWithValue("@unit_price", CDec(row("Price")))
                                    itemCommand.ExecuteNonQuery()
                                End Using

                                ' Update inventory
                                Dim updateQuery As String = "UPDATE item SET quantity = quantity - @quantity WHERE item_id = @item_id"

                                Using updateCommand As New MySqlCommand(updateQuery, connection, transaction)
                                    updateCommand.Parameters.AddWithValue("@quantity", quantity)
                                    updateCommand.Parameters.AddWithValue("@item_id", productId)
                                    updateCommand.ExecuteNonQuery()
                                End Using
                            Next

                            transaction.Commit()
                            Return True
                        End Using

                    Catch ex As Exception
                        transaction.Rollback()
                        Throw
                    End Try
                End Using

            Catch ex As Exception
                MessageBox.Show("Error processing sale: " & ex.Message)
                Return False
            End Try
        End Using
    End Function

    Private Sub GenerateReceipt()
        Try
            Dim receipt As New StringBuilder()
            receipt.AppendLine("SALONS SELLERIE - RECEIPT")
            receipt.AppendLine("Date: " & DateTime.Now.ToString("yyyy-MM-dd HH:mm"))
            receipt.AppendLine("Payment Type: " & cmbPaymentType.SelectedItem.ToString())
            receipt.AppendLine("".PadRight(40, "-"))
            receipt.AppendLine()

            receipt.AppendLine("ITEMS PURCHASED:")
            receipt.AppendLine("".PadRight(40, "-"))

            For Each row As DataRow In cartItems.Rows
                receipt.AppendLine($"{row("ProductName")}")
                receipt.AppendLine($"  {row("Quantity")} x {CDec(row("Price")):C} = {CDec(row("Subtotal")):C}")
            Next

            receipt.AppendLine("".PadRight(40, "-"))
            receipt.AppendLine($"TOTAL: {lblGrandTotal.Text}")
            receipt.AppendLine($"AMOUNT PAID: {Decimal.Parse(txtAmountPaid.Text):C}")
            receipt.AppendLine($"CHANGE: {lblChange.Text}")
            receipt.AppendLine()
            receipt.AppendLine("Thank you for your business!")

            ' Show receipt and option to print
            MessageBox.Show(receipt.ToString(), "Receipt - Sale Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error generating receipt: " & ex.Message)
        End Try
    End Sub


    Private Sub ResetForm()
        cartItems.Rows.Clear()
        CalculateTotal()
        ClearProductFields()
        txtAmountPaid.Clear()
        lblChange.Text = "R0.00"
        cmbPaymentType.SelectedIndex = -1
        LoadInventory() ' Refresh inventory grid

        ' Reset focus
        If cmbProductID.Items.Count > 0 Then
            cmbProductID.SelectedIndex = 0
        End If

    End Sub

    Private Sub txtAmountPaid_TextChanged(sender As Object, e As EventArgs) Handles txtAmountPaid.TextChanged
        CalculateChange()
    End Sub

    Private Sub CalculateChange()
        Try
            If String.IsNullOrEmpty(txtAmountPaid.Text) Then
                lblChange.Text = "R0.00"
                Return
            End If

            Dim amountPaid As Decimal = Decimal.Parse(txtAmountPaid.Text)
            Dim grandTotal As Decimal = Decimal.Parse(lblGrandTotal.Text.Replace("R", "").Replace("$", "").Trim())

            If amountPaid >= grandTotal Then
                Dim change As Decimal = amountPaid - grandTotal
                lblChange.Text = change.ToString("C")
            Else
                lblChange.Text = "R0.00"
            End If

        Catch ex As Exception
            lblChange.Text = "R0.00"
        End Try
    End Sub

    'Private Sub DataGridInventory_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewService.CellClick

    ' End Sub
End Class