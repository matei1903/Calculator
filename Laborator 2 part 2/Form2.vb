Public Class form2
    Dim numar1, numar2 As Double
    Dim rezultat As Double
    Dim operatie As String

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text = TextBox1.Text & 2
        Else
            TextBox1.Text = 2

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text = TextBox1.Text & 3
        Else
            TextBox1.Text = 3

        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text = TextBox1.Text & 4
        Else
            TextBox1.Text = 4

        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text = TextBox1.Text & 5
        Else
            TextBox1.Text = 5

        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text = TextBox1.Text & 6
        Else
            TextBox1.Text = 6

        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text = TextBox1.Text & 7
        Else
            TextBox1.Text = 7

        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text = TextBox1.Text & 8
        Else
            TextBox1.Text = 8

        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text = TextBox1.Text & 9
        Else
            TextBox1.Text = 9

        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text = TextBox1.Text & 0
        Else
            TextBox1.Text = 0

        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        numar1 = TextBox1.Text
        TextBox1.Text = ""
        operatie = "+"

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        numar1 = TextBox1.Text
        TextBox1.Text = ""
        operatie = "-"
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        numar1 = TextBox1.Text
        TextBox1.Text = ""
        operatie = "x"
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        numar1 = TextBox1.Text
        TextBox1.Text = ""
        operatie = "/"
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        numar2 = TextBox1.Text
        If operatie = "+" Then
            rezultat = numar1 + numar2
            TextBox1.Text = rezultat
        Else
            If operatie = "-" Then
                rezultat = numar1 - numar2
                TextBox1.Text = rezultat
            Else
                If operatie = "x" Then
                    rezultat = numar1 * numar2
                    TextBox1.Text = rezultat
                Else
                    If operatie = "/" Then
                        If numar2 = "0" Then
                            TextBox1.Text = "invalid"

                        Else
                            rezultat = numar1 / numar2
                            TextBox1.Text = rezultat
                        End If


                    End If
                End If

            End If

        End If


    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        TextBox1.Text = 0

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text = TextBox1.Text & 1
        Else
            TextBox1.Text = 1

        End If


    End Sub





End Class