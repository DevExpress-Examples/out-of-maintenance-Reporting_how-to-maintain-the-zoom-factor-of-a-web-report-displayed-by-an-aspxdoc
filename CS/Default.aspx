<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Assembly="DevExpress.XtraReports.v13.2.Web, Version=13.2.15.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.XtraReports.Web" TagPrefix="dx" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
    <script type="text/javascript">
        function documentViewer_Init(sender, e) {
            var scaleFactorEditor = sender.GetToolbar().GetItemTemplateControl("ScaleFactor");
            scaleFactorEditor.SetValue("100");
        }

        function documentViewer_ToolbarItemValueChanged(sender, e) {
            document.getElementById('Scale').value = e.editor.GetValue();
            sender.Refresh();
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <dx:ASPxDocumentViewer ID="ASPxDocumentViewer1" runat="server">
            <ToolbarItems>
                <dx:ReportToolbarButton ItemKind="Search" />
                <dx:ReportToolbarSeparator />
                <dx:ReportToolbarButton ItemKind="PrintReport" />
                <dx:ReportToolbarButton ItemKind="PrintPage" />
                <dx:ReportToolbarSeparator />
                <dx:ReportToolbarButton Enabled="False" ItemKind="FirstPage" />
                <dx:ReportToolbarButton Enabled="False" ItemKind="PreviousPage" />
                <dx:ReportToolbarLabel ItemKind="PageLabel" />
                <dx:ReportToolbarComboBox ItemKind="PageNumber" Width="65px">
                </dx:ReportToolbarComboBox>
                <dx:ReportToolbarLabel ItemKind="OfLabel" />
                <dx:ReportToolbarTextBox ItemKind="PageCount" />
                <dx:ReportToolbarButton ItemKind="NextPage" />
                <dx:ReportToolbarButton ItemKind="LastPage" />
                <dx:ReportToolbarSeparator />
                <dx:ReportToolbarButton ItemKind="SaveToDisk" />
                <dx:ReportToolbarButton ItemKind="SaveToWindow" />
                <dx:ReportToolbarComboBox ItemKind="SaveFormat" Width="70px">
                    <Elements>
                        <dx:ListElement Value="pdf" />
                        <dx:ListElement Value="xls" />
                        <dx:ListElement Value="xlsx" />
                        <dx:ListElement Value="rtf" />
                        <dx:ListElement Value="mht" />
                        <dx:ListElement Value="html" />
                        <dx:ListElement Value="txt" />
                        <dx:ListElement Value="csv" />
                        <dx:ListElement Value="png" />
                    </Elements>
                </dx:ReportToolbarComboBox>
                <dx:ReportToolbarSeparator />
                <dx:ReportToolbarLabel Text="Zoom Factor" />
                <dx:ReportToolbarComboBox Name="ScaleFactor" Width="60px">
                    <Elements>
                        <dx:ListElement Text="50%" Value="50" />
                        <dx:ListElement Text="75%" Value="75" />
                        <dx:ListElement Text="100%" Value="100" />
                        <dx:ListElement Text="200%" Value="200" />
                        <dx:ListElement Text="250%" Value="250" />
                    </Elements>
                </dx:ReportToolbarComboBox>
            </ToolbarItems>
            <ClientSideEvents Init="documentViewer_Init" ToolbarItemValueChanged="documentViewer_ToolbarItemValueChanged" />
        </dx:ASPxDocumentViewer>
        <input id="Scale" runat="server" type="hidden" />
    </div>
    </form>
</body>
</html>
