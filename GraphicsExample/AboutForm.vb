Public Class AboutForm
    Private Sub AboutLabel_Click(sender As Object, e As EventArgs) Handles AboutLabel.Click

    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
        QuietThermostat.Show()
    End Sub
End Class