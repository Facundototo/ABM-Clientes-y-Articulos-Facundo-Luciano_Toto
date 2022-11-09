<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Carga = New System.Windows.Forms.Button()
        Me.Vlistas = New System.Windows.Forms.Button()
        Me.Siguiente = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Efectivo = New System.Windows.Forms.RadioButton()
        Me.Cuotas = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(144, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NOMBRE DEL CLIENTE"
        '
        'TextBox
        '
        Me.TextBox.Location = New System.Drawing.Point(144, 74)
        Me.TextBox.Name = "TextBox"
        Me.TextBox.Size = New System.Drawing.Size(126, 20)
        Me.TextBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(126, 174)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Forma de pago"
        '
        'Carga
        '
        Me.Carga.Location = New System.Drawing.Point(51, 266)
        Me.Carga.Name = "Carga"
        Me.Carga.Size = New System.Drawing.Size(75, 31)
        Me.Carga.TabIndex = 5
        Me.Carga.Text = "CARGA"
        Me.Carga.UseVisualStyleBackColor = True
        '
        'Vlistas
        '
        Me.Vlistas.Location = New System.Drawing.Point(165, 266)
        Me.Vlistas.Name = "Vlistas"
        Me.Vlistas.Size = New System.Drawing.Size(83, 31)
        Me.Vlistas.TabIndex = 6
        Me.Vlistas.Text = "VER LISTAS"
        Me.Vlistas.UseVisualStyleBackColor = True
        '
        'Siguiente
        '
        Me.Siguiente.Location = New System.Drawing.Point(285, 266)
        Me.Siguiente.Name = "Siguiente"
        Me.Siguiente.Size = New System.Drawing.Size(75, 31)
        Me.Siguiente.TabIndex = 7
        Me.Siguiente.Text = "SIGUIENTE"
        Me.Siguiente.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(165, 335)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 30)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "FIN"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Efectivo
        '
        Me.Efectivo.AutoSize = True
        Me.Efectivo.Location = New System.Drawing.Point(242, 152)
        Me.Efectivo.Name = "Efectivo"
        Me.Efectivo.Size = New System.Drawing.Size(64, 17)
        Me.Efectivo.TabIndex = 9
        Me.Efectivo.TabStop = True
        Me.Efectivo.Text = "Efectivo"
        Me.Efectivo.UseVisualStyleBackColor = True
        '
        'Cuotas
        '
        Me.Cuotas.AutoSize = True
        Me.Cuotas.Location = New System.Drawing.Point(242, 191)
        Me.Cuotas.Name = "Cuotas"
        Me.Cuotas.Size = New System.Drawing.Size(73, 17)
        Me.Cuotas.TabIndex = 10
        Me.Cuotas.TabStop = True
        Me.Cuotas.Text = "En cuotas"
        Me.Cuotas.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 407)
        Me.Controls.Add(Me.Cuotas)
        Me.Controls.Add(Me.Efectivo)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Siguiente)
        Me.Controls.Add(Me.Vlistas)
        Me.Controls.Add(Me.Carga)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Carga As System.Windows.Forms.Button
    Friend WithEvents Vlistas As System.Windows.Forms.Button
    Friend WithEvents Siguiente As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Efectivo As System.Windows.Forms.RadioButton
    Friend WithEvents Cuotas As System.Windows.Forms.RadioButton

End Class
