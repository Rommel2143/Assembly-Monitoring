Public Class search_barcode
    Private Sub search_barcode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2DateTimePicker1.Value = Date.Now

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
        FROM `prod_scanner` ps " &
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
        "FROM `prod_scanner` ps " &
        "JOIN `prod_plan` pp ON pp.id = ps.planID " &
        "WHERE DATE(ps.`datestamp`) = '" & Guna2DateTimePicker1.Value.ToString("yyyy-MM-dd") & "' ORDER BY pp.line ASC"

        reload(query, datagrid2)

    End Sub


    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        exportExcel(datagrid1, "Barcode Records", Guna2DateTimePicker1.Value.ToString("MMMM dd yyyy"))
    End Sub
End Class