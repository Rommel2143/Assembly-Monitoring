Public Class ItemsCard
    Property barcode As String
    Property clock As Int32 = 0
    Property datestamp As DateTime

    Public Sub loadData(scannedBarcode As String)
        barcode = scannedBarcode
        datestamp = Date.Now
        lblBarcode.Text = barcode
        lblTimeStamp.Text = datestamp.ToString("HH:mm:ss tt")
        lblInterval.Text = "Interval: " & clock & "sec."
    End Sub

    Private Sub ItemsCard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub
End Class