Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Nama Anda Adalah : " + TextBox1.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MessageBox.Show("Nama Anda Adalah : " + TextBox1.Text, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
