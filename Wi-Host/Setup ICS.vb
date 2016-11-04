Public Class Setup_ICS

    Private Sub cmdok_Click(sender As Object, e As EventArgs) Handles cmdok.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim net As New ProcessStartInfo
        net.FileName = "control.exe"
        net.Arguments = "netconnections"
        Process.Start(net).WaitForExit()
    End Sub
End Class