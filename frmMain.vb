Public Class frmMain

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        'If IsNumeric(TextBox1.Text) Then
        '    If CDbl(TextBox1.Text) >= 1 And CDbl(TextBox1.Text) <= 10 Then
        '        MessageBox.Show("Valid Data")
        '    End If
        'Else
        '    MessageBox.Show("Numeric Not Found!")
        'End If


        Try
            If CDbl(TextBox1.Text) >= 1 And CDbl(TextBox1.Text) <= 10 Then
                MessageBox.Show("Valid Data")
            End If
        Catch ex As System.InvalidCastException

            MessageBox.Show("Error")


        End Try


    End Sub

End Class
