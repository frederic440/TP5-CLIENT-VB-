Public Class Client
    Dim _num As Integer
    Dim _nomClient As String
    Dim _adresseClient As String
    Dim _typeClient As String
    Dim _nbVisite As Integer
    Sub New(num As Integer, nomClient As String, adresseClient As String, typeClient As String, nbVisite As Integer)
        _num = num
        _nomClient = nomClient
        _adresseClient = adresseClient
        _typeClient = typeClient
        _nbVisite = nbVisite
    End Sub
    Property num As Integer
        Get
            Return _num
        End Get
        Set(ByVal value As Integer)
            _num = value
        End Set
    End Property
    Property nomClient As String
        Get
            Return _nomClient
        End Get
        Set(ByVal value As String)
            _nomClient = value
        End Set
    End Property
    Property adresseClient As String
        Get
            Return _adresseClient
        End Get
        Set(ByVal value As String)
            _adresseClient = value
        End Set
    End Property
    Property typeClient As String
        Get
            Return _typeClient
        End Get
        Set(ByVal value As String)
            _typeClient = value
        End Set
    End Property
    Property nbVisite As Integer
        Get
            Return _nbVisite
        End Get
        Set(ByVal value As Integer)
            _nbVisite = value
        End Set
    End Property
End Class
