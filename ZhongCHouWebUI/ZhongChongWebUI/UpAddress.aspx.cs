using System;
using System.Collections.Generic;
using System.Xml;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Model;
namespace ZhongChongWebUI
{
    public partial class UpAddress : System.Web.UI.Page
    {
        public static string Accounts = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.Cookies["userName"] != null)
                {
                    Accounts = Request.Cookies["userName"].Value;
                }
                loads(Accounts);
                BindProvince();
            }
        }
        //加载信息
        void loads(string Accounts)
        {
            PersonalSelectBLL usb = new PersonalSelectBLL();
        }
        //省市联动
        protected void ddlProvince_SelectedIndexChanged1(object sender, EventArgs e)
        {
            BindCity();
        }
        void BindProvince()
        {

            string CurrentPath = this.Server.MapPath(".");
            if (System.IO.File.Exists(CurrentPath + "//Province.xml"))
            {
                this.ddlProvince.Items.Clear();
                System.Xml.XmlDocument doc = new System.Xml.XmlDocument();
                doc.Load(CurrentPath + "//Province.xml");
                XmlNodeList nodes = doc.DocumentElement.ChildNodes;
                XmlNode nodeCity = doc.DocumentElement.SelectSingleNode(@"Province/City[@Name='" + "城市" + "']");
                foreach (XmlNode node in nodes)
                {
                    this.ddlProvince.Items.Add(node.Attributes["Name"].Value);
                    int n = this.ddlProvince.Items.Count - 1;

                    if (nodeCity != null && node == nodeCity.ParentNode)
                        this.ddlProvince.SelectedIndex = n;

                }
                BindCity();
            }
            else
            {

            }
        }
        void BindCity()
        {
            string CurrentPath = this.Server.MapPath(".");
            if (System.IO.File.Exists(CurrentPath + "//Province.xml"))
            {
                this.ddlCity.Items.Clear();
                System.Xml.XmlDocument doc = new System.Xml.XmlDocument();
                doc.Load(CurrentPath + "//Province.xml");
                XmlNodeList nodes = doc.DocumentElement.ChildNodes[this.ddlProvince.SelectedIndex].ChildNodes;
                foreach (XmlNode node in nodes)
                {
                    this.ddlCity.Items.Add(node.Attributes["Name"].Value);
                    int n = this.ddlCity.Items.Count - 1;
                    if (node.Attributes["Name"].Value == "城市")
                    {
                        this.ddlCity.SelectedIndex = n;
                    }
                }
                if (this.ddlCity.SelectedIndex == -1)
                    this.ddlCity.SelectedIndex = 0;
            }
            else
            {

            }
        }
        //添加收件信息
        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            Accounts = Request.Cookies["userName"].Value;
            PersonalAddBLL uir = new PersonalAddBLL();
            ReceivingInfo rec = new ReceivingInfo();
            rec.Zip_code = int.Parse(this.Zip_code.Text);
            rec.Receiving_Province = this.ddlProvince.Text;
            rec.Receiving_City = this.ddlCity.Text;
            rec.Receiving_Phone = this.Receiving_Phone.Text;
            rec.Receiving_Name = this.Receiving_Name.Text;
            rec.Detailed_address = this.Detailed_address.Text;
            rec.Accounts = Accounts;
            if (uir.UsersInsertRecei(rec))
            {
                ClientScript.RegisterStartupScript(this.GetType(), "zixunSucess", "<script>alert('添加成功！');</script> ");

            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "zixunSucess", "<script>alert('添加失败！');</script> ");
            }
        }

    }
}