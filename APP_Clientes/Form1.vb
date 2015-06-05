Imports APP_Clientes.ServiceClientes

Public Class Form1
    Dim servicio As New ServicioClienteClient


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboClientes.DataSource = servicio.ClienteListar.Tables(0)
        cboClientes.DisplayMember = "nomCliente"
        cboClientes.ValueMember = "idCliente"

        'dgPedidos.DataSource = servicio.ProductoListar.Tables(0)
        'dgPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub cboClientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboClientes.SelectedIndexChanged
        Try
            Dim idcli As String = cboClientes.SelectedValue.ToString
            dgPedidos.DataSource = servicio.PedidosCliente(idcli).Tables(0)
            dgPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
        Catch ex As Exception

        End Try
    End Sub
End Class
