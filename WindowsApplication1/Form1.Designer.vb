<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.Button2 = New System.Windows.Forms.Button
        Me.MinerProc = New System.Diagnostics.Process
        Me.Button3 = New System.Windows.Forms.Button
        Me.InfoBox = New System.Windows.Forms.ListBox
        Me.RunStatsGridView = New System.Windows.Forms.DataGridView
        Me.GPU = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.temperature = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Fan = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ETH = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DCR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.Cver = New System.Windows.Forms.ToolStripStatusLabel
        Me.Ver = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.RunTime = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel
        Me.RunStatus = New System.Windows.Forms.ToolStripStatusLabel
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.StatsPage = New System.Windows.Forms.TabPage
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DCRDelay = New System.Windows.Forms.Label
        Me.DCRRejected = New System.Windows.Forms.Label
        Me.DCRShares = New System.Windows.Forms.Label
        Me.DCRTotal = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ETHDelay = New System.Windows.Forms.Label
        Me.ETHRejectedShares = New System.Windows.Forms.Label
        Me.ETHShares = New System.Windows.Forms.Label
        Me.ETHTotal = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.MutilMinePage = New System.Windows.Forms.TabPage
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Button5 = New System.Windows.Forms.Button
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.ComboBox3 = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.DualMine = New System.Windows.Forms.CheckBox
        Me.OtherPage = New System.Windows.Forms.TabPage
        Me.ShortPage = New System.Windows.Forms.TabPage
        Me.VipPage = New System.Windows.Forms.TabPage
        Me.Button7 = New System.Windows.Forms.Button
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.Button6 = New System.Windows.Forms.Button
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Coin = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.pool = New System.Windows.Forms.ComboBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Wallet = New System.Windows.Forms.TextBox
        Me.CoreVer = New System.Windows.Forms.ComboBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.Debugtext = New System.Windows.Forms.TextBox
        Me.nodevfeeProc = New System.Diagnostics.Process
        CType(Me.RunStatsGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.StatsPage.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.MutilMinePage.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.VipPage.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(103, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "币种"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(427, 69)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(63, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "查看矿池"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "可执行|*.exe"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(13, 11)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(77, 36)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "开始挖矿"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'MinerProc
        '
        Me.MinerProc.EnableRaisingEvents = True
        Me.MinerProc.StartInfo.CreateNoWindow = True
        Me.MinerProc.StartInfo.Domain = ""
        Me.MinerProc.StartInfo.LoadUserProfile = False
        Me.MinerProc.StartInfo.Password = Nothing
        Me.MinerProc.StartInfo.StandardErrorEncoding = Nothing
        Me.MinerProc.StartInfo.StandardOutputEncoding = Nothing
        Me.MinerProc.StartInfo.UserName = ""
        Me.MinerProc.StartInfo.UseShellExecute = False
        Me.MinerProc.SynchronizingObject = Me
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.Location = New System.Drawing.Point(11, 54)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(79, 36)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "停止挖矿"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'InfoBox
        '
        Me.InfoBox.BackColor = System.Drawing.SystemColors.WindowText
        Me.InfoBox.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.InfoBox.FormattingEnabled = True
        Me.InfoBox.ItemHeight = 12
        Me.InfoBox.Items.AddRange(New Object() {"程序加载完毕！", "注意事项:", " 1.请不要将程序放在桌面或C盘根目录运行", " 2.程序路径请不要带空格", " 3.请关闭杀毒软件(包括系统自带防火墙与Windows Defender)", " 4.阉割版系统请安装微软运行库 (QQ群:840126 提供下载)"})
        Me.InfoBox.Location = New System.Drawing.Point(1, 273)
        Me.InfoBox.Name = "InfoBox"
        Me.InfoBox.Size = New System.Drawing.Size(574, 112)
        Me.InfoBox.TabIndex = 3
        '
        'RunStatsGridView
        '
        Me.RunStatsGridView.AllowUserToAddRows = False
        Me.RunStatsGridView.AllowUserToDeleteRows = False
        Me.RunStatsGridView.AllowUserToResizeColumns = False
        Me.RunStatsGridView.AllowUserToResizeRows = False
        Me.RunStatsGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.RunStatsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.RunStatsGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.GPU, Me.temperature, Me.Fan, Me.ETH, Me.DCR})
        Me.RunStatsGridView.Enabled = False
        Me.RunStatsGridView.Location = New System.Drawing.Point(0, 0)
        Me.RunStatsGridView.MultiSelect = False
        Me.RunStatsGridView.Name = "RunStatsGridView"
        Me.RunStatsGridView.ReadOnly = True
        Me.RunStatsGridView.RowHeadersVisible = False
        Me.RunStatsGridView.RowTemplate.Height = 23
        Me.RunStatsGridView.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.RunStatsGridView.Size = New System.Drawing.Size(394, 276)
        Me.RunStatsGridView.TabIndex = 5
        '
        'GPU
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.GPU.DefaultCellStyle = DataGridViewCellStyle1
        Me.GPU.HeaderText = "核心"
        Me.GPU.Name = "GPU"
        Me.GPU.ReadOnly = True
        Me.GPU.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.GPU.Width = 50
        '
        'temperature
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.temperature.DefaultCellStyle = DataGridViewCellStyle2
        Me.temperature.HeaderText = "温度"
        Me.temperature.Name = "temperature"
        Me.temperature.ReadOnly = True
        Me.temperature.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.temperature.Width = 50
        '
        'Fan
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Fan.DefaultCellStyle = DataGridViewCellStyle3
        Me.Fan.HeaderText = "风扇"
        Me.Fan.Name = "Fan"
        Me.Fan.ReadOnly = True
        Me.Fan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Fan.Width = 50
        '
        'ETH
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ETH.DefaultCellStyle = DataGridViewCellStyle4
        Me.ETH.HeaderText = "主币算力"
        Me.ETH.Name = "ETH"
        Me.ETH.ReadOnly = True
        Me.ETH.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ETH.Width = 120
        '
        'DCR
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DCR.DefaultCellStyle = DataGridViewCellStyle5
        Me.DCR.HeaderText = "辅币算力"
        Me.DCR.Name = "DCR"
        Me.DCR.ReadOnly = True
        Me.DCR.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DCR.Width = 120
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Cver, Me.Ver, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel1, Me.RunTime, Me.ToolStripStatusLabel3, Me.RunStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 510)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1267, 22)
        Me.StatusStrip1.TabIndex = 7
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Cver
        '
        Me.Cver.Name = "Cver"
        Me.Cver.Size = New System.Drawing.Size(68, 17)
        Me.Cver.Text = "当前版本："
        '
        'Ver
        '
        Me.Ver.Name = "Ver"
        Me.Ver.Size = New System.Drawing.Size(35, 17)
        Me.Ver.Text = "0.0.3"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(44, 17)
        Me.ToolStripStatusLabel2.Text = "　　　"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(68, 17)
        Me.ToolStripStatusLabel1.Text = "运行时间："
        '
        'RunTime
        '
        Me.RunTime.Name = "RunTime"
        Me.RunTime.Size = New System.Drawing.Size(80, 17)
        Me.RunTime.Text = "　　　　　　"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(68, 17)
        Me.ToolStripStatusLabel3.Text = "运行状态："
        '
        'RunStatus
        '
        Me.RunStatus.Name = "RunStatus"
        Me.RunStatus.Size = New System.Drawing.Size(80, 17)
        Me.RunStatus.Text = "程序已就绪！"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.StatsPage)
        Me.TabControl1.Controls.Add(Me.MutilMinePage)
        Me.TabControl1.Controls.Add(Me.OtherPage)
        Me.TabControl1.Controls.Add(Me.ShortPage)
        Me.TabControl1.Controls.Add(Me.VipPage)
        Me.TabControl1.Location = New System.Drawing.Point(12, 97)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(586, 413)
        Me.TabControl1.TabIndex = 8
        '
        'StatsPage
        '
        Me.StatsPage.BackColor = System.Drawing.SystemColors.Control
        Me.StatsPage.Controls.Add(Me.GroupBox2)
        Me.StatsPage.Controls.Add(Me.InfoBox)
        Me.StatsPage.Controls.Add(Me.GroupBox1)
        Me.StatsPage.Controls.Add(Me.RunStatsGridView)
        Me.StatsPage.Controls.Add(Me.GroupBox3)
        Me.StatsPage.Location = New System.Drawing.Point(4, 22)
        Me.StatsPage.Name = "StatsPage"
        Me.StatsPage.Padding = New System.Windows.Forms.Padding(3)
        Me.StatsPage.Size = New System.Drawing.Size(578, 387)
        Me.StatsPage.TabIndex = 0
        Me.StatsPage.Text = "运行状态"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DCRDelay)
        Me.GroupBox2.Controls.Add(Me.DCRRejected)
        Me.GroupBox2.Controls.Add(Me.DCRShares)
        Me.GroupBox2.Controls.Add(Me.DCRTotal)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Location = New System.Drawing.Point(400, 110)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(172, 105)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "辅币"
        '
        'DCRDelay
        '
        Me.DCRDelay.AutoSize = True
        Me.DCRDelay.Location = New System.Drawing.Point(63, 80)
        Me.DCRDelay.Name = "DCRDelay"
        Me.DCRDelay.Size = New System.Drawing.Size(0, 12)
        Me.DCRDelay.TabIndex = 8
        '
        'DCRRejected
        '
        Me.DCRRejected.AutoSize = True
        Me.DCRRejected.Location = New System.Drawing.Point(63, 59)
        Me.DCRRejected.Name = "DCRRejected"
        Me.DCRRejected.Size = New System.Drawing.Size(0, 12)
        Me.DCRRejected.TabIndex = 7
        '
        'DCRShares
        '
        Me.DCRShares.AutoSize = True
        Me.DCRShares.Location = New System.Drawing.Point(63, 40)
        Me.DCRShares.Name = "DCRShares"
        Me.DCRShares.Size = New System.Drawing.Size(0, 12)
        Me.DCRShares.TabIndex = 6
        '
        'DCRTotal
        '
        Me.DCRTotal.AutoSize = True
        Me.DCRTotal.Location = New System.Drawing.Point(63, 21)
        Me.DCRTotal.Name = "DCRTotal"
        Me.DCRTotal.Size = New System.Drawing.Size(0, 12)
        Me.DCRTotal.TabIndex = 5
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(4, 80)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(59, 12)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "矿池延迟:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(4, 59)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(59, 12)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "矿池拒绝:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(4, 40)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(59, 12)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "矿池接受:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(4, 21)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(59, 12)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "辅币算力:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ETHDelay)
        Me.GroupBox1.Controls.Add(Me.ETHRejectedShares)
        Me.GroupBox1.Controls.Add(Me.ETHShares)
        Me.GroupBox1.Controls.Add(Me.ETHTotal)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(400, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(172, 98)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "主币"
        '
        'ETHDelay
        '
        Me.ETHDelay.AutoSize = True
        Me.ETHDelay.Location = New System.Drawing.Point(63, 73)
        Me.ETHDelay.Name = "ETHDelay"
        Me.ETHDelay.Size = New System.Drawing.Size(0, 12)
        Me.ETHDelay.TabIndex = 8
        '
        'ETHRejectedShares
        '
        Me.ETHRejectedShares.AutoSize = True
        Me.ETHRejectedShares.Location = New System.Drawing.Point(63, 57)
        Me.ETHRejectedShares.Name = "ETHRejectedShares"
        Me.ETHRejectedShares.Size = New System.Drawing.Size(0, 12)
        Me.ETHRejectedShares.TabIndex = 7
        '
        'ETHShares
        '
        Me.ETHShares.AutoSize = True
        Me.ETHShares.Location = New System.Drawing.Point(63, 38)
        Me.ETHShares.Name = "ETHShares"
        Me.ETHShares.Size = New System.Drawing.Size(0, 12)
        Me.ETHShares.TabIndex = 6
        '
        'ETHTotal
        '
        Me.ETHTotal.AutoSize = True
        Me.ETHTotal.Location = New System.Drawing.Point(63, 21)
        Me.ETHTotal.Name = "ETHTotal"
        Me.ETHTotal.Size = New System.Drawing.Size(0, 12)
        Me.ETHTotal.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 12)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "矿池延迟:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 12)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "矿池拒绝:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 12)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "矿池接受:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 12)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "主币算力:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.Controls.Add(Me.Label25)
        Me.GroupBox3.Location = New System.Drawing.Point(400, 221)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(172, 55)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "CPU门罗"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(63, 33)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(0, 12)
        Me.Label20.TabIndex = 6
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(63, 16)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(0, 12)
        Me.Label21.TabIndex = 5
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(4, 33)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(59, 12)
        Me.Label24.TabIndex = 2
        Me.Label24.Text = "有效希哈:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(4, 16)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(53, 12)
        Me.Label25.TabIndex = 1
        Me.Label25.Text = "CPU算力:"
        '
        'MutilMinePage
        '
        Me.MutilMinePage.Controls.Add(Me.GroupBox5)
        Me.MutilMinePage.Controls.Add(Me.GroupBox4)
        Me.MutilMinePage.Location = New System.Drawing.Point(4, 22)
        Me.MutilMinePage.Name = "MutilMinePage"
        Me.MutilMinePage.Padding = New System.Windows.Forms.Padding(3)
        Me.MutilMinePage.Size = New System.Drawing.Size(578, 387)
        Me.MutilMinePage.TabIndex = 1
        Me.MutilMinePage.Text = "多挖设置"
        Me.MutilMinePage.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Location = New System.Drawing.Point(15, 233)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(546, 141)
        Me.GroupBox5.TabIndex = 1
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "CPU多挖"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TextBox3)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.TextBox2)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Button5)
        Me.GroupBox4.Controls.Add(Me.ComboBox2)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.ComboBox3)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.DualMine)
        Me.GroupBox4.Location = New System.Drawing.Point(15, 8)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(546, 221)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "双挖设置"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(70, 95)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(282, 21)
        Me.TextBox3.TabIndex = 19
        Me.TextBox3.Text = "20"
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(11, 98)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 12)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "辅币权重："
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(70, 54)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(467, 21)
        Me.TextBox2.TabIndex = 19
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 57)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 12)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "辅币钱包："
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(465, 14)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(73, 23)
        Me.Button5.TabIndex = 17
        Me.Button5.Text = "查看辅币矿池"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'ComboBox2
        '
        Me.ComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"水帘洞", "双优矿池"})
        Me.ComboBox2.Location = New System.Drawing.Point(306, 15)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(113, 20)
        Me.ComboBox2.TabIndex = 16
        Me.ComboBox2.Text = "水帘洞"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(225, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 12)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "辅币矿池"
        '
        'ComboBox3
        '
        Me.ComboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"SC", "DCR"})
        Me.ComboBox3.Location = New System.Drawing.Point(145, 15)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(52, 20)
        Me.ComboBox3.TabIndex = 14
        Me.ComboBox3.Text = "DCR"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(88, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 12)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "双挖币种"
        '
        'DualMine
        '
        Me.DualMine.AutoSize = True
        Me.DualMine.Location = New System.Drawing.Point(10, 17)
        Me.DualMine.Name = "DualMine"
        Me.DualMine.Size = New System.Drawing.Size(72, 16)
        Me.DualMine.TabIndex = 0
        Me.DualMine.Text = "双挖设置"
        Me.DualMine.UseVisualStyleBackColor = True
        '
        'OtherPage
        '
        Me.OtherPage.Location = New System.Drawing.Point(4, 22)
        Me.OtherPage.Name = "OtherPage"
        Me.OtherPage.Padding = New System.Windows.Forms.Padding(3)
        Me.OtherPage.Size = New System.Drawing.Size(578, 387)
        Me.OtherPage.TabIndex = 2
        Me.OtherPage.Text = "附加设置"
        Me.OtherPage.UseVisualStyleBackColor = True
        '
        'ShortPage
        '
        Me.ShortPage.Location = New System.Drawing.Point(4, 22)
        Me.ShortPage.Name = "ShortPage"
        Me.ShortPage.Padding = New System.Windows.Forms.Padding(3)
        Me.ShortPage.Size = New System.Drawing.Size(578, 387)
        Me.ShortPage.TabIndex = 3
        Me.ShortPage.Text = "便捷功能"
        Me.ShortPage.UseVisualStyleBackColor = True
        '
        'VipPage
        '
        Me.VipPage.Controls.Add(Me.Button7)
        Me.VipPage.Controls.Add(Me.LinkLabel1)
        Me.VipPage.Controls.Add(Me.CheckBox2)
        Me.VipPage.Controls.Add(Me.CheckBox1)
        Me.VipPage.Controls.Add(Me.Button6)
        Me.VipPage.Controls.Add(Me.TextBox5)
        Me.VipPage.Controls.Add(Me.Label12)
        Me.VipPage.Controls.Add(Me.TextBox4)
        Me.VipPage.Controls.Add(Me.Label11)
        Me.VipPage.Location = New System.Drawing.Point(4, 22)
        Me.VipPage.Name = "VipPage"
        Me.VipPage.Padding = New System.Windows.Forms.Padding(3)
        Me.VipPage.Size = New System.Drawing.Size(578, 387)
        Me.VipPage.TabIndex = 4
        Me.VipPage.Text = "会员登录"
        Me.VipPage.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(335, 200)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(85, 42)
        Me.Button7.TabIndex = 22
        Me.Button7.Text = "注册"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(307, 273)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(113, 12)
        Me.LinkLabel1.TabIndex = 21
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "没有帐号？注册一个"
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(309, 165)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(72, 16)
        Me.CheckBox2.TabIndex = 20
        Me.CheckBox2.Text = "自动登录"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(152, 165)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(72, 16)
        Me.CheckBox1.TabIndex = 19
        Me.CheckBox1.Text = "记住密码"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(134, 200)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(90, 42)
        Me.Button6.TabIndex = 18
        Me.Button6.Text = "登录"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(183, 123)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.PasswordChar = Global.Microsoft.VisualBasic.ChrW(65290)
        Me.TextBox5.Size = New System.Drawing.Size(237, 21)
        Me.TextBox5.TabIndex = 17
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(108, 126)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 12)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "密　　码"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(183, 81)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(237, 21)
        Me.TextBox4.TabIndex = 15
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(108, 84)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 12)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "帐　　号"
        '
        'Coin
        '
        Me.Coin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Coin.FormattingEnabled = True
        Me.Coin.Items.AddRange(New Object() {"ETC - 以太经典", "ETH - 以太坊", "ZEC - 零币", "ETZ - 以太零"})
        Me.Coin.Location = New System.Drawing.Point(138, 11)
        Me.Coin.Name = "Coin"
        Me.Coin.Size = New System.Drawing.Size(123, 20)
        Me.Coin.TabIndex = 10
        Me.Coin.Text = "ZEC - 零币"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(103, 43)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 12)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "矿池"
        '
        'pool
        '
        Me.pool.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.pool.FormattingEnabled = True
        Me.pool.Items.AddRange(New Object() {"水帘洞", "双优矿池"})
        Me.pool.Location = New System.Drawing.Point(139, 40)
        Me.pool.Name = "pool"
        Me.pool.Size = New System.Drawing.Size(123, 20)
        Me.pool.TabIndex = 12
        Me.pool.Text = "水帘洞"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(103, 74)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(29, 12)
        Me.Label18.TabIndex = 11
        Me.Label18.Text = "钱包"
        '
        'Wallet
        '
        Me.Wallet.Location = New System.Drawing.Point(138, 70)
        Me.Wallet.Name = "Wallet"
        Me.Wallet.Size = New System.Drawing.Size(282, 21)
        Me.Wallet.TabIndex = 13
        Me.Wallet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CoreVer
        '
        Me.CoreVer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CoreVer.FormattingEnabled = True
        Me.CoreVer.Items.AddRange(New Object() {"A卡12.5", "N卡11.0"})
        Me.CoreVer.Location = New System.Drawing.Point(436, 9)
        Me.CoreVer.Name = "CoreVer"
        Me.CoreVer.Size = New System.Drawing.Size(75, 20)
        Me.CoreVer.TabIndex = 15
        Me.CoreVer.Text = "A卡12.5"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(399, 12)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(29, 12)
        Me.Label19.TabIndex = 14
        Me.Label19.Text = "内核"
        '
        'ComboBox1
        '
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"水帘洞", "双优矿池"})
        Me.ComboBox1.Location = New System.Drawing.Point(313, 41)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(123, 20)
        Me.ComboBox1.TabIndex = 17
        Me.ComboBox1.Text = "水帘洞备用"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(278, 44)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(29, 12)
        Me.Label22.TabIndex = 16
        Me.Label22.Text = "备用"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(493, 73)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(41, 12)
        Me.Label23.TabIndex = 11
        Me.Label23.Text = "矿工名"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(535, 70)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(56, 21)
        Me.TextBox1.TabIndex = 13
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button4
        '
        Me.Button4.Enabled = False
        Me.Button4.Location = New System.Drawing.Point(280, 8)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(86, 23)
        Me.Button4.TabIndex = 1
        Me.Button4.Text = "切换币种"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Debugtext
        '
        Me.Debugtext.Location = New System.Drawing.Point(634, 8)
        Me.Debugtext.Multiline = True
        Me.Debugtext.Name = "Debugtext"
        Me.Debugtext.Size = New System.Drawing.Size(629, 496)
        Me.Debugtext.TabIndex = 13
        '
        'nodevfeeProc
        '
        Me.nodevfeeProc.EnableRaisingEvents = True
        Me.nodevfeeProc.StartInfo.CreateNoWindow = True
        Me.nodevfeeProc.StartInfo.Domain = ""
        Me.nodevfeeProc.StartInfo.LoadUserProfile = False
        Me.nodevfeeProc.StartInfo.Password = Nothing
        Me.nodevfeeProc.StartInfo.StandardErrorEncoding = Nothing
        Me.nodevfeeProc.StartInfo.StandardOutputEncoding = Nothing
        Me.nodevfeeProc.StartInfo.UserName = ""
        Me.nodevfeeProc.StartInfo.UseShellExecute = False
        Me.nodevfeeProc.SynchronizingObject = Me
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1267, 532)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.CoreVer)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Debugtext)
        Me.Controls.Add(Me.Wallet)
        Me.Controls.Add(Me.pool)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Coin)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "生动矿工 v0.0.3   网址:www.sd5h.com"
        CType(Me.RunStatsGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.StatsPage.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.MutilMinePage.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.VipPage.ResumeLayout(False)
        Me.VipPage.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents MinerProc As System.Diagnostics.Process
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents InfoBox As System.Windows.Forms.ListBox
    Friend WithEvents RunStatsGridView As System.Windows.Forms.DataGridView
    Friend WithEvents GPU As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents temperature As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ETH As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DCR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents StatsPage As System.Windows.Forms.TabPage
    Friend WithEvents MutilMinePage As System.Windows.Forms.TabPage
    Friend WithEvents OtherPage As System.Windows.Forms.TabPage
    Friend WithEvents ShortPage As System.Windows.Forms.TabPage
    Friend WithEvents VipPage As System.Windows.Forms.TabPage
    Friend WithEvents Coin As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ETHDelay As System.Windows.Forms.Label
    Friend WithEvents ETHRejectedShares As System.Windows.Forms.Label
    Friend WithEvents ETHShares As System.Windows.Forms.Label
    Friend WithEvents ETHTotal As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DCRDelay As System.Windows.Forms.Label
    Friend WithEvents DCRRejected As System.Windows.Forms.Label
    Friend WithEvents DCRShares As System.Windows.Forms.Label
    Friend WithEvents DCRTotal As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Wallet As System.Windows.Forms.TextBox
    Friend WithEvents pool As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CoreVer As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Cver As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Ver As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents RunTime As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents RunStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Debugtext As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DualMine As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents nodevfeeProc As System.Diagnostics.Process

End Class
