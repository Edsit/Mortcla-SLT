Imports C_Entidad
Imports C_Datos
Public Class Cn_Alm_Lotes
    Dim objCd_L As New Cd_Alm_Lotes

    Sub NuevoLote(ByVal obj As Ce_Alm_Lotes)
        objCd_L.NuevoLote(obj)
    End Sub

    Sub ModificarLote(ByVal obj As Ce_Alm_Lotes)
        objCd_L.ModificarLote(obj)
    End Sub

    Sub ModificarCantIniLote(ByVal obj As Ce_Alm_Lotes)
        objCd_L.ModificarCantIniLote(obj)
    End Sub

    Sub EliminarLote(ByVal obj As Ce_Alm_Lotes)
        objCd_L.EliminarLote(obj)
    End Sub

    Function ListarLotesProd(ByVal obj As Ce_Alm_Lotes) As DataSet
        Return objCd_L.ListarLotesProd(obj)
    End Function

    Function ExisteLote(ByVal obj As Ce_Alm_Lotes) As DataSet
        Return objCd_L.ExisteLote(obj)
    End Function

    Function ListarDatosLotes(ByVal obj As Ce_Alm_Lotes) As DataSet
        Return objCd_L.ListarDatosLotes(obj)
    End Function

    Function ListarLotesMedKardex(ByVal obj As Ce_Alm_Lotes, obj1 As Ce_Alm_Productos) As DataSet
        Return objCd_L.ListarLotesMedKardex(obj, obj1)
    End Function

    Function ListarLotesMQKardex(ByVal obj As Ce_Alm_Lotes, obj1 As Ce_Alm_Productos) As DataSet
        Return objCd_L.ListarLotesMQKardex(obj, obj1)
    End Function

    Function ListarLotesMedKardexCierre(ByVal obj As Ce_Alm_Lotes, obj1 As Ce_Alm_Productos) As DataSet
        Return objCd_L.ListarLotesMedKardexCierre(obj, obj1)
    End Function

    Function ListarLotesMQKardexCierre(ByVal obj As Ce_Alm_Lotes, obj1 As Ce_Alm_Productos) As DataSet
        Return objCd_L.ListarLotesMQKardexCierre(obj, obj1)
    End Function

    Function LoadMedLotesVence(ByVal obj As Ce_Alm_Lotes) As DataSet
        Return objCd_L.LoadMedLotesVence(obj)
    End Function

    Function VerLotesArreglar(ByVal obj As Ce_Alm_Lotes) As DataSet
        Return objCd_L.VerLotesArreglar(obj)
    End Function

    Function VerLotesBuenoArreglar(ByVal obj As Ce_Alm_Lotes) As DataSet
        Return objCd_L.VerLotesBuenoArreglar(obj)
    End Function

    Sub ActualziarLoteMalosAbril(ByVal obj As Ce_Alm_Lotes)
        objCd_L.ActualziarLoteMalosAbril(obj)
    End Sub

    Function VerIniLote(ByVal obj As Ce_Alm_Lotes) As DataSet
        Return objCd_L.VerIniLote(obj)
    End Function

    Function ValorInicialCentroCostos(ByVal obj As Ce_Alm_Lotes) As DataSet
        Return objCd_L.ValorInicialCentroCostos(obj)
    End Function

    Function ValorEntradasCentroCostos(ByVal obj As Ce_Alm_Entradas, obj1 As Ce_Alm_Productos) As DataSet
        Return objCd_L.ValorEntradasCentroCostos(obj, obj1)
    End Function

    Function ValorsALIDASCentroCostos(ByVal obj As Ce_Alm_Salidas, obj1 As Ce_Alm_Productos) As DataSet
        Return objCd_L.ValorSalidasCentroCostos(obj, obj1)
    End Function

    Function SeeLotes(ByVal obj As Ce_Alm_Lotes) As DataSet
        Return objCd_L.SeeLotes(obj)
    End Function

    Function SeeLotesRescate(ByVal obj As Ce_Alm_Lotes) As DataSet
        Return objCd_L.SeeLotesRescate(obj)
    End Function

    Function SeeLotesAnterior(ByVal obj As Ce_Alm_Lotes) As DataSet
        Return objCd_L.SeeLoteAnterior(obj)
    End Function

    Function SeeLoteRescate(ByVal obj As Ce_Alm_Lotes) As DataSet
        Return objCd_L.SeeLoteRescate(obj)
    End Function

    Function RescateLoteAnt(ByVal obj As Ce_Alm_Lotes) As DataSet
        Return objCd_L.RescateLoteAnt(obj)
    End Function

    Function ListarLotesNuevoCierre(ByVal obj As Ce_Alm_Lotes) As DataSet
        Return objCd_L.ListarLotesNuevoCierre(obj)
    End Function

    Function ListarLotesInventMovimientos(ByVal obj As Ce_Alm_Lotes, obj1 As Ce_Alm_Productos) As DataSet
        Return objCd_L.ListarLotesInventMovimientos(obj, obj1)
    End Function
End Class
