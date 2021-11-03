Public Class Fuentes_Form
    Public Shared Sub ventana()
        'Crea el Form
        Dim formfuentes As New Form()
        'Eje X para centrar los botones de las filas 2 y 3
        Dim x As New Double

        'Crea los botones para BINGO, LINEA y para el nombre del ganador
        'Fila 1
        Dim bingo_bttn As New Button()
        Dim linea_bttn As New Button
        Dim nombre_bttn As New Button()
        'Fila 2
        Dim fondo_panel As New Button
        Dim fuente_lbl_grande As New Button
        'Fila 3
        Dim fondo_numeros_org As New Button
        Dim texto_numeros_org As New Button
        'Fila 4
        Dim fondo_numeros As New Button
        Dim texto_numeros As New Button

        'Permite realizar la acción "Click" a los botones
        'Form
        'Fila 1
        AddHandler bingo_bttn.Click, AddressOf bingo_bttn_Click
        AddHandler linea_bttn.Click, AddressOf linea_bttn_Click
        AddHandler nombre_bttn.Click, AddressOf nombre_bttn_Click
        'Fila 2
        AddHandler fondo_panel.Click, AddressOf fondo_panel_Click
        AddHandler fuente_lbl_grande.Click, AddressOf fuente_lbl_grande_Click
        'Fila 3
        AddHandler fondo_numeros_org.Click, AddressOf fondo_numeros_org_Click
        AddHandler texto_numeros_org.Click, AddressOf texto_numeros_org_Click
        'Fila 4
        AddHandler fondo_numeros.Click, AddressOf fondo_numeros_Click
        AddHandler texto_numeros.Click, AddressOf texto_numeros_Click
        'Mensaje al inciar el form
        AddHandler formfuentes.Shown, AddressOf formfuentes_Shown

#Region "Buttons Configs"
        'BUTTONS CONFIGS
        'Texto de los botones
        'Fila 1
        bingo_bttn.Text = "Bingo"
        linea_bttn.Text = "Linea"
        nombre_bttn.Text = "Nombre ganador"
        'Fila 2
        fondo_panel.Text = "Color de fondo del panel de números"
        fuente_lbl_grande.Text = "Fuente del número grande"
        'Fila 3
        fondo_numeros_org.Text = "Fondo del número sin elegir"
        texto_numeros_org.Text = "Texto del número sin elegir"
        'Fila 4
        fondo_numeros.Text = "Fondo del número elegido"
        texto_numeros.Text = "Texto del número elegido"

        'Fuente y tamaño del texto
        Dim fuente As New Font("Times New Roman", 9.75, FontStyle.Regular)
        'Fila 1
        bingo_bttn.Font = fuente
        linea_bttn.Font = fuente
        nombre_bttn.Font = fuente
        'Fila 2
        fondo_panel.Font = fuente
        fuente_lbl_grande.Font = fuente
        'Fila 3
        fondo_numeros_org.Font = fuente
        texto_numeros_org.Font = fuente
        'Fila 4
        fondo_numeros.Font = fuente
        texto_numeros.Font = fuente

        'Tamaño de los botones
        'Fila 1
        bingo_bttn.Size = New Point(70, 24)
        linea_bttn.Size = New Point(70, 24)
        nombre_bttn.Size = New Point(119, 24)
        'Fila 2
        fondo_panel.Size = New Point(126, 40)
        fuente_lbl_grande.Size = New Point(107, 40)
        'Fila 3
        fondo_numeros_org.Size = New Point(118, 40)
        texto_numeros_org.Size = New Point(118, 40)
        'Fila 4
        fondo_numeros.Size = New Point(118, 40)
        texto_numeros.Size = New Point(118, 40)

        'Posición de los botones
        'Fila 1
        bingo_bttn.Location = New Point(12,
                                        12)
        linea_bttn.Location = New Point(bingo_bttn.Location.X + bingo_bttn.Size.Width + 8,
                                        bingo_bttn.Location.Y)
        nombre_bttn.Location = New Point(linea_bttn.Location.X + linea_bttn.Size.Width + 8,
                                         linea_bttn.Location.Y)
        'Fila 2
        fondo_panel.Location = New Point(12,
                                         bingo_bttn.Location.Y + bingo_bttn.Height + 8)
        fuente_lbl_grande.Location = New Point(fondo_panel.Location.X + fondo_panel.Width + 8,
                                               fondo_panel.Location.Y)
        'Fila 3
        fondo_numeros_org.Location = New Point(12,
                                               fondo_panel.Location.Y + fondo_panel.Height + 8)
        texto_numeros_org.Location = New Point(fondo_numeros_org.Location.X + fondo_numeros_org.Size.Width + 8,
                                               fondo_panel.Location.Y + fondo_panel.Height + 8)
        'Fila 4
        fondo_numeros.Location = New Point(12,
                                           fondo_numeros_org.Location.Y + fondo_numeros_org.Height + 8)
        texto_numeros.Location = New Point(fondo_numeros.Location.X + fondo_numeros.Size.Width + 8,
                                           fondo_numeros_org.Location.Y + fondo_numeros_org.Height + 8)

        'Agrega los botones al form
        'Fila 1
        formfuentes.Controls.Add(bingo_bttn)
        formfuentes.Controls.Add(linea_bttn)
        formfuentes.Controls.Add(nombre_bttn)
        'Fila 2
        formfuentes.Controls.Add(fondo_panel)
        formfuentes.Controls.Add(fuente_lbl_grande)
        'Fila 3
        formfuentes.Controls.Add(fondo_numeros)
        formfuentes.Controls.Add(texto_numeros)
        'Fila 4
        formfuentes.Controls.Add(fondo_numeros_org)
        formfuentes.Controls.Add(texto_numeros_org)
