Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        lblsalary1.Text = Val(txtsalary.Text) * 12
        lblsalary2.Text = Val(txtsalary.Text) * 12 * 0.05
        lblsalary3.Text = (Val(txtsalary.Text) * 12) - (Val(txtsalary.Text) * 12 * 0.05)
    End Sub
End Class
