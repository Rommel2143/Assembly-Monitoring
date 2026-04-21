Public Class DataValidations
    Dim _Plan As New Plan
    Dim _Box As New Box
    Private countdown As Integer = 20
    Private canClose As Boolean = False
    Public Sub New(plan As Plan, box As Box)
        InitializeComponent()
        _Plan = plan
        _Box = box
    End Sub
    Private Sub DataValidations_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        modelCodeLabel.Text = "✓ 3 Characters starting at """ & _Plan.PartItem.modelcode & """"
        sqpLabel.Text = "✓ Package quantity must be " & _Plan.PartItem.spq & "pcs."
        partcodeLabel.Text = "✓ Part code must be """ & _Plan.PartItem.partcode & """"
        Dim remarks As String = _Plan.PartItem.Remarks

        If Not String.IsNullOrWhiteSpace(remarks) Then
            Dim items = remarks.Split("|"c).
        Where(Function(x) Not String.IsNullOrWhiteSpace(x)).
        Select(Function(x) x.Trim()).
        ToList()

            Dim lines As New List(Of String)

            For i As Integer = 0 To items.Count - 1 Step 2
                If i + 1 < items.Count Then
                    ' two bullets in one line
                    lines.Add(String.Format("• {0,-20} • {1}", items(i), items(i + 1)))
                Else
                    ' last item if odd count
                    lines.Add("• " & items(i))
                End If
            Next

            remarksLabel.Text = String.Join(Environment.NewLine, lines)
        Else
            remarksLabel.Text = ""
        End If
        countdownTimer.Start()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles partcodeLabel.Click

    End Sub

    Private Sub sqpLabel_Click(sender As Object, e As EventArgs) Handles sqpLabel.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles labelClose.Click

        Me.Close()

    End Sub

    Private Sub countdownTimer_Tick(sender As Object, e As EventArgs) Handles countdownTimer.Tick
        countdown -= 1

        If countdown > 0 Then
            labelClose.Text = "Please read first (" & countdown & ")"
            labelClose.Enabled = False
        Else
            countdownTimer.Stop()
            labelClose.Enabled = True
            labelClose.Text = "Okay, I understand"
            canClose = True
        End If
    End Sub
End Class