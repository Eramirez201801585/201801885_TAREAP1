<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.grpMateriales = New System.Windows.Forms.GroupBox()
        Me.txtAlgodon = New System.Windows.Forms.TextBox()
        Me.chqHilo = New System.Windows.Forms.CheckBox()
        Me.chqSeda = New System.Windows.Forms.CheckBox()
        Me.chqAlgodon = New System.Windows.Forms.CheckBox()
        Me.chqLino = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtHilo = New System.Windows.Forms.TextBox()
        Me.txtSeda = New System.Windows.Forms.TextBox()
        Me.txtLino = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdbKing = New System.Windows.Forms.RadioButton()
        Me.rdbQueen = New System.Windows.Forms.RadioButton()
        Me.rdbMatrimonial = New System.Windows.Forms.RadioButton()
        Me.rdbImperial = New System.Windows.Forms.RadioButton()
        Me.lblKing = New System.Windows.Forms.Label()
        Me.lblQueen = New System.Windows.Forms.Label()
        Me.lblMatrimonial = New System.Windows.Forms.Label()
        Me.lblimperial = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.grpMateriales.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.grpMateriales)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(450, 180)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INGRESAR DATOS PARA FABICACIÓN"
        '
        'grpMateriales
        '
        Me.grpMateriales.Controls.Add(Me.txtAlgodon)
        Me.grpMateriales.Controls.Add(Me.chqHilo)
        Me.grpMateriales.Controls.Add(Me.chqSeda)
        Me.grpMateriales.Controls.Add(Me.chqAlgodon)
        Me.grpMateriales.Controls.Add(Me.chqLino)
        Me.grpMateriales.Controls.Add(Me.Label5)
        Me.grpMateriales.Controls.Add(Me.txtHilo)
        Me.grpMateriales.Controls.Add(Me.txtSeda)
        Me.grpMateriales.Controls.Add(Me.txtLino)
        Me.grpMateriales.Enabled = False
        Me.grpMateriales.Location = New System.Drawing.Point(224, 22)
        Me.grpMateriales.Name = "grpMateriales"
        Me.grpMateriales.Size = New System.Drawing.Size(221, 152)
        Me.grpMateriales.TabIndex = 1
        Me.grpMateriales.TabStop = False
        Me.grpMateriales.Text = "Material(es)"
        '
        'txtAlgodon
        '
        Me.txtAlgodon.Enabled = False
        Me.txtAlgodon.Location = New System.Drawing.Point(110, 68)
        Me.txtAlgodon.MaxLength = 4
        Me.txtAlgodon.Name = "txtAlgodon"
        Me.txtAlgodon.Size = New System.Drawing.Size(100, 23)
        Me.txtAlgodon.TabIndex = 4
        '
        'chqHilo
        '
        Me.chqHilo.AutoSize = True
        Me.chqHilo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chqHilo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chqHilo.Location = New System.Drawing.Point(7, 127)
        Me.chqHilo.Name = "chqHilo"
        Me.chqHilo.Size = New System.Drawing.Size(80, 19)
        Me.chqHilo.TabIndex = 7
        Me.chqHilo.Text = "hilo crudo"
        Me.chqHilo.UseVisualStyleBackColor = True
        '
        'chqSeda
        '
        Me.chqSeda.AutoSize = True
        Me.chqSeda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chqSeda.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chqSeda.Location = New System.Drawing.Point(7, 97)
        Me.chqSeda.Name = "chqSeda"
        Me.chqSeda.Size = New System.Drawing.Size(50, 19)
        Me.chqSeda.TabIndex = 5
        Me.chqSeda.Text = "seda"
        Me.chqSeda.UseVisualStyleBackColor = True
        '
        'chqAlgodon
        '
        Me.chqAlgodon.AutoSize = True
        Me.chqAlgodon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chqAlgodon.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chqAlgodon.Location = New System.Drawing.Point(7, 67)
        Me.chqAlgodon.Name = "chqAlgodon"
        Me.chqAlgodon.Size = New System.Drawing.Size(70, 19)
        Me.chqAlgodon.TabIndex = 3
        Me.chqAlgodon.Text = "algodón"
        Me.chqAlgodon.UseVisualStyleBackColor = True
        '
        'chqLino
        '
        Me.chqLino.AutoSize = True
        Me.chqLino.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chqLino.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chqLino.Location = New System.Drawing.Point(7, 37)
        Me.chqLino.Name = "chqLino"
        Me.chqLino.Size = New System.Drawing.Size(46, 19)
        Me.chqLino.TabIndex = 1
        Me.chqLino.Text = "lino"
        Me.chqLino.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(110, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Cantidad (Yardas)"
        '
        'txtHilo
        '
        Me.txtHilo.Enabled = False
        Me.txtHilo.Location = New System.Drawing.Point(110, 127)
        Me.txtHilo.MaxLength = 4
        Me.txtHilo.Name = "txtHilo"
        Me.txtHilo.Size = New System.Drawing.Size(100, 23)
        Me.txtHilo.TabIndex = 8
        '
        'txtSeda
        '
        Me.txtSeda.Enabled = False
        Me.txtSeda.Location = New System.Drawing.Point(110, 97)
        Me.txtSeda.MaxLength = 4
        Me.txtSeda.Name = "txtSeda"
        Me.txtSeda.Size = New System.Drawing.Size(100, 23)
        Me.txtSeda.TabIndex = 6
        '
        'txtLino
        '
        Me.txtLino.Enabled = False
        Me.txtLino.Location = New System.Drawing.Point(110, 37)
        Me.txtLino.MaxLength = 4
        Me.txtLino.Name = "txtLino"
        Me.txtLino.Size = New System.Drawing.Size(100, 23)
        Me.txtLino.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdbKing)
        Me.GroupBox2.Controls.Add(Me.rdbQueen)
        Me.GroupBox2.Controls.Add(Me.rdbMatrimonial)
        Me.GroupBox2.Controls.Add(Me.rdbImperial)
        Me.GroupBox2.Controls.Add(Me.lblKing)
        Me.GroupBox2.Controls.Add(Me.lblQueen)
        Me.GroupBox2.Controls.Add(Me.lblMatrimonial)
        Me.GroupBox2.Controls.Add(Me.lblimperial)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 30)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(211, 139)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tamaño de cubrecama"
        '
        'rdbKing
        '
        Me.rdbKing.AutoSize = True
        Me.rdbKing.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdbKing.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdbKing.Location = New System.Drawing.Point(7, 101)
        Me.rdbKing.Name = "rdbKing"
        Me.rdbKing.Size = New System.Drawing.Size(49, 19)
        Me.rdbKing.TabIndex = 4
        Me.rdbKing.Text = "King"
        Me.rdbKing.UseVisualStyleBackColor = True
        '
        'rdbQueen
        '
        Me.rdbQueen.AutoSize = True
        Me.rdbQueen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdbQueen.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdbQueen.Location = New System.Drawing.Point(7, 75)
        Me.rdbQueen.Name = "rdbQueen"
        Me.rdbQueen.Size = New System.Drawing.Size(60, 19)
        Me.rdbQueen.TabIndex = 3
        Me.rdbQueen.Text = "Queen"
        Me.rdbQueen.UseVisualStyleBackColor = True
        '
        'rdbMatrimonial
        '
        Me.rdbMatrimonial.AutoSize = True
        Me.rdbMatrimonial.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdbMatrimonial.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdbMatrimonial.Location = New System.Drawing.Point(7, 49)
        Me.rdbMatrimonial.Name = "rdbMatrimonial"
        Me.rdbMatrimonial.Size = New System.Drawing.Size(90, 19)
        Me.rdbMatrimonial.TabIndex = 2
        Me.rdbMatrimonial.Text = "Matrimonial"
        Me.rdbMatrimonial.UseVisualStyleBackColor = True
        '
        'rdbImperial
        '
        Me.rdbImperial.AutoSize = True
        Me.rdbImperial.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdbImperial.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdbImperial.Location = New System.Drawing.Point(7, 23)
        Me.rdbImperial.Name = "rdbImperial"
        Me.rdbImperial.Size = New System.Drawing.Size(68, 19)
        Me.rdbImperial.TabIndex = 1
        Me.rdbImperial.Text = "Imperial"
        Me.rdbImperial.UseVisualStyleBackColor = True
        '
        'lblKing
        '
        Me.lblKing.AutoSize = True
        Me.lblKing.Enabled = False
        Me.lblKing.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblKing.Location = New System.Drawing.Point(98, 101)
        Me.lblKing.Name = "lblKing"
        Me.lblKing.Size = New System.Drawing.Size(50, 15)
        Me.lblKing.TabIndex = 7
        Me.lblKing.Text = "7 yardas"
        Me.lblKing.Visible = False
        '
        'lblQueen
        '
        Me.lblQueen.AutoSize = True
        Me.lblQueen.Enabled = False
        Me.lblQueen.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblQueen.Location = New System.Drawing.Point(98, 75)
        Me.lblQueen.Name = "lblQueen"
        Me.lblQueen.Size = New System.Drawing.Size(50, 15)
        Me.lblQueen.TabIndex = 6
        Me.lblQueen.Text = "6 yardas"
        Me.lblQueen.Visible = False
        '
        'lblMatrimonial
        '
        Me.lblMatrimonial.AutoSize = True
        Me.lblMatrimonial.Enabled = False
        Me.lblMatrimonial.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMatrimonial.Location = New System.Drawing.Point(98, 49)
        Me.lblMatrimonial.Name = "lblMatrimonial"
        Me.lblMatrimonial.Size = New System.Drawing.Size(50, 15)
        Me.lblMatrimonial.TabIndex = 5
        Me.lblMatrimonial.Text = "5 yardas"
        Me.lblMatrimonial.Visible = False
        '
        'lblimperial
        '
        Me.lblimperial.AutoSize = True
        Me.lblimperial.Enabled = False
        Me.lblimperial.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblimperial.Location = New System.Drawing.Point(98, 26)
        Me.lblimperial.Name = "lblimperial"
        Me.lblimperial.Size = New System.Drawing.Size(50, 15)
        Me.lblimperial.TabIndex = 4
        Me.lblimperial.Text = "3 yardas"
        Me.lblimperial.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnSalir)
        Me.GroupBox4.Controls.Add(Me.btnLimpiar)
        Me.GroupBox4.Controls.Add(Me.btnCalcular)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 199)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(450, 53)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "ACCIONES"
        '
        'btnSalir
        '
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSalir.Location = New System.Drawing.Point(320, 22)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 2
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLimpiar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnLimpiar.Location = New System.Drawing.Point(176, 22)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 1
        Me.btnLimpiar.Text = "LIMPIAR"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnCalcular
        '
        Me.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCalcular.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCalcular.Location = New System.Drawing.Point(32, 22)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 0
        Me.btnCalcular.Text = "CALCULAR"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(467, 264)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DATOS"
        Me.GroupBox1.ResumeLayout(False)
        Me.grpMateriales.ResumeLayout(False)
        Me.grpMateriales.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents grpMateriales As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtHilo As TextBox
    Friend WithEvents txtSeda As TextBox
    Friend WithEvents txtLino As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblKing As Label
    Friend WithEvents lblQueen As Label
    Friend WithEvents lblMatrimonial As Label
    Friend WithEvents lblimperial As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnCalcular As Button
    Friend WithEvents rdbKing As RadioButton
    Friend WithEvents rdbQueen As RadioButton
    Friend WithEvents rdbMatrimonial As RadioButton
    Friend WithEvents rdbImperial As RadioButton
    Friend WithEvents chqHilo As CheckBox
    Friend WithEvents chqSeda As CheckBox
    Friend WithEvents chqAlgodon As CheckBox
    Friend WithEvents chqLino As CheckBox
    Friend WithEvents txtAlgodon As TextBox
End Class
