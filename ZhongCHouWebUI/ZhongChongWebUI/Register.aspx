<%@ Page Title="" Language="C#" MasterPageFile="~/Register.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="ZhongChouWebUI.Register1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="CSS/Register.css" rel="stylesheet" />
    <script type="text/javascript" src="Scripts/gVerify.js"></script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="center">
        <img src="images/3_06.png" alt="" />
        <div id="denglu">
            <h2>用户注册</h2>
            <table>
                <tr>
                    <td class="nameClass">用户名：</td>
                    <td>
                        <asp:TextBox ID="txt_accounts" runat="server" Font-Size="Larger"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*用户名不能为空！" ControlToValidate="txt_accounts" Text="*用户名不能为空！"></asp:RequiredFieldValidator>
                    </td>
                </tr>

                <tr>
                    <td class="nameClass">密码：</td>
                    <td>
                        <asp:TextBox ID="txt_pwd" runat="server" TextMode="Password" Font-Size="Larger" ControlToValidate="txt_pwd" ControlToCompare="txt_pwd"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*密码不能为空！" ControlToValidate="txt_pwd">*密码不能为空！</asp:RequiredFieldValidator>
                    </td>
                </tr>

                <tr>
                    <td class="nameClass">确认密码：</td>
                    <td>
                        <asp:TextBox ID="txt_repwd" runat="server" TextMode="Password" Font-Size="Larger" ControlToValidate="txt_repwd"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="*确认密码不能为空" Display="Dynamic" Text="*确认密码不能为空" ControlToValidate="txt_repwd"></asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="*两次密码不一致！" ControlToCompare="txt_pwd" ControlToValidate="txt_repwd" Text="*两次密码不一致！" Display="Dynamic"></asp:CompareValidator>
                    </td>
                </tr>

                <tr>
                    <td class="nameClass">邮箱：</td>
                    <td>
                        <asp:TextBox ID="txt_youxiang" runat="server" Font-Size="Larger"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txt_youxiang" ErrorMessage="*邮箱不能为空！" ForeColor="Red" Display="Dynamic">*邮箱不能为空！</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="邮箱格式不正确！" ControlToValidate="txt_youxiang" ValidationExpression="^[a-zA-Z0-9_-]+@[a-zA-Z0-9_-]+(\.[a-zA-Z0-9_-]+)+$">邮箱格式不正确！</asp:RegularExpressionValidator>
                    </td>
                </tr>

                <tr>
                    <td class="nameClass">验证码：</td>
                    <td style="width: 100px; height: 30px;">
                        <asp:TextBox ID="TextBox1" runat="server" Style="width: 100px; height: 30px; margin-left: -20px;"></asp:TextBox>
                        <asp:Button ID="Button1" runat="server" Text="获取" OnClick="Button1_Click" Style="width: 100px; height: 40px;" />
                    </td>

                </tr>

            </table>

            <div id="xieyi">
                <asp:CheckBox ID="check" runat="server" Checked="True" />&nbsp;阅读并同意众筹网的<a href="#">《服务协议》</a>
            </div>

            <div id="la">
                <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            </div>
            <div id="imgs">
                <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/images/red_ljzc.gif" Height="35px" Width="240px" OnClick="ImageButton1_Click" />
            </div>
            <div id="xl">
                <img src="images/3_09.png" alt="" />
                <div class="aa">
                    <a href="#" class="color">新浪微博</a><span>丨</span>
                </div>
            </div>
            <div id="tx">
                <img src="images/3_11.png" alt="" />
                <div class="aa">
                    <a href="#" class="color">腾讯微博</a>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
