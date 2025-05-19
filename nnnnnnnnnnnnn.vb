Imports System.Media

Public Class Form1
    Dim Dice(5) As PictureBox
    Dim rnd As New Random()
    Dim rollCount As Integer = 0
    Dim rolledValue As Integer
    Dim balance As Integer = 100
    Private player As New SoundPlayer()
    Private currentLanguage As String = "RO"
    Private currentCurrency As String = "lei"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dice(0) = D1
        Dice(1) = D2
        Dice(2) = D3
        Dice(3) = D4
        Dice(4) = D5
        Dice(5) = D6

        For Each pb As PictureBox In Dice
            pb.Visible = False
        Next

        SetRomanian()
    End Sub

    ' Butoane limbă
    Private Sub btnRomania_Click(sender As Object, e As EventArgs) Handles btnRomania.Click
        SetRomanian()
    End Sub

    Private Sub btnEngleza_Click(sender As Object, e As EventArgs) Handles btnEngleza.Click
        SetEnglish()
    End Sub

    Private Sub btnPoloneza_Click(sender As Object, e As EventArgs) Handles btnPoloneza.Click
        SetPolish()
    End Sub

    ' Setări limbă
    Private Sub SetRomanian()
        currentLanguage = "RO"
        currentCurrency = "lei"
        Label1.Text = "Balanță: " & balance & " " & currentCurrency
        RadioButtonHigh.Text = "Mai mare decât 3"
        RadioButtonLow.Text = "Mai mic sau egal cu 3"
        btnStart.Text = "Începe"
        Label2.Text = ""
    End Sub

    Private Sub SetEnglish()
        currentLanguage = "EN"
        currentCurrency = "£"
        Label1.Text = "Balance: " & balance & " " & currentCurrency
        RadioButtonHigh.Text = "Greater than 3"
        RadioButtonLow.Text = "Less than or equal to 3"
        btnStart.Text = "Start"
        Label2.Text = ""
    End Sub

    Private Sub SetPolish()
        currentLanguage = "PL"
        currentCurrency = "zł"
        Label1.Text = "Saldo: " & balance & " " & currentCurrency
        RadioButtonHigh.Text = "Większe niż 3"
        RadioButtonLow.Text = "Mniejsze lub równe 3"
        btnStart.Text = "Start"
        Label2.Text = ""
    End Sub

    ' Ascundem/afișăm controale
    Private Sub HideControls()
        btnStart.Visible = False
        TextBox1.Visible = False
        RadioButtonHigh.Visible = False
        RadioButtonLow.Visible = False
        btnRomania.Visible = False
        btnEngleza.Visible = False
        btnPoloneza.Visible = False
    End Sub

    Private Sub ShowControls()
        btnStart.Visible = True
        TextBox1.Visible = True
        RadioButtonHigh.Visible = True
        RadioButtonLow.Visible = True
        btnRomania.Visible = True
        btnEngleza.Visible = True
        btnPoloneza.Visible = True
    End Sub

    ' Start joc
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If Not Integer.TryParse(TextBox1.Text, Nothing) Then
            ShowMessage("Introduceți o sumă validă!", "Enter a valid amount!", "Wprowadź prawidłową kwotę!")
            Return
        End If

        Dim bet As Integer = Integer.Parse(TextBox1.Text)
        If bet <= 0 OrElse bet > balance Then
            ShowMessage("Pariu invalid!", "Invalid bet!", "Nieprawidłowy zakład!")
            Return
        End If

        HideControls()

        player.SoundLocation = "dice-142528.wav"
        Try
            player.Load()
            player.Play()
        Catch ex As Exception
            ShowMessage("Eroare la sunet: " & ex.Message, "Sound error: " & ex.Message, "Błąd dźwięku: " & ex.Message)
        End Try

        rollCount = 0
        Timer1.Interval = 100
        Timer1.Start()
    End Sub

    ' Animație zaruri
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        For Each pb As PictureBox In Dice
            pb.Visible = False
        Next

        rolledValue = rnd.Next(1, 7)
        Dice(rolledValue - 1).Visible = True

        rollCount += 1
        If rollCount >= 10 Then
            Timer1.Stop()
            CheckResult()
            ShowControls()
        End If
    End Sub

    ' Verificare rezultat
    Private Sub CheckResult()
        Dim bet As Integer = Integer.Parse(TextBox1.Text)
        Dim winCondition As Boolean = False

        If RadioButtonHigh.Checked AndAlso rolledValue > 3 Then
            winCondition = True
        ElseIf RadioButtonLow.Checked AndAlso rolledValue <= 3 Then
            winCondition = True
        End If

        If winCondition Then
            balance += bet
            Select Case currentLanguage
                Case "RO" : Label2.Text = "Ai câștigat! +" & bet & " " & currentCurrency
                Case "EN" : Label2.Text = "You won! +" & bet & " " & currentCurrency
                Case "PL" : Label2.Text = "Wygrałeś! +" & bet & " " & currentCurrency
            End Select
        Else
            balance -= bet
            Select Case currentLanguage
                Case "RO" : Label2.Text = "Ai pierdut! -" & bet & " " & currentCurrency
                Case "EN" : Label2.Text = "You lost! -" & bet & " " & currentCurrency
                Case "PL" : Label2.Text = "Przegrałeś! -" & bet & " " & currentCurrency
            End Select
        End If

        Select Case currentLanguage
            Case "RO" : Label1.Text = "Balanță: " & balance & " " & currentCurrency
            Case "EN" : Label1.Text = "Balance: " & balance & " " & currentCurrency
            Case "PL" : Label1.Text = "Saldo: " & balance & " " & currentCurrency
        End Select

        If balance <= 0 Then
            Select Case currentLanguage
                Case "RO" : MessageBox.Show("Ai rămas fără bani! Joc terminat.")
                Case "EN" : MessageBox.Show("You're out of money! Game over.")
                Case "PL" : MessageBox.Show("Koniec gry! Brak środków.")
            End Select
            btnStart.Enabled = False
        End If
    End Sub

    ' Mesaje în funcție de limbă
    Private Sub ShowMessage(msgRO As String, msgEN As String, msgPL As String)
        Select Case currentLanguage
            Case "RO" : MessageBox.Show(msgRO)
            Case "EN" : MessageBox.Show(msgEN)
            Case "PL" : MessageBox.Show(msgPL)
        End Select
    End Sub
End Class
