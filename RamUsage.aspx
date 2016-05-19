<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="RamUsage.aspx.cs" Inherits="RamUsage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style2 {
            height: 67px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:90%;">
        <tr style="border-style: solid; border-width: 1px">
            <td  class="auto-style2">
                <strong style="text-align: center; font-size:medium; color:blue">CURRENT RAM USAGE</strong>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Table id="tab1" style="width:100%; border-style: groove; border-width: 1px" runat="server" CellPadding="5">
                    <asp:TableRow>
                        <asp:TableCell >SAINS_SS</asp:TableCell>
                        <asp:TableCell >SSL03_PROD3</asp:TableCell>
                        <asp:TableCell >SSL04_PROD4</asp:TableCell>
                        <asp:TableCell >CVS01</asp:TableCell>
                        <asp:TableCell >CVS02</asp:TableCell>
                        <asp:TableCell >SOBEYS01</asp:TableCell>
                        <asp:TableCell >MADISON01</asp:TableCell>
                        <asp:TableCell >SPARTAN01</asp:TableCell>
                        <asp:TableCell >MIGROS01</asp:TableCell>
                        <asp:TableCell >SONAE01</asp:TableCell>
                        <asp:TableCell >AEON01</asp:TableCell>
                        <asp:TableCell >ICA01</asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow >
                        <asp:TableCell  ><asp:HyperLink Id="sains01" Runat="Server" NavigateUrl="~/Ramcharts.aspx?id=1"></asp:HyperLink> </asp:TableCell>
                        <asp:TableCell > <asp:HyperLink Id="sains02" Runat="Server" NavigateUrl="~/Ramcharts.aspx?id=2"></asp:HyperLink></asp:TableCell>
                        <asp:TableCell ><asp:HyperLink Id="sains03" Runat="Server" NavigateUrl="~/Ramcharts.aspx?id=3"></asp:HyperLink></asp:TableCell>
                        <asp:TableCell ><asp:HyperLink Id="cvs01" Runat="Server" NavigateUrl="~/Ramcharts.aspx?id=4" ></asp:HyperLink></asp:TableCell>
                        <asp:TableCell ><asp:HyperLink Id="cvs02" Runat="Server" NavigateUrl="~/Ramcharts.aspx?id=5" ></asp:HyperLink></asp:TableCell>
                        <asp:TableCell  ><asp:HyperLink Id="sobeys01" Runat="Server" NavigateUrl="~/Ramcharts.aspx?id=6" ></asp:HyperLink></asp:TableCell>
                        <asp:TableCell ><asp:HyperLink Id="madison01" Runat="Server" NavigateUrl="~/Ramcharts.aspx?id=7"></asp:HyperLink></asp:TableCell>
                        <asp:TableCell ><asp:HyperLink Id="spartan01" Runat="Server" NavigateUrl="~/Ramcharts.aspx?id=8"></asp:HyperLink></asp:TableCell>
                        <asp:TableCell ><asp:HyperLink Id="migros01" Runat="Server" NavigateUrl="~/Ramcharts.aspx?id=9"></asp:HyperLink></asp:TableCell>
                        <asp:TableCell ><asp:HyperLink Id="sonae01" Runat="Server" NavigateUrl="~/Ramcharts.aspx?id=10"></asp:HyperLink></asp:TableCell>
                        <asp:TableCell ><asp:HyperLink Id="aeon01" Runat="Server" NavigateUrl="~/Ramcharts.aspx?id=11" ></asp:HyperLink></asp:TableCell>
                        <asp:TableCell ><asp:HyperLink Id="ica01" Runat="Server" NavigateUrl="~/Ramcharts.aspx?id=12" ></asp:HyperLink></asp:TableCell>
                    </asp:TableRow>
                </asp:Table>
            </td>
        </tr>
    </table>
    <br />
    <table style="width:90%; border-style: solid; border-width: 2px">
        <tr>
            <td style="text-align: center">
                <strong style="text-align: center; font-size:larger">CURRENT DISK USAGE</strong>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Table id="tab2" style="width:100%; border-style: groove; border-width: 1px" runat="server" CellPadding="5">
     <asp:TableRow style="border-style: solid; border-width: 1px">
                    <asp:TableCell>SAINS_SS</asp:TableCell>
                    <asp:TableCell >SSL03_PROD3</asp:TableCell>
                    <asp:TableCell >SSL04_PROD4</asp:TableCell>
                    <asp:TableCell >CVS01</asp:TableCell>
                    <asp:TableCell >CVS02</asp:TableCell>
                    <asp:TableCell >SOBEYS01</asp:TableCell>
                    <asp:TableCell >MADISON01</asp:TableCell>
                    <asp:TableCell >SPARTAN01</asp:TableCell>
                    <asp:TableCell >MIGROS01</asp:TableCell>
                    <asp:TableCell >SONAE01</asp:TableCell>
                    <asp:TableCell >AEON01</asp:TableCell>
                    <asp:TableCell >ICA01</asp:TableCell>

                </asp:TableRow>
     <asp:TableRow style="border-style: solid; border-width: 1px">
            <asp:TableCell  style="border-style: solid; border-width: 2px; text-align: center" ><asp:HyperLink Id="sains01_d" Runat="Server" NavigateUrl="~/Diskusage.aspx?id=1"></asp:HyperLink> </asp:TableCell>
            <asp:TableCell style="border-style: solid; border-width: 2px; text-align: center"><asp:HyperLink Id="sains02_d" Runat="Server" NavigateUrl="~/Diskusage.aspx?id=2"></asp:HyperLink></asp:TableCell>
            <asp:TableCell style="border-style: solid; border-width: 2px; text-align: center"><asp:HyperLink Id="sains_d" Runat="Server" NavigateUrl="~/Diskusage.aspx?id=3" ></asp:HyperLink></asp:TableCell>
            <asp:TableCell style="border-style: solid; border-width: 2px; text-align: center"><asp:HyperLink Id="cvs01_d" Runat="Server" NavigateUrl="~/Diskusage.aspx?id=4" ></asp:HyperLink></asp:TableCell>
            <asp:TableCell style="border-style: solid; border-width: 2px; text-align: center"><asp:HyperLink Id="cvs02_d" Runat="Server" NavigateUrl="~/Diskusage.aspx?id=5" ></asp:HyperLink></asp:TableCell>
            <asp:TableCell style="border-style: solid; border-width: 2px; text-align: center" ><asp:HyperLink Id="sobeys01_d" Runat="Server" NavigateUrl="~/Diskusage.aspx?id=6" ></asp:HyperLink></asp:TableCell>
            <asp:TableCell style="border-style: solid; border-width: 2px; text-align: center"><asp:HyperLink Id="madison01_d" Runat="Server" NavigateUrl="~/Diskusage.aspx?id=7"></asp:HyperLink></asp:TableCell>
            <asp:TableCell style="border-style: solid; border-width: 2px; text-align: center"><asp:HyperLink Id="spartan01_d" Runat="Server" NavigateUrl="~/Diskusage.aspx?id=8"></asp:HyperLink></asp:TableCell>
            <asp:TableCell style="border-style: solid; border-width: 2px; text-align: center"><asp:HyperLink Id="migros01_d" Runat="Server" NavigateUrl="~/Diskusage.aspx?id=9"></asp:HyperLink></asp:TableCell>
            <asp:TableCell style="border-style: solid; border-width: 2px; text-align: center"><asp:HyperLink Id="sonae01_d" Runat="Server" NavigateUrl="~/Diskusage.aspx?id=10"></asp:HyperLink></asp:TableCell>
            <asp:TableCell style="border-style: solid; border-width: 2px; text-align: center"><asp:HyperLink Id="aeon01_d" Runat="Server" NavigateUrl="~/Diskusage.aspx?id=11" ></asp:HyperLink></asp:TableCell>
            <asp:TableCell style="border-style: solid; border-width: 2px; text-align: center"><asp:HyperLink Id="ica01_d" Runat="Server" NavigateUrl="~/Diskusage.aspx?id=12" ></asp:HyperLink></asp:TableCell>
            </asp:TableRow>
    </asp:Table>
            </td>
        </tr>
     </table>
    
</asp:Content>