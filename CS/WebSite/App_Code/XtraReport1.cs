using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

/// <summary>
/// Summary description for XtraReport1
/// </summary>
public class XtraReport1 : DevExpress.XtraReports.UI.XtraReport
{
	private DevExpress.XtraReports.UI.DetailBand Detail;
    private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
    private XRLabel xrLabel1;
    private XRPictureBox xrPictureBox1;
    private XRControlStyle xrControlStyle1;
    private XRControlStyle xrControlStyle2;
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
        System.Resources.ResourceManager resources = global::Resources.XtraReport1.ResourceManager;
        this.Detail = new DevExpress.XtraReports.UI.DetailBand();
        this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
        this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
        this.xrControlStyle1 = new DevExpress.XtraReports.UI.XRControlStyle();
        this.xrControlStyle2 = new DevExpress.XtraReports.UI.XRControlStyle();
        ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
        // 
        // Detail
        // 
        this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1});
        this.Detail.EvenStyleName = "xrControlStyle1";
        this.Detail.Height = 50;
        this.Detail.KeepTogether = true;
        this.Detail.Name = "Detail";
        this.Detail.OddStyleName = "xrControlStyle2";
        this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
        this.DetailPrintCountOnEmptyDataSource = 5;
        this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        // 
        // xrLabel1
        // 
        this.xrLabel1.Location = new System.Drawing.Point(8, 0);
        this.xrLabel1.Name = "xrLabel1";
        this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel1.Size = new System.Drawing.Size(633, 50);
        this.xrLabel1.Text = resources.GetString("xrLabel1.Text");
        // 
        // xrPictureBox1
        // 
        this.xrPictureBox1.ImageUrl = "~\\pix.png";
        this.xrPictureBox1.Location = new System.Drawing.Point(508, 0);
        this.xrPictureBox1.Name = "xrPictureBox1";
        this.xrPictureBox1.Size = new System.Drawing.Size(133, 124);
        this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage;
        // 
        // PageHeader
        // 
        this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPictureBox1});
        this.PageHeader.Height = 124;
        this.PageHeader.Name = "PageHeader";
        this.PageHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
        this.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        // 
        // xrControlStyle1
        // 
        this.xrControlStyle1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
        this.xrControlStyle1.Name = "xrControlStyle1";
        this.xrControlStyle1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
        // 
        // xrControlStyle2
        // 
        this.xrControlStyle2.BackColor = System.Drawing.Color.Transparent;
        this.xrControlStyle2.Name = "xrControlStyle2";
        this.xrControlStyle2.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
        // 
        // XtraReport1
        // 
        this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.PageHeader});
        this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.xrControlStyle1,
            this.xrControlStyle2});
        this.Version = "8.2";
        ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

	}

	#endregion
}
