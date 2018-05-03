Imports System.IO
Imports System.Threading

Public Class Program

    Public Shared Sub Main()

        Application.EnableVisualStyles()

        AddHandler Application.ThreadException, AddressOf ErrorSub

        If File.Exists(Path.Combine("\\diskstation\Storage\4all\LukasM\Essensplaner", "GESPERRT.txt")) = True Then
            Dim Bearbeiter As String = ""
            Using sr As New StreamReader(Path.Combine("\\diskstation\Storage\4all\LukasM\Essensplaner", "GESPERRT.txt"))
                Bearbeiter = sr.ReadLine
                sr.Close()
            End Using
            MessageBox.Show($"Die Datenbank wird bereits bearbeitet von {Bearbeiter}")

        Else
            Using sw As New StreamWriter(Path.Combine("\\diskstation\Storage\4all\LukasM\Essensplaner", "GESPERRT.txt"))
                sw.WriteLine(Environment.UserName)
                sw.Close()
            End Using
            Application.Run(New frmMain)
        End If

    End Sub

    Private Shared Sub ErrorSub(sender As Object, e As ThreadExceptionEventArgs)
        Dim LogFile = Path.Combine("\\diskstation\Storage\4all\LukasM\Essensplaner", "Log.txt")
        Using sw As New StreamWriter(LogFile, True)
            sw.Write($"{Date.Now}: {Environment.UserName} {Environment.NewLine} {e.Exception.Message} {Environment.NewLine}")
            sw.Close()
        End Using
    End Sub

End Class
