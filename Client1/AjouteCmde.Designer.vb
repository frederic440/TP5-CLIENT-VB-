<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AjouteCmde
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
        Me.btn_Quitter_Click = New System.Windows.Forms.Button()
        Me.btn_AjoutCdme_Click = New System.Windows.Forms.Button()
        Me.cb_CliNewCmde = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btn_Quitter_Click
        '
        Me.btn_Quitter_Click.Location = New System.Drawing.Point(216, 212)
        Me.btn_Quitter_Click.Name = "btn_Quitter_Click"
        Me.btn_Quitter_Click.Size = New System.Drawing.Size(75, 23)
        Me.btn_Quitter_Click.TabIndex = 0
        Me.btn_Quitter_Click.Text = "Quitter"
        Me.btn_Quitter_Click.UseVisualStyleBackColor = True
        '
        'btn_AjoutCdme_Click
        '
        Me.btn_AjoutCdme_Click.Location = New System.Drawing.Point(377, 99)
        Me.btn_AjoutCdme_Click.Name = "btn_AjoutCdme_Click"
        Me.btn_AjoutCdme_Click.Size = New System.Drawing.Size(75, 23)
        Me.btn_AjoutCdme_Click.TabIndex = 1
        Me.btn_AjoutCdme_Click.Text = "Ajouter"
        Me.btn_AjoutCdme_Click.UseVisualStyleBackColor = True
        '
        'cb_CliNewCmde
        '
        Me.cb_CliNewCmde.FormattingEnabled = True
        Me.cb_CliNewCmde.Location = New System.Drawing.Point(149, 98)
        Me.cb_CliNewCmde.Name = "cb_CliNewCmde"
        Me.cb_CliNewCmde.Size = New System.Drawing.Size(186, 24)
        Me.cb_CliNewCmde.TabIndex = 2
        '
        'AjouteCmde
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 337)
        Me.Controls.Add(Me.cb_CliNewCmde)
        Me.Controls.Add(Me.btn_AjoutCdme_Click)
        Me.Controls.Add(Me.btn_Quitter_Click)
        Me.Name = "AjouteCmde"
        Me.Text = "AjouteCmde"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_Quitter_Click As Button
    Friend WithEvents btn_AjoutCdme_Click As Button
    Friend WithEvents cb_CliNewCmde As ComboBox
End Class
