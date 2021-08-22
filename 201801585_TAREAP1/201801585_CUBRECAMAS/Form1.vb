Imports System.Math
Public Class Form1
    Private Sub rdbImperial_CheckedChanged(sender As Object, e As EventArgs) Handles rdbImperial.CheckedChanged
        If rdbImperial.Checked Then
            lblimperial.Visible = True
            MO = MOimperial
            Yarda = Yimperial
            grpMateriales.Enabled = True
        Else
            lblimperial.Visible = False
        End If

    End Sub

    Private Sub rdbMatrimonial_CheckedChanged(sender As Object, e As EventArgs) Handles rdbMatrimonial.CheckedChanged
        If rdbMatrimonial.Checked Then
            lblMatrimonial.Visible = True
            MO = MOmatrimonial
            Yarda = Ymatrimonial
            grpMateriales.Enabled = True
        Else
            lblMatrimonial.Visible = False
        End If
    End Sub

    Private Sub rdbQueen_CheckedChanged(sender As Object, e As EventArgs) Handles rdbQueen.CheckedChanged
        If rdbQueen.Checked Then
            lblQueen.Visible = True
            MO = MOqueen
            Yarda = Yqueen
            grpMateriales.Enabled = True
        Else
            lblQueen.Visible = False
        End If
    End Sub

    Private Sub rdbKing_CheckedChanged(sender As Object, e As EventArgs) Handles rdbKing.CheckedChanged
        If rdbKing.Checked Then
            lblKing.Visible = True
            MO = MOking
            Yarda = Yking
            grpMateriales.Enabled = True
        Else
            lblKing.Visible = False
        End If
    End Sub

    Private Sub chqLino_CheckedChanged(sender As Object, e As EventArgs) Handles chqLino.CheckedChanged
        If chqLino.Checked Then
            txtLino.Enabled = True
            txtLino.Focus()
        Else
            txtLino.Enabled = False
            txtLino.Clear()
        End If
    End Sub

    Private Sub chqAlgodon_CheckedChanged(sender As Object, e As EventArgs) Handles chqAlgodon.CheckedChanged
        If chqAlgodon.Checked Then
            txtAlgodon.Enabled = True
            txtAlgodon.Focus()
        Else
            txtAlgodon.Enabled = False
            txtAlgodon.Clear()
        End If
    End Sub

    Private Sub chqSeda_CheckedChanged(sender As Object, e As EventArgs) Handles chqSeda.CheckedChanged
        If chqSeda.Checked Then
            txtSeda.Enabled = True
            txtSeda.Focus()
        Else
            txtSeda.Enabled = False
            txtSeda.Clear()
        End If
    End Sub

    Private Sub chqHilo_CheckedChanged(sender As Object, e As EventArgs) Handles chqHilo.CheckedChanged
        If chqHilo.Checked Then
            txtHilo.Enabled = True
            txtHilo.Focus()
        Else
            txtHilo.Enabled = False
            txtHilo.Clear()
        End If
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        If rdbImperial.Checked = False And rdbMatrimonial.Checked = False And rdbQueen.Checked = False And rdbKing.Checked = False Then
            MsgBox("Seleccione un tamaño de cubrecama",, "Error")
            Exit Sub
        ElseIf chqLino.Checked = False And chqAlgodon.Checked = False And chqSeda.Checked = False And chqHilo.Checked = False Then
            MsgBox("Seleccione al menos un tipo de material",, "Error")
            Exit Sub
        End If
        Ylino = Val(txtLino.Text)
        Yalgodon = Val(txtAlgodon.Text)
        Yseda = Val(txtSeda.Text)
        Yhilo = Val(txtHilo.Text)
        Material = Round((Ylino + Yalgodon + Yseda + Yhilo), 3)
        If Material <> Yarda Then
            MsgBox("La suma total de yardas de material debe ser igual a:" + Str(Yarda) + " yardas" + vbCrLf + "Su total ahora es:" + Str(Material) + " yardas",, "Error")
            Exit Sub
        Else
            Clino = Round(Ylino * lino, 2)
            Calgodon = Round(Yalgodon * algodon, 2)
            Cseda = Round(Yseda * seda, 2)
            Chilo = Round(Yhilo * hilo, 2)
            Costo = Round(MO + Clino + Calgodon + Cseda + Chilo, 2)

            Me.Hide()
            Form2.Show()
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        If MsgBox("¿Desea limpiar los datos?", vbQuestion + vbYesNo, "LIMPIEZA DE DATOS") = vbYes Then
            Limpiar()
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If MsgBox("¿DESEA SALIR?", vbQuestion + vbYesNo, "SALIR DEL PROGRAMA") = vbYes Then
            'Cierre del programa
            Me.Close()
        End If
    End Sub
End Class
