Imports MySql.Data.MySqlClient
Public Class scan_IN
    Dim cycle As Integer = 0
    Dim targetcycle As Integer = 0
    Dim targettime As Integer = 0
    Dim planid As Integer

    Private Sub scan_IN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_line.Text = PCline

    End Sub

    Private Sub cmb_line_SelectedIndexChanged(sender As Object, e As EventArgs)



    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        cycle += 1
        lbl_clock.Text = cycle.ToString("00")

        If targettime = 0 Then
            targettime = targetcycle
            updatetarget()
            lbl_output.Text = Convert.ToInt32(lbl_output.Text) + 1
        Else
            targettime -= 1

        End If

        lbl_targettime.Text = targettime.ToString("00")

    End Sub

    Private Sub updatetarget()
        Try
            ' SQL query to update the target output
            Dim query As String = "UPDATE `assy_lineplan` SET `target_output` = `target_output` + 1 WHERE id = @planid"

            con.Close()
            con.Open()

            ' Create and parameterize the SQL command
            Dim updatedata As New MySqlCommand(query, con)
            updatedata.Parameters.AddWithValue("@planid", planid)

            ' Execute the query
            updatedata.ExecuteNonQuery()

        Catch ex As Exception
            ' Log or display the error for debugging
            MessageBox.Show("An error occurred while updating the target: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Ensure the connection is always closed
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Sub

    Private Sub txt_plan_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_barcode.KeyDown

        Try


            If e.KeyCode = Keys.Enter Then

                If txt_barcode.Text.Length >= 3 AndAlso txt_barcode.Text.Substring(0, 3) = lbl_modelcode.Text Then

                    Dim query As String = "INSERT INTO `assy_barcodes`(`barcode`, `partcode`, `datein`, `timein`, `clock`, `line`,shift) VALUES ('" & txt_barcode.Text & "','" & cmb_partcode.Text & "','" & datedb & "','" & Date.Now.ToString("HH:mm:ss") & "','" & lbl_clock.Text & "','" & PCline & "','" & selected_shift & "')"
                    con.Close()
                    con.Open()
                    Dim insertdata As New MySqlCommand(query, con)
                    insertdata.ExecuteNonQuery()

                    reload("SELECT barcode,clock,timein FROM assy_barcodes  WHERE partcode='" & cmb_partcode.Text & "'  and shift='" & selected_shift & "'  and line='" & PCline & "' and datein='" & datedb & "' ORDER BY id DESC", datagrid1)
                    lbl_cycle.Text = getcycletime()
                    lbl_actual.Text = getactual()
                    cycle = 0
                Else
                    Dim warn As New warning
                    warn.ShowDialog()
                    warn.BringToFront()

                End If
                txt_barcode.Clear()
                txt_barcode.Focus()


            End If

        Catch ex As MySqlException When ex.Number = 1062
            Dim warn As New warning
            warn.display("Duplicate Barcode Detected!")
            warn.ShowDialog()
            warn.BringToFront()
        Catch ex As Exception
            ' General error handling
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub
    Private Function getcycletime() As String
        Try


            Dim query As String = "SELECT SUM(clock)/(COUNT(clock)) as total FROM assy_barcodes 
                  WHERE partcode='" & cmb_partcode.Text & "' and line='" & cmb_line.Text & "' and datein='" & datedb & "' and shift='" & selected_shift & "'"

            con.Close()
            con.Open()
            Dim selectdata As New MySqlCommand(query, con)
            dr = selectdata.ExecuteReader
            If dr.Read = True Then
                If Not IsDBNull(dr("total")) Then
                    Return dr.GetDecimal("total").ToString("F1")
                End If
            End If
            Return "0.00"



        Catch ex As Exception
            Return "0.00"

        End Try
    End Function

    Private Function getactual() As String
        Try


            Dim query As String = "SELECT COUNT(id) as total FROM assy_barcodes 
                  WHERE partcode='" & cmb_partcode.Text & "' and line='" & cmb_line.Text & "' and datein='" & datedb & "' and shift='" & selected_shift & "'"

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

    Private Sub datagrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid1.CellContentClick

    End Sub

    Private Sub txt_barcode_TextChanged(sender As Object, e As EventArgs) Handles txt_barcode.TextChanged

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)

        Timer1.Stop()

        txt_barcode.Enabled = False

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        If Timer1.Enabled Then
            ' Currently running, so stop
            Timer1.Stop()
            txt_barcode.Enabled = False
            Guna2Button2.Text = "Start"
            Guna2Button2.FillColor = Color.MidnightBlue
            Guna2Button2.Image = My.Resources.play
            Guna2GroupBox1.Focus()
        Else
            ' Currently stopped, so start
            Timer1.Start()
            txt_barcode.Enabled = True
            txt_barcode.Focus()
            Guna2Button2.Text = "Stop"
            Guna2Button2.FillColor = Color.Crimson
            Guna2Button2.Image = My.Resources.pause
        End If
    End Sub

    Private Sub cmb_partcode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_partcode.SelectedIndexChanged
        Try

            Dim query As String = "SELECT ap.id,am.partname,am.model, ap.partcode, plan,ap.cycle,am.modelcode,ap.target_output FROM assy_lineplan ap
                    JOIN assy_masterlist am ON am.partcode=ap.partcode
                    WHERE line='" & cmb_line.Text & "' and datein='" & datedb & "' and shift='" & selected_shift & "' and ap.partcode='" & cmb_partcode.Text & "'"

            con.Close()
            con.Open()
            Dim selectdata As New MySqlCommand(query, con)
            dr = selectdata.ExecuteReader
            If dr.Read = True Then
                lbl_partname.Text = dr.GetString("partname")
                lbl_model.Text = dr.GetString("model")
                lbl_plan.Text = dr.GetInt32("plan").ToString
                targetcycle = dr.GetInt32("cycle")
                lbl_modelcode.Text = dr.GetString("modelcode")
                planid = dr.GetInt32("id")
                lbl_output.Text = dr.GetInt32("target_output").ToString
                panel_scan.Enabled = True
                lbl_actual.Text = getactual()
                Timer1.Stop()
                lbl_clock.Text = "0"
                lbl_cycle.Text = "0"
                lbl_targettime.Text = "0"
                lbl_target.Text = targetcycle
            End If

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub cmb_partcode_MouseClick(sender As Object, e As MouseEventArgs) Handles cmb_partcode.MouseClick
        cmb_display("SELECT DISTINCT(partcode) FROM assy_lineplan  WHERE line='" & PCline & "' and datein='" & datedb & "' and shift='" & selected_shift & "' ", "partcode", cmb_partcode)
    End Sub

    Private Sub Guna2Panel6_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub lbl_targettime_Click(sender As Object, e As EventArgs) Handles lbl_targettime.Click

    End Sub
End Class