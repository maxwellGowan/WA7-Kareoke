<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKaraoke
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKaraoke))
        Me.cboSelectAction = New System.Windows.Forms.ComboBox()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.txtValue = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboSelectAction
        '
        Me.cboSelectAction.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSelectAction.FormattingEnabled = True
        Me.cboSelectAction.Items.AddRange(New Object() {"Number of Songs ($2.99 per song)", "Hours in Private Karaoke Booth ($8.99 per hour)"})
        Me.cboSelectAction.Location = New System.Drawing.Point(345, 89)
        Me.cboSelectAction.Name = "cboSelectAction"
        Me.cboSelectAction.Size = New System.Drawing.Size(443, 28)
        Me.cboSelectAction.TabIndex = 0
        Me.cboSelectAction.Text = "Customize Your Night:"
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.SystemColors.Control
        Me.lblHeader.Location = New System.Drawing.Point(366, 21)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(356, 39)
        Me.lblHeader.TabIndex = 2
        Me.lblHeader.Text = "Karaoke Music Night"
        '
        'lblDisplay
        '
        Me.lblDisplay.AutoSize = True
        Me.lblDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplay.ForeColor = System.Drawing.SystemColors.Control
        Me.lblDisplay.Location = New System.Drawing.Point(413, 198)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(95, 18)
        Me.lblDisplay.TabIndex = 3
        Me.lblDisplay.Text = "placeholder"
        '
        'txtValue
        '
        Me.txtValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValue.Location = New System.Drawing.Point(543, 233)
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Size = New System.Drawing.Size(55, 24)
        Me.txtValue.TabIndex = 4
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(454, 312)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(103, 36)
        Me.btnCalculate.TabIndex = 5
        Me.btnCalculate.Text = "Total Cost"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(605, 312)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(117, 36)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear Form"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost.ForeColor = System.Drawing.SystemColors.Control
        Me.lblCost.Location = New System.Drawing.Point(451, 391)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(95, 18)
        Me.lblCost.TabIndex = 7
        Me.lblCost.Text = "placeholder"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-6, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(324, 455)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'frmKaraoke
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtValue)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.cboSelectAction)
        Me.Name = "frmKaraoke"
        Me.Text = "Karaoke Music Night"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboSelectAction As ComboBox
    Friend WithEvents lblHeader As Label
    Friend WithEvents lblDisplay As Label
    Friend WithEvents txtValue As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblCost As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
