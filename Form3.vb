
Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting


Public Class Form3
    Dim con As New SqlConnection("Data Source=.;Initial Catalog=SalesDB;Integrated Security=True")

    Private Sub btnLoadData_Click(sender As Object, e As EventArgs) Handles btnLoadData.Click
        Try
            Dim query As String = "SELECT * FROM Sales"

            ' فلترة حسب المنتج لو اختير من ComboBox
            If cmbFilterProduct.Text <> "" Then
                query &= " WHERE ProductName = @name"
            End If

            Dim cmd As New SqlCommand(query, con)
            If cmbFilterProduct.Text <> "" Then
                cmd.Parameters.AddWithValue("@name", cmbFilterProduct.Text)
            End If

            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)
            dgvSales.DataSource = dt


        Catch ex As Exception
            MessageBox.Show("خطأ في تحميل البيانات: " & ex.Message)
        End Try
    End Sub
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cmd As New SqlCommand("SELECT DISTINCT ProductName FROM Sales", con)
        con.Open()
        Dim reader = cmd.ExecuteReader()
        While reader.Read()
            cmbFilterProduct.Items.Add(reader("ProductName").ToString())
        End While
        reader.Close()
        con.Close()
    End Sub

    Private Sub dgvSales_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSales.CellContentClick

    End Sub

    Private Sub cmbFilterProduct_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFilterProduct.SelectedIndexChanged

    End Sub
End Class