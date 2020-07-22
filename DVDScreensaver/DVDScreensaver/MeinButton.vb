Public Class MeinButton
    Inherits Button

    Public Overrides Property BackColor As Color
        Get
            Return MyBase.BackColor
        End Get
        Set(value As Color)
            If value = Color.Pink Then
                MyBase.BackColor = Color.Black
            Else
                MyBase.BackColor = value
            End If
        End Set
    End Property


    Protected Overrides Sub OnPaint(pevent As PaintEventArgs)
        'MyBase.OnPaint(pevent)
        pevent.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

        pevent.Graphics.FillRectangle(New SolidBrush(Me.Parent.BackColor), pevent.ClipRectangle)


        pevent.ClipRectangle.Inflate(-14, -14)
        Dim bb = New Drawing2D.LinearGradientBrush(pevent.ClipRectangle, Me.BackColor, Color.Gray, 90)

        pevent.Graphics.FillEllipse(bb, pevent.ClipRectangle)

        Dim sf = New StringFormat()
        sf.Alignment = StringAlignment.Center
        sf.LineAlignment = StringAlignment.Center

        pevent.Graphics.DrawString(Me.Text, New Font("Segoe UI", 25.0F), New SolidBrush(Me.ForeColor), pevent.ClipRectangle, sf)

    End Sub

End Class
