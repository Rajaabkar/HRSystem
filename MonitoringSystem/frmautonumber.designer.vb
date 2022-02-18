<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmautonumber
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmautonumber))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtstart = New System.Windows.Forms.TextBox()
        Me.txtend = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtdescription = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.dtglist = New System.Windows.Forms.DataGridView()
        Me.txtincrement = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.dtglist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(70, 56)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Start"
        '
        'txtstart
        '
        Me.txtstart.Location = New System.Drawing.Point(117, 53)
        Me.txtstart.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.txtstart.Name = "txtstart"
        Me.txtstart.Size = New System.Drawing.Size(263, 26)
        Me.txtstart.TabIndex = 1
        '
        'txtend
        '
        Me.txtend.Location = New System.Drawing.Point(117, 89)
        Me.txtend.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.txtend.Name = "txtend"
        Me.txtend.Size = New System.Drawing.Size(263, 26)
        Me.txtend.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(70, 92)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "End"
        '
        'txtdescription
        '
        Me.txtdescription.Location = New System.Drawing.Point(117, 168)
        Me.txtdescription.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.txtdescription.Name = "txtdescription"
        Me.txtdescription.Size = New System.Drawing.Size(263, 26)
        Me.txtdescription.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(18, 172)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Description"
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.SteelBlue
        Me.btnsave.Location = New System.Drawing.Point(389, 43)
        Me.btnsave.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(114, 32)
        Me.btnsave.TabIndex = 6
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'btnupdate
        '
        Me.btnupdate.BackColor = System.Drawing.Color.SteelBlue
        Me.btnupdate.Location = New System.Drawing.Point(389, 83)
        Me.btnupdate.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(114, 32)
        Me.btnupdate.TabIndex = 7
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = False
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.Color.SteelBlue
        Me.btndelete.Location = New System.Drawing.Point(389, 125)
        Me.btndelete.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(114, 32)
        Me.btndelete.TabIndex = 8
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'dtglist
        '
        Me.dtglist.AllowUserToAddRows = False
        Me.dtglist.BackgroundColor = System.Drawing.Color.SkyBlue
        Me.dtglist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtglist.Location = New System.Drawing.Point(18, 212)
        Me.dtglist.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.dtglist.Name = "dtglist"
        Me.dtglist.RowHeadersWidth = 51
        Me.dtglist.Size = New System.Drawing.Size(485, 161)
        Me.dtglist.TabIndex = 9
        '
        'txtincrement
        '
        Me.txtincrement.Location = New System.Drawing.Point(117, 127)
        Me.txtincrement.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.txtincrement.Name = "txtincrement"
        Me.txtincrement.Size = New System.Drawing.Size(263, 26)
        Me.txtincrement.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(18, 132)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 18)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Increment"
        '
        'frmautonumber
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(513, 395)
        Me.Controls.Add(Me.txtincrement)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtglist)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.txtdescription)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtend)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtstart)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.Name = "frmautonumber"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmautonumber"
        CType(Me.dtglist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtstart As System.Windows.Forms.TextBox
    Friend WithEvents txtend As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtdescription As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents dtglist As System.Windows.Forms.DataGridView
    Friend WithEvents txtincrement As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
