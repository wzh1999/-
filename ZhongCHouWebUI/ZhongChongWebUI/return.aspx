<%@ Page Title="" Language="C#" MasterPageFile="~/TopMaster.Master" AutoEventWireup="true" CodeBehind="return.aspx.cs" Inherits="ZhongChongWebUI.Scripts.回报" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="CSS/return.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="center">
        <p id="pic">
            <img src="images/head_fqrxx.gif" alt=""/>
        </p>
        <div id="mid">
            <h2>回报设置</h2>
            <hr />
            <div id="middle">
                <asp:GridView ID="GridView1" runat="server" EnableModelValidation="True" Width="680px">
                    <Columns>
                        <asp:BoundField DataField="ReturnID" HeaderText="回报编号" />
                        <asp:BoundField DataField="Qualified_quota" HeaderText="名额" />
                        <asp:BoundField DataField="Support_amount" HeaderText="回报金额" />
                        <asp:BoundField DataField="Return_content" HeaderText="回报内容" />
                        <asp:BoundField DataField="Freight" HeaderText="运费" />
                        <asp:BoundField DataField="Return_time" HeaderText="回报时间" />
                    </Columns>
                </asp:GridView>
                <div id="bottom">
                    <h4>支持回报选项02</h4>
                </div>
                <div id="cash">
                    <p>
                        支持金额:
                        <asp:TextBox ID="TextBox1" runat="server" Height="20"></asp:TextBox>
                    </p>
                    <br />
                    <p>
                        回报内容:
                        <asp:TextBox ID="TextBox2" runat="server" Width="450" Height="80"></asp:TextBox>
                    </p>
                    <br />
          
                    <p>
                        限定名额:
                        <asp:TextBox ID="TextBox3" runat="server" Width="60"></asp:TextBox>个
                        <asp:Label ID="Label2" runat="server" Text='"0"为不限名额' Font-Size="Smaller" ForeColor="#999966"></asp:Label>
                    </p>
                    <br />
                    <p>
                        &nbsp; 运费:
                        <asp:TextBox ID="TextBox4" runat="server" Width="60"></asp:TextBox>天
                        <asp:Label ID="Label3" runat="server" Text='"0"为不收运费' Font-Size="Smaller" ForeColor="#999966"></asp:Label>
                    </p>
                    <br />
                    <p>汇报时间:项目结束后 <asp:TextBox ID="TextBox5" runat="server" Width="60"></asp:TextBox>&nbsp;天</p>
                    <br />
                    <p>
                        <asp:Label ID="Label1" runat="server" Text=""></asp:Label></p>
                    <p>
                        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/images/bt_bc.gif" OnClick="ImageButton1_Click" />
                        <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/images/bt_qxbc.gif" OnClick="ImageButton2_Click" />
                    </p>
                    <div id="ribht">
                        <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/images/bt_syb.gif" OnClick="ImageButton3_Click" /><asp:ImageButton ID="ImageButton4" runat="server" ImageUrl="~/images/bt_go.gif" OnClick="ImageButton4_Click" />
                    </div>
                </div>

            </div>
        </div>
        <div id="light">
            <h3>温馨提示</h3>
            <hr />
            <div id="light_x">
                <p>
                    3个以上的回报<br />
                    <asp:Label ID="Label5" runat="server" Text="多些选择能够提高项目的支持率" ForeColor="#CCCCCC" Font-Size="Small"></asp:Label>
                </p>
                <p>
                    几十、几百、上千元的支持<br />
                    <asp:Label ID="Label6" runat="server" Text="3个不同档次的回报，能让你的项目更快成功" ForeColor="#CCCCCC" Font-Size="Small"></asp:Label>
                </p>

                <p>
                    回报最好是项目的衍生品<br />
                    <asp:Label ID="Label7" runat="server" Text="与项目内容与关的回报更能吸引到大家的支持" ForeColor="#CCCCCC" Font-Size="Small"></asp:Label>
                </p>
            </div>
        </div>
    </div>
</asp:Content>
