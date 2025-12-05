<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormStaff
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
        Panel1 = New Panel()
        Panel2 = New Panel()
        DataGridViewstuff = New DataGridView()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        lblfname = New Label()
        lblRole = New Label()
        lblStatus = New Label()
        PictureBoxstuff = New PictureBox()
        Panellowerstuff = New Panel()
        lblsurname = New Label()
        lblemID = New Label()
        Label5 = New Label()
        Panel2.SuspendLayout()
        CType(DataGridViewstuff, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBoxstuff, ComponentModel.ISupportInitialize).BeginInit()
        Panellowerstuff.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.RightToLeft = RightToLeft.Yes
        Panel1.Size = New Size(0, 0)
        Panel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel2.BackColor = Color.FromArgb(CByte(31), CByte(31), CByte(68))
        Panel2.Controls.Add(DataGridViewstuff)
        Panel2.Location = New Point(3, 4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(634, 248)
        Panel2.TabIndex = 1
        ' 
        ' DataGridViewstuff
        ' 
        DataGridViewstuff.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridViewstuff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewstuff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewstuff.Location = New Point(0, 0)
        DataGridViewstuff.Name = "DataGridViewstuff"
        DataGridViewstuff.Size = New Size(634, 232)
        DataGridViewstuff.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9.75F)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(9, 6)
        Label1.Name = "Label1"
        Label1.Size = New Size(72, 17)
        Label1.TabIndex = 2
        Label1.Text = "Empolyee :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.75F)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(31, 88)
        Label2.Name = "Label2"
        Label2.Size = New Size(50, 17)
        Label2.TabIndex = 3
        Label2.Text = "Status :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9.75F)
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(35, 60)
        Label3.Name = "Label3"
        Label3.Size = New Size(46, 17)
        Label3.TabIndex = 4
        Label3.Text = "ROLE :"
        ' 
        ' lblfname
        ' 
        lblfname.AutoSize = True
        lblfname.Font = New Font("Segoe UI", 9.75F)
        lblfname.ForeColor = Color.Black
        lblfname.Location = New Point(95, 6)
        lblfname.Name = "lblfname"
        lblfname.Size = New Size(46, 17)
        lblfname.TabIndex = 5
        lblfname.Text = "Label4"
        ' 
        ' lblRole
        ' 
        lblRole.AutoSize = True
        lblRole.Font = New Font("Segoe UI", 9.75F)
        lblRole.ForeColor = Color.Black
        lblRole.Location = New Point(97, 60)
        lblRole.Name = "lblRole"
        lblRole.Size = New Size(61, 17)
        lblRole.TabIndex = 6
        lblRole.Text = "Nail Tech"
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Font = New Font("Segoe UI", 9.75F)
        lblStatus.ForeColor = Color.Black
        lblStatus.Location = New Point(97, 88)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(52, 17)
        lblStatus.TabIndex = 7
        lblStatus.Text = "Booked"
        ' 
        ' PictureBoxstuff
        ' 
        PictureBoxstuff.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PictureBoxstuff.BackColor = SystemColors.ControlDark
        PictureBoxstuff.Location = New Point(503, 6)
        PictureBoxstuff.Name = "PictureBoxstuff"
        PictureBoxstuff.Size = New Size(123, 99)
        PictureBoxstuff.TabIndex = 8
        PictureBoxstuff.TabStop = False
        ' 
        ' Panellowerstuff
        ' 
        Panellowerstuff.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panellowerstuff.AutoSize = True
        Panellowerstuff.Controls.Add(lblsurname)
        Panellowerstuff.Controls.Add(lblemID)
        Panellowerstuff.Controls.Add(Label5)
        Panellowerstuff.Controls.Add(lblRole)
        Panellowerstuff.Controls.Add(lblfname)
        Panellowerstuff.Controls.Add(Label3)
        Panellowerstuff.Controls.Add(Label2)
        Panellowerstuff.Controls.Add(PictureBoxstuff)
        Panellowerstuff.Controls.Add(Label1)
        Panellowerstuff.Controls.Add(lblStatus)
        Panellowerstuff.Location = New Point(3, 258)
        Panellowerstuff.Name = "Panellowerstuff"
        Panellowerstuff.Size = New Size(634, 109)
        Panellowerstuff.TabIndex = 2
        ' 
        ' lblsurname
        ' 
        lblsurname.AutoSize = True
        lblsurname.Font = New Font("Segoe UI", 9.75F)
        lblsurname.ForeColor = Color.Black
        lblsurname.Location = New Point(157, 6)
        lblsurname.Name = "lblsurname"
        lblsurname.Size = New Size(46, 17)
        lblsurname.TabIndex = 11
        lblsurname.Text = "Label4"
        ' 
        ' lblemID
        ' 
        lblemID.AutoSize = True
        lblemID.Font = New Font("Segoe UI", 9.75F)
        lblemID.ForeColor = Color.Black
        lblemID.Location = New Point(95, 32)
        lblemID.Name = "lblemID"
        lblemID.Size = New Size(36, 17)
        lblemID.TabIndex = 10
        lblemID.Text = "1000"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9.75F)
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(24, 32)
        Label5.Name = "Label5"
        Label5.Size = New Size(57, 17)
        Label5.TabIndex = 9
        Label5.Text = "Emp ID :"
        ' 
        ' FormStaff
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(641, 367)
        Controls.Add(Panellowerstuff)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        ForeColor = Color.Black
        Name = "FormStaff"
        Text = "Staff"
        Panel2.ResumeLayout(False)
        CType(DataGridViewstuff, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBoxstuff, ComponentModel.ISupportInitialize).EndInit()
        Panellowerstuff.ResumeLayout(False)
        Panellowerstuff.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataGridViewstuff As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblfname As Label
    Friend WithEvents lblRole As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents PictureBoxstuff As PictureBox
    Friend WithEvents Panellowerstuff As Panel
    Friend WithEvents lblemID As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblsurname As Label
End Class
