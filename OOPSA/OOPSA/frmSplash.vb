﻿Imports Syncfusion.Windows.Forms

Imports Microsoft.Win32

Imports System.Reflection

Imports System.IO
Imports System.Threading

Public Class frmSplash
    Inherits MetroForm

    Dim DB As New DBConnect
    Dim Console As New Console

    Dim rdy As Boolean = False

    Private Sub frmSplash_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        AutoLabel4.Text = versionController.version

        Me.Refresh()

        Initialize()

    End Sub

    Private Sub tmrSplash_Tick(sender As Object, e As EventArgs) Handles tmrSplash.Tick

        Try

            ''make a reference to a directory
            'Dim di As New DirectoryInfo(Environment.CurrentDirectory)
            'Dim diar1 As FileInfo() = di.GetFiles()
            'Dim dra As FileInfo

            ''List the names of all files in the specified directory

            Dim fileList As String
            Dim fileName As String
            fileList = My.Computer.FileSystem.ReadAllText(Environment.CurrentDirectory & "\required.txt")
            For X = 0 To fileList.Split(vbCrLf).Count - 1
                fileName = fileList.Split(vbCrLf).ElementAt(X).ToString.Replace(vbCr, "").Replace(vbLf, "")
                If My.Computer.FileSystem.FileExists(Environment.CurrentDirectory & "\" & fileName) Then
                    AutoLabel3.Text = fileName

                    AutoLabel3.Refresh()
                    Me.Refresh()

                    Thread.Sleep(25)
                Else
                    tmrSplash.Enabled = 0
                    MsgBox(fileName & " is not found!" & vbCrLf & "Exiting application and running update!")
                    Process.Start("chkUpdate.exe")
                    Environment.Exit(0)
                End If

            Next

            'For Each dra In diar1

            '    If Not File.Exists(Environment.CurrentDirectory & "\" & dra.Name) Then
            '        MsgBox(dra.Name & " is not found!" & vbCrLf & "Exiting application and running update!")
            '        Process.Start("chkUpdate.exe")
            '        Environment.Exit(0)
            '    End If

            '    AutoLabel3.Text = dra.Name

            '    AutoLabel3.Refresh()
            '    Me.Refresh()

            '    Thread.Sleep(25)

            'Next

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            chkDBCon()
        End Try

        tmrSplash.Stop()

    End Sub

    Public Sub Initialize()

        tmrSplash.Start()

    End Sub

    Public Sub chkDBCon()
        Try

            If con.State = ConnectionState.Closed Then
                AutoLabel2.Text = "Connecting to database"
                AutoLabel2.Refresh()
                AutoLabel3.Text = con.State & " - Trying to open connection"
                AutoLabel3.Refresh()
                Me.Refresh()
                Thread.Sleep(750)
                DB.ConnectDatabase()
            End If

            If con.State = ConnectionState.Open Then
                AutoLabel3.Text = "Connected"
                AutoLabel3.Refresh()
                Me.Refresh()
                Thread.Sleep(750)
            End If

        Catch ex As Exception

            AutoLabel3.Text = "Failed to connect to DB @" & server

            MsgBox(ex.Message)

        Finally
            chkFrmClasses()
        End Try

    End Sub

    Public Sub chkFrmClasses()

        Me.Refresh()

        Dim mscorelib As Assembly = GetType(String).Assembly

        AutoLabel2.Text = "Checking assemblies"

        Try

            For Each type As Object In mscorelib.GetModules
                AutoLabel3.Text = type.Name
                AutoLabel3.Refresh()
                Me.Refresh()
                Thread.Sleep(10)
            Next

            Me.Refresh()
            Thread.Sleep(500)
            Me.Refresh()
            AutoLabel2.Text = "Finalizing"

            Dim Forms As New List(Of Form)()
            Dim formType As Type = Type.GetType("System.Windows.Forms.Form")

            For Each t As Type In Me.GetType().Assembly.GetTypes()

                AutoLabel3.Text = t.Name
                AutoLabel3.Refresh()
                Me.Refresh()

                Thread.Sleep(25)

            Next

            rdy = 1

        Catch ex As Exception
            AutoLabel3.Text = ex.Message

            rdy = 0

        Finally
            If rdy = True AndAlso con.State = ConnectionState.Open Then
                frmMetroLogin.Show()
                Me.Close()

            ElseIf rdy = False Then
                MsgBox("Encountered an error while loading.")
                RIP()
            End If
        End Try

    End Sub
    Public Sub RIP()
        Application.Exit()
    End Sub
End Class