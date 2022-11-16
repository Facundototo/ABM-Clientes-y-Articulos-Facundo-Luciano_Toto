Public Class Form1
    Private Sub Carga_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Carga.Click
        nombre = TextBox.Text
        If nombre = "" Then
            MsgBox("Ingrese nombre", vbCritical, "Error")
        Else
            If Efectivo.Checked Then
                B_efectivo = True
                MediodePago = Efectivo.Text
            End If
            If Cuotas.Checked Then
                B_cuotas = True
                MediodePago = Cuotas.Text
            End If
        End If
    End Sub

    Private Sub Vlistas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Vlistas.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        End
    End Sub

    Private Sub Siguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Siguiente.Click
        Me.Hide()
        Form3.Show()

    End Sub
End Class
