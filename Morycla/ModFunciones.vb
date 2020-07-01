Imports C_Entidad
Imports C_Negocio
Module ModFunciones
    Dim objCe_A As New Ce_Auditoria
    Dim obj_Cn_A As New Cn_Auditoria

    Public Rojo As Integer = 0
    Public Amarillo As Integer = 0
    Public BProd As Integer = 0
    Public BEntrada As Integer = 0
    Public Bu As Integer = 0
    Public Ba As Integer = 0
    Public DE As Integer = 0
    Public Accion As String
    Public Tp As String = ""
    Public Sal As Integer = 0
    Public Tras As Integer = 0
    'Busqueda de Funcionario
    Public DocFun As String = ""

    'Identificacion del usuario
    Public ConsFunc As Integer
    Public SedeFuncCons As Integer
    Public Sede As String = ""
    Public DocuFunc As String
    Public NomFunc As String
    Public PerfilFunc As Integer

    Public Texto As String

    Public Sub Cript()
        Dim C As Integer
        Dim C2 As Integer
        Dim Car As String
        Dim Sale As String
        Dim cod() As Integer
        ReDim cod(10)
        Car = " "
        Sale = Space(255)
        cod(1) = 8
        cod(2) = -4
        cod(3) = 5
        cod(4) = -2
        cod(5) = 4
        cod(6) = -6
        cod(7) = -3
        cod(8) = 3
        cod(9) = 4
        cod(10) = 6

        For C = 1 To Len(Texto)
            C2 = Right(Trim(Str(C)), 1)
            C2 = IIf(C2 = 0, 10, C2)
            If Asc(Mid(Texto, C, 1)) <> 32 Then
                Car = Chr(Asc(Mid(Texto, C, 1)) + cod(C2))
                Mid(Sale, C, 1) = Car
            Else
                Mid(Sale, C, 1) = Mid(Texto, C, 1)
            End If
        Next
        Texto = Left(Trim(Sale), Len(Texto))
    End Sub

    Public Sub UnCript()
        Dim c As Integer
        Dim C2 As Integer
        Dim Car As String
        Dim Sale As String
        Dim cod() As Integer
        ReDim cod(10)
        Car = " "
        Sale = Space(255)
        cod(1) = 8
        cod(2) = -4
        cod(3) = 5
        cod(4) = -2
        cod(5) = 4
        cod(6) = -6
        cod(7) = -3
        cod(8) = 3
        cod(9) = 4
        cod(10) = 6

        For c = 1 To Len(Texto)
            C2 = Right(Trim(Str(c)), 1)
            C2 = IIf(C2 = 0, 10, C2)
            If Asc(Mid(Texto, c, 1)) <> 32 Then
                Car = Chr(Asc(Mid(Texto, c, 1)) + (cod(C2) * -1))
                Mid(Sale, c, 1) = Car
            Else
                Mid(Sale, c, 1) = Mid(Texto, c, 1)
            End If
        Next
        Texto = Left(Trim(Sale), Len(Texto))
    End Sub

    Public Sub RegistrarAuditoria()
        Try
            objCe_A.Fecha = Now.Date
            objCe_A.Hora = TimeOfDay
            objCe_A.Accion = Accion
            objCe_A.Usuario = ConsFunc
            obj_Cn_A.NuevoAuditoria(objCe_A)
        Catch ex As Exception
        End Try
    End Sub

    Public Function CalcularEdad(ByVal DiaNacimiento As Integer, ByVal MesNacimiento As Integer, ByVal AñoNacimiento As Integer, ByVal DiaAt As Integer, ByVal MesAt As Integer, ByVal AñoAt As Integer)
        'SE DEFINEN LAS FECHAS ACTUALES
        Dim AñoActual As Integer = AñoAt
        Dim MesActual As Integer = MesAt
        Dim DiaActual As Integer = DiaAt
        Dim Cumplidos As Boolean = False
        'SE COMPRUEBA CUANDO FUE EL ULTIMO CUMPLEAÑOS
        'FORMULA
        'Años cumplidos=(Año del ultimo cumpleaños - Año de nacimiento)
        If (MesNacimiento <= MesActual) Then
            If (DiaNacimiento <= DiaActual) Then
                If (DiaNacimiento = DiaActual) And (MesNacimiento = MesActual) Then
                    ' MsgBox("Feliz Cumpleaños!")
                End If
                'msgbox"Ya cumplió"
                Cumplidos = True
            End If
        End If
        If (Cumplidos = False) Then
            AñoActual = (AñoActual - 1)
            'ultimo cumpleaños: & AñoActual
        End If
        'Se realiza la resta de años para definir los años cumplidos
        Dim EdadAños As Integer = (AñoActual - AñoNacimiento)
        'DEFINICION DE LOS MESES LUEGO DEL ULTIMO CUMPLEAÑOS
        Dim EdadMes As Integer
        If Not (AñoActual = Now.Year) Then
            EdadMes = (12 - MesNacimiento)
            EdadMes = EdadMes + Now.Month
        Else
            EdadMes = Math.Abs(Now.Month - MesNacimiento)
        End If
        'SACAMOS LA CANTIDAD DE DIAS EXACTOS
        Dim EdadDia As Integer = (DiaActual - DiaNacimiento)
        'RETORNAMOS LOS VALORES EN UNA CADENA STRIN
        ' Return EdadAños & " años " & EdadMes & " meses y " & EdadDia & " dias"
        Return EdadAños
    End Function

End Module
