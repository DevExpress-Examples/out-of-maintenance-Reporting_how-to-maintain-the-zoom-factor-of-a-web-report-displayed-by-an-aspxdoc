<!-- default file list -->
*Files to look at*:

* [XtraReport1.cs](./CS/App_Code/XtraReport1.cs) (VB: [XtraReport1.vb](./VB/App_Code/XtraReport1.vb))
* **[Default.aspx](./CS/Default.aspx) (VB: [Default.aspx](./VB/Default.aspx))**
* [Default.aspx.cs](./CS/Default.aspx.cs) (VB: [Default.aspx](./VB/Default.aspx))
<!-- default file list end -->
# How to maintain the zoom factor of a web report displayed by an ASPxDocumentViewer


<p>The document zoom factor of an <a href="http://documentation.devexpress.com/#XtraReports/CustomDocument5193"><u>ASPxDocumentViewer</u></a> is controlled by the <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressXtraPrintingDocument_ScaleFactortopic"><u>XtraReport.PrintingSystem.Document.ScaleFactor</u></a> property and depends on the <strong>ScaleFactor</strong> value saved into the <strong>HiddenField</strong>.</p><p>To manipulate the <strong>HiddenField</strong> value, use a custom editor added to the Document Viewer Toolbar (<strong>ReportToolbarComboBox</strong>).</p><p>Because the <strong>Document.ScaleFactor</strong> property value has no effect upon the actual document page size, it may be required to manually adjust the page size to match the current scale factor value.</p>

<br/>


