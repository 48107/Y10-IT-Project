<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Seller
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
        Me.lblArea = New System.Windows.Forms.Label()
        Me.cbxArea = New System.Windows.Forms.ComboBox()
        Me.lblPaidTickets = New System.Windows.Forms.Label()
        Me.lblFreeTickets = New System.Windows.Forms.Label()
        Me.lblPrice_Label = New System.Windows.Forms.Label()
        Me.lblPrice_Output = New System.Windows.Forms.Label()
        Me.btnCharge = New System.Windows.Forms.Button()
        Me.btnHomepage = New System.Windows.Forms.Button()
        Me.nudPaidTix = New System.Windows.Forms.NumericUpDown()
        Me.nudFreeTix = New System.Windows.Forms.NumericUpDown()
        CType(Me.nudPaidTix, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudFreeTix, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(149, 25)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(102, 23)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Sell Tickets"
        '
        'lblArea
        '
        Me.lblArea.AutoSize = True
        Me.lblArea.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArea.Location = New System.Drawing.Point(21, 72)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(47, 20)
        Me.lblArea.TabIndex = 1
        Me.lblArea.Text = "Area:"
        '
        'cbxArea
        '
        Me.cbxArea.BackColor = System.Drawing.Color.PaleVioletRed
        Me.cbxArea.FormattingEnabled = True
        Me.cbxArea.Location = New System.Drawing.Point(168, 70)
        Me.cbxArea.Name = "cbxArea"
        Me.cbxArea.Size = New System.Drawing.Size(192, 27)
        Me.cbxArea.TabIndex = 2
        '
        'lblPaidTickets
        '
        Me.lblPaidTickets.AutoSize = True
        Me.lblPaidTickets.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaidTickets.Location = New System.Drawing.Point(21, 121)
        Me.lblPaidTickets.Name = "lblPaidTickets"
        Me.lblPaidTickets.Size = New System.Drawing.Size(132, 20)
        Me.lblPaidTickets.TabIndex = 3
        Me.lblPaidTickets.Text = "# of Paid Tickets:"
        '
        'lblFreeTickets
        '
        Me.lblFreeTickets.AutoSize = True
        Me.lblFreeTickets.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFreeTickets.Location = New System.Drawing.Point(21, 169)
        Me.lblFreeTickets.Name = "lblFreeTickets"
        Me.lblFreeTickets.Size = New System.Drawing.Size(133, 20)
        Me.lblFreeTickets.TabIndex = 5
        Me.lblFreeTickets.Text = "# of Free Tickets:"
        '
        'lblPrice_Label
        '
        Me.lblPrice_Label.AutoSize = True
        Me.lblPrice_Label.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice_Label.Location = New System.Drawing.Point(21, 239)
        Me.lblPrice_Label.Name = "lblPrice_Label"
        Me.lblPrice_Label.Size = New System.Drawing.Size(90, 20)
        Me.lblPrice_Label.TabIndex = 7
        Me.lblPrice_Label.Text = "Total Price:"
        '
        'lblPrice_Output
        '
        Me.lblPrice_Output.AutoSize = True
        Me.lblPrice_Output.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice_Output.Location = New System.Drawing.Point(164, 239)
        Me.lblPrice_Output.Name = "lblPrice_Output"
        Me.lblPrice_Output.Size = New System.Drawing.Size(27, 20)
        Me.lblPrice_Output.TabIndex = 8
        Me.lblPrice_Output.Text = "$0"
        '
        'btnCharge
        '
        Me.btnCharge.BackColor = System.Drawing.Color.PaleVioletRed
        Me.btnCharge.Location = New System.Drawing.Point(113, 312)
        Me.btnCharge.Name = "btnCharge"
        Me.btnCharge.Size = New System.Drawing.Size(184, 31)
        Me.btnCharge.TabIndex = 9
        Me.btnCharge.Text = "Charge and Issue Tickets"
        Me.btnCharge.UseVisualStyleBackColor = False
        '
        'btnHomepage
        '
        Me.btnHomepage.BackColor = System.Drawing.Color.PaleVioletRed
        Me.btnHomepage.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHomepage.Location = New System.Drawing.Point(323, 3)
        Me.btnHomepage.Name = "btnHomepage"
        Me.btnHomepage.Size = New System.Drawing.Size(78, 31)
        Me.btnHomepage.TabIndex = 10
        Me.btnHomepage.Text = "Homepage"
        Me.btnHomepage.UseVisualStyleBackColor = False
        '
        'nudPaidTix
        '
        Me.nudPaidTix.BackColor = System.Drawing.Color.PaleVioletRed
        Me.nudPaidTix.Location = New System.Drawing.Point(168, 117)
        Me.nudPaidTix.Name = "nudPaidTix"
        Me.nudPaidTix.Size = New System.Drawing.Size(192, 24)
        Me.nudPaidTix.TabIndex = 11
        '
        'nudFreeTix
        '
        Me.nudFreeTix.BackColor = System.Drawing.Color.PaleVioletRed
        Me.nudFreeTix.Location = New System.Drawing.Point(168, 169)
        Me.nudFreeTix.Name = "nudFreeTix"
        Me.nudFreeTix.Size = New System.Drawing.Size(192, 24)
        Me.nudFreeTix.TabIndex = 12
        '
        'Seller
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.ClientSize = New System.Drawing.Size(404, 405)
        Me.Controls.Add(Me.nudFreeTix)
        Me.Controls.Add(Me.nudPaidTix)
        Me.Controls.Add(Me.btnHomepage)
        Me.Controls.Add(Me.btnCharge)
        Me.Controls.Add(Me.lblPrice_Output)
        Me.Controls.Add(Me.lblPrice_Label)
        Me.Controls.Add(Me.lblFreeTickets)
        Me.Controls.Add(Me.lblPaidTickets)
        Me.Controls.Add(Me.cbxArea)
        Me.Controls.Add(Me.lblArea)
        Me.Controls.Add(Me.lblTitle)
        Me.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Seller"
        Me.Text = "Seller"
        CType(Me.nudPaidTix, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudFreeTix, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblArea As Label
    Friend WithEvents cbxArea As ComboBox
    Friend WithEvents lblPaidTickets As Label
    Friend WithEvents lblFreeTickets As Label
    Friend WithEvents lblPrice_Label As Label
    Friend WithEvents lblPrice_Output As Label
    Friend WithEvents btnCharge As Button
    Friend WithEvents btnHomepage As Button
    Friend WithEvents nudPaidTix As NumericUpDown
    Friend WithEvents nudFreeTix As NumericUpDown
End Class
