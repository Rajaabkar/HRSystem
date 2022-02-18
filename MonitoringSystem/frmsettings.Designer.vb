<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmsettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmsettings))
        Me.btnpositionload = New System.Windows.Forms.Button()
        Me.dtglistposition = New System.Windows.Forms.DataGridView()
        Me.npositiondelete = New System.Windows.Forms.Button()
        Me.npositionupdate = New System.Windows.Forms.Button()
        Me.npositionsave = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtposition = New System.Windows.Forms.TextBox()
        CType(Me.dtglistposition, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnpositionload
        '
        Me.btnpositionload.BackColor = System.Drawing.Color.SteelBlue
        Me.btnpositionload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnpositionload.Font = New System.Drawing.Font("Bodoni MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpositionload.ForeColor = System.Drawing.Color.White
        Me.btnpositionload.Location = New System.Drawing.Point(130, 491)
        Me.btnpositionload.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnpositionload.Name = "btnpositionload"
        Me.btnpositionload.Size = New System.Drawing.Size(107, 54)
        Me.btnpositionload.TabIndex = 6
        Me.btnpositionload.Text = "Load"
        Me.btnpositionload.UseVisualStyleBackColor = False
        '
        'dtglistposition
        '
        Me.dtglistposition.AllowUserToAddRows = False
        Me.dtglistposition.AllowUserToDeleteRows = False
        Me.dtglistposition.AllowUserToResizeColumns = False
        Me.dtglistposition.AllowUserToResizeRows = False
        Me.dtglistposition.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtglistposition.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtglistposition.BackgroundColor = System.Drawing.Color.SkyBlue
        Me.dtglistposition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtglistposition.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtglistposition.Location = New System.Drawing.Point(17, 64)
        Me.dtglistposition.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtglistposition.Name = "dtglistposition"
        Me.dtglistposition.RowHeadersWidth = 51
        Me.dtglistposition.Size = New System.Drawing.Size(791, 417)
        Me.dtglistposition.TabIndex = 1
        '
        'npositiondelete
        '
        Me.npositiondelete.BackColor = System.Drawing.Color.SteelBlue
        Me.npositiondelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.npositiondelete.Font = New System.Drawing.Font("Bodoni MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.npositiondelete.ForeColor = System.Drawing.Color.White
        Me.npositiondelete.Location = New System.Drawing.Point(349, 491)
        Me.npositiondelete.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.npositiondelete.Name = "npositiondelete"
        Me.npositiondelete.Size = New System.Drawing.Size(107, 54)
        Me.npositiondelete.TabIndex = 5
        Me.npositiondelete.Text = "Delete"
        Me.npositiondelete.UseVisualStyleBackColor = False
        '
        'npositionupdate
        '
        Me.npositionupdate.BackColor = System.Drawing.Color.SteelBlue
        Me.npositionupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.npositionupdate.Font = New System.Drawing.Font("Bodoni MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.npositionupdate.ForeColor = System.Drawing.Color.White
        Me.npositionupdate.Location = New System.Drawing.Point(239, 491)
        Me.npositionupdate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.npositionupdate.Name = "npositionupdate"
        Me.npositionupdate.Size = New System.Drawing.Size(107, 54)
        Me.npositionupdate.TabIndex = 4
        Me.npositionupdate.Text = "Update"
        Me.npositionupdate.UseVisualStyleBackColor = False
        '
        'npositionsave
        '
        Me.npositionsave.BackColor = System.Drawing.Color.SteelBlue
        Me.npositionsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.npositionsave.Font = New System.Drawing.Font("Bodoni MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.npositionsave.ForeColor = System.Drawing.Color.White
        Me.npositionsave.Location = New System.Drawing.Point(17, 491)
        Me.npositionsave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.npositionsave.Name = "npositionsave"
        Me.npositionsave.Size = New System.Drawing.Size(107, 54)
        Me.npositionsave.TabIndex = 3
        Me.npositionsave.Text = "Save"
        Me.npositionsave.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(17, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Position :"
        '
        'txtposition
        '
        Me.txtposition.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtposition.Location = New System.Drawing.Point(146, 12)
        Me.txtposition.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtposition.Multiline = True
        Me.txtposition.Name = "txtposition"
        Me.txtposition.Size = New System.Drawing.Size(504, 34)
        Me.txtposition.TabIndex = 2
        '
        'frmsettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(823, 551)
        Me.Controls.Add(Me.btnpositionload)
        Me.Controls.Add(Me.dtglistposition)
        Me.Controls.Add(Me.npositionsave)
        Me.Controls.Add(Me.npositiondelete)
        Me.Controls.Add(Me.txtposition)
        Me.Controls.Add(Me.npositionupdate)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "frmsettings"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        CType(Me.dtglistposition, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents npositionsave As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtposition As System.Windows.Forms.TextBox
    Friend WithEvents npositiondelete As System.Windows.Forms.Button
    Friend WithEvents npositionupdate As System.Windows.Forms.Button
    Friend WithEvents dtglistposition As System.Windows.Forms.DataGridView
    Friend WithEvents btnpositionload As System.Windows.Forms.Button
End Class
