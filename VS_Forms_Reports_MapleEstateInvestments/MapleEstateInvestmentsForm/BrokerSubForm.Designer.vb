<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BrokerSubForm
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
        Dim Broker_IDLabel As System.Windows.Forms.Label
        Dim License_Status_IDLabel As System.Windows.Forms.Label
        Dim Risk_Level_IDLabel As System.Windows.Forms.Label
        Dim Hire_DateLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim Work_PhoneLabel As System.Windows.Forms.Label
        Dim Cell_PhoneLabel As System.Windows.Forms.Label
        Dim TitleLabel As System.Windows.Forms.Label
        Dim License_DateLabel As System.Windows.Forms.Label
        Dim License_ExpireLabel As System.Windows.Forms.Label
        Dim lblTotalSold As System.Windows.Forms.Label
        Dim lblTotalList As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BrokerSubForm))
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MapleEstInvestDataSet = New MapleEstateInvestmentsForm.MapleEstInvestDataSet()
        Me.BROKERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BROKERTableAdapter = New MapleEstateInvestmentsForm.MapleEstInvestDataSetTableAdapters.BROKERTableAdapter()
        Me.TableAdapterManager = New MapleEstateInvestmentsForm.MapleEstInvestDataSetTableAdapters.TableAdapterManager()
        Me.LISTINGTableAdapter = New MapleEstateInvestmentsForm.MapleEstInvestDataSetTableAdapters.LISTINGTableAdapter()
        Me.BROKERBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.BROKERBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Broker_IDComboBox = New System.Windows.Forms.ComboBox()
        Me.BROKERBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.License_Status_IDComboBox = New System.Windows.Forms.ComboBox()
        Me.LICENSESTATUSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MapleEstInvestDataSet1 = New MapleEstateInvestmentsForm.MapleEstInvestDataSet()
        Me.Risk_Level_IDComboBox = New System.Windows.Forms.ComboBox()
        Me.RISKLEVELBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Hire_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.EmailMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Work_PhoneMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Cell_PhoneMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.TitleTextBox = New System.Windows.Forms.TextBox()
        Me.License_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.License_ExpireDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.LISTINGBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LISTINGDataGridView = New System.Windows.Forms.DataGridView()
        Me.PROPERTYBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SALESSTATUSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BROKERBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.RISK_LEVELTableAdapter = New MapleEstateInvestmentsForm.MapleEstInvestDataSetTableAdapters.RISK_LEVELTableAdapter()
        Me.BROKERBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.LICENSE_STATUSTableAdapter = New MapleEstateInvestmentsForm.MapleEstInvestDataSetTableAdapters.LICENSE_STATUSTableAdapter()
        Me.PROPERTYTableAdapter = New MapleEstateInvestmentsForm.MapleEstInvestDataSetTableAdapters.PROPERTYTableAdapter()
        Me.SALES_STATUSTableAdapter = New MapleEstateInvestmentsForm.MapleEstInvestDataSetTableAdapters.SALES_STATUSTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.FillByToolStrip = New System.Windows.Forms.ToolStrip()
        Me.NameToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillByToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.lblTotSold = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BrokersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransactionsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InvestorsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InvestorsDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InvestorsPortfolioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EndDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Days_On_Market = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Broker_IDLabel = New System.Windows.Forms.Label()
        License_Status_IDLabel = New System.Windows.Forms.Label()
        Risk_Level_IDLabel = New System.Windows.Forms.Label()
        Hire_DateLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        Work_PhoneLabel = New System.Windows.Forms.Label()
        Cell_PhoneLabel = New System.Windows.Forms.Label()
        TitleLabel = New System.Windows.Forms.Label()
        License_DateLabel = New System.Windows.Forms.Label()
        License_ExpireLabel = New System.Windows.Forms.Label()
        lblTotalSold = New System.Windows.Forms.Label()
        lblTotalList = New System.Windows.Forms.Label()
        CType(Me.MapleEstInvestDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BROKERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BROKERBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BROKERBindingNavigator.SuspendLayout()
        CType(Me.BROKERBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LICENSESTATUSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MapleEstInvestDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RISKLEVELBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LISTINGBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LISTINGDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROPERTYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SALESSTATUSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BROKERBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BROKERBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillByToolStrip.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Broker_IDLabel
        '
        Broker_IDLabel.AutoSize = True
        Broker_IDLabel.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Broker_IDLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Broker_IDLabel.Location = New System.Drawing.Point(116, 129)
        Broker_IDLabel.Name = "Broker_IDLabel"
        Broker_IDLabel.Size = New System.Drawing.Size(55, 14)
        Broker_IDLabel.TabIndex = 1
        Broker_IDLabel.Text = "Broker:"
        Broker_IDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'License_Status_IDLabel
        '
        License_Status_IDLabel.AutoSize = True
        License_Status_IDLabel.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        License_Status_IDLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        License_Status_IDLabel.Location = New System.Drawing.Point(429, 159)
        License_Status_IDLabel.Name = "License_Status_IDLabel"
        License_Status_IDLabel.Size = New System.Drawing.Size(108, 14)
        License_Status_IDLabel.TabIndex = 3
        License_Status_IDLabel.Text = "License Status:"
        License_Status_IDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Risk_Level_IDLabel
        '
        Risk_Level_IDLabel.AutoSize = True
        Risk_Level_IDLabel.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Risk_Level_IDLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Risk_Level_IDLabel.Location = New System.Drawing.Point(92, 249)
        Risk_Level_IDLabel.Name = "Risk_Level_IDLabel"
        Risk_Level_IDLabel.Size = New System.Drawing.Size(79, 14)
        Risk_Level_IDLabel.TabIndex = 5
        Risk_Level_IDLabel.Text = "Risk Level:"
        Risk_Level_IDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Hire_DateLabel
        '
        Hire_DateLabel.AutoSize = True
        Hire_DateLabel.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Hire_DateLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Hire_DateLabel.Location = New System.Drawing.Point(464, 249)
        Hire_DateLabel.Name = "Hire_DateLabel"
        Hire_DateLabel.Size = New System.Drawing.Size(73, 14)
        Hire_DateLabel.TabIndex = 11
        Hire_DateLabel.Text = "Hire Date:"
        Hire_DateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmailLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        EmailLabel.Location = New System.Drawing.Point(122, 159)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(49, 14)
        EmailLabel.TabIndex = 17
        EmailLabel.Text = "Email:"
        EmailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Work_PhoneLabel
        '
        Work_PhoneLabel.AutoSize = True
        Work_PhoneLabel.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Work_PhoneLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Work_PhoneLabel.Location = New System.Drawing.Point(81, 189)
        Work_PhoneLabel.Name = "Work_PhoneLabel"
        Work_PhoneLabel.Size = New System.Drawing.Size(90, 14)
        Work_PhoneLabel.TabIndex = 19
        Work_PhoneLabel.Text = "Work Phone:"
        Work_PhoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Cell_PhoneLabel
        '
        Cell_PhoneLabel.AutoSize = True
        Cell_PhoneLabel.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cell_PhoneLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Cell_PhoneLabel.Location = New System.Drawing.Point(90, 219)
        Cell_PhoneLabel.Name = "Cell_PhoneLabel"
        Cell_PhoneLabel.Size = New System.Drawing.Size(81, 14)
        Cell_PhoneLabel.TabIndex = 21
        Cell_PhoneLabel.Text = "Cell Phone:"
        Cell_PhoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TitleLabel
        '
        TitleLabel.AutoSize = True
        TitleLabel.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TitleLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        TitleLabel.Location = New System.Drawing.Point(495, 129)
        TitleLabel.Name = "TitleLabel"
        TitleLabel.Size = New System.Drawing.Size(42, 14)
        TitleLabel.TabIndex = 23
        TitleLabel.Text = "Title:"
        TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'License_DateLabel
        '
        License_DateLabel.AutoSize = True
        License_DateLabel.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        License_DateLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        License_DateLabel.Location = New System.Drawing.Point(442, 189)
        License_DateLabel.Name = "License_DateLabel"
        License_DateLabel.Size = New System.Drawing.Size(95, 14)
        License_DateLabel.TabIndex = 29
        License_DateLabel.Text = "License Date:"
        License_DateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'License_ExpireLabel
        '
        License_ExpireLabel.AutoSize = True
        License_ExpireLabel.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        License_ExpireLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        License_ExpireLabel.Location = New System.Drawing.Point(429, 219)
        License_ExpireLabel.Name = "License_ExpireLabel"
        License_ExpireLabel.Size = New System.Drawing.Size(108, 14)
        License_ExpireLabel.TabIndex = 31
        License_ExpireLabel.Text = "License Expire:"
        License_ExpireLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalSold
        '
        lblTotalSold.AutoSize = True
        lblTotalSold.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblTotalSold.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        lblTotalSold.Location = New System.Drawing.Point(478, 330)
        lblTotalSold.Name = "lblTotalSold"
        lblTotalSold.Size = New System.Drawing.Size(78, 14)
        lblTotalSold.TabIndex = 36
        lblTotalSold.Text = "Total Sold:"
        lblTotalSold.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalList
        '
        lblTotalList.AutoSize = True
        lblTotalList.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblTotalList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        lblTotalList.Location = New System.Drawing.Point(191, 330)
        lblTotalList.Name = "lblTotalList"
        lblTotalList.Size = New System.Drawing.Size(96, 14)
        lblTotalList.TabIndex = 37
        lblTotalList.Text = "Total Listing:"
        lblTotalList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MapleEstInvestDataSet
        '
        Me.MapleEstInvestDataSet.DataSetName = "MapleEstInvestDataSet"
        Me.MapleEstInvestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BROKERBindingSource
        '
        Me.BROKERBindingSource.DataMember = "BROKER"
        Me.BROKERBindingSource.DataSource = Me.MapleEstInvestDataSet
        '
        'BROKERTableAdapter
        '
        Me.BROKERTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BROKERTableAdapter = Me.BROKERTableAdapter
        Me.TableAdapterManager.FUNDING_METHODTableAdapter = Nothing
        Me.TableAdapterManager.INVESTORTableAdapter = Nothing
        Me.TableAdapterManager.LICENSE_STATUSTableAdapter = Nothing
        Me.TableAdapterManager.LISTINGTableAdapter = Me.LISTINGTableAdapter
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
        'LISTINGTableAdapter
        '
        Me.LISTINGTableAdapter.ClearBeforeFill = True
        '
        'BROKERBindingNavigator
        '
        Me.BROKERBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BROKERBindingNavigator.AutoSize = False
        Me.BROKERBindingNavigator.BackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.BROKERBindingNavigator.BindingSource = Me.BROKERBindingSource
        Me.BROKERBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.BROKERBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BROKERBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.BROKERBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.BROKERBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.BROKERBindingNavigatorSaveItem})
        Me.BROKERBindingNavigator.Location = New System.Drawing.Point(662, 69)
        Me.BROKERBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BROKERBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BROKERBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BROKERBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BROKERBindingNavigator.Name = "BROKERBindingNavigator"
        Me.BROKERBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.BROKERBindingNavigator.Size = New System.Drawing.Size(208, 26)
        Me.BROKERBindingNavigator.TabIndex = 0
        Me.BROKERBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Enabled = False
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        Me.BindingNavigatorAddNewItem.Visible = False
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 26)
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
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        Me.BindingNavigatorDeleteItem.Visible = False
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 23)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 23)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 26)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.ForeColor = System.Drawing.Color.Black
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(57, 26)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 26)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 23)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 23)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 26)
        '
        'BROKERBindingNavigatorSaveItem
        '
        Me.BROKERBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BROKERBindingNavigatorSaveItem.Enabled = False
        Me.BROKERBindingNavigatorSaveItem.Image = CType(resources.GetObject("BROKERBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.BROKERBindingNavigatorSaveItem.Name = "BROKERBindingNavigatorSaveItem"
        Me.BROKERBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 20)
        Me.BROKERBindingNavigatorSaveItem.Text = "Save Data"
        Me.BROKERBindingNavigatorSaveItem.Visible = False
        '
        'Broker_IDComboBox
        '
        Me.Broker_IDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.BROKERBindingSource, "Broker_ID", True))
        Me.Broker_IDComboBox.DataSource = Me.BROKERBindingSource1
        Me.Broker_IDComboBox.DisplayMember = "Full_Name"
        Me.Broker_IDComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Broker_IDComboBox.FormattingEnabled = True
        Me.Broker_IDComboBox.Location = New System.Drawing.Point(177, 125)
        Me.Broker_IDComboBox.Name = "Broker_IDComboBox"
        Me.Broker_IDComboBox.Size = New System.Drawing.Size(161, 23)
        Me.Broker_IDComboBox.TabIndex = 2
        Me.Broker_IDComboBox.ValueMember = "Broker_ID"
        '
        'BROKERBindingSource1
        '
        Me.BROKERBindingSource1.DataMember = "BROKER"
        Me.BROKERBindingSource1.DataSource = Me.MapleEstInvestDataSet
        '
        'License_Status_IDComboBox
        '
        Me.License_Status_IDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.BROKERBindingSource, "License_Status_ID", True))
        Me.License_Status_IDComboBox.DataSource = Me.LICENSESTATUSBindingSource
        Me.License_Status_IDComboBox.DisplayMember = "StatusText"
        Me.License_Status_IDComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.License_Status_IDComboBox.FormattingEnabled = True
        Me.License_Status_IDComboBox.Location = New System.Drawing.Point(543, 155)
        Me.License_Status_IDComboBox.Name = "License_Status_IDComboBox"
        Me.License_Status_IDComboBox.Size = New System.Drawing.Size(161, 23)
        Me.License_Status_IDComboBox.TabIndex = 4
        Me.License_Status_IDComboBox.ValueMember = "License_Status_ID"
        '
        'LICENSESTATUSBindingSource
        '
        Me.LICENSESTATUSBindingSource.DataMember = "LICENSE_STATUS"
        Me.LICENSESTATUSBindingSource.DataSource = Me.MapleEstInvestDataSet1
        '
        'MapleEstInvestDataSet1
        '
        Me.MapleEstInvestDataSet1.DataSetName = "MapleEstInvestDataSet"
        Me.MapleEstInvestDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Risk_Level_IDComboBox
        '
        Me.Risk_Level_IDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.BROKERBindingSource, "Risk_Level_ID", True))
        Me.Risk_Level_IDComboBox.DataSource = Me.RISKLEVELBindingSource
        Me.Risk_Level_IDComboBox.DisplayMember = "Risk_level"
        Me.Risk_Level_IDComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Risk_Level_IDComboBox.FormattingEnabled = True
        Me.Risk_Level_IDComboBox.Location = New System.Drawing.Point(177, 245)
        Me.Risk_Level_IDComboBox.Name = "Risk_Level_IDComboBox"
        Me.Risk_Level_IDComboBox.Size = New System.Drawing.Size(161, 23)
        Me.Risk_Level_IDComboBox.TabIndex = 6
        Me.Risk_Level_IDComboBox.ValueMember = "Risk_Level_ID"
        '
        'RISKLEVELBindingSource
        '
        Me.RISKLEVELBindingSource.DataMember = "RISK_LEVEL"
        Me.RISKLEVELBindingSource.DataSource = Me.MapleEstInvestDataSet1
        '
        'Hire_DateDateTimePicker
        '
        Me.Hire_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BROKERBindingSource, "Hire_Date", True))
        Me.Hire_DateDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hire_DateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Hire_DateDateTimePicker.Location = New System.Drawing.Point(543, 246)
        Me.Hire_DateDateTimePicker.Name = "Hire_DateDateTimePicker"
        Me.Hire_DateDateTimePicker.Size = New System.Drawing.Size(161, 21)
        Me.Hire_DateDateTimePicker.TabIndex = 12
        '
        'EmailMaskedTextBox
        '
        Me.EmailMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BROKERBindingSource, "Email", True))
        Me.EmailMaskedTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailMaskedTextBox.Location = New System.Drawing.Point(177, 156)
        Me.EmailMaskedTextBox.Name = "EmailMaskedTextBox"
        Me.EmailMaskedTextBox.Size = New System.Drawing.Size(161, 21)
        Me.EmailMaskedTextBox.TabIndex = 18
        '
        'Work_PhoneMaskedTextBox
        '
        Me.Work_PhoneMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BROKERBindingSource, "Work_Phone", True))
        Me.Work_PhoneMaskedTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Work_PhoneMaskedTextBox.Location = New System.Drawing.Point(177, 186)
        Me.Work_PhoneMaskedTextBox.Mask = "(999) 000-0000"
        Me.Work_PhoneMaskedTextBox.Name = "Work_PhoneMaskedTextBox"
        Me.Work_PhoneMaskedTextBox.Size = New System.Drawing.Size(161, 21)
        Me.Work_PhoneMaskedTextBox.TabIndex = 20
        '
        'Cell_PhoneMaskedTextBox
        '
        Me.Cell_PhoneMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BROKERBindingSource, "Cell_Phone", True))
        Me.Cell_PhoneMaskedTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cell_PhoneMaskedTextBox.Location = New System.Drawing.Point(177, 216)
        Me.Cell_PhoneMaskedTextBox.Mask = "(999) 000-0000"
        Me.Cell_PhoneMaskedTextBox.Name = "Cell_PhoneMaskedTextBox"
        Me.Cell_PhoneMaskedTextBox.Size = New System.Drawing.Size(161, 21)
        Me.Cell_PhoneMaskedTextBox.TabIndex = 22
        '
        'TitleTextBox
        '
        Me.TitleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BROKERBindingSource, "Title", True))
        Me.TitleTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleTextBox.Location = New System.Drawing.Point(543, 126)
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.Size = New System.Drawing.Size(161, 21)
        Me.TitleTextBox.TabIndex = 24
        '
        'License_DateDateTimePicker
        '
        Me.License_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BROKERBindingSource, "License_Date", True))
        Me.License_DateDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.License_DateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.License_DateDateTimePicker.Location = New System.Drawing.Point(543, 186)
        Me.License_DateDateTimePicker.Name = "License_DateDateTimePicker"
        Me.License_DateDateTimePicker.Size = New System.Drawing.Size(161, 21)
        Me.License_DateDateTimePicker.TabIndex = 30
        '
        'License_ExpireDateTimePicker
        '
        Me.License_ExpireDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BROKERBindingSource, "License_Expire", True))
        Me.License_ExpireDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.License_ExpireDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.License_ExpireDateTimePicker.Location = New System.Drawing.Point(543, 216)
        Me.License_ExpireDateTimePicker.Name = "License_ExpireDateTimePicker"
        Me.License_ExpireDateTimePicker.Size = New System.Drawing.Size(161, 21)
        Me.License_ExpireDateTimePicker.TabIndex = 32
        '
        'LISTINGBindingSource
        '
        Me.LISTINGBindingSource.DataMember = "fk_listing_agent_id"
        Me.LISTINGBindingSource.DataSource = Me.BROKERBindingSource
        '
        'LISTINGDataGridView
        '
        Me.LISTINGDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.LISTINGDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.LISTINGDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LISTINGDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.Status, Me.DataGridViewTextBoxColumn7, Me.StartDate, Me.EndDate, Me.Days_On_Market})
        Me.LISTINGDataGridView.DataSource = Me.LISTINGBindingSource
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.LISTINGDataGridView.DefaultCellStyle = DataGridViewCellStyle18
        Me.LISTINGDataGridView.Location = New System.Drawing.Point(26, 356)
        Me.LISTINGDataGridView.Name = "LISTINGDataGridView"
        Me.LISTINGDataGridView.Size = New System.Drawing.Size(813, 158)
        Me.LISTINGDataGridView.TabIndex = 32
        '
        'PROPERTYBindingSource
        '
        Me.PROPERTYBindingSource.DataMember = "PROPERTY"
        Me.PROPERTYBindingSource.DataSource = Me.MapleEstInvestDataSet1
        '
        'SALESSTATUSBindingSource
        '
        Me.SALESSTATUSBindingSource.DataMember = "SALES_STATUS"
        Me.SALESSTATUSBindingSource.DataSource = Me.MapleEstInvestDataSet1
        '
        'BROKERBindingSource2
        '
        Me.BROKERBindingSource2.DataMember = "BROKER"
        Me.BROKERBindingSource2.DataSource = Me.MapleEstInvestDataSet
        '
        'RISK_LEVELTableAdapter
        '
        Me.RISK_LEVELTableAdapter.ClearBeforeFill = True
        '
        'BROKERBindingSource3
        '
        Me.BROKERBindingSource3.DataMember = "BROKER"
        Me.BROKERBindingSource3.DataSource = Me.MapleEstInvestDataSet1
        '
        'LICENSE_STATUSTableAdapter
        '
        Me.LICENSE_STATUSTableAdapter.ClearBeforeFill = True
        '
        'PROPERTYTableAdapter
        '
        Me.PROPERTYTableAdapter.ClearBeforeFill = True
        '
        'SALES_STATUSTableAdapter
        '
        Me.SALES_STATUSTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(864, 70)
        Me.Panel1.TabIndex = 33
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
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Bookman Old Style", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(306, 24)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(253, 22)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Broker Listing Sub-Form"
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.Location = New System.Drawing.Point(776, 12)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(76, 21)
        Me.btnClose.TabIndex = 42
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'FillByToolStrip
        '
        Me.FillByToolStrip.AutoSize = False
        Me.FillByToolStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.FillByToolStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.FillByToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.FillByToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.FillByToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NameToolStripTextBox, Me.FillByToolStripButton})
        Me.FillByToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.FillByToolStrip.Location = New System.Drawing.Point(492, 69)
        Me.FillByToolStrip.Name = "FillByToolStrip"
        Me.FillByToolStrip.Padding = New System.Windows.Forms.Padding(0)
        Me.FillByToolStrip.Size = New System.Drawing.Size(200, 26)
        Me.FillByToolStrip.TabIndex = 35
        Me.FillByToolStrip.Text = "FillByToolStrip"
        '
        'NameToolStripTextBox
        '
        Me.NameToolStripTextBox.AutoSize = False
        Me.NameToolStripTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.NameToolStripTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NameToolStripTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.NameToolStripTextBox.Margin = New System.Windows.Forms.Padding(4, 1, 1, 2)
        Me.NameToolStripTextBox.Name = "NameToolStripTextBox"
        Me.NameToolStripTextBox.Size = New System.Drawing.Size(116, 23)
        '
        'FillByToolStripButton
        '
        Me.FillByToolStripButton.AutoSize = False
        Me.FillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByToolStripButton.Name = "FillByToolStripButton"
        Me.FillByToolStripButton.Size = New System.Drawing.Size(69, 23)
        Me.FillByToolStripButton.Text = "Search"
        Me.FillByToolStripButton.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.lblCount.Location = New System.Drawing.Point(289, 330)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(0, 14)
        Me.lblCount.TabIndex = 40
        '
        'lblTotSold
        '
        Me.lblTotSold.AutoSize = True
        Me.lblTotSold.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotSold.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.lblTotSold.Location = New System.Drawing.Point(558, 330)
        Me.lblTotSold.Name = "lblTotSold"
        Me.lblTotSold.Size = New System.Drawing.Size(0, 14)
        Me.lblTotSold.TabIndex = 41
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(-1, 94)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(870, 10)
        Me.Panel2.TabIndex = 44
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(389, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 25)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "First or Last Name:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BrokersToolStripMenuItem
        '
        Me.BrokersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TransactionsToolStripMenuItem1})
        Me.BrokersToolStripMenuItem.Name = "BrokersToolStripMenuItem"
        Me.BrokersToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.BrokersToolStripMenuItem.Text = "Brokers"
        '
        'TransactionsToolStripMenuItem1
        '
        Me.TransactionsToolStripMenuItem1.Name = "TransactionsToolStripMenuItem1"
        Me.TransactionsToolStripMenuItem1.Size = New System.Drawing.Size(139, 22)
        Me.TransactionsToolStripMenuItem1.Text = "Transactions"
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
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BrokersToolStripMenuItem, Me.InvestorsToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 70)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(864, 24)
        Me.MenuStrip1.TabIndex = 43
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Panel4.Controls.Add(Me.TextBox1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 526)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(864, 30)
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
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Listing_ID"
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridViewTextBoxColumn1.HeaderText = "Listing ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Property_ID"
        Me.DataGridViewTextBoxColumn2.DataSource = Me.PROPERTYBindingSource
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridViewTextBoxColumn2.DisplayMember = "Address"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Property"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn2.ValueMember = "Property_ID"
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'Status
        '
        Me.Status.DataPropertyName = "Sale_Status_ID"
        Me.Status.DataSource = Me.SALESSTATUSBindingSource
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Status.DefaultCellStyle = DataGridViewCellStyle13
        Me.Status.DisplayMember = "SaleStatus"
        Me.Status.HeaderText = "Sale Status"
        Me.Status.Name = "Status"
        Me.Status.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Status.ValueMember = "Sales_Status_ID"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Asking_Price"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle14.Format = "C2"
        DataGridViewCellStyle14.NullValue = Nothing
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle14
        Me.DataGridViewTextBoxColumn7.HeaderText = "Asking Price"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'StartDate
        '
        Me.StartDate.DataPropertyName = "Begin_List_Date"
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black
        Me.StartDate.DefaultCellStyle = DataGridViewCellStyle15
        Me.StartDate.HeaderText = "Begin List Date"
        Me.StartDate.Name = "StartDate"
        '
        'EndDate
        '
        Me.EndDate.DataPropertyName = "End_List_Date"
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black
        Me.EndDate.DefaultCellStyle = DataGridViewCellStyle16
        Me.EndDate.HeaderText = "End List Date"
        Me.EndDate.Name = "EndDate"
        '
        'Days_On_Market
        '
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Days_On_Market.DefaultCellStyle = DataGridViewCellStyle17
        Me.Days_On_Market.HeaderText = "Days On Market"
        Me.Days_On_Market.Name = "Days_On_Market"
        '
        'BrokerSubForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(864, 556)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.BROKERBindingNavigator)
        Me.Controls.Add(Me.FillByToolStrip)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.lblTotSold)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(lblTotalList)
        Me.Controls.Add(lblTotalSold)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LISTINGDataGridView)
        Me.Controls.Add(Broker_IDLabel)
        Me.Controls.Add(Me.Broker_IDComboBox)
        Me.Controls.Add(License_Status_IDLabel)
        Me.Controls.Add(Me.License_Status_IDComboBox)
        Me.Controls.Add(Risk_Level_IDLabel)
        Me.Controls.Add(Me.Risk_Level_IDComboBox)
        Me.Controls.Add(Hire_DateLabel)
        Me.Controls.Add(Me.Hire_DateDateTimePicker)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailMaskedTextBox)
        Me.Controls.Add(Work_PhoneLabel)
        Me.Controls.Add(Me.Work_PhoneMaskedTextBox)
        Me.Controls.Add(Cell_PhoneLabel)
        Me.Controls.Add(Me.Cell_PhoneMaskedTextBox)
        Me.Controls.Add(TitleLabel)
        Me.Controls.Add(Me.TitleTextBox)
        Me.Controls.Add(License_DateLabel)
        Me.Controls.Add(Me.License_DateDateTimePicker)
        Me.Controls.Add(License_ExpireLabel)
        Me.Controls.Add(Me.License_ExpireDateTimePicker)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "BrokerSubForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Broker SubForm"
        CType(Me.MapleEstInvestDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BROKERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BROKERBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BROKERBindingNavigator.ResumeLayout(False)
        Me.BROKERBindingNavigator.PerformLayout()
        CType(Me.BROKERBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LICENSESTATUSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MapleEstInvestDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RISKLEVELBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LISTINGBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LISTINGDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROPERTYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SALESSTATUSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BROKERBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BROKERBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillByToolStrip.ResumeLayout(False)
        Me.FillByToolStrip.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MapleEstInvestDataSet As MapleEstInvestDataSet
    Friend WithEvents BROKERBindingSource As BindingSource
    Friend WithEvents BROKERTableAdapter As MapleEstInvestDataSetTableAdapters.BROKERTableAdapter
    Friend WithEvents TableAdapterManager As MapleEstInvestDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BROKERBindingNavigator As BindingNavigator
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
    Friend WithEvents BROKERBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Broker_IDComboBox As ComboBox
    Friend WithEvents License_Status_IDComboBox As ComboBox
    Friend WithEvents Risk_Level_IDComboBox As ComboBox
    Friend WithEvents Hire_DateDateTimePicker As DateTimePicker
    Friend WithEvents EmailMaskedTextBox As MaskedTextBox
    Friend WithEvents Work_PhoneMaskedTextBox As MaskedTextBox
    Friend WithEvents Cell_PhoneMaskedTextBox As MaskedTextBox
    Friend WithEvents TitleTextBox As TextBox
    Friend WithEvents License_DateDateTimePicker As DateTimePicker
    Friend WithEvents License_ExpireDateTimePicker As DateTimePicker
    Friend WithEvents LISTINGTableAdapter As MapleEstInvestDataSetTableAdapters.LISTINGTableAdapter
    Friend WithEvents LISTINGBindingSource As BindingSource
    Friend WithEvents LISTINGDataGridView As DataGridView
    Friend WithEvents BROKERBindingSource1 As BindingSource
    Friend WithEvents BROKERBindingSource2 As BindingSource
    Friend WithEvents MapleEstInvestDataSet1 As MapleEstInvestDataSet
    Friend WithEvents RISKLEVELBindingSource As BindingSource
    Friend WithEvents RISK_LEVELTableAdapter As MapleEstInvestDataSetTableAdapters.RISK_LEVELTableAdapter
    Friend WithEvents BROKERBindingSource3 As BindingSource
    Friend WithEvents LICENSESTATUSBindingSource As BindingSource
    Friend WithEvents LICENSE_STATUSTableAdapter As MapleEstInvestDataSetTableAdapters.LICENSE_STATUSTableAdapter
    Friend WithEvents PROPERTYBindingSource As BindingSource
    Friend WithEvents PROPERTYTableAdapter As MapleEstInvestDataSetTableAdapters.PROPERTYTableAdapter
    Friend WithEvents SALESSTATUSBindingSource As BindingSource
    Friend WithEvents SALES_STATUSTableAdapter As MapleEstInvestDataSetTableAdapters.SALES_STATUSTableAdapter
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents FillByToolStrip As ToolStrip
    Friend WithEvents NameToolStripTextBox As ToolStripTextBox
    Friend WithEvents FillByToolStripButton As ToolStripButton
    Friend WithEvents lblCount As Label
    Friend WithEvents lblTotSold As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents BrokersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransactionsToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents InvestorsToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents InvestorsDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InvestorsPortfolioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Panel4 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewComboBoxColumn
    Friend WithEvents Status As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents StartDate As DataGridViewTextBoxColumn
    Friend WithEvents EndDate As DataGridViewTextBoxColumn
    Friend WithEvents Days_On_Market As DataGridViewTextBoxColumn
End Class
