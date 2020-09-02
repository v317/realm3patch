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
        ProgressBar1.Value = 0
        'Remove realms3.gog
        If My.Computer.FileSystem.FileExists(SteamDir.Text & "\realms3.gog") Then
            My.Computer.FileSystem.DeleteFile(SteamDir.Text & "\realms3.gog")
        Else
            MsgBox("Error: realms3.gog missing!")
        End If
        'Copy Riva.img and rename
        If My.Computer.FileSystem.FileExists(RivaImg.Text & "\RIVA.img") Then
            My.Computer.FileSystem.CopyFile(RivaImg.Text & "\RIVA.img", SteamDir.Text & "\RIVA.img")
            My.Computer.FileSystem.RenameFile(SteamDir.Text & "\RIVA.img", "realms3.gog")
        Else
            MsgBox("Error: RIVA.img missing!")
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
            MsgBox("Error: DATA directory missing!")
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
            MsgBox("Error: GAMES directory missing!")
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
        MsgBox("Valmista tuli!", MsgBoxStyle.Information, "Valmista!")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        MsgBox("Versio 0.2, 'Toimii paremmin Edition'" & Environment.NewLine & "Ongelmissa ota yhteys Discordissa Alt#0666")
    End Sub
End Class
