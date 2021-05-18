Imports MySql.Data.MySqlClient


Public Class Class_Collection

    Dim commandes As New List(Of Commande)
    Private cnxClient1 As MySqlConnection

    Sub New()
        'MsgBox("je marche !!!")
        InitialiserConnexionBase()
            get_CmdeInBDD()
        End Sub

        Public Function addCommande(ByVal unNumCmde As Integer, ByVal UneDateCmde As Date, ByVal UnClient As Integer)
            Dim Cmde As New Commande()
            Cmde.set_NumCmde(unNumCmde)
            Cmde.set_DateCmde(UneDateCmde)
            Cmde.set_NumClient(UnClient)
            commandes.Add(Cmde)

        End Function
        'Private lesClientsProspects As Collection = New Collection

        'Public Function GetlesClientsProspects()

        'End Function
        'Module Program
        '    Sub Main()
        '        ' Create a new instance of the Generic class List.
        '        Dim ListOfNames = New List(Of String)

        '        ' Add 3 elements to the list.
        '        ListOfNames.Add("Alexandre")
        '        ListOfNames.Add("Maxime")
        '        ListOfNames.Add("Daniel")
        '    End Sub
        'End Module

        'Private lesClientsProspects As List(Of Class_Collection)
        'Public Property ClientsProspects() As List(Of Class_Collection)

        '    Get
        '        If lesClientsProspects Is Nothing Then
        '            lesClientsProspects = "SELECT * FROM `vclientprospect`"
        '        End If
        '        Return lesClientsProspects
        '    End Get
        '    Set(ByVal value As Collection(Of MyFeatureVM))
        '        _items = value
        '    End Set
        'End Property
        'Private m_FormBackgroundColor As Color
        'Public Property FormBackgroundColor As Color
        '    Get
        '        Return m_FormBackgroundColor
        '    End Get
        '    Set(value As Color)
        '        m_FormBackgroundColor = value
        '        For Each Frm As Form In Application.OpenForms
        '            Frm.BackColor = m_FormBackgroundColor
        '        Next
        '    End Set
        'End Property
        'Public Function cc() As Bitmap
        '    Dim s As Screen = Screen.PrimaryScreen
        '    Dim img As New Bitmap(s.Bounds.Width, s.Bounds.Height)
        '    Dim gr As Graphics = Graphics.FromImage(img)
        '    gr.CopyFromScreen(s.Bounds.Location, Point.Empty, s.Bounds.Size)
        '    Return img
        'End Function

        ' Ouvre une connexion à base de données MySQL

        Private Sub InitialiserConnexionBase()
        ' Chaîne de connexion à la base de donnéees
        Dim ChaineConnexion As String
        ChaineConnexion = "server=localhost;user=root;database=tp5_client1;port=3306;password='';"
        'ChaineConnexion = "server=172.18.153.50;user=user;database=bdd_client1;password='12-Soleil&';"
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
    Public Function get_CmdeInBDD()
        ' Jeu d'enregistrement qui contiendra le résultat de la requête
        Dim dtClient As New DataTable
        ' Adaptateur SQL : l'objet sur lequel les commandes SQL seront lancées et dont le résultat sera mis dans un "DataTable"
        Dim sdaClient As New MySqlDataAdapter
        Dim dgvClient As New DataGridView
        ' Exécution de la requête sur la connexion
        sdaClient.SelectCommand = New MySqlCommand("SELECT * FROM `commande`;", cnxClient1)
        ' Récupération des données
        sdaClient.Fill(dtClient)
        For Each Client As DataRow In dtClient.Rows
            addCommande(Client("NumCmde"), Client("DateCmde"), Client("NumClient"))
        Next
        Return dgvClient.DataSource = dtClient
    End Function

End Class
