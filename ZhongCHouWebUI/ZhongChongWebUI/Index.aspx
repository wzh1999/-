<%@ Page Title="" Language="C#" MasterPageFile="~/TopMaster.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="ZhongChouWebUI.Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="CSS/index.css" rel="stylesheet" />
    <%--引入外部样式表--%>


    <script type="text/javascript" src="js/jquery-1.11.0.min.js"></script>
    <script type="text/javascript" src="js/jquery-1.8.3.min.js"></script>
    <script type="text/javascript" src="js/index.js"></script>
    <script type="text/javascript">
        function openwin() {
            window.open("zf.aspx", "newwindow", "height=100, width=400, toolbar=no,menubar=no, scrollbars=no, resizable=no, location=no, status=no")
            //写成一行 
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <div id="boss">
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
                <div id="zuo">
                    <img src="images/shouye/01.jpg" alt="" />
                </div>
                 <div class="lubo">
                <ul>
                    <li>
                        <img src="images/shouye/1.png" alt="" /></li>
                    <%-- <li>
                        <img style="width:970px;height:400px;" src="images/shouye/4.jpg" alt="" /></li>
                    <li>
                        <img src="images/shouye/3.gif" alt="" /></li>--%>
                </ul>
            </div>
                <div id="you">
                    <img src="images/shouye/02.jpg" alt="" />
                </div>
            </div>

        </div>
        <div id="center">

            <div id="zhong">

                <h2>众筹制造</h2>
                <ul>
                    <li>
                        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click" Class="abc">科技</asp:LinkButton>

                    </li>
                    <li>
                        <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click" Class="abc">艺术</asp:LinkButton></li>
                    <li>
                        <asp:LinkButton ID="LinkButton3" runat="server" OnClick="LinkButton3_Click" Class="abc">设计</asp:LinkButton></li>
                    <li>
                        <asp:LinkButton ID="LinkButton4" runat="server" OnClick="LinkButton4_Click" Class="abc">音乐</asp:LinkButton></li>
                    <li>
                        <asp:LinkButton ID="LinkButton5" runat="server" OnClick="LinkButton5_Click" Class="abc">影视</asp:LinkButton></li>
                    <li>
                        <asp:LinkButton ID="LinkButton6" runat="server" OnClick="LinkButton6_Click" Class="abc">出版</asp:LinkButton></li>
                    <li>
                        <asp:LinkButton ID="LinkButton7" runat="server" OnClick="LinkButton7_Click" Class="abc">动漫</asp:LinkButton></li>
                    <li>
                        <asp:LinkButton ID="LinkButton8" runat="server" OnClick="LinkButton8_Click" Class="abc">公益</asp:LinkButton></li>
                    <li>
                        <asp:LinkButton ID="LinkButton9" runat="server" OnClick="LinkButton9_Click" Class="abc">公开课</asp:LinkButton></li>
                    <li>
                        <asp:LinkButton ID="LinkButton10" runat="server" OnClick="LinkButton10_Click" Class="abc">农业</asp:LinkButton></li>
                    <li>
                        <asp:LinkButton ID="LinkButton11" runat="server" OnClick="LinkButton11_Click" Class="abc">苏州站</asp:LinkButton></li>
                    <li>
                        <asp:LinkButton ID="LinkButton12" runat="server" OnClick="LinkButton12_Click" Class="abc">其他</asp:LinkButton></li>
                </ul>
            </div>
            <div id="zhong_xm">
                <%--众筹制造项目展示--%>
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
                                <a href="dateils.aspx" >
                                <img src='<%# "/images/"+Eval("Project_cover") %>' alt="" />

                                </a>

                            </dt>
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
        </div>
        <div id="center_two">
            <div id="rmxm">
                <h2>热门项目</h2>
                <%--显示最大框--%>

                <div id="zhong-rmxm">
                    <asp:DataList ID="DataList2" runat="server" RepeatColumns="4">
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
                                    <div id="jd" style='width: <%# double.Parse( Eval("nu").ToString())<=100? Eval("nu"):100 %>%'></div>
                                </dd>
                                <dd>
                                    <div id="yd">
                                        <p><%# Eval("nu") %>%</p>
                                        <p>已达</p>
                                    </div>
                                    <div id="ycz">
                                        <p>¥<%# Eval("Raised_amount") %></p>
                                        <p>已筹资</p>
                                    </div>
                                    <div id="sy">
                                        <p><%# Eval("shu") %>天</p>
                                        <p>剩余时间</p>
                                    </div>
                                </dd>
                            </dl>
                        </ItemTemplate>
                    </asp:DataList>
                </div>
            </div>

            <%-- 查看更多项目--%>
            <div id="button1">
                <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~\images\8888.png" OnClick="ImageButton2_Click" />
                <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~\images\8888.jpg" OnClick="ImageButton3_Click" />
            </div>
            <div id="wo-left">
                <div class="wo-left1">
                    <h3>我们已经做到了...</h3>
                    <img src="images/2019-03-14_144424.jpg" alt="" />
                </div>
                <div id="wo-left2">
                    <img src="images/2019-03-14_145222.jpg" alt="" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>

