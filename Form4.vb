Imports System.Data.SqlClient

Public Class Form4

    Dim con As New SqlConnection("Data Source=.;Initial Catalog=SalesDB;Integrated Security=True")

    Private Sub btnLoadSummary_Click(sender As Object, e As EventArgs) Handles btnLoadSummary.Click
        Try
            Dim query As String = "SELECT COUNT(*) AS CountSales, SUM(Quantity * UnitPrice) AS TotalRevenue, MAX(Quantity * UnitPrice) AS MaxSale FROM Sales WHERE SaleDate BETWEEN @from AND @to"

            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@from", dtFrom.Value.Date)
            cmd.Parameters.AddWithValue("@to", dtTo.Value.Date)

            con.Open()
            Dim reader = cmd.ExecuteReader()
            If reader.Read() Then
                lblCount.Text = reader("CountSales").ToString()
                lblTotal.Text = reader("TotalRevenue").ToString()
                lblMax.Text = reader("MaxSale").ToString()
            End If
            reader.Close()
            con.Close()

        Catch ex As Exception
            MessageBox.Show("خطأ في الإحصائيات: " & ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub lblMax_Click(sender As Object, e As EventArgs) Handles lblMax.Click

    End Sub

    Private Sub lblCount_Click(sender As Object, e As EventArgs) Handles lblCount.Click

    End Sub
End Class