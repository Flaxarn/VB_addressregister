<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLista
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
        Me.lvwAdresser = New System.Windows.Forms.ListView()
        Me.collID = New System.Windows.Forms.ColumnHeader()
        Me.colFornamn = New System.Windows.Forms.ColumnHeader()
        Me.colEfternamn = New System.Windows.Forms.ColumnHeader()
        Me.colAdress = New System.Windows.Forms.ColumnHeader()
        Me.colPostnr = New System.Windows.Forms.ColumnHeader()
        Me.colOrt = New System.Windows.Forms.ColumnHeader()
        Me.colSkapad = New System.Windows.Forms.ColumnHeader()
        Me.SuspendLayout()
        '
        'lvwAdresser
        '
        Me.lvwAdresser.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.collID, Me.colFornamn, Me.colEfternamn, Me.colAdress, Me.colPostnr, Me.colOrt, Me.colSkapad})
        Me.lvwAdresser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvwAdresser.FullRowSelect = True
        Me.lvwAdresser.GridLines = True
        Me.lvwAdresser.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvwAdresser.HideSelection = False
        Me.lvwAdresser.Location = New System.Drawing.Point(0, 0)
        Me.lvwAdresser.MultiSelect = False
        Me.lvwAdresser.Name = "lvwAdresser"
        Me.lvwAdresser.Size = New System.Drawing.Size(698, 550)
        Me.lvwAdresser.TabIndex = 0
        Me.lvwAdresser.UseCompatibleStateImageBehavior = False
        Me.lvwAdresser.View = System.Windows.Forms.View.Details
        '
        'collID
        '
        Me.collID.Text = "Id"
        Me.collID.Width = 40
        '
        'colFornamn
        '
        Me.colFornamn.Text = "Förnamn"
        Me.colFornamn.Width = 100
        '
        'colEfternamn
        '
        Me.colEfternamn.Text = "Efternamn"
        Me.colEfternamn.Width = 100
        '
        'colAdress
        '
        Me.colAdress.Text = "Adress"
        Me.colAdress.Width = 100
        '
        'colPostnr
        '
        Me.colPostnr.DisplayIndex = 5
        Me.colPostnr.Text = "PostNR"
        Me.colPostnr.Width = 100
        '
        'colOrt
        '
        Me.colOrt.DisplayIndex = 4
        Me.colOrt.Text = "Ort"
        Me.colOrt.Width = 100
        '
        'colSkapad
        '
        Me.colSkapad.Text = "Skapad"
        Me.colSkapad.Width = 150
        '
        'frmLista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(698, 550)
        Me.Controls.Add(Me.lvwAdresser)
        Me.Name = "frmLista"
        Me.Text = "frmLista"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lvwAdresser As ListView
    Friend WithEvents collID As ColumnHeader
    Friend WithEvents colFornamn As ColumnHeader
    Friend WithEvents colEfternamn As ColumnHeader
    Friend WithEvents colAdress As ColumnHeader
    Friend WithEvents colPostnr As ColumnHeader
    Friend WithEvents colOrt As ColumnHeader
    Friend WithEvents colSkapad As ColumnHeader
End Class
