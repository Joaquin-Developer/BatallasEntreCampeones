<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPrincipal
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
        Me.btnCampeones = New System.Windows.Forms.Button()
        Me.btnNuevaBatalla = New System.Windows.Forms.Button()
        Me.pnlFondo = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.gBoxABM = New System.Windows.Forms.GroupBox()
        Me.gBoxJugarBatalla = New System.Windows.Forms.GroupBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.pnlFondo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gBoxABM.SuspendLayout()
        Me.gBoxJugarBatalla.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCampeones
        '
        Me.btnCampeones.ForeColor = System.Drawing.Color.Black
        Me.btnCampeones.Location = New System.Drawing.Point(25, 19)
        Me.btnCampeones.Name = "btnCampeones"
        Me.btnCampeones.Size = New System.Drawing.Size(120, 26)
        Me.btnCampeones.TabIndex = 0
        Me.btnCampeones.Text = "Campeónes"
        Me.btnCampeones.UseVisualStyleBackColor = True
        '
        'btnNuevaBatalla
        '
        Me.btnNuevaBatalla.ForeColor = System.Drawing.Color.Black
        Me.btnNuevaBatalla.Location = New System.Drawing.Point(40, 19)
        Me.btnNuevaBatalla.Name = "btnNuevaBatalla"
        Me.btnNuevaBatalla.Size = New System.Drawing.Size(120, 26)
        Me.btnNuevaBatalla.TabIndex = 2
        Me.btnNuevaBatalla.Text = "BATALLAS"
        Me.btnNuevaBatalla.UseVisualStyleBackColor = True
        '
        'pnlFondo
        '
        Me.pnlFondo.BackColor = System.Drawing.SystemColors.MenuText
        Me.pnlFondo.Controls.Add(Me.btnSalir)
        Me.pnlFondo.Controls.Add(Me.gBoxJugarBatalla)
        Me.pnlFondo.Controls.Add(Me.gBoxABM)
        Me.pnlFondo.Controls.Add(Me.PictureBox1)
        Me.pnlFondo.Location = New System.Drawing.Point(-2, -2)
        Me.pnlFondo.Name = "pnlFondo"
        Me.pnlFondo.Size = New System.Drawing.Size(554, 377)
        Me.pnlFondo.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.presentacion.My.Resources.Resources.logoMain
        Me.PictureBox1.Location = New System.Drawing.Point(90, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(320, 184)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'gBoxABM
        '
        Me.gBoxABM.Controls.Add(Me.btnCampeones)
        Me.gBoxABM.ForeColor = System.Drawing.Color.White
        Me.gBoxABM.Location = New System.Drawing.Point(33, 209)
        Me.gBoxABM.Name = "gBoxABM"
        Me.gBoxABM.Size = New System.Drawing.Size(200, 100)
        Me.gBoxABM.TabIndex = 4
        Me.gBoxABM.TabStop = False
        Me.gBoxABM.Text = "Alta, Baja y Modificaciòn de Datos"
        '
        'gBoxJugarBatalla
        '
        Me.gBoxJugarBatalla.Controls.Add(Me.btnNuevaBatalla)
        Me.gBoxJugarBatalla.ForeColor = System.Drawing.Color.White
        Me.gBoxJugarBatalla.Location = New System.Drawing.Point(268, 209)
        Me.gBoxJugarBatalla.Name = "gBoxJugarBatalla"
        Me.gBoxJugarBatalla.Size = New System.Drawing.Size(200, 100)
        Me.gBoxJugarBatalla.TabIndex = 5
        Me.gBoxJugarBatalla.TabStop = False
        Me.gBoxJugarBatalla.Text = "Jugar una Batalla"
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(453, 338)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(80, 26)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'FormPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 374)
        Me.Controls.Add(Me.pnlFondo)
        Me.Name = "FormPrincipal"
        Me.Text = "Batallas entre Campeónes - Menú Principal"
        Me.pnlFondo.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gBoxABM.ResumeLayout(False)
        Me.gBoxJugarBatalla.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCampeones As Button
    Friend WithEvents btnNuevaBatalla As Button
    Friend WithEvents pnlFondo As Panel
    Friend WithEvents gBoxJugarBatalla As GroupBox
    Friend WithEvents gBoxABM As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnSalir As Button
End Class
