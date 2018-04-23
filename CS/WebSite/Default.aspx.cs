using System;
using System.Web;
using System.Web.UI.HtmlControls;
// ...

public partial class _Default : System.Web.UI.Page {

    protected void Page_Load(object sender, EventArgs e) {
        XtraReport1 r = new XtraReport1();
        HtmlInputHidden hf = (HtmlInputHidden)this.Page.FindControl("Scale");
        float scaleFactor = 1;
        if (!string.IsNullOrEmpty(hf.Value))
            scaleFactor = Convert.ToSingle(hf.Value) / 100f;
        r.PaperKind = System.Drawing.Printing.PaperKind.Custom;
        r.PageWidth = Convert.ToInt32(r.PageWidth * scaleFactor);
        r.PageHeight = Convert.ToInt32(r.PageHeight * scaleFactor);
        r.CreateDocument();
        r.PrintingSystem.Document.ScaleFactor = scaleFactor;
        this.ReportViewer1.Report = r;
        this.ReportViewer1.DataBind();
    }
}
