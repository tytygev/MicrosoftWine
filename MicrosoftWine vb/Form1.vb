Public Class Form1
	Dim moving As Boolean
	Dim P As Point
	Dim i_y As Integer = 0
	Dim i_n As Integer = 0
	Dim textmessage(2, 44) As Array
	'
	Private Sub Form1_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
		PictureBox_head.Image = Global.MicrosoftWine_vb.My.Resources.Resources.c1_head_off
	End Sub
	Private Sub Form1_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
		PictureBox_head.Image = MicrosoftWine_vb.My.Resources.Resources.c1_head_on
	End Sub
	Private Sub PictureBox_head_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox_head.MouseDown
		P = e.Location
		moving = True
	End Sub
	Private Sub PictureBox_head_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox_head.MouseMove
		If moving Then
			Me.Location = MousePosition - P
		End If
	End Sub
	Private Sub PictureBox_head_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox_head.MouseUp
		moving = False
	End Sub
	Private Sub Label_head_MouseDown(sender As Object, e As MouseEventArgs) Handles Label_head.MouseDown
		P = e.Location
		moving = True
	End Sub
	Private Sub Label_head_MouseMove(sender As Object, e As MouseEventArgs) Handles Label_head.MouseMove
		If moving Then
			Me.Location = MousePosition - P
		End If
	End Sub
	Private Sub Label_head_MouseUp(sender As Object, e As MouseEventArgs) Handles Label_head.MouseUp
		moving = False
	End Sub

	Private Sub PictureBox_buttonclose_Click(sender As Object, e As EventArgs) Handles PictureBox_buttonclose.Click
		End
	End Sub
	Private Sub PictureBox_buttonclose_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox_buttonclose.MouseDown
		PictureBox_buttonclose.Image = MicrosoftWine_vb.My.Resources.Resources.c1_head_butt_down
	End Sub
	Private Sub PictureBox_buttonclose_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox_buttonclose.MouseUp
		PictureBox_buttonclose.Image = MicrosoftWine_vb.My.Resources.Resources.c1_head_butt_up
	End Sub

	Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
		Label_text.Text = "Вы действительно хотите выпить?"
		Timer1.Enabled = False
	End Sub

	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
		Label_head.Location = New Point(0, 0)
		Label_head.Parent = PictureBox_head
		Label_head.BackColor = Color.Transparent

		'textmessage(0, 0)

	End Sub



	Private Sub PictureBox_buttonYes_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox_buttonYes.MouseDown, Label_YES.MouseDown
		PictureBox_buttonYes.Image = MicrosoftWine_vb.My.Resources.Resources.c1B_butt_a_down
		Label_YES.Location = New Point(Label_YES.Location.X + 1, Label_YES.Location.Y + 1)
		PictureBox_buttonNo.Image = MicrosoftWine_vb.My.Resources.Resources.c1B_butt
	End Sub

	Private Sub PictureBox_buttonYes_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox_buttonYes.MouseUp, Label_YES.MouseUp
		PictureBox_buttonYes.Image = MicrosoftWine_vb.My.Resources.Resources.c1B_butt_a_up
		Label_YES.Location = New Point(Label_YES.Location.X - 1, Label_YES.Location.Y - 1)
	End Sub
	Private Sub PictureBox_buttonno_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox_buttonNo.MouseDown, Label_no.MouseDown
		PictureBox_buttonNo.Image = MicrosoftWine_vb.My.Resources.Resources.c1B_butt_a_down
		Label_NO.Location = New Point(Label_NO.Location.X + 1, Label_NO.Location.Y + 1)
		PictureBox_buttonYes.Image = MicrosoftWine_vb.My.Resources.Resources.c1B_butt
	End Sub

	Private Sub PictureBox_buttonno_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox_buttonNo.MouseUp, Label_no.MouseUp
		PictureBox_buttonNo.Image = MicrosoftWine_vb.My.Resources.Resources.c1B_butt_a_up
		Label_NO.Location = New Point(Label_no.Location.X - 1, Label_no.Location.Y - 1)
	End Sub
	Private Sub Label_YES_Click(sender As Object, e As EventArgs) Handles Label_YES.Click, PictureBox_buttonYes.Click
		MsgBox(i_y)
		MsgBox(i_n)
		If i_y = 0 Then
			Label_text.Text = "По 100?"

		ElseIf i_y = 1 Then
			If i_n = 1 Then
				'Timer1.Enabled = True
				MsgBox("error", 16)
				' RaiseEvent.Timer1.Tick()
			End If
			Label_text.Text = "Или по 150?"
		ElseIf i_y = 2 Then
			Label_text.Text = "Или сначала по 100, а потом по 150?"
		ElseIf i_y = 3 Then
			Label_text.Text = "А может сразу 250?"
		ElseIf i_y = 4 Then
			Label_text.Text = "А можно ещё вопрос?"
		ElseIf i_y = 5 Then
			Label_text.Text = "Вы уверены, что хотите выпить?"
		ElseIf i_y = 6 Then
			Label_text.Text = "Ну чё, поехали?"
		ElseIf i_y = 7 Then
			Label_text.Text = "Или ну его нахуй?"


		End If
		i_y = i_y + 1
		i_n = i_n + 1
	End Sub

	Private Sub Label_NO_Click(sender As Object, e As EventArgs) Handles Label_NO.Click, PictureBox_buttonNo.Click
		MsgBox(i_y)
		MsgBox(i_n)
		If i_n = 0 Then
			Label_text.Text = "Уверены, что не хотите?"
		ElseIf i_n = 1 Then
			Label_text.Text = "Тогда по 100?"
			i_y = 0
		ElseIf i_n = 2 Then
			Label_text.Text = "?"
		ElseIf i_n = 3 Then
			Label_text.Text = "А может сразу 250?"
		ElseIf i_n = 4 Then
			Label_text.Text = "А можно ещё вопрос?"
		ElseIf i_n = 5 Then
			Label_text.Text = "Подзаебало?"
		ElseIf i_n = 6 Then
			Label_text.Text = "Ну чё, поехали?"
		ElseIf i_n = 7 Then
			Label_text.Text = "Или ну его нахуй?"
		End If
		i_n = i_n + 1
		i_y = i_y + 1
	End Sub
End Class
