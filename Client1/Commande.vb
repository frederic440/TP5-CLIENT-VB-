Public Class Commande
    Dim NumCmde As Integer
    Dim DateCmde As Date
    Dim NumClient As Integer

    Sub New()
        MsgBox("je fonctionne !!!")
    End Sub

    Public Function get_NumCmde()
        Return NumCmde
    End Function
    Public Function get_DateCmde()
        Return DateCmde
    End Function
    Public Function get_NumClient()
        Return NumClient
    End Function


    Public Function set_NumCmde(val As Integer)
        NumCmde = val
    End Function
    Public Function set_DateCmde(val As Date)
        DateCmde = val
    End Function
    Public Function set_NumClient(val As Integer)
        NumClient = val
    End Function
End Class
