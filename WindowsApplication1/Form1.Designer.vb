<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.clbCanciones = New System.Windows.Forms.CheckedListBox()
        Me.pbCascos = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblP_Cancion = New System.Windows.Forms.Label()
        Me.lblP_Total = New System.Windows.Forms.Label()
        Me.btnComprar = New System.Windows.Forms.Button()
        Me.txbP_Total = New System.Windows.Forms.TextBox()
        Me.txbP_Cancion = New System.Windows.Forms.TextBox()
        CType(Me.pbCascos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'clbCanciones
        '
        Me.clbCanciones.BackColor = System.Drawing.Color.Black
        Me.clbCanciones.Font = New System.Drawing.Font("Elephant", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clbCanciones.ForeColor = System.Drawing.Color.Gold
        Me.clbCanciones.FormattingEnabled = True
        Me.clbCanciones.Items.AddRange(New Object() {"After Party", "Beggin", "Blue Exorcist", "Cinema", "Creo en ti", "Eclipse", "My Inmortal", "First of th Year", "It will rain", "Kyoto", "Wolrds Collide", "Savior", "Starlight Tears", "Warriors", "We are Harlot", "Wiggle"})
        Me.clbCanciones.Location = New System.Drawing.Point(4, 36)
        Me.clbCanciones.Name = "clbCanciones"
        Me.clbCanciones.Size = New System.Drawing.Size(144, 213)
        Me.clbCanciones.TabIndex = 0
        '
        'pbCascos
        '
        Me.pbCascos.Image = CType(resources.GetObject("pbCascos.Image"), System.Drawing.Image)
        Me.pbCascos.Location = New System.Drawing.Point(4, 256)
        Me.pbCascos.Name = "pbCascos"
        Me.pbCascos.Size = New System.Drawing.Size(240, 138)
        Me.pbCascos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbCascos.TabIndex = 1
        Me.pbCascos.TabStop = False
        '
        'lblP_Cancion
        '
        Me.lblP_Cancion.AutoSize = True
        Me.lblP_Cancion.Location = New System.Drawing.Point(150, 115)
        Me.lblP_Cancion.Name = "lblP_Cancion"
        Me.lblP_Cancion.Size = New System.Drawing.Size(96, 16)
        Me.lblP_Cancion.TabIndex = 2
        Me.lblP_Cancion.Text = "Precio de la cancion"
        '
        'lblP_Total
        '
        Me.lblP_Total.AutoSize = True
        Me.lblP_Total.Location = New System.Drawing.Point(162, 166)
        Me.lblP_Total.Name = "lblP_Total"
        Me.lblP_Total.Size = New System.Drawing.Size(73, 16)
        Me.lblP_Total.TabIndex = 3
        Me.lblP_Total.Text = "Monto Total:"
        '
        'btnComprar
        '
        Me.btnComprar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnComprar.Font = New System.Drawing.Font("Old English Text MT", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComprar.Location = New System.Drawing.Point(158, 217)
        Me.btnComprar.Name = "btnComprar"
        Me.btnComprar.Size = New System.Drawing.Size(80, 33)
        Me.btnComprar.TabIndex = 4
        Me.btnComprar.Text = "Comprar"
        Me.btnComprar.UseVisualStyleBackColor = True
        '
        'txbP_Total
        '
        Me.txbP_Total.Location = New System.Drawing.Point(156, 188)
        Me.txbP_Total.Name = "txbP_Total"
        Me.txbP_Total.Size = New System.Drawing.Size(85, 23)
        Me.txbP_Total.TabIndex = 5
        '
        'txbP_Cancion
        '
        Me.txbP_Cancion.Location = New System.Drawing.Point(158, 137)
        Me.txbP_Cancion.Name = "txbP_Cancion"
        Me.txbP_Cancion.Size = New System.Drawing.Size(80, 23)
        Me.txbP_Cancion.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(249, 400)
        Me.Controls.Add(Me.txbP_Cancion)
        Me.Controls.Add(Me.txbP_Total)
        Me.Controls.Add(Me.btnComprar)
        Me.Controls.Add(Me.lblP_Total)
        Me.Controls.Add(Me.lblP_Cancion)
        Me.Controls.Add(Me.pbCascos)
        Me.Controls.Add(Me.clbCanciones)
        Me.Font = New System.Drawing.Font("Old English Text MT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Gold
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.pbCascos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents clbCanciones As CheckedListBox
    Friend WithEvents pbCascos As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents lblP_Cancion As Label
    Friend WithEvents lblP_Total As Label
    Friend WithEvents btnComprar As Button
    Friend WithEvents txbP_Total As TextBox
    Friend WithEvents txbP_Cancion As TextBox
End Class
