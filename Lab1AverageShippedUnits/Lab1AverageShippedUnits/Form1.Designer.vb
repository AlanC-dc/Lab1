<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAverageUnitsShipped
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
        Me.components = New System.ComponentModel.Container()
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.lblResults = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.AverageUnitsShippedTips = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtEntryDisplay = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblUnits
        '
        Me.lblUnits.Location = New System.Drawing.Point(49, 39)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(48, 23)
        Me.lblUnits.TabIndex = 0
        Me.lblUnits.Text = "&Units:"
        Me.lblUnits.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtInput
        '
        Me.txtInput.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtInput.Location = New System.Drawing.Point(103, 40)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(62, 22)
        Me.txtInput.TabIndex = 1
        Me.AverageUnitsShippedTips.SetToolTip(Me.txtInput, "Input the number of units shipped for the day")
        '
        'lblDay
        '
        Me.lblDay.Location = New System.Drawing.Point(197, 40)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(47, 23)
        Me.lblDay.TabIndex = 2
        Me.lblDay.Text = "Day 1"
        Me.lblDay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblResults
        '
        Me.lblResults.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResults.Location = New System.Drawing.Point(44, 230)
        Me.lblResults.Name = "lblResults"
        Me.lblResults.Size = New System.Drawing.Size(241, 29)
        Me.lblResults.TabIndex = 4
        Me.lblResults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.AverageUnitsShippedTips.SetToolTip(Me.lblResults, "Displays the calculated average units shipped")
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(12, 271)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(85, 33)
        Me.btnEnter.TabIndex = 5
        Me.btnEnter.Text = "&Enter"
        Me.AverageUnitsShippedTips.SetToolTip(Me.btnEnter, "Confirm current textbox input")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(103, 271)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(91, 33)
        Me.btnReset.TabIndex = 6
        Me.btnReset.Text = "&Reset"
        Me.AverageUnitsShippedTips.SetToolTip(Me.btnReset, "Reset the entire application")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(200, 271)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(99, 33)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "E&xit"
        Me.AverageUnitsShippedTips.SetToolTip(Me.btnExit, "Exit the application")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtEntryDisplay
        '
        Me.txtEntryDisplay.Location = New System.Drawing.Point(44, 81)
        Me.txtEntryDisplay.Multiline = True
        Me.txtEntryDisplay.Name = "txtEntryDisplay"
        Me.txtEntryDisplay.ReadOnly = True
        Me.txtEntryDisplay.Size = New System.Drawing.Size(241, 134)
        Me.txtEntryDisplay.TabIndex = 8
        Me.AverageUnitsShippedTips.SetToolTip(Me.txtEntryDisplay, "Displays all previous day inputs")
        '
        'frmAverageUnitsShipped
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(321, 330)
        Me.Controls.Add(Me.txtEntryDisplay)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lblResults)
        Me.Controls.Add(Me.lblDay)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lblUnits)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAverageUnitsShipped"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUnits As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents lblDay As Label
    Friend WithEvents lblResults As Label
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents AverageUnitsShippedTips As ToolTip
    Friend WithEvents txtEntryDisplay As TextBox
End Class
