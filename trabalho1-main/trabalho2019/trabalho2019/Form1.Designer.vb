<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Titulo = New System.Windows.Forms.Label()
        Me.start_button = New System.Windows.Forms.Button()
        Me.Regras = New System.Windows.Forms.Button()
        Me.Começar = New System.Windows.Forms.Button()
        Me.Começar2 = New System.Windows.Forms.Button()
        Me.Começar3 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.creditos = New System.Windows.Forms.ToolStripMenuItem()
        Me.regras_label = New System.Windows.Forms.Label()
        Me.regras_label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Titulo
        '
        Me.Titulo.BackColor = System.Drawing.Color.Transparent
        Me.Titulo.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Bold)
        Me.Titulo.ForeColor = System.Drawing.Color.White
        Me.Titulo.Location = New System.Drawing.Point(688, 279)
        Me.Titulo.Name = "Titulo"
        Me.Titulo.Size = New System.Drawing.Size(100, 50)
        Me.Titulo.TabIndex = 0
        Me.Titulo.Text = "Jogar"
        Me.Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'start_button
        '
        Me.start_button.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.start_button.FlatAppearance.BorderSize = 3
        Me.start_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.start_button.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Bold)
        Me.start_button.Location = New System.Drawing.Point(688, 332)
        Me.start_button.Name = "start_button"
        Me.start_button.Size = New System.Drawing.Size(100, 50)
        Me.start_button.TabIndex = 1
        Me.start_button.Text = "Começar"
        Me.start_button.UseVisualStyleBackColor = True
        '
        'Regras
        '
        Me.Regras.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.Regras.FlatAppearance.BorderSize = 3
        Me.Regras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Regras.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Bold)
        Me.Regras.Location = New System.Drawing.Point(688, 388)
        Me.Regras.Name = "Regras"
        Me.Regras.Size = New System.Drawing.Size(100, 50)
        Me.Regras.TabIndex = 2
        Me.Regras.Text = "Regras"
        Me.Regras.UseVisualStyleBackColor = True
        '
        'Começar
        '
        Me.Começar.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.Começar.FlatAppearance.BorderSize = 3
        Me.Começar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Começar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Começar.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Começar.ForeColor = System.Drawing.Color.Black
        Me.Começar.Location = New System.Drawing.Point(338, 79)
        Me.Começar.Name = "Começar"
        Me.Começar.Size = New System.Drawing.Size(100, 50)
        Me.Começar.TabIndex = 3
        Me.Começar.Text = "Fácil"
        Me.Começar.UseVisualStyleBackColor = True
        '
        'Começar2
        '
        Me.Começar2.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.Começar2.FlatAppearance.BorderSize = 3
        Me.Começar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Começar2.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Bold)
        Me.Começar2.Location = New System.Drawing.Point(338, 135)
        Me.Começar2.Name = "Começar2"
        Me.Começar2.Size = New System.Drawing.Size(100, 50)
        Me.Começar2.TabIndex = 4
        Me.Começar2.Text = "Médio"
        Me.Começar2.UseVisualStyleBackColor = True
        '
        'Começar3
        '
        Me.Começar3.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.Começar3.FlatAppearance.BorderSize = 3
        Me.Começar3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Começar3.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Bold)
        Me.Começar3.Location = New System.Drawing.Point(338, 191)
        Me.Começar3.Name = "Começar3"
        Me.Começar3.Size = New System.Drawing.Size(100, 50)
        Me.Começar3.TabIndex = 5
        Me.Começar3.Text = "Díficil"
        Me.Começar3.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.creditos})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'creditos
        '
        Me.creditos.Name = "creditos"
        Me.creditos.Size = New System.Drawing.Size(63, 20)
        Me.creditos.Text = "Créditos"
        '
        'regras_label
        '
        Me.regras_label.BackColor = System.Drawing.Color.Transparent
        Me.regras_label.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Bold)
        Me.regras_label.ForeColor = System.Drawing.Color.White
        Me.regras_label.Location = New System.Drawing.Point(116, 170)
        Me.regras_label.Name = "regras_label"
        Me.regras_label.Size = New System.Drawing.Size(615, 137)
        Me.regras_label.TabIndex = 7
        Me.regras_label.Text = resources.GetString("regras_label.Text")
        Me.regras_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'regras_label2
        '
        Me.regras_label2.BackColor = System.Drawing.Color.Transparent
        Me.regras_label2.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Bold)
        Me.regras_label2.ForeColor = System.Drawing.Color.White
        Me.regras_label2.Location = New System.Drawing.Point(101, 287)
        Me.regras_label2.Name = "regras_label2"
        Me.regras_label2.Size = New System.Drawing.Size(615, 34)
        Me.regras_label2.TabIndex = 8
        Me.regras_label2.Text = "Única regra: não pesquise na internet!"
        Me.regras_label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.trabalho2019.My.Resources.Resources.Futebol
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.regras_label2)
        Me.Controls.Add(Me.regras_label)
        Me.Controls.Add(Me.Começar3)
        Me.Controls.Add(Me.Começar2)
        Me.Controls.Add(Me.Começar)
        Me.Controls.Add(Me.Regras)
        Me.Controls.Add(Me.start_button)
        Me.Controls.Add(Me.Titulo)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "FutQuiz"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Titulo As Label
    Friend WithEvents start_button As Button
    Friend WithEvents Regras As Button
    Friend WithEvents Começar As Button
    Friend WithEvents Começar2 As Button
    Friend WithEvents Começar3 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents creditos As ToolStripMenuItem
    Friend WithEvents regras_label As Label
    Friend WithEvents regras_label2 As Label
End Class
