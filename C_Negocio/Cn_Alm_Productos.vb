Imports C_Entidad
Imports C_Datos
Public Class Cn_Alm_Productos
    Dim objCd_P As New Cd_Alm_Productos

    Sub NuevoProducto(ByVal obj As Ce_Alm_Productos)
        objCd_P.NuevoProducto(obj)
    End Sub

    Sub ModificarProducto(ByVal obj As Ce_Alm_Productos)
        objCd_P.ModificarProducto(obj)
    End Sub

    Sub EliminarProducto(ByVal obj As Ce_Alm_Productos)
        objCd_P.EliminarProducto(obj)
    End Sub

    Function ListarTodosProductos() As DataSet
        Return objCd_P.LitarTodosProductos
    End Function

    Function ListarTipoProductos(ByVal obj As Ce_Alm_Productos) As DataSet
        Return objCd_P.LitarTipoProductos(obj)
    End Function

    Function FiltrarTodosProductosDescrip(ByVal obj As Ce_Alm_Productos) As DataSet
        Return objCd_P.FiltrarTodosProductosDescrip(obj)
    End Function

    Function FiltrarTipoProductosDescrip(ByVal obj As Ce_Alm_Productos) As DataSet
        Return objCd_P.FiltrarTipoProductosDescrip(obj)
    End Function

    Function LitarProductosCons(ByVal obj As Ce_Alm_Productos) As DataSet
        Return objCd_P.LitarProductosCons(obj)
    End Function

    Function LitarProductosSimilar(ByVal obj As Ce_Alm_Productos) As DataSet
        Return objCd_P.LitarProductosSimilar(obj)
    End Function

    Function LoadDatosProd(ByVal obj As Ce_Alm_Productos) As DataSet
        Return objCd_P.LoadDatosProd(obj)
    End Function

    Function LoadDatosProdMedKardex(ByVal obj As Ce_Alm_Productos) As DataSet
        Return objCd_P.LoadDatosProdMedKardex(obj)

    End Function
End Class
