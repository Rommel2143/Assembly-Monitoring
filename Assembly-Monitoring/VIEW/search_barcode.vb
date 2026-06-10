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

        Dim shiftFilter As String = ""

        Select Case ShiftSchedule.ToUpper()

            Case "DAYSHIFT"
                shiftFilter = "AND HOUR(datestamp) BETWEEN 7 AND 19"

            Case "NIGHTSHIFT"
                shiftFilter = "AND (HOUR(datestamp) >= 20 OR HOUR(datestamp) <= 6)"

            Case Else
                MessageBox.Show("Invalid shift schedule. Use DAYSHIFT or NIGHTSHIFT.")
                Exit Sub

        End Select

        Dim query As String =
"SELECT
    prod_scanner.partcode,
    am.partname,
    am.model,

    SUM(CASE WHEN HOUR(datestamp) = 7 THEN 1 ELSE 0 END) AS '7:00',
    SUM(CASE WHEN HOUR(datestamp) = 8 THEN 1 ELSE 0 END) AS '8:00',
    SUM(CASE WHEN HOUR(datestamp) = 9 THEN 1 ELSE 0 END) AS '9:00',
    SUM(CASE WHEN HOUR(datestamp) = 10 THEN 1 ELSE 0 END) AS '10:00',
    SUM(CASE WHEN HOUR(datestamp) = 11 THEN 1 ELSE 0 END) AS '11:00',
    SUM(CASE WHEN HOUR(datestamp) = 12 THEN 1 ELSE 0 END) AS '12:00',
    SUM(CASE WHEN HOUR(datestamp) = 13 THEN 1 ELSE 0 END) AS '13:00',
    SUM(CASE WHEN HOUR(datestamp) = 14 THEN 1 ELSE 0 END) AS '14:00',
    SUM(CASE WHEN HOUR(datestamp) = 15 THEN 1 ELSE 0 END) AS '15:00',
    SUM(CASE WHEN HOUR(datestamp) = 16 THEN 1 ELSE 0 END) AS '16:00',
    SUM(CASE WHEN HOUR(datestamp) = 17 THEN 1 ELSE 0 END) AS '17:00',
    SUM(CASE WHEN HOUR(datestamp) = 18 THEN 1 ELSE 0 END) AS '18:00',
    SUM(CASE WHEN HOUR(datestamp) = 19 THEN 1 ELSE 0 END) AS '19:00',

    COUNT(*) AS Total

FROM prod_scanner
LEFT JOIN assy_masterlist am 
    ON am.partcode = prod_scanner.partcode

WHERE DATE(datestamp) = @date
" & shiftFilter & "

GROUP BY prod_scanner.partcode, am.partname, am.model
ORDER BY Total DESC, prod_scanner.partcode;"

        Try
            Using conn As New MySqlConnection(ConnectionString)
                Using cmd As New MySqlCommand(query, conn)

                    cmd.Parameters.AddWithValue("@date", datepick.Date)

                    Using da As New MySqlDataAdapter(cmd)

                        Dim dt As New DataTable()
                        da.Fill(dt)

                        datagridHourly.AutoGenerateColumns = True
                        datagridHourly.DataSource = dt
                        datagridHourly.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                        datagridHourly.RowHeadersVisible = False

                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show(
            "Failed to load hourly report." & vbCrLf & vbCrLf & ex.Message,
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
End Class