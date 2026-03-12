Public Class Form1
	Public Sub HanyaAngka(sender As Object, e As KeyPressEventArgs)
		If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
			e.Handled = False
		Else
			e.Handled = True
		End If
	End Sub

	Public Sub HanyaHuruf(sender As Object, e As KeyPressEventArgs)
		If Char.IsLetter(e.KeyChar) OrElse Char.IsWhiteSpace(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
			e.Handled = False
		Else
			e.Handled = True
		End If
	End Sub

	Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
		HanyaHuruf(sender, e)
	End Sub

	Private Sub txtUmur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUmur.KeyPress
		HanyaAngka(sender, e)
	End Sub

	Private Sub txtTelp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelp.KeyPress
		HanyaAngka(sender, e)
	End Sub

	Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
		Dim openFile As New OpenFileDialog()
		openFile.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"

		If openFile.ShowDialog() = DialogResult.OK Then
			picProfile.Image = Image.FromFile(openFile.FileName)
			picProfile.SizeMode = PictureBoxSizeMode.StretchImage
		End If
	End Sub

	Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
		Dim gender As String = If(rbLaki.Checked, "Laki-Laki", "Perempuan")

		Dim hobbies As String = ""
		For Each ctrl As Control In gbHobby.Controls
			If TypeOf ctrl Is CheckBox Then
				Dim chk As CheckBox = DirectCast(ctrl, CheckBox)
				If chk.Checked Then
					hobbies &= chk.Text & ", "
				End If
			End If
		Next
		If hobbies.Length > 0 Then hobbies = hobbies.TrimEnd(", ".ToCharArray())

		With Form2
			.lblNamaHasil.Text = txtNama.Text
			.lblUmurHasil.Text = txtUmur.Text & " Tahun"
			.lblTglLahirHasil.Text = dtpLahir.Value.ToString("dd MMMM yyyy")
			.lblTelpHasil.Text = txtTelp.Text
			.lblAlamatHasil.Text = txtAlamat.Text
			.lblGenderHasil.Text = gender
			.lblHobbyHasil.Text = hobbies

			If picProfile.Image IsNot Nothing Then
				.picHasil.Image = picProfile.Image
				.picHasil.SizeMode = PictureBoxSizeMode.StretchImage
			End If

			.Show()
		End With
	End Sub

	Private Sub lblTglLahir_Click(sender As Object, e As EventArgs) Handles lblTglLahir.Click

	End Sub
End Class