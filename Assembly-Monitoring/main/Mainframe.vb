Public Class Mainframe

    Private Sub Mainframe_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        '----------------------------------------------------
        ' Load main content
        '----------------------------------------------------

        display_inMain(subframe)

    End Sub


    Private Sub Mainframe_Shown(
        sender As Object,
        e As EventArgs
    ) Handles Me.Shown

        '----------------------------------------------------
        ' Check PC line
        '----------------------------------------------------

        Dim lineNumber As Integer

        If Not Integer.TryParse(user_PCline, lineNumber) Then

            MessageBox.Show(
                "Unable to determine the production line assigned " &
                "to this computer." &
                Environment.NewLine &
                Environment.NewLine &
                "Please contact IT support.",
                "PC Configuration Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            Return

        End If


        '----------------------------------------------------
        ' No line assigned
        '----------------------------------------------------

        If lineNumber = 0 Then

            change_line.Guna2ControlBox1.Hide()

            change_line.StartPosition =
                FormStartPosition.CenterParent

            change_line.BringToFront()

            change_line.ShowDialog(Me)

        End If

    End Sub

End Class