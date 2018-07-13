Imports System.IO
Imports System.Text

Public Class frmMain

    Sub New()
        InitializeComponent()

        Me.Essensplaner.Laden()
        BerechnePreis()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim grid = DirectCast(sender, DataGridView)

        If TypeOf grid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 AndAlso e.ColumnIndex = 4 Then
            Dim currentRowSpeise = DirectCast(DirectCast(FKKategorieSpeiseBindingSource.Current, DataRowView).Row, Essensplaner.SpeiseRow)
            Dim currentRowRestaurant = DirectCast(DirectCast(RestaurantBindingSource.Current, DataRowView).Row, Essensplaner.RestaurantRow)

            Me.Essensplaner.Bestellung.AddBestellungRow(currentRowSpeise.Name, currentRowRestaurant.Name, currentRowSpeise.Preis, "", 1)
        ElseIf TypeOf grid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 AndAlso e.ColumnIndex = 3 Then
            'Wunsch hinzufügen
            Dim currentRowSpeise = DirectCast(DirectCast(FKKategorieSpeiseBindingSource.Current, DataRowView).Row, Essensplaner.SpeiseRow)
            Dim currentRowRestaurant = DirectCast(DirectCast(RestaurantBindingSource.Current, DataRowView).Row, Essensplaner.RestaurantRow)
            Dim wunsch = InputBox("Gib bitte deinen Wunsch ein. (Auf was soll geachtet werden?)", "Wunsch", "")
            If String.IsNullOrWhiteSpace(wunsch) = False Then
                Me.Essensplaner.Bestellung.AddBestellungRow(currentRowSpeise.Name, currentRowRestaurant.Name, currentRowSpeise.Preis, wunsch, 1)
            End If
        End If

        BerechnePreis()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start("\\diskstation\Storage\4all\LukasM\Essensplaner\EssensplanerEditor.exe")
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        Dim grid = DirectCast(sender, DataGridView)
        If TypeOf grid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 AndAlso e.ColumnIndex = 6 Then
            Dim row = DirectCast(DirectCast(BestellungBindingSource.Current, DataRowView).Row, Essensplaner.BestellungRow)
            row.Delete()
        ElseIf TypeOf grid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 AndAlso e.ColumnIndex = 4 Then
            Dim row = DirectCast(DirectCast(BestellungBindingSource.Current, DataRowView).Row, Essensplaner.BestellungRow)
            row.Anzahl += 1
        ElseIf TypeOf grid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 AndAlso e.ColumnIndex = 5 Then
            Dim row = DirectCast(DirectCast(BestellungBindingSource.Current, DataRowView).Row, Essensplaner.BestellungRow)
            If Not row.Anzahl - 1 <= 0 Then
                row.Anzahl -= 1
            End If
        End If
        BerechnePreis()
    End Sub

    Sub BerechnePreis()
        'Kompletten Preis
        lblPreis.Text = $"Kosten: {Essensplaner.Bestellung.Sum(Function(x) x.Field(Of Decimal)("GPreis"))}€"
    End Sub

    Private Sub DataGridView2_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellValueChanged
        If Me.Essensplaner IsNot Nothing Then
            Me.Validate()
            Me.Essensplaner.Bestellung.AcceptChanges()
            BerechnePreis()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

#If DEBUG = False Then
        Dim ZeitJetzt = Date.Now.TimeOfDay
        If ZeitJetzt >= New TimeSpan(11, 45, 0) Then
            If MessageBox.Show($"Tut mir Leid {Environment.UserName}, aber die Zeit ist abgelaufen. {Environment.NewLine}Möchtest du dennoch was bestellen?", "Die Zeit ist abgelaufen..", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                MessageBox.Show($"Ha, nur verarscht. :){Environment.NewLine}Bestellung wird also getrost ignoriert :P")
            End If
            Return
        End If
#End If

        'Alle verschiedenen Orte in eine Liste packen
        Dim Orte As New List(Of String)
        For Each row As Essensplaner.BestellungRow In Me.Essensplaner.Bestellung
            If Orte.Contains(row.Ort) = False Then
                Orte.Add(row.Ort)
            End If
        Next

        Dim sb As New StringBuilder
        sb.AppendLine($"Bestellung von {Environment.UserName}, Kosten: {Essensplaner.Bestellung.Sum(Function(x) x.Field(Of Decimal)("GPreis"))}€, Gegeben:")

        For Each s As String In Orte
            Dim sum = Me.Essensplaner.Bestellung.Where(Function(x) x.Ort = s).Sum(Function(x) x.Field(Of Decimal)("GPreis"))
            sb.AppendLine($"    Zu kaufen bei: {s}, Kostenpunkt: {sum}€")
            Dim bestellungen = Me.Essensplaner.Bestellung.Where(Function(x) x.Ort = s).ToList
            For Each row As Essensplaner.BestellungRow In bestellungen
                If String.IsNullOrWhiteSpace(row.Beachten) Then
                    sb.AppendLine($"        {row.Anzahl}x {row.Name}, Preis: {row.Preis}€, GPreis: {row.GPreis}€")
                Else
                    sb.AppendLine($"        {row.Anzahl}x {row.Name}, ACHTUNG: {row.Beachten}, Preis: {row.Preis}€, GPreis: {row.GPreis}€")
                End If
            Next
        Next

        Dim Pfad = Path.Combine(Application.StartupPath, "Bestellungen", $"{Environment.UserName}.txt")
        Using sw As New StreamWriter(Pfad, False)
            sw.Write(sb.ToString)
            sw.Close()
        End Using

        Me.Essensplaner.Bestellung.WriteXml(Path.Combine(Application.StartupPath, "Bestellungen", $"{Environment.UserName}RAW.xml"))
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim sb As New StringBuilder
        For Each s As String In Directory.GetFiles(Path.Combine(Application.StartupPath, "Bestellungen"), "*.txt")
            Dim fi As New FileInfo(s)
            If fi.Extension = ".txt" Then
                If fi.CreationTime.Date < Date.Now.Date Then
                    If fi.LastWriteTime < New Date(Date.Now.Year, Date.Now.Month, Date.Now.Day, 11, 45, 0) Then
                        Using sr As New StreamReader(fi.FullName)
                            sb.Append(sr.ReadToEnd)
                            sb.AppendLine()
                            sr.Close()
                        End Using
                    End If
                End If
            End If
        Next
        Using frmDrucken As New frmDrucken(sb.ToString)
            frmDrucken.ShowDialog(Me)
        End Using
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Process.Start(New ProcessStartInfo("explorer", "Z:\4all\LukasM\Essensplaner\Speisepläne"))
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Using frmEigen As New frmEigen
            If frmEigen.ShowDialog(Me) = DialogResult.OK Then
                Me.Essensplaner.Bestellung.AddBestellungRow(frmEigen.NameSpeise, frmEigen.Ort, frmEigen.Preis, frmEigen.Beachten, frmEigen.Anzahl)
                BerechnePreis()
            End If
        End Using
    End Sub

End Class