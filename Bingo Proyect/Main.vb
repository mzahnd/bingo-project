Public Class Main
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Muestra el tiempo elegido anteriormente para mostrar el número grande en el tablero. Lo modifica también en el trackbar correspondiente en la pesataña "opciones".
        tiemp_tckbar.Value = My.Settings.tiemp_contador
        cronometro_lbl.Text = My.Settings.tiemp_contador
        'Muestra el valor del trackbar (tckbar_val_lbl)
        tckbar_val_lbl.Text = tiemp_tckbar.Value.ToString + " segundos"

        'Muestra from Proyect
        Proyect.Show()
        'Establece número máximo para el contador
        numero_txtbx.Maximum = "90"

        'Texto a mostrar en el ComboBox para cambiar la imagen de fondo
        'Si nunca se eligió un fondo personalizado, no se hace nada
        'Si ya se había elegido uno, se agrega a la lista
        If Not My.Settings.fondo_pers_combobox = "" Then
            Me.fondo_select.Items.Insert(2, My.Settings.fondo_pers_combobox)
        End If

        'Si el último fondo usado fue uno por defecto, se aplica
        'Caso contrario, se usa el personalizado
        'Para verificar esto se utiliza "fondo_last", que en caso de ser 1 significa que se usó un fondo personalizado por última vez
        If My.Settings.fondo_last = False Then
            fondo_select.Text = My.Settings.fondo
        ElseIf My.Settings.fondo_last = True Then
            fondo_select.Text = My.Settings.fondo_pers_combobox
        End If
        'Imagen de fondo
        Configs.fondo()

        Call Idiomas.seleccionar()
    End Sub

#Region "Barra_Menu"
    'Idiomas
    Private Sub english_bttn_bm_Click(sender As Object, e As EventArgs) Handles english_bttn_bm.Click
        'Inglés
        'Evita que cualquier otro idioma quede seleccionado
        spanish_bttn_bm.Checked = False

        english_bttn_bm.Checked = True
        'Cambia la configuración en My.Settings
        My.Settings.language = "english"

        'Reinicia el form
        Call Idiomas.seleccionar()
    End Sub

    Private Sub spanish_bttn_bm_Click(sender As Object, e As EventArgs) Handles spanish_bttn_bm.Click
        'Español
        'Evita que cualquier otro idioma quede seleccionado
        english_bttn_bm.Checked = False

        spanish_bttn_bm.Checked = True
        'Cambia la configuración en My.Settings
        My.Settings.language = "spanish"

        'Reinicia el form
        Call Idiomas.seleccionar()
    End Sub

    'Botón salir
    Private Sub salir_bttn_bm_Click(sender As Object, e As EventArgs) Handles salir_bttn_bm.Click
        End
    End Sub

    Private Sub about_bttn_bm_Click(sender As Object, e As EventArgs) Handles about_bttn_bm.Click
        About.Show()
    End Sub
#End Region

#Region "Tab_Principal"
    Shared Sub numero_bttn_Click(sender As Object, e As EventArgs) Handles numero_bttn.Click
        'Envía el número del contador al from Proyect
        Call Colores_Numeros.displaynumeros()
    End Sub

    Shared Sub nombre_bttn_Click(sender As Object, e As EventArgs) Handles nombre_bttn.Click
        'Muestra y envía el nombre del ganador y lo centra en pantalla
        'Eje X para centrar
        Dim x As New Double

        If Main.nombre_txtbx.Text = "" Then
            '
        Else
            If Proyect.ganador_lbl.Visible = False Then
                Proyect.ganador_lbl.Visible = True
                Proyect.ganador_lbl.Text = Main.nombre_txtbx.Text
                Main.nombre_bttn.Text = "Ocultar nombre del ganador"

                'Centrado en pantalla
                x = (Proyect.Size.Width / 2) - (Proyect.ganador_lbl.Size.Width / 2) - 8
                Proyect.ganador_lbl.Location = New Point(x, Proyect.ganador_lbl.Location.Y)
            Else
                Main.nombre_bttn.Text = "Mostrar nombre del ganador"
                Proyect.ganador_lbl.Visible = False
            End If
        End If
    End Sub

    Private Sub nombre_txtbx_KeyPress(sender As Object, e As KeyPressEventArgs) Handles nombre_txtbx.KeyPress
        'Evita que se escriba otra cosa que no sea letras en el textbox donde va el nombre
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Cronometro_Tick(sender As Object, e As EventArgs) Handles Cronometro.Tick
        'Cuando se lo activa (ver en NumerosColor.vb), descuenta 1 al tiempo restante para mostrar el número grande
        cronometro_lbl.Text -= 1
    End Sub

    Private Sub linea_bttn_Click(sender As Object, e As EventArgs) Handles linea_bttn.Click
        'Envía "Linea" al from Proyect y lo centra en pantalla. Si ya aparece, lo oculta
        'Eje X e Y para centrar
        Dim x As New Double
        Dim y As New Double

        If Proyect.linea_lbl.Visible = False Then
            Proyect.bingo_lbl.Visible = False

            Proyect.linea_lbl.Visible = True

            'Centrado en pantalla
            x = (Proyect.Size.Width / 2) - (Proyect.linea_lbl.Size.Width / 2) - 8
            Proyect.linea_lbl.Location = New Point(x, Proyect.linea_lbl.Location.Y)


        Else
            Proyect.linea_lbl.Visible = False
        End If
    End Sub

    Private Sub bingo_bttn_Click(sender As Object, e As EventArgs) Handles bingo_bttn.Click
        'Envía "Bingo" al from Proyect y lo centra en pantalla. Si ya aparece, lo oculta
        'Eje X para centrar
        Dim x As New Double

        If Proyect.bingo_lbl.Visible = False Then
            Proyect.linea_lbl.Visible = False

            Proyect.bingo_lbl.Visible = True

            'Centrado en pantalla
            x = (Proyect.Size.Width / 2) - (Proyect.bingo_lbl.Size.Width / 2) - 8
            Proyect.bingo_lbl.Location = New Point(x, Proyect.bingo_lbl.Location.Y)
        Else
            Proyect.bingo_lbl.Visible = False
        End If
    End Sub
