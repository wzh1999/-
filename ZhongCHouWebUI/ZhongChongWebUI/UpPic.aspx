<%@ Page Title="" Language="C#" MasterPageFile="~/TopMaster.Master" AutoEventWireup="true" CodeBehind="UpPic.aspx.cs" Inherits="ZhongChongWebUI.UpPic" %>
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
                    <%--修改头像--%>
                    <div id="userstop">
                        <br />
                        <br />
                        <div id="left">
                            <asp:FileUpload ID="FileUpload1" runat="server" />
                            <asp:Button ID="btnchuan" runat="server" Text="修改头像" Width="65px" Height="26px" OnClick="btnchuan_Click" />
                            <asp:Label ID="lblhide" runat="server" Text=""></asp:Label>
                            <br />
                            <asp:Image ID="Image1" runat="server" Style="margin: 30px; margin-top: 20px; height: 180px; width: 170px;" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
