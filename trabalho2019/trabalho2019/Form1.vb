
Imports System.Reflection
Imports System.Windows.Forms

Public Class Form1
    Private Counter As Integer = 100
    Private Difficulty As Integer = 1
    Private QuestionsEasy(8) As String
    Private QuestionsMedium(16) As String
    Private QuestionsHard(24) As String
    Private AnswersEasy(8) As Integer
    Private AnswersMedium(16) As Integer
    Private AnswersHard(24) As Integer

    Private Options_button1Easy(8) As String
    Private Options_button2Easy(8) As String
    Private Options_button3Easy(8) As String

    Private Options_button1Medium(16) As String
    Private Options_button2Medium(16) As String
    Private Options_button3Medium(16) As String

    Private Options_button1Hard(24) As String
    Private Options_button2Hard(24) As String
    Private Options_button3Hard(24) As String


    Private Correct_answers As Integer = 0
    Private question_label As Label
    Private Question_number As Integer = 0
    Private label1 As Label
    Private GameOver_label As Label
    Private Score_label As Label
    Private WithEvents option1 As Button
    Private WithEvents option2 As Button
    Private WithEvents option3 As Button
    Private WithEvents voltar_button As Button


    Sub DisplayButtons()


    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Começar.Click
        'clearing the screen

        Começar.Visible = False
        Começar2.Visible = False
        Começar3.Visible = False
        Regras.Visible = False
        Titulo.Visible = False
        start_button.Visible = False

        'option creation

        option1.Text = Options_button1Easy(Question_number)
        option2.Text = Options_button2Easy(Question_number)
        option3.Text = Options_button3Easy(Question_number)
        option1.Visible = True
        option2.Visible = True
        option3.Visible = True
        Difficulty = 1


        question_label.Visible = True

        label1.Visible = True


        Timer1.Interval = 1000
        Timer1.Start()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Começar2.Click
        'clearing the screen

        Começar.Visible = False
        Começar2.Visible = False
        Começar3.Visible = False
        Regras.Visible = False
        Titulo.Visible = False
        start_button.Visible = False

        'option creation
        option1.Text = Options_button1Medium(Question_number)
        option2.Text = Options_button2Medium(Question_number)
        option3.Text = Options_button3Medium(Question_number)
        option1.Visible = True
        option2.Visible = True
        option3.Visible = True
        Difficulty = 2


        question_label.Visible = True

        label1.Visible = True


        Timer1.Interval = 1000
        Timer1.Start()


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Começar3.Click
        'clearing the screen

        Começar.Visible = False
        Começar2.Visible = False
        Começar3.Visible = False
        Regras.Visible = False
        Titulo.Visible = False
        start_button.Visible = False

        'option creation
        option1.Text = Options_button1Hard(Question_number)
        option2.Text = Options_button2Hard(Question_number)
        option3.Text = Options_button3Hard(Question_number)
        option1.Visible = True
        option2.Visible = True
        option3.Visible = True
        Difficulty = 3


        question_label.Visible = True

        label1.Visible = True


        Timer1.Interval = 1000
        Timer1.Start()


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        QuestionsEasy(0) = "Qual é o time de futebol mais antigo do mundo?"
        QuestionsEasy(1) = "Quem foi o primeiro time de futebol a se tornar profissional?"
        QuestionsEasy(2) = "Quais são as cores do time inglês Manchester United?"
        QuestionsEasy(3) = "Qual é o maior estádio de futebol do mundo?"
        QuestionsEasy(4) = "Quais são os três times brasileiros que mais vezes venceram o Campeonato Brasileiro?"
        QuestionsEasy(5) = "Quem foi o primeiro time de futebol a se tornar profissional?"
        QuestionsEasy(6) = "Quais são as cores do time inglês Manchester United?"
        QuestionsEasy(7) = "Qual é o maior estádio de futebol do mundo?"
        QuestionsEasy(8) = "Quais são os três times brasileiros que mais vezes venceram o Campeonato Brasileiro?"

        QuestionsMedium(0) = "1Qual é o time de futebol mais antigo do mundo?  1"
        QuestionsMedium(1) = "2Quem foi o primeiro time de futebol a se tornar profissional? 2"
        QuestionsMedium(2) = "3Quais são as cores do time inglês Manchester United?"
        QuestionsMedium(3) = "4Qual é o maior estádio de futebol do mundo?"
        QuestionsMedium(4) = "5Quais são os três times brasileiros que mais vezes venceram o Campeonato Brasileiro? 3"
        QuestionsMedium(5) = "6Qual é o time de futebol mais antigo do mundo? 4"
        QuestionsMedium(6) = "7Quem foi o primeiro time de futebol a se tornar profissional? 5 "
        QuestionsMedium(7) = "8Quais são as cores do time inglês Manchester United? 6"
        QuestionsMedium(8) = "9Qual é o maior estádio de futebol do mundo? 7"
        QuestionsMedium(9) = "2Quem foi o primeiro time de futebol a se tornar profissional? 2"
        QuestionsMedium(10) = "3Quais são as cores do time inglês Manchester United?"
        QuestionsMedium(11) = "4Qual é o maior estádio de futebol do mundo?"
        QuestionsMedium(12) = "5Quais são os três times brasileiros que mais vezes venceram o Campeonato Brasileiro? 3"
        QuestionsMedium(13) = "6Qual é o time de futebol mais antigo do mundo? 4"
        QuestionsMedium(14) = "7Quem foi o primeiro time de futebol a se tornar profissional? 5 "
        QuestionsMedium(15) = "8Quais são as cores do time inglês Manchester United? 6"
        QuestionsMedium(16) = "9Qual é o maior estádio de futebol do mundo? 7"

        QuestionsHard(0) = "Qual é o time de futebol mais antigo do mundo?"
        QuestionsHard(1) = "Quem foi o primeiro time de futebol a se tornar profissional?"
        QuestionsHard(2) = "Quais são as cores do time inglês Manchester United?"
        QuestionsHard(3) = "Qual é o maior estádio de futebol do mundo?"
        QuestionsHard(4) = "Quais são os três times brasileiros que mais vezes venceram o Campeonato Brasileiro?"
        QuestionsHard(5) = "Qual é o time de futebol mais antigo do mundo?"
        QuestionsHard(6) = "Quem foi o primeiro time de futebol a se tornar profissional?"
        QuestionsHard(7) = "Quais são as cores do time inglês Manchester United?"
        QuestionsHard(8) = "Qual é o maior estádio de futebol do mundo?"
        QuestionsHard(9) = "Quais são os três times brasileiros que mais vezes venceram o Campeonato Brasileiro?"
        QuestionsHard(10) = "Qual é o time de futebol mais antigo do mundo?"
        QuestionsHard(11) = "Quem foi o primeiro time de futebol a se tornar profissional?"
        QuestionsHard(12) = "Quais são as cores do time inglês Manchester United?"
        QuestionsHard(13) = "Quem foi o primeiro time de futebol a se tornar profissional?"
        QuestionsHard(14) = "Quais são as cores do time inglês Manchester United?"
        QuestionsHard(15) = "Qual é o maior estádio de futebol do mundo?"
        QuestionsHard(16) = "Quais são os três times brasileiros que mais vezes venceram o Campeonato Brasileiro?"
        QuestionsHard(17) = "Qual é o time de futebol mais antigo do mundo?"
        QuestionsHard(18) = "Quem foi o primeiro time de futebol a se tornar profissional?"
        QuestionsHard(19) = "Quais são as cores do time inglês Manchester United?"
        QuestionsHard(20) = "Qual é o maior estádio de futebol do mundo?"
        QuestionsHard(21) = "Quais são os três times brasileiros que mais vezes venceram o Campeonato Brasileiro?"
        QuestionsHard(22) = "Qual é o time de futebol mais antigo do mundo?"
        QuestionsHard(23) = "Quem foi o primeiro time de futebol a se tornar profissional?"
        QuestionsHard(24) = "Quais são as cores do time inglês Manchester United?"


        Options_button1Easy(0) = "Sheffield FC"
        Options_button1Easy(1) = "Inglaterra"
        Options_button1Easy(2) = "cores vermelhas e azuis"
        Options_button1Easy(3) = "Rungrado May Day Stadium, na Coreia do Norte"
        Options_button1Easy(4) = "Palmeiras, Chapecoense, Fluminense"
        Options_button1Easy(5) = "Inglaterra"
        Options_button1Easy(6) = "cores vermelhas e azuis"
        Options_button1Easy(7) = "Rungrado May Day Stadium, na Coreia do Norte"
        Options_button1Easy(8) = "Palmeiras, Chapecoense, Fluminense"

        Options_button2Easy(0) = "Manchester City"
        Options_button2Easy(1) = "Atlético Mineiro"
        Options_button2Easy(2) = "Azul e Verde"
        Options_button2Easy(3) = "Juventus"
        Options_button2Easy(4) = "Manchester United"
        Options_button2Easy(5) = "Atlético Mineiro"
        Options_button2Easy(6) = "Azul e Verde"
        Options_button2Easy(7) = "Juventus"
        Options_button2Easy(8) = "Manchester United"

        Options_button3Easy(0) = "Newcastle United"
        Options_button3Easy(1) = "Vasco da Gama"
        Options_button3Easy(2) = "Laranja e Rosa"
        Options_button3Easy(3) = "AC Milan"
        Options_button3Easy(4) = "Liverpool FC"
        Options_button3Easy(5) = "Vasco da Gama"
        Options_button3Easy(6) = "Laranja e Rosa"
        Options_button3Easy(7) = "AC Milan"
        Options_button3Easy(8) = "Liverpool FC"


        Options_button1Medium(0) = "Sheffield FC MEDIUM"
        Options_button1Medium(1) = "Inglaterra MEDIUM"
        Options_button1Medium(2) = "cores vermelhas e azuis MEDIUM"
        Options_button1Medium(3) = "Rungrado May Day Stadium, na Coreia do Norte MEDIUM"
        Options_button1Medium(4) = "Palmeiras, Chapecoense, Fluminense MEDIUM"
        Options_button1Medium(5) = "Inglaterra MEDIUM"
        Options_button1Medium(6) = "cores vermelhas e azuis MEDIUM"
        Options_button1Medium(7) = "Rungrado May Day Stadium, na Coreia do Norte MEDIUM"
        Options_button1Medium(8) = "Palmeiras, Chapecoense, Fluminense MEDIUM"
        Options_button1Medium(9) = "Inglaterra MEDIUM"
        Options_button1Medium(10) = "cores vermelhas e azuis MEDIUM"
        Options_button1Medium(11) = "Rungrado May Day Stadium, na Coreia do Norte MEDIUM"
        Options_button1Medium(12) = "Palmeiras, Chapecoense, Fluminense MEDIUM"
        Options_button1Medium(13) = "Inglaterra MEDIUM"
        Options_button1Medium(14) = "cores vermelhas e azuis MEDIUM"
        Options_button1Medium(15) = "Rungrado May Day Stadium, na Coreia do Norte MEDIUM"
        Options_button1Medium(16) = "Palmeiras, Chapecoense, Fluminense MEDIUM"

        Options_button2Medium(0) = "FC Barcelona"
        Options_button2Medium(1) = "Real Madrid"
        Options_button2Medium(2) = "Atletico Madrid"
        Options_button2Medium(3) = "Juventus"
        Options_button2Medium(4) = "Manchester United"
        Options_button2Medium(5) = "Real Madrid"
        Options_button2Medium(6) = "Atletico Madrid"
        Options_button2Medium(7) = "Juventus"
        Options_button2Medium(8) = "Manchester United"
        Options_button2Medium(9) = "Real Madrid"
        Options_button2Medium(10) = "Atletico Madrid"
        Options_button2Medium(11) = "Juventus"
        Options_button2Medium(12) = "Manchester United"
        Options_button2Medium(13) = "Real Madrid"
        Options_button2Medium(14) = "Atletico Madrid"
        Options_button2Medium(15) = "Juventus"
        Options_button2Medium(16) = "Manchester United"

        Options_button3Medium(0) = "Chelsea FC"
        Options_button3Medium(1) = "Arsenal FC"
        Options_button3Medium(2) = "Paris Saint-Germain"
        Options_button3Medium(3) = "AC Milan"
        Options_button3Medium(4) = "Liverpool FC"
        Options_button3Medium(5) = "Arsenal FC"
        Options_button3Medium(6) = "Paris Saint-Germain"
        Options_button3Medium(7) = "AC Milan"
        Options_button3Medium(8) = "Liverpool FC"
        Options_button3Medium(9) = "Arsenal FC"
        Options_button3Medium(10) = "Paris Saint-Germain"
        Options_button3Medium(11) = "AC Milan"
        Options_button3Medium(12) = "Liverpool FC"
        Options_button3Medium(13) = "Arsenal FC"
        Options_button3Medium(14) = "Paris Saint-Germain"
        Options_button3Medium(15) = "AC Milan"
        Options_button3Medium(16) = "Liverpool FC"

        Options_button1Hard(0) = "Sheffield FC HARD"
        Options_button1Hard(1) = "Inglaterra HARD"
        Options_button1Hard(2) = "cores vermelhas e azuis HARD"
        Options_button1Hard(3) = "Rungrado May Day Stadium, na Coreia do Norte HARD"
        Options_button1Hard(4) = "Palmeiras, Chapecoense, Fluminense HARD"
        Options_button1Hard(5) = "Paris Saint-Germain"
        Options_button1Hard(6) = "AC Milan"
        Options_button1Hard(7) = "Liverpool FC"
        Options_button1Hard(8) = "Liverpool FC"
        Options_button1Hard(9) = "Paris Saint-Germain"
        Options_button1Hard(10) = "AC Milan"
        Options_button1Hard(11) = "Liverpool FC"
        Options_button1Hard(12) = "Liverpool FC"
        Options_button1Hard(13) = "Inglaterra HARD"
        Options_button1Hard(14) = "cores vermelhas e azuis HARD"
        Options_button1Hard(15) = "Rungrado May Day Stadium, na Coreia do Norte HARD"
        Options_button1Hard(16) = "Palmeiras, Chapecoense, Fluminense HARD"
        Options_button1Hard(17) = "Paris Saint-Germain"
        Options_button1Hard(18) = "AC Milan"
        Options_button1Hard(19) = "Liverpool FC"
        Options_button1Hard(20) = "Liverpool FC"
        Options_button1Hard(21) = "Paris Saint-Germain"
        Options_button1Hard(22) = "AC Milan"
        Options_button1Hard(23) = "Liverpool FC"
        Options_button1Hard(24) = "Liverpool FC"

        Options_button2Hard(0) = "FC Barcelona"
        Options_button2Hard(1) = "Real Madrid"
        Options_button2Hard(2) = "Atletico Madrid"
        Options_button2Hard(3) = "Juventus"
        Options_button2Hard(4) = "Manchester United"
        Options_button2Hard(5) = "Paris Saint-Germain"
        Options_button2Hard(6) = "AC Milan"
        Options_button2Hard(7) = "Liverpool FC"
        Options_button2Hard(8) = "Liverpool FC"
        Options_button2Hard(9) = "Paris Saint-Germain"
        Options_button2Hard(10) = "AC Milan"
        Options_button2Hard(11) = "Liverpool FC"
        Options_button2Hard(12) = "Liverpool FC"
        Options_button2Hard(13) = "Real Madrid"
        Options_button2Hard(14) = "Atletico Madrid"
        Options_button2Hard(15) = "Juventus"
        Options_button2Hard(16) = "Manchester United"
        Options_button2Hard(17) = "Paris Saint-Germain"
        Options_button2Hard(18) = "AC Milan"
        Options_button2Hard(19) = "Liverpool FC"
        Options_button2Hard(20) = "Liverpool FC"
        Options_button2Hard(21) = "Paris Saint-Germain"
        Options_button2Hard(22) = "AC Milan"
        Options_button2Hard(23) = "Liverpool FC"
        Options_button2Hard(24) = "Liverpool FC"

        Options_button3Hard(0) = "Chelsea FC"
        Options_button3Hard(1) = "Arsenal FC"
        Options_button3Hard(2) = "Paris Saint-Germain"
        Options_button3Hard(3) = "AC Milan"
        Options_button3Hard(4) = "Liverpool FC"
        Options_button3Hard(5) = "Paris Saint-Germain"
        Options_button3Hard(6) = "AC Milan"
        Options_button3Hard(7) = "Liverpool FC"
        Options_button3Hard(8) = "Liverpool FC"
        Options_button3Hard(9) = "Paris Saint-Germain"
        Options_button3Hard(10) = "AC Milan"
        Options_button3Hard(11) = "Liverpool FC"
        Options_button3Hard(12) = "Liverpool FC"
        Options_button3Hard(13) = "Arsenal FC"
        Options_button3Hard(14) = "Paris Saint-Germain"
        Options_button3Hard(15) = "AC Milan"
        Options_button3Hard(16) = "Liverpool FC"
        Options_button3Hard(17) = "Paris Saint-Germain"
        Options_button3Hard(18) = "AC Milan"
        Options_button3Hard(19) = "Liverpool FC"
        Options_button3Hard(20) = "Liverpool FC"
        Options_button3Hard(21) = "Paris Saint-Germain"
        Options_button3Hard(22) = "AC Milan"
        Options_button3Hard(23) = "Liverpool FC"
        Options_button3Hard(24) = "Liverpool FC"


        AnswersEasy(0) = 1
        AnswersEasy(1) = 1
        AnswersEasy(2) = 1
        AnswersEasy(3) = 1
        AnswersEasy(4) = 1
        AnswersEasy(5) = 1
        AnswersEasy(6) = 1
        AnswersEasy(7) = 1
        AnswersEasy(8) = 1

        AnswersMedium(0) = 1
        AnswersMedium(1) = 1
        AnswersMedium(2) = 1
        AnswersMedium(3) = 1
        AnswersMedium(4) = 1
        AnswersMedium(5) = 1
        AnswersMedium(6) = 1
        AnswersMedium(7) = 1
        AnswersMedium(8) = 1
        AnswersMedium(9) = 1
        AnswersMedium(10) = 1
        AnswersMedium(11) = 1
        AnswersMedium(12) = 1
        AnswersMedium(13) = 1
        AnswersMedium(14) = 1
        AnswersMedium(15) = 1
        AnswersMedium(16) = 1


        AnswersHard(0) = 1
        AnswersHard(1) = 1
        AnswersHard(2) = 1
        AnswersHard(3) = 1
        AnswersHard(4) = 1
        AnswersHard(5) = 1
        AnswersHard(6) = 1
        AnswersHard(7) = 1
        AnswersHard(8) = 1
        AnswersHard(9) = 1
        AnswersHard(10) = 1
        AnswersHard(11) = 1
        AnswersHard(12) = 1
        AnswersHard(13) = 1
        AnswersHard(14) = 1
        AnswersHard(15) = 1
        AnswersHard(16) = 1
        AnswersHard(17) = 1
        AnswersHard(18) = 1
        AnswersHard(19) = 1
        AnswersHard(20) = 1
        AnswersHard(21) = 1
        AnswersHard(22) = 1
        AnswersHard(23) = 1
        AnswersHard(24) = 1



        start_button.Visible = True
        Começar.Visible = False
        Começar2.Visible = False
        Começar3.Visible = False


        label1 = New Label
        label1.Left = 0
        label1.Top = 0

        label1.Text = Counter.ToString
        Controls.Add(label1)
        label1.Visible = False
        Timer1.Interval = 1000






        question_label = New Label
        question_label.Left = 250
        question_label.Top = 50
        question_label.Width = 800
        question_label.Text = QuestionsEasy(Question_number)
        Controls.Add(CType(question_label, Control))
        question_label.Visible = False


        option1 = New Button
        option1.Location = New Point(200, 100)
        option1.Width = 400
        option1.Text = Options_button1Easy(Question_number)
        Controls.Add(option1)
        option1.Visible = False


        option2 = New Button
        option2.Location = New Point(200, 200)
        option2.Width = 400
        option2.Text = Options_button2Easy(Question_number)
        Controls.Add(option2)
        option2.Visible = False

        option3 = New Button
        option3.Location = New Point(200, 300)
        option3.Width = 400
        option3.Text = Options_button3Easy(Question_number)
        Controls.Add(option3)
        option3.Visible = False


        voltar_button = New Button
        voltar_button.Location = New Point(340, 300)
        voltar_button.Width = 100
        voltar_button.Text = "Voltar"
        Controls.Add(voltar_button)
        voltar_button.Visible = False

        'Game over Late night vibes
        GameOver_label = New Label
        GameOver_label.Left = 300
        GameOver_label.Top = 100
        GameOver_label.Width = 600
        GameOver_label.Text = "Game Over!"
        Controls.Add(CType(GameOver_label, Control))
        GameOver_label.Visible = False

        Score_label = New Label
        Score_label.Left = 300
        Score_label.Top = 200
        Score_label.Width = 600
        Score_label.Text = "Score"
        Controls.Add(CType(Score_label, Control))
        Score_label.Visible = False


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Counter -= 1
        label1.Text = Counter.ToString

        If Counter = 0 Then
            Timer1.Stop()
            GameOver_label.Visible = True
            question_label.Visible = False
            option1.Visible = False
            option2.Visible = False
            option3.Visible = False
        End If

    End Sub

    Private Sub Option1_Click(sender As Object, e As EventArgs) Handles option1.Click
        'Check if the option is the correct option





        If Question_number >= (Difficulty * 8) Then


            GameOver_label.Visible = True
            Score_label.Text = "A sua pontuação foi " & Correct_answers & " De " & Difficulty * 8
            MessageBox.Show("A sua pontuação foi " & Correct_answers & " De " & Difficulty * 8)
            Score_label.Visible = True

            question_label.Visible = False
            option1.Visible = False
            option2.Visible = False
            option3.Visible = False
            Question_number = 0
            Counter = 100
            Timer1.Stop()
        Else

            If Difficulty = 1 Then
                question_label.Text = QuestionsEasy(Question_number)
                option1.Text = Options_button1Easy(Question_number)
                option2.Text = Options_button2Easy(Question_number)
                option3.Text = Options_button3Easy(Question_number)

                If Question_number = (Difficulty * 8) - 1 Then
                    Dim userInput As String
                    userInput = InputBox("Ultima questão:", "Name Input", "John Doe")
                    MessageBox.Show("Hello, " & userInput & "!")
                End If
                If AnswersEasy(Question_number) = 1 Then
                    Correct_answers += 1
                End If
            End If
            If Difficulty = 2 Then
                question_label.Text = QuestionsMedium(Question_number)

                option1.Text = Options_button1Medium(Question_number)
                option2.Text = Options_button2Medium(Question_number)
                option3.Text = Options_button3Medium(Question_number)
                If AnswersMedium(Question_number) = 1 Then
                    Correct_answers += 1
                End If
            End If

            If Difficulty = 3 Then
                question_label.Text = QuestionsHard(Question_number)
                option1.Text = Options_button1Hard(Question_number)
                option2.Text = Options_button2Hard(Question_number)
                option3.Text = Options_button3Hard(Question_number)

                If AnswersHard(Question_number) = 1 Then
                    Correct_answers += 1
                End If
            End If
            Question_number += 1



        End If


    End Sub
    Private Sub Option2_Click(sender As Object, e As EventArgs) Handles option2.Click
        'Check if the option is the correct option
        If Question_number >= (Difficulty * 8) Then


            GameOver_label.Visible = True
            Score_label.Text = "A sua pontuação foi " & Correct_answers & " De " & Difficulty * 8
            Score_label.Visible = True
            question_label.Visible = False
            option1.Visible = False
            option2.Visible = False
            option3.Visible = False
            Question_number = 0
            Counter = 100
            Timer1.Stop()
        Else

            If Difficulty = 1 Then
                question_label.Text = QuestionsEasy(Question_number)
                option1.Text = Options_button1Easy(Question_number)
                option2.Text = Options_button2Easy(Question_number)
                option3.Text = Options_button3Easy(Question_number)
                If AnswersEasy(Question_number) = 2 Then
                    Correct_answers += 1
                End If
            End If
            If Difficulty = 2 Then
                question_label.Text = QuestionsMedium(Question_number)

                option1.Text = Options_button1Medium(Question_number)
                option2.Text = Options_button2Medium(Question_number)
                option3.Text = Options_button3Medium(Question_number)
                If AnswersMedium(Question_number) = 2 Then
                    Correct_answers += 1
                End If
            End If

            If Difficulty = 3 Then
                question_label.Text = QuestionsHard(Question_number)
                option1.Text = Options_button1Hard(Question_number)
                option2.Text = Options_button2Hard(Question_number)
                option3.Text = Options_button3Hard(Question_number)

                If AnswersHard(Question_number) = 2 Then
                    Correct_answers += 1
                End If
            End If
            Question_number += 1



        End If

    End Sub

    Private Sub Option3_Click(sender As Object, e As EventArgs) Handles option3.Click
        'Check if the option is the correct option
        'Tomorrow: Work on the game over mechanics and display the score // Change the difficulty or let other member of the group make the other part with forms, actually not


        'nota: adicionar som com este comando=> My.Computer.Audio.Play("C:\path\to\soundfile.wav", AudioPlayMode.WaitToComplete)
        If Question_number >= (Difficulty * 8) Then


            GameOver_label.Visible = True
            Score_label.Text = "A sua pontuação foi " & Correct_answers & " De " & Difficulty * 8
            Score_label.Visible = True
            question_label.Visible = False
            option1.Visible = False
            option2.Visible = False
            option3.Visible = False
            Question_number = 0
            Counter = 100
            Timer1.Stop()
        Else

            If Difficulty = 1 Then
                question_label.Text = QuestionsEasy(Question_number)
                option1.Text = Options_button1Easy(Question_number)
                option2.Text = Options_button2Easy(Question_number)
                option3.Text = Options_button3Easy(Question_number)
                If AnswersEasy(Question_number) = 3 Then
                    Correct_answers += 1
                End If
            End If
            If Difficulty = 2 Then
                question_label.Text = QuestionsMedium(Question_number)

                option1.Text = Options_button1Medium(Question_number)
                option2.Text = Options_button2Medium(Question_number)
                option3.Text = Options_button3Medium(Question_number)
                If AnswersMedium(Question_number) = 3 Then
                    Correct_answers += 1
                End If
            End If

            If Difficulty = 3 Then
                question_label.Text = QuestionsHard(Question_number)
                option1.Text = Options_button1Hard(Question_number)
                option2.Text = Options_button2Hard(Question_number)
                option3.Text = Options_button3Hard(Question_number)

                If AnswersHard(Question_number) = 3 Then
                    Correct_answers += 1
                End If
            End If
            Question_number += 1



        End If

    End Sub

    Private Sub start_button_Click(sender As Object, e As EventArgs) Handles start_button.Click
        Dim userInput As String
        userInput = InputBox("Please enter your name:", "Name Input", "John Doe")
        MessageBox.Show("Hello, " & userInput & "!")

        Começar.Visible = True
        Começar2.Visible = True
        Começar3.Visible = True
        voltar_button.Visible = True
        Regras.Visible = False
        Titulo.Visible = False
        start_button.Visible = False
    End Sub
    Private Sub voltar_button_Click(sender As Object, e As EventArgs) Handles voltar_button.Click
        start_button.Visible = True

        Começar.Visible = False
        Começar2.Visible = False
        Começar3.Visible = False
        voltar_button.Visible = False
        Regras.Visible = True
        Titulo.Visible = True

        GameOver_label.Visible = False
        Score_label.Visible = False
        Correct_answers = 0
        label1.Visible = False
    End Sub
End Class
