<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnSeller = New System.Windows.Forms.Button()
        Me.btnScanner = New System.Windows.Forms.Button()
        Me.btnAdmin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(109, 16)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(296, 45)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Ticketing System"
        '
        'btnSeller
        '
        Me.btnSeller.BackColor = System.Drawing.Color.PaleVioletRed
        Me.btnSeller.Location = New System.Drawing.Point(115, 69)
        Me.btnSeller.Name = "btnSeller"
        Me.btnSeller.Size = New System.Drawing.Size(140, 66)
        Me.btnSeller.TabIndex = 1
        Me.btnSeller.Text = "Seller"
        Me.btnSeller.UseVisualStyleBackColor = False
        '
        'btnScanner
        '
        Me.btnScanner.BackColor = System.Drawing.Color.PaleVioletRed
        Me.btnScanner.Location = New System.Drawing.Point(115, 146)
        Me.btnScanner.Name = "btnScanner"
        Me.btnScanner.Size = New System.Drawing.Size(140, 66)
        Me.btnScanner.TabIndex = 2
        Me.btnScanner.Text = "Scanner"
        Me.btnScanner.UseVisualStyleBackColor = False
        '
        'btnAdmin
        '
        Me.btnAdmin.BackColor = System.Drawing.Color.PaleVioletRed
        Me.btnAdmin.Location = New System.Drawing.Point(115, 223)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Size = New System.Drawing.Size(140, 66)
        Me.btnAdmin.TabIndex = 3
        Me.btnAdmin.Text = "Admin"
        Me.btnAdmin.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 35.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.ClientSize = New System.Drawing.Size(376, 313)
        Me.Controls.Add(Me.btnAdmin)
        Me.Controls.Add(Me.btnScanner)
        Me.Controls.Add(Me.btnSeller)
        Me.Controls.Add(Me.lblTitle)
        Me.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Homepage"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents btnSeller As Button
    Friend WithEvents btnScanner As Button
    Friend WithEvents btnAdmin As Button
End Class
