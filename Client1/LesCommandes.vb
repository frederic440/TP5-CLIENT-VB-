Imports MySql.Data.MySqlClient
Public Class LesCommandes
    Public commandes As New List(Of Commande)


    Sub New()

    End Sub
    Public Function addCommande(ByVal unNumCmde As Integer, ByVal UneDateCmde As Date, ByVal UnClient As Integer)
        Dim Cmde As New Commande(unNumCmde, UneDateCmde, UnClient)
        commandes.Add(Cmde)
    End Function
    Property allCommand As List(Of Commande)
        Get
            Return commandes
        End Get
        Set(ByVal value As List(Of Commande))
            commandes = value
        End Set
    End Property
End Class
