<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CaseNumber
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
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.CaseNumberLabel = New System.Windows.Forms.Label()
        Me.CaseNumberPanel = New System.Windows.Forms.Panel()
        Me.OtherReportsLabel = New System.Windows.Forms.Label()
        Me.ExpenseReportButton = New System.Windows.Forms.Button()
        Me.CostReportButton = New System.Windows.Forms.Button()
        Me.InventoryReportButton = New System.Windows.Forms.Button()
        Me.NewArrivalButton = New System.Windows.Forms.Button()
        Me.ClientReportButton = New System.Windows.Forms.Button()
        Me.CaseNumberInput = New System.Windows.Forms.TextBox()
        Me.CaseNumberLogo = New System.Windows.Forms.PictureBox()
        Me.InventoryReportToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.CostReportToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ExpenseReportToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.CaseNumberPanel.SuspendLayout()
        CType(Me.CaseNumberLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.Location = New System.Drawing.Point(353, 53)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(345, 34)
        Me.TitleLabel.TabIndex = 0
        Me.TitleLabel.Text = "Animal Records System"
        Me.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CaseNumberLabel
        '
        Me.CaseNumberLabel.AutoSize = True
        Me.CaseNumberLabel.Font = New System.Drawing.Font("Arial", 15.75!)
        Me.CaseNumberLabel.Location = New System.Drawing.Point(90, 80)
        Me.CaseNumberLabel.Name = "CaseNumberLabel"
        Me.CaseNumberLabel.Size = New System.Drawing.Size(137, 24)
        Me.CaseNumberLabel.TabIndex = 2
        Me.CaseNumberLabel.Text = "Case Number"
        '
        'CaseNumberPanel
        '
        Me.CaseNumberPanel.Controls.Add(Me.OtherReportsLabel)
        Me.CaseNumberPanel.Controls.Add(Me.ExpenseReportButton)
        Me.CaseNumberPanel.Controls.Add(Me.CostReportButton)
        Me.CaseNumberPanel.Controls.Add(Me.InventoryReportButton)
        Me.CaseNumberPanel.Controls.Add(Me.NewArrivalButton)
        Me.CaseNumberPanel.Controls.Add(Me.ClientReportButton)
        Me.CaseNumberPanel.Controls.Add(Me.CaseNumberInput)
        Me.CaseNumberPanel.Controls.Add(Me.CaseNumberLabel)
        Me.CaseNumberPanel.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CaseNumberPanel.Location = New System.Drawing.Point(12, 132)
        Me.CaseNumberPanel.Name = "CaseNumberPanel"
        Me.CaseNumberPanel.Size = New System.Drawing.Size(849, 324)
        Me.CaseNumberPanel.TabIndex = 3
        '
        'OtherReportsLabel
        '
        Me.OtherReportsLabel.AutoSize = True
        Me.OtherReportsLabel.Font = New System.Drawing.Font("Arial", 15.75!)
        Me.OtherReportsLabel.Location = New System.Drawing.Point(601, 84)
        Me.OtherReportsLabel.Name = "OtherReportsLabel"
        Me.OtherReportsLabel.Size = New System.Drawing.Size(142, 24)
        Me.OtherReportsLabel.TabIndex = 8
        Me.OtherReportsLabel.Text = "Other Reports"
        '
        'ExpenseReportButton
        '
        Me.ExpenseReportButton.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExpenseReportButton.Location = New System.Drawing.Point(594, 180)
        Me.ExpenseReportButton.Name = "ExpenseReportButton"
        Me.ExpenseReportButton.Size = New System.Drawing.Size(158, 30)
        Me.ExpenseReportButton.TabIndex = 5
        Me.ExpenseReportButton.Text = "Expense Report"
        Me.ExpenseReportToolTip.SetToolTip(Me.ExpenseReportButton, "List of total expenses for all animals in the shelter.")
        Me.ExpenseReportButton.UseVisualStyleBackColor = True
        '
        'CostReportButton
        '
        Me.CostReportButton.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CostReportButton.Location = New System.Drawing.Point(273, 124)
        Me.CostReportButton.Name = "CostReportButton"
        Me.CostReportButton.Size = New System.Drawing.Size(158, 30)
        Me.CostReportButton.TabIndex = 2
        Me.CostReportButton.Text = "Cost Report"
        Me.CostReportToolTip.SetToolTip(Me.CostReportButton, "A detailed list of all the expenses for an animal.")
        Me.CostReportButton.UseVisualStyleBackColor = True
        '
        'InventoryReportButton
        '
        Me.InventoryReportButton.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InventoryReportButton.Location = New System.Drawing.Point(594, 128)
        Me.InventoryReportButton.Name = "InventoryReportButton"
        Me.InventoryReportButton.Size = New System.Drawing.Size(158, 30)
        Me.InventoryReportButton.TabIndex = 4
        Me.InventoryReportButton.Text = "Inventory Report"
        Me.InventoryReportToolTip.SetToolTip(Me.InventoryReportButton, "List of every animal in the shelter and its location.")
        Me.InventoryReportButton.UseVisualStyleBackColor = True
        '
        'NewArrivalButton
        '
        Me.NewArrivalButton.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewArrivalButton.Location = New System.Drawing.Point(184, 189)
        Me.NewArrivalButton.Name = "NewArrivalButton"
        Me.NewArrivalButton.Size = New System.Drawing.Size(158, 30)
        Me.NewArrivalButton.TabIndex = 3
        Me.NewArrivalButton.Text = "New Arrival"
        Me.NewArrivalButton.UseVisualStyleBackColor = True
        '
        'ClientReportButton
        '
        Me.ClientReportButton.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClientReportButton.Location = New System.Drawing.Point(94, 124)
        Me.ClientReportButton.Name = "ClientReportButton"
        Me.ClientReportButton.Size = New System.Drawing.Size(158, 30)
        Me.ClientReportButton.TabIndex = 1
        Me.ClientReportButton.Text = "Client Report"
        Me.ClientReportButton.UseVisualStyleBackColor = True
        '
        'CaseNumberInput
        '
        Me.CaseNumberInput.Location = New System.Drawing.Point(233, 76)
        Me.CaseNumberInput.Name = "CaseNumberInput"
        Me.CaseNumberInput.Size = New System.Drawing.Size(198, 32)
        Me.CaseNumberInput.TabIndex = 0
        '
        'CaseNumberLogo
        '
        Me.CaseNumberLogo.Image = Global.FurryFriendsRecordsDatabase.My.Resources.Resources.FFLogo
        Me.CaseNumberLogo.Location = New System.Drawing.Point(129, 18)
        Me.CaseNumberLogo.Name = "CaseNumberLogo"
        Me.CaseNumberLogo.Size = New System.Drawing.Size(225, 98)
        Me.CaseNumberLogo.TabIndex = 4
        Me.CaseNumberLogo.TabStop = False
        '
        'CaseNumber
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(884, 564)
        Me.Controls.Add(Me.CaseNumberLogo)
        Me.Controls.Add(Me.CaseNumberPanel)
        Me.Controls.Add(Me.TitleLabel)
        Me.Name = "CaseNumber"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Furry Friends Animal Records System"
        Me.CaseNumberPanel.ResumeLayout(False)
        Me.CaseNumberPanel.PerformLayout()
        CType(Me.CaseNumberLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TitleLabel As System.Windows.Forms.Label
    Friend WithEvents CaseNumberLabel As System.Windows.Forms.Label
    Friend WithEvents CaseNumberPanel As System.Windows.Forms.Panel
    Friend WithEvents NewArrivalButton As System.Windows.Forms.Button
    Friend WithEvents ClientReportButton As System.Windows.Forms.Button
    Friend WithEvents CaseNumberInput As System.Windows.Forms.TextBox
    Friend WithEvents CaseNumberLogo As System.Windows.Forms.PictureBox
    Friend WithEvents ExpenseReportButton As System.Windows.Forms.Button
    Friend WithEvents CostReportButton As System.Windows.Forms.Button
    Friend WithEvents InventoryReportButton As System.Windows.Forms.Button
    Friend WithEvents InventoryReportToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ExpenseReportToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents CostReportToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents OtherReportsLabel As System.Windows.Forms.Label

End Class
