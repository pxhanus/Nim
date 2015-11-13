<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblStonesPile = New System.Windows.Forms.Label()
        Me.lblPlayerTakeAway = New System.Windows.Forms.Label()
        Me.txtPlayerTakeAway = New System.Windows.Forms.TextBox()
        Me.btnTakeStones = New System.Windows.Forms.Button()
        Me.lblComputerTook = New System.Windows.Forms.Label()
        Me.btnNewGame = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblStonesPile
        '
        Me.lblStonesPile.Font = New System.Drawing.Font("Poor Richard", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStonesPile.Location = New System.Drawing.Point(12, 9)
        Me.lblStonesPile.Name = "lblStonesPile"
        Me.lblStonesPile.Size = New System.Drawing.Size(268, 33)
        Me.lblStonesPile.TabIndex = 0
        '
        'lblPlayerTakeAway
        '
        Me.lblPlayerTakeAway.AutoSize = True
        Me.lblPlayerTakeAway.Location = New System.Drawing.Point(12, 64)
        Me.lblPlayerTakeAway.Name = "lblPlayerTakeAway"
        Me.lblPlayerTakeAway.Size = New System.Drawing.Size(157, 13)
        Me.lblPlayerTakeAway.TabIndex = 1
        Me.lblPlayerTakeAway.Text = "Number of stones to take away:"
        '
        'txtPlayerTakeAway
        '
        Me.txtPlayerTakeAway.Location = New System.Drawing.Point(175, 61)
        Me.txtPlayerTakeAway.Name = "txtPlayerTakeAway"
        Me.txtPlayerTakeAway.Size = New System.Drawing.Size(43, 20)
        Me.txtPlayerTakeAway.TabIndex = 2
        '
        'btnTakeStones
        '
        Me.btnTakeStones.Location = New System.Drawing.Point(248, 59)
        Me.btnTakeStones.Name = "btnTakeStones"
        Me.btnTakeStones.Size = New System.Drawing.Size(82, 22)
        Me.btnTakeStones.TabIndex = 3
        Me.btnTakeStones.Text = "Take Stones"
        Me.btnTakeStones.UseVisualStyleBackColor = True
        '
        'lblComputerTook
        '
        Me.lblComputerTook.AutoSize = True
        Me.lblComputerTook.Location = New System.Drawing.Point(12, 107)
        Me.lblComputerTook.Name = "lblComputerTook"
        Me.lblComputerTook.Size = New System.Drawing.Size(0, 13)
        Me.lblComputerTook.TabIndex = 4
        '
        'btnNewGame
        '
        Me.btnNewGame.Location = New System.Drawing.Point(248, 102)
        Me.btnNewGame.Name = "btnNewGame"
        Me.btnNewGame.Size = New System.Drawing.Size(82, 23)
        Me.btnNewGame.TabIndex = 5
        Me.btnNewGame.Text = "New Game"
        Me.btnNewGame.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 148)
        Me.Controls.Add(Me.btnNewGame)
        Me.Controls.Add(Me.lblComputerTook)
        Me.Controls.Add(Me.btnTakeStones)
        Me.Controls.Add(Me.txtPlayerTakeAway)
        Me.Controls.Add(Me.lblPlayerTakeAway)
        Me.Controls.Add(Me.lblStonesPile)
        Me.Name = "Form1"
        Me.Text = "Nim"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblStonesPile As System.Windows.Forms.Label
    Friend WithEvents lblPlayerTakeAway As System.Windows.Forms.Label
    Friend WithEvents txtPlayerTakeAway As System.Windows.Forms.TextBox
    Friend WithEvents btnTakeStones As System.Windows.Forms.Button
    Friend WithEvents lblComputerTook As System.Windows.Forms.Label
    Friend WithEvents btnNewGame As System.Windows.Forms.Button

End Class
