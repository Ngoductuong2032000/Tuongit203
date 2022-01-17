﻿<%@ Page Language="C#" AutoEventWireup="true"  MasterPageFile="~/Site.Master" CodeBehind="dangky.aspx.cs" Inherits="WebApplication1.dangky" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
      <div class="row">
         <div class="col-md-6 mx-auto">
            <div class="card">
               <div class="card-body">
                  <div class="row">
                     <div class="col">
                        <center>
                           <img src="imgs/hinhdangki.png" class="auto-style2"/>
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <center>
                           <h3>Đăng Ký</h3>
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
                           <asp:TextBox CssClass="form-control" ID="TextTK" runat="server" placeholder="Tài khoản"></asp:TextBox>
                        </div>
                        <label>Mật khẩu</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextMK" runat="server" placeholder="Mật khẩu" TextMode="Password"></asp:TextBox>
                        </div>
                        <div class="form-group">
                           <asp:Button class="btn btn-success btn-block btn-lg" ID="ButDK" runat="server" OnClick="ButDK_Click" Text="Đăng ký" BackColor="#3366ff" />
                        </div>
                     </div>
                  </div>
                    <a class="text-body"  href="TaikhoanUser.aspx"><< Quay về</a><br><br>
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

