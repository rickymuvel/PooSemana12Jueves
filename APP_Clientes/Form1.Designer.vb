<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboClientes = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgPedidos = New System.Windows.Forms.DataGridView()
        CType(Me.dgPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(99, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(390, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CONSULTA DE PEDIDOS POR CLIENTE"
        '
        'cboClientes
        '
        Me.cboClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboClientes.FormattingEnabled = True
        Me.cboClientes.Location = New System.Drawing.Point(69, 75)
        Me.cboClientes.Name = "cboClientes"
        Me.cboClientes.Size = New System.Drawing.Size(248, 21)
        Me.cboClientes.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Cliente"
        '
        'dgPedidos
        '
        Me.dgPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPedidos.Location = New System.Drawing.Point(27, 120)
        Me.dgPedidos.Name = "dgPedidos"
        Me.dgPedidos.Size = New System.Drawing.Size(515, 195)
        Me.dgPedidos.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 349)
        Me.Controls.Add(Me.dgPedidos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboClientes)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboClientes As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgPedidos As System.Windows.Forms.DataGridView

End Class
