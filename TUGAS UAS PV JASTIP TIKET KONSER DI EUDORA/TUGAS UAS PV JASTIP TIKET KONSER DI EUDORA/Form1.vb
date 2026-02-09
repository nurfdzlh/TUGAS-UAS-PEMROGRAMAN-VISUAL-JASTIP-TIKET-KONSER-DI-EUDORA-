Imports System.IO

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Text = "Jastip Tiket Konser"

        lblJudul.Text = "JASTIP TIKET KONSER DI EUDORA"
        lblJudul.Font = New Font("Segoe UI", 16, FontStyle.Bold)
        lblJudul.ForeColor = Color.MidnightBlue

        btnBaca.BackColor = Color.AliceBlue
        btnBaca.ForeColor = Color.MidnightBlue

        lblInfo.Font = New Font("Segoe UI", 14, FontStyle.Bold)
        lblInfo.ForeColor = Color.MidnightBlue

        With dgvJastip
            .Columns.Clear()
            .Columns.Add("nama", "Nama Pemesan")
            .Columns.Add("jumlah", "Jumlah Tiket")
            .Columns.Add("harga", "Harga")
            .Columns.Add("total", "Total Bayar")
            .Columns.Add("diskon", "Keterangan")

            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .ReadOnly = True
            .AllowUserToAddRows = False
            .BorderStyle = BorderStyle.None

            .EnableHeadersVisualStyles = False
            .ColumnHeadersDefaultCellStyle.BackColor = Color.AliceBlue
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.MidnightBlue
            .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 12, FontStyle.Bold)

            .DefaultCellStyle.Font = New Font("Segoe UI", 10)
            .DefaultCellStyle.SelectionBackColor = Color.SteelBlue
            .DefaultCellStyle.SelectionForeColor = Color.Black

            .AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue

            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With

    End Sub


    Private Sub btnBaca_Click(sender As Object, e As EventArgs) Handles btnBaca.Click

        Dim ofd As New OpenFileDialog
        ofd.Filter = "Text File|*.txt"

        If ofd.ShowDialog() = DialogResult.OK Then

            Dim baris() As String = File.ReadAllLines(ofd.FileName)

            ProsesJastip(baris)

        End If

    End Sub


    Sub ProsesJastip(data() As String)

        Dim totalTransaksi As Integer = 0

        dgvJastip.Rows.Clear()

        For i As Integer = 0 To data.Length - 1

            Dim pecah() As String = data(i).Split(",")

            Dim nama As String = pecah(0)
            Dim jumlah As Integer = Convert.ToInt32(pecah(1))
            Dim harga As Integer = Convert.ToInt32(pecah(2))

            Dim total As Integer = jumlah * harga
            Dim infoDiskon As String = "Tidak ada diskon"

            If jumlah >= 5 Then
                total = total - 10000
                infoDiskon = "Diskon jastip"
            End If

            totalTransaksi += total

            dgvJastip.Rows.Add(
                nama,
                jumlah,
                FormatRupiah(harga),
                FormatRupiah(total),
                infoDiskon
            )

        Next

        lblInfo.Text = "Total seluruh transaksi : " & FormatRupiah(totalTransaksi)
        lblInfo.Font = New Font("Segoe UI", 11, FontStyle.Bold)
        lblInfo.ForeColor = Color.MidnightBlue

    End Sub


    Function FormatRupiah(angka As Integer) As String
        Return "Rp " & angka.ToString("N0")
    End Function

End Class

