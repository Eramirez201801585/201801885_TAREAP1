Module Module1
    Public Const MOimperial As Double = 65.5
    Public Const MOmatrimonial As Double = 85.99
    Public Const MOqueen As Double = 99.99
    Public Const MOking As Double = 105.99
    Public Const Yimperial As Byte = 3
    Public Const Ymatrimonial As Byte = 5
    Public Const Yqueen As Byte = 6
    Public Const Yking As Byte = 7
    Public Const lino As Double = 15.0
    Public Const algodon As Double = 23.99
    Public Const seda As Double = 30.99
    Public Const hilo As Double = 39.99
    Public MO As Double
    Public Yarda As Double
    Public Material As Double
    Public Ylino, Yalgodon, Yseda, Yhilo As Double
    Public Clino, Calgodon, Cseda, Chilo As Double
    Public Costo As Double
    Public PrecioVenta As Double


    Public Sub Limpiar()
        Form1.rdbImperial.Checked = False
        Form1.rdbMatrimonial.Checked = False
        Form1.rdbQueen.Checked = False
        Form1.rdbKing.Checked = False
        Form1.chqLino.Checked = False
        Form1.chqAlgodon.Checked = False
        Form1.chqSeda.Checked = False
        Form1.chqHilo.Checked = False
        Form1.txtLino.Clear()
        Form1.txtAlgodon.Clear()
        Form1.txtSeda.Clear()
        Form1.txtHilo.Clear()
        Form1.grpMateriales.Enabled = False
        Form2.lblManodeObra.Text = ""
        Form2.lblYlino.Text = ""
        Form2.lblClino.Text = ""
        Form2.lblYalgodon.Text = ""
        Form2.lblCalgodon.Text = ""
        Form2.lblYseda.Text = ""
        Form2.lblCseda.Text = ""
        Form2.lblYhilo.Text = ""
        Form2.lblChilo.Text = ""
        Form2.lblCostoTotal.Text = ""
        Form2.lblCosto.Text = ""
        Form2.lblPrecio.Text = ""

    End Sub
End Module
