Public Class Form2
    Public calculos As New List(Of String)
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rtbCalculos.ReadOnly = True
        atualizaLista()
    End Sub

    Public Sub atualizaLista()
        rtbCalculos.Clear

        For Each calculo As String In calculos
            rtbCalculos.AppendText(calculo & Environment.NewLine)
        Next
    End Sub
End Class