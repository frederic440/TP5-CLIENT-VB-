<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmClient
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClient))
        Me.dgvClient = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SupprimerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblInfos = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SaisirUneNouvelleCmdToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AfficherListeCmdToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaisirUneNouvelleCmdToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LblNumeroDeClient = New System.Windows.Forms.Label()
        Me.txtBxNumClient = New System.Windows.Forms.TextBox()
        Me.BtnCreerClient = New System.Windows.Forms.Button()
        Me.BtnAnnuler = New System.Windows.Forms.Button()
        Me.BtnAjoutClientProspect = New System.Windows.Forms.GroupBox()
        Me.bt_listCommande = New System.Windows.Forms.Button()
        Me.bt_listClient = New System.Windows.Forms.Button()
        Me.GrpBxTypeClient = New System.Windows.Forms.GroupBox()
        Me.RdBtnPortefeuille = New System.Windows.Forms.RadioButton()
        Me.RdBtnProspect = New System.Windows.Forms.RadioButton()
        Me.BtnAjoutClient = New System.Windows.Forms.Button()
        Me.BtnAnnul = New System.Windows.Forms.Button()
        Me.TxtBxNomClient = New System.Windows.Forms.TextBox()
        Me.TxtBxAdresseClient = New System.Windows.Forms.TextBox()
        Me.TxtBxNbVisite = New System.Windows.Forms.TextBox()
        Me.LblNomClient = New System.Windows.Forms.Label()
        Me.LblAdresseClient = New System.Windows.Forms.Label()
        Me.LblNbVisiteClient = New System.Windows.Forms.Label()
        Me.cb_commande = New System.Windows.Forms.ComboBox()
        Me.BtnSuppCmde = New System.Windows.Forms.Button()
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.bt_CmdeCliExist = New System.Windows.Forms.Button()
        Me.lbl_AddCliExist = New System.Windows.Forms.Label()
        Me.lbl_CreateClient = New System.Windows.Forms.Label()
        CType(Me.dgvClient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.BtnAjoutClientProspect.SuspendLayout()
        Me.GrpBxTypeClient.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvClient
        '
        Me.dgvClient.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClient.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgvClient.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvClient.Location = New System.Drawing.Point(15, 64)
        Me.dgvClient.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvClient.Name = "dgvClient"
        Me.dgvClient.RowHeadersWidth = 51
        Me.dgvClient.RowTemplate.Height = 24
        Me.dgvClient.Size = New System.Drawing.Size(702, 329)
        Me.dgvClient.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SupprimerToolStripMenuItem, Me.ModifierToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(148, 52)
        '
        'SupprimerToolStripMenuItem
        '
        Me.SupprimerToolStripMenuItem.Name = "SupprimerToolStripMenuItem"
        Me.SupprimerToolStripMenuItem.Size = New System.Drawing.Size(147, 24)
        Me.SupprimerToolStripMenuItem.Text = "Supprimer"
        '
        'ModifierToolStripMenuItem
        '
        Me.ModifierToolStripMenuItem.Name = "ModifierToolStripMenuItem"
        Me.ModifierToolStripMenuItem.Size = New System.Drawing.Size(147, 24)
        Me.ModifierToolStripMenuItem.Text = "Modifier"
        '
        'lblInfos
        '
        Me.lblInfos.AutoSize = True
        Me.lblInfos.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblInfos.Location = New System.Drawing.Point(89, 30)
        Me.lblInfos.Name = "lblInfos"
        Me.lblInfos.Size = New System.Drawing.Size(504, 25)
        Me.lblInfos.TabIndex = 1
        Me.lblInfos.Text = "Liste des commandes de clients portefeuille"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaisirUneNouvelleCmdToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1355, 28)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SaisirUneNouvelleCmdToolStripMenuItem
        '
        Me.SaisirUneNouvelleCmdToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AfficherListeCmdToolStripMenuItem, Me.SaisirUneNouvelleCmdToolStripMenuItem1})
        Me.SaisirUneNouvelleCmdToolStripMenuItem.Name = "SaisirUneNouvelleCmdToolStripMenuItem"
        Me.SaisirUneNouvelleCmdToolStripMenuItem.Size = New System.Drawing.Size(60, 24)
        Me.SaisirUneNouvelleCmdToolStripMenuItem.Text = "Menu"
        '
        'AfficherListeCmdToolStripMenuItem
        '
        Me.AfficherListeCmdToolStripMenuItem.Name = "AfficherListeCmdToolStripMenuItem"
        Me.AfficherListeCmdToolStripMenuItem.Size = New System.Drawing.Size(248, 26)
        Me.AfficherListeCmdToolStripMenuItem.Text = "Afficher liste cmd"
        '
        'SaisirUneNouvelleCmdToolStripMenuItem1
        '
        Me.SaisirUneNouvelleCmdToolStripMenuItem1.Name = "SaisirUneNouvelleCmdToolStripMenuItem1"
        Me.SaisirUneNouvelleCmdToolStripMenuItem1.Size = New System.Drawing.Size(248, 26)
        Me.SaisirUneNouvelleCmdToolStripMenuItem1.Text = "Saisir une nouvelle cmd"
        '
        'LblNumeroDeClient
        '
        Me.LblNumeroDeClient.AutoSize = True
        Me.LblNumeroDeClient.Location = New System.Drawing.Point(43, 185)
        Me.LblNumeroDeClient.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblNumeroDeClient.Name = "LblNumeroDeClient"
        Me.LblNumeroDeClient.Size = New System.Drawing.Size(123, 17)
        Me.LblNumeroDeClient.TabIndex = 3
        Me.LblNumeroDeClient.Text = "Numero de client :"
        Me.LblNumeroDeClient.Visible = False
        '
        'txtBxNumClient
        '
        Me.txtBxNumClient.Location = New System.Drawing.Point(237, 181)
        Me.txtBxNumClient.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBxNumClient.Name = "txtBxNumClient"
        Me.txtBxNumClient.Size = New System.Drawing.Size(316, 22)
        Me.txtBxNumClient.TabIndex = 4
        Me.txtBxNumClient.Visible = False
        '
        'BtnCreerClient
        '
        Me.BtnCreerClient.BackColor = System.Drawing.Color.White
        Me.BtnCreerClient.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnCreerClient.Location = New System.Drawing.Point(237, 252)
        Me.BtnCreerClient.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCreerClient.Name = "BtnCreerClient"
        Me.BtnCreerClient.Size = New System.Drawing.Size(121, 38)
        Me.BtnCreerClient.TabIndex = 5
        Me.BtnCreerClient.Text = "Créer le client"
        Me.BtnCreerClient.UseVisualStyleBackColor = False
        Me.BtnCreerClient.Visible = False
        '
        'BtnAnnuler
        '
        Me.BtnAnnuler.BackColor = System.Drawing.Color.White
        Me.BtnAnnuler.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnAnnuler.Location = New System.Drawing.Point(433, 252)
        Me.BtnAnnuler.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnAnnuler.Name = "BtnAnnuler"
        Me.BtnAnnuler.Size = New System.Drawing.Size(121, 38)
        Me.BtnAnnuler.TabIndex = 6
        Me.BtnAnnuler.Text = "Annuler"
        Me.BtnAnnuler.UseVisualStyleBackColor = False
        Me.BtnAnnuler.Visible = False
        '
        'BtnAjoutClientProspect
        '
        Me.BtnAjoutClientProspect.Controls.Add(Me.bt_listCommande)
        Me.BtnAjoutClientProspect.Controls.Add(Me.bt_listClient)
        Me.BtnAjoutClientProspect.Location = New System.Drawing.Point(15, 414)
        Me.BtnAjoutClientProspect.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnAjoutClientProspect.Name = "BtnAjoutClientProspect"
        Me.BtnAjoutClientProspect.Padding = New System.Windows.Forms.Padding(4)
        Me.BtnAjoutClientProspect.Size = New System.Drawing.Size(268, 99)
        Me.BtnAjoutClientProspect.TabIndex = 7
        Me.BtnAjoutClientProspect.TabStop = False
        Me.BtnAjoutClientProspect.Text = "Action List"
        '
        'bt_listCommande
        '
        Me.bt_listCommande.BackColor = System.Drawing.Color.White
        Me.bt_listCommande.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.bt_listCommande.Location = New System.Drawing.Point(57, 51)
        Me.bt_listCommande.Name = "bt_listCommande"
        Me.bt_listCommande.Size = New System.Drawing.Size(189, 23)
        Me.bt_listCommande.TabIndex = 2
        Me.bt_listCommande.Text = "Liste des commandes"
        Me.bt_listCommande.UseVisualStyleBackColor = False
        '
        'bt_listClient
        '
        Me.bt_listClient.BackColor = System.Drawing.Color.White
        Me.bt_listClient.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.bt_listClient.Location = New System.Drawing.Point(80, 22)
        Me.bt_listClient.Name = "bt_listClient"
        Me.bt_listClient.Size = New System.Drawing.Size(138, 23)
        Me.bt_listClient.TabIndex = 1
        Me.bt_listClient.Text = "Liste des clients"
        Me.bt_listClient.UseVisualStyleBackColor = False
        '
        'GrpBxTypeClient
        '
        Me.GrpBxTypeClient.Controls.Add(Me.RdBtnPortefeuille)
        Me.GrpBxTypeClient.Controls.Add(Me.RdBtnProspect)
        Me.GrpBxTypeClient.Location = New System.Drawing.Point(920, 318)
        Me.GrpBxTypeClient.Name = "GrpBxTypeClient"
        Me.GrpBxTypeClient.Size = New System.Drawing.Size(254, 123)
        Me.GrpBxTypeClient.TabIndex = 14
        Me.GrpBxTypeClient.TabStop = False
        Me.GrpBxTypeClient.Text = "Type de client"
        '
        'RdBtnPortefeuille
        '
        Me.RdBtnPortefeuille.AutoSize = True
        Me.RdBtnPortefeuille.Location = New System.Drawing.Point(35, 81)
        Me.RdBtnPortefeuille.Name = "RdBtnPortefeuille"
        Me.RdBtnPortefeuille.Size = New System.Drawing.Size(100, 21)
        Me.RdBtnPortefeuille.TabIndex = 2
        Me.RdBtnPortefeuille.TabStop = True
        Me.RdBtnPortefeuille.Text = "Portefeuille"
        Me.RdBtnPortefeuille.UseVisualStyleBackColor = True
        '
        'RdBtnProspect
        '
        Me.RdBtnProspect.AutoSize = True
        Me.RdBtnProspect.Location = New System.Drawing.Point(35, 39)
        Me.RdBtnProspect.Name = "RdBtnProspect"
        Me.RdBtnProspect.Size = New System.Drawing.Size(85, 21)
        Me.RdBtnProspect.TabIndex = 1
        Me.RdBtnProspect.TabStop = True
        Me.RdBtnProspect.Text = "Prospect"
        Me.RdBtnProspect.UseVisualStyleBackColor = True
        '
        'BtnAjoutClient
        '
        Me.BtnAjoutClient.BackColor = System.Drawing.Color.White
        Me.BtnAjoutClient.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnAjoutClient.Location = New System.Drawing.Point(920, 475)
        Me.BtnAjoutClient.Name = "BtnAjoutClient"
        Me.BtnAjoutClient.Size = New System.Drawing.Size(75, 23)
        Me.BtnAjoutClient.TabIndex = 15
        Me.BtnAjoutClient.Text = "Ajouter"
        Me.BtnAjoutClient.UseVisualStyleBackColor = False
        '
        'BtnAnnul
        '
        Me.BtnAnnul.BackColor = System.Drawing.Color.White
        Me.BtnAnnul.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnAnnul.Location = New System.Drawing.Point(1067, 475)
        Me.BtnAnnul.Name = "BtnAnnul"
        Me.BtnAnnul.Size = New System.Drawing.Size(75, 23)
        Me.BtnAnnul.TabIndex = 16
        Me.BtnAnnul.Text = "Annuler"
        Me.BtnAnnul.UseVisualStyleBackColor = False
        '
        'TxtBxNomClient
        '
        Me.TxtBxNomClient.Location = New System.Drawing.Point(971, 144)
        Me.TxtBxNomClient.Name = "TxtBxNomClient"
        Me.TxtBxNomClient.Size = New System.Drawing.Size(242, 22)
        Me.TxtBxNomClient.TabIndex = 17
        '
        'TxtBxAdresseClient
        '
        Me.TxtBxAdresseClient.Location = New System.Drawing.Point(971, 199)
        Me.TxtBxAdresseClient.Name = "TxtBxAdresseClient"
        Me.TxtBxAdresseClient.Size = New System.Drawing.Size(242, 22)
        Me.TxtBxAdresseClient.TabIndex = 18
        '
        'TxtBxNbVisite
        '
        Me.TxtBxNbVisite.Location = New System.Drawing.Point(971, 255)
        Me.TxtBxNbVisite.Name = "TxtBxNbVisite"
        Me.TxtBxNbVisite.Size = New System.Drawing.Size(242, 22)
        Me.TxtBxNbVisite.TabIndex = 19
        '
        'LblNomClient
        '
        Me.LblNomClient.AutoSize = True
        Me.LblNomClient.Location = New System.Drawing.Point(863, 144)
        Me.LblNomClient.Name = "LblNomClient"
        Me.LblNomClient.Size = New System.Drawing.Size(86, 17)
        Me.LblNomClient.TabIndex = 20
        Me.LblNomClient.Text = "Nom client : "
        '
        'LblAdresseClient
        '
        Me.LblAdresseClient.AutoSize = True
        Me.LblAdresseClient.Location = New System.Drawing.Point(840, 202)
        Me.LblAdresseClient.Name = "LblAdresseClient"
        Me.LblAdresseClient.Size = New System.Drawing.Size(109, 17)
        Me.LblAdresseClient.TabIndex = 21
        Me.LblAdresseClient.Text = "Adresse client : "
        '
        'LblNbVisiteClient
        '
        Me.LblNbVisiteClient.AutoSize = True
        Me.LblNbVisiteClient.Location = New System.Drawing.Point(840, 258)
        Me.LblNbVisiteClient.Name = "LblNbVisiteClient"
        Me.LblNbVisiteClient.Size = New System.Drawing.Size(106, 17)
        Me.LblNbVisiteClient.TabIndex = 22
        Me.LblNbVisiteClient.Text = "Nombre visite : "
        '
        'cb_commande
        '
        Me.cb_commande.FormattingEnabled = True
        Me.cb_commande.Location = New System.Drawing.Point(376, 437)
        Me.cb_commande.Name = "cb_commande"
        Me.cb_commande.Size = New System.Drawing.Size(217, 24)
        Me.cb_commande.TabIndex = 23
        '
        'BtnSuppCmde
        '
        Me.BtnSuppCmde.BackColor = System.Drawing.Color.White
        Me.BtnSuppCmde.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnSuppCmde.Location = New System.Drawing.Point(628, 437)
        Me.BtnSuppCmde.Name = "BtnSuppCmde"
        Me.BtnSuppCmde.Size = New System.Drawing.Size(114, 23)
        Me.BtnSuppCmde.TabIndex = 24
        Me.BtnSuppCmde.Text = "Supprimer"
        Me.BtnSuppCmde.UseVisualStyleBackColor = False
        '
        'Guna2AnimateWindow1
        '
        Me.Guna2AnimateWindow1.TargetForm = Me
        '
        'bt_CmdeCliExist
        '
        Me.bt_CmdeCliExist.Location = New System.Drawing.Point(450, 516)
        Me.bt_CmdeCliExist.Name = "bt_CmdeCliExist"
        Me.bt_CmdeCliExist.Size = New System.Drawing.Size(143, 43)
        Me.bt_CmdeCliExist.TabIndex = 3
        Me.bt_CmdeCliExist.Text = "Ajouter la commande"
        Me.bt_CmdeCliExist.UseVisualStyleBackColor = True
        '
        'lbl_AddCliExist
        '
        Me.lbl_AddCliExist.AutoSize = True
        Me.lbl_AddCliExist.Location = New System.Drawing.Point(362, 496)
        Me.lbl_AddCliExist.Name = "lbl_AddCliExist"
        Me.lbl_AddCliExist.Size = New System.Drawing.Size(303, 17)
        Me.lbl_AddCliExist.TabIndex = 25
        Me.lbl_AddCliExist.Text = "Ajout d'une commande d'un client déjà existant"
        '
        'lbl_CreateClient
        '
        Me.lbl_CreateClient.AutoSize = True
        Me.lbl_CreateClient.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_CreateClient.Location = New System.Drawing.Point(902, 83)
        Me.lbl_CreateClient.Name = "lbl_CreateClient"
        Me.lbl_CreateClient.Size = New System.Drawing.Size(300, 25)
        Me.lbl_CreateClient.TabIndex = 26
        Me.lbl_CreateClient.Text = "Créer un nouveau client : "
        '
        'frmClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.ClientSize = New System.Drawing.Size(1355, 791)
        Me.Controls.Add(Me.lbl_CreateClient)
        Me.Controls.Add(Me.lbl_AddCliExist)
        Me.Controls.Add(Me.bt_CmdeCliExist)
        Me.Controls.Add(Me.BtnSuppCmde)
        Me.Controls.Add(Me.cb_commande)
        Me.Controls.Add(Me.LblNbVisiteClient)
        Me.Controls.Add(Me.LblAdresseClient)
        Me.Controls.Add(Me.LblNomClient)
        Me.Controls.Add(Me.TxtBxNbVisite)
        Me.Controls.Add(Me.TxtBxAdresseClient)
        Me.Controls.Add(Me.TxtBxNomClient)
        Me.Controls.Add(Me.BtnAnnul)
        Me.Controls.Add(Me.BtnAjoutClient)
        Me.Controls.Add(Me.GrpBxTypeClient)
        Me.Controls.Add(Me.BtnAjoutClientProspect)
        Me.Controls.Add(Me.BtnAnnuler)
        Me.Controls.Add(Me.BtnCreerClient)
        Me.Controls.Add(Me.txtBxNumClient)
        Me.Controls.Add(Me.LblNumeroDeClient)
        Me.Controls.Add(Me.lblInfos)
        Me.Controls.Add(Me.dgvClient)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmClient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clients v1.21"
        CType(Me.dgvClient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.BtnAjoutClientProspect.ResumeLayout(False)
        Me.GrpBxTypeClient.ResumeLayout(False)
        Me.GrpBxTypeClient.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvClient As System.Windows.Forms.DataGridView
    Friend WithEvents lblInfos As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SaisirUneNouvelleCmdToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AfficherListeCmdToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LblNumeroDeClient As System.Windows.Forms.Label
    Friend WithEvents txtBxNumClient As System.Windows.Forms.TextBox
    Friend WithEvents SaisirUneNouvelleCmdToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BtnCreerClient As System.Windows.Forms.Button
    Friend WithEvents BtnAnnuler As System.Windows.Forms.Button
    Friend WithEvents BtnAjoutClientProspect As GroupBox
    Friend WithEvents GrpBxTypeClient As GroupBox
    Friend WithEvents RdBtnPortefeuille As RadioButton
    Friend WithEvents RdBtnProspect As RadioButton
    Friend WithEvents BtnAjoutClient As Button
    Friend WithEvents BtnAnnul As Button
    Friend WithEvents TxtBxNomClient As TextBox
    Friend WithEvents TxtBxAdresseClient As TextBox
    Friend WithEvents TxtBxNbVisite As TextBox
    Friend WithEvents LblNomClient As Label
    Friend WithEvents LblAdresseClient As Label
    Friend WithEvents LblNbVisiteClient As Label
    Friend WithEvents bt_listCommande As Button
    Friend WithEvents bt_listClient As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents SupprimerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModifierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cb_commande As ComboBox
    Friend WithEvents BtnSuppCmde As Button
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents bt_CmdeCliExist As Button
    Friend WithEvents lbl_CreateClient As Label
    Friend WithEvents lbl_AddCliExist As Label
End Class
