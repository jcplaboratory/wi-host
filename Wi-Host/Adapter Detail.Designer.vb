<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Adapter_Detail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Adapter_Detail))
        Me.dt = New System.Windows.Forms.RichTextBox()
        Me.cmdok = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dt
        '
        Me.dt.BackColor = System.Drawing.SystemColors.Control
        Me.dt.Location = New System.Drawing.Point(86, 12)
        Me.dt.Name = "dt"
        Me.dt.ReadOnly = True
        Me.dt.Size = New System.Drawing.Size(454, 459)
        Me.dt.TabIndex = 1
        Me.dt.Text = ""
        '
        'cmdok
        '
        Me.cmdok.Location = New System.Drawing.Point(240, 477)
        Me.cmdok.Name = "cmdok"
        Me.cmdok.Size = New System.Drawing.Size(75, 23)
        Me.cmdok.TabIndex = 2
        Me.cmdok.Text = "&OK"
        Me.cmdok.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Wi_Host.My.Resources.Resources.wireless
        Me.PictureBox1.Location = New System.Drawing.Point(12, 183)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(68, 69)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Adapter_Detail
        '
        Me.AcceptButton = Me.cmdok
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 505)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdok)
        Me.Controls.Add(Me.dt)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Adapter_Detail"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Wifi Adapters' Driver Details"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents dt As System.Windows.Forms.RichTextBox
    Friend WithEvents cmdok As System.Windows.Forms.Button
End Class
