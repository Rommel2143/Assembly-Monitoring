Imports MySql.Data.MySqlClient

Public Class search_barcode
    Private Sub search_barcode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2DateTimePicker1.Value = Date.Now
        dtHourly.Value = Date.Now
        LoadHourlyReport(cmbShift.Text, dtHourly.Value)
    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox1.TextChanged
        If Guna2TextBox1.Text = "" Then
            datagrid1.DataSource = Nothing
        End If
    End Sub

    Private Sub Guna2TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles Guna2TextBox1.KeyDown

        If e.KeyCode = Keys.Enter Then

            reload("SELECT ps.`id`, ps.`barcode`, ps.`partcode`, ps.`fgQR`, ps.`datestamp`, " &
        "pp.location, pp.line,
                    CASE 
                WHEN pp.shift = 1 THEN 'DS'
                WHEN pp.shift = 0 THEN 'NS'
                ELSE 'Unknown'
            END AS shift 
        FROM `" & prodTable & "` ps " &
        "JOIN `prod_plan` pp ON pp.id = ps.planID 
                   WHERE barcode REGEXP '" & Guna2TextBox1.Text & "' OR fgQR REGEXP '" & Guna2TextBox1.Text & "'", datagrid1)

        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        exportExcel(datagrid1, "Barcode Records")
    End Sub

    Private Sub Guna2DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles Guna2DateTimePicker1.ValueChanged
        Dim selectedDate As Date = Guna2DateTimePicker1.Value.Date

        Dim query As String =
        "SELECT ps.`id`, ps.`barcode`, ps.`partcode`, ps.`fgQR`, ps.`datestamp`, " &
        "pp.location, pp.line, 
         CASE 
    WHEN pp.shift = 1 THEN 'DS'
    WHEN pp.shift = 0 THEN 'NS'
    ELSE 'Unknown'
END AS shift " &
        "FROM `" & prodTable & "` ps " &
        "JOIN `prod_plan` pp ON pp.id = ps.planID " &
        "WHERE DATE(ps.`datestamp`) = '" & Guna2DateTimePicker1.Value.ToString("yyyy-MM-dd") & "' ORDER BY pp.line ASC"

        reload(query, datagrid2)

    End Sub


    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        exportExcel(datagrid1, "Barcode Records", Guna2DateTimePicker1.Value.ToString("MMMM dd yyyy"))
    End Sub
    Private Sub LoadHourlyReport(ShiftSchedule As String, datepick As Date)

        Dim query As String = ""

        Select Case ShiftSchedule.ToUpperInvariant()

            Case "DAYSHIFT"

                query =
"SELECT
    CONCAT(prod_plan.location, '-LINE ', prod_plan.line) AS LocationLine,
    p.partcode,
    am.partname,
    am.model,

    SUM(CASE WHEN HOUR(p.datestamp) = 7 THEN 1 ELSE 0 END) AS `7:00`,
    SUM(CASE WHEN HOUR(p.datestamp) = 8 THEN 1 ELSE 0 END) AS `8:00`,
    SUM(CASE WHEN HOUR(p.datestamp) = 9 THEN 1 ELSE 0 END) AS `9:00`,
    SUM(CASE WHEN HOUR(p.datestamp) = 10 THEN 1 ELSE 0 END) AS `10:00`,
    SUM(CASE WHEN HOUR(p.datestamp) = 11 THEN 1 ELSE 0 END) AS `11:00`,
    SUM(CASE WHEN HOUR(p.datestamp) = 12 THEN 1 ELSE 0 END) AS `12:00`,
    SUM(CASE WHEN HOUR(p.datestamp) = 13 THEN 1 ELSE 0 END) AS `13:00`,
    SUM(CASE WHEN HOUR(p.datestamp) = 14 THEN 1 ELSE 0 END) AS `14:00`,
    SUM(CASE WHEN HOUR(p.datestamp) = 15 THEN 1 ELSE 0 END) AS `15:00`,
    SUM(CASE WHEN HOUR(p.datestamp) = 16 THEN 1 ELSE 0 END) AS `16:00`,
    SUM(CASE WHEN HOUR(p.datestamp) = 17 THEN 1 ELSE 0 END) AS `17:00`,
    SUM(CASE WHEN HOUR(p.datestamp) = 18 THEN 1 ELSE 0 END) AS `18:00`,
    SUM(CASE WHEN HOUR(p.datestamp) = 19 THEN 1 ELSE 0 END) AS `19:00`,

    COUNT(*) AS Total

FROM " & prodTable & " p

LEFT JOIN assy_masterlist am
    ON am.partcode = p.partcode

LEFT JOIN prod_plan
    ON prod_plan.id = p.planID

WHERE p.datestamp >= @startDate
  AND p.datestamp < @endDate

GROUP BY
    prod_plan.location,
    prod_plan.line,
    p.partcode,
    am.partname,
    am.model

ORDER BY
    Total DESC,
    p.partcode;"


            Case "NIGHTSHIFT"

                query =
"SELECT
    CONCAT(prod_plan.location, ' ', prod_plan.line) AS LocationLine,
    p.partcode,
    am.partname,
    am.model,

    SUM(CASE WHEN HOUR(p.datestamp) = 20 THEN 1 ELSE 0 END) AS `20:00`,
    SUM(CASE WHEN HOUR(p.datestamp) = 21 THEN 1 ELSE 0 END) AS `21:00`,
    SUM(CASE WHEN HOUR(p.datestamp) = 22 THEN 1 ELSE 0 END) AS `22:00`,
    SUM(CASE WHEN HOUR(p.datestamp) = 23 THEN 1 ELSE 0 END) AS `23:00`,
    SUM(CASE WHEN HOUR(p.datestamp) = 0 THEN 1 ELSE 0 END) AS `0:00`,
    SUM(CASE WHEN HOUR(p.datestamp) = 1 THEN 1 ELSE 0 END) AS `1:00`,
    SUM(CASE WHEN HOUR(p.datestamp) = 2 THEN 1 ELSE 0 END) AS `2:00`,
    SUM(CASE WHEN HOUR(p.datestamp) = 3 THEN 1 ELSE 0 END) AS `3:00`,
    SUM(CASE WHEN HOUR(p.datestamp) = 4 THEN 1 ELSE 0 END) AS `4:00`,
    SUM(CASE WHEN HOUR(p.datestamp) = 5 THEN 1 ELSE 0 END) AS `5:00`,
    SUM(CASE WHEN HOUR(p.datestamp) = 6 THEN 1 ELSE 0 END) AS `6:00`,

    COUNT(*) AS Total

FROM " & prodTable & " p

LEFT JOIN assy_masterlist am
    ON am.partcode = p.partcode

LEFT JOIN prod_plan
    ON prod_plan.id = p.planID

WHERE
    (
        p.datestamp >= @startDate
        AND p.datestamp < @midnight
    )
    OR
    (
        p.datestamp >= @nextMidnight
        AND p.datestamp < @endDate
    )

GROUP BY
    prod_plan.location,
    prod_plan.line,
    p.partcode,
    am.partname,
    am.model

ORDER BY
    Total DESC,
    p.partcode;"


            Case Else

                MessageBox.Show(
                "Invalid shift schedule. Use DAYSHIFT or NIGHTSHIFT.",
                "Invalid Shift",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning)

                Exit Sub

        End Select


        Try

            Using conn As New MySqlConnection(ConnectionString)

                Using cmd As New MySqlCommand(query, conn)

                    If ShiftSchedule.Equals(
                    "DAYSHIFT",
                    StringComparison.OrdinalIgnoreCase) Then

                        ' 07:00:00 → next day 00:00:00
                        cmd.Parameters.AddWithValue(
                        "@startDate",
                        datepick.Date.AddHours(7))

                        cmd.Parameters.AddWithValue(
                        "@endDate",
                        datepick.Date.AddDays(1))

                    Else

                        ' 20:00 today
                        cmd.Parameters.AddWithValue(
                        "@startDate",
                        datepick.Date.AddHours(20))

                        ' 00:00 next day
                        cmd.Parameters.AddWithValue(
                        "@midnight",
                        datepick.Date.AddDays(1))

                        ' 07:00 next day
                        cmd.Parameters.AddWithValue(
                        "@nextMidnight",
                        datepick.Date.AddDays(1))

                        cmd.Parameters.AddWithValue(
                        "@endDate",
                        datepick.Date.AddDays(1).AddHours(7))

                    End If


                    Using da As New MySqlDataAdapter(cmd)

                        Dim dt As New DataTable()

                        da.Fill(dt)

                        datagridHourly.AutoGenerateColumns = True
                        datagridHourly.DataSource = dt

                        datagridHourly.AutoSizeColumnsMode =
                        DataGridViewAutoSizeColumnsMode.AllCells

                        datagridHourly.RowHeadersVisible = False

                    End Using

                End Using

            End Using


        Catch ex As Exception

            MessageBox.Show(
            "Failed to load hourly report." &
            vbCrLf & vbCrLf &
            ex.Message,
            "Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error)

        End Try

    End Sub
    Private Sub dtHourly_ValueChanged(sender As Object, e As EventArgs) Handles dtHourly.ValueChanged, cmbShift.SelectedIndexChanged
        LoadHourlyReport(cmbShift.Text, dtHourly.Value)
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        exportExcel(datagridHourly, "Hourly Report " & cmbShift.Text & "", Guna2DateTimePicker1.Value.ToString("MMMM dd yyyy"))
    End Sub

    Private Sub Guna2TextBox2_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox2.TextChanged
        If Guna2TextBox2.Text = "" Then
            datagridLotnumber.DataSource = Nothing
        End If
    End Sub

    Private Sub Guna2TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles Guna2TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then

            Dim sql As String =
            "SELECT ps.`barcode`, ps.`partcode`, ps.`fgQR`,ps.lotnumber, ps.`datestamp` " &
            "FROM `" & prodTable & "` ps " &
            "WHERE ps.`lotnumber` = '" & Guna2TextBox2.Text.Trim() & "'"

            reload(sql, datagridLotnumber)

            e.SuppressKeyPress = True
            e.Handled = True
        End If
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        exportExcel(datagridLotnumber, "Lotnumber Records")
    End Sub
End Class