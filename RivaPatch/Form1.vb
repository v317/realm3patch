Imports System.IO
Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Threading

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (SteamPathDlg.ShowDialog() = DialogResult.OK) Then
            SteamDir.Text = SteamPathDlg.SelectedPath
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (RivaIMGPath.ShowDialog() = DialogResult.OK) Then
            RivaImg.Text = RivaIMGPath.SelectedPath
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (RivaPath.ShowDialog() = DialogResult.OK) Then
            RivaDir.Text = RivaPath.SelectedPath
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If SteamDir.Text = "" Then
            MsgBox("Hups! Taisit unohtaa jotakin! Syötä Steam -version hakemisto.", MsgBoxStyle.Critical, "Virhe!")
        ElseIf RivaImg.Text = "" Then
            MsgBox("Hups! Taisit unohtaa jotakin! Syötä RIVA.IMG -tiedoston hakemisto.", MsgBoxStyle.Critical, "Virhe!")
        ElseIf RivaDir.Text = "" Then
            MsgBox("Hups! Taisit unohtaa jotakin! Syötä asennetun Varjojen kaupunki Riva -pelin hakemisto.", MsgBoxStyle.Critical, "Virhe!")
        Else
            ProgressBar1.Value = 0
            Try
                'Remove realms3.gog
                If My.Computer.FileSystem.FileExists(SteamDir.Text & "\realms3.gog") Then
                    My.Computer.FileSystem.DeleteFile(SteamDir.Text & "\realms3.gog")
                Else
                    MsgBox("Virhe: realms3.gog ei löydy. Päivitys epäonnistuu!", MsgBoxStyle.Critical, "Virhe!")
                End If
                'Copy Riva.img and rename
                If My.Computer.FileSystem.FileExists(RivaImg.Text & "\RIVA.img") Then
                    My.Computer.FileSystem.CopyFile(RivaImg.Text & "\RIVA.img", SteamDir.Text & "\RIVA.img")
                    My.Computer.FileSystem.RenameFile(SteamDir.Text & "\RIVA.img", "realms3.gog")
                Else
                    MsgBox("Virhe: RIVA.img ei löydy. Päivitys epäonnistuu!", MsgBoxStyle.Critical, "Virhe!")
                End If
                'Remove Data Dir
                If Directory.Exists(SteamDir.Text & "\DATA") Then
                    'Delete all files from DATA Dir
                    For Each filepath As String In Directory.GetFiles(SteamDir.Text & "\DATA")
                        File.Delete(filepath)
                    Next
                    'Delete DATA Dir
                    Directory.Delete(SteamDir.Text & "\DATA")
                Else
                    MsgBox("Virhe: DATA hakemistoa ei löydy. Päivitys epäonnistuu!", MsgBoxStyle.Critical, "Virhe!")
                End If
                'Remove Data Dir
                If Directory.Exists(SteamDir.Text & "\GAMES") Then
                    'Delete all files from DATA Dir
                    For Each filepath As String In Directory.GetFiles(SteamDir.Text & "\GAMES")
                        File.Delete(filepath)
                    Next
                    'Delete DATA Dir
                    Directory.Delete(SteamDir.Text & "\GAMES")
                Else
                    MsgBox("Virhe: GAMES hakemistoa ei löydy. Päivitys epäonnistuu!", MsgBoxStyle.Critical, "Virhe!")
                End If
                'Copy Data Dir
                My.Computer.FileSystem.CopyDirectory(RivaDir.Text & "\DATA", SteamDir.Text & "\DATA")
                My.Computer.FileSystem.CopyDirectory(RivaDir.Text & "\GAMES", SteamDir.Text & "\GAMES")

                'Change Soundtrack
                If midiost.Checked = True Then
                    IO.File.WriteAllBytes(SteamDir.Text & "\realms3.inst", My.Resources.realms3)
                ElseIf redbookost.Checked = True Then
                    IO.File.WriteAllBytes(SteamDir.Text & "\realms3.inst", My.Resources.redbook)
                End If
                ProgressBar1.Value = 100
                MsgBox("Valmista tuli! Käynnistä peli Steamin avulla!", MsgBoxStyle.Information, "Valmista!")
            Catch ex As Exception
                MsgBox("Virheitä ilmeni. Muutoksia ei tehty!", MsgBoxStyle.Critical, "Virhe!")
            End Try
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        MsgBox("Versio " + My.Application.Info.Version.ToString + Environment.NewLine + "Yks päivitys vielä EDITION" + Environment.NewLine + Environment.NewLine + " Jos ohjelman kanssa on ongelmia, ota yhteys Discordissa Alt#0666." + Environment.NewLine + "-Alt", MsgBoxStyle.Information, "Tietoa")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Background Color
        Me.BackColor = ColorTranslator.FromHtml("#36393E") 'Background
        Me.ForeColor = Color.White 'Form text
        SteamDir.Select(0, 0)
        PictureBox1.Focus()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MsgBox("Saat tarvittavat kansiot seuraavilla tavoilla:" + Environment.NewLine + "1. Voit asentaa pelin käyttämällä DOSBOXia" + Environment.NewLine + "2. Avaamalla levykuvan WinCDEMu'lla ja kopioimalla kansiot levyltä esimerkiksi samaan kansioon RIVA.img kanssa. Suosittelen tätä tapaa, sillä se on helpompaa ja toimii varmasti. DOSBoxilla pelin asennus on vaativampaa ja vaatii osaamista ohjelman käytön kanssa.", MsgBoxStyle.Information, "Vinkki")

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If SteamDir.Text = "" Then
            MsgBox("Hups! Taisit unohtaa jotakin! Syötä Steam -version hakemisto.", MsgBoxStyle.Critical, "Virhe!")
        Else
            'Change Soundtrack
            If midiost.Checked = True Then
                IO.File.WriteAllBytes(SteamDir.Text & "\realms3.inst", My.Resources.realms3)
                MsgBox("Sountrack vaihdettiin: Alkuperäinen MIDI ", MsgBoxStyle.Information, "Valmista!")
            ElseIf redbookost.Checked = True Then
                IO.File.WriteAllBytes(SteamDir.Text & "\realms3.inst", My.Resources.redbook)
                MsgBox("Sountrack vaihdettiin: Steam Redbook CD ", MsgBoxStyle.Information, "Valmista!")
            End If
        End If
    End Sub

    Private Sub PalautaSteamvarmuuskopiotToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PalautaSteamvarmuuskopiotToolStripMenuItem.Click
        Dim result As DialogResult = MessageBox.Show("Haluatko palauttaa STEAM -version varmuuskopiot?", "Varmuuskopiointi", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            'Käyttäjä perui
        ElseIf result = DialogResult.Yes Then
            'Käyttäjä varmuuskopioi
            If My.Computer.FileSystem.DirectoryExists(SteamDir.Text + "\SaveBackup") Then
                My.Computer.FileSystem.CopyDirectory(SteamDir.Text + "\SaveBackup", SteamDir.Text & "\GAMES", True)
                MsgBox("Varmuuskopiot palautettiin!", MsgBoxStyle.Information, "Valmista!")
            Else
                MsgBox("Jokin meni vikaan...", MsgBoxStyle.Exclamation, "Outoa!")
            End If
        End If
    End Sub

    Private Sub VarmuuskopioiSteamtallenuksetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VarmuuskopioiSteamtallenuksetToolStripMenuItem.Click
        Dim result As DialogResult = MessageBox.Show("Haluatko varmuuskopioida STEAM -version tallenukset?", "Varmuuskopiointi", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            'Käyttäjä perui
        ElseIf result = DialogResult.Yes Then
            'Käyttäjä varmuuskopioi
            If My.Computer.FileSystem.DirectoryExists(SteamDir.Text + "\SaveBackup") Then
                My.Computer.FileSystem.CopyDirectory(SteamDir.Text + "\GAMES", SteamDir.Text & "\SaveBackup", True)
                MsgBox("Tiedostot varmuuskopioitiin. Löydät ne täältä: " + SteamDir.Text + "\SaveBackup", MsgBoxStyle.Information, "Valmista!")
            Else
                My.Computer.FileSystem.CreateDirectory(SteamDir.Text + "\SaveBackup")
                My.Computer.FileSystem.CopyDirectory(SteamDir.Text + "\GAMES", SteamDir.Text & "\SaveBackup", True)
                MsgBox("Tiedostot varmuuskopioitiin. Löydät ne täältä: " + SteamDir.Text + "\SaveBackup", MsgBoxStyle.Information, "Valmista!")
            End If
        End If
    End Sub
End Class
