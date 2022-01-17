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
    public partial class dangky : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void ButDK_Click(object sender, EventArgs e)
        {
            if (check())
            {

                Response.Write("<script>alert('Tài khoản và mật khẩu bị trùng');</script>");
            }
            else
            {
                sign();
            }
        }

        bool check()//kiểm tra
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }//khởi tạo và kiểm tra
                SqlCommand cmd = new SqlCommand("SELECT * from Taikhoan where Matkhau='" + TextMK.Text.Trim() + "';", con);
                // SqlDataAdapte sử dụng để điền vào DataSet và cập nhật cơ sở dữ liệu SQL Server
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                // khởi tạo bảng có phân trang sắp xếp 
                DataTable dt = new DataTable();
                da.Fill(dt);//thêm dữ liệu từ da vào dt
                if (dt.Rows.Count >= 1)//kiểm tra dữ liệu bảng của cái hàng
                {
                    return true;
                }
                else
                {
                    return false; 
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
                return false;
            }
        }
        void sign()//dk
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                //Khởi tạo và kết nối
                SqlCommand cmd = new SqlCommand("INSERT INTO Taikhoan(Tentaikhoan,Matkhau) values(@Tentaikhoan,@Matkhau)", con);
                cmd.Parameters.AddWithValue("@Tentaikhoan", TextTK.Text.Trim());//truy vấn tham số từ form
                cmd.Parameters.AddWithValue("@Matkhau", TextMK.Text.Trim());
                cmd.ExecuteNonQuery();//thi hành truy vấn
                con.Close();
                Response.Write("<script>alert('Đăng ký thành công quay về đăng nhập');</script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
    }
}
