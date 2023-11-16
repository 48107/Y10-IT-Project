<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
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
        Me.lblTixPrice = New System.Windows.Forms.Label()
        Me.lblAreas = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lbxAreas = New System.Windows.Forms.ListBox()
        Me.btnAddArea = New System.Windows.Forms.Button()
        Me.btnRenameArea = New System.Windows.Forms.Button()
        Me.btnRemoveArea = New System.Windows.Forms.Button()
        Me.txtTicketPrice = New System.Windows.Forms.TextBox()
        Me.lblDollar = New System.Windows.Forms.Label()
        Me.btnUpdatePrice = New System.Windows.Forms.Button()
        Me.btnHomepage = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTixPrice
        '
        Me.lblTixPrice.AutoSize = True
        Me.lblTixPrice.Location = New System.Drawing.Point(146, 247)
        Me.lblTixPrice.Name = "lblTixPrice"
        Me.lblTixPrice.Size = New System.Drawing.Size(125, 19)
        Me.lblTixPrice.TabIndex = 0
        Me.lblTixPrice.Text = "Global Ticket Price:"
        '
        'lblAreas
        '
        Me.lblAreas.AutoSize = True
        Me.lblAreas.Location = New System.Drawing.Point(186, 48)
        Me.lblAreas.Name = "lblAreas"
        Me.lblAreas.Size = New System.Drawing.Size(46, 19)
        Me.lblAreas.TabIndex = 1
        Me.lblAreas.Text = "Areas:"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(147, 14)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(130, 23)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "Administration"
        '
        'lbxAreas
        '
        Me.lbxAreas.FormattingEnabled = True
        Me.lbxAreas.ItemHeight = 19
        Me.lbxAreas.Location = New System.Drawing.Point(138, 70)
        Me.lbxAreas.Name = "lbxAreas"
        Me.lbxAreas.Size = New System.Drawing.Size(144, 99)
        Me.lbxAreas.TabIndex = 3
        '
        'btnAddArea
        '
        Me.btnAddArea.BackColor = System.Drawing.Color.PaleVioletRed
        Me.btnAddArea.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddArea.Location = New System.Drawing.Point(58, 175)
        Me.btnAddArea.Name = "btnAddArea"
        Me.btnAddArea.Size = New System.Drawing.Size(97, 41)
        Me.btnAddArea.TabIndex = 10
        Me.btnAddArea.Text = "Add an Area"
        Me.btnAddArea.UseVisualStyleBackColor = False
        '
        'btnRenameArea
        '
        Me.btnRenameArea.BackColor = System.Drawing.Color.PaleVioletRed
        Me.btnRenameArea.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRenameArea.Location = New System.Drawing.Point(161, 175)
        Me.btnRenameArea.Name = "btnRenameArea"
        Me.btnRenameArea.Size = New System.Drawing.Size(97, 41)
        Me.btnRenameArea.TabIndex = 11
        Me.btnRenameArea.Text = "Rename Selected Area"
        Me.btnRenameArea.UseVisualStyleBackColor = False
        '
        'btnRemoveArea
        '
        Me.btnRemoveArea.BackColor = System.Drawing.Color.PaleVioletRed
        Me.btnRemoveArea.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveArea.Location = New System.Drawing.Point(264, 175)
        Me.btnRemoveArea.Name = "btnRemoveArea"
        Me.btnRemoveArea.Size = New System.Drawing.Size(97, 41)
        Me.btnRemoveArea.TabIndex = 12
        Me.btnRemoveArea.Text = "Remove Selected Area"
        Me.btnRemoveArea.UseVisualStyleBackColor = False
        '
        'txtTicketPrice
        '
        Me.txtTicketPrice.Location = New System.Drawing.Point(167, 279)
        Me.txtTicketPrice.Name = "txtTicketPrice"
        Me.txtTicketPrice.Size = New System.Drawing.Size(100, 24)
        Me.txtTicketPrice.TabIndex = 13
        '
        'lblDollar
        '
        Me.lblDollar.AutoSize = True
        Me.lblDollar.Location = New System.Drawing.Point(147, 282)
        Me.lblDollar.Name = "lblDollar"
        Me.lblDollar.Size = New System.Drawing.Size(17, 19)
        Me.lblDollar.TabIndex = 14
        Me.lblDollar.Text = "$"
        '
        'btnUpdatePrice
        '
        Me.btnUpdatePrice.BackColor = System.Drawing.Color.PaleVioletRed
        Me.btnUpdatePrice.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdatePrice.Location = New System.Drawing.Point(150, 318)
        Me.btnUpdatePrice.Name = "btnUpdatePrice"
        Me.btnUpdatePrice.Size = New System.Drawing.Size(121, 41)
        Me.btnUpdatePrice.TabIndex = 15
        Me.btnUpdatePrice.Text = "Update Ticket Price"
        Me.btnUpdatePrice.UseVisualStyleBackColor = False
        '
        'btnHomepage
        '
        Me.btnHomepage.BackColor = System.Drawing.Color.PaleVioletRed
        Me.btnHomepage.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHomepage.Location = New System.Drawing.Point(341, 1)
        Me.btnHomepage.Name = "btnHomepage"
        Me.btnHomepage.Size = New System.Drawing.Size(78, 31)
        Me.btnHomepage.TabIndex = 16
        Me.btnHomepage.Text = "Homepage"
        Me.btnHomepage.UseVisualStyleBackColor = False
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.ClientSize = New System.Drawing.Size(421, 400)
        Me.Controls.Add(Me.btnHomepage)
        Me.Controls.Add(Me.btnUpdatePrice)
        Me.Controls.Add(Me.lblDollar)
        Me.Controls.Add(Me.txtTicketPrice)
        Me.Controls.Add(Me.btnRemoveArea)
        Me.Controls.Add(Me.btnRenameArea)
        Me.Controls.Add(Me.btnAddArea)
        Me.Controls.Add(Me.lbxAreas)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblAreas)
        Me.Controls.Add(Me.lblTixPrice)
        Me.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Admin"
        Me.Text = "Admin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTixPrice As Label
    Friend WithEvents lblAreas As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents lbxAreas As ListBox
    Friend WithEvents btnAddArea As Button
    Friend WithEvents btnRenameArea As Button
    Friend WithEvents btnRemoveArea As Button
    Friend WithEvents txtTicketPrice As TextBox
    Friend WithEvents lblDollar As Label
    Friend WithEvents btnUpdatePrice As Button
    Friend WithEvents btnHomepage As Button
End Class
