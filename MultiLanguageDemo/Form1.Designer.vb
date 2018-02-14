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
        Me.optEng = New System.Windows.Forms.RadioButton()
        Me.optSpn = New System.Windows.Forms.RadioButton()
        Me.btnHello = New System.Windows.Forms.Button()
        Me.btnBye = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'optEng
        '
        Me.optEng.AutoSize = True
        Me.optEng.Checked = True
        Me.optEng.Location = New System.Drawing.Point(18, 18)
        Me.optEng.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.optEng.Name = "optEng"
        Me.optEng.Size = New System.Drawing.Size(86, 24)
        Me.optEng.TabIndex = 0
        Me.optEng.TabStop = True
        Me.optEng.Text = "English"
        Me.optEng.UseVisualStyleBackColor = True
        '
        'optSpn
        '
        Me.optSpn.AutoSize = True
        Me.optSpn.Location = New System.Drawing.Point(18, 69)
        Me.optSpn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.optSpn.Name = "optSpn"
        Me.optSpn.Size = New System.Drawing.Size(92, 24)
        Me.optSpn.TabIndex = 1
        Me.optSpn.Text = "Spanish"
        Me.optSpn.UseVisualStyleBackColor = True
        '
        'btnHello
        '
        Me.btnHello.Location = New System.Drawing.Point(18, 212)
        Me.btnHello.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnHello.Name = "btnHello"
        Me.btnHello.Size = New System.Drawing.Size(184, 58)
        Me.btnHello.TabIndex = 2
        Me.btnHello.Text = "Hello"
        Me.btnHello.UseVisualStyleBackColor = True
        '
        'btnBye
        '
        Me.btnBye.Location = New System.Drawing.Point(212, 212)
        Me.btnBye.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnBye.Name = "btnBye"
        Me.btnBye.Size = New System.Drawing.Size(184, 58)
        Me.btnBye.TabIndex = 3
        Me.btnBye.Text = "Good bye"
        Me.btnBye.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 289)
        Me.Controls.Add(Me.btnBye)
        Me.Controls.Add(Me.btnHello)
        Me.Controls.Add(Me.optSpn)
        Me.Controls.Add(Me.optEng)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents optEng As System.Windows.Forms.RadioButton
    Friend WithEvents optSpn As System.Windows.Forms.RadioButton
    Friend WithEvents btnHello As System.Windows.Forms.Button
    Friend WithEvents btnBye As System.Windows.Forms.Button

End Class
