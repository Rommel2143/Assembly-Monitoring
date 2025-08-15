Imports MySql.Data.MySqlClient
Imports Guna.UI2.WinForms

Public Class overview

    Private Sub overview_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Timer1.Interval = 60000 ' 1 minute in milliseconds
        Timer1.Start()
        dtpicker1.Value = Date.Now
        ' Set default shift radio button
        rad_ds.Checked = If(selected_shift = 0, True, False)
        rad_ns.Checked = If(selected_shift = 1, True, False)
    End Sub
    Public Sub Loaddata()
        Try
            ' Freeze controls (optional: disable or suspend layout)
            Me.SuspendLayout()

            Cursor = Cursors.WaitCursor
            flow_item.Controls.Clear()
            con.Close()
            con.Open()



            Dim query As String = "SELECT 
    lp.line,
    ml.partname,
    ml.model,
    lp.partcode,
    lp.plan,
    lp.cycle,
    ml.modelcode,
    lp.target_output,
    COUNT(b.barcode) AS actualtotal,
    ROUND(AVG(b.clock), 2) AS actual_cycletime -- in seconds
FROM assy_lineplan lp
JOIN assy_masterlist ml 
    ON ml.partcode = lp.partcode
LEFT JOIN assy_barcodes b 
    ON b.partcode = lp.partcode
    AND b.line = lp.line
    AND b.datein = lp.datein
    AND b.shift = lp.shift
WHERE lp.datein = '" & dtpicker1.Value.ToString("yyyy-MM-dd") & "'  -- <-- filter date here
  AND lp.shift ='" & If(rad_ds.Checked = True, 0, 1) & "'           -- <-- filter shift here
GROUP BY 
   lp.id
ORDER BY 
    lp.line,
    lp.partcode;
