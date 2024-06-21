Public Class Form1
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim name As String = txtAnswer1.Text
        Dim source As String = If(rbOption1.Checked, "Google", "Friend")
        MessageBox.Show("Thank you, " & name & "! You heard about us from " & source & ".")
    End Sub
End Class
