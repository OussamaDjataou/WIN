Public Class Form1
    Dim mypath3, mypath1, mypath2, mypath4 As String
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If FolderBrowserDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then

            TextBox1.Text = FolderBrowserDialog1.SelectedPath
            Dim root As Environment.SpecialFolder = FolderBrowserDialog1.RootFolder
            Dim mypath1 As String


        End If
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If FolderBrowserDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then

            TextBox2.Text = FolderBrowserDialog1.SelectedPath
            Dim root As Environment.SpecialFolder = FolderBrowserDialog1.RootFolder


            mypath2 = TextBox2.Text
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If FolderBrowserDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then

            TextBox3.Text = FolderBrowserDialog1.SelectedPath
            Dim root As Environment.SpecialFolder = FolderBrowserDialog1.RootFolder


            mypath3 = TextBox3.Text
        End If

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub FolderBrowserDialog1_HelpRequest(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FolderBrowserDialog1.HelpRequest

    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox4.Text = mypath1 + "*" + mypath2 + "*" + mypath3


    End Sub

    Private Sub TextBox4_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If FolderBrowserDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then

            TextBox4.Text = FolderBrowserDialog1.SelectedPath
            Dim root As Environment.SpecialFolder = FolderBrowserDialog1.RootFolder


            mypath4 = TextBox4.Text
        End If
    End Sub
End Class
