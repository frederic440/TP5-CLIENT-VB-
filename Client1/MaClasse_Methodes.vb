Imports MySql.Data.MySqlClient


Module Class_Collection

    Dim commandes As New List(Of Commande)
    Private cnxClient1 As MySqlConnection



    Private Sub InitialiserConnexionBase()
        ' Chaîne de connexion à la base de donnéees
        Dim ChaineConnexion As String
        'ChaineConnexion = "server=localhost;user=root;database=tp5_client1;port=3306;password='';"
        ChaineConnexion = "server=172.18.153.50;user=fred;database=client1_db;password='12-Soleil&';"
        ' Création de la connexion
        cnxClient1 = New MySqlConnection(ChaineConnexion)

        ' Tentative d'ouverture de la connexion
        Try
            cnxClient1.Open()
        Catch ex As Exception
            MsgBox("ERREUR : Accès à la base impossible." + Chr(13) + ex.Message, vbCritical, "")
            End
        End Try
    End Sub
    Public Sub GetAllCommand(ByRef lesCommandes As LesCommandes)
        lesCommandes.commandes.Clear()
        'Connexion à la BDD
        InitialiserConnexionBase()
        ' Jeu d'enregistrement qui contiendra le résultat de la requête
        Dim dtCmde As New DataTable
        ' Adaptateur SQL : l'objet sur lequel les commandes SQL seront lancées et dont le résultat sera mis dans un "DataTable"
        Dim sdaCmde As New MySqlDataAdapter
        ' Exécution de la requête sur la connexion
        sdaCmde.SelectCommand = New MySqlCommand("SELECT commande.*, NomClient FROM commande INNER Join client ON commande.NumClient = client.NumClient ORDER by commande.DateCmde desc;", cnxClient1)
        ' Récupération des données
        sdaCmde.Fill(dtCmde)
        For Each commande As DataRow In dtCmde.Rows
            'Ajout à la collection des commandes, la ligne correspondantes
            lesCommandes.addCommande(commande("NumCmde"), commande("DateCmde"), commande("NumClient"))
        Next
    End Sub
    Public Function GetTheClient(ByVal num As Integer)
        'Connexion à la BDD
        InitialiserConnexionBase()
        ' Jeu d'enregistrement qui contiendra le résultat de la requête
        Dim dtClient As New DataTable
        ' Adaptateur SQL : l'objet sur lequel les commandes SQL seront lancées et dont le résultat sera mis dans un "DataTable"
        Dim sdaClient As New MySqlDataAdapter
        'On récupère le client concerné par
        sdaClient.SelectCommand = New MySqlCommand("SELECT * FROM `client` where NumClient = " + Str(num) + ";", cnxClient1)
        ' Récupération des données
        sdaClient.Fill(dtClient)
        For Each commande As DataRow In dtClient.Rows
            'On retourne le client qui vient d'être créer
            Return New Client(commande("NumClient"), commande("NomClient"), commande("AdresseClient"), commande("LibTypeClient"), commande("NbVisites"))
        Next
    End Function
    Public Function InsertNewCommande(ByVal numClient As Integer)
        'Connexion à la BDD
        InitialiserConnexionBase()
        'On récupère le client concerné par
        Dim cmdSQL As New MySqlCommand()
        cmdSQL.Connection = cnxClient1
        cmdSQL.CommandType = CommandType.StoredProcedure
        ' Tableau des paramètres à envoyer à la procédure stockée
        Dim Param(0) As MySqlParameter   '1 paramètres 

        ' Propiétés communes à tous les clients
        Param(0) = New MySqlParameter("unId", MySqlDbType.Int16)
        Param(0).Value = numClient

        'Insertion d'une nouvelles ligne dans la table Commande
        cmdSQL.CommandText = "sp_InsertCommande"
        ' Les paramètres sont attribués à la commande
        cmdSQL.Parameters.AddRange(Param)
        ' Contiendra le nombre de lignes affectées une fois la commande exécutée
        Dim NbLignesConcernées As Integer = 0
        Try
            ' Exécution de la commande
            NbLignesConcernées = cmdSQL.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ERREUR : Ajout impossible." + Chr(13) + ex.Message, vbCritical)
            Return False
        End Try
        If NbLignesConcernées = 1 Then
            ' La commande a bien fonctionné
            Return True
        Else
            Return False
        End If
    End Function
    Public Function GetlesClientsPortefeuille()
        'Connexion à la BDD
        InitialiserConnexionBase()
        ' Jeu d'enregistrement qui contiendra le résultat de la requête
        Dim dtClient As New DataTable
        ' Adaptateur SQL : l'objet sur lequel les commandes SQL seront lancées et dont le résultat sera mis dans un "DataTable"
        Dim sdaClient As New MySqlDataAdapter
        'On récupère les client portefeuille
        sdaClient.SelectCommand = New MySqlCommand("SELECT * FROM `client` WHERE `LibTypeClient` = 'portefeuille';", cnxClient1)
        ' Récupération des données
        sdaClient.Fill(dtClient)
        Dim lesClients As New List(Of Client)
        For Each client As DataRow In dtClient.Rows
            'NbVisites est rapporte une valeur null dans la base de données. On traite ceci avec IsDBNull
            If IsDBNull(client("NbVisites")) Then
                lesClients.Add(New Client(client("NumClient"), client("NomClient"), client("AdresseClient"), client("LibTypeClient"), 0))
            Else
                lesClients.Add(New Client(client("NumClient"), client("NomClient"), client("AdresseClient"), client("LibTypeClient"), client("NbVisites")))
            End If

        Next
        Return lesClients
    End Function
End Module
