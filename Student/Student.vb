Public Class Student
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        BunifuPages1.SetPage(profile)
        c1.Checked = True
        s1.ForeColor = Color.Indigo
        l1.ForeColor = Color.Indigo
    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        BunifuPages1.SetPage(login)
    End Sub

    Private Sub btnNext2_Click(sender As Object, e As EventArgs) Handles btnNext2.Click
        BunifuPages1.SetPage(academic)
        c2.Checked = True
        s2.ForeColor = Color.Indigo
        l2.ForeColor = Color.Indigo
    End Sub

    Private Sub btnPrev2_Click(sender As Object, e As EventArgs) Handles btnPrev2.Click
        BunifuPages1.SetPage(profile)
    End Sub

    Private Sub btnNext3_Click(sender As Object, e As EventArgs) Handles btnNext3.Click
        BunifuPages1.SetPage(finish)
        c3.Checked = True
        s3.ForeColor = Color.Indigo
        l3.ForeColor = Color.Indigo

        c4.Checked = True
        l4.ForeColor = Color.Indigo
    End Sub

    Private Sub btnClose2_Click(sender As Object, e As EventArgs) Handles btnClose2.Click
        Application.Exit()
    End Sub
End Class