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
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Label1 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.Info
        Button1.Cursor = Cursors.Hand
        Button1.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold)
        Button1.Location = New Point(611, 170)
        Button1.Name = "Button1"
        Button1.Size = New Size(127, 103)
        Button1.TabIndex = 0
        Button1.Text = "عرض المبيعات"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.Info
        Button2.Cursor = Cursors.Hand
        Button2.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold)
        Button2.Location = New Point(611, 304)
        Button2.Name = "Button2"
        Button2.Size = New Size(127, 103)
        Button2.TabIndex = 1
        Button2.Text = "الاجماليات"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.Info
        Button3.Cursor = Cursors.Hand
        Button3.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold)
        Button3.Location = New Point(611, 41)
        Button3.Name = "Button3"
        Button3.Size = New Size(127, 103)
        Button3.TabIndex = 2
        Button3.Text = "تسجيل عمليه"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Stencil", 48F, FontStyle.Bold)
        Label1.Location = New Point(2, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(221, 76)
        Label1.TabIndex = 3
        Label1.Text = "Sales"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Stencil", 48F, FontStyle.Bold)
        Label3.Location = New Point(2, 161)
        Label3.Name = "Label3"
        Label3.Size = New Size(313, 76)
        Label3.TabIndex = 5
        Label3.Text = "Project"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Stencil", 48F, FontStyle.Bold)
        Label4.Location = New Point(2, 85)
        Label4.Name = "Label4"
        Label4.Size = New Size(462, 76)
        Label4.TabIndex = 6
        Label4.Text = "Management"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSlateGray
        ClientSize = New Size(800, 450)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "الشاشه الرئيسيه"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
