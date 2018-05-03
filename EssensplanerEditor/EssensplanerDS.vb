Imports System.IO

Partial Class Essensplaner

    Sub Laden()
        Dim a = "\\diskstation\Storage\4all\LukasM\Essensplaner\EssensplanerDS.xml"
        If File.Exists(a) = True Then
            Me.ReadXml(a)
        End If
    End Sub

    Sub Speichern()
        Me.WriteXml("\\diskstation\Storage\4all\LukasM\Essensplaner\EssensplanerDS.xml")
    End Sub

End Class
