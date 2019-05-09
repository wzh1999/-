<%@ Page Title="" Language="C#" MasterPageFile="~/TopMaster.Master" AutoEventWireup="true" CodeBehind="ItemManage.aspx.cs" Inherits="ZhongChouWebUI.ItemManage" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        #top_xia a {
            text-decoration: none;
            color: #fff;
        }

        #us_body {
            overflow: hidden;
            width: 1300px;
            background-color: #F8F8F8;
            padding: 10px 0px;
            margin: 0px auto;
        }

        #hd_body {
            width: 1000px;
            overflow: hidden;
            margin: 0px auto;
            background-color: #F8F8F8;
        }

        #top_body {
            background-color: #F8F8F8;
            overflow: hidden;
        }

        #top_shang {
            margin: 20px 5px;
        }

        #top_body #top_shang {
            overflow: hidden;
            background-color: #F8F8F8;
            border-bottom: 1px solid #e6e6e6;
        }

            #top_body #top_shang #top_images {
                text-align: center;
                border: 1px solid #ededed;
                float: left;
                width: 180px;
                height: 155px;
            }

        .auto-style1 {
            width: 185px;
            height: 150px;
        }

        #top_body #top_shang #top_users {
            margin-left: 20px;
            width: 785px;
            float: left;
            background-color: #F8F8F8;
        }

        #top_users p {
            margin-bottom: 20px;
            height: 20px;
            line-height: 20px;
        }

        #top_body #top_xia {
            height: 40px;
            overflow: hidden;
            background-color: #c2c2c2;
        }

        #top_xia ul li {
            list-style-type: none;
            float: left;
            width: 331px;
            height: 40px;
            line-height: 40px;
            text-align: center;
            border: 1px solid #e6e6e6;
            font-size: 19px;
        }

        #end_body {
            background-color: #ffffff;
            overflow: hidden;
            height: 460px;
            text-align: center;
            margin: auto;
        }

        #end_body {
            height: 660px;
            width: 1000px;
            text-align: center;
            margin: auto;
        }

        #zhic table {
            height: 600px;
            width: 1000px;
            text-align: center;
            margin: auto;
        }

        table {
            background-color: #fff0bd;
            border-collapse: collapse;
        }

        .current {
            background-color: #EE5F59;
        }
    </style>
    <script src="JS/jquery-1.11.0.min.js"></script>
    <script type="text/javascript">
        $(function () {
            //鼠标移动到li上更改样式
            $("#top_xia li").hover(function () {
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
    <div id="us_body">
        <div id="hd_body">
            <div id="top_body">
                <div id="top_shang">
                    <div id="top_images">
                        <asp:Image ID="Head_portrait" runat="server" Width="180px" Height="180px" />
                    </div>
                    <div id="top_users">
                        <p>
                            <asp:Label ID="UserName" runat="server" Text="众人拾柴" Font-Size="16"></asp:Label>
                            &nbsp;&nbsp; <a href="PersonalSet.aspx">
                                <img src="images/h_grsz.gif" /></a>&nbsp; <a href="#">
                                    <img src="images/h_xxzx.gif" /></a>
                        </p>
                        <p>
                            <asp:Label ID="Personal_note" runat="server" Text="他很忙"></asp:Label>
                        </p>
                        <p>
                            <asp:Label ID="Label5" runat="server" Text="加入时间："></asp:Label>
                            <asp:Label ID="Registration_time" runat="server" Text="2019/03/21"></asp:Label>
                        </p>
                        <p>
                            <asp:Label ID="Label6" runat="server" Text="所在地区："></asp:Label>
                            <asp:Label ID="Province_City" runat="server" Text="湖南"></asp:Label>
                        </p>
                    </div>
                </div>
                <div id="top_xia">
                    <ul>
                        <li><a href="ItemManage.aspx?Investment_state=支持的">支持的项目</a></li>
                        <li><a href="ItemManage.aspx?Investment_state=发起的">发起的项目</a></li>
                        <li><a href="ItemManage.aspx?Investment_state=喜欢的">喜欢的项目</a></li>
                    </ul>
                </div>
            </div>
            <div id="end_body">
                <div id="zhic">
                    <asp:Repeater ID="rpProductInfo" runat="server" OnItemCommand="rp_zixun_ItemCommand">
                        <HeaderTemplate>
                            <table>
                                <tr>
                                    <th>项目编号</th>
                                    <th>项目图片</th>
                                    <th>项目名称</th>
                                    <th>发起时间</th>
                                    <th>结束时间</th>
                                    <th>目标金额</th>
                                    <th>筹集金额</th>
                                    <th>项目状态</th>
                                    <th>操作</th>
                                </tr>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <tr>
                                <td><%# Eval("ProjectID") %></td>
                                <td>
                                    <asp:Image ID="Image1" runat="server" ImageUrl='<%# "~/images/"+Eval("Project_cover") %>' Height="123" /></td>
                                <td><%# Eval("Project_Name") %></td>
                                <td><%# Eval("Release_date") %> </td>
                                <td><%# Eval("Closing_date") %> </td>
                                <td><%# Eval("Project_Money") %></td>
                                <td><%# Eval("Raised_amount") %></td>
                                <td><%# Eval("Project_state") %></td>
                                <td>
         <%--                           <asp:LinkButton ID="LinkButton1" CommandArgument='<%# Eval("ProjectID") %>' CommandName="bianj" runat="server" Font-Underline="False">编辑</asp:LinkButton>|--%>
                                    <asp:LinkButton ID="lkbtn" runat="server" CommandArgument='<%# Eval("Project_UserID") %>' CommandName="del" Font-Underline="False" OnClientClick="return confirm('确认删除吗')">删除</asp:LinkButton></td>
                            </tr>

                        </ItemTemplate>
                        <FooterTemplate></table></FooterTemplate>
                    </asp:Repeater>
                    <div style="height: 60px; line-height: 60px;background-color:#fff0bd">
                        <webdiyer:AspNetPager ID="anp_project" runat="server" pagesize="4" submitbuttontext="Go" textafterpageindexbox="页" textbeforepageindexbox="转到" firstpagetext="首页" lastpagetext="尾页" nextpagetext="下一页" prevpagetext="上一页" showcustominfosection="Right" custominfohtml="共%PageCount%页，当前为第%CurrentPageIndex%页" width="1000px" height="50px" onpagechanged="anp_project_PageChanged" NumericButtonCount="4"></webdiyer:AspNetPager>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
