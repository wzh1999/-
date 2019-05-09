<%@ Page Title="" Language="C#" MasterPageFile="~/TopMaster.Master" AutoEventWireup="true" CodeBehind="over.aspx.cs" Inherits="ZhongChongWebUI.over" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="CSS/over.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div id="center">
        <div id="pic">
            <img src="images/head_over.gif" />
            <br />
        </div>
        <div id="mid">
            <div id="left">
                <asp:Label ID="Label1" runat="server" Text="恭喜你项目设置成功！" Font-Size="20px" ForeColor="#565656" CssClass="label_over"></asp:Label>
                <br />
                <br />
                <div id="pic_over">
                    <asp:Image ID="Image2" runat="server" ImageUrl="~/images/dui_over.jpg" />
                </div>
            </div>
            <div id="right">
                <asp:Label ID="Label2" runat="server" Text="请耐心等待审核....." Font-Size="20px" ForeColor="#808080"></asp:Label>
                <br />
                <br />
                <asp:Label ID="Label3" runat="server" Text="或者" Font-Size="20px" ForeColor="#808080"></asp:Label>
                <div id="button">
                    <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/images/btn_over.png" Height="50px" Width="150px" OnClick="ImageButton1_Click"/>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
