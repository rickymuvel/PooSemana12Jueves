' ESTA ES LA INTERFACE
Imports System.ServiceModel
Imports System.Data.SqlClient

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "IServicioCliente" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface IServicioCliente


    <OperationContract()>
    Function ClienteListar() As DataSet

    <OperationContract()>
    Function PedidosCliente(idcli As String) As DataSet
    ' estos son los métodos que vamos a implementar en el servicio.

    <OperationContract()>
    Function ProductoListar() As DataSet


End Interface
