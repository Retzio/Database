Public Class StartUp
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnBroker_Click(sender As Object, e As EventArgs) Handles btnBroker.Click
        Try
            Dim frmBroker As New BrokerSubForm
            frmBroker.Show()
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnInvestors_Click(sender As Object, e As EventArgs) Handles btnInvestors.Click
        Try
            Dim frmInvestor As New InvestorDetail
            frmInvestor.Show()
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnTransactions_Click(sender As Object, e As EventArgs) Handles btnTransactions.Click
        Try
            Dim frmTransaction As New TransactionsGrid
            frmTransaction.Show()
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            Dim frmSearch As New SearchInvestorPortfolio
            frmSearch.Show()
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class