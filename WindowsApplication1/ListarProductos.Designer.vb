<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListarProductos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListarProductos))
        Me.LVProVen = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BtnCloseList = New System.Windows.Forms.PictureBox()
        Me.TextBoxNomb = New System.Windows.Forms.TextBox()
        Me.TextBoxCod = New System.Windows.Forms.TextBox()
        Me.TextBoxDes = New System.Windows.Forms.TextBox()
        Me.TextBoxPre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BntBusc = New System.Windows.Forms.Button()
        Me.BntSelec = New System.Windows.Forms.Button()
        CType(Me.BtnCloseList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LVProVen
        '
        Me.LVProVen.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.LVProVen.AllowColumnReorder = True
        Me.LVProVen.AllowDrop = True
        Me.LVProVen.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.LVProVen.FullRowSelect = True
        Me.LVProVen.Location = New System.Drawing.Point(10, 151)
        Me.LVProVen.Name = "LVProVen"
        Me.LVProVen.Size = New System.Drawing.Size(569, 301)
        Me.LVProVen.TabIndex = 1
        Me.LVProVen.UseCompatibleStateImageBehavior = False
        Me.LVProVen.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Codigo"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Descripcion"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 330
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Precio"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 99
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Stock"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 66
        '
        'BtnCloseList
        '
        Me.BtnCloseList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCloseList.Image = Global.WindowsApplication1.My.Resources.Resources.cer
        Me.BtnCloseList.Location = New System.Drawing.Point(563, 2)
        Me.BtnCloseList.Name = "BtnCloseList"
        Me.BtnCloseList.Size = New System.Drawing.Size(25, 21)
        Me.BtnCloseList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnCloseList.TabIndex = 3
        Me.BtnCloseList.TabStop = False
        '
        'TextBoxNomb
        '
        Me.TextBoxNomb.Location = New System.Drawing.Point(13, 60)
        Me.TextBoxNomb.Name = "TextBoxNomb"
        Me.TextBoxNomb.Size = New System.Drawing.Size(186, 20)
        Me.TextBoxNomb.TabIndex = 4
        '
        'TextBoxCod
        '
        Me.TextBoxCod.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.TextBoxCod.Enabled = False
        Me.TextBoxCod.ForeColor = System.Drawing.Color.Yellow
        Me.TextBoxCod.Location = New System.Drawing.Point(10, 122)
        Me.TextBoxCod.Name = "TextBoxCod"
        Me.TextBoxCod.Size = New System.Drawing.Size(175, 20)
        Me.TextBoxCod.TabIndex = 5
        '
        'TextBoxDes
        '
        Me.TextBoxDes.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.TextBoxDes.Enabled = False
        Me.TextBoxDes.ForeColor = System.Drawing.Color.Yellow
        Me.TextBoxDes.Location = New System.Drawing.Point(203, 122)
        Me.TextBoxDes.Name = "TextBoxDes"
        Me.TextBoxDes.Size = New System.Drawing.Size(175, 20)
        Me.TextBoxDes.TabIndex = 6
        '
        'TextBoxPre
        '
        Me.TextBoxPre.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.TextBoxPre.Enabled = False
        Me.TextBoxPre.ForeColor = System.Drawing.Color.Yellow
        Me.TextBoxPre.Location = New System.Drawing.Point(398, 122)
        Me.TextBoxPre.Name = "TextBoxPre"
        Me.TextBoxPre.Size = New System.Drawing.Size(175, 20)
        Me.TextBoxPre.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(79, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 15)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(65, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 15)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Codigo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(263, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 15)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Descripcion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(464, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 15)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Precio"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(231, 2)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 23)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "PRODUCTOS"
        '
        'BntBusc
        '
        Me.BntBusc.FlatAppearance.BorderSize = 0
        Me.BntBusc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow
        Me.BntBusc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BntBusc.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BntBusc.Image = CType(resources.GetObject("BntBusc.Image"), System.Drawing.Image)
        Me.BntBusc.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BntBusc.Location = New System.Drawing.Point(398, 35)
        Me.BntBusc.Name = "BntBusc"
        Me.BntBusc.Size = New System.Drawing.Size(50, 45)
        Me.BntBusc.TabIndex = 13
        Me.BntBusc.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.BntBusc.UseVisualStyleBackColor = True
        '
        'BntSelec
        '
        Me.BntSelec.FlatAppearance.BorderSize = 0
        Me.BntSelec.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow
        Me.BntSelec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BntSelec.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BntSelec.Image = CType(resources.GetObject("BntSelec.Image"), System.Drawing.Image)
        Me.BntSelec.Location = New System.Drawing.Point(467, 35)
        Me.BntSelec.Name = "BntSelec"
        Me.BntSelec.Size = New System.Drawing.Size(50, 45)
        Me.BntSelec.TabIndex = 14
        Me.BntSelec.UseVisualStyleBackColor = True
        '
        'ListarProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ClientSize = New System.Drawing.Size(590, 472)
        Me.Controls.Add(Me.BntSelec)
        Me.Controls.Add(Me.BntBusc)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxPre)
        Me.Controls.Add(Me.TextBoxDes)
        Me.Controls.Add(Me.TextBoxCod)
        Me.Controls.Add(Me.TextBoxNomb)
        Me.Controls.Add(Me.BtnCloseList)
        Me.Controls.Add(Me.LVProVen)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ListarProductos"
        Me.Text = "ListarProductos"
        CType(Me.BtnCloseList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Public WithEvents LVProVen As System.Windows.Forms.ListView
    Friend WithEvents BtnCloseList As System.Windows.Forms.PictureBox
    Friend WithEvents TextBoxNomb As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxCod As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxDes As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxPre As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BntBusc As System.Windows.Forms.Button
    Friend WithEvents BntSelec As System.Windows.Forms.Button
End Class
