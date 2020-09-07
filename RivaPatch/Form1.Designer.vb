<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SteamPathDlg = New System.Windows.Forms.FolderBrowserDialog()
        Me.RivaIMGPath = New System.Windows.Forms.FolderBrowserDialog()
        Me.RivaPath = New System.Windows.Forms.FolderBrowserDialog()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.midiost = New System.Windows.Forms.RadioButton()
        Me.redbookost = New System.Windows.Forms.RadioButton()
        Me.RivaDir = New System.Windows.Forms.TextBox()
        Me.RivaImg = New System.Windows.Forms.TextBox()
        Me.SteamDir = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TiedostoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PoistuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExtraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VarmuuskopiointiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VarmuuskopioiSteamtallenuksetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PalautaSteamvarmuuskopiotToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 201)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(280, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Missä Steam -versio sijaitsee? Valitse pelin hakemisto:"
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(12, 245)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Valitse..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(12, 327)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(105, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Valitse..."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 283)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(223, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Valitse hakemisto, jossa RIVA.img sijaitsee:"
        '
        'Button3
        '
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(12, 421)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(105, 23)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Valitse..."
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 361)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(262, 26)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Valitse Varjojen Kaupunki Riva -pelin hakemisto:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Tässä kansiossa sijaitsevat kan" &
    "siot DATA, GAMES..."
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Location = New System.Drawing.Point(12, 524)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(406, 31)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "Suorita"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 594)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(406, 20)
        Me.ProgressBar1.TabIndex = 11
        '
        'midiost
        '
        Me.midiost.AutoSize = True
        Me.midiost.Checked = True
        Me.midiost.Location = New System.Drawing.Point(12, 478)
        Me.midiost.Name = "midiost"
        Me.midiost.Size = New System.Drawing.Size(127, 17)
        Me.midiost.TabIndex = 12
        Me.midiost.TabStop = True
        Me.midiost.Text = "Alkuperäinen (MIDI)"
        Me.midiost.UseVisualStyleBackColor = True
        '
        'redbookost
        '
        Me.redbookost.AutoSize = True
        Me.redbookost.Location = New System.Drawing.Point(12, 501)
        Me.redbookost.Name = "redbookost"
        Me.redbookost.Size = New System.Drawing.Size(144, 17)
        Me.redbookost.TabIndex = 13
        Me.redbookost.Text = "Redbook Audioon (CD)"
        Me.redbookost.UseVisualStyleBackColor = True
        '
        'RivaDir
        '
        Me.RivaDir.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.RivaPatch.My.MySettings.Default, "DATADirectory", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.RivaDir.Location = New System.Drawing.Point(12, 390)
        Me.RivaDir.Name = "RivaDir"
        Me.RivaDir.ReadOnly = True
        Me.RivaDir.Size = New System.Drawing.Size(406, 22)
        Me.RivaDir.TabIndex = 7
        Me.RivaDir.Text = Global.RivaPatch.My.MySettings.Default.DATADirectory
        '
        'RivaImg
        '
        Me.RivaImg.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.RivaPatch.My.MySettings.Default, "RivaIMGDirectory", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.RivaImg.Location = New System.Drawing.Point(12, 299)
        Me.RivaImg.Name = "RivaImg"
        Me.RivaImg.ReadOnly = True
        Me.RivaImg.Size = New System.Drawing.Size(406, 22)
        Me.RivaImg.TabIndex = 4
        Me.RivaImg.Text = Global.RivaPatch.My.MySettings.Default.RivaIMGDirectory
        '
        'SteamDir
        '
        Me.SteamDir.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.RivaPatch.My.MySettings.Default, "SteamDirectory", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.SteamDir.Location = New System.Drawing.Point(12, 217)
        Me.SteamDir.Name = "SteamDir"
        Me.SteamDir.ReadOnly = True
        Me.SteamDir.Size = New System.Drawing.Size(406, 22)
        Me.SteamDir.TabIndex = 1
        Me.SteamDir.Text = Global.RivaPatch.My.MySettings.Default.SteamDirectory
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(420, 65)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = resources.GetString("Label4.Text")
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.RivaPatch.My.Resources.Resources.logo1
        Me.PictureBox1.Location = New System.Drawing.Point(12, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(409, 84)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Segoe UI", 8.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.White
        Me.LinkLabel1.Location = New System.Drawing.Point(123, 426)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(117, 13)
        Me.LinkLabel1.TabIndex = 15
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "...En ole asentanut peliä"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 454)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Valitse Soundtrack:"
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.Black
        Me.Button7.Location = New System.Drawing.Point(12, 557)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(406, 31)
        Me.Button7.TabIndex = 21
        Me.Button7.Text = "Vaihda vain Soundtrack"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TiedostoToolStripMenuItem, Me.ExtraToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(435, 24)
        Me.MenuStrip1.TabIndex = 22
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TiedostoToolStripMenuItem
        '
        Me.TiedostoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PoistuToolStripMenuItem})
        Me.TiedostoToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.TiedostoToolStripMenuItem.Name = "TiedostoToolStripMenuItem"
        Me.TiedostoToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.TiedostoToolStripMenuItem.Text = "Tiedosto"
        '
        'PoistuToolStripMenuItem
        '
        Me.PoistuToolStripMenuItem.Name = "PoistuToolStripMenuItem"
        Me.PoistuToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PoistuToolStripMenuItem.Text = "Poistu"
        '
        'ExtraToolStripMenuItem
        '
        Me.ExtraToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VarmuuskopiointiToolStripMenuItem})
        Me.ExtraToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ExtraToolStripMenuItem.Name = "ExtraToolStripMenuItem"
        Me.ExtraToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.ExtraToolStripMenuItem.Text = "Extra"
        '
        'VarmuuskopiointiToolStripMenuItem
        '
        Me.VarmuuskopiointiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VarmuuskopioiSteamtallenuksetToolStripMenuItem, Me.PalautaSteamvarmuuskopiotToolStripMenuItem})
        Me.VarmuuskopiointiToolStripMenuItem.Name = "VarmuuskopiointiToolStripMenuItem"
        Me.VarmuuskopiointiToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.VarmuuskopiointiToolStripMenuItem.Text = "Varmuuskopiointi"
        '
        'VarmuuskopioiSteamtallenuksetToolStripMenuItem
        '
        Me.VarmuuskopioiSteamtallenuksetToolStripMenuItem.Name = "VarmuuskopioiSteamtallenuksetToolStripMenuItem"
        Me.VarmuuskopioiSteamtallenuksetToolStripMenuItem.Size = New System.Drawing.Size(251, 22)
        Me.VarmuuskopioiSteamtallenuksetToolStripMenuItem.Text = "Varmuuskopioi Steam-tallenukset"
        '
        'PalautaSteamvarmuuskopiotToolStripMenuItem
        '
        Me.PalautaSteamvarmuuskopiotToolStripMenuItem.Name = "PalautaSteamvarmuuskopiotToolStripMenuItem"
        Me.PalautaSteamvarmuuskopiotToolStripMenuItem.Size = New System.Drawing.Size(251, 22)
        Me.PalautaSteamvarmuuskopiotToolStripMenuItem.Text = "Palauta Steam-varmuuskopiot"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 623)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.redbookost)
        Me.Controls.Add(Me.midiost)
        Me.Controls.Add(Me.ProgressBar1)
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
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Varjojen Kaupunki Riva STEAM"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
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
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents midiost As RadioButton
    Friend WithEvents redbookost As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label5 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TiedostoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PoistuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExtraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VarmuuskopiointiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VarmuuskopioiSteamtallenuksetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PalautaSteamvarmuuskopiotToolStripMenuItem As ToolStripMenuItem
End Class
