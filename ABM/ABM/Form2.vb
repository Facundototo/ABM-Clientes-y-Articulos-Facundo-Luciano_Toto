Public Class Form2
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If B_efectivo Then
            ListBox1.Items.Add(nombre)
        End If
        If B_cuotas Then
            ListBox2.Items.Add(nombre)
        End If
    End Sub
End Class