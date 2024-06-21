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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblQuestion1 = New System.Windows.Forms.Label()
        Me.txtAnswer1 = New System.Windows.Forms.TextBox()
        Me.lblQuestion2 = New System.Windows.Forms.Label()
        Me.rbOption1 = New System.Windows.Forms.RadioButton()
        Me.rbOption2 = New System.Windows.Forms.RadioButton()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(12, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(72, 13)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Survey Form"
        '
        'lblQuestion1
        '
        Me.lblQuestion1.AutoSize = True
        Me.lblQuestion1.Location = New System.Drawing.Point(12, 50)
        Me.lblQuestion1.Name = "lblQuestion1"
        Me.lblQuestion1.Size = New System.Drawing.Size(78, 13)
        Me.lblQuestion1.TabIndex = 1
        Me.lblQuestion1.Text = "What is your name?"
        '
        'txtAnswer1
        '
        Me.txtAnswer1.Location = New System.Drawing.Point(150, 50)
        Me.txtAnswer1.Name = "txtAnswer1"
        Me.txtAnswer1.Size = New System.Drawing.Size(200, 20)
        Me.txtAnswer1.TabIndex = 2
        '
        'lblQuestion2
        '
        Me.lblQuestion2.AutoSize = True
        Me.lblQuestion2.Location = New System.Drawing.Point(12, 100)
        Me.lblQuestion2.Name = "lblQuestion2"
        Me.lblQuestion2.Size = New System.Drawing.Size(111, 13)
        Me.lblQuestion2.TabIndex = 3
        Me.lblQuestion2.Text = "How did you hear about us?"
        '
        'rbOption1
        '
        Me.rbOption1.AutoSize = True
        Me.rbOption1.Location = New System.Drawing.Point(150, 100)
        Me.rbOption1.Name = "rbOption1"
        Me.rbOption1.Size = New System.Drawing.Size(56, 17)
        Me.rbOption1.TabIndex = 4
        Me.rbOption1.TabStop = True
        Me.rbOption1.Text = "Google"
        Me.rbOption1.UseVisualStyleBackColor = True
        '
        'rbOption2
        '
        Me.rbOption2.AutoSize = True
        Me.rbOption2.Location = New System.Drawing.Point(150, 123)
        Me.rbOption2.Name = "rbOption2"
        Me.rbOption2.Size = New System.Drawing.Size(54, 17)
        Me.rbOption2.TabIndex = 5
        Me.rbOption2.TabStop = True
        Me.rbOption2.Text = "Friend"
        Me.rbOption2.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(150, 200)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 6
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 261)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.rbOption2)
        Me.Controls.Add(Me.rbOption1)
        Me.Controls.Add(Me.lblQuestion2)
        Me.Controls.Add(Me.txtAnswer1)
        Me.Controls.Add(Me.lblQuestion1)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblQuestion1 As Label
    Friend WithEvents txtAnswer1 As TextBox
    Friend WithEvents lblQuestion2 As Label
    Friend WithEvents rbOption1 As RadioButton
    Friend WithEvents rbOption2 As RadioButton
    Friend WithEvents btnSubmit As Button
End Class
