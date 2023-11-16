<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Scanner
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.txtTicketCode = New System.Windows.Forms.TextBox()
        Me.lblTicketCode = New System.Windows.Forms.Label()
        Me.btnScan = New System.Windows.Forms.Button()
        Me.lblRemainingTickets = New System.Windows.Forms.Label()
        Me.nudTicketsToUse = New System.Windows.Forms.NumericUpDown()
        Me.lblTixToUse = New System.Windows.Forms.Label()
        Me.btnUseTix = New System.Windows.Forms.Button()
        Me.btnHomepage = New System.Windows.Forms.Button()
        Me.lblArea = New System.Windows.Forms.Label()
        Me.cbxArea = New System.Windows.Forms.ComboBox()
        CType(Me.nudTicketsToUse, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(128, 29)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(110, 23)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Scan Tickets"
        '
        'txtTicketCode
        '
        Me.txtTicketCode.BackColor = System.Drawing.Color.PaleVioletRed
        Me.txtTicketCode.Location = New System.Drawing.Point(105, 145)
        Me.txtTicketCode.Name = "txtTicketCode"
        Me.txtTicketCode.Size = New System.Drawing.Size(160, 24)
        Me.txtTicketCode.TabIndex = 2
        '
        'lblTicketCode
        '
        Me.lblTicketCode.AutoSize = True
        Me.lblTicketCode.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTicketCode.Location = New System.Drawing.Point(146, 125)
        Me.lblTicketCode.Name = "lblTicketCode"
        Me.lblTicketCode.Size = New System.Drawing.Size(80, 17)
        Me.lblTicketCode.TabIndex = 3
        Me.lblTicketCode.Text = "Ticket Code:"
        '
        'btnScan
        '
        Me.btnScan.BackColor = System.Drawing.Color.PaleVioletRed
        Me.btnScan.Location = New System.Drawing.Point(105, 190)
        Me.btnScan.Name = "btnScan"
        Me.btnScan.Size = New System.Drawing.Size(160, 31)
        Me.btnScan.TabIndex = 10
        Me.btnScan.Text = "Scan"
        Me.btnScan.UseVisualStyleBackColor = False
        '
        'lblRemainingTickets
        '
        Me.lblRemainingTickets.AutoSize = True
        Me.lblRemainingTickets.Location = New System.Drawing.Point(79, 256)
        Me.lblRemainingTickets.Name = "lblRemainingTickets"
        Me.lblRemainingTickets.Size = New System.Drawing.Size(49, 19)
        Me.lblRemainingTickets.TabIndex = 11
        Me.lblRemainingTickets.Text = "Label1"
        Me.lblRemainingTickets.Visible = False
        '
        'nudTicketsToUse
        '
        Me.nudTicketsToUse.BackColor = System.Drawing.Color.PaleVioletRed
        Me.nudTicketsToUse.Location = New System.Drawing.Point(143, 313)
        Me.nudTicketsToUse.Name = "nudTicketsToUse"
        Me.nudTicketsToUse.Size = New System.Drawing.Size(80, 24)
        Me.nudTicketsToUse.TabIndex = 12
        Me.nudTicketsToUse.Visible = False
        '
        'lblTixToUse
        '
        Me.lblTixToUse.AutoSize = True
        Me.lblTixToUse.Location = New System.Drawing.Point(79, 291)
        Me.lblTixToUse.Name = "lblTixToUse"
        Me.lblTixToUse.Size = New System.Drawing.Size(211, 19)
        Me.lblTixToUse.TabIndex = 13
        Me.lblTixToUse.Text = "Select Number of Tickets to Use:"
        Me.lblTixToUse.Visible = False
        '
        'btnUseTix
        '
        Me.btnUseTix.BackColor = System.Drawing.Color.PaleVioletRed
        Me.btnUseTix.Location = New System.Drawing.Point(102, 355)
        Me.btnUseTix.Name = "btnUseTix"
        Me.btnUseTix.Size = New System.Drawing.Size(160, 31)
        Me.btnUseTix.TabIndex = 14
        Me.btnUseTix.Text = "Use Tickets"
        Me.btnUseTix.UseVisualStyleBackColor = False
        Me.btnUseTix.Visible = False
        '
        'btnHomepage
        '
        Me.btnHomepage.BackColor = System.Drawing.Color.PaleVioletRed
        Me.btnHomepage.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHomepage.Location = New System.Drawing.Point(289, 0)
        Me.btnHomepage.Name = "btnHomepage"
        Me.btnHomepage.Size = New System.Drawing.Size(78, 31)
        Me.btnHomepage.TabIndex = 15
        Me.btnHomepage.Text = "Homepage"
        Me.btnHomepage.UseVisualStyleBackColor = False
        '
        'lblArea
        '
        Me.lblArea.AutoSize = True
        Me.lblArea.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArea.Location = New System.Drawing.Point(167, 67)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(38, 17)
        Me.lblArea.TabIndex = 17
        Me.lblArea.Text = "Area:"
        '
        'cbxArea
        '
        Me.cbxArea.BackColor = System.Drawing.Color.PaleVioletRed
        Me.cbxArea.FormattingEnabled = True
        Me.cbxArea.Location = New System.Drawing.Point(105, 87)
        Me.cbxArea.Name = "cbxArea"
        Me.cbxArea.Size = New System.Drawing.Size(160, 27)
        Me.cbxArea.TabIndex = 19
        '
        'Scanner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.ClientSize = New System.Drawing.Size(368, 239)
        Me.Controls.Add(Me.cbxArea)
        Me.Controls.Add(Me.lblArea)
        Me.Controls.Add(Me.btnHomepage)
        Me.Controls.Add(Me.btnUseTix)
        Me.Controls.Add(Me.lblTixToUse)
        Me.Controls.Add(Me.nudTicketsToUse)
        Me.Controls.Add(Me.lblRemainingTickets)
        Me.Controls.Add(Me.btnScan)
        Me.Controls.Add(Me.lblTicketCode)
        Me.Controls.Add(Me.txtTicketCode)
        Me.Controls.Add(Me.lblTitle)
        Me.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Scanner"
        Me.Text = "Scanner"
        CType(Me.nudTicketsToUse, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents txtTicketCode As TextBox
    Friend WithEvents lblTicketCode As Label
    Friend WithEvents btnScan As Button
    Friend WithEvents lblRemainingTickets As Label
    Friend WithEvents nudTicketsToUse As NumericUpDown
    Friend WithEvents lblTixToUse As Label
    Friend WithEvents btnUseTix As Button
    Friend WithEvents btnHomepage As Button
    Friend WithEvents lblArea As Label
    Friend WithEvents cbxArea As ComboBox
End Class
