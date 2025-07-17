Imports MySql.Data.MySqlClient

Public Class liveoutput
    Dim cycle As Integer = 0
    Dim targetcycle As Integer = 0
    Dim targettime As Integer = 0
    Dim planid As Integer

    Private Sub cmb_partcode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_partcode.SelectedIndexChanged
        Try
            Dim query As String = "SELECT ap.id, am.partname, am.model, ap.partcode, plan, ap.cycle, am.modelcode, ap.target_output 
                                   FROM assy_lineplan ap
                                   JOIN assy_masterlist am ON am.partcode = ap.partcode
                                   WHERE SUBSTRING_INDEX(`line`, '-', 1) = @line AND datein = @datein AND shift = @shift AND ap.partcode = @partcode"

            con.Close()
            con.Open()
            Dim selectdata As New MySqlCommand(query, con)
            selectdata.Parameters.AddWithValue("@line", PClinetotal)
            selectdata.Parameters.AddWithValue("@datein", datedb)
            selectdata.Parameters.AddWithValue("@shift", selected_shift)
            selectdata.Parameters.AddWithValue("@partcode", cmb_partcode.Text)

            dr = selectdata.ExecuteReader
            If dr.Read Then
                lbl_model.Text = dr.GetString("model")
                lbl_plan.Text = dr.GetInt32("plan").ToString
                radial.Maximum = dr.GetInt32("plan")
                targetcycle = dr.GetInt32("cycle")
                lbl_CTtarget.Text = targetcycle.ToString
                planid = dr.GetInt32("id")
                lbl_output.Text = dr.GetInt32("target_output").ToString

                updateview()

                Timer1.Stop()
                Timer1.Interval = 10000 ' 10 seconds update
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
        Dim actualOutput As Integer = Convert.ToInt32(getactual())
        lbl_actual.Text = actualOutput.ToString
        lbl_cycle.Text = getcycletime()

        If Convert.ToInt32(lbl_output.Text) > actualOutput Then
            panel_output.FillColor = Color.Crimson
            Label2.ForeColor = Color.White
            lbl_actual.ForeColor = Color.White
            lbl_cycle.ForeColor = Color.White
        Else
            panel_output.FillColor = Color.White
            Label2.ForeColor = SystemColors.ControlDarkDark
            lbl_actual.ForeColor = Color.Black
            lbl_cycle.ForeColor = SystemColors.ControlDarkDark
        End If

        Try
            Dim plan As Integer = Convert.ToInt32(lbl_plan.Text)
            If plan > 0 Then
                Dim percentage As Integer = (actualOutput / plan) * 100
                radial.Value = If(actualOutput > radial.Maximum, radial.Maximum, actualOutput)
                lbl_percent.Text = $"{percentage}% of {lbl_plan.Text}"
            Else
                lbl_percent.Text = "0%"
            End If
        Catch ex As Exception
            MessageBox.Show("Error calculating percentage: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            lbl_percent.Text = "N/A"
        End Try
    End Sub

    Private Function getactual() As String
        Try
            Dim query As String = "SELECT COUNT(id) AS total FROM assy_barcodes 
                                   WHERE partcode = @partcode AND SUBSTRING_INDEX(`line`, '-', 1) = @line AND datein = @datein AND shift = @shift"

            con.Close()
            con.Open()
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@partcode", cmb_partcode.Text)
            cmd.Parameters.AddWithValue("@line", PClinetotal)
            cmd.Parameters.AddWithValue("@datein", datedb)
            cmd.Parameters.AddWithValue("@shift", selected_shift)

            dr = cmd.ExecuteReader
            If dr.Read AndAlso Not IsDBNull(dr("total")) Then
                Return dr.GetInt32("total").ToString
            End If
            Return "0"
        Catch ex As Exception
            Return "0"
        End Try
    End Function

    Private Function getcycletime() As String
        Try
            Dim query As String = "SELECT IFNULL(SUM(clock) / COUNT(clock), 0) AS clockcycle FROM assy_barcodes 
                                   WHERE partcode = @partcode AND SUBSTRING_INDEX(`line`, '-', 1) = @line AND datein = @datein AND shift = @shift"

            con.Close()
            con.Open()
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@partcode", cmb_partcode.Text)
            cmd.Parameters.AddWithValue("@line", PClinetotal)
            cmd.Parameters.AddWithValue("@datein", datedb)
            cmd.Parameters.AddWithValue("@shift", selected_shift)

            dr = cmd.ExecuteReader
            If dr.Read AndAlso Not IsDBNull(dr("clockcycle")) Then
                Return Convert.ToDecimal(dr("clockcycle")).ToString("F1")
            End If
            Return "0.0"
        Catch ex As Exception
            Return "0.0"
        End Try
    End Function

    Private Sub updatetarget()
        Try
            Dim query As String = "SELECT SUM(target_output) AS target_output FROM assy_lineplan 
                                   WHERE partcode = @partcode AND SUBSTRING_INDEX(`line`, '-', 1) = @line AND datein = @datein AND shift = @shift"

            con.Close()
            con.Open()
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@partcode", cmb_partcode.Text)
            cmd.Parameters.AddWithValue("@line", PClinetotal)
            cmd.Parameters.AddWithValue("@datein", datedb)
            cmd.Parameters.AddWithValue("@shift", selected_shift)

            dr = cmd.ExecuteReader
            If dr.Read AndAlso Not IsDBNull(dr("target_output")) Then
                lbl_output.Text = dr.GetInt32("target_output").ToString
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred while updating the target: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Sub

    Private Sub monitoring_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_display("SELECT DISTINCT(partcode) FROM assy_lineplan WHERE SUBSTRING_INDEX(`line`, '-', 1) = '" & PClinetotal & "' AND datein = '" & datedb & "' AND shift = '" & selected_shift & "'", "partcode", cmb_partcode)

        If cmb_partcode.Items.Count > 0 Then
            cmb_partcode.SelectedIndex = 0
        End If
    End Sub

    ' Optional: You can customize these Paint events or remove them
    Private Sub Guna2Panel5_Paint(sender As Object, e As PaintEventArgs) Handles panel_output.Paint
    End Sub

    Private Sub Guna2Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel4.Paint
    End Sub
End Class
