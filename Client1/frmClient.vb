' ==========================================================
'
'   TP3-SLAM3 (SQL prodécural + VB)
'   Code à compléter
'   
' ==========================================================

' Nécessite l'ajout du composant MySQLData v6.9.12 au projet
Imports MySql.Data.MySqlClient
Public Class frmClient

    ' Object connexion à la base MySQL
    Private cnxClient1 As MySqlConnection

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
    '#####################################################################################################
    '#################################### LES METHODES ###################################################
    '#####################################################################################################

    ' Remplissage de la grille de données
    Private Sub RemplirGrilleCommande()
        ' Jeu d'enregistrement qui contiendra le résultat de la requête
        Dim dtClient As New DataTable
        ' Adaptateur SQL : l'objet sur lequel les commandes SQL seront lancées et dont le résultat sera mis dans un "DataTable"
        Dim sdaClient As New MySqlDataAdapter

        ' Exécution de la requête sur la connexion
        sdaClient.SelectCommand = New MySqlCommand("SELECT `NumCmde`,`DateCmde`,`NomClient`,`AdresseClient` FROM `commande` INNER Join client ON CLIENT.NumClient = commande.NumClient ORDER by commande.DateCmde desc;", cnxClient1)
        ' Récupération des données
        sdaClient.Fill(dtClient)
        ' On affecte le jeu d'enregistrements résultat à la grille de données
        dgvClient.DataSource = dtClient

    End Sub
    ' Remplissage de la grille de données
    Private Sub ListdesClient()

        ' Jeu d'enregistrement qui contiendra le résultat de la requête
        Dim dtClient As New DataTable
        ' Adaptateur SQL : l'objet sur lequel les commandes SQL seront lancées et dont le résultat sera mis dans un "DataTable"
        Dim sdaCmde As New MySqlDataAdapter

        ' Exécution de la requête sur la connexion
        sdaCmde.SelectCommand = New MySqlCommand("select * from client", cnxClient1)
        ' Récupération des données
        sdaCmde.Fill(dtClient)
        ' On affecte le jeu d'enregistrements résultat à la grille de données
        dgvClient.DataSource = dtClient

    End Sub

    Private Sub frmClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitialiserConnexionBase()
        RemplirGrilleCommande()
        remplirCb_Commande()

    End Sub

    Private Sub AfficherListeCmdToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AfficherListeCmdToolStripMenuItem.Click
        chargementListeCommande()
    End Sub

    Private Sub SaisirUneNouvelleCmdToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SaisirUneNouvelleCmdToolStripMenuItem1.Click
        lblInfos.Text = "Veuillez saisir un numéro de client portefeuille :"
        dgvClient.Hide()
        LblNumeroDeClient.Show()
        txtBxNumClient.Show()
        BtnCreerClient.Show()
        BtnAnnuler.Show()
    End Sub

    Private Sub chargementListeCommande()
        'On revient à l'accueil et on adapte la fenêtre + chargementListeCommande
        lblInfos.Text = "Liste des commandes de clients portefeuille"
        RemplirGrilleCommande()
        dgvClient.Show()
        LblNumeroDeClient.Hide()
        txtBxNumClient.Hide()
        BtnCreerClient.Hide()
        BtnAnnuler.Hide()
        txtBxNumClient.Clear()
    End Sub

    Private Sub creerCommande()
        Dim cmd As New MySqlCommand
        With cmd
            'Paramétrer la commande
            .Connection = cnxClient1
            .CommandText = "INSERT INTO `commande`(`DateCmde`, `NumClient`) VALUES (now()," + txtBxNumClient.Text + ");"
            .CommandType = CommandType.Text
        End With

        Try
            cmd.ExecuteNonQuery()
            MsgBox("La création de la commande du client " + txtBxNumClient.Text + " a bien été effectuée ! ", MsgBoxStyle.OkOnly, "Création de commande ok")
        Catch ex As Exception
            If ex.Message.ToString = "Ce client est prospect, souhaitez-vous qu’il passe en portefeuille ?" Then
                'Appel de la méthode de transmutation
                transmutationClient(ex)
            Else
                MsgBox("ERREUR : " + vbCr + Chr(13) + ex.Message, vbCritical, "Erreur insertion commande")
            End If
        End Try
        chargementListeCommande()
    End Sub
    Private Sub transmutationClient(ex As Exception)
        Dim Response = MsgBox("ERREUR : " + vbCr + Chr(13) + ex.Message, MsgBoxStyle.OkCancel + vbCritical, "Erreur (mauvais type cl)")
        If Response = DialogResult.OK Then
            'lancer transmutation du client dans le cas où c'est un client portefeuille et qu'on veut le transmuter
            Dim cmdTransmut As New MySqlCommand
            With cmdTransmut
                'Paramétrer la commande de transmutation
                .Connection = cnxClient1
                .CommandText = "CALL `sp_transmuter`(" + txtBxNumClient.Text + ");" 'procedure stockée avec paramètres
                .CommandType = CommandType.Text
            End With
            Try
                cmdTransmut.ExecuteNonQuery()
                MsgBox("La transmutation du client " + txtBxNumClient.Text + " a bien été effectuée ! ", MsgBoxStyle.OkOnly, "Transmutation ok")
            Catch exTransmut As Exception
                MsgBox("ERREUR : " + vbCr + Chr(13) + exTransmut.Message, vbCritical, "Transmutation échouée")
            End Try
            creerCommande()
        Else : MsgBox("ERREUR : " + vbCr + Chr(13) + "un client prospect ne peut pas avoir de commande !", vbCritical, "Ajout de commande impossible")
        End If

    End Sub


    ' Ajoute un client dans la base de données en appelant la procédure stockée 
    Private Sub AjouterClient()



        ' Tableau des paramètres à envoyer à la procédure stockée
        Dim Params(2) As MySqlParameter   '3 paramètres indicés de 0 à 2

        ' On indique les parametre pour la procédure stockée
        Params(0) = New MySqlParameter("unNomClient", MySqlDbType.VarChar)
        Params(0).Value = TxtBxNomClient.Text

        Params(1) = New MySqlParameter("uneAdresseClient", MySqlDbType.VarChar)
        Params(1).Value = TxtBxAdresseClient.Text

        Params(2) = New MySqlParameter("unNbVisites", MySqlDbType.VarChar)
        Params(2).Value = TxtBxNbVisite.Text

        Dim cmd As New MySqlCommand()
        'On indique la connexion et qu'il s'agit d'une procédure stockée
        cmd.Connection = cnxClient1
        cmd.CommandType = CommandType.StoredProcedure

        'Verification du type de client
        If RdBtnPortefeuille.Checked = True Then
            cmd.CommandText = "sp_InsertPortefeuille"
        Else
            cmd.CommandText = "sp_InsertProspect"
        End If
        ' Les paramètres sont attribués à la commande
        cmd.Parameters.AddRange(Params)



        Try
            ' Exécution de la commande
            cmd.ExecuteNonQuery()
            MsgBox("Insertion réussie !")
            ListdesClient()

        Catch ex As Exception
            MsgBox("ERREUR : Ajout impossible." + Chr(13) + ex.Message, vbCritical)

        End Try



    End Sub

    Private Sub SupprimerCommande()

        ' Tableau des paramètres à envoyer à la procédure stockée
        Dim Params(0) As MySqlParameter   '3 paramètres indicés de 0 à 2

        ' On indique les parametre pour la procédure stockée
        Params(0) = New MySqlParameter("unNumCmde", MySqlDbType.VarChar)
        Params(0).Value = cb_commande.Text

        Dim cmd As New MySqlCommand()

        cmd.Connection = cnxClient1
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_DeleteCommande"

        cmd.Parameters.AddRange(Params)

        Try
            ' Exécution de la commande
            cmd.ExecuteNonQuery()
            MsgBox("Suppression réussie !")
            RemplirGrilleCommande()

        Catch ex As Exception
            MsgBox("ERREUR : Suppression impossible." + Chr(13) + ex.Message, vbCritical)

        End Try
    End Sub
    Private Sub remplirCb_Commande()
        Dim adapteras As New MySqlDataAdapter("select * from commande", cnxClient1)
        Dim table As New DataTable()

        adapteras.Fill(table)
        cb_commande.DataSource = table

        cb_commande.ValueMember = "NumCmde"
        cb_commande.DisplayMember = "NumCmde"
    End Sub
    '#####################################################################################################
    '#################################### BOUTONS Event ##################################################
    '#####################################################################################################

    Private Sub BtnCreerClient_Click(sender As Object, e As EventArgs) Handles BtnCreerClient.Click
        creerCommande()
    End Sub

    Private Sub BtnAnnuler_Click(sender As Object, e As EventArgs) Handles BtnAnnuler.Click
        chargementListeCommande()
    End Sub
    Private Sub BtnSuppCmde_Click(sender As Object, e As EventArgs) Handles BtnSuppCmde.Click
        SupprimerCommande()
    End Sub
    Private Sub bt_listClient_Click(sender As Object, e As EventArgs) Handles bt_listClient.Click
        ListdesClient()
        lblInfos.Text = "Liste de tout les types de clients"
    End Sub

    Private Sub bt_listCommande_Click(sender As Object, e As EventArgs) Handles bt_listCommande.Click
        RemplirGrilleCommande()
        lblInfos.Text = "Liste des commandes clients portefeuille"
    End Sub
    Private Sub BtnAjoutClient_Click(sender As Object, e As EventArgs) Handles BtnAjoutClient.Click
        AjouterClient()
    End Sub

    Private Sub bt_color_Click(sender As Object, e As EventArgs) Handles bt_color.Click
        'Dim maclass As New Class_Collection
        'Try
        '    maclass.cc()
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
    End Sub
End Class
