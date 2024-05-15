Imports MySql.Data.MySqlClient
Public Class Form1
    Dim strkon As String = "server=localhost;uid=root;database=quiz_UTS_2321012"
    Dim kon As New MySqlConnection(strkon)
    Dim perintah As New MySqlCommand
    Dim mda As New MySqlDataAdapter
    Dim ds As New DataSet
    Dim cek As MySqlDataReader


    Sub tidakaktif()
        TxtId.Enabled = False
        TxtNama.Enabled = False
        TxtTempatLahir.Enabled = False
        DtTanggallahir.Enabled = False
        TxtNoHP.Enabled = False
        TxtAlamat.Enabled = False
        DtTanggalMasuk.Enabled = False

        TxtId.BackColor = Color.Gray
        TxtNama.BackColor = Color.Gray
        TxtTempatLahir.BackColor = Color.Gray
        DtTanggallahir.BackColor = Color.Gray
        TxtNoHP.BackColor = Color.Gray
        TxtAlamat.BackColor = Color.Gray
        DtTanggalMasuk.BackColor = Color.Gray

        CmdSimpan.Enabled = False
        CmdBatal.Enabled = False
        CmdHapus.Enabled = False
        CmdUpdate.Enabled = False
    End Sub

    Sub aktif()
        TxtId.Enabled = True
        TxtNama.Enabled = True
        TxtTempatLahir.Enabled = True
        DtTanggallahir.Enabled = True
        TxtNoHP.Enabled = True
        TxtAlamat.Enabled = True
        DtTanggalMasuk.Enabled = True

        TxtId.BackColor = Color.White
        TxtNama.BackColor = Color.White
        TxtTempatLahir.BackColor = Color.White
        DtTanggallahir.BackColor = Color.White
        TxtNoHP.BackColor = Color.White
        TxtAlamat.BackColor = Color.White
        DtTanggalMasuk.BackColor = Color.White

        CmdSimpan.Enabled = True
        CmdBatal.Enabled = True
        CmdHapus.Enabled = True
        CmdUpdate.Enabled = True
    End Sub

    Sub bersih()
        TxtId.Text = ""
        TxtNama.Text = ""
        TxtTempatLahir.Text = ""
        DtTanggallahir.Text = ""
        TxtNoHP.Text = ""
        TxtAlamat.Text = ""
        DtTanggalMasuk.Text = ""

    End Sub

    Sub tampil()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select * from data"
        mda.SelectCommand = perintah
        ds.Tables.Clear()
        mda.Fill(ds, "data")
        DgTampil.DataSource = ds.Tables("data")
        kon.Close()
    End Sub

    Private Sub TxtId_TextChanged(sender As Object, e As KeyEventArgs) Handles TxtId.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                kon.Open()
                perintah.Connection = kon
                perintah.CommandType = CommandType.Text
                perintah.CommandText = "select * from data " &
                " where Id='" & TxtId.Text & "'"
                cek = perintah.ExecuteReader
                cek.Read()
                MsgBox("data sudah ada...!", MsgBoxStyle.Information, "Pesan")
                If cek.HasRows Then
                    TxtNama.Text = cek.Item("Nama")
                    TxtTempatLahir.Text = cek.Item("Tempatlahir")
                    DtTanggallahir.Value = cek.Item("Tanggallahir")
                    TxtNoHP.Text = cek.Item("NoHP")
                    TxtAlamat.Text = cek.Item("Alamat")
                    DtTanggalMasuk.Value = cek.Item("Tanggalmasuk")
                    CmdSimpan.Enabled = False
                End If
                kon.Close()
                ' tidakaktif()
                CmdTambah.Enabled = True
        End Select
    End Sub

    Private Sub CmdTambah_Click(sender As Object, e As EventArgs) Handles CmdTambah.Click
        aktif()
        TxtId.Focus()
        CmdTambah.Enabled = False
    End Sub

    Private Sub CmdSimpan_Click(sender As Object, e As EventArgs) Handles CmdSimpan.Click
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "insert into data values " &
        " ('" & TxtId.Text & "', '" & TxtNama.Text & "', " &
        " '" & TxtTempatLahir.Text & "',  '" & Format(DtTanggallahir.Value, "yyyy-MM-dd") & "', " &
        " '" & TxtNoHP.Text & "','" & TxtAlamat.Text & "', " &
        " '" & Format(DtTanggalMasuk.Value, "yyyy-MM-dd") & "')"
        perintah.ExecuteNonQuery()
        kon.Close()
        MsgBox("data berhasil disimpan", MsgBoxStyle.Information, "Pesan")
        tampil()
        bersih()
        tidakaktif()
        CmdTambah.Enabled = True
    End Sub

    Private Sub CmdBatal_Click(sender As Object, e As EventArgs) Handles CmdBatal.Click
        tidakaktif()
        CmdTambah.Enabled = True
        bersih()
    End Sub

    Private Sub CmdUpdate_Click(sender As Object, e As EventArgs) Handles CmdUpdate.Click
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "Update data set nama =  '" & TxtNama.Text & "' ,
        TempatLahir = '" & TxtTempatLahir.Text & "',
        TanggalLahir = '" & Format(DtTanggallahir.Value, "yyyy-MM-dd") & "',
        NoHP = '" & TxtNoHP.Text & "',
        Alamat = '" & TxtAlamat.Text & "',
        TanggalMasuk = '" & Format(DtTanggalMasuk.Value, "yyyy-MM-dd") & "' where Id ='" & TxtId.Text & "'"
        perintah.ExecuteNonQuery()
        kon.Close()
        tampil()
        bersih()
        tidakaktif()
    End Sub

    Private Sub CmdHapus_Click(sender As Object, e As EventArgs) Handles CmdHapus.Click
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "delete from data where Id='" & TxtId.Text & "'"
        perintah.ExecuteNonQuery()
        kon.Close()
        tampil()
        bersih()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tidakaktif()
        bersih()
        tampil()
    End Sub

    Private Sub CtKeluar_Click(sender As Object, e As EventArgs) Handles CtKeluar.Click
        Me.Close()
    End Sub

    Private Sub DgTampil_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgTampil.CellContentClick

    End Sub
End Class
