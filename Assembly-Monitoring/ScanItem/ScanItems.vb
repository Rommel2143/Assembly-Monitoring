Imports Guna.UI2.WinForms
Imports MySql.Data.MySqlClient

Public Class ScanItems

    Private SetPlan As New Plan
    Private BoxPlan As New Box


    '========================================================
    ' SELECT PRODUCTION PLAN
    '========================================================
    Private Sub btn_select_Click(
        sender As Object,
        e As EventArgs
    ) Handles btn_select.Click

        Using setPart As New selectPlan

            setPart.dateSelected = dtpicker1.Value.ToString("yyyy-MM-dd")
            setPart.shiftSelected = If(Guna2RadioButton1.Checked, "DS", "NS")

            Dim btnLocation As Point =
                btn_select.PointToScreen(Point.Empty)

            setPart.StartPosition = FormStartPosition.Manual

            setPart.Location =
                New Point(
                    btnLocation.X,
                    btnLocation.Y + btn_select.Height
                )

            If setPart.ShowDialog() = DialogResult.OK Then

                SetPlan = setPart.SelectedPlan

                lblPartname.Text = SetPlan.PartItem.partname
                lblPartcode.Text = SetPlan.PartItem.partcode

                lblPlan.Text =
                    "Production Plan: " &
                    SetPlan.plan.ToString("N0")

                lblModel.Text = "Model: " & SetPlan.PartItem.model

                lblModel1.Text =
                    If(
                        String.IsNullOrWhiteSpace(SetPlan.PartItem.modelcode),
                        "-",
                       "Model Code 1: " & SetPlan.PartItem.modelcode
                    )

                lblModel2.Text =
                    If(
                        String.IsNullOrWhiteSpace(SetPlan.PartItem.modelcode2),
                        "Model Code 2: -",
                       "Model Code 2: " & SetPlan.PartItem.modelcode2
                    )

                lblSPQ.Text =
                    "Package Qty: " &
                    SetPlan.PartItem.spq &
                    " pcs/Box"

                txtItemBarcode.Enabled = True

                flowScanned.Controls.Clear()

                lblExpectedCT.Text =
                    SetPlan.cycletime.ToString("N0")

                lblExpectedOutput.Text =
                    SetPlan.ExpectedOutput.ToString("N0")

                lbl_targettime.Text =
                    SetPlan.cycletime.ToString("N0")

                lbl_qctimer.Text = "0"
                txtItemBarcode2.Enabled = If(String.IsNullOrWhiteSpace(SetPlan.PartItem.modelcode2), False, True)
                updateactual()

                Using viewValidation As New DataValidations(SetPlan, BoxPlan)
                    viewValidation.ShowDialog()
                End Using

            End If

        End Using

    End Sub


    '========================================================
    ' LOAD SCANNED ITEMS
    '========================================================
    Public Sub LoadItems()

        reload(
            "SELECT barcode,
                    clock,
                    TIME_FORMAT(datestamp, '%H:%i:%s') AS Time
             FROM " & prodTable & "
             WHERE planID = " & SetPlan.planID & "
             ORDER BY id DESC",
            datagrid1
        )

    End Sub


    '========================================================
    ' FORM LOAD
    '========================================================
    Private Sub ScanItems_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        dtpicker1.Value = Date.Now

        panelScan.Enabled = False
        panel_select.Enabled = True

        Guna2GroupBox1.Text =
            user_PClocation &
            " - LINE " &
            user_PCline

    End Sub

    '========================================================
    ' ITEM BARCODE 1 SCAN
    '========================================================
    Private Sub txtItemBarcode_KeyDown(
    sender As Object,
    e As KeyEventArgs
) Handles txtItemBarcode.KeyDown

        If e.KeyCode <> Keys.Enter Then Return

        e.SuppressKeyPress = True
        e.Handled = True

        ' Second barcode is not required
        If Not txtItemBarcode2.Enabled Then

            SaveBarcode()

        Else

            ' Second barcode is required for this item
            txtItemBarcode2.Clear()
            txtItemBarcode2.Focus()

        End If

    End Sub


    '========================================================
    ' ITEM BARCODE 2 SCAN
    '========================================================
    Private Sub txtItemBarcode2_KeyDown(
    sender As Object,
    e As KeyEventArgs
) Handles txtItemBarcode2.KeyDown

        If e.KeyCode <> Keys.Enter Then Return

        e.SuppressKeyPress = True
        e.Handled = True

        SaveBarcode()

    End Sub


    '========================================================
    ' SAVE BARCODE
    '========================================================
    Private Sub SaveBarcode()

        '----------------------------------------------------
        ' CHECK SELECTED PLAN
        '----------------------------------------------------
        If SetPlan Is Nothing OrElse
       SetPlan.PartItem Is Nothing OrElse
       SetPlan.planID <= 0 Then

            MessageBox.Show(
            "Please select a production plan first!",
            "No Plan Selected",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning
        )

            ResetBarcodeInput()
            Return
        End If


        '----------------------------------------------------
        ' GET BARCODE 1
        '----------------------------------------------------
        Dim barcode As String =
        txtItemBarcode.Text.Trim()


        '----------------------------------------------------
        ' GET BARCODE 2
        '----------------------------------------------------
        Dim barcode2 As String = Nothing

        If txtItemBarcode2.Enabled Then

            Dim scannedBarcode2 As String =
            txtItemBarcode2.Text.Trim()

            If Not String.IsNullOrWhiteSpace(scannedBarcode2) Then
                barcode2 = scannedBarcode2
            End If

        End If


        '====================================================
        ' VALIDATE BARCODE 1
        '====================================================
        If barcode.Length <> 12 Then

            ShowBarcodeError(
            "Invalid Barcode 1!" &
            Environment.NewLine &
            "Barcode: " & barcode
        )

            ResetBarcodeInput()
            Return

        End If


        '====================================================
        ' VALIDATE BARCODE 2
        '====================================================
        If txtItemBarcode2.Enabled Then

            '------------------------------------------------
            ' BARCODE 2 REQUIRED
            '------------------------------------------------
            If String.IsNullOrWhiteSpace(barcode2) Then

                ShowBarcodeError(
                "Please scan Barcode 2."
            )

                txtItemBarcode2.Focus()
                Return

            End If


            '------------------------------------------------
            ' BARCODE 2 LENGTH
            '------------------------------------------------
            If barcode2.Length <> 12 Then

                ShowBarcodeError(
                "Invalid Barcode 2!" &
                Environment.NewLine &
                "Barcode: " & barcode2
            )

                txtItemBarcode2.Clear()
                txtItemBarcode2.Focus()
                Return

            End If


            '------------------------------------------------
            ' BARCODE 1 AND BARCODE 2 CANNOT BE THE SAME
            '------------------------------------------------
            If String.Equals(
            barcode,
            barcode2,
            StringComparison.OrdinalIgnoreCase
        ) Then

                ShowBarcodeError(
                "Barcode 1 and Barcode 2 cannot be the same!" &
                Environment.NewLine &
                "Barcode: " & barcode
            )

                txtItemBarcode2.Clear()
                txtItemBarcode2.Focus()
                Return

            End If

        End If


        '====================================================
        ' GET MODEL CODES
        '====================================================
        Dim modelCode1 As String =
        If(SetPlan.PartItem.modelcode, String.Empty).Trim()

        Dim modelCode2 As String =
        If(SetPlan.PartItem.modelcode2, String.Empty).Trim()


        '====================================================
        ' VALIDATE BARCODE 1 MODEL CODE
        '====================================================
        Dim barcode1IsModel1 As Boolean =
        StartsWithModelCode(
            barcode,
            modelCode1
        )

        Dim barcode1IsModel2 As Boolean =
        StartsWithModelCode(
            barcode,
            modelCode2
        )


        '----------------------------------------------------
        ' BARCODE 1 MUST MATCH A VALID MODEL CODE
        '----------------------------------------------------
        If Not barcode1IsModel1 AndAlso
       Not barcode1IsModel2 Then

            ShowBarcodeError(
            "Invalid Model Code for Barcode 1!" &
            Environment.NewLine &
            "Barcode: " & barcode &
            Environment.NewLine &
            "Expected: " &
            GetAllowedModelCodes(
                modelCode1,
                modelCode2
            )
        )

            ResetBarcodeInput()
            Return

        End If


        '====================================================
        ' VALIDATE BARCODE 2 MODEL CODE
        '====================================================
        If barcode2 IsNot Nothing Then

            Dim barcode2IsModel1 As Boolean =
            StartsWithModelCode(
                barcode2,
                modelCode1
            )

            Dim barcode2IsModel2 As Boolean =
            StartsWithModelCode(
                barcode2,
                modelCode2
            )


            '------------------------------------------------
            ' BARCODE 2 MUST MATCH A VALID MODEL CODE
            '------------------------------------------------
            If Not barcode2IsModel1 AndAlso
           Not barcode2IsModel2 Then

                ShowBarcodeError(
                "Invalid Model Code for Barcode 2!" &
                Environment.NewLine &
                "Barcode: " & barcode2 &
                Environment.NewLine &
                "Expected: " &
                GetAllowedModelCodes(
                    modelCode1,
                    modelCode2
                )
            )

                txtItemBarcode2.Clear()
                txtItemBarcode2.Focus()
                Return

            End If


            '================================================
            ' SAME MODEL CODE CANNOT BE USED TWICE
            '================================================

            '------------------------------------------------
            ' BOTH USE MODEL CODE 1
            '------------------------------------------------
            If barcode1IsModel1 AndAlso
           barcode2IsModel1 Then

                ShowBarcodeError(
                "Invalid Barcode Combination!" &
                Environment.NewLine &
                "Both barcodes use Model Code: " &
                modelCode1 &
                Environment.NewLine &
                "Barcode 1 and Barcode 2 must use different model codes."
            )

                txtItemBarcode2.Clear()
                txtItemBarcode2.Focus()
                Return

            End If


            '------------------------------------------------
            ' BOTH USE MODEL CODE 2
            '------------------------------------------------
            If barcode1IsModel2 AndAlso
           barcode2IsModel2 Then

                ShowBarcodeError(
                "Invalid Barcode Combination!" &
                Environment.NewLine &
                "Both barcodes use Model Code: " &
                modelCode2 &
                Environment.NewLine &
                "Barcode 1 and Barcode 2 must use different model codes."
            )

                txtItemBarcode2.Clear()
                txtItemBarcode2.Focus()
                Return

            End If

        End If


        '====================================================
        ' CREATE ITEM
        '====================================================
        Dim item As New Items With {
        .barcode = barcode, .barcode2 = barcode2,
        .clock = lbl_qctimer.Text,
        .datestamp = DateTime.Now
    }


        ' If your Items class has barcode2:
        '
        ' item.barcode2 = barcode2


        '====================================================
        ' ADD ITEM TO BOX
        '====================================================
        If Not BoxPlan.AddItem(item) Then

            ResetBarcodeInput()
            Return

        End If


        '====================================================
        ' DISPLAY SCANNED ITEM
        '====================================================
        Dim itemcard As New ItemsCard

        itemcard.loadData(
        barcode,
        barcode2,
        lbl_qctimer.Text
    )

        flowScanned.Controls.Add(itemcard)


        '====================================================
        ' UPDATE BOX CONTENT
        '====================================================
        lblBoxContent.Text =
        $"Box Content: {BoxPlan.Items.Count}/{SetPlan.PartItem.spq}"

        lbl_qctimer.Text = "0"


        '====================================================
        ' CHECK BOX QUANTITY
        '====================================================
        If BoxPlan.Items.Count >= SetPlan.PartItem.spq Then

            txtItemBarcode.Clear()
            txtItemBarcode2.Clear()

            txtItemBarcode.Enabled = False
            txtItemBarcode2.Enabled = False

            txtLotQR.Enabled = True
            txtLotQR.Clear()
            txtLotQR.Focus()

        Else

            ResetBarcodeInput()

        End If

    End Sub


    '========================================================
    ' CHECK BARCODE MODEL CODE
    '========================================================
    Private Function StartsWithModelCode(
    barcode As String,
    modelCode As String
) As Boolean

        If String.IsNullOrWhiteSpace(barcode) OrElse
       String.IsNullOrWhiteSpace(modelCode) Then

            Return False
        End If

        Return barcode.StartsWith(
        modelCode,
        StringComparison.OrdinalIgnoreCase
    )

    End Function


    '========================================================
    ' GET ALLOWED MODEL CODES
    '========================================================
    Private Function GetAllowedModelCodes(
    modelCode1 As String,
    modelCode2 As String
) As String

        Dim codes As New List(Of String)

        If Not String.IsNullOrWhiteSpace(modelCode1) Then
            codes.Add(modelCode1)
        End If

        If Not String.IsNullOrWhiteSpace(modelCode2) Then
            codes.Add(modelCode2)
        End If

        If codes.Count = 0 Then
            Return "No model code configured"
        End If

        Return String.Join(" / ", codes)

    End Function


    '========================================================
    ' SHOW BARCODE ERROR
    '========================================================
    Private Sub ShowBarcodeError(
    message As String
)

        Using prompt As New PasswordPrompt

            prompt.ErrorText = message
            prompt.ShowDialog()

        End Using

    End Sub


    '========================================================
    ' RESET BARCODE INPUT
    '========================================================
    Private Sub ResetBarcodeInput()

        txtItemBarcode.Clear()
        txtItemBarcode2.Clear()

        txtItemBarcode.Focus()

    End Sub


    '========================================================
    ' RESET BOX
    '========================================================
    Private Sub Guna2Button1_Click(
        sender As Object,
        e As EventArgs
    ) Handles Guna2Button1.Click

        If SetPlan Is Nothing OrElse
           SetPlan.planID = 0 Then

            MessageBox.Show(
                "Please select a plan first!"
            )

            Return

        End If


        Using PasswordPrompt As New PasswordPrompt

            PasswordPrompt.ErrorText =
                "Box reset for Plan ID: " &
                SetPlan.planID

            If PasswordPrompt.ShowDialog() = DialogResult.OK Then

                txtLotQR.Clear()
                txtItemBarcode.Clear()

                flowScanned.Controls.Clear()

                txtLotQR.Enabled = False
                txtItemBarcode.Enabled = True

                BoxPlan = New Box

                lblBoxContent.Text =
                    "Box Content: " &
                    BoxPlan.Items.Count &
                    "/" &
                    SetPlan.PartItem.spq

                lbl_qctimer.Text = "0"

                updateactual()

                txtItemBarcode.Focus()

            End If

        End Using

    End Sub


    '========================================================
    ' LOT QR SCAN
    '========================================================
    Private Sub txtLotQR_KeyDown(
        sender As Object,
        e As KeyEventArgs
    ) Handles txtLotQR.KeyDown

        If e.KeyCode <> Keys.Enter Then Return

        e.SuppressKeyPress = True

        Try

            Dim qrText As String =
                txtLotQR.Text.Trim()

            Dim result =
                QRParser.ParseQR(qrText)


            If Not result.HasValue Then

                MessageBox.Show(
                    "Invalid QR Code",
                    "Invalid QR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                )

                txtLotQR.Clear()
                txtLotQR.Focus()

                Return

            End If


            Dim qr = result.Value


            '------------------------------------------------
            ' VALIDATE PART CODE
            '------------------------------------------------
            If Not qr.PartCode.Equals(
                SetPlan.PartItem.partcode,
                StringComparison.OrdinalIgnoreCase
            ) Then

                Using PasswordPrompt As New PasswordPrompt

                    PasswordPrompt.ErrorText =
                        "QR Code part code does not match the selected plan! | " &
                        qrText

                    PasswordPrompt.ShowDialog()

                End Using

                txtLotQR.Clear()
                txtLotQR.Focus()

                Return

            End If


            '------------------------------------------------
            ' VALIDATE REMARKS
            '------------------------------------------------
            Dim remarksValid As Boolean = False

            If SetPlan.PartItem.RemarksList IsNot Nothing Then

                remarksValid =
                    SetPlan.PartItem.RemarksList.Any(
                        Function(x)
                            Return x.Equals(
                                qr.Remarks,
                                StringComparison.OrdinalIgnoreCase
                            )
                        End Function
                    )

            End If


            If Not remarksValid Then

                Using PasswordPrompt As New PasswordPrompt

                    PasswordPrompt.ErrorText =
                        "Remarks not found in selected plan! | " &
                        qrText

                    PasswordPrompt.ShowDialog()

                End Using

                txtLotQR.Clear()
                txtLotQR.Focus()

                Return

            End If


            '------------------------------------------------
            ' VALIDATE SPQ
            '------------------------------------------------
            If qr.Qty <> SetPlan.PartItem.spq Then

                Using PasswordPrompt As New PasswordPrompt

                    PasswordPrompt.ErrorText =
                        "QR code SPQ does not match the selected plan! | " &
                        qrText

                    PasswordPrompt.ShowDialog()

                End Using

                txtLotQR.Clear()
                txtLotQR.Focus()

                Return

            End If


            '------------------------------------------------
            ' SET BOX INFORMATION
            '------------------------------------------------
            BoxPlan.Qrcode = qrText
            BoxPlan.Lotnumber = qr.LotNumber
            BoxPlan.planID = SetPlan.planID
            BoxPlan.partcode = qr.PartCode


            '------------------------------------------------
            ' SAVE BOX
            '------------------------------------------------
            Try

                If BoxPlan.SaveBox() Then

                    txtLotQR.Clear()
                    txtItemBarcode.Clear()

                    flowScanned.Controls.Clear()

                    txtLotQR.Enabled = False
                    txtItemBarcode.Enabled = True
                    txtItemBarcode2.Enabled = If(String.IsNullOrWhiteSpace(SetPlan.PartItem.modelcode2), False, True)
                    BoxPlan = New Box

                    lblBoxContent.Text =
                        "Box Content: " &
                        BoxPlan.Items.Count &
                        "/" &
                        SetPlan.PartItem.spq

                    lbl_qctimer.Text = "0"

                    updateactual()

                    txtItemBarcode.Focus()

                Else

                    txtLotQR.Clear()
                    txtLotQR.Focus()

                End If

            Catch ex As Exception

                Using PasswordPrompt As New PasswordPrompt

                    PasswordPrompt.ErrorText =
                        "Failure on QR: " &
                        qrText &
                        " Error: " &
                        ex.Message

                    PasswordPrompt.ShowDialog()

                End Using

                txtLotQR.Clear()
                txtLotQR.Focus()

            End Try


        Catch ex As Exception

            MessageBox.Show(
                "Error processing QR Code: " &
                ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

            txtLotQR.Clear()
            txtLotQR.Focus()

        End Try

    End Sub


    '========================================================
    ' START / STOP PRODUCTION
    '========================================================
    Private Sub Guna2Button2_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnPlay.Click

        If SetPlan Is Nothing OrElse
           SetPlan.planID = 0 Then

            MessageBox.Show(
                "Please select a plan first!"
            )

            Return

        End If


        If Timer1.Enabled Then

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


    '========================================================
    ' CYCLE TIMER
    '========================================================
    Private Sub Timer1_Tick(
        sender As Object,
        e As EventArgs
    ) Handles Timer1.Tick

        Dim qcTimer As Integer

        If Integer.TryParse(
            lbl_qctimer.Text,
            qcTimer
        ) Then

            qcTimer += 1

        Else

            qcTimer = 1

        End If

        lbl_qctimer.Text =
            qcTimer.ToString()


        Dim targetTime As Integer

        If Not Integer.TryParse(
            lbl_targettime.Text,
            targetTime
        ) Then

            targetTime = 0

        End If


        If targetTime <= 0 Then

            targetTime =
                Convert.ToInt32(
                    Math.Round(SetPlan.cycletime)
                )

            lbl_targettime.Text =
                targetTime.ToString()

            updatetarget()

        Else

            targetTime -= 1

            lbl_targettime.Text =
                targetTime.ToString()

        End If

    End Sub


    '========================================================
    ' UPDATE TARGET OUTPUT
    '========================================================
    Private Sub updatetarget()

        Try

            Dim query As String =
                "UPDATE prod_plan
                 SET target_output = target_output + 1
                 WHERE id = @planid"

            Using conn As New MySqlConnection(ConnectionString)

                Using cmd As New MySqlCommand(query, conn)

                    cmd.Parameters.Add(
                        "@planid",
                        MySqlDbType.Int32
                    ).Value = SetPlan.planID

                    conn.Open()

                    cmd.ExecuteNonQuery()

                End Using

            End Using


            Dim currentOutput As Integer

            If Integer.TryParse(
                lblExpectedOutput.Text.Replace(",", ""),
                currentOutput
            ) Then

                lblExpectedOutput.Text =
                    (currentOutput + 1).ToString("N0")

            End If


        Catch ex As Exception

            MessageBox.Show(
                "An error occurred while updating the target: " &
                ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub


    '========================================================
    ' UPDATE ACTUAL OUTPUT / ACTUAL CYCLE TIME
    '========================================================
    Private Sub updateactual()

        LoadItems()

        Try

            Dim query As String =
                "SELECT
                    COUNT(id) AS total_count,
                    AVG(clock) AS average_cycle
                 FROM " & prodTable & "
                 WHERE planID = @planid"


            Using conn As New MySqlConnection(ConnectionString)

                Using cmd As New MySqlCommand(query, conn)

                    cmd.Parameters.Add(
                        "@planid",
                        MySqlDbType.Int32
                    ).Value = SetPlan.planID

                    conn.Open()


                    Using reader As MySqlDataReader =
                        cmd.ExecuteReader()

                        If reader.Read() Then

                            '--------------------------------
                            ' ACTUAL OUTPUT
                            '--------------------------------
                            If Not reader.IsDBNull(
                                reader.GetOrdinal("total_count")
                            ) Then

                                lbl_actual.Text =
                                    Convert.ToInt32(
                                        reader("total_count")
                                    ).ToString("N0")

                            Else

                                lbl_actual.Text = "0"

                            End If


                            '--------------------------------
                            ' ACTUAL CYCLE TIME
                            '--------------------------------
                            If Not reader.IsDBNull(
                                reader.GetOrdinal("average_cycle")
                            ) Then

                                lbl_cycle.Text =
                                    Convert.ToDecimal(
                                        reader("average_cycle")
                                    ).ToString("N0") &
                                    " sec."

                            Else

                                lbl_cycle.Text =
                                    "0 sec."

                            End If

                        End If

                    End Using

                End Using

            End Using


        Catch ex As Exception

            MessageBox.Show(
                "Unable to update actual production data: " &
                ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub


    '========================================================
    ' OPEN DATA VALIDATION
    '========================================================
    Private Sub Guna2Button2_Click_1(
        sender As Object,
        e As EventArgs
    ) Handles Guna2Button2.Click

        If SetPlan Is Nothing OrElse
           SetPlan.planID = 0 Then

            MessageBox.Show(
                "Please select a plan first!"
            )

            Return

        End If


        Using viewValidation As New DataValidations(
            SetPlan,
            BoxPlan
        )

            viewValidation.ShowDialog()

        End Using

    End Sub

    Private Sub txtItemBarcode_TextChanged(sender As Object, e As EventArgs) Handles txtItemBarcode.TextChanged

    End Sub

    Private Sub txtItemBarcode2_TextChanged(sender As Object, e As EventArgs) Handles txtItemBarcode2.TextChanged

    End Sub

    Private Sub txtLotQR_TextChanged(sender As Object, e As EventArgs) Handles txtLotQR.TextChanged

    End Sub
End Class