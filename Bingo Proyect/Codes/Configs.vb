Public Class Configs

    Public Shared Sub fondo()
        'De acuerdo al texto en el ComboBox, elige la imagen de fondo
        Select Case Main.fondo_select.Text
            Case "Tela roja"
                'Establece la opción en las configuraciones
                My.Settings.fondo = "Tela roja"
                My.Settings.color_fondo_panel = Color.Maroon

                'En caso de ser  "Tela roja", elige la imagen con tela roja
                Proyect.Fondo_pic.Image = Bingo_Project.My.Resources.Resources.tela_roja

                'Cambia el color de fondo del panel en el form Proyect por uno similar 
                Proyect.panel_numeros.BackColor = My.Settings.color_fondo_panel

                'Evita que se seleccione el fondo personalizado por defecto
                My.Settings.fondo_last = False

            Case "Tela blanca"
                'Establece la opción en las configuraciones
                My.Settings.fondo = "Tela blanca"
                My.Settings.color_fondo_panel = Color.White

                'En caso de ser  "Tela blanca", elige la imagen con tela blanca
                Proyect.Fondo_pic.Image = Bingo_Project.My.Resources.Resources.tela_blanca

                'Cambia el color de fondo del panel en el form Proyect por uno similar 
                Proyect.panel_numeros.BackColor = My.Settings.color_fondo_panel

                'Evita que se seleccione el fondo personalizado por defecto
                My.Settings.fondo_last = False

            Case "Examinar..."
                'Si se elige examinar para buscar uno personalizado, se crea un cuadro de diálogo para abrir la imagen
                Dim Abrir As New OpenFileDialog()

                'Nombre para mostrar del cuadro de diálogo
                Abrir.Title = "Abrir"
                'Se inicializa en la ruta de imágenes del usuario
                Abrir.InitialDirectory = "%homepath%\Pictures"
                'Se filtran las imágenes, aunque se mantiene la opción de abrir un archivo cualquiera
                Abrir.Filter = "Archivo de imagen (*.gif;*.jpg;*.jpeg;*.bmp;*.wmf;*.png)|*.gif;*.jpg;*.jpeg;*.bmp;*.wmf;*.png|Todos los archivos [*,*]|*,*"
                'Corrobora que el usuario no haya introducido un archivo con un nombre inexistente
                Abrir.CheckFileExists = True

                If Abrir.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    'Si seleccionó una imagen, la asigna como fondo del Form Proyect
                    Proyect.Fondo_pic.Image = Image.FromFile(Abrir.FileName)
                    'Se remueve el actual
                    Main.fondo_select.Items.RemoveAt(2)
                    'Agrega el nombre del archivo (sin extensión ni ruta) en el tercer lugar del ComboBox "fondo_select"
                    If Main.fondo_select.Items.Count <> 3 Then
                        Main.fondo_select.Items.Insert(2, System.IO.Path.GetFileNameWithoutExtension(Abrir.FileName))
                        Main.fondo_select.Items.Insert(3, "Examinar...")
                    Else
                        Main.fondo_select.Items.Remove(2)
                        Main.fondo_select.Items.Insert(2, System.IO.Path.GetFileNameWithoutExtension(Abrir.FileName))
                    End If

                    'Guarda la ruta del archivo
                    My.Settings.fondo_pers = Abrir.FileName
                    'Guarda el nombre del archivo (sin extensión ni ruta) y su lugar en el ComboBox "fondo_select"
                    My.Settings.fondo_pers_combobox = Main.fondo_select.Items(2)

                    'Selecciona el nombre del archivo en el ComboBox "fondo_select"
                    Main.fondo_select.SelectedIndex = 2

                    'Selecciona el fondo personalizado por defecto
                    My.Settings.fondo_last = True
                End If

            Case My.Settings.fondo_pers_combobox
                Proyect.Fondo_pic.Image = Image.FromFile(My.Settings.fondo_pers.ToString)

                'Selecciona el fondo personalizado por defecto
                My.Settings.fondo_last = True
        End Select
    End Sub

    Public Shared Sub numero_lbl()
