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
        Me.btnSubmit_24 = New System.Windows.Forms.Button()
        Me.txtUserName_24 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSubmit_24
        '
        Me.btnSubmit_24.Location = New System.Drawing.Point(330, 365)
        Me.btnSubmit_24.Name = "btnSubmit_24"
        Me.btnSubmit_24.Size = New System.Drawing.Size(294, 37)
        Me.btnSubmit_24.TabIndex = 0
        Me.btnSubmit_24.Text = "Submit"
        Me.btnSubmit_24.UseVisualStyleBackColor = True
        '
        'txtUserName_24
        '
        Me.txtUserName_24.Location = New System.Drawing.Point(174, 79)
        Me.txtUserName_24.Multiline = True
        Me.txtUserName_24.Name = "txtUserName_24"
        Me.txtUserName_24.Size = New System.Drawing.Size(782, 94)
        Me.txtUserName_24.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(86, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Enter senteces"
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(174, 205)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(82, 15)
        Me.lblResult.TabIndex = 3
        Me.lblResult.Text = "Enter senteces"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1019, 464)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtUserName_24)
        Me.Controls.Add(Me.btnSubmit_24)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSubmit_24 As Button
    Friend WithEvents txtUserName_24 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblResult As Label
End Class
