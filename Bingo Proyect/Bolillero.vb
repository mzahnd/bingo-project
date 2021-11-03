Public Class Bolillero
    'Crea una lista para almacenar los valores generados
    'La lista se utiliza para verificar que no se repita ninguno
    Dim almacen As New ArrayList
    'Variable donde se almacena el número que se muestra en pantalla
    'Se utiliza para el timer encargado de enviar el número al form Proyect
    Dim lblnum As Integer
    'Controla que no sobrepase el límite de números al azar posibles a generar
    Dim j As Integer

    Private Sub Bolillero_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        j = 0
    End Sub

    Private Sub numero_rnd_bttn_Click(sender As Object, e As EventArgs) Handles numero_rnd_bttn.Click
        Call Generar_Numero(almacen)
    End Sub

    Private Sub snd_numero_CheckedChanged(sender As Object, e As EventArgs) Handles snd_numero.CheckedChanged
        If snd_numero.Checked = True Then
            envia_numero.Enabled = True
            envia_numero.Start()
            lblnum = numero_rnd_lbl.Text
        ElseIf snd_numero.Checked = False Then
            envia_numero.Stop()
            envia_numero.Enabled = False
        End If
    End Sub

    Private Sub ReiniciarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReiniciarToolStripMenuItem.Click
        'Borra todos los datos contenidos en la lista "almacen"
        'Y cambia el número en el label "numero_rnd_lbl" a "00"
        almacen.Clear()
        numero_rnd_lbl.Text = "00"
    End Sub

    Sub Generar_Numero(ByRef almacen)
        'Variable entera para el contador
        Dim i As Integer

        'Linea llamada "numero_random" para poder volver a ella en caso de que un número esté repetido
numero_random:

        'Inicia el generador de números al azar
        Randomize()
        'Genera un número al azar entre 1 y 90
        Dim numero As Integer = CInt(Int((90 * Rnd()) + 1))

        'Revisa que no se haya pasado el máximo
        If j < 90 Then
            'Bucle para verificar si el número al azar ya existe
            For i = 0 To 90

                'Verifica que "almacen" no contenga el número generado
                If Not almacen.Contains(numero) Then
                    'Si no lo contiene, lo agrega y sale del bucle
                    almacen.Insert(i, numero)
                    j = j + 1
                    Exit For
                Else
                    GoTo numero_random
                    Exit For

                End If
            Next

            'Si el número generado es menor o igual a 9, le agrega un 0 antes para que se muestre con el formato '00'
            'Luego lo muestra en pantalla
            If numero <= 9 Then
                numero_rnd_lbl.Text = "0" + numero.ToString
            Else
                numero_rnd_lbl.Text = numero.ToString
            End If


        Else
            'Reinicia el bolillero para evitar errores
            MsgBox("Se reiniciará el bolillero.")
            'Devuelve a i el valor 0
            j = 0
            'Borra todos los datos contenidos en la lista "almacen"
            'Y cambia el número en el label "numero_rnd_lbl" a "00"
            almacen.Clear()
            numero_rnd_lbl.Text = "00"

        End If
    End Sub

    Private Sub envia_numero_Tick(sender As Object, e As EventArgs) Handles envia_numero.Tick
        'En caso de que el número almacenado en la variable sea distinto al mostrado en pantalla
        'Se envía para que sea mostrado
        If lblnum <> numero_rnd_lbl.Text Then
            'Se establece como el texto en el DomainUpDown del form Main
            Main.numero_txtbx.Text = numero_rnd_lbl.Text
            'Se muestra en grande en el form Proyect
            Proyect.numero_lbl_grande.Text = numero_rnd_lbl.Text

            'Se detiene el timer del form Proyect
            'Detiene y deshabilita el timer "Contador", encargado de mostrar el número elegido por 10 segundos
            Proyect.Contador.Stop()
            Proyect.Contador.Enabled = False

            'Habilita y comienza el timer "Contra_contador", encargado de mostrar "00" en lugar del número elegido
            Proyect.Contra_contador.Enabled = True
            Proyect.Contra_contador.Start()
            'Se colorea e inicia el timer para ocultar el número grande
            Call Colores_Numeros.displaynumeros()
            'Se cambia el valor de "lblnum"
            lblnum = numero_rnd_lbl.Text
        Else
            '
        End If
    End Sub
End Class