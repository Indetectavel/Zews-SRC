Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num As Integer = 0
        Do
            num += 1
        Loop While num <= 100
        Me.netsh()
        Me.reg()
        Interaction.MsgBox("Tweaker V4.5 Intalada com sucesso!", MsgBoxStyle.Information, "Zews Tweaker V4.5")
    End Sub

    Public Sub netsh()
        Me.cmdnetsh("netsh int tcp set global timestamps=disabled")
        Me.cmdnetsh("netsh int tcp set global chimney=enabled")
        Me.cmdnetsh("netsh int tcp set global netdma=enabled")
        Me.cmdnetsh("netsh int tcp set global autotuninglevel=normal")
        Me.cmdnetsh("netsh int tcp set global ecncapability=disabled")
        Me.cmdnetsh("netsh int tcp set global congestionprovider=cubic")
        Me.cmdnetsh("netsh int tcp set global dca=enabled")
        Me.cmdnetsh("netsh int ipv4 set dynamicport tcp start=1025 num=64511")
        Me.cmdnetsh("netsh int ipv4 set dynamicport protocol=udp start1025 num=64511")
        Me.cmdnetsh("netsh int ipv6 set dynamicport tcp start=1025 num=64511")
        Me.cmdnetsh("netsh int ipv6 set dynamicport protocol=udp start1025 num=64511")
        Me.cmdnetsh("netsh int tcp set heuristics disabled")
    End Sub

    Public Sub reg()
        Me.cmd("HKCU\SOFTWARE\Microsoft\Windows\Current\Version\Explorer\Advanced /v LastActiveClick /t REG_DWORD /d 1 /f")
        Me.cmd("HKCU\SOFTWARE\Microsoft\Windows\Current\Version\Explorer\Advanced /v DisallowShaking /t REG_DWORD /d 1 /f")
        Me.cmd("HKLM\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile /v SystemResponsiveness /t REG_DWORD /d 0 /f")
        Me.cmd("HKLM\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile /v LargeSystemCache /t REG_DWORD /d 0 /f")
        Me.cmd("HKLM\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile\Tasks\Games /v Affinity /t REG_DWORD /d 0 /f")
        Me.cmd("HKLM\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile\Tasks\Games /v Background Only /t REG_SZ /d False /f")
        Me.cmd("HKLM\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile\Tasks\Games /v Clock Rate /t REG_DWORD /d 10000 /f")
        Me.cmd("HKLM\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile\Tasks\Games /v GPU Priority /t REG_DWORD /d 8 /f")
        Me.cmd("HKLM\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile\Tasks\Games /v Priority /t REG_DWORD /d 6 /f")
        Me.cmd("HKLM\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile\Tasks\Games /v SFIO Priority /t REG_SZ /d High /f")
        Me.cmd("HKLM\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile /v NetworkThrottlingIndex /t REG_DWORD /d 4294967295 /f")
        Me.cmd("HKLM\SOFTWARE\Microsoft\MSMQ\Parameters /v TCPNoDelay /t REG_DWORD /d 1 /f")
        Me.cmd("HKCU\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced /v EnableBalloonTips /t REG_DWORD /d 0 /f")
        Me.cmd("HKLM\SYSTEM\CurrentControlSet\Services\LanmanServer\Parameters /v IRPStackSize /t REG_DWORD /d 50 /f")
        Me.cmd("HKCU\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer /v NoLowDiskSpaceChecks /t REG_DWORD /d 1 /f")
        Me.cmd("HKCU\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer /v LinkResolveIgnoreLinkInfo /t REG_DWORD /d 1 /f")
        Me.cmd("HKCU\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer /v NoResolveSearch /t REG_DWORD /d 1 /f")
        Me.cmd("HKCU\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer /v NoResolveTrack /t REG_DWORD /d 1 /f")
        Me.cmd("HKCU\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer /v NoInternetOpenWith /t REG_DWORD /d 1 /f")
        Me.cmd("HKLM\SYSTEM\ControlSet002\Control /v WaitToKillServiceTimeout /t REG_SZ /d 1000 /f")
        Me.cmd("HKCU\Control Panel\Desktop /v AutoEndTasks /t REG_SZ /d 1 /f")
        Me.cmd("HKCU\Control Panel\Desktop /v WaitToKillAppTimeout /t REG_SZ /d 2000 /f")
        Me.cmd("HKU\S-1-5-20\Control Panel\Desktop /v AutoEndTasks /t REG_SZ /d 1 /f")
        Me.cmd("HKU\S-1-5-20\Control Panel\Desktop /v HungAppTimeout /t REG_SZ /d 1000 /f")
        Me.cmd("HKU\S-1-5-20\Control Panel\Desktop /v MenuShowDelay /t REG_SZ /d 0 /f")
        Me.cmd("HKU\S-1-5-20\Control Panel\Desktop /v WaitToKillAppTimeout /t REG_SZ /d 2000 /f")
        Me.cmd("HKLM\SYSTEM\CurrentControlSet\Control /v WaitToKillServiceTimeout /t REG_SZ /d 2000 /f")
        Me.cmd("HKCU\Control Panel\Desktop /v HungAppTimeout /t REG_SZ /d 1000 /f")
        Me.cmd("HKCU\Control Panel\Desktop /v MenuShowDelay /t REG_SZ /d 8 /f")
        Me.cmd("HKCU\Control Panel\Desktop /v LowLevelHooksTimeout /t REG_SZ /d 1000 /f")
        Me.cmd("HKLM\SYSTEM\CurrentControlSet\Services\Pshed /v NonBestEffortLimit /t REG_DWORD /d 0 /f")
        Me.cmd("HKLM\SYSTEM\CurrentControlSet\Services\Tcpip\Parameters /v EnableDCA /t REG_DWORD /d 1 /f")
        Me.cmd("HKLM\SYSTEM\CurrentControlSet\Services\Tcpip\Parameters /v EnableWsd /t REG_DWORD /d 0 /f")
        Me.cmd("HKLM\SYSTEM\CurrentControlSet\Services\Tcpip\Parameters /v EnableTCPA /t REG_DWORD /d 1 /f")
        Me.cmd("HKLM\SYSTEM\CurrentControlSet\Services\Tcpip\Parameters /v DisableTaskOffload /t REG_DWORD /d 0 /f")
        Me.cmd("HKLM\SYSTEM\CurrentControlSet\Services\Tcpip\Parameters /v EnableConnectionRateLimiting /t REG_DWORD /d 0 /f")
        Me.cmd("HKLM\SYSTEM\CurrentControlSet\Services\Tcpip\Parameters /v TcPMaxDataRetransmissions /t REG_DWORD /d 5 /f")
        Me.cmd("HKLM\SYSTEM\CurrentControlSet\Services\Tcpip\Parameters /v TcpNumConnections /t REG_DWORD /d 1280 /f")
        Me.cmd("HKLM\SYSTEM\CurrentControlSet\Services\Tcpip\Parameters /v TcpTimedWaitDelay /t REG_DWORD /d 25 /f")
        Me.cmd("HKLM\SYSTEM\CurrentControlSet\Services\Tcpip\Parameters /v SynAttackProtect /t REG_DWORD /d 1 /f")
        Me.cmd("HKLM\SYSTEM\CurrentControlSet\Services\Tcpip\Parameters /v TcpCreateAndConnectTcbRateLimitDepth /t REG_DWORD /d 0 /f")
        Me.cmd("HKLM\SYSTEM\CurrentControlSet\Services\Tcpip\Parameters /v TCPNoDelay /t REG_DWORD /d 1 /f")
        Me.cmd("HKLM\SYSTEM\CurrentControlSet\Services\Tcpip\Parameters /v TcpAckFrequency /t REG_DWORD /d 1 /f")
        Me.cmd("HKLM\SYSTEM\CurrentControlSet\Services\Tcpip\Parameters /v TcpMaxDataRetransmissions /t REG_DWORD /d 5 /f")
        Me.cmd("HKLM\SYSTEM\CurrentControlSet\Services\Tcpip\Parameters /v TCPDelAckTicks /t REG_DWORD /d 0 /f")
        Me.cmd("HKLM\SYSTEM\CurrentControlSet\Services\Tcpip\Parameters /v Tcp1323Opts /t REG_DWORD /d 3 /f")
        Me.cmd("HKLM\SYSTEM\CurrentControlSet\Services\Tcpip\Parameters /v MaxFreeTcbs /t REG_DWORD /d 415030 /f")
        Me.cmd("HKLM\SYSTEM\CurrentControlSet\Services\Tcpip\Parameters /v MaxUserPort /t REG_DWORD /d 415028 /f")
        Me.cmd("HKLM\SYSTEM\CurrentControlSet\Services\Tcpip\Parameters /v DefaultTTL /t REG_DWORD /d 100 /f")
        Me.cmd("HKLM\SYSTEM\CurrentControlSet\Services\Tcpip\Parameters /v GlobalMaxTcpWindowSize /t REG_DWORD /d 415029 /f")
        Me.cmd("HKLM\SOFTWARE\Policies\Microsoft\Windows /v NonBestEffortLimit /t REG_DWORD /d 0 /f")
        Me.cmd("HKCU\Control Panel\Mouse /v MouseSensitivity /t REG_SZ /d 10 /f")
    End Sub

    Public Sub cmd(arguments As String)
        Dim startInfo As ProcessStartInfo = New ProcessStartInfo() With {.FileName = "reg.exe", .Arguments = "ADD " + arguments, .UseShellExecute = True, .WindowStyle = ProcessWindowStyle.Hidden}
        Process.Start(startInfo)
    End Sub

    Public Sub cmdnetsh(arguments As String)
        Dim startInfo As ProcessStartInfo = New ProcessStartInfo() With {.FileName = "cmd.exe", .Arguments = arguments, .UseShellExecute = True, .WindowStyle = ProcessWindowStyle.Hidden}
        Process.Start(startInfo)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Process.Start("https://twitter.com/Indetectavell")
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Process.Start("https://www.youtube.com/channel/UCOSE1SSCsvbJ8kg07TwlcVA?view_as=subscriber")
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Close()
    End Sub
End Class
