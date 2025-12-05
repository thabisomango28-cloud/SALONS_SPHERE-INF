<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminclient
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
        Panel2 = New Panel()
        Label1 = New Label()
        Label6 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Label9 = New Label()
        Label10 = New Label()
        btndeletee = New Button()
        btnadd = New Button()
        Label8 = New Label()
        Label7 = New Label()
        txtEmail = New TextBox()
        txtFname = New TextBox()
        txtLname = New TextBox()
        txtCellno = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        DataGridViewclients = New DataGridView()
        Panel2.SuspendLayout()
        CType(DataGridViewclients, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.AutoSize = True
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(TextBox1)
        Panel2.Controls.Add(TextBox2)
        Panel2.Controls.Add(Label9)
        Panel2.Controls.Add(Label10)
        Panel2.Controls.Add(btndeletee)
        Panel2.Controls.Add(btnadd)
        Panel2.Controls.Add(Label8)
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
        Panel2.Location = New Point(0, 283)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(641, 101)
        Panel2.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(576, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 15)
        Label1.TabIndex = 21
        Label1.Text = "0 points"
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(473, 27)
        Label6.Name = "Label6"
        Label6.Size = New Size(87, 15)
        Label6.TabIndex = 20
        Label6.Text = "Loyalty points :"
        ' 
        ' TextBox1
        ' 
        TextBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TextBox1.Location = New Point(337, 69)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(109, 23)
        TextBox1.TabIndex = 19
        ' 
        ' TextBox2
        ' 
        TextBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TextBox2.Location = New Point(337, 22)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(109, 23)
        TextBox2.TabIndex = 18
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.ForeColor = Color.Black
        Label9.Location = New Point(295, 72)
        Label9.Name = "Label9"
        Label9.Size = New Size(36, 15)
        Label9.TabIndex = 17
        Label9.Text = "Email"
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.ForeColor = Color.Black
        Label10.Location = New Point(290, 25)
        Label10.Name = "Label10"
        Label10.Size = New Size(41, 15)
        Label10.TabIndex = 16
        Label10.Text = "Phone"
        ' 
        ' btndeletee
        ' 
        btndeletee.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btndeletee.BackColor = Color.FromArgb(CByte(31), CByte(31), CByte(68))
        btndeletee.FlatStyle = FlatStyle.Flat
        btndeletee.ForeColor = Color.Gainsboro
        btndeletee.Location = New Point(732, 149)
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
        btnadd.Location = New Point(123, 149)
        btnadd.Name = "btnadd"
        btnadd.Size = New Size(156, 24)
        btnadd.TabIndex = 14
        btnadd.Text = "ADD"
        btnadd.UseVisualStyleBackColor = False
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.ForeColor = Color.Black
        Label8.Location = New Point(1018, 30)
        Label8.Name = "Label8"
        Label8.Size = New Size(49, 15)
        Label8.TabIndex = 13
        Label8.Text = "0 points"
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.ForeColor = Color.Black
        Label7.Location = New Point(915, 30)
        Label7.Name = "Label7"
        Label7.Size = New Size(87, 15)
        Label7.TabIndex = 12
        Label7.Text = "Loyalty points :"
        ' 
        ' txtEmail
        ' 
        txtEmail.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtEmail.Location = New Point(779, 72)
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
        txtCellno.Location = New Point(779, 25)
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
        Label5.Location = New Point(737, 75)
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
        Label3.Location = New Point(732, 28)
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
        DataGridViewclients.Location = New Point(-8, -20)
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
        DataGridViewclients.TabIndex = 2
        ' 
        ' adminclient
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(641, 384)
        Controls.Add(Panel2)
        Controls.Add(DataGridViewclients)
        FormBorderStyle = FormBorderStyle.None
        Name = "adminclient"
        Text = "Clients"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(DataGridViewclients, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents btndeletee As Button
    Friend WithEvents btnadd As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtFname As TextBox
    Friend WithEvents txtLname As TextBox
    Friend WithEvents txtCellno As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridViewclients As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
End Class
