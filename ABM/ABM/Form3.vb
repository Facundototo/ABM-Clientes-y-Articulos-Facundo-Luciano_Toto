Public Class Form3

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Otro.CheckedChanged
        InputBox("Ingrese la cantidad:", "CANTIDAD", otraUnidad)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        articulo = ComboBox.Text
        precio = TextBoxPrecio.Text
        If Unidad6.Checked Then
            valorG = 6
        End If
        If Unidad12.Checked Then
            valorG = 12
        End If
        If Otro.Checked Then
            valorG = otraUnidad
        End If

        If B_efectivo Then
            total = (precio * valorG) * 0.9
        End If
        If B_cuotas Then
            total = (precio * valorG) + (precio * valorG) * 0.85
        End If
    End Sub
End Class