Imports Microsoft.VisualBasic
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
	Private Detail As DevExpress.XtraReports.UI.DetailBand
	Private PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
	Private xrLabel1 As XRLabel
	Private xrPictureBox1 As XRPictureBox
	Private xrControlStyle1 As XRControlStyle
	Private xrControlStyle2 As XRControlStyle
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
	Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
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
		Dim resources As System.Resources.ResourceManager = Global.Resources.XtraReport1.ResourceManager
		Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
		Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
		Me.xrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
		Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
		Me.xrControlStyle1 = New DevExpress.XtraReports.UI.XRControlStyle()
		Me.xrControlStyle2 = New DevExpress.XtraReports.UI.XRControlStyle()
		CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
		' 
		' Detail
		' 
		Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel1})
		Me.Detail.EvenStyleName = "xrControlStyle1"
		Me.Detail.Height = 50
		Me.Detail.KeepTogether = True
		Me.Detail.Name = "Detail"
		Me.Detail.OddStyleName = "xrControlStyle2"
		Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
		Me.Detail.RepeatCountOnEmptyDataSource = 5
		Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
		' 
		' xrLabel1
		' 
		Me.xrLabel1.Location = New System.Drawing.Point(8, 0)
		Me.xrLabel1.Name = "xrLabel1"
		Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
		Me.xrLabel1.Size = New System.Drawing.Size(633, 50)
		Me.xrLabel1.Text = resources.GetString("xrLabel1.Text")
		' 
		' xrPictureBox1
		' 
		Me.xrPictureBox1.ImageUrl = "~\pix.png"
		Me.xrPictureBox1.Location = New System.Drawing.Point(508, 0)
		Me.xrPictureBox1.Name = "xrPictureBox1"
		Me.xrPictureBox1.Size = New System.Drawing.Size(133, 124)
		Me.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
		' 
		' PageHeader
		' 
		Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPictureBox1})
		Me.PageHeader.Height = 124
		Me.PageHeader.Name = "PageHeader"
		Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
		Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
		' 
		' xrControlStyle1
		' 
		Me.xrControlStyle1.BackColor = System.Drawing.Color.LightGoldenrodYellow
		Me.xrControlStyle1.Name = "xrControlStyle1"
		Me.xrControlStyle1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
		' 
		' xrControlStyle2
		' 
		Me.xrControlStyle2.BackColor = System.Drawing.Color.Transparent
		Me.xrControlStyle2.Name = "xrControlStyle2"
		Me.xrControlStyle2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
		' 
		' XtraReport1
		' 
		Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.PageHeader})
		Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() { Me.xrControlStyle1, Me.xrControlStyle2})
		Me.Version = "8.2"
		CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

	End Sub

	#End Region
End Class
