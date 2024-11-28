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
        Me.lblDecimalTitle = New System.Windows.Forms.Label()
        Me.txtDecimal = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lblBinaryTitle = New System.Windows.Forms.Label()
        Me.lblBinaryOutput = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.txtBinary = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 33)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(285, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "IP Decimal to Binary Converter"
        '
        'lblDecimalTitle
        '
        Me.lblDecimalTitle.AutoSize = True
        Me.lblDecimalTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDecimalTitle.Location = New System.Drawing.Point(151, 97)
        Me.lblDecimalTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDecimalTitle.Name = "lblDecimalTitle"
        Me.lblDecimalTitle.Size = New System.Drawing.Size(52, 13)
        Me.lblDecimalTitle.TabIndex = 1
        Me.lblDecimalTitle.Text = "Decimal"
        '
        'txtDecimal
        '
        Me.txtDecimal.Location = New System.Drawing.Point(154, 113)
        Me.txtDecimal.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtDecimal.Name = "txtDecimal"
        Me.txtDecimal.Size = New System.Drawing.Size(206, 20)
        Me.txtDecimal.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(34, 153)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(70, 27)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Calculate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(34, 195)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(70, 27)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lblBinaryTitle
        '
        Me.lblBinaryTitle.AutoSize = True
        Me.lblBinaryTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBinaryTitle.Location = New System.Drawing.Point(151, 168)
        Me.lblBinaryTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBinaryTitle.Name = "lblBinaryTitle"
        Me.lblBinaryTitle.Size = New System.Drawing.Size(42, 13)
        Me.lblBinaryTitle.TabIndex = 5
        Me.lblBinaryTitle.Text = "Binary"
        '
        'lblBinaryOutput
        '
        Me.lblBinaryOutput.AutoSize = True
        Me.lblBinaryOutput.Location = New System.Drawing.Point(126, 207)
        Me.lblBinaryOutput.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBinaryOutput.Name = "lblBinaryOutput"
        Me.lblBinaryOutput.Size = New System.Drawing.Size(0, 15)
        Me.lblBinaryOutput.TabIndex = 6
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(12, 118)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(121, 19)
        Me.RadioButton1.TabIndex = 7
        Me.RadioButton1.Text = "Binary to Decimal"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Checked = True
        Me.RadioButton2.Location = New System.Drawing.Point(12, 93)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(121, 19)
        Me.RadioButton2.TabIndex = 8
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Decimal to Binary"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'txtBinary
        '
        Me.txtBinary.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBinary.Location = New System.Drawing.Point(154, 184)
        Me.txtBinary.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtBinary.Name = "txtBinary"
        Me.txtBinary.ReadOnly = True
        Me.txtBinary.Size = New System.Drawing.Size(206, 20)
        Me.txtBinary.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(381, 245)
        Me.Controls.Add(Me.txtBinary)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.lblBinaryOutput)
        Me.Controls.Add(Me.lblBinaryTitle)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtDecimal)
        Me.Controls.Add(Me.lblDecimalTitle)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "Form1"
        Me.RightToLeftLayout = True
        Me.Text = "IP Decimal to Binary Converter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblDecimalTitle As Label
    Friend WithEvents txtDecimal As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents lblBinaryTitle As Label
    Friend WithEvents lblBinaryOutput As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents txtBinary As TextBox
End Class
