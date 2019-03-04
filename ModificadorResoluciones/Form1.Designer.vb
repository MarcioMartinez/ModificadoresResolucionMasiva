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
        Me.components = New System.ComponentModel.Container()
        Me.FlpResoluciones = New System.Windows.Forms.FlowLayoutPanel()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CboFormato = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PbImagen = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CboResolucionesAlmacenadas = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PbImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FlpResoluciones
        '
        Me.FlpResoluciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlpResoluciones.AutoScroll = True
        Me.FlpResoluciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FlpResoluciones.Location = New System.Drawing.Point(191, 9)
        Me.FlpResoluciones.Name = "FlpResoluciones"
        Me.FlpResoluciones.Size = New System.Drawing.Size(380, 443)
        Me.FlpResoluciones.TabIndex = 3
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button2
        '
        Me.Button2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(191, 458)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(380, 32)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "CAMBIAR RESOLUCIÓN"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.CboResolucionesAlmacenadas)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TxtNombre)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.CboFormato)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.PbImagen)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(185, 499)
        Me.Panel1.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 277)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Nombre Nueva Imagen"
        '
        'TxtNombre
        '
        Me.TxtNombre.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre.Location = New System.Drawing.Point(7, 293)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(173, 27)
        Me.TxtNombre.TabIndex = 13
        Me.TxtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 328)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Formato"
        '
        'CboFormato
        '
        Me.CboFormato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboFormato.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.CboFormato.FormattingEnabled = True
        Me.CboFormato.Items.AddRange(New Object() {"PNG", "JPEG", "ICON", "GIF", "BMP"})
        Me.CboFormato.Location = New System.Drawing.Point(7, 344)
        Me.CboFormato.Name = "CboFormato"
        Me.CboFormato.Size = New System.Drawing.Size(173, 27)
        Me.CboFormato.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(7, 232)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(173, 32)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "SELECCIONAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PbImagen
        '
        Me.PbImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PbImagen.Location = New System.Drawing.Point(7, 56)
        Me.PbImagen.Name = "PbImagen"
        Me.PbImagen.Size = New System.Drawing.Size(173, 170)
        Me.PbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PbImagen.TabIndex = 9
        Me.PbImagen.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Cantidad de Resoluciones"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(7, 23)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(173, 27)
        Me.TextBox1.TabIndex = 7
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(4, 378)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(159, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Resoluciones almacenadas"
        '
        'CboResolucionesAlmacenadas
        '
        Me.CboResolucionesAlmacenadas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboResolucionesAlmacenadas.DropDownWidth = 400
        Me.CboResolucionesAlmacenadas.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.CboResolucionesAlmacenadas.FormattingEnabled = True
        Me.CboResolucionesAlmacenadas.Items.AddRange(New Object() {"PNG", "JPEG", "ICON", "GIF", "BMP"})
        Me.CboResolucionesAlmacenadas.Location = New System.Drawing.Point(7, 394)
        Me.CboResolucionesAlmacenadas.Name = "CboResolucionesAlmacenadas"
        Me.CboResolucionesAlmacenadas.Size = New System.Drawing.Size(133, 27)
        Me.CboResolucionesAlmacenadas.TabIndex = 15
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(146, 394)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(34, 27)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "X"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(578, 499)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.FlpResoluciones)
        Me.MinimumSize = New System.Drawing.Size(594, 338)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificador Resoluciones 2019"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PbImagen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FlpResoluciones As FlowLayoutPanel
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents PbImagen As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents CboFormato As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CboResolucionesAlmacenadas As ComboBox
    Friend WithEvents Button3 As Button
End Class
