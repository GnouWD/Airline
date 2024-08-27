<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Airline/Usermaster.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="FlaitBooking.Airline.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


<!-- contact-form -->
<section class="w3l-contact" id="contact">
  <div class="contact-infubd py-5">
    <div class="container py-lg-3">
      <div class="contact-grids row">
        <div class="col-lg-6 contact-left">
          <div class="partners">
            <div class="cont-details">
              <h5>Get in touch</h5>
              <p class="mt-3 mb-4">Hi there, We are available 24/7 by fax, e-mail or by phone. Drop us line so we can talk
                futher about that.</p>
            </div>
            <div class="hours">
              <h6 class="mt-4">Email:</h6>
              <p> <a href="#">
                indiaflight@gmail.com</a></p>
              <h6 class="mt-4">Visit Us:</h6>
              <p>Bhadarod, NH-51 Gujrat-India.</p>
              <h6 class="mt-4">Contact:</h6>
              <p class="margin-top"><a href="3">+91 8585968585</a></p>
            </div>
          </div>
        </div>
        <div class="col-lg-6 mt-lg-0 mt-5 contact-right">
          <form action="" method="post" class="signin-form">
            <div class="input-grids">
              <div class="form-group">
                  <asp:TextBox ID="txtName" runat="server"  placeholder="Your Name*" class="contact-input"></asp:TextBox>
                <%--<input type="text" name="w3lName" id="w3lName" placeholder="Your Name*" class="contact-input" />--%>
              </div>
              <div class="form-group">
                  <asp:TextBox ID="txtEmail" runat="server" TextMode="Email"  placeholder="Your Email*" class="contact-input"></asp:TextBox>
                <%--<input type="email" name="w3lSender" id="w3lSender" placeholder="Your Email*" class="contact-input" required="" />--%>
              </div>
              <div class="form-group">
                  <asp:TextBox ID="txtSubject" runat="server"  placeholder="Subject*" class="contact-input"></asp:TextBox>
               <%-- <input type="text" name="w3lSubect" id="w3lSubect" placeholder="Subject*" class="contact-input" />--%>
              </div>
            </div>
            <div class="form-group">
                <asp:TextBox ID="txtMessage" TextMode="MultiLine" runat="server"  placeholder="Type your message here*" class="contact-input"></asp:TextBox>
             <%-- <textarea name="w3lMessage" id="w3lMessage" placeholder="Type your message here*" required=""></textarea>--%>
            </div>
            <div class="text-right">
                <asp:Button ID="btnSend" class="btn btn-style btn-primary" runat="server" Text="Send" OnClick="btnSend_Click" />
             <%-- <button class="btn btn-style btn-primary">Send Message</button>--%>
            </div>
          </form>
        </div>

      </div>
      
    </div>
</section>
<!-- /contact-form -->





</asp:Content>
