﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmdepartment
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
        Me.btndeptLoad = New System.Windows.Forms.Button()
        Me.dtgdeptlist = New System.Windows.Forms.DataGridView()
        Me.btndeptDelete = New System.Windows.Forms.Button()
        Me.btndeptUpdate = New System.Windows.Forms.Button()
        Me.btndeptSave = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtdepartment = New System.Windows.Forms.TextBox()
        CType(Me.dtgdeptlist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btndeptLoad
        '
        Me.btndeptLoad.BackColor = System.Drawing.Color.Brown
        Me.btndeptLoad.FlatAppearance.BorderSize = 0
        Me.btndeptLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndeptLoad.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndeptLoad.ForeColor = System.Drawing.Color.White
        Me.btndeptLoad.Location = New System.Drawing.Point(97, 364)
        Me.btndeptLoad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btndeptLoad.Name = "btndeptLoad"
        Me.btndeptLoad.Size = New System.Drawing.Size(75, 40)
        Me.btndeptLoad.TabIndex = 6
        Me.btndeptLoad.Text = "Load"
        Me.btndeptLoad.UseVisualStyleBackColor = False
        '
        'dtgdeptlist
        '
        Me.dtgdeptlist.AllowUserToAddRows = False
        Me.dtgdeptlist.AllowUserToDeleteRows = False
        Me.dtgdeptlist.AllowUserToResizeColumns = False
        Me.dtgdeptlist.AllowUserToResizeRows = False
        Me.dtgdeptlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgdeptlist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgdeptlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgdeptlist.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtgdeptlist.Location = New System.Drawing.Point(12, 53)
        Me.dtgdeptlist.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtgdeptlist.Name = "dtgdeptlist"
        Me.dtgdeptlist.Size = New System.Drawing.Size(587, 303)
        Me.dtgdeptlist.TabIndex = 1
        '
        'btndeptDelete
        '
        Me.btndeptDelete.BackColor = System.Drawing.Color.Brown
        Me.btndeptDelete.FlatAppearance.BorderSize = 0
        Me.btndeptDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndeptDelete.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndeptDelete.ForeColor = System.Drawing.Color.White
        Me.btndeptDelete.Location = New System.Drawing.Point(259, 364)
        Me.btndeptDelete.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btndeptDelete.Name = "btndeptDelete"
        Me.btndeptDelete.Size = New System.Drawing.Size(75, 40)
        Me.btndeptDelete.TabIndex = 5
        Me.btndeptDelete.Text = "Delete"
        Me.btndeptDelete.UseVisualStyleBackColor = False
        '
        'btndeptUpdate
        '
        Me.btndeptUpdate.BackColor = System.Drawing.Color.Brown
        Me.btndeptUpdate.FlatAppearance.BorderSize = 0
        Me.btndeptUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndeptUpdate.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndeptUpdate.ForeColor = System.Drawing.Color.White
        Me.btndeptUpdate.Location = New System.Drawing.Point(178, 364)
        Me.btndeptUpdate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btndeptUpdate.Name = "btndeptUpdate"
        Me.btndeptUpdate.Size = New System.Drawing.Size(75, 40)
        Me.btndeptUpdate.TabIndex = 4
        Me.btndeptUpdate.Text = "Update"
        Me.btndeptUpdate.UseVisualStyleBackColor = False
        '
        'btndeptSave
        '
        Me.btndeptSave.BackColor = System.Drawing.Color.Brown
        Me.btndeptSave.FlatAppearance.BorderSize = 0
        Me.btndeptSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndeptSave.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndeptSave.ForeColor = System.Drawing.Color.White
        Me.btndeptSave.Location = New System.Drawing.Point(16, 364)
        Me.btndeptSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btndeptSave.Name = "btndeptSave"
        Me.btndeptSave.Size = New System.Drawing.Size(75, 40)
        Me.btndeptSave.TabIndex = 3
        Me.btndeptSave.Text = "Save"
        Me.btndeptSave.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Subject Handled:"
        '
        'txtdepartment
        '
        Me.txtdepartment.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdepartment.Location = New System.Drawing.Point(130, 19)
        Me.txtdepartment.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtdepartment.Multiline = True
        Me.txtdepartment.Name = "txtdepartment"
        Me.txtdepartment.Size = New System.Drawing.Size(354, 26)
        Me.txtdepartment.TabIndex = 2
        '
        'frmdepartment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 410)
        Me.Controls.Add(Me.dtgdeptlist)
        Me.Controls.Add(Me.btndeptLoad)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtdepartment)
        Me.Controls.Add(Me.btndeptDelete)
        Me.Controls.Add(Me.btndeptSave)
        Me.Controls.Add(Me.btndeptUpdate)
        Me.Name = "frmdepartment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Department"
        CType(Me.dtgdeptlist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btndeptLoad As Button
    Friend WithEvents dtgdeptlist As DataGridView
    Friend WithEvents btndeptDelete As Button
    Friend WithEvents btndeptUpdate As Button
    Friend WithEvents btndeptSave As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtdepartment As TextBox
End Class
