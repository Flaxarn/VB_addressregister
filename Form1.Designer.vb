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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.txtOrt = New System.Windows.Forms.TextBox()
        Me.txtPostnr = New System.Windows.Forms.TextBox()
        Me.txtAdress = New System.Windows.Forms.TextBox()
        Me.txtEfternamn = New System.Windows.Forms.TextBox()
        Me.txtFornamn = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblSkapad = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Förnamn"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(168, 195)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ort"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Efternamn"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Adress"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(12, 195)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(65, 25)
        Me.label5.TabIndex = 4
        Me.label5.Text = "PostNr"
        '
        'txtOrt
        '
        Me.txtOrt.Location = New System.Drawing.Point(168, 223)
        Me.txtOrt.Name = "txtOrt"
        Me.txtOrt.Size = New System.Drawing.Size(255, 31)
        Me.txtOrt.TabIndex = 5
        '
        'txtPostnr
        '
        Me.txtPostnr.Location = New System.Drawing.Point(12, 223)
        Me.txtPostnr.Name = "txtPostnr"
        Me.txtPostnr.Size = New System.Drawing.Size(150, 31)
        Me.txtPostnr.TabIndex = 6
        '
        'txtAdress
        '
        Me.txtAdress.Location = New System.Drawing.Point(12, 161)
        Me.txtAdress.Name = "txtAdress"
        Me.txtAdress.Size = New System.Drawing.Size(150, 31)
        Me.txtAdress.TabIndex = 7
        '
        'txtEfternamn
        '
        Me.txtEfternamn.Location = New System.Drawing.Point(12, 99)
        Me.txtEfternamn.Name = "txtEfternamn"
        Me.txtEfternamn.Size = New System.Drawing.Size(150, 31)
        Me.txtEfternamn.TabIndex = 8
        '
        'txtFornamn
        '
        Me.txtFornamn.Location = New System.Drawing.Point(12, 37)
        Me.txtFornamn.Name = "txtFornamn"
        Me.txtFornamn.Size = New System.Drawing.Size(150, 31)
        Me.txtFornamn.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 257)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 25)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Skapad:"
        '
        'lblSkapad
        '
        Me.lblSkapad.AutoSize = True
        Me.lblSkapad.Location = New System.Drawing.Point(168, 257)
        Me.lblSkapad.Name = "lblSkapad"
        Me.lblSkapad.Size = New System.Drawing.Size(90, 25)
        Me.lblSkapad.TabIndex = 11
        Me.lblSkapad.Text = "lblSkapad"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblSkapad)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtFornamn)
        Me.Controls.Add(Me.txtEfternamn)
        Me.Controls.Add(Me.txtAdress)
        Me.Controls.Add(Me.txtPostnr)
        Me.Controls.Add(Me.txtOrt)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Adresser"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents label5 As Label
    Friend WithEvents txtOrt As TextBox
    Friend WithEvents txtPostnr As TextBox
    Friend WithEvents txtAdress As TextBox
    Friend WithEvents txtEfternamn As TextBox
    Friend WithEvents txtFornamn As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lblSkapad As Label
End Class
