Public Class frmHello
    Dim nome As String

    Private Sub btnHello_Click(sender As Object, e As EventArgs) Handles btnHello.Click
        nome = txtNome.Text
        lblHello.Text = lblHello.Text & " " & nome
    End Sub
End Class
