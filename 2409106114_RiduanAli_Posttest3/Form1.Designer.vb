<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
	Protected Overrides Sub Dispose(disposing As Boolean)
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
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		picProfile = New PictureBox()
		btnBrowse = New Button()
		lblNama = New Label()
		lblUmur = New Label()
		lblTglLahir = New Label()
		lblTelpon = New Label()
		lblAlamat = New Label()
		txtNama = New TextBox()
		txtUmur = New TextBox()
		txtTelp = New TextBox()
		txtAlamat = New TextBox()
		dtpLahir = New DateTimePicker()
		gbGender = New GroupBox()
		rbPerempuan = New RadioButton()
		rbLaki = New RadioButton()
		gbHobby = New GroupBox()
		chkHobi5 = New CheckBox()
		chkHobi4 = New CheckBox()
		chkHobi3 = New CheckBox()
		chkHobi2 = New CheckBox()
		chkHobi1 = New CheckBox()
		btnCetak = New Button()
		CType(picProfile, ComponentModel.ISupportInitialize).BeginInit()
		gbGender.SuspendLayout()
		gbHobby.SuspendLayout()
		SuspendLayout()
		' 
		' picProfile
		' 
		picProfile.Location = New Point(71, 54)
		picProfile.Name = "picProfile"
		picProfile.Size = New Size(257, 365)
		picProfile.TabIndex = 0
		picProfile.TabStop = False
		' 
		' btnBrowse
		' 
		btnBrowse.Location = New Point(134, 435)
		btnBrowse.Name = "btnBrowse"
		btnBrowse.Size = New Size(94, 29)
		btnBrowse.TabIndex = 1
		btnBrowse.Text = "Browse"
		btnBrowse.UseVisualStyleBackColor = True
		' 
		' lblNama
		' 
		lblNama.AutoSize = True
		lblNama.Location = New Point(343, 54)
		lblNama.Name = "lblNama"
		lblNama.Size = New Size(56, 20)
		lblNama.TabIndex = 2
		lblNama.Text = "Nama :"
		' 
		' lblUmur
		' 
		lblUmur.AutoSize = True
		lblUmur.Location = New Point(343, 96)
		lblUmur.Name = "lblUmur"
		lblUmur.Size = New Size(52, 20)
		lblUmur.TabIndex = 3
		lblUmur.Text = "Umur :"
		' 
		' lblTglLahir
		' 
		lblTglLahir.AutoSize = True
		lblTglLahir.Location = New Point(343, 146)
		lblTglLahir.Name = "lblTglLahir"
		lblTglLahir.Size = New Size(104, 20)
		lblTglLahir.TabIndex = 4
		lblTglLahir.Text = "Tanggal Lahir :"
		' 
		' lblTelpon
		' 
		lblTelpon.AutoSize = True
		lblTelpon.Location = New Point(343, 193)
		lblTelpon.Name = "lblTelpon"
		lblTelpon.Size = New Size(85, 20)
		lblTelpon.TabIndex = 5
		lblTelpon.Text = "No Telpon :"
		' 
		' lblAlamat
		' 
		lblAlamat.AutoSize = True
		lblAlamat.Location = New Point(343, 245)
		lblAlamat.Name = "lblAlamat"
		lblAlamat.Size = New Size(64, 20)
		lblAlamat.TabIndex = 6
		lblAlamat.Text = "Alamat :"
		' 
		' txtNama
		' 
		txtNama.Location = New Point(498, 51)
		txtNama.Name = "txtNama"
		txtNama.Size = New Size(125, 27)
		txtNama.TabIndex = 7
		' 
		' txtUmur
		' 
		txtUmur.Location = New Point(498, 89)
		txtUmur.Name = "txtUmur"
		txtUmur.Size = New Size(125, 27)
		txtUmur.TabIndex = 8
		' 
		' txtTelp
		' 
		txtTelp.Location = New Point(498, 186)
		txtTelp.Name = "txtTelp"
		txtTelp.Size = New Size(125, 27)
		txtTelp.TabIndex = 9
		' 
		' txtAlamat
		' 
		txtAlamat.Location = New Point(498, 242)
		txtAlamat.Name = "txtAlamat"
		txtAlamat.Size = New Size(125, 27)
		txtAlamat.TabIndex = 10
		' 
		' dtpLahir
		' 
		dtpLahir.Location = New Point(498, 141)
		dtpLahir.Name = "dtpLahir"
		dtpLahir.Size = New Size(250, 27)
		dtpLahir.TabIndex = 11
		' 
		' gbGender
		' 
		gbGender.Controls.Add(rbPerempuan)
		gbGender.Controls.Add(rbLaki)
		gbGender.Location = New Point(373, 294)
		gbGender.Name = "gbGender"
		gbGender.Size = New Size(260, 144)
		gbGender.TabIndex = 12
		gbGender.TabStop = False
		gbGender.Text = "Jenis Kelamin"
		' 
		' rbPerempuan
		' 
		rbPerempuan.AutoSize = True
		rbPerempuan.Location = New Point(35, 90)
		rbPerempuan.Name = "rbPerempuan"
		rbPerempuan.Size = New Size(104, 24)
		rbPerempuan.TabIndex = 1
		rbPerempuan.TabStop = True
		rbPerempuan.Text = "Perempuan"
		rbPerempuan.UseVisualStyleBackColor = True
		' 
		' rbLaki
		' 
		rbLaki.AutoSize = True
		rbLaki.Location = New Point(35, 42)
		rbLaki.Name = "rbLaki"
		rbLaki.Size = New Size(88, 24)
		rbLaki.TabIndex = 0
		rbLaki.TabStop = True
		rbLaki.Text = "Laki-Laki"
		rbLaki.UseVisualStyleBackColor = True
		' 
		' gbHobby
		' 
		gbHobby.Controls.Add(chkHobi5)
		gbHobby.Controls.Add(chkHobi4)
		gbHobby.Controls.Add(chkHobi3)
		gbHobby.Controls.Add(chkHobi2)
		gbHobby.Controls.Add(chkHobi1)
		gbHobby.Location = New Point(683, 294)
		gbHobby.Name = "gbHobby"
		gbHobby.Size = New Size(292, 183)
		gbHobby.TabIndex = 13
		gbHobby.TabStop = False
		gbHobby.Text = "Hobby"
		' 
		' chkHobi5
		' 
		chkHobi5.AutoSize = True
		chkHobi5.Location = New Point(49, 141)
		chkHobi5.Name = "chkHobi5"
		chkHobi5.Size = New Size(144, 24)
		chkHobi5.TabIndex = 4
		chkHobi5.Text = "Fans Real Madrid"
		chkHobi5.UseVisualStyleBackColor = True
		' 
		' chkHobi4
		' 
		chkHobi4.AutoSize = True
		chkHobi4.Location = New Point(159, 90)
		chkHobi4.Name = "chkHobi4"
		chkHobi4.Size = New Size(109, 24)
		chkHobi4.TabIndex = 3
		chkHobi4.Text = "Memancing"
		chkHobi4.UseVisualStyleBackColor = True
		' 
		' chkHobi3
		' 
		chkHobi3.AutoSize = True
		chkHobi3.Location = New Point(159, 42)
		chkHobi3.Name = "chkHobi3"
		chkHobi3.Size = New Size(85, 24)
		chkHobi3.TabIndex = 2
		chkHobi3.Text = "Balapan"
		chkHobi3.UseVisualStyleBackColor = True
		' 
		' chkHobi2
		' 
		chkHobi2.AutoSize = True
		chkHobi2.Location = New Point(6, 90)
		chkHobi2.Name = "chkHobi2"
		chkHobi2.Size = New Size(65, 24)
		chkHobi2.TabIndex = 1
		chkHobi2.Text = "Tidur"
		chkHobi2.UseVisualStyleBackColor = True
		' 
		' chkHobi1
		' 
		chkHobi1.AutoSize = True
		chkHobi1.Location = New Point(6, 42)
		chkHobi1.Name = "chkHobi1"
		chkHobi1.Size = New Size(83, 24)
		chkHobi1.TabIndex = 0
		chkHobi1.Text = "Gaming"
		chkHobi1.UseVisualStyleBackColor = True
		' 
		' btnCetak
		' 
		btnCetak.Location = New Point(343, 484)
		btnCetak.Name = "btnCetak"
		btnCetak.Size = New Size(632, 29)
		btnCetak.TabIndex = 14
		btnCetak.Text = "Cetak Kartu"
		btnCetak.UseVisualStyleBackColor = True
		' 
		' Form1
		' 
		AutoScaleDimensions = New SizeF(8F, 20F)
		AutoScaleMode = AutoScaleMode.Font
		ClientSize = New Size(999, 555)
		Controls.Add(btnCetak)
		Controls.Add(gbHobby)
		Controls.Add(gbGender)
		Controls.Add(dtpLahir)
		Controls.Add(txtAlamat)
		Controls.Add(txtTelp)
		Controls.Add(txtUmur)
		Controls.Add(txtNama)
		Controls.Add(lblAlamat)
		Controls.Add(lblTelpon)
		Controls.Add(lblTglLahir)
		Controls.Add(lblUmur)
		Controls.Add(lblNama)
		Controls.Add(btnBrowse)
		Controls.Add(picProfile)
		Name = "Form1"
		Text = "Form1"
		CType(picProfile, ComponentModel.ISupportInitialize).EndInit()
		gbGender.ResumeLayout(False)
		gbGender.PerformLayout()
		gbHobby.ResumeLayout(False)
		gbHobby.PerformLayout()
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents picProfile As PictureBox
	Friend WithEvents btnBrowse As Button
	Friend WithEvents lblNama As Label
	Friend WithEvents lblUmur As Label
	Friend WithEvents lblTglLahir As Label
	Friend WithEvents lblTelpon As Label
	Friend WithEvents lblAlamat As Label
	Friend WithEvents txtNama As TextBox
	Friend WithEvents txtUmur As TextBox
	Friend WithEvents txtTelp As TextBox
	Friend WithEvents txtAlamat As TextBox
	Friend WithEvents dtpLahir As DateTimePicker
	Friend WithEvents gbGender As GroupBox
	Friend WithEvents rbPerempuan As RadioButton
	Friend WithEvents rbLaki As RadioButton
	Friend WithEvents gbHobby As GroupBox
	Friend WithEvents chkHobi5 As CheckBox
	Friend WithEvents chkHobi4 As CheckBox
	Friend WithEvents chkHobi3 As CheckBox
	Friend WithEvents chkHobi2 As CheckBox
	Friend WithEvents chkHobi1 As CheckBox
	Friend WithEvents btnCetak As Button

End Class
