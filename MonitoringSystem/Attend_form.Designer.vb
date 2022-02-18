<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Attend_form
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnTimeInOut = New System.Windows.Forms.Button()
        Me.btn_New = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnTimeInOut)
        Me.Panel1.Controls.Add(Me.btn_New)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1099, 88)
        Me.Panel1.TabIndex = 0
        '
        'btnTimeInOut
        '
        Me.btnTimeInOut.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnTimeInOut.Location = New System.Drawing.Point(177, 12)
        Me.btnTimeInOut.Name = "btnTimeInOut"
        Me.btnTimeInOut.Size = New System.Drawing.Size(168, 63)
        Me.btnTimeInOut.TabIndex = 1
        Me.btnTimeInOut.Text = "Time In/Out"
        Me.btnTimeInOut.UseVisualStyleBackColor = True
        '
        'btn_New
        '
        Me.btn_New.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btn_New.Location = New System.Drawing.Point(3, 12)
        Me.btn_New.Name = "btn_New"
        Me.btn_New.Size = New System.Drawing.Size(168, 63)
        Me.btn_New.TabIndex = 0
        Me.btn_New.Text = "New Employee"
        Me.btn_New.UseVisualStyleBackColor = True
        '
        'Attend_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.MonitoringSystem.My.Resources.Resources.comex
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1099, 625)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Attend_form"
        Me.Text = "Attend_form"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_New As Button
    Friend WithEvents btnTimeInOut As Button
End Class
