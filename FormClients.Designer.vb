<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormClients
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
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        DataGridViewclients = New DataGridView()
        Panel2 = New Panel()
        Button1 = New Button()
        btndeletee = New Button()
        btnadd = New Button()
        lblLoyalty = New Label()
        Label7 = New Label()
        txtEmail = New TextBox()
        txtFname = New TextBox()
        txtLname = New TextBox()
        txtCellno = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Paneldivide = New Panel()
        Panel1.SuspendLayout()
        CType(DataGridViewclients, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.AutoSize = True
        Panel1.BackColor = Color.FromArgb(CByte(31), CByte(31), CByte(68))
        Panel1.Controls.Add(DataGridViewclients)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(657, 406)
        Panel1.TabIndex = 0
        ' 
        ' DataGridViewclients
        ' 
        DataGridViewclients.AllowDrop = True
        DataGridViewclients.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridViewclients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewclients.BackgroundColor = Color.White
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.ControlDark
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle1.ForeColor = SystemColors.ActiveCaptionText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridViewclients.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewclients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.White
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        DataGridViewclients.DefaultCellStyle = DataGridViewCellStyle2
        DataGridViewclients.GridColor = Color.Gray
        DataGridViewclients.Location = New Point(0, 0)
        DataGridViewclients.Name = "DataGridViewclients"
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = Color.Black
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        DataGridViewclients.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DataGridViewCellStyle4.ForeColor = Color.Black
        DataGridViewclients.RowsDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewclients.Size = New Size(657, 406)
        DataGridViewclients.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.AutoSize = True
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(btndeletee)
        Panel2.Controls.Add(btnadd)
        Panel2.Controls.Add(lblLoyalty)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(txtEmail)
        Panel2.Controls.Add(txtFname)
        Panel2.Controls.Add(txtLname)
        Panel2.Controls.Add(txtCellno)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label2)
        Panel2.Dock = DockStyle.Bottom
        Panel2.Location = New Point(0, 219)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(657, 187)
        Panel2.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Button1.BackColor = Color.Fuchsia
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.Gainsboro
        Button1.Location = New Point(474, 71)
        Button1.Name = "Button1"
        Button1.Size = New Size(156, 24)
        Button1.TabIndex = 16
        Button1.Text = "Book"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' btndeletee
        ' 
        btndeletee.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btndeletee.BackColor = Color.FromArgb(CByte(31), CByte(31), CByte(68))
        btndeletee.FlatStyle = FlatStyle.Flat
        btndeletee.ForeColor = Color.Gainsboro
        btndeletee.Location = New Point(291, 148)
        btndeletee.Name = "btndeletee"
        btndeletee.Size = New Size(156, 24)
        btndeletee.TabIndex = 15
        btndeletee.Text = "DELETE"
        btndeletee.UseVisualStyleBackColor = False
        ' 
        ' btnadd
        ' 
        btnadd.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnadd.BackColor = Color.FromArgb(CByte(31), CByte(31), CByte(68))
        btnadd.FlatStyle = FlatStyle.Flat
        btnadd.ForeColor = Color.Gainsboro
        btnadd.Location = New Point(123, 148)
        btnadd.Name = "btnadd"
        btnadd.Size = New Size(156, 24)
        btnadd.TabIndex = 14
        btnadd.Text = "ADD"
        btnadd.UseVisualStyleBackColor = False
        ' 
        ' lblLoyalty
        ' 
        lblLoyalty.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblLoyalty.AutoSize = True
        lblLoyalty.BackColor = Color.Transparent
        lblLoyalty.ForeColor = Color.Black
        lblLoyalty.Location = New Point(577, 30)
        lblLoyalty.Name = "lblLoyalty"
        lblLoyalty.Size = New Size(49, 15)
        lblLoyalty.TabIndex = 13
        lblLoyalty.Text = "0 points"
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.ForeColor = Color.Black
        Label7.Location = New Point(474, 30)
        Label7.Name = "Label7"
        Label7.Size = New Size(87, 15)
        Label7.TabIndex = 12
        Label7.Text = "Loyalty points :"
        ' 
        ' txtEmail
        ' 
        txtEmail.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtEmail.Location = New Point(338, 72)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(109, 23)
        txtEmail.TabIndex = 9
        ' 
        ' txtFname
        ' 
        txtFname.Location = New Point(104, 22)
        txtFname.Name = "txtFname"
        txtFname.Size = New Size(126, 23)
        txtFname.TabIndex = 8
        ' 
        ' txtLname
        ' 
        txtLname.Location = New Point(104, 75)
        txtLname.Name = "txtLname"
        txtLname.Size = New Size(126, 23)
        txtLname.TabIndex = 7
        ' 
        ' txtCellno
        ' 
        txtCellno.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtCellno.Location = New Point(338, 25)
        txtCellno.Name = "txtCellno"
        txtCellno.Size = New Size(109, 23)
        txtCellno.TabIndex = 6
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(296, 75)
        Label5.Name = "Label5"
        Label5.Size = New Size(36, 15)
        Label5.TabIndex = 4
        Label5.Text = "Email"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(34, 80)
        Label4.Name = "Label4"
        Label4.Size = New Size(63, 15)
        Label4.TabIndex = 3
        Label4.Text = "Last Name"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(291, 28)
        Label3.Name = "Label3"
        Label3.Size = New Size(41, 15)
        Label3.TabIndex = 2
        Label3.Text = "Phone"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(34, 25)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 15)
        Label2.TabIndex = 1
        Label2.Text = "First Name"
        ' 
        ' Paneldivide
        ' 
        Paneldivide.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Paneldivide.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Paneldivide.BackColor = Color.FromArgb(CByte(31), CByte(31), CByte(68))
        Paneldivide.Location = New Point(0, 219)
        Paneldivide.Name = "Paneldivide"
        Paneldivide.Size = New Size(657, 19)
        Paneldivide.TabIndex = 2
        ' 
        ' FormClients
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(657, 406)
        Controls.Add(Paneldivide)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormClients"
        Text = "Clients"
        Panel1.ResumeLayout(False)
        CType(DataGridViewclients, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataGridViewclients As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtFname As TextBox
    Friend WithEvents txtLname As TextBox
    Friend WithEvents txtCellno As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblLoyalty As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btndeletee As Button
    Friend WithEvents btnadd As Button
    Friend WithEvents Paneldivide As Panel
    Friend WithEvents Button1 As Button
End Class
