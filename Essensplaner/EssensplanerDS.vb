Imports System.IO

Partial Class Essensplaner

    Sub Laden()
        Dim a = "\\diskstation\Storage\4all\LukasM\Essensplaner\EssensplanerDS.xml"
        Dim b = "\\diskstation\Storage\4all\LukasM\Essensplaner\Bestellungen"
        Dim PfadExe = System.Reflection.Assembly.GetExecutingAssembly().Location
        Dim PfadOrdner = System.IO.Path.GetDirectoryName(PfadExe)
        'If File.Exists(Path.Combine(PfadOrdner, "EssensplanerDS.xml")) = True Then
        '    Me.ReadXml("EssensplanerDS.xml")
        'End If
        'If File.Exists(Path.Combine(PfadOrdner, "Bestellungen", $"{Environment.UserName}RAW.xml")) = True Then
        '    Me.Bestellung.ReadXml(Path.Combine(Application.StartupPath, "Bestellungen", $"{Environment.UserName}RAW.xml"))
        'End If

        If File.Exists(a) = True Then
            Me.ReadXml(a)
        End If
        If File.Exists(Path.Combine("\\diskstation\Storage\4all\LukasM\Essensplaner\Bestellungen", $"{Environment.UserName}RAW.xml")) = True Then
            Me.Bestellung.ReadXml(Path.Combine("\\diskstation\Storage\4all\LukasM\Essensplaner", "Bestellungen", $"{Environment.UserName}RAW.xml"))
        End If
    End Sub

End Class
