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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SteamDir = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.RivaImg = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.RivaDir = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SteamPathDlg = New System.Windows.Forms.FolderBrowserDialog()
        Me.RivaIMGPath = New System.Windows.Forms.FolderBrowserDialog()
        Me.RivaPath = New System.Windows.Forms.FolderBrowserDialog()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Missä Steam -versio sijaitsee?"
        '
        'SteamDir
        '
        Me.SteamDir.Location = New System.Drawing.Point(12, 152)
        Me.SteamDir.Name = "SteamDir"
        Me.SteamDir.Size = New System.Drawing.Size(392, 20)
        Me.SteamDir.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 178)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Valitse..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 262)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(105, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Valitse..."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'RivaImg
        '
        Me.RivaImg.Location = New System.Drawing.Point(12, 236)
        Me.RivaImg.Name = "RivaImg"
        Me.RivaImg.Size = New System.Drawing.Size(392, 20)
        Me.RivaImg.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 220)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(192, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Valitse kansio, jossa RIVA.img sijaitsee:"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(12, 365)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(105, 23)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Valitse..."
        Me.Button3.UseVisualStyleBackColor = True
        '
        'RivaDir
        '
        Me.RivaDir.Location = New System.Drawing.Point(12, 339)
        Me.RivaDir.Name = "RivaDir"
        Me.RivaDir.Size = New System.Drawing.Size(392, 20)
        Me.RivaDir.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 310)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(257, 26)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Valitse Varjojen Kaupunki Riva -pelin asennuskansio." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Tässä kansiossa sijaitsevat" &
    " kansiot DATA, GAMES..."
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(12, 414)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(392, 31)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "Suorita"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.RivaPatch.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(12, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(403, 134)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 457)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.RivaDir)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.RivaImg)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.SteamDir)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.Text = "Varjojen Kaupunki Riva STEAM"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents SteamDir As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents RivaImg As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents RivaDir As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents SteamPathDlg As FolderBrowserDialog
    Friend WithEvents RivaIMGPath As FolderBrowserDialog
    Friend WithEvents RivaPath As FolderBrowserDialog
    Friend WithEvents PictureBox1 As PictureBox
End Class
