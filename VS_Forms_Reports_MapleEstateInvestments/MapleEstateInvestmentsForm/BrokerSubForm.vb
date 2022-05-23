Public Class BrokerSubForm
    Private Sub BROKERBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.BROKERBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MapleEstInvestDataSet)

    End Sub

    Private Sub BROKERBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles BROKERBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.BROKERBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MapleEstInvestDataSet)

    End Sub

    Private Sub SubForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MapleEstInvestDataSet1.SALES_STATUS' table. You can move, or remove it, as needed.
        Me.SALES_STATUSTableAdapter.Fill(Me.MapleEstInvestDataSet1.SALES_STATUS)
        'TODO: This line of code loads data into the 'MapleEstInvestDataSet1._PROPERTY' table. You can move, or remove it, as needed.
        Me.PROPERTYTableAdapter.Fill(Me.MapleEstInvestDataSet1._PROPERTY)
        'TODO: This line of code loads data into the 'MapleEstInvestDataSet1.LICENSE_STATUS' table. You can move, or remove it, as needed.
        Me.LICENSE_STATUSTableAdapter.Fill(Me.MapleEstInvestDataSet1.LICENSE_STATUS)
        'TODO: This line of code loads data into the 'MapleEstInvestDataSet1.BROKER' table. You can move, or remove it, as needed.
        Me.BROKERTableAdapter.Fill(Me.MapleEstInvestDataSet1.BROKER)
        'TODO: This line of code loads data into the 'MapleEstInvestDataSet1.RISK_LEVEL' table. You can move, or remove it, as needed.
        Me.RISK_LEVELTableAdapter.Fill(Me.MapleEstInvestDataSet1.RISK_LEVEL)
        'TODO: This line of code loads data into the 'MapleEstInvestDataSet.LISTING' table. You can move, or remove it, as needed.
        Me.LISTINGTableAdapter.Fill(Me.MapleEstInvestDataSet.LISTING)
        'TODO: This line of code loads data into the 'MapleEstInvestDataSet.BROKER' table. You can move, or remove it, as needed.
        Me.BROKERTableAdapter.Fill(Me.MapleEstInvestDataSet.BROKER)

    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs) Handles FillByToolStripButton.Click
        Try
            Me.BROKERTableAdapter.FillBy(Me.MapleEstInvestDataSet.BROKER, NameToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub LISTINGDataGridView_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles LISTINGDataGridView.RowPostPaint
        Dim days As Long
        Dim dgvr As System.Windows.Forms.DataGridViewRow
        For Each dgvr In Me.LISTINGDataGridView.Rows
            days = DateDiff(DateInterval.Day, dgvr.Cells("StartDate").Value, dgvr.Cells("EndDate").Value)
            dgvr.Cells("Days_On_Market").Value = days
        Next

        Dim count As Integer
        Dim sold As Integer = 0

        count = Me.LISTINGDataGridView.Rows.Count - 1

        For Each dgvr In Me.LISTINGDataGridView.Rows
            If dgvr.Cells("Status").Value = 103 Then
                sold += 1
            End If
        Next

        Me.lblTotSold.Text = sold.ToString
        Me.lblCount.Text = count.ToString


    End Sub

    Private Sub TransactionsToolStripMenuItem1_Click_1(sender As Object, e As EventArgs) Handles TransactionsToolStripMenuItem1.Click
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

    Private Sub InvestorsDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InvestorsDetailsToolStripMenuItem.Click
        Me.Close()
        Try
            Dim frmInvestor As New InvestorDetail
            frmInvestor.Show()
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class