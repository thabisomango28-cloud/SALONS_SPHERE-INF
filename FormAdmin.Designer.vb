<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAdmin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAdmin))
        sideMenu = New Panel()
        IconButton1 = New FontAwesome.Sharp.IconButton()
        btnInvemtory = New FontAwesome.Sharp.IconButton()
        btnStaff = New FontAwesome.Sharp.IconButton()
        btnService = New FontAwesome.Sharp.IconButton()
        btnAppointmets = New FontAwesome.Sharp.IconButton()
        btnDashboard = New FontAwesome.Sharp.IconButton()
        logoSide = New Panel()
        PictureBox1 = New PictureBox()
        PanelnavBar = New Panel()
        Label1 = New Label()
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
        sideMenu.Controls.Add(IconButton1)
        sideMenu.Controls.Add(btnInvemtory)
        sideMenu.Controls.Add(btnStaff)
        sideMenu.Controls.Add(btnService)
        sideMenu.Controls.Add(btnAppointmets)
        sideMenu.Controls.Add(btnDashboard)
        sideMenu.Controls.Add(logoSide)
        sideMenu.Dock = DockStyle.Left
        sideMenu.Location = New Point(0, 0)
        sideMenu.Name = "sideMenu"
        sideMenu.Size = New Size(200, 504)
        sideMenu.TabIndex = 1
        ' 
        ' IconButton1
        ' 
        IconButton1.Dock = DockStyle.Bottom
        IconButton1.FlatAppearance.BorderSize = 0
        IconButton1.FlatStyle = FlatStyle.Flat
        IconButton1.ForeColor = Color.Gainsboro
        IconButton1.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt
        IconButton1.IconColor = Color.White
        IconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton1.IconSize = 32
        IconButton1.ImageAlign = ContentAlignment.MiddleLeft
        IconButton1.Location = New Point(0, 455)
        IconButton1.Name = "IconButton1"
        IconButton1.Padding = New Padding(20, 0, 20, 0)
        IconButton1.Size = New Size(200, 49)
        IconButton1.TabIndex = 7
        IconButton1.Text = "Log Out"
        IconButton1.TextAlign = ContentAlignment.MiddleLeft
        IconButton1.TextImageRelation = TextImageRelation.ImageBeforeText
        IconButton1.UseVisualStyleBackColor = True
        ' 
        ' btnInvemtory
        ' 
        btnInvemtory.Dock = DockStyle.Top
        btnInvemtory.FlatAppearance.BorderSize = 0
        btnInvemtory.FlatStyle = FlatStyle.Flat
        btnInvemtory.ForeColor = Color.Gainsboro
        btnInvemtory.IconChar = FontAwesome.Sharp.IconChar.Store
        btnInvemtory.IconColor = Color.White
        btnInvemtory.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnInvemtory.IconSize = 32
        btnInvemtory.ImageAlign = ContentAlignment.MiddleLeft
        btnInvemtory.Location = New Point(0, 320)
        btnInvemtory.Name = "btnInvemtory"
        btnInvemtory.Padding = New Padding(20, 0, 20, 0)
        btnInvemtory.Size = New Size(200, 49)
        btnInvemtory.TabIndex = 6
        btnInvemtory.Text = "stock"
        btnInvemtory.TextAlign = ContentAlignment.MiddleLeft
        btnInvemtory.TextImageRelation = TextImageRelation.ImageBeforeText
        btnInvemtory.UseVisualStyleBackColor = True
        ' 
        ' btnStaff
        ' 
        btnStaff.Dock = DockStyle.Top
        btnStaff.FlatAppearance.BorderSize = 0
        btnStaff.FlatStyle = FlatStyle.Flat
        btnStaff.ForeColor = Color.Gainsboro
        btnStaff.IconChar = FontAwesome.Sharp.IconChar.UserPlus
        btnStaff.IconColor = Color.White
        btnStaff.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnStaff.IconSize = 32
        btnStaff.ImageAlign = ContentAlignment.MiddleLeft
        btnStaff.Location = New Point(0, 271)
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
        btnService.IconChar = FontAwesome.Sharp.IconChar.Shopify
        btnService.IconColor = Color.White
        btnService.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnService.IconSize = 32
        btnService.ImageAlign = ContentAlignment.MiddleLeft
        btnService.Location = New Point(0, 222)
        btnService.Name = "btnService"
        btnService.Padding = New Padding(20, 0, 20, 0)
        btnService.Size = New Size(200, 49)
        btnService.TabIndex = 4
        btnService.Text = "Service"
        btnService.TextAlign = ContentAlignment.MiddleLeft
        btnService.TextImageRelation = TextImageRelation.ImageBeforeText
        btnService.UseVisualStyleBackColor = True
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
        PanelnavBar.Controls.Add(Label1)
        PanelnavBar.Controls.Add(LblFormTitle)
        PanelnavBar.Controls.Add(IconCurrentForm)
        PanelnavBar.Dock = DockStyle.Top
        PanelnavBar.Location = New Point(200, 0)
        PanelnavBar.Name = "PanelnavBar"
        PanelnavBar.Size = New Size(673, 59)
        PanelnavBar.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Gainsboro
        Label1.Location = New Point(314, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(71, 23)
        Label1.TabIndex = 2
        Label1.Text = "Admin"
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
        PanelDesktop.TabIndex = 3
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
        ' FormAdmin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(873, 504)
        Controls.Add(PanelDesktop)
        Controls.Add(PanelnavBar)
        Controls.Add(sideMenu)
        Name = "FormAdmin"
        Text = "FormAdmin"
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
    Friend WithEvents btnInvemtory As FontAwesome.Sharp.IconButton
    Friend WithEvents btnStaff As FontAwesome.Sharp.IconButton
    Friend WithEvents btnService As FontAwesome.Sharp.IconButton
    Friend WithEvents btnAppointmets As FontAwesome.Sharp.IconButton
    Friend WithEvents btnDashboard As FontAwesome.Sharp.IconButton
    Friend WithEvents logoSide As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PanelnavBar As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents LblFormTitle As Label
    Friend WithEvents IconCurrentForm As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents PanelDesktop As Panel
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents PictureBox2 As PictureBox
End Class
