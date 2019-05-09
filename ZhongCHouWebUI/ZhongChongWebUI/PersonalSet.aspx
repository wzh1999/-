<%@ Page Title="" Language="C#" MasterPageFile="~/TopMaster.Master" AutoEventWireup="true" CodeBehind="PersonalSet.aspx.cs" Inherits="ZhongChouWebUI.PersonalSet" %>
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
                    <li><a href="#usersman">资料修改</a></li>
                    <li><a href="#userspwd">密码修改</a></li>
                    <li><a href="UpPic.aspx">头像修改</a></li>
                    <li><a href="UpAddress.aspx">收件地址管理</a></li>
                    <li><a href="#usersgos" aria-autocomplete="none">我的优惠券</a></li>
                </ul>
            </div>
            <div id="had_lr">
                <div id="box">
                    <%--修改个人信息--%>
                    <div id="usersman">
                        <br />
                        <br />
                        <p>
                            <label style="color: #ee5f5b">手机：</label><asp:Label ID="Phone" runat="server" Text="" Style="color: #ee5f5b"></asp:Label>
                        </p>
                        <p>
                            <label style="color: #ee5f5b">用户名：</label><asp:TextBox ID="UserName" class="txt" runat="server" Height="25px"></asp:TextBox>

                        </p>
                        <p>
                            <label>性别：</label>
                            <asp:RadioButton ID="RadioButton1" runat="server" GroupName="Sex" />男
                            <asp:RadioButton ID="RadioButton2" runat="server" GroupName="Sex" />女
                        </p>
                        <p>
                            <label>所在地：</label><asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
                            <asp:DropDownList ID="DropDownList2" runat="server"></asp:DropDownList>
                        </p>
                        <p>
                            <label>网址：</label><asp:TextBox ID="URL" class="txt" runat="server" Height="25px"></asp:TextBox>
                        </p>
                        <p>
                            <label>个人说明：</label><asp:TextBox ID="Personal_note" class="txt" runat="server" Height="83px" TextMode="MultiLine" Width="228px"></asp:TextBox>
                        </p>
                        <p>
                            <asp:Button runat="server" Style="margin-left: 80px;" Text="保存" OnClick="Unnamed1_Click" BackColor="#F45F5B" BorderStyle="Outset" ForeColor="White" Height="35px" Width="65px" />
                        </p>
                    </div>

                    <%--修改密码--%>
                    <div id="userspwd">
                        <div class="daers">
                            <br />
                            <br />
                           <p>
                                <label>手机：</label><asp:TextBox ID="rdPhone" runat="server" class="txt" Height="25px"></asp:TextBox><asp:RequiredFieldValidator ID="Reqphone" runat="server" ErrorMessage="手机号必填" EnableClientScript="True" ControlToValidate="rdPhone"></asp:RequiredFieldValidator>
                            </p>
                            <p>
                                <label>修改密码：</label><asp:TextBox ID="PWD" runat="server" class="txt" Height="25px" TextMode="Password"></asp:TextBox><asp:RequiredFieldValidator ID="Reqpwd" runat="server" ErrorMessage="密码必填" EnableClientScript="True" ControlToValidate="PWD"></asp:RequiredFieldValidator>
                            </p>
                            <p>
                                <label>确认密码：</label><asp:TextBox ID="rdPWD" runat="server" class="txt" Height="25px" TextMode="Password"></asp:TextBox><asp:CompareValidator ID="Compwd" runat="server" ErrorMessage="两次输入密码不一致" ControlToValidate="rdPWD" ControlToCompare="PWD"></asp:CompareValidator>
                            </p>
                            <asp:Button runat="server" Style="margin-left: 80px;" Text="保存" OnClick="Unnamed4_Click" BackColor="#F45F5B" BorderStyle="Outset" ForeColor="White" Height="35px" Width="65px" />
                        </div>
                    </div>
                    <%--我的优惠--%>
                    <div id="usersgos">
                        <br />
                        <br />
                        <h1>此功能暂未开放，请等候。。。</h1>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
