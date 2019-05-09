<%@ Page Title="" Language="C#" MasterPageFile="~/TopMaster.Master" AutoEventWireup="true" CodeBehind="BrowseUI.aspx.cs" Inherits="ZhongChouWebUI.BrowseUI" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="CSS/BrowseUI.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%--  最大的div背景色--%>
    <div id="boss">
        <%-- 内容框--%>
        <div id="nrong">
            <%--头部导航--%>
            <div id="topper">
                <ul>
                    <li>
                        <asp:Button ID="btnquanbu" runat="server" Text="全部" CssClass="typecss" OnClick="btnquanbu_Click" style="width:30px;border-radius: 5px 5px;"/></li>
                    <li>
                        <asp:Button ID="btnkeji" runat="server" Text="科技" CssClass="typecss" OnClick="btnkeji_Click" style="width:30px;border-radius: 5px 5px;"/></li>
                    <li>
                        <asp:Button ID="btnyishu" runat="server" Text="艺术" CssClass="typecss" OnClick="btnyishu_Click" style="width:30px;border-radius: 5px 5px;"/></li>
                    <li>
                        <asp:Button ID="btnsheji" runat="server" Text="设计" CssClass="typecss" OnClick="btnsheji_Click" style="width:30px;border-radius: 5px 5px;"/></li>
                    <li>
                        <asp:Button ID="btnyinyue" runat="server" Text="音乐" CssClass="typecss" OnClick="btnyinyue_Click" style="width:30px;border-radius: 5px 5px;"/></li>
                    <li>
                        <asp:Button ID="btnyingshi" runat="server" Text="影视" CssClass="typecss" OnClick="btnyingshi_Click" style="width:30px;border-radius: 5px 5px;" /></li>
                    <li>
                        <asp:Button ID="btnchuban" runat="server" Text="出版" CssClass="typecss" OnClick="btnchuban_Click" style="width:30px;border-radius: 5px 5px;"/></li>
                    <li>
                        <asp:Button ID="btndongman" runat="server" Text="动漫" CssClass="typecss" OnClick="btndongman_Click" style="width:30px;border-radius: 5px 5px;"/></li>
                    <li>
                        <asp:Button ID="btngongyi" runat="server" Text="公益" CssClass="typecss" OnClick="btngongyi_Click" style="width:30px;border-radius: 5px 5px;"/></li>
                    <li>
                        <asp:Button ID="btngongkaike" runat="server" Text="公开课" CssClass="typecss" OnClick="btngongkaike_Click" style="width:40px;border-radius: 5px 5px;"/></li>
                    <li>
                        <asp:Button ID="btnnongye" runat="server" Text="农业" CssClass="typecss" OnClick="btnnongye_Click" style="width:30px;border-radius: 5px 5px;"/></li>
                    <li>
                        <asp:Button ID="btnqita" runat="server" Text="其他" CssClass="typecss" OnClick="btnqita_Click" style="width:30px;border-radius: 5px 5px;"/></li>
                    <li id="kongge">
                        <asp:Button ID="btnzhongchouzhizhao" runat="server" Text="众筹制造" CssClass="typecss" Width="71px" style="width:60px;border-radius: 5px 5px;"/></li>
                    <li>
                        <asp:Button ID="btnyuanchuangshougong" runat="server" Text="原创手工" CssClass="typecss" style="width:60px;border-radius: 5px 5px;"/></li>
                    <li>
                        <asp:Button ID="btnyingjianshebei" runat="server" Text="硬件设备" CssClass="typecss" style="width:60px;border-radius: 5px 5px;"/></li>

                </ul>
            </div>

            <div id="liulan">
                <%--进度条目录--%>
                <div id="jindu">
                    <asp:Button ID="suoyouxiangmu" runat="server" Text="所有项目" CssClass="yangshi" OnClick="suoyouxiangmu_Click" style="width:80px;height:40px;border-radius: 5px 5px;"/>
                    <asp:Button ID="zhongchouzhong" runat="server" Text="众筹中" CssClass="yangshi" OnClick="zhongchouzhong_Click" style="width:80px;height:40px;border-radius: 5px 5px;" />
                    <asp:Button ID="yichenggong" runat="server" Text="已成功" CssClass="yangshi" OnClick="yichenggong_Click" style="width:80px;height:40px;border-radius: 5px 5px;"/>
                    <asp:DropDownList ID="dropdown1" runat="server" CssClass="drop_sort" AutoPostBack="True" OnSelectedIndexChanged="dropdown1_SelectedIndexChanged2">
                        <asp:ListItem>默认排序</asp:ListItem>
                        <asp:ListItem>最新上线</asp:ListItem>
                        <asp:ListItem>最高目标金额</asp:ListItem>
                        <asp:ListItem>最多喜欢人数</asp:ListItem>
                        <asp:ListItem>最多支持金额</asp:ListItem>
                    </asp:DropDownList>
                </div>
                <%--资料显示--%>
                <div id="xianshi">
                    <asp:Repeater ID="RP_details" runat="server">
                        <ItemTemplate>
                            <div id="list">
                                <%--爱心图片--%>
                            <div id="aixin">
                                    <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="images/aixin.png" style="width:56px;height:25px;"/>
                                </div>
                                <%--喜欢的数字,绑定数据源--%>
                                <div id="shuzi"><%# Eval("Like_number")%></div>
                                <%-- 板块内容--%>

                                <%--  图片设置--%>
                                <div id="tu">
                                    <%--跳转项目编号--%>
                                    <a href="dateils.aspx" >
                                        <%--   项目封面--%>
                                        <asp:Image ID="Image1" runat="server" ImageUrl='<%# "~/images/"+Eval("Project_cover") %>' style="width:223px; height:169px;"/></a>
                                </div>
                                <%--项目名称--%>
                                <div id="detail1"><%# Eval("Project_Name") %></div>
                                <%-- 目标设置--%>
                                <div id="detail2"><span>目标：<%# Eval("Raise_day") %>天</span>  ¥<%# Eval("Project_Money") %><span id="state"><%# Eval("Financing_state") %></span></div>
                                <%--   进度条设置--%>


                                <div id="detail3" style='width: <%# double.Parse( Eval("chouji").ToString())<=100? Eval("chouji"):100 %>%'>
                                </div>


                                <%--获取筹集进度，目标资金，天数--%>
                                <div id="detail4"><span><%# Eval("chouji")%>%</span><span>¥<%# Eval("Raised_amount") %></span><span><%# Eval("shengyutime") %>天</span></div>
                                <div id="detail5"><span>已达</span><span>已筹资</span><span>剩余时间</span></div>
                            </div>
                        </ItemTemplate>

                    </asp:Repeater>
                   
         
       
                </div>
            
            </div>
        </div>
        <div id="fenye">
            <webdiyer:AspNetPager ID="AspNetPager1" runat="server" AlwaysShow="True" AlwaysShowFirstLastPageNumber="True" FirstPageText="第一页" LastPageText="最后一页" NextPageText="下一页" OnPageChanged="AspNetPager1_PageChanged" PageSize="20" PrevPageText="上一页" ShowDisabledButtons="True" CustomInfoHTML="共%PageCount%页，当前为第%CurrentPageIndex%页" ShowCustomInfoSection="Right"></webdiyer:AspNetPager>
        </div>
             
    </div>

</asp:Content>
