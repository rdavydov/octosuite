﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserOrgsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserOrgsForm))
        Me.DataGridViewUserOrgs = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridViewUserOrgs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewUserOrgs
        '
        Me.DataGridViewUserOrgs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewUserOrgs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewUserOrgs.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewUserOrgs.Name = "DataGridViewUserOrgs"
        Me.DataGridViewUserOrgs.ReadOnly = True
        Me.DataGridViewUserOrgs.RowTemplate.Height = 25
        Me.DataGridViewUserOrgs.Size = New System.Drawing.Size(714, 450)
        Me.DataGridViewUserOrgs.TabIndex = 4
        '
        'UserOrgsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(714, 450)
        Me.Controls.Add(Me.DataGridViewUserOrgs)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "UserOrgsForm"
        Me.Text = "Octosuite - User:Orgs"
        CType(Me.DataGridViewUserOrgs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridViewUserOrgs As DataGridView
End Class
