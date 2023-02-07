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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TxtCorreoE = New System.Windows.Forms.TextBox()
        Me.TxtNumTel = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtRfc = New System.Windows.Forms.TextBox()
        Me.TxtApMat = New System.Windows.Forms.TextBox()
        Me.TxtApPat = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.LblRfc = New System.Windows.Forms.Label()
        Me.PbxRFC = New System.Windows.Forms.PictureBox()
        Me.LblAño = New System.Windows.Forms.Label()
        Me.LblMes = New System.Windows.Forms.Label()
        Me.LblDia = New System.Windows.Forms.Label()
        Me.CbAño = New System.Windows.Forms.ComboBox()
        Me.CbMes = New System.Windows.Forms.ComboBox()
        Me.CbDia = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.PbxRFC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtCorreoE
        '
        Me.TxtCorreoE.Location = New System.Drawing.Point(576, 153)
        Me.TxtCorreoE.Name = "TxtCorreoE"
        Me.TxtCorreoE.Size = New System.Drawing.Size(171, 22)
        Me.TxtCorreoE.TabIndex = 62
        '
        'TxtNumTel
        '
        Me.TxtNumTel.Location = New System.Drawing.Point(576, 116)
        Me.TxtNumTel.Name = "TxtNumTel"
        Me.TxtNumTel.Size = New System.Drawing.Size(171, 22)
        Me.TxtNumTel.TabIndex = 61
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lucida Sans Unicode", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(430, 158)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(140, 17)
        Me.Label7.TabIndex = 60
        Me.Label7.Text = "Correo electronico:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Sans Unicode", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(421, 121)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(149, 17)
        Me.Label6.TabIndex = 59
        Me.Label6.Text = "Numero de telefono:"
        '
        'TxtRfc
        '
        Me.TxtRfc.Enabled = False
        Me.TxtRfc.Location = New System.Drawing.Point(181, 213)
        Me.TxtRfc.Name = "TxtRfc"
        Me.TxtRfc.Size = New System.Drawing.Size(212, 22)
        Me.TxtRfc.TabIndex = 58
        '
        'TxtApMat
        '
        Me.TxtApMat.Location = New System.Drawing.Point(181, 180)
        Me.TxtApMat.Name = "TxtApMat"
        Me.TxtApMat.Size = New System.Drawing.Size(212, 22)
        Me.TxtApMat.TabIndex = 57
        '
        'TxtApPat
        '
        Me.TxtApPat.Location = New System.Drawing.Point(181, 148)
        Me.TxtApPat.Name = "TxtApPat"
        Me.TxtApPat.Size = New System.Drawing.Size(212, 22)
        Me.TxtApPat.TabIndex = 56
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(181, 116)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(212, 22)
        Me.TxtNombre.TabIndex = 55
        '
        'LblRfc
        '
        Me.LblRfc.AutoSize = True
        Me.LblRfc.Font = New System.Drawing.Font("Lucida Sans Unicode", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRfc.Location = New System.Drawing.Point(126, 218)
        Me.LblRfc.Name = "LblRfc"
        Me.LblRfc.Size = New System.Drawing.Size(39, 17)
        Me.LblRfc.TabIndex = 54
        Me.LblRfc.Text = "RFC:"
        '
        'PbxRFC
        '
        Me.PbxRFC.Image = CType(resources.GetObject("PbxRFC.Image"), System.Drawing.Image)
        Me.PbxRFC.Location = New System.Drawing.Point(642, 48)
        Me.PbxRFC.Name = "PbxRFC"
        Me.PbxRFC.Size = New System.Drawing.Size(45, 43)
        Me.PbxRFC.TabIndex = 53
        Me.PbxRFC.TabStop = False
        '
        'LblAño
        '
        Me.LblAño.AutoSize = True
        Me.LblAño.Font = New System.Drawing.Font("Lucida Sans Unicode", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAño.Location = New System.Drawing.Point(228, 35)
        Me.LblAño.Name = "LblAño"
        Me.LblAño.Size = New System.Drawing.Size(36, 17)
        Me.LblAño.TabIndex = 52
        Me.LblAño.Text = "Año"
        '
        'LblMes
        '
        Me.LblMes.AutoSize = True
        Me.LblMes.Font = New System.Drawing.Font("Lucida Sans Unicode", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMes.Location = New System.Drawing.Point(148, 35)
        Me.LblMes.Name = "LblMes"
        Me.LblMes.Size = New System.Drawing.Size(35, 17)
        Me.LblMes.TabIndex = 51
        Me.LblMes.Text = "Mes"
        '
        'LblDia
        '
        Me.LblDia.AutoSize = True
        Me.LblDia.Font = New System.Drawing.Font("Lucida Sans Unicode", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDia.Location = New System.Drawing.Point(71, 35)
        Me.LblDia.Name = "LblDia"
        Me.LblDia.Size = New System.Drawing.Size(30, 17)
        Me.LblDia.TabIndex = 50
        Me.LblDia.Text = "Dia"
        '
        'CbAño
        '
        Me.CbAño.Font = New System.Drawing.Font("Lucida Sans Unicode", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbAño.FormattingEnabled = True
        Me.CbAño.Items.AddRange(New Object() {"1980", "1981", "1982", "1983", "1984", "1985", "1986", "1987", "1988", "1989", "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023"})
        Me.CbAño.Location = New System.Drawing.Point(213, 55)
        Me.CbAño.Name = "CbAño"
        Me.CbAño.Size = New System.Drawing.Size(62, 24)
        Me.CbAño.TabIndex = 49
        '
        'CbMes
        '
        Me.CbMes.Font = New System.Drawing.Font("Lucida Sans Unicode", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbMes.FormattingEnabled = True
        Me.CbMes.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.CbMes.Location = New System.Drawing.Point(133, 55)
        Me.CbMes.Name = "CbMes"
        Me.CbMes.Size = New System.Drawing.Size(64, 24)
        Me.CbMes.TabIndex = 48
        '
        'CbDia
        '
        Me.CbDia.Font = New System.Drawing.Font("Lucida Sans Unicode", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbDia.FormattingEnabled = True
        Me.CbDia.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30"})
        Me.CbDia.Location = New System.Drawing.Point(50, 55)
        Me.CbDia.Name = "CbDia"
        Me.CbDia.Size = New System.Drawing.Size(64, 24)
        Me.CbDia.TabIndex = 47
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans Unicode", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(34, 185)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 17)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Apellido materno:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans Unicode", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(38, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 17)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Apellido paterno:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(98, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 17)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("DK Lemon Yellow Sun", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(356, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 29)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Persona"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LblMes)
        Me.GroupBox1.Controls.Add(Me.CbDia)
        Me.GroupBox1.Controls.Add(Me.CbMes)
        Me.GroupBox1.Controls.Add(Me.CbAño)
        Me.GroupBox1.Controls.Add(Me.LblDia)
        Me.GroupBox1.Controls.Add(Me.LblAño)
        Me.GroupBox1.Font = New System.Drawing.Font("Lucida Sans Unicode", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(37, 262)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(356, 100)
        Me.GroupBox1.TabIndex = 63
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fecha nacimiento:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TxtCorreoE)
        Me.Controls.Add(Me.TxtNumTel)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtRfc)
        Me.Controls.Add(Me.TxtApMat)
        Me.Controls.Add(Me.TxtApPat)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.LblRfc)
        Me.Controls.Add(Me.PbxRFC)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PbxRFC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtCorreoE As TextBox
    Friend WithEvents TxtNumTel As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtRfc As TextBox
    Friend WithEvents TxtApMat As TextBox
    Friend WithEvents TxtApPat As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents LblRfc As Label
    Friend WithEvents PbxRFC As PictureBox
    Friend WithEvents LblAño As Label
    Friend WithEvents LblMes As Label
    Friend WithEvents LblDia As Label
    Friend WithEvents CbAño As ComboBox
    Friend WithEvents CbMes As ComboBox
    Friend WithEvents CbDia As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
End Class
