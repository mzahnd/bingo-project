Public Class Colores_Numeros
    Public Shared Sub displaynumeros() 'ByVal numero_lbl_list)
        'En "almacen" se guardará el número que se introduce en en form Main
        Dim almacen As String
        'Se almacenan los colores de fondo y texto, así como la fuente, una vez elegido el número
        Dim color_fondo As Color
        Dim color_texto As Color
        Dim fuente_texto As Font

        'Indicador
        Dim color_igual As Byte
        color_igual = 0

        'Se indica de dónde tomar el número a guardar
        almacen = Main.numero_txtbx.Text

        'Colores de fondo, texto y fuente una vez elegido el número
        color_fondo = My.Settings.color_fondo_numeros
        color_texto = My.Settings.color_texto_numeros
        fuente_texto = My.Settings.fuente_texto_numeros

        'Se verifica si el número elegido ya lo había sido previamente; en caso que sea así
        'se lo devuelve a sus colores originales
        yaelegido(color_igual, almacen, color_fondo)

        'Si la variable "color_igual" continua siendo 0, se cambia el color del número
        If color_igual = 0 Then
            'Detiene y deshabilita el timer "Contra_contador", encargado de mostrar "00" en lugar del número elegido
            Proyect.Contra_contador.Stop()
            Proyect.Contra_contador.Enabled = False

            'Habilita y comienza el timer "Contador", encargado de mostrar el número elegido por 10 segundos
            Proyect.Contador.Enabled = True
            Main.Cronometro.Enabled = True
            'Reinicia el tiempo del timer a 0 para evitar que se visualice el número menos de lo debido
            'Ambos timers (Contador en Proyect y Cronometro en Main) se cambian de intervalo a 1 y luego a su valor final_
            'para evitar un bug en el cual se muestra por menos tiempo de lo debido el número en pantalla
            'Timer encargado de mostrar "00" en el Form Proyect
            Proyect.Contador.Interval = "1"
            Proyect.Contador.Start()
            Proyect.Contador.Stop()
            'Timer que muestra el tiempo transcurrido en el Main Form
            Main.Cronometro.Interval = "1"
            Main.Cronometro.Start()
            Main.Cronometro.Stop()
            'Intervalo final
            Proyect.Contador.Interval = My.Settings.tiemp_contador * 1000
            Proyect.Contador.Start()
            Main.Cronometro.Interval = "1000"
            Main.Cronometro.Start()

