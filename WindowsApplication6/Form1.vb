Public Class Form1

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        If txtname.Text = "admin" And txtpassword.Text = "admin" Then
            Form2.Show()
        Else
            MessageBox.Show("Password yang anda masukan salah",
                            "judul", MessageBoxButtons.OK,
                               MessageBoxIcon.Information)
        End If
    End Sub
End Class
