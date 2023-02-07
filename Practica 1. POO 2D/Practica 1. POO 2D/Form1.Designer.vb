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
        Me.Txtz2 = New System.Windows.Forms.TextBox()
        Me.lblz2 = New System.Windows.Forms.Label()
        Me.lblz1 = New System.Windows.Forms.Label()
        Me.Txtz1 = New System.Windows.Forms.TextBox()
        Me.Txty2 = New System.Windows.Forms.TextBox()
        Me.lbly2 = New System.Windows.Forms.Label()
        Me.lbly1 = New System.Windows.Forms.Label()
        Me.Txtx2 = New System.Windows.Forms.TextBox()
        Me.lblx2 = New System.Windows.Forms.Label()
        Me.PbxCalculaDistancia = New System.Windows.Forms.PictureBox()
        Me.TxtDistancia = New System.Windows.Forms.TextBox()
        Me.Txty1 = New System.Windows.Forms.TextBox()
        Me.Txtx1 = New System.Windows.Forms.TextBox()
        Me.lbldistancia = New System.Windows.Forms.Label()
        Me.lblx1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.PbxCalculaDistancia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Txtz2
        '
        Me.Txtz2.Location = New System.Drawing.Point(221, 306)
        Me.Txtz2.Name = "Txtz2"
        Me.Txtz2.Size = New System.Drawing.Size(100, 22)
        Me.Txtz2.TabIndex = 34
        '
        'lblz2
        '
        Me.lblz2.AutoSize = True
        Me.lblz2.Font = New System.Drawing.Font("Lucida Sans Unicode", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblz2.Location = New System.Drawing.Point(41, 306)
        Me.lblz2.Name = "lblz2"
        Me.lblz2.Size = New System.Drawing.Size(166, 17)
        Me.lblz2.TabIndex = 33
        Me.lblz2.Text = "Introduzca valor de z2:"
        '
        'lblz1
        '
        Me.lblz1.AutoSize = True
        Me.lblz1.Font = New System.Drawing.Font("Lucida Sans Unicode", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblz1.Location = New System.Drawing.Point(41, 274)
        Me.lblz1.Name = "lblz1"
        Me.lblz1.Size = New System.Drawing.Size(166, 17)
        Me.lblz1.TabIndex = 32
        Me.lblz1.Text = "Introduzca valor de z1:"
        '
        'Txtz1
        '
        Me.Txtz1.Location = New System.Drawing.Point(221, 269)
        Me.Txtz1.Name = "Txtz1"
        Me.Txtz1.Size = New System.Drawing.Size(100, 22)
        Me.Txtz1.TabIndex = 31
        '
        'Txty2
        '
        Me.Txty2.Location = New System.Drawing.Point(221, 237)
        Me.Txty2.Name = "Txty2"
        Me.Txty2.Size = New System.Drawing.Size(100, 22)
        Me.Txty2.TabIndex = 30
        '
        'lbly2
        '
        Me.lbly2.AutoSize = True
        Me.lbly2.Font = New System.Drawing.Font("Lucida Sans Unicode", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbly2.Location = New System.Drawing.Point(41, 237)
        Me.lbly2.Name = "lbly2"
        Me.lbly2.Size = New System.Drawing.Size(165, 17)
        Me.lbly2.TabIndex = 29
        Me.lbly2.Text = "Introduzca valor de y2:"
        '
        'lbly1
        '
        Me.lbly1.AutoSize = True
        Me.lbly1.Font = New System.Drawing.Font("Lucida Sans Unicode", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbly1.Location = New System.Drawing.Point(41, 205)
        Me.lbly1.Name = "lbly1"
        Me.lbly1.Size = New System.Drawing.Size(165, 17)
        Me.lbly1.TabIndex = 28
        Me.lbly1.Text = "Introduzca valor de y1:"
        '
        'Txtx2
        '
        Me.Txtx2.Location = New System.Drawing.Point(221, 161)
        Me.Txtx2.Name = "Txtx2"
        Me.Txtx2.Size = New System.Drawing.Size(100, 22)
        Me.Txtx2.TabIndex = 27
        '
        'lblx2
        '
        Me.lblx2.AutoSize = True
        Me.lblx2.Font = New System.Drawing.Font("Lucida Sans Unicode", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblx2.Location = New System.Drawing.Point(39, 166)
        Me.lblx2.Name = "lblx2"
        Me.lblx2.Size = New System.Drawing.Size(167, 17)
        Me.lblx2.TabIndex = 26
        Me.lblx2.Text = "Introduzca valor de x2:"
        '
        'PbxCalculaDistancia
        '
        Me.PbxCalculaDistancia.Image = CType(resources.GetObject("PbxCalculaDistancia.Image"), System.Drawing.Image)
        Me.PbxCalculaDistancia.Location = New System.Drawing.Point(371, 114)
        Me.PbxCalculaDistancia.Name = "PbxCalculaDistancia"
        Me.PbxCalculaDistancia.Size = New System.Drawing.Size(57, 50)
        Me.PbxCalculaDistancia.TabIndex = 25
        Me.PbxCalculaDistancia.TabStop = False
        '
        'TxtDistancia
        '
        Me.TxtDistancia.Location = New System.Drawing.Point(221, 342)
        Me.TxtDistancia.Name = "TxtDistancia"
        Me.TxtDistancia.Size = New System.Drawing.Size(100, 22)
        Me.TxtDistancia.TabIndex = 24
        '
        'Txty1
        '
        Me.Txty1.Location = New System.Drawing.Point(221, 200)
        Me.Txty1.Name = "Txty1"
        Me.Txty1.Size = New System.Drawing.Size(100, 22)
        Me.Txty1.TabIndex = 23
        '
        'Txtx1
        '
        Me.Txtx1.Location = New System.Drawing.Point(221, 124)
        Me.Txtx1.Name = "Txtx1"
        Me.Txtx1.Size = New System.Drawing.Size(100, 22)
        Me.Txtx1.TabIndex = 22
        '
        'lbldistancia
        '
        Me.lbldistancia.AutoSize = True
        Me.lbldistancia.Font = New System.Drawing.Font("Lucida Sans Unicode", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldistancia.Location = New System.Drawing.Point(74, 347)
        Me.lbldistancia.Name = "lbldistancia"
        Me.lbldistancia.Size = New System.Drawing.Size(132, 17)
        Me.lbldistancia.TabIndex = 21
        Me.lbldistancia.Text = "La distancia es de:"
        '
        'lblx1
        '
        Me.lblx1.AutoSize = True
        Me.lblx1.Font = New System.Drawing.Font("Lucida Sans Unicode", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblx1.Location = New System.Drawing.Point(39, 129)
        Me.lblx1.Name = "lblx1"
        Me.lblx1.Size = New System.Drawing.Size(167, 17)
        Me.lblx1.TabIndex = 20
        Me.lblx1.Text = "Introduzca valor de x1:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("DK Lemon Yellow Sun", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(116, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(255, 29)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Distancia entre dos puntos"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkViolet
        Me.Panel1.Location = New System.Drawing.Point(-2, -3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(483, 55)
        Me.Panel1.TabIndex = 35
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.ClientSize = New System.Drawing.Size(481, 393)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Txtz2)
        Me.Controls.Add(Me.lblz2)
        Me.Controls.Add(Me.lblz1)
        Me.Controls.Add(Me.Txtz1)
        Me.Controls.Add(Me.Txty2)
        Me.Controls.Add(Me.lbly2)
        Me.Controls.Add(Me.lbly1)
        Me.Controls.Add(Me.Txtx2)
        Me.Controls.Add(Me.lblx2)
        Me.Controls.Add(Me.PbxCalculaDistancia)
        Me.Controls.Add(Me.TxtDistancia)
        Me.Controls.Add(Me.Txty1)
        Me.Controls.Add(Me.Txtx1)
        Me.Controls.Add(Me.lbldistancia)
        Me.Controls.Add(Me.lblx1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PbxCalculaDistancia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Txtz2 As TextBox
    Friend WithEvents lblz2 As Label
    Friend WithEvents lblz1 As Label
    Friend WithEvents Txtz1 As TextBox
    Friend WithEvents Txty2 As TextBox
    Friend WithEvents lbly2 As Label
    Friend WithEvents lbly1 As Label
    Friend WithEvents Txtx2 As TextBox
    Friend WithEvents lblx2 As Label
    Friend WithEvents PbxCalculaDistancia As PictureBox
    Friend WithEvents TxtDistancia As TextBox
    Friend WithEvents Txty1 As TextBox
    Friend WithEvents Txtx1 As TextBox
    Friend WithEvents lbldistancia As Label
    Friend WithEvents lblx1 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
End Class