#Region "Color"
            'Dependiendo el número guardado en "almacen" selecciona el lable correspondiente y cambia su color de fondo y letra
            Select Case almacen
                Case "1"
                    Proyect.numero_lbl_1.BackColor = color_fondo
                    Proyect.numero_lbl_1.ForeColor = color_texto
                    Proyect.numero_lbl_1.Font = fuente_texto
                Case "2"
                    Proyect.numero_lbl_2.BackColor = color_fondo
                    Proyect.numero_lbl_2.ForeColor = color_texto
                    Proyect.numero_lbl_2.Font = fuente_texto
                Case "3"
                    Proyect.numero_lbl_3.BackColor = color_fondo
                    Proyect.numero_lbl_3.ForeColor = color_texto
                    Proyect.numero_lbl_3.Font = fuente_texto
                Case "4"
                    Proyect.numero_lbl_4.BackColor = color_fondo
                    Proyect.numero_lbl_4.ForeColor = color_texto
                    Proyect.numero_lbl_4.Font = fuente_texto
                Case "5"
                    Proyect.numero_lbl_5.BackColor = color_fondo
                    Proyect.numero_lbl_5.ForeColor = color_texto
                    Proyect.numero_lbl_5.Font = fuente_texto
                Case "6"
                    Proyect.numero_lbl_6.BackColor = color_fondo
                    Proyect.numero_lbl_6.ForeColor = color_texto
                    Proyect.numero_lbl_6.Font = fuente_texto
                Case "7"
                    Proyect.numero_lbl_7.BackColor = color_fondo
                    Proyect.numero_lbl_7.ForeColor = color_texto
                    Proyect.numero_lbl_7.Font = fuente_texto
                Case "8"
                    Proyect.numero_lbl_8.BackColor = color_fondo
                    Proyect.numero_lbl_8.ForeColor = color_texto
                    Proyect.numero_lbl_8.Font = fuente_texto
                Case "9"
                    Proyect.numero_lbl_9.BackColor = color_fondo
                    Proyect.numero_lbl_9.ForeColor = color_texto
                    Proyect.numero_lbl_9.Font = fuente_texto


                Case "10"
                    Proyect.numero_lbl_10.BackColor = color_fondo
                    Proyect.numero_lbl_10.ForeColor = color_texto
                    Proyect.numero_lbl_10.Font = fuente_texto
                Case "11"
                    Proyect.numero_lbl_11.BackColor = color_fondo
                    Proyect.numero_lbl_11.ForeColor = color_texto
                    Proyect.numero_lbl_11.Font = fuente_texto
                Case "12"
                    Proyect.numero_lbl_12.BackColor = color_fondo
                    Proyect.numero_lbl_12.ForeColor = color_texto
                    Proyect.numero_lbl_12.Font = fuente_texto
                Case "13"
                    Proyect.numero_lbl_13.BackColor = color_fondo
                    Proyect.numero_lbl_13.ForeColor = color_texto
                    Proyect.numero_lbl_13.Font = fuente_texto
                Case "14"
                    Proyect.numero_lbl_14.BackColor = color_fondo
                    Proyect.numero_lbl_14.ForeColor = color_texto
                    Proyect.numero_lbl_14.Font = fuente_texto
                Case "15"
                    Proyect.numero_lbl_15.BackColor = color_fondo
                    Proyect.numero_lbl_15.ForeColor = color_texto
                    Proyect.numero_lbl_15.Font = fuente_texto
                Case "16"
                    Proyect.numero_lbl_16.BackColor = color_fondo
                    Proyect.numero_lbl_16.ForeColor = color_texto
                    Proyect.numero_lbl_16.Font = fuente_texto
                Case "17"
                    Proyect.numero_lbl_17.BackColor = color_fondo
                    Proyect.numero_lbl_17.ForeColor = color_texto
                    Proyect.numero_lbl_17.Font = fuente_texto
                Case "18"
                    Proyect.numero_lbl_18.BackColor = color_fondo
                    Proyect.numero_lbl_18.ForeColor = color_texto
                    Proyect.numero_lbl_18.Font = fuente_texto
                Case "19"
                    Proyect.numero_lbl_19.BackColor = color_fondo
                    Proyect.numero_lbl_19.ForeColor = color_texto
                    Proyect.numero_lbl_19.Font = fuente_texto


                Case "20"
                    Proyect.numero_lbl_20.BackColor = color_fondo
                    Proyect.numero_lbl_20.ForeColor = color_texto
                    Proyect.numero_lbl_20.Font = fuente_texto
                Case "21"
                    Proyect.numero_lbl_21.BackColor = color_fondo
                    Proyect.numero_lbl_21.ForeColor = color_texto
                    Proyect.numero_lbl_21.Font = fuente_texto
                Case "22"
                    Proyect.numero_lbl_22.BackColor = color_fondo
                    Proyect.numero_lbl_22.ForeColor = color_texto
                    Proyect.numero_lbl_22.Font = fuente_texto
                Case "23"
                    Proyect.numero_lbl_23.BackColor = color_fondo
                    Proyect.numero_lbl_23.ForeColor = color_texto
                    Proyect.numero_lbl_23.Font = fuente_texto
                Case "24"
                    Proyect.numero_lbl_24.BackColor = color_fondo
                    Proyect.numero_lbl_24.ForeColor = color_texto
                    Proyect.numero_lbl_24.Font = fuente_texto
                Case "25"
                    Proyect.numero_lbl_25.BackColor = color_fondo
                    Proyect.numero_lbl_25.ForeColor = color_texto
                    Proyect.numero_lbl_25.Font = fuente_texto
                Case "26"
                    Proyect.numero_lbl_26.BackColor = color_fondo
                    Proyect.numero_lbl_26.ForeColor = color_texto
                    Proyect.numero_lbl_26.Font = fuente_texto
                Case "27"
                    Proyect.numero_lbl_27.BackColor = color_fondo
                    Proyect.numero_lbl_27.ForeColor = color_texto
                    Proyect.numero_lbl_27.Font = fuente_texto
                Case "28"
                    Proyect.numero_lbl_28.BackColor = color_fondo
                    Proyect.numero_lbl_28.ForeColor = color_texto
                    Proyect.numero_lbl_28.Font = fuente_texto
                Case "29"
                    Proyect.numero_lbl_29.BackColor = color_fondo
                    Proyect.numero_lbl_29.ForeColor = color_texto
                    Proyect.numero_lbl_29.Font = fuente_texto

                Case "30"
                    Proyect.numero_lbl_30.BackColor = color_fondo
                    Proyect.numero_lbl_30.ForeColor = color_texto
                    Proyect.numero_lbl_30.Font = fuente_texto
                Case "31"
                    Proyect.numero_lbl_31.BackColor = color_fondo
                    Proyect.numero_lbl_31.ForeColor = color_texto
                    Proyect.numero_lbl_31.Font = fuente_texto
                Case "32"
                    Proyect.numero_lbl_32.BackColor = color_fondo
                    Proyect.numero_lbl_32.ForeColor = color_texto
                    Proyect.numero_lbl_32.Font = fuente_texto
                Case "33"
                    Proyect.numero_lbl_33.BackColor = color_fondo
                    Proyect.numero_lbl_33.ForeColor = color_texto
                    Proyect.numero_lbl_33.Font = fuente_texto
                Case "34"
                    Proyect.numero_lbl_34.BackColor = color_fondo
                    Proyect.numero_lbl_34.ForeColor = color_texto
                    Proyect.numero_lbl_34.Font = fuente_texto
                Case "35"
                    Proyect.numero_lbl_35.BackColor = color_fondo
                    Proyect.numero_lbl_35.ForeColor = color_texto
                    Proyect.numero_lbl_35.Font = fuente_texto
                Case "36"
                    Proyect.numero_lbl_36.BackColor = color_fondo
                    Proyect.numero_lbl_36.ForeColor = color_texto
                    Proyect.numero_lbl_36.Font = fuente_texto
                Case "37"
                    Proyect.numero_lbl_37.BackColor = color_fondo
                    Proyect.numero_lbl_37.ForeColor = color_texto
                    Proyect.numero_lbl_37.Font = fuente_texto
                Case "38"
                    Proyect.numero_lbl_38.BackColor = color_fondo
                    Proyect.numero_lbl_38.ForeColor = color_texto
                    Proyect.numero_lbl_38.Font = fuente_texto
                Case "39"
                    Proyect.numero_lbl_39.BackColor = color_fondo
                    Proyect.numero_lbl_39.ForeColor = color_texto
                    Proyect.numero_lbl_39.Font = fuente_texto


                Case "40"
                    Proyect.numero_lbl_40.BackColor = color_fondo
                    Proyect.numero_lbl_40.ForeColor = color_texto
                    Proyect.numero_lbl_40.Font = fuente_texto
                Case "41"
                    Proyect.numero_lbl_41.BackColor = color_fondo
                    Proyect.numero_lbl_41.ForeColor = color_texto
                    Proyect.numero_lbl_41.Font = fuente_texto
                Case "42"
                    Proyect.numero_lbl_42.BackColor = color_fondo
                    Proyect.numero_lbl_42.ForeColor = color_texto
                    Proyect.numero_lbl_42.Font = fuente_texto
                Case "43"
                    Proyect.numero_lbl_43.BackColor = color_fondo
                    Proyect.numero_lbl_43.ForeColor = color_texto
                    Proyect.numero_lbl_43.Font = fuente_texto
                Case "44"
                    Proyect.numero_lbl_44.BackColor = color_fondo
                    Proyect.numero_lbl_44.ForeColor = color_texto
                    Proyect.numero_lbl_44.Font = fuente_texto
                Case "45"
                    Proyect.numero_lbl_45.BackColor = color_fondo
                    Proyect.numero_lbl_45.ForeColor = color_texto
                    Proyect.numero_lbl_45.Font = fuente_texto
                Case "46"
                    Proyect.numero_lbl_46.BackColor = color_fondo
                    Proyect.numero_lbl_46.ForeColor = color_texto
                    Proyect.numero_lbl_46.Font = fuente_texto
                Case "47"
                    Proyect.numero_lbl_47.BackColor = color_fondo
                    Proyect.numero_lbl_47.ForeColor = color_texto
                    Proyect.numero_lbl_47.Font = fuente_texto
                Case "48"
                    Proyect.numero_lbl_48.BackColor = color_fondo
                    Proyect.numero_lbl_48.ForeColor = color_texto
                    Proyect.numero_lbl_48.Font = fuente_texto
                Case "49"
                    Proyect.numero_lbl_49.BackColor = color_fondo
                    Proyect.numero_lbl_49.ForeColor = color_texto
                    Proyect.numero_lbl_49.Font = fuente_texto

                Case "50"
                    Proyect.numero_lbl_50.BackColor = color_fondo
                    Proyect.numero_lbl_50.ForeColor = color_texto
                    Proyect.numero_lbl_50.Font = fuente_texto
                Case "51"
                    Proyect.numero_lbl_51.BackColor = color_fondo
                    Proyect.numero_lbl_51.ForeColor = color_texto
                    Proyect.numero_lbl_51.Font = fuente_texto
                Case "52"
                    Proyect.numero_lbl_52.BackColor = color_fondo
                    Proyect.numero_lbl_52.ForeColor = color_texto
                    Proyect.numero_lbl_52.Font = fuente_texto
                Case "53"
                    Proyect.numero_lbl_53.BackColor = color_fondo
                    Proyect.numero_lbl_53.ForeColor = color_texto
                    Proyect.numero_lbl_53.Font = fuente_texto
                Case "54"
                    Proyect.numero_lbl_54.BackColor = color_fondo
                    Proyect.numero_lbl_54.ForeColor = color_texto
                    Proyect.numero_lbl_54.Font = fuente_texto
                Case "55"
                    Proyect.numero_lbl_55.BackColor = color_fondo
                    Proyect.numero_lbl_55.ForeColor = color_texto
                    Proyect.numero_lbl_55.Font = fuente_texto
                Case "56"
                    Proyect.numero_lbl_56.BackColor = color_fondo
                    Proyect.numero_lbl_56.ForeColor = color_texto
                    Proyect.numero_lbl_56.Font = fuente_texto
                Case "57"
                    Proyect.numero_lbl_57.BackColor = color_fondo
                    Proyect.numero_lbl_57.ForeColor = color_texto
                    Proyect.numero_lbl_57.Font = fuente_texto
                Case "58"
                    Proyect.numero_lbl_58.BackColor = color_fondo
                    Proyect.numero_lbl_58.ForeColor = color_texto
                    Proyect.numero_lbl_58.Font = fuente_texto
                Case "59"
                    Proyect.numero_lbl_59.BackColor = color_fondo
                    Proyect.numero_lbl_59.ForeColor = color_texto
                    Proyect.numero_lbl_59.Font = fuente_texto

                Case "60"
                    Proyect.numero_lbl_60.BackColor = color_fondo
                    Proyect.numero_lbl_60.ForeColor = color_texto
                    Proyect.numero_lbl_60.Font = fuente_texto
                Case "61"
                    Proyect.numero_lbl_61.BackColor = color_fondo
                    Proyect.numero_lbl_61.ForeColor = color_texto
                    Proyect.numero_lbl_61.Font = fuente_texto
                Case "62"
                    Proyect.numero_lbl_62.BackColor = color_fondo
                    Proyect.numero_lbl_62.ForeColor = color_texto
                    Proyect.numero_lbl_62.Font = fuente_texto
                Case "63"
                    Proyect.numero_lbl_63.BackColor = color_fondo
                    Proyect.numero_lbl_63.ForeColor = color_texto
                    Proyect.numero_lbl_63.Font = fuente_texto
                Case "64"
                    Proyect.numero_lbl_64.BackColor = color_fondo
                    Proyect.numero_lbl_64.ForeColor = color_texto
                    Proyect.numero_lbl_64.Font = fuente_texto
                Case "65"
                    Proyect.numero_lbl_65.BackColor = color_fondo
                    Proyect.numero_lbl_65.ForeColor = color_texto
                    Proyect.numero_lbl_65.Font = fuente_texto
                Case "66"
                    Proyect.numero_lbl_66.BackColor = color_fondo
                    Proyect.numero_lbl_66.ForeColor = color_texto
                    Proyect.numero_lbl_66.Font = fuente_texto
                Case "67"
                    Proyect.numero_lbl_67.BackColor = color_fondo
                    Proyect.numero_lbl_67.ForeColor = color_texto
                    Proyect.numero_lbl_67.Font = fuente_texto
                Case "68"
                    Proyect.numero_lbl_68.BackColor = color_fondo
                    Proyect.numero_lbl_68.ForeColor = color_texto
                    Proyect.numero_lbl_68.Font = fuente_texto
                Case "69"
                    Proyect.numero_lbl_69.BackColor = color_fondo
                    Proyect.numero_lbl_69.ForeColor = color_texto
                    Proyect.numero_lbl_69.Font = fuente_texto


                Case "70"
                    Proyect.numero_lbl_70.BackColor = color_fondo
                    Proyect.numero_lbl_70.ForeColor = color_texto
                    Proyect.numero_lbl_70.Font = fuente_texto
                Case "71"
                    Proyect.numero_lbl_71.BackColor = color_fondo
                    Proyect.numero_lbl_71.ForeColor = color_texto
                    Proyect.numero_lbl_71.Font = fuente_texto
                Case "72"
                    Proyect.numero_lbl_72.BackColor = color_fondo
                    Proyect.numero_lbl_72.ForeColor = color_texto
                    Proyect.numero_lbl_72.Font = fuente_texto
                Case "73"
                    Proyect.numero_lbl_73.BackColor = color_fondo
                    Proyect.numero_lbl_73.ForeColor = color_texto
                    Proyect.numero_lbl_73.Font = fuente_texto
                Case "74"
                    Proyect.numero_lbl_74.BackColor = color_fondo
                    Proyect.numero_lbl_74.ForeColor = color_texto
                    Proyect.numero_lbl_74.Font = fuente_texto
                Case "75"
                    Proyect.numero_lbl_75.BackColor = color_fondo
                    Proyect.numero_lbl_75.ForeColor = color_texto
                    Proyect.numero_lbl_75.Font = fuente_texto
                Case "76"
                    Proyect.numero_lbl_76.BackColor = color_fondo
                    Proyect.numero_lbl_76.ForeColor = color_texto
                    Proyect.numero_lbl_76.Font = fuente_texto
                Case "77"
                    Proyect.numero_lbl_77.BackColor = color_fondo
                    Proyect.numero_lbl_77.ForeColor = color_texto
                    Proyect.numero_lbl_77.Font = fuente_texto
                Case "78"
                    Proyect.numero_lbl_78.BackColor = color_fondo
                    Proyect.numero_lbl_78.ForeColor = color_texto
                    Proyect.numero_lbl_78.Font = fuente_texto
                Case "79"
                    Proyect.numero_lbl_79.BackColor = color_fondo
                    Proyect.numero_lbl_79.ForeColor = color_texto
                    Proyect.numero_lbl_79.Font = fuente_texto


                Case "80"
                    Proyect.numero_lbl_80.BackColor = color_fondo
                    Proyect.numero_lbl_80.ForeColor = color_texto
                    Proyect.numero_lbl_80.Font = fuente_texto
                Case "81"
                    Proyect.numero_lbl_81.BackColor = color_fondo
                    Proyect.numero_lbl_81.ForeColor = color_texto
                    Proyect.numero_lbl_81.Font = fuente_texto
                Case "82"
                    Proyect.numero_lbl_82.BackColor = color_fondo
                    Proyect.numero_lbl_82.ForeColor = color_texto
                    Proyect.numero_lbl_82.Font = fuente_texto
                Case "83"
                    Proyect.numero_lbl_83.BackColor = color_fondo
                    Proyect.numero_lbl_83.ForeColor = color_texto
                    Proyect.numero_lbl_83.Font = fuente_texto
                Case "84"
                    Proyect.numero_lbl_84.BackColor = color_fondo
                    Proyect.numero_lbl_84.ForeColor = color_texto
                    Proyect.numero_lbl_84.Font = fuente_texto
                Case "85"
                    Proyect.numero_lbl_85.BackColor = color_fondo
                    Proyect.numero_lbl_85.ForeColor = color_texto
                    Proyect.numero_lbl_85.Font = fuente_texto
                Case "86"
                    Proyect.numero_lbl_86.BackColor = color_fondo
                    Proyect.numero_lbl_86.ForeColor = color_texto
                    Proyect.numero_lbl_86.Font = fuente_texto
                Case "87"
                    Proyect.numero_lbl_87.BackColor = color_fondo
                    Proyect.numero_lbl_87.ForeColor = color_texto
                    Proyect.numero_lbl_87.Font = fuente_texto
                Case "88"
                    Proyect.numero_lbl_88.BackColor = color_fondo
                    Proyect.numero_lbl_88.ForeColor = color_texto
                    Proyect.numero_lbl_88.Font = fuente_texto
                Case "89"
                    Proyect.numero_lbl_89.BackColor = color_fondo
                    Proyect.numero_lbl_89.ForeColor = color_texto
                    Proyect.numero_lbl_89.Font = fuente_texto


                Case "90"
                    Proyect.numero_lbl_90.BackColor = color_fondo
                    Proyect.numero_lbl_90.ForeColor = color_texto
                    Proyect.numero_lbl_90.Font = fuente_texto
            End Select
