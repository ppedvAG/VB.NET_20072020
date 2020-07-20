Module Module1

    Sub Main()
        Console.WriteLine("*** Hallo BOOL ***")

        Dim einBool As Boolean = (25 <= 15 And 6 > 2 Or 6 > 7)
        Dim einBool2 As Boolean = (False AndAlso True Or False)

        Console.WriteLine(einBool)

        If einBool Then
            Console.WriteLine("Der Bool ist wahr")
        Else
            Console.WriteLine("Der Bool ist falsch")
        End If

        Console.WriteLine("Bitte ein Zahl eingeben:")

        Dim zahl = Integer.Parse(Console.ReadLine())
        If zahl < 0 Then
            Console.WriteLine("Die Zahl ist negativ")
        ElseIf zahl > 1000 Then
            Console.WriteLine("Die Zahl ist sehr groß")
        Else
            Console.WriteLine("Das ist eine nicht negative Zahl unter Tausend")
        End If

        Console.WriteLine("Ende")
        Console.ReadKey()
    End Sub

End Module
