Public Class FormCliente
    Private Sub CLIENTEBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CLIENTEBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CLIENTEBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Base_datos2DataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Base_datos2DataSet.CLIENTE' Puede moverla o quitarla según sea necesario.
        Me.CLIENTETableAdapter.Fill(Me.Base_datos2DataSet.CLIENTE)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAgregarCliente.Click
        Me.CLIENTETableAdapter.AgregarCliente(CODIGO_CLIENTETextBox.Text, NOMBRE_CLIENTETextBox.Text, APELLIDO_CLIENTETextBox.Text, DIRECCION_CLIENTETextBox.Text, FECHA_NAC_CLIENTEDateTimePicker.Value)
        Me.CLIENTETableAdapter.Fill(Me.Base_datos2DataSet.CLIENTE)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnModificarCliente.Click
        Me.CLIENTETableAdapter.ModificarCliente(CODIGO_CLIENTETextBox.Text, NOMBRE_CLIENTETextBox.Text, APELLIDO_CLIENTETextBox.Text, DIRECCION_CLIENTETextBox.Text, FECHA_NAC_CLIENTEDateTimePicker.Value, CODIGO_CLIENTETextBox.Text)
        Me.CLIENTETableAdapter.Fill(Me.Base_datos2DataSet.CLIENTE)
    End Sub

    Private Sub btnEliminarCliente_Click(sender As Object, e As EventArgs) Handles btnEliminarCliente.Click
        Me.CLIENTETableAdapter.EliminarCliente(CODIGO_CLIENTETextBox.Text)
        Me.CLIENTETableAdapter.Fill(Me.Base_datos2DataSet.CLIENTE)
    End Sub

    Private Sub btnBuscarCliente_Click(sender As Object, e As EventArgs) Handles btnBuscarCliente.Click
        Me.CLIENTETableAdapter.BuscarCliente(Base_datos2DataSet.CLIENTE, CODIGO_CLIENTETextBox.Text)
    End Sub

    Private Sub btnMostrarCliente_Click(sender As Object, e As EventArgs) Handles btnMostrarCliente.Click
        Me.CLIENTETableAdapter.Fill(Me.Base_datos2DataSet.CLIENTE)
    End Sub
End Class
