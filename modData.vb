Module modData
    ' Kontakt för databaskopplingar
    Public con As New OleDb.OleDbConnection            ' Connection
    Public ds As New DataSet                           ' Tabeller
    Public da As New OleDb.OleDbDataAdapter            ' Uppdatera tabeller

    Public Sub dbConnect()

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
    End Sub
End Module
