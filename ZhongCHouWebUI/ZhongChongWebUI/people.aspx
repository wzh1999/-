<%@ Page Title="" Language="C#" MasterPageFile="~/TopMaster.Master" AutoEventWireup="true" CodeBehind="people.aspx.cs" Inherits="ZhongChongWebUI.people" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="CSS/people.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="center">
        <p id="pic">
            <img src="images/people.PNG" alt=""/>
        </p>
        <div id="mid">
            <h2>回报设置</h2>
            <hr />
            <div id="middle">
                <p>真实姓名: <asp:TextBox ID="TextBox1" runat="server" Width="200" Height="25"></asp:TextBox></p>
                <p>&nbsp;&nbsp; 所在地: <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem>湖北</asp:ListItem>
                    </asp:DropDownList>
                    <asp:DropDownList ID="DropDownList2" runat="server">
                        <asp:ListItem>武汉</asp:ListItem>
                    </asp:DropDownList>
                </p>
                    <p>移动电话: <asp:TextBox ID="TextBox2" runat="server" Width="200" Height="25"></asp:TextBox></p>
               <h2>补充打款信息</h2>
                <p>银行名称: <asp:TextBox ID="TextBox3" runat="server" Width="300" Height="25"></asp:TextBox></p>
                <p>开户支行: <asp:TextBox ID="TextBox4" runat="server" Width="300" Height="25"></asp:TextBox></p>
                <p>开户名称: <asp:TextBox ID="TextBox5" runat="server" Width="300" Height="25"></asp:TextBox></p>
                <p>银行账号: <asp:TextBox ID="TextBox6" runat="server" Width="300" Height="25"></asp:TextBox></p>
                <div id="bottom">
                    <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
                    <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/images/bt_syb.gif" OnClick="ImageButton1_Click" /><asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/images/bt_bccg.gif" OnClick="ImageButton2_Click" /><asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/images/bt_tjsh.gif" OnClick="ImageButton3_Click" />
                </div>
            </div>
        </div>
                <div id="light">
            <h3>温馨提示</h3>
            <hr />
                    <div id="light_x">
                        <asp:Label ID="Label1" runat="server" Text="请准确填写本页信息，确保项目成功后能快速并准确的为您打款。" Font-Size="Small" ForeColor="#CCCCCC"></asp:Label>
                    </div>
                   
        </div>
    </div>
</asp:Content>
