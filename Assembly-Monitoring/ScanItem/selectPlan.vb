Imports MySql.Data.MySqlClient

Public Class selectPlan
    Public Property dateSelected As Date
    Public Property shiftSelected As String
    Public Property SelectedPlan As Plan

    Public Sub getData()

        flowPartcode.Controls.Clear()

        Dim query As String =
        "SELECT pp.id FROM prod_plan pp
         WHERE pp.location = @location 
           AND pp.line = @line 
           AND pp.datein = @datein
           AND pp.shiftplan = @shift"

        Using conn As New MySqlConnection(ConnectionString)
            Using cmd As New MySqlCommand(query, conn)

                cmd.Parameters.AddWithValue("@location", user_PClocation)
                cmd.Parameters.AddWithValue("@line", user_PCline)
                cmd.Parameters.AddWithValue("@shift", shiftSelected)
                cmd.Parameters.AddWithValue("@datein", dateSelected.ToString("yyyy-MM-dd"))
                conn.Open()
                flowPartcode.Controls.Clear()

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim card = New PlanCard
                        card.loadData(reader("id"))
                        AddHandler card.PlanSelected, AddressOf OnPlanSelected
                        flowPartcode.Controls.Add(card)

                    End While
                End Using

            End Using
        End Using

    End Sub

    Private Sub SelectPartcode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getData()
    End Sub


    Private Sub OnPlanSelected(plan As Plan)
        SelectedPlan = plan
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
End Class