using System;
using System.Web;
using System.Web.UI.HtmlControls;
using System.Drawing.Printing;
using DevExpress.XtraReports.UI;
// ...

public partial class _Default : System.Web.UI.Page {

    protected bool IsReportPrinted() {
        return (((Request.Params["__EVENTTARGET"] == ASPxDocumentViewer1.UniqueID) && Request.Params["__EVENTARGUMENT"].Contains("showPrintDialog:true")) ||
                ((Request.Params["__CALLBACKID"] == ASPxDocumentViewer1.UniqueID) && Request.Params["__CALLBACKPARAM"].Contains("print=idx")));
    }

    private void ScaleReportDocument(XtraReport report, float scaleFactor) {
        Margins newMargins = new Margins(Convert.ToInt32(report.Margins.Left * scaleFactor), Convert.ToInt32(report.Margins.Right * scaleFactor), Convert.ToInt32(report.Margins.Top * scaleFactor), Convert.ToInt32(report.Margins.Bottom * scaleFactor));
        report.PaperKind = System.Drawing.Printing.PaperKind.Custom;
        report.PageWidth = (int)(report.PageWidth * scaleFactor);
        report.PageHeight = (int)(report.PageHeight * scaleFactor);
        report.Margins = newMargins;
        report.CreateDocument();

        report.PrintingSystem.Document.ScaleFactor = scaleFactor;
    }

    protected void Page_Load(object sender, EventArgs e) {
        XtraReport report = new XtraReport1();        
        if (!IsReportPrinted() && !String.IsNullOrEmpty(Request["Scale"])) {
            
            float scaleFactor = Convert.ToSingle(Request["Scale"]) / 100f;

            ScaleReportDocument(report, scaleFactor);
        }
        ASPxDocumentViewer1.Report = report;
    }
}
