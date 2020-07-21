Module Module1

    Sub Main()
        Console.WriteLine("*** Bier! 🍻 ***")

        Console.WriteLine(Environment.ProcessorCount)

        Dim hoepfner As Bier 'deklaration
        hoepfner = New Bier() 'instanzierung

        hoepfner.Brauerei = "Hoepfner"
        hoepfner.Sorte = "Pilsner"
        hoepfner.Art = "Pils"
        hoepfner.Alk = 4.9
        hoepfner.Geburt = New Date(1798, 1, 1)

        Dim welde As New Bier() 'deklaration + instanzierung
        welde.Brauerei = "Welde"
        welde.Sorte = "No. 1"
        welde.Art = "Pils"
        welde.Alk = 4.9
        welde.Geburt = New Date(1752, 1, 1)


        ZeigeBier(hoepfner)
        ZeigeBier(welde)
        ZeigeBier(CreateRothaus())

        Dim feierabendBier As New Drink
        feierabendBier.Inhalt = welde
        feierabendBier.FüllMenge = 500
        feierabendBier.Behälter = "Bierglass"
        feierabendBier.Nachfüllen()
        feierabendBier.ZeigeStatus()
        feierabendBier.SchluckNehmen(124)
        feierabendBier.ZeigeStatus()
        feierabendBier.SchluckNehmen(624)
        feierabendBier.ZeigeStatus()
        Console.WriteLine(feierabendBier.Füllstand)

        Console.WriteLine("Ende")
        Console.ReadKey()
    End Sub

    Function CreateRothaus() As Bier
        Dim b = New Bier
        b.Brauerei = "Badische Staatbrauerei Rothaus AG"
        b.Sorte = "Tannenzäpfle"
        b.Art = "Pils"
        b.Alk = 5.1
        b.Geburt = New Date(1791, 1, 1)
        Return b
    End Function

    Sub ZeigeBier(einBier As Bier)
        Console.WriteLine("------ ZeigeBier ------")
        Console.WriteLine(einBier.Brauerei & " " & einBier.Sorte & "(" & einBier.Art & ")")
        Console.WriteLine(einBier.Alk.ToString("f2") & "% " & einBier.Geburt.Year)
        Console.WriteLine("-----------------------")
    End Sub

    Sub Verwässern(einBier As Bier, faktor As Integer)
        einBier.Alk /= faktor
    End Sub

    Sub Verwässern(einBier As Bier)
        einBier.Alk /= 2
    End Sub

    Function GibtMirFünf() As Integer
        Return 5
    End Function



End Module
