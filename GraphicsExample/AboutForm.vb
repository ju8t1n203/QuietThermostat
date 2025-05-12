Public Class AboutForm

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
        QuietThermostat.Show()
    End Sub
End Class