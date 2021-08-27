<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1301)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [XtraReport1.cs](./CS/WebSite/App_Code/XtraReport1.cs) (VB: [XtraReport1.vb](./VB/WebSite/App_Code/XtraReport1.vb))
* [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))
<!-- default file list end -->
# How to maintain the zoom factor of a web report displayed by an ASPxDocumentViewer
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e1301/)**
<!-- run online end -->


<p>The document zoom factor of an <a href="http://documentation.devexpress.com/#XtraReports/CustomDocument5193"><u>ASPxDocumentViewer</u></a> is controlled by the <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressXtraPrintingDocument_ScaleFactortopic"><u>XtraReport.PrintingSystem.Document.ScaleFactor</u></a> property and depends on the <strong>ScaleFactor</strong> value saved into the <strong>HiddenField</strong>.</p><p>To manipulate the <strong>HiddenField</strong> value, use a custom editor added to the Document Viewer Toolbar (<strong>ReportToolbarComboBox</strong>).</p><p>Because the <strong>Document.ScaleFactor</strong> property value has no effect upon the actual document page size, it may be required to manually adjust the page size to match the current scale factor value.</p>

<br/>


