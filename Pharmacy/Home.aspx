<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Pharmacy.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
       
 
   
    <style type="text/css">
        .auto-style2 {
            width: 100%;
            max-width: 340px;
            min-width: 92px;
            height: 168px;
            margin-left: auto;
            margin-right: auto;
            padding-left: 15px;
            padding-right: 15px;
         
    </style>
    <link rel="stylesheet" href="style.css" />
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>
</head>
<body>
    <div id="fullscreen_bg" class="fullscreen_bg"/>

<div class="auto-style2">

	<form id="form1" runat="server">
		<h1 class="form-signin-heading text-muted">Sign In </h1>
		<%--<input type="text" id="User" class="form-control" placeholder="User Name" required="" autofocus="">
		<input type="password" id="Pass" class="form-control" placeholder="Password" required="">--%>
        
        <asp:TextBox ID="TextBox1" runat="server" class="form-control"  placeholder="Username"></asp:TextBox>
        <asp:TextBox ID="TextBox3" type="password" runat="server" class="form-control" placeholder="Password" style="margin-top:10px;" ></asp:TextBox>
        <asp:Button ID="Button3" class="btn btn-lg btn-primary btn-block" runat="server" OnClick="Button3_Click" Text="Sign In"  style="margin-top:10px;" />

&nbsp;<%--  <asp:TextBox  ID="TextBox1" class="form-control" runat="server" OnTextChanged="TextBox1_TextChanged">
    </asp:TextBox>--%><%--<asp:button class="btn btn-lg btn-primary btn-block" type="submit" ID="Button1" runat="server" OnClick="Button1_Click" Text="Sign In" />--%>

	</form>

</div>

    <div class="g-recaptcha" 

data-sitekey="YOUR SITE KEY"></div>

    
    
        
</body>
</html>
