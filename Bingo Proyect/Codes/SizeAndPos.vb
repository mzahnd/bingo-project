Public Class Proyect_size
    Public Shared Sub size_numeros()
        'Variables
        'Tamaño del panel
        Dim x_size As New Double
        Dim y_size As New Double
        'Posicion de los labels
        Dim x_pos As New Double
        Dim y_pos As New Double
        'Tamaño del espacio entre ellos
        Dim spc_pos_x As New Double
        Dim spc_pos_y As New Double

        'Calcula el porcentaje que ocupa de ancho y alto cada label
        'Tamaño panel: 485; 319
        x_size = Proyect.panel_numeros.Width * (44 * 100 / 485) / 100
        y_size = Proyect.panel_numeros.Height * (31 * 100 / 319) / 100
        'Calcula el porcentaje que ocupa de el espacio entre cada label
        spc_pos_x = Proyect.panel_numeros.Width * (5 * 100 / 485) / 100
        spc_pos_y = Proyect.panel_numeros.Height * (5 * 100 / 319) / 100

#Region "Labels' Size"
        'Tamaño de los labels manteniendo el porcentaje
        'Números 1 al 9
        Proyect.numero_lbl_1.Size = New Size(x_size, y_size)
        Proyect.numero_lbl_2.Size = New Size(x_size, y_size)
        Proyect.numero_lbl_3.Size = New Size(x_size, y_size)
        Proyect.numero_lbl_4.Size = New Size(x_size, y_size)
        Proyect.numero_lbl_5.Size = New Size(x_size, y_size)
        Proyect.numero_lbl_6.Size = New Size(x_size, y_size)
        Proyect.numero_lbl_7.Size = New Size(x_size, y_size)
        Proyect.numero_lbl_8.Size = New Size(x_size, y_size)
        Proyect.numero_lbl_9.Size = New Size(x_size, y_size)

        'Números 10 al 19
        Proyect.numero_lbl_10.Size = New Size(x_size, y_size)
        Proyect.numero_lbl_11.Size = New Size(x_size, y_size)
        Proyect.numero_lbl_12.Size = New Size(x_size, y_size)
        Proyect.numero_lbl_13.Size = New Size(x_size, y_size)
        Proyect.numero_lbl_14.Size = New Size(x_size, y_size)
        Proyect.numero_lbl_15.Size = New Size(x_size, y_size)
        Proyect.numero_lbl_16.Size = New Size(x_size, y_size)
        Proyect.numero_lbl_17.Size = New Size(x_size, y_size)
        Proyect.numero_lbl_18.Size = New Size(x_size, y_size)
        Proyect.numero_lbl_19.Size = New Size(x_size, y_size)

        'Números 20 al 29
        Proyect.numero_lbl_20.Size = New Size(x_size, y_size)
        Proyect.numero_lbl_21.Size = New Size(x_size, y_size)
        Proyect.numero_lbl_22.Size = New Size(x_size, y_size)
        Proyect.numero_lbl_23.Size = New Size(x_size, y_size)
        Proyect.numero_lbl_24.Size = New Size(x_size, y_size)
        Proyect.numero_lbl_25.Size = New Size(x_size, y_size)
        Proyect.numero_lbl_26.Size = New Size(x_size, y_size)
        Proyect.numero_lbl_27.Size = New Size(x_size, y_size)
        Proyect.numero_lbl_28.Size = New Size(x_size, y_size)
        Proyect.numero_lbl_29.Size = New Size(x_size, y_size)

        'Números 30 al 39
        Proyect.numero_lbl_30.Size = New Size(x_size, y_size)
        Proyect.numero_lbl_31.Size = New Size(x_size, y_size)
        Proyect.numero_lbl_32.Size = New Size(x_size, y_size)
        Proyect.numero_lbl_33.Size = New Size(x_size, y_size)
        Proyect.numero_lbl_34.Size = New Size(x_size, y_size)
        Proyect.numero_lbl_35.Size = New Size(x_size, y_size)
        Proyect.numero_lbl_36.Size = New Size(x_size, y_size)
        Proyect.numero_lbl_37.Size = New Size(x_size, y_size)
        Proyect.numero_lbl_38.Size = New Size(x_size, y_size)
        Proyect.numero_lbl_39.Size = New Size(x_size, y_size)

        'Números 40 al 49
        Proyect.numero_lbl_40.Size = New Size(x_size, y_size)
        Proyect.numero_lbl_41.Size = New Size(x_size, y_size)
        Proyect.numero_lbl_42.Size = New Size(x_size, y_size)
        Proyect.numero_lbl_43.Size = New Size(x_size, y_size)
        Proyect.numero_lbl_44.Size = New Size(x_size, y_size)
        Proyect.numero_lbl_45.Size = New Size(x_size, y_size)
        Proyect.numero_lbl_46.Size = New Size(x_size, y_size)
        Proyect.numero_lbl_47.Size = New Size(x_size, y_size)
        Proyect.numero_lbl_48.Size = New Size(x_size, y_size)
        Proyect.numero_lbl_49.Size = New Size(x_size, y_size)

        'Números 50 al 59
        Proyect.numero_lbl_50.Size = New Size(x_size, y_size)
        Proyect.numero_lbl_51.Size = New Size(x_size, y_size)
        Proyect.numero_lbl_52.Size = New Size(x_size, y_size)
        Proyect.numero_lbl_53.Size = New Size(x_size, y_size)
        Proyect.numero_lbl_54.Size = New Size(x_size, y_size)
        Proyect.numero_lbl_55.Size = New Size(x_size, y_size)
        Proyect.numero_lbl_56.Size = New Size(x_size, y_size)
        Proyect.numero_lbl_57.Size = New Size(x_size, y_size)
        Proyect.numero_lbl_58.Size = New Size(x_size, y_size)
        Proyect.numero_lbl_59.Size = New Size(x_size, y_size)

        'Números 60 al 69
        Proyect.numero_lbl_60.Size = New Size(x_size, y_size)
        Proyect.numero_lbl_61.Size = New Size(x_size, y_size)
        Proyect.numero_lbl_62.Size = New Size(x_size, y_size)
        Proyect.numero_lbl_63.Size = New Size(x_size, y_size)
        Proyect.numero_lbl_64.Size = New Size(x_size, y_size)
        Proyect.numero_lbl_65.Size = New Size(x_size, y_size)
        Proyect.numero_lbl_66.Size = New Size(x_size, y_size)
        Proyect.numero_lbl_67.Size = New Size(x_size, y_size)
        Proyect.numero_lbl_68.Size = New Size(x_size, y_size)
        Proyect.numero_lbl_69.Size = New Size(x_size, y_size)

        'Números 70 al 79
        Proyect.numero_lbl_70.Size = New Size(x_size, y_size)
        Proyect.numero_lbl_71.Size = New Size(x_size, y_size)
        Proyect.numero_lbl_72.Size = New Size(x_size, y_size)
        Proyect.numero_lbl_73.Size = New Size(x_size, y_size)
        Proyect.numero_lbl_74.Size = New Size(x_size, y_size)
        Proyect.numero_lbl_75.Size = New Size(x_size, y_size)
        Proyect.numero_lbl_76.Size = New Size(x_size, y_size)
        Proyect.numero_lbl_77.Size = New Size(x_size, y_size)
        Proyect.numero_lbl_78.Size = New Size(x_size, y_size)
        Proyect.numero_lbl_79.Size = New Size(x_size, y_size)

        'Números 80 al 89
        Proyect.numero_lbl_80.Size = New Size(x_size, y_size)
        Proyect.numero_lbl_81.Size = New Size(x_size, y_size)
        Proyect.numero_lbl_82.Size = New Size(x_size, y_size)
        Proyect.numero_lbl_83.Size = New Size(x_size, y_size)
        Proyect.numero_lbl_84.Size = New Size(x_size, y_size)
        Proyect.numero_lbl_85.Size = New Size(x_size, y_size)
        Proyect.numero_lbl_86.Size = New Size(x_size, y_size)
        Proyect.numero_lbl_87.Size = New Size(x_size, y_size)
        Proyect.numero_lbl_88.Size = New Size(x_size, y_size)
        Proyect.numero_lbl_89.Size = New Size(x_size, y_size)

        'Número 90
        Proyect.numero_lbl_90.Size = New Size(x_size, y_size)