#End Region

        ElseIf color_igual = 1 Then
            'Detiene y deshabilita el timer "Contador", encargado de mostrar el número elegido por 10 segundos
            Proyect.Contador.Stop()
            Proyect.Contador.Enabled = False

            'Detiene y deshabilita el timer "Cronómetro", encargado de contar el tiempo restante para mostrar el número elegido
            Main.Cronometro.Stop()
            Main.Cronometro.Enabled = False

            'Habilita y comienza el timer "Contra_contador", encargado de mostrar "00" en lugar del número elegido
            Proyect.Contra_contador.Enabled = True
            Proyect.Contra_contador.Start() 
        End If

        'Agrega el 0 antes del número de ser necesario, caso contrario lo muestra directamente
        If almacen <= 9 Then
            Proyect.numero_lbl_grande.Text = "0" + almacen
        Else
            Proyect.numero_lbl_grande.Text = almacen
        End If
    End Sub

    Public Shared Sub yaelegido(ByRef color_igual As Byte, ByVal almacen As String, ByVal color_fondo As Color)
        'Se almacenan los colores de fondo y texto, así como la fuente, de los números al inicio del form
        Dim color_fondo_org As Color
        Dim color_texto_org As Color
        Dim fuente_texto_org As Font

        'Colores de fondo, texto y fuente al inicio del form
        color_fondo_org = My.Settings.color_fondo_numeros_org
        color_texto_org = My.Settings.color_texto_numeros_org
        fuente_texto_org = My.Settings.fuente_texto_numeros_org

        'Se revisan todos los números, comprobando si el seleccionado ya se cambió el fondo o no
        'En caso de que se haya hecho, se restaura al original y se cambia la variable
        '"color_original" por 1.
