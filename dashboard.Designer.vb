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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dashboard))
        Panel2 = New Panel()
        Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Panel1 = New Panel()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(1), CByte(73), CByte(124))
        Panel2.Controls.Add(Guna2Button1)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1097, 84)
        Panel2.TabIndex = 1
        ' 
        ' Guna2Button1
        ' 
        Guna2Button1.BorderRadius = 15
        Guna2Button1.CustomizableEdges = CustomizableEdges1
        Guna2Button1.DisabledState.BorderColor = Color.DarkGray
        Guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button1.Font = New Font("Jellee Bold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2Button1.ForeColor = Color.White
        Guna2Button1.Location = New Point(1003, 12)
        Guna2Button1.Name = "Guna2Button1"
        Guna2Button1.PressedColor = Color.FromArgb(CByte(70), CByte(143), CByte(175))
        Guna2Button1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2Button1.Size = New Size(82, 56)
        Guna2Button1.TabIndex = 0
        Guna2Button1.Text = "Login / Signup"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(42), CByte(111), CByte(151))
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 84)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(228, 637)
        Panel1.TabIndex = 2
        ' 
        ' dashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1097, 721)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "dashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "dashboard"
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
End Class
