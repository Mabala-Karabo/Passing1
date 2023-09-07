Public Class Form2
    'declaring puplic variable named StringPass
    Public Property StringPass As String

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = StringPass 'label1 from form2 
    End Sub
End Class