
Imports System.IO
Imports System.Xml.Serialization
Imports DrinkModel
Imports Newtonsoft.Json

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim gk As New Getränkekarte()
        DataGridView1.DataSource = gk.GetAll()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim dlg As New SaveFileDialog
        dlg.Title = "Wo soll das Gesöff hin?"
        dlg.Filter = "Kaffeedatei|*.kaffee|Bierdatei|*.bier|Alle Dateien|*.*"

        If dlg.ShowDialog() = DialogResult.OK Then
            Dim sw As New StreamWriter(dlg.FileName)

            Dim liste = TryCast(DataGridView1.DataSource, List(Of Getränk))
            For Each getränk In liste
                sw.WriteLine($"{getränk.Hersteller}|{getränk.Kcal}|{getränk.CO2}")
            Next

            sw.Close()
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim dlg As New OpenFileDialog
        dlg.Title = "Wo kommt das Gesöff her?"
        dlg.Filter = "Kaffeedatei|*.kaffee|Bierdatei|*.bier|Alle Dateien|*.*"

        If dlg.ShowDialog() = DialogResult.OK Then
            Dim sr As New StreamReader(dlg.FileName) 'Damit lese wir Dateien
            Dim liste = New List(Of Getränk) ' Eine Liste in der wir temporär die leadenen Getränke speichern

            While Not sr.EndOfStream 'wir lese bis zu ende der Datei
                Dim line = sr.ReadLine() 'wir lesen 1 Zeile
                Dim chunks = line.Split("|") 'die eine Zeile wird in Zerteilt an Hand eines Trennzeichens
                Dim g As New Getränk() 'Wir erstellen ein neues Getränk
                g.Hersteller = chunks(0) 'dem wir die Werte
                g.Kcal = Integer.Parse(chunks(1)) ' der Einzelnen Teile zuweisen
                g.CO2 = Boolean.Parse(chunks(2)) 'an diese kommen wird per Index (1,2,3)
                liste.Add(g) 'Das zusammengesetzte getränk kommt in eine Liste
            End While

            sr.Close() 'Die Datei können wir schließen
            DataGridView1.DataSource = liste 'die temporäre Liste in der Oberfläche anzeigen
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim dlg As New SaveFileDialog
        dlg.Title = "Wo soll das Gesöff hin?"
        dlg.Filter = "Getränkedatei|*.xml"

        If dlg.ShowDialog() = DialogResult.OK Then
            Dim sw As New StreamWriter(dlg.FileName)

            Dim serial As New XmlSerializer(GetType(List(Of Bier)))
            serial.Serialize(sw, CType(DataGridView1.DataSource, List(Of Getränk)).OfType(Of Bier).ToList())
            sw.Close()
        End If


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim dlg As New OpenFileDialog
        dlg.Title = "Wo kommt das Gesöff her?"
        dlg.Filter = "Getränkedatei|*.xml"

        If dlg.ShowDialog() = DialogResult.OK Then
            Dim sr As New StreamReader(dlg.FileName)

            Dim serial As New XmlSerializer(GetType(List(Of Bier)))
            DataGridView1.DataSource = serial.Deserialize(sr)
            sr.Close()
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim dlg As New SaveFileDialog
        dlg.Title = "Wo soll das Gesöff hin?"
        dlg.Filter = "Getränkedatei|*.json"

        If dlg.ShowDialog() = DialogResult.OK Then

            Dim sw As New StreamWriter(dlg.FileName)

            sw.Write(JsonConvert.SerializeObject(DataGridView1.DataSource))
            sw.Close()
        End If

    End Sub
End Class
