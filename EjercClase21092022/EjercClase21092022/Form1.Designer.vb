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
        Me.components = New System.ComponentModel.Container()
        Me.TxtResultado = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CalculadoraDataSet = New EjercClase21092022.CalculadoraDataSet()
        Me.TResultadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TResultadoTableAdapter = New EjercClase21092022.CalculadoraDataSetTableAdapters.TResultadoTableAdapter()
        Me.ResultadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CalculadoraDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TResultadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtResultado
        '
        Me.TxtResultado.Location = New System.Drawing.Point(21, 23)
        Me.TxtResultado.Name = "TxtResultado"
        Me.TxtResultado.Size = New System.Drawing.Size(238, 22)
        Me.TxtResultado.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(21, 72)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(68, 40)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "7"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(106, 72)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(68, 40)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "8"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(191, 72)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(68, 40)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "9"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(274, 72)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(68, 40)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "-"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(274, 135)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(68, 40)
        Me.Button5.TabIndex = 8
        Me.Button5.Text = "*"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(191, 135)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(68, 40)
        Me.Button6.TabIndex = 7
        Me.Button6.Text = "6"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(106, 135)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(68, 40)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "5"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(21, 135)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(68, 40)
        Me.Button8.TabIndex = 5
        Me.Button8.Text = "4"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(274, 197)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(68, 40)
        Me.Button9.TabIndex = 12
        Me.Button9.Text = "/"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(191, 197)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(68, 40)
        Me.Button10.TabIndex = 11
        Me.Button10.Text = "3"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(106, 197)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(68, 40)
        Me.Button11.TabIndex = 10
        Me.Button11.Text = "2"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(21, 197)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(68, 40)
        Me.Button12.TabIndex = 9
        Me.Button12.Text = "1"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.Location = New System.Drawing.Point(274, 254)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(68, 40)
        Me.Button13.TabIndex = 16
        Me.Button13.Text = "C"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Button14
        '
        Me.Button14.Location = New System.Drawing.Point(191, 254)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(68, 40)
        Me.Button14.TabIndex = 15
        Me.Button14.Text = "="
        Me.Button14.UseVisualStyleBackColor = True
        '
        'Button15
        '
        Me.Button15.Location = New System.Drawing.Point(106, 254)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(68, 40)
        Me.Button15.TabIndex = 14
        Me.Button15.Text = "."
        Me.Button15.UseVisualStyleBackColor = True
        '
        'Button16
        '
        Me.Button16.Location = New System.Drawing.Point(21, 254)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(68, 40)
        Me.Button16.TabIndex = 13
        Me.Button16.Text = "0"
        Me.Button16.UseVisualStyleBackColor = True
        '
        'Button17
        '
        Me.Button17.Location = New System.Drawing.Point(274, 14)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(68, 40)
        Me.Button17.TabIndex = 17
        Me.Button17.Text = "+"
        Me.Button17.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ResultadoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TResultadoBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(366, 23)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(188, 286)
        Me.DataGridView1.TabIndex = 18
        '
        'CalculadoraDataSet
        '
        Me.CalculadoraDataSet.DataSetName = "CalculadoraDataSet"
        Me.CalculadoraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TResultadoBindingSource
        '
        Me.TResultadoBindingSource.DataMember = "TResultado"
        Me.TResultadoBindingSource.DataSource = Me.CalculadoraDataSet
        '
        'TResultadoTableAdapter
        '
        Me.TResultadoTableAdapter.ClearBeforeFill = True
        '
        'ResultadoDataGridViewTextBoxColumn
        '
        Me.ResultadoDataGridViewTextBoxColumn.DataPropertyName = "Resultado"
        Me.ResultadoDataGridViewTextBoxColumn.HeaderText = "Resultado"
        Me.ResultadoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ResultadoDataGridViewTextBoxColumn.Name = "ResultadoDataGridViewTextBoxColumn"
        Me.ResultadoDataGridViewTextBoxColumn.Width = 125
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(613, 337)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button17)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.Button14)
        Me.Controls.Add(Me.Button15)
        Me.Controls.Add(Me.Button16)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TxtResultado)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CalculadoraDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TResultadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtResultado As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents Button16 As Button
    Friend WithEvents Button17 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CalculadoraDataSet As CalculadoraDataSet
    Friend WithEvents TResultadoBindingSource As BindingSource
    Friend WithEvents TResultadoTableAdapter As CalculadoraDataSetTableAdapters.TResultadoTableAdapter
    Friend WithEvents ResultadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
