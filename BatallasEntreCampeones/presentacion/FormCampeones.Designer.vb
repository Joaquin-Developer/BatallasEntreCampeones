<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCampeones
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
        Me.GroupBoxBusqueda = New System.Windows.Forms.GroupBox()
        Me.groupBoxDatos = New System.Windows.Forms.GroupBox()
        Me.lblFuerza = New System.Windows.Forms.Label()
        Me.lblResistencia = New System.Windows.Forms.Label()
        Me.lblDestreza = New System.Windows.Forms.Label()
        Me.lblInteligencia = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnVerDatosCampeon = New System.Windows.Forms.Button()
        Me.cBoxNombresCampeones = New System.Windows.Forms.ComboBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenúToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsMenuItemAltaCampeon = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsMenuItemModificarCampeon = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnModificarCampeon = New System.Windows.Forms.Button()
        Me.GroupBoxBusqueda.SuspendLayout()
        Me.groupBoxDatos.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxBusqueda
        '
        Me.GroupBoxBusqueda.Controls.Add(Me.btnModificarCampeon)
        Me.GroupBoxBusqueda.Controls.Add(Me.groupBoxDatos)
        Me.GroupBoxBusqueda.Controls.Add(Me.btnEliminar)
        Me.GroupBoxBusqueda.Controls.Add(Me.btnVerDatosCampeon)
        Me.GroupBoxBusqueda.Controls.Add(Me.cBoxNombresCampeones)
        Me.GroupBoxBusqueda.Controls.Add(Me.lblNombre)
        Me.GroupBoxBusqueda.Location = New System.Drawing.Point(12, 42)
        Me.GroupBoxBusqueda.Name = "GroupBoxBusqueda"
        Me.GroupBoxBusqueda.Size = New System.Drawing.Size(537, 225)
        Me.GroupBoxBusqueda.TabIndex = 0
        Me.GroupBoxBusqueda.TabStop = False
        Me.GroupBoxBusqueda.Text = "Filtrar Campeón por nombre"
        '
        'groupBoxDatos
        '
        Me.groupBoxDatos.Controls.Add(Me.lblFuerza)
        Me.groupBoxDatos.Controls.Add(Me.lblResistencia)
        Me.groupBoxDatos.Controls.Add(Me.lblDestreza)
        Me.groupBoxDatos.Controls.Add(Me.lblInteligencia)
        Me.groupBoxDatos.Location = New System.Drawing.Point(23, 54)
        Me.groupBoxDatos.Name = "groupBoxDatos"
        Me.groupBoxDatos.Size = New System.Drawing.Size(502, 83)
        Me.groupBoxDatos.TabIndex = 9
        Me.groupBoxDatos.TabStop = False
        Me.groupBoxDatos.Text = "Datos"
        '
        'lblFuerza
        '
        Me.lblFuerza.AutoSize = True
        Me.lblFuerza.Location = New System.Drawing.Point(6, 37)
        Me.lblFuerza.Name = "lblFuerza"
        Me.lblFuerza.Size = New System.Drawing.Size(63, 13)
        Me.lblFuerza.TabIndex = 5
        Me.lblFuerza.Text = "Fuerza: 000"
        '
        'lblResistencia
        '
        Me.lblResistencia.AutoSize = True
        Me.lblResistencia.Location = New System.Drawing.Point(339, 37)
        Me.lblResistencia.Name = "lblResistencia"
        Me.lblResistencia.Size = New System.Drawing.Size(86, 13)
        Me.lblResistencia.TabIndex = 8
        Me.lblResistencia.Text = "Resistencia: 000"
        '
        'lblDestreza
        '
        Me.lblDestreza.AutoSize = True
        Me.lblDestreza.Location = New System.Drawing.Point(101, 37)
        Me.lblDestreza.Name = "lblDestreza"
        Me.lblDestreza.Size = New System.Drawing.Size(73, 13)
        Me.lblDestreza.TabIndex = 6
        Me.lblDestreza.Text = "Destreza: 000"
        '
        'lblInteligencia
        '
        Me.lblInteligencia.AutoSize = True
        Me.lblInteligencia.Location = New System.Drawing.Point(221, 37)
        Me.lblInteligencia.Name = "lblInteligencia"
        Me.lblInteligencia.Size = New System.Drawing.Size(85, 13)
        Me.lblInteligencia.TabIndex = 7
        Me.lblInteligencia.Text = "Inteligencia: 000"
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(402, 25)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(129, 23)
        Me.btnEliminar.TabIndex = 4
        Me.btnEliminar.Text = "Eliminar campeón"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnVerDatosCampeon
        '
        Me.btnVerDatosCampeon.Location = New System.Drawing.Point(230, 25)
        Me.btnVerDatosCampeon.Name = "btnVerDatosCampeon"
        Me.btnVerDatosCampeon.Size = New System.Drawing.Size(70, 23)
        Me.btnVerDatosCampeon.TabIndex = 2
        Me.btnVerDatosCampeon.Text = "Ver Datos"
        Me.btnVerDatosCampeon.UseVisualStyleBackColor = True
        '
        'cBoxNombresCampeones
        '
        Me.cBoxNombresCampeones.FormattingEnabled = True
        Me.cBoxNombresCampeones.Location = New System.Drawing.Point(86, 27)
        Me.cBoxNombresCampeones.Name = "cBoxNombresCampeones"
        Me.cBoxNombresCampeones.Size = New System.Drawing.Size(138, 21)
        Me.cBoxNombresCampeones.TabIndex = 1
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(20, 28)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(60, 16)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre:"
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(474, 273)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrar.TabIndex = 2
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenúToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(580, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenúToolStripMenuItem
        '
        Me.MenúToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsMenuItemAltaCampeon, Me.tsMenuItemModificarCampeon})
        Me.MenúToolStripMenuItem.Name = "MenúToolStripMenuItem"
        Me.MenúToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenúToolStripMenuItem.Text = "Menú"
        '
        'tsMenuItemAltaCampeon
        '
        Me.tsMenuItemAltaCampeon.Name = "tsMenuItemAltaCampeon"
        Me.tsMenuItemAltaCampeon.Size = New System.Drawing.Size(180, 22)
        Me.tsMenuItemAltaCampeon.Text = "Agregar campeón"
        '
        'tsMenuItemModificarCampeon
        '
        Me.tsMenuItemModificarCampeon.Name = "tsMenuItemModificarCampeon"
        Me.tsMenuItemModificarCampeon.Size = New System.Drawing.Size(180, 22)
        Me.tsMenuItemModificarCampeon.Text = "Modificar campeón"
        '
        'btnModificarCampeon
        '
        Me.btnModificarCampeon.Location = New System.Drawing.Point(306, 25)
        Me.btnModificarCampeon.Name = "btnModificarCampeon"
        Me.btnModificarCampeon.Size = New System.Drawing.Size(90, 23)
        Me.btnModificarCampeon.TabIndex = 10
        Me.btnModificarCampeon.Text = "Modificar"
        Me.btnModificarCampeon.UseVisualStyleBackColor = True
        '
        'FormCampeones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 312)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.GroupBoxBusqueda)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormCampeones"
        Me.Text = "Campeónes"
        Me.GroupBoxBusqueda.ResumeLayout(False)
        Me.GroupBoxBusqueda.PerformLayout()
        Me.groupBoxDatos.ResumeLayout(False)
        Me.groupBoxDatos.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBoxBusqueda As GroupBox
    Friend WithEvents btnVerDatosCampeon As Button
    Friend WithEvents cBoxNombresCampeones As ComboBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenúToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsMenuItemAltaCampeon As ToolStripMenuItem
    Friend WithEvents tsMenuItemModificarCampeon As ToolStripMenuItem
    Friend WithEvents groupBoxDatos As GroupBox
    Friend WithEvents lblFuerza As Label
    Friend WithEvents lblResistencia As Label
    Friend WithEvents lblDestreza As Label
    Friend WithEvents lblInteligencia As Label
    Friend WithEvents btnModificarCampeon As Button
End Class
