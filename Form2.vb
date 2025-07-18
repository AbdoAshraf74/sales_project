Imports System.Data.SqlClient

Public Class Form2
    Dim con As New SqlConnection("Data Source=.;Initial Catalog=SalesDB;Integrated Security=True")

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim cmd As New SqlCommand("INSERT INTO Sales (ProductName, Quantity, UnitPrice, SaleDate) VALUES (@name, @qty, @price, @date)", con)

            cmd.Parameters.AddWithValue("@name", txtProductName.Text)
            cmd.Parameters.AddWithValue("@qty", CInt(txtQuantity.Text))
            cmd.Parameters.AddWithValue("@price", CDec(txtUnitPrice.Text))
            cmd.Parameters.AddWithValue("@date", dtSaleDate.Value.Date)

            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()

            MessageBox.Show("تم حفظ البيع بنجاح")
        Catch ex As Exception
            MessageBox.Show("خطأ: " & ex.Message)
            con.Close()
        End Try
    End Sub
End Class
