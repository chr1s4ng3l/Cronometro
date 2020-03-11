'
' Created by SharpDevelop.
' User: Christopher
' Date: 14/03/2019
' Time: 01:42 p. m.
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class MainForm
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.labelH = New System.Windows.Forms.Label()
		Me.labelM = New System.Windows.Forms.Label()
		Me.labelS = New System.Windows.Forms.Label()
		Me.label4 = New System.Windows.Forms.Label()
		Me.label5 = New System.Windows.Forms.Label()
		Me.timer1 = New System.Windows.Forms.Timer(Me.components)
		Me.buttonReiniciar = New System.Windows.Forms.Button()
		Me.buttonIniciar = New System.Windows.Forms.Button()
		Me.listBox1 = New System.Windows.Forms.ListBox()
		Me.labelVuelta = New System.Windows.Forms.Label()
		Me.labelHora = New System.Windows.Forms.Label()
		Me.labelTiempo = New System.Windows.Forms.Label()
		Me.labelS1 = New System.Windows.Forms.Label()
		Me.labelM1 = New System.Windows.Forms.Label()
		Me.labelH1 = New System.Windows.Forms.Label()
		Me.timer2 = New System.Windows.Forms.Timer(Me.components)
		Me.SuspendLayout
		'
		'labelH
		'
		Me.labelH.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.labelH.AutoSize = true
		Me.labelH.Font = New System.Drawing.Font("Times New Roman", 72!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.labelH.Location = New System.Drawing.Point(19, 9)
		Me.labelH.Name = "labelH"
		Me.labelH.Size = New System.Drawing.Size(141, 108)
		Me.labelH.TabIndex = 0
		Me.labelH.Text = "00"
		'
		'labelM
		'
		Me.labelM.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.labelM.AutoSize = true
		Me.labelM.Font = New System.Drawing.Font("Times New Roman", 72!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.labelM.Location = New System.Drawing.Point(193, 10)
		Me.labelM.Name = "labelM"
		Me.labelM.Size = New System.Drawing.Size(141, 108)
		Me.labelM.TabIndex = 1
		Me.labelM.Text = "00"
		'
		'labelS
		'
		Me.labelS.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.labelS.AutoSize = true
		Me.labelS.Font = New System.Drawing.Font("Times New Roman", 24!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.labelS.Location = New System.Drawing.Point(321, 68)
		Me.labelS.Name = "labelS"
		Me.labelS.Size = New System.Drawing.Size(47, 36)
		Me.labelS.TabIndex = 2
		Me.labelS.Text = "00"
		AddHandler Me.labelS.Click, AddressOf Me.LabelSClick
		'
		'label4
		'
		Me.label4.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.label4.AutoSize = true
		Me.label4.Font = New System.Drawing.Font("Times New Roman", 72!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label4.Location = New System.Drawing.Point(135, -4)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(77, 108)
		Me.label4.TabIndex = 3
		Me.label4.Text = ":"
		AddHandler Me.label4.Click, AddressOf Me.Label4Click
		'
		'label5
		'
		Me.label5.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.label5.Font = New System.Drawing.Font("Times New Roman", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label5.Location = New System.Drawing.Point(307, 58)
		Me.label5.Name = "label5"
		Me.label5.Size = New System.Drawing.Size(20, 42)
		Me.label5.TabIndex = 4
		Me.label5.Text = "."
		'
		'timer1
		'
		Me.timer1.Interval = 10
		AddHandler Me.timer1.Tick, AddressOf Me.Timer1Tick
		'
		'buttonReiniciar
		'
		Me.buttonReiniciar.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.buttonReiniciar.BackColor = System.Drawing.Color.Gold
		Me.buttonReiniciar.Enabled = false
		Me.buttonReiniciar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.buttonReiniciar.ForeColor = System.Drawing.SystemColors.ControlLightLight
		Me.buttonReiniciar.Location = New System.Drawing.Point(71, 131)
		Me.buttonReiniciar.Name = "buttonReiniciar"
		Me.buttonReiniciar.Size = New System.Drawing.Size(89, 33)
		Me.buttonReiniciar.TabIndex = 5
		Me.buttonReiniciar.Text = "Reiniciar"
		Me.buttonReiniciar.UseVisualStyleBackColor = false
		AddHandler Me.buttonReiniciar.Click, AddressOf Me.ButtonReiniciarClick
		'
		'buttonIniciar
		'
		Me.buttonIniciar.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.buttonIniciar.BackColor = System.Drawing.Color.LimeGreen
		Me.buttonIniciar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.buttonIniciar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
		Me.buttonIniciar.Location = New System.Drawing.Point(220, 131)
		Me.buttonIniciar.Name = "buttonIniciar"
		Me.buttonIniciar.Size = New System.Drawing.Size(75, 33)
		Me.buttonIniciar.TabIndex = 6
		Me.buttonIniciar.Text = "Iniciar"
		Me.buttonIniciar.UseVisualStyleBackColor = false
		AddHandler Me.buttonIniciar.Click, AddressOf Me.ButtonIniciarClick
		'
		'listBox1
		'
		Me.listBox1.BackColor = System.Drawing.Color.White
		Me.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.listBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.listBox1.FormattingEnabled = true
		Me.listBox1.ItemHeight = 20
		Me.listBox1.Location = New System.Drawing.Point(40, 225)
		Me.listBox1.Name = "listBox1"
		Me.listBox1.Size = New System.Drawing.Size(314, 80)
		Me.listBox1.TabIndex = 7
		'
		'labelVuelta
		'
		Me.labelVuelta.AutoSize = true
		Me.labelVuelta.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.labelVuelta.Location = New System.Drawing.Point(40, 184)
		Me.labelVuelta.Name = "labelVuelta"
		Me.labelVuelta.Size = New System.Drawing.Size(73, 25)
		Me.labelVuelta.TabIndex = 8
		Me.labelVuelta.Text = "Vuelta"
		'
		'labelHora
		'
		Me.labelHora.AutoSize = true
		Me.labelHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.labelHora.Location = New System.Drawing.Point(135, 184)
		Me.labelHora.Name = "labelHora"
		Me.labelHora.Size = New System.Drawing.Size(58, 25)
		Me.labelHora.TabIndex = 9
		Me.labelHora.Text = "Hora"
		AddHandler Me.labelHora.Click, AddressOf Me.LabelHoraClick
		'
		'labelTiempo
		'
		Me.labelTiempo.AutoSize = true
		Me.labelTiempo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.labelTiempo.Location = New System.Drawing.Point(220, 184)
		Me.labelTiempo.Name = "labelTiempo"
		Me.labelTiempo.Size = New System.Drawing.Size(137, 25)
		Me.labelTiempo.TabIndex = 10
		Me.labelTiempo.Text = "Tiempo Total"
		'
		'labelS1
		'
		Me.labelS1.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.labelS1.AutoSize = true
		Me.labelS1.Font = New System.Drawing.Font("Times New Roman", 24!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.labelS1.Location = New System.Drawing.Point(321, 64)
		Me.labelS1.Name = "labelS1"
		Me.labelS1.Size = New System.Drawing.Size(47, 36)
		Me.labelS1.TabIndex = 13
		Me.labelS1.Text = "00"
		Me.labelS1.Visible = false
		'
		'labelM1
		'
		Me.labelM1.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.labelM1.AutoSize = true
		Me.labelM1.Font = New System.Drawing.Font("Times New Roman", 72!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.labelM1.Location = New System.Drawing.Point(186, 10)
		Me.labelM1.Name = "labelM1"
		Me.labelM1.Size = New System.Drawing.Size(141, 108)
		Me.labelM1.TabIndex = 12
		Me.labelM1.Text = "00"
		Me.labelM1.Visible = false
		'
		'labelH1
		'
		Me.labelH1.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.labelH1.AutoSize = true
		Me.labelH1.Font = New System.Drawing.Font("Times New Roman", 72!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.labelH1.Location = New System.Drawing.Point(12, 6)
		Me.labelH1.Name = "labelH1"
		Me.labelH1.Size = New System.Drawing.Size(141, 108)
		Me.labelH1.TabIndex = 11
		Me.labelH1.Text = "00"
		Me.labelH1.Visible = false
		'
		'timer2
		'
		Me.timer2.Interval = 10
		AddHandler Me.timer2.Tick, AddressOf Me.Timer2Tick
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(401, 328)
		Me.Controls.Add(Me.labelS1)
		Me.Controls.Add(Me.labelM1)
		Me.Controls.Add(Me.labelH1)
		Me.Controls.Add(Me.labelTiempo)
		Me.Controls.Add(Me.labelHora)
		Me.Controls.Add(Me.labelVuelta)
		Me.Controls.Add(Me.listBox1)
		Me.Controls.Add(Me.buttonIniciar)
		Me.Controls.Add(Me.buttonReiniciar)
		Me.Controls.Add(Me.label5)
		Me.Controls.Add(Me.label4)
		Me.Controls.Add(Me.labelS)
		Me.Controls.Add(Me.labelM)
		Me.Controls.Add(Me.labelH)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Name = "MainForm"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Cronometro"
		AddHandler Load, AddressOf Me.MainFormLoad
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private timer2 As System.Windows.Forms.Timer
	Private labelH1 As System.Windows.Forms.Label
	Private labelM1 As System.Windows.Forms.Label
	Private labelS1 As System.Windows.Forms.Label
	Private labelTiempo As System.Windows.Forms.Label
	Private labelHora As System.Windows.Forms.Label
	Private labelVuelta As System.Windows.Forms.Label
	Private listBox1 As System.Windows.Forms.ListBox
	Private buttonIniciar As System.Windows.Forms.Button
	Private buttonReiniciar As System.Windows.Forms.Button
	Private timer1 As System.Windows.Forms.Timer
	Private label5 As System.Windows.Forms.Label
	Private label4 As System.Windows.Forms.Label
	Private labelS As System.Windows.Forms.Label
	Private labelM As System.Windows.Forms.Label
	Private labelH As System.Windows.Forms.Label
	
	Sub LabelSClick(sender As Object, e As EventArgs)
		
	End Sub
	
	Sub Label4Click(sender As Object, e As EventArgs)
		
	End Sub
End Class
