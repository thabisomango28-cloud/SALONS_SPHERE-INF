Imports MySql.Data.MySqlClient

Public Class LoginForm
    Dim connectionString As String = "server=localhost;userid=root;password=Lancelot@28m;database=class1"
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Fill role combo box
        cmbRole.Items.Clear()
        cmbRole.Items.Add("Admin")
        cmbRole.Items.Add("Staff")
        cmbRole.SelectedIndex = 0
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If String.IsNullOrWhiteSpace(txtUname.Text) Then
            MessageBox.Show("Please enter username", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtUname.Focus()
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(txtpassword.Text) Then
            MessageBox.Show("Please enter password", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtpassword.Focus()
            Exit Sub
        End If

        If cmbRole.SelectedIndex = -1 Then
            MessageBox.Show("Please select a role", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Step 2: Check credentials in DB
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Dim query As String = "SELECT COUNT(*) FROM users WHERE uname=@username AND password=@password AND role=@role"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", txtUname.Text.Trim())
                    cmd.Parameters.AddWithValue("@password", txtpassword.Text.Trim())
                    cmd.Parameters.AddWithValue("@role", cmbRole.SelectedItem.ToString())

                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                    If count > 0 Then
                        ' Step 3: Redirect based on role
                        If cmbRole.SelectedItem.ToString() = "Admin" Then
                            FormAdmin.Show()
                            Me.Hide()
                        ElseIf cmbRole.SelectedItem.ToString() = "Staff" Then
                            Form1.Show()
                            Me.Hide()
                        End If
                    Else
                        MessageBox.Show("Invalid username, password, or role", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



End Class