Imports HalloKlassen

Public Class Form1

    Private meinDrink As Drink

    Private Sub NeuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NeuToolStripMenuItem.Click
        meinDrink = New Drink()
        meinDrink.Behälter = "Glass"
        meinDrink.FüllMenge = 500
        meinDrink.Nachfüllen()
        ShowMyDrink()
    End Sub

    Private Sub ShowMyDrink()
        TextBox1.Text = meinDrink.Behälter
        TextBox2.Text = meinDrink.FüllMenge
        ProgressBar1.Maximum = meinDrink.FüllMenge
        ProgressBar1.Value = meinDrink.Füllstand
        Label4.Text = $"Füllstand: {vbNewLine}{meinDrink.Füllstand} ml"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        meinDrink.SchluckNehmen(NumericUpDown1.Value)
        ShowMyDrink()
    End Sub
End Class
