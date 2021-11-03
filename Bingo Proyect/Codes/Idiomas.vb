Public Class Idiomas

    Public Shared Sub seleccionar()
        Select Case My.Settings.language
            Case "english"
                english()
            Case "spanish"
                spanish()
        End Select
    End Sub

    Public Shared Sub english()
        Main.numero_bttn.Text = "Send number"
    End Sub

    Public Shared Sub spanish()
#Region "Main"
        'Barra menú
        Dim archivo_bttn_bm = Main.archivo_bttn_bm
        Dim idioma_bttn_bm = Main.idioma_bttn_bm
        Dim salir_bttn_bm = Main.salir_bttn_bm
        Dim about_bttn_bm = Main.about_bttn_bm

        'Tab Control
        '========== PENDIENTE ==========

        'Principal
        Dim numero_bttn = Main.numero_bttn
        Dim nombre_bttn = Main.nombre_bttn
        Dim linea_bttn = Main.linea_bttn
        Dim bingo_bttn = Main.bingo_bttn

        'Opciones
        Dim reiniciar_bttn = Main.reiniciar_bttn
        Dim bolillero_bttn = Main.bolillero_bttn
        Dim GroupBox = Main.GroupBox
        Dim mostrar_bttn = Main.mostrar_bttn
        Dim titulo_bttn = Main.titulo_bttn
        Dim panel_bttn = Main.panel_bttn
        Dim fuentes_bttn = Main.fuentes_bttn
        Dim img_fnd_lbl = Main.img_fnd_lbl
        Dim fondo_select = Main.fondo_select
        Dim aplicar_fnd_bttn = Main.aplicar_fnd_bttn
        Dim restaurar_bttn = Main.restaurar_bttn

        'Traducciones
        numero_bttn.Text = "Enviar número"


#End Region
    End Sub
End Class
