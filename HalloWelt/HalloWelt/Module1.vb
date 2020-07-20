
Module Module1

    Sub Main()

        'https://docs.microsoft.com/de-de/dotnet/visual-basic/language-reference/data-types/

        'so kann die Console das € Zeichen darstellen
        Console.OutputEncoding = System.Text.Encoding.UTF8

        Dim einText As String = "Hallo Text"
        Dim einZeichen As Char = "B"c

        'dimensioniert einen integer (32-bit)
        '[-2.147.483.648 bis 2.147.483.647 (signiert)]
        Dim eineZahl As Integer = 224747474
        '0 bis 4.294.967.295 (ohne Vorzeichen)
        Dim eineZahlNurPositiv As UInteger = 4111111111

        '-9.223.372.036.854.775.808 bis 9.223.372.036.854.775.807 (9.2... E + 18 †) (signiert)
        Dim eineGroßeZahl As Long = 234567856784567845

        '0 bis 255 (ohne Vorzeichen)
        Dim vielBier As Byte = 155

        'zahl mit komma
        Dim zahlMitKomma As Double = 3.7623456789

        'zahl als Geld
        Dim gehalt As Decimal = 234.2722D

        Console.WriteLine("Zahl mit Komma: " & zahlMitKomma.ToString("N3"))
        Console.WriteLine("Zahl mit Komma: " & (2.3).ToString("0.00"))
        Console.WriteLine("Rechnung: " & gehalt.ToString("C", New Globalization.CultureInfo("jp")))


        'implizites casting integer to double
        zahlMitKomma = eineZahl

        zahlMitKomma = 3.5
        'explizites casting double to integer
        eineZahl = CType(zahlMitKomma, Integer) ' vb spezial zeug
        eineZahl = Convert.ToInt32(zahlMitKomma) '.net version

        Console.WriteLine("Zahl: " & eineZahl)


        Console.WriteLine("Hallo Welt")
        'Gibt die zahl aus
        Console.WriteLine("Zahl: " & eineZahl)
        Console.WriteLine("Zahl: " & eineZahlNurPositiv - eineZahl)

        Console.WriteLine(einText)
        Console.WriteLine("Ausgabe: " & einText)
        Console.WriteLine("Textlänge: " & einText.Length)
        Console.WriteLine(einText.ToUpper())


        Console.ReadKey()
    End Sub

End Module
