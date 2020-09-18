<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormModificarCampeon
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.nudResistencia = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.nudInteligencia = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nudDestreza = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nudFuerza = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblIdCampeon = New System.Windows.Forms.Label()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.nudResistencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudInteligencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDestreza, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudFuerza, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnModificar)
        Me.GroupBox1.Controls.Add(Me.lblIdCampeon)
        Me.GroupBox1.Controls.Add(Me.nudResistencia)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.nudInteligencia)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.nudDestreza)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.nudFuerza)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(282, 231)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Campeón"
        '
        'nudResistencia
        '
        Me.nudResistencia.Location = New System.Drawing.Point(221, 140)
        Me.nudResistencia.Name = "nudResistencia"
        Me.nudResistencia.Size = New System.Drawing.Size(39, 20)
        Me.nudResistencia.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(150, 142)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Resistencia:"
        '
        'nudInteligencia
        '
        Me.nudInteligencia.Location = New System.Drawing.Point(81, 140)
        Me.nudInteligencia.Name = "nudInteligencia"
        Me.nudInteligencia.Size = New System.Drawing.Size(39, 20)
        Me.nudInteligencia.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Inteligencia:"
        '
        'nudDestreza
        '
        Me.nudDestreza.Location = New System.Drawing.Point(221, 97)
        Me.nudDestreza.Name = "nudDestreza"
        Me.nudDestreza.Size = New System.Drawing.Size(39, 20)
        Me.nudDestreza.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(150, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Destreza:"
        '
        'nudFuerza
        '
        Me.nudFuerza.Location = New System.Drawing.Point(81, 97)
        Me.nudFuerza.Name = "nudFuerza"
        Me.nudFuerza.Size = New System.Drawing.Size(39, 20)
        Me.nudFuerza.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Fuerza:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(81, 60)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(179, 20)
        Me.txtNombre.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre:"
        '
        'lblIdCampeon
        '
        Me.lblIdCampeon.AutoSize = True
        Me.lblIdCampeon.Location = New System.Drawing.Point(81, 26)
        Me.lblIdCampeon.Name = "lblIdCampeon"
        Me.lblIdCampeon.Size = New System.Drawing.Size(37, 13)
        Me.lblIdCampeon.TabIndex = 12
        Me.lblIdCampeon.Text = "00000"
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(9, 188)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(251, 23)
        Me.btnModificar.TabIndex = 13
        Me.btnModificar.Text = "GUARDAR MODIFICACIÓNES"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(219, 249)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 2
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'FormModificarCampeon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(315, 289)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormModificarCampeon"
        Me.Text = "Modificar Campeón"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.nudResistencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudInteligencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDestreza, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudFuerza, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents nudResistencia As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents nudInteligencia As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents nudDestreza As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents nudFuerza As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents lblIdCampeon As Label
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnCancelar As Button
End Class
