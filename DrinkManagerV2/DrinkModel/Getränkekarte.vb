Public Class Getränkekarte


    Function GetAll() As List(Of Getränk)

        Return GetKaffees().Cast(Of Getränk).Union(GetBiere()).ToList()

    End Function

    Function GetKaffees() As List(Of Kaffee)
        Dim liste As New List(Of Kaffee)

        Dim jack = New Kaffee()
        jack.CO2 = False
        jack.Kcal = 12
        jack.Hersteller = "Jackobs"
        jack.Röstung = "Kaffee"
        liste.Add(jack)

        Dim lav = New Kaffee()
        lav.Kcal = 18
        lav.Hersteller = "Lavazza"
        lav.Röstung = "Espresso"
        liste.Add(lav)

        Return liste
    End Function

    Function GetBiere() As List(Of Bier)

        Dim liste As New List(Of Bier)

        Dim hoepfner As New Bier()
        hoepfner.Brauerei = "Hoepfner"
        hoepfner.Sorte = "Pilsner"
        hoepfner.Art = "Pils"
        hoepfner.Alk = 4.9
        hoepfner.Geburt = New Date(1798, 1, 1)
        liste.Add(hoepfner)

        Dim welde As New Bier()
        welde.Brauerei = "Welde"
        welde.Sorte = "No. 1"
        welde.Art = "Pils"
        welde.Alk = 4.9
        welde.Geburt = New Date(1752, 1, 1)
        liste.Add(welde)

        Dim rot = New Bier
        rot.Brauerei = "Badische Staatbrauerei Rothaus AG"
        rot.Sorte = "Tannenzäpfle"
        rot.Art = "Pils"
        rot.Alk = 5.1
        rot.Geburt = New Date(1791, 1, 1)
        liste.Add(rot)

        Return liste

    End Function

End Class
