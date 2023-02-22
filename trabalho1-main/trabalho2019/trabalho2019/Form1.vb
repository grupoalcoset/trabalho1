
Imports System.Reflection
Imports System.Windows.Forms


'Afonso, eu coloquei muitas dicas para tentar facilitar o seu entendimento do que está a acontecer neste codigo, eu resolvi alterar a nossa estrutura antiga, pois ela só permitia um tipo de questoes
'por isso, eu estudei visual baisc e fiz desta maneira, eu quero que hoje tu cries as tabelas das questões com questoes personalizadas de futebol com as respostas corretas
'Também quero que no form cries à tua maneira a parte das regras, pode ser com outro form, e que também coloques imagens no Form1 e nas regras

'se tiveres alguma duvida fale comigo, mas se ela for muito grande e nada resulta, coloca no github que eu tento resolver! Boa sorte!


'Se apertares no botao das dificuldades, depois de colocar o nome, e der erro, aperte no botao vermelho lá em cima, fora do form, no visual studio para parar a aplicacao, é normal dar algum erro nas questoes, pq ainda nao terminei elas!
Public Class Form1
    Private Counter As Integer = 100
    Private Difficulty As Integer = 1
    Public score As Integer
    Public tamanho_tabela_nivel As Integer

    Private WithEvents RadioButton1 As RadioButton
    Private WithEvents RadioButton2 As RadioButton
    Private WithEvents RadioButton3 As RadioButton
    Public WithEvents TextBox1 As TextBox
    Public WithEvents Listbox_options As ListBox



    Public Correct_answers As Integer = 0
    Public WithEvents question_label As Label
    Public WithEvents score_greet As Label
    Public Question_number As Integer = 0
    Private label1 As Label
    Private GameOver_label As Label


    Private WithEvents proximaQuestao As Button

    Private WithEvents voltar_button As Button


    Private Interface Questao

        Function PegarQuestao() As String

    End Interface
    Public Class EscolhaMultipla
        Public textoQuestao As String
        Public escolhas As String()
        Public escolhaCorreta As String
        Public tipo As String

        Public Sub New(textQuestao As String, escolhas As String(), escolhaCorreta As String, tipoQuestao As String)
            Me.textoQuestao = textQuestao
            Me.escolhas = escolhas
            Me.escolhaCorreta = escolhaCorreta
            Me.tipo = tipoQuestao

        End Sub


    End Class



    Public Class VerdadeiroFalso
        Public textoQuestao As String
        Public escolhas As String()
        Public escolhaCorreta As String
        Public tipo As String


        'No verdadeiro e falso, as escolhas são apenas verdadeiro ou falso
        Public Sub New(textQuestao As String, escolhas As String(), escolhaCorreta As String, tipoQuestao As String)
            Me.textoQuestao = textQuestao
            Me.escolhas = escolhas
            Me.escolhaCorreta = escolhaCorreta
            Me.tipo = tipoQuestao

        End Sub


    End Class

    Public Class Escrever
        Public textoQuestao As String
        Public escolhaCorreta As String
        Public tipo As String

        Public Sub New(textQuestao As String, escolhaCorreta As String, tipoQuestao As String)
            Me.textoQuestao = textQuestao
            Me.escolhaCorreta = escolhaCorreta
            Me.tipo = tipoQuestao

        End Sub


    End Class

    Private indice_questao As Integer = 0
    'Afonso, cria outras 2 tabelas com outras questoes para os outros niveis como esta aqui em baixo. Tem tres tipos de questoes, EscolhaMultipla, VerdadeiroFalso e Escrever
    'Em cada tabela, pode adicionar mais questoes, seguindo esta aqui em baixo, para mudar o tipo, basta mudar o nome a verde e lembrar que para o tipo Escrever não tem as opcoes, a parte do meio, em {}
    'vou colocar alguns exemplos

    'Basta copiar e colocar dentro da tabela

    'EscolhaMultipla("Mudar a pergunta de escolha multipla", {"opcao1", "opcao2", "opcao3"}, "opcao1", "EscolhaMultipla")
    'VerdadeiroFalso("Mudar para a pergunta de vf ", {"Verdadeiro", "Falso"}, "Verdadeiro", "VerdadeiroFalso")
    'Escrever("Mudar para a pergunta de escrita ", "resposta, tipo 1997", "Escrever")

    'para fazer uma tabela nova, basta copiar isto:

    'Public questoes_tablea_dificuldade = {
    '   New EscolhaMultipla("Mudar a pergunta de escolha multipla", {"opcao1", "opcao2", "opcao3"}, "opcao1", "EscolhaMultipla"),
    '   coloque mais ...
    '}
    Public questoes_tablea_facil = {
        New EscolhaMultipla("Quanto tempo tem uma partida de futebol?", {"45 minutos", "100 minutos", "90 minutos"}, "90 minutos", "EscolhaMultipla"),
        New VerdadeiroFalso("A equipa de futebol com mais Copas do Mundo é a Espanha? ", {"Verdadeiro", "Falso"}, "Falso", "VerdadeiroFalso"),
        New Escrever("Quem é o atual artilheiro do FC Barcelona? (Primeiro e ultimo nome )", "robert lewandowski", "Escrever"),
        New EscolhaMultipla("Quantos jogadores uma equipa de futebol tem em jogo?", {"10", "6", "11"}, "11", "EscolhaMultipla"),
        New VerdadeiroFalso("O Real Madrid é a equipa com mais Champions League? ", {"Verdadeiro", "Falso"}, "Verdadeiro", "VerdadeiroFalso"),
        New Escrever("Qual jogador era conhecido como O Rei?", "pelé", "Escrever"),
        New EscolhaMultipla("Qual é o nome da primeira liga de futebol alemã?", {"Ligue 1", "Premier League", "Bundesliga"}, "bundesliga", "EscolhaMultipla"),
        New VerdadeiroFalso("Lionel Messi possui 8 bolas de ouro? ", {"Verdadeiro", "Falso"}, "Verdadeiro", "VerdadeiroFalso"),
        New Escrever("Quantas bolas de ouro ganhou Luís Figo? (por exemplo: dez ou duas)", "uma", "Escrever"),
        New EscolhaMultipla("Qual é a nacionalidade do jogador Johan Cruijff? ", {"Holandês", "Alemão", "Francês"}, "Holandês", "EscolhaMultipla"),
        New VerdadeiroFalso("Cristiano Ronaldo jogou no Real Madrid? ", {"Verdadeiro", "Falso"}, "Verdadeiro", "VerdadeiroFalso"),
        New Escrever("Qual instituição governa as federações de futebol ao redor do planeta? ", "fifa", "Escrever"),
        New EscolhaMultipla("Qual é a famosa alcunha que Cristiano Ronaldo possui? ", {"CR7", "R9", "R10"}, "CR7", "EscolhaMultipla"),
        New VerdadeiroFalso("A famosa alcunha de Eusébio era Pantera Negra? ", {"Verdadeiro", "Falso"}, "Verdadeiro", "VerdadeiroFalso"),
        New Escrever("Que equipa tem mais títulos de liga na Liga Nos? ", "benfica", "Escrever")
        }

    Private Sub Facil()
        Dim questao_atual As Object = questoes_tablea_facil(indice_questao)

        Dim texto_atual As String = questao_atual.textoQuestao
        Listbox_options.Visible = False
        voltar_button.Visible = False
        proximaQuestao.Visible = True
        question_label.Visible = True
        question_label.Text = texto_atual

        If questao_atual.tipo = "EscolhaMultipla" Then
            RadioButton1.Text = questao_atual.escolhas(0)
            RadioButton2.Text = questao_atual.escolhas(1)
            RadioButton3.Text = questao_atual.escolhas(2)
            RadioButton1.Checked = False
            RadioButton2.Checked = False
            RadioButton3.Checked = False
            RadioButton1.Visible = True
            RadioButton2.Visible = True
            RadioButton3.Visible = True
            TextBox1.Visible = False


        ElseIf questao_atual.tipo = "VerdadeiroFalso" Then


            ' Para verdadeiro e falso
            RadioButton1.Text = "Verdadeiro"
            RadioButton2.Text = "Falso"
            RadioButton1.Checked = False
            RadioButton2.Checked = False
            RadioButton1.Visible = True
            RadioButton2.Visible = True
            RadioButton3.Visible = False
            TextBox1.Visible = False
        ElseIf questao_atual.tipo = "Escrever" Then
            ' Para texto
            RadioButton1.Visible = False
            RadioButton2.Visible = False
            RadioButton3.Visible = False
            TextBox1.Text = ""
            TextBox1.Visible = True
        End If

    End Sub


    Public questoes_tablea_medio = {
        New EscolhaMultipla("Qual equipa foi a campeã do campeonato mundial de futebol de 2014? ", {"Alemanha", "Brasil", "França"}, "Alemanha", "EscolhaMultipla"),
        New VerdadeiroFalso("O melhor marcador da história da copa do mundo é Miroslav Klose? ", {"Verdadeiro", "Falso"}, "Verdadeiro", "VerdadeiroFalso"),
        New Escrever("Qual time famoso é conhecido como os Reds ", "liverpool", "Escrever"),
        New EscolhaMultipla("Qual guarda-redes soviético era conhecido como A Aranha Negra?", {"Lev Yashin", "Oliver Kahn", "Peter Schmeichel"}, "Lev Yashin", "EscolhaMultipla"),
        New VerdadeiroFalso("A última equipa do ex-jogador de futebol italiano Andrea Pirlo foi New York City?", {"Verdadeiro", "Falso"}, "Verdadeiro", "VerdadeiroFalso"),
        New Escrever("De que país é Mohammed Kudus? ", "Gana", "Escrever"),
        New EscolhaMultipla("Em que equipa Marco van Basten jogou?", {"PSV", "Ajax", "AZ Alkmar"}, "Ajax", "EscolhaMultipla"),
        New VerdadeiroFalso("Roberto Baggio ganhou uma bola de ouro. ", {"Verdadeiro", "Falso"}, "Verdadeiro", "VerdadeiroFalso"),
        New Escrever("Quantas copas do mundo tem Espanha? ", "uma", "Escrever"),
        New EscolhaMultipla("Em que posição o colombiano René Higuita jogou? ", {"guarda-redes", "defesa", "médio defensivo"}, "guarda-redes", "EscolhaMultipla")
        }

    Private Sub Medio()
        'Afonso, crie esta funcao, basta copiar a facil e alterar o que achares preciso!
        Dim questao_atual As Object = questoes_tablea_medio(indice_questao)

        Dim texto_atual As String = questao_atual.textoQuestao
        voltar_button.Visible = False
        proximaQuestao.Visible = True
        question_label.Visible = True
        question_label.Text = texto_atual

        If questao_atual.tipo = "EscolhaMultipla" Then
            RadioButton1.Text = questao_atual.escolhas(0)
            RadioButton2.Text = questao_atual.escolhas(1)
            RadioButton3.Text = questao_atual.escolhas(2)
            RadioButton1.Checked = False
            RadioButton2.Checked = False
            RadioButton3.Checked = False
            RadioButton1.Visible = True
            RadioButton2.Visible = True
            RadioButton3.Visible = True
            TextBox1.Visible = False


        ElseIf questao_atual.tipo = "VerdadeiroFalso" Then


            ' Para verdadeiro e falso
            RadioButton1.Text = "Verdadeiro"
            RadioButton2.Text = "Falso"
            RadioButton1.Checked = False
            RadioButton2.Checked = False
            RadioButton1.Visible = True
            RadioButton2.Visible = True
            RadioButton3.Visible = False
            TextBox1.Visible = False
        ElseIf questao_atual.tipo = "Escrever" Then
            ' Para texto
            RadioButton1.Visible = False
            RadioButton2.Visible = False
            RadioButton3.Visible = False
            TextBox1.Text = ""
            TextBox1.Visible = True
        End If

    End Sub

    Public questoes_tablea_dificil = {
        New EscolhaMultipla("Quem foi o primeiro africano a ganhar a Bola de Ouro? ", {"George Weah", "Samuel Eto", "Didier Drogba"}, "George Weah", "Listbox"),
        New VerdadeiroFalso("O animal que foi escolhido para a mascote do Mundial da Russía (2018) foi um lobo? ", {"Verdadeiro", "Falso"}, "Verdadeiro", "VerdadeiroFalso"),
        New Escrever("Em qual equipa italiana Michel Platini venceu a liga? ", "juventus", "Escrever"),
        New EscolhaMultipla("Em qual time europeu jogou o peruano Hugo (El Cholo) Sotil?", {"Napoli", "PSG", "FC Barcelona"}, "FC Barcelona", "Listbox"),
        New VerdadeiroFalso("O Sporting foi o primeiro clube profissional de Cristiano Ronaldo? ", {"Verdadeiro", "Falso"}, "Verdadeiro", "VerdadeiroFalso"),
        New Escrever("Contra qual país Wayne Rooney quebrou o recorde de golos da Inglaterra? ", "suiça", "Escrever"),
        New EscolhaMultipla("Qual jogador francês de ascendência argelina jogou pelo Real Madrid?", {"Zinedine Zidane", "Christian Lali Karembeu", "Claude Makelele"}, "Zinedine Zidane", "EscolhaMultipla")
        }

    Private Sub Dificil()
        'Afonso, crie esta funcao tambem, basta copiar a facil e alterar o que achares preciso!

        Dim questao_atual As Object = questoes_tablea_dificil(indice_questao)

        Dim texto_atual As String = questao_atual.textoQuestao
        voltar_button.Visible = False
        proximaQuestao.Visible = True
        question_label.Visible = True
        question_label.Text = texto_atual

        If questao_atual.tipo = "EscolhaMultipla" Then
            RadioButton1.Text = questao_atual.escolhas(0)
            RadioButton2.Text = questao_atual.escolhas(1)
            RadioButton3.Text = questao_atual.escolhas(2)
            RadioButton1.Checked = False
            RadioButton2.Checked = False
            RadioButton3.Checked = False
            RadioButton1.Visible = True
            RadioButton2.Visible = True
            RadioButton3.Visible = True
            TextBox1.Visible = False
            Listbox_options.Visible = False


        ElseIf questao_atual.tipo = "VerdadeiroFalso" Then


            ' Para verdadeiro e falso
            RadioButton1.Text = "Verdadeiro"
            RadioButton2.Text = "Falso"
            RadioButton1.Checked = False
            RadioButton2.Checked = False
            RadioButton1.Visible = True
            RadioButton2.Visible = True
            RadioButton3.Visible = False
            Listbox_options.Visible = False
            TextBox1.Visible = False
        ElseIf questao_atual.tipo = "Escrever" Then
            ' Para texto
            RadioButton1.Visible = False
            RadioButton2.Visible = False
            RadioButton3.Visible = False
            Listbox_options.Visible = False
            TextBox1.Text = ""
            TextBox1.Visible = True
        ElseIf questao_atual.tipo = "Listbox" Then
            ' Para texto
            Listbox_options.Visible = True
            RadioButton1.Visible = False
            RadioButton2.Visible = False
            RadioButton3.Visible = False
            TextBox1.Text = ""
            TextBox1.Visible = False
            Listbox_options.Items.Clear()
            Listbox_options.Items.Add(questao_atual.escolhas(0))
            Listbox_options.Items.Add(questao_atual.escolhas(1))
            Listbox_options.Items.Add(questao_atual.escolhas(2))

        End If

    End Sub



    'Afonso, este Private Sub NextButton_Click não precisa de tocar
    Private userAnswers As String() = New String(questoes_tablea_facil.Length - 1) {}
    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles proximaQuestao.Click

        Dim questoes_tabela As Object

        If Difficulty = 0 Then
            tamanho_tabela_nivel = questoes_tablea_facil.Length
        ElseIf Difficulty = 1 Then


            tamanho_tabela_nivel = questoes_tablea_medio.Length

        ElseIf Difficulty = 2 Then
            tamanho_tabela_nivel = questoes_tablea_dificil.Length


        End If
        System.Console.WriteLine(tamanho_tabela_nivel & " difficlty")

        'Ver se não é o fim de jogo
        If indice_questao < tamanho_tabela_nivel - 1 Then


            If Difficulty = 0 Then
                questoes_tabela = questoes_tablea_facil
            ElseIf Difficulty = 1 Then


                questoes_tabela = questoes_tablea_medio

            ElseIf Difficulty = 2 Then
                questoes_tabela = questoes_tablea_dificil


            End If
            Dim questao_atual As Object = questoes_tabela(indice_questao)

            If questao_atual.tipo = "EscolhaMultipla" Then

                Dim correto As String = questao_atual.escolhaCorreta


                If RadioButton1.Checked Then
                    'Make other if statement to check if it is the right answer
                    'Same to the other 

                    If correto = RadioButton1.Text Then

                        score += 1
                    End If
                ElseIf RadioButton2.Checked Then
                    If questao_atual.escolhaCorreta = RadioButton2.Text Then
                        score += 1
                    End If
                ElseIf RadioButton3.Checked Then
                    If questao_atual.escolhaCorreta = RadioButton3.Text Then
                        score += 1
                    End If
                Else
                    userAnswers(indice_questao) = ""
                End If
            ElseIf questao_atual.tipo = "VerdadeiroFalso" Then
                System.Console.WriteLine(questao_atual.escolhaCorreta & "hello world")
                If RadioButton1.Checked Then
                    If questao_atual.escolhaCorreta = RadioButton1.Text Then
                        score += 1
                    End If
                ElseIf RadioButton2.Checked Then
                    If questao_atual.escolhaCorreta = RadioButton2.Text Then
                        score += 1
                    End If
                Else
                    userAnswers(indice_questao) = ""
                End If
            ElseIf questao_atual.tipo = "Escrever" Then
                Dim resposta_utilizador As String = TextBox1.Text
                resposta_utilizador = resposta_utilizador.ToLower()
                If questao_atual.escolhaCorreta = resposta_utilizador Then
                    score += 1
                End If
            ElseIf questao_atual.tipo = "Listbox" Then
                ''change this part of the code

                If Listbox_options.SelectedItem IsNot Nothing Then
                    Dim resposta_utilizador As String = Listbox_options.SelectedItem.ToString()
                    ' do something with the selected answer
                    If questao_atual.escolhaCorreta = resposta_utilizador Then
                        score += 1
                    End If
                End If




            End If
            indice_questao += 1
            If Difficulty = 0 Then
                Facil()
            ElseIf Difficulty = 1 Then
                Medio()

            ElseIf Difficulty = 2 Then
                Dificil()


            End If

        Else
            'Condição para fim de jogo
            indice_questao = 0
            GameOver_label.Visible = True
            TextBox1.Visible = False
            voltar_button.Visible = True
            RadioButton1.Visible = False
            RadioButton2.Visible = False
            Timer1.Stop()
            RadioButton3.Visible = False
            question_label.Visible = False
            proximaQuestao.Visible = False
            score_greet.Text = "A sua pontuação foi " & score & " de " & tamanho_tabela_nivel - 1
            score_greet.Visible = True

        End If
        ' Record the user's answer to the current question

        ' Ir para a proxima questao 



        System.Console.WriteLine(tamanho_tabela_nivel)

    End Sub


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

        Difficulty = 0

        label1.Visible = True
        label1.Text = 100
        Facil()
        Timer1.Interval = 2000
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
        Difficulty = 1



        label1.Visible = True
        label1.Text = 60
        Medio()
        Counter = 60
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

        Difficulty = 2




        label1.Visible = True
        label1.Text = 40
        Dificil()

        Counter = 40
        Timer1.Interval = 1000
        Timer1.Start()


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load






        start_button.Visible = True
        Começar.Visible = False
        Começar2.Visible = False
        Começar3.Visible = False

        'Para as labels é diferente dos botoes

        label1 = New Label
        label1.Left = 0
        label1.Top = 30



        label1.Text = Counter.ToString
        Controls.Add(label1)
        label1.Visible = False
        Timer1.Interval = 2000


        question_label = New Label
        question_label.Text = "Pargunta"
        question_label.Top = 30
        question_label.Left = 190
        question_label.Width = 600
        Controls.Add(CType(question_label, Control))
        question_label.Visible = False



        'Isso vai mostrar a pontuação no final, Afonso, muda o top left e width 
        score_greet = New Label
        score_greet.Text = "A sua Pontuacão foi"
        score_greet.Top = 200
        score_greet.Left = 100
        score_greet.Width = 400
        Controls.Add(CType(score_greet, Control))
        score_greet.Visible = False

        TextBox1 = New TextBox
        TextBox1.Visible = False
        TextBox1.Location = New Point(340, 180)
        Controls.Add(CType(TextBox1, Control))


        Listbox_options = New ListBox
        Listbox_options.Visible = False
        Listbox_options.Location = New Point(330, 180)
        Controls.Add(CType(Listbox_options, Control))


        ' Afonso, Aqui no .Location é a localizacao na pagina de cada elemento, o (0,0) é no canto superior esquerdo
        proximaQuestao = New Button
        proximaQuestao.Location = New Point(340, 300)
        'Aqui em baixo é a largura 
        proximaQuestao.Width = 100

        'Aqui em baixo é o texto, o que está escrito dentro dele
        proximaQuestao.Text = "Próxima"
        Controls.Add(proximaQuestao)

        'Aqui é para ver se o botao é visivel quando ligamos o programa, na pagina inicial, com as regras
        proximaQuestao.Visible = False

        RadioButton1 = New RadioButton
        RadioButton2 = New RadioButton
        RadioButton3 = New RadioButton

        RadioButton1.Location = New Point(140, 100)
        RadioButton1.Width = 200

        RadioButton2.Location = New Point(190, 150)
        RadioButton2.Width = 200

        RadioButton3.Location = New Point(240, 200)
        RadioButton3.Width = 200

        Controls.Add(RadioButton1)
        Controls.Add(RadioButton2)
        Controls.Add(RadioButton3)

        RadioButton1.Visible = False
        RadioButton2.Visible = False
        RadioButton3.Visible = False
        'Para o voltar é a mesma coisa
        voltar_button = New Button
        voltar_button.Location = New Point(340, 380)
        voltar_button.Width = 100
        voltar_button.Height = 50
        voltar_button.Text = "Voltar"
        Controls.Add(voltar_button)
        voltar_button.Visible = False
        voltar_button.Font = New Font("Arial", 12, voltar_button.Font.Style.Bold)
        voltar_button.FlatStyle = FlatStyle.Flat
        voltar_button.FlatAppearance.BorderSize = 3
        voltar_button.FlatAppearance.BorderColor = Color.Green

        'Aparencia Butão Proxima
        proximaQuestao.Height = 50
        proximaQuestao.Font = New Font("Arial", 12, proximaQuestao.Font.Style.Bold)
        proximaQuestao.FlatStyle = FlatStyle.Flat
        proximaQuestao.FlatAppearance.BorderSize = 3
        proximaQuestao.FlatAppearance.BorderColor = Color.Green

        'Exibação do Game Over
        GameOver_label = New Label
        GameOver_label.Left = 250
        GameOver_label.Top = 130
        GameOver_label.Height = 60
        GameOver_label.Width = 800
        GameOver_label.Text = "Game Over!"
        Controls.Add(CType(GameOver_label, Control))
        GameOver_label.Visible = False
        GameOver_label.BackColor = Color.Transparent
        GameOver_label.Font = New Font("Arial", 40, GameOver_label.Font.Style.Bold)
        GameOver_label.ForeColor = Color.White

        'Exibição da pontuação
        score_greet.Left = 300
        score_greet.Top = 250
        score_greet.Height = 50
        score_greet.Width = 800
        score_greet.BackColor = Color.Transparent
        score_greet.Font = New Font("Arial", 12, score_greet.Font.Style.Bold)
        score_greet.ForeColor = Color.White

        'Exibição da pergunta
        question_label.BackColor = Color.Transparent
        question_label.Font = New Font("Arial", 10, question_label.Font.Style.Bold)
        question_label.ForeColor = Color.White

        'Exibição do radiao button 1
        RadioButton1.BackColor = Color.Transparent
        RadioButton1.Font = New Font("Arial", 14, RadioButton1.Font.Style.Bold)
        RadioButton1.ForeColor = Color.White

        'Exibição do radiao button 2
        RadioButton2.BackColor = Color.Transparent
        RadioButton2.Font = New Font("Arial", 14, RadioButton2.Font.Style.Bold)
        RadioButton2.ForeColor = Color.White

        'Exibição do radiao button 3
        RadioButton3.BackColor = Color.Transparent
        RadioButton3.Font = New Font("Arial", 14, RadioButton3.Font.Style.Bold)
        RadioButton3.ForeColor = Color.White

        'Exibição do tempo
        label1.BackColor = Color.Transparent
        label1.Font = New Font("Arial", 14, label1.Font.Style.Bold)
        label1.ForeColor = Color.White


        regras_label.Visible = False
        regras_label2.Visible = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Counter -= 1
        label1.Text = Counter.ToString

        If Counter = 0 Then
            Timer1.Stop()
            GameOver_label.Visible = True
            question_label.Visible = False
            Listbox_options.Visible = False
            RadioButton1.Visible = False
            RadioButton2.Visible = False
            RadioButton3.Visible = False
            TextBox1.Text = ""
            TextBox1.Visible = False
            proximaQuestao.Visible = False
            voltar_button.Visible = True
            score_greet.Visible = True
            score_greet.Text = "A sua pontuação foi " & score & " de " & tamanho_tabela_nivel - 1

        End If

    End Sub


    Private Sub start_button_Click(sender As Object, e As EventArgs) Handles start_button.Click
        Dim userInput As String
        userInput = InputBox("Coloque o seu nome:", "Name Input", "Joãozinho")
        MessageBox.Show("Boa sorte com o seu jogo, " & userInput & "!")



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
        regras_label.Visible = False
        regras_label2.Visible = False
        GameOver_label.Visible = False
        score_greet.Visible = False
        Correct_answers = 0
        label1.Visible = False
    End Sub

    Private Sub creditos_Click(sender As Object, e As EventArgs) Handles creditos.Click
        MessageBox.Show("Afonso Francisco e João")
    End Sub

    Private Sub Regras_Click(sender As Object, e As EventArgs) Handles Regras.Click

        voltar_button.Visible = True
        Regras.Visible = False
        Titulo.Visible = False
        start_button.Visible = False
        regras_label.Visible = True
        regras_label2.Visible = True

    End Sub
End Class
