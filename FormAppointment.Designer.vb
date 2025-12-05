<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAppointment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAppointment))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        PanelSideAdd = New Panel()
        Panel2 = New Panel()
        Panelsearch = New Panel()
        panelinnerseach = New Panel()
        txtsearch = New TextBox()
        PictureBox1 = New PictureBox()
        IconButtondelete = New FontAwesome.Sharp.IconButton()
        IconButton1 = New FontAwesome.Sharp.IconButton()
        DataGridAppointView = New DataGridView()
        Panel1 = New Panel()
        Panel2.SuspendLayout()
        Panelsearch.SuspendLayout()
        panelinnerseach.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridAppointView, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelSideAdd
        ' 
        PanelSideAdd.BackColor = Color.FromArgb(CByte(31), CByte(31), CByte(68))
        PanelSideAdd.Dock = DockStyle.Right
        PanelSideAdd.Location = New Point(499, 66)
        PanelSideAdd.Name = "PanelSideAdd"
        PanelSideAdd.Size = New Size(142, 301)
        PanelSideAdd.TabIndex = 4
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Transparent
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Controls.Add(Panelsearch)
        Panel2.Controls.Add(IconButtondelete)
        Panel2.Controls.Add(IconButton1)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(641, 66)
        Panel2.TabIndex = 2
        ' 
        ' Panelsearch
        ' 
        Panelsearch.BorderStyle = BorderStyle.Fixed3D
        Panelsearch.Controls.Add(panelinnerseach)
        Panelsearch.Dock = DockStyle.Right
        Panelsearch.Location = New Point(266, 0)
        Panelsearch.Name = "Panelsearch"
        Panelsearch.Size = New Size(371, 62)
        Panelsearch.TabIndex = 12
        ' 
        ' panelinnerseach
        ' 
        panelinnerseach.BackColor = Color.FromArgb(CByte(31), CByte(31), CByte(68))
        panelinnerseach.Controls.Add(txtsearch)
        panelinnerseach.Controls.Add(PictureBox1)
        panelinnerseach.Location = New Point(155, 13)
        panelinnerseach.Name = "panelinnerseach"
        panelinnerseach.Size = New Size(203, 23)
        panelinnerseach.TabIndex = 0
        ' 
        ' txtsearch
        ' 
        txtsearch.BackColor = Color.FromArgb(CByte(31), CByte(31), CByte(68))
        txtsearch.Dock = DockStyle.Fill
        txtsearch.ForeColor = Color.Gainsboro
        txtsearch.Location = New Point(0, 0)
        txtsearch.Name = "txtsearch"
        txtsearch.Size = New Size(173, 23)
        txtsearch.TabIndex = 1
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
        ' IconButtondelete
        ' 
        IconButtondelete.BackColor = Color.FromArgb(CByte(31), CByte(31), CByte(68))
        IconButtondelete.FlatAppearance.BorderSize = 0
        IconButtondelete.FlatStyle = FlatStyle.Flat
        IconButtondelete.ForeColor = Color.Gainsboro
        IconButtondelete.IconChar = FontAwesome.Sharp.IconChar.Trash
        IconButtondelete.IconColor = Color.White
        IconButtondelete.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButtondelete.IconSize = 32
        IconButtondelete.ImageAlign = ContentAlignment.MiddleLeft
        IconButtondelete.Location = New Point(99, 3)
        IconButtondelete.Name = "IconButtondelete"
        IconButtondelete.Padding = New Padding(20, 0, 20, 0)
        IconButtondelete.Size = New Size(90, 56)
        IconButtondelete.TabIndex = 11
        IconButtondelete.Text = "Delete"
        IconButtondelete.TextImageRelation = TextImageRelation.ImageAboveText
        IconButtondelete.UseVisualStyleBackColor = False
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
        IconButton1.Location = New Point(3, 3)
        IconButton1.Name = "IconButton1"
        IconButton1.Padding = New Padding(20, 0, 20, 0)
        IconButton1.Size = New Size(90, 56)
        IconButton1.TabIndex = 8
        IconButton1.Text = "Assign "
        IconButton1.TextAlign = ContentAlignment.MiddleLeft
        IconButton1.TextImageRelation = TextImageRelation.ImageAboveText
        IconButton1.UseVisualStyleBackColor = False
        ' 
        ' DataGridAppointView
        ' 
        DataGridAppointView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridAppointView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridAppointView.Dock = DockStyle.Fill
        DataGridAppointView.GridColor = Color.Black
        DataGridAppointView.Location = New Point(0, 0)
        DataGridAppointView.Name = "DataGridAppointView"
        DataGridViewCellStyle1.ForeColor = Color.Black
        DataGridAppointView.RowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridAppointView.Size = New Size(499, 301)
        DataGridAppointView.TabIndex = 3
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(DataGridAppointView)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 66)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(499, 301)
        Panel1.TabIndex = 5
        ' 
        ' FormAppointment
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(641, 367)
        Controls.Add(Panel1)
        Controls.Add(PanelSideAdd)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormAppointment"
        Text = "Appointments"
        Panel2.ResumeLayout(False)
        Panelsearch.ResumeLayout(False)
        panelinnerseach.ResumeLayout(False)
        panelinnerseach.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridAppointView, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelSideAdd As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panelsearch As Panel
    Friend WithEvents panelinnerseach As Panel
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents IconButtondelete As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents DataGridAppointView As DataGridView
    Friend WithEvents Panel1 As Panel
End Class
