Imports System.IO
Imports Microsoft.VisualBasic.ApplicationServices

Namespace My
    ' Für MyApplication sind folgende Ereignisse verfügbar:
    ' Startup: Wird beim Starten der Anwendung noch vor dem Erstellen des Startformulars ausgelöst.
    ' Shutdown: Wird nach dem Schließen aller Anwendungsformulare ausgelöst.  Dieses Ereignis wird nicht ausgelöst, wenn die Anwendung mit einem Fehler beendet wird.
    ' UnhandledException: Wird bei einem Ausnahmefehler ausgelöst.
    ' StartupNextInstance: Wird beim Starten einer Einzelinstanzanwendung ausgelöst, wenn die Anwendung bereits aktiv ist. 
    ' NetworkAvailabilityChanged: Wird beim Herstellen oder Trennen der Netzwerkverbindung ausgelöst.
    Partial Friend Class MyApplication

        Private Sub MyApplication_UnhandledException(sender As Object, e As UnhandledExceptionEventArgs) Handles Me.UnhandledException
            Dim PfadExe = System.Reflection.Assembly.GetExecutingAssembly().Location
            Dim PfadOrdner = System.IO.Path.GetDirectoryName(PfadExe)
            Dim LogFile = Path.Combine(PfadOrdner, "Log.txt")
            Using sw As New StreamWriter(LogFile, True)
                sw.Write($"{Date.Now}: {Environment.UserName} {Environment.NewLine} {e.Exception.Message} {Environment.NewLine} {Environment.NewLine} {e.Exception.InnerException}")
                sw.Close()
            End Using
            e.ExitApplication = False
        End Sub

    End Class
End Namespace
