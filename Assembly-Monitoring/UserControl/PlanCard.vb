Public Class PlanCard
    Dim plan As New Plan
    Public Event PlanSelected(selectedPlan As Plan)

    Public Sub loadData(planID As Integer)
        plan.getplan(planID)
        lblPartcode.Text = plan.PartItem.partcode
        lblPartname.Text = plan.PartItem.partname
        lblModel.Text = plan.PartItem.model
        lblSPQ.Text = "SPQ: " & plan.PartItem.spq
        lblPlan.Text = "Plan: " & plan.plan.ToString("N0")
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        RaiseEvent PlanSelected(plan)
    End Sub
End Class