#End Region

#Region "Tab_Opciones"
    Private Sub reiniciar_bttn_Click(sender As Object, e As EventArgs) Handles reiniciar_bttn.Click
        'Reinicia el programa
        'Lo cierra, restaura su tamaño original, ajusta el círuclo y el panel, y vuelve a mostrar el form
        Proyect.Close()

        Proyect.Width = 880
        Proyect.Height = 700

        Call Proyect_size.pos_circulo_spanel_default()

        'Si fue elegido un fondo personalizado, asegura que se muestre al reiniciar el Form
        If My.Settings.fondo_last = True Then
            Proyect.Fondo_pic.Image = Image.FromFile(My.Settings.fondo_pers.ToString)
        End If

        Proyect.Show()


    End Sub

    Private Sub bolillero_bttn_Click(sender As Object, e As EventArgs) Handles bolillero_bttn.Click
        'Muestra el bolillero
        Bolillero.Show()
    End Sub

    Private Sub mostrar_bttn_Click(sender As Object, e As EventArgs) Handles mostrar_bttn.Click
        'Muestra el from Proyect
        Proyect.Show()
    End Sub

    Private Sub titulo_bttn_Click(sender As Object, e As EventArgs) Handles titulo_bttn.Click
        Call Proyect_size.full_screen()
    End Sub

    Private Sub fuentes_bttn_Click(sender As Object, e As EventArgs) Handles fuentes_bttn.Click
        Call Fuentes_Form.ventana()
    End Sub

    Private Sub fondo_select_SelectedIndexChanged(sender As Object, e As EventArgs) Handles fondo_select.SelectedIndexChanged
        If fondo_select.Text = "Examinar..." Then
            Call Configs.fondo()
        End If
    End Sub

    Private Sub aplicar_fnd_bttn_Click(sender As Object, e As EventArgs) Handles aplicar_fnd_bttn.Click
        'Aplica el fondo elegido y guarda la elección
        Configs.fondo()
    End Sub

    Private Sub panel_bttn_Click(sender As Object, e As EventArgs) Handles panel_bttn.Click

        If panel_bttn.Text = "Ocultar panel de números" Then
            'Oculta el panel
            Call Proyect_size.pos_circulo_spanel()

        ElseIf panel_bttn.Text = "Mostrar panel de números" Then
            'Muestra el panel
            Call Proyect_size.pos_circulo_cpanel()

        End If
    End Sub

    Private Sub tiemp_tckbar_Scroll(sender As Object, e As EventArgs) Handles tiemp_tckbar.Scroll
        'Cuando el valor del trackbar cambia, se muestra en el label a su derecha (tckbar_val_lbl)
        tckbar_val_lbl.Text = tiemp_tckbar.Value.ToString + " segundos"

        'Cuando el valor del trackbar cambia, también lo hace el del cronómetro en la pestaña principal (cronometro_lbl)
        cronometro_lbl.Text = tiemp_tckbar.Value

        'Además se cambia el valor en My.Settings, para guardarlo luego de cerrar el programa
        My.Settings.tiemp_contador = tiemp_tckbar.Value
    End Sub

    Private Sub restaurar_bttn_Click(sender As Object, e As EventArgs) Handles restaurar_bttn.Click
        'Restaura las configuraciones por defecto
        Call Configs.restaurar_defaults()
    End Sub
#End Region

End Class
