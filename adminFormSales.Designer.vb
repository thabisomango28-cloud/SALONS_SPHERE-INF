<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminFormSales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adminFormSales))
        DataGridAppointView = New DataGridView()
        Panel2 = New Panel()
        Panelsearch = New Panel()
        panelinnerseach = New Panel()
        TextBox1 = New TextBox()
        PictureBox1 = New PictureBox()
        IconButton2 = New FontAwesome.Sharp.IconButton()
        IconButton1 = New FontAwesome.Sharp.IconButton()
        btnadd = New FontAwesome.Sharp.IconButton()
        Panel3 = New Panel()
        Label1 = New Label()
        PanelSideAdd = New Panel()
        CType(DataGridAppointView, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panelsearch.SuspendLayout()
        panelinnerseach.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        PanelSideAdd.SuspendLayout()
        SuspendLayout()
        ' 
        ' DataGridAppointView
        ' 
        DataGridAppointView.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridAppointView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridAppointView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridAppointView.GridColor = Color.Black
        DataGridAppointView.Location = New Point(0, 62)
        DataGridAppointView.Name = "DataGridAppointView"
        DataGridViewCellStyle1.ForeColor = Color.Black
        DataGridAppointView.RowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridAppointView.Size = New Size(444, 344)
        DataGridAppointView.TabIndex = 2
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
        Panel2.TabIndex = 3
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
        TextBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TextBox1.BackColor = Color.FromArgb(CByte(31), CByte(31), CByte(68))
        TextBox1.ForeColor = Color.Gainsboro
        TextBox1.Location = New Point(0, 0)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(173, 23)
        TextBox1.TabIndex = 1
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
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
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(31), CByte(31), CByte(68))
        Panel3.Controls.Add(Label1)
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
        Label1.Location = New Point(70, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(103, 15)
        Label1.TabIndex = 10
        Label1.Text = "Add Appointment"
        ' 
        ' PanelSideAdd
        ' 
        PanelSideAdd.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        PanelSideAdd.BackColor = Color.FromArgb(CByte(31), CByte(31), CByte(68))
        PanelSideAdd.Controls.Add(Panel3)
        PanelSideAdd.Location = New Point(441, 62)
        PanelSideAdd.Name = "PanelSideAdd"
        PanelSideAdd.Size = New Size(216, 344)
        PanelSideAdd.TabIndex = 4
        ' 
        ' adminFormSales
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(657, 406)
        Controls.Add(PanelSideAdd)
        Controls.Add(DataGridAppointView)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.None
        Name = "adminFormSales"
        Text = "adminFormSales"
        CType(DataGridAppointView, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panelsearch.ResumeLayout(False)
        panelinnerseach.ResumeLayout(False)
        panelinnerseach.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        PanelSideAdd.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents DataGridAppointView As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panelsearch As Panel
    Friend WithEvents panelinnerseach As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents btnadd As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelSideAdd As Panel
End Class
