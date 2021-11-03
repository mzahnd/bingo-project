Public Class Proyect
    Private Sub Proyect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Sitúa el fondo y hace que llene el Form
        Fondo_pic.Location = New Point(0, 0)
        Fondo_pic.Dock = DockStyle.Fill

#Region "Transparencia"
        'Establece la transparencia
        'numero_lbl_grande.Parent = circulo_pic
        circulo_pic.Parent = Fondo_pic

        panel_numeros.Parent = Fondo_pic
        bingo_lbl.Parent = Fondo_pic
        linea_lbl.Parent = Fondo_pic
        ganador_lbl.Parent = Fondo_pic
#End Region

#Region "Configuraciones"
        'Se establecen las configuraciones de colores en los números
        Call Configs.numero_lbl()
        'Configuraciones del panel
        panel_numeros.BackColor = My.Settings.color_fondo_panel
        'Configuraciones del label Linea
        linea_lbl.Font = My.Settings.fuentes_linea
        linea_lbl.ForeColor = My.Settings.fuentes_linea_color
        'Configuraciones del label Bingo
        bingo_lbl.Font = My.Settings.fuentes_bingo
        bingo_lbl.ForeColor = My.Settings.fuentes_bingo_color
        'Configuraciones del label Nombre
        ganador_lbl.Font = My.Settings.fuentes_nombre
        ganador_lbl.ForeColor = My.Settings.fuentes_nombre_color

        'Guarda el estado del panel (visible u oculto)
        If My.Settings.panel_sh = True Then
            'Muestra el panel
            Call Proyect_size.pos_circulo_cpanel()

        ElseIf My.Settings.panel_sh = False Then
            'Oculta el panel
            Call Proyect_size.pos_circulo_spanel()

        End If
#End Region
    End Sub

    Private Sub Proyect_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        'Si detecta que es pulsada la tecla Escape o F11 en el teclado, activa o desactiva la pantalla completa
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Escape) Or e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.F11) Then
            Call Proyect_size.full_screen()
            e.Handled = True
        End If
    End Sub

    Private Sub tamano_Tick(sender As Object, e As EventArgs) Handles Tamano.Tick
        'Se encarga de mantener el tamaño de todos los números proporcional al del form
        Call Proyect_size.size_numeros()

        Call Proyect_size.size_lblsinf()
    End Sub

    Private Sub Contador_Tick(sender As Object, e As EventArgs) Handles Contador.Tick
        'Muestra "00" como texto en el numero_lbl_grande
        numero_lbl_grande.Text = "00"

        'Desactiva el cronómetro mostrado en el Main Form
        Main.Cronometro.Stop()
        Main.Cronometro.Enabled = False
        'El cronómetro del Main Form se detiene antes de cambiar el valor del label que ve el usuario, dejando siempre el tiempo restante en 1.
        'Con la siguiente condición If se transforma en 0.
        If Main.cronometro_lbl.Text <> 0 And Main.cronometro_lbl.Text <> Main.tiemp_tckbar.Value Then
            Main.cronometro_lbl.Text -= 1
        End If
        'Se espera un segundo antes de volver el label del cronómetro al valor del trackbar.
        Dim intervalo As New TimeSpan(0, 0, 1)
        'Se cambia el label al valor del trackbar.
        If Main.cronometro_lbl.Text = 0 Then
            Main.cronometro_lbl.Text = Main.tiemp_tckbar.Value
        End If


    End Sub

    Private Sub Contra_contador_Tick(sender As Object, e As EventArgs) Handles Contra_contador.Tick
        'Muestra "00" como texto en el numero_lbl_grande
        numero_lbl_grande.Text = "00"
    End Sub

    Private Sub tamano_circulo_Tick(sender As Object, e As EventArgs) Handles Tamano_circulo.Tick
        'Cambia el tamaño del círculo grande
        Call Proyect_size.size_circulo()
    End Sub
End Class