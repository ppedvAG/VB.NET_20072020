Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Du hast mich geklickt mit dem Speed:" & speedX)
        MachButtonBunt()
    End Sub

    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        Button1.BackColor = Color.OrangeRed
        'Button1.Left = Button1.Left + 110
        'Button1.Left += 110
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = Color.Chartreuse
    End Sub

    Sub MachButtonBunt()
        Dim ran As New Random()

        Button1.BackColor = Color.FromArgb(ran.Next(255), ran.Next(255), ran.Next(255))
        BackColor = Color.FromArgb(ran.Next(255), ran.Next(255), ran.Next(255))

        Task.Run(Sub() Console.Beep(220, 200))


    End Sub

    Dim speedX As Integer = 4
    Dim speedY As Integer = 4

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Text = Button1.Left & "x" & Button1.Top
        Button1.Left += speedX

        If Button1.Left + Button1.Width >= ClientSize.Width Or Button1.Left <= 0 Then
            speedX *= -1
            MachButtonBunt()
        End If

        Button1.Top += speedY

        If Button1.Top + Button1.Height >= ClientSize.Height Or Button1.Top <= 0 Then
            speedY *= -1
            MachButtonBunt()

        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'MessageBox.Show("Viel Spass am " & Date.Now.DayOfWeek.ToString())

        'Dim tag As Date = Date.Now.AddDays(3)
        Dim tag As Date = New Date(2020, 7, 26)

        Select Case tag.DayOfWeek
            Case DayOfWeek.Monday
                Button1.Text = "🙇‍"
            Case DayOfWeek.Wednesday
                Button1.Text = "🍔"
            Case DayOfWeek.Friday
                Button1.Text = "🧦🧦"
            Case DayOfWeek.Saturday
                Button1.Text = "🍻🍻"
            Case DayOfWeek.Sunday
                Button1.Text = "🍆"
            Case Else
                Button1.Text = "🍗"
        End Select

    End Sub
End Class
