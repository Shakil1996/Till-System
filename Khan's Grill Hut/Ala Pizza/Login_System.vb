Public Class Login_System

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles LoginBTN.Click
        'Here is a simple line of me declaring the username and password so that the login system works
        Dim password, username As String
        username = ""
        password = ""
        'Here i have used the IF statement so that if the user types in the correct user and password they can have access to the till system
        'But if the username and password is incorrect, then the user can't login
        If username = txt_username.Text And password = txt_password.Text Then
            Khan_Grill_Hut_Till.Show()
            Me.Hide()
        Else
            MsgBox("please try again")
        End If
    End Sub

End Class
