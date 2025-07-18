<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        cmbFilterProduct = New ComboBox()
        btnLoadData = New Button()
        dgvSales = New DataGridView()
        Label1 = New Label()
        Label2 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        CType(dgvSales, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cmbFilterProduct
        ' 
        cmbFilterProduct.FormattingEnabled = True
        cmbFilterProduct.Location = New Point(626, 107)
        cmbFilterProduct.Name = "cmbFilterProduct"
        cmbFilterProduct.Size = New Size(121, 23)
        cmbFilterProduct.TabIndex = 1
        ' 
        ' btnLoadData
        ' 
        btnLoadData.BackColor = SystemColors.Info
        btnLoadData.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLoadData.Location = New Point(293, 123)
        btnLoadData.Name = "btnLoadData"
        btnLoadData.Size = New Size(218, 66)
        btnLoadData.TabIndex = 2
        btnLoadData.Text = "تحميل البيانات"
        btnLoadData.UseVisualStyleBackColor = False
        ' 
        ' dgvSales
        ' 
        dgvSales.AllowUserToAddRows = False
        dgvSales.AllowUserToDeleteRows = False
        dgvSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvSales.Location = New Point(0, 214)
        dgvSales.Name = "dgvSales"
        dgvSales.ReadOnly = True
        dgvSales.Size = New Size(800, 236)
        dgvSales.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(628, 72)
        Label1.Name = "Label1"
        Label1.Size = New Size(119, 32)
        Label1.TabIndex = 3
        Label1.Text = "اسم المنتج"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Stencil", 26.25F)
        Label2.ForeColor = SystemColors.WindowText
        Label2.Location = New Point(0, 62)
        Label2.Name = "Label2"
        Label2.Size = New Size(159, 42)
        Label2.TabIndex = 4
        Label2.Text = "Display"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Stencil", 26.25F)
        Label4.ForeColor = SystemColors.WindowText
        Label4.Location = New Point(0, 20)
        Label4.Name = "Label4"
        Label4.Size = New Size(106, 42)
        Label4.TabIndex = 6
        Label4.Text = "Data"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Stencil", 26.25F)
        Label3.ForeColor = SystemColors.WindowText
        Label3.Location = New Point(0, 104)
        Label3.Name = "Label3"
        Label3.Size = New Size(147, 42)
        Label3.TabIndex = 7
        Label3.Text = "Screen"
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSlateGray
        ClientSize = New Size(800, 450)
        Controls.Add(Label3)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnLoadData)
        Controls.Add(cmbFilterProduct)
        Controls.Add(dgvSales)
        Name = "Form3"
        Text = "عرض البيانات"
        CType(dgvSales, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents cmbFilterProduct As ComboBox
    Friend WithEvents btnLoadData As Button
    Friend WithEvents dgvSales As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
End Class
