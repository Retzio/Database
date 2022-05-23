<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransactionsGrid
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TransactionsGrid))
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.MapleEstInvestDataSet = New MapleEstateInvestmentsForm.MapleEstInvestDataSet()
        Me.TRANSACTIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TRANSACTIONTableAdapter = New MapleEstateInvestmentsForm.MapleEstInvestDataSetTableAdapters.TRANSACTIONTableAdapter()
        Me.TableAdapterManager = New MapleEstateInvestmentsForm.MapleEstInvestDataSetTableAdapters.TableAdapterManager()
        Me.BROKERTableAdapter = New MapleEstateInvestmentsForm.MapleEstInvestDataSetTableAdapters.BROKERTableAdapter()
        Me.INVESTORTableAdapter = New MapleEstateInvestmentsForm.MapleEstInvestDataSetTableAdapters.INVESTORTableAdapter()
        Me.TRANSACTIONBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TRANSACTIONBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TRANSACTIONDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.INVESTORBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.BROKERBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Comission = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BROKERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BrokersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BrokerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InvestorsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InvestorsDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InvestorsPortfolioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MapleEstInvestDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TRANSACTIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TRANSACTIONBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TRANSACTIONBindingNavigator.SuspendLayout()
        CType(Me.TRANSACTIONDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INVESTORBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BROKERBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BROKERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Bookman Old Style", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(357, 24)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(136, 22)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "Transactions"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(850, 70)
        Me.Panel1.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(28, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 47
        Me.PictureBox1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(106, 70)
        Me.Panel3.TabIndex = 48
        '
        'btnClose
        '
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.Location = New System.Drawing.Point(762, 12)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(76, 21)
        Me.btnClose.TabIndex = 29
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'MapleEstInvestDataSet
        '
        Me.MapleEstInvestDataSet.DataSetName = "MapleEstInvestDataSet"
        Me.MapleEstInvestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TRANSACTIONBindingSource
        '
        Me.TRANSACTIONBindingSource.DataMember = "TRANSACTION"
        Me.TRANSACTIONBindingSource.DataSource = Me.MapleEstInvestDataSet
        '
        'TRANSACTIONTableAdapter
        '
        Me.TRANSACTIONTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BROKERTableAdapter = Me.BROKERTableAdapter
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
        Me.TableAdapterManager.TRANSACTIONTableAdapter = Me.TRANSACTIONTableAdapter
        Me.TableAdapterManager.UpdateOrder = MapleEstateInvestmentsForm.MapleEstInvestDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BROKERTableAdapter
        '
        Me.BROKERTableAdapter.ClearBeforeFill = True
        '
        'INVESTORTableAdapter
        '
        Me.INVESTORTableAdapter.ClearBeforeFill = True
        '
        'TRANSACTIONBindingNavigator
        '
        Me.TRANSACTIONBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TRANSACTIONBindingNavigator.BackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.TRANSACTIONBindingNavigator.BindingSource = Me.TRANSACTIONBindingSource
        Me.TRANSACTIONBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TRANSACTIONBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TRANSACTIONBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.TRANSACTIONBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.TRANSACTIONBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TRANSACTIONBindingNavigatorSaveItem})
        Me.TRANSACTIONBindingNavigator.Location = New System.Drawing.Point(12, 113)
        Me.TRANSACTIONBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TRANSACTIONBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TRANSACTIONBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TRANSACTIONBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TRANSACTIONBindingNavigator.Name = "TRANSACTIONBindingNavigator"
        Me.TRANSACTIONBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TRANSACTIONBindingNavigator.Size = New System.Drawing.Size(194, 25)
        Me.TRANSACTIONBindingNavigator.TabIndex = 3
        Me.TRANSACTIONBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Enabled = False
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        Me.BindingNavigatorAddNewItem.Visible = False
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Enabled = False
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        Me.BindingNavigatorDeleteItem.Visible = False
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        Me.BindingNavigatorSeparator2.Visible = False
        '
        'TRANSACTIONBindingNavigatorSaveItem
        '
        Me.TRANSACTIONBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TRANSACTIONBindingNavigatorSaveItem.Enabled = False
        Me.TRANSACTIONBindingNavigatorSaveItem.Image = CType(resources.GetObject("TRANSACTIONBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TRANSACTIONBindingNavigatorSaveItem.Name = "TRANSACTIONBindingNavigatorSaveItem"
        Me.TRANSACTIONBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TRANSACTIONBindingNavigatorSaveItem.Text = "Save Data"
        Me.TRANSACTIONBindingNavigatorSaveItem.Visible = False
        '
        'TRANSACTIONDataGridView
        '
        Me.TRANSACTIONDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TRANSACTIONDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.TRANSACTIONDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TRANSACTIONDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn7, Me.Price, Me.Rate, Me.Comission})
        Me.TRANSACTIONDataGridView.DataSource = Me.TRANSACTIONBindingSource
        Me.TRANSACTIONDataGridView.Location = New System.Drawing.Point(12, 145)
        Me.TRANSACTIONDataGridView.Name = "TRANSACTIONDataGridView"
        Me.TRANSACTIONDataGridView.Size = New System.Drawing.Size(803, 286)
        Me.TRANSACTIONDataGridView.TabIndex = 3
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Transaction_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Transaction ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Investor_ID"
        Me.DataGridViewTextBoxColumn2.DataSource = Me.INVESTORBindingSource
        Me.DataGridViewTextBoxColumn2.DisplayMember = "Investor_Full_Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Investor"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn2.ValueMember = "Investor_ID"
        Me.DataGridViewTextBoxColumn2.Width = 130
        '
        'INVESTORBindingSource
        '
        Me.INVESTORBindingSource.DataMember = "INVESTOR"
        Me.INVESTORBindingSource.DataSource = Me.MapleEstInvestDataSet
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Broker_ID"
        Me.DataGridViewTextBoxColumn3.DataSource = Me.BROKERBindingSource1
        Me.DataGridViewTextBoxColumn3.DisplayMember = "Full_Name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Broker"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn3.ValueMember = "Broker_ID"
        Me.DataGridViewTextBoxColumn3.Width = 130
        '
        'BROKERBindingSource1
        '
        Me.BROKERBindingSource1.DataMember = "BROKER"
        Me.BROKERBindingSource1.DataSource = Me.MapleEstInvestDataSet
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Transaction_Date"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'Price
        '
        Me.Price.DataPropertyName = "Transaction_Price"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "C2"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.Price.DefaultCellStyle = DataGridViewCellStyle10
        Me.Price.HeaderText = "Price"
        Me.Price.Name = "Price"
        '
        'Rate
        '
        Me.Rate.DataPropertyName = "Transaction_Commission_Rate"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.Format = "N2"
        DataGridViewCellStyle11.NullValue = Nothing
        Me.Rate.DefaultCellStyle = DataGridViewCellStyle11
        Me.Rate.HeaderText = "Comission Rate"
        Me.Rate.Name = "Rate"
        Me.Rate.Width = 80
        '
        'Comission
        '
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle12.Format = "C2"
        DataGridViewCellStyle12.NullValue = Nothing
        Me.Comission.DefaultCellStyle = DataGridViewCellStyle12
        Me.Comission.HeaderText = "Broker's Comission"
        Me.Comission.Name = "Comission"
        '
        'BROKERBindingSource
        '
        Me.BROKERBindingSource.DataMember = "BROKER"
        Me.BROKERBindingSource.DataSource = Me.MapleEstInvestDataSet
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(11, 137)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 5)
        Me.Panel2.TabIndex = 5
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BrokersToolStripMenuItem, Me.InvestorsToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 70)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(850, 24)
        Me.MenuStrip1.TabIndex = 44
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BrokersToolStripMenuItem
        '
        Me.BrokersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BrokerToolStripMenuItem})
        Me.BrokersToolStripMenuItem.Name = "BrokersToolStripMenuItem"
        Me.BrokersToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.BrokersToolStripMenuItem.Text = "Brokers"
        '
        'BrokerToolStripMenuItem
        '
        Me.BrokerToolStripMenuItem.Name = "BrokerToolStripMenuItem"
        Me.BrokerToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.BrokerToolStripMenuItem.Text = "Broker's Listings"
        '
        'InvestorsToolStripMenuItem1
        '
        Me.InvestorsToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InvestorsDetailsToolStripMenuItem, Me.InvestorsPortfolioToolStripMenuItem})
        Me.InvestorsToolStripMenuItem1.Name = "InvestorsToolStripMenuItem1"
        Me.InvestorsToolStripMenuItem1.Size = New System.Drawing.Size(66, 20)
        Me.InvestorsToolStripMenuItem1.Text = "Investors"
        '
        'InvestorsDetailsToolStripMenuItem
        '
        Me.InvestorsDetailsToolStripMenuItem.Name = "InvestorsDetailsToolStripMenuItem"
        Me.InvestorsDetailsToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.InvestorsDetailsToolStripMenuItem.Text = "Investor Details"
        '
        'InvestorsPortfolioToolStripMenuItem
        '
        Me.InvestorsPortfolioToolStripMenuItem.Name = "InvestorsPortfolioToolStripMenuItem"
        Me.InvestorsPortfolioToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.InvestorsPortfolioToolStripMenuItem.Text = "Investor's Portfolios"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Panel4.Controls.Add(Me.TextBox1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 454)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(850, 30)
        Me.Panel4.TabIndex = 45
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.TextBox1.Location = New System.Drawing.Point(4, 8)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(294, 15)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "2021 © Maple Estate Investments. All Rights Reserved"
        '
        'TransactionsGrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(850, 484)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TRANSACTIONBindingNavigator)
        Me.Controls.Add(Me.TRANSACTIONDataGridView)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "TransactionsGrid"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transactions"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MapleEstInvestDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TRANSACTIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TRANSACTIONBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TRANSACTIONBindingNavigator.ResumeLayout(False)
        Me.TRANSACTIONBindingNavigator.PerformLayout()
        CType(Me.TRANSACTIONDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INVESTORBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BROKERBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BROKERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MapleEstInvestDataSet As MapleEstInvestDataSet
    Friend WithEvents TRANSACTIONBindingSource As BindingSource
    Friend WithEvents TRANSACTIONTableAdapter As MapleEstInvestDataSetTableAdapters.TRANSACTIONTableAdapter
    Friend WithEvents TableAdapterManager As MapleEstInvestDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TRANSACTIONBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents TRANSACTIONBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents BROKERTableAdapter As MapleEstInvestDataSetTableAdapters.BROKERTableAdapter
    Friend WithEvents TRANSACTIONDataGridView As DataGridView
    Friend WithEvents BROKERBindingSource As BindingSource
    Friend WithEvents INVESTORTableAdapter As MapleEstInvestDataSetTableAdapters.INVESTORTableAdapter
    Friend WithEvents INVESTORBindingSource As BindingSource
    Friend WithEvents BROKERBindingSource1 As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents Price As DataGridViewTextBoxColumn
    Friend WithEvents Rate As DataGridViewTextBoxColumn
    Friend WithEvents Comission As DataGridViewTextBoxColumn
    Friend WithEvents btnClose As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BrokersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BrokerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InvestorsToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents InvestorsDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InvestorsPortfolioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel4 As Panel
    Friend WithEvents TextBox1 As TextBox
End Class
