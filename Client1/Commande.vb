Imports MySql.Data.MySqlClient

Public Class Commande
    Private cnxClient1 As MySqlConnection
    Dim NumCmde As Integer
    Dim DateCmde As Date
    Dim client As Client
    Sub New(num As Integer, datcmd As Date, numClient As Integer)
        NumCmde = num
        DateCmde = datcmd
        client = GetTheClient(numClient)
    End Sub
    Public Function get_NumCmde()
        Return NumCmde
    End Function
    Public Function get_DateCmde()
        Return DateCmde
    End Function
    Public Function get_Client()
        Return client
    End Function
    Public Function set_NumCmde(val As Integer)
        NumCmde = val
    End Function
    Public Function set_DateCmde(val As Date)
        DateCmde = val
    End Function
    Public Function set_NumClient(val As Client)
        client = val
    End Function
End Class
