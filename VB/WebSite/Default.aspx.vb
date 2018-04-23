Imports Microsoft.VisualBasic
Imports System
Imports System.Web
Imports System.Web.UI.HtmlControls
' ...

Partial Public Class _Default
	Inherits System.Web.UI.Page

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		Dim r As New XtraReport1()
		Dim hf As HtmlInputHidden = CType(Me.Page.FindControl("Scale"), HtmlInputHidden)
		Dim scaleFactor As Single = 1
		If (Not String.IsNullOrEmpty(hf.Value)) Then
			scaleFactor = Convert.ToSingle(hf.Value) / 100f
		End If
		r.PaperKind = System.Drawing.Printing.PaperKind.Custom
		r.PageWidth = Convert.ToInt32(r.PageWidth * scaleFactor)
		r.PageHeight = Convert.ToInt32(r.PageHeight * scaleFactor)
		r.CreateDocument()
		r.PrintingSystem.Document.ScaleFactor = scaleFactor
		Me.ReportViewer1.Report = r
		Me.ReportViewer1.DataBind()
	End Sub
End Class
