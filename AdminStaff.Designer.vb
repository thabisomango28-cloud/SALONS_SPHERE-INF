<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminStaff
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminStaff))
        Panel2 = New Panel()
        DataGridViewstuff = New DataGridView()
        Label1 = New Label()
        PictureBoxstuff = New PictureBox()
        Label3 = New Label()
        Label5 = New Label()
        txtFname = New TextBox()
        txtLastname = New TextBox()
        txtPosition = New TextBox()
        btnAdd = New Button()
        PicEmployee = New PictureBox()
        Panellowerstuff = New Panel()
        Button1 = New Button()
        Button2 = New Button()
        Panel2.SuspendLayout()
        CType(DataGridViewstuff, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBoxstuff, ComponentModel.ISupportInitialize).BeginInit()
        CType(PicEmployee, ComponentModel.ISupportInitialize).BeginInit()
        Panellowerstuff.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(31), CByte(31), CByte(68))
        Panel2.Controls.Add(DataGridViewstuff)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(657, 248)
        Panel2.TabIndex = 2
        ' 
        ' DataGridViewstuff
        ' 
        DataGridViewstuff.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridViewstuff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewstuff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewstuff.Location = New Point(0, 0)
        DataGridViewstuff.Name = "DataGridViewstuff"
        DataGridViewstuff.Size = New Size(654, 232)
        DataGridViewstuff.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9.75F)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(3, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(78, 17)
        Label1.TabIndex = 2
        Label1.Text = "First Name :"
        ' 
        ' PictureBoxstuff
        ' 
        PictureBoxstuff.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PictureBoxstuff.BackColor = SystemColors.ControlDark
        PictureBoxstuff.Location = New Point(960, 6)
        PictureBoxstuff.Name = "PictureBoxstuff"
        PictureBoxstuff.Size = New Size(123, 99)
        PictureBoxstuff.TabIndex = 8
        PictureBoxstuff.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9.75F)
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(19, 85)
        Label3.Name = "Label3"
        Label3.Size = New Size(61, 17)
        Label3.TabIndex = 4
        Label3.Text = "Position :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9.75F)
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(3, 51)
        Label5.Name = "Label5"
        Label5.Size = New Size(77, 17)
        Label5.TabIndex = 9
        Label5.Text = "Last Name :"
        ' 
        ' txtFname
        ' 
        txtFname.Location = New Point(80, 11)
        txtFname.Name = "txtFname"
        txtFname.Size = New Size(145, 23)
        txtFname.TabIndex = 14
        ' 
        ' txtLastname
        ' 
        txtLastname.Location = New Point(80, 50)
        txtLastname.Name = "txtLastname"
        txtLastname.Size = New Size(145, 23)
        txtLastname.TabIndex = 15
        ' 
        ' txtPosition
        ' 
        txtPosition.Location = New Point(80, 84)
        txtPosition.Name = "txtPosition"
        txtPosition.Size = New Size(145, 23)
        txtPosition.TabIndex = 16
        ' 
        ' btnAdd
        ' 
        btnAdd.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnAdd.BackColor = Color.Lime
        btnAdd.FlatStyle = FlatStyle.Flat
        btnAdd.Location = New Point(507, 122)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(106, 24)
        btnAdd.TabIndex = 17
        btnAdd.Text = "ADD"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' PicEmployee
        ' 
        PicEmployee.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PicEmployee.Image = CType(resources.GetObject("PicEmployee.Image"), Image)
        PicEmployee.Location = New Point(498, 6)
        PicEmployee.Name = "PicEmployee"
        PicEmployee.Size = New Size(106, 67)
        PicEmployee.SizeMode = PictureBoxSizeMode.StretchImage
        PicEmployee.TabIndex = 19
        PicEmployee.TabStop = False
        ' 
        ' Panellowerstuff
        ' 
        Panellowerstuff.AutoSize = True
        Panellowerstuff.Controls.Add(Button1)
        Panellowerstuff.Controls.Add(Button2)
        Panellowerstuff.Controls.Add(PicEmployee)
        Panellowerstuff.Controls.Add(btnAdd)
        Panellowerstuff.Controls.Add(txtPosition)
        Panellowerstuff.Controls.Add(txtLastname)
        Panellowerstuff.Controls.Add(txtFname)
        Panellowerstuff.Controls.Add(Label5)
        Panellowerstuff.Controls.Add(Label3)
        Panellowerstuff.Controls.Add(PictureBoxstuff)
        Panellowerstuff.Controls.Add(Label1)
        Panellowerstuff.Dock = DockStyle.Fill
        Panellowerstuff.Location = New Point(0, 248)
        Panellowerstuff.Name = "Panellowerstuff"
        Panellowerstuff.Size = New Size(657, 158)
        Panellowerstuff.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Button1.BackColor = Color.Tomato
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Location = New Point(19, 122)
        Button1.Name = "Button1"
        Button1.Size = New Size(106, 24)
        Button1.TabIndex = 21
        Button1.Text = "Delete"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button2.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Location = New Point(498, 82)
        Button2.Name = "Button2"
        Button2.Size = New Size(106, 24)
        Button2.TabIndex = 20
        Button2.Text = "UPLOAD"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' AdminStaff
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(657, 406)
        Controls.Add(Panellowerstuff)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.None
        Name = "AdminStaff"
        StartPosition = FormStartPosition.WindowsDefaultBounds
        Text = "AdminStaff"
        Panel2.ResumeLayout(False)
        CType(DataGridViewstuff, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBoxstuff, ComponentModel.ISupportInitialize).EndInit()
        CType(PicEmployee, ComponentModel.ISupportInitialize).EndInit()
        Panellowerstuff.ResumeLayout(False)
        Panellowerstuff.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataGridViewstuff As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBoxstuff As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtFname As TextBox
    Private WithEvents txtLastname As TextBox
    Private WithEvents txtPosition As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents PicEmployee As PictureBox
    Friend WithEvents Panellowerstuff As Panel
    Friend WithEvents Button2 As Button


End Class
