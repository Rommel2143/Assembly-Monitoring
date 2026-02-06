Public Class PartcodeCard

    Public Property PartCode As String
    Private partItem As New Partcode

    Private Sub PartcodeCard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If String.IsNullOrEmpty(PartCode) Then Exit Sub

        partItem.getPartData(PartCode)

        lblPartcode.Text = partItem.partcode
        lblPartname.Text = partItem.partname
        lblModel.Text = partItem.model
        lblSPQ.Text = "SPQ: " & partItem.qty.ToString()


    End Sub

End Class
