Imports MySql.Data.MySqlClient
Public Class liveoutput
    Dim cycle As Integer = 0
    Dim targetcycle As Integer = 0
    Dim targettime As Integer = 0
    Dim planid As Integer
    Private Sub cmb_line_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub cmb_partcode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_partcode.SelectedIndexChanged
        Try

            Dim query As String = "SELECT ap.id,am.partname,am.model, ap.partcode, plan,ap.cycle,am.modelcode,ap.target_output FROM assy_lineplan ap
                    JOIN assy_masterlist am ON am.partcode=ap.partcode
                    WHERE SUBSTRING_INDEX(`line`, '-', 1)='" & PClinetotal & "' and datein='" & datedb & "' and shift='" & selected_shift & "' and ap.partcode='" & cmb_partcode.Text & "'"

            con.Close()
            con.Open()
            Dim selectdata As New MySqlCommand(query, con)
            dr = selectdata.ExecuteReader
            If dr.Read = True Then
                lbl_partcode.Text = dr.GetString("partcode")
                lbl_model.Text = dr.GetString("model")
                lbl_plan.Text = dr.GetInt32("plan").ToString
                targetcycle = dr.GetInt32("cycle")

                planid = dr.GetInt32("id")
                lbl_output.Text = dr.GetInt32("target_output").ToString
                updateview()

                Timer1.Start()
            End If

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        updateview()
    End Sub

    Private Sub updateview()
        updatetarget()
        lbl_actual.Text = getactual()
        lbl_cycle.Text = getcycletime()

        If Convert.ToInt32(lbl_output.Text) > Convert.ToInt32(lbl_actual.Text) Then
            panel_output.FillColor = Color.Crimson
            lbl_target.ForeColor = Color.White
            lbl_output.ForeColor = Color.White
        Else
            panel_output.FillColor = Color.White
            lbl_target.ForeColor = SystemColors.ControlDarkDark
            lbl_output.ForeColor = Color.Black

        End If
        Try
            Dim plan As Integer = Convert.ToInt32(lbl_plan.Text)
            Dim actual As Integer = Convert.ToInt32(lbl_actual.Text)

            If actual = 0 Then
                lbl_percent.Text = "0%" ' Avoid division by zero
            Else
                Dim percentage As Integer = (actual / plan) * 100
                radial.Value = percentage
                lbl_percent.Text = percentage.ToString() & "%"
            End If
        Catch ex As Exception
            MessageBox.Show("Error calculating percentage: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            lbl_percent.Text = "N/A" ' Set to a default value if an error occurs
        End Try

    End Sub



    Private Function getactual() As String
        Try


            Dim query As String = "SELECT COUNT(id) as total FROM assy_barcodes 
                  WHERE partcode='" & cmb_partcode.Text & "' and SUBSTRING_INDEX(`line`, '-', 1)='" & PClinetotal & "' and datein='" & datedb & "' and shift='" & selected_shift & "'"

            con.Close()
            con.Open()
            Dim selectdata As New MySqlCommand(query, con)
            dr = selectdata.ExecuteReader
            If dr.Read = True Then
                If Not IsDBNull(dr("total")) Then
                    Return dr.GetInt32("total").ToString
                End If
            End If
            Return "0"


        Catch ex As Exception
            Return "0"
        End Try
    End Function

    Private Function getcycletime() As String
        Try


            Dim query As String = "SELECT SUM(clock)/COUNT(clock) as clockcycle FROM assy_barcodes 
                  WHERE partcode='" & cmb_partcode.Text & "' and SUBSTRING_INDEX(`line`, '-', 1)='" & PClinetotal & "' and datein='" & datedb & "' and shift='" & selected_shift & "'"

            con.Close()
            con.Open()
            Dim selectdata As New MySqlCommand(query, con)
            dr = selectdata.ExecuteReader
            If dr.Read = True Then
                If Not IsDBNull(dr("clockcycle")) Then
                    Return dr.GetDecimal("clockcycle").ToString("F1")
                End If
            End If
            Return "0"


        Catch ex As Exception
            Return "0"
        End Try
    End Function

    Private Sub updatetarget()
        Try
            ' SQL query to update the target output
            Dim query As String = "SELECT SUM(target_output) AS target_output FROM assy_lineplan  WHERE partcode='" & cmb_partcode.Text & "' and SUBSTRING_INDEX(`line`, '-', 1)='" & PClinetotal & "' and datein='" & datedb & "' and shift='" & selected_shift & "'"

            con.Close()
            con.Open()

            ' Create and parameterize the SQL command
            Dim updatedata As New MySqlCommand(query, con)
            ' Execute the query
            dr = updatedata.ExecuteReader
            If dr.Read = True Then
                lbl_output.Text = dr.GetInt32("target_output").ToString
            End If
        Catch ex As Exception
            ' Log or display the error for debugging
            MessageBox.Show("An error occurred while updating the target: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Ensure the connection is always closed
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Sub

    Private Sub monitoring_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmb_display("SELECT DISTINCT(partcode) FROM assy_lineplan  WHERE  SUBSTRING_INDEX(`line`, '-', 1)='" & PClinetotal & "' and datein='" & datedb & "' and shift='" & selected_shift & "' ", "partcode", cmb_partcode)

    End Sub

    Private Sub Guna2Panel5_Paint(sender As Object, e As PaintEventArgs) Handles panel_output.Paint

    End Sub

    Private Sub Guna2Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel4.Paint

    End Sub
End Class