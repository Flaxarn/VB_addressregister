Public Class frmLista
    Private Sub frmLista_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        frmDetalj.show()
    End Sub

    Private Sub frmLista_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim itm As ListViewItem

        da.Fill(ds, SchemaType.Mapped)

        For i = 0 To ds.Tables("Adressbok").Rows.Count - 1
            itm = lvwAdresser.Items.Add(ds.Tables("Adressbok").Rows(i)("id"))
            itm.SubItems.Add(ds.Tables("Adressbok").Rows(i)("Fornamn"))
            itm.SubItems.Add(ds.Tables("Adressbok").Rows(i)("Efternamn"))
            itm.SubItems.Add(ds.Tables("Adressbok").Rows(i)("Adress"))
            itm.SubItems.Add(ds.Tables("Adressbok").Rows(i)("Postnr"))
            itm.SubItems.Add(ds.Tables("Adressbok").Rows(i)("Ort"))
            itm.SubItems.Add(ds.Tables("Adressbok").Rows(i)("Skapad"))
        Next
    End Sub
End Class