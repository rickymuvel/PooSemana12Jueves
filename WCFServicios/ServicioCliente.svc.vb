' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "ServicioCliente" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServicioCliente.svc o ServicioCliente.svc.vb en el Explorador de soluciones e inicie la depuración.
Imports System.Data.SqlClient

Public Class ServicioCliente
    Implements IServicioCliente
    ' solo presionamos enter.
    Dim cn As New SqlConnection("Data Source=localhost;Initial Catalog=Negocios2015;UID=sa;PWD=sql")


    Public Function ClienteListar() As DataSet Implements IServicioCliente.ClienteListar
        Dim da As New SqlDataAdapter("usp_ClienteListadoWCF", cn)
        Dim ds As New DataSet
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.Fill(ds)
        Return ds
    End Function

    Public Function PedidosCliente(idcli As String) As DataSet Implements IServicioCliente.PedidosCliente
        Dim da As New SqlDataAdapter("usp_PedidosClienteWCF", cn)
        Dim ds As New DataSet
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.SelectCommand.Parameters.AddWithValue("@IdCliente", idcli)
        da.Fill(ds)
        Return ds
    End Function
End Class
