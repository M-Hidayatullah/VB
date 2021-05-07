Public Class Form2
    Public nama, jenjang, jurusan As String
    Dim nilaiakhir, nilaikehadiran, nilaitugas, nilaiUTS, nilaiUAS As Integer
    Dim nilaihuruf, keterangan As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        nilaikehadiran = cbkehadiran.Text * 10 / 100
        nilaitugas = cbtugas.Text * 20 / 100
        nilaiUTS = cbuts.Text * 30 / 100
        nilaiUAS = cbuas.Text * 40 / 100

        nilaiakhir = nilaikehadiran + nilaitugas + nilaiUTS + nilaiUAS
        txtakhir.Text = nilaiakhir
        txthuruf.Text = nilaihuruf
        txtketerangan.Text = keterangan

        If nilaiakhir >= 85 Then
            txtketerangan.Text = "LULUS"
        ElseIf nilaiakhir >= 75 Then
            txthuruf.Text = "B"
            txtketerangan.Text = "LULUS"
        ElseIf nilaiakhir >= 60 Then
            txthuruf.Text = "C"
            txtketerangan.Text = "LULUS"
        ElseIf nilaiakhir >= 40 Then
            txthuruf.Text = "D"
            txtketerangan.Text = "GAGAL"
        ElseIf nilaiakhir >= 0 Then
            txthuruf.Text = "E"
            txtketerangan.Text = "GAGAL"
        End If
    End Sub

    Private Sub gbnim_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gbnim.SelectedIndexChanged
        Select Case gbnim.Text
            Case "1901021075"
                txtnama.Text = "Dinda Ayu"
                txtjenjang.Text = "S-1"
                txtjurusan.Text = "Teknik Informatika"
                gbnim.Focus()
                nama = "Dinda"
                jenjang = "S-1"
                jurusan = "Teknik Informatika"
            Case "1901021076"
                txtnama.Text = "Ade Irma Suriyani"
                txtjenjang.Text = "S-1"
                txtjurusan.Text = "Sistem Informasi"
                gbnim.Focus()
                nama = "Ade Irma Suriyani"
                jenjang = "S-1"
                jurusan = "Sistem Informasi"
            Case "1901021077"
                txtnama.Text = "Arya Doni"
                txtjenjang.Text = "D-3"
                txtjurusan.Text = "Manajemen Informatika"
                gbnim.Focus()
                nama = "Arya Doni"
                jenjang = "D-3"
                jurusan = "Manajemen informatika"
            Case "1901021078"
                txtnama.Text = "Abdul Muhaimi"
                txtjenjang.Text = "D-3"
                txtjurusan.Text = "Sistem Informasi"
                gbnim.Focus()
                nama = "Abdul Muhaimi"
                jenjang = "D-3"
                jurusan = "Sistem Informasi"
        End Select
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer
        i = 0
        While i <= 100
            cbkehadiran.Items.Add(i)
            cbtugas.Items.Add(i)
            cbuts.Items.Add(i)
            cbuas.Items.Add(i)
            i += 10
        End While

        ListView1.GridLines = True
        ListView1.View = View.Details
        ListView1.Columns.Add("NIM", 110)
        ListView1.Columns.Add("NAMA", 110)
        ListView1.Columns.Add("JURUSAN", 80)
        ListView1.Columns.Add("NILAI AKHIR", 80)
        ListView1.Columns.Add("KETERANGAN", 80)
        
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim x(7) As String
        x(0) = gbnim.Text
        x(1) = txtnama.Text
        x(2) = txtjurusan.Text
        x(3) = txtakhir.Text
        x(4) = txtketerangan.Text
       
        Dim tampilan As ListViewItem
        tampilan = ListView1.Items.Add(x(0))
        tampilan.SubItems.Add(x(1))
        tampilan.SubItems.Add(x(2))
        tampilan.SubItems.Add(x(3))
        tampilan.SubItems.Add(x(4))
      

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cbkehadiran.Text = ""
        cbtugas.Text = ""
        cbuts.Text = ""
        cbuas.Text = ""
        txtakhir.Text = ""
        txthuruf.Text = ""
        txtketerangan.Text = ""
        ListView1.ResetText()
        cbkehadiran.Focus()
    End Sub
End Class