<%@ Page Title="" Language="C#" MasterPageFile="~/TopMaster.Master" AutoEventWireup="true" CodeBehind="NewsHelp.aspx.cs" Inherits="ZhongChongWebUI.NewsHelp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript" src="js/jquery-1.11.0.min.js"></script>
    <style type="text/css">
        #perSet_helpTabCBox {
            width: 1300px;
            /*height: 1300px;*/
            border: 1px solid #d1cece;
            margin: 0px auto;
        }

        .preset_helpQusBox {
            width: 400px;
            margin-top: 10px;
        }

        .preset_helpQusRes {
            width: 400px;
            display: none;
        }

        .preset_helpQusA {
            font-size: 16px;
            color: #50ABF2;
            font-weight: bold;
        }

        .fen1 {
            width: 400px;
            /*border: 1px solid red;*/
            margin-left: 270px;
        }

        .fen2 {
            width: 400px;
            /*border: 1px solid red;*/
            position: absolute;
            top: 140px;
            left: 750px;
        }

        #top {
            margin-left: 200px;
            margin-top: 20px;
        }

        #kong {
            width: 400px;
            height: 200px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div id="perSet_helpTabCBox">
        <div id="top">
            <h1>常见问题：</h1>
        </div>
        <div class="fen1">
            <div class="preset_helpQusBox">
                <a href="#1_1" class="preset_helpQusA">1、众筹是什么？</a>
                <div class="preset_helpQusRes">
                    <p>众筹译自crowdfunding，即大众筹资。当代众筹指通过互联网发布筹款项目并筹集资金。只要是网友喜欢的项目，都可以通过众筹方式获得项目启动的第一笔资金，或者获得项目发展的第一批粉丝用户。</p>
                </div>
            </div>
            <div class="preset_helpQusBox">
                <a href="#1_2" class="preset_helpQusA">2、如何成为注册用户？</a>
                <div class="preset_helpQusRes">
                    <ul>
                        <li>1、点击“快速注册”，通过手机号码进行注册；</li>
                        <li>2、点击“快速注册”，通过邮箱进行注册；（仅支持pc端）</li>
                        <li>3、点击“登录”，无需注册，通过手机短信登录；</li>
                        <li>4、通过新浪微博、微信（仅支持app）、QQ进行账号关联登录。</li>
                    </ul>
                </div>
            </div>
            <div class="preset_helpQusBox">
                <a href="#1_3" class="preset_helpQusA">3、手机号码注册时为什么收不到验证码？</a>
                <div class="preset_helpQusRes">
                    <ul>
                        <li>1、请确认您的手机是否对此类系统短信进行拦截设置，需解除设置；</li>
                        <li>2、曾向运营商投诉，拒收此类短信，可联系众筹网查询原因。</li>
                    </ul>
                </div>
            </div>
            <div class="preset_helpQusBox">
                <a href="#1_4" class="preset_helpQusA">4、忘记账号是否可以查询？</a>
                <div class="preset_helpQusRes">
                    <p>很抱歉，我们无法查询注册账号，建议您再尝试一下，或者重新注册，若您曾经支持过项目，会按正常流程办理，不会对您造成任何影响。</p>
                </div>
            </div>
            <div class="preset_helpQusBox">
                <a href="#1_5" class="preset_helpQusA">5、登陆网站提示“密码错误”怎么办？</a>
                <div class="preset_helpQusRes">
                    <p>请点击“忘记密码？”，根据提示进行找回密码的操作。</p>
                </div>
            </div>
            <div class="preset_helpQusBox">
                <a href="#1_5" class="preset_helpQusA">6、如何更换注册账号？</a>
                <div class="preset_helpQusRes">
                    <p>
                        如果为手机注册用户，您可以打开众筹网app，点击右下角“我的”，进入“个人中心”，点击头像，进入“个人资料”，选择“手机”，按提示输入当前绑定的手机号，通过验证后，根据提示输入新绑定的手机号，并输入获取的验证码，验证通过后，即为更换成功。新绑定的手机号码必须为未注册过众筹网的手机号码。
