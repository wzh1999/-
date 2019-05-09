<%@ Page Title="" Language="C#" MasterPageFile="~/Login.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ZhongChouWebUI.Login1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="CSS/Login.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="center">
        <img src="images/3_06.png" />
        <div id="denglu">
            <h3>用户登录</h3>
            <div id="kuang">
                <br />
                <asp:Label ID="Label1" runat="server" Text="账号："></asp:Label>
                <asp:TextBox ID="txt_zhanghao" runat="server" Font-Size="Medium" ForeColor="Gray" OnLoad="txt_Accounts_Load"></asp:TextBox>
                <br />
                <asp:Label ID="Label2" runat="server" Text="密码："></asp:Label>
                <asp:TextBox ID="txt_mima" runat="server" TextMode="Password" Font-Size="Medium"></asp:TextBox>
                <br />
                <br />
                <div id="la">
                    <asp:Label ID="Label3" runat="server" Font-Size="Larger"></asp:Label>

                </div>
                <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/images/1-01.JPG" CssClass="btn_pic" OnClick="ImageButton1_Click" />
                <br />

                <br />


            </div>
            <div id="xl">
                <img src="images/3_09.png" />
                <div class="aa">
                    <a href="#" class="color">新浪微博</a><span>丨</span>
                </div>
            </div>
            <div id="tx">
                <img src="images/3_11.png" />
                <div class="aa">
                    <a href="#" class="color">腾讯微博</a> &nbsp;<a href="#" class="red">忘记密码？</a>
                </div>
            </div>
        </div>

    </div>


</asp:Content>
