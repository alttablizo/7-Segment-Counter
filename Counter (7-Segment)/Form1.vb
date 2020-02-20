Public Class Form1
    Public counter As Integer = -1

    Private Sub clear_color()
        abtn.BackColor = Color.LightGray
        bbtn.BackColor = Color.LightGray
        cbtn.BackColor = Color.LightGray
        dbtn.BackColor = Color.LightGray
        ebtn.BackColor = Color.LightGray
        fbtn.BackColor = Color.LightGray
        gbtn.BackColor = Color.LightGray
    End Sub

    Private Sub startButton_Click(sender As Object, e As EventArgs) Handles startButton.Click
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        counter += 1

        If counter > 9 Then
            counter = 0
        End If

        If counter = 0 Then
            clear_color()
            abtn.BackColor = Color.Red
            bbtn.BackColor = Color.Red
            cbtn.BackColor = Color.Red
            dbtn.BackColor = Color.Red
            ebtn.BackColor = Color.Red
            fbtn.BackColor = Color.Red
        End If

        If counter = 1 Then
            clear_color()
            bbtn.BackColor = Color.Red
            cbtn.BackColor = Color.Red
        End If

        If counter = 2 Then
            clear_color()
            abtn.BackColor = Color.Red
            bbtn.BackColor = Color.Red
            dbtn.BackColor = Color.Red
            ebtn.BackColor = Color.Red
            gbtn.BackColor = Color.Red
        End If

        If counter = 3 Then
            clear_color()
            abtn.BackColor = Color.Red
            bbtn.BackColor = Color.Red
            cbtn.BackColor = Color.Red
            dbtn.BackColor = Color.Red
            gbtn.BackColor = Color.Red
        End If

        If counter = 4 Then
            clear_color()
            bbtn.BackColor = Color.Red
            cbtn.BackColor = Color.Red
            fbtn.BackColor = Color.Red
            gbtn.BackColor = Color.Red
        End If

        If counter = 5 Then
            clear_color()
            abtn.BackColor = Color.Red
            cbtn.BackColor = Color.Red
            dbtn.BackColor = Color.Red
            fbtn.BackColor = Color.Red
            gbtn.BackColor = Color.Red
        End If

        If counter = 6 Then
            clear_color()
            abtn.BackColor = Color.Red
            cbtn.BackColor = Color.Red
            dbtn.BackColor = Color.Red
            fbtn.BackColor = Color.Red
            ebtn.BackColor = Color.Red
            gbtn.BackColor = Color.Red
        End If

        If counter = 7 Then
            clear_color()
            abtn.BackColor = Color.Red
            bbtn.BackColor = Color.Red
            cbtn.BackColor = Color.Red
        End If

        If counter = 8 Then
            clear_color()
            abtn.BackColor = Color.Red
            bbtn.BackColor = Color.Red
            cbtn.BackColor = Color.Red
            dbtn.BackColor = Color.Red
            ebtn.BackColor = Color.Red
            fbtn.BackColor = Color.Red
            gbtn.BackColor = Color.Red
        End If

        If counter = 9 Then
            clear_color()
            abtn.BackColor = Color.Red
            bbtn.BackColor = Color.Red
            cbtn.BackColor = Color.Red
            dbtn.BackColor = Color.Red
            fbtn.BackColor = Color.Red
            gbtn.BackColor = Color.Red
        End If



    End Sub

    Private Sub stopButton_Click(sender As Object, e As EventArgs) Handles stopButton.Click
        Timer1.Stop()
        startButton.Text = "Continue"

    End Sub

End Class
