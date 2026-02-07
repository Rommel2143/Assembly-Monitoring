Imports MySql.Data.MySqlClient

Public Class Parts
    Public Property partID As Integer
    Public Property partcode As String
    Public Property partname As String
    Public Property model As String
    Public Property modelcode As String
    Public Property spq As Integer
    Public Property location As String

    Public Sub getPartData(partcodeVal As String)

        Dim query As String =
            "SELECT id, partcode, partname, model, modelcode, qty, location
             FROM assy_masterlist
             WHERE partcode = @partcode"

        Using conn As New MySqlConnection(ConnectionString)
            Using cmd As New MySqlCommand(query, conn)

                cmd.Parameters.AddWithValue("@partcode", partcodeVal)

                conn.Open()

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        partID = reader("id")
                        partcode = reader("partcode").ToString()
                        partname = reader("partname").ToString()
                        model = reader("model").ToString()
                        modelcode = reader("modelcode").ToString()
                        spq = Convert.ToInt32(reader("qty"))
                        location = reader("location").ToString()
                    End If
                End Using

            End Using
        End Using
    End Sub
End Class