#Region "Color"
        Select Case almacen
            Case "1"
                If Proyect.numero_lbl_1.BackColor = color_fondo Then
                    Proyect.numero_lbl_1.BackColor = color_fondo_org
                    Proyect.numero_lbl_1.ForeColor = color_texto_org
                    Proyect.numero_lbl_1.Font = fuente_texto_org
                    color_igual = 1
                End If
            Case "2"
                If Proyect.numero_lbl_2.BackColor = color_fondo Then
                    Proyect.numero_lbl_2.BackColor = color_fondo_org
                    Proyect.numero_lbl_2.ForeColor = color_texto_org
                    Proyect.numero_lbl_2.Font = fuente_texto_org
                    color_igual = 1
                End If
            Case "3"
                If Proyect.numero_lbl_3.BackColor = color_fondo Then
                    Proyect.numero_lbl_3.BackColor = color_fondo_org
                    Proyect.numero_lbl_3.ForeColor = color_texto_org
                    Proyect.numero_lbl_3.Font = fuente_texto_org
                    color_igual = 1
                End If
            Case "4"
                If Proyect.numero_lbl_4.BackColor = color_fondo Then
                    Proyect.numero_lbl_4.BackColor = color_fondo_org
                    Proyect.numero_lbl_4.ForeColor = color_texto_org
                    Proyect.numero_lbl_4.Font = fuente_texto_org
                    color_igual = 1
                End If
            Case "5"
                If Proyect.numero_lbl_5.BackColor = color_fondo Then
                    Proyect.numero_lbl_5.BackColor = color_fondo_org
                    Proyect.numero_lbl_5.ForeColor = color_texto_org
                    Proyect.numero_lbl_5.Font = fuente_texto_org
                    color_igual = 1
                End If
            Case "6"
                If Proyect.numero_lbl_6.BackColor = color_fondo Then
                    Proyect.numero_lbl_6.BackColor = color_fondo_org
                    Proyect.numero_lbl_6.ForeColor = color_texto_org
                    Proyect.numero_lbl_6.Font = fuente_texto_org
                    color_igual = 1
                End If
            Case "7"
                If Proyect.numero_lbl_7.BackColor = color_fondo Then
                    Proyect.numero_lbl_7.BackColor = color_fondo_org
                    Proyect.numero_lbl_7.ForeColor = color_texto_org
                    Proyect.numero_lbl_7.Font = fuente_texto_org
                    color_igual = 1
                End If
            Case "8"
                If Proyect.numero_lbl_8.BackColor = color_fondo Then
                    Proyect.numero_lbl_8.BackColor = color_fondo_org
                    Proyect.numero_lbl_8.ForeColor = color_texto_org
                    Proyect.numero_lbl_8.Font = fuente_texto_org
                    color_igual = 1
                End If
            Case "9"
                If Proyect.numero_lbl_9.BackColor = color_fondo Then
                    Proyect.numero_lbl_9.BackColor = color_fondo_org
                    Proyect.numero_lbl_9.ForeColor = color_texto_org
                    Proyect.numero_lbl_9.Font = fuente_texto_org
                    color_igual = 1
                End If

            Case "10"
                If Proyect.numero_lbl_10.BackColor = color_fondo Then
                    Proyect.numero_lbl_10.BackColor = color_fondo_org
                    Proyect.numero_lbl_10.ForeColor = color_texto_org
                    Proyect.numero_lbl_10.Font = fuente_texto_org
                    color_igual = 1
                End If
            Case "11"
                If Proyect.numero_lbl_11.BackColor = color_fondo Then
                    Proyect.numero_lbl_11.BackColor = color_fondo_org
                    Proyect.numero_lbl_11.ForeColor = color_texto_org
                    Proyect.numero_lbl_11.Font = fuente_texto_org
                    color_igual = 1
                End If
            Case "12"
                If Proyect.numero_lbl_12.BackColor = color_fondo Then
                    Proyect.numero_lbl_12.BackColor = color_fondo_org
                    Proyect.numero_lbl_12.ForeColor = color_texto_org
                    Proyect.numero_lbl_12.Font = fuente_texto_org
                    color_igual = 1
                End If
            Case "13"
                If Proyect.numero_lbl_13.BackColor = color_fondo Then
                    Proyect.numero_lbl_13.BackColor = color_fondo_org
                    Proyect.numero_lbl_13.ForeColor = color_texto_org
                    Proyect.numero_lbl_13.Font = fuente_texto_org
                    color_igual = 1
                End If
            Case "14"
                If Proyect.numero_lbl_14.BackColor = color_fondo Then
                    Proyect.numero_lbl_14.BackColor = color_fondo_org
                    Proyect.numero_lbl_14.ForeColor = color_texto_org
                    Proyect.numero_lbl_14.Font = fuente_texto_org
                    color_igual = 1
                End If
            Case "15"
                If Proyect.numero_lbl_15.BackColor = color_fondo Then
                    Proyect.numero_lbl_15.BackColor = color_fondo_org
                    Proyect.numero_lbl_15.ForeColor = color_texto_org
                    Proyect.numero_lbl_15.Font = fuente_texto_org
                    color_igual = 1
                End If
            Case "16"
                If Proyect.numero_lbl_16.BackColor = color_fondo Then
                    Proyect.numero_lbl_16.BackColor = color_fondo_org
                    Proyect.numero_lbl_16.ForeColor = color_texto_org
                    Proyect.numero_lbl_16.Font = fuente_texto_org
                    color_igual = 1
                End If
            Case "17"
                If Proyect.numero_lbl_17.BackColor = color_fondo Then
                    Proyect.numero_lbl_17.BackColor = color_fondo_org
                    Proyect.numero_lbl_17.ForeColor = color_texto_org
                    Proyect.numero_lbl_17.Font = fuente_texto_org
                    color_igual = 1
                End If
            Case "18"
                If Proyect.numero_lbl_18.BackColor = color_fondo Then
                    Proyect.numero_lbl_18.BackColor = color_fondo_org
                    Proyect.numero_lbl_18.ForeColor = color_texto_org
                    Proyect.numero_lbl_18.Font = fuente_texto_org
                    color_igual = 1
                End If
            Case "19"
                If Proyect.numero_lbl_19.BackColor = color_fondo Then
                    Proyect.numero_lbl_19.BackColor = color_fondo_org
                    Proyect.numero_lbl_19.ForeColor = color_texto_org
                    Proyect.numero_lbl_19.Font = fuente_texto_org
                    color_igual = 1
                End If


            Case "20"
                If Proyect.numero_lbl_20.BackColor = color_fondo Then
                    Proyect.numero_lbl_20.BackColor = color_fondo_org
                    Proyect.numero_lbl_20.ForeColor = color_texto_org
                    Proyect.numero_lbl_20.Font = fuente_texto_org
                    color_igual = 1
                End If
            Case "21"
                If Proyect.numero_lbl_21.BackColor = color_fondo Then
                    Proyect.numero_lbl_21.BackColor = color_fondo_org
                    Proyect.numero_lbl_21.ForeColor = color_texto_org
                    Proyect.numero_lbl_21.Font = fuente_texto_org
                    color_igual = 1
                End If
            Case "22"
                If Proyect.numero_lbl_22.BackColor = color_fondo Then
                    Proyect.numero_lbl_22.BackColor = color_fondo_org
                    Proyect.numero_lbl_22.ForeColor = color_texto_org
                    Proyect.numero_lbl_22.Font = fuente_texto_org
                    color_igual = 1
                End If
            Case "23"
                If Proyect.numero_lbl_23.BackColor = color_fondo Then
                    Proyect.numero_lbl_23.BackColor = color_fondo_org
                    Proyect.numero_lbl_23.ForeColor = color_texto_org
                    Proyect.numero_lbl_23.Font = fuente_texto_org
                    color_igual = 1
                End If
            Case "24"
                If Proyect.numero_lbl_24.BackColor = color_fondo Then
                    Proyect.numero_lbl_24.BackColor = color_fondo_org
                    Proyect.numero_lbl_24.ForeColor = color_texto_org
                    Proyect.numero_lbl_24.Font = fuente_texto_org
                    color_igual = 1
                End If
            Case "25"
                If Proyect.numero_lbl_25.BackColor = color_fondo Then
                    Proyect.numero_lbl_25.BackColor = color_fondo_org
                    Proyect.numero_lbl_25.ForeColor = color_texto_org
                    Proyect.numero_lbl_25.Font = fuente_texto_org
                    color_igual = 1
                End If
            Case "26"
                If Proyect.numero_lbl_26.BackColor = color_fondo Then
                    Proyect.numero_lbl_26.BackColor = color_fondo_org
                    Proyect.numero_lbl_26.ForeColor = color_texto_org
                    Proyect.numero_lbl_26.Font = fuente_texto_org
                    color_igual = 1
                End If
            Case "27"
                If Proyect.numero_lbl_27.BackColor = color_fondo Then
                    Proyect.numero_lbl_27.BackColor = color_fondo_org
                    Proyect.numero_lbl_27.ForeColor = color_texto_org
                    Proyect.numero_lbl_27.Font = fuente_texto_org
                    color_igual = 1
                End If
            Case "28"
                If Proyect.numero_lbl_28.BackColor = color_fondo Then
                    Proyect.numero_lbl_28.BackColor = color_fondo_org
                    Proyect.numero_lbl_28.ForeColor = color_texto_org
                    Proyect.numero_lbl_28.Font = fuente_texto_org
                    color_igual = 1
                End If
            Case "29"
                If Proyect.numero_lbl_29.BackColor = color_fondo Then
                    Proyect.numero_lbl_29.BackColor = color_fondo_org
                    Proyect.numero_lbl_29.ForeColor = color_texto_org
                    Proyect.numero_lbl_29.Font = fuente_texto_org
                    color_igual = 1
                End If

            Case "30"
                If Proyect.numero_lbl_30.BackColor = color_fondo Then
                    Proyect.numero_lbl_30.BackColor = color_fondo_org
                    Proyect.numero_lbl_30.ForeColor = color_texto_org
                    Proyect.numero_lbl_30.Font = fuente_texto_org
                    color_igual = 1
                End If
            Case "31"
                If Proyect.numero_lbl_31.BackColor = color_fondo Then
                    Proyect.numero_lbl_31.BackColor = color_fondo_org
                    Proyect.numero_lbl_31.ForeColor = color_texto_org
                    Proyect.numero_lbl_31.Font = fuente_texto_org
                    color_igual = 1
                End If
            Case "32"
                If Proyect.numero_lbl_32.BackColor = color_fondo Then
                    Proyect.numero_lbl_32.BackColor = color_fondo_org
                    Proyect.numero_lbl_32.ForeColor = color_texto_org
                    Proyect.numero_lbl_32.Font = fuente_texto_org
                    color_igual = 1
                End If
            Case "33"
                If Proyect.numero_lbl_33.BackColor = color_fondo Then
                    Proyect.numero_lbl_33.BackColor = color_fondo_org
                    Proyect.numero_lbl_33.ForeColor = color_texto_org
                    Proyect.numero_lbl_33.Font = fuente_texto_org
                    color_igual = 1
                End If
            Case "34"
                If Proyect.numero_lbl_34.BackColor = color_fondo Then
                    Proyect.numero_lbl_34.BackColor = color_fondo_org
                    Proyect.numero_lbl_34.ForeColor = color_texto_org
                    Proyect.numero_lbl_34.Font = fuente_texto_org
                    color_igual = 1
                End If
            Case "35"
                If Proyect.numero_lbl_35.BackColor = color_fondo Then
                    Proyect.numero_lbl_35.BackColor = color_fondo_org
                    Proyect.numero_lbl_35.ForeColor = color_texto_org
                    Proyect.numero_lbl_35.Font = fuente_texto_org
                    color_igual = 1
                End If
            Case "36"
                If Proyect.numero_lbl_36.BackColor = color_fondo Then
                    Proyect.numero_lbl_36.BackColor = color_fondo_org
                    Proyect.numero_lbl_36.ForeColor = color_texto_org
                    Proyect.numero_lbl_36.Font = fuente_texto_org
                    color_igual = 1
                End If
            Case "37"
                If Proyect.numero_lbl_37.BackColor = color_fondo Then
                    Proyect.numero_lbl_37.BackColor = color_fondo_org
                    Proyect.numero_lbl_37.ForeColor = color_texto_org
                    Proyect.numero_lbl_37.Font = fuente_texto_org
                    color_igual = 1
                End If
            Case "38"
                If Proyect.numero_lbl_38.BackColor = color_fondo Then
                    Proyect.numero_lbl_38.BackColor = color_fondo_org
                    Proyect.numero_lbl_38.ForeColor = color_texto_org
                    Proyect.numero_lbl_38.Font = fuente_texto_org
                    color_igual = 1
                End If
            Case "39"
                If Proyect.numero_lbl_39.BackColor = color_fondo Then
                    Proyect.numero_lbl_39.BackColor = color_fondo_org
                    Proyect.numero_lbl_39.ForeColor = color_texto_org
                    Proyect.numero_lbl_39.Font = fuente_texto_org
                    color_igual = 1
                End If

            Case "40"
                If Proyect.numero_lbl_40.BackColor = color_fondo Then
                    Proyect.numero_lbl_40.BackColor = color_fondo_org
                    Proyect.numero_lbl_40.ForeColor = color_texto_org
                    Proyect.numero_lbl_40.Font = fuente_texto_org
                    color_igual = 1
                End If
            Case "41"
                If Proyect.numero_lbl_41.BackColor = color_fondo Then
                    Proyect.numero_lbl_41.BackColor = color_fondo_org
                    Proyect.numero_lbl_41.ForeColor = color_texto_org
                    Proyect.numero_lbl_41.Font = fuente_texto_org
                    color_igual = 1
                End If
            Case "42"
                If Proyect.numero_lbl_42.BackColor = color_fondo Then
                    Proyect.numero_lbl_42.BackColor = color_fondo_org
                    Proyect.numero_lbl_42.ForeColor = color_texto_org
                    Proyect.numero_lbl_42.Font = fuente_texto_org
                    color_igual = 1
                End If
            Case "43"
                If Proyect.numero_lbl_43.BackColor = color_fondo Then
                    Proyect.numero_lbl_43.BackColor = color_fondo_org
                    Proyect.numero_lbl_43.ForeColor = color_texto_org
                    Proyect.numero_lbl_43.Font = fuente_texto_org
                    color_igual = 1
                End If
            Case "44"
                If Proyect.numero_lbl_44.BackColor = color_fondo Then
                    Proyect.numero_lbl_44.BackColor = color_fondo_org
                    Proyect.numero_lbl_44.ForeColor = color_texto_org
                    Proyect.numero_lbl_44.Font = fuente_texto_org
                    color_igual = 1
                End If
            Case "45"
                If Proyect.numero_lbl_45.BackColor = color_fondo Then
                    Proyect.numero_lbl_45.BackColor = color_fondo_org
                    Proyect.numero_lbl_45.ForeColor = color_texto_org
                    Proyect.numero_lbl_45.Font = fuente_texto_org
                    color_igual = 1
                End If
            Case "46"
                If Proyect.numero_lbl_46.BackColor = color_fondo Then
                    Proyect.numero_lbl_46.BackColor = color_fondo_org
                    Proyect.numero_lbl_46.ForeColor = color_texto_org
                    Proyect.numero_lbl_46.Font = fuente_texto_org
                    color_igual = 1
                End If
            Case "47"
                If Proyect.numero_lbl_47.BackColor = color_fondo Then
                    Proyect.numero_lbl_47.BackColor = color_fondo_org
                    Proyect.numero_lbl_47.ForeColor = color_texto_org
                    Proyect.numero_lbl_47.Font = fuente_texto_org
                    color_igual = 1
                End If
            Case "48"
                If Proyect.numero_lbl_48.BackColor = color_fondo Then
                    Proyect.numero_lbl_48.BackColor = color_fondo_org
                    Proyect.numero_lbl_48.ForeColor = color_texto_org
                    Proyect.numero_lbl_48.Font = fuente_texto_org
                    color_igual = 1
                End If
            Case "49"
                If Proyect.numero_lbl_49.BackColor = color_fondo Then
                    Proyect.numero_lbl_49.BackColor = color_fondo_org
                    Proyect.numero_lbl_49.ForeColor = color_texto_org
                    Proyect.numero_lbl_49.Font = fuente_texto_org
                    color_igual = 1
                End If

            Case "50"
                If Proyect.numero_lbl_50.BackColor = color_fondo Then
                    Proyect.numero_lbl_50.BackColor = color_fondo_org
                    Proyect.numero_lbl_50.ForeColor = color_texto_org
                    Proyect.numero_lbl_50.Font = fuente_texto_org
                    color_igual = 1
                End If
            Case "51"
                If Proyect.numero_lbl_51.BackColor = color_fondo Then
                    Proyect.numero_lbl_51.BackColor = color_fondo_org
                    Proyect.numero_lbl_51.ForeColor = color_texto_org
                    Proyect.numero_lbl_51.Font = fuente_texto_org
                    color_igual = 1
                End If
            Case "52"
                If Proyect.numero_lbl_52.BackColor = color_fondo Then
                    Proyect.numero_lbl_52.BackColor = color_fondo_org
                    Proyect.numero_lbl_52.ForeColor = color_texto_org
                    Proyect.numero_lbl_52.Font = fuente_texto_org
                    color_igual = 1
                End If
            Case "53"
                If Proyect.numero_lbl_53.BackColor = color_fondo Then
                    Proyect.numero_lbl_53.BackColor = color_fondo_org
                    Proyect.numero_lbl_53.ForeColor = color_texto_org
                    Proyect.numero_lbl_53.Font = fuente_texto_org
                    color_igual = 1
                End If
            Case "54"
                If Proyect.numero_lbl_54.BackColor = color_fondo Then
                    Proyect.numero_lbl_54.BackColor = color_fondo_org
                    Proyect.numero_lbl_54.ForeColor = color_texto_org
                    Proyect.numero_lbl_54.Font = fuente_texto_org
                    color_igual = 1
                End If
            Case "55"
                If Proyect.numero_lbl_55.BackColor = color_fondo Then
                    Proyect.numero_lbl_55.BackColor = color_fondo_org
                    Proyect.numero_lbl_55.ForeColor = color_texto_org
                    Proyect.numero_lbl_55.Font = fuente_texto_org
                    color_igual = 1
                End If
            Case "56"
                If Proyect.numero_lbl_56.BackColor = color_fondo Then
                    Proyect.numero_lbl_56.BackColor = color_fondo_org
                    Proyect.numero_lbl_56.ForeColor = color_texto_org
                    Proyect.numero_lbl_56.Font = fuente_texto_org
                    color_igual = 1
                End If
            Case "57"
                If Proyect.numero_lbl_57.BackColor = color_fondo Then
                    Proyect.numero_lbl_57.BackColor = color_fondo_org
                    Proyect.numero_lbl_57.ForeColor = color_texto_org
                    Proyect.numero_lbl_57.Font = fuente_texto_org
                    color_igual = 1
                End If
            Case "58"
                If Proyect.numero_lbl_58.BackColor = color_fondo Then
                    Proyect.numero_lbl_58.BackColor = color_fondo_org
                    Proyect.numero_lbl_58.ForeColor = color_texto_org
                    Proyect.numero_lbl_58.Font = fuente_texto_org
                    color_igual = 1
                End If
            Case "59"
                If Proyect.numero_lbl_59.BackColor = color_fondo Then
                    Proyect.numero_lbl_59.BackColor = color_fondo_org
                    Proyect.numero_lbl_59.ForeColor = color_texto_org
                    Proyect.numero_lbl_59.Font = fuente_texto_org
                    color_igual = 1
                End If

            Case "60"
                If Proyect.numero_lbl_60.BackColor = color_fondo Then
                    Proyect.numero_lbl_60.BackColor = color_fondo_org
                    Proyect.numero_lbl_60.ForeColor = color_texto_org
                    Proyect.numero_lbl_60.Font = fuente_texto_org
                    color_igual = 1
                End If
            Case "61"
                If Proyect.numero_lbl_61.BackColor = color_fondo Then
                    Proyect.numero_lbl_61.BackColor = color_fondo_org
                    Proyect.numero_lbl_61.ForeColor = color_texto_org
                    Proyect.numero_lbl_61.Font = fuente_texto_org
                    color_igual = 1
                End If
            Case "62"
                If Proyect.numero_lbl_62.BackColor = color_fondo Then
                    Proyect.numero_lbl_62.BackColor = color_fondo_org
                    Proyect.numero_lbl_62.ForeColor = color_texto_org
                    Proyect.numero_lbl_62.Font = fuente_texto_org
                    color_igual = 1
                End If
            Case "63"
                If Proyect.numero_lbl_63.BackColor = color_fondo Then
                    Proyect.numero_lbl_63.BackColor = color_fondo_org
                    Proyect.numero_lbl_63.ForeColor = color_texto_org
                    Proyect.numero_lbl_63.Font = fuente_texto_org
                    color_igual = 1
                End If
            Case "64"
                If Proyect.numero_lbl_64.BackColor = color_fondo Then
                    Proyect.numero_lbl_64.BackColor = color_fondo_org
                    Proyect.numero_lbl_64.ForeColor = color_texto_org
                    Proyect.numero_lbl_64.Font = fuente_texto_org
                    color_igual = 1
                End If
            Case "65"
                If Proyect.numero_lbl_65.BackColor = color_fondo Then
                    Proyect.numero_lbl_65.BackColor = color_fondo_org
                    Proyect.numero_lbl_65.ForeColor = color_texto_org
                    Proyect.numero_lbl_65.Font = fuente_texto_org
                    color_igual = 1
                End If
            Case "66"
                If Proyect.numero_lbl_66.BackColor = color_fondo Then
                    Proyect.numero_lbl_66.BackColor = color_fondo_org
                    Proyect.numero_lbl_66.ForeColor = color_texto_org
                    Proyect.numero_lbl_66.Font = fuente_texto_org
                    color_igual = 1
                End If
            Case "67"
                If Proyect.numero_lbl_67.BackColor = color_fondo Then
                    Proyect.numero_lbl_67.BackColor = color_fondo_org
                    Proyect.numero_lbl_67.ForeColor = color_texto_org
                    Proyect.numero_lbl_67.Font = fuente_texto_org
                    color_igual = 1
                End If
            Case "68"
                If Proyect.numero_lbl_68.BackColor = color_fondo Then
                    Proyect.numero_lbl_68.BackColor = color_fondo_org
                    Proyect.numero_lbl_68.ForeColor = color_texto_org
                    Proyect.numero_lbl_68.Font = fuente_texto_org
                    color_igual = 1
                End If
            Case "69"
                If Proyect.numero_lbl_69.BackColor = color_fondo Then
                    Proyect.numero_lbl_69.BackColor = color_fondo_org
                    Proyect.numero_lbl_69.ForeColor = color_texto_org
                    Proyect.numero_lbl_69.Font = fuente_texto_org
                    color_igual = 1
                End If

            Case "70"
                If Proyect.numero_lbl_70.BackColor = color_fondo Then
                    Proyect.numero_lbl_70.BackColor = color_fondo_org
                    Proyect.numero_lbl_70.ForeColor = color_texto_org
                    Proyect.numero_lbl_70.Font = fuente_texto_org
                    color_igual = 1
                End If
            Case "71"
                If Proyect.numero_lbl_71.BackColor = color_fondo Then
                    Proyect.numero_lbl_71.BackColor = color_fondo_org
                    Proyect.numero_lbl_71.ForeColor = color_texto_org
                    Proyect.numero_lbl_71.Font = fuente_texto_org
                    color_igual = 1
                End If
            Case "72"
                If Proyect.numero_lbl_72.BackColor = color_fondo Then
                    Proyect.numero_lbl_72.BackColor = color_fondo_org
                    Proyect.numero_lbl_72.ForeColor = color_texto_org
                    Proyect.numero_lbl_72.Font = fuente_texto_org
                    color_igual = 1
                End If
            Case "73"
                If Proyect.numero_lbl_73.BackColor = color_fondo Then
                    Proyect.numero_lbl_73.BackColor = color_fondo_org
                    Proyect.numero_lbl_73.ForeColor = color_texto_org
                    Proyect.numero_lbl_73.Font = fuente_texto_org
                    color_igual = 1
                End If
            Case "74"
                If Proyect.numero_lbl_74.BackColor = color_fondo Then
                    Proyect.numero_lbl_74.BackColor = color_fondo_org
                    Proyect.numero_lbl_74.ForeColor = color_texto_org
                    Proyect.numero_lbl_74.Font = fuente_texto_org
                    color_igual = 1
                End If
            Case "75"
                If Proyect.numero_lbl_75.BackColor = color_fondo Then
                    Proyect.numero_lbl_75.BackColor = color_fondo_org
                    Proyect.numero_lbl_75.ForeColor = color_texto_org
                    Proyect.numero_lbl_75.Font = fuente_texto_org
                    color_igual = 1
                End If
            Case "76"
                If Proyect.numero_lbl_76.BackColor = color_fondo Then
                    Proyect.numero_lbl_76.BackColor = color_fondo_org
                    Proyect.numero_lbl_76.ForeColor = color_texto_org
                    Proyect.numero_lbl_76.Font = fuente_texto_org
                    color_igual = 1
                End If
            Case "77"
                If Proyect.numero_lbl_77.BackColor = color_fondo Then
                    Proyect.numero_lbl_77.BackColor = color_fondo_org
                    Proyect.numero_lbl_77.ForeColor = color_texto_org
                    Proyect.numero_lbl_77.Font = fuente_texto_org
                    color_igual = 1
                End If
            Case "78"
                If Proyect.numero_lbl_78.BackColor = color_fondo Then
                    Proyect.numero_lbl_78.BackColor = color_fondo_org
                    Proyect.numero_lbl_78.ForeColor = color_texto_org
                    Proyect.numero_lbl_78.Font = fuente_texto_org
                    color_igual = 1
                End If
            Case "79"
                If Proyect.numero_lbl_79.BackColor = color_fondo Then
                    Proyect.numero_lbl_79.BackColor = color_fondo_org
                    Proyect.numero_lbl_79.ForeColor = color_texto_org
                    Proyect.numero_lbl_79.Font = fuente_texto_org
                    color_igual = 1
                End If

            Case "80"
                If Proyect.numero_lbl_80.BackColor = color_fondo Then
                    Proyect.numero_lbl_80.BackColor = color_fondo_org
                    Proyect.numero_lbl_80.ForeColor = color_texto_org
                    Proyect.numero_lbl_80.Font = fuente_texto_org
                    color_igual = 1
                End If
            Case "81"
                If Proyect.numero_lbl_81.BackColor = color_fondo Then
                    Proyect.numero_lbl_81.BackColor = color_fondo_org
                    Proyect.numero_lbl_81.ForeColor = color_texto_org
                    Proyect.numero_lbl_81.Font = fuente_texto_org
                    color_igual = 1
                End If
            Case "82"
                If Proyect.numero_lbl_82.BackColor = color_fondo Then
                    Proyect.numero_lbl_82.BackColor = color_fondo_org
                    Proyect.numero_lbl_82.ForeColor = color_texto_org
                    Proyect.numero_lbl_82.Font = fuente_texto_org
                    color_igual = 1
                End If
            Case "83"
                If Proyect.numero_lbl_83.BackColor = color_fondo Then
                    Proyect.numero_lbl_83.BackColor = color_fondo_org
                    Proyect.numero_lbl_83.ForeColor = color_texto_org
                    Proyect.numero_lbl_83.Font = fuente_texto_org
                    color_igual = 1
                End If
            Case "84"
                If Proyect.numero_lbl_84.BackColor = color_fondo Then
                    Proyect.numero_lbl_84.BackColor = color_fondo_org
                    Proyect.numero_lbl_84.ForeColor = color_texto_org
                    Proyect.numero_lbl_84.Font = fuente_texto_org
                    color_igual = 1
                End If
            Case "85"
                If Proyect.numero_lbl_85.BackColor = color_fondo Then
                    Proyect.numero_lbl_85.BackColor = color_fondo_org
                    Proyect.numero_lbl_85.ForeColor = color_texto_org
                    Proyect.numero_lbl_85.Font = fuente_texto_org
                    color_igual = 1
                End If
            Case "86"
                If Proyect.numero_lbl_86.BackColor = color_fondo Then
                    Proyect.numero_lbl_86.BackColor = color_fondo_org
                    Proyect.numero_lbl_86.ForeColor = color_texto_org
                    Proyect.numero_lbl_86.Font = fuente_texto_org
                    color_igual = 1
                End If
            Case "87"
                If Proyect.numero_lbl_87.BackColor = color_fondo Then
                    Proyect.numero_lbl_87.BackColor = color_fondo_org
                    Proyect.numero_lbl_87.ForeColor = color_texto_org
                    Proyect.numero_lbl_87.Font = fuente_texto_org
                    color_igual = 1
                End If
            Case "88"
                If Proyect.numero_lbl_88.BackColor = color_fondo Then
                    Proyect.numero_lbl_88.BackColor = color_fondo_org
                    Proyect.numero_lbl_88.ForeColor = color_texto_org
                    Proyect.numero_lbl_88.Font = fuente_texto_org
                    color_igual = 1
                End If
            Case "89"
                If Proyect.numero_lbl_89.BackColor = color_fondo Then
                    Proyect.numero_lbl_89.BackColor = color_fondo_org
                    Proyect.numero_lbl_89.ForeColor = color_texto_org
                    Proyect.numero_lbl_89.Font = fuente_texto_org
                    color_igual = 1
                End If

            Case "90"
                If Proyect.numero_lbl_90.BackColor = color_fondo Then
                    Proyect.numero_lbl_90.BackColor = color_fondo_org
                    Proyect.numero_lbl_90.ForeColor = color_texto_org
                    Proyect.numero_lbl_90.Font = fuente_texto_org
                    color_igual = 1
                End If
        End Select
#End Region
    End Sub
End Class