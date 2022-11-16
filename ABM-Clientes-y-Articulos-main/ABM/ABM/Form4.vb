Public Class Form4

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        LabelNom.Text = nombre
        PagoLabel.Text = MediodePago
        LabelProdu.Text = articulo
        LabelImp.Text = total
        total = 0
        valorG = 0
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Form2.Show()
    End Sub
End Class