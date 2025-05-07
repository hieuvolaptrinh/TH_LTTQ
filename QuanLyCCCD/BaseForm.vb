' BaseForm.vb
Public Class BaseForm
    Public WithEvents fadeTimer As New Timer()
    Public fadeOpacity As Double = 0
    Public activeChildForm As Form = Nothing
    Public fadeContainer As Panel = Nothing

    Public Sub LoadFormWithFade(newForm As Form, container As Panel)
        If activeChildForm IsNot Nothing Then
            activeChildForm.Hide()
        End If

        activeChildForm = newForm
        activeChildForm.TopLevel = False
        activeChildForm.FormBorderStyle = FormBorderStyle.None
        activeChildForm.Dock = DockStyle.Fill
        activeChildForm.Opacity = 0
        container.Controls.Clear()
        container.Controls.Add(activeChildForm)
        activeChildForm.Show()

        fadeOpacity = 0
        fadeContainer = container
        fadeTimer.Interval = 10
        fadeTimer.Start()
    End Sub

    Public Sub HandleFadeTick(sender As Object, e As EventArgs)
        If activeChildForm IsNot Nothing AndAlso fadeOpacity < 1 Then
            fadeOpacity += 0.05
            activeChildForm.Opacity = fadeOpacity
        Else
            fadeTimer.Stop()
        End If
    End Sub
End Class
