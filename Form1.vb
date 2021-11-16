Public Class Form1
    ' Kontakt för databaskopplingar
    Private con As New OleDb.OleDbConnection          ' Connection
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
        sql = "SELECT * from Personer"

        ' Koppla och fyll dataadaptern
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(ds, "Adressbok")

        ' Räkna antal poster
        recordCount = ds.Tables("Adressbok").Rows.Count
        postNr = 0
        fyllFormular(postNr)

    End Sub

    Private Sub fyllFormular(postNr As Integer)
        If postNr >= 0 And postNr < recordCount Then
            ' Fyll formulär
            txtFornamn.Text = ds.Tables("Adressbok").Rows(postNr)("Fornamn")
            txtEfternamn.Text = ds.Tables("Adressbok").Rows(postNr)("Efternamn")
            txtAdress.Text = ds.Tables("Adressbok").Rows(postNr)("Adress")
            txtPostnr.Text = ds.Tables("Adressbok").Rows(postNr)("Postnr")
            txtOrt.Text = ds.Tables("Adressbok").Rows(postNr)("Ort")
            lblSkapad.Text = ds.Tables("Adressbok").Rows(postNr)("Skapad")

            ' Visa aktuellt postNr ( svåra varianten ^^ )
            txtPost.Text = postNr + 1
        End If
    End Sub

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        postNr = 0
        fyllFormular(postNr)
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If postNr > 0 Then
            postNr = postNr - 1
            fyllFormular(postNr)
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If postNr < recordCount - 1 Then
            postNr = postNr + 1
            fyllFormular(postNr)
        End If
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        postNr = recordCount - 1
        fyllFormular(postNr)
    End Sub
End Class
