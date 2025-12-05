<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AppointmentForm
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AppointmentForm))
        Panel1 = New Panel()
        PnlDVAPP = New Panel()
        DataGridAppointView = New DataGridView()
        PanelSideAdd = New Panel()
        cmbEmployee = New ComboBox()
        cboservicetype = New ComboBox()
        lblendtime = New Label()
        Label7 = New Label()
        Label2 = New Label()
        txttime = New TextBox()
        Label6 = New Label()
        DATETIME = New DateTimePicker()
        Label5 = New Label()
        Label4 = New Label()
        txtcustID = New TextBox()
        Label3 = New Label()
        Panel3 = New Panel()
        Label1 = New Label()
        IconButton4 = New FontAwesome.Sharp.IconButton()
        btnBook = New FontAwesome.Sharp.IconButton()
        Panel2 = New Panel()
        Panelsearch = New Panel()
        panelinnerseach = New Panel()
        TextBox1 = New TextBox()
        PictureBox1 = New PictureBox()
        IconButton2 = New FontAwesome.Sharp.IconButton()
        IconButton1 = New FontAwesome.Sharp.IconButton()
        btnadd = New FontAwesome.Sharp.IconButton()
        Panel1.SuspendLayout()
        PnlDVAPP.SuspendLayout()
        CType(DataGridAppointView, ComponentModel.ISupportInitialize).BeginInit()
        PanelSideAdd.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        Panelsearch.SuspendLayout()
        panelinnerseach.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(PnlDVAPP)
        Panel1.Controls.Add(PanelSideAdd)
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(657, 406)
        Panel1.TabIndex = 0
        ' 
        ' PnlDVAPP
        ' 
        PnlDVAPP.Controls.Add(DataGridAppointView)
        PnlDVAPP.Dock = DockStyle.Fill
        PnlDVAPP.Location = New Point(0, 62)
        PnlDVAPP.Name = "PnlDVAPP"
        PnlDVAPP.Size = New Size(441, 344)
        PnlDVAPP.TabIndex = 2
        ' 
        ' DataGridAppointView
        ' 
        DataGridAppointView.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridAppointView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridAppointView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridAppointView.GridColor = Color.Black
        DataGridAppointView.Location = New Point(0, 0)
        DataGridAppointView.Name = "DataGridAppointView"
        DataGridViewCellStyle1.ForeColor = Color.Black
        DataGridAppointView.RowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridAppointView.Size = New Size(441, 344)
        DataGridAppointView.TabIndex = 0
        ' 
        ' PanelSideAdd
        ' 
        PanelSideAdd.BackColor = Color.FromArgb(CByte(31), CByte(31), CByte(68))
        PanelSideAdd.Controls.Add(cmbEmployee)
        PanelSideAdd.Controls.Add(cboservicetype)
        PanelSideAdd.Controls.Add(lblendtime)
        PanelSideAdd.Controls.Add(Label7)
        PanelSideAdd.Controls.Add(Label2)
        PanelSideAdd.Controls.Add(txttime)
        PanelSideAdd.Controls.Add(Label6)
        PanelSideAdd.Controls.Add(DATETIME)
        PanelSideAdd.Controls.Add(Label5)
        PanelSideAdd.Controls.Add(Label4)
        PanelSideAdd.Controls.Add(txtcustID)
        PanelSideAdd.Controls.Add(Label3)
        PanelSideAdd.Controls.Add(Panel3)
        PanelSideAdd.Dock = DockStyle.Right
        PanelSideAdd.Location = New Point(441, 62)
        PanelSideAdd.Name = "PanelSideAdd"
        PanelSideAdd.Size = New Size(216, 344)
        PanelSideAdd.TabIndex = 1
        ' 
        ' cmbEmployee
        ' 
        cmbEmployee.FormattingEnabled = True
        cmbEmployee.Location = New Point(10, 276)
        cmbEmployee.Name = "cmbEmployee"
        cmbEmployee.Size = New Size(200, 23)
        cmbEmployee.TabIndex = 13
        ' 
        ' cboservicetype
        ' 
        cboservicetype.FormattingEnabled = True
        cboservicetype.Location = New Point(10, 115)
        cboservicetype.Name = "cboservicetype"
        cboservicetype.Size = New Size(121, 23)
        cboservicetype.TabIndex = 10
        ' 
        ' lblendtime
        ' 
        lblendtime.AutoSize = True
        lblendtime.ForeColor = Color.Gainsboro
        lblendtime.Location = New Point(72, 229)
        lblendtime.Name = "lblendtime"
        lblendtime.Size = New Size(30, 15)
        lblendtime.TabIndex = 12
        lblendtime.Text = "--:--"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.ForeColor = Color.Gainsboro
        Label7.Location = New Point(10, 97)
        Label7.Name = "Label7"
        Label7.Size = New Size(76, 15)
        Label7.TabIndex = 9
        Label7.Text = "Service type :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.Gainsboro
        Label2.Location = New Point(10, 229)
        Label2.Name = "Label2"
        Label2.Size = New Size(62, 15)
        Label2.TabIndex = 11
        Label2.Text = "End Time :"
        ' 
        ' txttime
        ' 
        txttime.Location = New Point(10, 203)
        txttime.Name = "txttime"
        txttime.Size = New Size(163, 23)
        txttime.TabIndex = 8
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.ForeColor = Color.Gainsboro
        Label6.Location = New Point(10, 185)
        Label6.Name = "Label6"
        Label6.Size = New Size(60, 15)
        Label6.TabIndex = 7
        Label6.Text = "Start Time"
        ' 
        ' DATETIME
        ' 
        DATETIME.Location = New Point(10, 159)
        DATETIME.Name = "DATETIME"
        DATETIME.Size = New Size(200, 23)
        DATETIME.TabIndex = 6
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = Color.Gainsboro
        Label5.Location = New Point(10, 141)
        Label5.Name = "Label5"
        Label5.Size = New Size(31, 15)
        Label5.TabIndex = 5
        Label5.Text = "Date"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.Gainsboro
        Label4.Location = New Point(10, 258)
        Label4.Name = "Label4"
        Label4.Size = New Size(73, 15)
        Label4.TabIndex = 3
        Label4.Text = "Employee ID"
        ' 
        ' txtcustID
        ' 
        txtcustID.Location = New Point(10, 71)
        txtcustID.Name = "txtcustID"
        txtcustID.Size = New Size(163, 23)
        txtcustID.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.Gainsboro
        Label3.Location = New Point(10, 53)
        Label3.Name = "Label3"
        Label3.Size = New Size(73, 15)
        Label3.TabIndex = 1
        Label3.Text = "Customer ID"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(31), CByte(31), CByte(68))
        Panel3.Controls.Add(Label1)
        Panel3.Controls.Add(IconButton4)
        Panel3.Controls.Add(btnBook)
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(0, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(216, 40)
        Panel3.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.Gainsboro
        Label1.Location = New Point(110, 13)
        Label1.Name = "Label1"
        Label1.Size = New Size(103, 15)
        Label1.TabIndex = 10
        Label1.Text = "Add Appointment"
        ' 
        ' IconButton4
        ' 
        IconButton4.BackColor = Color.FromArgb(CByte(31), CByte(31), CByte(68))
        IconButton4.Dock = DockStyle.Left
        IconButton4.FlatAppearance.BorderSize = 0
        IconButton4.FlatStyle = FlatStyle.Flat
        IconButton4.ForeColor = Color.Gainsboro
        IconButton4.IconChar = FontAwesome.Sharp.IconChar.FolderMinus
        IconButton4.IconColor = Color.White
        IconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton4.IconSize = 22
        IconButton4.ImageAlign = ContentAlignment.MiddleLeft
        IconButton4.Location = New Point(51, 0)
        IconButton4.Name = "IconButton4"
        IconButton4.Padding = New Padding(20, 0, 20, 0)
        IconButton4.Size = New Size(51, 40)
        IconButton4.TabIndex = 9
        IconButton4.TextAlign = ContentAlignment.MiddleLeft
        IconButton4.TextImageRelation = TextImageRelation.ImageBeforeText
        IconButton4.UseVisualStyleBackColor = False
        ' 
        ' btnBook
        ' 
        btnBook.BackColor = Color.FromArgb(CByte(31), CByte(31), CByte(68))
        btnBook.Dock = DockStyle.Left
        btnBook.FlatAppearance.BorderSize = 0
        btnBook.FlatStyle = FlatStyle.Flat
        btnBook.ForeColor = Color.Gainsboro
        btnBook.IconChar = FontAwesome.Sharp.IconChar.FolderPlus
        btnBook.IconColor = Color.White
        btnBook.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnBook.IconSize = 22
        btnBook.ImageAlign = ContentAlignment.MiddleLeft
        btnBook.Location = New Point(0, 0)
        btnBook.Name = "btnBook"
        btnBook.Padding = New Padding(20, 0, 20, 0)
        btnBook.Size = New Size(51, 40)
        btnBook.TabIndex = 8
        btnBook.TextAlign = ContentAlignment.MiddleLeft
        btnBook.TextImageRelation = TextImageRelation.ImageBeforeText
        btnBook.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Transparent
        Panel2.Controls.Add(Panelsearch)
        Panel2.Controls.Add(IconButton2)
        Panel2.Controls.Add(IconButton1)
        Panel2.Controls.Add(btnadd)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(657, 62)
        Panel2.TabIndex = 0
        ' 
        ' Panelsearch
        ' 
        Panelsearch.Controls.Add(panelinnerseach)
        Panelsearch.Dock = DockStyle.Right
        Panelsearch.Location = New Point(286, 0)
        Panelsearch.Name = "Panelsearch"
        Panelsearch.Size = New Size(371, 62)
        Panelsearch.TabIndex = 12
        ' 
        ' panelinnerseach
        ' 
        panelinnerseach.BackColor = Color.FromArgb(CByte(31), CByte(31), CByte(68))
        panelinnerseach.Controls.Add(TextBox1)
        panelinnerseach.Controls.Add(PictureBox1)
        panelinnerseach.Location = New Point(155, 13)
        panelinnerseach.Name = "panelinnerseach"
        panelinnerseach.Size = New Size(203, 23)
        panelinnerseach.TabIndex = 0
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.FromArgb(CByte(31), CByte(31), CByte(68))
        TextBox1.Dock = DockStyle.Fill
        TextBox1.ForeColor = Color.Gainsboro
        TextBox1.Location = New Point(0, 0)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(173, 23)
        TextBox1.TabIndex = 1
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Right
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(173, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(30, 23)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' IconButton2
        ' 
        IconButton2.BackColor = Color.FromArgb(CByte(31), CByte(31), CByte(68))
        IconButton2.FlatAppearance.BorderSize = 0
        IconButton2.FlatStyle = FlatStyle.Flat
        IconButton2.ForeColor = Color.Gainsboro
        IconButton2.IconChar = FontAwesome.Sharp.IconChar.Trash
        IconButton2.IconColor = Color.White
        IconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton2.IconSize = 32
        IconButton2.ImageAlign = ContentAlignment.MiddleLeft
        IconButton2.Location = New Point(190, 3)
        IconButton2.Name = "IconButton2"
        IconButton2.Padding = New Padding(20, 0, 20, 0)
        IconButton2.Size = New Size(90, 56)
        IconButton2.TabIndex = 11
        IconButton2.Text = "Delete"
        IconButton2.TextImageRelation = TextImageRelation.ImageAboveText
        IconButton2.UseVisualStyleBackColor = False
        ' 
        ' IconButton1
        ' 
        IconButton1.BackColor = Color.FromArgb(CByte(31), CByte(31), CByte(68))
        IconButton1.FlatAppearance.BorderSize = 0
        IconButton1.FlatStyle = FlatStyle.Flat
        IconButton1.ForeColor = Color.Gainsboro
        IconButton1.IconChar = FontAwesome.Sharp.IconChar.FileUpload
        IconButton1.IconColor = Color.White
        IconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton1.IconSize = 32
        IconButton1.ImageAlign = ContentAlignment.MiddleLeft
        IconButton1.Location = New Point(94, 3)
        IconButton1.Name = "IconButton1"
        IconButton1.Padding = New Padding(20, 0, 20, 0)
        IconButton1.Size = New Size(90, 56)
        IconButton1.TabIndex = 8
        IconButton1.Text = "Assign "
        IconButton1.TextAlign = ContentAlignment.MiddleLeft
        IconButton1.TextImageRelation = TextImageRelation.ImageAboveText
        IconButton1.UseVisualStyleBackColor = False
        ' 
        ' btnadd
        ' 
        btnadd.BackColor = Color.FromArgb(CByte(31), CByte(31), CByte(68))
        btnadd.FlatAppearance.BorderSize = 0
        btnadd.FlatStyle = FlatStyle.Flat
        btnadd.ForeColor = Color.Gainsboro
        btnadd.IconChar = FontAwesome.Sharp.IconChar.Add
        btnadd.IconColor = Color.White
        btnadd.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnadd.IconSize = 32
        btnadd.ImageAlign = ContentAlignment.MiddleLeft
        btnadd.Location = New Point(3, 3)
        btnadd.Name = "btnadd"
        btnadd.Padding = New Padding(20, 0, 20, 0)
        btnadd.Size = New Size(85, 56)
        btnadd.TabIndex = 7
        btnadd.Text = "ADD"
        btnadd.TextAlign = ContentAlignment.MiddleLeft
        btnadd.TextImageRelation = TextImageRelation.ImageAboveText
        btnadd.UseVisualStyleBackColor = False
        ' 
        ' AppointmentForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(657, 406)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "AppointmentForm"
        Text = "AppointmentForm"
        Panel1.ResumeLayout(False)
        PnlDVAPP.ResumeLayout(False)
        CType(DataGridAppointView, ComponentModel.ISupportInitialize).EndInit()
        PanelSideAdd.ResumeLayout(False)
        PanelSideAdd.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel2.ResumeLayout(False)
        Panelsearch.ResumeLayout(False)
        panelinnerseach.ResumeLayout(False)
        panelinnerseach.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnadd As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents Panelsearch As Panel
    Friend WithEvents panelinnerseach As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PanelSideAdd As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnBook As FontAwesome.Sharp.IconButton
    Friend WithEvents Label1 As Label
    Friend WithEvents IconButton4 As FontAwesome.Sharp.IconButton
    Friend WithEvents PnlDVAPP As Panel
    Friend WithEvents DataGridAppointView As DataGridView
    Friend WithEvents txtcustID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txttime As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents DATETIME As DateTimePicker
    Friend WithEvents cboservicetype As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lblendtime As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbEmployee As ComboBox
End Class
