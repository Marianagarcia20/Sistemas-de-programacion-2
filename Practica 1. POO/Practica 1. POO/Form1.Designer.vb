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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txtx1 = New System.Windows.Forms.TextBox()
        Me.Txty1 = New System.Windows.Forms.TextBox()
        Me.TxtDistancia = New System.Windows.Forms.TextBox()
        Me.PbxCalculaDistancia = New System.Windows.Forms.PictureBox()
        Me.Txtx2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txty2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.PbxCalculaDistancia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("DK Lemon Yellow Sun", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(118, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(255, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Distancia entre dos puntos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(38, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Introduzca valor de x1:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans Unicode", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(73, 291)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "La distancia es de:"
        '
        'Txtx1
        '
        Me.Txtx1.Location = New System.Drawing.Point(220, 139)
        Me.Txtx1.Name = "Txtx1"
        Me.Txtx1.Size = New System.Drawing.Size(100, 22)
        Me.Txtx1.TabIndex = 4
        '
        'Txty1
        '
        Me.Txty1.Location = New System.Drawing.Point(220, 215)
        Me.Txty1.Name = "Txty1"
        Me.Txty1.Size = New System.Drawing.Size(100, 22)
        Me.Txty1.TabIndex = 5
        '
        'TxtDistancia
        '
        Me.TxtDistancia.Location = New System.Drawing.Point(220, 291)
        Me.TxtDistancia.Name = "TxtDistancia"
        Me.TxtDistancia.Size = New System.Drawing.Size(100, 22)
        Me.TxtDistancia.TabIndex = 6
        '
        'PbxCalculaDistancia
        '
        Me.PbxCalculaDistancia.Image = CType(resources.GetObject("PbxCalculaDistancia.Image"), System.Drawing.Image)
        Me.PbxCalculaDistancia.Location = New System.Drawing.Point(370, 129)
        Me.PbxCalculaDistancia.Name = "PbxCalculaDistancia"
        Me.PbxCalculaDistancia.Size = New System.Drawing.Size(62, 50)
        Me.PbxCalculaDistancia.TabIndex = 7
        Me.PbxCalculaDistancia.TabStop = False
        '
        'Txtx2
        '
        Me.Txtx2.Location = New System.Drawing.Point(220, 176)
        Me.Txtx2.Name = "Txtx2"
        Me.Txtx2.Size = New System.Drawing.Size(100, 22)
        Me.Txtx2.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Sans Unicode", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(38, 181)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(167, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Introduzca valor de x2:"
        '
        'Txty2
        '
        Me.Txty2.Location = New System.Drawing.Point(220, 252)
        Me.Txty2.Name = "Txty2"
        Me.Txty2.Size = New System.Drawing.Size(100, 22)
        Me.Txty2.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans Unicode", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(40, 252)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(165, 17)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Introduzca valor de y2:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Sans Unicode", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(40, 220)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(165, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Introduzca valor de y1:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.BlueViolet
        Me.Panel1.Location = New System.Drawing.Point(-4, -5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(479, 61)
        Me.Panel1.TabIndex = 14
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(475, 365)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Txty2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Txtx2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PbxCalculaDistancia)
        Me.Controls.Add(Me.TxtDistancia)
        Me.Controls.Add(Me.Txty1)
        Me.Controls.Add(Me.Txtx1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PbxCalculaDistancia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Txtx1 As TextBox
    Friend WithEvents Txty1 As TextBox
    Friend WithEvents TxtDistancia As TextBox
    Friend WithEvents PbxCalculaDistancia As PictureBox
    Friend WithEvents Txtx2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Txty2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
End Class
