'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My
    
    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Partial Friend NotInheritable Class MySettings
        Inherits Global.System.Configuration.ApplicationSettingsBase
        
        Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings()),MySettings)
        
#Region "My.Settings Auto-Save Functionality"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(ByVal sender As Global.System.Object, ByVal e As Global.System.EventArgs)
        If My.Application.SaveMySettingsOnExit Then
            My.Settings.Save()
        End If
    End Sub
#End If
#End Region
        
        Public Shared ReadOnly Property [Default]() As MySettings
            Get
                
#If _MyType = "WindowsForms" Then
               If Not addedHandler Then
                    SyncLock addedHandlerLockObject
                        If Not addedHandler Then
                            AddHandler My.Application.Shutdown, AddressOf AutoSaveSettings
                            addedHandler = True
                        End If
                    End SyncLock
                End If
#End If
                Return defaultInstance
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("spanish")>  _
        Public Property language() As String
            Get
                Return CType(Me("language"),String)
            End Get
            Set
                Me("language") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Tela roja")>  _
        Public Property fondo() As String
            Get
                Return CType(Me("fondo"),String)
            End Get
            Set
                Me("fondo") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Arial Narrow, 72pt")>  _
        Public Property fuentes_bingo() As Global.System.Drawing.Font
            Get
                Return CType(Me("fuentes_bingo"),Global.System.Drawing.Font)
            End Get
            Set
                Me("fuentes_bingo") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Yellow")>  _
        Public Property fuentes_bingo_color() As Global.System.Drawing.Color
            Get
                Return CType(Me("fuentes_bingo_color"),Global.System.Drawing.Color)
            End Get
            Set
                Me("fuentes_bingo_color") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Arial Narrow, 72pt")>  _
        Public Property fuentes_linea() As Global.System.Drawing.Font
            Get
                Return CType(Me("fuentes_linea"),Global.System.Drawing.Font)
            End Get
            Set
                Me("fuentes_linea") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Yellow")>  _
        Public Property fuentes_linea_color() As Global.System.Drawing.Color
            Get
                Return CType(Me("fuentes_linea_color"),Global.System.Drawing.Color)
            End Get
            Set
                Me("fuentes_linea_color") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Arial Narrow, 48pt")>  _
        Public Property fuentes_nombre() As Global.System.Drawing.Font
            Get
                Return CType(Me("fuentes_nombre"),Global.System.Drawing.Font)
            End Get
            Set
                Me("fuentes_nombre") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("White")>  _
        Public Property fuentes_nombre_color() As Global.System.Drawing.Color
            Get
                Return CType(Me("fuentes_nombre_color"),Global.System.Drawing.Color)
            End Get
            Set
                Me("fuentes_nombre_color") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Maroon")>  _
        Public Property color_fondo_panel() As Global.System.Drawing.Color
            Get
                Return CType(Me("color_fondo_panel"),Global.System.Drawing.Color)
            End Get
            Set
                Me("color_fondo_panel") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Black")>  _
        Public Property color_fondo_numeros() As Global.System.Drawing.Color
            Get
                Return CType(Me("color_fondo_numeros"),Global.System.Drawing.Color)
            End Get
            Set
                Me("color_fondo_numeros") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Yellow")>  _
        Public Property color_texto_numeros() As Global.System.Drawing.Color
            Get
                Return CType(Me("color_texto_numeros"),Global.System.Drawing.Color)
            End Get
            Set
                Me("color_texto_numeros") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Green")>  _
        Public Property color_fondo_numeros_org() As Global.System.Drawing.Color
            Get
                Return CType(Me("color_fondo_numeros_org"),Global.System.Drawing.Color)
            End Get
            Set
                Me("color_fondo_numeros_org") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("White")>  _
        Public Property color_texto_numeros_org() As Global.System.Drawing.Color
            Get
                Return CType(Me("color_texto_numeros_org"),Global.System.Drawing.Color)
            End Get
            Set
                Me("color_texto_numeros_org") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Times New Roman, 20.25pt")>  _
        Public Property fuente_texto_numeros() As Global.System.Drawing.Font
            Get
                Return CType(Me("fuente_texto_numeros"),Global.System.Drawing.Font)
            End Get
            Set
                Me("fuente_texto_numeros") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Times New Roman, 20.25pt")>  _
        Public Property fuente_texto_numeros_org() As Global.System.Drawing.Font
            Get
                Return CType(Me("fuente_texto_numeros_org"),Global.System.Drawing.Font)
            End Get
            Set
                Me("fuente_texto_numeros_org") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property fondo_pers() As String
            Get
                Return CType(Me("fondo_pers"),String)
            End Get
            Set
                Me("fondo_pers") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property fondo_pers_combobox() As String
            Get
                Return CType(Me("fondo_pers_combobox"),String)
            End Get
            Set
                Me("fondo_pers_combobox") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property fondo_last() As Boolean
            Get
                Return CType(Me("fondo_last"),Boolean)
            End Get
            Set
                Me("fondo_last") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property panel_sh() As Boolean
            Get
                Return CType(Me("panel_sh"),Boolean)
            End Get
            Set
                Me("panel_sh") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Times New Roman, 108pt")>  _
        Public Property lbl_grande() As Global.System.Drawing.Font
            Get
                Return CType(Me("lbl_grande"),Global.System.Drawing.Font)
            End Get
            Set
                Me("lbl_grande") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Black")>  _
        Public Property lbl_grande_color() As Global.System.Drawing.Color
            Get
                Return CType(Me("lbl_grande_color"),Global.System.Drawing.Color)
            End Get
            Set
                Me("lbl_grande_color") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("10")>  _
        Public Property tiemp_contador() As Byte
            Get
                Return CType(Me("tiemp_contador"),Byte)
            End Get
            Set
                Me("tiemp_contador") = value
            End Set
        End Property
    End Class
End Namespace

Namespace My
    
    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Module MySettingsProperty
        
        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>  _
        Friend ReadOnly Property Settings() As Global.Bingo_Project.My.MySettings
            Get
                Return Global.Bingo_Project.My.MySettings.Default
            End Get
        End Property
    End Module
End Namespace
