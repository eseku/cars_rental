<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerPicker
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
        Me.PickerGrid = New System.Windows.Forms.DataGridView()
        Me.confirm = New System.Windows.Forms.Button()
        CType(Me.PickerGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PickerGrid
        '
        Me.PickerGrid.AllowUserToAddRows = False
        Me.PickerGrid.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.PickerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PickerGrid.Location = New System.Drawing.Point(12, 12)
        Me.PickerGrid.Name = "PickerGrid"
        Me.PickerGrid.ReadOnly = True
        Me.PickerGrid.RowHeadersWidth = 51
        Me.PickerGrid.RowTemplate.Height = 24
        Me.PickerGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.PickerGrid.Size = New System.Drawing.Size(669, 319)
        Me.PickerGrid.TabIndex = 0
        '
        'confirm
        '
        Me.confirm.Location = New System.Drawing.Point(13, 338)
        Me.confirm.Name = "confirm"
        Me.confirm.Size = New System.Drawing.Size(146, 57)
        Me.confirm.TabIndex = 1
        Me.confirm.Text = "OK"
        Me.confirm.UseVisualStyleBackColor = True
        '
        'CustomerPicker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(698, 407)
        Me.Controls.Add(Me.confirm)
        Me.Controls.Add(Me.PickerGrid)
        Me.Name = "CustomerPicker"
        Me.ShowInTaskbar = False
        Me.Text = "Picker"
        CType(Me.PickerGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PickerGrid As DataGridView
    Friend WithEvents confirm As Button
End Class
