Imports System.Linq
Imports DocumentFormat.OpenXml.Spreadsheet
Imports MySql.Data.MySqlClient

Public Class Box

    Public Property Qrcode As String
    Public Property Lotnumber As String
    Public Property planID As String
    Public Property partcode As String

    Public Items As List(Of Items)

    Public Sub New()
        Items = New List(Of Items)()
    End Sub


    ' ===============================
    ' ADD ITEM WITH DUPLICATE CHECK
    ' ===============================
    Public Function AddItem(newItem As Items) As Boolean

        ' 1️⃣ Check duplicate inside current box (memory)
        If Items.Any(Function(i) i.barcode = newItem.barcode) Then
            MessageBox.Show("Barcode already scanned in this box.")
            Return False
        End If


        ' 2️⃣ Check duplicate in database
        Dim query As String = "SELECT COUNT(*) FROM " & prodTable & " WHERE barcode = @barcode"

        Using conn As New MySqlConnection(ConnectionString)
            Using cmd As New MySqlCommand(query, conn)

                cmd.Parameters.AddWithValue("@barcode", newItem.barcode)

                conn.Open()

                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                If count > 0 Then
                    MessageBox.Show("Barcode already exists in database.")
                    Return False
                End If

            End Using
        End Using


        ' 3️⃣ Safe to add
        Items.Add(newItem)
        Return True

    End Function


    ' ===============================
    ' SAVE BOX WITH fgQR DUPLICATE CHECK
    ' ===============================
    Public Function SaveBox() As Boolean
        Using conn As New MySqlConnection(ConnectionString)
            conn.Open()

            ' 1️⃣ Check if fgQR already exists
            Dim checkQuery As String = "SELECT COUNT(*) FROM " & prodTable & " WHERE fgQR = @fgQR LIMIT 1"
            Using checkCmd As New MySqlCommand(checkQuery, conn)
                checkCmd.Parameters.AddWithValue("@fgQR", Qrcode)
                Dim fgQRCount As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

                If fgQRCount > 0 Then
                    MessageBox.Show("FG QR code already exists in database: " & Qrcode, "Duplicate FG QR", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return False
                End If
            End Using

            ' 2️⃣ Insert all items in a transaction
            Using transaction = conn.BeginTransaction()
                Try
                    For Each item In Items
                        Dim query As String = "
                    INSERT INTO " & prodTable & "
                    (planID, barcode, partcode, clock,pc, fgQR, lotnumber, datestamp)
                    VALUES
                    (@planID, @barcode, @partcode, @clock,@pc, @fgQR, @lotnumber, @datestamp)"

                        Using cmd As New MySqlCommand(query, conn, transaction)
                            cmd.Parameters.AddWithValue("@planID", planID)
                            cmd.Parameters.AddWithValue("@barcode", item.barcode)
                            cmd.Parameters.AddWithValue("@partcode", partcode)
                            cmd.Parameters.AddWithValue("@clock", item.clock)
                            cmd.Parameters.AddWithValue("@pc", user_PC)
                            cmd.Parameters.AddWithValue("@fgQR", Qrcode)
                            cmd.Parameters.AddWithValue("@lotnumber", Lotnumber)
                            cmd.Parameters.AddWithValue("@datestamp", item.datestamp)

                            cmd.ExecuteNonQuery()
                        End Using
                    Next

                    transaction.Commit()
                    Return True ' ✅ Success

                Catch ex As Exception
                    transaction.Rollback()
                    MessageBox.Show("Failed to save box: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False ' ❌ Failed
                End Try
            End Using
        End Using
    End Function
End Class
Public Class Items
    Public Property barcode As String
    Public Property clock As Integer
    Public Property datestamp As DateTime
End Class

