Imports MySql.Data.MySqlClient
Imports Guna.UI2.WinForms
Public Class overview
    Private Sub overview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loaddata()
    End Sub

    Public Sub Loaddata()
        Try
            flow_item.Controls.Clear()
            con.Close()
            con.Open()
            Dim query As String = "SELECT COUNT(ab.id) as total,am.model ,ab.partcode, ab.datein, ab.shift, ab.timein, SUM(clock)/COUNT(clock) as clockcycle, ab.line,al.plan,al.target_output
                       FROM assy_barcodes ab
                      JOIN assy_lineplan al ON al.partcode = ab.partcode
                      JOIN assy_masterlist am on am.partcode=ab.partcode
                      WHERE ab.datein = '" & datedb & "' AND ab.shift = '" & selected_shift & "'
                      GROUP BY ab.partcode, ab.line"


            Dim cmd As New MySqlCommand(query, con)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                ' Create a new Guna2Panel for each member
                Dim memberPanel As New Guna2Panel()
                memberPanel.Width = 450
                memberPanel.Height = 220
                memberPanel.BackColor = Color.FromArgb(250, 250, 250)
                ' memberPanel.BorderRadius = 10
                memberPanel.Margin = New Padding(10)
                memberPanel.FillColor = Color.White

                memberPanel.ShadowDecoration.Enabled = True
                memberPanel.ShadowDecoration.Color = Color.Silver
                memberPanel.ShadowDecoration.BorderRadius = 10

                ' Label for member information
                Dim memberLabel As New Label()
                memberLabel.Font = New Font("Segoe UI", 20)
                memberLabel.ForeColor = Color.FromArgb(50, 50, 50)
                memberLabel.AutoSize = True
                memberLabel.Text = $"Line: {reader("line")}       Plan: {reader("plan")}" & Environment.NewLine &
                                  $"Partcode: {reader("partcode")}" & Environment.NewLine &
                                  $"Model: {reader("model")}  " & Environment.NewLine &
                                  $"      Actual: {reader("total")}          Target: {reader("target_output")}" & Environment.NewLine &
                                  $"      Cycletime: {Convert.ToDecimal(reader("clockcycle")).ToString("F2")} sec/item"

                memberLabel.Location = New Point(10, 15)




                memberPanel.Controls.Add(memberLabel)
                flow_item.Controls.Add(memberPanel)



            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally

            con.Close()

        End Try
    End Sub

    Private Sub flow_item_Paint(sender As Object, e As PaintEventArgs) Handles flow_item.Paint

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Loaddata()
    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint
        Timer1.Start()
    End Sub
End Class