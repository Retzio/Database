<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SearchInvestorPortfolio
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SearchInvestorPortfolio))
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.cboInvestor = New System.Windows.Forms.ComboBox()
        Me.InvestorFullNameBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MapleEstInvestDataSet = New MapleEstateInvestmentsForm.MapleEstInvestDataSet()
        Me.INVESTORBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.INVESTORTableAdapter = New MapleEstateInvestmentsForm.MapleEstInvestDataSetTableAdapters.INVESTORTableAdapter()
        Me.InvestorPortfolioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InvestorPortfolioTableAdapter = New MapleEstateInvestmentsForm.MapleEstInvestDataSetTableAdapters.InvestorPortfolioTableAdapter()
        Me.TableAdapterManager = New MapleEstateInvestmentsForm.MapleEstInvestDataSetTableAdapters.TableAdapterManager()
        Me.InvestorPortfolioDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PropertyValue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EquityPercent = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AverageROI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PropertyExpenses = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HOAExpenses = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Insurance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PropertyTax = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YearPurchased = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YearBuilt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clbPropertyType = New System.Windows.Forms.CheckedListBox()
        Me.lblTotalEquity = New System.Windows.Forms.Label()
        Me.lblAverageROI = New System.Windows.Forms.Label()
        Me.lblTotalRevenue = New System.Windows.Forms.Label()
        Me.lblOPTotProf = New System.Windows.Forms.Label()
        Me.lblOPAvgROI = New System.Windows.Forms.Label()
        Me.lblOPTotEq = New System.Windows.Forms.Label()
        Me.lblOPTotEx = New System.Windows.Forms.Label()
        Me.lblOPTotEqPer = New System.Windows.Forms.Label()
        Me.lblOPTotPropVal = New System.Windows.Forms.Label()
        Me.lblTotalExpenses = New System.Windows.Forms.Label()
        Me.lblTotalEquityPercent = New System.Windows.Forms.Label()
        Me.lblTotalPropertyValue = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblInvestor = New System.Windows.Forms.Label()
        Me.lblPropertyType = New System.Windows.Forms.Label()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblROI = New System.Windows.Forms.Label()
        Me.DistinctCityBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboPercent = New System.Windows.Forms.ComboBox()
        Me.radBottom = New System.Windows.Forms.RadioButton()
        Me.radTop = New System.Windows.Forms.RadioButton()
        Me.InvestorFullNameTableAdapter = New MapleEstateInvestmentsForm.MapleEstInvestDataSetTableAdapters.InvestorFullNameTableAdapter()
        Me.lblOPCount = New System.Windows.Forms.Label()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.lblOPAvgEqPer = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTotProfit = New System.Windows.Forms.Label()
        Me.lblOPTotRev = New System.Windows.Forms.Label()
        Me.pbFamily = New System.Windows.Forms.ProgressBar()
        Me.pbDuplex = New System.Windows.Forms.ProgressBar()
        Me.pbFourplex = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblBarFamily = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblBarFourplex = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblBarDuplex = New System.Windows.Forms.Label()
        Me.pnlGraph = New System.Windows.Forms.Panel()
        Me.lblGraph = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BrokersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmBroker = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmTransaction = New System.Windows.Forms.ToolStripMenuItem()
        Me.InvestorsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmInvestorDetail = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.InvestorFullNameBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MapleEstInvestDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INVESTORBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvestorPortfolioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvestorPortfolioDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHeader.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DistinctCityBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlGraph.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.btnSearch.Location = New System.Drawing.Point(941, 171)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(112, 38)
        Me.btnSearch.TabIndex = 0
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'cboInvestor
        '
        Me.cboInvestor.DataSource = Me.InvestorFullNameBindingSource
        Me.cboInvestor.DisplayMember = "Investor_FullName"
        Me.cboInvestor.FormattingEnabled = True
        Me.cboInvestor.Location = New System.Drawing.Point(52, 142)
        Me.cboInvestor.Name = "cboInvestor"
        Me.cboInvestor.Size = New System.Drawing.Size(121, 21)
        Me.cboInvestor.TabIndex = 1
        Me.cboInvestor.ValueMember = "Investor_ID"
        '
        'InvestorFullNameBindingSource
        '
        Me.InvestorFullNameBindingSource.DataMember = "InvestorFullName"
        Me.InvestorFullNameBindingSource.DataSource = Me.MapleEstInvestDataSet
        '
        'MapleEstInvestDataSet
        '
        Me.MapleEstInvestDataSet.DataSetName = "MapleEstInvestDataSet"
        Me.MapleEstInvestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'INVESTORBindingSource
        '
        Me.INVESTORBindingSource.DataMember = "INVESTOR"
        Me.INVESTORBindingSource.DataSource = Me.MapleEstInvestDataSet
        '
        'INVESTORTableAdapter
        '
        Me.INVESTORTableAdapter.ClearBeforeFill = True
        '
        'InvestorPortfolioBindingSource
        '
        Me.InvestorPortfolioBindingSource.DataMember = "InvestorPortfolio"
        Me.InvestorPortfolioBindingSource.DataSource = Me.MapleEstInvestDataSet
        '
        'InvestorPortfolioTableAdapter
        '
        Me.InvestorPortfolioTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BROKERTableAdapter = Nothing
        Me.TableAdapterManager.FUNDING_METHODTableAdapter = Nothing
        Me.TableAdapterManager.INVESTORTableAdapter = Me.INVESTORTableAdapter
        Me.TableAdapterManager.LICENSE_STATUSTableAdapter = Nothing
        Me.TableAdapterManager.LISTINGTableAdapter = Nothing
        Me.TableAdapterManager.LOAN_TYPETableAdapter = Nothing
        Me.TableAdapterManager.PORTFOLIO_PROPERTYTableAdapter = Nothing
        Me.TableAdapterManager.PROPERTY_HISTORYTableAdapter = Nothing
        Me.TableAdapterManager.PROPERTY_TYPETableAdapter = Nothing
        Me.TableAdapterManager.PROPERTYTableAdapter = Nothing
        Me.TableAdapterManager.RISK_LEVELTableAdapter = Nothing
        Me.TableAdapterManager.SALES_STATUSTableAdapter = Nothing
        Me.TableAdapterManager.TRANSACTION_TYPETableAdapter = Nothing
        Me.TableAdapterManager.TRANSACTIONTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = MapleEstateInvestmentsForm.MapleEstInvestDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'InvestorPortfolioDataGridView
        '
        Me.InvestorPortfolioDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.InvestorPortfolioDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.InvestorPortfolioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.InvestorPortfolioDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.PropertyValue, Me.EquityPercent, Me.AverageROI, Me.PropertyExpenses, Me.HOAExpenses, Me.Insurance, Me.PropertyTax, Me.YearPurchased, Me.YearBuilt, Me.Type})
        Me.InvestorPortfolioDataGridView.DataSource = Me.InvestorPortfolioBindingSource
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.InvestorPortfolioDataGridView.DefaultCellStyle = DataGridViewCellStyle22
        Me.InvestorPortfolioDataGridView.Location = New System.Drawing.Point(40, 237)
        Me.InvestorPortfolioDataGridView.Name = "InvestorPortfolioDataGridView"
        Me.InvestorPortfolioDataGridView.Size = New System.Drawing.Size(1035, 243)
        Me.InvestorPortfolioDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Address"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 150
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "City"
        Me.DataGridViewTextBoxColumn6.FillWeight = 90.0!
        Me.DataGridViewTextBoxColumn6.HeaderText = "City"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'PropertyValue
        '
        Me.PropertyValue.DataPropertyName = "Property_Value"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle13.Format = "C2"
        DataGridViewCellStyle13.NullValue = Nothing
        Me.PropertyValue.DefaultCellStyle = DataGridViewCellStyle13
        Me.PropertyValue.FillWeight = 80.0!
        Me.PropertyValue.HeaderText = "Property Value"
        Me.PropertyValue.Name = "PropertyValue"
        '
        'EquityPercent
        '
        Me.EquityPercent.DataPropertyName = "Equity_Percent"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle14.Format = "0.00%"
        DataGridViewCellStyle14.NullValue = Nothing
        Me.EquityPercent.DefaultCellStyle = DataGridViewCellStyle14
        Me.EquityPercent.HeaderText = "Equity Percent"
        Me.EquityPercent.Name = "EquityPercent"
        Me.EquityPercent.Width = 60
        '
        'AverageROI
        '
        Me.AverageROI.DataPropertyName = "Average_ROI"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle15.Format = "0.00%"
        DataGridViewCellStyle15.NullValue = Nothing
        Me.AverageROI.DefaultCellStyle = DataGridViewCellStyle15
        Me.AverageROI.HeaderText = "Average ROI"
        Me.AverageROI.Name = "AverageROI"
        Me.AverageROI.Width = 60
        '
        'PropertyExpenses
        '
        Me.PropertyExpenses.DataPropertyName = "Property_Expenses"
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle16.Format = "C2"
        DataGridViewCellStyle16.NullValue = Nothing
        Me.PropertyExpenses.DefaultCellStyle = DataGridViewCellStyle16
        Me.PropertyExpenses.HeaderText = "Property Expenses"
        Me.PropertyExpenses.Name = "PropertyExpenses"
        Me.PropertyExpenses.Width = 70
        '
        'HOAExpenses
        '
        Me.HOAExpenses.DataPropertyName = "HOA_Expenses"
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle17.Format = "C2"
        Me.HOAExpenses.DefaultCellStyle = DataGridViewCellStyle17
        Me.HOAExpenses.HeaderText = "HOA Expenses"
        Me.HOAExpenses.Name = "HOAExpenses"
        Me.HOAExpenses.Width = 70
        '
        'Insurance
        '
        Me.Insurance.DataPropertyName = "Insurance"
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle18.Format = "C2"
        DataGridViewCellStyle18.NullValue = Nothing
        Me.Insurance.DefaultCellStyle = DataGridViewCellStyle18
        Me.Insurance.HeaderText = "Insurance"
        Me.Insurance.Name = "Insurance"
        Me.Insurance.Width = 80
        '
        'PropertyTax
        '
        Me.PropertyTax.DataPropertyName = "Property_Tax"
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle19.Format = "C2"
        DataGridViewCellStyle19.NullValue = Nothing
        Me.PropertyTax.DefaultCellStyle = DataGridViewCellStyle19
        Me.PropertyTax.HeaderText = "Property Tax"
        Me.PropertyTax.Name = "PropertyTax"
        Me.PropertyTax.Width = 80
        '
        'YearPurchased
        '
        Me.YearPurchased.DataPropertyName = "Year_Purchased"
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle20.NullValue = Nothing
        Me.YearPurchased.DefaultCellStyle = DataGridViewCellStyle20
        Me.YearPurchased.HeaderText = "Year Purchased"
        Me.YearPurchased.Name = "YearPurchased"
        Me.YearPurchased.Width = 75
        '
        'YearBuilt
        '
        Me.YearBuilt.DataPropertyName = "Year_Built"
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.YearBuilt.DefaultCellStyle = DataGridViewCellStyle21
        Me.YearBuilt.HeaderText = "Year Built"
        Me.YearBuilt.Name = "YearBuilt"
        Me.YearBuilt.Width = 50
        '
        'Type
        '
        Me.Type.DataPropertyName = "Type"
        Me.Type.HeaderText = "Type"
        Me.Type.Name = "Type"
        Me.Type.Width = 80
        '
        'clbPropertyType
        '
        Me.clbPropertyType.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.clbPropertyType.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.clbPropertyType.CheckOnClick = True
        Me.clbPropertyType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.clbPropertyType.FormattingEnabled = True
        Me.clbPropertyType.Items.AddRange(New Object() {"Duplex", "Fourplex", "Single Family"})
        Me.clbPropertyType.Location = New System.Drawing.Point(221, 142)
        Me.clbPropertyType.Name = "clbPropertyType"
        Me.clbPropertyType.Size = New System.Drawing.Size(120, 45)
        Me.clbPropertyType.TabIndex = 3
        '
        'lblTotalEquity
        '
        Me.lblTotalEquity.AutoSize = True
        Me.lblTotalEquity.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.lblTotalEquity.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalEquity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.lblTotalEquity.Location = New System.Drawing.Point(124, 113)
        Me.lblTotalEquity.Name = "lblTotalEquity"
        Me.lblTotalEquity.Size = New System.Drawing.Size(92, 14)
        Me.lblTotalEquity.TabIndex = 4
        Me.lblTotalEquity.Text = "Total Equity:"
        Me.lblTotalEquity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAverageROI
        '
        Me.lblAverageROI.AutoSize = True
        Me.lblAverageROI.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.lblAverageROI.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverageROI.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.lblAverageROI.Location = New System.Drawing.Point(467, 90)
        Me.lblAverageROI.Name = "lblAverageROI"
        Me.lblAverageROI.Size = New System.Drawing.Size(90, 14)
        Me.lblAverageROI.TabIndex = 5
        Me.lblAverageROI.Text = "Average ROI:"
        Me.lblAverageROI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalRevenue
        '
        Me.lblTotalRevenue.AutoSize = True
        Me.lblTotalRevenue.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.lblTotalRevenue.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalRevenue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.lblTotalRevenue.Location = New System.Drawing.Point(67, 23)
        Me.lblTotalRevenue.Name = "lblTotalRevenue"
        Me.lblTotalRevenue.Size = New System.Drawing.Size(149, 14)
        Me.lblTotalRevenue.TabIndex = 6
        Me.lblTotalRevenue.Text = "Total Yearly Revenue:"
        Me.lblTotalRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOPTotProf
        '
        Me.lblOPTotProf.AutoSize = True
        Me.lblOPTotProf.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.lblOPTotProf.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOPTotProf.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.lblOPTotProf.Location = New System.Drawing.Point(222, 67)
        Me.lblOPTotProf.Name = "lblOPTotProf"
        Me.lblOPTotProf.Size = New System.Drawing.Size(0, 14)
        Me.lblOPTotProf.TabIndex = 9
        '
        'lblOPAvgROI
        '
        Me.lblOPAvgROI.AutoSize = True
        Me.lblOPAvgROI.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.lblOPAvgROI.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOPAvgROI.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.lblOPAvgROI.Location = New System.Drawing.Point(563, 90)
        Me.lblOPAvgROI.Name = "lblOPAvgROI"
        Me.lblOPAvgROI.Size = New System.Drawing.Size(0, 14)
        Me.lblOPAvgROI.TabIndex = 8
        '
        'lblOPTotEq
        '
        Me.lblOPTotEq.AutoSize = True
        Me.lblOPTotEq.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.lblOPTotEq.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOPTotEq.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.lblOPTotEq.Location = New System.Drawing.Point(222, 113)
        Me.lblOPTotEq.Name = "lblOPTotEq"
        Me.lblOPTotEq.Size = New System.Drawing.Size(0, 14)
        Me.lblOPTotEq.TabIndex = 7
        '
        'lblOPTotEx
        '
        Me.lblOPTotEx.AutoSize = True
        Me.lblOPTotEx.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.lblOPTotEx.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOPTotEx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.lblOPTotEx.Location = New System.Drawing.Point(222, 44)
        Me.lblOPTotEx.Name = "lblOPTotEx"
        Me.lblOPTotEx.Size = New System.Drawing.Size(0, 14)
        Me.lblOPTotEx.TabIndex = 15
        '
        'lblOPTotEqPer
        '
        Me.lblOPTotEqPer.AutoSize = True
        Me.lblOPTotEqPer.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.lblOPTotEqPer.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOPTotEqPer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.lblOPTotEqPer.Location = New System.Drawing.Point(563, 44)
        Me.lblOPTotEqPer.Name = "lblOPTotEqPer"
        Me.lblOPTotEqPer.Size = New System.Drawing.Size(0, 14)
        Me.lblOPTotEqPer.TabIndex = 14
        '
        'lblOPTotPropVal
        '
        Me.lblOPTotPropVal.AutoSize = True
        Me.lblOPTotPropVal.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.lblOPTotPropVal.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOPTotPropVal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.lblOPTotPropVal.Location = New System.Drawing.Point(222, 90)
        Me.lblOPTotPropVal.Name = "lblOPTotPropVal"
        Me.lblOPTotPropVal.Size = New System.Drawing.Size(0, 14)
        Me.lblOPTotPropVal.TabIndex = 13
        '
        'lblTotalExpenses
        '
        Me.lblTotalExpenses.AutoSize = True
        Me.lblTotalExpenses.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.lblTotalExpenses.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalExpenses.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.lblTotalExpenses.Location = New System.Drawing.Point(61, 44)
        Me.lblTotalExpenses.Name = "lblTotalExpenses"
        Me.lblTotalExpenses.Size = New System.Drawing.Size(155, 14)
        Me.lblTotalExpenses.TabIndex = 12
        Me.lblTotalExpenses.Text = "Total Yearly Expenses:"
        Me.lblTotalExpenses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalEquityPercent
        '
        Me.lblTotalEquityPercent.AutoSize = True
        Me.lblTotalEquityPercent.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.lblTotalEquityPercent.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalEquityPercent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.lblTotalEquityPercent.Location = New System.Drawing.Point(411, 44)
        Me.lblTotalEquityPercent.Name = "lblTotalEquityPercent"
        Me.lblTotalEquityPercent.Size = New System.Drawing.Size(146, 14)
        Me.lblTotalEquityPercent.TabIndex = 11
        Me.lblTotalEquityPercent.Text = "Total Equity Percent:"
        Me.lblTotalEquityPercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalPropertyValue
        '
        Me.lblTotalPropertyValue.AutoSize = True
        Me.lblTotalPropertyValue.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.lblTotalPropertyValue.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPropertyValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.lblTotalPropertyValue.Location = New System.Drawing.Point(70, 90)
        Me.lblTotalPropertyValue.Name = "lblTotalPropertyValue"
        Me.lblTotalPropertyValue.Size = New System.Drawing.Size(146, 14)
        Me.lblTotalPropertyValue.TabIndex = 10
        Me.lblTotalPropertyValue.Text = "Total Property Value:"
        Me.lblTotalPropertyValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Bookman Old Style", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(416, 24)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(271, 22)
        Me.lblTitle.TabIndex = 19
        Me.lblTitle.Text = "Investor's Portfolio Search"
        '
        'lblInvestor
        '
        Me.lblInvestor.AutoSize = True
        Me.lblInvestor.Font = New System.Drawing.Font("Bookman Old Style", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvestor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.lblInvestor.Location = New System.Drawing.Point(49, 113)
        Me.lblInvestor.Name = "lblInvestor"
        Me.lblInvestor.Size = New System.Drawing.Size(71, 17)
        Me.lblInvestor.TabIndex = 17
        Me.lblInvestor.Text = "Investor:"
        Me.lblInvestor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPropertyType
        '
        Me.lblPropertyType.AutoSize = True
        Me.lblPropertyType.Font = New System.Drawing.Font("Bookman Old Style", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPropertyType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.lblPropertyType.Location = New System.Drawing.Point(218, 113)
        Me.lblPropertyType.Name = "lblPropertyType"
        Me.lblPropertyType.Size = New System.Drawing.Size(113, 17)
        Me.lblPropertyType.TabIndex = 16
        Me.lblPropertyType.Text = "Property Type"
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.btnClose)
        Me.pnlHeader.Controls.Add(Me.PictureBox1)
        Me.pnlHeader.Controls.Add(Me.Panel3)
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1103, 70)
        Me.pnlHeader.TabIndex = 22
        '
        'btnClose
        '
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.Location = New System.Drawing.Point(1015, 12)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(76, 21)
        Me.btnClose.TabIndex = 46
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(28, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(106, 70)
        Me.Panel3.TabIndex = 46
        '
        'lblROI
        '
        Me.lblROI.AutoSize = True
        Me.lblROI.Font = New System.Drawing.Font("Bookman Old Style", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblROI.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.lblROI.Location = New System.Drawing.Point(387, 113)
        Me.lblROI.Name = "lblROI"
        Me.lblROI.Size = New System.Drawing.Size(255, 17)
        Me.lblROI.TabIndex = 23
        Me.lblROI.Text = "Top% or Bottom% Property Value "
        '
        'DistinctCityBindingSource
        '
        Me.DistinctCityBindingSource.DataMember = "Distinct_City"
        Me.DistinctCityBindingSource.DataSource = Me.MapleEstInvestDataSet
        '
        'cboPercent
        '
        Me.cboPercent.FormatString = "0%"
        Me.cboPercent.FormattingEnabled = True
        Me.cboPercent.Items.AddRange(New Object() {"100", "90", "80", "70", "60", "50", "40", "30", "20", "10"})
        Me.cboPercent.Location = New System.Drawing.Point(390, 188)
        Me.cboPercent.Name = "cboPercent"
        Me.cboPercent.Size = New System.Drawing.Size(66, 21)
        Me.cboPercent.TabIndex = 27
        '
        'radBottom
        '
        Me.radBottom.AutoSize = True
        Me.radBottom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.radBottom.Location = New System.Drawing.Point(394, 156)
        Me.radBottom.Name = "radBottom"
        Me.radBottom.Size = New System.Drawing.Size(58, 17)
        Me.radBottom.TabIndex = 28
        Me.radBottom.Tag = "1"
        Me.radBottom.Text = "Bottom"
        Me.radBottom.UseVisualStyleBackColor = True
        '
        'radTop
        '
        Me.radTop.AutoSize = True
        Me.radTop.Checked = True
        Me.radTop.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.radTop.Location = New System.Drawing.Point(393, 133)
        Me.radTop.Name = "radTop"
        Me.radTop.Size = New System.Drawing.Size(44, 17)
        Me.radTop.TabIndex = 29
        Me.radTop.TabStop = True
        Me.radTop.Tag = "0"
        Me.radTop.Text = "Top"
        Me.radTop.UseVisualStyleBackColor = True
        '
        'InvestorFullNameTableAdapter
        '
        Me.InvestorFullNameTableAdapter.ClearBeforeFill = True
        '
        'lblOPCount
        '
        Me.lblOPCount.AutoSize = True
        Me.lblOPCount.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.lblOPCount.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOPCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.lblOPCount.Location = New System.Drawing.Point(563, 23)
        Me.lblOPCount.Name = "lblOPCount"
        Me.lblOPCount.Size = New System.Drawing.Size(0, 14)
        Me.lblOPCount.TabIndex = 31
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.lblCount.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.lblCount.Location = New System.Drawing.Point(440, 23)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(117, 14)
        Me.lblCount.TabIndex = 30
        Me.lblCount.Text = "Total Properties:"
        Me.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOPAvgEqPer
        '
        Me.lblOPAvgEqPer.AutoSize = True
        Me.lblOPAvgEqPer.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.lblOPAvgEqPer.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOPAvgEqPer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.lblOPAvgEqPer.Location = New System.Drawing.Point(563, 67)
        Me.lblOPAvgEqPer.Name = "lblOPAvgEqPer"
        Me.lblOPAvgEqPer.Size = New System.Drawing.Size(0, 14)
        Me.lblOPAvgEqPer.TabIndex = 33
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(394, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 14)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Average Equity Percent:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotProfit
        '
        Me.lblTotProfit.AutoSize = True
        Me.lblTotProfit.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.lblTotProfit.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotProfit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.lblTotProfit.Location = New System.Drawing.Point(85, 570)
        Me.lblTotProfit.Name = "lblTotProfit"
        Me.lblTotProfit.Size = New System.Drawing.Size(131, 14)
        Me.lblTotProfit.TabIndex = 34
        Me.lblTotProfit.Text = "Total Yearly Profit:"
        Me.lblTotProfit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOPTotRev
        '
        Me.lblOPTotRev.AutoSize = True
        Me.lblOPTotRev.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.lblOPTotRev.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOPTotRev.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.lblOPTotRev.Location = New System.Drawing.Point(222, 23)
        Me.lblOPTotRev.Name = "lblOPTotRev"
        Me.lblOPTotRev.Size = New System.Drawing.Size(0, 14)
        Me.lblOPTotRev.TabIndex = 35
        '
        'pbFamily
        '
        Me.pbFamily.Location = New System.Drawing.Point(135, 113)
        Me.pbFamily.Name = "pbFamily"
        Me.pbFamily.Size = New System.Drawing.Size(173, 20)
        Me.pbFamily.TabIndex = 36
        '
        'pbDuplex
        '
        Me.pbDuplex.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.pbDuplex.Location = New System.Drawing.Point(135, 50)
        Me.pbDuplex.Name = "pbDuplex"
        Me.pbDuplex.Size = New System.Drawing.Size(173, 20)
        Me.pbDuplex.TabIndex = 37
        '
        'pbFourplex
        '
        Me.pbFourplex.Location = New System.Drawing.Point(135, 80)
        Me.pbFourplex.Name = "pbFourplex"
        Me.pbFourplex.Size = New System.Drawing.Size(173, 20)
        Me.pbFourplex.TabIndex = 38
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(356, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 14)
        Me.Label1.TabIndex = 44
        '
        'lblBarFamily
        '
        Me.lblBarFamily.AutoSize = True
        Me.lblBarFamily.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBarFamily.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.lblBarFamily.Location = New System.Drawing.Point(21, 119)
        Me.lblBarFamily.Name = "lblBarFamily"
        Me.lblBarFamily.Size = New System.Drawing.Size(96, 14)
        Me.lblBarFamily.TabIndex = 43
        Me.lblBarFamily.Text = "Single Family"
        Me.lblBarFamily.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(356, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 14)
        Me.Label4.TabIndex = 42
        '
        'lblBarFourplex
        '
        Me.lblBarFourplex.AutoSize = True
        Me.lblBarFourplex.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBarFourplex.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.lblBarFourplex.Location = New System.Drawing.Point(51, 86)
        Me.lblBarFourplex.Name = "lblBarFourplex"
        Me.lblBarFourplex.Size = New System.Drawing.Size(66, 14)
        Me.lblBarFourplex.TabIndex = 41
        Me.lblBarFourplex.Text = "Fourplex"
        Me.lblBarFourplex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(356, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 14)
        Me.Label6.TabIndex = 40
        '
        'lblBarDuplex
        '
        Me.lblBarDuplex.AutoSize = True
        Me.lblBarDuplex.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBarDuplex.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.lblBarDuplex.Location = New System.Drawing.Point(63, 56)
        Me.lblBarDuplex.Name = "lblBarDuplex"
        Me.lblBarDuplex.Size = New System.Drawing.Size(54, 14)
        Me.lblBarDuplex.TabIndex = 39
        Me.lblBarDuplex.Text = "Duplex"
        Me.lblBarDuplex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlGraph
        '
        Me.pnlGraph.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.pnlGraph.Controls.Add(Me.lblGraph)
        Me.pnlGraph.Controls.Add(Me.Label1)
        Me.pnlGraph.Controls.Add(Me.lblBarDuplex)
        Me.pnlGraph.Controls.Add(Me.lblBarFamily)
        Me.pnlGraph.Controls.Add(Me.pbFamily)
        Me.pnlGraph.Controls.Add(Me.Label4)
        Me.pnlGraph.Controls.Add(Me.pbDuplex)
        Me.pnlGraph.Controls.Add(Me.lblBarFourplex)
        Me.pnlGraph.Controls.Add(Me.pbFourplex)
        Me.pnlGraph.Controls.Add(Me.Label6)
        Me.pnlGraph.Location = New System.Drawing.Point(731, 0)
        Me.pnlGraph.Name = "pnlGraph"
        Me.pnlGraph.Size = New System.Drawing.Size(321, 148)
        Me.pnlGraph.TabIndex = 45
        '
        'lblGraph
        '
        Me.lblGraph.AutoSize = True
        Me.lblGraph.Font = New System.Drawing.Font("Bookman Old Style", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGraph.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.lblGraph.Location = New System.Drawing.Point(39, 13)
        Me.lblGraph.Name = "lblGraph"
        Me.lblGraph.Size = New System.Drawing.Size(269, 17)
        Me.lblGraph.TabIndex = 45
        Me.lblGraph.Text = "Graph of % Value in Property Types"
        Me.lblGraph.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblTotalPropertyValue)
        Me.Panel1.Controls.Add(Me.lblOPAvgEqPer)
        Me.Panel1.Controls.Add(Me.lblOPCount)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lblCount)
        Me.Panel1.Controls.Add(Me.lblTotalRevenue)
        Me.Panel1.Controls.Add(Me.lblTotalExpenses)
        Me.Panel1.Controls.Add(Me.lblOPAvgROI)
        Me.Panel1.Controls.Add(Me.lblOPTotEx)
        Me.Panel1.Controls.Add(Me.lblOPTotPropVal)
        Me.Panel1.Controls.Add(Me.lblOPTotEqPer)
        Me.Panel1.Controls.Add(Me.lblOPTotEq)
        Me.Panel1.Controls.Add(Me.pnlGraph)
        Me.Panel1.Controls.Add(Me.lblTotalEquity)
        Me.Panel1.Controls.Add(Me.lblAverageROI)
        Me.Panel1.Controls.Add(Me.lblOPTotRev)
        Me.Panel1.Controls.Add(Me.lblTotalEquityPercent)
        Me.Panel1.Controls.Add(Me.lblOPTotProf)
        Me.Panel1.Location = New System.Drawing.Point(0, 503)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1114, 149)
        Me.Panel1.TabIndex = 46
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BrokersToolStripMenuItem, Me.InvestorsToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 70)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1103, 24)
        Me.MenuStrip1.TabIndex = 47
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BrokersToolStripMenuItem
        '
        Me.BrokersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmBroker, Me.tsmTransaction})
        Me.BrokersToolStripMenuItem.Name = "BrokersToolStripMenuItem"
        Me.BrokersToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.BrokersToolStripMenuItem.Text = "Brokers"
        '
        'tsmBroker
        '
        Me.tsmBroker.Name = "tsmBroker"
        Me.tsmBroker.Size = New System.Drawing.Size(159, 22)
        Me.tsmBroker.Text = "Broker's Listings"
        '
        'tsmTransaction
        '
        Me.tsmTransaction.Name = "tsmTransaction"
        Me.tsmTransaction.Size = New System.Drawing.Size(159, 22)
        Me.tsmTransaction.Text = "Transactions"
        '
        'InvestorsToolStripMenuItem1
        '
        Me.InvestorsToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmInvestorDetail})
        Me.InvestorsToolStripMenuItem1.Name = "InvestorsToolStripMenuItem1"
        Me.InvestorsToolStripMenuItem1.Size = New System.Drawing.Size(66, 20)
        Me.InvestorsToolStripMenuItem1.Text = "Investors"
        '
        'tsmInvestorDetail
        '
        Me.tsmInvestorDetail.Name = "tsmInvestorDetail"
        Me.tsmInvestorDetail.Size = New System.Drawing.Size(154, 22)
        Me.tsmInvestorDetail.Text = "Investor Details"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Panel4.Controls.Add(Me.TextBox1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 652)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1103, 30)
        Me.Panel4.TabIndex = 48
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.TextBox1.Location = New System.Drawing.Point(4, 8)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(294, 15)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "2021 © Maple Estate Investments. All Rights Reserved"
        '
        'SearchInvestorPortfolio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1103, 682)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.lblTotProfit)
        Me.Controls.Add(Me.radTop)
        Me.Controls.Add(Me.radBottom)
        Me.Controls.Add(Me.cboPercent)
        Me.Controls.Add(Me.lblROI)
        Me.Controls.Add(Me.lblInvestor)
        Me.Controls.Add(Me.lblPropertyType)
        Me.Controls.Add(Me.clbPropertyType)
        Me.Controls.Add(Me.InvestorPortfolioDataGridView)
        Me.Controls.Add(Me.cboInvestor)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "SearchInvestorPortfolio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search Investor Portfolio"
        CType(Me.InvestorFullNameBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MapleEstInvestDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INVESTORBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvestorPortfolioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvestorPortfolioDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DistinctCityBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlGraph.ResumeLayout(False)
        Me.pnlGraph.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSearch As Button
    Friend WithEvents cboInvestor As ComboBox
    Friend WithEvents MapleEstInvestDataSet As MapleEstInvestDataSet
    Friend WithEvents INVESTORBindingSource As BindingSource
    Friend WithEvents INVESTORTableAdapter As MapleEstInvestDataSetTableAdapters.INVESTORTableAdapter
    Friend WithEvents InvestorPortfolioBindingSource As BindingSource
    Friend WithEvents InvestorPortfolioTableAdapter As MapleEstInvestDataSetTableAdapters.InvestorPortfolioTableAdapter
    Friend WithEvents TableAdapterManager As MapleEstInvestDataSetTableAdapters.TableAdapterManager
    Friend WithEvents InvestorPortfolioDataGridView As DataGridView
    Friend WithEvents clbPropertyType As CheckedListBox
    Friend WithEvents lblTotalEquity As Label
    Friend WithEvents lblAverageROI As Label
    Friend WithEvents lblTotalRevenue As Label
    Friend WithEvents lblOPTotProf As Label
    Friend WithEvents lblOPAvgROI As Label
    Friend WithEvents lblOPTotEq As Label
    Friend WithEvents lblOPTotEx As Label
    Friend WithEvents lblOPTotEqPer As Label
    Friend WithEvents lblOPTotPropVal As Label
    Friend WithEvents lblTotalExpenses As Label
    Friend WithEvents lblTotalEquityPercent As Label
    Friend WithEvents lblTotalPropertyValue As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblInvestor As Label
    Friend WithEvents lblPropertyType As Label
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblROI As Label
    Friend WithEvents cboPercent As ComboBox
    Friend WithEvents radBottom As RadioButton
    Friend WithEvents radTop As RadioButton
    Friend WithEvents DistinctCityBindingSource As BindingSource
    Friend WithEvents InvestorFullNameBindingSource As BindingSource
    Friend WithEvents InvestorFullNameTableAdapter As MapleEstInvestDataSetTableAdapters.InvestorFullNameTableAdapter
    Friend WithEvents lblOPCount As Label
    Friend WithEvents lblCount As Label
    Friend WithEvents lblOPAvgEqPer As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTotProfit As Label
    Friend WithEvents lblOPTotRev As Label
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents PropertyValue As DataGridViewTextBoxColumn
    Friend WithEvents EquityPercent As DataGridViewTextBoxColumn
    Friend WithEvents AverageROI As DataGridViewTextBoxColumn
    Friend WithEvents PropertyExpenses As DataGridViewTextBoxColumn
    Friend WithEvents HOAExpenses As DataGridViewTextBoxColumn
    Friend WithEvents Insurance As DataGridViewTextBoxColumn
    Friend WithEvents PropertyTax As DataGridViewTextBoxColumn
    Friend WithEvents YearPurchased As DataGridViewTextBoxColumn
    Friend WithEvents YearBuilt As DataGridViewTextBoxColumn
    Friend WithEvents Type As DataGridViewTextBoxColumn
    Friend WithEvents pbFamily As ProgressBar
    Friend WithEvents pbDuplex As ProgressBar
    Friend WithEvents pbFourplex As ProgressBar
    Friend WithEvents Label1 As Label
    Friend WithEvents lblBarFamily As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblBarFourplex As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblBarDuplex As Label
    Friend WithEvents pnlGraph As Panel
    Friend WithEvents lblGraph As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BrokersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsmBroker As ToolStripMenuItem
    Friend WithEvents tsmTransaction As ToolStripMenuItem
    Friend WithEvents InvestorsToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents tsmInvestorDetail As ToolStripMenuItem
    Friend WithEvents Panel4 As Panel
    Friend WithEvents TextBox1 As TextBox
End Class
