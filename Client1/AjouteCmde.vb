Public Class AjouteCmde
    Private Sub AjouteCmde_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each cli As Client In GetlesClientsPortefeuille()
            Me.cb_CliNewCmde.Items.Add(cli.num & " - " & cli.nomClient)
        Next
    End Sub

    Private Sub btn_AjoutCdme_Click_Click(sender As Object, e As EventArgs) Handles btn_AjoutCdme_Click.Click
        'Fonction d'
        If Me.cb_CliNewCmde.Text <> "" Then
            Dim tmp As String() = Me.cb_CliNewCmde.SelectedItem.Split({" - "}, StringSplitOptions.None)
            InsertNewCommande(Int(tmp(0)))
            frmClient.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub btn_Quitter_Click_Click(sender As Object, e As EventArgs) Handles btn_Quitter_Click.Click
        Me.Close()

    End Sub

    Private Sub cb_CliNewCmde_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_CliNewCmde.SelectedIndexChanged

    End Sub
End Class