<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Diskusage.aspx.cs" Inherits="Diskusage" %>






 
   
<asp:Content ID="Content1" runat="server" contentplaceholderid="ContentPlaceHolder1">
    
                
        <div style="float:left; width:60%;">
    
         <asp:Table runat="server" Height="16px" style="margin-left: 23px" Width="353px" >
                <asp:TableRow>
                
          <asp:TableCell>
            <asp:Label Id="Label1" runat="server" style="text-align:inherit;  text-shadow:2px 2px 4px #C0C0C0; color: #0000FF; font-family: Cambria, Cochin, Georgia, Times, 'Times New Roman', serif; font-style: italic; font-size:small; font-weight: 900; border-right-color: #C0C0C0;"></asp:Label></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell><asp:Label Id="Label2" runat="server" style="text-align:inherit;  text-shadow:2px 2px 4px #C0C0C0; color: #0000FF; font-family: Cambria, Cochin, Georgia, Times, 'Times New Roman', serif; font-style: italic; font-size:small; font-weight: 900; border-right-color: #C0C0C0;"></asp:Label></asp:TableCell>
                </asp:TableRow>
               
      </asp:Table>
        

        <asp:Chart ID="Chart1" runat="server" Height="726px" Width="797px" style="margin-right: 115px; margin-top: 0px;">
          
            <Series>
                <asp:Series Name="Series1">
                </asp:Series>

            </Series>
           
            <ChartAreas>
                <asp:ChartArea Name="ChartArea1">
                   
                </asp:ChartArea>
            </ChartAreas>
        </asp:Chart>
        
           
    
            </div>
    
    <div style="float:right; width:40%; height: 773px;">
        <h1 runat="server" style="text-align:inherit;  text-shadow:2px 2px 4px #C0C0C0; color: #0000FF; font-family: Cambria, Cochin, Georgia, Times, 'Times New Roman', serif; font-style: normal; font-size:small; font-weight: 900; border-right-color: #C0C0C0;">Slab Grouping Information:</h1>
        <asp:gridview id="gridview1" runat="server" Height="79px" Width="375px" style="margin-left: 0px; margin-bottom: 28px;" CellPadding="1" ForeColor="#333333" GridLines="Both" Font-Size="X-Small" BorderStyle="Groove" >
            <AlternatingRowStyle BackColor="WhiteSmoke" />
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White"/>
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1"/>
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
               </asp:gridview>
      </div>
     </asp:Content>








 
   
