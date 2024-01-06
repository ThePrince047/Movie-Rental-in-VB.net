<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class splashscreen
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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(splashscreen))
        ProgressBar1 = New Guna.UI2.WinForms.Guna2ProgressBar()
        lb_text = New Label()
        lb_percent = New Label()
        Timer1 = New Timer(components)
        Timer2 = New Timer(components)
        SuspendLayout()
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.CustomizableEdges = CustomizableEdges1
        ProgressBar1.Location = New Point(206, 400)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        ProgressBar1.Size = New Size(375, 38)
        ProgressBar1.TabIndex = 0
        ProgressBar1.Text = "Guna2ProgressBar1"
        ProgressBar1.TextRenderingHint = Drawing.Text.TextRenderingHint.SystemDefault
        ' 
        ' lb_text
        ' 
        lb_text.AutoSize = True
        lb_text.Font = New Font("Jellee Bold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lb_text.Location = New Point(283, 194)
        lb_text.Name = "lb_text"
        lb_text.Size = New Size(235, 42)
        lb_text.TabIndex = 1
        lb_text.Text = "Processing..."
        ' 
        ' lb_percent
        ' 
        lb_percent.AutoSize = True
        lb_percent.Font = New Font("Jellee Bold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lb_percent.Location = New Point(362, 365)
        lb_percent.Name = "lb_percent"
        lb_percent.Size = New Size(60, 28)
        lb_percent.TabIndex = 2
        lb_percent.Text = "000"
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        ' 
        ' Timer2
        ' 
        Timer2.Enabled = True
        ' 
        ' splashscreen
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lb_percent)
        Controls.Add(lb_text)
        Controls.Add(ProgressBar1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "splashscreen"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Splashscreen"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ProgressBar1 As Guna.UI2.WinForms.Guna2ProgressBar
    Friend WithEvents lb_text As Label
    Friend WithEvents lb_percent As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
End Class
