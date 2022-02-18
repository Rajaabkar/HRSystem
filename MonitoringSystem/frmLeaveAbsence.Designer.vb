<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLeaveAbsence
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLeaveAbsence))
        Me.btnApprove = New System.Windows.Forms.Button()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.txtempsearch = New System.Windows.Forms.TextBox()
        Me.dtgemplist = New System.Windows.Forms.DataGridView()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtbalanceleave = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtnodaysapplied = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtempname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtremainingdays = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtgapprovedlist = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtapprovesearch = New System.Windows.Forms.TextBox()
        Me.btnview = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.dtgemplist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtgapprovedlist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnApprove
        '
        Me.btnApprove.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnApprove.Font = New System.Drawing.Font("Bodoni MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApprove.Location = New System.Drawing.Point(12, 244)
        Me.btnApprove.Name = "btnApprove"
        Me.btnApprove.Size = New System.Drawing.Size(91, 38)
        Me.btnApprove.TabIndex = 26
        Me.btnApprove.Text = "Approve"
        Me.btnApprove.UseVisualStyleBackColor = False
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.Location = New System.Drawing.Point(119, 26)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(76, 20)
        Me.Label46.TabIndex = 25
        Me.Label46.Text = "Search :"
        '
        'txtempsearch
        '
        Me.txtempsearch.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtempsearch.Location = New System.Drawing.Point(629, 123)
        Me.txtempsearch.Multiline = True
        Me.txtempsearch.Name = "txtempsearch"
        Me.txtempsearch.Size = New System.Drawing.Size(234, 28)
        Me.txtempsearch.TabIndex = 24
        '
        'dtgemplist
        '
        Me.dtgemplist.AllowUserToAddRows = False
        Me.dtgemplist.AllowUserToDeleteRows = False
        Me.dtgemplist.AllowUserToResizeColumns = False
        Me.dtgemplist.AllowUserToResizeRows = False
        Me.dtgemplist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgemplist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgemplist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgemplist.Location = New System.Drawing.Point(12, 66)
        Me.dtgemplist.Name = "dtgemplist"
        Me.dtgemplist.RowHeadersVisible = False
        Me.dtgemplist.RowHeadersWidth = 51
        Me.dtgemplist.RowTemplate.Height = 24
        Me.dtgemplist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dtgemplist.ShowCellToolTips = False
        Me.dtgemplist.Size = New System.Drawing.Size(872, 172)
        Me.dtgemplist.TabIndex = 23
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnCancel.Font = New System.Drawing.Font("Bodoni MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(109, 244)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(95, 38)
        Me.btnCancel.TabIndex = 26
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SteelBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Bodoni MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(774, 480)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 38)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtbalanceleave)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtnodaysapplied)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtempname)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtremainingdays)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label46)
        Me.GroupBox1.Location = New System.Drawing.Point(464, 74)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(155, 69)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Set the number of leave to the employee"
        '
        'txtbalanceleave
        '
        Me.txtbalanceleave.Enabled = False
        Me.txtbalanceleave.Location = New System.Drawing.Point(165, 46)
        Me.txtbalanceleave.Name = "txtbalanceleave"
        Me.txtbalanceleave.Size = New System.Drawing.Size(326, 25)
        Me.txtbalanceleave.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(165, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Balance of days(s)  leave :"
        '
        'txtnodaysapplied
        '
        Me.txtnodaysapplied.Location = New System.Drawing.Point(165, 77)
        Me.txtnodaysapplied.Name = "txtnodaysapplied"
        Me.txtnodaysapplied.Size = New System.Drawing.Size(326, 25)
        Me.txtnodaysapplied.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(177, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Number of days applied for:"
        '
        'txtempname
        '
        Me.txtempname.Enabled = False
        Me.txtempname.Location = New System.Drawing.Point(165, 20)
        Me.txtempname.Name = "txtempname"
        Me.txtempname.Size = New System.Drawing.Size(326, 25)
        Me.txtempname.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(172, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Remaining day(s) of leave :"
        '
        'txtremainingdays
        '
        Me.txtremainingdays.Enabled = False
        Me.txtremainingdays.Location = New System.Drawing.Point(165, 104)
        Me.txtremainingdays.Name = "txtremainingdays"
        Me.txtremainingdays.Size = New System.Drawing.Size(326, 25)
        Me.txtremainingdays.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(61, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Employee's Name : "
        '
        'dtgapprovedlist
        '
        Me.dtgapprovedlist.AllowUserToAddRows = False
        Me.dtgapprovedlist.AllowUserToDeleteRows = False
        Me.dtgapprovedlist.AllowUserToResizeColumns = False
        Me.dtgapprovedlist.AllowUserToResizeRows = False
        Me.dtgapprovedlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgapprovedlist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgapprovedlist.BackgroundColor = System.Drawing.Color.SkyBlue
        Me.dtgapprovedlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgapprovedlist.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtgapprovedlist.Location = New System.Drawing.Point(12, 13)
        Me.dtgapprovedlist.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtgapprovedlist.Name = "dtgapprovedlist"
        Me.dtgapprovedlist.RowHeadersWidth = 51
        Me.dtgapprovedlist.RowTemplate.Height = 24
        Me.dtgapprovedlist.Size = New System.Drawing.Size(872, 460)
        Me.dtgapprovedlist.TabIndex = 33
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(14, 495)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 26)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Search :"
        '
        'txtapprovesearch
        '
        Me.txtapprovesearch.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtapprovesearch.Location = New System.Drawing.Point(105, 491)
        Me.txtapprovesearch.Multiline = True
        Me.txtapprovesearch.Name = "txtapprovesearch"
        Me.txtapprovesearch.Size = New System.Drawing.Size(282, 27)
        Me.txtapprovesearch.TabIndex = 35
        '
        'btnview
        '
        Me.btnview.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnview.Location = New System.Drawing.Point(629, 436)
        Me.btnview.Name = "btnview"
        Me.btnview.Size = New System.Drawing.Size(89, 38)
        Me.btnview.TabIndex = 28
        Me.btnview.Text = "View"
        Me.btnview.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Button2.Font = New System.Drawing.Font("Bodoni MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(124, 367)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(180, 38)
        Me.Button2.TabIndex = 38
        Me.Button2.Text = "Print to Preview"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'FrmLeaveAbsence
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(896, 531)
        Me.Controls.Add(Me.dtgapprovedlist)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtapprovesearch)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnApprove)
        Me.Controls.Add(Me.txtempsearch)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnview)
        Me.Controls.Add(Me.dtgemplist)
        Me.Controls.Add(Me.Button2)
        Me.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmLeaveAbsence"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee's Leave of Absence"
        CType(Me.dtgemplist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dtgapprovedlist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnApprove As System.Windows.Forms.Button
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents txtempsearch As System.Windows.Forms.TextBox
    Friend WithEvents dtgemplist As System.Windows.Forms.DataGridView
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtremainingdays As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtbalanceleave As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtnodaysapplied As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtempname As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtgapprovedlist As System.Windows.Forms.DataGridView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtapprovesearch As System.Windows.Forms.TextBox
    Friend WithEvents btnview As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
