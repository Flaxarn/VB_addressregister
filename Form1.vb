﻿Public Class frmDetalj
    ' Kontakt för databaskopplingar
    Private con As New OleDb.OleDbConnection            ' Connection
    Private ds As New DataSet                           ' Tabeller
    Private da As New OleDb.OleDbDataAdapter            ' Uppdatera tabeller

    ' Globala variabler
    Dim recordCount As Integer
    Dim postNr As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Databas variabler
        Dim dbProvider As String
        Dim dbSource As String
        Dim dbName As String
        Dim dbPath As String
        Dim sql As String

        ' Kombinera sökväg och databasnamn till en connection string
        dbProvider = "PROVIDER=Microsoft.ACE.OLEDB.12.0;"
        dbName = "adresser.accdb"
        'dbPath = "C:\Users\Kim Ståhl\OneDrive\Dokument\GitHub\VB_addressregister"
        dbPath = "..\..\..\"

        dbSource = "Data Source= " & dbPath & "\" & dbName
        con.ConnectionString = dbProvider & dbSource

        ' Öppna databasen
        con.Open()

        ' Välj data att visa
        sql = "SELECT * from Personer;"

        ' Koppla och fyll dataadaptern
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(ds, "Adressbok")

        ' Räkna antal poster
        recordCount = ds.Tables("Adressbok").Rows.Count
        txtPost.MaxLength = Math.Ceiling(Math.Log10(recordCount)) ' Ändra längd på inmatning av textruta efter hur många poster som finns
        postNr = 0
        fyllFormular(postNr)

    End Sub

    Private Sub fyllFormular(postNr As Integer)

        ' Hantera felaktiga postinmatningar
        If postNr > recordCount - 1 Then
            postNr = recordCount - 1
        ElseIf postNr < 0 Then
            postNr = 0
        End If

        ' Fyll formulär
        txtFornamn.Text = ds.Tables("Adressbok").Rows(postNr)("Fornamn")
        txtEfternamn.Text = ds.Tables("Adressbok").Rows(postNr)("Efternamn")
        txtAdress.Text = ds.Tables("Adressbok").Rows(postNr)("Adress")
        txtPostnr.Text = ds.Tables("Adressbok").Rows(postNr)("Postnr")
        txtOrt.Text = ds.Tables("Adressbok").Rows(postNr)("Ort")
        lblSkapad.Text = ds.Tables("Adressbok").Rows(postNr)("Skapad")

        ' Visa aktuellt postNr ( svåra varianten ^^ )
        txtPost.Text = postNr + 1

        ' Hantera knappar
        hanteraKnappar(postNr)
    End Sub

    Private Sub hanteraKnappar(postNr As Integer)

        ' Hantera enable/disable för knappar
        btnFirst.Enabled = Not (postNr = 0)
        btnPrevious.Enabled = Not (postNr = 0)

        btnLast.Enabled = Not (postNr = (recordCount - 1))
        btnNext.Enabled = Not (postNr = (recordCount - 1))

        If postNr = -1 Then
            btnRadera.Enabled = False
        Else
            btnRadera.Enabled = True
        End If
    End Sub
    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click

        postNr = 0
        fyllFormular(postNr)
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click

        postNr = postNr - 1
        fyllFormular(postNr)
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        postNr = postNr + 1
        fyllFormular(postNr)
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click

        postNr = recordCount - 1
        fyllFormular(postNr)
    End Sub

    Private Sub txtPost_Leave(sender As Object, e As EventArgs) Handles txtPost.Leave

        Dim input As Integer
        input = Val(txtPost.Text)
        postNr = input - 1
        fyllFormular(postNr)
    End Sub

    Private Sub txtPost_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPost.KeyDown

        If e.KeyCode = Keys.Enter Then
            txtPost_Leave(sender, e)
        End If
    End Sub

    Private Sub btnSpara_Click(sender As Object, e As EventArgs) Handles btnSpara.Click
        saveData()
    End Sub

    Private Sub saveData()

        Dim cb As New OleDb.OleDbCommandBuilder(da)
        Dim dbRow As DataRow

        ' Kontroller om ny post eller befintlig
        If postNr = -1 Then
            dbRow = ds.Tables("Adressbok").NewRow
            dbRow.Item("Skapad") = Now
        Else
            dbRow = ds.Tables("Adressbok").Rows(postNr)
        End If

        ' Tilldela databasraden nya värden
        dbRow.Item("Fornamn") = txtFornamn.Text
        dbRow.Item("Efternamn") = txtEfternamn.Text
        dbRow.Item("Adress") = txtAdress.Text
        dbRow.Item("Ort") = txtOrt.Text
        dbRow.Item("Postnr") = txtPostnr.Text

        ' Uppdatera databasadaptern om ny post
        If postNr = -1 Then
            ds.Tables("Adressbok").Rows.Add(dbRow)
            postNr = ds.Tables("Adressbok").Rows.Count - 1
            recordCount = ds.Tables("Adressbok").Rows.Count
        End If

        ' Uppdatera databasraden
        da.Update(ds, "Adressbok")

        ' Visa posten
        fyllFormular(postNr)
    End Sub

    Private Sub btnNy_Click(sender As Object, e As EventArgs) Handles btnNy.Click

        ' Töm formulär
        txtFornamn.Text = ""
        txtEfternamn.Text = ""
        txtAdress.Text = ""
        txtPostnr.Text = ""
        txtOrt.Text = ""
        lblSkapad.Text = ""

        ' Indikera ny post
        postNr = -1

        ' Släck alla knappar
        hanteraKnappar(postNr)
    End Sub

    Private Sub btnRadera_Click(sender As Object, e As EventArgs) Handles btnRadera.Click

        If MsgBox("Vill du radera posten?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Adressregister!") = MsgBoxResult.Yes Then
            raderaPost()
        End If
    End Sub

    Private Sub raderaPost()

        Dim cb As New OleDb.OleDbCommandBuilder(da)

        ' Ta bort posten från datasetet och uppdatera dataadaptern
        ds.Tables("Adressbok").Rows(postNr).Delete()
        da.Update(ds, "Adressbok")

        recordCount = ds.Tables("Adressbok").Rows.Count
        If postNr >= recordCount Then
            postNr = recordCount - 1
        End If

        ' Visa följande post
        fyllFormular(postNr)

        MsgBox("Borta!")
    End Sub

    Private Sub btnVisaLista_Click(sender As Object, e As EventArgs) Handles btnVisaLista.Click
        frmLista.Show()
        Me.Hide()
    End Sub
End Class
