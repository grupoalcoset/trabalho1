
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


    Private WithEvents RadioButton1 As RadioButton
    Private WithEvents RadioButton2 As RadioButton
    Private WithEvents RadioButton3 As RadioButton
    Private WithEvents TextBox1 As TextBox


    Private Correct_answers As Integer = 0
    Private question_label As Label
    Private Question_number As Integer = 0
    Private label1 As Label
    Private GameOver_label As Label
    Private Score_label As Label

    Private WithEvents proximaQuestao As Button

    Private WithEvents voltar_button As Button


    Private Interface Questao

        Function PegarQuestao() As String

    End Interface
    Public Class EscolhaMultipla
        Private textoQuestao As String
        Private escolhas As String()
        Private escolhaCorreta As String
        Private tipo As String

        Public Sub New(textQuestao As String, escolhas As String(), escolhaCorreta As String, tipoQuestao As String)
            Me.textoQuestao = textoQuestao
            Me.escolhas = escolhas
            Me.escolhaCorreta = escolhaCorreta
            Me.tipo = tipoQuestao

        End Sub


    End Class

    Public Class VerdadeiroFalso
        Private textoQuestao As String
        Private escolhas As String()
        Private escolhaCorreta As String
        Private tipo As String


        'No verdadeiro e falso, as escolhas são apenas verdadeiro ou falso
        Public Sub New(textQuestao As String, escolhas As String(), escolhaCorreta As String, tipoQuestao As String)
            Me.textoQuestao = textoQuestao
            Me.escolhas = escolhas
            Me.escolhaCorreta = escolhaCorreta
            Me.tipo = tipoQuestao

        End Sub


    End Class

    Public Class Escrever
        Private textoQuestao As String
        Private escolhaCorreta As String
        Private tipo As String

        Public Sub New(textQuestao As String, escolhaCorreta As String, tipoQuestao As String)
            Me.textoQuestao = textoQuestao
            Me.escolhaCorreta = escolhaCorreta
            Me.tipo = tipoQuestao

        End Sub


    End Class

    Private indice_questao As Integer = 0
    'Afonso, cria outras 2 tabelas com outras questoes para os outros niveis como esta aqui em baixo. Tem tres tipos de questoes, EscolhaMultipla, VerdadeiroFalso e Escrever
    'Em cada tabela, pode adicionar mais questoes, seguindo esta aqui em baixo, para mudar o tipo, basta mudar o nome a verde e lembrar que para o tipo Escrever não tem as opcoes, a parte do meio, em {}
    'vou colocar alguns exemplos

    'Basta copiar e colocar dentro da tabela

    'EscolhaMultipla("Mudar a pergunta de escolha multipla", {"opcao1", "opcao2", "opcao3"}, "opcao1", "EscolhaMultipa")
    'VerdadeiroFalso("Mudar para a pergunta de vf ", {"Verdadeiro", "Falso"}, "Verdadeiro", "VerdadeiroFalso")
    'Escrever("Mudar para a pergunta de escrita ", "resposta, tipo 1997", "Escrever")

    'para fazer uma tabela nova, basta copiar isto:

    'Public questoes_tablea_dificuldade = {
    '   New EscolhaMultipla("Mudar a pergunta de escolha multipla", {"opcao1", "opcao2", "opcao3"}, "opcao1", "EscolhaMultipa"),
    '   coloque mais ...
    '}
    Public questoes_tablea_facil = {
        New EscolhaMultipla("Mudar a pergunta de escolha multipla", {"opcao1", "opcao2", "opcao3"}, "opcao1", "EscolhaMultipa"),
        New EscolhaMultipla("Mudar a pergunta de escolha multipla", {"opcao1", "opcao2", "opcao3"}, "opcao1", "EscolhaMultipa"),
        New EscolhaMultipla("Mudar a pergunta de escolha multipla", {"opcao1", "opcao2", "opcao3"}, "opcao1", "EscolhaMultipa")
    }
    Private Sub Facil()
        Dim questao_atual As Object = questoes_tablea_facil(indice_questao)
        question_label.Text = questao_atual.textoQuestao
        If questao_atual.tipo = "EscolhaMultipa" Then
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
            RadioButton1.Text = "True"
            RadioButton2.Text = "False"
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


    Private Sub Medio()
        'Afonso, crie esta funcao, basta copiar a facil e alterar o que achares preciso!

    End Sub

    Private Sub Dificil()
        'Afonso, crie esta funcao tambem, basta copiar a facil e alterar o que achares preciso!

    End Sub


    'Afonso, este Private Sub NextButton_Click não precisa de tocar
    Private userAnswers As String() = New String(questoes_tablea_facil.Length - 1) {}
    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles proximaQuestao.Click
        Dim questao_atual As Object = questoes_tablea_facil(indice_questao)
        ' Record the user's answer to the current question
        If questao_atual.tipo = "Escrever" Then
            If RadioButton1.Checked Then
                questao_atual(indice_questao) = RadioButton1.Text
            ElseIf RadioButton2.Checked Then
                questao_atual(indice_questao) = RadioButton2.Text
            ElseIf RadioButton3.Checked Then
                questao_atual(indice_questao) = RadioButton3.Text
            Else
                userAnswers(indice_questao) = ""
            End If
        ElseIf questao_atual.tipo = "Escrever" Then
            If RadioButton1.Checked Then
                userAnswers(indice_questao) = "True"
            ElseIf RadioButton2.Checked Then
                userAnswers(indice_questao) = "False"
            Else
                userAnswers(indice_questao) = ""
            End If
        ElseIf questao_atual.tipo = "Escrever" Then
            userAnswers(indice_questao) = TextBox1.Text
        End If

        ' Ir para a proxima questao 
        indice_questao += 1
        Dim tamanho_tabela_nivel As Integer = questoes_tablea_facil.Length
        If indice_questao < tamanho_tabela_nivel Then
            Facil()
        Else
            'Mostrar o que a pessoa escolheu em cada questão no final
            Dim results As String = ""
        End If

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



        label1.Visible = True

        Facil()
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

        Difficulty = 3




        label1.Visible = True


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
        label1.Top = 0



        label1.Text = Counter.ToString
        Controls.Add(label1)
        label1.Visible = False
        Timer1.Interval = 1000








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



        'Para o voltar é a mesma coisa
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

        GameOver_label.Visible = False
        Score_label.Visible = False
        Correct_answers = 0
        label1.Visible = False
    End Sub
End Class
