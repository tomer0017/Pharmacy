﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteClientP.aspx.cs" Inherits="Pharmacy.DeleteClientP" %>


<!doctype html>
<html lang="en">

<head>
	<!-- Required meta tags -->
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
	<link rel="icon" href="img/favicon.png" type="image/png">
	<title>TYM Medical</title>
	<!-- Bootstrap CSS -->
	<link rel="stylesheet" href="css/bootstrap.css">
	<link rel="stylesheet" href="vendors/linericon/style.css">
	<link rel="stylesheet" href="css/font-awesome.min.css">
	<link rel="stylesheet" href="vendors/owl-carousel/owl.carousel.min.css">
	<link rel="stylesheet" href="vendors/lightbox/simpleLightbox.css">
	<link rel="stylesheet" href="vendors/nice-select/css/nice-select.css">
	<link rel="stylesheet" href="vendors/animate-css/animate.css">
	<link rel="stylesheet" href="vendors/jquery-ui/jquery-ui.css">
	<!-- main css -->
	<link rel="stylesheet" href="css/style.css">
	<link rel="stylesheet" href="css/responsive.css">
    <style type="text/css">
        .auto-style1 {
            margin-top: 0px;
        }
    </style>
</head>

<body>



	<form id="form1" runat="server">



	<!--================Header Menu Area =================-->
	<header class="header_area">
		<div class="top_menu row m0">
			<div class="container">
				<div class="float-left">
					<ul class="left_side">
						<li>
							<a href="login.html">
								<i class="fa fa-facebook-f"></i>
							</a>
						</li>
						<li>
							<a href="login.html">
								<i class="fa fa-twitter"></i>
							</a>
						</li>
						<li>
							<a href="login.html">
								<i class="fa fa-dribbble"></i>
							</a>
						</li>
						<li>
							<a href="login.html">
								<i class="fa fa-behance"></i>
							</a>
						</li>
					</ul>
				</div>
				<div class="float-right">
					<ul class="right_side">
						<li>
							<a href="login.html">
								<i class="lnr lnr-phone-handset"></i>
								012-6532-568-9746
							</a>
						</li>
						<li>
							<a href="#">
								<i class="lnr lnr-envelope"></i>
								emergency@colorlib.com
							</a>
						</li>
					</ul>
				</div>
			</div>
		</div>
		<div class="main_menu">
			<nav class="navbar navbar-expand-lg navbar-light">
				<div class="container">
					<!-- Brand and toggle get grouped for better mobile display -->
					<a class="navbar-brand logo_h" href="Admin.aspx">
						<img src="img/logo.png" alt="">
					</a>
					<button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent"
					 aria-expanded="false" aria-label="Toggle navigation">
						<span class="icon-bar"></span>
						<span class="icon-bar"></span>
						<span class="icon-bar"></span>
					</button>
					<!-- Collect the nav links, forms, and other content for toggling -->
					<div class="collapse navbar-collapse offset" id="navbarSupportedContent">
						<div class="row ml-0 w-100">
							<div class="col-lg-12 pr-0">
								<ul class="nav navbar-nav center_nav pull-right">
									<li class="nav-item active">
										<a class="nav-link" href="Pharmacist.aspx">עמוד הבית</a>
									</li>
									
									<li class="nav-item ">
										<a class="nav-link" href="ReportsP.aspx">דוחות
                                        </a>
									&nbsp;</li>
									<li class="nav-item submenu dropdown">
										<a href="#" class="nav-link dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false">ניהול לקוחות</a>
										<ul class="dropdown-menu">
											<li class="nav-item">
												<a class="nav-link" href="AddClientP.aspx">הוספת לקוח</a>
											</li>
										<li class="nav-item">
												<a class="nav-link" href="UpdateClientP.aspx">עדכון לקוח</a>
											</li>
											<li class="nav-item">
												<a class="nav-link" href="DeleteClientP.aspx">הסרת לקוח</a>
											</li>
										</ul>
									</li>
									
									
								</ul>
							</div>
						</div>
					</div>
				</div>
			</nav>
		</div>
	</header>
	<!--================Header Menu Area =================-->

	<!--================ Home Banner Area =================-->
	<section class="home_banner_area" >

		<div class="banner_inner d-flex align-items-center">
			<div  class="container">

				<div class="banner_content row">
					<div class="col-lg-12">
       <div class="row">
           <h1>הוספת עובד</h1>

                        <div class="col-md-6 my-3">
                            <div class="card card-outline-secondary">
                                <div class="card-body">
                                        <div class="form-group row">
                                            <div class="col-md-9">
                                                <%--<asp:TextBox ID="TextBox1" class="form-control" runat="server" value="" ></asp:TextBox> --%>
                                                <asp:DropDownList AppendDataBoundItems="true"  ID="DropDownList3" runat="server" value="" class="form-control" DataSourceID="SqlDataSource1" DataTextField="Wid" DataValueField="Wid" AutoPostBack="true" OnSelectedIndexChanged="DropDownList3_SelectedIndexChanged1">
                                                <asp:ListItem Value="-1">חפש</asp:ListItem>
                                        </asp:DropDownList>
                                            </div>
                                           <%-- <label class="col-md-3 col-form-label form-control-label"> <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="TextBox1" ErrorMessage="הכנס מספר תעודת זהות" ForeColor="Red">*</asp:RequiredFieldValidator><asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="תעודת הזהות חייבת להכיל 9 תווים" ValidationExpression="[0-9]{9}" ControlToValidate="TextBox1" ForeColor="#CC0000">*</asp:RegularExpressionValidator>תעודת זהות </label>--%>
                                            
                                        </div>
                                         <div class="form-group row">
                                            <div class="col-md-9">
                                                <asp:TextBox ID="TextBox2" class="form-control" runat="server" value="" ></asp:TextBox> 
                                            </div>
                                            <label class="col-md-3 col-form-label form-control-label"> <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox2" ErrorMessage="הכנס שם פרטי" ForeColor="Red">*</asp:RequiredFieldValidator>שם פרטי</label>
                                            
                                        </div>
                                         <div class="form-group row">
                                            <div class="col-md-9">
                                                <asp:TextBox ID="TextBox3" class="form-control" runat="server" value="" ></asp:TextBox> 
                                            </div>
                                            <label class="col-md-3 col-form-label form-control-label"><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="הכנס שם משפחה" ForeColor="Red">*</asp:RequiredFieldValidator>שם משפחה </label>
                                            
                                        
                                        <div class="form-group row">
                                            <label class="col-lg-3 col-form-label form-control-label"></label>
                                            <div class="col-lg-9">
                                                
                                                <asp:Button ID="Button2" class="btn btn-primary" runat="server" OnClick="Button2_Click" Text="הסר לקוח" />
                                               
                                                
                                                <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="#CC0000" />
                                               
                                                
                                            </div>
                                        </div>
                                </div><!-- card body -->
                            </div> <!-- card-outline -->
                        &nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CssClass="auto-style1" DataSourceID="SqlDataSource1" EmptyDataText="There are no data records to display.">
                                <Columns>
                                    <asp:BoundField DataField="LastName" HeaderText="שם משפחה" SortExpression="LastName" />
                                    <asp:BoundField DataField="FirstName" HeaderText="שם פרטי" SortExpression="FirstName" />
                                    <asp:BoundField DataField="Wid" HeaderText="תעודת זהות" SortExpression="Wid" />
                                </Columns>
                            </asp:GridView>
                            <asp:SqlDataSource ID="SqlDataSource2" runat="server"></asp:SqlDataSource>
                            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:PharmacyConnectionString %>" ProviderName="<%$ ConnectionStrings:PharmacyConnectionString.ProviderName %>" SelectCommand="SELECT [Wid], [FirstName], [LastName] FROM [Worker]"></asp:SqlDataSource>
                        </div>
                    </div>						
					</div>
				</div>
			</div>
		</div>
	    
	</section>
	<!--================ End Home Banner Area =================-->


	

	<!--================ start footer Area =================-->
	<footer class="footer-area section_gap">
		<div class="container">
			<div class="row">
				<div class="col-lg-2  col-md-6">
					<div class="single-footer-widget">
						<h6>מתכנתים</h6>
						<ul class="footer-nav">
							<li>
								<a href="#">מור ביטון</a>
							</li>
							<li>
								<a href="#">תומר כהן</a>
							</li>
							<li>
								<a href="#">טל שוורץ</a>
							</li>
							<li>
								<a href="#">יונתן אוזן</a>
							</li>
						</ul>
					</div>
				</div>
				<div class="col-lg-4  col-md-6">
					<div class="single-footer-widget mail-chimp">
						<h6 class="mb-20">צור קשר</h6>
						<p>
							נורית 8,עומר
						</p>
						<h3>08-61231452</h3>
						
					</div>
				</div>
				
			</div>

	
		</div>
	</footer>
	<!--================ End footer Area =================-->



	<!--================ Optional JavaScript =================-->
	<!--================ jQuery first, then Popper.js, then Bootstrap JS =================-->
	<script src="js/jquery-3.2.1.min.js"></script>
	<script src="js/popper.js"></script>
	<script src="js/bootstrap.min.js"></script>
	<script src="vendors/nice-select/js/jquery.nice-select.min.js"></script>
	<script src="vendors/isotope/isotope-min.js"></script>
	<script src="vendors/owl-carousel/owl.carousel.min.js"></script>
	<script src="js/jquery.ajaxchimp.min.js"></script>
	<script src="https://cdnjs.cloudflare.com/ajax/libs/Counter-Up/1.0.0/jquery.counterup.min.js"></script>
	<script src="https://cdnjs.cloudflare.com/ajax/libs/waypoints/4.0.1/jquery.waypoints.min.js"></script>
	<script src="js/mail-script.js"></script>
	<script src="js/custom.js"></script>
    </form>
</body>

</html>