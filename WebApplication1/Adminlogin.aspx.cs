using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Adminlogin : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void BtnDN_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);//Kết nối 
                if (con.State == ConnectionState.Closed)//Kiểm tra 
                {
                    con.Open();
                }
                //khởi tạo truy vấn và kết nối 
                SqlCommand cmd = new SqlCommand("select * from admin where taikhoan='" + TxtTK.Text.Trim() + "' AND matkhau='" + TxtMK.Text.Trim() + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();//Đọc dữ liệu từ SQL
                if (dr.HasRows)//nếu không có rows 
                {
                    while (dr.Read())
                    {
                        
                        Session["Tentaikhoan"] = dr.GetValue(0).ToString();//lưu và đọc dữ liệu
                        Session["Matkhau"] = dr.GetValue(0).ToString();
                        Session["role"] = "admin";
                        Response.Write("<script>alert('Đăng nhập thành công');</script>");
     
                    }
                    Response.Redirect("homepage.aspx");
                }
                else
                {
                    Response.Write("<script>alert('Thất bại');</script>");
                }

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
    }
}
