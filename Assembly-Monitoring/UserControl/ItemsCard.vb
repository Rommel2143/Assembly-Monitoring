Public Class ItemsCard
    Property barcode As String
    Property barcode2 As String
    Property clock As Int32 = 0
    Property datestamp As DateTime

    Public Sub loadData(scannedBarcode As String, scannedBarcode2 As String, _clock As Integer)
        barcode = scannedBarcode
        barcode2 = scannedBarcode2
        datestamp = Date.Now
        lblBarcode.Text = barcode
        lblBarcode2.Text = barcode2
        clock = _clock
        lblTimeStamp.Text = datestamp.ToString("HH:mm:ss tt")
        lblInterval.Text = "Interval: " & clock & "sec."
    End Sub

    Private Sub ItemsCard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub
End Class