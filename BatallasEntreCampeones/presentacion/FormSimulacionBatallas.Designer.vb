<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSimulacionBatallas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cBoxCampeonA = New System.Windows.Forms.ComboBox()
        Me.cBoxCampeonB = New System.Windows.Forms.ComboBox()
        Me.richTxtEventosRonda = New System.Windows.Forms.RichTextBox()
        Me.lblVersus = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSimularRonda = New System.Windows.Forms.Button()
        Me.btnSimularBatalla = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cBoxCampeonA
        '
        Me.cBoxCampeonA.FormattingEnabled = True
        Me.cBoxCampeonA.Location = New System.Drawing.Point(21, 19)
        Me.cBoxCampeonA.Name = "cBoxCampeonA"
        Me.cBoxCampeonA.Size = New System.Drawing.Size(121, 21)
        Me.cBoxCampeonA.TabIndex = 0
        '
        'cBoxCampeonB
        '
        Me.cBoxCampeonB.FormattingEnabled = True
        Me.cBoxCampeonB.Location = New System.Drawing.Point(211, 19)
        Me.cBoxCampeonB.Name = "cBoxCampeonB"
        Me.cBoxCampeonB.Size = New System.Drawing.Size(121, 21)
        Me.cBoxCampeonB.TabIndex = 1
        '
        'richTxtEventosRonda
        '
        Me.richTxtEventosRonda.Location = New System.Drawing.Point(12, 74)
        Me.richTxtEventosRonda.Name = "richTxtEventosRonda"
        Me.richTxtEventosRonda.ReadOnly = True
        Me.richTxtEventosRonda.Size = New System.Drawing.Size(395, 272)
        Me.richTxtEventosRonda.TabIndex = 2
        Me.richTxtEventosRonda.Text = ""
        '
        'lblVersus
        '
        Me.lblVersus.AutoSize = True
        Me.lblVersus.Location = New System.Drawing.Point(162, 22)
        Me.lblVersus.Name = "lblVersus"
        Me.lblVersus.Size = New System.Drawing.Size(21, 13)
        Me.lblVersus.TabIndex = 3
        Me.lblVersus.Text = "VS"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cBoxCampeonA)
        Me.GroupBox1.Controls.Add(Me.lblVersus)
        Me.GroupBox1.Controls.Add(Me.cBoxCampeonB)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(395, 56)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Duelo entre:"
        '
        'btnSimularRonda
        '
        Me.btnSimularRonda.Location = New System.Drawing.Point(413, 74)
        Me.btnSimularRonda.Name = "btnSimularRonda"
        Me.btnSimularRonda.Size = New System.Drawing.Size(75, 49)
        Me.btnSimularRonda.TabIndex = 5
        Me.btnSimularRonda.Text = "SIMULAR RONDA"
        Me.btnSimularRonda.UseVisualStyleBackColor = True
        '
        'btnSimularBatalla
        '
        Me.btnSimularBatalla.Location = New System.Drawing.Point(413, 146)
        Me.btnSimularBatalla.Name = "btnSimularBatalla"
        Me.btnSimularBatalla.Size = New System.Drawing.Size(75, 48)
        Me.btnSimularBatalla.TabIndex = 6
        Me.btnSimularBatalla.Text = "SIMULAR BATALLA"
        Me.btnSimularBatalla.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(432, 358)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 7
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'FormSimulacionBatallas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(519, 384)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnSimularBatalla)
        Me.Controls.Add(Me.btnSimularRonda)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.richTxtEventosRonda)
        Me.Name = "FormSimulacionBatallas"
        Me.Text = "Simulación de Batallas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cBoxCampeonA As ComboBox
    Friend WithEvents cBoxCampeonB As ComboBox
    Friend WithEvents richTxtEventosRonda As RichTextBox
    Friend WithEvents lblVersus As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSimularRonda As Button
    Friend WithEvents btnSimularBatalla As Button
    Friend WithEvents btnSalir As Button
End Class
