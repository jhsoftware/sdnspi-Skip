<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Skip
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
    Me.lblCaption = New System.Windows.Forms.Label
    Me.radSome = New System.Windows.Forms.RadioButton
    Me.radAll = New System.Windows.Forms.RadioButton
    Me.numCt = New System.Windows.Forms.NumericUpDown
    Me.Label1 = New System.Windows.Forms.Label
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
    CType(Me.numCt, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.TableLayoutPanel1.SuspendLayout()
    Me.SuspendLayout()
    '
    'lblCaption
    '
    Me.lblCaption.AutoSize = True
    Me.TableLayoutPanel1.SetColumnSpan(Me.lblCaption, 3)
    Me.lblCaption.Location = New System.Drawing.Point(0, 0)
    Me.lblCaption.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
    Me.lblCaption.Name = "lblCaption"
    Me.lblCaption.Size = New System.Drawing.Size(31, 13)
    Me.lblCaption.TabIndex = 0
    Me.lblCaption.Text = "Skip:"
    '
    'radSome
    '
    Me.radSome.Anchor = System.Windows.Forms.AnchorStyles.None
    Me.radSome.AutoSize = True
    Me.radSome.Location = New System.Drawing.Point(0, 37)
    Me.radSome.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
    Me.radSome.Name = "radSome"
    Me.radSome.Size = New System.Drawing.Size(67, 17)
    Me.radSome.TabIndex = 2
    Me.radSome.TabStop = True
    Me.radSome.Text = "The next"
    Me.radSome.UseVisualStyleBackColor = True
    '
    'radAll
    '
    Me.radAll.AutoSize = True
    Me.radAll.Checked = True
    Me.TableLayoutPanel1.SetColumnSpan(Me.radAll, 3)
    Me.radAll.Location = New System.Drawing.Point(0, 16)
    Me.radAll.Margin = New System.Windows.Forms.Padding(0, 3, 3, 0)
    Me.radAll.Name = "radAll"
    Me.radAll.Size = New System.Drawing.Size(166, 17)
    Me.radAll.TabIndex = 1
    Me.radAll.TabStop = True
    Me.radAll.Text = "All remaining plug-in instances"
    Me.radAll.UseVisualStyleBackColor = True
    '
    'numCt
    '
    Me.numCt.Enabled = False
    Me.numCt.Location = New System.Drawing.Point(70, 36)
    Me.numCt.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
    Me.numCt.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
    Me.numCt.Name = "numCt"
    Me.numCt.Size = New System.Drawing.Size(48, 20)
    Me.numCt.TabIndex = 3
    Me.numCt.Value = New Decimal(New Integer() {1, 0, 0, 0})
    '
    'Label1
    '
    Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(121, 39)
    Me.Label1.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(86, 13)
    Me.Label1.TabIndex = 4
    Me.Label1.Text = "plug-in instances"
    '
    'TableLayoutPanel1
    '
    Me.TableLayoutPanel1.AutoSize = True
    Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
    Me.TableLayoutPanel1.ColumnCount = 3
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
    Me.TableLayoutPanel1.Controls.Add(Me.radSome, 0, 2)
    Me.TableLayoutPanel1.Controls.Add(Me.radAll, 0, 1)
    Me.TableLayoutPanel1.Controls.Add(Me.lblCaption, 0, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.numCt, 1, 2)
    Me.TableLayoutPanel1.Controls.Add(Me.Label1, 2, 2)
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
    Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 3
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle)
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle)
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle)
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(210, 59)
    Me.TableLayoutPanel1.TabIndex = 0
    '
    'Skip
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.AutoSize = True
    Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
    Me.Controls.Add(Me.TableLayoutPanel1)
    Me.Name = "Skip"
    Me.Size = New System.Drawing.Size(210, 59)
    CType(Me.numCt, System.ComponentModel.ISupportInitialize).EndInit()
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.TableLayoutPanel1.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents lblCaption As System.Windows.Forms.Label
  Friend WithEvents radSome As System.Windows.Forms.RadioButton
  Friend WithEvents radAll As System.Windows.Forms.RadioButton
  Friend WithEvents numCt As System.Windows.Forms.NumericUpDown
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel

End Class
