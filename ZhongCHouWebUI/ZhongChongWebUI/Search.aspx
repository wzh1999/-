<%@ Page Title="" Language="C#" MasterPageFile="~/TopMaster.Master" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="ZhongChongWebUI.Search" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="CSS/index.css" rel="stylesheet" />
    <%--引入外部样式表--%>
    <style type="text/css">
        #zhong-rmxm>dl {
            float:left;
        }
    </style>

    <script type="text/javascript" src="js/jquery-1.11.0.min.js"></script>
    <script type="text/javascript" src="js/jquery-1.8.3.min.js"></script>
    <script type="text/javascript" src="js/index.js"></script>
    <div id="fh">
        <a href="#">
            <img src="images/2019-03-14_145712.jpg" alt="" /></a>
    </div>
    <div id="top-dao">
        <div id="diaohang">
            <ul>
                <li><a href="#">浏览全部</a></li>
                <li><a href="#">科技</a></li>
                <li><a href="#">艺术</a></li>
                <li><a href="#">设计</a></li>
                <li><a href="#">艺术</a></li>
                <li><a href="#">设计</a></li>
                <li><a href="#">音乐</a></li>
                <li><a href="#">影视</a></li>
                <li><a href="#">出版</a></li>
                <li><a href="#">动漫</a></li>
                <li><a href="#">公益</a></li>
                <li><a href="#">公开课</a></li>
                <li><a href="#">农业</a></li>
                <li><a href="#">其他</a></li>
                <li>|</li>
                <li><a href="#">苏州站</a></li>
            </ul>
        </div>
    </div>
    <div id="lubo">
        <div class="lubo">
            <div id="zuo">
                <img src="images/shouye/01.jpg" alt="" />
            </div>
            <ul>
                <li>
                    <img src="images/shouye/1.png" alt="" /></li>
                <li>
                    <img src="images/shouye/2.jpg" alt="" /></li>
                <li>
                    <img src="images/shouye/3.gif" alt="" /></li>
            </ul>
            <div id="you">
                <img src="images/shouye/02.jpg" alt="" />
            </div>
        </div>

    </div>
      <div id="zhong-rmxm">
    <asp:DataList ID="DataList1" runat="server" RepeatColumns="4">
        <ItemTemplate>
            <dl>
                <dt>
                    <%--爱心图片--%>
                    <div id="aixin">
                        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="images/aixin.png" Style="width: 56px; height: 25px; border-radius: 10px;" />
                    </div>
                    <%--喜欢的数字,绑定数据源--%>
                    <div id="shuzi"><%# Eval("Like_number")%></div>
                    <img src='<%# "/images/"+Eval("Project_cover") %>' alt="" /></dt>
                <dd>
                    <h5><%# Eval("Project_Name") %></h5>
                </dd>
                <dd class="nr"><span>目标:<%# Eval("Raise_day")%>天&nbsp&nbsp&nbsp&nbsp ¥<%# Eval("Project_Money")%></span><span id="zt"><%# Eval("Financing_state") %></span></dd>
                <dd class="jd">
                    <div id="jd" style='width: <%# double.Parse( Eval("chouji").ToString())<=100? Eval("chouji"):100 %>%'></div>
                </dd>
                <dd>
                    <div id="yd">
                        <p><%# Eval("chouji") %>%</p>
                        <p>已达</p>
                    </div>
                    <div id="ycz">
                        <p>¥<%# Eval("Raised_amount") %></p>
                        <p>已筹资</p>
                    </div>
                    <div id="sy">
                        <p><%# Eval("shengyutime") %>天</p>
                        <p>剩余时间</p>
                    </div>
                </dd>
            </dl>
        </ItemTemplate>
    </asp:DataList>
          </div>
</asp:Content>
