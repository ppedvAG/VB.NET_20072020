﻿Imports System.IO
Imports DrinkModel
Imports SpreadsheetLight

Public Class Form1

    Private meinDrink As Drink


    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim gk As New Getränkekarte()
        ComboBox1.DataSource = gk.GetBiere()
        'ComboBox1.DisplayMember = "Sorte"

        GetränkteComboBox.DataSource = gk.GetAll()
        GetränkteComboBox.DisplayMember = "Hersteller"
    End Sub

    Private Sub NeuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NeuToolStripMenuItem.Click
        meinDrink = New Drink()
        meinDrink.Behälter = "Glass"
        'meinDrink.Füllmenge = 500
        'meinDrink.Nachfüllen()
        ShowMyDrink()
    End Sub

    Private Sub ShowMyDrink()
        TextBox1.Text = meinDrink.Behälter
        TextBox2.Text = meinDrink.Füllmenge
        ProgressBar1.Maximum = meinDrink.Füllmenge
        ProgressBar1.Value = meinDrink.Füllstand
        Label4.Text = $"Füllstand: {vbNewLine}{meinDrink.Füllstand} ml"
    End Sub

    Private Sub SchluckNehmenButton_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If meinDrink Is Nothing Then
            MessageBox.Show("Bitte erst Drink neu erstellen oder laden")
        Else
            meinDrink.SchluckNehmen(NumericUpDown1.Value)
            ShowMyDrink()
        End If
    End Sub

    Dim nachfüllZähler As Integer = 0
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If meinDrink Is Nothing Then
            'MessageBox.Show("Bitte erst Drink neu" & vbNewLine & " erstellen oder laden")
            MessageBox.Show($"Bitte erst Drink neu {vbNewLine} erstellen oder laden")
        Else
            meinDrink.Nachfüllen()
            ShowMyDrink()
            nachfüllZähler += 1
            If nachfüllZähler = 1 Then
                Label6.Text = $"Es wurde zu ersten mal nachgefüllt"
            Else
                Label6.Text = $"Es wurde {nachfüllZähler} mal nachgefüllt"
            End If
        End If

    End Sub

    Private Sub ExcelExportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExcelExportToolStripMenuItem.Click
        Dim sl As New SLDocument("Bier.xlsx")
        meinDrink.Behälter = sl.GetCellValueAsString("A2")
        meinDrink.Füllmenge = Integer.Parse(sl.GetCellValueAsString("A3"))
        nachfüllZähler = sl.GetCellValueAsInt32("A4")
        ShowMyDrink()


    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        Dim sl As New SLDocument()
        sl.SetCellValue("A1", "Bier!!")
        sl.SetCellValue("A2", TextBox1.Text)
        sl.SetCellValue("A3", TextBox2.Text)
        sl.SetCellValue("A4", nachfüllZähler)

        sl.SaveAs("Bier.xlsx")
        Process.Start("Bier.xlsx")
    End Sub

    Private Sub SpeichernToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SpeichernToolStripMenuItem.Click

        Dim sw As New StreamWriter("drink.txt")
        sw.WriteLine(TextBox1.Text)
        sw.WriteLine(TextBox2.Text)
        sw.WriteLine(nachfüllZähler)
        sw.Close()

        'Process.Start("drink.txt")
    End Sub

    Private Sub LadenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LadenToolStripMenuItem.Click

        'wenn meinDrink noch nicht erstellt wurde, erstelle wir ihn direkt
        If meinDrink Is Nothing Then
            meinDrink = New Drink()
            'meinDrink.Nachfüllen()
        End If

        Dim sr As New StreamReader("drink.txt")
        meinDrink.Behälter = sr.ReadLine()
        meinDrink.Füllmenge = Integer.Parse(sr.ReadLine())
        nachfüllZähler = Integer.Parse(sr.ReadLine())
        sr.Close()
        ShowMyDrink()

    End Sub

    Private Sub ComboBox1_Format(sender As Object, e As ListControlConvertEventArgs) Handles ComboBox1.Format

        Dim b = TryCast(e.ListItem, Bier)
        If Not b Is Nothing Then
            e.Value = $"{b.Brauerei} {b.Sorte} [{b.Alk:F2}%]"
        End If

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        'ComboBox1.SelectedItem '<--- Das sollte Bier sein

        ' b ist nun aus ausgewählte Bier aus der ComboBox
        Dim b = TryCast(ComboBox1.SelectedItem, Bier)

        RothausPictureBox.Visible = b.Brauerei.ToLower().Contains("rot")
        WeldePictureBox.Visible = b.Brauerei.ToLower().Contains("welde")
        HoepfnerPictureBox.Visible = b.Brauerei.ToLower().Contains("hoepf")

    End Sub
End Class
