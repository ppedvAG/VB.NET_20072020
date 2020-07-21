<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NeuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.LadenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpeichernToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BeendenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExcelExportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Behälter"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(48, 69)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(200, 28)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(48, 162)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(200, 28)
        Me.TextBox2.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(182, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Max. Füllmenge [ml]"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 236)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 24)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Inhalt"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(48, 263)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(200, 30)
        Me.ComboBox1.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(290, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(214, 92)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Füllstand: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "137ml"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Increment = New Decimal(New Integer() {20, 0, 0, 0})
        Me.NumericUpDown1.Location = New System.Drawing.Point(6, 27)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(85, 28)
        Me.NumericUpDown1.TabIndex = 7
        Me.NumericUpDown1.Value = New Decimal(New Integer() {150, 0, 0, 0})
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(7, 58)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(193, 38)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Schluck nehmen"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox1.Location = New System.Drawing.Point(307, 203)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(209, 100)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Trinken"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(97, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 24)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "ml"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(435, 321)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(299, 47)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Nachfüllen"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(449, 371)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(265, 24)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Es wurde noch nie nachgefüllt"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.DrinkManager.My.Resources.Resources.iu_1_
        Me.PictureBox1.Location = New System.Drawing.Point(554, 53)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(180, 180)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(298, 149)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(218, 38)
        Me.ProgressBar1.TabIndex = 14
        Me.ProgressBar1.Value = 58
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BierToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(746, 28)
        Me.MenuStrip1.TabIndex = 15
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BierToolStripMenuItem
        '
        Me.BierToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NeuToolStripMenuItem, Me.ToolStripMenuItem1, Me.LadenToolStripMenuItem, Me.SpeichernToolStripMenuItem, Me.ToolStripMenuItem3, Me.ExcelExportToolStripMenuItem, Me.ToolStripMenuItem2, Me.BeendenToolStripMenuItem})
        Me.BierToolStripMenuItem.Name = "BierToolStripMenuItem"
        Me.BierToolStripMenuItem.Size = New System.Drawing.Size(58, 24)
        Me.BierToolStripMenuItem.Text = "Drink"
        '
        'NeuToolStripMenuItem
        '
        Me.NeuToolStripMenuItem.Name = "NeuToolStripMenuItem"
        Me.NeuToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.NeuToolStripMenuItem.Text = "Neu"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(221, 6)
        '
        'LadenToolStripMenuItem
        '
        Me.LadenToolStripMenuItem.Name = "LadenToolStripMenuItem"
        Me.LadenToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.LadenToolStripMenuItem.Text = "Laden..."
        '
        'SpeichernToolStripMenuItem
        '
        Me.SpeichernToolStripMenuItem.Name = "SpeichernToolStripMenuItem"
        Me.SpeichernToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.SpeichernToolStripMenuItem.Text = "Speichern..."
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(221, 6)
        '
        'BeendenToolStripMenuItem
        '
        Me.BeendenToolStripMenuItem.Name = "BeendenToolStripMenuItem"
        Me.BeendenToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.BeendenToolStripMenuItem.Text = "Beenden"
        '
        'ExcelExportToolStripMenuItem
        '
        Me.ExcelExportToolStripMenuItem.Name = "ExcelExportToolStripMenuItem"
        Me.ExcelExportToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ExcelExportToolStripMenuItem.Text = "Excel Import"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(224, 26)
        Me.ToolStripMenuItem3.Text = "Excel Export"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(746, 408)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Drink-Manager 5000 v0.2 *** PREMIUM EDITION *** (nur ab 18 Jahre)"
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NeuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents LadenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SpeichernToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents BeendenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExcelExportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
End Class
