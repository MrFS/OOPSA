
Imports System.Diagnostics
Imports System.IO
Imports System.Reflection

Imports System.Net


Module updateModule


    ''' <summary>
    ''' 
    ''' </summary>
    Sub Main()


        Dim OOPSA() As Process = Process.GetProcessesByName("OOPSA")

        Console.WriteLine("OOPSA Update")
        Console.WriteLine("Would you like to update? Y/N")

        Console.In.ReadLine.ToUpper()

        Select Case Console.In.ReadLine
            Case "Y"
                Console.WriteLine("PENIOS")
            Case "N"
                Environment.Exit(0)
        End Select

    End Sub

End Module
