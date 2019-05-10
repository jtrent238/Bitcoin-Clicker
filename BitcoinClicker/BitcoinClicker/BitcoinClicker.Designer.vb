<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BitcoinClicker
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
        Me.Button_mineBitcoin = New System.Windows.Forms.Button()
        Me.Label_myBitcoin = New System.Windows.Forms.Label()
        Me.Label_mySatoshi = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button_mineBitcoin
        '
        Me.Button_mineBitcoin.Location = New System.Drawing.Point(12, 74)
        Me.Button_mineBitcoin.Name = "Button_mineBitcoin"
        Me.Button_mineBitcoin.Size = New System.Drawing.Size(75, 23)
        Me.Button_mineBitcoin.TabIndex = 1
        Me.Button_mineBitcoin.Text = "Mine Bitcoin"
        Me.Button_mineBitcoin.UseVisualStyleBackColor = True
        '
        'Label_myBitcoin
        '
        Me.Label_myBitcoin.AutoSize = True
        Me.Label_myBitcoin.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_myBitcoin.Location = New System.Drawing.Point(441, 9)
        Me.Label_myBitcoin.Name = "Label_myBitcoin"
        Me.Label_myBitcoin.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label_myBitcoin.Size = New System.Drawing.Size(185, 33)
        Me.Label_myBitcoin.TabIndex = 0
        Me.Label_myBitcoin.Text = "₿{myBitcoin}"
        '
        'Label_mySatoshi
        '
        Me.Label_mySatoshi.AutoSize = True
        Me.Label_mySatoshi.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_mySatoshi.Location = New System.Drawing.Point(441, 52)
        Me.Label_mySatoshi.Name = "Label_mySatoshi"
        Me.Label_mySatoshi.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label_mySatoshi.Size = New System.Drawing.Size(172, 33)
        Me.Label_mySatoshi.TabIndex = 2
        Me.Label_mySatoshi.Text = "{mySatoshi}"
        '
        'BitcoinClicker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GrayText
        Me.ClientSize = New System.Drawing.Size(638, 385)
        Me.Controls.Add(Me.Label_mySatoshi)
        Me.Controls.Add(Me.Button_mineBitcoin)
        Me.Controls.Add(Me.Label_myBitcoin)
        Me.Name = "BitcoinClicker"
        Me.Text = "Bitcoin Clicker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button_mineBitcoin As Button
    Friend WithEvents Label_myBitcoin As Label
    Friend WithEvents Label_mySatoshi As Label
End Class
