<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Setup_ICS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Setup_ICS))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cmdok = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 12)
        Me.Label1.MaximumSize = New System.Drawing.Size(403, 130)
        Me.Label1.MinimumSize = New System.Drawing.Size(403, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(403, 130)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Wi_Host.My.Resources.Resources.info
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'cmdok
        '
        Me.cmdok.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdok.Location = New System.Drawing.Point(203, 220)
        Me.cmdok.Name = "cmdok"
        Me.cmdok.Size = New System.Drawing.Size(75, 23)
        Me.cmdok.TabIndex = 2
        Me.cmdok.Text = "&OK"
        Me.cmdok.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(53, 145)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(153, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Open &Network Connections"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Setup_ICS
        '
        Me.AcceptButton = Me.cmdok
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 255)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmdok)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Setup_ICS"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Wi-Host | Setup ICS"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cmdok As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
