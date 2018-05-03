Imports System.IO

Public Class frmMain

    Sub New()
        InitializeComponent()

        Me.Essensplaner1.Laden()
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("Sollen die Änderungen gespeichert werden?", "Frage", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.Essensplaner1.Speichern()
        End If
        File.Delete(Path.Combine("\\diskstation\Storage\4all\LukasM\Essensplaner", "GESPERRT.txt"))
    End Sub

End Class
