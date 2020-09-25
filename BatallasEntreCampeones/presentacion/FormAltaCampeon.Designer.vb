<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAltaCampeon
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
        Me.groupBoxAlta = New System.Windows.Forms.GroupBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
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
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.groupBoxAlta.SuspendLayout()
        CType(Me.nudResistencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudInteligencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDestreza, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudFuerza, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'groupBoxAlta
        '
        Me.groupBoxAlta.Controls.Add(Me.btnAgregar)
        Me.groupBoxAlta.Controls.Add(Me.nudResistencia)
        Me.groupBoxAlta.Controls.Add(Me.Label6)
        Me.groupBoxAlta.Controls.Add(Me.nudInteligencia)
        Me.groupBoxAlta.Controls.Add(Me.Label5)
        Me.groupBoxAlta.Controls.Add(Me.nudDestreza)
        Me.groupBoxAlta.Controls.Add(Me.Label4)
        Me.groupBoxAlta.Controls.Add(Me.nudFuerza)
        Me.groupBoxAlta.Controls.Add(Me.Label3)
        Me.groupBoxAlta.Controls.Add(Me.txtNombre)
        Me.groupBoxAlta.Controls.Add(Me.Label2)
        Me.groupBoxAlta.Location = New System.Drawing.Point(12, 12)
        Me.groupBoxAlta.Name = "groupBoxAlta"
        Me.groupBoxAlta.Size = New System.Drawing.Size(282, 204)
        Me.groupBoxAlta.TabIndex = 2
        Me.groupBoxAlta.TabStop = False
        Me.groupBoxAlta.Text = "Ingresar un nuevo Campeon:"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(10, 162)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(251, 23)
        Me.btnAgregar.TabIndex = 13
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'nudResistencia
        '
        Me.nudResistencia.Location = New System.Drawing.Point(222, 114)
        Me.nudResistencia.Name = "nudResistencia"
        Me.nudResistencia.Size = New System.Drawing.Size(39, 20)
        Me.nudResistencia.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(151, 116)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Resistencia:"
        '
        'nudInteligencia
        '
        Me.nudInteligencia.Location = New System.Drawing.Point(82, 114)
        Me.nudInteligencia.Name = "nudInteligencia"
        Me.nudInteligencia.Size = New System.Drawing.Size(39, 20)
        Me.nudInteligencia.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Inteligencia:"
        '
        'nudDestreza
        '
        Me.nudDestreza.Location = New System.Drawing.Point(222, 71)
        Me.nudDestreza.Name = "nudDestreza"
        Me.nudDestreza.Size = New System.Drawing.Size(39, 20)
        Me.nudDestreza.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(151, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Destreza:"
        '
        'nudFuerza
        '
        Me.nudFuerza.Location = New System.Drawing.Point(82, 71)
        Me.nudFuerza.Name = "nudFuerza"
        Me.nudFuerza.Size = New System.Drawing.Size(39, 20)
        Me.nudFuerza.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Fuerza:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(82, 34)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(179, 20)
        Me.txtNombre.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre:"
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(219, 222)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrar.TabIndex = 3
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'FormAltaCampeon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(315, 272)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.groupBoxAlta)
        Me.Name = "FormAltaCampeon"
        Me.Text = "FormAltaCampeon"
        Me.groupBoxAlta.ResumeLayout(False)
        Me.groupBoxAlta.PerformLayout()
        CType(Me.nudResistencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudInteligencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDestreza, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudFuerza, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents groupBoxAlta As GroupBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents nudResistencia As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents nudInteligencia As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents nudDestreza As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents nudFuerza As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCerrar As Button
End Class