"

            '        lp.line,
            'ml.partname,
            'ml.model,
            'lp.partcode,
            'lp.plan,
            'lp.cycle,
            'ml.modelcode,
            'lp.target_output

            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@datein", dtpicker1.Value.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@shift", If(rad_ds.Checked = True, 0, 1))

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                Dim actual As Integer = If(IsDBNull(reader("actualtotal")), 0, Convert.ToInt32(reader("actualtotal")))
                Dim target As Integer = If(IsDBNull(reader("target_output")), 0, Convert.ToInt32(reader("target_output")))
                Dim actualCycleTime As Decimal = If(IsDBNull(reader("actual_cycletime")), 0D, Convert.ToDecimal(reader("actual_cycletime")))
                Dim cycleTime As Decimal = If(IsDBNull(reader("cycle")), 0D, Convert.ToDecimal(reader("cycle")))
                Dim model As String = reader("model").ToString()
                Dim line As String = reader("line").ToString()
                Dim plan As String = reader("plan").ToString()

                '    ' Panel container
                '    Dim memberPanel As New Guna2Panel With {
                '    .Width = 400,
                '    .Height = 260,
                '    .BorderRadius = 12,
                '    .Margin = New Padding(10),
                '    .BorderColor = Color.Gray,
                '    .BorderThickness = 1,
                '    .FillColor = Color.White
                '}

                '    ' Header (Line and Plan)
                '    Dim headerPanel As New Guna2GradientPanel With {
                '    .Height = 40,
                '    .Dock = DockStyle.Top,
                '    .FillColor = Color.FromArgb(72, 167, 255),
                '    .FillColor2 = Color.FromArgb(30, 144, 255),
                '    .BorderRadius = 8,
                '    .Padding = New Padding(15, 0, 15, 0),
                '    .BorderThickness = 1,
                '    .BorderColor = Color.DimGray,
                '    .BackColor = Color.Transparent
                '}

                '    Dim lblLine As New Label With {
                '    .Text = $"LINE {line}",
                '    .ForeColor = Color.White,
                '    .Font = New Font("Segoe UI", 10, FontStyle.Bold),
                '    .Dock = DockStyle.Left,
                '    .TextAlign = ContentAlignment.MiddleLeft,
                '    .BackColor = Color.Transparent
                '}

                '    Dim lblPlan As New Label With {
                '    .Text = $"Plan : {plan}",
                '    .ForeColor = Color.White,
                '    .Font = New Font("Segoe UI", 10, FontStyle.Bold),
                '    .Dock = DockStyle.Right,
                '    .TextAlign = ContentAlignment.MiddleRight,
                '    .BackColor = Color.Transparent
                '}

                '    headerPanel.Controls.Add(lblLine)
                '    headerPanel.Controls.Add(lblPlan)

                '    ' Model label
                '    Dim lblModel As New Label With {
                '    .Text = model.ToUpper(),
                '    .Dock = DockStyle.Top,
                '    .Height = 30,
                '    .TextAlign = ContentAlignment.MiddleCenter,
                '    .Font = New Font("Segoe UI Semibold", 11, FontStyle.Bold),
                '    .ForeColor = Color.Black,
                '    .BackColor = Color.Transparent
                '}

                '    ' Redesigned Target vs Actual Section
                '    Dim statPanel As New TableLayoutPanel With {
                '    .Dock = DockStyle.Top,
                '    .Height = 120,
                '    .ColumnCount = 3,
                '    .RowCount = 3,
                '    .BackColor = Color.Transparent
                '}

                '    statPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 45))
                '    statPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10))
                '    statPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 45))
                '    statPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 30)) ' Headers
                '    statPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 40)) ' Big numbers
                '    statPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 30)) ' Cycle times

                '    statPanel.Controls.Add(MakeCenterLabel("TARGET", FontStyle.Regular, 10), 0, 0)
                '    statPanel.Controls.Add(MakeCenterLabel("ACTUAL", FontStyle.Regular, 10), 2, 0)
                '    statPanel.Controls.Add(MakeCenterLabel(target.ToString(), FontStyle.Bold, 30), 0, 1)
                '    statPanel.Controls.Add(MakeCenterLabel(actual.ToString(), FontStyle.Bold, 30), 2, 1)
                '    statPanel.Controls.Add(MakeCenterLabel($"{cycleTime:F0} sec / item", FontStyle.Regular, 15), 0, 2)
                '    statPanel.Controls.Add(MakeCenterLabel($"{actualCycleTime:F0} sec / item", FontStyle.Regular, 15), 2, 2)

                '    ' Vertical separator
                '    Dim verticalSeparator As New Panel With {
                '        .BackColor = Color.LightGray,
                '        .Width = 0.8,
                '        .Margin = New Padding(20, 4, 20, 4),
                '        .Dock = DockStyle.Fill
                '    }

                '    statPanel.Controls.Add(verticalSeparator, 1, 0)
                '    statPanel.SetRowSpan(verticalSeparator, 3)

                '    ' Progress Bar
                '    Dim percentage As Integer = If(target > 0, Math.Min(CInt((actual / plan) * 100), 100), 0)

                '    Dim progressPanel As New Panel With {
                '    .Dock = DockStyle.Bottom,
                '    .Height = 40,
                '    .Padding = New Padding(10, 5, 10, 5),
                '    .BackColor = Color.Transparent
                '}

                '    Dim progressBar As New Guna2ProgressBar With {
                '    .Dock = DockStyle.Fill,
                '    .Value = percentage,
                '    .FillColor = Color.LightGray,
                '    .ProgressColor = Color.MediumSeaGreen,
                '    .BorderRadius = 6
                '}

                '    Dim percentageLabel As New Label With {
                '    .Text = $"{percentage}%",
                '    .Dock = DockStyle.Right,
                '    .Width = 50,
                '    .TextAlign = ContentAlignment.MiddleRight,
                '    .ForeColor = Color.Black,
                '    .Font = New Font("Segoe UI", 10, FontStyle.Bold),
                '    .BackColor = Color.Transparent
                '}

                '    progressPanel.Controls.Add(progressBar)
                '    progressPanel.Controls.Add(percentageLabel)
                '    If percentage = 100 Then
                '        memberPanel.FillColor = Color.LightGreen
                '    End If

                '    ' Assemble Final UI
                '    memberPanel.Controls.Add(progressPanel)
                '    memberPanel.Controls.Add(statPanel)
                '    memberPanel.Controls.Add(lblModel)
                '    memberPanel.Controls.Add(headerPanel)
                '    flow_item.Controls.Add(memberPanel)
                ' Panel container (extra compact)
                Dim memberPanel As New Guna2Panel With {
    .Width = 260,
    .Height = 160,
    .BorderRadius = 8,
    .Margin = New Padding(4),
    .BorderColor = Color.Gray,
    .BorderThickness = 1,
    .FillColor = Color.White
}

                ' Header
                Dim headerPanel As New Guna2GradientPanel With {
    .Height = 24,
    .Dock = DockStyle.Top,
    .FillColor = Color.FromArgb(72, 167, 255),
    .FillColor2 = Color.FromArgb(30, 144, 255),
    .BorderRadius = 5,
    .Padding = New Padding(6, 0, 6, 0),
    .BorderThickness = 1,
    .BorderColor = Color.DimGray,
    .BackColor = Color.Transparent
}

                Dim lblLine As New Label With {
    .Text = $"LINE {line}",
    .ForeColor = Color.White,
    .Font = New Font("Segoe UI", 7, FontStyle.Bold),
    .Dock = DockStyle.Left,
    .TextAlign = ContentAlignment.MiddleLeft,
    .BackColor = Color.Transparent
}

                Dim lblPlan As New Label With {
    .Text = $"Plan : {plan}",
    .ForeColor = Color.White,
    .Font = New Font("Segoe UI", 7, FontStyle.Bold),
    .Dock = DockStyle.Right,
    .TextAlign = ContentAlignment.MiddleRight,
    .BackColor = Color.Transparent
}

                headerPanel.Controls.Add(lblLine)
                headerPanel.Controls.Add(lblPlan)

                ' Model label
                Dim lblModel As New Label With {
    .Text = model.ToUpper(),
    .Dock = DockStyle.Top,
    .Height = 20,
    .TextAlign = ContentAlignment.MiddleCenter,
    .Font = New Font("Segoe UI Semibold", 8, FontStyle.Bold),
    .ForeColor = Color.Black,
    .BackColor = Color.Transparent
}

                ' Target vs Actual Section
                Dim statPanel As New TableLayoutPanel With {
    .Dock = DockStyle.Top,
    .Height = 70,
    .ColumnCount = 3,
    .RowCount = 3,
    .BackColor = Color.Transparent
}

                statPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 45))
                statPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10))
                statPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 45))
                statPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 30))
                statPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 40))
                statPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 30))

                statPanel.Controls.Add(MakeCenterLabel("TARGET", FontStyle.Regular, 7), 0, 0)
                statPanel.Controls.Add(MakeCenterLabel("ACTUAL", FontStyle.Regular, 7), 2, 0)
                statPanel.Controls.Add(MakeCenterLabel(target.ToString(), FontStyle.Bold, 14), 0, 1)
                statPanel.Controls.Add(MakeCenterLabel(actual.ToString(), FontStyle.Bold, 14), 2, 1)
                statPanel.Controls.Add(MakeCenterLabel($"{cycleTime:F0}s/item", FontStyle.Regular, 8), 0, 2)
                statPanel.Controls.Add(MakeCenterLabel($"{actualCycleTime:F0}s/item", FontStyle.Regular, 8), 2, 2)

                ' Vertical separator
                Dim verticalSeparator As New Panel With {
    .BackColor = Color.LightGray,
    .Width = 1,
    .Margin = New Padding(6, 1, 6, 1),
    .Dock = DockStyle.Fill
}
                statPanel.Controls.Add(verticalSeparator, 1, 0)
                statPanel.SetRowSpan(verticalSeparator, 3)

                ' Progress Bar
                Dim percentage As Integer = If(target > 0, Math.Min(CInt((actual / plan) * 100), 100), 0)
                Dim progressPanel As New Panel With {
    .Dock = DockStyle.Bottom,
    .Height = 24,
    .Padding = New Padding(4, 2, 4, 2),
    .BackColor = Color.Transparent
}

                Dim progressBar As New Guna2ProgressBar With {
    .Dock = DockStyle.Fill,
    .Value = percentage,
    .FillColor = Color.LightGray,
    .ProgressColor = Color.MediumSeaGreen,
    .BorderRadius = 3
}

                Dim percentageLabel As New Label With {
    .Text = $"{percentage}%",
    .Dock = DockStyle.Right,
    .Width = 34,
    .TextAlign = ContentAlignment.MiddleRight,
    .ForeColor = Color.Black,
    .Font = New Font("Segoe UI", 7, FontStyle.Bold),
    .BackColor = Color.Transparent
}

                progressPanel.Controls.Add(progressBar)
                progressPanel.Controls.Add(percentageLabel)
                If percentage = 100 Then
                    memberPanel.FillColor = Color.LightGreen
                End If

                ' Assemble UI
                memberPanel.Controls.Add(progressPanel)
                memberPanel.Controls.Add(statPanel)
                memberPanel.Controls.Add(lblModel)
                memberPanel.Controls.Add(headerPanel)
                flow_item.Controls.Add(memberPanel)

            End While

            reader.Close()

            Cursor = Cursors.Default
            Me.ResumeLayout()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub




    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick


        ' Load your data
        Loaddata()


    End Sub


    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)
        display_formsub(New assembly_reports)
    End Sub
    Private Function MakeInfoLabel(text As String) As Label
        Return New Label With {
        .Text = text,
        .Font = New Font("Segoe UI", 11),
        .ForeColor = Color.FromArgb(40, 40, 40),
        .AutoSize = False,
        .Dock = DockStyle.Fill,
        .TextAlign = ContentAlignment.MiddleLeft
    }
    End Function
    Private Function MakeValueLabel(text As String) As Label
        Return New Label With {
        .Text = text,
        .Font = New Font("Segoe UI Semibold", 11),
        .ForeColor = Color.Black,
        .AutoSize = False,
        .Dock = DockStyle.Fill,
        .TextAlign = ContentAlignment.MiddleLeft
    }
    End Function
    Private Function MakeCenterLabel(text As String, style As FontStyle, Optional size As Integer = 11) As Label
        Return New Label With {
        .Text = text,
        .Font = New Font("Segoe UI", size, style),
        .ForeColor = Color.Black,
        .Dock = DockStyle.Fill,
        .TextAlign = ContentAlignment.MiddleCenter,
        .BackColor = Color.Transparent
    }
    End Function



    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub dtpicker1_ValueChanged(sender As Object, e As EventArgs) Handles dtpicker1.ValueChanged
        Loaddata()
    End Sub

    Private Sub rad_ds_CheckedChanged(sender As Object, e As EventArgs) Handles rad_ds.CheckedChanged
        Loaddata()
    End Sub
End Class
