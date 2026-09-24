Public Class selectLive

    Private Sub selectLive_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        'Default date
        Guna2DateTimePicker1.Value = Date.Today

        'Default shift
        radDS.Checked = True

    End Sub


    Private Sub btn_select_Click(
    sender As Object,
    e As EventArgs
) Handles btn_select.Click

        '========================================================
        ' DETERMINE SHIFT
        '========================================================

        Dim shiftPlan As String

        If radDS.Checked Then

            shiftPlan = "DS"

        ElseIf radNS.Checked Then

            shiftPlan = "NS"

        Else

            MessageBox.Show(
            "Please select a shift.",
            "Select Shift",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning
        )

            Return

        End If


        '========================================================
        ' GET PC LINE
        '========================================================

        Dim linePlan As Integer

        If Not Integer.TryParse(user_PCline, linePlan) Then

            MessageBox.Show(
            "Invalid PC line configuration.",
            "Configuration Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning
        )

            Return

        End If


        '========================================================
        ' CREATE LIVE VIEW
        '========================================================

        Dim frmLiveView As New LiveView(
        Guna2DateTimePicker1.Value.Date,
        user_PClocation,
        linePlan,
        shiftPlan
    )


        '========================================================
        ' SHOW LIVE VIEW
        '========================================================

        frmLiveView.Show()

        frmLiveView.BringToFront()
        '========================================================
        ' CLOSE SELECTION
        '========================================================

        Me.Close()

    End Sub

    Private Sub radDS_CheckedChanged(
        sender As Object,
        e As EventArgs
    ) Handles radDS.CheckedChanged

        If radDS.Checked Then
            radNS.Checked = False
        End If

    End Sub


    Private Sub radNS_CheckedChanged(
        sender As Object,
        e As EventArgs
    ) Handles radNS.CheckedChanged

        If radNS.Checked Then
            radDS.Checked = False
        End If

    End Sub

End Class