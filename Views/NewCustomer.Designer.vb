<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewCustomer
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
        Me.addcustomer = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.emailsignup = New System.Windows.Forms.TextBox()
        Me.lastnamesignup = New System.Windows.Forms.TextBox()
        Me.firstnamesignup = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.updatecustomer = New System.Windows.Forms.Button()
        Me.CustomerDataGrid = New System.Windows.Forms.DataGridView()
        Me.editcustomer = New System.Windows.Forms.Button()
        Me.deletecustomer = New System.Windows.Forms.Button()
        CType(Me.CustomerDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'addcustomer
        '
        Me.addcustomer.BackColor = System.Drawing.Color.PowderBlue
        Me.addcustomer.Font = New System.Drawing.Font("Microsoft Tai Le", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addcustomer.Location = New System.Drawing.Point(22, 383)
        Me.addcustomer.Name = "addcustomer"
        Me.addcustomer.Size = New System.Drawing.Size(183, 53)
        Me.addcustomer.TabIndex = 33
        Me.addcustomer.Text = "Add"
        Me.addcustomer.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Tai Le", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 238)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(161, 30)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Email Address"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(57, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 30)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Last Name"
        '
        'emailsignup
        '
        Me.emailsignup.Font = New System.Drawing.Font("Microsoft Tai Le", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailsignup.Location = New System.Drawing.Point(210, 235)
        Me.emailsignup.Name = "emailsignup"
        Me.emailsignup.Size = New System.Drawing.Size(227, 37)
        Me.emailsignup.TabIndex = 22
        '
        'lastnamesignup
        '
        Me.lastnamesignup.Font = New System.Drawing.Font("Microsoft Tai Le", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastnamesignup.Location = New System.Drawing.Point(210, 168)
        Me.lastnamesignup.Name = "lastnamesignup"
        Me.lastnamesignup.Size = New System.Drawing.Size(227, 37)
        Me.lastnamesignup.TabIndex = 21
        '
        'firstnamesignup
        '
        Me.firstnamesignup.Font = New System.Drawing.Font("Microsoft Tai Le", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstnamesignup.Location = New System.Drawing.Point(210, 105)
        Me.firstnamesignup.Name = "firstnamesignup"
        Me.firstnamesignup.Size = New System.Drawing.Size(227, 37)
        Me.firstnamesignup.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(54, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 30)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "First Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 29)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Add Customer"
        '
        'updatecustomer
        '
        Me.updatecustomer.BackColor = System.Drawing.Color.PowderBlue
        Me.updatecustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updatecustomer.Location = New System.Drawing.Point(22, 465)
        Me.updatecustomer.Name = "updatecustomer"
        Me.updatecustomer.Size = New System.Drawing.Size(183, 51)
        Me.updatecustomer.TabIndex = 34
        Me.updatecustomer.Text = "Update"
        Me.updatecustomer.UseVisualStyleBackColor = False
        '
        'CustomerDataGrid
        '
        Me.CustomerDataGrid.AllowUserToAddRows = False
        Me.CustomerDataGrid.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.CustomerDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CustomerDataGrid.Location = New System.Drawing.Point(538, 24)
        Me.CustomerDataGrid.MultiSelect = False
        Me.CustomerDataGrid.Name = "CustomerDataGrid"
        Me.CustomerDataGrid.ReadOnly = True
        Me.CustomerDataGrid.RowHeadersWidth = 51
        Me.CustomerDataGrid.RowTemplate.Height = 24
        Me.CustomerDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CustomerDataGrid.Size = New System.Drawing.Size(835, 603)
        Me.CustomerDataGrid.TabIndex = 35
        '
        'editcustomer
        '
        Me.editcustomer.BackColor = System.Drawing.Color.PowderBlue
        Me.editcustomer.Font = New System.Drawing.Font("Microsoft Tai Le", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editcustomer.Location = New System.Drawing.Point(226, 383)
        Me.editcustomer.Name = "editcustomer"
        Me.editcustomer.Size = New System.Drawing.Size(211, 53)
        Me.editcustomer.TabIndex = 36
        Me.editcustomer.Text = "Edit"
        Me.editcustomer.UseVisualStyleBackColor = False
        '
        'deletecustomer
        '
        Me.deletecustomer.BackColor = System.Drawing.Color.PowderBlue
        Me.deletecustomer.Font = New System.Drawing.Font("Microsoft Tai Le", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deletecustomer.Location = New System.Drawing.Point(226, 465)
        Me.deletecustomer.Name = "deletecustomer"
        Me.deletecustomer.Size = New System.Drawing.Size(211, 51)
        Me.deletecustomer.TabIndex = 37
        Me.deletecustomer.Text = "Delete"
        Me.deletecustomer.UseVisualStyleBackColor = False
        '
        'NewCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(1401, 653)
        Me.Controls.Add(Me.deletecustomer)
        Me.Controls.Add(Me.editcustomer)
        Me.Controls.Add(Me.CustomerDataGrid)
        Me.Controls.Add(Me.updatecustomer)
        Me.Controls.Add(Me.addcustomer)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.emailsignup)
        Me.Controls.Add(Me.lastnamesignup)
        Me.Controls.Add(Me.firstnamesignup)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "NewCustomer"
        Me.Text = "NewCustomer"
        CType(Me.CustomerDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents addcustomer As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents emailsignup As TextBox
    Friend WithEvents lastnamesignup As TextBox
    Friend WithEvents firstnamesignup As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents updatecustomer As Button
    Friend WithEvents CustomerDataGrid As DataGridView
    Friend WithEvents editcustomer As Button
    Friend WithEvents deletecustomer As Button
End Class
