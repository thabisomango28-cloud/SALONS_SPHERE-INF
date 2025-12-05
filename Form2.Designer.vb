<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customer
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        txtfirstn = New TextBox()
        txtlastn = New TextBox()
        txtcnumber = New TextBox()
        txtemail = New TextBox()
        btnback = New Button()
        btnsubmit = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(btnsubmit)
        Panel1.Controls.Add(btnback)
        Panel1.Controls.Add(txtemail)
        Panel1.Controls.Add(txtcnumber)
        Panel1.Controls.Add(txtlastn)
        Panel1.Controls.Add(txtfirstn)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(821, 450)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(59, 96)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 15)
        Label1.TabIndex = 0
        Label1.Text = "First Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(59, 152)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 15)
        Label2.TabIndex = 1
        Label2.Text = "Last Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(59, 234)
        Label3.Name = "Label3"
        Label3.Size = New Size(74, 15)
        Label3.TabIndex = 2
        Label3.Text = "Cell Number"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(59, 311)
        Label4.Name = "Label4"
        Label4.Size = New Size(36, 15)
        Label4.TabIndex = 3
        Label4.Text = "Email"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(228, 29)
        Label5.Name = "Label5"
        Label5.Size = New Size(98, 25)
        Label5.TabIndex = 4
        Label5.Text = "Customer"
        ' 
        ' txtfirstn
        ' 
        txtfirstn.Location = New Point(228, 88)
        txtfirstn.Name = "txtfirstn"
        txtfirstn.Size = New Size(100, 23)
        txtfirstn.TabIndex = 5
        ' 
        ' txtlastn
        ' 
        txtlastn.Location = New Point(230, 144)
        txtlastn.Name = "txtlastn"
        txtlastn.Size = New Size(100, 23)
        txtlastn.TabIndex = 6
        ' 
        ' txtcnumber
        ' 
        txtcnumber.Location = New Point(230, 213)
        txtcnumber.Name = "txtcnumber"
        txtcnumber.Size = New Size(100, 23)
        txtcnumber.TabIndex = 7
        ' 
        ' txtemail
        ' 
        txtemail.Location = New Point(230, 303)
        txtemail.Name = "txtemail"
        txtemail.Size = New Size(100, 23)
        txtemail.TabIndex = 8
        ' 
        ' btnback
        ' 
        btnback.Location = New Point(59, 373)
        btnback.Name = "btnback"
        btnback.Size = New Size(75, 36)
        btnback.TabIndex = 9
        btnback.Text = "Back"
        btnback.UseVisualStyleBackColor = True
        ' 
        ' btnsubmit
        ' 
        btnsubmit.Location = New Point(242, 373)
        btnsubmit.Name = "btnsubmit"
        btnsubmit.Size = New Size(75, 36)
        btnsubmit.TabIndex = 10
        btnsubmit.Text = "Submit"
        btnsubmit.UseVisualStyleBackColor = True
        ' 
        ' Customer
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(821, 450)
        Controls.Add(Panel1)
        Name = "Customer"
        Text = "Customer"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtemail As TextBox
    Friend WithEvents txtcnumber As TextBox
    Friend WithEvents txtlastn As TextBox
    Friend WithEvents txtfirstn As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnsubmit As Button
    Friend WithEvents btnback As Button
End Class
