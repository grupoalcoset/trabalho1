<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Titulo = New System.Windows.Forms.Label()
        Me.Começar = New System.Windows.Forms.Button()
        Me.Regras = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Começar2 = New System.Windows.Forms.Button()
        Me.Começar3 = New System.Windows.Forms.Button()
        Me.start_button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Titulo
        '
        Me.Titulo.AutoSize = True
        Me.Titulo.Location = New System.Drawing.Point(648, 245)
        Me.Titulo.Name = "Titulo"
        Me.Titulo.Size = New System.Drawing.Size(140, 15)
        Me.Titulo.TabIndex = 0
        Me.Titulo.Text = "Qual é o time de futebol?"
        '
        'Começar
        '
        Me.Começar.Location = New System.Drawing.Point(338, 126)
        Me.Começar.Name = "Começar"
        Me.Começar.Size = New System.Drawing.Size(112, 23)
        Me.Começar.TabIndex = 1
        Me.Começar.Text = "Comecar Fácil"
        Me.Começar.UseVisualStyleBackColor = True
        '
        'Regras
        '
        Me.Regras.Location = New System.Drawing.Point(684, 350)
        Me.Regras.Name = "Regras"
        Me.Regras.Size = New System.Drawing.Size(75, 23)
        Me.Regras.TabIndex = 2
        Me.Regras.Text = "Regras"
        Me.Regras.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Começar2
        '
        Me.Começar2.Location = New System.Drawing.Point(338, 164)
        Me.Começar2.Name = "Começar2"
        Me.Começar2.Size = New System.Drawing.Size(112, 23)
        Me.Começar2.TabIndex = 3
        Me.Começar2.Text = "Começar Méido"
        Me.Começar2.UseVisualStyleBackColor = True
        '
        'Começar3
        '
        Me.Começar3.Location = New System.Drawing.Point(338, 208)
        Me.Começar3.Name = "Começar3"
        Me.Começar3.Size = New System.Drawing.Size(112, 23)
        Me.Começar3.TabIndex = 4
        Me.Começar3.Text = "Começar Dificil"
        Me.Começar3.UseVisualStyleBackColor = True
        '
        'start_button
        '
        Me.start_button.Location = New System.Drawing.Point(684, 294)
        Me.start_button.Name = "start_button"
        Me.start_button.Size = New System.Drawing.Size(75, 23)
        Me.start_button.TabIndex = 5
        Me.start_button.Text = "Iniciar"
        Me.start_button.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.start_button)
        Me.Controls.Add(Me.Começar3)
        Me.Controls.Add(Me.Começar2)
        Me.Controls.Add(Me.Regras)
        Me.Controls.Add(Me.Começar)
        Me.Controls.Add(Me.Titulo)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Titulo As Label
    Friend WithEvents Começar As Button
    Friend WithEvents Regras As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Começar2 As Button
    Friend WithEvents Começar3 As Button
    Friend WithEvents start_button As Button
End Class
