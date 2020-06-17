<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.newcustomermenustrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.CarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.newcarmenustrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.RentalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mainpanel = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RentalsDataGridView = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1.SuspendLayout()
        Me.mainpanel.SuspendLayout()
        CType(Me.RentalsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomerToolStripMenuItem, Me.CarToolStripMenuItem, Me.RentalToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1509, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CustomerToolStripMenuItem
        '
        Me.CustomerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.newcustomermenustrip})
        Me.CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem"
        Me.CustomerToolStripMenuItem.Size = New System.Drawing.Size(92, 24)
        Me.CustomerToolStripMenuItem.Text = "Customers"
        '
        'newcustomermenustrip
        '
        Me.newcustomermenustrip.Name = "newcustomermenustrip"
        Me.newcustomermenustrip.Size = New System.Drawing.Size(146, 26)
        Me.newcustomermenustrip.Text = "Manage"
        '
        'CarToolStripMenuItem
        '
        Me.CarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.newcarmenustrip})
        Me.CarToolStripMenuItem.Name = "CarToolStripMenuItem"
        Me.CarToolStripMenuItem.Size = New System.Drawing.Size(51, 24)
        Me.CarToolStripMenuItem.Text = "Cars"
        '
        'newcarmenustrip
        '
        Me.newcarmenustrip.Name = "newcarmenustrip"
        Me.newcarmenustrip.Size = New System.Drawing.Size(146, 26)
        Me.newcarmenustrip.Text = "Manage"
        '
        'RentalToolStripMenuItem
        '
        Me.RentalToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem})
        Me.RentalToolStripMenuItem.Name = "RentalToolStripMenuItem"
        Me.RentalToolStripMenuItem.Size = New System.Drawing.Size(71, 24)
        Me.RentalToolStripMenuItem.Text = "Rentals"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(146, 26)
        Me.NewToolStripMenuItem.Text = "Manage"
        '
        'mainpanel
        '
        Me.mainpanel.Controls.Add(Me.Label1)
        Me.mainpanel.Controls.Add(Me.RentalsDataGridView)
        Me.mainpanel.Location = New System.Drawing.Point(13, 32)
        Me.mainpanel.Name = "mainpanel"
        Me.mainpanel.Size = New System.Drawing.Size(1484, 631)
        Me.mainpanel.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 30)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Overview"
        '
        'RentalsDataGridView
        '
        Me.RentalsDataGridView.AllowUserToAddRows = False
        Me.RentalsDataGridView.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.RentalsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RentalsDataGridView.Location = New System.Drawing.Point(13, 58)
        Me.RentalsDataGridView.MultiSelect = False
        Me.RentalsDataGridView.Name = "RentalsDataGridView"
        Me.RentalsDataGridView.ReadOnly = True
        Me.RentalsDataGridView.RowHeadersWidth = 51
        Me.RentalsDataGridView.RowTemplate.Height = 24
        Me.RentalsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.RentalsDataGridView.Size = New System.Drawing.Size(1454, 560)
        Me.RentalsDataGridView.TabIndex = 0
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1509, 675)
        Me.Controls.Add(Me.mainpanel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Dashboard"
        Me.Text = "Dashboard"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.mainpanel.ResumeLayout(False)
        Me.mainpanel.PerformLayout()
        CType(Me.RentalsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CustomerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents newcustomermenustrip As ToolStripMenuItem
    Friend WithEvents newcarmenustrip As ToolStripMenuItem
    Friend WithEvents mainpanel As Panel
    Friend WithEvents RentalsDataGridView As DataGridView
    Friend WithEvents RentalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
End Class
