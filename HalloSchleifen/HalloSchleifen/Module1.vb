Module Module1

    Sub Main()

        Console.WriteLine("*** Hallo Schleifen ***")


        'zählergesteuerte Schleife
        For index = 1 To 100 Step 4
            Console.WriteLine(index)
        Next

        Dim text = "Die ist ein toller Text"

        Dim buchstabe As Char = text(4)

        Dim sw = New IO.StreamWriter("meineDaten.txt")

        For index = 0 To text.Length - 1
            Console.WriteLine(text(index))
            sw.WriteLine("Char an Index " & index & ": " & text(index))
        Next

        sw.Close()
        Console.WriteLine("=================================================0")

        'while schleife
        Dim sr = New IO.StreamReader("meineDaten.txt")
        While Not sr.EndOfStream
            Console.WriteLine("Datei: " & sr.ReadLine())
        End While

        Dim z = 0
        While True
            If z Mod 1000000 = 0 Then
                Console.WriteLine(z & " " & Date.Now)
            End If
            z += 1
        End While

        Console.WriteLine("Ende")
        Console.ReadKey()

    End Sub

End Module
