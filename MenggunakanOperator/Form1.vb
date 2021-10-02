Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim value1 As Double = TextBox1.Text
        Dim value2 As Double = TextBox2.Text
        MessageBox.Show("Hasil Penjumlahan adalah : " + (value1 + value2).ToString())
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim value1 As Double = TextBox1.Text
        Dim value2 As Double = TextBox2.Text
        MessageBox.Show("Hasil Pengurangan adalah : " + (value1 - value2).ToString())
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim value1 As Double = TextBox1.Text
        Dim value2 As Double = TextBox2.Text
        MessageBox.Show("Hasil Perkalian adalah : " + (value1 * value2).ToString())
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim value1 As Double = TextBox1.Text
        Dim value2 As Double = TextBox2.Text
        MessageBox.Show("Hasil Pembagian adalah : " + (value1 / value2).ToString())
    End Sub

End Class