邮箱注册的用户暂时无法更换注册账号。
                    </p>
                </div>
            </div>
            <div class="preset_helpQusBox">
                <a href="#2_1" class="preset_helpQusA">7、如何支持项目？</a>
                <div class="preset_helpQusRes">
                    <p>项目支持方可以点击项目，进入项目详情页后，选择适合的支持选项，点击进行支付。可通过网银、支付宝、微信、易宝等进行付款，为保证资金的安全，支付的款项会进入第三方支付账户，不会直接进入发起人账户或者众筹网账户。</p>
                </div>
            </div>
            <div class="preset_helpQusBox">
                <a href="#2_2" class="preset_helpQusA">8、什么时间可以收到回报？</a>
                <div class="preset_helpQusRes">
                    <p>
                        项目回报会在项目结束后发起方承诺的期间内发放，具体时间在项目页的每个回报项下显示。
                   
                    </p>
                </div>
            </div>

            <div class="preset_helpQusBox">
                <a href="#2_3" class="preset_helpQusA">9、支持了项目是否可以退款？</a>
                <div class="preset_helpQusRes">
                    <p>
                        项目失败后，用户支持的资金会原路返回到付款账户中。项目众筹期间与项目成功后均不予办理退款。
                   
                    </p>
                </div>
            </div>


            <div class="preset_helpQusBox">
                <a href="#2_4" class="preset_helpQusA">10、如何联系项目发起方？</a>
                <div class="preset_helpQusRes">
                    <p>
                        如果您已经支持了项目，您可以通过：
                   
                    </p>
                    <ul>
                        <li>a：登录众筹网pc端，点击“个人中心－订单”，鼠标放在发起人用户名的位置，即可显示发起人联系方式。</li>
                        <li>b：打开众筹网app，点击右下角“我的”，选择“奖励订单－待发货/待收货－电话联系”，便可与发起人进行联系；</li>
                    </ul>
                </div>
            </div>
            <div class="preset_helpQusBox">
                <a href="#2_5" class="preset_helpQusA">11、如何更改收货信息？</a>
                <div class="preset_helpQusRes">
                    <p>您好，更换地址的方式有两种：</p>
                    <ul>
                        <li>1、为保证变更收货信息的及时性与准确性，可直接联系发起方进行修改。（联系发起人方法见问题：如何联系项目发起方？）
                        </li>
                        <li>2、在确认发起方尚未发货的情况下，可使用您在支持项目时预留的手机号码拨打众筹网客服电话：4000106810，进行修改。
                        </li>
                    </ul>
                </div>
            </div>


            <div class="preset_helpQusBox">
                <a href="#2_6" class="preset_helpQusA">12、如何确认回报？</a>
                <div class="preset_helpQusRes">
                    <p>
                        在您收到回报后，请登录众筹网，在“我的订单”中点击“确认收货”，若15天您仍未点击确认，系统会将该订单转为“已收货”状态。
                   
                    </p>
                </div>
            </div>


            <div class="preset_helpQusBox">
                <a href="#2_7" class="preset_helpQusA">13、项目失败如何退款？</a>
                <div class="preset_helpQusRes">
                    <p>
                        项目失败后，众筹网将为您办理退款，资金将原路返回到您的支付宝或银行账户中，您将于7-15个工作日收到退款。
                   
                    </p>
                </div>
            </div>
            <div class="preset_helpQusBox">
                <a href="#3_1" class="preset_helpQusA">14、什么人可以发起项目?</a>
                <div class="preset_helpQusRes">
                    <ul>
                        <li>1、已满18周岁有完全民事行为能力的人、未满18周岁者请由监护人协助提供相关资料。</li>
                        <li>2、中华人民共和国公民，或能提供长期在中国居住证明的非中华人民共和国公民，并在网站需要时，按照网站要求，提供必要的身份认证和资质认证，根据项目内容，包括但不限于：身份证、护照、学历证明等。</li>
                        <li>3、拥有能够在中国地区接收人民币汇款的银行卡或者支付宝账户。</li>
                        <li>4、众筹网的注册用户，已仔细阅读、同意并无条件接受众筹网的《服务条款》所涉全部内容。</li>
                    </ul>
                </div>
            </div>
        </div>
        <div id="kong">
        </div>
    <div class="fen2">
        <div class="preset_helpQusBox">
            <a href="#3_2" class="preset_helpQusA">15、众筹网支持哪些行业？</a>
            <div class="preset_helpQusRes">
                <p>众筹网目前支持科技、公益、出版、娱乐、艺术、农业、商铺、房产八个行业的项目，具体标准请参考《项目发起规范》，如果您发起的项目不属于上述行业，可在发起时选择“其他”行业。</p>
            </div>
        </div>
        <div class="preset_helpQusBox">
            <a href="#3_3" class="preset_helpQusA">16、如何发起项目</a>
            <div class="preset_helpQusRes">
                <p>在成为众筹网注册用户后，在网页上方点击“发起众筹”，根据提示将页面中的“基本信息”、“项目信息”、“项目详情”、“回报设置”四个板块填写完整后，生成“发布”标签，仔细阅读《众筹网合作协议》并确认后，便可提交审核。</p>
            </div>
        </div>
        <div class="preset_helpQusBox">
            <a href="#3_4" class="preset_helpQusA">17、项目文案如何撰写？</a>
            <div class="preset_helpQusRes">
                <p>在“项目详情”标签下以图文结合的形式展示“关于我”、“我想要做什么”、“为什么需要你的支持及资金用途”等重要板块，尽可能的使文案具有创意、吸引力。文字或图片的缺失都极可能导致您的项目被退回。</p>
            </div>
        </div>
        <div class="preset_helpQusBox">
            <a href="#3_5" class="preset_helpQusA">18、筹资额如何设置？</a>
            <div class="preset_helpQusRes">
                <p>筹资额不得少于500，建议您根据项目的资金需要进行设置，不要盲目填写过高或过低的金额。</p>
            </div>
        </div>
        <div class="preset_helpQusBox">
            <a href="#3_6" class="preset_helpQusA">19、筹资回报如何设置？</a>
            <div class="preset_helpQusRes">
                <p>建议回报为项目的衍生品，与项目内容有关的回报更能吸引到大家的支持。建议设置3个以上的梯度回报，例如：几十、几百、几千元。多些选择能提高项目的支持率，能让你的项目更快成功。项目内容及回报均不得涉及现金、利润分红、股权、金融理财产品等相关内容。</p>
            </div>
        </div>
        <div class="preset_helpQusBox">
            <a href="#3_7" class="preset_helpQusA">20、项目公开性与安全性如何保证？</a>
            <div class="preset_helpQusRes">
                <p>作为项目发起人，您可以选择信息的公开程度，回避涉及知识产权等敏感信息。但与此同时，众筹网是一个面对公众的平台，您所提供的信息越丰富和生动，就越容易获得众人的支持。在项目审核阶段，只有具有审核权限的工作人员可以看到您的项目，众筹网内部都有明确的权限分级，不会向他人泄露您的项目资料。</p>
            </div>
        </div>
        <div class="preset_helpQusBox">
            <a href="#3_8" class="preset_helpQusA">21、众筹网如何审核项目？</a>
            <div class="preset_helpQusRes">
                <p>
                    项目提交审核后，众筹网会有专业的审核人员对项目进行审核。审核的内容包括项：项目的完整性、项目所需资质、项目的合理性、项目的可行性等。项目审核周期为3个工作日，您可以在“个人中心－发起中心－我的发起”页面查看项目审核意见。
                   
                </p>
            </div>
        </div>
        <div class="preset_helpQusBox">
            <a href="#3_9" class="preset_helpQusA">22、众筹网如何收费？</a>
            <div class="preset_helpQusRes">
                <p>众筹网对于成功的项目都会收取3.0%的资金支付渠道费，如果您需要行业内向您提供其他相关服务，所产生的成本及费用，需要在项目通过审核后，向项目经理确认。</p>
            </div>
        </div>
        <div class="preset_helpQusBox">
            <a href="#3_10" class="preset_helpQusA">23、如何对项目进行维护？<b></b></a>
            <div class="preset_helpQusRes">
                <p>项目上线后，建议您积极自主推广项目，带动项目筹资额，并及时回复项目下的用户评论，与关注该项目的用户进行良好互动。同时，不要打扰其他项目的正常展示，请勿在其他项目下推广自己的项目。</p>
            </div>
        </div>
       
        <div class="preset_helpQusBox">
            <a href="#3_12" class="preset_helpQusA">24、项目上线后是否可以取消或修改？</a>
            <div class="preset_helpQusRes">
                <p>众筹网在发起人发布的项目上线后，有权保留发起人项目展示页面相关信息，包括但不限于发起人信息、项目介绍与说明、筹资金额、回馈标准、项目筹资情况（包括项目筹资成功或失败）等相关页面内容，发起人不得要求众筹网删除已经发布的项目展示页面或项目信息；发起人确有正当理由，要求对项目展示页面进行修改的，应书面进行申请，众筹网审核后酌情收费进行处理。</p>
            </div>
        </div>
        <div class="preset_helpQusBox">
            <a href="#3_14" class="preset_helpQusA">25、项目失败如何处理？</a>
            <div class="preset_helpQusRes">
                <p>项目失败后，众筹网将为支持者办理退款，资金将原路返回到支持者的付款账户中，支持者将于7-15个工作日收到退款。您无需申请。</p>
            </div>
        </div>
    </div>
    </div>
    <script type="text/javascript">
        $('#perSet_helpTabCBox').on('click', '.preset_helpQusA', function () {
            var nextDiv = $(this).next('div');
            if (nextDiv.css('display') != "none") {
                nextDiv.hide();
            } else {
                nextDiv.show();
            }
        });
</script>
    <%-- 书本191--%>
</asp:Content>
