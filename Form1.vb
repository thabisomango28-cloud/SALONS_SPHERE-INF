Imports FontAwesome.Sharp

Public Class Form1
    'fields
    Public currentbtn As IconButton
    Public leftBoarderBtn As Panel
    Public currentChildForam As Form


    'constructor
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        leftBoarderBtn = New Panel()
        leftBoarderBtn.Size = New Size(7, 49)
        sideMenu.Controls.Add(leftBoarderBtn)




    End Sub

    ' Public method to open child form with customer data
    Public Sub OpenAppointmentFormWithCustomer(customerId As String, firstName As String, lastName As String)
        ' Activate the appointments button
        activateButton(btnAppointmets, RGBcolors.color2)

        ' Create and open appointment form
        Dim appointmentForm As New AppointmentForm()
        OpenChildForm(appointmentForm)

        ' Pass customer data to the appointment form
        appointmentForm.SetCustomerData(customerId)
    End Sub

    Public Sub activateButton(senderbtn As Object, customcolour As Color)
        If senderbtn IsNot Nothing Then
            DisableButton()
            'button
            currentbtn = CType(senderbtn, IconButton)
            currentbtn.BackColor = Color.FromArgb(37, 36, 81)
            currentbtn.ForeColor = customcolour
            currentbtn.IconColor = customcolour
            currentbtn.TextAlign = ContentAlignment.MiddleCenter
            currentbtn.ImageAlign = ContentAlignment.MiddleRight
            currentbtn.TextImageRelation = TextImageRelation.TextBeforeImage
            'left boarder

            leftBoarderBtn.BackColor = customcolour
            leftBoarderBtn.Location = New Point(0, currentbtn.Location.Y)
            leftBoarderBtn.Visible = True
            leftBoarderBtn.BringToFront()
            'current form icon
            IconCurrentForm.IconChar = currentbtn.IconChar
            IconCurrentForm.IconColor = customcolour
        End If
    End Sub

    Public Sub DisableButton()
        If currentbtn IsNot Nothing Then
            currentbtn.BackColor = Color.FromArgb(31, 31, 68)
            currentbtn.ForeColor = Color.Gainsboro
            currentbtn.IconColor = Color.Gainsboro
            currentbtn.TextAlign = ContentAlignment.MiddleLeft
            currentbtn.ImageAlign = ContentAlignment.MiddleLeft
            currentbtn.TextImageRelation = TextImageRelation.ImageBeforeText

        End If
    End Sub

    Public Sub OpenChildForm(childForm As Form)
        'open only foarm
        If currentChildForam IsNot Nothing Then
            currentChildForam.Close()
        End If
        currentChildForam = childForm
        'end
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelDesktop.Controls.Add(childForm)
        PanelDesktop.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
        LblFormTitle.Text = childForm.Text


    End Sub


    'events
    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        activateButton(sender, RGBcolors.color1)
        OpenChildForm(New FormDashboard)
    End Sub

    Private Sub btnAppointmets_Click(sender As Object, e As EventArgs) Handles btnAppointmets.Click
        activateButton(sender, RGBcolors.color2)
        OpenChildForm(New AppointmentForm)
    End Sub

    ' Update the OpenChildForm calls for FormClients to pass Me as the parentForm argument.
    Private Sub btnClients_Click(sender As Object, e As EventArgs) Handles btnClients.Click
        activateButton(sender, RGBcolors.color3)
        OpenChildForm(New FormClients(Me))
    End Sub        ' In FormClients.vb
    Public Sub New(parentForm As Form1)
        InitializeComponent()
        ' Store parentForm if needed
    End Sub


    Private Sub btnService_Click(sender As Object, e As EventArgs) Handles btnService.Click
        activateButton(sender, RGBcolors.color4)
        OpenChildForm(New FormServices)
    End Sub

    Private Sub btnStaff_Click(sender As Object, e As EventArgs) Handles btnStaff.Click
        activateButton(sender, RGBcolors.color5)
        OpenChildForm(New FormStaff)
    End Sub

    Private Sub btnInvemtory_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        activateButton(sender, RGBcolors.color6)
        LoginForm.Show()
        Me.Hide()
    End Sub

    Friend Sub OpenAppointmentFormWithCustomer(custId As Object)
        Throw New NotImplementedException()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
