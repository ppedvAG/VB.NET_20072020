Public Class Bier
    Inherits Getränk

    Public Overrides Property Hersteller As String
        Get
            Return Brauerei
        End Get
        Set(value As String)
            Brauerei = value
        End Set
    End Property

    Public Property Brauerei As String
    Public Property Sorte As String
    Public Property Art As String
    Public Property Alk As Double
    Public Property Geburt As Date
End Class
