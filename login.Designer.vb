<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges13 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges14 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges15 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges16 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges17 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges18 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        closeButton = New Guna.UI2.WinForms.Guna2ImageButton()
        Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Guna2TextBox2 = New Guna.UI2.WinForms.Guna2TextBox()
        Label1 = New Label()
        Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        forgotPassword = New Label()
        Label2 = New Label()
        CType(Guna2PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Guna2PictureBox1
        ' 
        Guna2PictureBox1.BackColor = Color.MediumBlue
        Guna2PictureBox1.BackgroundImage = CType(resources.GetObject("Guna2PictureBox1.BackgroundImage"), Image)
        Guna2PictureBox1.BorderRadius = 30
        Guna2PictureBox1.CustomizableEdges = CustomizableEdges10
        Guna2PictureBox1.ImageRotate = 0F
        Guna2PictureBox1.Location = New Point(582, -2)
        Guna2PictureBox1.Name = "Guna2PictureBox1"
        Guna2PictureBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges11
        Guna2PictureBox1.Size = New Size(455, 597)
        Guna2PictureBox1.TabIndex = 0
        Guna2PictureBox1.TabStop = False
        ' 
        ' closeButton
        ' 
        closeButton.BackColor = Color.White
        closeButton.CheckedState.ImageSize = New Size(64, 64)
        closeButton.HoverState.ImageSize = New Size(64, 64)
        closeButton.Image = CType(resources.GetObject("closeButton.Image"), Image)
        closeButton.ImageOffset = New Point(0, 0)
        closeButton.ImageRotate = 0F
        closeButton.ImageSize = New Size(20, 20)
        closeButton.Location = New Point(974, 12)
        closeButton.Name = "closeButton"
        closeButton.PressedState.ImageSize = New Size(64, 64)
        closeButton.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        closeButton.Size = New Size(30, 30)
        closeButton.TabIndex = 1
        ' 
        ' Guna2TextBox1
        ' 
        Guna2TextBox1.BackColor = Color.White
        Guna2TextBox1.BorderRadius = 5
        Guna2TextBox1.CustomizableEdges = CustomizableEdges13
        Guna2TextBox1.DefaultText = ""
        Guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        Guna2TextBox1.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        Guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox1.Font = New Font("Jellee Bold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2TextBox1.ForeColor = Color.Black
        Guna2TextBox1.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox1.Location = New Point(626, 186)
        Guna2TextBox1.Margin = New Padding(4)
        Guna2TextBox1.Name = "Guna2TextBox1"
        Guna2TextBox1.PasswordChar = ChrW(0)
        Guna2TextBox1.PlaceholderText = "Username"
        Guna2TextBox1.SelectedText = ""
        Guna2TextBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges14
        Guna2TextBox1.Size = New Size(358, 54)
        Guna2TextBox1.TabIndex = 2
        ' 
        ' Guna2TextBox2
        ' 
        Guna2TextBox2.BackColor = Color.White
        Guna2TextBox2.BorderRadius = 5
        Guna2TextBox2.CustomizableEdges = CustomizableEdges15
        Guna2TextBox2.DefaultText = ""
        Guna2TextBox2.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        Guna2TextBox2.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        Guna2TextBox2.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox2.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox2.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox2.Font = New Font("Jellee Bold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2TextBox2.ForeColor = Color.Black
        Guna2TextBox2.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox2.Location = New Point(626, 278)
        Guna2TextBox2.Margin = New Padding(4)
        Guna2TextBox2.Name = "Guna2TextBox2"
        Guna2TextBox2.PasswordChar = "*"c
        Guna2TextBox2.PlaceholderText = "Password"
        Guna2TextBox2.SelectedText = ""
        Guna2TextBox2.ShadowDecoration.CustomizableEdges = CustomizableEdges16
        Guna2TextBox2.Size = New Size(358, 54)
        Guna2TextBox2.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.White
        Label1.Font = New Font("Jellee Bold", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(751, 99)
        Label1.Name = "Label1"
        Label1.Size = New Size(121, 42)
        Label1.TabIndex = 4
        Label1.Text = "Log In"
        ' 
        ' Guna2Button1
        ' 
        Guna2Button1.BackColor = Color.White
        Guna2Button1.BorderColor = Color.Blue
        Guna2Button1.BorderRadius = 15
        Guna2Button1.BorderThickness = 2
        Guna2Button1.Cursor = Cursors.Hand
        Guna2Button1.CustomizableEdges = CustomizableEdges17
        Guna2Button1.DisabledState.BorderColor = Color.DarkGray
        Guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button1.FillColor = Color.Blue
        Guna2Button1.Font = New Font("Jellee Bold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2Button1.ForeColor = Color.White
        Guna2Button1.HoverState.BorderColor = Color.Blue
        Guna2Button1.HoverState.FillColor = Color.DodgerBlue
        Guna2Button1.HoverState.Font = New Font("Jellee Bold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2Button1.Location = New Point(719, 395)
        Guna2Button1.Name = "Guna2Button1"
        Guna2Button1.ShadowDecoration.CustomizableEdges = CustomizableEdges18
        Guna2Button1.Size = New Size(174, 69)
        Guna2Button1.TabIndex = 5
        Guna2Button1.Text = "Submit"
        ' 
        ' forgotPassword
        ' 
        forgotPassword.AutoSize = True
        forgotPassword.BackColor = Color.White
        forgotPassword.Cursor = Cursors.Hand
        forgotPassword.Font = New Font("Jellee Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        forgotPassword.ForeColor = SystemColors.ActiveBorder
        forgotPassword.Location = New Point(837, 336)
        forgotPassword.Name = "forgotPassword"
        forgotPassword.Size = New Size(147, 18)
        forgotPassword.TabIndex = 6
        forgotPassword.Text = "Forgot Passowrd ?"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.White
        Label2.Font = New Font("Jellee Bold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ActiveBorder
        Label2.Location = New Point(751, 505)
        Label2.Name = "Label2"
        Label2.Size = New Size(114, 22)
        Label2.TabIndex = 7
        Label2.Text = "New User ?"
        ' 
        ' login
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1016, 591)
        Controls.Add(Label2)
        Controls.Add(forgotPassword)
        Controls.Add(Guna2Button1)
        Controls.Add(Label1)
        Controls.Add(Guna2TextBox2)
        Controls.Add(Guna2TextBox1)
        Controls.Add(closeButton)
        Controls.Add(Guna2PictureBox1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "login"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        CType(Guna2PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents closeButton As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TextBox2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents forgotPassword As Label
    Friend WithEvents Label2 As Label

End Class
