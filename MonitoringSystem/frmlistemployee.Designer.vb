<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmlistemployee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmlistemployee))
        Me.txtempsearch = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.dtgemplist = New System.Windows.Forms.DataGridView()
        Me.dtgremain_List = New System.Windows.Forms.DataGridView()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.dtgemplist, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgremain_List, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtempsearch
        '
        Me.txtempsearch.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtempsearch.Location = New System.Drawing.Point(88, 72)
        Me.txtempsearch.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.txtempsearch.Multiline = True
        Me.txtempsearch.Name = "txtempsearch"
        Me.txtempsearch.Size = New System.Drawing.Size(351, 32)
        Me.txtempsearch.TabIndex = 30
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(11, 75)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 19)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Search :"
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.Color.SteelBlue
        Me.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndelete.Font = New System.Drawing.Font("Bodoni MT Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.ForeColor = System.Drawing.Color.White
        Me.btndelete.Location = New System.Drawing.Point(163, 25)
        Me.btndelete.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(85, 60)
        Me.btndelete.TabIndex = 31
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'dtgemplist
        '
        Me.dtgemplist.AllowUserToAddRows = False
        Me.dtgemplist.AllowUserToDeleteRows = False
        Me.dtgemplist.AllowUserToResizeColumns = False
        Me.dtgemplist.AllowUserToResizeRows = False
        Me.dtgemplist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgemplist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgemplist.BackgroundColor = System.Drawing.Color.SkyBlue
        Me.dtgemplist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgemplist.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtgemplist.Location = New System.Drawing.Point(7, 116)
        Me.dtgemplist.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.dtgemplist.Name = "dtgemplist"
        Me.dtgemplist.RowHeadersVisible = False
        Me.dtgemplist.RowHeadersWidth = 51
        Me.dtgemplist.RowTemplate.Height = 24
        Me.dtgemplist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgemplist.Size = New System.Drawing.Size(982, 492)
        Me.dtgemplist.StandardTab = True
        Me.dtgemplist.TabIndex = 28
        '
        'dtgremain_List
        '
        Me.dtgremain_List.AllowUserToAddRows = False
        Me.dtgremain_List.AllowUserToDeleteRows = False
        Me.dtgremain_List.AllowUserToResizeColumns = False
        Me.dtgremain_List.AllowUserToResizeRows = False
        Me.dtgremain_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgremain_List.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgremain_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgremain_List.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtgremain_List.Location = New System.Drawing.Point(465, 169)
        Me.dtgremain_List.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.dtgremain_List.Name = "dtgremain_List"
        Me.dtgremain_List.RowHeadersVisible = False
        Me.dtgremain_List.RowHeadersWidth = 51
        Me.dtgremain_List.RowTemplate.Height = 24
        Me.dtgremain_List.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgremain_List.ShowCellToolTips = False
        Me.dtgremain_List.Size = New System.Drawing.Size(24, 21)
        Me.dtgremain_List.TabIndex = 29
        '
        'btnclose
        '
        Me.btnclose.BackColor = System.Drawing.Color.SteelBlue
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclose.Font = New System.Drawing.Font("Bodoni MT Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.ForeColor = System.Drawing.Color.White
        Me.btnclose.Location = New System.Drawing.Point(248, 25)
        Me.btnclose.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(71, 60)
        Me.btnclose.TabIndex = 31
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = False
        '
        'btnedit
        '
        Me.btnedit.BackColor = System.Drawing.Color.SteelBlue
        Me.btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnedit.Font = New System.Drawing.Font("Bodoni MT Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnedit.ForeColor = System.Drawing.Color.White
        Me.btnedit.Location = New System.Drawing.Point(21, 25)
        Me.btnedit.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(143, 60)
        Me.btnedit.TabIndex = 38
        Me.btnedit.Text = "Edit Employee"
        Me.btnedit.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnedit)
        Me.GroupBox1.Controls.Add(Me.btndelete)
        Me.GroupBox1.Controls.Add(Me.btnclose)
        Me.GroupBox1.Location = New System.Drawing.Point(654, 14)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(335, 93)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Actions"
        '
        'frmlistemployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1002, 613)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtempsearch)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dtgemplist)
        Me.Controls.Add(Me.dtgremain_List)
        Me.Font = New System.Drawing.Font("Arial Narrow", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frmlistemployee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee List"
        CType(Me.dtgemplist, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgremain_List, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtempsearch As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents dtgemplist As System.Windows.Forms.DataGridView
    Friend WithEvents dtgremain_List As System.Windows.Forms.DataGridView
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
