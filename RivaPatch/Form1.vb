Imports System.IO

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
        MsgBox("Versio " + My.Application.Info.Version.ToString + Environment.NewLine + "Tää oli tässä Edition." + Environment.NewLine + Environment.NewLine + "Tässä versiossa pitäs olla kaikki kondiksessa, mutta jos jotain virheitä ilmenee, ota yhteys Discordissa Alt#0666." + Environment.NewLine + "-Alt", MsgBoxStyle.Information, "Tietoa")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Background Color
        Me.BackColor = ColorTranslator.FromHtml("#36393E") 'Background
        Me.ForeColor = Color.White 'Form text
        PictureBox1.Focus()
    End Sub

    Private Sub redbookost_CheckedChanged(sender As Object, e As EventArgs) Handles redbookost.CheckedChanged

    End Sub

    Private Sub midiost_CheckedChanged(sender As Object, e As EventArgs) Handles midiost.CheckedChanged

    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub RivaDir_TextChanged(sender As Object, e As EventArgs) Handles RivaDir.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub RivaImg_TextChanged(sender As Object, e As EventArgs) Handles RivaImg.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub SteamDir_TextChanged(sender As Object, e As EventArgs) Handles SteamDir.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
