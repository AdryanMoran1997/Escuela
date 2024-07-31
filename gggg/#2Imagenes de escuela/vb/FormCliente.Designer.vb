<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCliente
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCliente))
        Dim CODIGO_CLIENTELabel As System.Windows.Forms.Label
        Dim NOMBRE_CLIENTELabel As System.Windows.Forms.Label
        Dim APELLIDO_CLIENTELabel As System.Windows.Forms.Label
        Dim DIRECCION_CLIENTELabel As System.Windows.Forms.Label
        Dim FECHA_NAC_CLIENTELabel As System.Windows.Forms.Label
        Me.CLIENTEBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.CLIENTEBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CLIENTEDataGridView = New System.Windows.Forms.DataGridView()
        Me.CODIGO_CLIENTETextBox = New System.Windows.Forms.TextBox()
        Me.NOMBRE_CLIENTETextBox = New System.Windows.Forms.TextBox()
        Me.APELLIDO_CLIENTETextBox = New System.Windows.Forms.TextBox()
        Me.DIRECCION_CLIENTETextBox = New System.Windows.Forms.TextBox()
        Me.FECHA_NAC_CLIENTEDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.btnAgregarCliente = New System.Windows.Forms.Button()
        Me.btnModificarCliente = New System.Windows.Forms.Button()
        Me.btnEliminarCliente = New System.Windows.Forms.Button()
        Me.btnBuscarCliente = New System.Windows.Forms.Button()
        Me.btnMostrarCliente = New System.Windows.Forms.Button()
        Me.CLIENTEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Base_datos2DataSet = New base_datos.base_datos2DataSet()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIENTETableAdapter = New base_datos.base_datos2DataSetTableAdapters.CLIENTETableAdapter()
        Me.TableAdapterManager = New base_datos.base_datos2DataSetTableAdapters.TableAdapterManager()
        CODIGO_CLIENTELabel = New System.Windows.Forms.Label()
        NOMBRE_CLIENTELabel = New System.Windows.Forms.Label()
        APELLIDO_CLIENTELabel = New System.Windows.Forms.Label()
        DIRECCION_CLIENTELabel = New System.Windows.Forms.Label()
        FECHA_NAC_CLIENTELabel = New System.Windows.Forms.Label()
        CType(Me.CLIENTEBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CLIENTEBindingNavigator.SuspendLayout()
        CType(Me.CLIENTEDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLIENTEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Base_datos2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CLIENTEBindingNavigator
        '
        Me.CLIENTEBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CLIENTEBindingNavigator.BindingSource = Me.CLIENTEBindingSource
        Me.CLIENTEBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CLIENTEBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CLIENTEBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CLIENTEBindingNavigatorSaveItem})
        Me.CLIENTEBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CLIENTEBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CLIENTEBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CLIENTEBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CLIENTEBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CLIENTEBindingNavigator.Name = "CLIENTEBindingNavigator"
        Me.CLIENTEBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CLIENTEBindingNavigator.Size = New System.Drawing.Size(939, 25)
        Me.CLIENTEBindingNavigator.TabIndex = 0
        Me.CLIENTEBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'CLIENTEBindingNavigatorSaveItem
        '
        Me.CLIENTEBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CLIENTEBindingNavigatorSaveItem.Image = CType(resources.GetObject("CLIENTEBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CLIENTEBindingNavigatorSaveItem.Name = "CLIENTEBindingNavigatorSaveItem"
        Me.CLIENTEBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CLIENTEBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'CLIENTEDataGridView
        '
        Me.CLIENTEDataGridView.AutoGenerateColumns = False
        Me.CLIENTEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CLIENTEDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.CLIENTEDataGridView.DataSource = Me.CLIENTEBindingSource
        Me.CLIENTEDataGridView.Location = New System.Drawing.Point(360, 12)
        Me.CLIENTEDataGridView.Name = "CLIENTEDataGridView"
        Me.CLIENTEDataGridView.Size = New System.Drawing.Size(544, 206)
        Me.CLIENTEDataGridView.TabIndex = 1
        '
        'CODIGO_CLIENTELabel
        '
        CODIGO_CLIENTELabel.AutoSize = True
        CODIGO_CLIENTELabel.Location = New System.Drawing.Point(34, 63)
        CODIGO_CLIENTELabel.Name = "CODIGO_CLIENTELabel"
        CODIGO_CLIENTELabel.Size = New System.Drawing.Size(100, 13)
        CODIGO_CLIENTELabel.TabIndex = 2
        CODIGO_CLIENTELabel.Text = "CODIGO CLIENTE:"
        '
        'CODIGO_CLIENTETextBox
        '
        Me.CODIGO_CLIENTETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTEBindingSource, "CODIGO_CLIENTE", True))
        Me.CODIGO_CLIENTETextBox.Location = New System.Drawing.Point(158, 60)
        Me.CODIGO_CLIENTETextBox.Name = "CODIGO_CLIENTETextBox"
        Me.CODIGO_CLIENTETextBox.Size = New System.Drawing.Size(123, 20)
        Me.CODIGO_CLIENTETextBox.TabIndex = 3
        '
        'NOMBRE_CLIENTELabel
        '
        NOMBRE_CLIENTELabel.AutoSize = True
        NOMBRE_CLIENTELabel.Location = New System.Drawing.Point(34, 89)
        NOMBRE_CLIENTELabel.Name = "NOMBRE_CLIENTELabel"
        NOMBRE_CLIENTELabel.Size = New System.Drawing.Size(105, 13)
        NOMBRE_CLIENTELabel.TabIndex = 4
        NOMBRE_CLIENTELabel.Text = "NOMBRE CLIENTE:"
        '
        'NOMBRE_CLIENTETextBox
        '
        Me.NOMBRE_CLIENTETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTEBindingSource, "NOMBRE_CLIENTE", True))
        Me.NOMBRE_CLIENTETextBox.Location = New System.Drawing.Point(158, 86)
        Me.NOMBRE_CLIENTETextBox.Name = "NOMBRE_CLIENTETextBox"
        Me.NOMBRE_CLIENTETextBox.Size = New System.Drawing.Size(123, 20)
        Me.NOMBRE_CLIENTETextBox.TabIndex = 5
        '
        'APELLIDO_CLIENTELabel
        '
        APELLIDO_CLIENTELabel.AutoSize = True
        APELLIDO_CLIENTELabel.Location = New System.Drawing.Point(34, 115)
        APELLIDO_CLIENTELabel.Name = "APELLIDO_CLIENTELabel"
        APELLIDO_CLIENTELabel.Size = New System.Drawing.Size(110, 13)
        APELLIDO_CLIENTELabel.TabIndex = 6
        APELLIDO_CLIENTELabel.Text = "APELLIDO CLIENTE:"
        '
        'APELLIDO_CLIENTETextBox
        '
        Me.APELLIDO_CLIENTETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTEBindingSource, "APELLIDO_CLIENTE", True))
        Me.APELLIDO_CLIENTETextBox.Location = New System.Drawing.Point(158, 112)
        Me.APELLIDO_CLIENTETextBox.Name = "APELLIDO_CLIENTETextBox"
        Me.APELLIDO_CLIENTETextBox.Size = New System.Drawing.Size(123, 20)
        Me.APELLIDO_CLIENTETextBox.TabIndex = 7
        '
        'DIRECCION_CLIENTELabel
        '
        DIRECCION_CLIENTELabel.AutoSize = True
        DIRECCION_CLIENTELabel.Location = New System.Drawing.Point(34, 141)
        DIRECCION_CLIENTELabel.Name = "DIRECCION_CLIENTELabel"
        DIRECCION_CLIENTELabel.Size = New System.Drawing.Size(117, 13)
        DIRECCION_CLIENTELabel.TabIndex = 8
        DIRECCION_CLIENTELabel.Text = "DIRECCION CLIENTE:"
        '
        'DIRECCION_CLIENTETextBox
        '
        Me.DIRECCION_CLIENTETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTEBindingSource, "DIRECCION_CLIENTE", True))
        Me.DIRECCION_CLIENTETextBox.Location = New System.Drawing.Point(158, 138)
        Me.DIRECCION_CLIENTETextBox.Name = "DIRECCION_CLIENTETextBox"
        Me.DIRECCION_CLIENTETextBox.Size = New System.Drawing.Size(123, 20)
        Me.DIRECCION_CLIENTETextBox.TabIndex = 9
        '
        'FECHA_NAC_CLIENTELabel
        '
        FECHA_NAC_CLIENTELabel.AutoSize = True
        FECHA_NAC_CLIENTELabel.Location = New System.Drawing.Point(34, 168)
        FECHA_NAC_CLIENTELabel.Name = "FECHA_NAC_CLIENTELabel"
        FECHA_NAC_CLIENTELabel.Size = New System.Drawing.Size(118, 13)
        FECHA_NAC_CLIENTELabel.TabIndex = 10
        FECHA_NAC_CLIENTELabel.Text = "FECHA NAC CLIENTE:"
        '
        'FECHA_NAC_CLIENTEDateTimePicker
        '
        Me.FECHA_NAC_CLIENTEDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CLIENTEBindingSource, "FECHA_NAC_CLIENTE", True))
        Me.FECHA_NAC_CLIENTEDateTimePicker.Location = New System.Drawing.Point(158, 164)
        Me.FECHA_NAC_CLIENTEDateTimePicker.Name = "FECHA_NAC_CLIENTEDateTimePicker"
        Me.FECHA_NAC_CLIENTEDateTimePicker.Size = New System.Drawing.Size(123, 20)
        Me.FECHA_NAC_CLIENTEDateTimePicker.TabIndex = 11
        '
        'btnAgregarCliente
        '
        Me.btnAgregarCliente.Location = New System.Drawing.Point(23, 195)
        Me.btnAgregarCliente.Name = "btnAgregarCliente"
        Me.btnAgregarCliente.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregarCliente.TabIndex = 12
        Me.btnAgregarCliente.Text = "AGREGAR"
        Me.btnAgregarCliente.UseVisualStyleBackColor = True
        '
        'btnModificarCliente
        '
        Me.btnModificarCliente.Location = New System.Drawing.Point(104, 195)
        Me.btnModificarCliente.Name = "btnModificarCliente"
        Me.btnModificarCliente.Size = New System.Drawing.Size(75, 23)
        Me.btnModificarCliente.TabIndex = 13
        Me.btnModificarCliente.Text = "MODIFICAR"
        Me.btnModificarCliente.UseVisualStyleBackColor = True
        '
        'btnEliminarCliente
        '
        Me.btnEliminarCliente.Location = New System.Drawing.Point(185, 195)
        Me.btnEliminarCliente.Name = "btnEliminarCliente"
        Me.btnEliminarCliente.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminarCliente.TabIndex = 14
        Me.btnEliminarCliente.Text = "ELIMINAR"
        Me.btnEliminarCliente.UseVisualStyleBackColor = True
        '
        'btnBuscarCliente
        '
        Me.btnBuscarCliente.Location = New System.Drawing.Point(23, 224)
        Me.btnBuscarCliente.Name = "btnBuscarCliente"
        Me.btnBuscarCliente.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscarCliente.TabIndex = 15
        Me.btnBuscarCliente.Text = "BUSCAR"
        Me.btnBuscarCliente.UseVisualStyleBackColor = True
        '
        'btnMostrarCliente
        '
        Me.btnMostrarCliente.Location = New System.Drawing.Point(104, 224)
        Me.btnMostrarCliente.Name = "btnMostrarCliente"
        Me.btnMostrarCliente.Size = New System.Drawing.Size(156, 23)
        Me.btnMostrarCliente.TabIndex = 16
        Me.btnMostrarCliente.Text = "MOSTRAR CLIENTES"
        Me.btnMostrarCliente.UseVisualStyleBackColor = True
        '
        'CLIENTEBindingSource
        '
        Me.CLIENTEBindingSource.DataMember = "CLIENTE"
        Me.CLIENTEBindingSource.DataSource = Me.Base_datos2DataSet
        '
        'Base_datos2DataSet
        '
        Me.Base_datos2DataSet.DataSetName = "base_datos2DataSet"
        Me.Base_datos2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CODIGO_CLIENTE"
        Me.DataGridViewTextBoxColumn1.HeaderText = "CODIGO_CLIENTE"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NOMBRE_CLIENTE"
        Me.DataGridViewTextBoxColumn2.HeaderText = "NOMBRE_CLIENTE"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "APELLIDO_CLIENTE"
        Me.DataGridViewTextBoxColumn3.HeaderText = "APELLIDO_CLIENTE"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "DIRECCION_CLIENTE"
        Me.DataGridViewTextBoxColumn4.HeaderText = "DIRECCION_CLIENTE"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "FECHA_NAC_CLIENTE"
        Me.DataGridViewTextBoxColumn5.HeaderText = "FECHA_NAC_CLIENTE"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'CLIENTETableAdapter
        '
        Me.CLIENTETableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CLIENTETableAdapter = Me.CLIENTETableAdapter
        Me.TableAdapterManager.COMPRATableAdapter = Nothing
        Me.TableAdapterManager.PRODUCTOTableAdapter = Nothing
        Me.TableAdapterManager.PROVEEDORTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = base_datos.base_datos2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(939, 450)
        Me.Controls.Add(Me.btnMostrarCliente)
        Me.Controls.Add(Me.btnBuscarCliente)
        Me.Controls.Add(Me.btnEliminarCliente)
        Me.Controls.Add(Me.btnModificarCliente)
        Me.Controls.Add(Me.btnAgregarCliente)
        Me.Controls.Add(CODIGO_CLIENTELabel)
        Me.Controls.Add(Me.CODIGO_CLIENTETextBox)
        Me.Controls.Add(NOMBRE_CLIENTELabel)
        Me.Controls.Add(Me.NOMBRE_CLIENTETextBox)
        Me.Controls.Add(APELLIDO_CLIENTELabel)
        Me.Controls.Add(Me.APELLIDO_CLIENTETextBox)
        Me.Controls.Add(DIRECCION_CLIENTELabel)
        Me.Controls.Add(Me.DIRECCION_CLIENTETextBox)
        Me.Controls.Add(FECHA_NAC_CLIENTELabel)
        Me.Controls.Add(Me.FECHA_NAC_CLIENTEDateTimePicker)
        Me.Controls.Add(Me.CLIENTEDataGridView)
        Me.Controls.Add(Me.CLIENTEBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.CLIENTEBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CLIENTEBindingNavigator.ResumeLayout(False)
        Me.CLIENTEBindingNavigator.PerformLayout()
        CType(Me.CLIENTEDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLIENTEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Base_datos2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Base_datos2DataSet As base_datos2DataSet
    Friend WithEvents CLIENTEBindingSource As BindingSource
    Friend WithEvents CLIENTETableAdapter As base_datos2DataSetTableAdapters.CLIENTETableAdapter
    Friend WithEvents TableAdapterManager As base_datos2DataSetTableAdapters.TableAdapterManager
    Friend WithEvents CLIENTEBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents CLIENTEBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents CLIENTEDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents CODIGO_CLIENTETextBox As TextBox
    Friend WithEvents NOMBRE_CLIENTETextBox As TextBox
    Friend WithEvents APELLIDO_CLIENTETextBox As TextBox
    Friend WithEvents DIRECCION_CLIENTETextBox As TextBox
    Friend WithEvents FECHA_NAC_CLIENTEDateTimePicker As DateTimePicker
    Friend WithEvents btnAgregarCliente As Button
    Friend WithEvents btnModificarCliente As Button
    Friend WithEvents btnEliminarCliente As Button
    Friend WithEvents btnBuscarCliente As Button
    Friend WithEvents btnMostrarCliente As Button
End Class
