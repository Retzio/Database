Public Class InvestorDetail
    Private Sub INVESTORBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles INVESTORBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.INVESTORBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MapleEstInvestDataSet)

    End Sub

    Private Sub InvestorDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MapleEstInvestDataSet.RISK_LEVEL' table. You can move, or remove it, as needed.
        Me.RISK_LEVELTableAdapter.Fill(Me.MapleEstInvestDataSet.RISK_LEVEL)
        'TODO: This line of code loads data into the 'MapleEstInvestDataSet.INVESTOR' table. You can move, or remove it, as needed.
        Me.INVESTORTableAdapter.Fill(Me.MapleEstInvestDataSet.INVESTOR)

    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs) Handles FillByToolStripButton.Click
        Try
            Me.INVESTORTableAdapter.FillBy(Me.MapleEstInvestDataSet.INVESTOR, NameToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub


    Public Sub LoadInvestor(ByVal InvestorID As Integer)
        Me.INVESTORTableAdapter.FillBy(Me.MapleEstInvestDataSet.INVESTOR, InvestorID)
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        '    Dim CurrentInvestorID As Integer
        Return

        Dim InvestorID As Integer

        Dim nInvestor As New InvestorDetail
        nInvestor.Show()

        InvestorID = Me.cboInvestor.SelectedIndex
        Me.INVESTORTableAdapter.FillBy(Me.MapleEstInvestDataSet.INVESTOR, InvestorID)



        '   CurrentInvestorID = Me.cboInvestor.SelectedValue
        '  Me.INVESTORTableAdapter.FillBy(Me.MapleEstInvestDataSet.INVESTOR, CurrentInvestorID)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub BrokersToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Close()
        Try
            Dim frmBroker As New BrokerSubForm
            frmBroker.Show()
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BrokerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BrokerToolStripMenuItem.Click
        Me.Close()
        Try
            Dim frmBroker As New BrokerSubForm
            frmBroker.Show()
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub tsmTransaction_Click(sender As Object, e As EventArgs) Handles tsmTransaction.Click
        Me.Close()
        Try
            Dim frmTransaction As New TransactionsGrid
            frmTransaction.Show()
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