<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
	Inherits System.Windows.Forms.Form

	'Form reemplaza a Dispose para limpiar la lista de componentes.
	<System.Diagnostics.DebuggerNonUserCode()>
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
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.lbEntrada = New System.Windows.Forms.ListBox()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.btnAgregar = New System.Windows.Forms.Button()
		Me.btnVaciar = New System.Windows.Forms.Button()
		Me.btnBurbuja = New System.Windows.Forms.Button()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.btnBidireccional = New System.Windows.Forms.Button()
		Me.btnSeleccion = New System.Windows.Forms.Button()
		Me.btnInsercioon = New System.Windows.Forms.Button()
		Me.btnMezcla = New System.Windows.Forms.Button()
		Me.btnQuick = New System.Windows.Forms.Button()
		Me.nudValor = New System.Windows.Forms.NumericUpDown()
		Me.nudVelocidad = New System.Windows.Forms.NumericUpDown()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.lbSalida = New System.Windows.Forms.ListBox()
		Me.GroupBox1.SuspendLayout()
		Me.GroupBox2.SuspendLayout()
		CType(Me.nudValor, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudVelocidad, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel1.SuspendLayout()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(40, 27)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(70, 25)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Valor:"
		'
		'lbEntrada
		'
		Me.lbEntrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbEntrada.FormattingEnabled = True
		Me.lbEntrada.ItemHeight = 22
		Me.lbEntrada.Location = New System.Drawing.Point(16, 29)
		Me.lbEntrada.Name = "lbEntrada"
		Me.lbEntrada.Size = New System.Drawing.Size(178, 246)
		Me.lbEntrada.TabIndex = 3
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.lbEntrada)
		Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
		Me.GroupBox1.Location = New System.Drawing.Point(45, 75)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(210, 287)
		Me.GroupBox1.TabIndex = 4
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Lista de valores"
		'
		'btnAgregar
		'
		Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
		Me.btnAgregar.Location = New System.Drawing.Point(242, 19)
		Me.btnAgregar.Name = "btnAgregar"
		Me.btnAgregar.Size = New System.Drawing.Size(43, 41)
		Me.btnAgregar.TabIndex = 5
		Me.btnAgregar.Text = "+"
		Me.btnAgregar.UseVisualStyleBackColor = True
		'
		'btnVaciar
		'
		Me.btnVaciar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
		Me.btnVaciar.Location = New System.Drawing.Point(291, 19)
		Me.btnVaciar.Name = "btnVaciar"
		Me.btnVaciar.Size = New System.Drawing.Size(43, 41)
		Me.btnVaciar.TabIndex = 6
		Me.btnVaciar.Text = "[]"
		Me.btnVaciar.UseVisualStyleBackColor = True
		'
		'btnBurbuja
		'
		Me.btnBurbuja.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
		Me.btnBurbuja.Location = New System.Drawing.Point(22, 44)
		Me.btnBurbuja.Name = "btnBurbuja"
		Me.btnBurbuja.Size = New System.Drawing.Size(168, 41)
		Me.btnBurbuja.TabIndex = 7
		Me.btnBurbuja.Text = "Burbuja"
		Me.btnBurbuja.UseVisualStyleBackColor = True
		'
		'GroupBox2
		'
		Me.GroupBox2.Controls.Add(Me.btnQuick)
		Me.GroupBox2.Controls.Add(Me.btnMezcla)
		Me.GroupBox2.Controls.Add(Me.btnInsercioon)
		Me.GroupBox2.Controls.Add(Me.btnSeleccion)
		Me.GroupBox2.Controls.Add(Me.btnBidireccional)
		Me.GroupBox2.Controls.Add(Me.btnBurbuja)
		Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
		Me.GroupBox2.Location = New System.Drawing.Point(261, 93)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(401, 203)
		Me.GroupBox2.TabIndex = 8
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = " Metodos de ordenamiento"
		'
		'btnBidireccional
		'
		Me.btnBidireccional.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
		Me.btnBidireccional.Location = New System.Drawing.Point(197, 44)
		Me.btnBidireccional.Name = "btnBidireccional"
		Me.btnBidireccional.Size = New System.Drawing.Size(168, 41)
		Me.btnBidireccional.TabIndex = 8
		Me.btnBidireccional.Text = "B. bidireccional"
		Me.btnBidireccional.UseVisualStyleBackColor = True
		'
		'btnSeleccion
		'
		Me.btnSeleccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
		Me.btnSeleccion.Location = New System.Drawing.Point(22, 148)
		Me.btnSeleccion.Name = "btnSeleccion"
		Me.btnSeleccion.Size = New System.Drawing.Size(168, 41)
		Me.btnSeleccion.TabIndex = 9
		Me.btnSeleccion.Text = "Selección"
		Me.btnSeleccion.UseVisualStyleBackColor = True
		'
		'btnInsercioon
		'
		Me.btnInsercioon.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
		Me.btnInsercioon.Location = New System.Drawing.Point(197, 96)
		Me.btnInsercioon.Name = "btnInsercioon"
		Me.btnInsercioon.Size = New System.Drawing.Size(168, 41)
		Me.btnInsercioon.TabIndex = 10
		Me.btnInsercioon.Text = "Inserción"
		Me.btnInsercioon.UseVisualStyleBackColor = True
		'
		'btnMezcla
		'
		Me.btnMezcla.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
		Me.btnMezcla.Location = New System.Drawing.Point(22, 96)
		Me.btnMezcla.Name = "btnMezcla"
		Me.btnMezcla.Size = New System.Drawing.Size(168, 41)
		Me.btnMezcla.TabIndex = 11
		Me.btnMezcla.Text = "Mezcla"
		Me.btnMezcla.UseVisualStyleBackColor = True
		'
		'btnQuick
		'
		Me.btnQuick.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
		Me.btnQuick.Location = New System.Drawing.Point(197, 148)
		Me.btnQuick.Name = "btnQuick"
		Me.btnQuick.Size = New System.Drawing.Size(168, 41)
		Me.btnQuick.TabIndex = 12
		Me.btnQuick.Text = "Quicksort"
		Me.btnQuick.UseVisualStyleBackColor = True
		'
		'nudValor
		'
		Me.nudValor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
		Me.nudValor.Location = New System.Drawing.Point(116, 25)
		Me.nudValor.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
		Me.nudValor.Minimum = New Decimal(New Integer() {999, 0, 0, -2147483648})
		Me.nudValor.Name = "nudValor"
		Me.nudValor.Size = New System.Drawing.Size(120, 30)
		Me.nudValor.TabIndex = 2
		'
		'nudVelocidad
		'
		Me.nudVelocidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
		Me.nudVelocidad.Increment = New Decimal(New Integer() {500, 0, 0, 0})
		Me.nudVelocidad.Location = New System.Drawing.Point(394, 320)
		Me.nudVelocidad.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
		Me.nudVelocidad.Minimum = New Decimal(New Integer() {100, 0, 0, 0})
		Me.nudVelocidad.Name = "nudVelocidad"
		Me.nudVelocidad.Size = New System.Drawing.Size(120, 30)
		Me.nudVelocidad.TabIndex = 10
		Me.nudVelocidad.Value = New Decimal(New Integer() {100, 0, 0, 0})
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(273, 322)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(115, 25)
		Me.Label2.TabIndex = 9
		Me.Label2.Text = "Velocidad:"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(520, 322)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(129, 25)
		Me.Label3.TabIndex = 11
		Me.Label3.Text = "ms/iteracion"
		'
		'Panel1
		'
		Me.Panel1.Controls.Add(Me.lbSalida)
		Me.Panel1.Location = New System.Drawing.Point(15, 372)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(629, 360)
		Me.Panel1.TabIndex = 12
		'
		'lbSalida
		'
		Me.lbSalida.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbSalida.FormattingEnabled = True
		Me.lbSalida.ItemHeight = 22
		Me.lbSalida.Location = New System.Drawing.Point(30, 22)
		Me.lbSalida.Name = "lbSalida"
		Me.lbSalida.Size = New System.Drawing.Size(194, 246)
		Me.lbSalida.TabIndex = 4
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(670, 740)
		Me.Controls.Add(Me.Panel1)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.nudVelocidad)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.GroupBox2)
		Me.Controls.Add(Me.btnVaciar)
		Me.Controls.Add(Me.btnAgregar)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.nudValor)
		Me.Controls.Add(Me.Label1)
		Me.Name = "Form1"
		Me.Text = "Form1"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox2.ResumeLayout(False)
		CType(Me.nudValor, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudVelocidad, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents lbEntrada As ListBox
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents btnAgregar As Button
	Friend WithEvents btnVaciar As Button
	Friend WithEvents btnBurbuja As Button
	Friend WithEvents GroupBox2 As GroupBox
	Friend WithEvents btnQuick As Button
	Friend WithEvents btnMezcla As Button
	Friend WithEvents btnInsercioon As Button
	Friend WithEvents btnSeleccion As Button
	Friend WithEvents btnBidireccional As Button
	Friend WithEvents nudValor As NumericUpDown
	Friend WithEvents nudVelocidad As NumericUpDown
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Panel1 As Panel
	Friend WithEvents lbSalida As ListBox
End Class
