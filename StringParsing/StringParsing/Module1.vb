Module Module1

    Sub Main()
        Console.WriteLine("*** String Parser 5000 v1.0 ***")

        Console.WriteLine("Bitte ein Zahl eingeben:")
        Dim eingabe As String = Console.ReadLine()
        Console.WriteLine("Eingabe: " & eingabe)

        Dim eingabeAlsInt As Integer = Integer.Parse(eingabe)
        Console.WriteLine("Eingabe als Int:" & eingabeAlsInt)
        Console.WriteLine("Das doppelte ist:" & eingabeAlsInt * 2)



        Console.WriteLine("Ende")
        Console.ReadKey()
    End Sub

End Module
