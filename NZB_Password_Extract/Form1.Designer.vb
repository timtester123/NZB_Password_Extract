<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TextBox_passwords = New System.Windows.Forms.TextBox()
        Me.Button_plain = New System.Windows.Forms.Button()
        Me.Button_comma = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox_passwords
        '
        Me.TextBox_passwords.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TextBox_passwords.Location = New System.Drawing.Point(0, 72)
        Me.TextBox_passwords.Multiline = True
        Me.TextBox_passwords.Name = "TextBox_passwords"
        Me.TextBox_passwords.Size = New System.Drawing.Size(660, 339)
        Me.TextBox_passwords.TabIndex = 0
        '
        'Button_plain
        '
        Me.Button_plain.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button_plain.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_plain.Location = New System.Drawing.Point(0, 0)
        Me.Button_plain.Name = "Button_plain"
        Me.Button_plain.Size = New System.Drawing.Size(325, 72)
        Me.Button_plain.TabIndex = 1
        Me.Button_plain.Text = "Plain Text"
        Me.Button_plain.UseVisualStyleBackColor = True
        '
        'Button_comma
        '
        Me.Button_comma.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button_comma.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_comma.Location = New System.Drawing.Point(331, 0)
        Me.Button_comma.Name = "Button_comma"
        Me.Button_comma.Size = New System.Drawing.Size(329, 72)
        Me.Button_comma.TabIndex = 2
        Me.Button_comma.Text = "Comma separated"
        Me.Button_comma.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(660, 411)
        Me.Controls.Add(Me.Button_comma)
        Me.Controls.Add(Me.Button_plain)
        Me.Controls.Add(Me.TextBox_passwords)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Password Extract"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox_passwords As TextBox
    Friend WithEvents Button_plain As Button
    Friend WithEvents Button_comma As Button
End Class
