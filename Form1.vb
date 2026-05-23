Public Class Form1
    Dim n1 As Double = Nothing, n2 As Double = Nothing
    Dim op As Char
    Dim resultado As String
    Dim calculos As New List(Of String)
    Dim limparDisplay As Boolean = False
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblConta.Enabled = False
        txtResultado.ReadOnly = True
    End Sub

    Private Sub btnNum_Click(sender As Object, e As EventArgs) Handles btn1.Click, btn0.Click, btn9.Click, btn8.Click, btn7.Click, btn6.Click, btn5.Click, btn4.Click, btn3.Click, btn2.Click

        If limparDisplay = True Then
            limparCampos()
        End If

        Dim botaoClicado As Button = CType(sender, Button)

        If txtResultado.Text.Contains(",") Then
            txtResultado.MaxLength = 6
        Else
            txtResultado.MaxLength = 5
        End If

        If (txtResultado.Text.Length >= txtResultado.MaxLength) Then
            MessageBox.Show("Só são aceites valores com máximo de 5 digitos", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        txtResultado.Text += botaoClicado.Text

    End Sub

    Private Sub btnOperacao_Click(sender As Object, e As EventArgs) Handles btnAdicao.Click, btnDivisao.Click, btnSubtracao.Click, btnMultiplicacao.Click

        If (String.IsNullOrWhiteSpace(txtResultado.Text)) Then
            Return
        End If

        Dim botaoClicado As Button = CType(sender, Button)
        If (botaoClicado.Text.ToLower = "x") Then
            op = "*"
        Else
            op = botaoClicado.Text
        End If

        If (limparDisplay = True) Then
            Double.TryParse(txtResultado.Text, n1)
            n2 = Nothing
            lblConta.Text = n1.ToString() + " " + op + " "
            txtResultado.Clear()
            limparDisplay = False
            Return
        End If

        If (n1 <> Nothing Or n2 <> Nothing) Then
            limparCampos()
            Return
        End If

        If (Not Double.TryParse(txtResultado.Text, n1)) Then
            limparCampos()
            MessageBox.Show("Valor inserido inválido.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        txtResultado.Clear()
        lblConta.Text = n1.ToString() + " " + op + " "
    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        limparCampos()
    End Sub

    Private Sub limparCampos()
        txtResultado.Clear()
        lblConta.Text = Nothing
        n1 = Nothing
        n2 = Nothing
        op = Nothing
        limparDisplay = False
    End Sub

    Private Sub btnResultado_Click(sender As Object, e As EventArgs) Handles btnResultado.Click

        If (String.IsNullOrWhiteSpace(txtResultado.Text) Or n1 = Nothing) Then
            limparCampos()
            Return
        End If

        If (Not Double.TryParse(txtResultado.Text, n2)) Then
            limparCampos()
            MessageBox.Show("Valor inserido inválido.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        lblConta.Text += n2.ToString + " ="

        Select Case op
            Case "+"c : resultado = (n1 + n2).ToString()
                txtResultado.Text = resultado
                calculos.Add(n1.ToString() + " + " + n2.ToString() + " = " + resultado)
            Case "-"c : resultado = (n1 - n2).ToString()
                txtResultado.Text = resultado
                calculos.Add(n1.ToString() + " - " + n2.ToString() + " = " + resultado)
            Case "*"c : resultado = (n1 * n2).ToString()
                txtResultado.Text = resultado
                calculos.Add(n1.ToString() + " x " + n2.ToString() + " = " + resultado)
            Case "/"c : If (n2 = 0) Then
                    limparCampos()
                    MessageBox.Show("Impossivel dividir por 0", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If
                resultado = (n1 / n2).ToString()
                txtResultado.Text = resultado
                calculos.Add(n1.ToString() + " / " + n2.ToString() + " = " + resultado)
        End Select

        Dim form2Aberto As Form2 = Application.OpenForms.OfType(Of Form2)().FirstOrDefault()
        If form2Aberto IsNot Nothing Then
            form2Aberto.calculos = Me.calculos
            form2Aberto.atualizaLista()
        End If

        limparDisplay = True
    End Sub

    Private Sub btnVirgula_Click(sender As Object, e As EventArgs) Handles btnVirgula.Click
        If limparDisplay = True Then
            limparCampos()
            txtResultado.Text = "0,"
            Return
        End If

        If txtResultado.Text.Contains(",") Then
            Return
        End If

        If txtResultado.Text = "" Then
            txtResultado.Text += "0,"
        Else
            txtResultado.Text += btnVirgula.Text
        End If
    End Sub

    Private Sub FecharToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FecharCalculadoraToolStripMenuItem.Click
        Dim dr As DialogResult = MessageBox.Show("Certeza que deseja sair da calculadora?", "CONFIRMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (dr = DialogResult.Yes) Then
            Application.Exit()
        End If
    End Sub

    Private Sub InfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InfoToolStripMenuItem.Click
        MessageBox.Show("Calculadora feita por Leandro Fialho EFA57", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnHistorico_Click(sender As Object, e As EventArgs) Handles btnHistorico.Click
        Dim form2Aberto As Form2 = Application.OpenForms.OfType(Of Form2)().FirstOrDefault()

        If (form2Aberto IsNot Nothing) Then
            If form2Aberto.WindowState = FormWindowState.Minimized Then
                form2Aberto.WindowState = FormWindowState.Normal
            End If
            form2Aberto.BringToFront()
            form2Aberto.Activate()
        Else
            Dim novoForm2 As Form2 = New Form2
            novoForm2.calculos = calculos
            novoForm2.Show()
        End If
    End Sub
End Class