#End Region

#Region "Form Configs"
        'FORM CONFIGS
        'Establece el estilo del form como FixedToolWindow
        formfuentes.FormBorderStyle = FormBorderStyle.FixedToolWindow
        'Centra el form en la pantalla
        formfuentes.StartPosition = FormStartPosition.CenterScreen
        'Nombre visible del form
        formfuentes.Text = "Editar fuentes"
        'Icono del form
        formfuentes.Icon = My.Resources.icono_verde
        'Tamaño del form
        'X = 15 (3 márgen, 12 separación); tamaño X del primer botón; 12 separación; tamaño X del siguiente botón; 
        'etc; 15 (3 márgen, 12 separación)
        'Y = 48 (36 barra de título, 12 de separación); tamaño Y del botón más alto fila 1; 12 separación;_
        'tamaño Y del botón más alto fila 2; 12 separación; tamaño Y del botón más alto fila 3; 
        'tamaño Y del botón más alto de la fila 4 + 15 (3 márgen; 12 separación)
        formfuentes.Size = New Point(15 + bingo_bttn.Width + 12 + linea_bttn.Width + 12 + nombre_bttn.Width + 15,
                                      48 + bingo_bttn.Height + 12 + fondo_panel.Height + fondo_numeros_org.Height + 12 + fondo_numeros.Height + 15)
        'Centrado en pantalla de los botones
        'Fila 2
        x = ((formfuentes.Width / 4) - (fondo_panel.Width / 2) + 8) '- (fondo_panel.Width / 2) - 6
        fondo_panel.Location = New Point(x, fondo_panel.Location.Y)
        '
        x = ((formfuentes.Width / 4) - (fuente_lbl_grande.Width / 2) + 8) + fondo_panel.Width
        fuente_lbl_grande.Location = New Point(x, fuente_lbl_grande.Location.Y)

        'Fila 3
        x = ((formfuentes.Width / 2) - (fondo_numeros_org.Width / 2) - 8) - (fondo_numeros_org.Width / 2) - 6
        fondo_numeros_org.Location = New Point(x, fondo_numeros_org.Location.Y)
        '
        x = ((formfuentes.Width / 2) - (texto_numeros_org.Width / 2) - 8) + (fondo_numeros_org.Width / 2) + 6
        texto_numeros_org.Location = New Point(x, texto_numeros_org.Location.Y)

        'Fila 4
        x = ((formfuentes.Width / 2) - (fondo_numeros.Width / 2) - 8) - (fondo_numeros.Width / 2) - 6
        fondo_numeros.Location = New Point(x, fondo_numeros.Location.Y)
        '
        x = ((formfuentes.Width / 2) - (texto_numeros.Width / 2) - 8) + (fondo_numeros.Width / 2) + 6
        texto_numeros.Location = New Point(x, texto_numeros.Location.Y)


        'Muestra el form
        formfuentes.Show()
#End Region
    End Sub

