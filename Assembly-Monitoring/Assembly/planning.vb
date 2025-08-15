Imports MySql.Data.MySqlClient
Public Class planning

    Private Sub planning_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_line.Text = "SET Line (" & PCline & ") Plan"
        reloadgrid_plan()
        lbl_date.Text = date1 & " ( " & thisshift() & " )"
    End Sub



    Private Sub Guna2TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_plan.KeyPress, txt_cycle.KeyPress
        ' Allow only numbers and control keys
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True ' Block the input
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btn_start.Click
        If Val(txt_plan.Text) > 0 Then
            'Dim selectquery As String = "SELECT `partcode`, `plan`, `datein`, `shift` FROM `assy_lineplan` WHERE line = '" & PCline & "' AND shift ='" & selected_shift & "' AND partcode = '" & cmb_partcode.Text.Trim & "'"
            'con.Close()
            'con.Open()
            'Using cmd As New MySqlCommand(selectquery, con)
            '    dr = cmd.ExecuteReader
            '    If dr.HasRows Then
            '        MessageBox.Show("You already set a plan for this Partcode.", "Duplicate")
            '        Exit Sub
            '    End If

            'End Using


            Dim query As String = "INSERT INTO `assy_lineplan`(`partcode`, `plan`, `datein`, `shift`, `line`,cycle,target_output) VALUES ('" & cmb_partcode.Text.Trim & "','" & txt_plan.Text & "','" & datedb & "','" & selected_shift & "','" & PCline & "','" & txt_cycle.Text & "','0')"
            con.Close()
            con.Open()

            Dim insert As New MySqlCommand(query, con)
            insert.ExecuteNonQuery()
            reloadgrid_plan()
        Else
            display_error("You can't start the line without PLAN!", 0)
        End If
    End Sub


    Public Sub reloadgrid_plan()
        Try
            ' Load data into the DataGridView
            reload("SELECT ap.id, ap.partcode, am.partname, `plan`, `line`, cycle, CASE 
        WHEN ap.shift = 0 THEN 'DS'
        WHEN ap.shift = 1 THEN 'NS'
    END AS shift FROM assy_lineplan ap
                JOIN assy_masterlist am ON am.partcode = ap.partcode 
                WHERE line = '" & PCline & "' AND datein = '" & datedb & "'", datagrid1)

            ' Check if "ActionImage" column already exists
            Dim columnExists As Boolean = False
            For Each column As DataGridViewColumn In datagrid1.Columns
                If column.Name = "ActionImage" Then
                    columnExists = True
                    Exit For
                End If
            Next

            ' Add an image column if not already added
            If Not columnExists Then
                Dim imgColumn As New DataGridViewImageColumn()
                imgColumn.Name = "ActionImage"
                imgColumn.HeaderText = "Action"
                imgColumn.Image = My.Resources.edit_btn ' Replace with your actual resource

                datagrid1.Columns.Insert(0, imgColumn) ' Insert at the first column
                datagrid1.Columns(0).Width = 50
            End If

            ' Hide the "id" column
            datagrid1.Columns("id").Visible = False
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub datagrid1_ClClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid1.CellClick
        ' Check if the clicked cell is in the image column
        If e.ColumnIndex = datagrid1.Columns("ActionImage").Index AndAlso e.RowIndex >= 0 Then
            Dim selectedPartCode As String = datagrid1.Rows(e.RowIndex).Cells("id").Value.ToString()
            edit_plan.loaddata(selectedPartCode)
            edit_plan.ShowDialog()

        End If
    End Sub


    Private Sub txt_plan_TextChanged(sender As Object, e As EventArgs) Handles txt_plan.TextChanged

    End Sub

    Private Sub cmb_partcode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_partcode.SelectedIndexChanged
        Dim query As String = "Select am.planset,am.cycleset,am.partname,am.model FROM assy_masterlist am WHERE partcode='" & cmb_partcode.Text & "'"
        con.Close()
        con.Open()
        Dim selectpart As New MySqlCommand(query, con)
        dr = selectpart.ExecuteReader
        If dr.Read = True Then
            txt_plan.Text = dr.GetInt32("planset").ToString
            txt_cycle.Text = dr.GetInt32("cycleset").ToString
            txt_partname.Text = dr.GetString("partname").ToString
            txt_model.Text = dr.GetString("model").ToString
        End If
    End Sub

    Private Sub cmb_partcode_MouseClick(sender As Object, e As MouseEventArgs) Handles cmb_partcode.MouseClick
        cmb_display("SELECT distinct(partcode) as ITEM FROM `assy_masterlist`", "ITEM", cmb_partcode)
    End Sub

    Private Sub datagrid1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid1.CellClick

    End Sub

    Private Sub datagrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid1.CellContentClick

    End Sub
End Class