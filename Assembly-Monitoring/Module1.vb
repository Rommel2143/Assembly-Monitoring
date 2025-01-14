Imports MySql.Data.MySqlClient
Imports System.Net.NetworkInformation
Module Module1

    Public Function connection() As MySqlConnection
        Return New MySqlConnection("server=TRCF2D-060;user id=Inventory;password=inventory123@;database=trcsystem")
        ' Return New MySqlConnection("server=localhost;user id=momel;password=Magnaye2143@#;database=trcsystem")
    End Function
    Public con As MySqlConnection = connection()
    Public result As String
    Public cmd As New MySqlCommand
    Public da As New MySqlDataAdapter
    Public dr As MySqlDataReader
    Public dt As New DataTable

    'credentials for log in
    Public fname As String
    Public idno As String
    Public user_level As Integer
    Public designation As String


    Public PCname As String = Environment.MachineName
    Public PCline As String
    Public PClinetotal As String

    Public date1 As String
    Public datedb As String
    Public selected_shift As Integer



    Public report_cmlqr As String


    Function getPCline() As String
        Dim query As String = "SELECT line,SUBSTRING_INDEX(`line`, '-', 1) AS merged_line FROM assy_devices WHERE pcname='" & Environment.MachineName & "'"
        con.Close()
        con.Open()
        Dim selectpc As New MySqlCommand(query, con)
        dr = selectpc.ExecuteReader
        If dr.Read = True Then
            PCline = dr.GetString("line")
            PClinetotal = dr.GetString("merged_line")

            Return dr.GetString("line")
        Else
            Return "0"
        End If

    End Function

    Public Function thisshift() As String
        Select Case selected_shift
            Case 0
                Return "Day Shift"
            Case 1
                Return "Night Shift"
            Case Else
                Return Nothing
        End Select
    End Function


    Public Sub sounderror()
        My.Computer.Audio.Play(My.Resources.errorsound, AudioPlayMode.Background)
    End Sub
    Public Sub soundduplicate()
        My.Computer.Audio.Play(My.Resources.duplicate, AudioPlayMode.Background)
    End Sub
    Public Sub cmb_display(sql As String, column As String, cmb As Guna.UI2.WinForms.Guna2ComboBox)
        Try
            con.Close()
            con.Open()
            Dim cmdselect As New MySqlCommand(sql, con)
            dr = cmdselect.ExecuteReader
            cmb.Items.Clear()
            While (dr.Read())
                cmb.Items.Add(dr.GetString(column))
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Public Sub viewdata(ByVal sql As String)
        con.Close()
        con.Open()

        With cmd
            .Connection = con
            .CommandText = sql
        End With
        dr = cmd.ExecuteReader
    End Sub
    Public Sub display_form(form As Form)

        With form
            .Refresh()
            .TopLevel = False

            Mainframe.Panel1.Controls.Add(form)
            .BringToFront()
            .Show()

        End With
    End Sub

    Public Sub display_formsub(form As Form)

        With form
            .Refresh()
            .TopLevel = False

            sub_mainframe.Panel1.Controls.Add(form)
            .BringToFront()
            .Show()

        End With
    End Sub

    Public Sub reload(ByVal sql As String, ByVal DTG As Object)
        Try
            dt = New DataTable
            con.Close()
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            DTG.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
            da.Dispose()

        End Try
    End Sub



    Public Sub display_error(text As String, sound As Integer)

        ShowSnackbar(text)
        Select Case sound
            Case 0

            Case 1
                sounderror()
            Case 2
                soundduplicate()
        End Select
    End Sub

    Private Sub display_formscan(form As Form)
        With form
            .Refresh()
            .TopLevel = False
            Mainframe.Panel1.Controls.Add(form)
            .BringToFront()
            .Show()

        End With
    End Sub
    Public Sub ShowSnackbar(message As String)
        ' Create a new Form to act as the snackbar
        Dim snackbarForm As New Form()

        ' Set basic properties
        snackbarForm.FormBorderStyle = FormBorderStyle.None
        snackbarForm.StartPosition = FormStartPosition.Manual
        snackbarForm.BackColor = Color.FromArgb(60, 63, 65) ' Dark background
        snackbarForm.ForeColor = Color.White ' White text
        snackbarForm.Height = 40 ' Set the height of the snackbar
        snackbarForm.Width = Screen.PrimaryScreen.Bounds.Width ' Set the width to screen width
        snackbarForm.TopMost = True ' Ensure it's on top
        snackbarForm.ShowInTaskbar = False

        ' Set the position at the top of the screen (90 pixels from the top)
        snackbarForm.Location = New Point(0, 60) ' Start at the top-left corner of the screen

        ' Add a label to display the message
        Dim messageLabel As New Label()
        messageLabel.Text = message
        messageLabel.Font = New Font("Segoe UI", 10)
        messageLabel.ForeColor = Color.White ' White text for better contrast
        messageLabel.AutoSize = False
        messageLabel.TextAlign = ContentAlignment.MiddleCenter
        messageLabel.Dock = DockStyle.Fill ' Fill the entire form with the label
        snackbarForm.Controls.Add(messageLabel)



        snackbarForm.Show()


        ' Set up a timer to close the snackbar after a few seconds
        Dim closeTimer As New Timer()
        AddHandler closeTimer.Tick, Sub(sender, e)
                                        ' Fade out effect
                                        For i As Integer = 10 To 0 Step -1
                                            snackbarForm.Opacity = i / 10.0
                                            Threading.Thread.Sleep(30)
                                        Next
                                        snackbarForm.Close() ' Close the snackbar
                                        closeTimer.Stop()
                                    End Sub
        closeTimer.Interval = 3000 ' Show for specified duration
        closeTimer.Start()
    End Sub



End Module
