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
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtPost = New System.Windows.Forms.TextBox()
        Me.btnSpara = New System.Windows.Forms.Button()
        Me.btnNy = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
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
        'btnFirst
        '
        Me.btnFirst.Location = New System.Drawing.Point(3, 3)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(80, 34)
        Me.btnFirst.TabIndex = 12
        Me.btnFirst.Text = "<<"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(89, 3)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(80, 34)
        Me.btnPrevious.TabIndex = 13
        Me.btnPrevious.Text = "<"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(245, 3)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(80, 34)
        Me.btnNext.TabIndex = 14
        Me.btnNext.Text = ">"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(331, 3)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(80, 34)
        Me.btnLast.TabIndex = 15
        Me.btnLast.Text = ">>"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.txtPost)
        Me.Panel1.Controls.Add(Me.btnFirst)
        Me.Panel1.Controls.Add(Me.btnLast)
        Me.Panel1.Controls.Add(Me.btnPrevious)
        Me.Panel1.Controls.Add(Me.btnNext)
        Me.Panel1.Location = New System.Drawing.Point(12, 324)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(415, 41)
        Me.Panel1.TabIndex = 16
        '
        'txtPost
        '
        Me.txtPost.Location = New System.Drawing.Point(176, 4)
        Me.txtPost.MaxLength = 7
        Me.txtPost.Name = "txtPost"
        Me.txtPost.Size = New System.Drawing.Size(63, 31)
        Me.txtPost.TabIndex = 1
        Me.txtPost.Text = "txtPost"
        Me.txtPost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnSpara
        '
        Me.btnSpara.Location = New System.Drawing.Point(311, 99)
        Me.btnSpara.Name = "btnSpara"
        Me.btnSpara.Size = New System.Drawing.Size(112, 34)
        Me.btnSpara.TabIndex = 17
        Me.btnSpara.Text = "Spara"
        Me.btnSpara.UseVisualStyleBackColor = True
        '
        'btnNy
        '
        Me.btnNy.Location = New System.Drawing.Point(311, 33)
        Me.btnNy.Name = "btnNy"
        Me.btnNy.Size = New System.Drawing.Size(112, 34)
        Me.btnNy.TabIndex = 18
        Me.btnNy.Text = "Ny"
        Me.btnNy.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 377)
        Me.Controls.Add(Me.btnNy)
        Me.Controls.Add(Me.btnSpara)
        Me.Controls.Add(Me.Panel1)
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
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
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
    Friend WithEvents btnFirst As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnLast As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtPost As TextBox
    Friend WithEvents btnSpara As Button
    Friend WithEvents btnNy As Button
End Class
