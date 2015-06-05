Imports APP_Clientes.ServiceClientes

Public Class Form1
    Dim servicio As New ServicioClienteClient


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboClientes.DataSource = servicio.ClienteListar.Tables(0)
        cboClientes.DisplayMember = "nomCliente"
        cboClientes.ValueMember = "idCliente"
    End Sub
End Class
