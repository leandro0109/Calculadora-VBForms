<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        txtResultado = New TextBox()
        btnAdicao = New Button()
        btnMultiplicacao = New Button()
        btnResultado = New Button()
        btnSubtracao = New Button()
        btnDivisao = New Button()
        btnLimpar = New Button()
        btn1 = New Button()
        btn2 = New Button()
        btn3 = New Button()
        btn4 = New Button()
        btn5 = New Button()
        btn6 = New Button()
        btn7 = New Button()
        btn8 = New Button()
        btn9 = New Button()
        btn0 = New Button()
        btnHistorico = New Button()
        btnVirgula = New Button()
        lblConta = New Label()
        MenuStrip1 = New MenuStrip()
        InfoToolStripMenuItem = New ToolStripMenuItem()
        FecharCalculadoraToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtResultado
        ' 
        txtResultado.Anchor = AnchorStyles.None
        txtResultado.BackColor = Color.Gainsboro
        txtResultado.Font = New Font("Segoe UI", 27F)
        txtResultado.Location = New Point(31, 58)
        txtResultado.MaxLength = 5000
        txtResultado.Name = "txtResultado"
        txtResultado.Size = New Size(240, 55)
        txtResultado.TabIndex = 0
        txtResultado.TextAlign = HorizontalAlignment.Right
        ' 
        ' btnAdicao
        ' 
        btnAdicao.Anchor = AnchorStyles.None
        btnAdicao.Cursor = Cursors.Hand
        btnAdicao.Font = New Font("Segoe UI", 22F)
        btnAdicao.Location = New Point(206, 210)
        btnAdicao.Name = "btnAdicao"
        btnAdicao.Size = New Size(65, 60)
        btnAdicao.TabIndex = 1
        btnAdicao.Text = "+"
        btnAdicao.TextAlign = ContentAlignment.TopCenter
        btnAdicao.UseVisualStyleBackColor = True
        ' 
        ' btnMultiplicacao
        ' 
        btnMultiplicacao.Anchor = AnchorStyles.None
        btnMultiplicacao.Cursor = Cursors.Hand
        btnMultiplicacao.Font = New Font("Segoe UI", 14F)
        btnMultiplicacao.ImageAlign = ContentAlignment.MiddleLeft
        btnMultiplicacao.Location = New Point(206, 368)
        btnMultiplicacao.Name = "btnMultiplicacao"
        btnMultiplicacao.Size = New Size(65, 60)
        btnMultiplicacao.TabIndex = 2
        btnMultiplicacao.Text = "X"
        btnMultiplicacao.UseVisualStyleBackColor = True
        ' 
        ' btnResultado
        ' 
        btnResultado.Anchor = AnchorStyles.None
        btnResultado.Cursor = Cursors.Hand
        btnResultado.Font = New Font("Segoe UI", 22F)
        btnResultado.Location = New Point(206, 530)
        btnResultado.Name = "btnResultado"
        btnResultado.Size = New Size(65, 60)
        btnResultado.TabIndex = 3
        btnResultado.Text = "="
        btnResultado.UseVisualStyleBackColor = True
        ' 
        ' btnSubtracao
        ' 
        btnSubtracao.Anchor = AnchorStyles.None
        btnSubtracao.Cursor = Cursors.Hand
        btnSubtracao.Font = New Font("Segoe UI", 25F)
        btnSubtracao.Location = New Point(206, 289)
        btnSubtracao.Name = "btnSubtracao"
        btnSubtracao.Size = New Size(65, 60)
        btnSubtracao.TabIndex = 4
        btnSubtracao.Text = "-"
        btnSubtracao.TextAlign = ContentAlignment.TopCenter
        btnSubtracao.UseVisualStyleBackColor = True
        ' 
        ' btnDivisao
        ' 
        btnDivisao.Anchor = AnchorStyles.None
        btnDivisao.Cursor = Cursors.Hand
        btnDivisao.Font = New Font("Segoe UI", 18F)
        btnDivisao.Location = New Point(206, 449)
        btnDivisao.Name = "btnDivisao"
        btnDivisao.Size = New Size(65, 60)
        btnDivisao.TabIndex = 5
        btnDivisao.Text = "/"
        btnDivisao.UseVisualStyleBackColor = True
        ' 
        ' btnLimpar
        ' 
        btnLimpar.Anchor = AnchorStyles.None
        btnLimpar.Cursor = Cursors.Hand
        btnLimpar.Font = New Font("Segoe UI", 11F)
        btnLimpar.Location = New Point(206, 132)
        btnLimpar.Name = "btnLimpar"
        btnLimpar.Size = New Size(65, 60)
        btnLimpar.TabIndex = 6
        btnLimpar.Text = "Limpar"
        btnLimpar.UseVisualStyleBackColor = True
        ' 
        ' btn1
        ' 
        btn1.Anchor = AnchorStyles.None
        btn1.Cursor = Cursors.Hand
        btn1.Font = New Font("Segoe UI", 16F)
        btn1.Location = New Point(31, 132)
        btn1.Name = "btn1"
        btn1.Size = New Size(65, 60)
        btn1.TabIndex = 7
        btn1.Text = "1"
        btn1.UseVisualStyleBackColor = True
        ' 
        ' btn2
        ' 
        btn2.Anchor = AnchorStyles.None
        btn2.Cursor = Cursors.Hand
        btn2.Font = New Font("Segoe UI", 16F)
        btn2.Location = New Point(119, 132)
        btn2.Name = "btn2"
        btn2.Size = New Size(65, 60)
        btn2.TabIndex = 8
        btn2.Text = "2"
        btn2.UseVisualStyleBackColor = True
        ' 
        ' btn3
        ' 
        btn3.Anchor = AnchorStyles.None
        btn3.Cursor = Cursors.Hand
        btn3.Font = New Font("Segoe UI", 16F)
        btn3.Location = New Point(31, 210)
        btn3.Name = "btn3"
        btn3.Size = New Size(65, 60)
        btn3.TabIndex = 9
        btn3.Text = "3"
        btn3.UseVisualStyleBackColor = True
        ' 
        ' btn4
        ' 
        btn4.Anchor = AnchorStyles.None
        btn4.Cursor = Cursors.Hand
        btn4.Font = New Font("Segoe UI", 16F)
        btn4.Location = New Point(119, 210)
        btn4.Name = "btn4"
        btn4.Size = New Size(65, 60)
        btn4.TabIndex = 10
        btn4.Text = "4"
        btn4.UseVisualStyleBackColor = True
        ' 
        ' btn5
        ' 
        btn5.Anchor = AnchorStyles.None
        btn5.Cursor = Cursors.Hand
        btn5.Font = New Font("Segoe UI", 16F)
        btn5.Location = New Point(31, 293)
        btn5.Name = "btn5"
        btn5.Size = New Size(65, 60)
        btn5.TabIndex = 11
        btn5.Text = "5"
        btn5.UseVisualStyleBackColor = True
        ' 
        ' btn6
        ' 
        btn6.Anchor = AnchorStyles.None
        btn6.Cursor = Cursors.Hand
        btn6.Font = New Font("Segoe UI", 16F)
        btn6.Location = New Point(119, 293)
        btn6.Name = "btn6"
        btn6.Size = New Size(65, 60)
        btn6.TabIndex = 12
        btn6.Text = "6"
        btn6.UseVisualStyleBackColor = True
        ' 
        ' btn7
        ' 
        btn7.Anchor = AnchorStyles.None
        btn7.Cursor = Cursors.Hand
        btn7.Font = New Font("Segoe UI", 16F)
        btn7.Location = New Point(31, 368)
        btn7.Name = "btn7"
        btn7.Size = New Size(65, 60)
        btn7.TabIndex = 13
        btn7.Text = "7"
        btn7.UseVisualStyleBackColor = True
        ' 
        ' btn8
        ' 
        btn8.Anchor = AnchorStyles.None
        btn8.Cursor = Cursors.Hand
        btn8.Font = New Font("Segoe UI", 16F)
        btn8.Location = New Point(119, 368)
        btn8.Name = "btn8"
        btn8.Size = New Size(65, 60)
        btn8.TabIndex = 14
        btn8.Text = "8"
        btn8.UseVisualStyleBackColor = True
        ' 
        ' btn9
        ' 
        btn9.Anchor = AnchorStyles.None
        btn9.Cursor = Cursors.Hand
        btn9.Font = New Font("Segoe UI", 16F)
        btn9.Location = New Point(31, 449)
        btn9.Name = "btn9"
        btn9.Size = New Size(65, 60)
        btn9.TabIndex = 15
        btn9.Text = "9"
        btn9.UseVisualStyleBackColor = True
        ' 
        ' btn0
        ' 
        btn0.Anchor = AnchorStyles.None
        btn0.Cursor = Cursors.Hand
        btn0.Font = New Font("Segoe UI", 16F)
        btn0.Location = New Point(119, 449)
        btn0.Name = "btn0"
        btn0.Size = New Size(65, 60)
        btn0.TabIndex = 16
        btn0.Text = "0"
        btn0.UseVisualStyleBackColor = True
        ' 
        ' btnHistorico
        ' 
        btnHistorico.Anchor = AnchorStyles.None
        btnHistorico.BackgroundImage = CType(resources.GetObject("btnHistorico.BackgroundImage"), Image)
        btnHistorico.BackgroundImageLayout = ImageLayout.Stretch
        btnHistorico.Cursor = Cursors.Hand
        btnHistorico.Font = New Font("Segoe UI", 14F)
        btnHistorico.Location = New Point(31, 530)
        btnHistorico.Name = "btnHistorico"
        btnHistorico.Size = New Size(65, 60)
        btnHistorico.TabIndex = 17
        btnHistorico.UseVisualStyleBackColor = True
        ' 
        ' btnVirgula
        ' 
        btnVirgula.Anchor = AnchorStyles.None
        btnVirgula.Cursor = Cursors.Hand
        btnVirgula.Font = New Font("Segoe UI", 22F)
        btnVirgula.Location = New Point(119, 530)
        btnVirgula.Name = "btnVirgula"
        btnVirgula.Size = New Size(65, 60)
        btnVirgula.TabIndex = 18
        btnVirgula.Text = ","
        btnVirgula.TextAlign = ContentAlignment.TopCenter
        btnVirgula.UseVisualStyleBackColor = True
        ' 
        ' lblConta
        ' 
        lblConta.Anchor = AnchorStyles.None
        lblConta.Location = New Point(31, 39)
        lblConta.Name = "lblConta"
        lblConta.Size = New Size(240, 26)
        lblConta.TabIndex = 19
        lblConta.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {InfoToolStripMenuItem, FecharCalculadoraToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(302, 24)
        MenuStrip1.TabIndex = 20
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' InfoToolStripMenuItem
        ' 
        InfoToolStripMenuItem.Name = "InfoToolStripMenuItem"
        InfoToolStripMenuItem.Size = New Size(40, 20)
        InfoToolStripMenuItem.Text = "Info"
        ' 
        ' FecharCalculadoraToolStripMenuItem
        ' 
        FecharCalculadoraToolStripMenuItem.Name = "FecharCalculadoraToolStripMenuItem"
        FecharCalculadoraToolStripMenuItem.Size = New Size(54, 20)
        FecharCalculadoraToolStripMenuItem.Text = "Fechar"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(302, 618)
        Controls.Add(lblConta)
        Controls.Add(btnVirgula)
        Controls.Add(btnHistorico)
        Controls.Add(btn0)
        Controls.Add(btn9)
        Controls.Add(btn8)
        Controls.Add(btn7)
        Controls.Add(btn6)
        Controls.Add(btn5)
        Controls.Add(btn4)
        Controls.Add(btn3)
        Controls.Add(btn2)
        Controls.Add(btn1)
        Controls.Add(btnLimpar)
        Controls.Add(btnDivisao)
        Controls.Add(btnSubtracao)
        Controls.Add(btnResultado)
        Controls.Add(btnMultiplicacao)
        Controls.Add(btnAdicao)
        Controls.Add(txtResultado)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Calculadora"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtResultado As TextBox
    Friend WithEvents btnAdicao As Button
    Friend WithEvents btnMultiplicacao As Button
    Friend WithEvents btnResultado As Button
    Friend WithEvents btnSubtracao As Button
    Friend WithEvents btnDivisao As Button
    Friend WithEvents btnLimpar As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btn0 As Button
    Friend WithEvents btnHistorico As Button
    Friend WithEvents btnVirgula As Button
    Friend WithEvents lblConta As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FecharCalculadoraToolStripMenuItem As ToolStripMenuItem

End Class
