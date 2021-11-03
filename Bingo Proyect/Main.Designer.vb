<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.bingo_bttn = New System.Windows.Forms.Button()
        Me.linea_bttn = New System.Windows.Forms.Button()
        Me.nombre_bttn = New System.Windows.Forms.Button()
        Me.numero_bttn = New System.Windows.Forms.Button()
        Me.numero_txtbx = New System.Windows.Forms.NumericUpDown()
        Me.nombre_txtbx = New System.Windows.Forms.MaskedTextBox()
        Me.tab_control = New System.Windows.Forms.TabControl()
        Me.tab_principal = New System.Windows.Forms.TabPage()
        Me.cronometro_lbl = New System.Windows.Forms.Label()
        Me.tab_opciones = New System.Windows.Forms.TabPage()
        Me.GroupBox = New System.Windows.Forms.GroupBox()
        Me.tckbar_val_lbl = New System.Windows.Forms.Label()
        Me.tiemp_tckbar = New System.Windows.Forms.TrackBar()
        Me.tiemp_lbl = New System.Windows.Forms.Label()
        Me.restaurar_bttn = New System.Windows.Forms.Button()
        Me.panel_bttn = New System.Windows.Forms.Button()
        Me.aplicar_fnd_bttn = New System.Windows.Forms.Button()
        Me.fondo_select = New System.Windows.Forms.ComboBox()
        Me.img_fnd_lbl = New System.Windows.Forms.Label()
        Me.fuentes_bttn = New System.Windows.Forms.Button()
        Me.mostrar_bttn = New System.Windows.Forms.Button()
        Me.titulo_bttn = New System.Windows.Forms.Button()
        Me.bolillero_bttn = New System.Windows.Forms.Button()
        Me.reiniciar_bttn = New System.Windows.Forms.Button()
        Me.BarraMenu = New System.Windows.Forms.ToolStrip()
        Me.archivo_bttn_bm = New System.Windows.Forms.ToolStripDropDownButton()
        Me.idioma_bttn_bm = New System.Windows.Forms.ToolStripMenuItem()
        Me.english_bttn_bm = New System.Windows.Forms.ToolStripMenuItem()
        Me.spanish_bttn_bm = New System.Windows.Forms.ToolStripMenuItem()
        Me.salir_bttn_bm = New System.Windows.Forms.ToolStripMenuItem()
        Me.about_bttn_bm = New System.Windows.Forms.ToolStripButton()
        Me.Cronometro = New System.Windows.Forms.Timer(Me.components)
        Me.cronometro_seg_lbl = New System.Windows.Forms.Label()
        CType(Me.numero_txtbx, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_control.SuspendLayout()
        Me.tab_principal.SuspendLayout()
        Me.tab_opciones.SuspendLayout()
        Me.GroupBox.SuspendLayout()
        CType(Me.tiemp_tckbar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BarraMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'bingo_bttn
        '
        Me.bingo_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bingo_bttn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bingo_bttn.ForeColor = System.Drawing.Color.Red
        Me.bingo_bttn.Location = New System.Drawing.Point(195, 194)
        Me.bingo_bttn.Name = "bingo_bttn"
        Me.bingo_bttn.Size = New System.Drawing.Size(112, 56)
        Me.bingo_bttn.TabIndex = 5
        Me.bingo_bttn.Text = "¡Bingo!"
        Me.bingo_bttn.UseVisualStyleBackColor = True
        '
        'linea_bttn
        '
        Me.linea_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.linea_bttn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linea_bttn.ForeColor = System.Drawing.Color.Green
        Me.linea_bttn.Location = New System.Drawing.Point(77, 194)
        Me.linea_bttn.Name = "linea_bttn"
        Me.linea_bttn.Size = New System.Drawing.Size(112, 56)
        Me.linea_bttn.TabIndex = 4
        Me.linea_bttn.Text = "Línea"
        Me.linea_bttn.UseVisualStyleBackColor = True
        '
        'nombre_bttn
        '
        Me.nombre_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.nombre_bttn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombre_bttn.Location = New System.Drawing.Point(99, 137)
        Me.nombre_bttn.Name = "nombre_bttn"
        Me.nombre_bttn.Size = New System.Drawing.Size(188, 27)
        Me.nombre_bttn.TabIndex = 3
        Me.nombre_bttn.Text = "Mostrar nombre del ganador"
        Me.nombre_bttn.UseVisualStyleBackColor = True
        '
        'numero_bttn
        '
        Me.numero_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.numero_bttn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numero_bttn.Location = New System.Drawing.Point(168, 51)
        Me.numero_bttn.Name = "numero_bttn"
        Me.numero_bttn.Size = New System.Drawing.Size(104, 27)
        Me.numero_bttn.TabIndex = 1
        Me.numero_bttn.Text = "Enviar número"
        Me.numero_bttn.UseVisualStyleBackColor = True
        '
        'numero_txtbx
        '
        Me.numero_txtbx.Location = New System.Drawing.Point(112, 54)
        Me.numero_txtbx.Maximum = New Decimal(New Integer() {90, 0, 0, 0})
        Me.numero_txtbx.Name = "numero_txtbx"
        Me.numero_txtbx.Size = New System.Drawing.Size(50, 20)
        Me.numero_txtbx.TabIndex = 0
        Me.numero_txtbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'nombre_txtbx
        '
        Me.nombre_txtbx.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombre_txtbx.Location = New System.Drawing.Point(42, 109)
        Me.nombre_txtbx.Name = "nombre_txtbx"
        Me.nombre_txtbx.Size = New System.Drawing.Size(300, 22)
        Me.nombre_txtbx.TabIndex = 2
        '
        'tab_control
        '
        Me.tab_control.Controls.Add(Me.tab_principal)
        Me.tab_control.Controls.Add(Me.tab_opciones)
        Me.tab_control.Location = New System.Drawing.Point(0, 28)
        Me.tab_control.Name = "tab_control"
        Me.tab_control.SelectedIndex = 0
        Me.tab_control.Size = New System.Drawing.Size(392, 334)
        Me.tab_control.TabIndex = 6
        '
        'tab_principal
        '
        Me.tab_principal.BackColor = System.Drawing.SystemColors.Control
        Me.tab_principal.Controls.Add(Me.cronometro_lbl)
        Me.tab_principal.Controls.Add(Me.cronometro_seg_lbl)
        Me.tab_principal.Controls.Add(Me.numero_txtbx)
        Me.tab_principal.Controls.Add(Me.numero_bttn)
        Me.tab_principal.Controls.Add(Me.nombre_txtbx)
        Me.tab_principal.Controls.Add(Me.nombre_bttn)
        Me.tab_principal.Controls.Add(Me.bingo_bttn)
        Me.tab_principal.Controls.Add(Me.linea_bttn)
        Me.tab_principal.Location = New System.Drawing.Point(4, 22)
        Me.tab_principal.Name = "tab_principal"
        Me.tab_principal.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_principal.Size = New System.Drawing.Size(384, 308)
        Me.tab_principal.TabIndex = 0
        Me.tab_principal.Text = "Principal"
        '
        'cronometro_lbl
        '
        Me.cronometro_lbl.AutoSize = True
        Me.cronometro_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cronometro_lbl.Location = New System.Drawing.Point(275, 81)
        Me.cronometro_lbl.Name = "cronometro_lbl"
        Me.cronometro_lbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cronometro_lbl.Size = New System.Drawing.Size(27, 20)
        Me.cronometro_lbl.TabIndex = 6
        Me.cronometro_lbl.Text = "10"
        Me.cronometro_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tab_opciones
        '
        Me.tab_opciones.BackColor = System.Drawing.SystemColors.Control
        Me.tab_opciones.Controls.Add(Me.GroupBox)
        Me.tab_opciones.Controls.Add(Me.bolillero_bttn)
        Me.tab_opciones.Controls.Add(Me.reiniciar_bttn)
        Me.tab_opciones.Location = New System.Drawing.Point(4, 22)
        Me.tab_opciones.Name = "tab_opciones"
        Me.tab_opciones.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_opciones.Size = New System.Drawing.Size(384, 308)
        Me.tab_opciones.TabIndex = 1
        Me.tab_opciones.Text = "Opciones"
        '
        'GroupBox
        '
        Me.GroupBox.Controls.Add(Me.tckbar_val_lbl)
        Me.GroupBox.Controls.Add(Me.tiemp_tckbar)
        Me.GroupBox.Controls.Add(Me.tiemp_lbl)
        Me.GroupBox.Controls.Add(Me.restaurar_bttn)
        Me.GroupBox.Controls.Add(Me.panel_bttn)
        Me.GroupBox.Controls.Add(Me.aplicar_fnd_bttn)
        Me.GroupBox.Controls.Add(Me.fondo_select)
        Me.GroupBox.Controls.Add(Me.img_fnd_lbl)
        Me.GroupBox.Controls.Add(Me.fuentes_bttn)
        Me.GroupBox.Controls.Add(Me.mostrar_bttn)
        Me.GroupBox.Controls.Add(Me.titulo_bttn)
        Me.GroupBox.Location = New System.Drawing.Point(82, 6)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Size = New System.Drawing.Size(296, 271)
        Me.GroupBox.TabIndex = 2
        Me.GroupBox.TabStop = False
        Me.GroupBox.Text = "Segunda ventana"
        '
        'tckbar_val_lbl
        '
        Me.tckbar_val_lbl.AutoSize = True
        Me.tckbar_val_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tckbar_val_lbl.Location = New System.Drawing.Point(153, 187)
        Me.tckbar_val_lbl.Name = "tckbar_val_lbl"
        Me.tckbar_val_lbl.Size = New System.Drawing.Size(85, 16)
        Me.tckbar_val_lbl.TabIndex = 12
        Me.tckbar_val_lbl.Text = "10 segundos"
        '
        'tiemp_tckbar
        '
        Me.tiemp_tckbar.LargeChange = 1
        Me.tiemp_tckbar.Location = New System.Drawing.Point(49, 173)
        Me.tiemp_tckbar.Minimum = 4
        Me.tiemp_tckbar.Name = "tiemp_tckbar"
        Me.tiemp_tckbar.Size = New System.Drawing.Size(104, 45)
        Me.tiemp_tckbar.TabIndex = 11
        Me.tiemp_tckbar.Value = 10
        '
        'tiemp_lbl
        '
        Me.tiemp_lbl.AutoSize = True
        Me.tiemp_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tiemp_lbl.Location = New System.Drawing.Point(25, 154)
        Me.tiemp_lbl.Name = "tiemp_lbl"
        Me.tiemp_lbl.Size = New System.Drawing.Size(245, 16)
        Me.tiemp_lbl.TabIndex = 10
        Me.tiemp_lbl.Text = "Tiempo para mostrar el número elegido"
        '
        'restaurar_bttn
        '
        Me.restaurar_bttn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.restaurar_bttn.Location = New System.Drawing.Point(116, 224)
        Me.restaurar_bttn.Name = "restaurar_bttn"
        Me.restaurar_bttn.Size = New System.Drawing.Size(174, 41)
        Me.restaurar_bttn.TabIndex = 3
        Me.restaurar_bttn.Text = "Restaurar configuraciones por defecto"
        Me.restaurar_bttn.UseVisualStyleBackColor = True
        '
        'panel_bttn
        '
        Me.panel_bttn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panel_bttn.Location = New System.Drawing.Point(189, 19)
        Me.panel_bttn.Name = "panel_bttn"
        Me.panel_bttn.Size = New System.Drawing.Size(98, 40)
        Me.panel_bttn.TabIndex = 9
        Me.panel_bttn.Text = "Ocultar panel de números"
        Me.panel_bttn.UseVisualStyleBackColor = True
        '
        'aplicar_fnd_bttn
        '
        Me.aplicar_fnd_bttn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aplicar_fnd_bttn.Location = New System.Drawing.Point(217, 111)
        Me.aplicar_fnd_bttn.Name = "aplicar_fnd_bttn"
        Me.aplicar_fnd_bttn.Size = New System.Drawing.Size(70, 24)
        Me.aplicar_fnd_bttn.TabIndex = 8
        Me.aplicar_fnd_bttn.Text = "Aplicar"
        Me.aplicar_fnd_bttn.UseVisualStyleBackColor = True
        '
        'fondo_select
        '
        Me.fondo_select.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.fondo_select.FormattingEnabled = True
        Me.fondo_select.Items.AddRange(New Object() {"Tela roja", "Tela blanca", "Examinar..."})
        Me.fondo_select.Location = New System.Drawing.Point(124, 113)
        Me.fondo_select.Name = "fondo_select"
        Me.fondo_select.Size = New System.Drawing.Size(87, 21)
        Me.fondo_select.TabIndex = 7
        '
        'img_fnd_lbl
        '
        Me.img_fnd_lbl.AutoSize = True
        Me.img_fnd_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.img_fnd_lbl.Location = New System.Drawing.Point(9, 115)
        Me.img_fnd_lbl.Name = "img_fnd_lbl"
        Me.img_fnd_lbl.Size = New System.Drawing.Size(109, 16)
        Me.img_fnd_lbl.TabIndex = 6
        Me.img_fnd_lbl.Text = "Imagen de fondo"
        '
        'fuentes_bttn
        '
        Me.fuentes_bttn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fuentes_bttn.Location = New System.Drawing.Point(87, 65)
        Me.fuentes_bttn.Name = "fuentes_bttn"
        Me.fuentes_bttn.Size = New System.Drawing.Size(106, 40)
        Me.fuentes_bttn.TabIndex = 5
        Me.fuentes_bttn.Text = "Editar colores y fuentes"
        Me.fuentes_bttn.UseVisualStyleBackColor = True
        '
        'mostrar_bttn
        '
        Me.mostrar_bttn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mostrar_bttn.Location = New System.Drawing.Point(11, 27)
        Me.mostrar_bttn.Name = "mostrar_bttn"
        Me.mostrar_bttn.Size = New System.Drawing.Size(70, 24)
        Me.mostrar_bttn.TabIndex = 3
        Me.mostrar_bttn.Text = "Mostrar"
        Me.mostrar_bttn.UseVisualStyleBackColor = True
        '
        'titulo_bttn
        '
        Me.titulo_bttn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titulo_bttn.Location = New System.Drawing.Point(87, 19)
        Me.titulo_bttn.Name = "titulo_bttn"
        Me.titulo_bttn.Size = New System.Drawing.Size(96, 40)
        Me.titulo_bttn.TabIndex = 4
        Me.titulo_bttn.Text = "Ocultar barra de título"
        Me.titulo_bttn.UseVisualStyleBackColor = True
        '
        'bolillero_bttn
        '
        Me.bolillero_bttn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bolillero_bttn.Location = New System.Drawing.Point(6, 36)
        Me.bolillero_bttn.Name = "bolillero_bttn"
        Me.bolillero_bttn.Size = New System.Drawing.Size(70, 40)
        Me.bolillero_bttn.TabIndex = 1
        Me.bolillero_bttn.Text = "Mostrar bolillero"
        Me.bolillero_bttn.UseVisualStyleBackColor = True
        '
        'reiniciar_bttn
        '
        Me.reiniciar_bttn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reiniciar_bttn.Location = New System.Drawing.Point(6, 6)
        Me.reiniciar_bttn.Name = "reiniciar_bttn"
        Me.reiniciar_bttn.Size = New System.Drawing.Size(70, 24)
        Me.reiniciar_bttn.TabIndex = 0
        Me.reiniciar_bttn.Text = "Reiniciar"
        Me.reiniciar_bttn.UseVisualStyleBackColor = True
        '
        'BarraMenu
        '
        Me.BarraMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.archivo_bttn_bm, Me.about_bttn_bm})
        Me.BarraMenu.Location = New System.Drawing.Point(0, 0)
        Me.BarraMenu.Name = "BarraMenu"
        Me.BarraMenu.Size = New System.Drawing.Size(392, 25)
        Me.BarraMenu.TabIndex = 7
        Me.BarraMenu.Text = "ToolStrip1"
        '
        'archivo_bttn_bm
        '
        Me.archivo_bttn_bm.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.archivo_bttn_bm.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.idioma_bttn_bm, Me.salir_bttn_bm})
        Me.archivo_bttn_bm.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.archivo_bttn_bm.Name = "archivo_bttn_bm"
        Me.archivo_bttn_bm.Size = New System.Drawing.Size(61, 22)
        Me.archivo_bttn_bm.Text = "Archivo"
        Me.archivo_bttn_bm.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'idioma_bttn_bm
        '
        Me.idioma_bttn_bm.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.english_bttn_bm, Me.spanish_bttn_bm})
        Me.idioma_bttn_bm.Name = "idioma_bttn_bm"
        Me.idioma_bttn_bm.Size = New System.Drawing.Size(111, 22)
        Me.idioma_bttn_bm.Text = "Idioma"
        '
        'english_bttn_bm
        '
        Me.english_bttn_bm.Name = "english_bttn_bm"
        Me.english_bttn_bm.Size = New System.Drawing.Size(115, 22)
        Me.english_bttn_bm.Text = "English"
        Me.english_bttn_bm.Visible = False
        '
        'spanish_bttn_bm
        '
        Me.spanish_bttn_bm.Checked = True
        Me.spanish_bttn_bm.CheckState = System.Windows.Forms.CheckState.Checked
        Me.spanish_bttn_bm.Name = "spanish_bttn_bm"
        Me.spanish_bttn_bm.Size = New System.Drawing.Size(115, 22)
        Me.spanish_bttn_bm.Text = "Español"
        '
        'salir_bttn_bm
        '
        Me.salir_bttn_bm.Name = "salir_bttn_bm"
        Me.salir_bttn_bm.Size = New System.Drawing.Size(111, 22)
        Me.salir_bttn_bm.Text = "Salir"
        '
        'about_bttn_bm
        '
        Me.about_bttn_bm.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.about_bttn_bm.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.about_bttn_bm.Name = "about_bttn_bm"
        Me.about_bttn_bm.Size = New System.Drawing.Size(72, 22)
        Me.about_bttn_bm.Text = "Acerca de..."
        '
        'Cronometro
        '
        Me.Cronometro.Interval = 1000
        '
        'cronometro_seg_lbl
        '
        Me.cronometro_seg_lbl.AutoSize = True
        Me.cronometro_seg_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cronometro_seg_lbl.Location = New System.Drawing.Point(293, 81)
        Me.cronometro_seg_lbl.Name = "cronometro_seg_lbl"
        Me.cronometro_seg_lbl.Size = New System.Drawing.Size(83, 20)
        Me.cronometro_seg_lbl.TabIndex = 7
        Me.cronometro_seg_lbl.Text = " segundos"
        '
        'Main
        '
        Me.AcceptButton = Me.numero_bttn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(392, 361)
        Me.Controls.Add(Me.BarraMenu)
        Me.Controls.Add(Me.tab_control)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bingo Project"
        CType(Me.numero_txtbx, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_control.ResumeLayout(False)
        Me.tab_principal.ResumeLayout(False)
        Me.tab_principal.PerformLayout()
        Me.tab_opciones.ResumeLayout(False)
        Me.GroupBox.ResumeLayout(False)
        Me.GroupBox.PerformLayout()
        CType(Me.tiemp_tckbar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BarraMenu.ResumeLayout(False)
        Me.BarraMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bingo_bttn As Button
    Friend WithEvents linea_bttn As Button
    Friend WithEvents nombre_bttn As Button
    Friend WithEvents numero_bttn As Button
    Friend WithEvents numero_txtbx As NumericUpDown
    Friend WithEvents nombre_txtbx As MaskedTextBox
    Friend WithEvents tab_control As TabControl
    Friend WithEvents tab_principal As TabPage
    Friend WithEvents tab_opciones As TabPage
    Friend WithEvents BarraMenu As ToolStrip
    Friend WithEvents reiniciar_bttn As Button
    Friend WithEvents bolillero_bttn As Button
    Friend WithEvents titulo_bttn As Button
    Friend WithEvents GroupBox As GroupBox
    Friend WithEvents about_bttn_bm As ToolStripButton
    Friend WithEvents archivo_bttn_bm As ToolStripDropDownButton
    Friend WithEvents idioma_bttn_bm As ToolStripMenuItem
    Friend WithEvents spanish_bttn_bm As ToolStripMenuItem
    Friend WithEvents english_bttn_bm As ToolStripMenuItem
    Friend WithEvents salir_bttn_bm As ToolStripMenuItem
    Friend WithEvents mostrar_bttn As Button
    Friend WithEvents fuentes_bttn As Button
    Friend WithEvents fondo_select As ComboBox
    Friend WithEvents img_fnd_lbl As Label
    Friend WithEvents aplicar_fnd_bttn As Button
    Friend WithEvents panel_bttn As Button
    Friend WithEvents restaurar_bttn As Button
    Friend WithEvents cronometro_lbl As Label
    Friend WithEvents Cronometro As Timer
    Friend WithEvents tckbar_val_lbl As Label
    Friend WithEvents tiemp_tckbar As TrackBar
    Friend WithEvents tiemp_lbl As Label
    Friend WithEvents cronometro_seg_lbl As Label
End Class
