Imports System.Math
Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Activated
        lblManodeObra.Text = "Q" + Str(MO)
        lblYlino.Text = Str(Ylino) + " Yardas"
        lblClino.Text = "Q" + Str(Val(Clino))
        lblYalgodon.Text = Str(Yalgodon) + " Yardas"
        lblCalgodon.Text = "Q" + Str(Calgodon)
        lblYseda.Text = Str(Yseda) + " Yardas"
        lblCseda.Text = "Q" + Str(Cseda)
        lblYhilo.Text = Str(Yhilo) + " Yardas"
        lblChilo.Text = "Q" + Str(Chilo)
        lblCostoTotal.Text = "Q" + Str(Costo)
        lblCosto.Text = "Q" + Str(Costo)
        PrecioVenta = Costo + Val(0.65 * Costo)
        lblPrecio.Text = "Q" + Str(Round(PrecioVenta))



    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        If MsgBox("¿Desea regresar?", vbQuestion + vbYesNo, "Mensaje") = vbYes Then
            Me.Hide()
            Form1.Show()
        End If

    End Sub

    Private Sub btnLimpiarRegresar_Click(sender As Object, e As EventArgs) Handles btnLimpiarRegresar.Click
        If MsgBox("¿Desea regresar y limpiar los datos?", vbQuestion + vbYesNo, "Mensaje") = vbYes Then
            Me.Hide()
            Form1.Show()
            Limpiar()
        End If
    End Sub
End Class