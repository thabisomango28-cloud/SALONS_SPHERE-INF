<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Service
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
        txtsName = New TextBox()
        txtduration = New TextBox()
        txtprice = New TextBox()
        txtgategory = New TextBox()
        btnback = New Button()
        btnsubmit = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(btnsubmit)
        Panel1.Controls.Add(btnback)
        Panel1.Controls.Add(txtgategory)
        Panel1.Controls.Add(txtprice)
        Panel1.Controls.Add(txtduration)
        Panel1.Controls.Add(txtsName)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(800, 450)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(75, 98)
        Label1.Name = "Label1"
        Label1.Size = New Size(79, 15)
        Label1.TabIndex = 0
        Label1.Text = "Service Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(75, 164)
        Label2.Name = "Label2"
        Label2.Size = New Size(53, 15)
        Label2.TabIndex = 1
        Label2.Text = "Duration"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(75, 243)
        Label3.Name = "Label3"
        Label3.Size = New Size(33, 15)
        Label3.TabIndex = 2
        Label3.Text = "Price"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(75, 323)
        Label4.Name = "Label4"
        Label4.Size = New Size(55, 15)
        Label4.TabIndex = 3
        Label4.Text = "Gategory"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(226, 40)
        Label5.Name = "Label5"
        Label5.Size = New Size(84, 25)
        Label5.TabIndex = 4
        Label5.Text = "Services"
        ' 
        ' txtsName
        ' 
        txtsName.Location = New Point(226, 90)
        txtsName.Name = "txtsName"
        txtsName.Size = New Size(100, 23)
        txtsName.TabIndex = 5
        ' 
        ' txtduration
        ' 
        txtduration.Location = New Point(226, 156)
        txtduration.Name = "txtduration"
        txtduration.Size = New Size(100, 23)
        txtduration.TabIndex = 6
        ' 
        ' txtprice
        ' 
        txtprice.Location = New Point(226, 235)
        txtprice.Name = "txtprice"
        txtprice.Size = New Size(100, 23)
        txtprice.TabIndex = 7
        ' 
        ' txtgategory
        ' 
        txtgategory.Location = New Point(226, 315)
        txtgategory.Name = "txtgategory"
        txtgategory.Size = New Size(100, 23)
        txtgategory.TabIndex = 8
        ' 
        ' btnback
        ' 
        btnback.Location = New Point(75, 386)
        btnback.Name = "btnback"
        btnback.Size = New Size(75, 23)
        btnback.TabIndex = 9
        btnback.Text = "Back"
        btnback.UseVisualStyleBackColor = True
        ' 
        ' btnsubmit
        ' 
        btnsubmit.Location = New Point(226, 386)
        btnsubmit.Name = "btnsubmit"
        btnsubmit.Size = New Size(75, 23)
        btnsubmit.TabIndex = 10
        btnsubmit.Text = "Submit"
        btnsubmit.UseVisualStyleBackColor = True
        ' 
        ' Service
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Name = "Service"
        Text = "Service"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnsubmit As Button
    Friend WithEvents btnback As Button
    Friend WithEvents txtgategory As TextBox
    Friend WithEvents txtprice As TextBox
    Friend WithEvents txtduration As TextBox
    Friend WithEvents txtsName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