#Region "Click buttons"
    Shared Sub bingo_bttn_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Se crean dos cuadros de diálogo, uno para la fuente y otro para elegir el color
        Dim bingo_fntdiag As New FontDialog()
        Dim bingo_cldiag As New ColorDialog()
        'Eje X para centrar
        Dim x As New Double

        'Muestra la última fuente y color utilizados en los cuadros de diálogo
        bingo_fntdiag.Font = My.Settings.fuentes_bingo
        bingo_cldiag.Color = My.Settings.fuentes_bingo_color

        'Si el cuadro de diálogo se cierra clickeando el botón "Ok", se cambia la fuente
        If bingo_fntdiag.ShowDialog() = DialogResult.OK Then
            Proyect.bingo_lbl.Font = bingo_fntdiag.Font
            'Guarda las configuraciones
            My.Settings.fuentes_bingo = bingo_fntdiag.Font
        End If

        'Si el cuadro de diálogo se cierra clickeando el botón "Ok", se cambia el color
        If bingo_cldiag.ShowDialog() = DialogResult.OK Then
            Proyect.bingo_lbl.ForeColor = bingo_cldiag.Color
            'Guarda las configuraciones
            My.Settings.fuentes_bingo_color = Proyect.bingo_lbl.ForeColor
        End If

        'Centrado en pantalla
        x = (Proyect.Size.Width / 2) - (Proyect.bingo_lbl.Size.Width / 2) - 8
        Proyect.bingo_lbl.Location = New Point(x, Proyect.bingo_lbl.Location.Y)
    End Sub

    Shared Sub linea_bttn_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Se crean dos cuadros de diálogo, uno para la fuente y otro para elegir el color
        Dim linea_fntdiag As New FontDialog()
        Dim linea_cldiag As New ColorDialog()
        'Eje X para centrar
        Dim x As New Double

        'Muestra la última fuente y color utilizados en los cuadros de diálogo
        linea_fntdiag.Font = My.Settings.fuentes_linea
        linea_cldiag.Color = My.Settings.fuentes_linea_color

        'Si el cuadro de diálogo se cierra clickeando el botón "Ok", se cambia la fuente
        If linea_fntdiag.ShowDialog() = DialogResult.OK Then
            Proyect.linea_lbl.Font = linea_fntdiag.Font
            'Guarda las configuraciones
            My.Settings.fuentes_linea = linea_fntdiag.Font
        End If

        'Si el cuadro de diálogo se cierra clickeando el botón "Ok", se cambia el color
        If linea_cldiag.ShowDialog() = DialogResult.OK Then
            Proyect.linea_lbl.ForeColor = linea_cldiag.Color
            'Guarda las configuraciones
            My.Settings.fuentes_linea_color = linea_cldiag.Color
        End If

        'Centrado en pantalla
        x = (Proyect.Size.Width / 2) - (Proyect.linea_lbl.Size.Width / 2) - 8
        Proyect.linea_lbl.Location = New Point(x, Proyect.linea_lbl.Location.Y)
    End Sub

    Shared Sub nombre_bttn_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Se crean dos cuadros de diálogo, uno para la fuente y otro para elegir el color
        Dim nombre_fntdiag As New FontDialog()
        Dim nombre_cldiag As New ColorDialog()
        'Eje X para centrar
        Dim x As New Double

        'Muestra la última fuente y color utilizados en los cuadros de diálogo
        nombre_fntdiag.Font = My.Settings.fuentes_nombre
        nombre_cldiag.Color = My.Settings.fuentes_nombre_color

        'Si el cuadro de diálogo se cierra clickeando el botón "Ok", se cambia la fuente
        If nombre_fntdiag.ShowDialog() = DialogResult.OK Then
            Proyect.ganador_lbl.Font = nombre_fntdiag.Font
            'Guarda las configuraciones
            My.Settings.fuentes_nombre = nombre_fntdiag.Font
        End If

        'Si el cuadro de diálogo se cierra clickeando el botón "Ok", se cambia el color
        If nombre_cldiag.ShowDialog() = DialogResult.OK Then
            Proyect.ganador_lbl.ForeColor = nombre_cldiag.Color
            'Guarda las configuraciones
            My.Settings.fuentes_nombre_color = Proyect.ganador_lbl.ForeColor
        End If

        'Centrado en pantalla
        x = (Proyect.Size.Width / 2) - (Proyect.ganador_lbl.Size.Width / 2) - 8
        Proyect.ganador_lbl.Location = New Point(x, Proyect.ganador_lbl.Location.Y)
    End Sub

    Shared Sub fondo_panel_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Se crean dos cuadros de diálogo para elegir el color
        Dim fondo_panel_cldiag As New ColorDialog()

        'Muestra el último color utilizado en los cuadro de diálogo
        fondo_panel_cldiag.Color = My.Settings.color_fondo_panel

        'Si el cuadro de diálogo se cierra clickeando el botón "Ok", se cambia el color
        If fondo_panel_cldiag.ShowDialog() = DialogResult.OK Then
            'Guarda las configuraciones
            My.Settings.color_fondo_panel = fondo_panel_cldiag.Color
        End If
    End Sub

    Shared Sub fuente_lbl_grande_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Se crean dos cuadros de diálogo para elegir el color
        Dim lbl_grande_fntdiag As New FontDialog()
        Dim lbl_grande_cldiag As New ColorDialog()

        'Muestra la última fuente y color utilizados en los cuadros de diálogo
        lbl_grande_fntdiag.Font = My.Settings.lbl_grande
        lbl_grande_cldiag.Color = My.Settings.lbl_grande_color

        'Si el cuadro de diálogo se cierra clickeando el botón "Ok", se cambia la fuente
        If lbl_grande_fntdiag.ShowDialog() = DialogResult.OK Then
            Proyect.numero_lbl_grande.Font = lbl_grande_fntdiag.Font
            'Guarda las configuraciones
            My.Settings.lbl_grande = lbl_grande_fntdiag.Font
        End If

        'Si el cuadro de diálogo se cierra clickeando el botón "Ok", se cambia el color
        If lbl_grande_cldiag.ShowDialog() = DialogResult.OK Then
            Proyect.numero_lbl_grande.ForeColor = lbl_grande_cldiag.Color
            'Guarda las configuraciones
            My.Settings.lbl_grande_color = lbl_grande_cldiag.Color
        End If
    End Sub

    Shared Sub fondo_numeros_org_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Se crean dos cuadros de diálogo para elegir el color
        Dim fondo_numeros_org_cldiag As New ColorDialog()

        'Muestra el último color utilizado en los cuadro de diálogo
        fondo_numeros_org_cldiag.Color = My.Settings.color_fondo_numeros_org

        'Si el cuadro de diálogo se cierra clickeando el botón "Ok", se cambia el color
        If fondo_numeros_org_cldiag.ShowDialog() = DialogResult.OK Then
            'Guarda las configuraciones
            My.Settings.color_fondo_numeros_org = fondo_numeros_org_cldiag.Color
        End If
    End Sub

    Shared Sub texto_numeros_org_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Se crean dos cuadros de diálogo, uno para la fuente y otro para elegir el color
        Dim texto_numeros_org_fntdiag As New FontDialog()
        Dim texto_numeros_org_cldiag As New ColorDialog()

        'Muestra la última fuente y color utilizados en los cuadros de diálogo
        texto_numeros_org_fntdiag.Font = My.Settings.fuente_texto_numeros_org
        texto_numeros_org_cldiag.Color = My.Settings.color_texto_numeros_org

        'Si el cuadro de diálogo se cierra clickeando el botón "Ok", se cambia la fuente
        If texto_numeros_org_fntdiag.ShowDialog() = DialogResult.OK Then
            'Guarda las configuraciones
            My.Settings.fuente_texto_numeros_org = texto_numeros_org_fntdiag.Font
        End If

        'Si el cuadro de diálogo se cierra clickeando el botón "Ok", se cambia el color
        If texto_numeros_org_cldiag.ShowDialog() = DialogResult.OK Then
            'Guarda las configuraciones
            My.Settings.color_texto_numeros_org = texto_numeros_org_cldiag.Color
        End If
    End Sub

    Shared Sub fondo_numeros_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Se crean un cuadros de diálogo para elegir el color de fondo de los botones 
        Dim fondo_numeros_cldiag As New ColorDialog()

        'Muestra el último color utilizado en los cuadro de diálogo
        fondo_numeros_cldiag.Color = My.Settings.color_fondo_numeros

        'Si el cuadro de diálogo se cierra clickeando el botón "Ok", se cambia el color
        If fondo_numeros_cldiag.ShowDialog() = DialogResult.OK Then
            'Guarda las configuraciones
            My.Settings.color_fondo_numeros = fondo_numeros_cldiag.Color
        End If
    End Sub

    Shared Sub texto_numeros_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Se crean dos cuadros de diálogo, uno para la fuente y otro para elegir el color
        Dim texto_numeros_fntdiag As New FontDialog()
        Dim texto_numeros_cldiag As New ColorDialog()

        'Muestra la última fuente y color utilizados en los cuadros de diálogo
        texto_numeros_fntdiag.Font = My.Settings.fuente_texto_numeros
        texto_numeros_cldiag.Color = My.Settings.color_texto_numeros

        'Si el cuadro de diálogo se cierra clickeando el botón "Ok", se cambia la fuente
        If texto_numeros_fntdiag.ShowDialog() = DialogResult.OK Then
            'Guarda las configuraciones
            My.Settings.fuente_texto_numeros = texto_numeros_fntdiag.Font
        End If

        'Si el cuadro de diálogo se cierra clickeando el botón "Ok", se cambia el color
        If texto_numeros_cldiag.ShowDialog() = DialogResult.OK Then
            'Guarda las configuraciones
            My.Settings.color_texto_numeros = texto_numeros_cldiag.Color
        End If
    End Sub

#End Region

    Shared Sub formfuentes_Shown(sender As Object, e As EventArgs)
        MsgBox("Deberá reiniciar la ventana con el tablero luego de aplicar los cambios para que surtan efecto")
    End Sub
End Class
