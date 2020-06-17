Public Class Signup

    Private Sub Signup_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.CenterToScreen()
    End Sub
    Private Sub Linktologin_Click(sender As Object, e As EventArgs) Handles linktologin.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub Signupbutton_Click(sender As Object, e As EventArgs) Handles signupbutton.Click
        Me.Hide()
        Dashboard.Show()
    End Sub
End Class