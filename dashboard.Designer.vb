<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dashboard
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
        components = New ComponentModel.Container()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dashboard))
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Panel1 = New Panel()
        Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(components)
        pnlTop = New Guna.UI2.WinForms.Guna2Panel()
        Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Guna2PictureBox3 = New Guna.UI2.WinForms.Guna2PictureBox()
        ImageList1 = New ImageList(components)
        Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(components)
        pnlTop.SuspendLayout()
        CType(Guna2PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(Guna2PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Guna2Panel3.SuspendLayout()
        CType(Guna2PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(1), CByte(79), CByte(134))
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(228, 721)
        Panel1.TabIndex = 2
        ' 
        ' Guna2Elipse1
        ' 
        Guna2Elipse1.BorderRadius = 8
        Guna2Elipse1.TargetControl = Me
        ' 
        ' pnlTop
        ' 
        pnlTop.Controls.Add(Guna2PictureBox2)
        pnlTop.Controls.Add(Guna2PictureBox1)
        pnlTop.CustomizableEdges = CustomizableEdges9
        pnlTop.Dock = DockStyle.Top
        pnlTop.Location = New Point(228, 0)
        pnlTop.Name = "pnlTop"
        pnlTop.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        pnlTop.Size = New Size(869, 44)
        pnlTop.TabIndex = 3
        ' 
        ' Guna2PictureBox2
        ' 
        Guna2PictureBox2.Cursor = Cursors.Hand
        Guna2PictureBox2.CustomizableEdges = CustomizableEdges5
        Guna2PictureBox2.Image = CType(resources.GetObject("Guna2PictureBox2.Image"), Image)
        Guna2PictureBox2.ImageRotate = 0F
        Guna2PictureBox2.Location = New Point(757, 0)
        Guna2PictureBox2.Name = "Guna2PictureBox2"
        Guna2PictureBox2.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Guna2PictureBox2.Size = New Size(32, 32)
        Guna2PictureBox2.SizeMode = PictureBoxSizeMode.AutoSize
        Guna2PictureBox2.TabIndex = 1
        Guna2PictureBox2.TabStop = False
        ' 
        ' Guna2PictureBox1
        ' 
        Guna2PictureBox1.Cursor = Cursors.Hand
        Guna2PictureBox1.CustomizableEdges = CustomizableEdges7
        Guna2PictureBox1.Image = My.Resources.Resources.closeBW
        Guna2PictureBox1.ImageRotate = 0F
        Guna2PictureBox1.Location = New Point(825, 0)
        Guna2PictureBox1.Name = "Guna2PictureBox1"
        Guna2PictureBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        Guna2PictureBox1.Size = New Size(32, 32)
        Guna2PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
        Guna2PictureBox1.TabIndex = 0
        Guna2PictureBox1.TabStop = False
        ' 
        ' Guna2Panel3
        ' 
        Guna2Panel3.BackColor = Color.FromArgb(CByte(97), CByte(165), CByte(194))
        Guna2Panel3.Controls.Add(Guna2PictureBox3)
        Guna2Panel3.CustomizableEdges = CustomizableEdges3
        Guna2Panel3.Dock = DockStyle.Fill
        Guna2Panel3.Location = New Point(228, 44)
        Guna2Panel3.Name = "Guna2Panel3"
        Guna2Panel3.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2Panel3.Size = New Size(869, 677)
        Guna2Panel3.TabIndex = 4
        ' 
        ' Guna2PictureBox3
        ' 
        Guna2PictureBox3.BorderRadius = 20
        Guna2PictureBox3.CustomizableEdges = CustomizableEdges1
        Guna2PictureBox3.ImageRotate = 0F
        Guna2PictureBox3.Location = New Point(17, 21)
        Guna2PictureBox3.Name = "Guna2PictureBox3"
        Guna2PictureBox3.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2PictureBox3.Size = New Size(840, 357)
        Guna2PictureBox3.TabIndex = 0
        Guna2PictureBox3.TabStop = False
        ' 
        ' ImageList1
        ' 
        ImageList1.ColorDepth = ColorDepth.Depth32Bit
        ImageList1.ImageSize = New Size(16, 16)
        ImageList1.TransparentColor = Color.Transparent
        ' 
        ' Guna2DragControl1
        ' 
        Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Guna2DragControl1.TargetControl = pnlTop
        Guna2DragControl1.UseTransparentDrag = True
        ' 
        ' dashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1097, 721)
        Controls.Add(Guna2Panel3)
        Controls.Add(pnlTop)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "dashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "dashboard"
        pnlTop.ResumeLayout(False)
        pnlTop.PerformLayout()
        CType(Guna2PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(Guna2PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Guna2Panel3.ResumeLayout(False)
        CType(Guna2PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnlTop As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2PictureBox3 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
End Class
