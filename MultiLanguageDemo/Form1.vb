Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SetSpanish()
        btnBye.Text = My.Resources.SpanishText.ByeButton
        btnHello.Text = My.Resources.SpanishText.HelloButton
    End Sub

    Private Sub SetEnglish()
        btnBye.Text = My.Resources.EnglishText.ByeButton
        btnHello.Text = My.Resources.EnglishText.HelloButton
    End Sub

    Private Sub optEng_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optEng.CheckedChanged

        If optEng.Checked Then
            SetEnglish()
        End If

    End Sub

    Private Sub optSpn_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optSpn.CheckedChanged
        If optSpn.Checked Then
            SetSpanish()
        End If
    End Sub

    Private Sub btnHello_Click(sender As Object, e As EventArgs) Handles btnHello.Click

    End Sub
End Class


