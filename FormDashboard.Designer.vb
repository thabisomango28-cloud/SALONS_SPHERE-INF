<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDashboard))
        Panel1 = New Panel()
        lblAppnum = New Label()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Panel2 = New Panel()
        Panel4 = New Panel()
        Button1 = New Button()
        lblTime = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Panel3 = New Panel()
        lblSales = New Label()
        Label4 = New Label()
        PictureBox2 = New PictureBox()
        Label5 = New Label()
        PanelBottomdash = New Panel()
        Panel6 = New Panel()
        lblMessage = New Label()
        Label10 = New Label()
        Panel5 = New Panel()
        Panel7 = New Panel()
        lblBestsell = New Label()
        lblBestSelling = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel4.SuspendLayout()
        Panel3.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        PanelBottomdash.SuspendLayout()
        Panel6.SuspendLayout()
        Panel5.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(31), CByte(31), CByte(68))
        Panel1.Controls.Add(lblAppnum)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(223, 249)
        Panel1.TabIndex = 0
        ' 
        ' lblAppnum
        ' 
        lblAppnum.AutoSize = True
        lblAppnum.Font = New Font("MS Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAppnum.ForeColor = Color.White
        lblAppnum.Location = New Point(40, 53)
        lblAppnum.Name = "lblAppnum"
        lblAppnum.Size = New Size(36, 24)
        lblAppnum.TabIndex = 3
        lblAppnum.Text = "0+"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.White
        Label2.Location = New Point(40, 53)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 15)
        Label2.TabIndex = 2
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Right
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(123, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(100, 249)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Lucida Sans", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(13, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(104, 15)
        Label1.TabIndex = 0
        Label1.Text = "Appointments"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.DarkBlue
        Panel2.Controls.Add(Panel4)
        Panel2.Controls.Add(Panel3)
        Panel2.Controls.Add(Panel1)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(641, 249)
        Panel2.TabIndex = 1
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(31), CByte(31), CByte(68))
        Panel4.Controls.Add(Button1)
        Panel4.Controls.Add(lblTime)
        Panel4.Controls.Add(Label7)
        Panel4.Controls.Add(Label8)
        Panel4.Dock = DockStyle.Right
        Panel4.Location = New Point(465, 0)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(176, 249)
        Panel4.TabIndex = 2
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(46, 104)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 4
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' lblTime
        ' 
        lblTime.AutoSize = True
        lblTime.Font = New Font("Symbol", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(2))
        lblTime.ForeColor = Color.White
        lblTime.Location = New Point(46, 41)
        lblTime.Name = "lblTime"
        lblTime.Size = New Size(73, 30)
        lblTime.TabIndex = 3
        lblTime.Text = "00:00"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.ForeColor = Color.White
        Label7.Location = New Point(40, 53)
        Label7.Name = "Label7"
        Label7.Size = New Size(0, 15)
        Label7.TabIndex = 2
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Lucida Sans", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.White
        Label8.Location = New Point(60, 9)
        Label8.Name = "Label8"
        Label8.Size = New Size(39, 15)
        Label8.TabIndex = 0
        Label8.Text = "Time"
        ' 
        ' Panel3
        ' 
        Panel3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Panel3.BackColor = Color.FromArgb(CByte(31), CByte(31), CByte(68))
        Panel3.Controls.Add(lblSales)
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(PictureBox2)
        Panel3.Controls.Add(Label5)
        Panel3.Location = New Point(238, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(223, 249)
        Panel3.TabIndex = 1
        ' 
        ' lblSales
        ' 
        lblSales.AutoSize = True
        lblSales.Font = New Font("MS Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSales.ForeColor = Color.White
        lblSales.Location = New Point(40, 53)
        lblSales.Name = "lblSales"
        lblSales.Size = New Size(36, 24)
        lblSales.TabIndex = 3
        lblSales.Text = "0+"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.White
        Label4.Location = New Point(40, 53)
        Label4.Name = "Label4"
        Label4.Size = New Size(0, 15)
        Label4.TabIndex = 2
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Dock = DockStyle.Right
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(123, 0)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(100, 249)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Lucida Sans", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(35, 9)
        Label5.Name = "Label5"
        Label5.Size = New Size(42, 15)
        Label5.TabIndex = 0
        Label5.Text = "Sales"
        ' 
        ' PanelBottomdash
        ' 
        PanelBottomdash.BackColor = Color.FromArgb(CByte(31), CByte(31), CByte(68))
        PanelBottomdash.Controls.Add(Panel6)
        PanelBottomdash.Controls.Add(Panel5)
        PanelBottomdash.Dock = DockStyle.Fill
        PanelBottomdash.Location = New Point(0, 249)
        PanelBottomdash.Name = "PanelBottomdash"
        PanelBottomdash.Size = New Size(641, 118)
        PanelBottomdash.TabIndex = 2
        ' 
        ' Panel6
        ' 
        Panel6.AutoSize = True
        Panel6.Controls.Add(lblMessage)
        Panel6.Controls.Add(Label10)
        Panel6.Dock = DockStyle.Fill
        Panel6.Location = New Point(323, 0)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(318, 118)
        Panel6.TabIndex = 1
        ' 
        ' lblMessage
        ' 
        lblMessage.AutoSize = True
        lblMessage.Font = New Font("MS Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblMessage.ForeColor = Color.White
        lblMessage.Location = New Point(22, 59)
        lblMessage.Name = "lblMessage"
        lblMessage.Size = New Size(153, 24)
        lblMessage.TabIndex = 5
        lblMessage.Text = "Stock level"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Dock = DockStyle.Top
        Label10.Font = New Font("Lucida Sans", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.White
        Label10.Location = New Point(0, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(206, 23)
        Label10.TabIndex = 4
        Label10.Text = "  System Message"
        ' 
        ' Panel5
        ' 
        Panel5.AutoSize = True
        Panel5.Controls.Add(Panel7)
        Panel5.Controls.Add(lblBestsell)
        Panel5.Controls.Add(lblBestSelling)
        Panel5.Dock = DockStyle.Left
        Panel5.Location = New Point(0, 0)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(323, 118)
        Panel5.TabIndex = 0
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.Red
        Panel7.Location = New Point(310, 0)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(10, 187)
        Panel7.TabIndex = 5
        ' 
        ' lblBestsell
        ' 
        lblBestsell.AutoSize = True
        lblBestsell.Font = New Font("MS Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblBestsell.ForeColor = Color.White
        lblBestsell.Location = New Point(13, 59)
        lblBestsell.Name = "lblBestsell"
        lblBestsell.Size = New Size(62, 24)
        lblBestsell.TabIndex = 4
        lblBestsell.Text = "-Dye"
        ' 
        ' lblBestSelling
        ' 
        lblBestSelling.AutoSize = True
        lblBestSelling.Dock = DockStyle.Fill
        lblBestSelling.Font = New Font("Lucida Sans", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblBestSelling.ForeColor = Color.White
        lblBestSelling.Location = New Point(0, 0)
        lblBestSelling.Name = "lblBestSelling"
        lblBestSelling.Size = New Size(248, 23)
        lblBestSelling.TabIndex = 3
        lblBestSelling.Text = "   Best Selling Product"
        ' 
        ' FormDashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(641, 367)
        Controls.Add(PanelBottomdash)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormDashboard"
        Text = "Dashboard"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        PanelBottomdash.ResumeLayout(False)
        PanelBottomdash.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblAppnum As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblSales As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblTime As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents PanelBottomdash As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents lblBestSelling As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents lblMessage As Label
    Friend WithEvents lblBestsell As Label
    Friend WithEvents Panel7 As Panel
End Class
