Public Class mainboard
#Region "Hosted Network Check"
    Sub hostednetworkcheck(ByVal typeofresult As String)
        Dim datloc As String
        datloc = Application.StartupPath & "\data.dat"
        Dim clear As New System.IO.StreamWriter(datloc)
        clear.Write("")
        clear.Close()
        Dim status As New ProcessStartInfo
        status.FileName = "cmd.exe"
        status.Arguments = "/c netsh wlan show drivers | find " & """" & "Hosted network supported" & """" & ">>" & """" & Application.StartupPath & "\data.dat" & """"
        status.WindowStyle = ProcessWindowStyle.Hidden
        Process.Start(status).WaitForExit()
        Dim appdata As New System.IO.StreamReader(datloc)
        Dim msg As String
        msg = appdata.ReadToEnd
        appdata.Close()
        Try
            If InStr(msg, "No", CompareMethod.Text) Then
                If typeofresult = "Check1" Then
                    MsgBox("Your Wifi Adapter does not support " & """" & "Hosted Network" & """" & ".", MsgBoxStyle.Critical, "Wi-Host | Hosted Network Not Supported")
                Else
                    lblsns_true.Text = "No"
                End If
            ElseIf InStr(msg, "Yes", CompareMethod.Text) Then
                If typeofresult = "Check1" Then
                    MsgBox("Your Wifi Adapter supports " & """" & "Hosted Network" & """" & ".", MsgBoxStyle.Information, "Wi-Host | Hosted Network Supported")
                Else
                    lblsns_true.Text = "Yes"
                End If
            End If
        Catch ex As Exception
            MsgBox("We could not check if your Wi-Fi Adapter supports hosted network", vbCritical)
        End Try
    End Sub
#End Region
#Region "Hosted Network Start/Stop"
    Sub stophostednetwork(ByVal return_type As String)
        Dim datloc As String
        datloc = Application.StartupPath & "\data.dat"
        Dim cleardata As New System.IO.StreamWriter(datloc)
        cleardata.Write("")
        cleardata.Close()
        Dim pro As New ProcessStartInfo
        pro.FileName = "cmd.exe"
        pro.Arguments = "/c netsh wlan stop hostednetwork>>" & """" & Application.StartupPath & "\data.dat" & """"
        pro.WindowStyle = ProcessWindowStyle.Hidden
        Process.Start(pro).WaitForExit()
        Dim appdata2 As New System.IO.StreamReader(datloc)
        Dim msg As String = appdata2.ReadToEnd
        appdata2.Close()
        Call registrycheck("Write Off")
        cmdstop.Enabled = False
        cmdstart.Enabled = True
        If return_type = "Msg" Then
            MsgBox(msg, MsgBoxStyle.Information, "Wi-Host | Network Status")
        ElseIf return_type = "Nothing" Then
            'do nothing
        End If
    End Sub
    Sub starthostednetwork(ByVal return_type As String)
        Dim datloc As String
        datloc = Application.StartupPath & "\data.dat"
        Dim cleardata As New System.IO.StreamWriter(datloc)
        cleardata.Write("")
        cleardata.Close()
        Dim pro As New ProcessStartInfo
        pro.FileName = "cmd.exe"
        pro.Arguments = "/c netsh wlan start hostednetwork>>" & """" & Application.StartupPath & "\data.dat" & """"
        pro.WindowStyle = ProcessWindowStyle.Hidden
        Process.Start(pro).WaitForExit()
        Dim appdata2 As New System.IO.StreamReader(datloc)
        Dim msg As String = appdata2.ReadToEnd
        appdata2.Close()
        If InStr(msg, "couldn't be started", CompareMethod.Text) Then
            'do nothing
        Else
            Call registrycheck("Write On")
            cmdstart.Enabled = False
            cmdstop.Enabled = True
            Setup_ICS.ShowDialog()
        End If
        If return_type = "Msg" Then
            MsgBox(msg, MsgBoxStyle.Information, "Wi-Host | Network Status")
        ElseIf return_type = "Nothing" Then
            'do nothing
        End If
    End Sub
#End Region
#Region "Registry Value Checker"
    Sub registrycheck(ByVal typeOfSearch As String)
        Try
            If typeOfSearch = "Standard" Then
                Dim mykey As Microsoft.Win32.RegistryKey
                mykey = My.Computer.Registry.LocalMachine.CreateSubKey("SOFTWARE\J.C.P Laboratory\Wi-Host")
                Dim val As Integer = mykey.GetValue("First RUN")
                If val = 1 Then
                    val = mykey.GetValue("Wi-Fi Status")
                    If val = 1 Then
                        cmdstart.Enabled = False
                    ElseIf val = 0 Then
                        cmdstop.Enabled = False
                    End If
                Else
                    mykey = My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\J.C.P Laboratory\Wi-Host\", True)
                    mykey.SetValue("Wi-Fi Status", 0)
                    mykey.SetValue("First RUN", 1)
                    Call stophostednetwork("Nothing")
                    cmdstop.Enabled = False
                End If
            ElseIf typeOfSearch = "Write On" Then
                Dim mykey As Microsoft.Win32.RegistryKey
                mykey = My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\J.C.P Laboratory\Wi-Host\", True)
                mykey.SetValue("Wi-Fi Status", 1)
            ElseIf typeOfSearch = "Write Off" Then
                Dim mykey As Microsoft.Win32.RegistryKey
                mykey = My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\J.C.P Laboratory\Wi-Host\", True)
                mykey.SetValue("Wi-Fi Status", 0)
            End If
        Catch ex As Exception
            MsgBox("System update failed. Cannot access the system's registry settings.", MsgBoxStyle.Critical, "Wi-Host | Access was denied accessing the registry")
        End Try
    End Sub
#End Region
#Region "Hosted Network Status"
    Sub network_status()
        Dim datloc As String
        datloc = Application.StartupPath & "\data.dat"
        Dim clear As New System.IO.StreamWriter(datloc)
        clear.Write("")
        clear.Close()
        Dim status As New ProcessStartInfo
        status.FileName = "cmd.exe"
        status.Arguments = "/c netsh wlan show hostednetwork>>" & """" & Application.StartupPath & "\data.dat" & """"
        status.WindowStyle = ProcessWindowStyle.Hidden
        Process.Start(status).WaitForExit()
        Dim appdatard As New System.IO.StreamReader(datloc)
        comstatus.Text = appdatard.ReadToEnd
        appdatard.Close()
        comtypeau.Text = "WPA2-Personal"
        commode.Text = "Allow"
    End Sub
#End Region
    Private Sub mainboard_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If System.IO.File.Exists(Application.StartupPath & "\data.dat") = True Then
            Kill(Application.StartupPath & "\data.dat")
        End If
    End Sub

    Private Sub mainboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call IsUserAdministrator()
        If IsUserAdministrator() = True Then
            Dim build As Integer = Environment.OSVersion.Version.Build
            If build >= 5999 Then
                'create resource registry
                Call registrycheck("Standard")
                'checks wireless interface presence.
                Dim datloc As String
                Dim sysload As Boolean = False
                datloc = Application.StartupPath & "\data.dat"
                Dim clearwnp As New System.IO.StreamWriter(datloc)
                clearwnp.Write("")
                clearwnp.Close()
                Dim wnp As New ProcessStartInfo
                wnp.FileName = "cmd.exe"
                wnp.Arguments = "/c netsh wlan show drivers" & ">>" & """" & Application.StartupPath & "\data.dat" & """"
                wnp.WindowStyle = ProcessWindowStyle.Hidden
                Process.Start(wnp).WaitForExit()
                Dim appdata As New System.IO.StreamReader(datloc)
                Dim msg As String
                msg = appdata.ReadToEnd
                appdata.Close()
                If InStr(msg, "There is no wireless interface on the system", CompareMethod.Text) Then
                    MsgBox("Whether your system is not equipped with a Wireless Interface Card or it has an incorrect configuration.", MsgBoxStyle.Critical, "Wi-Host | Wireless Interface Not Found")
                    Button1.Enabled = False
                    comstatus.Text = "Whether your system is not" & vbNewLine & "equipped with a Wireless Interface Card" & vbNewLine & "or it has an incorrect configuration." & vbNewLine & vbNewLine & "Please check if your Wifi Adapter has been properly installed and turned on."
                    comstatus.ForeColor = Color.OrangeRed
                    cmdhns.Enabled = False
                    GroupBox3.Enabled = False
                    lblsns_true.Visible = False
                    Label11.Visible = False
                    HostedNetworkSupportedToolStripMenuItem.Enabled = False
                    SetupNewHostedNetworkToolStripMenuItem.Enabled = False
                Else
                    sysload = True
                    lblinterface_true.Text = "Yes"
                End If
                'status load
                If sysload = True Then
                    Call network_status()
                    Call hostednetworkcheck("Check2")
                End If
            Else
                MsgBox("A newer version of Microsoft Windows is required to run this application." & vbNewLine & "At least Microsoft Windows Vista", vbCritical)
            End If
        Else
            MsgBox("Wi-Host requires administrative rights to operate properly. Please restart this App as admin.", vbCritical, "Wi-Host | Requires Elevated Privileges")
            Me.Close()
            Application.Exit()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TabControl.SelectTab(1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Adapter_Detail.ShowDialog()
    End Sub

    Private Sub cmdhns_Click(sender As Object, e As EventArgs) Handles cmdhns.Click
        Call hostednetworkcheck("Check1")
    End Sub

    Private Sub ok_Click(sender As Object, e As EventArgs) Handles ok.Click
        Dim datloc As String
        Dim done As Boolean = False
        datloc = Application.StartupPath & "\data.dat"
        If txtspw.Text = Nothing And txtssid.Text = Nothing Then
            MsgBox("It looks like there are some fields empty. Please fill out all fields and try again.", vbExclamation, "Wi-Host | Missing Fields")
        Else
            If txtspw.TextLength = 8 Or txtspw.TextLength >= 8 Then
                Dim clear As New System.IO.StreamWriter(datloc)
                clear.Write("")
                clear.Close()
                If txtssid.Text <> Nothing Then
                    Dim nnet As New ProcessStartInfo
                    nnet.FileName = "cmd.exe"
                    nnet.Arguments = "/c netsh wlan set hostednetwork mode=" & commode.Text & " ssid=" & """" & txtssid.Text & """" & " key=" & """" & txtspw.Text & """" & ">>" & """" & Application.StartupPath & "\data.dat" & """"
                    nnet.WindowStyle = ProcessWindowStyle.Hidden
                    Process.Start(nnet).WaitForExit()
                    Dim appdata As New System.IO.StreamReader(datloc)
                    MsgBox("Hosted Network was sucessfully setup." & vbNewLine & vbNewLine & "Network SSID: " & txtssid.Text & vbNewLine & "Password: " & txtspw.Text & vbNewLine & vbNewLine & appdata.ReadToEnd, vbInformation, "Wi-Host | Hosted Network set")
                    appdata.Close()
                    done = True
                Else
                    MsgBox("The Network name (SSID) is missing. Please setup a network name.", vbExclamation, "Wi-Host | SSID Not Set")
                    txtssid.Focus()
                End If
            Else
                MsgBox("The password must be a minimum of eight characters. Please check your password.", vbExclamation, "Wi-Host | Password Invalid")
                txtspw.Focus()
            End If

            If done = True Then
                Dim cleardat As New System.IO.StreamWriter(datloc)
                cleardat.Write("")
                cleardat.Close()
                Dim status As New ProcessStartInfo
                status.FileName = "cmd.exe"
                status.Arguments = "/c netsh wlan show hostednetwork>>" & """" & Application.StartupPath & "\data.dat" & """"
                status.WindowStyle = ProcessWindowStyle.Hidden
                Process.Start(status).WaitForExit()
                Dim appdata As New System.IO.StreamReader(datloc)
                comstatus.Text = appdata.ReadToEnd
                appdata.Close()
                comtypeau.Text = "WPA2-Personal"
                commode.Text = "Allow"
                txtspw.Text = Nothing
                txtssid.Text = Nothing
                TabControl.SelectTab(0)
                Dim ms1 As Integer
                ms1 = MsgBox("Do you want to start the Hosted Network now?", vbQuestion + vbYesNo, "Wi-Host | Start Hosted Network")
                If ms1 = vbYes Then
                    Call starthostednetwork("Msg")
                End If
            End If
        End If
    End Sub

    Private Sub cmdstop_Click(sender As Object, e As EventArgs) Handles cmdstop.Click
        Call stophostednetwork("Msg")
        Call network_status()
    End Sub

    Private Sub cmdstart_Click(sender As Object, e As EventArgs) Handles cmdstart.Click
        Call starthostednetwork("Msg")
        Call network_status()
    End Sub

    Private Sub SetupNewHostedNetworkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetupNewHostedNetworkToolStripMenuItem.Click
        TabControl.SelectTab(1)
    End Sub

    Private Sub ViewAdaptersDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewAdaptersDetailsToolStripMenuItem.Click
        Adapter_Detail.ShowDialog()
    End Sub

    Private Sub HostedNetworkSupportedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HostedNetworkSupportedToolStripMenuItem.Click
        Call hostednetworkcheck("Check1")
    End Sub

    Private Sub AboutWiHostToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutWiHostToolStripMenuItem.Click
        TabControl.SelectTab(2)
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked, LinkLabel1.LinkClicked
        Process.Start("http://www.askvg.com")
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
       
    End Sub

    Private Sub HowToSetupInternetConnectionSharingICSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HowToSetupInternetConnectionSharingICSToolStripMenuItem.Click
        Setup_ICS.ShowDialog()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub LinkLabel1_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs)
        'Process.Start("http://www.askvg.com")
        Process.Start("http://www.jcplaboratory.webs.com")
    End Sub
End Class
