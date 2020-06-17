<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewCar
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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cpd = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.bodytypecombo = New System.Windows.Forms.ComboBox()
        Me.deletecar = New System.Windows.Forms.Button()
        Me.editcar = New System.Windows.Forms.Button()
        Me.CarDataGridView = New System.Windows.Forms.DataGridView()
        Me.updatecar = New System.Windows.Forms.Button()
        Me.addcar = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.transcombo = New System.Windows.Forms.ComboBox()
        Me.doorscombo = New System.Windows.Forms.ComboBox()
        Me.yearofmakeinput = New System.Windows.Forms.TextBox()
        Me.plateinput = New System.Windows.Forms.TextBox()
        Me.modelinput = New System.Windows.Forms.TextBox()
        Me.makeinput = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.CarDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.cpd)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.bodytypecombo)
        Me.Panel1.Controls.Add(Me.deletecar)
        Me.Panel1.Controls.Add(Me.editcar)
        Me.Panel1.Controls.Add(Me.CarDataGridView)
        Me.Panel1.Controls.Add(Me.updatecar)
        Me.Panel1.Controls.Add(Me.addcar)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.transcombo)
        Me.Panel1.Controls.Add(Me.doorscombo)
        Me.Panel1.Controls.Add(Me.yearofmakeinput)
        Me.Panel1.Controls.Add(Me.plateinput)
        Me.Panel1.Controls.Add(Me.modelinput)
        Me.Panel1.Controls.Add(Me.makeinput)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1374, 633)
        Me.Panel1.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Tai Le", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(74, 441)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(149, 30)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Cost Per Day"
        '
        'cpd
        '
        Me.cpd.Font = New System.Drawing.Font("Microsoft Tai Le", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cpd.Location = New System.Drawing.Point(244, 434)
        Me.cpd.Name = "cpd"
        Me.cpd.Size = New System.Drawing.Size(227, 37)
        Me.cpd.TabIndex = 24
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Tai Le", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(106, 381)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 30)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Body Type"
        '
        'bodytypecombo
        '
        Me.bodytypecombo.Font = New System.Drawing.Font("Microsoft Tai Le", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bodytypecombo.FormattingEnabled = True
        Me.bodytypecombo.Items.AddRange(New Object() {"COUPE", "SEDAN", "HATCHKACK", "CONVERTIBLE", "WAGON", "SUV"})
        Me.bodytypecombo.Location = New System.Drawing.Point(244, 378)
        Me.bodytypecombo.Name = "bodytypecombo"
        Me.bodytypecombo.Size = New System.Drawing.Size(227, 38)
        Me.bodytypecombo.TabIndex = 22
        '
        'deletecar
        '
        Me.deletecar.BackColor = System.Drawing.Color.LightBlue
        Me.deletecar.Font = New System.Drawing.Font("Microsoft Tai Le", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deletecar.Location = New System.Drawing.Point(244, 562)
        Me.deletecar.Name = "deletecar"
        Me.deletecar.Size = New System.Drawing.Size(227, 48)
        Me.deletecar.TabIndex = 21
        Me.deletecar.Text = "Delete"
        Me.deletecar.UseVisualStyleBackColor = False
        '
        'editcar
        '
        Me.editcar.BackColor = System.Drawing.Color.LightBlue
        Me.editcar.Font = New System.Drawing.Font("Microsoft Tai Le", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editcar.Location = New System.Drawing.Point(244, 496)
        Me.editcar.Name = "editcar"
        Me.editcar.Size = New System.Drawing.Size(227, 48)
        Me.editcar.TabIndex = 20
        Me.editcar.Text = "Edit"
        Me.editcar.UseVisualStyleBackColor = False
        '
        'CarDataGridView
        '
        Me.CarDataGridView.AllowUserToAddRows = False
        Me.CarDataGridView.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.CarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CarDataGridView.Location = New System.Drawing.Point(535, 18)
        Me.CarDataGridView.MultiSelect = False
        Me.CarDataGridView.Name = "CarDataGridView"
        Me.CarDataGridView.ReadOnly = True
        Me.CarDataGridView.RowHeadersWidth = 51
        Me.CarDataGridView.RowTemplate.Height = 24
        Me.CarDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CarDataGridView.Size = New System.Drawing.Size(817, 594)
        Me.CarDataGridView.TabIndex = 19
        '
        'updatecar
        '
        Me.updatecar.BackColor = System.Drawing.Color.LightBlue
        Me.updatecar.Font = New System.Drawing.Font("Microsoft Tai Le", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updatecar.Location = New System.Drawing.Point(24, 562)
        Me.updatecar.Name = "updatecar"
        Me.updatecar.Size = New System.Drawing.Size(208, 48)
        Me.updatecar.TabIndex = 18
        Me.updatecar.Text = "Update"
        Me.updatecar.UseVisualStyleBackColor = False
        '
        'addcar
        '
        Me.addcar.BackColor = System.Drawing.Color.LightBlue
        Me.addcar.Font = New System.Drawing.Font("Microsoft Tai Le", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addcar.Location = New System.Drawing.Point(24, 496)
        Me.addcar.Name = "addcar"
        Me.addcar.Size = New System.Drawing.Size(208, 48)
        Me.addcar.TabIndex = 17
        Me.addcar.Text = "Add "
        Me.addcar.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Tai Le", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(11, 330)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(221, 30)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Transmission Mode"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Tai Le", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(28, 275)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(204, 30)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Number Of Doors"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Tai Le", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(74, 219)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(158, 30)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Year Of Make"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Tai Le", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(155, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 30)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Plate"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(150, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 30)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Model"
        '
        'transcombo
        '
        Me.transcombo.Font = New System.Drawing.Font("Microsoft Tai Le", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.transcombo.FormattingEnabled = True
        Me.transcombo.Items.AddRange(New Object() {"MANUAL", "AUTOMATIC"})
        Me.transcombo.Location = New System.Drawing.Point(244, 325)
        Me.transcombo.Name = "transcombo"
        Me.transcombo.Size = New System.Drawing.Size(227, 38)
        Me.transcombo.TabIndex = 10
        '
        'doorscombo
        '
        Me.doorscombo.Font = New System.Drawing.Font("Microsoft Tai Le", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.doorscombo.FormattingEnabled = True
        Me.doorscombo.Items.AddRange(New Object() {"2", "4"})
        Me.doorscombo.Location = New System.Drawing.Point(244, 270)
        Me.doorscombo.Name = "doorscombo"
        Me.doorscombo.Size = New System.Drawing.Size(227, 38)
        Me.doorscombo.TabIndex = 9
        '
        'yearofmakeinput
        '
        Me.yearofmakeinput.Font = New System.Drawing.Font("Microsoft Tai Le", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yearofmakeinput.Location = New System.Drawing.Point(244, 212)
        Me.yearofmakeinput.Name = "yearofmakeinput"
        Me.yearofmakeinput.Size = New System.Drawing.Size(227, 37)
        Me.yearofmakeinput.TabIndex = 5
        '
        'plateinput
        '
        Me.plateinput.Font = New System.Drawing.Font("Microsoft Tai Le", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.plateinput.Location = New System.Drawing.Point(244, 158)
        Me.plateinput.Name = "plateinput"
        Me.plateinput.Size = New System.Drawing.Size(227, 37)
        Me.plateinput.TabIndex = 4
        '
        'modelinput
        '
        Me.modelinput.Font = New System.Drawing.Font("Microsoft Tai Le", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modelinput.Location = New System.Drawing.Point(244, 103)
        Me.modelinput.Name = "modelinput"
        Me.modelinput.Size = New System.Drawing.Size(227, 37)
        Me.modelinput.TabIndex = 3
        '
        'makeinput
        '
        Me.makeinput.Font = New System.Drawing.Font("Microsoft Tai Le", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.makeinput.Location = New System.Drawing.Point(244, 49)
        Me.makeinput.Name = "makeinput"
        Me.makeinput.Size = New System.Drawing.Size(227, 37)
        Me.makeinput.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(160, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 30)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Make"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Add Car"
        '
        'NewCar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(1398, 657)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "NewCar"
        Me.Text = "NewCar"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.CarDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents plateinput As TextBox
    Friend WithEvents modelinput As TextBox
    Friend WithEvents makeinput As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents addcar As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents transcombo As ComboBox
    Friend WithEvents doorscombo As ComboBox
    Friend WithEvents yearofmakeinput As TextBox
    Friend WithEvents deletecar As Button
    Friend WithEvents editcar As Button
    Friend WithEvents CarDataGridView As DataGridView
    Friend WithEvents updatecar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents bodytypecombo As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cpd As TextBox
End Class
