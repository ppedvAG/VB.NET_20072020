Public Class Drink
    Public Property Behälter As String
    Public Property Füllmenge As Integer
    Public Property Füllstand As Integer
    Public Property Inhalt As Bier

    Sub New() 'default konstuktor
        Behälter = "Becher"
        Füllmenge = 300
        Nachfüllen()
    End Sub

    Sub New(_füllmenge As Integer)
        Me.New()
        Füllmenge = _füllmenge
        Nachfüllen()
    End Sub

    Public Sub Nachfüllen()
        Füllstand = Füllmenge
    End Sub

    Public Sub SchluckNehmen(menge As Integer)
        If menge > Füllstand Then
            Füllstand = 0
        Else
            Füllstand -= menge
        End If
    End Sub
End Class
