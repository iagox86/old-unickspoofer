Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmMain
	Inherits System.Windows.Forms.Form
#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
		If m_vb6FormDefInstance Is Nothing Then
			If m_InitializingDefInstance Then
				m_vb6FormDefInstance = Me
			Else
				Try 
					'For the start-up form, the first instance created is the default instance.
					If System.Reflection.Assembly.GetExecutingAssembly.EntryPoint.DeclaringType Is Me.GetType Then
						m_vb6FormDefInstance = Me
					End If
				Catch
				End Try
			End If
		End If
		'This call is required by the Windows Form Designer.
		InitializeComponent()
	End Sub
	'Form overrides dispose to clean up the component list.
	Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents tmrUpdate As System.Windows.Forms.Timer
	Public WithEvents CD As AxMSComDlg.AxCommonDialog
	Public WithEvents GetProcessHandles As System.Windows.Forms.Timer
	Public WithEvents SB As AxMSComctlLib.AxStatusBar
	Public WithEvents picSystemTray As System.Windows.Forms.PictureBox
	Public WithEvents scPregame As AxRichTextLib.AxRichTextBox
	Public WithEvents scIngame As AxRichTextLib.AxRichTextBox
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Frame5 As System.Windows.Forms.GroupBox
	Public WithEvents scName As AxRichTextLib.AxRichTextBox
	Public WithEvents Frame4 As System.Windows.Forms.GroupBox
	Public WithEvents scClearColors As System.Windows.Forms.Button
	Public WithEvents scGreen As System.Windows.Forms.Button
	Public WithEvents scRed As System.Windows.Forms.Button
	Public WithEvents scGrey As System.Windows.Forms.Button
	Public WithEvents scWhite As System.Windows.Forms.Button
	Public WithEvents scYellow As System.Windows.Forms.Button
	Public WithEvents scNormal As System.Windows.Forms.Button
	Public WithEvents Frame3 As System.Windows.Forms.GroupBox
	Public WithEvents scAlignment As System.Windows.Forms.ComboBox
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents _Frame_1 As System.Windows.Forms.GroupBox
	Public WithEvents chkUseColors As System.Windows.Forms.CheckBox
	Public WithEvents frame14 As System.Windows.Forms.GroupBox
	Public WithEvents wc3Name As System.Windows.Forms.TextBox
	Public WithEvents frame13 As System.Windows.Forms.GroupBox
	Public WithEvents tmrUsage As System.Windows.Forms.Timer
	Public WithEvents cmdCheat As System.Windows.Forms.Button
	Public WithEvents cmdBrown As System.Windows.Forms.Button
	Public WithEvents cmdDGreen As System.Windows.Forms.Button
	Public WithEvents cmdLBlue As System.Windows.Forms.Button
	Public WithEvents cmdGrey As System.Windows.Forms.Button
	Public WithEvents cmdWhite As System.Windows.Forms.Button
	Public WithEvents cmdPink As System.Windows.Forms.Button
	Public WithEvents cmdGreen As System.Windows.Forms.Button
	Public WithEvents cmdOrange As System.Windows.Forms.Button
	Public WithEvents cmdYellow As System.Windows.Forms.Button
	Public WithEvents cmdBlack As System.Windows.Forms.Button
	Public WithEvents cmdPurple As System.Windows.Forms.Button
	Public WithEvents cmdTeal As System.Windows.Forms.Button
	Public WithEvents cmdBlue As System.Windows.Forms.Button
	Public WithEvents cmdRed As System.Windows.Forms.Button
	Public WithEvents txtGreen As System.Windows.Forms.TextBox
	Public WithEvents txtBlue As System.Windows.Forms.TextBox
	Public WithEvents txtRed As System.Windows.Forms.TextBox
	Public WithEvents wsUsage As AxMSWinsockLib.AxWinsock
	Public WithEvents Line1 As System.Windows.Forms.Label
	Public WithEvents wc3Preview As System.Windows.Forms.Label
	Public WithEvents Label8 As System.Windows.Forms.Label
	Public WithEvents fraWC3Colors As System.Windows.Forms.GroupBox
	Public WithEvents _Frame_4 As System.Windows.Forms.GroupBox
	Public WithEvents wc2Pregame As AxRichTextLib.AxRichTextBox
	Public WithEvents wc2Ingame As AxRichTextLib.AxRichTextBox
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Frame12 As System.Windows.Forms.GroupBox
	Public WithEvents wc2Name As AxRichTextLib.AxRichTextBox
	Public WithEvents Frame11 As System.Windows.Forms.GroupBox
	Public WithEvents wc2ClearColors As System.Windows.Forms.Button
	Public WithEvents wc2Grey As System.Windows.Forms.Button
	Public WithEvents wc2Black As System.Windows.Forms.Button
	Public WithEvents wc2White As System.Windows.Forms.Button
	Public WithEvents wc2Red As System.Windows.Forms.Button
	Public WithEvents wc2Normal As System.Windows.Forms.Button
	Public WithEvents Frame10 As System.Windows.Forms.GroupBox
	Public WithEvents _Frame_3 As System.Windows.Forms.GroupBox
	Public WithEvents bwAlignment As System.Windows.Forms.ComboBox
	Public WithEvents Frame8 As System.Windows.Forms.GroupBox
	Public WithEvents bwNormal As System.Windows.Forms.Button
	Public WithEvents bwYellow As System.Windows.Forms.Button
	Public WithEvents bwWhite As System.Windows.Forms.Button
	Public WithEvents bwGrey As System.Windows.Forms.Button
	Public WithEvents bwRed As System.Windows.Forms.Button
	Public WithEvents bwGreen As System.Windows.Forms.Button
	Public WithEvents bwClearColors As System.Windows.Forms.Button
	Public WithEvents Frame7 As System.Windows.Forms.GroupBox
	Public WithEvents bwName As AxRichTextLib.AxRichTextBox
	Public WithEvents Frame6 As System.Windows.Forms.GroupBox
	Public WithEvents bwPregame As AxRichTextLib.AxRichTextBox
	Public WithEvents bwIngame As AxRichTextLib.AxRichTextBox
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents _Frame_2 As System.Windows.Forms.GroupBox
	Public WithEvents Label9 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Frame As Microsoft.VisualBasic.Compatibility.VB6.GroupBoxArray
	Public WithEvents mnuFileExit As System.Windows.Forms.MenuItem
	Public WithEvents mnuFile As System.Windows.Forms.MenuItem
	Public WithEvents mnuHelpAbout As System.Windows.Forms.MenuItem
	Public WithEvents mnuHelp As System.Windows.Forms.MenuItem
	Public WithEvents mnuSTRestore As System.Windows.Forms.MenuItem
	Public WithEvents mnuSTExit As System.Windows.Forms.MenuItem
	Public WithEvents mnuST As System.Windows.Forms.MenuItem
	Public MainMenu1 As System.Windows.Forms.MainMenu
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMain))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.ToolTip1.Active = True
		Me.tmrUpdate = New System.Windows.Forms.Timer(components)
		Me.CD = New AxMSComDlg.AxCommonDialog
		Me.GetProcessHandles = New System.Windows.Forms.Timer(components)
		Me.SB = New AxMSComctlLib.AxStatusBar
		Me._Frame_1 = New System.Windows.Forms.GroupBox
		Me.picSystemTray = New System.Windows.Forms.PictureBox
		Me.Frame5 = New System.Windows.Forms.GroupBox
		Me.scPregame = New AxRichTextLib.AxRichTextBox
		Me.scIngame = New AxRichTextLib.AxRichTextBox
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.Frame4 = New System.Windows.Forms.GroupBox
		Me.scName = New AxRichTextLib.AxRichTextBox
		Me.Frame3 = New System.Windows.Forms.GroupBox
		Me.scClearColors = New System.Windows.Forms.Button
		Me.scGreen = New System.Windows.Forms.Button
		Me.scRed = New System.Windows.Forms.Button
		Me.scGrey = New System.Windows.Forms.Button
		Me.scWhite = New System.Windows.Forms.Button
		Me.scYellow = New System.Windows.Forms.Button
		Me.scNormal = New System.Windows.Forms.Button
		Me.Frame2 = New System.Windows.Forms.GroupBox
		Me.scAlignment = New System.Windows.Forms.ComboBox
		Me._Frame_4 = New System.Windows.Forms.GroupBox
		Me.frame14 = New System.Windows.Forms.GroupBox
		Me.chkUseColors = New System.Windows.Forms.CheckBox
		Me.frame13 = New System.Windows.Forms.GroupBox
		Me.wc3Name = New System.Windows.Forms.TextBox
		Me.fraWC3Colors = New System.Windows.Forms.GroupBox
		Me.tmrUsage = New System.Windows.Forms.Timer(components)
		Me.cmdCheat = New System.Windows.Forms.Button
		Me.cmdBrown = New System.Windows.Forms.Button
		Me.cmdDGreen = New System.Windows.Forms.Button
		Me.cmdLBlue = New System.Windows.Forms.Button
		Me.cmdGrey = New System.Windows.Forms.Button
		Me.cmdWhite = New System.Windows.Forms.Button
		Me.cmdPink = New System.Windows.Forms.Button
		Me.cmdGreen = New System.Windows.Forms.Button
		Me.cmdOrange = New System.Windows.Forms.Button
		Me.cmdYellow = New System.Windows.Forms.Button
		Me.cmdBlack = New System.Windows.Forms.Button
		Me.cmdPurple = New System.Windows.Forms.Button
		Me.cmdTeal = New System.Windows.Forms.Button
		Me.cmdBlue = New System.Windows.Forms.Button
		Me.cmdRed = New System.Windows.Forms.Button
		Me.txtGreen = New System.Windows.Forms.TextBox
		Me.txtBlue = New System.Windows.Forms.TextBox
		Me.txtRed = New System.Windows.Forms.TextBox
		Me.wsUsage = New AxMSWinsockLib.AxWinsock
		Me.Line1 = New System.Windows.Forms.Label
		Me.wc3Preview = New System.Windows.Forms.Label
		Me.Label8 = New System.Windows.Forms.Label
		Me._Frame_3 = New System.Windows.Forms.GroupBox
		Me.Frame12 = New System.Windows.Forms.GroupBox
		Me.wc2Pregame = New AxRichTextLib.AxRichTextBox
		Me.wc2Ingame = New AxRichTextLib.AxRichTextBox
		Me.Label7 = New System.Windows.Forms.Label
		Me.Label6 = New System.Windows.Forms.Label
		Me.Frame11 = New System.Windows.Forms.GroupBox
		Me.wc2Name = New AxRichTextLib.AxRichTextBox
		Me.Frame10 = New System.Windows.Forms.GroupBox
		Me.wc2ClearColors = New System.Windows.Forms.Button
		Me.wc2Grey = New System.Windows.Forms.Button
		Me.wc2Black = New System.Windows.Forms.Button
		Me.wc2White = New System.Windows.Forms.Button
		Me.wc2Red = New System.Windows.Forms.Button
		Me.wc2Normal = New System.Windows.Forms.Button
		Me._Frame_2 = New System.Windows.Forms.GroupBox
		Me.Frame8 = New System.Windows.Forms.GroupBox
		Me.bwAlignment = New System.Windows.Forms.ComboBox
		Me.Frame7 = New System.Windows.Forms.GroupBox
		Me.bwNormal = New System.Windows.Forms.Button
		Me.bwYellow = New System.Windows.Forms.Button
		Me.bwWhite = New System.Windows.Forms.Button
		Me.bwGrey = New System.Windows.Forms.Button
		Me.bwRed = New System.Windows.Forms.Button
		Me.bwGreen = New System.Windows.Forms.Button
		Me.bwClearColors = New System.Windows.Forms.Button
		Me.Frame6 = New System.Windows.Forms.GroupBox
		Me.bwName = New AxRichTextLib.AxRichTextBox
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.bwPregame = New AxRichTextLib.AxRichTextBox
		Me.bwIngame = New AxRichTextLib.AxRichTextBox
		Me.Label5 = New System.Windows.Forms.Label
		Me.Label4 = New System.Windows.Forms.Label
		Me.Label9 = New System.Windows.Forms.Label
		Me.Label3 = New System.Windows.Forms.Label
		Me.Frame = New Microsoft.VisualBasic.Compatibility.VB6.GroupBoxArray(components)
		Me.MainMenu1 = New System.Windows.Forms.MainMenu
		Me.mnuFile = New System.Windows.Forms.MenuItem
		Me.mnuFileExit = New System.Windows.Forms.MenuItem
		Me.mnuHelp = New System.Windows.Forms.MenuItem
		Me.mnuHelpAbout = New System.Windows.Forms.MenuItem
		Me.mnuST = New System.Windows.Forms.MenuItem
		Me.mnuSTRestore = New System.Windows.Forms.MenuItem
		Me.mnuSTExit = New System.Windows.Forms.MenuItem
		CType(Me.CD, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.SB, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.scPregame, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.scIngame, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.scName, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.wsUsage, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.wc2Pregame, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.wc2Ingame, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.wc2Name, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.bwName, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.bwPregame, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.bwIngame, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Frame, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Text = "Universal Namespoofer - by iago[vL]"
		Me.ClientSize = New System.Drawing.Size(477, 168)
		Me.Location = New System.Drawing.Point(10, 48)
		Me.Icon = CType(resources.GetObject("frmMain.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
		Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.MinimizeBox = True
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = True
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmMain"
		Me.tmrUpdate.Interval = 1000
		Me.tmrUpdate.Enabled = True
		CD.OcxState = CType(resources.GetObject("CD.OcxState"), System.Windows.Forms.AxHost.State)
		Me.CD.Location = New System.Drawing.Point(456, 48)
		Me.CD.Name = "CD"
		Me.GetProcessHandles.Interval = 5000
		Me.GetProcessHandles.Enabled = True
		SB.OcxState = CType(resources.GetObject("SB.OcxState"), System.Windows.Forms.AxHost.State)
		Me.SB.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.SB.Size = New System.Drawing.Size(477, 25)
		Me.SB.Location = New System.Drawing.Point(0, 143)
		Me.SB.TabIndex = 1
		Me.SB.Name = "SB"
		Me._Frame_1.Text = "Starcraft"
		Me._Frame_1.Size = New System.Drawing.Size(473, 137)
		Me._Frame_1.Location = New System.Drawing.Point(0, 0)
		Me._Frame_1.TabIndex = 2
		Me._Frame_1.Visible = False
		Me._Frame_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._Frame_1.BackColor = System.Drawing.SystemColors.Control
		Me._Frame_1.Enabled = True
		Me._Frame_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._Frame_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Frame_1.Name = "_Frame_1"
		Me.picSystemTray.Size = New System.Drawing.Size(49, 49)
		Me.picSystemTray.Location = New System.Drawing.Point(120, 40)
		Me.picSystemTray.Image = CType(resources.GetObject("picSystemTray.Image"), System.Drawing.Image)
		Me.picSystemTray.TabIndex = 79
		Me.picSystemTray.Visible = False
		Me.picSystemTray.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.picSystemTray.Dock = System.Windows.Forms.DockStyle.None
		Me.picSystemTray.BackColor = System.Drawing.SystemColors.Control
		Me.picSystemTray.CausesValidation = True
		Me.picSystemTray.Enabled = True
		Me.picSystemTray.ForeColor = System.Drawing.SystemColors.ControlText
		Me.picSystemTray.Cursor = System.Windows.Forms.Cursors.Default
		Me.picSystemTray.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.picSystemTray.TabStop = True
		Me.picSystemTray.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me.picSystemTray.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.picSystemTray.Name = "picSystemTray"
		Me.Frame5.Text = "Previews:"
		Me.Frame5.Size = New System.Drawing.Size(129, 113)
		Me.Frame5.Location = New System.Drawing.Point(336, 16)
		Me.Frame5.TabIndex = 13
		Me.Frame5.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame5.BackColor = System.Drawing.SystemColors.Control
		Me.Frame5.Enabled = True
		Me.Frame5.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame5.Visible = True
		Me.Frame5.Name = "Frame5"
		scPregame.OcxState = CType(resources.GetObject("scPregame.OcxState"), System.Windows.Forms.AxHost.State)
		Me.scPregame.Size = New System.Drawing.Size(113, 25)
		Me.scPregame.Location = New System.Drawing.Point(8, 32)
		Me.scPregame.TabIndex = 14
		Me.scPregame.Name = "scPregame"
		scIngame.OcxState = CType(resources.GetObject("scIngame.OcxState"), System.Windows.Forms.AxHost.State)
		Me.scIngame.Size = New System.Drawing.Size(113, 25)
		Me.scIngame.Location = New System.Drawing.Point(8, 72)
		Me.scIngame.TabIndex = 15
		Me.scIngame.Name = "scIngame"
		Me.Label2.Text = "In game"
		Me.Label2.Size = New System.Drawing.Size(113, 17)
		Me.Label2.Location = New System.Drawing.Point(8, 56)
		Me.Label2.TabIndex = 17
		Me.Label2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label2.BackColor = System.Drawing.SystemColors.Control
		Me.Label2.Enabled = True
		Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label2.UseMnemonic = True
		Me.Label2.Visible = True
		Me.Label2.AutoSize = False
		Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label2.Name = "Label2"
		Me.Label1.Text = "Pregame"
		Me.Label1.Size = New System.Drawing.Size(113, 17)
		Me.Label1.Location = New System.Drawing.Point(8, 16)
		Me.Label1.TabIndex = 16
		Me.Label1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label1.BackColor = System.Drawing.SystemColors.Control
		Me.Label1.Enabled = True
		Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label1.UseMnemonic = True
		Me.Label1.Visible = True
		Me.Label1.AutoSize = False
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label1.Name = "Label1"
		Me.Frame4.Text = "Name"
		Me.Frame4.Size = New System.Drawing.Size(129, 57)
		Me.Frame4.Location = New System.Drawing.Point(8, 72)
		Me.Frame4.TabIndex = 12
		Me.Frame4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame4.BackColor = System.Drawing.SystemColors.Control
		Me.Frame4.Enabled = True
		Me.Frame4.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame4.Visible = True
		Me.Frame4.Name = "Frame4"
		scName.OcxState = CType(resources.GetObject("scName.OcxState"), System.Windows.Forms.AxHost.State)
		Me.scName.Size = New System.Drawing.Size(113, 25)
		Me.scName.Location = New System.Drawing.Point(8, 16)
		Me.scName.TabIndex = 0
		Me.scName.Name = "scName"
		Me.Frame3.Text = "Insert Color"
		Me.Frame3.Size = New System.Drawing.Size(185, 113)
		Me.Frame3.Location = New System.Drawing.Point(144, 16)
		Me.Frame3.TabIndex = 5
		Me.Frame3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame3.BackColor = System.Drawing.SystemColors.Control
		Me.Frame3.Enabled = True
		Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame3.Visible = True
		Me.Frame3.Name = "Frame3"
		Me.scClearColors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.scClearColors.Text = "Clear Colors"
		Me.scClearColors.Size = New System.Drawing.Size(169, 17)
		Me.scClearColors.Location = New System.Drawing.Point(8, 88)
		Me.scClearColors.TabIndex = 18
		Me.scClearColors.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.scClearColors.BackColor = System.Drawing.SystemColors.Control
		Me.scClearColors.CausesValidation = True
		Me.scClearColors.Enabled = True
		Me.scClearColors.ForeColor = System.Drawing.SystemColors.ControlText
		Me.scClearColors.Cursor = System.Windows.Forms.Cursors.Default
		Me.scClearColors.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.scClearColors.TabStop = True
		Me.scClearColors.Name = "scClearColors"
		Me.scGreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.scGreen.Text = "Red/Green"
		Me.scGreen.Size = New System.Drawing.Size(81, 17)
		Me.scGreen.Location = New System.Drawing.Point(96, 64)
		Me.scGreen.TabIndex = 11
		Me.scGreen.TabStop = False
		Me.scGreen.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.scGreen.BackColor = System.Drawing.SystemColors.Control
		Me.scGreen.CausesValidation = True
		Me.scGreen.Enabled = True
		Me.scGreen.ForeColor = System.Drawing.SystemColors.ControlText
		Me.scGreen.Cursor = System.Windows.Forms.Cursors.Default
		Me.scGreen.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.scGreen.Name = "scGreen"
		Me.scRed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.scRed.Text = "White/Red"
		Me.scRed.Size = New System.Drawing.Size(81, 17)
		Me.scRed.Location = New System.Drawing.Point(96, 40)
		Me.scRed.TabIndex = 10
		Me.scRed.TabStop = False
		Me.scRed.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.scRed.BackColor = System.Drawing.SystemColors.Control
		Me.scRed.CausesValidation = True
		Me.scRed.Enabled = True
		Me.scRed.ForeColor = System.Drawing.SystemColors.ControlText
		Me.scRed.Cursor = System.Windows.Forms.Cursors.Default
		Me.scRed.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.scRed.Name = "scRed"
		Me.scGrey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.scGrey.Text = "Grey"
		Me.scGrey.Size = New System.Drawing.Size(81, 17)
		Me.scGrey.Location = New System.Drawing.Point(96, 16)
		Me.scGrey.TabIndex = 9
		Me.scGrey.TabStop = False
		Me.scGrey.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.scGrey.BackColor = System.Drawing.SystemColors.Control
		Me.scGrey.CausesValidation = True
		Me.scGrey.Enabled = True
		Me.scGrey.ForeColor = System.Drawing.SystemColors.ControlText
		Me.scGrey.Cursor = System.Windows.Forms.Cursors.Default
		Me.scGrey.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.scGrey.Name = "scGrey"
		Me.scWhite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.scWhite.Text = "LGreen/White"
		Me.scWhite.Size = New System.Drawing.Size(81, 17)
		Me.scWhite.Location = New System.Drawing.Point(8, 64)
		Me.scWhite.TabIndex = 8
		Me.scWhite.TabStop = False
		Me.scWhite.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.scWhite.BackColor = System.Drawing.SystemColors.Control
		Me.scWhite.CausesValidation = True
		Me.scWhite.Enabled = True
		Me.scWhite.ForeColor = System.Drawing.SystemColors.ControlText
		Me.scWhite.Cursor = System.Windows.Forms.Cursors.Default
		Me.scWhite.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.scWhite.Name = "scWhite"
		Me.scYellow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.scYellow.Text = "Normal/Yellow"
		Me.scYellow.Size = New System.Drawing.Size(81, 17)
		Me.scYellow.Location = New System.Drawing.Point(8, 40)
		Me.scYellow.TabIndex = 7
		Me.scYellow.TabStop = False
		Me.scYellow.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.scYellow.BackColor = System.Drawing.SystemColors.Control
		Me.scYellow.CausesValidation = True
		Me.scYellow.Enabled = True
		Me.scYellow.ForeColor = System.Drawing.SystemColors.ControlText
		Me.scYellow.Cursor = System.Windows.Forms.Cursors.Default
		Me.scYellow.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.scYellow.Name = "scYellow"
		Me.scNormal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.scNormal.Text = "LBlue/Normal"
		Me.scNormal.Size = New System.Drawing.Size(81, 17)
		Me.scNormal.Location = New System.Drawing.Point(8, 16)
		Me.scNormal.TabIndex = 6
		Me.scNormal.TabStop = False
		Me.scNormal.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.scNormal.BackColor = System.Drawing.SystemColors.Control
		Me.scNormal.CausesValidation = True
		Me.scNormal.Enabled = True
		Me.scNormal.ForeColor = System.Drawing.SystemColors.ControlText
		Me.scNormal.Cursor = System.Windows.Forms.Cursors.Default
		Me.scNormal.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.scNormal.Name = "scNormal"
		Me.Frame2.Text = "Alignment"
		Me.Frame2.Size = New System.Drawing.Size(129, 49)
		Me.Frame2.Location = New System.Drawing.Point(8, 16)
		Me.Frame2.TabIndex = 3
		Me.Frame2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame2.BackColor = System.Drawing.SystemColors.Control
		Me.Frame2.Enabled = True
		Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame2.Visible = True
		Me.Frame2.Name = "Frame2"
		Me.scAlignment.Size = New System.Drawing.Size(113, 21)
		Me.scAlignment.Location = New System.Drawing.Point(8, 16)
		Me.scAlignment.Items.AddRange(New Object(){"Left", "Right", "Center"})
		Me.scAlignment.TabIndex = 4
		Me.scAlignment.TabStop = False
		Me.scAlignment.Text = "Left"
		Me.scAlignment.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.scAlignment.BackColor = System.Drawing.SystemColors.Window
		Me.scAlignment.CausesValidation = True
		Me.scAlignment.Enabled = True
		Me.scAlignment.ForeColor = System.Drawing.SystemColors.WindowText
		Me.scAlignment.IntegralHeight = True
		Me.scAlignment.Cursor = System.Windows.Forms.Cursors.Default
		Me.scAlignment.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.scAlignment.Sorted = False
		Me.scAlignment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.scAlignment.Visible = True
		Me.scAlignment.Name = "scAlignment"
		Me._Frame_4.Text = "Warcraft III"
		Me._Frame_4.Size = New System.Drawing.Size(473, 137)
		Me._Frame_4.Location = New System.Drawing.Point(0, 0)
		Me._Frame_4.TabIndex = 53
		Me._Frame_4.Visible = False
		Me._Frame_4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._Frame_4.BackColor = System.Drawing.SystemColors.Control
		Me._Frame_4.Enabled = True
		Me._Frame_4.ForeColor = System.Drawing.SystemColors.ControlText
		Me._Frame_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Frame_4.Name = "_Frame_4"
		Me.frame14.Size = New System.Drawing.Size(169, 57)
		Me.frame14.Location = New System.Drawing.Point(296, 72)
		Me.frame14.TabIndex = 75
		Me.frame14.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.frame14.BackColor = System.Drawing.SystemColors.Control
		Me.frame14.Enabled = True
		Me.frame14.ForeColor = System.Drawing.SystemColors.ControlText
		Me.frame14.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.frame14.Visible = True
		Me.frame14.Name = "frame14"
		Me.chkUseColors.Text = "Use Colors? (shorter allowed name)"
		Me.chkUseColors.Size = New System.Drawing.Size(153, 25)
		Me.chkUseColors.Location = New System.Drawing.Point(8, 16)
		Me.chkUseColors.TabIndex = 76
		Me.chkUseColors.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkUseColors.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkUseColors.BackColor = System.Drawing.SystemColors.Control
		Me.chkUseColors.CausesValidation = True
		Me.chkUseColors.Enabled = True
		Me.chkUseColors.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkUseColors.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkUseColors.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkUseColors.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkUseColors.TabStop = True
		Me.chkUseColors.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkUseColors.Visible = True
		Me.chkUseColors.Name = "chkUseColors"
		Me.frame13.Text = "Name"
		Me.frame13.Size = New System.Drawing.Size(169, 57)
		Me.frame13.Location = New System.Drawing.Point(296, 16)
		Me.frame13.TabIndex = 74
		Me.frame13.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.frame13.BackColor = System.Drawing.SystemColors.Control
		Me.frame13.Enabled = True
		Me.frame13.ForeColor = System.Drawing.SystemColors.ControlText
		Me.frame13.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.frame13.Visible = True
		Me.frame13.Name = "frame13"
		Me.wc3Name.AutoSize = False
		Me.wc3Name.Size = New System.Drawing.Size(153, 19)
		Me.wc3Name.Location = New System.Drawing.Point(8, 16)
		Me.wc3Name.Maxlength = 16
		Me.wc3Name.TabIndex = 77
		Me.wc3Name.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.wc3Name.AcceptsReturn = True
		Me.wc3Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.wc3Name.BackColor = System.Drawing.SystemColors.Window
		Me.wc3Name.CausesValidation = True
		Me.wc3Name.Enabled = True
		Me.wc3Name.ForeColor = System.Drawing.SystemColors.WindowText
		Me.wc3Name.HideSelection = True
		Me.wc3Name.ReadOnly = False
		Me.wc3Name.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.wc3Name.MultiLine = False
		Me.wc3Name.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.wc3Name.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.wc3Name.TabStop = True
		Me.wc3Name.Visible = True
		Me.wc3Name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.wc3Name.Name = "wc3Name"
		Me.fraWC3Colors.Text = "Colors"
		Me.fraWC3Colors.Enabled = False
		Me.fraWC3Colors.Size = New System.Drawing.Size(281, 113)
		Me.fraWC3Colors.Location = New System.Drawing.Point(8, 16)
		Me.fraWC3Colors.TabIndex = 54
		Me.fraWC3Colors.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraWC3Colors.BackColor = System.Drawing.SystemColors.Control
		Me.fraWC3Colors.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraWC3Colors.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraWC3Colors.Visible = True
		Me.fraWC3Colors.Name = "fraWC3Colors"
		Me.tmrUsage.Interval = 60000
		Me.tmrUsage.Enabled = True
		Me.cmdCheat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdCheat.Text = "Cheat..."
		Me.cmdCheat.Enabled = False
		Me.cmdCheat.Size = New System.Drawing.Size(49, 17)
		Me.cmdCheat.Location = New System.Drawing.Point(224, 88)
		Me.cmdCheat.TabIndex = 73
		Me.cmdCheat.TabStop = False
		Me.cmdCheat.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdCheat.BackColor = System.Drawing.SystemColors.Control
		Me.cmdCheat.CausesValidation = True
		Me.cmdCheat.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdCheat.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdCheat.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdCheat.Name = "cmdCheat"
		Me.cmdBrown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdBrown.Text = "Brown"
		Me.cmdBrown.Enabled = False
		Me.cmdBrown.Size = New System.Drawing.Size(49, 17)
		Me.cmdBrown.Location = New System.Drawing.Point(224, 64)
		Me.cmdBrown.TabIndex = 72
		Me.cmdBrown.TabStop = False
		Me.cmdBrown.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdBrown.BackColor = System.Drawing.SystemColors.Control
		Me.cmdBrown.CausesValidation = True
		Me.cmdBrown.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdBrown.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdBrown.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdBrown.Name = "cmdBrown"
		Me.cmdDGreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdDGreen.Text = "DGreen"
		Me.cmdDGreen.Enabled = False
		Me.cmdDGreen.Size = New System.Drawing.Size(49, 17)
		Me.cmdDGreen.Location = New System.Drawing.Point(224, 48)
		Me.cmdDGreen.TabIndex = 71
		Me.cmdDGreen.TabStop = False
		Me.cmdDGreen.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdDGreen.BackColor = System.Drawing.SystemColors.Control
		Me.cmdDGreen.CausesValidation = True
		Me.cmdDGreen.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdDGreen.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdDGreen.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdDGreen.Name = "cmdDGreen"
		Me.cmdLBlue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdLBlue.Text = "LBlue"
		Me.cmdLBlue.Enabled = False
		Me.cmdLBlue.Size = New System.Drawing.Size(49, 17)
		Me.cmdLBlue.Location = New System.Drawing.Point(224, 32)
		Me.cmdLBlue.TabIndex = 70
		Me.cmdLBlue.TabStop = False
		Me.cmdLBlue.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdLBlue.BackColor = System.Drawing.SystemColors.Control
		Me.cmdLBlue.CausesValidation = True
		Me.cmdLBlue.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdLBlue.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdLBlue.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdLBlue.Name = "cmdLBlue"
		Me.cmdGrey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdGrey.Text = "Grey"
		Me.cmdGrey.Enabled = False
		Me.cmdGrey.Size = New System.Drawing.Size(49, 17)
		Me.cmdGrey.Location = New System.Drawing.Point(224, 16)
		Me.cmdGrey.TabIndex = 69
		Me.cmdGrey.TabStop = False
		Me.cmdGrey.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdGrey.BackColor = System.Drawing.SystemColors.Control
		Me.cmdGrey.CausesValidation = True
		Me.cmdGrey.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdGrey.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdGrey.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdGrey.Name = "cmdGrey"
		Me.cmdWhite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdWhite.Text = "White"
		Me.cmdWhite.Enabled = False
		Me.cmdWhite.Size = New System.Drawing.Size(49, 17)
		Me.cmdWhite.Location = New System.Drawing.Point(176, 88)
		Me.cmdWhite.TabIndex = 68
		Me.cmdWhite.TabStop = False
		Me.cmdWhite.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdWhite.BackColor = System.Drawing.SystemColors.Control
		Me.cmdWhite.CausesValidation = True
		Me.cmdWhite.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdWhite.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdWhite.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdWhite.Name = "cmdWhite"
		Me.cmdPink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdPink.Text = "Pink"
		Me.cmdPink.Enabled = False
		Me.cmdPink.Size = New System.Drawing.Size(49, 17)
		Me.cmdPink.Location = New System.Drawing.Point(176, 64)
		Me.cmdPink.TabIndex = 67
		Me.cmdPink.TabStop = False
		Me.cmdPink.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdPink.BackColor = System.Drawing.SystemColors.Control
		Me.cmdPink.CausesValidation = True
		Me.cmdPink.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdPink.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdPink.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdPink.Name = "cmdPink"
		Me.cmdGreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdGreen.Text = "Green"
		Me.cmdGreen.Enabled = False
		Me.cmdGreen.Size = New System.Drawing.Size(49, 17)
		Me.cmdGreen.Location = New System.Drawing.Point(176, 48)
		Me.cmdGreen.TabIndex = 66
		Me.cmdGreen.TabStop = False
		Me.cmdGreen.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdGreen.BackColor = System.Drawing.SystemColors.Control
		Me.cmdGreen.CausesValidation = True
		Me.cmdGreen.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdGreen.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdGreen.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdGreen.Name = "cmdGreen"
		Me.cmdOrange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdOrange.Text = "Orange"
		Me.cmdOrange.Enabled = False
		Me.cmdOrange.Size = New System.Drawing.Size(49, 17)
		Me.cmdOrange.Location = New System.Drawing.Point(176, 32)
		Me.cmdOrange.TabIndex = 65
		Me.cmdOrange.TabStop = False
		Me.cmdOrange.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdOrange.BackColor = System.Drawing.SystemColors.Control
		Me.cmdOrange.CausesValidation = True
		Me.cmdOrange.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdOrange.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdOrange.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdOrange.Name = "cmdOrange"
		Me.cmdYellow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdYellow.Text = "Yellow"
		Me.cmdYellow.Enabled = False
		Me.cmdYellow.Size = New System.Drawing.Size(49, 17)
		Me.cmdYellow.Location = New System.Drawing.Point(176, 16)
		Me.cmdYellow.TabIndex = 64
		Me.cmdYellow.TabStop = False
		Me.cmdYellow.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdYellow.BackColor = System.Drawing.SystemColors.Control
		Me.cmdYellow.CausesValidation = True
		Me.cmdYellow.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdYellow.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdYellow.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdYellow.Name = "cmdYellow"
		Me.cmdBlack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdBlack.Text = "Black"
		Me.cmdBlack.Enabled = False
		Me.cmdBlack.Size = New System.Drawing.Size(49, 17)
		Me.cmdBlack.Location = New System.Drawing.Point(128, 88)
		Me.cmdBlack.TabIndex = 63
		Me.cmdBlack.TabStop = False
		Me.cmdBlack.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdBlack.BackColor = System.Drawing.SystemColors.Control
		Me.cmdBlack.CausesValidation = True
		Me.cmdBlack.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdBlack.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdBlack.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdBlack.Name = "cmdBlack"
		Me.cmdPurple.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdPurple.Text = "Purple"
		Me.cmdPurple.Enabled = False
		Me.cmdPurple.Size = New System.Drawing.Size(49, 17)
		Me.cmdPurple.Location = New System.Drawing.Point(128, 64)
		Me.cmdPurple.TabIndex = 62
		Me.cmdPurple.TabStop = False
		Me.cmdPurple.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdPurple.BackColor = System.Drawing.SystemColors.Control
		Me.cmdPurple.CausesValidation = True
		Me.cmdPurple.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdPurple.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdPurple.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdPurple.Name = "cmdPurple"
		Me.cmdTeal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdTeal.Text = "Teal"
		Me.cmdTeal.Enabled = False
		Me.cmdTeal.Size = New System.Drawing.Size(49, 17)
		Me.cmdTeal.Location = New System.Drawing.Point(128, 48)
		Me.cmdTeal.TabIndex = 61
		Me.cmdTeal.TabStop = False
		Me.cmdTeal.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdTeal.BackColor = System.Drawing.SystemColors.Control
		Me.cmdTeal.CausesValidation = True
		Me.cmdTeal.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdTeal.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdTeal.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdTeal.Name = "cmdTeal"
		Me.cmdBlue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdBlue.Text = "Blue"
		Me.cmdBlue.Enabled = False
		Me.cmdBlue.Size = New System.Drawing.Size(49, 17)
		Me.cmdBlue.Location = New System.Drawing.Point(128, 32)
		Me.cmdBlue.TabIndex = 60
		Me.cmdBlue.TabStop = False
		Me.cmdBlue.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdBlue.BackColor = System.Drawing.SystemColors.Control
		Me.cmdBlue.CausesValidation = True
		Me.cmdBlue.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdBlue.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdBlue.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdBlue.Name = "cmdBlue"
		Me.cmdRed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdRed.Text = "Red"
		Me.cmdRed.Enabled = False
		Me.cmdRed.Size = New System.Drawing.Size(49, 17)
		Me.cmdRed.Location = New System.Drawing.Point(128, 16)
		Me.cmdRed.TabIndex = 59
		Me.cmdRed.TabStop = False
		Me.cmdRed.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdRed.BackColor = System.Drawing.SystemColors.Control
		Me.cmdRed.CausesValidation = True
		Me.cmdRed.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdRed.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdRed.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdRed.Name = "cmdRed"
		Me.txtGreen.AutoSize = False
		Me.txtGreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.txtGreen.Enabled = False
		Me.txtGreen.Size = New System.Drawing.Size(33, 19)
		Me.txtGreen.Location = New System.Drawing.Point(48, 32)
		Me.txtGreen.Maxlength = 3
		Me.txtGreen.TabIndex = 57
		Me.txtGreen.Text = "00"
		Me.txtGreen.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtGreen.AcceptsReturn = True
		Me.txtGreen.BackColor = System.Drawing.SystemColors.Window
		Me.txtGreen.CausesValidation = True
		Me.txtGreen.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtGreen.HideSelection = True
		Me.txtGreen.ReadOnly = False
		Me.txtGreen.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtGreen.MultiLine = False
		Me.txtGreen.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtGreen.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtGreen.TabStop = True
		Me.txtGreen.Visible = True
		Me.txtGreen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtGreen.Name = "txtGreen"
		Me.txtBlue.AutoSize = False
		Me.txtBlue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.txtBlue.Enabled = False
		Me.txtBlue.Size = New System.Drawing.Size(33, 19)
		Me.txtBlue.Location = New System.Drawing.Point(80, 32)
		Me.txtBlue.Maxlength = 3
		Me.txtBlue.TabIndex = 58
		Me.txtBlue.Text = "00"
		Me.txtBlue.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtBlue.AcceptsReturn = True
		Me.txtBlue.BackColor = System.Drawing.SystemColors.Window
		Me.txtBlue.CausesValidation = True
		Me.txtBlue.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtBlue.HideSelection = True
		Me.txtBlue.ReadOnly = False
		Me.txtBlue.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtBlue.MultiLine = False
		Me.txtBlue.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtBlue.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtBlue.TabStop = True
		Me.txtBlue.Visible = True
		Me.txtBlue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtBlue.Name = "txtBlue"
		Me.txtRed.AutoSize = False
		Me.txtRed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.txtRed.Enabled = False
		Me.txtRed.Size = New System.Drawing.Size(33, 19)
		Me.txtRed.Location = New System.Drawing.Point(16, 32)
		Me.txtRed.Maxlength = 3
		Me.txtRed.TabIndex = 55
		Me.txtRed.Text = "00"
		Me.txtRed.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtRed.AcceptsReturn = True
		Me.txtRed.BackColor = System.Drawing.SystemColors.Window
		Me.txtRed.CausesValidation = True
		Me.txtRed.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtRed.HideSelection = True
		Me.txtRed.ReadOnly = False
		Me.txtRed.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtRed.MultiLine = False
		Me.txtRed.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtRed.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtRed.TabStop = True
		Me.txtRed.Visible = True
		Me.txtRed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtRed.Name = "txtRed"
		wsUsage.OcxState = CType(resources.GetObject("wsUsage.OcxState"), System.Windows.Forms.AxHost.State)
		Me.wsUsage.Location = New System.Drawing.Point(40, 0)
		Me.wsUsage.Name = "wsUsage"
		Me.Line1.BackColor = System.Drawing.SystemColors.WindowText
		Me.Line1.Visible = True
		Me.Line1.Location = New System.Drawing.Point(120, 8)
		Me.Line1.Width = 1
		Me.Line1.Height = 104
		Me.Line1.Name = "Line1"
		Me.wc3Preview.BackColor = System.Drawing.Color.Black
		Me.wc3Preview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.wc3Preview.Size = New System.Drawing.Size(97, 41)
		Me.wc3Preview.Location = New System.Drawing.Point(16, 56)
		Me.wc3Preview.Visible = True
		Me.wc3Preview.Name = "wc3Preview"
		Me.Label8.Text = "Color Code (R G B):"
		Me.Label8.Size = New System.Drawing.Size(105, 17)
		Me.Label8.Location = New System.Drawing.Point(16, 16)
		Me.Label8.TabIndex = 56
		Me.Label8.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label8.BackColor = System.Drawing.SystemColors.Control
		Me.Label8.Enabled = True
		Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label8.UseMnemonic = True
		Me.Label8.Visible = True
		Me.Label8.AutoSize = False
		Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label8.Name = "Label8"
		Me._Frame_3.Text = "Warcraft II"
		Me._Frame_3.Size = New System.Drawing.Size(473, 137)
		Me._Frame_3.Location = New System.Drawing.Point(0, 0)
		Me._Frame_3.TabIndex = 38
		Me._Frame_3.Visible = False
		Me._Frame_3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._Frame_3.BackColor = System.Drawing.SystemColors.Control
		Me._Frame_3.Enabled = True
		Me._Frame_3.ForeColor = System.Drawing.SystemColors.ControlText
		Me._Frame_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Frame_3.Name = "_Frame_3"
		Me.Frame12.Text = "Previews:"
		Me.Frame12.Size = New System.Drawing.Size(129, 113)
		Me.Frame12.Location = New System.Drawing.Point(336, 16)
		Me.Frame12.TabIndex = 48
		Me.Frame12.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame12.BackColor = System.Drawing.SystemColors.Control
		Me.Frame12.Enabled = True
		Me.Frame12.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame12.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame12.Visible = True
		Me.Frame12.Name = "Frame12"
		wc2Pregame.OcxState = CType(resources.GetObject("wc2Pregame.OcxState"), System.Windows.Forms.AxHost.State)
		Me.wc2Pregame.Size = New System.Drawing.Size(113, 25)
		Me.wc2Pregame.Location = New System.Drawing.Point(8, 32)
		Me.wc2Pregame.TabIndex = 49
		Me.wc2Pregame.Name = "wc2Pregame"
		wc2Ingame.OcxState = CType(resources.GetObject("wc2Ingame.OcxState"), System.Windows.Forms.AxHost.State)
		Me.wc2Ingame.Size = New System.Drawing.Size(113, 25)
		Me.wc2Ingame.Location = New System.Drawing.Point(8, 72)
		Me.wc2Ingame.TabIndex = 50
		Me.wc2Ingame.Name = "wc2Ingame"
		Me.Label7.Text = "In game"
		Me.Label7.Size = New System.Drawing.Size(113, 17)
		Me.Label7.Location = New System.Drawing.Point(8, 56)
		Me.Label7.TabIndex = 52
		Me.Label7.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label7.BackColor = System.Drawing.SystemColors.Control
		Me.Label7.Enabled = True
		Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label7.UseMnemonic = True
		Me.Label7.Visible = True
		Me.Label7.AutoSize = False
		Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label7.Name = "Label7"
		Me.Label6.Text = "Pregame"
		Me.Label6.Size = New System.Drawing.Size(113, 17)
		Me.Label6.Location = New System.Drawing.Point(8, 16)
		Me.Label6.TabIndex = 51
		Me.Label6.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label6.BackColor = System.Drawing.SystemColors.Control
		Me.Label6.Enabled = True
		Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label6.UseMnemonic = True
		Me.Label6.Visible = True
		Me.Label6.AutoSize = False
		Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label6.Name = "Label6"
		Me.Frame11.Text = "Name"
		Me.Frame11.Size = New System.Drawing.Size(129, 57)
		Me.Frame11.Location = New System.Drawing.Point(8, 16)
		Me.Frame11.TabIndex = 46
		Me.Frame11.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame11.BackColor = System.Drawing.SystemColors.Control
		Me.Frame11.Enabled = True
		Me.Frame11.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame11.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame11.Visible = True
		Me.Frame11.Name = "Frame11"
		wc2Name.OcxState = CType(resources.GetObject("wc2Name.OcxState"), System.Windows.Forms.AxHost.State)
		Me.wc2Name.Size = New System.Drawing.Size(113, 25)
		Me.wc2Name.Location = New System.Drawing.Point(8, 16)
		Me.wc2Name.TabIndex = 47
		Me.wc2Name.Name = "wc2Name"
		Me.Frame10.Text = "Insert Color"
		Me.Frame10.Size = New System.Drawing.Size(185, 113)
		Me.Frame10.Location = New System.Drawing.Point(144, 16)
		Me.Frame10.TabIndex = 39
		Me.Frame10.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame10.BackColor = System.Drawing.SystemColors.Control
		Me.Frame10.Enabled = True
		Me.Frame10.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame10.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame10.Visible = True
		Me.Frame10.Name = "Frame10"
		Me.wc2ClearColors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.wc2ClearColors.Text = "Clear Colors"
		Me.wc2ClearColors.Size = New System.Drawing.Size(169, 17)
		Me.wc2ClearColors.Location = New System.Drawing.Point(8, 88)
		Me.wc2ClearColors.TabIndex = 45
		Me.wc2ClearColors.TabStop = False
		Me.wc2ClearColors.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.wc2ClearColors.BackColor = System.Drawing.SystemColors.Control
		Me.wc2ClearColors.CausesValidation = True
		Me.wc2ClearColors.Enabled = True
		Me.wc2ClearColors.ForeColor = System.Drawing.SystemColors.ControlText
		Me.wc2ClearColors.Cursor = System.Windows.Forms.Cursors.Default
		Me.wc2ClearColors.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.wc2ClearColors.Name = "wc2ClearColors"
		Me.wc2Grey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.wc2Grey.Text = "Grey"
		Me.wc2Grey.Size = New System.Drawing.Size(81, 17)
		Me.wc2Grey.Location = New System.Drawing.Point(96, 16)
		Me.wc2Grey.TabIndex = 44
		Me.wc2Grey.TabStop = False
		Me.wc2Grey.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.wc2Grey.BackColor = System.Drawing.SystemColors.Control
		Me.wc2Grey.CausesValidation = True
		Me.wc2Grey.Enabled = True
		Me.wc2Grey.ForeColor = System.Drawing.SystemColors.ControlText
		Me.wc2Grey.Cursor = System.Windows.Forms.Cursors.Default
		Me.wc2Grey.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.wc2Grey.Name = "wc2Grey"
		Me.wc2Black.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.wc2Black.Text = "Black"
		Me.wc2Black.Size = New System.Drawing.Size(81, 17)
		Me.wc2Black.Location = New System.Drawing.Point(96, 40)
		Me.wc2Black.TabIndex = 43
		Me.wc2Black.TabStop = False
		Me.wc2Black.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.wc2Black.BackColor = System.Drawing.SystemColors.Control
		Me.wc2Black.CausesValidation = True
		Me.wc2Black.Enabled = True
		Me.wc2Black.ForeColor = System.Drawing.SystemColors.ControlText
		Me.wc2Black.Cursor = System.Windows.Forms.Cursors.Default
		Me.wc2Black.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.wc2Black.Name = "wc2Black"
		Me.wc2White.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.wc2White.Text = "White/Yellow"
		Me.wc2White.Size = New System.Drawing.Size(81, 17)
		Me.wc2White.Location = New System.Drawing.Point(8, 64)
		Me.wc2White.TabIndex = 42
		Me.wc2White.TabStop = False
		Me.wc2White.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.wc2White.BackColor = System.Drawing.SystemColors.Control
		Me.wc2White.CausesValidation = True
		Me.wc2White.Enabled = True
		Me.wc2White.ForeColor = System.Drawing.SystemColors.ControlText
		Me.wc2White.Cursor = System.Windows.Forms.Cursors.Default
		Me.wc2White.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.wc2White.Name = "wc2White"
		Me.wc2Red.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.wc2Red.Text = "Red"
		Me.wc2Red.Size = New System.Drawing.Size(81, 17)
		Me.wc2Red.Location = New System.Drawing.Point(8, 40)
		Me.wc2Red.TabIndex = 41
		Me.wc2Red.TabStop = False
		Me.wc2Red.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.wc2Red.BackColor = System.Drawing.SystemColors.Control
		Me.wc2Red.CausesValidation = True
		Me.wc2Red.Enabled = True
		Me.wc2Red.ForeColor = System.Drawing.SystemColors.ControlText
		Me.wc2Red.Cursor = System.Windows.Forms.Cursors.Default
		Me.wc2Red.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.wc2Red.Name = "wc2Red"
		Me.wc2Normal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.wc2Normal.Text = "Normal"
		Me.wc2Normal.Size = New System.Drawing.Size(81, 17)
		Me.wc2Normal.Location = New System.Drawing.Point(8, 16)
		Me.wc2Normal.TabIndex = 40
		Me.wc2Normal.TabStop = False
		Me.wc2Normal.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.wc2Normal.BackColor = System.Drawing.SystemColors.Control
		Me.wc2Normal.CausesValidation = True
		Me.wc2Normal.Enabled = True
		Me.wc2Normal.ForeColor = System.Drawing.SystemColors.ControlText
		Me.wc2Normal.Cursor = System.Windows.Forms.Cursors.Default
		Me.wc2Normal.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.wc2Normal.Name = "wc2Normal"
		Me._Frame_2.Text = "Brood War"
		Me._Frame_2.Size = New System.Drawing.Size(473, 137)
		Me._Frame_2.Location = New System.Drawing.Point(0, 0)
		Me._Frame_2.TabIndex = 20
		Me._Frame_2.Visible = False
		Me._Frame_2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._Frame_2.BackColor = System.Drawing.SystemColors.Control
		Me._Frame_2.Enabled = True
		Me._Frame_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._Frame_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Frame_2.Name = "_Frame_2"
		Me.Frame8.Text = "Alignment"
		Me.Frame8.Size = New System.Drawing.Size(129, 49)
		Me.Frame8.Location = New System.Drawing.Point(8, 16)
		Me.Frame8.TabIndex = 36
		Me.Frame8.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame8.BackColor = System.Drawing.SystemColors.Control
		Me.Frame8.Enabled = True
		Me.Frame8.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame8.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame8.Visible = True
		Me.Frame8.Name = "Frame8"
		Me.bwAlignment.Size = New System.Drawing.Size(113, 21)
		Me.bwAlignment.Location = New System.Drawing.Point(8, 16)
		Me.bwAlignment.Items.AddRange(New Object(){"Left", "Right", "Center"})
		Me.bwAlignment.TabIndex = 37
		Me.bwAlignment.TabStop = False
		Me.bwAlignment.Text = "Left"
		Me.bwAlignment.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.bwAlignment.BackColor = System.Drawing.SystemColors.Window
		Me.bwAlignment.CausesValidation = True
		Me.bwAlignment.Enabled = True
		Me.bwAlignment.ForeColor = System.Drawing.SystemColors.WindowText
		Me.bwAlignment.IntegralHeight = True
		Me.bwAlignment.Cursor = System.Windows.Forms.Cursors.Default
		Me.bwAlignment.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.bwAlignment.Sorted = False
		Me.bwAlignment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.bwAlignment.Visible = True
		Me.bwAlignment.Name = "bwAlignment"
		Me.Frame7.Text = "Insert Color"
		Me.Frame7.Size = New System.Drawing.Size(185, 113)
		Me.Frame7.Location = New System.Drawing.Point(144, 16)
		Me.Frame7.TabIndex = 28
		Me.Frame7.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame7.BackColor = System.Drawing.SystemColors.Control
		Me.Frame7.Enabled = True
		Me.Frame7.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame7.Visible = True
		Me.Frame7.Name = "Frame7"
		Me.bwNormal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.bwNormal.Text = "LBlue/Normal"
		Me.bwNormal.Size = New System.Drawing.Size(81, 17)
		Me.bwNormal.Location = New System.Drawing.Point(8, 16)
		Me.bwNormal.TabIndex = 35
		Me.bwNormal.TabStop = False
		Me.bwNormal.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.bwNormal.BackColor = System.Drawing.SystemColors.Control
		Me.bwNormal.CausesValidation = True
		Me.bwNormal.Enabled = True
		Me.bwNormal.ForeColor = System.Drawing.SystemColors.ControlText
		Me.bwNormal.Cursor = System.Windows.Forms.Cursors.Default
		Me.bwNormal.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.bwNormal.Name = "bwNormal"
		Me.bwYellow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.bwYellow.Text = "Normal/Yellow"
		Me.bwYellow.Size = New System.Drawing.Size(81, 17)
		Me.bwYellow.Location = New System.Drawing.Point(8, 40)
		Me.bwYellow.TabIndex = 34
		Me.bwYellow.TabStop = False
		Me.bwYellow.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.bwYellow.BackColor = System.Drawing.SystemColors.Control
		Me.bwYellow.CausesValidation = True
		Me.bwYellow.Enabled = True
		Me.bwYellow.ForeColor = System.Drawing.SystemColors.ControlText
		Me.bwYellow.Cursor = System.Windows.Forms.Cursors.Default
		Me.bwYellow.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.bwYellow.Name = "bwYellow"
		Me.bwWhite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.bwWhite.Text = "LGreen/White"
		Me.bwWhite.Size = New System.Drawing.Size(81, 17)
		Me.bwWhite.Location = New System.Drawing.Point(8, 64)
		Me.bwWhite.TabIndex = 33
		Me.bwWhite.TabStop = False
		Me.bwWhite.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.bwWhite.BackColor = System.Drawing.SystemColors.Control
		Me.bwWhite.CausesValidation = True
		Me.bwWhite.Enabled = True
		Me.bwWhite.ForeColor = System.Drawing.SystemColors.ControlText
		Me.bwWhite.Cursor = System.Windows.Forms.Cursors.Default
		Me.bwWhite.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.bwWhite.Name = "bwWhite"
		Me.bwGrey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.bwGrey.Text = "Grey"
		Me.bwGrey.Size = New System.Drawing.Size(81, 17)
		Me.bwGrey.Location = New System.Drawing.Point(96, 16)
		Me.bwGrey.TabIndex = 32
		Me.bwGrey.TabStop = False
		Me.bwGrey.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.bwGrey.BackColor = System.Drawing.SystemColors.Control
		Me.bwGrey.CausesValidation = True
		Me.bwGrey.Enabled = True
		Me.bwGrey.ForeColor = System.Drawing.SystemColors.ControlText
		Me.bwGrey.Cursor = System.Windows.Forms.Cursors.Default
		Me.bwGrey.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.bwGrey.Name = "bwGrey"
		Me.bwRed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.bwRed.Text = "White/Red"
		Me.bwRed.Size = New System.Drawing.Size(81, 17)
		Me.bwRed.Location = New System.Drawing.Point(96, 40)
		Me.bwRed.TabIndex = 31
		Me.bwRed.TabStop = False
		Me.bwRed.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.bwRed.BackColor = System.Drawing.SystemColors.Control
		Me.bwRed.CausesValidation = True
		Me.bwRed.Enabled = True
		Me.bwRed.ForeColor = System.Drawing.SystemColors.ControlText
		Me.bwRed.Cursor = System.Windows.Forms.Cursors.Default
		Me.bwRed.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.bwRed.Name = "bwRed"
		Me.bwGreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.bwGreen.Text = "Red/Green"
		Me.bwGreen.Size = New System.Drawing.Size(81, 17)
		Me.bwGreen.Location = New System.Drawing.Point(96, 64)
		Me.bwGreen.TabIndex = 30
		Me.bwGreen.TabStop = False
		Me.bwGreen.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.bwGreen.BackColor = System.Drawing.SystemColors.Control
		Me.bwGreen.CausesValidation = True
		Me.bwGreen.Enabled = True
		Me.bwGreen.ForeColor = System.Drawing.SystemColors.ControlText
		Me.bwGreen.Cursor = System.Windows.Forms.Cursors.Default
		Me.bwGreen.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.bwGreen.Name = "bwGreen"
		Me.bwClearColors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.bwClearColors.Text = "Clear Colors"
		Me.bwClearColors.Size = New System.Drawing.Size(169, 17)
		Me.bwClearColors.Location = New System.Drawing.Point(8, 88)
		Me.bwClearColors.TabIndex = 29
		Me.bwClearColors.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.bwClearColors.BackColor = System.Drawing.SystemColors.Control
		Me.bwClearColors.CausesValidation = True
		Me.bwClearColors.Enabled = True
		Me.bwClearColors.ForeColor = System.Drawing.SystemColors.ControlText
		Me.bwClearColors.Cursor = System.Windows.Forms.Cursors.Default
		Me.bwClearColors.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.bwClearColors.TabStop = True
		Me.bwClearColors.Name = "bwClearColors"
		Me.Frame6.Text = "Name"
		Me.Frame6.Size = New System.Drawing.Size(129, 57)
		Me.Frame6.Location = New System.Drawing.Point(8, 72)
		Me.Frame6.TabIndex = 26
		Me.Frame6.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame6.BackColor = System.Drawing.SystemColors.Control
		Me.Frame6.Enabled = True
		Me.Frame6.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame6.Visible = True
		Me.Frame6.Name = "Frame6"
		bwName.OcxState = CType(resources.GetObject("bwName.OcxState"), System.Windows.Forms.AxHost.State)
		Me.bwName.Size = New System.Drawing.Size(113, 25)
		Me.bwName.Location = New System.Drawing.Point(8, 16)
		Me.bwName.TabIndex = 27
		Me.bwName.Name = "bwName"
		Me.Frame1.Text = "Previews:"
		Me.Frame1.Size = New System.Drawing.Size(129, 113)
		Me.Frame1.Location = New System.Drawing.Point(336, 16)
		Me.Frame1.TabIndex = 21
		Me.Frame1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Name = "Frame1"
		bwPregame.OcxState = CType(resources.GetObject("bwPregame.OcxState"), System.Windows.Forms.AxHost.State)
		Me.bwPregame.Size = New System.Drawing.Size(113, 25)
		Me.bwPregame.Location = New System.Drawing.Point(8, 32)
		Me.bwPregame.TabIndex = 22
		Me.bwPregame.Name = "bwPregame"
		bwIngame.OcxState = CType(resources.GetObject("bwIngame.OcxState"), System.Windows.Forms.AxHost.State)
		Me.bwIngame.Size = New System.Drawing.Size(113, 25)
		Me.bwIngame.Location = New System.Drawing.Point(8, 72)
		Me.bwIngame.TabIndex = 23
		Me.bwIngame.Name = "bwIngame"
		Me.Label5.Text = "Pregame"
		Me.Label5.Size = New System.Drawing.Size(113, 17)
		Me.Label5.Location = New System.Drawing.Point(8, 16)
		Me.Label5.TabIndex = 25
		Me.Label5.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label5.BackColor = System.Drawing.SystemColors.Control
		Me.Label5.Enabled = True
		Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label5.UseMnemonic = True
		Me.Label5.Visible = True
		Me.Label5.AutoSize = False
		Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label5.Name = "Label5"
		Me.Label4.Text = "In game"
		Me.Label4.Size = New System.Drawing.Size(113, 17)
		Me.Label4.Location = New System.Drawing.Point(8, 56)
		Me.Label4.TabIndex = 24
		Me.Label4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label4.BackColor = System.Drawing.SystemColors.Control
		Me.Label4.Enabled = True
		Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label4.UseMnemonic = True
		Me.Label4.Visible = True
		Me.Label4.AutoSize = False
		Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label4.Name = "Label4"
		Me.Label9.Text = "WARNING: In their infinite wisdom, Blizzard has begun PERMENANTLY banning ips of anybody who uses colors or any other banned characters in Starcraft, Brood War, and Warcraft 2.  Do NOT use these unless you have an anti-banning program in use!  It is OK to use colors in Warcraft III custom games, however.  You have been warned!"
		Me.Label9.Size = New System.Drawing.Size(393, 81)
		Me.Label9.Location = New System.Drawing.Point(48, 64)
		Me.Label9.TabIndex = 78
		Me.Label9.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label9.BackColor = System.Drawing.SystemColors.Control
		Me.Label9.Enabled = True
		Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label9.UseMnemonic = True
		Me.Label9.Visible = True
		Me.Label9.AutoSize = False
		Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label9.Name = "Label9"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.Label3.Text = "To continue, please launch one of the supported games."
		Me.Label3.Font = New System.Drawing.Font("Arial", 13.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Size = New System.Drawing.Size(377, 73)
		Me.Label3.Location = New System.Drawing.Point(56, 0)
		Me.Label3.TabIndex = 19
		Me.Label3.BackColor = System.Drawing.SystemColors.Control
		Me.Label3.Enabled = True
		Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label3.UseMnemonic = True
		Me.Label3.Visible = True
		Me.Label3.AutoSize = False
		Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label3.Name = "Label3"
		Me.mnuFile.Text = "&File"
		Me.mnuFile.Checked = False
		Me.mnuFile.Enabled = True
		Me.mnuFile.Visible = True
		Me.mnuFile.MDIList = False
		Me.mnuFileExit.Text = "E&xit"
		Me.mnuFileExit.Checked = False
		Me.mnuFileExit.Enabled = True
		Me.mnuFileExit.Visible = True
		Me.mnuFileExit.MDIList = False
		Me.mnuHelp.Text = "&Help"
		Me.mnuHelp.Checked = False
		Me.mnuHelp.Enabled = True
		Me.mnuHelp.Visible = True
		Me.mnuHelp.MDIList = False
		Me.mnuHelpAbout.Text = "&About"
		Me.mnuHelpAbout.Checked = False
		Me.mnuHelpAbout.Enabled = True
		Me.mnuHelpAbout.Visible = True
		Me.mnuHelpAbout.MDIList = False
		Me.mnuST.Text = "ST"
		Me.mnuST.Visible = False
		Me.mnuST.Checked = False
		Me.mnuST.Enabled = True
		Me.mnuST.MDIList = False
		Me.mnuSTRestore.Text = "&Restore"
		Me.mnuSTRestore.Checked = False
		Me.mnuSTRestore.Enabled = True
		Me.mnuSTRestore.Visible = True
		Me.mnuSTRestore.MDIList = False
		Me.mnuSTExit.Text = "E&xit"
		Me.mnuSTExit.Checked = False
		Me.mnuSTExit.Enabled = True
		Me.mnuSTExit.Visible = True
		Me.mnuSTExit.MDIList = False
		Me.Controls.Add(CD)
		Me.Controls.Add(SB)
		Me.Controls.Add(_Frame_1)
		Me.Controls.Add(_Frame_4)
		Me.Controls.Add(_Frame_3)
		Me.Controls.Add(_Frame_2)
		Me.Controls.Add(Label9)
		Me.Controls.Add(Label3)
		Me._Frame_1.Controls.Add(picSystemTray)
		Me._Frame_1.Controls.Add(Frame5)
		Me._Frame_1.Controls.Add(Frame4)
		Me._Frame_1.Controls.Add(Frame3)
		Me._Frame_1.Controls.Add(Frame2)
		Me.Frame5.Controls.Add(scPregame)
		Me.Frame5.Controls.Add(scIngame)
		Me.Frame5.Controls.Add(Label2)
		Me.Frame5.Controls.Add(Label1)
		Me.Frame4.Controls.Add(scName)
		Me.Frame3.Controls.Add(scClearColors)
		Me.Frame3.Controls.Add(scGreen)
		Me.Frame3.Controls.Add(scRed)
		Me.Frame3.Controls.Add(scGrey)
		Me.Frame3.Controls.Add(scWhite)
		Me.Frame3.Controls.Add(scYellow)
		Me.Frame3.Controls.Add(scNormal)
		Me.Frame2.Controls.Add(scAlignment)
		Me._Frame_4.Controls.Add(frame14)
		Me._Frame_4.Controls.Add(frame13)
		Me._Frame_4.Controls.Add(fraWC3Colors)
		Me.frame14.Controls.Add(chkUseColors)
		Me.frame13.Controls.Add(wc3Name)
		Me.fraWC3Colors.Controls.Add(cmdCheat)
		Me.fraWC3Colors.Controls.Add(cmdBrown)
		Me.fraWC3Colors.Controls.Add(cmdDGreen)
		Me.fraWC3Colors.Controls.Add(cmdLBlue)
		Me.fraWC3Colors.Controls.Add(cmdGrey)
		Me.fraWC3Colors.Controls.Add(cmdWhite)
		Me.fraWC3Colors.Controls.Add(cmdPink)
		Me.fraWC3Colors.Controls.Add(cmdGreen)
		Me.fraWC3Colors.Controls.Add(cmdOrange)
		Me.fraWC3Colors.Controls.Add(cmdYellow)
		Me.fraWC3Colors.Controls.Add(cmdBlack)
		Me.fraWC3Colors.Controls.Add(cmdPurple)
		Me.fraWC3Colors.Controls.Add(cmdTeal)
		Me.fraWC3Colors.Controls.Add(cmdBlue)
		Me.fraWC3Colors.Controls.Add(cmdRed)
		Me.fraWC3Colors.Controls.Add(txtGreen)
		Me.fraWC3Colors.Controls.Add(txtBlue)
		Me.fraWC3Colors.Controls.Add(txtRed)
		Me.fraWC3Colors.Controls.Add(wsUsage)
		Me.fraWC3Colors.Controls.Add(Line1)
		Me.fraWC3Colors.Controls.Add(wc3Preview)
		Me.fraWC3Colors.Controls.Add(Label8)
		Me._Frame_3.Controls.Add(Frame12)
		Me._Frame_3.Controls.Add(Frame11)
		Me._Frame_3.Controls.Add(Frame10)
		Me.Frame12.Controls.Add(wc2Pregame)
		Me.Frame12.Controls.Add(wc2Ingame)
		Me.Frame12.Controls.Add(Label7)
		Me.Frame12.Controls.Add(Label6)
		Me.Frame11.Controls.Add(wc2Name)
		Me.Frame10.Controls.Add(wc2ClearColors)
		Me.Frame10.Controls.Add(wc2Grey)
		Me.Frame10.Controls.Add(wc2Black)
		Me.Frame10.Controls.Add(wc2White)
		Me.Frame10.Controls.Add(wc2Red)
		Me.Frame10.Controls.Add(wc2Normal)
		Me._Frame_2.Controls.Add(Frame8)
		Me._Frame_2.Controls.Add(Frame7)
		Me._Frame_2.Controls.Add(Frame6)
		Me._Frame_2.Controls.Add(Frame1)
		Me.Frame8.Controls.Add(bwAlignment)
		Me.Frame7.Controls.Add(bwNormal)
		Me.Frame7.Controls.Add(bwYellow)
		Me.Frame7.Controls.Add(bwWhite)
		Me.Frame7.Controls.Add(bwGrey)
		Me.Frame7.Controls.Add(bwRed)
		Me.Frame7.Controls.Add(bwGreen)
		Me.Frame7.Controls.Add(bwClearColors)
		Me.Frame6.Controls.Add(bwName)
		Me.Frame1.Controls.Add(bwPregame)
		Me.Frame1.Controls.Add(bwIngame)
		Me.Frame1.Controls.Add(Label5)
		Me.Frame1.Controls.Add(Label4)
		Me.Frame.SetIndex(_Frame_1, CType(1, Short))
		Me.Frame.SetIndex(_Frame_4, CType(4, Short))
		Me.Frame.SetIndex(_Frame_3, CType(3, Short))
		Me.Frame.SetIndex(_Frame_2, CType(2, Short))
		CType(Me.Frame, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.bwIngame, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.bwPregame, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.bwName, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.wc2Name, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.wc2Ingame, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.wc2Pregame, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.wsUsage, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.scName, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.scIngame, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.scPregame, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.SB, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.CD, System.ComponentModel.ISupportInitialize).EndInit()
		Me.mnuFile.Index = 0
		Me.mnuHelp.Index = 1
		Me.mnuST.Index = 2
		MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem(){Me.mnuFile, Me.mnuHelp, Me.mnuST})
		Me.mnuFileExit.Index = 0
		mnuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem(){Me.mnuFileExit})
		Me.mnuHelpAbout.Index = 0
		mnuHelp.MenuItems.AddRange(New System.Windows.Forms.MenuItem(){Me.mnuHelpAbout})
		Me.mnuSTRestore.Index = 0
		Me.mnuSTExit.Index = 1
		mnuST.MenuItems.AddRange(New System.Windows.Forms.MenuItem(){Me.mnuSTRestore, Me.mnuSTExit})
		Me.Menu = MainMenu1
	End Sub
#End Region 
#Region "Upgrade Support "
	Private Shared m_vb6FormDefInstance As frmMain
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As frmMain
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = New frmMain()
				m_InitializingDefInstance = False
			End If
			DefInstance = m_vb6FormDefInstance
		End Get
		Set
			m_vb6FormDefInstance = Value
		End Set
	End Property
#End Region 
	
	Dim SC_DGREEN As Integer
	Dim SC_LGREEN As Integer
	Dim SC_BLUE As Integer
	Dim SC_YELLOW As Integer
	Dim SC_WHITE As Integer
	Dim SC_RED As Integer
	Dim SC_GAMEGREEN As Integer
	Dim SC_GREY As Integer
	
	Dim WC2_PreYELLOW As Integer
	Dim WC2_PreRED As Integer
	Dim WC2_PreWHITE As Integer
	Dim WC2_PreGREY As Integer
	Dim WC2_PreBLACK As Integer
	Dim WC2_InYELLOW As Integer
	Dim WC2_InRED As Integer
	Dim WC2_InWHITE As Integer
	Dim WC2_InGREY As Integer
	Dim WC2_InBLACK As Integer
	
	Const wcNormal As Short = 2
	Const wcRed As Short = 3
	Const wcWhite As Short = 4
	Const wcGrey As Short = 5
	Const wcBlack As Short = 6
	
	Const cLBlue As Short = 2
	Const cNormal As Short = 3
	Const cLGreen As Short = 4
	Const cGrey As Short = 5
	Const cWhite As Short = 6
	Const cRed As Short = 7
	
	Const SC_RIGHT As Short = 18
	Const SC_CENTER As Short = 19
	
	
	'UPGRADE_WARNING: Event chkUseColors.CheckStateChanged may fire when form is intialized. Click for more: 'ms-help://MS.VSCC/commoner/redir/redirect.htm?keyword="vbup2075"'
	Private Sub chkUseColors_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkUseColors.CheckStateChanged
		If chkUseColors.CheckState = 1 Then
			fraWC3Colors.Enabled = True
			'UPGRADE_WARNING: TextBox property wc3Name.MaxLength has a new behavior. Click for more: 'ms-help://MS.VSCC/commoner/redir/redirect.htm?keyword="vbup2065"'
			wc3Name.Maxlength = 6
			If Len(wc3Name.Text) > 6 Then
				wc3Name.Text = VB.Left(wc3Name.Text, 6)
			End If
			
			txtRed.Enabled = True
			txtGreen.Enabled = True
			txtBlue.Enabled = True
			cmdRed.Enabled = True
			cmdBlue.Enabled = True
			cmdTeal.Enabled = True
			cmdPurple.Enabled = True
			cmdYellow.Enabled = True
			cmdOrange.Enabled = True
			cmdGreen.Enabled = True
			cmdPink.Enabled = True
			cmdGrey.Enabled = True
			cmdLBlue.Enabled = True
			cmdDGreen.Enabled = True
			cmdBrown.Enabled = True
			cmdBlack.Enabled = True
			cmdWhite.Enabled = True
			cmdCheat.Enabled = True
		Else
			fraWC3Colors.Enabled = False
			'UPGRADE_WARNING: TextBox property wc3Name.MaxLength has a new behavior. Click for more: 'ms-help://MS.VSCC/commoner/redir/redirect.htm?keyword="vbup2065"'
			wc3Name.Maxlength = 16
			txtRed.Enabled = False
			txtGreen.Enabled = False
			txtBlue.Enabled = False
			cmdRed.Enabled = False
			cmdBlue.Enabled = False
			cmdTeal.Enabled = False
			cmdPurple.Enabled = False
			cmdYellow.Enabled = False
			cmdOrange.Enabled = False
			cmdGreen.Enabled = False
			cmdPink.Enabled = False
			cmdGrey.Enabled = False
			cmdLBlue.Enabled = False
			cmdDGreen.Enabled = False
			cmdBrown.Enabled = False
			cmdBlack.Enabled = False
			cmdWhite.Enabled = False
			cmdCheat.Enabled = False
		End If
		
	End Sub
	
	Private Sub cmdBlack_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdBlack.Click
		txtRed.Text = CStr(0)
		txtGreen.Text = CStr(0)
		txtBlue.Text = CStr(0)
	End Sub
	
	Private Sub cmdBlue_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdBlue.Click
		txtRed.Text = CStr(0)
		txtGreen.Text = CStr(66)
		txtBlue.Text = CStr(248)
		
	End Sub
	
	Private Sub cmdBrown_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdBrown.Click
		txtRed.Text = CStr(76)
		txtGreen.Text = CStr(42)
		txtBlue.Text = CStr(4)
	End Sub
	
	Private Sub cmdCheat_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCheat.Click
		Dim TheColor As Integer
		CD.ShowColor()
		TheColor = System.Drawing.ColorTranslator.ToOle(CD.Color)
		
		txtRed.Text = CStr((System.Drawing.ColorTranslator.ToOle(CD.Color)) And &HFFs)
		txtGreen.Text = CStr((System.Drawing.ColorTranslator.ToOle(CD.Color) / 256) And &HFFs)
		txtBlue.Text = CStr(((System.Drawing.ColorTranslator.ToOle(CD.Color) / 256) / 256) And &HFFs)
		
	End Sub
	
	Private Sub cmdDGreen_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdDGreen.Click
		txtRed.Text = CStr(16)
		txtGreen.Text = CStr(98)
		txtBlue.Text = CStr(78)
		
	End Sub
	
	Private Sub cmdGreen_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdGreen.Click
		txtRed.Text = CStr(28)
		txtGreen.Text = CStr(190)
		txtBlue.Text = CStr(0)
		
	End Sub
	
	Private Sub cmdLBlue_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdLBlue.Click
		txtRed.Text = CStr(124)
		txtGreen.Text = CStr(190)
		txtBlue.Text = CStr(236)
		
	End Sub
	
	Private Sub cmdOrange_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOrange.Click
		txtRed.Text = CStr(248)
		txtGreen.Text = CStr(136)
		txtBlue.Text = CStr(12)
		
	End Sub
	
	Private Sub cmdPink_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPink.Click
		txtRed.Text = CStr(220)
		txtGreen.Text = CStr(90)
		txtBlue.Text = CStr(172)
		
	End Sub
	
	Private Sub cmdPurple_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPurple.Click
		txtRed.Text = CStr(84)
		txtGreen.Text = CStr(0)
		txtBlue.Text = CStr(124)
		
	End Sub
	
	Private Sub cmdRed_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdRed.Click
		txtRed.Text = CStr(248)
		txtGreen.Text = CStr(2)
		txtBlue.Text = CStr(0)
		
	End Sub
	
	Private Sub cmdTeal_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdTeal.Click
		txtRed.Text = CStr(28)
		txtGreen.Text = CStr(226)
		txtBlue.Text = CStr(180)
		
	End Sub
	
	Private Sub cmdWhite_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdWhite.Click
		txtRed.Text = CStr(255)
		txtGreen.Text = CStr(255)
		txtBlue.Text = CStr(255)
		
	End Sub
	
	Private Sub cmdYellow_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdYellow.Click
		txtRed.Text = CStr(248)
		txtGreen.Text = CStr(250)
		txtBlue.Text = CStr(0)
		
	End Sub
	
	Private Sub cmdGrey_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdGrey.Click
		txtRed.Text = CStr(148)
		txtGreen.Text = CStr(148)
		txtBlue.Text = CStr(148)
		
	End Sub
	
	Private Sub frmMain_Paint(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
		tmrUsage.Interval = 60000
		tmrUsage.Enabled = True
	End Sub
	
	Public Sub mnuFileExit_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuFileExit.Popup
		mnuFileExit_Click(eventSender, eventArgs)
	End Sub
	Public Sub mnuFileExit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuFileExit.Click
		End
	End Sub
	
	Public Sub mnuHelpAbout_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuHelpAbout.Popup
		mnuHelpAbout_Click(eventSender, eventArgs)
	End Sub
	Public Sub mnuHelpAbout_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuHelpAbout.Click
		frmAbout.DefInstance.ShowDialog()
	End Sub
	
	Private Sub tmrUsage_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles tmrUsage.Tick
		' send usage report every minute
		DoUsageReport()
	End Sub
	
	'UPGRADE_WARNING: Event txtBlue.TextChanged may fire when form is intialized. Click for more: 'ms-help://MS.VSCC/commoner/redir/redirect.htm?keyword="vbup2075"'
	Private Sub txtBlue_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtBlue.TextChanged
		If Val(txtBlue.Text) > 255 Then
			txtBlue.Text = "255"
		ElseIf Val(txtBlue.Text) < 0 Then 
			txtBlue.Text = "0"
		End If
		If Val(txtRed.Text) > 255 Then
			txtRed.Text = "255"
		ElseIf Val(txtRed.Text) < 0 Then 
			txtRed.Text = "0"
		End If
		If Val(txtGreen.Text) > 255 Then
			txtGreen.Text = "255"
		ElseIf Val(txtGreen.Text) < 0 Then 
			txtGreen.Text = "0"
		End If
		
		wc3Preview.BackColor = System.Drawing.ColorTranslator.FromOle(GetWar3Color)
	End Sub
	
	'UPGRADE_WARNING: Event txtGreen.TextChanged may fire when form is intialized. Click for more: 'ms-help://MS.VSCC/commoner/redir/redirect.htm?keyword="vbup2075"'
	Private Sub txtGreen_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtGreen.TextChanged
		If Val(txtBlue.Text) > 255 Then
			txtBlue.Text = "255"
		ElseIf Val(txtBlue.Text) < 0 Then 
			txtBlue.Text = "0"
		End If
		If Val(txtRed.Text) > 255 Then
			txtRed.Text = "255"
		ElseIf Val(txtRed.Text) < 0 Then 
			txtRed.Text = "0"
		End If
		If Val(txtGreen.Text) > 255 Then
			txtGreen.Text = "255"
		ElseIf Val(txtGreen.Text) < 0 Then 
			txtGreen.Text = "0"
		End If
		wc3Preview.BackColor = System.Drawing.ColorTranslator.FromOle(GetWar3Color)
	End Sub
	
	'UPGRADE_WARNING: Event txtRed.TextChanged may fire when form is intialized. Click for more: 'ms-help://MS.VSCC/commoner/redir/redirect.htm?keyword="vbup2075"'
	Private Sub txtRed_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtRed.TextChanged
		If Val(txtBlue.Text) > 255 Then
			txtBlue.Text = "255"
		ElseIf Val(txtBlue.Text) < 0 Then 
			txtBlue.Text = "0"
		End If
		If Val(txtRed.Text) > 255 Then
			txtRed.Text = "255"
		ElseIf Val(txtRed.Text) < 0 Then 
			txtRed.Text = "0"
		End If
		If Val(txtGreen.Text) > 255 Then
			txtGreen.Text = "255"
		ElseIf Val(txtGreen.Text) < 0 Then 
			txtGreen.Text = "0"
		End If
		wc3Preview.BackColor = System.Drawing.ColorTranslator.FromOle(GetWar3Color)
	End Sub
	
	Private Sub txtRed_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtRed.Enter
		txtRed.SelectionStart = 0
		txtRed.SelectionLength = Len(txtRed.Text)
		txtGreen.SelectionStart = 0
		txtGreen.SelectionLength = Len(txtGreen.Text)
		txtBlue.SelectionStart = 0
		txtBlue.SelectionLength = Len(txtBlue.Text)
	End Sub
	
	Private Sub txtgreen_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtgreen.Enter
		txtRed.SelectionStart = 0
		txtRed.SelectionLength = Len(txtRed.Text)
		txtGreen.SelectionStart = 0
		txtGreen.SelectionLength = Len(txtGreen.Text)
		txtBlue.SelectionStart = 0
		txtBlue.SelectionLength = Len(txtBlue.Text)
	End Sub
	Private Sub txtblue_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtblue.Enter
		txtRed.SelectionStart = 0
		txtRed.SelectionLength = Len(txtRed.Text)
		txtGreen.SelectionStart = 0
		txtGreen.SelectionLength = Len(txtGreen.Text)
		txtBlue.SelectionStart = 0
		txtBlue.SelectionLength = Len(txtBlue.Text)
	End Sub
	
	Private Sub txtRed_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtRed.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If KeyAscii < &H30s Or KeyAscii > &H39s Then
			KeyAscii = 0
		End If
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	Private Sub txtGreen_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtGreen.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If KeyAscii < &H30s Or KeyAscii > &H39s Then
			KeyAscii = 0
		End If
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	Private Sub txtBlue_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtBlue.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If KeyAscii < &H30s Or KeyAscii > &H39s Then
			KeyAscii = 0
		End If
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub wc2ClearColors_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles wc2ClearColors.Click
		Dim i As Short
		
		For i = 0 To 24
			wc2Colors(i) = "0"
		Next 
		
		Dowc2Change()
		wc2Name.SelStart = 0
		wc2Name.SelLength = Len(wc2Name.Text)
		wc2Name.SelColor = WC2_PreYELLOW
		wc2Name.SelLength = 0
		wc2Name.SelStart = Len(wc2Name.Text)
		wc2Name.Focus()
	End Sub
	Private Sub bwClearColors_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles bwClearColors.Click
		Dim i As Short
		
		For i = 0 To 24
			bwColors(i) = "0"
		Next 
		
		DobwChange()
		bwName.SelStart = 0
		bwName.SelLength = Len(bwName.Text)
		bwName.SelColor = SC_DGREEN
		bwName.SelLength = 0
		bwName.SelStart = Len(bwName.Text)
		bwName.Focus()
	End Sub
	
	
	Private Sub scClearColors_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles scClearColors.Click
		Dim i As Short
		
		For i = 0 To 24
			scColors(i) = "0"
		Next 
		
		DoScChange()
		scName.SelStart = 0
		scName.SelLength = Len(scName.Text)
		scName.SelColor = SC_DGREEN
		scName.SelLength = 0
		scName.SelStart = Len(scName.Text)
		scName.Focus()
	End Sub
	
	Private Sub frmMain_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		GetProcessHandles_Tick(GetProcessHandles, New System.EventArgs())
		tmrUpdate_Tick(tmrUpdate, New System.EventArgs())
		wc3Address = 0
		SC_DGREEN = RGB(91, 204, 52)
		SC_LGREEN = RGB(189, 252, 130)
		SC_BLUE = RGB(175, 189, 249)
		SC_YELLOW = RGB(225, 225, 74)
		SC_WHITE = RGB(255, 255, 255)
		SC_RED = RGB(252, 0, 0)
		SC_GAMEGREEN = RGB(24, 252, 34)
		SC_GREY = RGB(103, 103, 103)
		
		WC2_PreYELLOW = RGB(211, 195, 31)
		WC2_PreRED = RGB(255, 0, 0)
		WC2_PreWHITE = RGB(255, 251, 243)
		WC2_PreBLACK = RGB(1, 1, 1)
		WC2_PreGREY = RGB(159, 159, 159)
		WC2_InYELLOW = RGB(208, 192, 28)
		WC2_InRED = RGB(252, 0, 0)
		WC2_InWHITE = RGB(252, 248, 240)
		WC2_InBLACK = RGB(1, 1, 1)
		WC2_InGREY = RGB(156, 156, 156)
		
		scName.SelColor = SC_DGREEN
		bwName.SelColor = SC_DGREEN
		wc2Name.SelColor = WC2_PreYELLOW
		
		
	End Sub
	
	Private Sub GetProcessHandles_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles GetProcessHandles.Tick
		' Every 5 seconds we're going to try to get the process handles for
		' our games (War2, Starcraft, War3)
		
		scHandle = GetGameHandle("Starcraft", STAR)
		wc2Handle = GetGameHandle("Warcraft II", W2BN)
		bwHandle = GetGameHandle("Brood War", SEXP)
		wc3Handle = GetGameHandle("Warcraft III", WAR3)
		d2Handle = GetGameHandle("Diablo II", vbNullString)
		
		If wc3Address = 0 And wc3Handle <> 0 Then
			GetWar3Address()
		End If
		
		If wc3Handle = 0 Then
			wc3Address = 0
		End If
		
		If ReportCount = 0 Then
			ReportCount = 1
			DoUsageReport()
		End If
		
	End Sub
	
	Function GetGameHandle(ByRef WindowName As String, ByRef GameCode As Object) As Integer
		Dim Window As Integer
		Dim Pid As Integer
		'UPGRADE_NOTE: Handle was upgraded to Handle_Renamed. Click for more: 'ms-help://MS.VSCC/commoner/redir/redirect.htm?keyword="vbup1061"'
		Dim Handle_Renamed As Integer
		
		Window = FindWindow(vbNullString, WindowName)
		GetWindowThreadProcessId(Window, Pid)
		Handle_Renamed = OpenProcess(PROCESS_ALL_ACCESS, False, Pid)
		
		'UPGRADE_WARNING: Couldn't resolve default property of object GameCode. Click for more: 'ms-help://MS.VSCC/commoner/redir/redirect.htm?keyword="vbup1037"'
		If GameCode <> vbNullString Then
			If Handle_Renamed And SB.Panels.Item(GameCode).Enabled <> True Then
				SB.Panels.Item(GameCode).Enabled = True
				SB.Panels.Item(GameCode).Text = "Online"
			ElseIf Handle_Renamed = 0 And SB.Panels.Item(GameCode).Enabled <> False Then 
				SB.Panels.Item(GameCode).Enabled = False
				SB.Panels.Item(GameCode).Text = "Offline"
				SB.Panels(GameCode).Bevel = MSComctlLib.PanelBevelConstants.sbrRaised
			End If
		End If
		
		GetGameHandle = Handle_Renamed
	End Function
	
	Private Sub SB_PanelClick(ByVal eventSender As System.Object, ByVal eventArgs As AxMSComctlLib.IStatusBarEvents_PanelClickEvent) Handles SB.PanelClick
		Dim iIndex As Short
		If eventArgs.Panel.Style <> MSComctlLib.PanelStyleConstants.sbrTime Then
			If eventArgs.Panel.Enabled Then
				For iIndex = 1 To SB.Panels.Count - 1
					If SB.Panels(iIndex).Bevel = MSComctlLib.PanelBevelConstants.sbrInset Then
						SB.Panels(iIndex).Bevel = MSComctlLib.PanelBevelConstants.sbrRaised
						Frame(iIndex).Visible = False
					End If
				Next 
				
				eventArgs.Panel.Bevel = MSComctlLib.PanelBevelConstants.sbrInset
				Frame(eventArgs.Panel.Index).Visible = True
			End If
		End If
	End Sub
	
	'UPGRADE_WARNING: Event scAlignment.SelectedIndexChanged may fire when form is intialized. Click for more: 'ms-help://MS.VSCC/commoner/redir/redirect.htm?keyword="vbup2075"'
	Private Sub scAlignment_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles scAlignment.SelectedIndexChanged
		If VB6.GetItemData(scAlignment, scAlignment.SelectedIndex) = 0 Then
			scName.SelAlignment = 0
		ElseIf VB6.GetItemData(scAlignment, scAlignment.SelectedIndex) = 18 Then 
			scName.SelAlignment = 1
		ElseIf VB6.GetItemData(scAlignment, scAlignment.SelectedIndex) = 19 Then 
			scName.SelAlignment = 2
		End If
		
		DoScChange()
	End Sub
	'UPGRADE_WARNING: Event bwAlignment.SelectedIndexChanged may fire when form is intialized. Click for more: 'ms-help://MS.VSCC/commoner/redir/redirect.htm?keyword="vbup2075"'
	Private Sub bwAlignment_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles bwAlignment.SelectedIndexChanged
		If VB6.GetItemData(bwAlignment, bwAlignment.SelectedIndex) = 0 Then
			bwName.SelAlignment = 0
		ElseIf VB6.GetItemData(bwAlignment, bwAlignment.SelectedIndex) = 18 Then 
			bwName.SelAlignment = 1
		ElseIf VB6.GetItemData(bwAlignment, bwAlignment.SelectedIndex) = 19 Then 
			bwName.SelAlignment = 2
		End If
		
		DobwChange()
	End Sub
	
	Private Sub scGreen_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles scGreen.Click
		scAddColor(cRed, SC_RED)
	End Sub
	Private Sub scGrey_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles scGrey.Click
		scAddColor(cGrey, SC_GREY)
	End Sub
	Private Sub scName_Change(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles scName.Change
		DoScChange()
	End Sub
	Private Sub scPregame_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles scPregame.Enter
		scName.Focus()
	End Sub
	Private Sub scIngame_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles scIngame.Enter
		scName.Focus()
	End Sub
	Private Sub scRed_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles scRed.Click
		scAddColor(cWhite, SC_WHITE)
	End Sub
	Private Sub scWhite_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles scWhite.Click
		scAddColor(cLGreen, SC_LGREEN)
	End Sub
	Private Sub scYellow_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles scYellow.Click
		scAddColor(cNormal, SC_DGREEN)
	End Sub
	Private Sub scNormal_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles scNormal.Click
		scAddColor(cLBlue, SC_BLUE)
	End Sub
	Private Sub scAddColor(ByRef scColor As Short, ByRef rgbColor As Integer)
		Dim i As Short
		
		scName.SelLength = Len(scName.Text)
		scName.SelColor = rgbColor
		
		For i = scName.SelStart To 24
			scColors(i) = "0"
		Next 
		
		scColors(scName.SelStart) = CStr(scColor)
		DoScChange()
		scName.SelLength = 0
		scName.Focus()
	End Sub
	
	
	Private Sub wc2Name_Change(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles wc2Name.Change
		Dowc2Change()
	End Sub
	
	Private Sub wc2Normal_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles wc2Normal.Click
		wc2AddColor(wcNormal, WC2_PreYELLOW)
	End Sub
	
	Private Sub wc2Pregame_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles wc2Pregame.Enter
		wc2Name.Focus()
	End Sub
	Private Sub wc2Ingame_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles wc2Ingame.Enter
		wc2Name.Focus()
	End Sub
	Private Sub wc2AddColor(ByRef wc2Color As Short, ByRef rgbColor As Integer)
		Dim i As Short
		
		wc2Name.SelLength = Len(wc2Name.Text)
		wc2Name.SelColor = rgbColor
		
		For i = wc2Name.SelStart To 24
			wc2Colors(i) = "0"
		Next 
		
		wc2Colors(wc2Name.SelStart) = CStr(wc2Color)
		Dowc2Change()
		wc2Name.SelLength = 0
		wc2Name.Focus()
	End Sub
	Private Sub bwGreen_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles bwGreen.Click
		bwAddColor(cRed, SC_RED)
	End Sub
	Private Sub bwGrey_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles bwGrey.Click
		bwAddColor(cGrey, SC_GREY)
	End Sub
	Private Sub bwName_Change(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles bwName.Change
		DobwChange()
	End Sub
	Private Sub bwPregame_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles bwPregame.Enter
		bwName.Focus()
	End Sub
	Private Sub bwIngame_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles bwIngame.Enter
		bwName.Focus()
	End Sub
	Private Sub bwRed_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles bwRed.Click
		bwAddColor(cWhite, SC_WHITE)
	End Sub
	Private Sub bwWhite_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles bwWhite.Click
		bwAddColor(cLGreen, SC_LGREEN)
	End Sub
	Private Sub bwYellow_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles bwYellow.Click
		bwAddColor(cNormal, SC_DGREEN)
	End Sub
	Private Sub bwNormal_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles bwNormal.Click
		bwAddColor(cLBlue, SC_BLUE)
	End Sub
	Private Sub bwAddColor(ByRef bwColor As Short, ByRef rgbColor As Integer)
		Dim i As Short
		
		bwName.SelLength = Len(bwName.Text)
		bwName.SelColor = rgbColor
		
		For i = bwName.SelStart To 24
			bwColors(i) = "0"
		Next 
		
		bwColors(bwName.SelStart) = CStr(bwColor)
		DobwChange()
		bwName.SelLength = 0
		bwName.Focus()
	End Sub
	
	Private Sub tmrUpdate_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles tmrUpdate.Tick
		' Starcraft
		Dim strBuffer As New VB6.FixedLengthString(24)
		Dim BytesWritten As Integer
		DoScChange()
		DobwChange()
		Dowc2Change()
		Dowc3Change()
		
		ReadProcessMemory(scHandle, scAddress, strBuffer.Value, 24, BytesWritten)
		scDecode(strBuffer.Value)
		
		ReadProcessMemory(bwHandle, bwAddress, strBuffer.Value, 24, BytesWritten)
		bwDecode(strBuffer.Value)
		
		ReadProcessMemory(wc2Handle, wc2Address, strBuffer.Value, 24, BytesWritten)
		wc2Decode(strBuffer.Value)
		
		
		
	End Sub
	
	
	Private Sub scDecode(ByRef Buf As String)
		Dim Output As String
		Dim i As Short
		Dim ColorsGoneOver As Short
		Dim PGColor(24) As Integer ' Pregame Color
		Dim IGColor(24) As Integer ' Ingame Color
		i = 1
		scIngame.Text = ""
		scPregame.Text = ""
		While i < 24 And Asc(Mid(Buf, i, 1)) <> 0
			If Asc(Mid(Buf, i, 1)) < &H20s Then
				Select Case Asc(Mid(Buf, i, 1))
					Case 1
						PGColor(i - ColorsGoneOver) = SC_DGREEN
						IGColor(i - ColorsGoneOver) = SC_BLUE
						ColorsGoneOver = ColorsGoneOver + 1
					Case 2
						PGColor(i - ColorsGoneOver) = SC_BLUE
						IGColor(i - ColorsGoneOver) = SC_BLUE
						ColorsGoneOver = ColorsGoneOver + 1
					Case 3
						PGColor(i - ColorsGoneOver) = SC_DGREEN
						IGColor(i - ColorsGoneOver) = SC_YELLOW
						ColorsGoneOver = ColorsGoneOver + 1
					Case 4
						PGColor(i - ColorsGoneOver) = SC_LGREEN
						IGColor(i - ColorsGoneOver) = SC_WHITE
						ColorsGoneOver = ColorsGoneOver + 1
					Case 5
						PGColor(i - ColorsGoneOver) = SC_GREY
						IGColor(i - ColorsGoneOver) = SC_GREY
						ColorsGoneOver = ColorsGoneOver + 1
					Case 6
						PGColor(i - ColorsGoneOver) = SC_WHITE
						IGColor(i - ColorsGoneOver) = SC_RED
						ColorsGoneOver = ColorsGoneOver + 1
					Case 7
						PGColor(i - ColorsGoneOver) = SC_RED
						IGColor(i - ColorsGoneOver) = SC_GAMEGREEN
						ColorsGoneOver = ColorsGoneOver + 1
					Case &H12s
						MsgBox("The previewed name is very dangerous, it will crash as soon as game starts.  I recomment not using it!", MsgBoxStyle.Critical, "Warning!!")
					Case 18
						scIngame.SelAlignment = 1
						scPregame.SelAlignment = 1
					Case 19
						scIngame.SelAlignment = 2
						scPregame.SelAlignment = 2
				End Select
			Else
				' it was a normal character
				scIngame.Text = scIngame.Text & Mid(Buf, i, 1)
				scPregame.Text = scPregame.Text & Mid(Buf, i, 1)
			End If
			
			i = i + 1
		End While
		
		scIngame.SelStart = 0
		scIngame.SelLength = Len(scIngame.Text)
		scIngame.SelColor = SC_BLUE
		
		scPregame.SelStart = 0
		scPregame.SelLength = Len(scPregame.Text)
		scPregame.SelColor = SC_DGREEN
		
		
		For i = 0 To 24
			If PGColor(i) <> 0 Then
				scPregame.SelStart = i - 1
				scPregame.SelLength = Len(scIngame.Text)
				scPregame.SelColor = PGColor(i)
				
				scIngame.SelStart = i - 1
				scIngame.SelLength = Len(scIngame.Text)
				scIngame.SelColor = IGColor(i)
			End If
		Next 
	End Sub
	
	Private Sub bwDecode(ByRef Buf As String)
		Dim Output As String
		Dim i As Short
		Dim ColorsGoneOver As Short
		Dim PGColor(24) As Integer ' Pregame Color
		Dim IGColor(24) As Integer ' Ingame Color
		i = 1
		bwIngame.Text = ""
		bwPregame.Text = ""
		While i < 24 And Asc(Mid(Buf, i, 1)) <> 0
			If Asc(Mid(Buf, i, 1)) < &H20s Then
				Select Case Asc(Mid(Buf, i, 1))
					Case 1
						PGColor(i - ColorsGoneOver) = SC_DGREEN
						IGColor(i - ColorsGoneOver) = SC_BLUE
						ColorsGoneOver = ColorsGoneOver + 1
					Case 2
						PGColor(i - ColorsGoneOver) = SC_BLUE
						IGColor(i - ColorsGoneOver) = SC_BLUE
						ColorsGoneOver = ColorsGoneOver + 1
					Case 3
						PGColor(i - ColorsGoneOver) = SC_DGREEN
						IGColor(i - ColorsGoneOver) = SC_YELLOW
						ColorsGoneOver = ColorsGoneOver + 1
					Case 4
						PGColor(i - ColorsGoneOver) = SC_LGREEN
						IGColor(i - ColorsGoneOver) = SC_WHITE
						ColorsGoneOver = ColorsGoneOver + 1
					Case 5
						PGColor(i - ColorsGoneOver) = SC_GREY
						IGColor(i - ColorsGoneOver) = SC_GREY
						ColorsGoneOver = ColorsGoneOver + 1
					Case 6
						PGColor(i - ColorsGoneOver) = SC_WHITE
						IGColor(i - ColorsGoneOver) = SC_RED
						ColorsGoneOver = ColorsGoneOver + 1
					Case 7
						PGColor(i - ColorsGoneOver) = SC_RED
						IGColor(i - ColorsGoneOver) = SC_GAMEGREEN
						ColorsGoneOver = ColorsGoneOver + 1
					Case &H12s
						MsgBox("The previewed name is very dangerous, it will crash as soon as game starts.  I recomment not using it!", MsgBoxStyle.Critical, "Warning!!")
					Case 18
						bwIngame.SelAlignment = 1
						bwPregame.SelAlignment = 1
					Case 19
						bwIngame.SelAlignment = 2
						bwPregame.SelAlignment = 2
				End Select
			Else
				' it was a normal character
				bwIngame.Text = bwIngame.Text & Mid(Buf, i, 1)
				bwPregame.Text = bwPregame.Text & Mid(Buf, i, 1)
			End If
			
			i = i + 1
		End While
		
		bwIngame.SelStart = 0
		bwIngame.SelLength = Len(bwIngame.Text)
		bwIngame.SelColor = SC_BLUE
		
		bwPregame.SelStart = 0
		bwPregame.SelLength = Len(bwPregame.Text)
		bwPregame.SelColor = SC_DGREEN
		
		
		For i = 0 To 24
			If PGColor(i) <> 0 Then
				bwPregame.SelStart = i - 1
				bwPregame.SelLength = Len(bwIngame.Text)
				bwPregame.SelColor = PGColor(i)
				
				bwIngame.SelStart = i - 1
				bwIngame.SelLength = Len(bwIngame.Text)
				bwIngame.SelColor = IGColor(i)
			End If
		Next 
	End Sub
	
	Private Sub wc2Decode(ByRef Buf As String)
		Dim Output As String
		Dim i As Short
		Dim ColorsGoneOver As Short
		Dim PGColor(24) As Integer ' Pregame Color
		Dim IGColor(24) As Integer ' Ingame Color
		i = 1
		wc2Ingame.Text = ""
		wc2Pregame.Text = ""
		
		While i < 24 And Asc(Mid(Buf, i, 1)) <> 0
			If Asc(Mid(Buf, i, 1)) < &H20s Then
				Select Case Asc(Mid(Buf, i, 1))
					Case 1
						PGColor(i - ColorsGoneOver) = WC2_PreYELLOW
						IGColor(i - ColorsGoneOver) = WC2_InWHITE
						ColorsGoneOver = ColorsGoneOver + 1
					Case 2
						PGColor(i - ColorsGoneOver) = WC2_PreYELLOW
						IGColor(i - ColorsGoneOver) = WC2_InWHITE
						ColorsGoneOver = ColorsGoneOver + 1
					Case 3
						PGColor(i - ColorsGoneOver) = WC2_PreRED
						IGColor(i - ColorsGoneOver) = WC2_InRED
						ColorsGoneOver = ColorsGoneOver + 1
					Case 4
						PGColor(i - ColorsGoneOver) = WC2_PreWHITE
						IGColor(i - ColorsGoneOver) = WC2_InYELLOW
						ColorsGoneOver = ColorsGoneOver + 1
					Case 5
						PGColor(i - ColorsGoneOver) = WC2_PreGREY
						IGColor(i - ColorsGoneOver) = WC2_InGREY
						ColorsGoneOver = ColorsGoneOver + 1
					Case 6
						PGColor(i - ColorsGoneOver) = WC2_PreBLACK
						IGColor(i - ColorsGoneOver) = WC2_InBLACK
						ColorsGoneOver = ColorsGoneOver + 1
				End Select
			Else
				' it was a normal character
				wc2Ingame.Text = wc2Ingame.Text & Mid(Buf, i, 1)
				wc2Pregame.Text = wc2Pregame.Text & Mid(Buf, i, 1)
			End If
			
			i = i + 1
		End While
		
		wc2Ingame.SelStart = 0
		wc2Ingame.SelLength = Len(wc2Ingame.Text)
		wc2Ingame.SelColor = WC2_InWHITE
		
		wc2Pregame.SelStart = 0
		wc2Pregame.SelLength = Len(wc2Pregame.Text)
		wc2Pregame.SelColor = WC2_PreYELLOW
		
		
		For i = 0 To 24
			If PGColor(i) <> 0 Then
				wc2Pregame.SelStart = i - 1
				wc2Pregame.SelLength = Len(wc2Ingame.Text)
				wc2Pregame.SelColor = PGColor(i)
				
				wc2Ingame.SelStart = i - 1
				wc2Ingame.SelLength = Len(wc2Ingame.Text)
				wc2Ingame.SelColor = IGColor(i)
			End If
		Next 
	End Sub
	
	Private Sub wc2Red_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles wc2Red.Click
		wc2AddColor(wcRed, WC2_PreRED)
	End Sub
	
	Private Sub wc2White_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles wc2White.Click
		wc2AddColor(wcWhite, WC2_PreWHITE)
	End Sub
	Private Sub wc2Black_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles wc2Black.Click
		wc2AddColor(wcBlack, WC2_PreBLACK)
	End Sub
	Private Sub wc2Grey_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles wc2Grey.Click
		wc2AddColor(wcGrey, WC2_PreGREY)
	End Sub
	
	Private Function GetWar3Color() As Integer
		GetWar3Color = RGB(Val(txtRed.Text), Val(txtGreen.Text), Val(txtBlue.Text))
	End Function
	
	'UPGRADE_WARNING: Event frmMain.Resize may fire when form is intialized. Click for more: 'ms-help://MS.VSCC/commoner/redir/redirect.htm?keyword="vbup2075"'
	Private Sub frmMain_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Resize
		If frmMain.DefInstance.WindowState = 1 And Restoring <> True Then
			'UPGRADE_ISSUE: App property App.TaskVisible was not upgraded. Click for more: 'ms-help://MS.VSCC/commoner/redir/redirect.htm?keyword="vbup2069"'
			App.TaskVisible = False
			Me.Hide()
			CreateIcon()
		ElseIf frmMain.DefInstance.WindowState = 0 Then 
			Me.Show()
			'UPGRADE_ISSUE: App property App.TaskVisible was not upgraded. Click for more: 'ms-help://MS.VSCC/commoner/redir/redirect.htm?keyword="vbup2069"'
			App.TaskVisible = True
			Restoring = False
			DeleteIcon()
		End If
	End Sub
	
	Private Sub picSystemTray_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles picSystemTray.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		X = X / VB6.TwipsPerPixelX
		Select Case X
			Case WM_LBUTTONDOWN
				'UPGRADE_ISSUE: Form method frmMain.PopupMenu was not upgraded. Click for more: 'ms-help://MS.VSCC/commoner/redir/redirect.htm?keyword="vbup2064"'
                Me.PopupMenu(mnuST)
			Case WM_RBUTTONDOWN
				'UPGRADE_ISSUE: Form method frmMain.PopupMenu was not upgraded. Click for more: 'ms-help://MS.VSCC/commoner/redir/redirect.htm?keyword="vbup2064"'
				Me.PopupMenu(mnuST)
			Case WM_LBUTTONDBLCLK
				Restoring = True
				'UPGRADE_ISSUE: App property App.TaskVisible was not upgraded. Click for more: 'ms-help://MS.VSCC/commoner/redir/redirect.htm?keyword="vbup2069"'
				App.TaskVisible = True
				Me.Show()
				Me.WindowState = System.Windows.Forms.FormWindowState.Normal
				DeleteIcon()
		End Select
	End Sub
	
	Public Sub mnuSTExit_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuSTExit.Popup
		mnuSTExit_Click(eventSender, eventArgs)
	End Sub
	Public Sub mnuSTExit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuSTExit.Click
		DeleteIcon()
		Me.Close()
		End
	End Sub
	
	Public Sub mnuSTRestore_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuSTRestore.Popup
		mnuSTRestore_Click(eventSender, eventArgs)
	End Sub
	Public Sub mnuSTRestore_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuSTRestore.Click
		Restoring = True
		'UPGRADE_ISSUE: App property App.TaskVisible was not upgraded. Click for more: 'ms-help://MS.VSCC/commoner/redir/redirect.htm?keyword="vbup2069"'
		App.TaskVisible = True
		Me.Show()
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		DeleteIcon()
	End Sub
End Class