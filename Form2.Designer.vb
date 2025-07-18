<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtProductName = New TextBox()
        txtQuantity = New TextBox()
        txtUnitPrice = New TextBox()
        Label4 = New Label()
        btnSave = New Button()
        dtSaleDate = New DateTimePicker()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.BackColor = SystemColors.Info
        Label1.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold)
        Label1.Location = New Point(167, 66)
        Label1.Name = "Label1"
        Label1.Size = New Size(356, 52)
        Label1.TabIndex = 0
        Label1.Text = "اسم المنتج"
        Label1.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label2
        ' 
        Label2.BackColor = SystemColors.Info
        Label2.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold)
        Label2.Location = New Point(167, 128)
        Label2.Name = "Label2"
        Label2.Size = New Size(356, 46)
        Label2.TabIndex = 1
        Label2.Text = "الكمية"
        Label2.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label3
        ' 
        Label3.BackColor = SystemColors.Info
        Label3.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold)
        Label3.Location = New Point(167, 192)
        Label3.Name = "Label3"
        Label3.Size = New Size(356, 45)
        Label3.TabIndex = 2
        Label3.Text = "السعر"
        Label3.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' txtProductName
        ' 
        txtProductName.Location = New Point(189, 83)
        txtProductName.Name = "txtProductName"
        txtProductName.Size = New Size(200, 23)
        txtProductName.TabIndex = 3
        ' 
        ' txtQuantity
        ' 
        txtQuantity.Location = New Point(189, 144)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(200, 23)
        txtQuantity.TabIndex = 4
        ' 
        ' txtUnitPrice
        ' 
        txtUnitPrice.Location = New Point(189, 203)
        txtUnitPrice.Name = "txtUnitPrice"
        txtUnitPrice.Size = New Size(200, 23)
        txtUnitPrice.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.BackColor = SystemColors.Info
        Label4.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold)
        Label4.Location = New Point(167, 255)
        Label4.Name = "Label4"
        Label4.Size = New Size(356, 44)
        Label4.TabIndex = 6
        Label4.Text = "التاريخ"
        Label4.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = SystemColors.Info
        btnSave.Font = New Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSave.Location = New Point(167, 327)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(356, 70)
        btnSave.TabIndex = 8
        btnSave.Text = "حفظ"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' dtSaleDate
        ' 
        dtSaleDate.Location = New Point(189, 267)
        dtSaleDate.Name = "dtSaleDate"
        dtSaleDate.Size = New Size(200, 23)
        dtSaleDate.TabIndex = 9
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSlateGray
        ClientSize = New Size(696, 450)
        Controls.Add(dtSaleDate)
        Controls.Add(btnSave)
        Controls.Add(Label4)
        Controls.Add(txtUnitPrice)
        Controls.Add(txtQuantity)
        Controls.Add(txtProductName)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form2"
        Text = "تسجيل عمليه بيع"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents txtUnitPrice As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents dtSaleDate As DateTimePicker

End Class
