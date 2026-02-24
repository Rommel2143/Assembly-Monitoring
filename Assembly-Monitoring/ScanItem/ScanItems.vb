Imports System.Web.UI.WebControls
Imports Guna.UI2.WinForms
Imports MySql.Data.MySqlClient

Public Class ScanItems
    Dim SetPlan As New Plan
    Dim BoxPlan As New Box

    Private Sub btn_select_Click(sender As Object, e As EventArgs) Handles btn_select.Click

        Using setPart As New selectPlan

            setPart.dateSelected = dtpicker1.Value.ToString("yyyy-MM-dd")
            setPart.shiftSelected = If(Guna2RadioButton1.Checked, "DS", "NS")

            ' 👇 Get button screen location
            Dim btnLocation As Point = btn_select.PointToScreen(Point.Empty)

            ' 👇 Set form start position manually
            setPart.StartPosition = FormStartPosition.Manual
            setPart.Location = New Point(btnLocation.X, btnLocation.Y + btn_select.Height)

            If setPart.ShowDialog() = DialogResult.OK Then
                SetPlan = setPart.SelectedPlan
                lblPartname.Text = SetPlan.PartItem.partname
                lblPartcode.Text = SetPlan.PartItem.partcode
                lblPlan.Text = "Production Plan: " & SetPlan.plan.ToString("N0")
                lblModel.Text = SetPlan.PartItem.model & " (" & SetPlan.PartItem.modelcode & ")"

                lblSPQ.Text = "Package Qty: " & SetPlan.PartItem.spq & " pcs/Box"
                txtItemBarcode.Enabled = True
                flowScanned.Controls.Clear()
                lblExpectedCT.Text = SetPlan.cycletime.ToString("N0")
                lblExpectedOutput.Text = SetPlan.ExpectedOutput.ToString("N0")
                lbl_targettime.Text = SetPlan.cycletime.ToString("N0")
                updateactual()
                LoadItems()

            End If

        End Using

    End Sub

    Public Sub LoadItems()
        reload("SELECT barcode,clock,TIME_FORMAT(datestamp, '%H:%i:%s') AS Time FROM " & prodTable & "  WHERE planID=" & SetPlan.planID & " ORDER BY id DESC", datagrid1)

    End Sub

    Private Sub ScanItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpicker1.Value = Date.Now
        panelScan.Enabled = False
        panel_select.Enabled = True
    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtItemBarcode.TextChanged

    End Sub

    Private Sub Guna2TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtItemBarcode.KeyDown
        If e.KeyCode = Keys.Enter Then

            If txtItemBarcode.Text.Length <> 12 Then
                MessageBox.Show("Invalid Barcode!")
                Return
            End If

            If Not txtItemBarcode.Text.StartsWith(SetPlan.PartItem.modelcode) Then
                MessageBox.Show("Invalid Model Code!")
                Return
            End If


            Dim item As New Items With {
            .barcode = txtItemBarcode.Text,
            .clock = lbl_qctimer.Text,
            .datestamp = DateTime.Now
                }

            If BoxPlan.AddItem(item) Then

                Dim itemcard As New ItemsCard
                itemcard.loadData(txtItemBarcode.Text, lbl_qctimer.Text)
                flowScanned.Controls.Add(itemcard)
                BoxPlan = New Box
                lblBoxContent.Text = "Box Content: " & BoxPlan.Items.Count & "/" & SetPlan.PartItem.spq
                lbl_qctimer.Text = "0"
            Else
                Exit Sub
            End If

            If flowScanned.Controls.Count >= SetPlan.PartItem.spq Then
                txtLotQR.Enabled = True
                txtItemBarcode.Enabled = False
                txtLotQR.Clear()
                txtLotQR.Focus()
            Else
                txtItemBarcode.Clear()
                txtItemBarcode.Focus()
            End If


        End If


    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        If lblPartname.Text = "Partname" Then
            MessageBox.Show("Please select a plan first!")
            Return
        End If

        txtItemBarcode.Enabled = True
        txtLotQR.Clear()
        txtItemBarcode.Clear()
        flowScanned.Controls.Clear()
        lblBoxContent.Text = "Box Content: " & BoxPlan.Items.Count & "/" & SetPlan.PartItem.spq
        txtLotQR.Enabled = False
        txtItemBarcode.Focus()
    End Sub

    Private Sub txtLotQR_KeyDown(sender As Object, e As KeyEventArgs) Handles txtLotQR.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try


                Dim result = QRParser.ParseQR(txtLotQR.Text)

                If result.HasValue Then
                    Dim qr = result.Value

                    If qr.PartCode <> SetPlan.PartItem.partcode Then
                        MessageBox.Show("QR Code part code does not match the selected plan!")
                        txtLotQR.Clear()
                        Return
                    End If


                    BoxPlan.Qrcode = txtLotQR.Text
                    BoxPlan.Lotnumber = qr.LotNumber
                    BoxPlan.planID = SetPlan.planID
                    BoxPlan.partcode = qr.PartCode


                    If BoxPlan.SaveBox() = True Then

                        txtLotQR.Clear()
                        txtItemBarcode.Clear()
                        flowScanned.Controls.Clear()
                        txtLotQR.Enabled = False
                        txtItemBarcode.Enabled = True
                        txtItemBarcode.Focus()
                        BoxPlan = New Box
                        lblBoxContent.Text = "Box Content: " & BoxPlan.Items.Count & "/" & SetPlan.PartItem.spq
                        LoadItems()
                    Else
                        txtLotQR.Clear()
                        txtLotQR.Focus()
                    End If

                Else
                        MessageBox.Show("Invalid QR Code")
                End If
            Catch ex As Exception
                MessageBox.Show("Error processing QR Code: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        If lblPartname.Text = "Partname" Then
            MessageBox.Show("Please select a plan first!")
            Return
        End If

        If Timer1.Enabled Then
            ' Currently running, so stop
            Timer1.Stop()
            panelScan.Enabled = False
            panel_select.Enabled = True
            btnPlay.Text = "START"
            btnPlay.FillColor = Color.ForestGreen
            btnPlay.Image = My.Resources.play
            btnPlay.Focus()
        Else
            Timer1.Start()
            panelScan.Enabled = True
            panel_select.Enabled = False
            btnPlay.Text = "STOP"
            btnPlay.FillColor = Color.Crimson
            btnPlay.Image = My.Resources.pause
            txtItemBarcode.Focus()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_qctimer.Text += 1
        If lbl_targettime.Text = 0 Then
            lbl_targettime.Text = SetPlan.cycletime.ToString("N0")
            updatetarget()

        Else
            lbl_targettime.Text -= 1

        End If

    End Sub


    Private Sub updatetarget()
        Try
            ' SQL query to update the target output
            Dim query As String = "UPDATE `prod_plan` SET `target_output` = `target_output` + 1 WHERE id = @planid"

            con.Close()
            con.Open()

            ' Create and parameterize the SQL command
            Dim updatedata As New MySqlCommand(query, con)
            updatedata.Parameters.AddWithValue("@planid", SetPlan.planID)

            ' Execute the query
            updatedata.ExecuteNonQuery()
            lblExpectedOutput.Text = Convert.ToInt32(lblExpectedOutput.Text) + 1
        Catch ex As Exception
            ' Log or display the error for debugging
            MessageBox.Show("An error occurred while updating the target: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Ensure the connection is always closed
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Sub


    Sub updateactual()

        Dim query As String = "SELECT COUNT(id) AS count, SUM(clock)/(COUNT(id)) as total FROM " & prodTable & "
                  WHERE planID=" & SetPlan.planID & ""

        con.Close()
        con.Open()
        Dim selectdata As New MySqlCommand(query, con)
        dr = selectdata.ExecuteReader
        If dr.Read = True Then
            ' Handle NULL safely
            If Not IsDBNull(dr("count")) Then
                lbl_actual.Text = dr("count").ToString()
            Else
                lbl_actual.Text = "0"
            End If

            If Not IsDBNull(dr("total")) Then
                lbl_cycle.Text = Convert.ToDecimal(dr("total")).ToString("N0") & " sec."
            Else
                lbl_cycle.Text = "0 sec."
            End If
        End If


    End Sub

    Private Sub txtLotQR_TextChanged(sender As Object, e As EventArgs) Handles txtLotQR.TextChanged

    End Sub

    Private Sub flowItems_Paint(sender As Object, e As PaintEventArgs)

    End Sub
End Class