Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI

''' <summary>
''' Summary description for XtraReport1
''' </summary>
Public Class XtraReport1
    Inherits DevExpress.XtraReports.UI.XtraReport

    Private TopMargin As TopMarginBand
    Private PageFooter As PageFooterBand
    Private lbText As XRLabel
    Private BottomMargin As BottomMarginBand
    Private Detail As DetailBand
    Private PageHeader As PageHeaderBand
    Private xrCrossBandBox1 As XRCrossBandBox
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    Public Sub New()
        InitializeComponent()
        '
        ' TODO: Add constructor logic here
        '
    End Sub

    ''' <summary> 
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    #Region "Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
            Dim resourceFileName As String = "XtraReport1.resx"
            Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
            Me.lbText = New DevExpress.XtraReports.UI.XRLabel()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
            Me.xrCrossBandBox1 = New DevExpress.XtraReports.UI.XRCrossBandBox()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' TopMargin
            ' 
            Me.TopMargin.Name = "TopMargin"
            Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' PageFooter
            ' 
            Me.PageFooter.HeightF = 2F
            Me.PageFooter.Name = "PageFooter"
            ' 
            ' lbText
            ' 
            Me.lbText.Font = New System.Drawing.Font("Times New Roman", 48F)
            Me.lbText.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 10.00001F)
            Me.lbText.Name = "lbText"
            Me.lbText.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.lbText.SizeF = New System.Drawing.SizeF(630F, 79.99999F)
            Me.lbText.StylePriority.UseFont = False
            Me.lbText.StylePriority.UseTextAlignment = False
            Me.lbText.Text = "Sample Report"
            Me.lbText.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.Name = "BottomMargin"
            Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.lbText})
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' PageHeader
            ' 
            Me.PageHeader.HeightF = 2F
            Me.PageHeader.Name = "PageHeader"
            ' 
            ' xrCrossBandBox1
            ' 
            Me.xrCrossBandBox1.BorderWidth = 2F
            Me.xrCrossBandBox1.EndBand = Me.PageFooter
            Me.xrCrossBandBox1.EndPointFloat = New DevExpress.Utils.PointFloat(2F, 2F)
            Me.xrCrossBandBox1.LocationFloat = New DevExpress.Utils.PointFloat(2F, 0F)
            Me.xrCrossBandBox1.Name = "xrCrossBandBox1"
            Me.xrCrossBandBox1.StartBand = Me.PageHeader
            Me.xrCrossBandBox1.StartPointFloat = New DevExpress.Utils.PointFloat(2F, 0F)
            Me.xrCrossBandBox1.WidthF = 648F
            ' 
            ' XtraReport1
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin, Me.PageHeader, Me.PageFooter})
            Me.CrossBandControls.AddRange(New DevExpress.XtraReports.UI.XRCrossBandControl() { Me.xrCrossBandBox1})
            Me.Version = "15.1"
            DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    #End Region
End Class
