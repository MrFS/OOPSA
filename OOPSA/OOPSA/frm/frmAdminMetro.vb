﻿Imports Syncfusion.Windows.Forms

Imports Syncfusion.DocIO
Imports Syncfusion.DocIO.DLS

Public Class frmAdminMetro
    Inherits MetroForm
    Dim Core As New frmAdminCore

    Private Sub btnAddUsr_Click(sender As Object, e As EventArgs) Handles btnAddUsr.Click
        frmAddUsrMetro.Show()
    End Sub

    Private Sub frmAdminMetro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Core.VisAnsatt()
        Core.visLeie()

        For Each var As Object In Me.FontListBox1.Items
            txtFontCombo.Items.Add(var)
        Next

        Me.richTextBox1.Font = New Font(Me.richTextBox1.Font.Name, CInt(txtFontSizeCombo.Text), Me.richTextBox1.Font.Style)


        Me.ReportViewer1.RefreshReport
    End Sub

    Private Sub txtAlignLeft_Click(sender As Object, e As EventArgs) Handles txtAlignLeft.Click
        richTextBox1.SelectionAlignment = Windows.Forms.HorizontalAlignment.Left
    End Sub

    Private Sub txtAlignJust_Click(sender As Object, e As EventArgs) Handles txtAlignJust.Click
        richTextBox1.SelectionAlignment = Windows.Forms.HorizontalAlignment.Center
    End Sub

    Private Sub txtAlignRight_Click(sender As Object, e As EventArgs) Handles txtAlignRight.Click
        richTextBox1.SelectionAlignment = Windows.Forms.HorizontalAlignment.Right
    End Sub

    Private Sub txtFontCombo_DropDownClosed(sender As Object, e As EventArgs) Handles txtFontCombo.DropDownClosed

        If Me.richTextBox1.SelectedText = "" Then
            richTextBox1.Font = New Font(txtFontCombo.Text, CInt(txtFontSizeCombo.Text), Me.richTextBox1.Font.Style)
        Else
            richTextBox1.SelectionFont = New Font(txtFontCombo.Text, CInt(txtFontSizeCombo.Text), Me.richTextBox1.Font.Style)
        End If

    End Sub
    Private Sub txtFontSizeCombo_DropDownClosed(sender As Object, e As EventArgs) Handles txtFontSizeCombo.DropDownClosed
        If Me.richTextBox1.SelectedText = "" Then
            Me.richTextBox1.Font = New Font(Me.richTextBox1.Font.Name, CInt(txtFontSizeCombo.Text), Me.richTextBox1.Font.Style)
        Else
            richTextBox1.SelectionFont = New Font(Me.richTextBox1.Font.Name, CInt(txtFontSizeCombo.Text), Me.richTextBox1.Font.Style)
        End If
    End Sub

    Private Sub richTextBox1_TextChanged(sender As Object, e As EventArgs) Handles richTextBox1.TextChanged
        Me.txtUndo.Enabled = Me.richTextBox1.CanUndo
        Me.txtRedo.Enabled = Me.richTextBox1.CanRedo
    End Sub

    Private Sub txtUndo_Click(sender As Object, e As EventArgs) Handles txtUndo.Click
        Me.richTextBox1.Undo()
    End Sub

    Private Sub txtRedo_Click(sender As Object, e As EventArgs) Handles txtRedo.Click
        Me.richTextBox1.Redo()
    End Sub

    Private Sub txtInsertImg_Click(sender As Object, e As EventArgs) Handles txtInsertImg.Click

        Dim ofd As New OpenFileDialog

        ofd.ShowDialog()

        Dim lstrFile As String = ofd.FileName

        Dim img As New Bitmap(lstrFile)

        Clipboard.SetDataObject(img)

        Dim imgformat As DataFormats.Format = DataFormats.GetFormat(DataFormats.Bitmap)



        If Me.richTextBox1.CanPaste(imgformat) Then
            richTextBox1.Paste(imgformat)
        Else
            MsgBox("Feil format")
        End If
    End Sub

    Private Sub NewToolStripButton_Click(sender As Object, e As EventArgs) Handles NewToolStripButton.Click
        If richTextBox1.Text IsNot Nothing Then
            'Save before proceeding
            MsgBox("Save before creating a new document?", MsgBoxStyle.YesNo, "Save masterpiece?")

            If MsgBoxResult.Ok Then
                Dim sfd As New SaveFileDialog
                sfd.Filter = "KUK Files (*.kuk) |*.kuk"

                If sfd.ShowDialog = Windows.Forms.DialogResult.OK Then
                    richTextBox1.SaveFile(sfd.FileName)
                End If

            ElseIf MsgBoxResult.No Then
                richTextBox1.Clear()
            End If




        Else

                richTextBox1.Clear()



        End If
    End Sub

    Private Sub PrintToolStripButton_Click(sender As Object, e As EventArgs) Handles PrintToolStripButton.Click
        Dim print As New PrintPreviewDialog

        print.ShowDialog()

    End Sub
End Class