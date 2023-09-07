Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim string1 As New Form2 'instance of a class form2
        string1.StringPass = TextBox1.Text 'assigning string variable which was declared in form2 variable 
        string1.Show() ' showing form2
    End Sub
End Class
