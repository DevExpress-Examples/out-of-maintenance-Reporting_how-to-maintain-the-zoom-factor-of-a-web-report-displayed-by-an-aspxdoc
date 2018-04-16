using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

/// <summary>
/// Summary description for XtraReport1
/// </summary>
public class XtraReport1 : DevExpress.XtraReports.UI.XtraReport {
    private TopMarginBand TopMargin;
    private PageFooterBand PageFooter;
    private XRLabel lbText;
    private BottomMarginBand BottomMargin;
    private DetailBand Detail;
    private PageHeaderBand PageHeader;
    private XRCrossBandBox xrCrossBandBox1;
	/// <summary>
	/// Required designer variable.
	/// </summary>
	private System.ComponentModel.IContainer components = null;

	public XtraReport1()
	{
		InitializeComponent();
		//
		// TODO: Add constructor logic here
		//
	}
	
	/// <summary> 
	/// Clean up any resources being used.
	/// </summary>
	/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	protected override void Dispose(bool disposing) {
		if (disposing && (components != null)) {
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	#region Designer generated code

	/// <summary>
	/// Required method for Designer support - do not modify
	/// the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent() {
            string resourceFileName = "XtraReport1.resx";
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.lbText = new DevExpress.XtraReports.UI.XRLabel();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrCrossBandBox1 = new DevExpress.XtraReports.UI.XRCrossBandBox();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // PageFooter
            // 
            this.PageFooter.HeightF = 2F;
            this.PageFooter.Name = "PageFooter";
            // 
            // lbText
            // 
            this.lbText.Font = new System.Drawing.Font("Times New Roman", 48F);
            this.lbText.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 10.00001F);
            this.lbText.Name = "lbText";
            this.lbText.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbText.SizeF = new System.Drawing.SizeF(630F, 79.99999F);
            this.lbText.StylePriority.UseFont = false;
            this.lbText.StylePriority.UseTextAlignment = false;
            this.lbText.Text = "Sample Report";
            this.lbText.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lbText});
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // PageHeader
            // 
            this.PageHeader.HeightF = 2F;
            this.PageHeader.Name = "PageHeader";
            // 
            // xrCrossBandBox1
            // 
            this.xrCrossBandBox1.BorderWidth = 2F;
            this.xrCrossBandBox1.EndBand = this.PageFooter;
            this.xrCrossBandBox1.EndPointFloat = new DevExpress.Utils.PointFloat(2F, 2F);
            this.xrCrossBandBox1.LocationFloat = new DevExpress.Utils.PointFloat(2F, 0F);
            this.xrCrossBandBox1.Name = "xrCrossBandBox1";
            this.xrCrossBandBox1.StartBand = this.PageHeader;
            this.xrCrossBandBox1.StartPointFloat = new DevExpress.Utils.PointFloat(2F, 0F);
            this.xrCrossBandBox1.WidthF = 648F;
            // 
            // XtraReport1
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.PageHeader,
            this.PageFooter});
            this.CrossBandControls.AddRange(new DevExpress.XtraReports.UI.XRCrossBandControl[] {
            this.xrCrossBandBox1});
            this.Version = "15.1";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

	}

	#endregion
}