#End Region

        'Posición de cada label
        location_numeros(x_size, y_size, x_pos, y_pos, spc_pos_x, spc_pos_y)
    End Sub

    Public Shared Sub location_numeros(x_size, y_size, x_pos, y_pos, spc_pos_x, spc_pos_y)
        'Posiciona cada label de acuerdo al porcentaje
#Region "Labels' Position"

        'Números 1 al 10
        y_pos = 0
        x_pos = 0
        Proyect.numero_lbl_1.Location = New Point(x_pos, y_pos)

        x_pos = x_size + spc_pos_x + Proyect.numero_lbl_1.Location.X
        Proyect.numero_lbl_2.Location = New Point(x_pos, y_pos)

        x_pos = x_size + spc_pos_x + Proyect.numero_lbl_2.Location.X
        Proyect.numero_lbl_3.Location = New Point(x_pos, y_pos)

        x_pos = x_size + spc_pos_x + Proyect.numero_lbl_3.Location.X
        Proyect.numero_lbl_4.Location = New Point(x_pos, y_pos)

        x_pos = x_size + spc_pos_x + Proyect.numero_lbl_4.Location.X
        Proyect.numero_lbl_5.Location = New Point(x_pos, y_pos)

        x_pos = x_size + spc_pos_x + Proyect.numero_lbl_5.Location.X
        Proyect.numero_lbl_6.Location = New Point(x_pos, y_pos)

        x_pos = x_size + spc_pos_x + Proyect.numero_lbl_6.Location.X
        Proyect.numero_lbl_7.Location = New Point(x_pos, y_pos)

        x_pos = x_size + spc_pos_x + Proyect.numero_lbl_7.Location.X
        Proyect.numero_lbl_8.Location = New Point(x_pos, y_pos)

        x_pos = x_size + spc_pos_x + Proyect.numero_lbl_8.Location.X
        Proyect.numero_lbl_9.Location = New Point(x_pos, y_pos)

        x_pos = x_size + spc_pos_x + Proyect.numero_lbl_9.Location.X
        Proyect.numero_lbl_10.Location = New Point(x_pos, y_pos)

        '=============================================================
        'Números 11 al 20

        x_pos = 0
        y_pos = y_size + spc_pos_y + Proyect.numero_lbl_1.Location.Y
        Proyect.numero_lbl_11.Location = New Point(x_pos, y_pos)

        x_pos = x_size + spc_pos_x + Proyect.numero_lbl_11.Location.X
        y_pos = y_size + spc_pos_y + Proyect.numero_lbl_2.Location.Y
        Proyect.numero_lbl_12.Location = New Point(x_pos, y_pos)

        x_pos = x_size + spc_pos_x + Proyect.numero_lbl_12.Location.X
        y_pos = y_size + spc_pos_y + Proyect.numero_lbl_3.Location.Y
        Proyect.numero_lbl_13.Location = New Point(x_pos, y_pos)

        x_pos = x_size + spc_pos_x + Proyect.numero_lbl_13.Location.X
        y_pos = y_size + spc_pos_y + Proyect.numero_lbl_4.Location.Y
        Proyect.numero_lbl_14.Location = New Point(x_pos, y_pos)

        x_pos = x_size + spc_pos_x + Proyect.numero_lbl_14.Location.X
        y_pos = y_size + spc_pos_y + Proyect.numero_lbl_5.Location.Y
        Proyect.numero_lbl_15.Location = New Point(x_pos, y_pos)

        x_pos = x_size + spc_pos_x + Proyect.numero_lbl_15.Location.X
        y_pos = y_size + spc_pos_y + Proyect.numero_lbl_6.Location.Y
        Proyect.numero_lbl_16.Location = New Point(x_pos, y_pos)

        x_pos = x_size + spc_pos_x + Proyect.numero_lbl_16.Location.X
        y_pos = y_size + spc_pos_y + Proyect.numero_lbl_7.Location.Y
        Proyect.numero_lbl_17.Location = New Point(x_pos, y_pos)

        x_pos = x_size + spc_pos_x + Proyect.numero_lbl_17.Location.X
        y_pos = y_size + spc_pos_y + Proyect.numero_lbl_8.Location.Y
        Proyect.numero_lbl_18.Location = New Point(x_pos, y_pos)

        x_pos = x_size + spc_pos_x + Proyect.numero_lbl_18.Location.X
        y_pos = y_size + spc_pos_y + Proyect.numero_lbl_9.Location.Y
        Proyect.numero_lbl_19.Location = New Point(x_pos, y_pos)

        x_pos = x_size + spc_pos_x + Proyect.numero_lbl_19.Location.X
        y_pos = y_size + spc_pos_y + Proyect.numero_lbl_10.Location.Y
        Proyect.numero_lbl_20.Location = New Point(x_pos, y_pos)

        '=============================================================
        'Números 21 al 30

        x_pos = 0
        y_pos = y_size + spc_pos_y + Proyect.numero_lbl_11.Location.Y
        Proyect.numero_lbl_21.Location = New Point(x_pos, y_pos)

        x_pos = x_size + spc_pos_x + Proyect.numero_lbl_21.Location.X
        y_pos = y_size + spc_pos_y + Proyect.numero_lbl_12.Location.Y
        Proyect.numero_lbl_22.Location = New Point(x_pos, y_pos)

        x_pos = x_size + spc_pos_x + Proyect.numero_lbl_22.Location.X
        y_pos = y_size + spc_pos_y + Proyect.numero_lbl_13.Location.Y
        Proyect.numero_lbl_23.Location = New Point(x_pos, y_pos)

        x_pos = x_size + spc_pos_x + Proyect.numero_lbl_23.Location.X
        y_pos = y_size + spc_pos_y + Proyect.numero_lbl_14.Location.Y
        Proyect.numero_lbl_24.Location = New Point(x_pos, y_pos)

        x_pos = x_size + spc_pos_x + Proyect.numero_lbl_24.Location.X
        y_pos = y_size + spc_pos_y + Proyect.numero_lbl_15.Location.Y
        Proyect.numero_lbl_25.Location = New Point(x_pos, y_pos)

        x_pos = x_size + spc_pos_x + Proyect.numero_lbl_25.Location.X
        y_pos = y_size + spc_pos_y + Proyect.numero_lbl_16.Location.Y
        Proyect.numero_lbl_26.Location = New Point(x_pos, y_pos)

        x_pos = x_size + spc_pos_x + Proyect.numero_lbl_26.Location.X
        y_pos = y_size + spc_pos_y + Proyect.numero_lbl_17.Location.Y
        Proyect.numero_lbl_27.Location = New Point(x_pos, y_pos)

        x_pos = x_size + spc_pos_x + Proyect.numero_lbl_27.Location.X
        y_pos = y_size + spc_pos_y + Proyect.numero_lbl_18.Location.Y
        Proyect.numero_lbl_28.Location = New Point(x_pos, y_pos)

        x_pos = x_size + spc_pos_x + Proyect.numero_lbl_28.Location.X
        y_pos = y_size + spc_pos_y + Proyect.numero_lbl_19.Location.Y
        Proyect.numero_lbl_29.Location = New Point(x_pos, y_pos)

        x_pos = x_size + spc_pos_x + Proyect.numero_lbl_29.Location.X
        y_pos = y_size + spc_pos_y + Proyect.numero_lbl_20.Location.Y
        Proyect.numero_lbl_30.Location = New Point(x_pos, y_pos)
        '=============================================================
        'Números 31 al 40

        x_pos = 0
        y_pos = y_size + spc_pos_y + Proyect.numero_lbl_21.Location.Y
        Proyect.numero_lbl_31.Location = New Point(x_pos, y_pos)

        x_pos = x_size + spc_pos_x + Proyect.numero_lbl_31.Location.X
        y_pos = y_size + spc_pos_y + Proyect.numero_lbl_22.Location.Y
        Proyect.numero_lbl_32.Location = New Point(x_pos, y_pos)

        x_pos = x_size + spc_pos_x + Proyect.numero_lbl_32.Location.X
        y_pos = y_size + spc_pos_y + Proyect.numero_lbl_23.Location.Y
        Proyect.numero_lbl_33.Location = New Point(x_pos, y_pos)

        x_pos = x_size + spc_pos_x + Proyect.numero_lbl_33.Location.X
        y_pos = y_size + spc_pos_y + Proyect.numero_lbl_24.Location.Y
        Proyect.numero_lbl_34.Location = New Point(x_pos, y_pos)

        x_pos = x_size + spc_pos_x + Proyect.numero_lbl_34.Location.X
        y_pos = y_size + spc_pos_y + Proyect.numero_lbl_25.Location.Y
        Proyect.numero_lbl_35.Location = New Point(x_pos, y_pos)

        x_pos = x_size + spc_pos_x + Proyect.numero_lbl_35.Location.X
        y_pos = y_size + spc_pos_y + Proyect.numero_lbl_26.Location.Y
        Proyect.numero_lbl_36.Location = New Point(x_pos, y_pos)

        x_pos = x_size + spc_pos_x + Proyect.numero_lbl_36.Location.X
        y_pos = y_size + spc_pos_y + Proyect.numero_lbl_27.Location.Y
        Proyect.numero_lbl_37.Location = New Point(x_pos, y_pos)

        x_pos = x_size + spc_pos_x + Proyect.numero_lbl_37.Location.X
        y_pos = y_size + spc_pos_y + Proyect.numero_lbl_28.Location.Y
        Proyect.numero_lbl_38.Location = New Point(x_pos, y_pos)

        x_pos = x_size + spc_pos_x + Proyect.numero_lbl_38.Location.X
        y_pos = y_size + spc_pos_y + Proyect.numero_lbl_29.Location.Y
        Proyect.numero_lbl_39.Location = New Point(x_pos, y_pos)

        x_pos = x_size + spc_pos_x + Proyect.numero_lbl_39.Location.X
        y_pos = y_size + spc_pos_y + Proyect.numero_lbl_30.Location.Y
        Proyect.numero_lbl_40.Location = New Point(x_pos, y_pos)

        '=============================================================
        'Números 41 al 50

        x_pos = 0
        y_pos = y_size + spc_pos_y + Proyect.numero_lbl_31.Location.Y
        Proyect.numero_lbl_41.Location = New Point(x_pos, y_pos)

        x_pos = x_size + spc_pos_x + Proyect.numero_lbl_41.Location.X
        y_pos = y_size + spc_pos_y + Proyect.numero_lbl_32.Location.Y
        Proyect.numero_lbl_42.Location = New Point(x_pos, y_pos)

        x_pos = x_size + spc_pos_x + Proyect.numero_lbl_42.Location.X
        y_pos = y_size + spc_pos_y + Proyect.numero_lbl_33.Location.Y
        Proyect.numero_lbl_43.Location = New Point(x_pos, y_pos)

        x_pos = x_size + spc_pos_x + Proyect.numero_lbl_43.Location.X
        y_pos = y_size + spc_pos_y + Proyect.numero_lbl_34.Location.Y
        Proyect.numero_lbl_44.Location = New Point(x_pos, y_pos)

        x_pos = x_size + spc_pos_x + Proyect.numero_lbl_44.Location.X
        y_pos = y_size + spc_pos_y + Proyect.numero_lbl_35.Location.Y
        Proyect.numero_lbl_45.Location = New Point(x_pos, y_pos)

        x_pos = x_size + spc_pos_x + Proyect.numero_lbl_45.Location.X
        y_pos = y_size + spc_pos_y + Proyect.numero_lbl_36.Location.Y
        Proyect.numero_lbl_46.Location = New Point(x_pos, y_pos)

        x_pos = x_size + spc_pos_x + Proyect.numero_lbl_46.Location.X
        y_pos = y_size + spc_pos_y + Proyect.numero_lbl_37.Location.Y
        Proyect.numero_lbl_47.Location = New Point(x_pos, y_pos)

        x_pos = x_size + spc_pos_x + Proyect.numero_lbl_47.Location.X
        y_pos = y_size + spc_pos_y + Proyect.numero_lbl_38.Location.Y
        Proyect.numero_lbl_48.Location = New Point(x_pos, y_pos)

        x_pos = x_size + spc_pos_x + Proyect.numero_lbl_48.Location.X
        y_pos = y_size + spc_pos_y + Proyect.numero_lbl_39.Location.Y
        Proyect.numero_lbl_49.Location = New Point(x_pos, y_pos)

        x_pos = x_size + spc_pos_x + Proyect.numero_lbl_49.Location.X
        y_pos = y_size + spc_pos_y + Proyect.numero_lbl_40.Location.Y
        Proyect.numero_lbl_50.Location = New Point(x_pos, y_pos)

        '=============================================================
        'Números 51 al 60

        x_pos = 0
        y_pos = y_size + spc_pos_y + Proyect.numero_lbl_41.Location.Y
        Proyect.numero_lbl_51.Location = New Point(x_pos, y_pos)

        x_pos = x_size + spc_pos_x + Proyect.numero_lbl_51.Location.X
        y_pos = y_size + spc_pos_y + Proyect.numero_lbl_42.Location.Y
        Proyect.numero_lbl_52.Location = New Point(x_pos, y_pos)

        x_pos = x_size + spc_pos_x + Proyect.numero_lbl_52.Location.X
        y_pos = y_size + spc_pos_y + Proyect.numero_lbl_43.Location.Y
        Proyect.numero_lbl_53.Location = New Point(x_pos, y_pos)

        x_pos = x_size + spc_pos_x + Proyect.numero_lbl_53.Location.X
        y_pos = y_size + spc_pos_y + Proyect.numero_lbl_44.Location.Y
        Proyect.numero_lbl_54.Location = New Point(x_pos, y_pos)

        x_pos = x_size + spc_pos_x + Proyect.numero_lbl_54.Location.X
        y_pos = y_size + spc_pos_y + Proyect.numero_lbl_45.Location.Y
        Proyect.numero_lbl_55.Location = New Point(x_pos, y_pos)

        x_pos = x_size + spc_pos_x + Proyect.numero_lbl_55.Location.X
        y_pos = y_size + spc_pos_y + Proyect.numero_lbl_46.Location.Y
        Proyect.numero_lbl_56.Location = New Point(x_pos, y_pos)

        x_pos = x_size + spc_pos_x + Proyect.numero_lbl_56.Location.X
        y_pos = y_size + spc_pos_y + Proyect.numero_lbl_47.Location.Y
        Proyect.numero_lbl_57.Location = New Point(x_pos, y_pos)

        x_pos = x_size + spc_pos_x + Proyect.numero_lbl_57.Location.X
        y_pos = y_size + spc_pos_y + Proyect.numero_lbl_48.Location.Y
        Proyect.numero_lbl_58.Location = New Point(x_pos, y_pos)

        x_pos = x_size + spc_pos_x + Proyect.numero_lbl_58.Location.X
        y_pos = y_size + spc_pos_y + Proyect.numero_lbl_49.Location.Y
        Proyect.numero_lbl_59.Location = New Point(x_pos, y_pos)

        x_pos = x_size + spc_pos_x + Proyect.numero_lbl_59.Location.X
        y_pos = y_size + spc_pos_y + Proyect.numero_lbl_50.Location.Y
        Proyect.numero_lbl_60.Location = New Point(x_pos, y_pos)

        '=============================================================
        'Números 61 al 70

        x_pos = 0
        y_pos = y_size + spc_pos_y + Proyect.numero_lbl_51.Location.Y
        Proyect.numero_lbl_61.Location = New Point(x_pos, y_pos)

        x_pos = x_size + spc_pos_x + Proyect.numero_lbl_61.Location.X
        y_pos = y_size + spc_pos_y + Proyect.numero_lbl_52.Location.Y
        Proyect.numero_lbl_62.Location = New Point(x_pos, y_pos)

        x_pos = x_size + spc_pos_x + Proyect.numero_lbl_62.Location.X
        y_pos = y_size + spc_pos_y + Proyect.numero_lbl_53.Location.Y
        Proyect.numero_lbl_63.Location = New Point(x_pos, y_pos)

        x_pos = x_size + spc_pos_x + Proyect.numero_lbl_63.Location.X
        y_pos = y_size + spc_pos_y + Proyect.numero_lbl_54.Location.Y
        Proyect.numero_lbl_64.Location = New Point(x_pos, y_pos)

        x_pos = x_size + spc_pos_x + Proyect.numero_lbl_64.Location.X
        y_pos = y_size + spc_pos_y + Proyect.numero_lbl_55.Location.Y
        Proyect.numero_lbl_65.Location = New Point(x_pos, y_pos)

        x_pos = x_size + spc_pos_x + Proyect.numero_lbl_65.Location.X
        y_pos = y_size + spc_pos_y + Proyect.numero_lbl_56.Location.Y
        Proyect.numero_lbl_66.Location = New Point(x_pos, y_pos)

        x_pos = x_size + spc_pos_x + Proyect.numero_lbl_66.Location.X
        y_pos = y_size + spc_pos_y + Proyect.numero_lbl_57.Location.Y
        Proyect.numero_lbl_67.Location = New Point(x_pos, y_pos)

        x_pos = x_size + spc_pos_x + Proyect.numero_lbl_67.Location.X
        y_pos = y_size + spc_pos_y + Proyect.numero_lbl_58.Location.Y
        Proyect.numero_lbl_68.Location = New Point(x_pos, y_pos)

        x_pos = x_size + spc_pos_x + Proyect.numero_lbl_68.Location.X
        y_pos = y_size + spc_pos_y + Proyect.numero_lbl_59.Location.Y
        Proyect.numero_lbl_69.Location = New Point(x_pos, y_pos)

        x_pos = x_size + spc_pos_x + Proyect.numero_lbl_69.Location.X
        y_pos = y_size + spc_pos_y + Proyect.numero_lbl_60.Location.Y
        Proyect.numero_lbl_70.Location = New Point(x_pos, y_pos)

        '=============================================================
        'Números 71 al 80

        x_pos = 0
        y_pos = y_size + spc_pos_y + Proyect.numero_lbl_61.Location.Y
        Proyect.numero_lbl_71.Location = New Point(x_pos, y_pos)

        x_pos = x_size + spc_pos_x + Proyect.numero_lbl_71.Location.X
        y_pos = y_size + spc_pos_y + Proyect.numero_lbl_62.Location.Y
        Proyect.numero_lbl_72.Location = New Point(x_pos, y_pos)

        x_pos = x_size + spc_pos_x + Proyect.numero_lbl_72.Location.X
        y_pos = y_size + spc_pos_y + Proyect.numero_lbl_63.Location.Y
        Proyect.numero_lbl_73.Location = New Point(x_pos, y_pos)

        x_pos = x_size + spc_pos_x + Proyect.numero_lbl_73.Location.X
        y_pos = y_size + spc_pos_y + Proyect.numero_lbl_64.Location.Y
        Proyect.numero_lbl_74.Location = New Point(x_pos, y_pos)

        x_pos = x_size + spc_pos_x + Proyect.numero_lbl_74.Location.X
        y_pos = y_size + spc_pos_y + Proyect.numero_lbl_65.Location.Y
        Proyect.numero_lbl_75.Location = New Point(x_pos, y_pos)

        x_pos = x_size + spc_pos_x + Proyect.numero_lbl_75.Location.X
        y_pos = y_size + spc_pos_y + Proyect.numero_lbl_66.Location.Y
        Proyect.numero_lbl_76.Location = New Point(x_pos, y_pos)

        x_pos = x_size + spc_pos_x + Proyect.numero_lbl_76.Location.X
        y_pos = y_size + spc_pos_y + Proyect.numero_lbl_67.Location.Y
        Proyect.numero_lbl_77.Location = New Point(x_pos, y_pos)

        x_pos = x_size + spc_pos_x + Proyect.numero_lbl_77.Location.X
        y_pos = y_size + spc_pos_y + Proyect.numero_lbl_68.Location.Y
        Proyect.numero_lbl_78.Location = New Point(x_pos, y_pos)

        x_pos = x_size + spc_pos_x + Proyect.numero_lbl_78.Location.X
        y_pos = y_size + spc_pos_y + Proyect.numero_lbl_69.Location.Y
        Proyect.numero_lbl_79.Location = New Point(x_pos, y_pos)

        x_pos = x_size + spc_pos_x + Proyect.numero_lbl_79.Location.X
        y_pos = y_size + spc_pos_y + Proyect.numero_lbl_70.Location.Y
        Proyect.numero_lbl_80.Location = New Point(x_pos, y_pos)

        '=============================================================
        'Números 81 al 90

        x_pos = 0
        y_pos = y_size + spc_pos_y + Proyect.numero_lbl_71.Location.Y
        Proyect.numero_lbl_81.Location = New Point(x_pos, y_pos)

        x_pos = x_size + spc_pos_x + Proyect.numero_lbl_81.Location.X
        y_pos = y_size + spc_pos_y + Proyect.numero_lbl_72.Location.Y
        Proyect.numero_lbl_82.Location = New Point(x_pos, y_pos)

        x_pos = x_size + spc_pos_x + Proyect.numero_lbl_82.Location.X
        y_pos = y_size + spc_pos_y + Proyect.numero_lbl_73.Location.Y
        Proyect.numero_lbl_83.Location = New Point(x_pos, y_pos)

        x_pos = x_size + spc_pos_x + Proyect.numero_lbl_83.Location.X
        y_pos = y_size + spc_pos_y + Proyect.numero_lbl_74.Location.Y
        Proyect.numero_lbl_84.Location = New Point(x_pos, y_pos)

        x_pos = x_size + spc_pos_x + Proyect.numero_lbl_84.Location.X
        y_pos = y_size + spc_pos_y + Proyect.numero_lbl_75.Location.Y
        Proyect.numero_lbl_85.Location = New Point(x_pos, y_pos)

        x_pos = x_size + spc_pos_x + Proyect.numero_lbl_85.Location.X
        y_pos = y_size + spc_pos_y + Proyect.numero_lbl_76.Location.Y
        Proyect.numero_lbl_86.Location = New Point(x_pos, y_pos)

        x_pos = x_size + spc_pos_x + Proyect.numero_lbl_86.Location.X
        y_pos = y_size + spc_pos_y + Proyect.numero_lbl_77.Location.Y
        Proyect.numero_lbl_87.Location = New Point(x_pos, y_pos)

        x_pos = x_size + spc_pos_x + Proyect.numero_lbl_87.Location.X
        y_pos = y_size + spc_pos_y + Proyect.numero_lbl_78.Location.Y
        Proyect.numero_lbl_88.Location = New Point(x_pos, y_pos)

        x_pos = x_size + spc_pos_x + Proyect.numero_lbl_88.Location.X
        y_pos = y_size + spc_pos_y + Proyect.numero_lbl_79.Location.Y
        Proyect.numero_lbl_89.Location = New Point(x_pos, y_pos)

        x_pos = x_size + spc_pos_x + Proyect.numero_lbl_89.Location.X
        y_pos = y_size + spc_pos_y + Proyect.numero_lbl_80.Location.Y
        Proyect.numero_lbl_90.Location = New Point(x_pos, y_pos)
