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
        'Remove realms3.gog
        My.Computer.FileSystem.DeleteFile(SteamDir.Text & "\realms3.gog")
        'Copy Riva.img and rename
        My.Computer.FileSystem.CopyFile(RivaImg.Text & "\RIVA.img", SteamDir.Text & "\RIVA.img")
        My.Computer.FileSystem.RenameFile(SteamDir.Text & "\RIVA.img", "realms3.gog")
        'Remove Data Dir
        If Directory.Exists(SteamDir.Text & "\DATA") Then
            'Delete all files from DATA Dir
            For Each filepath As String In Directory.GetFiles(SteamDir.Text & "\DATA")
                File.Delete(filepath)
            Next
            'Delete DATA Dir
            Directory.Delete(SteamDir.Text & "\DATA")
        End If
        'Remove Data Dir
        If Directory.Exists(SteamDir.Text & "\GAMES") Then
            'Delete all files from DATA Dir
            For Each filepath As String In Directory.GetFiles(SteamDir.Text & "\GAMES")
                File.Delete(filepath)
            Next
            'Delete DATA Dir
            Directory.Delete(SteamDir.Text & "\GAMES")
        End If
        'Copy Data Dir
        My.Computer.FileSystem.CopyDirectory(RivaDir.Text & "\DATA", SteamDir.Text & "\DATA")
        My.Computer.FileSystem.CopyDirectory(RivaDir.Text & "\GAMES", SteamDir.Text & "\GAMES")
        MsgBox("Valmista tuli!", MsgBoxStyle.Information, "Valmista!")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        MsgBox("Versio 0.1, nopeasti väsätty sekasotku (joka toimii!).... Discordissa yhteys Alt#0666")
    End Sub
End Class
