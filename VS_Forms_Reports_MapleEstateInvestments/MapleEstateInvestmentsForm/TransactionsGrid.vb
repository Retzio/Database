Public Class TransactionsGrid
    Private Sub TRANSACTIONBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TRANSACTIONBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TRANSACTIONBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MapleEstInvestDataSet)

    End Sub

    Private Sub Grid_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MapleEstInvestDataSet.INVESTOR' table. You can move, or remove it, as needed.
        Me.INVESTORTableAdapter.Fill(Me.MapleEstInvestDataSet.INVESTOR)
        'TODO: This line of code loads data into the 'MapleEstInvestDataSet.BROKER' table. You can move, or remove it, as needed.
        Me.BROKERTableAdapter.Fill(Me.MapleEstInvestDataSet.BROKER)
        'TODO: This line of code loads data into the 'MapleEstInvestDataSet.TRANSACTION' table. You can move, or remove it, as needed.
        Me.TRANSACTIONTableAdapter.Fill(Me.MapleEstInvestDataSet.TRANSACTION)

    End Sub

    Private Sub TRANSACTIONDataGridView_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles TRANSACTIONDataGridView.RowPostPaint

        Dim com As Decimal
        Dim dgvr As System.Windows.Forms.DataGridViewRow
        For Each dgvr In Me.TRANSACTIONDataGridView.Rows
            com = (dgvr.Cells("Rate").Value * dgvr.Cells("Price").Value)
            dgvr.Cells("Comission").Value = com
        Next
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub BrokerToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles BrokerToolStripMenuItem.Click
        Me.Close()
        Try
            Dim frmBroker As New BrokerSubForm
            frmBroker.Show()
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub InvestorsDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InvestorsDetailsToolStripMenuItem.Click
        Me.Close()
        Try
            Dim frmInvestor As New InvestorDetail
            frmInvestor.Show()
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub InvestorsPortfolioToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles InvestorsPortfolioToolStripMenuItem.Click
        Me.Close()
        Try
            Dim frmSearch As New SearchInvestorPortfolio
            frmSearch.Show()
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class