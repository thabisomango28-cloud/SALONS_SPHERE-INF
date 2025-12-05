Imports MySql.Data.MySqlClient
Imports System.Threading

Public Class FormDashboard
    Private connectionString As String = "server=localhost;userid=root;password=Lancelot@28m;database=class1;"

    Private Sub FormDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTime.Text = DateTime.Now.ToString("HH:mm")
        LoadDailyAppointments()
        LoadDailySales()
        ShowMostPurchasedItemToday()
    End Sub
    Private Sub CheckLowStock()
        Try
            Dim query As String = "SELECT COUNT(*) as low_count FROM low_stock_items"

            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Using cmd As New MySqlCommand(query, conn)
                    Dim lowStockCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                    If lowStockCount > 0 Then
                        Label10.Text = $"STOCK IS LOW - {lowStockCount} items need reorder!"
                    Else
                        lblMessage.Text = "Stock levels are good"
                    End If
                End Using
            End Using

        Catch ex As Exception
            lblMessage.Text = "Stock levels are good"
        End Try
    End Sub

    Private Sub ShowMostPurchasedItemToday()
        Try
            Dim query As String = "SELECT * FROM today_best_seller"

            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Dim itemName As String = reader.GetString("item_name")
                            Dim totalSold As Integer = reader.GetInt32("total_sold_today")
                            lblBestsell.Text = $"Best Seller: {itemName}"
                        Else
                            lblBestsell.Text = "No sales today"
                        End If
                    End Using
                End Using
            End Using

        Catch ex As Exception
            lblBestSelling.Text = "No sales today"
        End Try
    End Sub

    ' Method to calculate and display daily appointments count
    Private Sub LoadDailyAppointments()
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' SQL to count appointments for today
                Dim sql As String = "SELECT COUNT(*) as appointment_count 
                                   FROM appointmentsss 
                                   WHERE DATE(appointment_date) = CURDATE()"


                Using command As New MySqlCommand(sql, connection)
                    Dim appointmentCount As Integer = Convert.ToInt32(command.ExecuteScalar())

                    ' Update the appointments label
                    lblAppnum.Text = appointmentCount.ToString() & "+"

                    ' Optional: Change color based on count
                    If appointmentCount = 0 Then
                        lblAppnum.ForeColor = Color.Gray
                    ElseIf appointmentCount <= 5 Then
                        lblAppnum.ForeColor = Color.Green
                    Else
                        lblAppnum.ForeColor = Color.Orange
                    End If
                End Using
            End Using

        Catch ex As MySqlException
            lblAppnum.Text = "0+"
            lblAppnum.ForeColor = Color.Red
            MessageBox.Show($"Database error loading appointments: {ex.Message}", "Database Error")
        Catch ex As Exception
            lblAppnum.Text = "0+"
            lblAppnum.ForeColor = Color.Red
            MessageBox.Show($"Error loading appointments: {ex.Message}", "Error")
        End Try
    End Sub
    ' Method to calculate and display daily sales total
    Private Sub LoadDailySales()
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' SQL to sum sales for today
                Dim sql As String = "SELECT COALESCE(SUM(total_amount), 0) as daily_sales 
                                   FROM sales 
                                   WHERE DATE(sale_date) = CURDATE() "


                Using command As New MySqlCommand(sql, connection)
                    Dim dailySales As Decimal = Convert.ToDecimal(command.ExecuteScalar())

                    ' Update the sales label
                    lblSales.Text = dailySales.ToString("C0") & "+"

                    ' Optional: Change color based on sales amount
                    If dailySales = 0 Then
                        lblSales.ForeColor = Color.Gray
                    ElseIf dailySales < 100 Then
                        lblSales.ForeColor = Color.Orange
                    Else
                        lblSales.ForeColor = Color.Green
                    End If
                End Using
            End Using

        Catch ex As MySqlException
            lblSales.Text = "$0+"
            lblSales.ForeColor = Color.Red
            MessageBox.Show($"Database error loading sales: {ex.Message}", "Database Error")
        Catch ex As Exception
            lblSales.Text = "$0+"
            lblSales.ForeColor = Color.Red
            MessageBox.Show($"Error loading sales: {ex.Message}", "Error")
        End Try
    End Sub

    ' Method to load both appointments and sales
    Private Sub LoadDashboardData()
        LoadDailyAppointments()
        LoadDailySales()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LoadDailyAppointments()
        LoadDailySales()
    End Sub

    Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs) Handles Panel6.Paint

    End Sub
End Class