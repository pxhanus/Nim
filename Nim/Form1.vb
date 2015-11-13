'Patricia Hanus
'151113
'Nim
'______________________________________________________________________________________________
Public Class Form1

    Private Sub btnNewGame_Click(sender As Object, e As EventArgs) Handles btnNewGame.Click
        Randomize()
        Dim stonePile As Integer = Int(Rnd() * 30 + 15)
        Me.lblStonesPile.Text = "Stones in pile: " & stonePile
    End Sub

    Private Sub btnTakeStones_Click(sender As Object, e As EventArgs) Handles btnTakeStones.Click
        Const MIN As Integer = 1
        Const MAX As Integer = 3
        Dim playerTakeAway As Integer = Val(Me.txtPlayerTakeAway.Text)

        If Not ValidEntry(playerTakeAway, MAX, MIN) Then
            MessageBox.Show("Invalid guess. Please try again.")
        End If
    End Sub
    '*******************************************************************************************
    'Valid Entry
    'Returns True if MIN <= playerTakeAway <= MAX
    '
    'True has been returned if MIN <= playerTakeAway <= MAX. 
    'Else False is returned.
    '*******************************************************************************************
    Function ValidEntry(ByVal playerTA As Integer, ByVal max As Integer, ByVal min As Integer) As Boolean
        If playerTA > max Or playerTA < min Then
            Return False
        Else
            Return True
        End If
    End Function
End Class
