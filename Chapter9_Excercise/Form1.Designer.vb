<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NameBox = New System.Windows.Forms.TextBox()
        Me.MemberListBox = New System.Windows.Forms.ListBox()
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenu = New System.Windows.Forms.MenuStrip()
        Me.PhoneBox = New System.Windows.Forms.MaskedTextBox()
        Me.ToolStripMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(138, 387)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(138, 451)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Phone:"
        '
        'NameBox
        '
        Me.NameBox.Location = New System.Drawing.Point(291, 387)
        Me.NameBox.Name = "NameBox"
        Me.NameBox.Size = New System.Drawing.Size(100, 26)
        Me.NameBox.TabIndex = 2
        '
        'MemberListBox
        '
        Me.MemberListBox.FormattingEnabled = True
        Me.MemberListBox.ItemHeight = 20
        Me.MemberListBox.Location = New System.Drawing.Point(142, 101)
        Me.MemberListBox.Name = "MemberListBox"
        Me.MemberListBox.Size = New System.Drawing.Size(249, 244)
        Me.MemberListBox.TabIndex = 6
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModifyToolStripMenuItem, Me.AddToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(86, 29)
        Me.UpdateToolStripMenuItem.Text = "Update"
        '
        'ModifyToolStripMenuItem
        '
        Me.ModifyToolStripMenuItem.Name = "ModifyToolStripMenuItem"
        Me.ModifyToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.ModifyToolStripMenuItem.Size = New System.Drawing.Size(202, 34)
        Me.ModifyToolStripMenuItem.Text = "Modify"
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(202, 34)
        Me.AddToolStripMenuItem.Text = "Add"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(202, 34)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(55, 29)
        Me.SaveToolStripMenuItem.Text = "Exit"
        '
        'ToolStripMenu
        '
        Me.ToolStripMenu.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.ToolStripMenu.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStripMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateToolStripMenuItem, Me.SaveToolStripMenuItem})
        Me.ToolStripMenu.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripMenu.Name = "ToolStripMenu"
        Me.ToolStripMenu.Size = New System.Drawing.Size(553, 33)
        Me.ToolStripMenu.TabIndex = 7
        Me.ToolStripMenu.Text = "MenuStrip1"
        '
        'PhoneBox
        '
        Me.PhoneBox.Location = New System.Drawing.Point(291, 451)
        Me.PhoneBox.Mask = "000-0000"
        Me.PhoneBox.Name = "PhoneBox"
        Me.PhoneBox.Size = New System.Drawing.Size(100, 26)
        Me.PhoneBox.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(553, 553)
        Me.Controls.Add(Me.PhoneBox)
        Me.Controls.Add(Me.ToolStripMenu)
        Me.Controls.Add(Me.MemberListBox)
        Me.Controls.Add(Me.NameBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.KeyPreview = True
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ToolStripMenu.ResumeLayout(False)
        Me.ToolStripMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents NameBox As TextBox
    Friend WithEvents MemberListBox As ListBox
    Friend WithEvents UpdateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModifyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenu As MenuStrip
    Friend WithEvents PhoneBox As MaskedTextBox
End Class
