Public Class Help_and_FAQ_Page

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        'This is the coding behind the exit program button'
        'What these coding does is that it will close all of the forums that i have created
        Me.Close()
        Khan_Grill_Hut_Till.Close()
        Login_System.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        'This coding will allow the user to return back to the till system by a click of a button
        Khan_Grill_Hut_Till.Show()
        Me.Close()
    End Sub

End Class