#Region "Lista de números"
        Dim numero_lbl_list As New List(Of Label) From {Proyect.numero_lbl_1,
                                                  Proyect.numero_lbl_2,
                                                  Proyect.numero_lbl_3,
                                                  Proyect.numero_lbl_4,
                                                  Proyect.numero_lbl_5,
                                                  Proyect.numero_lbl_6,
                                                  Proyect.numero_lbl_7,
                                                  Proyect.numero_lbl_8,
                                                  Proyect.numero_lbl_9,
                                                  Proyect.numero_lbl_10,
                                                  Proyect.numero_lbl_11,
                                                  Proyect.numero_lbl_12,
                                                  Proyect.numero_lbl_13,
                                                  Proyect.numero_lbl_14,
                                                  Proyect.numero_lbl_15,
                                                  Proyect.numero_lbl_16,
                                                  Proyect.numero_lbl_17,
                                                  Proyect.numero_lbl_18,
                                                  Proyect.numero_lbl_19,
                                                  Proyect.numero_lbl_20,
                                                  Proyect.numero_lbl_21,
                                                  Proyect.numero_lbl_22,
                                                  Proyect.numero_lbl_23,
                                                  Proyect.numero_lbl_24,
                                                  Proyect.numero_lbl_25,
                                                  Proyect.numero_lbl_26,
                                                  Proyect.numero_lbl_27,
                                                  Proyect.numero_lbl_28,
                                                  Proyect.numero_lbl_29,
                                                  Proyect.numero_lbl_30,
                                                  Proyect.numero_lbl_31,
                                                  Proyect.numero_lbl_32,
                                                  Proyect.numero_lbl_33,
                                                  Proyect.numero_lbl_34,
                                                  Proyect.numero_lbl_35,
                                                  Proyect.numero_lbl_36,
                                                  Proyect.numero_lbl_37,
                                                  Proyect.numero_lbl_38,
                                                  Proyect.numero_lbl_39,
                                                  Proyect.numero_lbl_40,
                                                  Proyect.numero_lbl_41,
                                                  Proyect.numero_lbl_42,
                                                  Proyect.numero_lbl_43,
                                                  Proyect.numero_lbl_44,
                                                  Proyect.numero_lbl_45,
                                                  Proyect.numero_lbl_46,
                                                  Proyect.numero_lbl_47,
                                                  Proyect.numero_lbl_48,
                                                  Proyect.numero_lbl_49,
                                                  Proyect.numero_lbl_50,
                                                  Proyect.numero_lbl_51,
                                                  Proyect.numero_lbl_52,
                                                  Proyect.numero_lbl_53,
                                                  Proyect.numero_lbl_54,
                                                  Proyect.numero_lbl_55,
                                                  Proyect.numero_lbl_56,
                                                  Proyect.numero_lbl_57,
                                                  Proyect.numero_lbl_58,
                                                  Proyect.numero_lbl_59,
                                                  Proyect.numero_lbl_60,
                                                  Proyect.numero_lbl_61,
                                                  Proyect.numero_lbl_62,
                                                  Proyect.numero_lbl_63,
                                                  Proyect.numero_lbl_64,
                                                  Proyect.numero_lbl_65,
                                                  Proyect.numero_lbl_66,
                                                  Proyect.numero_lbl_67,
                                                  Proyect.numero_lbl_68,
                                                  Proyect.numero_lbl_69,
                                                  Proyect.numero_lbl_70,
                                                  Proyect.numero_lbl_71,
                                                  Proyect.numero_lbl_72,
                                                  Proyect.numero_lbl_73,
                                                  Proyect.numero_lbl_74,
                                                  Proyect.numero_lbl_75,
                                                  Proyect.numero_lbl_76,
                                                  Proyect.numero_lbl_77,
                                                  Proyect.numero_lbl_78,
                                                  Proyect.numero_lbl_79,
                                                  Proyect.numero_lbl_80,
                                                  Proyect.numero_lbl_81,
                                                  Proyect.numero_lbl_82,
                                                  Proyect.numero_lbl_83,
                                                  Proyect.numero_lbl_84,
                                                  Proyect.numero_lbl_85,
                                                  Proyect.numero_lbl_86,
                                                  Proyect.numero_lbl_87,
                                                  Proyect.numero_lbl_88,
                                                  Proyect.numero_lbl_89,
                                                  Proyect.numero_lbl_90}
