'Patricia Hanus
'151113
'Nim
'______________________________________________________________________________________________
Public Class Form1
    Dim stonePile As Integer = RndInt(15, 30)
    Private Sub btnNewGame_Click(sender As Object, e As EventArgs) Handles btnNewGame.Click
        Me.lblStonesPile.Text = "Stones in pile: " & stonePile
    End Sub

    Private Sub btnTakeStones_Click(sender As Object, e As EventArgs) Handles btnTakeStones.Click
        Const MIN As Integer = 1
        Const MAX As Integer = 3
        Dim compTakeAway As Integer = RndInt(1, 3)
        Dim playerTakeAway As Integer = Val(Me.txtPlayerTakeAway.Text)


        If Not ValidEntry(playerTakeAway, MAX, MIN) Then
            MessageBox.Show("Invalid guess. Please try again.")
        End If

            stonePile = stonePile - playerTakeAway
            stonePile = stonePile - compTakeAway
            Me.lblStonesPile.Text = "Stones in pile: " & stonePile
    End Sub
    '********************************************************************************************
    'RndInt
    'Returns a random integer between max and min
    '
    'post:  A number is returned
    '********************************************************************************************
    Function RndInt(ByVal min As Integer, ByVal max As Integer) As Integer
        Randomize()
        Return Int((max - min + 1) * Rnd() + min)
    End Function
    '*******************************************************************************************
    'ValidEntry
    'Returns True if MIN <= playerTakeAway <= MAX
    '
    'post:  True has been returned if MIN <= playerTakeAway <= MAX. 
    '       Else False is returned.
    '*******************************************************************************************
    Function ValidEntry(ByVal playerTA As Integer, ByVal max As Integer, ByVal min As Integer) As Boolean
        If playerTA > max Or playerTA < min Then
            Return False
        Else
            Return True
        End If
    End Function
End Class
