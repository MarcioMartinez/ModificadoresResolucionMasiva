' DESARROLLADO POR MARCIO FRANCISCO MARTINEZ OCHOA
' CORREO: marciomartinez500@gmail.com
Public Class Form1
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim cantidad As Integer = 0
        Dim controles As New List(Of Control)

        If CType(sender, TextBox).Text.Trim <> "" Then
            cantidad = CInt(CType(sender, TextBox).Text)
        End If

        For Each control As Control In FlpResoluciones.Controls
            controles.Add(control)
        Next

        For Each control As Control In controles
            FlpResoluciones.Controls.Remove(control)
            control.Dispose()
        Next

        For i As Integer = 0 To cantidad - 1

            Dim _TextBox1, _TextBox2 As New TextBox
            Dim _GroupBox As New GroupBox

            _TextBox1.Location = New Point(14, 15)
            _TextBox1.Name = $"Txt1Resolucion{i + 1}"
            _TextBox1.Size = New Size(71, 20)
            _TextBox1.Text = "Ancho"
            _TextBox1.ForeColor = Color.Gray

            _TextBox2.Location = New System.Drawing.Point(91, 15)
            _TextBox2.Name = $"Txt2Resolucion{i + 1}"
            _TextBox2.Size = New Size(71, 20)
            _TextBox2.Text = "Alto"
            _TextBox2.ForeColor = Color.Gray


            AddHandler _TextBox1.KeyPress, AddressOf Evento_KeyPress
            AddHandler _TextBox2.KeyPress, AddressOf Evento_KeyPress
            AddHandler _TextBox1.TextChanged, AddressOf Evento_TextChanged
            AddHandler _TextBox2.TextChanged, AddressOf Evento_TextChanged
            AddHandler _TextBox1.GotFocus, AddressOf Evento_GotFocus
            AddHandler _TextBox2.GotFocus, AddressOf Evento2_GotFocus
            AddHandler _TextBox1.LostFocus, AddressOf Evento_LostFocus
            AddHandler _TextBox2.LostFocus, AddressOf Evento2_LostFocus

            _GroupBox.Controls.Add(_TextBox1)
            _GroupBox.Controls.Add(_TextBox2)
            _GroupBox.Location = New Point(3, 3)
            _GroupBox.Name = $"Resolucion{i + 1}"
            _GroupBox.Size = New Size(173, 45)
            _GroupBox.Font = New Font("Tahoma", 8.25!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            _GroupBox.TabStop = False
            _GroupBox.Text = $"Resolución #{i + 1}"

            FlpResoluciones.Controls.Add(_GroupBox)

        Next
    End Sub

    Private Sub Evento_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8)
    End Sub
    Private Sub Evento_TextChanged(sender As Object, e As EventArgs)
        If CType(sender, TextBox).Text.Trim = "Ancho" Or CType(sender, TextBox).Text.Trim = "Alto" Then
            ErrorProvider1.SetError(CType(sender, TextBox), $"Ingrese el {CType(sender, TextBox).Text.Trim}")
        Else
            ErrorProvider1.SetError(CType(sender, TextBox), "")
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            OpenFileDialog1.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyPictures
            OpenFileDialog1.Filter = "Todos los archivos (*.*)|*.*"
            OpenFileDialog1.Title = "Seleccione la imagen"

            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                PbImagen.Image = Image.FromFile(OpenFileDialog1.FileName)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If PbImagen.Image Is Nothing Then
            MessageBox.Show("Debe seleccionar una imagen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If FlpResoluciones.Controls.Count = 0 Then
            MessageBox.Show("Debe tener almenos una resolución", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If TxtNombre.Text.ToString.Trim = "" Then
            MessageBox.Show("Ingrese el nombre de la nueva imagen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If CboFormato.Text.ToString.Trim = "" Then
            MessageBox.Show("Seleccione el formato de imagen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim i As Integer = 1
        Dim sin_errores As Boolean = True
        For Each GroupBox As Control In FlpResoluciones.Controls
            Dim gb As GroupBox = TryCast(GroupBox, GroupBox)

            If gb.Controls.Find($"Txt1Resolucion{i}", True).First().Text.Trim = "Ancho" Then
                Dim txt As TextBox = DirectCast(gb.Controls.Find($"Txt1Resolucion{i}", True).First(), TextBox)
                ErrorProvider1.SetError(txt, "Ingrese el Ancho")
                sin_errores = False
            End If
            If gb.Controls.Find($"Txt2Resolucion{i}", True).First().Text.Trim = "Alto" Then
                Dim txt As TextBox = DirectCast(gb.Controls.Find($"Txt2Resolucion{i}", True).First(), TextBox)
                ErrorProvider1.SetError(txt, "Ingrese el Alto")
                sin_errores = False
            End If
            i = i + 1
        Next

        If sin_errores Then
            SaveFileDialog1.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyPictures
            SaveFileDialog1.Title = "Ingrese el nombre de la carpeta"

            If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
                System.IO.Directory.CreateDirectory(SaveFileDialog1.FileName)

                i = 1
                For Each GroupBox As Control In FlpResoluciones.Controls
                    Dim gb As GroupBox = TryCast(GroupBox, GroupBox)
                    Dim x1, x2 As Integer

                    x1 = CInt(DirectCast(gb.Controls.Find($"Txt1Resolucion{i}", True).First(), TextBox).Text.Trim)
                    x2 = CInt(DirectCast(gb.Controls.Find($"Txt2Resolucion{i}", True).First(), TextBox).Text.Trim)

                    Using Bitmap As New Bitmap(PbImagen.Image, New Size(x1, x2))
                        If CboFormato.SelectedItem.ToString = "PNG" Then
                            Bitmap.Save(SaveFileDialog1.FileName + $"/{TxtNombre.Text}_{x1}_x_{x2}_{i}.png", Imaging.ImageFormat.Png)
                        ElseIf CboFormato.SelectedItem.ToString = "JPEG" Then
                            Bitmap.Save(SaveFileDialog1.FileName + $"/{TxtNombre.Text}_{x1}_x_{x2}_{i}.jpg", Imaging.ImageFormat.Jpeg)
                        ElseIf CboFormato.SelectedItem.ToString = "ICON" Then
                            Bitmap.Save(SaveFileDialog1.FileName + $"/{TxtNombre.Text}_{x1}_x_{x2}_{i}.ico", Imaging.ImageFormat.Icon)
                        ElseIf CboFormato.SelectedItem.ToString = "GIF" Then
                            Bitmap.Save(SaveFileDialog1.FileName + $"/{TxtNombre.Text}_{x1}_x_{x2}_{i}.gif", Imaging.ImageFormat.Gif)
                        ElseIf CboFormato.SelectedItem.ToString = "BMP" Then
                            Bitmap.Save(SaveFileDialog1.FileName + $"/{TxtNombre.Text}_{x1}_x_{x2}_{i}.bmp", Imaging.ImageFormat.Bmp)
                        End If
                    End Using
                    i = i + 1
                Next
                MessageBox.Show("Imagenes almacenadas con exito!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                If CboResolucionesAlmacenadas.Text.Trim = "Ninguna" Then
                    If MessageBox.Show("¿Desea almacenar estas resoluciones?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

                        i = 1
                        Dim lista As New List(Of String)
                        Dim nombre As String = ""

                        nombre = InputBox("Ingrese el nombre de la resolución", "Información", "")

                        While nombre.Trim = "" Or My.Settings.Resoluciones.Contains(nombre.Trim)
                            If nombre.Trim = "" Then
                                nombre = InputBox("Ingrese el nombre de la resolución", "Información", "")
                            Else
                                nombre = InputBox("Ingrese otro nombre de resolución", "Información", "")
                            End If

                        End While


                        For Each GroupBox As Control In FlpResoluciones.Controls
                            Dim gb As GroupBox = TryCast(GroupBox, GroupBox)
                            Dim x1, x2 As Integer

                            x1 = CInt(DirectCast(gb.Controls.Find($"Txt1Resolucion{i}", True).First(), TextBox).Text.Trim)
                            x2 = CInt(DirectCast(gb.Controls.Find($"Txt2Resolucion{i}", True).First(), TextBox).Text.Trim)
                            lista.Add($"{i}_{x1}_{x2}_{nombre.Trim}")
                            i = i + 1
                        Next

                        For Each s As String In lista
                            My.Settings.Resoluciones.Add(s)
                            My.Settings.Save()
                        Next

                        MessageBox.Show("Resoluciones almacenadas con exito!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    End If
                End If


                CboResolucionesAlmacenadas.SelectedIndex = -1
                CboFormato.SelectedIndex = -1
                TextBox1.Text = "0"
                TextBox1.Text = ""
                TxtNombre.Text = ""
                PbImagen.Image = Nothing
                llenarResoluciones()
            End If
        End If
    End Sub

    Private Sub Evento_GotFocus(sender As Object, e As EventArgs)
        If CType(sender, TextBox).Text.Trim = "Ancho" Then
            CType(sender, TextBox).Text = ""
            CType(sender, TextBox).ForeColor = Color.Black
        Else
            CType(sender, TextBox).ForeColor = Color.Black
        End If
    End Sub

    Private Sub Evento_LostFocus(sender As Object, e As EventArgs)
        If CType(sender, TextBox).Text.Trim = "" Then
            CType(sender, TextBox).Text = "Ancho"
            CType(sender, TextBox).ForeColor = Color.Gray
        Else
            CType(sender, TextBox).ForeColor = Color.Black
        End If
    End Sub

    Private Sub Evento2_GotFocus(sender As Object, e As EventArgs)
        If CType(sender, TextBox).Text.Trim = "Alto" Then
            CType(sender, TextBox).Text = ""
            CType(sender, TextBox).ForeColor = Color.Black
        Else
            CType(sender, TextBox).ForeColor = Color.Black
        End If
    End Sub

    Private Sub Evento2_LostFocus(sender As Object, e As EventArgs)
        If CType(sender, TextBox).Text.Trim = "" Then
            CType(sender, TextBox).Text = "Alto"
            CType(sender, TextBox).ForeColor = Color.Gray
        Else
            CType(sender, TextBox).ForeColor = Color.Black
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarResoluciones()
    End Sub

    Private Sub CboResolucionesAlmacenadas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboResolucionesAlmacenadas.SelectedIndexChanged
        TextBox1.Enabled = (CboResolucionesAlmacenadas.Text = "Ninguna")
        Button3.Enabled = Not (CboResolucionesAlmacenadas.Text = "Ninguna")


        Dim controles As New List(Of Control)

        For Each control As Control In FlpResoluciones.Controls
            controles.Add(control)
        Next

        For Each control As Control In controles
            FlpResoluciones.Controls.Remove(control)
            control.Dispose()
        Next

        For Each item As String In My.Settings.Resoluciones
            If item.Contains(CboResolucionesAlmacenadas.Text.Trim) Then
                Dim i As Integer = CInt(item.Split("_")(0))


                Dim _TextBox1, _TextBox2 As New TextBox
                Dim _GroupBox As New GroupBox

                _TextBox1.Location = New Point(14, 15)
                _TextBox1.Name = $"Txt1Resolucion{i}"
                _TextBox1.Size = New Size(71, 20)
                _TextBox1.Text = item.Split("_")(1)
                _TextBox1.ForeColor = Color.Black

                _TextBox2.Location = New System.Drawing.Point(91, 15)
                _TextBox2.Name = $"Txt2Resolucion{i}"
                _TextBox2.Size = New Size(71, 20)
                _TextBox2.Text = item.Split("_")(2)
                _TextBox2.ForeColor = Color.Black


                AddHandler _TextBox1.KeyPress, AddressOf Evento_KeyPress
                AddHandler _TextBox2.KeyPress, AddressOf Evento_KeyPress
                AddHandler _TextBox1.TextChanged, AddressOf Evento_TextChanged
                AddHandler _TextBox2.TextChanged, AddressOf Evento_TextChanged
                AddHandler _TextBox1.GotFocus, AddressOf Evento_GotFocus
                AddHandler _TextBox2.GotFocus, AddressOf Evento2_GotFocus
                AddHandler _TextBox1.LostFocus, AddressOf Evento_LostFocus
                AddHandler _TextBox2.LostFocus, AddressOf Evento2_LostFocus

                _GroupBox.Controls.Add(_TextBox1)
                _GroupBox.Controls.Add(_TextBox2)
                _GroupBox.Location = New Point(3, 3)
                _GroupBox.Name = $"Resolucion{i}"
                _GroupBox.Size = New Size(173, 45)
                _GroupBox.Font = New Font("Tahoma", 8.25!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
                _GroupBox.TabStop = False
                _GroupBox.Text = $"Resolución #{i}"

                FlpResoluciones.Controls.Add(_GroupBox)
            End If
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If MessageBox.Show("¿Seguro de eliminar esta resolución?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Exit Sub
        End If

        Dim lista1 As New List(Of String)

        For Each item As String In My.Settings.Resoluciones
            If item.Split("_")(3).Trim = CboResolucionesAlmacenadas.Text.Trim Then
                lista1.Add(item)
            End If
        Next

        For Each i As String In lista1
            My.Settings.Resoluciones.Remove(i)
            My.Settings.Save()
        Next
        llenarResoluciones()
    End Sub

    Public Sub llenarResoluciones()
        Dim lista As New List(Of String)
        lista.Add("Ninguna")
        For Each item As String In My.Settings.Resoluciones
            If Not lista.Contains(item.Split("_")(3).Trim) Then
                lista.Add(item.Split("_")(3).Trim)
            End If
        Next
        CboResolucionesAlmacenadas.DataSource = lista
    End Sub
End Class
