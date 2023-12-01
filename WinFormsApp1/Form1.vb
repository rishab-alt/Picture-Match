Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Dim num1 As Integer
    Dim num2 As Integer
    Dim num3 As Integer

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged


        If TextBox1.Text = TextBox2.Text And TextBox2.Text = TextBox3.Text Then
            MsgBox("your a winner")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Randomize()
        num1 = ((Rnd() * 2) + 1)
        num2 = ((Rnd() * 2) + 1)
        num3 = ((Rnd() * 2) + 1)

        TextBox1.Text = num1.ToString
        TextBox1.Text = num2.ToString
        TextBox1.Text = num3.ToString

    End Sub
End Class
