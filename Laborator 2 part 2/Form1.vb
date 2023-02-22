Public Class Form1
    Dim x As Double
    Dim s As Double
    Dim nr As Double



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



        If TextBox1.Text <> "1" Then
            If TextBox1.Text = "+" Then
                x += 1
                TextBox1.Text = x

            Else
                If TextBox1.Text = "-" Then
                    x -= 1
                    TextBox1.Text = x
                Else
                    If TextBox1.Text = "x" Then
                        x *= 1
                        TextBox1.Text = x
                    Else
                        If TextBox1.Text = "/" Then
                            x /= 1
                            TextBox1.Text = x
                        Else
                            If TextBox1.Text = "0.0" Then
                                TextBox1.Text = Button1.Text
                                x = 1

                            End If
                        End If
                    End If
                End If

            End If



        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If TextBox1.Text <> "2" Then
            If TextBox1.Text = "+" Then
                x += 2
                TextBox1.Text = x

            Else
                If TextBox1.Text = "-" Then
                    x -= 2
                    TextBox1.Text = x
                Else
                    If TextBox1.Text = "x" Then
                        x *= 2
                        TextBox1.Text = x
                    Else
                        If TextBox1.Text = "/" Then
                            x /= 2
                            TextBox1.Text = x
                        Else
                            If TextBox1.Text = "0.0" Then
                                TextBox1.Text = Button2.Text
                                x = 2

                            End If
                        End If
                    End If
                End If

            End If



        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If TextBox1.Text <> "3" Then
            If TextBox1.Text = "+" Then
                x += 3
                TextBox1.Text = x

            Else
                If TextBox1.Text = "-" Then
                    x -= 3
                    TextBox1.Text = x
                Else
                    If TextBox1.Text = "x" Then
                        x *= 3
                        TextBox1.Text = x
                    Else
                        If TextBox1.Text = "/" Then
                            x /= 3
                            TextBox1.Text = x
                        Else
                            If TextBox1.Text = "0.0" Then
                                TextBox1.Text = Button3.Text
                                x = 3

                            End If
                        End If
                    End If
                End If

            End If



        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        If TextBox1.Text <> "4" Then
            If TextBox1.Text = "+" Then
                x += 4
                TextBox1.Text = x

            Else
                If TextBox1.Text = "-" Then
                    x -= 4
                    TextBox1.Text = x
                Else
                    If TextBox1.Text = "x" Then
                        x *= 4
                        TextBox1.Text = x
                    Else
                        If TextBox1.Text = "/" Then
                            x /= 4
                            TextBox1.Text = x
                        Else
                            If TextBox1.Text = "0.0" Then
                                TextBox1.Text = Button5.Text
                                x = 4

                            End If
                        End If
                    End If
                End If

            End If



        End If



    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        If TextBox1.Text <> "5" Then
            If TextBox1.Text = "+" Then
                x += 5
                TextBox1.Text = x

            Else
                If TextBox1.Text = "-" Then
                    x -= 5
                    TextBox1.Text = x
                Else
                    If TextBox1.Text = "x" Then
                        x *= 5
                        TextBox1.Text = x
                    Else
                        If TextBox1.Text = "/" Then
                            x /= 5
                            TextBox1.Text = x
                        Else
                            If TextBox1.Text = "0.0" Then
                                TextBox1.Text = Button6.Text
                                x = 5

                            End If
                        End If
                    End If
                End If

            End If



        End If


    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        If TextBox1.Text <> "6" Then
            If TextBox1.Text = "+" Then
                x += 6
                TextBox1.Text = x

            Else
                If TextBox1.Text = "-" Then
                    x -= 6
                    TextBox1.Text = x
                Else
                    If TextBox1.Text = "x" Then
                        x *= 6
                        TextBox1.Text = x
                    Else
                        If TextBox1.Text = "/" Then
                            x /= 6
                            TextBox1.Text = x
                        Else
                            If TextBox1.Text = "0.0" Then
                                TextBox1.Text = Button7.Text
                                x = 6

                            End If
                        End If
                    End If
                End If

            End If



        End If

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

        If TextBox1.Text <> "7" Then
            If TextBox1.Text = "+" Then
                x += 7
                TextBox1.Text = x

            Else
                If TextBox1.Text = "-" Then
                    x -= 7
                    TextBox1.Text = x
                Else
                    If TextBox1.Text = "x" Then
                        x *= 7
                        TextBox1.Text = x
                    Else
                        If TextBox1.Text = "/" Then
                            x /= 7
                            TextBox1.Text = x
                        Else
                            If TextBox1.Text = "0.0" Then
                                TextBox1.Text = Button9.Text
                                x = 7

                            End If
                        End If
                    End If
                End If

            End If



        End If

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

        If TextBox1.Text <> "8" Then
            If TextBox1.Text = "+" Then
                x += 8
                TextBox1.Text = x

            Else
                If TextBox1.Text = "-" Then
                    x -= 8
                    TextBox1.Text = x
                Else
                    If TextBox1.Text = "x" Then
                        x *= 8
                        TextBox1.Text = x
                    Else
                        If TextBox1.Text = "/" Then
                            x /= 8
                            TextBox1.Text = x
                        Else
                            If TextBox1.Text = "0.0" Then
                                TextBox1.Text = Button10.Text
                                x = 8

                            End If
                        End If
                    End If
                End If

            End If



        End If

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click

        If TextBox1.Text <> "9" Then
            If TextBox1.Text = "+" Then
                x += 9
                TextBox1.Text = x

            Else
                If TextBox1.Text = "-" Then
                    x -= 9
                    TextBox1.Text = x
                Else
                    If TextBox1.Text = "x" Then
                        x *= 9
                        TextBox1.Text = x
                    Else
                        If TextBox1.Text = "/" Then
                            x /= 9
                            TextBox1.Text = x
                        Else
                            If TextBox1.Text = "0.0" Then
                                TextBox1.Text = Button11.Text
                                x = 9

                            End If
                        End If
                    End If
                End If

            End If



        End If

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click

        If TextBox1.Text <> "0" Then
            If TextBox1.Text = "+" Then
                x += 0
                TextBox1.Text = x

            Else
                If TextBox1.Text = "-" Then
                    x -= 0
                    TextBox1.Text = x
                Else
                    If TextBox1.Text = "x" Then
                        x *= 0
                        TextBox1.Text = x
                    Else
                        If TextBox1.Text = "/" Then
                            TextBox1.Text = "Invalid"

                        Else
                            If TextBox1.Text = "0.0" Then
                                TextBox1.Text = Button13.Text
                                x = 0

                            End If
                        End If
                    End If
                End If

            End If



        End If

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        TextBox1.Text = "0.0"
        x = 0

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = "+"

    End Sub
    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        TextBox1.Text = x
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox1.Text = "-"

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        TextBox1.Text = "x"
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        TextBox1.Text = "/"

    End Sub
End Class
