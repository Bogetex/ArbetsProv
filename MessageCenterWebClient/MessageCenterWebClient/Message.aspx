<%@ Page Title="Message" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Message.aspx.cs" Inherits="MessageCenterWebClient.Message"%>
<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            text-align: right;
        }
    </style>
</asp:Content>

<asp:Content ID="MainContent" runat="server" ContentPlaceHolderID="MainContent">
    <p>
        <asp:GridView ID="grdViewMessages" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Height="156px" Width="651px" AutoGenerateColumns="false">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775"></AlternatingRowStyle>

            <EditRowStyle BackColor="#999999"></EditRowStyle>

            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White"></FooterStyle>

            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White"></HeaderStyle>

            <PagerStyle HorizontalAlign="Center" BackColor="#284775" ForeColor="White"></PagerStyle>

            <RowStyle BackColor="#F7F6F3" ForeColor="#333333"></RowStyle>

            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333"></SelectedRowStyle>

            <SortedAscendingCellStyle BackColor="#E9E7E2"></SortedAscendingCellStyle>

            <SortedAscendingHeaderStyle BackColor="#506C8C"></SortedAscendingHeaderStyle>

            <SortedDescendingCellStyle BackColor="#FFFDF8"></SortedDescendingCellStyle>

            <SortedDescendingHeaderStyle BackColor="#6F8DAE"></SortedDescendingHeaderStyle>
            <Columns>
                <asp:BoundField HeaderText="MessageID" DataField="MessageID" />
                <asp:BoundField HeaderText="Message Body" DataField="MessageBody" />
                <asp:BoundField HeaderText="Time Stemp" DataField="MessageTime" />
            </Columns>
        </asp:GridView>
    </p>
</asp:Content>

