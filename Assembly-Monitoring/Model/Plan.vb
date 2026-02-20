Imports MySql.Data.MySqlClient

Public Class Plan
    Public Property planID As Integer
    Public Property location As String
    Public Property line As String
    Public Property plan As Integer
    Public Property duration As Double
    Public Property username As String
    Public Property plan_shift As String
    Public Property plan_partcode As String

    Public Property PartItem As Parts

    Public Sub getplan(SetPlan As Int32)

        Dim query As String =
            "SELECT id, location, line, partcode, plan, duration, `user`, shiftplan 
             FROM prod_plan 
             WHERE id=" & SetPlan & ""

        Using conn As New MySqlConnection(ConnectionString)
            Using cmd As New MySqlCommand(query, conn)
                conn.Open()

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        planID = reader("id")
                        location = reader("location").ToString()
                        line = reader("line").ToString()
                        plan = reader("plan")
                        duration = reader("duration")
                        username = reader("user").ToString()
                        plan_shift = reader("shiftplan").ToString()
                        plan_partcode = reader("partcode").ToString
                        ' Load Parts
                        PartItem = New Parts()
                        PartItem.getPartData(plan_partcode)
                    End If
                End Using


            End Using
        End Using
    End Sub


End Class
