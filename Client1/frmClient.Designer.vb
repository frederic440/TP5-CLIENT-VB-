<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClient
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
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
        Me.bt_color = New System.Windows.Forms.Button()
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        CType(Me.dgvClient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.BtnAjoutClientProspect.SuspendLayout()
        Me.GrpBxTypeClient.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvClient
        '
        resources.ApplyResources(Me.dgvClient, "dgvClient")
        Me.dgvClient.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClient.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgvClient.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvClient.Name = "dgvClient"
        Me.dgvClient.RowTemplate.Height = 24
        '
        'ContextMenuStrip1
        '
        resources.ApplyResources(Me.ContextMenuStrip1, "ContextMenuStrip1")
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SupprimerToolStripMenuItem, Me.ModifierToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        '
        'SupprimerToolStripMenuItem
        '
        resources.ApplyResources(Me.SupprimerToolStripMenuItem, "SupprimerToolStripMenuItem")
        Me.SupprimerToolStripMenuItem.Name = "SupprimerToolStripMenuItem"
        '
        'ModifierToolStripMenuItem
        '
        resources.ApplyResources(Me.ModifierToolStripMenuItem, "ModifierToolStripMenuItem")
        Me.ModifierToolStripMenuItem.Name = "ModifierToolStripMenuItem"
        '
        'lblInfos
        '
        resources.ApplyResources(Me.lblInfos, "lblInfos")
        Me.lblInfos.Name = "lblInfos"
        '
        'MenuStrip1
        '
        resources.ApplyResources(Me.MenuStrip1, "MenuStrip1")
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaisirUneNouvelleCmdToolStripMenuItem})
        Me.MenuStrip1.Name = "MenuStrip1"
        '
        'SaisirUneNouvelleCmdToolStripMenuItem
        '
        resources.ApplyResources(Me.SaisirUneNouvelleCmdToolStripMenuItem, "SaisirUneNouvelleCmdToolStripMenuItem")
        Me.SaisirUneNouvelleCmdToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AfficherListeCmdToolStripMenuItem, Me.SaisirUneNouvelleCmdToolStripMenuItem1})
        Me.SaisirUneNouvelleCmdToolStripMenuItem.Name = "SaisirUneNouvelleCmdToolStripMenuItem"
        '
        'AfficherListeCmdToolStripMenuItem
        '
        resources.ApplyResources(Me.AfficherListeCmdToolStripMenuItem, "AfficherListeCmdToolStripMenuItem")
        Me.AfficherListeCmdToolStripMenuItem.Name = "AfficherListeCmdToolStripMenuItem"
        '
        'SaisirUneNouvelleCmdToolStripMenuItem1
        '
        resources.ApplyResources(Me.SaisirUneNouvelleCmdToolStripMenuItem1, "SaisirUneNouvelleCmdToolStripMenuItem1")
        Me.SaisirUneNouvelleCmdToolStripMenuItem1.Name = "SaisirUneNouvelleCmdToolStripMenuItem1"
        '
        'LblNumeroDeClient
        '
        resources.ApplyResources(Me.LblNumeroDeClient, "LblNumeroDeClient")
        Me.LblNumeroDeClient.Name = "LblNumeroDeClient"
        '
        'txtBxNumClient
        '
        resources.ApplyResources(Me.txtBxNumClient, "txtBxNumClient")
        Me.txtBxNumClient.Name = "txtBxNumClient"
        '
        'BtnCreerClient
        '
        resources.ApplyResources(Me.BtnCreerClient, "BtnCreerClient")
        Me.BtnCreerClient.BackColor = System.Drawing.Color.White
        Me.BtnCreerClient.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnCreerClient.Name = "BtnCreerClient"
        Me.BtnCreerClient.UseVisualStyleBackColor = False
        '
        'BtnAnnuler
        '
        resources.ApplyResources(Me.BtnAnnuler, "BtnAnnuler")
        Me.BtnAnnuler.BackColor = System.Drawing.Color.White
        Me.BtnAnnuler.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnAnnuler.Name = "BtnAnnuler"
        Me.BtnAnnuler.UseVisualStyleBackColor = False
        '
        'BtnAjoutClientProspect
        '
        resources.ApplyResources(Me.BtnAjoutClientProspect, "BtnAjoutClientProspect")
        Me.BtnAjoutClientProspect.Controls.Add(Me.bt_listCommande)
        Me.BtnAjoutClientProspect.Controls.Add(Me.bt_listClient)
        Me.BtnAjoutClientProspect.Name = "BtnAjoutClientProspect"
        Me.BtnAjoutClientProspect.TabStop = False
        '
        'bt_listCommande
        '
        resources.ApplyResources(Me.bt_listCommande, "bt_listCommande")
        Me.bt_listCommande.BackColor = System.Drawing.Color.White
        Me.bt_listCommande.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.bt_listCommande.Name = "bt_listCommande"
        Me.bt_listCommande.UseVisualStyleBackColor = False
        '
        'bt_listClient
        '
        resources.ApplyResources(Me.bt_listClient, "bt_listClient")
        Me.bt_listClient.BackColor = System.Drawing.Color.White
        Me.bt_listClient.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.bt_listClient.Name = "bt_listClient"
        Me.bt_listClient.UseVisualStyleBackColor = False
        '
        'GrpBxTypeClient
        '
        resources.ApplyResources(Me.GrpBxTypeClient, "GrpBxTypeClient")
        Me.GrpBxTypeClient.Controls.Add(Me.RdBtnPortefeuille)
        Me.GrpBxTypeClient.Controls.Add(Me.RdBtnProspect)
        Me.GrpBxTypeClient.Name = "GrpBxTypeClient"
        Me.GrpBxTypeClient.TabStop = False
        '
        'RdBtnPortefeuille
        '
        resources.ApplyResources(Me.RdBtnPortefeuille, "RdBtnPortefeuille")
        Me.RdBtnPortefeuille.Name = "RdBtnPortefeuille"
        Me.RdBtnPortefeuille.TabStop = True
        Me.RdBtnPortefeuille.UseVisualStyleBackColor = True
        '
        'RdBtnProspect
        '
        resources.ApplyResources(Me.RdBtnProspect, "RdBtnProspect")
        Me.RdBtnProspect.Name = "RdBtnProspect"
        Me.RdBtnProspect.TabStop = True
        Me.RdBtnProspect.UseVisualStyleBackColor = True
        '
        'BtnAjoutClient
        '
        resources.ApplyResources(Me.BtnAjoutClient, "BtnAjoutClient")
        Me.BtnAjoutClient.BackColor = System.Drawing.Color.White
        Me.BtnAjoutClient.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnAjoutClient.Name = "BtnAjoutClient"
        Me.BtnAjoutClient.UseVisualStyleBackColor = False
        '
        'BtnAnnul
        '
        resources.ApplyResources(Me.BtnAnnul, "BtnAnnul")
        Me.BtnAnnul.BackColor = System.Drawing.Color.White
        Me.BtnAnnul.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnAnnul.Name = "BtnAnnul"
        Me.BtnAnnul.UseVisualStyleBackColor = False
        '
        'TxtBxNomClient
        '
        resources.ApplyResources(Me.TxtBxNomClient, "TxtBxNomClient")
        Me.TxtBxNomClient.Name = "TxtBxNomClient"
        '
        'TxtBxAdresseClient
        '
        resources.ApplyResources(Me.TxtBxAdresseClient, "TxtBxAdresseClient")
        Me.TxtBxAdresseClient.Name = "TxtBxAdresseClient"
        '
        'TxtBxNbVisite
        '
        resources.ApplyResources(Me.TxtBxNbVisite, "TxtBxNbVisite")
        Me.TxtBxNbVisite.Name = "TxtBxNbVisite"
        '
        'LblNomClient
        '
        resources.ApplyResources(Me.LblNomClient, "LblNomClient")
        Me.LblNomClient.Name = "LblNomClient"
        '
        'LblAdresseClient
        '
        resources.ApplyResources(Me.LblAdresseClient, "LblAdresseClient")
        Me.LblAdresseClient.Name = "LblAdresseClient"
        '
        'LblNbVisiteClient
        '
        resources.ApplyResources(Me.LblNbVisiteClient, "LblNbVisiteClient")
        Me.LblNbVisiteClient.Name = "LblNbVisiteClient"
        '
        'cb_commande
        '
        resources.ApplyResources(Me.cb_commande, "cb_commande")
        Me.cb_commande.FormattingEnabled = True
        Me.cb_commande.Name = "cb_commande"
        '
        'BtnSuppCmde
        '
        resources.ApplyResources(Me.BtnSuppCmde, "BtnSuppCmde")
        Me.BtnSuppCmde.BackColor = System.Drawing.Color.White
        Me.BtnSuppCmde.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnSuppCmde.Name = "BtnSuppCmde"
        Me.BtnSuppCmde.UseVisualStyleBackColor = False
        '
        'bt_color
        '
        resources.ApplyResources(Me.bt_color, "bt_color")
        Me.bt_color.BackColor = System.Drawing.Color.White
        Me.bt_color.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.bt_color.Name = "bt_color"
        Me.bt_color.UseVisualStyleBackColor = False
        '
        'Guna2AnimateWindow1
        '
        Me.Guna2AnimateWindow1.TargetForm = Me
        '
        'frmClient
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.Controls.Add(Me.bt_color)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmClient"
        CType(Me.dgvClient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.BtnAjoutClientProspect.ResumeLayout(False)
        Me.GrpBxTypeClient.ResumeLayout(False)
        Me.GrpBxTypeClient.PerformLayout()
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
    Friend WithEvents bt_color As Button
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
End Class
