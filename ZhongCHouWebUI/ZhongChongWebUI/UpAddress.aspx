<%@ Page Title="" Language="C#" MasterPageFile="~/TopMaster.Master" AutoEventWireup="true" CodeBehind="UpAddress.aspx.cs" Inherits="ZhongChongWebUI.UpAddress" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="CSS/PersonalSet.css" rel="stylesheet" />
    <style type="text/css">
        .current {
            background-color: #ffffff;
        }
    </style>
    <script src="js/jquery-1.11.0.min.js"></script>
    <script type="text/javascript">
        $(function () {
            //鼠标移动到li上更改样式
            $("#had_lb li").hover(function () {
                $(this).addClass("current");
            }, function () {
                $(this).removeClass("current");
            });

            $(document).keypress(function () {
                if (event.keyCode == 27) {
                    window.close();
                }
            })
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <div id="herbody">
        <div id="shebody">
            <div id="top_body">
                <h2>个人设置</h2>
                <div id="fanhui"><a href="ItemManage.aspx">返回个人中心</a></div>
            </div>
            <div id="had_lb">
                <ul>
                    <li><a href="PersonalSet.aspx#usersman">资料修改</a></li>
                    <li><a href="PersonalSet.aspx#userspwd">密码修改</a></li>
                    <li><a href="UpPic.aspx">头像修改</a></li>
                    <li><a href="UpAddress.aspx">收件地址管理</a></li>
                    <li><a href="PersonalSet.aspx#usersgos" aria-autocomplete="none">我的优惠券</a></li>
                </ul>
            </div>
            <div id="had_lr">
                <div id="box">
                     <%--收件地址--%>
                    <div id="usersase">
                        <div class="daers">
                            <br />
                            <h3 style="color: #ff6161;">收件地址管理</h3>
                            <p>可添加管理多个收件地址，以便收取回报时使用</p>
                            <p style="text-align: right;">
                            </p>
                            <hr style="width: 750px; margin-bottom: 15px;" />
                            <p>
                                <label>收件人：</label><asp:TextBox ID="Receiving_Name" runat="server" class="txt" Height="25px"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="Rece" runat="server" ErrorMessage="收件人必填" EnableClientScript="True" ControlToValidate="Receiving_Name"></asp:RequiredFieldValidator>
                            </p>
                            <p>
                                <label>手机：</label><asp:TextBox ID="Receiving_Phone" runat="server" class="txt" Height="25px"></asp:TextBox>
                                 <asp:RequiredFieldValidator ID="phone" runat="server" ErrorMessage="手机号必填" EnableClientScript="True" ControlToValidate="Receiving_Phone"></asp:RequiredFieldValidator>
                            </p>
                            <p>
                                <label>所在地：</label><asp:DropDownList ID="ddlProvince" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlProvince_SelectedIndexChanged1"></asp:DropDownList>
                                <asp:DropDownList ID="ddlCity" runat="server"></asp:DropDownList>
                            </p>
                            <p>
                                <label>详细地址：</label><asp:TextBox ID="Detailed_address" runat="server" class="txt" Height="25px" Width="180px"></asp:TextBox>
                                 <asp:RequiredFieldValidator ID="address" runat="server" ErrorMessage="详细地址必填" EnableClientScript="True" ControlToValidate="Detailed_address"></asp:RequiredFieldValidator>
                            </p>
                            <p>
                                <label>邮编：</label><asp:TextBox ID="Zip_code" runat="server" class="txt" Height="25px"></asp:TextBox>
                                 <asp:RequiredFieldValidator ID="zip" runat="server" ErrorMessage="邮编必填" EnableClientScript="True" ControlToValidate="Zip_code"></asp:RequiredFieldValidator>
                            </p>
                            <asp:Button ID="Button1" runat="server" Style="margin-left: 80px;" Text="保存" OnClick="Unnamed2_Click" BackColor="#F45F5B" BorderStyle="Outset" ForeColor="White" Height="35px" Width="65px" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>