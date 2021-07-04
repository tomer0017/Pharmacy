<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteMed.aspx.cs" Inherits="Pharmacy.DeleteMed" %>
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
            left: 0px;
            top: -1px;
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
										<a class="nav-link" href="Admin.aspx">עמוד הבית</a>
									</li>
									
									<li class="nav-item ">
										<a class="nav-link" href="Reports.aspx">דוחות
                                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:PharmacyConnectionString %>" SelectCommand="SELECT [Name] FROM [Medicine]"></asp:SqlDataSource>
                                        </a>
									&nbsp;</li>
									<li class="nav-item submenu dropdown">
										<a href="#" class="nav-link dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false">ניהול לקוחות</a>
										<ul class="dropdown-menu">
											<li class="nav-item">
												<a class="nav-link" href="AddClient.aspx">הוספת לקוח</a>
											</li>
											<li class="nav-item">
												<a class="nav-link" href="services.html">עדכון לקוח</a>
											</li>
											<li class="nav-item">
												<a class="nav-link" href="elements.html">הסרת לקוח</a>
											</li>
										</ul>
									</li>
									<li class="nav-item submenu dropdown">
										<a href="#" class="nav-link dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false">ניהול תרופות</a>
										<ul class="dropdown-menu">
											<li class="nav-item">
												<a class="nav-link" href="AddWorker.aspx">הוספת תרופה</a>
											</li>
											<li class="nav-item">
												<a class="nav-link" href="services.html">עידכון תרופה</a>
											</li>
											<li class="nav-item">
												<a class="nav-link" href="elements.html">הסרת תרופה</a>
											</li>
										</ul>
									</li>
									<li class="nav-item submenu dropdown">
										<a href="#" class="nav-link dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false">ניהול עובדים</a>
										<ul class="dropdown-menu">
											<li class="nav-item">
												<a class="nav-link" href="AddWorker.aspx">הוספת עובד</a>
											</li>
											<li class="nav-item">
												<a class="nav-link" href="UpdateWorker.aspx">עידכון עובד</a>
											</li>
											<li class="nav-item">
												<a class="nav-link" href="elements.html">הסרת עובד</a>
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
			<div class="container">

				<div class="banner_content row">
					<div class="col-lg-12">
       <div class="row">
                        <div class="col-md-6 my-3">
                            <div class="card card-outline-secondary">
                                <div class="card-body">
                                     <div class="form-group row">
                                            <div class="col-md-9">
                                        <asp:DropDownList AppendDataBoundItems="true" ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" AutoPostBack="true" DataTextField="Name" DataValueField="Name" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged1">
                                             <asp:ListItem Value="-1">שם תרופה</asp:ListItem>
                                        </asp:DropDownList>
                                                </div>
                                         </div>
                                        
                                        
                                        <div class="form-group row">
                                            <div class="col-md-9">
                                                <asp:TextBox ID="TextBox4" class="form-control" runat="server" value="" ></asp:TextBox> 
                                            </div>
                                           
                                            <label class="col-md-3 col-form-label form-control-label"><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox4" ErrorMessage="הכנס את תיאור התרופה" ForeColor="Red">*</asp:RequiredFieldValidator>תיאור התרופה</label>
                                            
                                        </div>
                                         <div class="form-group row">
                                            <div class="col-md-9">
                                                <asp:TextBox ID="TextBox5" class="form-control" runat="server" value="" ></asp:TextBox> 
                                            </div>
                                            <label class="col-md-3 col-form-label form-control-label"><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox5" ErrorMessage="הכנס את שם החברה" ForeColor="Red">*</asp:RequiredFieldValidator>חברה</label>
                                            
                                        </div>
                                      <%--  <div class="form-group row">
                                            <div class="col-md-9">
                                                <asp:TextBox ID="TextBox6" class="form-control" runat="server" value="" ></asp:TextBox> 
                                            </div>
                                            <label class="col-md-3 col-form-label form-control-label"><asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="TextBox6" ErrorMessage="הכנס תמונה" ForeColor="Red">*</asp:RequiredFieldValidator>תמונה</label>
                                            
                                        </div>--%>
                                      
                                        
                                   
                                        
                                        <div class="form-group row">
                                            <label class="col-lg-3 col-form-label form-control-label"></label>
                                            <div class="col-lg-9">
                                                
                                                <asp:Button ID="Button2" class="btn btn-primary" runat="server" OnClick="Button2_Click" Text="הסר תרופה" />
                                               
                                                
                                                <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="#CC0000" />
                                               
                                                
                                            </div>
                                        </div>
                                </div><!-- card body -->
                            </div> <!-- card-outline -->
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