#End Region

        Call fondo_numeros_org(numero_lbl_list)
        Call texto_numeros_org(numero_lbl_list)
        'Call fondo_numeros(numero_lbl_list)
        'Call texto_numeros(numero_lbl_list)
    End Sub

    Public Shared Sub fondo_numeros_org(ByVal numero_lbl_list)
        For i = 0 To numero_lbl_list.Count - 1
            numero_lbl_list(i).BackColor = My.Settings.color_fondo_numeros_org
        Next
    End Sub

    Public Shared Sub texto_numeros_org(ByVal numero_lbl_list)
        For i = 0 To numero_lbl_list.Count - 1
            numero_lbl_list(i).Font = My.Settings.fuente_texto_numeros_org
        Next

        For i = 0 To numero_lbl_list.Count - 1
            numero_lbl_list(i).ForeColor = My.Settings.color_texto_numeros_org
        Next
    End Sub

    Public Shared Sub fondo_numeros(ByVal numero_lbl_list)
        For i = 0 To numero_lbl_list.Count - 1
            numero_lbl_list(i).BackColor = My.Settings.color_fondo_numeros
        Next
    End Sub

    Public Shared Sub texto_numeros(ByVal numero_lbl_list)
        For i = 0 To numero_lbl_list.Count - 1
            numero_lbl_list(i).Font = My.Settings.fuente_texto_numeros
        Next

        For i = 0 To numero_lbl_list.Count - 1
            numero_lbl_list(i).ForeColor = My.Settings.color_texto_numeros
        Next
    End Sub

    Public Shared Sub restaurar_defaults()
        '=== Restaura todas las configuraciones por defecto del programa ===
        '=== Reemplazando las de My Settings por las originales ===
        'Fuentes para no repetir código
        Dim fuente_108 As New Font("Times New Roman", 108, FontStyle.Regular)
        Dim fuente_72 As New Font("Arial", 72, FontStyle.Regular)
        Dim fuente_48 As New Font("Arial", 48, FontStyle.Regular)
        Dim fuente_20 As New Font("Times New Roman", 20.25, FontStyle.Regular)

        '=== Configuraciones a restaurar ===
        'Valor timer del número grande y el trackbar que lo modifica
        'Tiempo almacenado en My.Settings
        My.Settings.tiemp_contador = 10
        'Timer Contador en Form Proyect
        Proyect.Contador.Interval = "10000"
        'TrackBar y su label en Form Main
        Main.tiemp_tckbar.Value = 10
        Main.tckbar_val_lbl.Text = Main.tiemp_tckbar.Value

        'Restauración de fuentes
        My.Settings.fuentes_bingo = fuente_72
        My.Settings.fuentes_bingo_color = Color.Yellow
        My.Settings.fuentes_linea = fuente_72
        My.Settings.fuentes_linea_color = Color.Yellow
        My.Settings.fuentes_nombre = fuente_48
        My.Settings.fuentes_nombre_color = Color.White



        'Color números y cuadrícula
        My.Settings.color_fondo_numeros = Color.Black
        My.Settings.color_texto_numeros = Color.Yellow
        My.Settings.color_fondo_numeros_org = Color.Green
        My.Settings.color_texto_numeros_org = Color.White

        'Fuente números
        My.Settings.fuente_texto_numeros = fuente_20
        My.Settings.fuente_texto_numeros_org = fuente_20

        'Fuente número grande
        My.Settings.lbl_grande = fuente_108
        'Color número grande
        My.Settings.lbl_grande_color = Color.Black

        'Panel
        'Color panel de números
        My.Settings.color_fondo_panel = Color.Maroon
        'Muestra el panel
        My.Settings.panel_sh = True

        'Fondo
        My.Settings.fondo_pers = ""
        My.Settings.fondo_pers_combobox = ""
        My.Settings.fondo_last = False
        My.Settings.fondo = "Tela roja"

        'Botón Main Form
        Main.titulo_bttn.Text = "Ocultar barra de título"

        '=== Borra la imagen agregada por el usuario y establece el fondo por defecto ===
        If Main.fondo_select.Items.Count <> 3 Then
            Main.fondo_select.Items.RemoveAt(2)
        End If
        Main.fondo_select.Text = "Tela roja"
        Proyect.Fondo_pic.Image = Bingo_Project.My.Resources.Resources.tela_roja

        '=== Oculta y luego muestra el form Proyect nuevamente ===
        Proyect.Close()
        Proyect.Show()
    End Sub
End Class
