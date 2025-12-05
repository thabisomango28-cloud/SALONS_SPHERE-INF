<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormServices
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
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        DataGridViewService = New DataGridView()
        Panel3 = New Panel()
        Panel2 = New Panel()
        lblstock = New Label()
        txtProductName = New TextBox()
        Button4 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button1 = New Button()
        lblPrice = New Label()
        txtQuantity = New TextBox()
        Label4 = New Label()
        Label14 = New Label()
        Label3 = New Label()
        cmbProductID = New ComboBox()
        Label2 = New Label()
        cmbType = New ComboBox()
        Label1 = New Label()
        Panel4 = New Panel()
        Button6 = New Button()
        btnProcessPayment = New Button()
        lblChange = New Label()
        Label13 = New Label()
        txtAmountPaid = New TextBox()
        Label11 = New Label()
        cmbPaymentType = New ComboBox()
        Label10 = New Label()
        lblGrandTotal = New Label()
        Label8 = New Label()
        DataGridView2 = New DataGridView()
        Panel1.SuspendLayout()
        CType(DataGridViewService, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel4.SuspendLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel1.BackColor = Color.FromArgb(CByte(31), CByte(31), CByte(68))
        Panel1.Controls.Add(DataGridViewService)
        Panel1.Controls.Add(Panel3)
        Panel1.Location = New Point(3, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(431, 213)
        Panel1.TabIndex = 0
        ' 
        ' DataGridViewService
        ' 
        DataGridViewService.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewService.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders
        DataGridViewService.BackgroundColor = SystemColors.ControlLightLight
        DataGridViewService.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewService.Dock = DockStyle.Fill
        DataGridViewService.GridColor = SystemColors.Desktop
        DataGridViewService.Location = New Point(0, 0)
        DataGridViewService.Name = "DataGridViewService"
        DataGridViewCellStyle2.ForeColor = Color.Black
        DataGridViewService.RowsDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewService.Size = New Size(431, 213)
        DataGridViewService.TabIndex = 1
        ' 
        ' Panel3
        ' 
        Panel3.Location = New Point(526, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(250, 426)
        Panel3.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel2.BackColor = Color.Silver
        Panel2.Controls.Add(lblstock)
        Panel2.Controls.Add(txtProductName)
        Panel2.Controls.Add(Button4)
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(Button3)
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(lblPrice)
        Panel2.Controls.Add(txtQuantity)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label14)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(cmbProductID)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(cmbType)
        Panel2.Controls.Add(Label1)
        Panel2.ForeColor = Color.White
        Panel2.Location = New Point(3, 214)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(428, 199)
        Panel2.TabIndex = 0
        ' 
        ' lblstock
        ' 
        lblstock.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblstock.AutoSize = True
        lblstock.BackColor = Color.Transparent
        lblstock.ForeColor = Color.Black
        lblstock.Location = New Point(296, 118)
        lblstock.Name = "lblstock"
        lblstock.Size = New Size(35, 15)
        lblstock.TabIndex = 12
        lblstock.Text = "stock"
        ' 
        ' txtProductName
        ' 
        txtProductName.Location = New Point(99, 70)
        txtProductName.Name = "txtProductName"
        txtProductName.Size = New Size(111, 23)
        txtProductName.TabIndex = 11
        ' 
        ' Button4
        ' 
        Button4.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Button4.BackColor = Color.FromArgb(CByte(31), CByte(31), CByte(68))
        Button4.FlatStyle = FlatStyle.Flat
        Button4.ForeColor = Color.Gainsboro
        Button4.Location = New Point(280, 155)
        Button4.Name = "Button4"
        Button4.Size = New Size(103, 23)
        Button4.TabIndex = 10
        Button4.Text = "Clear"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Button2.BackColor = Color.FromArgb(CByte(31), CByte(31), CByte(68))
        Button2.FlatStyle = FlatStyle.Flat
        Button2.ForeColor = Color.Gainsboro
        Button2.Location = New Point(170, 155)
        Button2.Name = "Button2"
        Button2.Size = New Size(103, 23)
        Button2.TabIndex = 9
        Button2.Text = "Remove"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(464, 263)
        Button3.Name = "Button3"
        Button3.Size = New Size(103, 23)
        Button3.TabIndex = 8
        Button3.Text = "Button3"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Button1.BackColor = Color.FromArgb(CByte(31), CByte(31), CByte(68))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.Gainsboro
        Button1.Location = New Point(46, 155)
        Button1.Name = "Button1"
        Button1.Size = New Size(103, 23)
        Button1.TabIndex = 6
        Button1.Text = "ADD"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' lblPrice
        ' 
        lblPrice.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblPrice.AutoSize = True
        lblPrice.BackColor = Color.Transparent
        lblPrice.ForeColor = Color.Black
        lblPrice.Location = New Point(119, 120)
        lblPrice.Name = "lblPrice"
        lblPrice.Size = New Size(25, 15)
        lblPrice.TabIndex = 5
        lblPrice.Text = "100"
        ' 
        ' txtQuantity
        ' 
        txtQuantity.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtQuantity.Location = New Point(296, 75)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(111, 23)
        txtQuantity.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(240, 78)
        Label4.Name = "Label4"
        Label4.Size = New Size(56, 15)
        Label4.TabIndex = 2
        Label4.Text = "Qauntity:"
        ' 
        ' Label14
        ' 
        Label14.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label14.AutoSize = True
        Label14.BackColor = Color.Transparent
        Label14.ForeColor = Color.Black
        Label14.Location = New Point(54, 120)
        Label14.Name = "Label14"
        Label14.Size = New Size(59, 15)
        Label14.TabIndex = 2
        Label14.Text = "Price ($)  :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(3, 75)
        Label3.Name = "Label3"
        Label3.Size = New Size(90, 15)
        Label3.TabIndex = 2
        Label3.Text = "Product Name :"
        ' 
        ' cmbProductID
        ' 
        cmbProductID.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cmbProductID.FormattingEnabled = True
        cmbProductID.Location = New Point(296, 34)
        cmbProductID.Name = "cmbProductID"
        cmbProductID.Size = New Size(111, 23)
        cmbProductID.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(227, 34)
        Label2.Name = "Label2"
        Label2.Size = New Size(69, 15)
        Label2.TabIndex = 0
        Label2.Text = "Product ID :"
        ' 
        ' cmbType
        ' 
        cmbType.FormattingEnabled = True
        cmbType.Location = New Point(75, 34)
        cmbType.Name = "cmbType"
        cmbType.Size = New Size(121, 23)
        cmbType.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(32, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(37, 15)
        Label1.TabIndex = 0
        Label1.Text = "Type :"
        ' 
        ' Panel4
        ' 
        Panel4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        Panel4.AutoSize = True
        Panel4.BackColor = Color.FromArgb(CByte(31), CByte(31), CByte(68))
        Panel4.Controls.Add(Button6)
        Panel4.Controls.Add(btnProcessPayment)
        Panel4.Controls.Add(lblChange)
        Panel4.Controls.Add(Label13)
        Panel4.Controls.Add(txtAmountPaid)
        Panel4.Controls.Add(Label11)
        Panel4.Controls.Add(cmbPaymentType)
        Panel4.Controls.Add(Label10)
        Panel4.Controls.Add(lblGrandTotal)
        Panel4.Controls.Add(Label8)
        Panel4.Controls.Add(DataGridView2)
        Panel4.ForeColor = Color.White
        Panel4.Location = New Point(429, 3)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(225, 401)
        Panel4.TabIndex = 0
        ' 
        ' Button6
        ' 
        Button6.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Button6.BackColor = Color.FromArgb(CByte(31), CByte(31), CByte(68))
        Button6.FlatStyle = FlatStyle.Flat
        Button6.ForeColor = Color.Gainsboro
        Button6.Location = New Point(47, 353)
        Button6.Name = "Button6"
        Button6.Size = New Size(156, 23)
        Button6.TabIndex = 14
        Button6.Text = "RECEIPT"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' btnProcessPayment
        ' 
        btnProcessPayment.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnProcessPayment.BackColor = Color.FromArgb(CByte(31), CByte(31), CByte(68))
        btnProcessPayment.FlatStyle = FlatStyle.Flat
        btnProcessPayment.ForeColor = Color.Gainsboro
        btnProcessPayment.Location = New Point(48, 324)
        btnProcessPayment.Name = "btnProcessPayment"
        btnProcessPayment.Size = New Size(156, 24)
        btnProcessPayment.TabIndex = 13
        btnProcessPayment.Text = "PAY"
        btnProcessPayment.UseVisualStyleBackColor = False
        ' 
        ' lblChange
        ' 
        lblChange.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblChange.AutoSize = True
        lblChange.ForeColor = Color.White
        lblChange.Location = New Point(122, 297)
        lblChange.Name = "lblChange"
        lblChange.Size = New Size(28, 15)
        lblChange.TabIndex = 12
        lblChange.Text = "00.0"
        ' 
        ' Label13
        ' 
        Label13.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label13.AutoSize = True
        Label13.ForeColor = Color.White
        Label13.Location = New Point(45, 297)
        Label13.Name = "Label13"
        Label13.Size = New Size(71, 15)
        Label13.TabIndex = 11
        Label13.Text = "Change ($) :"
        ' 
        ' txtAmountPaid
        ' 
        txtAmountPaid.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtAmountPaid.Location = New Point(122, 261)
        txtAmountPaid.Name = "txtAmountPaid"
        txtAmountPaid.Size = New Size(86, 23)
        txtAmountPaid.TabIndex = 10
        ' 
        ' Label11
        ' 
        Label11.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label11.AutoSize = True
        Label11.ForeColor = Color.White
        Label11.Location = New Point(12, 269)
        Label11.Name = "Label11"
        Label11.Size = New Size(104, 15)
        Label11.TabIndex = 9
        Label11.Text = "Amount paid (R)  :"
        ' 
        ' cmbPaymentType
        ' 
        cmbPaymentType.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cmbPaymentType.FormattingEnabled = True
        cmbPaymentType.Location = New Point(122, 230)
        cmbPaymentType.Name = "cmbPaymentType"
        cmbPaymentType.Size = New Size(86, 23)
        cmbPaymentType.TabIndex = 8
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label10.AutoSize = True
        Label10.ForeColor = Color.White
        Label10.Location = New Point(25, 238)
        Label10.Name = "Label10"
        Label10.Size = New Size(87, 15)
        Label10.TabIndex = 7
        Label10.Text = "Payment Type :"
        ' 
        ' lblGrandTotal
        ' 
        lblGrandTotal.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblGrandTotal.AutoSize = True
        lblGrandTotal.BackColor = Color.Transparent
        lblGrandTotal.ForeColor = Color.White
        lblGrandTotal.Location = New Point(122, 202)
        lblGrandTotal.Name = "lblGrandTotal"
        lblGrandTotal.Size = New Size(25, 15)
        lblGrandTotal.TabIndex = 6
        lblGrandTotal.Text = "100"
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.ForeColor = Color.White
        Label8.Location = New Point(53, 202)
        Label8.Name = "Label8"
        Label8.Size = New Size(59, 15)
        Label8.TabIndex = 3
        Label8.Text = "Total (R)  :"
        ' 
        ' DataGridView2
        ' 
        DataGridView2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Location = New Point(8, 9)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.Size = New Size(208, 186)
        DataGridView2.TabIndex = 0
        ' 
        ' FormServices
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(657, 406)
        Controls.Add(Panel4)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormServices"
        Text = "Services"
        Panel1.ResumeLayout(False)
        CType(DataGridViewService, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents DataGridViewService As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbProductID As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbType As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents cmbPaymentType As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents lblGrandTotal As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtAmountPaid As TextBox
    Friend WithEvents lblChange As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnProcessPayment As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents lblstock As Label
End Class
