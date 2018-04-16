Imports System
Imports System.Web
Imports System.Web.UI.HtmlControls
Imports System.Drawing.Printing
Imports DevExpress.XtraReports.UI
' ...

Partial Public Class _Default
    Inherits System.Web.UI.Page

    Protected Function IsReportPrinted() As Boolean
        Return (((Request.Params("__EVENTTARGET") = ASPxDocumentViewer1.UniqueID) AndAlso Request.Params("__EVENTARGUMENT").Contains("showPrintDialog:true")) OrElse ((Request.Params("__CALLBACKID") = ASPxDocumentViewer1.UniqueID) AndAlso Request.Params("__CALLBACKPARAM").Contains("print=idx")))
    End Function

    Private Sub ScaleReportDocument(ByVal report As XtraReport, ByVal scaleFactor As Single)
        Dim newMargins As New Margins(Convert.ToInt32(report.Margins.Left * scaleFactor), Convert.ToInt32(report.Margins.Right * scaleFactor), Convert.ToInt32(report.Margins.Top * scaleFactor), Convert.ToInt32(report.Margins.Bottom * scaleFactor))
        report.PaperKind = System.Drawing.Printing.PaperKind.Custom
        report.PageWidth = CInt((report.PageWidth * scaleFactor))
        report.PageHeight = CInt((report.PageHeight * scaleFactor))
        report.Margins = newMargins
        report.CreateDocument()

        report.PrintingSystem.Document.ScaleFactor = scaleFactor
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        Dim report As XtraReport = New XtraReport1()
        If (Not IsReportPrinted()) AndAlso (Not String.IsNullOrEmpty(Request("Scale"))) Then

            Dim scaleFactor As Single = Convert.ToSingle(Request("Scale")) / 100F

            ScaleReportDocument(report, scaleFactor)
        End If
        ASPxDocumentViewer1.Report = report
    End Sub
End Class
