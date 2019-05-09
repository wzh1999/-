<%@ Page Title="" Language="C#" MasterPageFile="~/TopMaster.Master" AutoEventWireup="true" CodeBehind="information.aspx.cs" Inherits="ZhongChongWebUI.information" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="CSS/information.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="back">
        <div id="pic">
            <p>
                <img src="images/shou_xmxx.gif" />
            </p>
        </div>
        <div id="mid">
            <h2>项目信息</h2>
            <hr />
            <div id="middle">
                <br />
                <p>项目名称:<asp:TextBox ID="tbusername" runat="server" Height="25" Width="300"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="项目名称不能为空！" ControlToValidate="tbusername" Font-Overline="False"></asp:RequiredFieldValidator></p>
                <br />
                <p>筹集金额:<asp:TextBox ID="tbusermoney" runat="server" Width="300" Height="25"></asp:TextBox>元<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="筹集金额不能为空！" ControlToValidate="tbusermoney" Display="Dynamic"></asp:RequiredFieldValidator></p>
                <br />
                <p>筹集天数:<asp:TextBox ID="tbuserdays" runat="server" Width="300" Height="25"></asp:TextBox>天<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="筹集天数不能为空！" ControlToValidate="tbuserdays" Display="Dynamic"></asp:RequiredFieldValidator></p>
                <br />
                <p>
                    类别:<asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem>科技</asp:ListItem>
                        <asp:ListItem>艺术</asp:ListItem>
                        <asp:ListItem>设计</asp:ListItem>
                        <asp:ListItem>音乐</asp:ListItem>
                        <asp:ListItem>影视</asp:ListItem>
                        <asp:ListItem>出版</asp:ListItem>
                        <asp:ListItem>动漫</asp:ListItem>
                        <asp:ListItem>公益</asp:ListItem>
                        <asp:ListItem>公开课</asp:ListItem>
                        <asp:ListItem>农业</asp:ListItem>
                        <asp:ListItem>其他</asp:ListItem>
                    </asp:RadioButtonList>
                </p>
                <br />
                <p>
                    项目地点:<asp:DropDownList ID="DropDownList2" runat="server" Height="22px" Width="75px">
                        <asp:ListItem>湖南</asp:ListItem>
                        <asp:ListItem>广东</asp:ListItem>
                        <asp:ListItem>云南</asp:ListItem>
                        <asp:ListItem>香港</asp:ListItem>
                        <asp:ListItem>上海</asp:ListItem>
                        <asp:ListItem>澳门</asp:ListItem>
                        <asp:ListItem>深圳</asp:ListItem>
                        <asp:ListItem>广西</asp:ListItem>
                        <asp:ListItem>湖北</asp:ListItem>
                        <asp:ListItem>河南</asp:ListItem>
                        <asp:ListItem>海南</asp:ListItem>
                        <asp:ListItem>重庆</asp:ListItem>
                    </asp:DropDownList>

                    <asp:DropDownList ID="DropDownList1" runat="server" Height="22px" Width="75px">
                        <asp:ListItem>长沙</asp:ListItem>
                        <asp:ListItem>株洲</asp:ListItem>
                        <asp:ListItem>湘潭</asp:ListItem>
                        <asp:ListItem Value="衡阳"></asp:ListItem>
                        <asp:ListItem>邵阳</asp:ListItem>
                        <asp:ListItem>岳阳</asp:ListItem>
                        <asp:ListItem>常德</asp:ListItem>
                    </asp:DropDownList>
                </p>
                <br />
              
            
                <p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 视频:<asp:TextBox ID="tbuservideo" runat="server" Width="300" Height="25"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="视频链接不能为空！" ControlToValidate="tbuservideo"></asp:RequiredFieldValidator></p>
                <br />
                <p>项目简介:</p>
                <p>
                    <asp:TextBox ID="tbuserjianjie" runat="server" TextMode="MultiLine" Width="616" Height="144"></asp:TextBox>
                </p>
                <br />
                <p>项目详情:</p>
                <p>
                    <asp:TextBox ID="tbuserxiangqing" runat="server" Width="652" Height="338" TextMode="MultiLine"></asp:TextBox>
                </p>
                <br />
                <p>&nbsp;&nbsp;&nbsp;&nbsp;标签:<asp:TextBox ID="tbuserbiaoqiao" runat="server" Width="300px" Height="25"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="标签不能为空！" Height="25px" Width="106px" ControlToValidate="tbuserbiaoqiao"></asp:RequiredFieldValidator></p>
                <br />
                  <p>
                    项目封面:<asp:FileUpload ID="FileUpload1" runat="server" Width="139px" /><asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/images/scfm.gif" OnClick="ImageButton1_Click" />
                    <asp:Label ID="Label1" runat="server" ForeColor="#999966" Font-Size="Smaller">支持jpg、jpeg、png、gif格式，大小不超过5m。建议尺寸600*450px</asp:Label>
                    <asp:Label ID="Label3" runat="server" Text="" Visible="False"></asp:Label>
                </p>
                    <br />
                <div id="button">
                    <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/images/bt_go.gif" OnClick="ImageButton2_Click" />
                </div>
            </div>
        </div>
        <div id="light">

            <asp:Image ID="Image1" runat="server" Height="200px" Visible="True" Width="240px" />
            <asp:Label ID="Label2" runat="server" Text="目标"></asp:Label>
        </div>

    </div>
</asp:Content>
