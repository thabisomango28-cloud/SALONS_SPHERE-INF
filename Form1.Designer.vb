<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        sideMenu = New Panel()
        btnLogout = New FontAwesome.Sharp.IconButton()
        btnStaff = New FontAwesome.Sharp.IconButton()
        btnService = New FontAwesome.Sharp.IconButton()
        btnClients = New FontAwesome.Sharp.IconButton()
        btnAppointmets = New FontAwesome.Sharp.IconButton()
        btnDashboard = New FontAwesome.Sharp.IconButton()
        logoSide = New Panel()
        PictureBox1 = New PictureBox()
        PanelnavBar = New Panel()
        LblFormTitle = New Label()
        IconCurrentForm = New FontAwesome.Sharp.IconPictureBox()
        PanelDesktop = New Panel()
        PictureBox2 = New PictureBox()
        sideMenu.SuspendLayout()
        logoSide.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        PanelnavBar.SuspendLayout()
        CType(IconCurrentForm, ComponentModel.ISupportInitialize).BeginInit()
        PanelDesktop.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' sideMenu
        ' 
        sideMenu.BackColor = Color.FromArgb(CByte(31), CByte(31), CByte(68))
        sideMenu.Controls.Add(btnLogout)
        sideMenu.Controls.Add(btnStaff)
        sideMenu.Controls.Add(btnService)
        sideMenu.Controls.Add(btnClients)
        sideMenu.Controls.Add(btnAppointmets)
        sideMenu.Controls.Add(btnDashboard)
        sideMenu.Controls.Add(logoSide)
        sideMenu.Dock = DockStyle.Left
        sideMenu.Location = New Point(0, 0)
        sideMenu.Name = "sideMenu"
        sideMenu.Size = New Size(200, 504)
        sideMenu.TabIndex = 0
        ' 
        ' btnLogout
        ' 
        btnLogout.Dock = DockStyle.Bottom
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.ForeColor = Color.Gainsboro
        btnLogout.IconChar = FontAwesome.Sharp.IconChar.SignOut
        btnLogout.IconColor = Color.White
        btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnLogout.IconSize = 32
        btnLogout.ImageAlign = ContentAlignment.MiddleLeft
        btnLogout.Location = New Point(0, 455)
        btnLogout.Name = "btnLogout"
        btnLogout.Padding = New Padding(20, 0, 20, 0)
        btnLogout.Size = New Size(200, 49)
        btnLogout.TabIndex = 6
        btnLogout.Text = "LogOut"
        btnLogout.TextAlign = ContentAlignment.MiddleLeft
        btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' btnStaff
        ' 
        btnStaff.Dock = DockStyle.Top
        btnStaff.FlatAppearance.BorderSize = 0
        btnStaff.FlatStyle = FlatStyle.Flat
        btnStaff.ForeColor = Color.Gainsboro
        btnStaff.IconChar = FontAwesome.Sharp.IconChar.Users
        btnStaff.IconColor = Color.White
        btnStaff.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnStaff.IconSize = 32
        btnStaff.ImageAlign = ContentAlignment.MiddleLeft
        btnStaff.Location = New Point(0, 320)
        btnStaff.Name = "btnStaff"
        btnStaff.Padding = New Padding(20, 0, 20, 0)
        btnStaff.Size = New Size(200, 49)
        btnStaff.TabIndex = 5
        btnStaff.Text = "Staff"
        btnStaff.TextAlign = ContentAlignment.MiddleLeft
        btnStaff.TextImageRelation = TextImageRelation.ImageBeforeText
        btnStaff.UseVisualStyleBackColor = True
        ' 
        ' btnService
        ' 
        btnService.Dock = DockStyle.Top
        btnService.FlatAppearance.BorderSize = 0
        btnService.FlatStyle = FlatStyle.Flat
        btnService.ForeColor = Color.Gainsboro
        btnService.IconChar = FontAwesome.Sharp.IconChar.Tools
        btnService.IconColor = Color.White
        btnService.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnService.IconSize = 32
        btnService.ImageAlign = ContentAlignment.MiddleLeft
        btnService.Location = New Point(0, 271)
        btnService.Name = "btnService"
        btnService.Padding = New Padding(20, 0, 20, 0)
        btnService.Size = New Size(200, 49)
        btnService.TabIndex = 4
        btnService.Text = "Service"
        btnService.TextAlign = ContentAlignment.MiddleLeft
        btnService.TextImageRelation = TextImageRelation.ImageBeforeText
        btnService.UseVisualStyleBackColor = True
        ' 
        ' btnClients
        ' 
        btnClients.Dock = DockStyle.Top
        btnClients.FlatAppearance.BorderSize = 0
        btnClients.FlatStyle = FlatStyle.Flat
        btnClients.ForeColor = Color.Gainsboro
        btnClients.IconChar = FontAwesome.Sharp.IconChar.Male
        btnClients.IconColor = Color.White
        btnClients.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnClients.IconSize = 32
        btnClients.ImageAlign = ContentAlignment.MiddleLeft
        btnClients.Location = New Point(0, 222)
        btnClients.Name = "btnClients"
        btnClients.Padding = New Padding(20, 0, 20, 0)
        btnClients.Size = New Size(200, 49)
        btnClients.TabIndex = 3
        btnClients.Text = "Clients"
        btnClients.TextAlign = ContentAlignment.MiddleLeft
        btnClients.TextImageRelation = TextImageRelation.ImageBeforeText
        btnClients.UseVisualStyleBackColor = True
        ' 
        ' btnAppointmets
        ' 
        btnAppointmets.Dock = DockStyle.Top
        btnAppointmets.FlatAppearance.BorderSize = 0
        btnAppointmets.FlatStyle = FlatStyle.Flat
        btnAppointmets.ForeColor = Color.Gainsboro
        btnAppointmets.IconChar = FontAwesome.Sharp.IconChar.CalendarDay
        btnAppointmets.IconColor = Color.White
        btnAppointmets.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnAppointmets.IconSize = 32
        btnAppointmets.ImageAlign = ContentAlignment.MiddleLeft
        btnAppointmets.Location = New Point(0, 173)
        btnAppointmets.Name = "btnAppointmets"
        btnAppointmets.Padding = New Padding(20, 0, 20, 0)
        btnAppointmets.Size = New Size(200, 49)
        btnAppointmets.TabIndex = 2
        btnAppointmets.Text = "Appointments"
        btnAppointmets.TextAlign = ContentAlignment.MiddleLeft
        btnAppointmets.TextImageRelation = TextImageRelation.ImageBeforeText
        btnAppointmets.UseVisualStyleBackColor = True
        ' 
        ' btnDashboard
        ' 
        btnDashboard.Dock = DockStyle.Top
        btnDashboard.FlatAppearance.BorderSize = 0
        btnDashboard.FlatStyle = FlatStyle.Flat
        btnDashboard.ForeColor = Color.WhiteSmoke
        btnDashboard.IconChar = FontAwesome.Sharp.IconChar.ChartLine
        btnDashboard.IconColor = Color.White
        btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnDashboard.IconSize = 32
        btnDashboard.ImageAlign = ContentAlignment.MiddleLeft
        btnDashboard.Location = New Point(0, 124)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Padding = New Padding(20, 0, 20, 0)
        btnDashboard.Size = New Size(200, 49)
        btnDashboard.TabIndex = 1
        btnDashboard.Text = "Dashboard"
        btnDashboard.TextAlign = ContentAlignment.MiddleLeft
        btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText
        btnDashboard.UseVisualStyleBackColor = True
        ' 
        ' logoSide
        ' 
        logoSide.Controls.Add(PictureBox1)
        logoSide.Dock = DockStyle.Top
        logoSide.Location = New Point(0, 0)
        logoSide.Name = "logoSide"
        logoSide.Size = New Size(200, 124)
        logoSide.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(200, 124)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' PanelnavBar
        ' 
        PanelnavBar.BackColor = Color.FromArgb(CByte(31), CByte(31), CByte(68))
        PanelnavBar.Controls.Add(LblFormTitle)
        PanelnavBar.Controls.Add(IconCurrentForm)
        PanelnavBar.Dock = DockStyle.Top
        PanelnavBar.Location = New Point(200, 0)
        PanelnavBar.Name = "PanelnavBar"
        PanelnavBar.Size = New Size(673, 59)
        PanelnavBar.TabIndex = 1
        ' 
        ' LblFormTitle
        ' 
        LblFormTitle.AutoSize = True
        LblFormTitle.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold)
        LblFormTitle.ForeColor = Color.Gainsboro
        LblFormTitle.Location = New Point(50, 28)
        LblFormTitle.Name = "LblFormTitle"
        LblFormTitle.Size = New Size(44, 16)
        LblFormTitle.TabIndex = 1
        LblFormTitle.Text = "Home"
        ' 
        ' IconCurrentForm
        ' 
        IconCurrentForm.BackColor = Color.FromArgb(CByte(31), CByte(31), CByte(68))
        IconCurrentForm.ForeColor = Color.MediumPurple
        IconCurrentForm.IconChar = FontAwesome.Sharp.IconChar.HomeLg
        IconCurrentForm.IconColor = Color.MediumPurple
        IconCurrentForm.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconCurrentForm.Location = New Point(6, 24)
        IconCurrentForm.Name = "IconCurrentForm"
        IconCurrentForm.Size = New Size(38, 32)
        IconCurrentForm.TabIndex = 0
        IconCurrentForm.TabStop = False
        ' 
        ' PanelDesktop
        ' 
        PanelDesktop.BackColor = Color.FromArgb(CByte(32), CByte(33), CByte(74))
        PanelDesktop.Controls.Add(PictureBox2)
        PanelDesktop.Dock = DockStyle.Fill
        PanelDesktop.Location = New Point(200, 59)
        PanelDesktop.Name = "PanelDesktop"
        PanelDesktop.Size = New Size(673, 445)
        PanelDesktop.TabIndex = 2
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Dock = DockStyle.Fill
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(0, 0)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(673, 445)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 0
        PictureBox2.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(873, 504)
        Controls.Add(PanelDesktop)
        Controls.Add(PanelnavBar)
        Controls.Add(sideMenu)
        ForeColor = Color.Transparent
        Name = "Form1"
        Text = "1"
        sideMenu.ResumeLayout(False)
        logoSide.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        PanelnavBar.ResumeLayout(False)
        PanelnavBar.PerformLayout()
        CType(IconCurrentForm, ComponentModel.ISupportInitialize).EndInit()
        PanelDesktop.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents sideMenu As Panel
    Friend WithEvents logoSide As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnLogout As FontAwesome.Sharp.IconButton
    Friend WithEvents btnStaff As FontAwesome.Sharp.IconButton
    Friend WithEvents btnService As FontAwesome.Sharp.IconButton
    Friend WithEvents btnClients As FontAwesome.Sharp.IconButton
    Friend WithEvents btnAppointmets As FontAwesome.Sharp.IconButton
    Friend WithEvents btnDashboard As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelnavBar As Panel
    Friend WithEvents LblFormTitle As Label
    Friend WithEvents IconCurrentForm As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents PanelDesktop As Panel
    Friend WithEvents PictureBox2 As PictureBox
End Class
