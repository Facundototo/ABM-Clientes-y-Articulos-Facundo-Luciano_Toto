Public Class Form1

    Private Sub Carga_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Carga.Click

        nombre = TextBox.Text

        If Efectivo.Checked Then
            B_efectivo = True
        End If

        If Cuotas.Checked Then
            B_cuotas = True
        End If





    End Sub

    Private Sub Vlistas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Vlistas.Click
        Me.Hide()
        Form2.Show()



    End Sub

    Private Sub Cuotas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cuotas.CheckedChanged

    End Sub
End Class
