<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        lblCount = New Label()
        lblMax = New Label()
        lblTotal = New Label()
        dtFrom = New DateTimePicker()
        dtTo = New DateTimePicker()
        Label4 = New Label()
        Label5 = New Label()
        btnLoadSummary = New Button()
        SuspendLayout()
        ' 
        ' label1
        ' 
        label1.AutoSize = True
        label1.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold)
        label1.Location = New Point(258, 375)
        label1.Name = "label1"
        label1.Size = New Size(145, 32)
        label1.TabIndex = 0
        label1.Text = "عدد المبيعات"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold)
        Label2.Location = New Point(307, 257)
        Label2.Name = "Label2"
        Label2.Size = New Size(96, 32)
        Label2.TabIndex = 1
        Label2.Text = "الاجمالي"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold)
        Label3.Location = New Point(327, 321)
        Label3.Name = "Label3"
        Label3.Size = New Size(76, 32)
        Label3.TabIndex = 3
        Label3.Text = "الاعلي"
        ' 
        ' lblCount
        ' 
        lblCount.AutoSize = True
        lblCount.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold)
        lblCount.Location = New Point(444, 375)
        lblCount.Name = "lblCount"
        lblCount.Size = New Size(0, 32)
        lblCount.TabIndex = 2
        ' 
        ' lblMax
        ' 
        lblMax.AutoSize = True
        lblMax.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold)
        lblMax.Location = New Point(444, 321)
        lblMax.Name = "lblMax"
        lblMax.Size = New Size(0, 32)
        lblMax.TabIndex = 5
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold)
        lblTotal.Location = New Point(444, 257)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(0, 32)
        lblTotal.TabIndex = 4
        ' 
        ' dtFrom
        ' 
        dtFrom.Location = New Point(164, 109)
        dtFrom.Name = "dtFrom"
        dtFrom.Size = New Size(194, 23)
        dtFrom.TabIndex = 6
        ' 
        ' dtTo
        ' 
        dtTo.Location = New Point(467, 109)
        dtTo.Name = "dtTo"
        dtTo.Size = New Size(200, 23)
        dtTo.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(164, 81)
        Label4.Name = "Label4"
        Label4.Size = New Size(64, 25)
        Label4.TabIndex = 8
        Label4.Text = "From:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(467, 81)
        Label5.Name = "Label5"
        Label5.Size = New Size(38, 25)
        Label5.TabIndex = 9
        Label5.Text = "To:"
        ' 
        ' btnLoadSummary
        ' 
        btnLoadSummary.BackColor = SystemColors.Info
        btnLoadSummary.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLoadSummary.Location = New Point(357, 172)
        btnLoadSummary.Name = "btnLoadSummary"
        btnLoadSummary.Size = New Size(106, 40)
        btnLoadSummary.TabIndex = 11
        btnLoadSummary.Text = "تحميل الملخص"
        btnLoadSummary.UseVisualStyleBackColor = False
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSlateGray
        ClientSize = New Size(800, 450)
        Controls.Add(btnLoadSummary)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(dtTo)
        Controls.Add(dtFrom)
        Controls.Add(lblMax)
        Controls.Add(lblTotal)
        Controls.Add(Label3)
        Controls.Add(lblCount)
        Controls.Add(Label2)
        Controls.Add(label1)
        Name = "Form4"
        Text = "الاجماليات"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblCount As Label
    Friend WithEvents lblMax As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents dtFrom As DateTimePicker
    Friend WithEvents dtTo As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnLoadSummary As Button
End Class
