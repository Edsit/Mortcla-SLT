Imports C_Entidad
Imports C_Datos
Public Class Cn_Almacenes
    Dim objCd_A As New Cd_Almacenes

    Sub NuevoAlmacen(ByVal obj As Ce_Almacenes)
        objCd_A.NuevoAlmacen(obj)
    End Sub

    Sub ModificarAlmacen(ByVal obj As Ce_Almacenes)
        objCd_A.ModificarAlmacen(obj)
    End Sub

    Sub EliminarAlmacen(ByVal obj As Ce_Almacenes)
        objCd_A.EliminarAlmacen(obj)
    End Sub

    Function ListarAlmacenes() As DataSet
        Return objCd_A.ListarAlmacenes
    End Function

    Function ListarAlmacenesActivos() As DataSet
        Return objCd_A.ListarAlmacenesActivos()
    End Function

    Function ExisteAlmacen(ByVal obj As Ce_Almacenes) As DataSet
        Return objCd_A.ExisteAlmacene(obj)
    End Function

    Function ListarAlmacenesActivosFunc(ByVal obj As Ce_AlmacenFunc) As DataSet
        Return objCd_A.ListarAlmacenesActivosFunc(obj)
    End Function

    Function ListarAlmacenesRotacion(ByVal obj As Ce_Almacenes) As DataSet
        Return objCd_A.ListarAlmacenesRotacion(obj)
    End Function

    Function VerResponsable(ByVal obj As Ce_Almacenes) As DataSet
        Return objCd_A.VerResponsable(obj)
    End Function

    Function VerDatosTraslado(ByVal obj As Ce_Almacenes) As DataSet
        Return objCd_A.VerDatosTraslado(obj)
    End Function

    Function ListarAlmacenesActivosSede(ByVal obj As Ce_Almacenes) As DataSet
        Return objCd_A.ListarAlmacenesActivosSede(obj)
    End Function
End Class
