Public Class Portada
    Private Usuario As String
    Private id As String
    'Permisos del Usuario
    'en portada
    Private clientes As Boolean
    Private proveedores As Boolean
    Private ventas As Boolean
    'productos
    'Private eliminar_productos As Boolean

    Public Sub New(ByVal _Usuario As String, ByVal _id As String, ByVal _clientes As Boolean, ByVal _proveedores As Boolean, ByVal _ventas As Boolean)
        InitializeComponent()
        Usuario = _Usuario
        'portada
        clientes = _clientes
        proveedores = _proveedores
        ventas = _ventas
        id = _id
        'PRODUCTOS
        'eliminar_productos = _eliminar_productos


    End Sub
    Private Sub Portada_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            BtnProveedor.Enabled = proveedores
            BtnCliente.Enabled = clientes
            BtnVentas.Enabled = ventas

            'para ganar velocidad conecto y desconecto
            Call conectar()
            conexion.Open()
            conexion.Close()
        Catch ex As Exception
            'si hay error muestro el mensaje
            MsgBox(ex.Message)
            conexion.Close()
        End Try
        
    End Sub
    Private Sub BtnCliente_Click(sender As Object, e As EventArgs) Handles BtnCliente.Click
        Me.Panelcontenedor.Controls.Clear()
        Dim fr As New FrmClientes
        fr.TopLevel = False
        fr.Show()
        Panelcontenedor.Controls.Add(fr)
    End Sub

    Private Sub BtnProductos_Click(sender As Object, e As EventArgs) Handles BtnProductos.Click

        Me.Panelcontenedor.Controls.Clear()

        'Dim productos As New Productos(eliminar_productos)

        Dim frProductos As New Productos
        frProductos.TopLevel = False
        frProductos.Show()
        Panelcontenedor.Controls.Add(frProductos)
    End Sub

    Private Sub BtnVentas_Click(sender As Object, e As EventArgs) Handles BtnVentas.Click
        Me.Panelcontenedor.Controls.Clear()

        Dim frventas As New Ventas
        'Dim id As New Ventas(id)
        frventas.TopLevel = False
        frventas.Show()
        Panelcontenedor.Controls.Add(frventas)
    End Sub

    Private Sub BtnProveedor_Click(sender As Object, e As EventArgs) Handles BtnProveedor.Click
        Me.Panelcontenedor.Controls.Clear()

        Dim frm As New Proveedor
        frm.TopLevel = False
        frm.Show()
        Panelcontenedor.Controls.Add(frm)
    End Sub

    Private Sub Panelcontenedor_Paint(sender As Object, e As PaintEventArgs) Handles Panelcontenedor.Paint

    End Sub


    Private Sub PanelMenu_Paint(sender As Object, e As PaintEventArgs) Handles PanelMenu.Paint

    End Sub
End Class