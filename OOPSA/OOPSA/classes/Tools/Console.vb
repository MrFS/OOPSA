Imports System.Windows.Forms

Public Class Console

    Private WithEvents pc_CPU As New PerformanceCounter
    Private WithEvents pc_RAM As New PerformanceCounter

    Public Function PingSvr(server As String)

        Return ping.Send(server).RoundtripTime() & "ms"

    End Function

    Public Sub Quit()
        Application.Exit()
    End Sub

    Public Sub Reset()

    End Sub


    Public Sub GetDir()

    End Sub

    Public Function CPU()

        pc_CPU.CategoryName = "Processor"
        pc_CPU.CounterName = "% Processor Time"
        pc_CPU.InstanceName = "_Total"

        Return pc_CPU.NextValue

    End Function

    Public Function RAM()

        pc_RAM.CategoryName = "Memory"
        pc_RAM.CounterName = "% Committed Bytes In Use"

        Return pc_RAM.NextValue

    End Function
End Class
