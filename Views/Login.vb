Public Class Login

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.CenterToScreen()
    End Sub


    Private Sub Loginbutton_Click(sender As Object, e As EventArgs) Handles loginbutton.Click
        If usernamelogin.Text = "admin" And passwordlogin.Text = "admin" Then
            Dashboard.Show()
            Me.Hide()
        Else
            MsgBox("Error")
        End If


    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Me.Hide()
        Signup.Show()

    End Sub
End Class
