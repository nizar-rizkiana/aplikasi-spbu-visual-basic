Public Class Form1
    Public radio As String
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.Text
            Case "Premium"
                TextBox1.Text = "4500"
            Case "Pertalite"
                TextBox1.Text = "6500"
            Case "Pertamax"
                TextBox1.Text = "9000"
            Case "Solar"
                TextBox1.Text = "5500"
        End Select
    End Sub


    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        radio = "uang"
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        radio = "liter"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If radio = "uang" Then
            Label9.Text = ComboBox1.Text
            Label10.Text = FormatCurrency(TextBox2.Text)
            Label11.Text = FormatNumber(TextBox2.Text / TextBox1.Text)
        Else
            Label9.Text = ComboBox1.Text
            Label10.Text = FormatCurrency(TextBox1.Text * TextBox2.Text)
            Label11.Text = TextBox2.Text
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ComboBox1.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
        Label9.Text = ""
        Label10.Text = ""
        Label11.Text = ""
        RadioButton1.Checked = False
        RadioButton2.Checked = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
End Class
