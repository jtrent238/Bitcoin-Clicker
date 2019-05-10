Public Class BitcoinClicker

    Dim myBitcoin = 0.00000000
    Dim mySatoshi = 0

    Dim btcClickMultiplier = 0.00000001
    Dim numBitcoinMultiplier = 1
    Dim clickBitcoinAdd = 0.00000001 * numBitcoinMultiplier
    Dim clickSatoshiAdd = 1 * numBitcoinMultiplier

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateBitcoinCounter() ' Updates the bitcoin and satoshis counters
    End Sub

    Private Sub Button_mineBitcoin_Click(sender As Object, e As EventArgs) Handles Button_mineBitcoin.Click
        myBitcoin = myBitcoin + clickBitcoinAdd ' Adds x to myBitcoin based on numBitcoinMultiplier
        mySatoshi = mySatoshi + clickSatoshiAdd ' Adds x to mySatoshi based on numBitcoinMultiplier

        UpdateBitcoinCounter() ' Updates the Bitcoin counter on screen
    End Sub

    Sub UpdateBitcoinCounter()
        Label_myBitcoin.Text = myBitcoin.ToString + " BTC" ' Updates the Bitcoin counter on screen
        Label_mySatoshi.Text = mySatoshi.ToString + " Satoshis" ' Updates the Satoshis counter on screen
    End Sub

End Class
