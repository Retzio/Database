<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InvestorDetail
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
        Dim Investor_IDLabel As System.Windows.Forms.Label
        Dim Investor_Risk_LevelLabel As System.Windows.Forms.Label
        Dim Credit_ScoreLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim Cell_PhoneLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim CityLabel As System.Windows.Forms.Label
        Dim StateLabel As System.Windows.Forms.Label
        Dim ZipcodeLabel As System.Windows.Forms.Label
        Dim Social_Security_NumberLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InvestorDetail))
        Me.InvestorDetails = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.MapleEstInvestDataSet = New MapleEstateInvestmentsForm.MapleEstInvestDataSet()
        Me.INVESTORBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.INVESTORTableAdapter = New MapleEstateInvestmentsForm.MapleEstInvestDataSetTableAdapters.INVESTORTableAdapter()
        Me.TableAdapterManager = New MapleEstateInvestmentsForm.MapleEstInvestDataSetTableAdapters.TableAdapterManager()
        Me.RISK_LEVELTableAdapter = New MapleEstateInvestmentsForm.MapleEstInvestDataSetTableAdapters.RISK_LEVELTableAdapter()
        Me.RISKLEVELBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.INVESTORBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.INVESTORBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.cboInvestor = New System.Windows.Forms.ComboBox()
        Me.INVESTORBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Investor_Risk_LevelComboBox = New System.Windows.Forms.ComboBox()
        Me.RISKLEVELBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Credit_ScoreTextBox = New System.Windows.Forms.TextBox()
        Me.EmailMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Cell_PhoneMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.StateTextBox = New System.Windows.Forms.TextBox()
        Me.ZipcodeMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Social_Security_NumberMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.INVESTORBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.FillByToolStrip = New System.Windows.Forms.ToolStrip()
        Me.NameToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillByToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BrokersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BrokerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmTransaction = New System.Windows.Forms.ToolStripMenuItem()
        Me.InvestorsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InvestorsPortfolioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Investor_IDLabel = New System.Windows.Forms.Label()
        Investor_Risk_LevelLabel = New System.Windows.Forms.Label()
        Credit_ScoreLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        Cell_PhoneLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        CityLabel = New System.Windows.Forms.Label()
        StateLabel = New System.Windows.Forms.Label()
        ZipcodeLabel = New System.Windows.Forms.Label()
        Social_Security_NumberLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MapleEstInvestDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INVESTORBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RISKLEVELBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INVESTORBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.INVESTORBindingNavigator.SuspendLayout()
        CType(Me.INVESTORBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RISKLEVELBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INVESTORBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillByToolStrip.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Investor_IDLabel
        '
        Investor_IDLabel.AutoSize = True
        Investor_IDLabel.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Investor_IDLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Investor_IDLabel.Location = New System.Drawing.Point(128, 153)
        Investor_IDLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Investor_IDLabel.Name = "Investor_IDLabel"
        Investor_IDLabel.Size = New System.Drawing.Size(67, 14)
        Investor_IDLabel.TabIndex = 3
        Investor_IDLabel.Text = "Investor:"
        '
        'Investor_Risk_LevelLabel
        '
        Investor_Risk_LevelLabel.AutoSize = True
        Investor_Risk_LevelLabel.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Investor_Risk_LevelLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Investor_Risk_LevelLabel.Location = New System.Drawing.Point(56, 195)
        Investor_Risk_LevelLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Investor_Risk_LevelLabel.Name = "Investor_Risk_LevelLabel"
        Investor_Risk_LevelLabel.Size = New System.Drawing.Size(139, 14)
        Investor_Risk_LevelLabel.TabIndex = 5
        Investor_Risk_LevelLabel.Text = "Investor Risk Level:"
        '
        'Credit_ScoreLabel
        '
        Credit_ScoreLabel.AutoSize = True
        Credit_ScoreLabel.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Credit_ScoreLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Credit_ScoreLabel.Location = New System.Drawing.Point(103, 319)
        Credit_ScoreLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Credit_ScoreLabel.Name = "Credit_ScoreLabel"
        Credit_ScoreLabel.Size = New System.Drawing.Size(92, 14)
        Credit_ScoreLabel.TabIndex = 11
        Credit_ScoreLabel.Text = "Credit Score:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmailLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        EmailLabel.Location = New System.Drawing.Point(146, 235)
        EmailLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(49, 14)
        EmailLabel.TabIndex = 13
        EmailLabel.Text = "Email:"
        '
        'Cell_PhoneLabel
        '
        Cell_PhoneLabel.AutoSize = True
        Cell_PhoneLabel.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cell_PhoneLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Cell_PhoneLabel.Location = New System.Drawing.Point(114, 277)
        Cell_PhoneLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Cell_PhoneLabel.Name = "Cell_PhoneLabel"
        Cell_PhoneLabel.Size = New System.Drawing.Size(81, 14)
        Cell_PhoneLabel.TabIndex = 15
        Cell_PhoneLabel.Text = "Cell Phone:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AddressLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        AddressLabel.Location = New System.Drawing.Point(483, 153)
        AddressLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(63, 14)
        AddressLabel.TabIndex = 17
        AddressLabel.Text = "Address:"
        '
        'CityLabel
        '
        CityLabel.AutoSize = True
        CityLabel.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CityLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        CityLabel.Location = New System.Drawing.Point(508, 195)
        CityLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New System.Drawing.Size(38, 14)
        CityLabel.TabIndex = 19
        CityLabel.Text = "City:"
        '
        'StateLabel
        '
        StateLabel.AutoSize = True
        StateLabel.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StateLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        StateLabel.Location = New System.Drawing.Point(501, 235)
        StateLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        StateLabel.Name = "StateLabel"
        StateLabel.Size = New System.Drawing.Size(45, 14)
        StateLabel.TabIndex = 21
        StateLabel.Text = "State:"
        '
        'ZipcodeLabel
        '
        ZipcodeLabel.AutoSize = True
        ZipcodeLabel.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ZipcodeLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        ZipcodeLabel.Location = New System.Drawing.Point(484, 277)
        ZipcodeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ZipcodeLabel.Name = "ZipcodeLabel"
        ZipcodeLabel.Size = New System.Drawing.Size(62, 14)
        ZipcodeLabel.TabIndex = 23
        ZipcodeLabel.Text = "Zipcode:"
        '
        'Social_Security_NumberLabel
        '
        Social_Security_NumberLabel.AutoSize = True
        Social_Security_NumberLabel.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Social_Security_NumberLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Social_Security_NumberLabel.Location = New System.Drawing.Point(31, 361)
        Social_Security_NumberLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Social_Security_NumberLabel.Name = "Social_Security_NumberLabel"
        Social_Security_NumberLabel.Size = New System.Drawing.Size(164, 14)
        Social_Security_NumberLabel.TabIndex = 25
        Social_Security_NumberLabel.Text = "Social Security Number:"
        '
        'InvestorDetails
        '
        Me.InvestorDetails.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.InvestorDetails.AutoSize = True
        Me.InvestorDetails.Font = New System.Drawing.Font("Bookman Old Style", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InvestorDetails.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.InvestorDetails.Location = New System.Drawing.Point(319, 24)
        Me.InvestorDetails.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.InvestorDetails.Name = "InvestorDetails"
        Me.InvestorDetails.Size = New System.Drawing.Size(214, 22)
        Me.InvestorDetails.TabIndex = 2
        Me.InvestorDetails.Text = "Investor Detail Form"
        Me.InvestorDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.InvestorDetails)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(852, 70)
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
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.Location = New System.Drawing.Point(764, 12)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(76, 21)
        Me.btnClose.TabIndex = 28
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
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
        Me.TableAdapterManager.RISK_LEVELTableAdapter = Me.RISK_LEVELTableAdapter
        Me.TableAdapterManager.SALES_STATUSTableAdapter = Nothing
        Me.TableAdapterManager.TRANSACTION_TYPETableAdapter = Nothing
        Me.TableAdapterManager.TRANSACTIONTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = MapleEstateInvestmentsForm.MapleEstInvestDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'RISK_LEVELTableAdapter
        '
        Me.RISK_LEVELTableAdapter.ClearBeforeFill = True
        '
        'RISKLEVELBindingSource
        '
        Me.RISKLEVELBindingSource.DataMember = "RISK_LEVEL"
        Me.RISKLEVELBindingSource.DataSource = Me.MapleEstInvestDataSet
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.ForeColor = System.Drawing.Color.Black
        Me.BindingNavigatorCountItem.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 26)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Enabled = False
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 23)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        Me.BindingNavigatorAddNewItem.Visible = False
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Enabled = False
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 23)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        Me.BindingNavigatorDeleteItem.Visible = False
        '
        'INVESTORBindingNavigatorSaveItem
        '
        Me.INVESTORBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.INVESTORBindingNavigatorSaveItem.Enabled = False
        Me.INVESTORBindingNavigatorSaveItem.Image = CType(resources.GetObject("INVESTORBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.INVESTORBindingNavigatorSaveItem.Name = "INVESTORBindingNavigatorSaveItem"
        Me.INVESTORBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.INVESTORBindingNavigatorSaveItem.Text = "Save Data"
        Me.INVESTORBindingNavigatorSaveItem.Visible = False
        '
        'INVESTORBindingNavigator
        '
        Me.INVESTORBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.INVESTORBindingNavigator.AutoSize = False
        Me.INVESTORBindingNavigator.BackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.INVESTORBindingNavigator.BindingSource = Me.INVESTORBindingSource
        Me.INVESTORBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.INVESTORBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.INVESTORBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.INVESTORBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.INVESTORBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.INVESTORBindingNavigatorSaveItem})
        Me.INVESTORBindingNavigator.Location = New System.Drawing.Point(652, 69)
        Me.INVESTORBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.INVESTORBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.INVESTORBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.INVESTORBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.INVESTORBindingNavigator.Name = "INVESTORBindingNavigator"
        Me.INVESTORBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.INVESTORBindingNavigator.Size = New System.Drawing.Size(307, 26)
        Me.INVESTORBindingNavigator.TabIndex = 3
        Me.INVESTORBindingNavigator.Text = "BindingNavigator1"
        '
        'cboInvestor
        '
        Me.cboInvestor.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.INVESTORBindingSource, "Investor_ID", True))
        Me.cboInvestor.DataSource = Me.INVESTORBindingSource2
        Me.cboInvestor.DisplayMember = "Investor_Full_Name"
        Me.cboInvestor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboInvestor.FormattingEnabled = True
        Me.cboInvestor.Location = New System.Drawing.Point(205, 149)
        Me.cboInvestor.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cboInvestor.Name = "cboInvestor"
        Me.cboInvestor.Size = New System.Drawing.Size(201, 23)
        Me.cboInvestor.TabIndex = 4
        Me.cboInvestor.ValueMember = "Investor_ID"
        '
        'INVESTORBindingSource2
        '
        Me.INVESTORBindingSource2.DataMember = "INVESTOR"
        Me.INVESTORBindingSource2.DataSource = Me.MapleEstInvestDataSet
        '
        'Investor_Risk_LevelComboBox
        '
        Me.Investor_Risk_LevelComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.INVESTORBindingSource, "Investor_Risk_Level", True))
        Me.Investor_Risk_LevelComboBox.DataSource = Me.RISKLEVELBindingSource1
        Me.Investor_Risk_LevelComboBox.DisplayMember = "Risk_level"
        Me.Investor_Risk_LevelComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Investor_Risk_LevelComboBox.FormattingEnabled = True
        Me.Investor_Risk_LevelComboBox.Location = New System.Drawing.Point(205, 191)
        Me.Investor_Risk_LevelComboBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Investor_Risk_LevelComboBox.Name = "Investor_Risk_LevelComboBox"
        Me.Investor_Risk_LevelComboBox.Size = New System.Drawing.Size(201, 23)
        Me.Investor_Risk_LevelComboBox.TabIndex = 6
        Me.Investor_Risk_LevelComboBox.ValueMember = "Risk_Level_ID"
        '
        'RISKLEVELBindingSource1
        '
        Me.RISKLEVELBindingSource1.DataMember = "RISK_LEVEL"
        Me.RISKLEVELBindingSource1.DataSource = Me.MapleEstInvestDataSet
        '
        'Credit_ScoreTextBox
        '
        Me.Credit_ScoreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.INVESTORBindingSource, "Credit_Score", True))
        Me.Credit_ScoreTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Credit_ScoreTextBox.Location = New System.Drawing.Point(205, 317)
        Me.Credit_ScoreTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Credit_ScoreTextBox.Name = "Credit_ScoreTextBox"
        Me.Credit_ScoreTextBox.Size = New System.Drawing.Size(201, 21)
        Me.Credit_ScoreTextBox.TabIndex = 12
        '
        'EmailMaskedTextBox
        '
        Me.EmailMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.INVESTORBindingSource, "Email", True))
        Me.EmailMaskedTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailMaskedTextBox.Location = New System.Drawing.Point(205, 232)
        Me.EmailMaskedTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.EmailMaskedTextBox.Name = "EmailMaskedTextBox"
        Me.EmailMaskedTextBox.Size = New System.Drawing.Size(201, 21)
        Me.EmailMaskedTextBox.TabIndex = 14
        '
        'Cell_PhoneMaskedTextBox
        '
        Me.Cell_PhoneMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.INVESTORBindingSource, "Cell_Phone", True))
        Me.Cell_PhoneMaskedTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cell_PhoneMaskedTextBox.Location = New System.Drawing.Point(205, 274)
        Me.Cell_PhoneMaskedTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Cell_PhoneMaskedTextBox.Mask = "(999) 000-0000"
        Me.Cell_PhoneMaskedTextBox.Name = "Cell_PhoneMaskedTextBox"
        Me.Cell_PhoneMaskedTextBox.Size = New System.Drawing.Size(201, 21)
        Me.Cell_PhoneMaskedTextBox.TabIndex = 16
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.INVESTORBindingSource, "Address", True))
        Me.AddressTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressTextBox.Location = New System.Drawing.Point(548, 150)
        Me.AddressTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(201, 21)
        Me.AddressTextBox.TabIndex = 18
        '
        'CityTextBox
        '
        Me.CityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.INVESTORBindingSource, "City", True))
        Me.CityTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CityTextBox.Location = New System.Drawing.Point(548, 192)
        Me.CityTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(201, 21)
        Me.CityTextBox.TabIndex = 20
        '
        'StateTextBox
        '
        Me.StateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.INVESTORBindingSource, "State", True))
        Me.StateTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StateTextBox.Location = New System.Drawing.Point(548, 232)
        Me.StateTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(201, 21)
        Me.StateTextBox.TabIndex = 22
        '
        'ZipcodeMaskedTextBox
        '
        Me.ZipcodeMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.INVESTORBindingSource, "Zipcode", True))
        Me.ZipcodeMaskedTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ZipcodeMaskedTextBox.Location = New System.Drawing.Point(548, 274)
        Me.ZipcodeMaskedTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ZipcodeMaskedTextBox.Mask = "00000-9999"
        Me.ZipcodeMaskedTextBox.Name = "ZipcodeMaskedTextBox"
        Me.ZipcodeMaskedTextBox.Size = New System.Drawing.Size(201, 21)
        Me.ZipcodeMaskedTextBox.TabIndex = 24
        '
        'Social_Security_NumberMaskedTextBox
        '
        Me.Social_Security_NumberMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.INVESTORBindingSource, "Social_Security_Number", True))
        Me.Social_Security_NumberMaskedTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Social_Security_NumberMaskedTextBox.Location = New System.Drawing.Point(205, 358)
        Me.Social_Security_NumberMaskedTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Social_Security_NumberMaskedTextBox.Mask = "000-00-0000"
        Me.Social_Security_NumberMaskedTextBox.Name = "Social_Security_NumberMaskedTextBox"
        Me.Social_Security_NumberMaskedTextBox.Size = New System.Drawing.Size(201, 21)
        Me.Social_Security_NumberMaskedTextBox.TabIndex = 26
        '
        'INVESTORBindingSource1
        '
        Me.INVESTORBindingSource1.DataMember = "INVESTOR"
        Me.INVESTORBindingSource1.DataSource = Me.MapleEstInvestDataSet
        '
        'FillByToolStrip
        '
        Me.FillByToolStrip.AutoSize = False
        Me.FillByToolStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.FillByToolStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.FillByToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.FillByToolStrip.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FillByToolStrip.GripMargin = New System.Windows.Forms.Padding(0)
        Me.FillByToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.FillByToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NameToolStripTextBox, Me.FillByToolStripButton})
        Me.FillByToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.FillByToolStrip.Location = New System.Drawing.Point(483, 69)
        Me.FillByToolStrip.Name = "FillByToolStrip"
        Me.FillByToolStrip.Padding = New System.Windows.Forms.Padding(0)
        Me.FillByToolStrip.Size = New System.Drawing.Size(200, 26)
        Me.FillByToolStrip.Stretch = True
        Me.FillByToolStrip.TabIndex = 27
        Me.FillByToolStrip.Text = "FillByToolStrip"
        '
        'NameToolStripTextBox
        '
        Me.NameToolStripTextBox.AutoSize = False
        Me.NameToolStripTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.NameToolStripTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NameToolStripTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.NameToolStripTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.NameToolStripTextBox.Margin = New System.Windows.Forms.Padding(4, 1, 1, 2)
        Me.NameToolStripTextBox.Name = "NameToolStripTextBox"
        Me.NameToolStripTextBox.Size = New System.Drawing.Size(116, 23)
        '
        'FillByToolStripButton
        '
        Me.FillByToolStripButton.AutoSize = False
        Me.FillByToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.FillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByToolStripButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FillByToolStripButton.ForeColor = System.Drawing.Color.Black
        Me.FillByToolStripButton.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.FillByToolStripButton.Name = "FillByToolStripButton"
        Me.FillByToolStripButton.Size = New System.Drawing.Size(69, 23)
        Me.FillByToolStripButton.Text = "Search"
        Me.FillByToolStripButton.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(-9, 94)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(870, 10)
        Me.Panel2.TabIndex = 45
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(380, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 25)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "First or Last Name:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BrokersToolStripMenuItem, Me.InvestorsToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 70)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(852, 24)
        Me.MenuStrip1.TabIndex = 47
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BrokersToolStripMenuItem
        '
        Me.BrokersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BrokerToolStripMenuItem, Me.tsmTransaction})
        Me.BrokersToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText
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
        'tsmTransaction
        '
        Me.tsmTransaction.Name = "tsmTransaction"
        Me.tsmTransaction.Size = New System.Drawing.Size(159, 22)
        Me.tsmTransaction.Text = "Transactions"
        '
        'InvestorsToolStripMenuItem1
        '
        Me.InvestorsToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InvestorsPortfolioToolStripMenuItem})
        Me.InvestorsToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.InvestorsToolStripMenuItem1.Name = "InvestorsToolStripMenuItem1"
        Me.InvestorsToolStripMenuItem1.Size = New System.Drawing.Size(66, 20)
        Me.InvestorsToolStripMenuItem1.Text = "Investors"
        '
        'InvestorsPortfolioToolStripMenuItem
        '
        Me.InvestorsPortfolioToolStripMenuItem.Name = "InvestorsPortfolioToolStripMenuItem"
        Me.InvestorsPortfolioToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.InvestorsPortfolioToolStripMenuItem.Text = "Investor's Portfolios"
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
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Panel4.Controls.Add(Me.TextBox1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 402)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(852, 30)
        Me.Panel4.TabIndex = 49
        '
        'InvestorDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(852, 432)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.INVESTORBindingNavigator)
        Me.Controls.Add(Me.FillByToolStrip)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Investor_IDLabel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.cboInvestor)
        Me.Controls.Add(Investor_Risk_LevelLabel)
        Me.Controls.Add(Me.Investor_Risk_LevelComboBox)
        Me.Controls.Add(Credit_ScoreLabel)
        Me.Controls.Add(Me.Credit_ScoreTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailMaskedTextBox)
        Me.Controls.Add(Cell_PhoneLabel)
        Me.Controls.Add(Me.Cell_PhoneMaskedTextBox)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(CityLabel)
        Me.Controls.Add(Me.CityTextBox)
        Me.Controls.Add(StateLabel)
        Me.Controls.Add(Me.StateTextBox)
        Me.Controls.Add(ZipcodeLabel)
        Me.Controls.Add(Me.ZipcodeMaskedTextBox)
        Me.Controls.Add(Social_Security_NumberLabel)
        Me.Controls.Add(Me.Social_Security_NumberMaskedTextBox)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "InvestorDetail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Investor"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MapleEstInvestDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INVESTORBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RISKLEVELBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INVESTORBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.INVESTORBindingNavigator.ResumeLayout(False)
        Me.INVESTORBindingNavigator.PerformLayout()
        CType(Me.INVESTORBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RISKLEVELBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INVESTORBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillByToolStrip.ResumeLayout(False)
        Me.FillByToolStrip.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents InvestorDetails As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MapleEstInvestDataSet As MapleEstInvestDataSet
    Friend WithEvents INVESTORBindingSource As BindingSource
    Friend WithEvents INVESTORTableAdapter As MapleEstInvestDataSetTableAdapters.INVESTORTableAdapter
    Friend WithEvents TableAdapterManager As MapleEstInvestDataSetTableAdapters.TableAdapterManager
    Friend WithEvents RISK_LEVELTableAdapter As MapleEstInvestDataSetTableAdapters.RISK_LEVELTableAdapter
    Friend WithEvents RISKLEVELBindingSource As BindingSource
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents INVESTORBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents INVESTORBindingNavigator As BindingNavigator
    Friend WithEvents cboInvestor As ComboBox
    Friend WithEvents Investor_Risk_LevelComboBox As ComboBox
    Friend WithEvents Credit_ScoreTextBox As TextBox
    Friend WithEvents EmailMaskedTextBox As MaskedTextBox
    Friend WithEvents Cell_PhoneMaskedTextBox As MaskedTextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents StateTextBox As TextBox
    Friend WithEvents ZipcodeMaskedTextBox As MaskedTextBox
    Friend WithEvents Social_Security_NumberMaskedTextBox As MaskedTextBox
    Friend WithEvents INVESTORBindingSource1 As BindingSource
    Friend WithEvents INVESTORBindingSource2 As BindingSource
    Friend WithEvents RISKLEVELBindingSource1 As BindingSource
    Friend WithEvents FillByToolStrip As ToolStrip
    Friend WithEvents NameToolStripTextBox As ToolStripTextBox
    Friend WithEvents FillByToolStripButton As ToolStripButton
    Friend WithEvents btnClose As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BrokersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BrokerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InvestorsToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents InvestorsPortfolioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsmTransaction As ToolStripMenuItem
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel4 As Panel
End Class
