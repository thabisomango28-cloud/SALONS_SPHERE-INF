<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminstock
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
        Panellowerstuff = New Panel()
        Button1 = New Button()
        btnClear = New Button()
        btnAdd = New Button()
        txtPrice = New TextBox()
        Label4 = New Label()
        txtReorder = New TextBox()
        Label2 = New Label()
        BTN_UPLOAD = New Button()
        txtquantity = New TextBox()
        txtCategory = New TextBox()
        txtItemName = New TextBox()
        Label5 = New Label()
        Label3 = New Label()
        PictureBoxstuff = New PictureBox()
        Label1 = New Label()
        Panel2 = New Panel()
        DataGridViewstock = New DataGridView()
        Panellowerstuff.SuspendLayout()
        CType(PictureBoxstuff, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(DataGridViewstock, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panellowerstuff
        ' 
        Panellowerstuff.AutoSize = True
        Panellowerstuff.Controls.Add(Button1)
        Panellowerstuff.Controls.Add(btnClear)
        Panellowerstuff.Controls.Add(btnAdd)
        Panellowerstuff.Controls.Add(txtPrice)
        Panellowerstuff.Controls.Add(Label4)
        Panellowerstuff.Controls.Add(txtReorder)
        Panellowerstuff.Controls.Add(Label2)
        Panellowerstuff.Controls.Add(BTN_UPLOAD)
        Panellowerstuff.Controls.Add(txtquantity)
        Panellowerstuff.Controls.Add(txtCategory)
        Panellowerstuff.Controls.Add(txtItemName)
        Panellowerstuff.Controls.Add(Label5)
        Panellowerstuff.Controls.Add(Label3)
        Panellowerstuff.Controls.Add(PictureBoxstuff)
        Panellowerstuff.Controls.Add(Label1)
        Panellowerstuff.Dock = DockStyle.Fill
        Panellowerstuff.Location = New Point(0, 253)
        Panellowerstuff.Name = "Panellowerstuff"
        Panellowerstuff.Size = New Size(657, 153)
        Panellowerstuff.TabIndex = 5
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Button1.BackColor = Color.Red
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Location = New Point(42, 127)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 25
        Button1.Text = "Delete"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnClear.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.Location = New Point(150, 127)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(75, 23)
        btnClear.TabIndex = 24
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnAdd
        ' 
        btnAdd.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnAdd.BackColor = SystemColors.ActiveCaption
        btnAdd.FlatStyle = FlatStyle.Flat
        btnAdd.Location = New Point(519, 127)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(75, 23)
        btnAdd.TabIndex = 23
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' txtPrice
        ' 
        txtPrice.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtPrice.Location = New Point(449, 50)
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(145, 23)
        txtPrice.TabIndex = 22
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9.75F)
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(400, 51)
        Label4.Name = "Label4"
        Label4.Size = New Size(43, 17)
        Label4.TabIndex = 21
        Label4.Text = "Price :"
        ' 
        ' txtReorder
        ' 
        txtReorder.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtReorder.Location = New Point(449, 12)
        txtReorder.Name = "txtReorder"
        txtReorder.Size = New Size(145, 23)
        txtReorder.TabIndex = 20
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.75F)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(347, 17)
        Label2.Name = "Label2"
        Label2.Size = New Size(96, 17)
        Label2.TabIndex = 19
        Label2.Text = "ReOrder_level :"
        ' 
        ' BTN_UPLOAD
        ' 
        BTN_UPLOAD.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        BTN_UPLOAD.BackColor = Color.Lime
        BTN_UPLOAD.FlatStyle = FlatStyle.Flat
        BTN_UPLOAD.Location = New Point(955, 123)
        BTN_UPLOAD.Name = "BTN_UPLOAD"
        BTN_UPLOAD.Size = New Size(106, 24)
        BTN_UPLOAD.TabIndex = 18
        BTN_UPLOAD.Text = "UPLOAD"
        BTN_UPLOAD.UseVisualStyleBackColor = False
        ' 
        ' txtquantity
        ' 
        txtquantity.Location = New Point(80, 84)
        txtquantity.Name = "txtquantity"
        txtquantity.Size = New Size(145, 23)
        txtquantity.TabIndex = 16
        ' 
        ' txtCategory
        ' 
        txtCategory.Location = New Point(80, 50)
        txtCategory.Name = "txtCategory"
        txtCategory.Size = New Size(145, 23)
        txtCategory.TabIndex = 15
        ' 
        ' txtItemName
        ' 
        txtItemName.Location = New Point(80, 11)
        txtItemName.Name = "txtItemName"
        txtItemName.Size = New Size(145, 23)
        txtItemName.TabIndex = 14
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9.75F)
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(12, 51)
        Label5.Name = "Label5"
        Label5.Size = New Size(68, 17)
        Label5.TabIndex = 9
        Label5.Text = "Category :"
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
        Label3.Text = "quantity :"
        ' 
        ' PictureBoxstuff
        ' 
        PictureBoxstuff.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PictureBoxstuff.BackColor = SystemColors.ControlDark
        PictureBoxstuff.Location = New Point(1417, 6)
        PictureBoxstuff.Name = "PictureBoxstuff"
        PictureBoxstuff.Size = New Size(123, 99)
        PictureBoxstuff.TabIndex = 8
        PictureBoxstuff.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9.75F)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(3, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(79, 17)
        Label1.TabIndex = 2
        Label1.Text = "Item Name :"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(31), CByte(31), CByte(68))
        Panel2.Controls.Add(DataGridViewstock)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(657, 253)
        Panel2.TabIndex = 4
        ' 
        ' DataGridViewstock
        ' 
        DataGridViewstock.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridViewstock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewstock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewstock.Location = New Point(0, 3)
        DataGridViewstock.Name = "DataGridViewstock"
        DataGridViewstock.Size = New Size(654, 244)
        DataGridViewstock.TabIndex = 0
        ' 
        ' adminstock
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(657, 406)
        Controls.Add(Panellowerstuff)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.None
        Name = "adminstock"
        Text = "adminstock"
        Panellowerstuff.ResumeLayout(False)
        Panellowerstuff.PerformLayout()
        CType(PictureBoxstuff, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        CType(DataGridViewstock, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panellowerstuff As Panel
    Friend WithEvents BTN_UPLOAD As Button
    Private WithEvents txtquantity As TextBox
    Private WithEvents txtCategory As TextBox
    Friend WithEvents txtItemName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBoxstuff As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataGridViewstock As DataGridView
    Private WithEvents txtReorder As TextBox
    Friend WithEvents Label2 As Label
    Private WithEvents txtPrice As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents Button1 As Button
End Class
