Imports MySql.Data.MySqlClient

Public Class LiveView

    Private ReadOnly DatePlan As Date
    Private ReadOnly LocationPlan As String
    Private ReadOnly LinePlan As Integer
    Private ReadOnly ShiftPlan As String

    '----------------------------------------
    ' Auto Refresh
    '----------------------------------------
    Private WithEvents RefreshTimer As New Timer()
    Private WithEvents CountdownTimer As New Timer()

    Private ReadOnly RefreshInterval As Integer = 11
    Private CountdownSeconds As Integer = RefreshInterval

    Private IsLoading As Boolean = False

    Public Sub New(
        datePlan As Date,
        locationPlan As String,
        linePlan As Integer,
        shiftPlan As String
    )
        InitializeComponent()

        Me.DatePlan = datePlan.Date
        Me.LocationPlan = locationPlan.Trim()
        Me.LinePlan = linePlan
        Me.ShiftPlan = shiftPlan.Trim().ToUpperInvariant()
    End Sub

    Private Sub LiveView_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        progress1.Minimum = 0
        progress1.Maximum = 100
        lblLine.Text = LocationPlan & " LINE " & LinePlan
        '----------------------------------------
        ' Initial Load
        '----------------------------------------
        LoadLivePlans()

        '----------------------------------------
        ' Refresh every 5 seconds
        '----------------------------------------
        RefreshTimer.Interval = RefreshInterval * 1000
        RefreshTimer.Start()

        '----------------------------------------
        ' Countdown every 1 second
        '----------------------------------------
        CountdownTimer.Interval = 1000

        CountdownSeconds = RefreshInterval
        UpdateCountdownLabel()

        CountdownTimer.Start()

    End Sub

    '----------------------------------------
    ' Countdown Tick
    '----------------------------------------
    Private Sub CountdownTimer_Tick(
        sender As Object,
        e As EventArgs
    ) Handles CountdownTimer.Tick

        CountdownSeconds -= 1

        If CountdownSeconds <= 0 Then

            CountdownSeconds = RefreshInterval

            ' Refresh immediately
            If Not IsLoading Then
                LoadLivePlans()
            End If

        End If

        UpdateCountdownLabel()

    End Sub

    '----------------------------------------
    ' Refresh Timer
    '----------------------------------------
    Private Sub RefreshTimer_Tick(
        sender As Object,
        e As EventArgs
    ) Handles RefreshTimer.Tick

        ' The CountdownTimer already triggers
        ' the refresh, so this timer is not needed.
        '
        ' Kept empty intentionally.
    End Sub

    '----------------------------------------
    ' Update Countdown Label
    '----------------------------------------
    Private Sub UpdateCountdownLabel()

        If lblCountdown Is Nothing Then Return

        lblCountdown.Text =
            "Next refresh in: " &
            CountdownSeconds.ToString() &
            " second" &
            If(CountdownSeconds = 1, "", "s")

    End Sub

    '----------------------------------------
    ' Load Live Production Data
    '----------------------------------------
    Public Sub LoadLivePlans()

        If IsLoading Then Return

        IsLoading = True

        Try

            Dim query As String =
                "
                SELECT
                    COALESCE(SUM(pp.plan), 0) AS TotalPlan,
                    COUNT(pp.id) AS PlanCount,
                    COALESCE(AVG(pp.cycletime), 0) AS TargetCycleTime,
                    COALESCE(SUM(pp.target_output), 0) AS TargetOutput,
                    COALESCE(SUM(ps.ActualScanned), 0) AS ActualScanned,
                    COALESCE(
                        SUM(ps.TotalClock) /
                        NULLIF(SUM(ps.ActualScanned), 0),
                        0
                    ) AS AverageActualTime
                FROM prod_plan pp

                LEFT JOIN
                (
                    SELECT
                        planID,
                        COUNT(id) AS ActualScanned,
                        COALESCE(SUM(clock), 0) AS TotalClock
                    FROM prod_scanner
                    GROUP BY planID
                ) ps

                    ON ps.planID = pp.id

                WHERE pp.location = @location
                  AND pp.line = @line
                  AND DATE(pp.datein) = @date
                  AND pp.shiftplan = @shiftplan
                "

            Using cmd As New MySqlCommand(query, con)

                cmd.Parameters.Add(
                    "@location",
                    MySqlDbType.VarChar
                ).Value = LocationPlan

                cmd.Parameters.Add(
                    "@line",
                    MySqlDbType.Int32
                ).Value = LinePlan

                cmd.Parameters.Add(
                    "@date",
                    MySqlDbType.Date
                ).Value = DatePlan

                cmd.Parameters.Add(
                    "@shiftplan",
                    MySqlDbType.VarChar
                ).Value = ShiftPlan

                If con.State <> ConnectionState.Open Then
                    con.Open()
                End If

                Using reader As MySqlDataReader =
                    cmd.ExecuteReader()

                    If reader.Read() Then

                        Dim totalPlan As Integer =
                            Convert.ToInt32(reader("TotalPlan"))

                        Dim targetCycleTime As Decimal =
                            Convert.ToDecimal(reader("TargetCycleTime"))

                        Dim targetOutput As Integer =
                            Convert.ToInt32(reader("TargetOutput"))

                        Dim actualScanned As Integer =
                            Convert.ToInt32(reader("ActualScanned"))

                        Dim averageActualTime As Decimal =
                            Convert.ToDecimal(reader("AverageActualTime"))

                        '----------------------------------------
                        ' Update Labels
                        '----------------------------------------

                        lbl_plan.Text =
                            totalPlan.ToString("N0")

                        lblActualScanned.Text =
                            actualScanned.ToString("N0")

                        lblTargetOutput.Text =
                            targetOutput.ToString("N0")

                        lblTargetCycle.Text =
                            "TARGET CYCLE (" &
                            targetCycleTime.ToString("N0") &
                            " seconds/item)"

                        lblActualCycle.Text =
                            "ACTUAL CYCLE (" &
                            averageActualTime.ToString("N0") &
                            " seconds/item)"

                        '----------------------------------------
                        ' Progress
                        '----------------------------------------

                        Dim percentage As Decimal = 0D

                        If totalPlan > 0 Then

                            percentage =
                                (CDec(actualScanned) /
                                 CDec(totalPlan)) * 100D

                        End If

                        Dim progressValue As Integer =
                            Convert.ToInt32(
                                Math.Round(percentage)
                            )

                        progressValue =
                            Math.Max(
                                progress1.Minimum,
                                Math.Min(
                                    progressValue,
                                    progress1.Maximum
                                )
                            )

                        progress1.Value =
                            progressValue

                    End If

                End Using

            End Using

        Catch ex As Exception

            System.Diagnostics.Debug.WriteLine(
                "LiveView refresh error: " &
                ex.Message
            )

        Finally

            If con.State <> ConnectionState.Closed Then
                con.Close()
            End If

            IsLoading = False

        End Try

    End Sub

    '----------------------------------------
    ' Form Closed
    '----------------------------------------
    Private Sub LiveView_FormClosed(
        sender As Object,
        e As FormClosedEventArgs
    ) Handles MyBase.FormClosed

        RefreshTimer.Stop()
        RefreshTimer.Dispose()

        CountdownTimer.Stop()
        CountdownTimer.Dispose()

    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub
End Class