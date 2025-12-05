Imports MySql.Data.MySqlClient

Public Class adminFormSales




    Private Sub LoadSalesData()
        Try
            Dim connectionString As String = "server=localhost;userid=root;password=Lancelot@28m;database=class1"

            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                ' Use either view - choose one:
                Dim query As String = "SELECT * FROM sales_summary_view ORDER BY sale_date DESC"


                Using cmd As New MySqlCommand(query, conn)
                    Using adapter As New MySqlDataAdapter(cmd)
                        Dim dataTable As New DataTable()
                        adapter.Fill(dataTable)

                        ' Bind to DataGridView
                        DataGridAppointView.DataSource = dataTable

                        ' Optional: Format the DataGridView
                        FormatSalesDataGridView()
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading sales data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FormatSalesDataGridView()
        ' Auto-size columns to fit content
        DataGridAppointView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells

        ' Format currency columns
        If DataGridAppointView.Columns.Contains("Total Amount") Then
            DataGridAppointView.Columns("Total Amount").DefaultCellStyle.Format = "C2"
        End If

        If DataGridAppointView.Columns.Contains("unit_price") Then
            DataGridAppointView.Columns("unit_price").DefaultCellStyle.Format = "C2"
        End If

        If DataGridAppointView.Columns.Contains("item_total") Then
            DataGridAppointView.Columns("item_total").DefaultCellStyle.Format = "C2"
        End If

        ' Set column headers appearance
        DataGridAppointView.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        DataGridAppointView.EnableHeadersVisualStyles = False
        DataGridAppointView.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue

        ' Alternating row colors
        DataGridAppointView.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray
    End Sub

    Private Sub adminFormSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSalesData()
        LoadSalesData()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub DataGridAppointView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridAppointView.CellContentClick

    End Sub
End Class