'
' Created by SharpDevelop.
' User: Christopher
' Date: 14/03/2019
' Time: 01:42 p. m.
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Partial Class MainForm
Dim i As Int32	
	Public Sub New()
		
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	
	
	Sub ButtonIniciarClick(sender As Object, e As EventArgs)
		If buttonIniciar.Text = "Iniciar" Then
			timer1.Start()
			timer2.Start()
			buttonReiniciar.Enabled = True
			buttonIniciar.Text = "Parar"
			buttonIniciar.BackColor = Color.red
			buttonReiniciar.Text = "Vuelta"
			buttonReiniciar.BackColor = Color.Blue
	
		ElseIf buttonIniciar.Text = "Parar"
			buttonIniciar.Text = "Iniciar"
			buttonIniciar.BackColor = Color.LimeGreen
			buttonReiniciar.Text = "Reiniciar"
			buttonReiniciar.BackColor = Color.Gold
		    timer1.Enabled = False
			timer2.Enabled = False

		End If
	
	End Sub
	
	Sub Timer1Tick(sender As Object, e As EventArgs)
	
		labels.Text +=1
		If Labels.Text = "60" Then
			labelM.Text +=1
			labelS.Text = "00"
		End If
	
		If labelM.Text = "60" Then
			labelH.Text +=1
			labelM.Text ="00"
		End If

	End Sub
	
	Sub MainFormLoad(sender As Object, e As EventArgs)
		labelHora.Text=""
		labelVuelta.Text =""
		labelTiempo.Text =""		
	End Sub
	
	Sub LabelHoraClick(sender As Object, e As EventArgs)
		
	End Sub
	
	Sub ButtonReiniciarClick(sender As Object, e As EventArgs)
	
		i= i + 1
	
	    If  buttonReiniciar.text= "Vuelta" Then
	    labelHora.Text="Hora"
		labelVuelta.Text ="Vuelta"
		labelTiempo.Text ="Tiempo Total"
	    	listBox1.Items.Add("      " & i.ToString &"              "& labelH1.Text &  " : " & labelM1.Text &  " : " & labelS1.text &"           "&labelH.Text &  " : " & labelM.Text &  " : " & labelS.text)
	    	labels1.Text = "00"
		labelH1.Text = "00"
		labelM1.Text = "00"
		End If
		If buttonReiniciar.Text="Reiniciar" Then
	    labels1.Text = "00"
		labelH1.Text = "00"
		labelM1.Text = "00"
		labels.Text = "00"
		labelH.Text = "00"
		labelM.Text = "00"
		listBox1.Items.Clear
		labelHora.Text=""
		labelVuelta.Text =""
		labelTiempo.Text =""
		i=0
		buttonReiniciar.Enabled = False
		End If
			
		
	End Sub
	
	Sub Timer2Tick(sender As Object, e As EventArgs)
			labels1.Text +=1
		If Labels1.Text = "60" Then
			labelM1.Text +=1
			labelS1.Text = "00"
		End If
	
		If labelM1.Text = "60" Then
			labelH1.Text +=1
			labelM1.Text ="00"
		End If
	End Sub
End Class
