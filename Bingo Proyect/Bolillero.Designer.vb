<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bolillero
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Bolillero))
        Me.numero_rnd_lbl = New System.Windows.Forms.Label()
        Me.snd_numero = New System.Windows.Forms.CheckBox()
        Me.numero_rnd_bttn = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ReiniciarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.envia_numero = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'numero_rnd_lbl
        '
        Me.numero_rnd_lbl.AutoSize = True
        Me.numero_rnd_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 99.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numero_rnd_lbl.Location = New System.Drawing.Point(18, 24)
        Me.numero_rnd_lbl.Name = "numero_rnd_lbl"
        Me.numero_rnd_lbl.Size = New System.Drawing.Size(213, 152)
        Me.numero_rnd_lbl.TabIndex = 0
        Me.numero_rnd_lbl.Text = "00"
        Me.numero_rnd_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'snd_numero
        '
        Me.snd_numero.AutoSize = True
        Me.snd_numero.Location = New System.Drawing.Point(12, 247)
        Me.snd_numero.Name = "snd_numero"
        Me.snd_numero.Size = New System.Drawing.Size(224, 17)
        Me.snd_numero.TabIndex = 1
        Me.snd_numero.Text = "Enviar número automáticamente al tablero"
        Me.snd_numero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.snd_numero.UseVisualStyleBackColor = True
        '
        'numero_rnd_bttn
        '
        Me.numero_rnd_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.numero_rnd_bttn.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numero_rnd_bttn.Location = New System.Drawing.Point(12, 179)
        Me.numero_rnd_bttn.Name = "numero_rnd_bttn"
        Me.numero_rnd_bttn.Size = New System.Drawing.Size(224, 62)
        Me.numero_rnd_bttn.TabIndex = 2
        Me.numero_rnd_bttn.Text = "¡Número!"
        Me.numero_rnd_bttn.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReiniciarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(248, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ReiniciarToolStripMenuItem
        '
        Me.ReiniciarToolStripMenuItem.Name = "ReiniciarToolStripMenuItem"
        Me.ReiniciarToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.ReiniciarToolStripMenuItem.Text = "Reiniciar"
        '
        'envia_numero
        '
        Me.envia_numero.Interval = 1
        '
        'Bolillero
        '
        Me.AcceptButton = Me.numero_rnd_bttn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(248, 276)
        Me.Controls.Add(Me.numero_rnd_bttn)
        Me.Controls.Add(Me.snd_numero)
        Me.Controls.Add(Me.numero_rnd_lbl)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Bolillero"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bolillero"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents numero_rnd_lbl As Label
    Friend WithEvents snd_numero As CheckBox
    Friend WithEvents numero_rnd_bttn As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ReiniciarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents envia_numero As Timer
End Class
