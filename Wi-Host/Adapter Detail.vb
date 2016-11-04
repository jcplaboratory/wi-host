Public Class Adapter_Detail

    Private Sub Adapter_Detail_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        dt.Text = Nothing
    End Sub

    Private Sub Adapter_Detail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim datloc As String
        datloc = Application.StartupPath & "\data.dat"
        Dim clear As New System.IO.StreamWriter(datloc)
        clear.Write("")
        clear.Close()
        Dim status As New ProcessStartInfo
        status.FileName = "cmd.exe"
        status.Arguments = "/c netsh wlan show drivers>>" & """" & Application.StartupPath & "\data.dat" & """"
        status.WindowStyle = ProcessWindowStyle.Hidden
        Process.Start(status).WaitForExit()
        Dim appdata As New System.IO.StreamReader(datloc)
        dt.Text = appdata.ReadToEnd
        appdata.Close()
    End Sub

    Private Sub cmdok_Click(sender As Object, e As EventArgs) Handles cmdok.Click
        Me.Close()
    End Sub
End Class