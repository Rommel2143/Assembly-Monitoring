Imports Guna.UI2.WinForms
Imports MySql.Data.MySqlClient

Public Class ScanItems
    Dim SetPlan As New Plan
    Private Sub btn_select_Click(sender As Object, e As EventArgs) Handles btn_select.Click
        Using setPart As New selectPlan
            setPart.dateSelected = dtpicker1.Value.ToString("yyyy-MM-dd")
            setPart.shiftSelected = If(Guna2RadioButton1.Checked, "DS", "NS")

            If setPart.ShowDialog() = DialogResult.OK Then
                SetPlan = setPart.SelectedPlan
                lblPartname.Text = SetPlan.PartItem.partname
                lblPartcode.Text = SetPlan.PartItem.partcode
                lblPlan.Text = "Plan: " & SetPlan.plan
                lblModel.Text = SetPlan.PartItem.model
                lblModelcode.Text = "Model Code: " & SetPlan.PartItem.modelcode
                lblSPQ.Text = "SPQ: " & SetPlan.PartItem.spq
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

            Dim item As New ItemsCard
            item.loadData(txtItemBarcode.Text)
            flowScanned.Controls.Add(item)
            If flowScanned.Controls.Count > SetPlan.PartItem.spq Then
                txt_barcode.Enabled = True
                txt_barcode.Clear()
                txt_barcode.Focus()
            Else
                txtItemBarcode.Clear()
                txtItemBarcode.Focus()
            End If



        End If


    End Sub
End Class