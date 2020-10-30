Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button_plain_Click(sender As Object, e As EventArgs) Handles Button_plain.Click
        read_PWS(False)
    End Sub

    Private Sub Button_comma_Click(sender As Object, e As EventArgs) Handles Button_comma.Click
        read_PWS(True)
    End Sub

    Private Sub read_PWS(ByVal comma As Boolean)

        Dim StartUpPath As String = Application.StartupPath


        Dim files As String() = My.Computer.FileSystem.GetFiles(StartUpPath).ToArray

        For index = 0 To files.Length - 1
            Dim file As String = files(index)
            If file.ToLower.EndsWith(".nzb") Then
                Dim start As Integer = file.IndexOf("{{") + 2
                Dim ende As Integer = file.IndexOf("}}")
                If start > 0 And ende > 0 Then
                    Dim pw As String = file.Substring(start, ende - start)

                    If comma Then
                        TextBox_passwords.Text = TextBox_passwords.Text + ",""" + pw + """"
                    Else
                        TextBox_passwords.Text = TextBox_passwords.Text + vbCrLf + pw
                    End If

                End If
            End If
        Next

    End Sub


End Class
