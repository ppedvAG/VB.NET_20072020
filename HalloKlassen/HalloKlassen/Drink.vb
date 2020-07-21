Public Class Drink
    Public Property Behälter As String 'Auto Property

    Private _füllMenge As Integer

    Public Property FüllMenge() As Integer 'Full Property
        Get
            Return _füllMenge
        End Get
        Set(value As Integer)
            If value < 0 Then
                _füllMenge = 0
            Else
                _füllMenge = value
            End If
        End Set
    End Property

    Private _Füllstand As Integer

    Public Property Füllstand As Integer
        Get
            Return _Füllstand
        End Get
        Private Set
            _Füllstand = Value
        End Set
    End Property

    Public Property Inhalt As Bier

    Public Sub Nachfüllen()
        Füllstand = FüllMenge
    End Sub

    Public Sub SchluckNehmen(schluckmenge As Integer)
        If schluckmenge > Füllstand Then
            Füllstand = 0
        Else
            Füllstand -= schluckmenge
        End If
    End Sub

    Public Sub ZeigeStatus()
        Console.WriteLine(Behälter & " mit " & Inhalt.Sorte & " hat noch " _
                          & Füllstand & "ml von " & FüllMenge & "ml")
    End Sub
End Class
