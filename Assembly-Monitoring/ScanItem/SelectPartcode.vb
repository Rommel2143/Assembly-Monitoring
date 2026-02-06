Imports System.Numerics
Imports DocumentFormat.OpenXml.EMMA
Imports DocumentFormat.OpenXml.Wordprocessing
Imports MySql.Data.MySqlClient

Public Class SelectPartcode
    Public Property dateSelected As Date
    Public Property shiftSelected As String

    Private Sub Guna2DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)
        getData()
    End Sub

    Public Sub getData()

        flowPartcode.Controls.Clear()

        Dim query As String =
        "SELECT partcode 
         FROM prod_plan 
         WHERE location = @location 
           AND line = @line 
           AND datein = @datein
           AND shift @shift"

        Using conn As New MySqlConnection(ConnectionString)
            Using cmd As New MySqlCommand(query, conn)

                cmd.Parameters.AddWithValue("@location", user_PClocation)
                cmd.Parameters.AddWithValue("@line", user_PCline)
                cmd.Parameters.AddWithValue("@shift", shiftSelected)
                cmd.Parameters.AddWithValue("@datein", dateSelected.ToString("yyyy-MM-dd"))
                conn.Open()

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()

                        Dim card As New PartcodeCard()
                        card.PartCode = reader("partcode").ToString()

                        flowPartcode.Controls.Add(card)

                    End While
                End Using

            End Using
        End Using

    End Sub



End Class