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
		chkHobi6 = New CheckBox()
		chkHobi10 = New CheckBox()
		chkHobi9 = New CheckBox()
		chkHobi8 = New CheckBox()
		chkHobi7 = New CheckBox()
		chkHobi4 = New CheckBox()
		chkHobi3 = New CheckBox()
		chkHobi2 = New CheckBox()
		chkHobi1 = New CheckBox()
		chkHobi5 = New CheckBox()
		btnCetak = New Button()
		CType(picProfile, ComponentModel.ISupportInitialize).BeginInit()
		gbGender.SuspendLayout()
		gbHobby.SuspendLayout()
		SuspendLayout()
		' 
		' picProfile
		' 
		picProfile.BackColor = Color.Transparent
		picProfile.Location = New Point(71, 54)
		picProfile.Name = "picProfile"
		picProfile.Size = New Size(257, 365)
		picProfile.TabIndex = 0
		picProfile.TabStop = False
		' 
		' btnBrowse
		' 
		btnBrowse.BackColor = Color.Transparent
		btnBrowse.Location = New Point(134, 435)
		btnBrowse.Name = "btnBrowse"
		btnBrowse.Size = New Size(94, 29)
		btnBrowse.TabIndex = 1
		btnBrowse.Text = "Browse"
		btnBrowse.UseVisualStyleBackColor = False
		' 
		' lblNama
		' 
		lblNama.AutoSize = True
		lblNama.BackColor = Color.Transparent
		lblNama.Location = New Point(343, 54)
		lblNama.Name = "lblNama"
		lblNama.Size = New Size(56, 20)
		lblNama.TabIndex = 2
		lblNama.Text = "Nama :"
		' 
		' lblUmur
		' 
		lblUmur.AutoSize = True
		lblUmur.BackColor = Color.Transparent
		lblUmur.Location = New Point(343, 96)
		lblUmur.Name = "lblUmur"
		lblUmur.Size = New Size(52, 20)
		lblUmur.TabIndex = 3
		lblUmur.Text = "Umur :"
		' 
		' lblTglLahir
		' 
		lblTglLahir.AutoSize = True
		lblTglLahir.BackColor = Color.Transparent
		lblTglLahir.Location = New Point(343, 146)
		lblTglLahir.Name = "lblTglLahir"
		lblTglLahir.Size = New Size(104, 20)
		lblTglLahir.TabIndex = 4
		lblTglLahir.Text = "Tanggal Lahir :"
		' 
		' lblTelpon
		' 
		lblTelpon.AutoSize = True
		lblTelpon.BackColor = Color.Transparent
		lblTelpon.Location = New Point(343, 193)
		lblTelpon.Name = "lblTelpon"
		lblTelpon.Size = New Size(85, 20)
		lblTelpon.TabIndex = 5
		lblTelpon.Text = "No Telpon :"
		' 
		' lblAlamat
		' 
		lblAlamat.AutoSize = True
		lblAlamat.BackColor = Color.Transparent
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
		gbGender.BackColor = Color.Transparent
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
		gbHobby.BackColor = Color.Transparent
		gbHobby.Controls.Add(chkHobi6)
		gbHobby.Controls.Add(chkHobi10)
		gbHobby.Controls.Add(chkHobi9)
		gbHobby.Controls.Add(chkHobi8)
		gbHobby.Controls.Add(chkHobi7)
		gbHobby.Controls.Add(chkHobi4)
		gbHobby.Controls.Add(chkHobi3)
		gbHobby.Controls.Add(chkHobi2)
		gbHobby.Controls.Add(chkHobi1)
		gbHobby.Controls.Add(chkHobi5)
		gbHobby.Location = New Point(683, 294)
		gbHobby.Name = "gbHobby"
		gbHobby.Size = New Size(304, 197)
		gbHobby.TabIndex = 13
		gbHobby.TabStop = False
		gbHobby.Text = "Hobby"
		' 
		' chkHobi6
		' 
		chkHobi6.AutoSize = True
		chkHobi6.Location = New Point(159, 86)
		chkHobi6.Name = "chkHobi6"
		chkHobi6.Size = New Size(55, 24)
		chkHobi6.TabIndex = 9
		chkHobi6.Text = "Lari"
		chkHobi6.UseVisualStyleBackColor = True
		' 
		' chkHobi10
		' 
		chkHobi10.AutoSize = True
		chkHobi10.Location = New Point(159, 150)
		chkHobi10.Name = "chkHobi10"
		chkHobi10.Size = New Size(69, 24)
		chkHobi10.TabIndex = 8
		chkHobi10.Text = "Decul"
		chkHobi10.UseVisualStyleBackColor = True
		' 
		' chkHobi9
		' 
		chkHobi9.AutoSize = True
		chkHobi9.Location = New Point(6, 150)
		chkHobi9.Name = "chkHobi9"
		chkHobi9.Size = New Size(103, 24)
		chkHobi9.TabIndex = 7
		chkHobi9.Text = "Jalan-Jalan"
		chkHobi9.UseVisualStyleBackColor = True
		' 
		' chkHobi8
		' 
		chkHobi8.AutoSize = True
		chkHobi8.Location = New Point(159, 120)
		chkHobi8.Name = "chkHobi8"
		chkHobi8.Size = New Size(75, 24)
		chkHobi8.TabIndex = 6
		chkHobi8.Text = "Makan"
		chkHobi8.UseVisualStyleBackColor = True
		' 
		' chkHobi7
		' 
		chkHobi7.AutoSize = True
		chkHobi7.Location = New Point(6, 120)
		chkHobi7.Name = "chkHobi7"
		chkHobi7.Size = New Size(73, 24)
		chkHobi7.TabIndex = 5
		chkHobi7.Text = "Masak"
		chkHobi7.UseVisualStyleBackColor = True
		' 
		' chkHobi4
		' 
		chkHobi4.AutoSize = True
		chkHobi4.Location = New Point(159, 56)
		chkHobi4.Name = "chkHobi4"
		chkHobi4.Size = New Size(109, 24)
		chkHobi4.TabIndex = 3
		chkHobi4.Text = "Memancing"
		chkHobi4.UseVisualStyleBackColor = True
		' 
		' chkHobi3
		' 
		chkHobi3.AutoSize = True
		chkHobi3.Location = New Point(159, 26)
		chkHobi3.Name = "chkHobi3"
		chkHobi3.Size = New Size(85, 24)
		chkHobi3.TabIndex = 2
		chkHobi3.Text = "Balapan"
		chkHobi3.UseVisualStyleBackColor = True
		' 
		' chkHobi2
		' 
		chkHobi2.AutoSize = True
		chkHobi2.Location = New Point(6, 56)
		chkHobi2.Name = "chkHobi2"
		chkHobi2.Size = New Size(65, 24)
		chkHobi2.TabIndex = 1
		chkHobi2.Text = "Tidur"
		chkHobi2.UseVisualStyleBackColor = True
		' 
		' chkHobi1
		' 
		chkHobi1.AutoSize = True
		chkHobi1.Location = New Point(6, 26)
		chkHobi1.Name = "chkHobi1"
		chkHobi1.Size = New Size(83, 24)
		chkHobi1.TabIndex = 0
		chkHobi1.Text = "Gaming"
		chkHobi1.UseVisualStyleBackColor = True
		' 
		' chkHobi5
		' 
		chkHobi5.AutoSize = True
		chkHobi5.Location = New Point(6, 86)
		chkHobi5.Name = "chkHobi5"
		chkHobi5.Size = New Size(144, 24)
		chkHobi5.TabIndex = 4
		chkHobi5.Text = "Fans Real Madrid"
		chkHobi5.UseVisualStyleBackColor = True
		' 
		' btnCetak
		' 
		btnCetak.BackColor = Color.Transparent
		btnCetak.Location = New Point(285, 497)
		btnCetak.Name = "btnCetak"
		btnCetak.Size = New Size(632, 29)
		btnCetak.TabIndex = 14
		btnCetak.Text = "Cetak Kartu"
		btnCetak.UseVisualStyleBackColor = False
		' 
		' Form1
		' 
		AutoScaleDimensions = New SizeF(8.0F, 20.0F)
		AutoScaleMode = AutoScaleMode.Font
		BackColor = Color.Moccasin
		BackgroundImage = My.Resources.Resources.Real_Madrid_symbol
		BackgroundImageLayout = ImageLayout.Stretch
		ClientSize = New Size(1128, 597)
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
		DoubleBuffered = True
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
	Friend WithEvents btnCetak As Button
	Friend WithEvents chkHobi1 As CheckBox
	Friend WithEvents chkHobi2 As CheckBox
	Friend WithEvents chkHobi3 As CheckBox
	Friend WithEvents chkHobi4 As CheckBox
	Friend WithEvents chkHobi5 As CheckBox
	Friend WithEvents chkHobi6 As CheckBox
	Friend WithEvents chkHobi7 As CheckBox
	Friend WithEvents chkHobi8 As CheckBox
	Friend WithEvents chkHobi9 As CheckBox
	Friend WithEvents chkHobi10 As CheckBox

End Class

