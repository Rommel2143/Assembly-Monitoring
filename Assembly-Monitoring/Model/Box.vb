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
        Dim query As String = $"SELECT COUNT(*) FROM {prodTable} WHERE barcode = @barcode"

        Using conn As New MySqlConnection(ConnectionString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.Add("@barcode", MySqlDbType.VarChar).Value = newItem.barcode

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
    ' SAVE BOX WITH FG QR DUPLICATE CHECK
    ' ===============================
    Public Function SaveBox() As Boolean
        Using conn As New MySqlConnection(ConnectionString)
            conn.Open()

            ' 1️⃣ Check if FG QR already exists
            Dim checkQuery As String = $"SELECT COUNT(*) FROM {prodTable} WHERE fgQR = @fgQR"
            Using checkCmd As New MySqlCommand(checkQuery, conn)
                checkCmd.Parameters.Add("@fgQR", MySqlDbType.VarChar).Value = Qrcode
                Dim fgQRCount As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

                If fgQRCount > 0 Then
                    Throw New Exception("FG QR code already exists in database")
                    Return False
                End If
            End Using

            ' 2️⃣ Insert all items in a transaction
            Using transaction = conn.BeginTransaction()
                Try
                    For Each item In Items
                        Dim insertQuery As String = $"
                        INSERT INTO {prodTable} 
                        (planID, barcode, partcode, clock, pc, fgQR, lotnumber, datestamp)
                        VALUES
                        (@planID, @barcode, @partcode, @clock, @pc, @fgQR, @lotnumber, @datestamp)"

                        Using cmd As New MySqlCommand(insertQuery, conn, transaction)
                            cmd.Parameters.Add("@planID", MySqlDbType.VarChar).Value = planID
                            cmd.Parameters.Add("@barcode", MySqlDbType.VarChar).Value = item.barcode
                            cmd.Parameters.Add("@partcode", MySqlDbType.VarChar).Value = partcode
                            cmd.Parameters.Add("@clock", MySqlDbType.Int32).Value = item.clock
                            cmd.Parameters.Add("@pc", MySqlDbType.VarChar).Value = user_PC
                            cmd.Parameters.Add("@fgQR", MySqlDbType.VarChar).Value = Qrcode
                            cmd.Parameters.Add("@lotnumber", MySqlDbType.VarChar).Value = Lotnumber
                            cmd.Parameters.Add("@datestamp", MySqlDbType.DateTime).Value = item.datestamp

                            cmd.ExecuteNonQuery()
                        End Using
                    Next

                    transaction.Commit()
                    Return True ' ✅ Success

                Catch ex As Exception
                    transaction.Rollback()
                    Throw New Exception("Failed to save box: " & ex.Message)
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