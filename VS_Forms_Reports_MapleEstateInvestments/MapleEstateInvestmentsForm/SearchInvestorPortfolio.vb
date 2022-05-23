Public Class SearchInvestorPortfolio
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.InvestorFullNameTableAdapter.Fill(Me.MapleEstInvestDataSet.InvestorFullName)
        Me.INVESTORTableAdapter.Fill(Me.MapleEstInvestDataSet.INVESTOR)
        For i As Integer = 0 To clbPropertyType.Items.Count - 1
            clbPropertyType.SetItemChecked(i, True)
        Next
        Me.cboPercent.SelectedIndex = 0
        Me.pbDuplex.Hide()
        Me.pbFamily.Hide()
        Me.pbFourplex.Hide()
        Me.lblBarDuplex.Hide()
        Me.lblBarFamily.Hide()
        Me.lblBarFourplex.Hide()
        Me.lblGraph.Hide()
        Me.pnlGraph.Hide()

    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click

        Dim Percent As String
        Percent = Me.cboPercent.SelectedText

        Dim DuPlex As String, FourPlex As String, SingleFamily As String

        Try
            If clbPropertyType.GetItemChecked(0) Then
                DuPlex = "DuPlex"
            Else
                DuPlex = "Null"
            End If

            If clbPropertyType.GetItemChecked(1) Then
                FourPlex = "FourPlex"
            Else
                FourPlex = "Null"
            End If
            If clbPropertyType.GetItemChecked(2) Then
                SingleFamily = "Single Family"
            Else
                SingleFamily = "Null"
            End If
        Catch ex As Exception
            MsgBox(ex.Message, , "Error in the Query")
        End Try

        If radTop.Checked Then
            Try
                Me.InvestorPortfolioTableAdapter.FillByTop(
               Me.MapleEstInvestDataSet.InvestorPortfolio,
               CType(Me.cboPercent.Text, Decimal),
               Me.cboInvestor.SelectedValue,
               CType(DuPlex, String),
               CType(FourPlex, String),
               CType(SingleFamily, String))
            Catch ex As Exception
                MsgBox(ex.Message, , "Error in the Query")
            End Try
        ElseIf radBottom.Checked Then
            Try
                Me.InvestorPortfolioTableAdapter.FillByBottom(
                Me.MapleEstInvestDataSet.InvestorPortfolio,
                CType(Me.cboPercent.Text, Decimal),
                Me.cboInvestor.SelectedValue,
                CType(DuPlex, String),
                CType(FourPlex, String),
                CType(SingleFamily, String))
            Catch ex As Exception
                MsgBox(ex.Message, , "Error in the Query")
            End Try
        End If

        'Validate Check Boxes
        Try
            Dim boxcount As Integer = 0
            For i As Integer = 0 To clbPropertyType.Items.Count - 1
                If clbPropertyType.GetItemChecked(i) Then
                    boxcount += 1
                End If
            Next

            If boxcount = 0 Then
                MsgBox("Must have at least one check box selected for Property Type")
                For i As Integer = 0 To clbPropertyType.Items.Count - 1
                    clbPropertyType.SetItemChecked(i, True)
                Next
            Else
                'Load Aggregates
                CountMatches()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, , "Error in the Query")
        End Try

    End Sub
    Private Sub CountMatches()
        Dim tpval As Decimal
        Dim teq As Decimal
        Dim countprops As Integer
        Dim tprof As Decimal
        Dim tex As Decimal
        Dim trev As Decimal
        Dim toteqper As Decimal
        Dim avgeq As Decimal
        Dim avgroi As Decimal
        Dim sumeq As Decimal
        Dim sumroi As Decimal
        Dim gduplex As Decimal
        Dim gfourplex As Decimal
        Dim gfamily As Decimal
        Dim dgvr As System.Windows.Forms.DataGridViewRow

        'Check if data is thetere
        countprops = Me.InvestorPortfolioDataGridView.Rows.Count - 1
        Try
            If countprops = 0 Then
                MsgBox("This Investor has no properties in his portfolio yet")
            Else
                For Each dgvr In Me.InvestorPortfolioDataGridView.Rows
                    tpval += dgvr.Cells("PropertyValue").Value
                    teq += (dgvr.Cells("PropertyValue").Value * dgvr.Cells("EquityPercent").Value)
                    trev += (dgvr.Cells("PropertyValue").Value * dgvr.Cells("AverageROI").Value)
                    sumeq += dgvr.Cells("EquityPercent").Value
                    sumroi += dgvr.Cells("AverageROI").Value

                Next dgvr

                For Each dgvr In Me.InvestorPortfolioDataGridView.Rows
                    If IsDBNull(dgvr.Cells("HOAExpenses").Value) Then
                        tex += (dgvr.Cells("PropertyExpenses").Value + dgvr.Cells("Insurance").Value + dgvr.Cells("PropertyTax").Value)
                    Else
                        tex += (dgvr.Cells("PropertyExpenses").Value + dgvr.Cells("Insurance").Value + dgvr.Cells("PropertyTax").Value + dgvr.Cells("HOAExpenses").Value)
                    End If
                Next dgvr

                If (countprops > 0) Then
                    toteqper = teq / tpval
                    avgeq = sumeq / countprops
                    tprof = trev - tex
                    avgroi = sumroi / countprops
                End If

                For Each dgvr In Me.InvestorPortfolioDataGridView.Rows
                    If dgvr.Cells("Type").Value Like "DuPlex" Then
                        gduplex += dgvr.Cells("PropertyValue").Value
                    ElseIf dgvr.Cells("Type").Value Like "FourPlex" Then
                        gfourplex += dgvr.Cells("PropertyValue").Value
                    ElseIf dgvr.Cells("Type").Value Like "Single Family" Then
                        gfamily += dgvr.Cells("PropertyValue").Value
                    End If
                Next
                gduplex += dgvr.Cells("PropertyValue").Value
                gfourplex += dgvr.Cells("PropertyValue").Value
                gfamily += dgvr.Cells("PropertyValue").Value

                lblOPTotPropVal.Text = tpval.ToString("$ #,##0.00")
                lblOPTotEq.Text = teq.ToString("$ #,##0.00")
                lblOPCount.Text = countprops.ToString
                lblOPTotProf.Text = tprof.ToString("$ #,##0.00")
                lblOPTotEx.Text = tex.ToString("$ #,##0.00")
                lblOPTotRev.Text = trev.ToString("$ #,##0.00")
                lblOPTotEqPer.Text = toteqper.ToString("0.00%")
                lblOPAvgEqPer.Text = avgeq.ToString("0.00%")
                lblOPAvgROI.Text = avgroi.ToString("0.00%")

                'Load Graph
                Me.pbDuplex.Show()
                Me.pbFamily.Show()
                Me.pbFourplex.Show()
                Me.lblBarDuplex.Show()
                Me.lblBarFamily.Show()
                Me.lblBarFourplex.Show()
                Me.lblGraph.Show()
                Me.pnlGraph.Show()
                BuildGraph(gduplex, gfourplex, gfamily)

            End If
        Catch ex As Exception
            MsgBox(ex.Message, , "Error in the Query")
        End Try


    End Sub

    Private Function BuildGraph(Duplex As Decimal, FourPlex As Decimal, Family As Decimal) As Decimal

        Dim Total As Decimal
        Dim ResDuplex As Decimal
        Dim ResFourplex As Decimal
        Dim ResFamily As Decimal

        Total = Duplex + FourPlex + Family
        ResDuplex = Duplex / Total * 100
        ResFourplex = FourPlex / Total * 100
        ResFamily = Family / Total * 100

        Me.pbDuplex.Value = ResDuplex
        Me.pbFourplex.Value = ResFourplex
        Me.pbFamily.Value = ResFamily

        Return ResDuplex
        Return ResFourplex
        Return ResFamily

    End Function

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub tsmBroker_Click_1(sender As Object, e As EventArgs) Handles tsmBroker.Click
        Me.Close()
        Try
            Dim frmBroker As New BrokerSubForm
            frmBroker.Show()
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub tsmTransaction_Click_1(sender As Object, e As EventArgs) Handles tsmTransaction.Click
        Me.Close()
        Try
            Dim frmTransaction As New TransactionsGrid
            frmTransaction.Show()
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub tsmInvestorDetail_Click_1(sender As Object, e As EventArgs) Handles tsmInvestorDetail.Click
        Me.Close()
        Try
            Dim frmInvestor As New InvestorDetail
            frmInvestor.Show()
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class