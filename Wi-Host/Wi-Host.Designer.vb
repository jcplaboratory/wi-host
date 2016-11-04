<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainboard))
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.comstatus = New System.Windows.Forms.RichTextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmdhns = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cmdstart = New System.Windows.Forms.Button()
        Me.cmdstop = New System.Windows.Forms.Button()
        Me.ok = New System.Windows.Forms.Button()
        Me.comtypeau = New System.Windows.Forms.ComboBox()
        Me.txtspw = New System.Windows.Forms.TextBox()
        Me.txtssid = New System.Windows.Forms.TextBox()
        Me.commode = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetupNewHostedNetworkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewAdaptersDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HowToSetupInternetConnectionSharingICSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HostedNetworkSupportedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutWiHostToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblinterface_true = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblsns_true = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.TabControl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.TabPage1)
        Me.TabControl.Controls.Add(Me.TabPage2)
        Me.TabControl.Controls.Add(Me.TabPage3)
        Me.TabControl.Location = New System.Drawing.Point(12, 27)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(510, 336)
        Me.TabControl.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(502, 310)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Wi-Host Network Status"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.comstatus)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(487, 295)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Wifi Hosted Network Status:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Wi_Host.My.Resources.Resources.hotspot_icon1
        Me.PictureBox1.Location = New System.Drawing.Point(6, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(153, 132)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'comstatus
        '
        Me.comstatus.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.comstatus.Location = New System.Drawing.Point(165, 35)
        Me.comstatus.Name = "comstatus"
        Me.comstatus.ReadOnly = True
        Me.comstatus.Size = New System.Drawing.Size(316, 200)
        Me.comstatus.TabIndex = 5
        Me.comstatus.Text = ""
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmdhns)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 241)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(472, 48)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Component"
        '
        'cmdhns
        '
        Me.cmdhns.Location = New System.Drawing.Point(291, 19)
        Me.cmdhns.Name = "cmdhns"
        Me.cmdhns.Size = New System.Drawing.Size(171, 23)
        Me.cmdhns.TabIndex = 4
        Me.cmdhns.Text = "Hosted Network Supported?"
        Me.cmdhns.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(157, 19)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(128, 24)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "&View Adapters' Details"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(7, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(144, 24)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "&Setup Hosted Network>"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(162, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Hosted Network Status:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(502, 310)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Setup New Hosted Network"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.comtypeau)
        Me.GroupBox3.Controls.Add(Me.txtspw)
        Me.GroupBox3.Controls.Add(Me.txtssid)
        Me.GroupBox3.Controls.Add(Me.commode)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.PictureBox2)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(487, 295)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Setup New Wifi Hosted Network"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cmdstart)
        Me.GroupBox4.Controls.Add(Me.cmdstop)
        Me.GroupBox4.Controls.Add(Me.ok)
        Me.GroupBox4.Location = New System.Drawing.Point(9, 241)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(472, 48)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Setup and Configuration"
        '
        'cmdstart
        '
        Me.cmdstart.Location = New System.Drawing.Point(304, 19)
        Me.cmdstart.Name = "cmdstart"
        Me.cmdstart.Size = New System.Drawing.Size(120, 23)
        Me.cmdstart.TabIndex = 7
        Me.cmdstart.Text = "Star&t Hosted Network"
        Me.cmdstart.UseVisualStyleBackColor = True
        '
        'cmdstop
        '
        Me.cmdstop.Location = New System.Drawing.Point(177, 19)
        Me.cmdstop.Name = "cmdstop"
        Me.cmdstop.Size = New System.Drawing.Size(121, 23)
        Me.cmdstop.TabIndex = 1
        Me.cmdstop.Text = "Sto&p Hosted Network"
        Me.cmdstop.UseVisualStyleBackColor = True
        '
        'ok
        '
        Me.ok.Location = New System.Drawing.Point(50, 19)
        Me.ok.Name = "ok"
        Me.ok.Size = New System.Drawing.Size(121, 23)
        Me.ok.TabIndex = 0
        Me.ok.Text = "&Setup Network"
        Me.ok.UseVisualStyleBackColor = True
        '
        'comtypeau
        '
        Me.comtypeau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comtypeau.FormattingEnabled = True
        Me.comtypeau.Items.AddRange(New Object() {"WPA2-Personal"})
        Me.comtypeau.Location = New System.Drawing.Point(152, 128)
        Me.comtypeau.Name = "comtypeau"
        Me.comtypeau.Size = New System.Drawing.Size(145, 21)
        Me.comtypeau.TabIndex = 5
        '
        'txtspw
        '
        Me.txtspw.Location = New System.Drawing.Point(152, 67)
        Me.txtspw.MaxLength = 32
        Me.txtspw.Name = "txtspw"
        Me.txtspw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtspw.Size = New System.Drawing.Size(145, 20)
        Me.txtspw.TabIndex = 4
        '
        'txtssid
        '
        Me.txtssid.Location = New System.Drawing.Point(152, 39)
        Me.txtssid.Name = "txtssid"
        Me.txtssid.Size = New System.Drawing.Size(145, 20)
        Me.txtssid.TabIndex = 3
        '
        'commode
        '
        Me.commode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.commode.Enabled = False
        Me.commode.FormattingEnabled = True
        Me.commode.Items.AddRange(New Object() {"Allow", "Disallow"})
        Me.commode.Location = New System.Drawing.Point(152, 97)
        Me.commode.Name = "commode"
        Me.commode.Size = New System.Drawing.Size(145, 21)
        Me.commode.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(38, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Hosted Network Key:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "New Network Name (SSID):"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(40, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Authentification type:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Hosted Network Mode:"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Wi_Host.My.Resources.Resources.signal
        Me.PictureBox2.Location = New System.Drawing.Point(353, 39)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(128, 128)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Label8)
        Me.TabPage3.Controls.Add(Me.LinkLabel2)
        Me.TabPage3.Controls.Add(Me.Label6)
        Me.TabPage3.Controls.Add(Me.Label7)
        Me.TabPage3.Controls.Add(Me.PictureBox3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(502, 310)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "About Wi-Host"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 292)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(168, 15)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "©J.C.P Laboratory 2008-2013" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.LinkColor = System.Drawing.SystemColors.HotTrack
        Me.LinkLabel2.Location = New System.Drawing.Point(209, 208)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(94, 20)
        Me.LinkLabel2.TabIndex = 7
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "AskVG.com"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(209, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(282, 180)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = resources.GetString("Label6.Text")
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(209, 3)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(252, 20)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Wi-Host | Wifi Hosted Network"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Wi_Host.My.Resources.Resources.Wireless_H
        Me.PictureBox3.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(200, 200)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 9
        Me.PictureBox3.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(352, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(168, 15)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "©J.C.P Laboratory 2008-2013" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(534, 24)
        Me.MenuStrip.TabIndex = 10
        Me.MenuStrip.Text = "MenuStrip"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SetupNewHostedNetworkToolStripMenuItem, Me.ViewAdaptersDetailsToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "&Menu"
        '
        'SetupNewHostedNetworkToolStripMenuItem
        '
        Me.SetupNewHostedNetworkToolStripMenuItem.Image = Global.Wi_Host.My.Resources.Resources.Wireless_H
        Me.SetupNewHostedNetworkToolStripMenuItem.Name = "SetupNewHostedNetworkToolStripMenuItem"
        Me.SetupNewHostedNetworkToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.SetupNewHostedNetworkToolStripMenuItem.Text = "&Setup New Hosted Network"
        '
        'ViewAdaptersDetailsToolStripMenuItem
        '
        Me.ViewAdaptersDetailsToolStripMenuItem.Name = "ViewAdaptersDetailsToolStripMenuItem"
        Me.ViewAdaptersDetailsToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.ViewAdaptersDetailsToolStripMenuItem.Text = "View Adapters' Details"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HowToSetupInternetConnectionSharingICSToolStripMenuItem, Me.HostedNetworkSupportedToolStripMenuItem, Me.AboutWiHostToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'HowToSetupInternetConnectionSharingICSToolStripMenuItem
        '
        Me.HowToSetupInternetConnectionSharingICSToolStripMenuItem.Name = "HowToSetupInternetConnectionSharingICSToolStripMenuItem"
        Me.HowToSetupInternetConnectionSharingICSToolStripMenuItem.Size = New System.Drawing.Size(325, 22)
        Me.HowToSetupInternetConnectionSharingICSToolStripMenuItem.Text = "How to setup Internet Connection Sharing (ICS)"
        '
        'HostedNetworkSupportedToolStripMenuItem
        '
        Me.HostedNetworkSupportedToolStripMenuItem.Name = "HostedNetworkSupportedToolStripMenuItem"
        Me.HostedNetworkSupportedToolStripMenuItem.Size = New System.Drawing.Size(325, 22)
        Me.HostedNetworkSupportedToolStripMenuItem.Text = "Hosted Network Supported?"
        '
        'AboutWiHostToolStripMenuItem
        '
        Me.AboutWiHostToolStripMenuItem.Image = Global.Wi_Host.My.Resources.Resources.info
        Me.AboutWiHostToolStripMenuItem.Name = "AboutWiHostToolStripMenuItem"
        Me.AboutWiHostToolStripMenuItem.Size = New System.Drawing.Size(325, 22)
        Me.AboutWiHostToolStripMenuItem.Text = "About Wi-Host"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(11, 366)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(142, 13)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Wireless Interface presence:"
        '
        'lblinterface_true
        '
        Me.lblinterface_true.AutoSize = True
        Me.lblinterface_true.Location = New System.Drawing.Point(159, 366)
        Me.lblinterface_true.Name = "lblinterface_true"
        Me.lblinterface_true.Size = New System.Drawing.Size(21, 13)
        Me.lblinterface_true.TabIndex = 12
        Me.lblinterface_true.Text = "No"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(186, 366)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(139, 13)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Hosted Network Supported:"
        '
        'lblsns_true
        '
        Me.lblsns_true.AutoSize = True
        Me.lblsns_true.Location = New System.Drawing.Point(331, 366)
        Me.lblsns_true.Name = "lblsns_true"
        Me.lblsns_true.Size = New System.Drawing.Size(53, 13)
        Me.lblsns_true.TabIndex = 13
        Me.lblsns_true.Text = "Unknown"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.SystemColors.HotTrack
        Me.LinkLabel1.Location = New System.Drawing.Point(428, 362)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(94, 20)
        Me.LinkLabel1.TabIndex = 7
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "AskVG.com"
        '
        'mainboard
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 384)
        Me.Controls.Add(Me.lblsns_true)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.lblinterface_true)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.MenuStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip
        Me.MaximizeBox = False
        Me.Name = "mainboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Wi-Host | Wi-Fi Hosted Network"
        Me.TabControl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdhns As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents comstatus As System.Windows.Forms.RichTextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents txtspw As System.Windows.Forms.TextBox
    Friend WithEvents txtssid As System.Windows.Forms.TextBox
    Friend WithEvents commode As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents comtypeau As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ok As System.Windows.Forms.Button
    Friend WithEvents cmdstart As System.Windows.Forms.Button
    Friend WithEvents cmdstop As System.Windows.Forms.Button
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetupNewHostedNetworkToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewAdaptersDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HostedNetworkSupportedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutWiHostToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblinterface_true As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblsns_true As System.Windows.Forms.Label
    Friend WithEvents HowToSetupInternetConnectionSharingICSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel

End Class
