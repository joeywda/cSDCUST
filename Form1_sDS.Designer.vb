<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1_sDS
    Inherits Srvtools.InfoForm

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim StateItem1 As Srvtools.StateItem = New Srvtools.StateItem()
        Dim StateItem2 As Srvtools.StateItem = New Srvtools.StateItem()
        Dim StateItem3 As Srvtools.StateItem = New Srvtools.StateItem()
        Dim StateItem4 As Srvtools.StateItem = New Srvtools.StateItem()
        Dim StateItem5 As Srvtools.StateItem = New Srvtools.StateItem()
        Dim StateItem6 As Srvtools.StateItem = New Srvtools.StateItem()
        Dim StateItem7 As Srvtools.StateItem = New Srvtools.StateItem()
        Dim StateItem8 As Srvtools.StateItem = New Srvtools.StateItem()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1_sDS))
        Me.InfoNavigator1 = New Srvtools.InfoNavigator()
        Me.bindingNavigatorAbortItem = New System.Windows.Forms.ToolStripButton()
        Me.bindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.bindingNavigatorApplyItem = New System.Windows.Forms.ToolStripButton()
        Me.ibSDCUST = New Srvtools.InfoBindingSource(Me.components)
        Me.idSDUST = New Srvtools.InfoDataSet(Me.components)
        Me.bindingNavigatorCancelItem = New System.Windows.Forms.ToolStripButton()
        Me.bindingNavigatorCopyItem = New System.Windows.Forms.ToolStripButton()
        Me.bindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.bindingNavigatorEditItem = New System.Windows.Forms.ToolStripButton()
        Me.bindingNavigatorExportItem = New System.Windows.Forms.ToolStripButton()
        Me.bindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.bindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.bindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.bindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.bindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.bindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.bindingNavigatorOKItem = New System.Windows.Forms.ToolStripButton()
        Me.bindingNavigatorSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.bindingNavigatorRefreshItem = New System.Windows.Forms.ToolStripButton()
        Me.bindingNavigatorQueryItem = New System.Windows.Forms.ToolStripButton()
        Me.bindingNavigatorPrintItem = New System.Windows.Forms.ToolStripButton()
        Me.bindingNavigatorSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.bindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.bindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.InfoDataGridView1 = New Srvtools.InfoDataGridView()
        Me.GLCNODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GLCP1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GLCP2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GLCP3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GLCP4DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GLCP5DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GLCP6DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GLCP7DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GLCP8DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GLCP9DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GLCP10DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GLCP11DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GLCP12DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GLCMRKDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GLCOPDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GLCVDNODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.InfoNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.InfoNavigator1.SuspendLayout()
        CType(Me.ibSDCUST, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.idSDUST, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.InfoDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'InfoNavigator1
        '
        Me.InfoNavigator1.AbortItem = Me.bindingNavigatorAbortItem
        Me.InfoNavigator1.AddNewItem = Me.bindingNavigatorAddNewItem
        Me.InfoNavigator1.AnyQueryID = ""
        Me.InfoNavigator1.ApplyItem = Me.bindingNavigatorApplyItem
        Me.InfoNavigator1.BindingSource = Me.ibSDCUST
        Me.InfoNavigator1.CancelItem = Me.bindingNavigatorCancelItem
        Me.InfoNavigator1.CopyItem = Me.bindingNavigatorCopyItem
        Me.InfoNavigator1.CountItem = Nothing
        Me.InfoNavigator1.DeleteItem = Me.bindingNavigatorDeleteItem
        Me.InfoNavigator1.DescriptionItem = Nothing
        Me.InfoNavigator1.DetailBindingSource = Nothing
        Me.InfoNavigator1.DetailKeyField = Nothing
        Me.InfoNavigator1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
        Me.InfoNavigator1.EditItem = Me.bindingNavigatorEditItem
        Me.InfoNavigator1.ExportItem = Me.bindingNavigatorExportItem
        Me.InfoNavigator1.ForeColors = System.Drawing.Color.Empty
        Me.InfoNavigator1.GetRealRecordsCount = False
        Me.InfoNavigator1.GetServerText = True
        Me.InfoNavigator1.HideItemStates = False
        Me.InfoNavigator1.InternalQuery = True
        Me.InfoNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bindingNavigatorMoveFirstItem, Me.bindingNavigatorMovePreviousItem, Me.bindingNavigatorMoveNextItem, Me.bindingNavigatorMoveLastItem, Me.bindingNavigatorSeparator1, Me.bindingNavigatorAddNewItem, Me.bindingNavigatorDeleteItem, Me.bindingNavigatorEditItem, Me.bindingNavigatorSeparator2, Me.bindingNavigatorOKItem, Me.bindingNavigatorCancelItem, Me.bindingNavigatorApplyItem, Me.bindingNavigatorAbortItem, Me.bindingNavigatorSeparator3, Me.bindingNavigatorRefreshItem, Me.bindingNavigatorQueryItem, Me.bindingNavigatorPrintItem, Me.bindingNavigatorExportItem, Me.bindingNavigatorCopyItem, Me.bindingNavigatorSeparator4, Me.bindingNavigatorPositionItem, Me.bindingNavigatorCountItem})
        Me.InfoNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.InfoNavigator1.MasterDetailField = Nothing
        Me.InfoNavigator1.MoveFirstItem = Nothing
        Me.InfoNavigator1.MoveLastItem = Nothing
        Me.InfoNavigator1.MoveNextItem = Nothing
        Me.InfoNavigator1.MovePreviousItem = Nothing
        Me.InfoNavigator1.MultiLanguage = False
        Me.InfoNavigator1.Name = "InfoNavigator1"
        Me.InfoNavigator1.OKItem = Me.bindingNavigatorOKItem
        Me.InfoNavigator1.PositionItem = Nothing
        Me.InfoNavigator1.PreQueryCondition = CType(resources.GetObject("InfoNavigator1.PreQueryCondition"), System.Collections.Generic.List(Of String))
        Me.InfoNavigator1.PreQueryField = CType(resources.GetObject("InfoNavigator1.PreQueryField"), System.Collections.Generic.List(Of String))
        Me.InfoNavigator1.PreQueryValue = CType(resources.GetObject("InfoNavigator1.PreQueryValue"), System.Collections.Generic.List(Of String))
        Me.InfoNavigator1.PrintItem = Me.bindingNavigatorPrintItem
        Me.InfoNavigator1.QueryFont = New System.Drawing.Font("宋体", 9.0!)
        Me.InfoNavigator1.QueryKeepCondition = False
        Me.InfoNavigator1.QueryMargin = New System.Drawing.Printing.Margins(100, 30, 10, 30)
        Me.InfoNavigator1.QueryMode = Srvtools.InfoNavigator.QueryModeType.ClientQuery
        Me.InfoNavigator1.QuerySQLSend = True
        Me.InfoNavigator1.Size = New System.Drawing.Size(488, 38)
        StateItem1.Description = "Initial"
        StateItem1.EnabledControls = CType(resources.GetObject("StateItem1.EnabledControls"), System.Collections.Generic.List(Of String))
        StateItem1.EnabledControlsEdited = False
        StateItem1.StateText = "Initial"
        StateItem2.Description = "Browsed"
        StateItem2.EnabledControls = CType(resources.GetObject("StateItem2.EnabledControls"), System.Collections.Generic.List(Of String))
        StateItem2.EnabledControlsEdited = False
        StateItem2.StateText = "Browsed"
        StateItem3.Description = "Inserting"
        StateItem3.EnabledControls = CType(resources.GetObject("StateItem3.EnabledControls"), System.Collections.Generic.List(Of String))
        StateItem3.EnabledControlsEdited = False
        StateItem3.StateText = "Inserting"
        StateItem4.Description = "Editing"
        StateItem4.EnabledControls = CType(resources.GetObject("StateItem4.EnabledControls"), System.Collections.Generic.List(Of String))
        StateItem4.EnabledControlsEdited = False
        StateItem4.StateText = "Editing"
        StateItem5.Description = "Applying"
        StateItem5.EnabledControls = CType(resources.GetObject("StateItem5.EnabledControls"), System.Collections.Generic.List(Of String))
        StateItem5.EnabledControlsEdited = False
        StateItem5.StateText = "Applying"
        StateItem6.Description = "Changing"
        StateItem6.EnabledControls = CType(resources.GetObject("StateItem6.EnabledControls"), System.Collections.Generic.List(Of String))
        StateItem6.EnabledControlsEdited = False
        StateItem6.StateText = "Changing"
        StateItem7.Description = "Querying"
        StateItem7.EnabledControls = CType(resources.GetObject("StateItem7.EnabledControls"), System.Collections.Generic.List(Of String))
        StateItem7.EnabledControlsEdited = False
        StateItem7.StateText = "Querying"
        StateItem8.Description = "Printing"
        StateItem8.EnabledControls = CType(resources.GetObject("StateItem8.EnabledControls"), System.Collections.Generic.List(Of String))
        StateItem8.EnabledControlsEdited = False
        StateItem8.StateText = "Printing"
        Me.InfoNavigator1.States.Add(StateItem1)
        Me.InfoNavigator1.States.Add(StateItem2)
        Me.InfoNavigator1.States.Add(StateItem3)
        Me.InfoNavigator1.States.Add(StateItem4)
        Me.InfoNavigator1.States.Add(StateItem5)
        Me.InfoNavigator1.States.Add(StateItem6)
        Me.InfoNavigator1.States.Add(StateItem7)
        Me.InfoNavigator1.States.Add(StateItem8)
        Me.InfoNavigator1.StatusStrip = Nothing
        Me.InfoNavigator1.SureAbort = False
        Me.InfoNavigator1.SureDelete = True
        Me.InfoNavigator1.SureDeleteText = Nothing
        Me.InfoNavigator1.SureInsert = False
        Me.InfoNavigator1.SureInsertText = Nothing
        Me.InfoNavigator1.TabIndex = 0
        Me.InfoNavigator1.Text = "InfoNavigator1"
        Me.InfoNavigator1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.InfoNavigator1.ViewBindingSource = Nothing
        Me.InfoNavigator1.ViewCountItem = Me.bindingNavigatorCountItem
        Me.InfoNavigator1.ViewCountItemFormat = "of {0}"
        Me.InfoNavigator1.ViewMoveFirstItem = Me.bindingNavigatorMoveFirstItem
        Me.InfoNavigator1.ViewMoveLastItem = Me.bindingNavigatorMoveLastItem
        Me.InfoNavigator1.ViewMoveNextItem = Me.bindingNavigatorMoveNextItem
        Me.InfoNavigator1.ViewMovePreviousItem = Me.bindingNavigatorMovePreviousItem
        Me.InfoNavigator1.ViewPositionItem = Me.bindingNavigatorPositionItem
        Me.InfoNavigator1.ViewQueryItem = Me.bindingNavigatorQueryItem
        Me.InfoNavigator1.ViewRefreshItem = Me.bindingNavigatorRefreshItem
        Me.InfoNavigator1.ViewScrollProtect = False
        '
        'bindingNavigatorAbortItem
        '
        Me.bindingNavigatorAbortItem.Image = CType(resources.GetObject("bindingNavigatorAbortItem.Image"), System.Drawing.Image)
        Me.bindingNavigatorAbortItem.Name = "bindingNavigatorAbortItem"
        Me.bindingNavigatorAbortItem.Size = New System.Drawing.Size(42, 35)
        Me.bindingNavigatorAbortItem.Text = "abort"
        Me.bindingNavigatorAbortItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'bindingNavigatorAddNewItem
        '
        Me.bindingNavigatorAddNewItem.Image = CType(resources.GetObject("bindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem"
        Me.bindingNavigatorAddNewItem.Size = New System.Drawing.Size(34, 35)
        Me.bindingNavigatorAddNewItem.Text = "add"
        Me.bindingNavigatorAddNewItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'bindingNavigatorApplyItem
        '
        Me.bindingNavigatorApplyItem.Image = CType(resources.GetObject("bindingNavigatorApplyItem.Image"), System.Drawing.Image)
        Me.bindingNavigatorApplyItem.Name = "bindingNavigatorApplyItem"
        Me.bindingNavigatorApplyItem.Size = New System.Drawing.Size(43, 35)
        Me.bindingNavigatorApplyItem.Text = "apply"
        Me.bindingNavigatorApplyItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ibSDCUST
        '
        Me.ibSDCUST.AllowAdd = True
        Me.ibSDCUST.AllowDelete = True
        Me.ibSDCUST.AllowPrint = True
        Me.ibSDCUST.AllowUpdate = True
        Me.ibSDCUST.AutoApply = False
        Me.ibSDCUST.AutoApplyMaster = False
        Me.ibSDCUST.AutoDisableControl = False
        Me.ibSDCUST.AutoDisableStyle = Srvtools.InfoBindingSource.AutoDisableStyleType.Enabled
        Me.ibSDCUST.AutoRecordLock = False
        Me.ibSDCUST.AutoRecordLockMode = Srvtools.InfoBindingSource.LockMode.NoneReload
        Me.ibSDCUST.CloseProtect = False
        Me.ibSDCUST.DataMember = "_sTGLC"
        Me.ibSDCUST.DataSource = Me.idSDUST
        Me.ibSDCUST.DelayInterval = 300
        Me.ibSDCUST.DisableKeyFields = False
        Me.ibSDCUST.EnableFlag = False
        Me.ibSDCUST.FocusedControl = Nothing
        Me.ibSDCUST.OwnerComp = Nothing
        Me.ibSDCUST.RelationDelay = False
        Me.ibSDCUST.ServerModifyCache = False
        Me.ibSDCUST.text = "ibSDCUST"
        '
        'idSDUST
        '
        Me.idSDUST.Active = True
        Me.idSDUST.AlwaysClose = True
        Me.idSDUST.DataCompressed = True
        Me.idSDUST.DeleteIncomplete = True
        Me.idSDUST.LastKeyValues = Nothing
        Me.idSDUST.Locale = New System.Globalization.CultureInfo("zh-TW")
        Me.idSDUST.PacketRecords = 100
        Me.idSDUST.Position = -1
        Me.idSDUST.RemoteName = "sBASIC._sTGLC"
        Me.idSDUST.ServerModify = False
        '
        'bindingNavigatorCancelItem
        '
        Me.bindingNavigatorCancelItem.Image = CType(resources.GetObject("bindingNavigatorCancelItem.Image"), System.Drawing.Image)
        Me.bindingNavigatorCancelItem.Name = "bindingNavigatorCancelItem"
        Me.bindingNavigatorCancelItem.Size = New System.Drawing.Size(47, 35)
        Me.bindingNavigatorCancelItem.Text = "cancel"
        Me.bindingNavigatorCancelItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'bindingNavigatorCopyItem
        '
        Me.bindingNavigatorCopyItem.Image = CType(resources.GetObject("bindingNavigatorCopyItem.Image"), System.Drawing.Image)
        Me.bindingNavigatorCopyItem.Name = "bindingNavigatorCopyItem"
        Me.bindingNavigatorCopyItem.Size = New System.Drawing.Size(39, 35)
        Me.bindingNavigatorCopyItem.Text = "copy"
        Me.bindingNavigatorCopyItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'bindingNavigatorDeleteItem
        '
        Me.bindingNavigatorDeleteItem.Image = CType(resources.GetObject("bindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem"
        Me.bindingNavigatorDeleteItem.Size = New System.Drawing.Size(47, 35)
        Me.bindingNavigatorDeleteItem.Text = "delete"
        Me.bindingNavigatorDeleteItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'bindingNavigatorEditItem
        '
        Me.bindingNavigatorEditItem.Image = CType(resources.GetObject("bindingNavigatorEditItem.Image"), System.Drawing.Image)
        Me.bindingNavigatorEditItem.Name = "bindingNavigatorEditItem"
        Me.bindingNavigatorEditItem.Size = New System.Drawing.Size(33, 35)
        Me.bindingNavigatorEditItem.Text = "edit"
        Me.bindingNavigatorEditItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'bindingNavigatorExportItem
        '
        Me.bindingNavigatorExportItem.Image = CType(resources.GetObject("bindingNavigatorExportItem.Image"), System.Drawing.Image)
        Me.bindingNavigatorExportItem.Name = "bindingNavigatorExportItem"
        Me.bindingNavigatorExportItem.Size = New System.Drawing.Size(48, 35)
        Me.bindingNavigatorExportItem.Text = "export"
        Me.bindingNavigatorExportItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'bindingNavigatorMoveFirstItem
        '
        Me.bindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("bindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem"
        Me.bindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(31, 35)
        Me.bindingNavigatorMoveFirstItem.Text = "first"
        Me.bindingNavigatorMoveFirstItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'bindingNavigatorMovePreviousItem
        '
        Me.bindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("bindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem"
        Me.bindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(59, 35)
        Me.bindingNavigatorMovePreviousItem.Text = "previous"
        Me.bindingNavigatorMovePreviousItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'bindingNavigatorMoveNextItem
        '
        Me.bindingNavigatorMoveNextItem.Image = CType(resources.GetObject("bindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem"
        Me.bindingNavigatorMoveNextItem.Size = New System.Drawing.Size(35, 35)
        Me.bindingNavigatorMoveNextItem.Text = "next"
        Me.bindingNavigatorMoveNextItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'bindingNavigatorMoveLastItem
        '
        Me.bindingNavigatorMoveLastItem.Image = CType(resources.GetObject("bindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem"
        Me.bindingNavigatorMoveLastItem.Size = New System.Drawing.Size(30, 35)
        Me.bindingNavigatorMoveLastItem.Text = "last"
        Me.bindingNavigatorMoveLastItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'bindingNavigatorSeparator1
        '
        Me.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1"
        Me.bindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 38)
        '
        'bindingNavigatorSeparator2
        '
        Me.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2"
        Me.bindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 38)
        '
        'bindingNavigatorOKItem
        '
        Me.bindingNavigatorOKItem.Image = CType(resources.GetObject("bindingNavigatorOKItem.Image"), System.Drawing.Image)
        Me.bindingNavigatorOKItem.Name = "bindingNavigatorOKItem"
        Me.bindingNavigatorOKItem.Size = New System.Drawing.Size(25, 35)
        Me.bindingNavigatorOKItem.Text = "ok"
        Me.bindingNavigatorOKItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'bindingNavigatorSeparator3
        '
        Me.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3"
        Me.bindingNavigatorSeparator3.Size = New System.Drawing.Size(6, 38)
        '
        'bindingNavigatorRefreshItem
        '
        Me.bindingNavigatorRefreshItem.Image = CType(resources.GetObject("bindingNavigatorRefreshItem.Image"), System.Drawing.Image)
        Me.bindingNavigatorRefreshItem.Name = "bindingNavigatorRefreshItem"
        Me.bindingNavigatorRefreshItem.Size = New System.Drawing.Size(49, 35)
        Me.bindingNavigatorRefreshItem.Text = "refresh"
        Me.bindingNavigatorRefreshItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'bindingNavigatorQueryItem
        '
        Me.bindingNavigatorQueryItem.Image = CType(resources.GetObject("bindingNavigatorQueryItem.Image"), System.Drawing.Image)
        Me.bindingNavigatorQueryItem.Name = "bindingNavigatorQueryItem"
        Me.bindingNavigatorQueryItem.Size = New System.Drawing.Size(43, 35)
        Me.bindingNavigatorQueryItem.Text = "query"
        Me.bindingNavigatorQueryItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'bindingNavigatorPrintItem
        '
        Me.bindingNavigatorPrintItem.Image = CType(resources.GetObject("bindingNavigatorPrintItem.Image"), System.Drawing.Image)
        Me.bindingNavigatorPrintItem.Name = "bindingNavigatorPrintItem"
        Me.bindingNavigatorPrintItem.Size = New System.Drawing.Size(37, 35)
        Me.bindingNavigatorPrintItem.Text = "print"
        Me.bindingNavigatorPrintItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'bindingNavigatorSeparator4
        '
        Me.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4"
        Me.bindingNavigatorSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'bindingNavigatorPositionItem
        '
        Me.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem"
        Me.bindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.bindingNavigatorPositionItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.bindingNavigatorPositionItem.ToolTipText = "position"
        '
        'bindingNavigatorCountItem
        '
        Me.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem"
        Me.bindingNavigatorCountItem.Size = New System.Drawing.Size(37, 15)
        Me.bindingNavigatorCountItem.Text = "of {0}"
        Me.bindingNavigatorCountItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.bindingNavigatorCountItem.ToolTipText = "count"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 38)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.InfoDataGridView1)
        Me.SplitContainer1.Size = New System.Drawing.Size(488, 269)
        Me.SplitContainer1.SplitterDistance = 301
        Me.SplitContainer1.TabIndex = 1
        '
        'InfoDataGridView1
        '
        Me.InfoDataGridView1.AutoGenerateColumns = False
        Me.InfoDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.InfoDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.GLCNODataGridViewTextBoxColumn, Me.GLCP1DataGridViewTextBoxColumn, Me.GLCP2DataGridViewTextBoxColumn, Me.GLCP3DataGridViewTextBoxColumn, Me.GLCP4DataGridViewTextBoxColumn, Me.GLCP5DataGridViewTextBoxColumn, Me.GLCP6DataGridViewTextBoxColumn, Me.GLCP7DataGridViewTextBoxColumn, Me.GLCP8DataGridViewTextBoxColumn, Me.GLCP9DataGridViewTextBoxColumn, Me.GLCP10DataGridViewTextBoxColumn, Me.GLCP11DataGridViewTextBoxColumn, Me.GLCP12DataGridViewTextBoxColumn, Me.GLCMRKDataGridViewTextBoxColumn, Me.GLCOPDDataGridViewTextBoxColumn, Me.GLCVDNODataGridViewTextBoxColumn})
        Me.InfoDataGridView1.DataSource = Me.ibSDCUST
        Me.InfoDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InfoDataGridView1.EnterEnable = True
        Me.InfoDataGridView1.EnterRefValControl = False
        Me.InfoDataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.InfoDataGridView1.Name = "InfoDataGridView1"
        Me.InfoDataGridView1.RowTemplate.Height = 24
        Me.InfoDataGridView1.Size = New System.Drawing.Size(301, 269)
        Me.InfoDataGridView1.SureDelete = False
        Me.InfoDataGridView1.TabIndex = 0
        Me.InfoDataGridView1.TotalActive = True
        Me.InfoDataGridView1.TotalBackColor = System.Drawing.SystemColors.Info
        Me.InfoDataGridView1.TotalCaption = Nothing
        Me.InfoDataGridView1.TotalCaptionFont = New System.Drawing.Font("宋体", 9.0!)
        Me.InfoDataGridView1.TotalFont = New System.Drawing.Font("宋体", 9.0!)
        '
        'GLCNODataGridViewTextBoxColumn
        '
        Me.GLCNODataGridViewTextBoxColumn.DataPropertyName = "GLC_NO"
        Me.GLCNODataGridViewTextBoxColumn.HeaderText = "紗號"
        Me.GLCNODataGridViewTextBoxColumn.Name = "GLCNODataGridViewTextBoxColumn"
        '
        'GLCP1DataGridViewTextBoxColumn
        '
        Me.GLCP1DataGridViewTextBoxColumn.DataPropertyName = "GLC_P1"
        Me.GLCP1DataGridViewTextBoxColumn.HeaderText = "1月單價"
        Me.GLCP1DataGridViewTextBoxColumn.Name = "GLCP1DataGridViewTextBoxColumn"
        '
        'GLCP2DataGridViewTextBoxColumn
        '
        Me.GLCP2DataGridViewTextBoxColumn.DataPropertyName = "GLC_P2"
        Me.GLCP2DataGridViewTextBoxColumn.HeaderText = "2月單價"
        Me.GLCP2DataGridViewTextBoxColumn.Name = "GLCP2DataGridViewTextBoxColumn"
        '
        'GLCP3DataGridViewTextBoxColumn
        '
        Me.GLCP3DataGridViewTextBoxColumn.DataPropertyName = "GLC_P3"
        Me.GLCP3DataGridViewTextBoxColumn.HeaderText = "3月單價"
        Me.GLCP3DataGridViewTextBoxColumn.Name = "GLCP3DataGridViewTextBoxColumn"
        '
        'GLCP4DataGridViewTextBoxColumn
        '
        Me.GLCP4DataGridViewTextBoxColumn.DataPropertyName = "GLC_P4"
        Me.GLCP4DataGridViewTextBoxColumn.HeaderText = "4月單價"
        Me.GLCP4DataGridViewTextBoxColumn.Name = "GLCP4DataGridViewTextBoxColumn"
        '
        'GLCP5DataGridViewTextBoxColumn
        '
        Me.GLCP5DataGridViewTextBoxColumn.DataPropertyName = "GLC_P5"
        Me.GLCP5DataGridViewTextBoxColumn.HeaderText = "5月單價"
        Me.GLCP5DataGridViewTextBoxColumn.Name = "GLCP5DataGridViewTextBoxColumn"
        '
        'GLCP6DataGridViewTextBoxColumn
        '
        Me.GLCP6DataGridViewTextBoxColumn.DataPropertyName = "GLC_P6"
        Me.GLCP6DataGridViewTextBoxColumn.HeaderText = "6月單價"
        Me.GLCP6DataGridViewTextBoxColumn.Name = "GLCP6DataGridViewTextBoxColumn"
        '
        'GLCP7DataGridViewTextBoxColumn
        '
        Me.GLCP7DataGridViewTextBoxColumn.DataPropertyName = "GLC_P7"
        Me.GLCP7DataGridViewTextBoxColumn.HeaderText = "7月單價"
        Me.GLCP7DataGridViewTextBoxColumn.Name = "GLCP7DataGridViewTextBoxColumn"
        '
        'GLCP8DataGridViewTextBoxColumn
        '
        Me.GLCP8DataGridViewTextBoxColumn.DataPropertyName = "GLC_P8"
        Me.GLCP8DataGridViewTextBoxColumn.HeaderText = "8月單價"
        Me.GLCP8DataGridViewTextBoxColumn.Name = "GLCP8DataGridViewTextBoxColumn"
        '
        'GLCP9DataGridViewTextBoxColumn
        '
        Me.GLCP9DataGridViewTextBoxColumn.DataPropertyName = "GLC_P9"
        Me.GLCP9DataGridViewTextBoxColumn.HeaderText = "9月單價"
        Me.GLCP9DataGridViewTextBoxColumn.Name = "GLCP9DataGridViewTextBoxColumn"
        '
        'GLCP10DataGridViewTextBoxColumn
        '
        Me.GLCP10DataGridViewTextBoxColumn.DataPropertyName = "GLC_P10"
        Me.GLCP10DataGridViewTextBoxColumn.HeaderText = "10月單價"
        Me.GLCP10DataGridViewTextBoxColumn.Name = "GLCP10DataGridViewTextBoxColumn"
        '
        'GLCP11DataGridViewTextBoxColumn
        '
        Me.GLCP11DataGridViewTextBoxColumn.DataPropertyName = "GLC_P11"
        Me.GLCP11DataGridViewTextBoxColumn.HeaderText = "11月單價"
        Me.GLCP11DataGridViewTextBoxColumn.Name = "GLCP11DataGridViewTextBoxColumn"
        '
        'GLCP12DataGridViewTextBoxColumn
        '
        Me.GLCP12DataGridViewTextBoxColumn.DataPropertyName = "GLC_P12"
        Me.GLCP12DataGridViewTextBoxColumn.HeaderText = "12月單價"
        Me.GLCP12DataGridViewTextBoxColumn.Name = "GLCP12DataGridViewTextBoxColumn"
        '
        'GLCMRKDataGridViewTextBoxColumn
        '
        Me.GLCMRKDataGridViewTextBoxColumn.DataPropertyName = "GLC_MRK"
        Me.GLCMRKDataGridViewTextBoxColumn.HeaderText = "備註"
        Me.GLCMRKDataGridViewTextBoxColumn.Name = "GLCMRKDataGridViewTextBoxColumn"
        '
        'GLCOPDDataGridViewTextBoxColumn
        '
        Me.GLCOPDDataGridViewTextBoxColumn.DataPropertyName = "GLC_OPD"
        Me.GLCOPDDataGridViewTextBoxColumn.HeaderText = "異動日期"
        Me.GLCOPDDataGridViewTextBoxColumn.Name = "GLCOPDDataGridViewTextBoxColumn"
        '
        'GLCVDNODataGridViewTextBoxColumn
        '
        Me.GLCVDNODataGridViewTextBoxColumn.DataPropertyName = "GLC_VDNO"
        Me.GLCVDNODataGridViewTextBoxColumn.HeaderText = "詢價廠商"
        Me.GLCVDNODataGridViewTextBoxColumn.Name = "GLCVDNODataGridViewTextBoxColumn"
        '
        'Form1_sDS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.ClientSize = New System.Drawing.Size(488, 307)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.InfoNavigator1)
        Me.Name = "Form1_sDS"
        Me.Text = "J0326"
        CType(Me.InfoNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.InfoNavigator1.ResumeLayout(False)
        Me.InfoNavigator1.PerformLayout()
        CType(Me.ibSDCUST, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.idSDUST, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.InfoDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents InfoNavigator1 As Srvtools.InfoNavigator
    Friend WithEvents bindingNavigatorAbortItem As Windows.Forms.ToolStripButton
    Friend WithEvents bindingNavigatorAddNewItem As Windows.Forms.ToolStripButton
    Friend WithEvents bindingNavigatorApplyItem As Windows.Forms.ToolStripButton
    Friend WithEvents ibSDCUST As Srvtools.InfoBindingSource
    Friend WithEvents idSDUST As Srvtools.InfoDataSet
    Friend WithEvents bindingNavigatorCancelItem As Windows.Forms.ToolStripButton
    Friend WithEvents bindingNavigatorCopyItem As Windows.Forms.ToolStripButton
    Friend WithEvents bindingNavigatorDeleteItem As Windows.Forms.ToolStripButton
    Friend WithEvents bindingNavigatorEditItem As Windows.Forms.ToolStripButton
    Friend WithEvents bindingNavigatorExportItem As Windows.Forms.ToolStripButton
    Friend WithEvents bindingNavigatorMoveFirstItem As Windows.Forms.ToolStripButton
    Friend WithEvents bindingNavigatorMovePreviousItem As Windows.Forms.ToolStripButton
    Friend WithEvents bindingNavigatorMoveNextItem As Windows.Forms.ToolStripButton
    Friend WithEvents bindingNavigatorMoveLastItem As Windows.Forms.ToolStripButton
    Friend WithEvents bindingNavigatorSeparator1 As Windows.Forms.ToolStripSeparator
    Friend WithEvents bindingNavigatorSeparator2 As Windows.Forms.ToolStripSeparator
    Friend WithEvents bindingNavigatorOKItem As Windows.Forms.ToolStripButton
    Friend WithEvents bindingNavigatorSeparator3 As Windows.Forms.ToolStripSeparator
    Friend WithEvents bindingNavigatorRefreshItem As Windows.Forms.ToolStripButton
    Friend WithEvents bindingNavigatorQueryItem As Windows.Forms.ToolStripButton
    Friend WithEvents bindingNavigatorPrintItem As Windows.Forms.ToolStripButton
    Friend WithEvents bindingNavigatorSeparator4 As Windows.Forms.ToolStripSeparator
    Friend WithEvents bindingNavigatorPositionItem As Windows.Forms.ToolStripTextBox
    Friend WithEvents bindingNavigatorCountItem As Windows.Forms.ToolStripLabel
    Friend WithEvents SplitContainer1 As Windows.Forms.SplitContainer
    Friend WithEvents InfoDataGridView1 As Srvtools.InfoDataGridView
    Friend WithEvents GLCNODataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GLCP1DataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GLCP2DataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GLCP3DataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GLCP4DataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GLCP5DataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GLCP6DataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GLCP7DataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GLCP8DataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GLCP9DataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GLCP10DataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GLCP11DataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GLCP12DataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GLCMRKDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GLCOPDDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GLCVDNODataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
End Class
