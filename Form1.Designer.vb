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
        Me.lstChat = New System.Windows.Forms.ListBox()
        Me.txtUserInput = New System.Windows.Forms.TextBox()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.lblSuggestions = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstChat
        '
        Me.lstChat.BackColor = System.Drawing.Color.Black
        Me.lstChat.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lstChat.ForeColor = System.Drawing.Color.LightGreen
        Me.lstChat.FormattingEnabled = True
        Me.lstChat.ItemHeight = 19
        Me.lstChat.Location = New System.Drawing.Point(10, 10)
        Me.lstChat.Name = "lstChat"
        Me.lstChat.Size = New System.Drawing.Size(460, 289)
        Me.lstChat.TabIndex = 0
        '
        'txtUserInput
        '
        Me.txtUserInput.BackColor = System.Drawing.Color.White
        Me.txtUserInput.Location = New System.Drawing.Point(10, 320)
        Me.txtUserInput.Name = "txtUserInput"
        Me.txtUserInput.Size = New System.Drawing.Size(360, 22)
        Me.txtUserInput.TabIndex = 1
        '
        'btnSend
        '
        Me.btnSend.BackColor = System.Drawing.Color.DarkBlue
        Me.btnSend.ForeColor = System.Drawing.Color.White
        Me.btnSend.Location = New System.Drawing.Point(380, 320)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(90, 30)
        Me.btnSend.TabIndex = 2
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = False
        '
        'lblSuggestions
        '
        Me.lblSuggestions.BackColor = System.Drawing.Color.DarkBlue
        Me.lblSuggestions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSuggestions.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.lblSuggestions.ForeColor = System.Drawing.Color.White
        Me.lblSuggestions.Location = New System.Drawing.Point(513, 65)
        Me.lblSuggestions.Name = "lblSuggestions"
        Me.lblSuggestions.Size = New System.Drawing.Size(300, 100)
        Me.lblSuggestions.TabIndex = 3
        Me.lblSuggestions.Text = "Label1"
        Me.lblSuggestions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(860, 450)
        Me.Controls.Add(Me.lblSuggestions)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.txtUserInput)
        Me.Controls.Add(Me.lstChat)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstChat As ListBox
    Friend WithEvents txtUserInput As TextBox
    Friend WithEvents btnSend As Button
    Friend WithEvents lblSuggestions As Label
End Class
