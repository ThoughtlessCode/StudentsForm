<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnStore = New System.Windows.Forms.Button()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.txtDoB = New System.Windows.Forms.TextBox()
        Me.txtCourse = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.lstDetails = New System.Windows.Forms.ListBox()
        Me.BTN_Search = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnStore
        '
        Me.btnStore.Location = New System.Drawing.Point(338, 35)
        Me.btnStore.Name = "btnStore"
        Me.btnStore.Size = New System.Drawing.Size(201, 88)
        Me.btnStore.TabIndex = 0
        Me.btnStore.Text = "Store Details"
        Me.btnStore.UseVisualStyleBackColor = True
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(338, 171)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(201, 85)
        Me.btnDisplay.TabIndex = 1
        Me.btnDisplay.Text = "Display All Details"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'txtDoB
        '
        Me.txtDoB.Location = New System.Drawing.Point(143, 201)
        Me.txtDoB.Name = "txtDoB"
        Me.txtDoB.Size = New System.Drawing.Size(153, 22)
        Me.txtDoB.TabIndex = 3
        '
        'txtCourse
        '
        Me.txtCourse.Location = New System.Drawing.Point(143, 158)
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.Size = New System.Drawing.Size(153, 22)
        Me.txtCourse.TabIndex = 4
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(143, 112)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(153, 22)
        Me.txtPhone.TabIndex = 5
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(143, 68)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(153, 22)
        Me.txtAddress.TabIndex = 6
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(143, 26)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(153, 22)
        Me.txtName.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 17)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Name"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 163)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Course"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Phone Number"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 17)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Address"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 206)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 17)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Date of Birth"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblMessage.Location = New System.Drawing.Point(385, 135)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(51, 17)
        Me.lblMessage.TabIndex = 13
        Me.lblMessage.Text = "Label6"
        '
        'lstDetails
        '
        Me.lstDetails.FormattingEnabled = True
        Me.lstDetails.ItemHeight = 16
        Me.lstDetails.Location = New System.Drawing.Point(15, 306)
        Me.lstDetails.Name = "lstDetails"
        Me.lstDetails.Size = New System.Drawing.Size(1559, 420)
        Me.lstDetails.TabIndex = 14
        '
        'BTN_Search
        '
        Me.BTN_Search.Location = New System.Drawing.Point(610, 99)
        Me.BTN_Search.Name = "BTN_Search"
        Me.BTN_Search.Size = New System.Drawing.Size(201, 88)
        Me.BTN_Search.TabIndex = 15
        Me.BTN_Search.Text = "Search"
        Me.BTN_Search.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1902, 1033)
        Me.Controls.Add(Me.BTN_Search)
        Me.Controls.Add(Me.lstDetails)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtCourse)
        Me.Controls.Add(Me.txtDoB)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.btnStore)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnStore As Button
    Friend WithEvents btnDisplay As Button
    Friend WithEvents txtDoB As TextBox
    Friend WithEvents txtCourse As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblMessage As Label

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Friend WithEvents lstDetails As ListBox
    Friend WithEvents BTN_Search As Button
End Class
