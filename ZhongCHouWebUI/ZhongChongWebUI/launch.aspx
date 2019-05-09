<%@ Page Title="" Language="C#" MasterPageFile="~/TopMaster.Master" AutoEventWireup="true" CodeBehind="launch.aspx.cs" Inherits="ZhongChongWebUI.launch" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="CSS/launch.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="conect">
        <div id="kuang">
            <h2>发起项目</h2>
            <hr />
            <div id="img">
                <img src="images/tree.gif" />
            </div>
            <div id="white">
                <p id="w1"><b>如果你有一颗<span>真诚的心</span></b></p>
                <p id="w2"><b>那么请在这里发起<span>你的梦想</span></b></p>
                <p id="w3"><a>众筹网是一家可以帮助您实现梦想的网站，在这里您可以发布您的梦想，创意和创业计划，并通过网络平台面对公众筹集，
                    让有创造力的人可能获得他们所需要的资金，以便使他们的梦想有可能实现。</a></p>
                <p id="w4">
                    <asp:CheckBox ID="CheckBox1" runat="server" />
                    <a class="q1">阅读并同意众筹网的</a><a class="q2" href="#">《服务协议》&nbsp《众筹公告》</a> </p>
                <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/images/logo_fqxm.gif" OnClick="ImageButton1_Click" />
            </div>
        </div>

    </div>
</asp:Content>

