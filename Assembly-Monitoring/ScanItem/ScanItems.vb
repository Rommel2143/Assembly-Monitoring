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
            End If

        End Using

    End Sub



    Private Sub ScanItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpicker1.Value = Date.Now
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
            .clock = DateTime.Now.ToString("HH:mm:ss"),
            .datestamp = DateTime.Now
                }

            If BoxPlan.AddItem(item) Then

                Dim itemcard As New ItemsCard
                itemcard.loadData(txtItemBarcode.Text)
                flowScanned.Controls.Add(itemcard)
                lblBoxContent.Text = "Box Content: " & BoxPlan.Items.Count & "/" & SetPlan.PartItem.spq
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
        txtLotQR.Enabled = False
        txtItemBarcode.Focus()
    End Sub

    Private Sub txtLotQR_TextChanged(sender As Object, e As EventArgs) Handles txtLotQR.TextChanged

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
End Class