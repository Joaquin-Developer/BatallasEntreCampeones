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
        Me.btnBatallas = New System.Windows.Forms.Button()
        Me.btnNuevaBatalla = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCampeones
        '
        Me.btnCampeones.Location = New System.Drawing.Point(63, 29)
        Me.btnCampeones.Name = "btnCampeones"
        Me.btnCampeones.Size = New System.Drawing.Size(120, 50)
        Me.btnCampeones.TabIndex = 0
        Me.btnCampeones.Text = "Campeónes"
        Me.btnCampeones.UseVisualStyleBackColor = True
        '
        'btnBatallas
        '
        Me.btnBatallas.Location = New System.Drawing.Point(201, 29)
        Me.btnBatallas.Name = "btnBatallas"
        Me.btnBatallas.Size = New System.Drawing.Size(120, 50)
        Me.btnBatallas.TabIndex = 1
        Me.btnBatallas.Text = "Batallas"
        Me.btnBatallas.UseVisualStyleBackColor = True
        '
        'btnNuevaBatalla
        '
        Me.btnNuevaBatalla.Location = New System.Drawing.Point(414, 29)
        Me.btnNuevaBatalla.Name = "btnNuevaBatalla"
        Me.btnNuevaBatalla.Size = New System.Drawing.Size(120, 50)
        Me.btnNuevaBatalla.TabIndex = 2
        Me.btnNuevaBatalla.Text = "BATALLAS"
        Me.btnNuevaBatalla.UseVisualStyleBackColor = True
        '
        'FormPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(796, 447)
        Me.Controls.Add(Me.btnNuevaBatalla)
        Me.Controls.Add(Me.btnBatallas)
        Me.Controls.Add(Me.btnCampeones)
        Me.Name = "FormPrincipal"
        Me.Text = "Batallas entre Campeónes - Menú Principal"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCampeones As Button
    Friend WithEvents btnBatallas As Button
    Friend WithEvents btnNuevaBatalla As Button
End Class
