<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Titulo = New System.Windows.Forms.Label()
        Me.start_button = New System.Windows.Forms.Button()
        Me.Regras = New System.Windows.Forms.Button()
        Me.Começar = New System.Windows.Forms.Button()
        Me.Começar2 = New System.Windows.Forms.Button()
        Me.Começar3 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Titulo
        '
        Me.Titulo.AutoSize = True
        Me.Titulo.Location = New System.Drawing.Point(713, 287)
        Me.Titulo.Name = "Titulo"
        Me.Titulo.Size = New System.Drawing.Size(39, 13)
        Me.Titulo.TabIndex = 0
        Me.Titulo.Text = "Label2"
        '
        'start_button
        '
        Me.start_button.Location = New System.Drawing.Point(716, 332)
        Me.start_button.Name = "start_button"
        Me.start_button.Size = New System.Drawing.Size(75, 23)
        Me.start_button.TabIndex = 1
        Me.start_button.Text = "Button1"
        Me.start_button.UseVisualStyleBackColor = True
        '
        'Regras
        '
        Me.Regras.Location = New System.Drawing.Point(716, 385)
        Me.Regras.Name = "Regras"
        Me.Regras.Size = New System.Drawing.Size(75, 23)
        Me.Regras.TabIndex = 2
        Me.Regras.Text = "Button2"
        Me.Regras.UseVisualStyleBackColor = True
        '
        'Começar
        '
        Me.Começar.Location = New System.Drawing.Point(338, 121)
        Me.Começar.Name = "Começar"
        Me.Começar.Size = New System.Drawing.Size(75, 23)
        Me.Começar.TabIndex = 3
        Me.Começar.Text = "Button3"
        Me.Começar.UseVisualStyleBackColor = True
        '
        'Começar2
        '
        Me.Começar2.Location = New System.Drawing.Point(338, 170)
        Me.Começar2.Name = "Começar2"
        Me.Começar2.Size = New System.Drawing.Size(75, 23)
        Me.Começar2.TabIndex = 4
        Me.Começar2.Text = "Button4"
        Me.Começar2.UseVisualStyleBackColor = True
        '
        'Começar3
        '
        Me.Começar3.Location = New System.Drawing.Point(338, 226)
        Me.Começar3.Name = "Começar3"
        Me.Começar3.Size = New System.Drawing.Size(75, 23)
        Me.Começar3.TabIndex = 5
        Me.Começar3.Text = "Button5"
        Me.Começar3.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Começar3)
        Me.Controls.Add(Me.Começar2)
        Me.Controls.Add(Me.Começar)
        Me.Controls.Add(Me.Regras)
        Me.Controls.Add(Me.start_button)
        Me.Controls.Add(Me.Titulo)
        Me.Name = "Form1"
        Me.Text = "Form1"
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
End Class