#End Region
    End Sub

    Public Shared Sub size_lblsinf()
        'Eje X e Y para centrar
        Dim x As New Double
        Dim y As New Double

        Dim bingo_lbl = Proyect.bingo_lbl
        Dim linea_lbl = Proyect.linea_lbl
        Dim ganador_lbl = Proyect.ganador_lbl
        Dim panel_numeros = Proyect.panel_numeros
        Dim sobra = (Proyect.Height - panel_numeros.Location.Y - panel_numeros.Height)

        'Centrado en pantalla del label Bingo
        x = (Proyect.Width / 2) - (Proyect.bingo_lbl.Width / 2) - 8
        y = (Proyect.Height - (sobra / 2)) - bingo_lbl.Height - (bingo_lbl.Height / 1 / 3)

        Proyect.bingo_lbl.Location = New Point(x, y)

        'Centrado en pantalla del label Linea
        x = (Proyect.Width / 2) - (Proyect.linea_lbl.Width / 2) - 8
        y = (Proyect.Height - (sobra / 2)) - linea_lbl.Height - (linea_lbl.Height / 1 / 3)

        Proyect.linea_lbl.Location = New Point(x, y)

        'Centrado en pantalla del label con el nombre del ganador
        x = (Proyect.Width / 2) - (Proyect.ganador_lbl.Width / 2) - 8
        y = bingo_lbl.Location.Y + bingo_lbl.Height '(Proyect.Height - (sobra / 2)) + (bingo_lbl.Height / 2) - ganador_lbl.Height

        Proyect.ganador_lbl.Location = New Point(x, y)
    End Sub

    Public Shared Sub size_circulo()
        'Ejes X e Y para centrar
        Dim x As New Double
        Dim y As New Double

        'Abreviaciones de rutas del form Proyect
        Dim circulo_pic = Proyect.circulo_pic
        Dim numero_lbl_grande = Proyect.numero_lbl_grande
        Dim panel_numeros = Proyect.panel_numeros

        If Main.panel_bttn.Text = "Mostrar panel de números" Then
            circulo_pic.Width = panel_numeros.Height
            circulo_pic.Height = panel_numeros.Height

            x = (Proyect.Width / 2) - (Proyect.circulo_pic.Width / 2) - 8
            y = 20
            circulo_pic.Location = New Point(x, y)

            'Calcula el porcentaje que ocupa de ancho y alto el label
            'Circulo = 294; 294
            'Label = 230; 178
            numero_lbl_grande.Width = circulo_pic.Width * (230 * 100 / 294) / 100
            numero_lbl_grande.Height = circulo_pic.Height * (178 * 100 / 294) / 100

            x = (Proyect.Width / 2) - (numero_lbl_grande.Width / 2) - 8
            y = (circulo_pic.Height / 2) - (numero_lbl_grande.Height / 2) + 19
            numero_lbl_grande.Location = New Point(x, y)

        Else
            circulo_pic.Height = 294
            circulo_pic.Width = 294

            numero_lbl_grande.Width = 230
            numero_lbl_grande.Height = 178
        End If
    End Sub

    Public Shared Sub pos_circulo_cpanel()
        'Ejes X e Y para centrar 
        Dim x As New Double
        Dim y As New Double

        'Abreviación de la ruta de cada label form Proyect
        Dim numero_lbl_grande = Proyect.numero_lbl_grande
        Dim panel_numeros = Proyect.panel_numeros
        Dim circulo_pic = Proyect.circulo_pic
        'Abreviación rutas form Main
        Dim panel_bttn = Main.panel_bttn

        'Muestrael panel
        panel_numeros.Visible = True

        'Toma como punto de referencia el borde derecho del form Proyect
        numero_lbl_grande.Anchor = AnchorStyles.Right
        circulo_pic.Anchor = AnchorStyles.Right

        'Ajusta el tamaño del círculo y la posisicón del label
        Proyect.Tamano_circulo.Stop()
        Proyect.Tamano_circulo.Enabled = False

        'Tamaño del círculo
        circulo_pic.Size = New Size(294, 294)
        'Mueve el círculo a la derecha
        'Para el eje Y calcula el centro del panel y luego resta la mitad de su tamaño
        x = Proyect.Width - 356
        y = (panel_numeros.Height / 2) + panel_numeros.Location.Y - (294 / 2)
        circulo_pic.Location = New Point(x, y)

        'Centra el label (con respecto al panel) en el lado derecho de la pantalla
        'Tamaños originales:
        'Circulo = 294; 294
        'Label = 230; 178
        'Calcula el porcentaje del tamaño del label para mantenerlo constante
        numero_lbl_grande.Width = circulo_pic.Width * (230 * 100 / 294) / 100
        numero_lbl_grande.Height = circulo_pic.Height * (178 * 100 / 294) / 100

        x = (circulo_pic.Location.X) + 32
        y = (circulo_pic.Location.Y) + 58
        numero_lbl_grande.Location = New Point(x, y)

        'Cambia el nombre del botón
        panel_bttn.Text = "Ocultar panel de números"

        'Guarda la configuración en My Settings
        My.Settings.panel_sh = True
    End Sub

    Public Shared Sub pos_circulo_spanel()
        'Ejes X e Y para centrar 
        Dim x As New Double
        Dim y As New Double

        'Abreviación de la ruta de cada label
        Dim numero_lbl_grande = Proyect.numero_lbl_grande
        Dim panel_numeros = Proyect.panel_numeros
        Dim circulo_pic = Proyect.circulo_pic
        'Abreviación rutas form Main
        Dim panel_bttn = Main.panel_bttn

        'Oculta el panel
        panel_numeros.Visible = False

        'Evita que tome como punto de referencia el borde derecho del form Proyect
        numero_lbl_grande.Anchor = AnchorStyles.None
        circulo_pic.Anchor = AnchorStyles.None

        'Ajusta el tamaño del círculo y la posisicón del label
        Proyect.Tamano_circulo.Enabled = True
        Proyect.Tamano_circulo.Start()

        ''Centra el label
        ''Toma el eje Y por defecto
        'x = (Proyect.Width / 2) - (numero_lbl_grande.Width / 2) - 8
        'y = Proyect.numero_lbl_grande.Location.Y
        'numero_lbl_grande.Location = New Point(x, y)

        ''Centra el círculo
        ''Toma el eje Y por defecto
        'x = (Proyect.Width / 2) - (circulo_pic.Width / 2) - 8
        'y = 29
        'circulo_pic.Location = New Point(x, y)

        'Cambia el nombre del botón
        panel_bttn.Text = "Mostrar panel de números"

        'Guarda la configuración en My Settings
        My.Settings.panel_sh = False
    End Sub

    Public Shared Sub pos_circulo_spanel_default()
        'Ejes X e Y para centrar 
        Dim x As New Double
        Dim y As New Double

        'Abreviación de la ruta de cada label
        Dim numero_lbl_grande = Proyect.numero_lbl_grande
        Dim panel_numeros = Proyect.panel_numeros
        Dim circulo_pic = Proyect.circulo_pic
        'Abreviación rutas form Main
        Dim panel_bttn = Main.panel_bttn

        'Muestra el panel
        panel_numeros.Visible = True

        'Ajusta el tamaño del círculo y la posisicón del label
        Proyect.Tamano_circulo.Stop()
        Proyect.Tamano_circulo.Enabled = False

        circulo_pic.Size = New Size(294, 294)
        circulo_pic.Location = New Point(524, 29)

        numero_lbl_grande.Size = New Size(230, 178)
        numero_lbl_grande.Location = New Point(556, 87)

        'Cambia el nombre del botón
        panel_bttn.Text = "Ocultar panel de números"

        'Guarda la configuración en My Settings
        My.Settings.panel_sh = True
    End Sub

    Public Shared Sub full_screen()
        If Main.titulo_bttn.Text = "Ocultar barra de título" Then
            Proyect.WindowState = FormWindowState.Maximized
            Proyect.FormBorderStyle = FormBorderStyle.None
            Main.titulo_bttn.Text = "Mostrar barra de título"
        Else
            Proyect.WindowState = FormWindowState.Normal
            Proyect.FormBorderStyle = FormBorderStyle.Sizable
            Main.titulo_bttn.Text = "Ocultar barra de título"
        End If
    End Sub
End Class
