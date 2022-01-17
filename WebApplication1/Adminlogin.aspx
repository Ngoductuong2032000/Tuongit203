<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Adminlogin.aspx.cs" Inherits="WebApplication1.Adminlogin" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
      <div class="row">
         <div class="col-md-6 mx-auto">
            <div class="card">
               <div class="card-body">
                  <div class="row">
                     <div class="col">
                        <center>
                           <img src="imgs/Sample_User_Icon.png" class="auto-style2"/>
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <center>
                           <h3>Quản Lý</h3>
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <hr>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <label>Tên tài khoản</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TxtTK" runat="server" placeholder="Tài khoản"></asp:TextBox>
                        </div>
                        <label>Mật khẩu</label>
  
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TxtMK" runat="server" placeholder="Mật khẩu" TextMode="Password"></asp:TextBox>
                        </div>
                        <div class="form-group">
                           <asp:Button class="btn btn-success btn-block btn-lg" ID="BtnDN" runat="server" Text="Đăng nhập" OnClick="BtnDN_Click" />
                            <br />
                        </div>
                     </div>
                  </div>
                   <a class="text-body" href="Homepage.aspx"><< Quay về trang chủ</a><br><br>
               </div>
            </div>
         </div>
      </div>
   </div>
</asp:Content>
<asp:Content ID="Content3" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .auto-style2 {
            width: 151px;
            height: 152px;
              border: 1px #d4d4d4 solid;
                padding: 7px;
                border-radius:50%;
                -moz-border-radius:50%;
                -webkit-border-radius:50%;
        }
    </style>
</asp:Content>
