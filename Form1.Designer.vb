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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DtTanggallahir = New System.Windows.Forms.DateTimePicker()
        Me.DtTanggalMasuk = New System.Windows.Forms.DateTimePicker()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.TxtTempatLahir = New System.Windows.Forms.TextBox()
        Me.TxtNoHP = New System.Windows.Forms.TextBox()
        Me.TxtAlamat = New System.Windows.Forms.TextBox()
        Me.CmdTambah = New System.Windows.Forms.Button()
        Me.CmdSimpan = New System.Windows.Forms.Button()
        Me.CmdBatal = New System.Windows.Forms.Button()
        Me.CmdUpdate = New System.Windows.Forms.Button()
        Me.CmdHapus = New System.Windows.Forms.Button()
        Me.DgTampil = New System.Windows.Forms.DataGridView()
        Me.CtKeluar = New System.Windows.Forms.Button()
        CType(Me.DgTampil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(73, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Karyawan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(73, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(73, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tempat Lahir"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(73, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tanggal lahir"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(73, 230)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "No HP"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(73, 269)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Alamat"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(73, 346)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Tanggal masuk"
        '
        'DtTanggallahir
        '
        Me.DtTanggallahir.Location = New System.Drawing.Point(212, 188)
        Me.DtTanggallahir.Name = "DtTanggallahir"
        Me.DtTanggallahir.Size = New System.Drawing.Size(200, 20)
        Me.DtTanggallahir.TabIndex = 7
        '
        'DtTanggalMasuk
        '
        Me.DtTanggalMasuk.Location = New System.Drawing.Point(212, 346)
        Me.DtTanggalMasuk.Name = "DtTanggalMasuk"
        Me.DtTanggalMasuk.Size = New System.Drawing.Size(200, 20)
        Me.DtTanggalMasuk.TabIndex = 8
        '
        'TxtId
        '
        Me.TxtId.Location = New System.Drawing.Point(212, 67)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(100, 20)
        Me.TxtId.TabIndex = 9
        '
        'TxtNama
        '
        Me.TxtNama.Location = New System.Drawing.Point(212, 110)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(200, 20)
        Me.TxtNama.TabIndex = 10
        '
        'TxtTempatLahir
        '
        Me.TxtTempatLahir.Location = New System.Drawing.Point(212, 145)
        Me.TxtTempatLahir.Name = "TxtTempatLahir"
        Me.TxtTempatLahir.Size = New System.Drawing.Size(200, 20)
        Me.TxtTempatLahir.TabIndex = 11
        '
        'TxtNoHP
        '
        Me.TxtNoHP.Location = New System.Drawing.Point(212, 227)
        Me.TxtNoHP.Name = "TxtNoHP"
        Me.TxtNoHP.Size = New System.Drawing.Size(200, 20)
        Me.TxtNoHP.TabIndex = 12
        '
        'TxtAlamat
        '
        Me.TxtAlamat.Location = New System.Drawing.Point(212, 269)
        Me.TxtAlamat.Name = "TxtAlamat"
        Me.TxtAlamat.Size = New System.Drawing.Size(424, 20)
        Me.TxtAlamat.TabIndex = 13
        '
        'CmdTambah
        '
        Me.CmdTambah.Location = New System.Drawing.Point(76, 403)
        Me.CmdTambah.Name = "CmdTambah"
        Me.CmdTambah.Size = New System.Drawing.Size(75, 23)
        Me.CmdTambah.TabIndex = 14
        Me.CmdTambah.Text = "Tambah"
        Me.CmdTambah.UseVisualStyleBackColor = True
        '
        'CmdSimpan
        '
        Me.CmdSimpan.Location = New System.Drawing.Point(183, 403)
        Me.CmdSimpan.Name = "CmdSimpan"
        Me.CmdSimpan.Size = New System.Drawing.Size(75, 23)
        Me.CmdSimpan.TabIndex = 15
        Me.CmdSimpan.Text = "Simpan"
        Me.CmdSimpan.UseVisualStyleBackColor = True
        '
        'CmdBatal
        '
        Me.CmdBatal.Location = New System.Drawing.Point(290, 403)
        Me.CmdBatal.Name = "CmdBatal"
        Me.CmdBatal.Size = New System.Drawing.Size(75, 23)
        Me.CmdBatal.TabIndex = 16
        Me.CmdBatal.Text = "Batal"
        Me.CmdBatal.UseVisualStyleBackColor = True
        '
        'CmdUpdate
        '
        Me.CmdUpdate.Location = New System.Drawing.Point(399, 403)
        Me.CmdUpdate.Name = "CmdUpdate"
        Me.CmdUpdate.Size = New System.Drawing.Size(75, 23)
        Me.CmdUpdate.TabIndex = 17
        Me.CmdUpdate.Text = "Update"
        Me.CmdUpdate.UseVisualStyleBackColor = True
        '
        'CmdHapus
        '
        Me.CmdHapus.Location = New System.Drawing.Point(500, 403)
        Me.CmdHapus.Name = "CmdHapus"
        Me.CmdHapus.Size = New System.Drawing.Size(75, 23)
        Me.CmdHapus.TabIndex = 18
        Me.CmdHapus.Text = "Hapus"
        Me.CmdHapus.UseVisualStyleBackColor = True
        '
        'DgTampil
        '
        Me.DgTampil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgTampil.Location = New System.Drawing.Point(76, 447)
        Me.DgTampil.Name = "DgTampil"
        Me.DgTampil.Size = New System.Drawing.Size(627, 150)
        Me.DgTampil.TabIndex = 19
        '
        'CtKeluar
        '
        Me.CtKeluar.Location = New System.Drawing.Point(601, 403)
        Me.CtKeluar.Name = "CtKeluar"
        Me.CtKeluar.Size = New System.Drawing.Size(75, 23)
        Me.CtKeluar.TabIndex = 20
        Me.CtKeluar.Text = "Keluar"
        Me.CtKeluar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 544)
        Me.Controls.Add(Me.CtKeluar)
        Me.Controls.Add(Me.DgTampil)
        Me.Controls.Add(Me.CmdHapus)
        Me.Controls.Add(Me.CmdUpdate)
        Me.Controls.Add(Me.CmdBatal)
        Me.Controls.Add(Me.CmdSimpan)
        Me.Controls.Add(Me.CmdTambah)
        Me.Controls.Add(Me.TxtAlamat)
        Me.Controls.Add(Me.TxtNoHP)
        Me.Controls.Add(Me.TxtTempatLahir)
        Me.Controls.Add(Me.TxtNama)
        Me.Controls.Add(Me.TxtId)
        Me.Controls.Add(Me.DtTanggalMasuk)
        Me.Controls.Add(Me.DtTanggallahir)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DgTampil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents DtTanggallahir As DateTimePicker
    Friend WithEvents DtTanggalMasuk As DateTimePicker
    Friend WithEvents TxtId As TextBox
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents TxtTempatLahir As TextBox
    Friend WithEvents TxtNoHP As TextBox
    Friend WithEvents TxtAlamat As TextBox
    Friend WithEvents CmdTambah As Button
    Friend WithEvents CmdSimpan As Button
    Friend WithEvents CmdBatal As Button
    Friend WithEvents CmdUpdate As Button
    Friend WithEvents CmdHapus As Button
    Friend WithEvents DgTampil As DataGridView
    Friend WithEvents CtKeluar As Button
End Class
