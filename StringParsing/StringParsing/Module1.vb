Module Module1

    Sub Main()
        Console.WriteLine("*** String Parser 5000 v1.0 ***")

        Console.WriteLine("Bitte ein Zahl eingeben:")
        Dim eingabe As String = Console.ReadLine()
        Console.WriteLine("Eingabe: " & eingabe)


        Try

            Dim eingabeAlsInt As Integer = Integer.Parse(eingabe)
            Console.WriteLine("Eingabe als Int:" & eingabeAlsInt)
            Console.WriteLine("Das doppelte ist:" & eingabeAlsInt * 2)

        Catch ex As Exception
            Console.WriteLine("Eingabe war ungültig")
        End Try




        Console.WriteLine("Ende")
        Console.ReadKey()
    End Sub

End Module
