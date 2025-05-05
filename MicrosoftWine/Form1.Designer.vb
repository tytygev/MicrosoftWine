<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
		Me.PictureBox_animate = New System.Windows.Forms.PictureBox()
		Me.PictureBox_head = New System.Windows.Forms.PictureBox()
		Me.PictureBox_pic = New System.Windows.Forms.PictureBox()
		Me.PictureBox_buttonC = New System.Windows.Forms.PictureBox()
		Me.PictureBox_buttonNo = New System.Windows.Forms.PictureBox()
		Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
		Me.PictureBox_buttonclose = New System.Windows.Forms.PictureBox()
		Me.Label_head = New System.Windows.Forms.Label()
		Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
		Me.PictureBox_buttonYes = New System.Windows.Forms.PictureBox()
		Me.Label_YES = New System.Windows.Forms.Label()
		Me.Label_NO = New System.Windows.Forms.Label()
		Me.Label_text = New System.Windows.Forms.Label()
		Me.Label_C = New System.Windows.Forms.Label()
		CType(Me.PictureBox_animate, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox_head, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox_pic, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox_buttonC, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox_buttonNo, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox_buttonclose, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox_buttonYes, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'PictureBox_animate
		'
		Me.PictureBox_animate.BackColor = System.Drawing.Color.Transparent
		Me.PictureBox_animate.Image = Global.MicrosoftWine.My.Resources.Resources._3g
		Me.PictureBox_animate.Location = New System.Drawing.Point(12, 27)
		Me.PictureBox_animate.Name = "PictureBox_animate"
		Me.PictureBox_animate.Size = New System.Drawing.Size(272, 60)
		Me.PictureBox_animate.TabIndex = 0
		Me.PictureBox_animate.TabStop = False
		Me.PictureBox_animate.Visible = False
		'
		'PictureBox_head
		'
		Me.PictureBox_head.BackgroundImage = Global.MicrosoftWine.My.Resources.Resources.c1_head_off
		Me.PictureBox_head.Location = New System.Drawing.Point(1, 3)
		Me.PictureBox_head.Name = "PictureBox_head"
		Me.PictureBox_head.Size = New System.Drawing.Size(375, 18)
		Me.PictureBox_head.TabIndex = 1
		Me.PictureBox_head.TabStop = False
		'
		'PictureBox_pic
		'
		Me.PictureBox_pic.BackColor = System.Drawing.Color.Transparent
		Me.PictureBox_pic.BackgroundImage = Global.MicrosoftWine.My.Resources.Resources._3g_1
		Me.PictureBox_pic.Location = New System.Drawing.Point(12, 27)
		Me.PictureBox_pic.Name = "PictureBox_pic"
		Me.PictureBox_pic.Size = New System.Drawing.Size(43, 60)
		Me.PictureBox_pic.TabIndex = 2
		Me.PictureBox_pic.TabStop = False
		'
		'PictureBox_buttonC
		'
		Me.PictureBox_buttonC.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
		Me.PictureBox_buttonC.Image = Global.MicrosoftWine.My.Resources.Resources.c1_butt
		Me.PictureBox_buttonC.Location = New System.Drawing.Point(309, 127)
		Me.PictureBox_buttonC.Name = "PictureBox_buttonC"
		Me.PictureBox_buttonC.Size = New System.Drawing.Size(60, 23)
		Me.PictureBox_buttonC.TabIndex = 3
		Me.PictureBox_buttonC.TabStop = False
		Me.PictureBox_buttonC.Visible = False
		'
		'PictureBox_buttonNo
		'
		Me.PictureBox_buttonNo.Image = Global.MicrosoftWine.My.Resources.Resources.c1B_butt
		Me.PictureBox_buttonNo.Location = New System.Drawing.Point(295, 127)
		Me.PictureBox_buttonNo.Name = "PictureBox_buttonNo"
		Me.PictureBox_buttonNo.Size = New System.Drawing.Size(74, 23)
		Me.PictureBox_buttonNo.TabIndex = 4
		Me.PictureBox_buttonNo.TabStop = False
		'
		'ProgressBar1
		'
		Me.ProgressBar1.ForeColor = System.Drawing.Color.MidnightBlue
		Me.ProgressBar1.Location = New System.Drawing.Point(12, 127)
		Me.ProgressBar1.Name = "ProgressBar1"
		Me.ProgressBar1.Size = New System.Drawing.Size(285, 13)
		Me.ProgressBar1.TabIndex = 5
		Me.ProgressBar1.Visible = False
		'
		'PictureBox_buttonclose
		'
		Me.PictureBox_buttonclose.BackgroundImage = Global.MicrosoftWine.My.Resources.Resources.c1_head_butt_down
		Me.PictureBox_buttonclose.Image = Global.MicrosoftWine.My.Resources.Resources.c1_head_butt_up
		Me.PictureBox_buttonclose.Location = New System.Drawing.Point(360, 5)
		Me.PictureBox_buttonclose.Name = "PictureBox_buttonclose"
		Me.PictureBox_buttonclose.Size = New System.Drawing.Size(16, 14)
		Me.PictureBox_buttonclose.TabIndex = 6
		Me.PictureBox_buttonclose.TabStop = False
		'
		'Label_head
		'
		Me.Label_head.AccessibleRole = System.Windows.Forms.AccessibleRole.None
		Me.Label_head.AutoSize = True
		Me.Label_head.BackColor = System.Drawing.Color.Transparent
		Me.Label_head.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.Label_head.ForeColor = System.Drawing.Color.White
		Me.Label_head.Location = New System.Drawing.Point(3, 4)
		Me.Label_head.Name = "Label_head"
		Me.Label_head.Size = New System.Drawing.Size(142, 16)
		Me.Label_head.TabIndex = 7
		Me.Label_head.Text = "MicrosoftWine v.0.1"
		'
		'Timer1
		'
		Me.Timer1.Enabled = True
		Me.Timer1.Interval = 1000
		'
		'PictureBox_buttonYes
		'
		Me.PictureBox_buttonYes.Image = Global.MicrosoftWine.My.Resources.Resources.c1B_butt
		Me.PictureBox_buttonYes.Location = New System.Drawing.Point(210, 127)
		Me.PictureBox_buttonYes.Name = "PictureBox_buttonYes"
		Me.PictureBox_buttonYes.Size = New System.Drawing.Size(74, 23)
		Me.PictureBox_buttonYes.TabIndex = 8
		Me.PictureBox_buttonYes.TabStop = False
		'
		'Label_YES
		'
		Me.Label_YES.AutoSize = True
		Me.Label_YES.BackColor = System.Drawing.Color.Transparent
		Me.Label_YES.ForeColor = System.Drawing.Color.Black
		Me.Label_YES.Location = New System.Drawing.Point(236, 131)
		Me.Label_YES.Name = "Label_YES"
		Me.Label_YES.Size = New System.Drawing.Size(22, 13)
		Me.Label_YES.TabIndex = 9
		Me.Label_YES.Text = "Да"
		'
		'Label_NO
		'
		Me.Label_NO.AutoSize = True
		Me.Label_NO.BackColor = System.Drawing.Color.Transparent
		Me.Label_NO.ForeColor = System.Drawing.Color.Black
		Me.Label_NO.Location = New System.Drawing.Point(319, 131)
		Me.Label_NO.Name = "Label_NO"
		Me.Label_NO.Size = New System.Drawing.Size(26, 13)
		Me.Label_NO.TabIndex = 10
		Me.Label_NO.Text = "Нет"
		'
		'Label_text
		'
		Me.Label_text.AutoSize = True
		Me.Label_text.ForeColor = System.Drawing.Color.Black
		Me.Label_text.Location = New System.Drawing.Point(77, 47)
		Me.Label_text.Name = "Label_text"
		Me.Label_text.Size = New System.Drawing.Size(0, 13)
		Me.Label_text.TabIndex = 11
		'
		'Label_C
		'
		Me.Label_C.AutoSize = True
		Me.Label_C.BackColor = System.Drawing.Color.Transparent
		Me.Label_C.ForeColor = System.Drawing.Color.Black
		Me.Label_C.Location = New System.Drawing.Point(316, 131)
		Me.Label_C.Name = "Label_C"
		Me.Label_C.Size = New System.Drawing.Size(46, 13)
		Me.Label_C.TabIndex = 12
		Me.Label_C.Text = "Отмена"
		Me.Label_C.Visible = False
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.Silver
		Me.BackgroundImage = Global.MicrosoftWine.My.Resources.Resources.c1_body_form
		Me.ClientSize = New System.Drawing.Size(381, 162)
		Me.Controls.Add(Me.Label_C)
		Me.Controls.Add(Me.Label_text)
		Me.Controls.Add(Me.Label_NO)
		Me.Controls.Add(Me.Label_YES)
		Me.Controls.Add(Me.PictureBox_buttonYes)
		Me.Controls.Add(Me.Label_head)
		Me.Controls.Add(Me.PictureBox_buttonclose)
		Me.Controls.Add(Me.ProgressBar1)
		Me.Controls.Add(Me.PictureBox_buttonNo)
		Me.Controls.Add(Me.PictureBox_buttonC)
		Me.Controls.Add(Me.PictureBox_pic)
		Me.Controls.Add(Me.PictureBox_head)
		Me.Controls.Add(Me.PictureBox_animate)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "Form1"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "MicrosoftWine"
		CType(Me.PictureBox_animate, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox_head, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox_pic, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox_buttonC, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox_buttonNo, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox_buttonclose, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox_buttonYes, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents PictureBox_animate As PictureBox
    Friend WithEvents PictureBox_head As PictureBox
    Friend WithEvents PictureBox_pic As PictureBox
    Friend WithEvents PictureBox_buttonC As PictureBox
    Friend WithEvents PictureBox_buttonNo As PictureBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents PictureBox_buttonclose As PictureBox
    Friend WithEvents Label_head As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox_buttonYes As PictureBox
    Friend WithEvents Label_YES As Label
    Friend WithEvents Label_NO As Label
    Friend WithEvents Label_text As Label
    Friend WithEvents Label_C As Label
End Class
