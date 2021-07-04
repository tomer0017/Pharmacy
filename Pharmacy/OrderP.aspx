<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderP.aspx.cs" Inherits="Pharmacy.OrderP" %>


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
	<section class="home_banner_area">
		<div class="banner_inner d-flex align-items-center">
			<div class="container">
				<div class="banner_content row">
					<div class="col-lg-12">
    <div class="form-group">
        <h1>יצירת הזמנה</h1>
<%--     <label for="inputType" class="control-label">מספר הזמנה</label>
      <div class="col-md-3">
          <input type="text" class="form-control" id="inputType" placeholder=" ">
      </div>--%>
       
    </div>
    <div class="form-group">
       <%-- <span class="col-md-2 control-label">Metadata</span>--%>
        <div class="col-md-6">
            <div class="form-group row">
               
                <div class="col-md-2">
                     <asp:TextBox ID="TextBox24" ReadOnly = true class="form-control" runat="server"></asp:TextBox>
                </div> 
                <label for="inputKey" class="col-md-1 control-label">שם משפחה</label>
               
                <div class="col-md-2">
                     <asp:TextBox ID="TextBox23" ReadOnly = true class="form-control" runat="server"></asp:TextBox>
                </div>
                <label for="inputValue" class="col-md-1 control-label">שם פרטי</label>
                 
                
                <div class="col-md-2">
                     <asp:TextBox ID="TextBox22" class="form-control" AutoPostBack="True" OnTextChanged="textBox22_Leave" runat="server"></asp:TextBox>
                </div>
                <label for="inputValue" class="col-md-1 control-label">ת"ז</label>
                
            </div>
        </div>
    </div>
                  <div class="form-group">
       <%-- <span class="col-md-2 control-label">Metadata</span>--%>
        <div class="col-md-6">
            <h2>עגלת קניות</h2>
            <div class="form-group row">
                 
               
                <div class="col-md-2">
                    <asp:TextBox ID="TextBox1" class="form-control" AutoPostBack="True" OnTextChanged="textBox3_Leave"  runat="server" >0</asp:TextBox>
                </div> 
                <label for="inputKey" class="col-md-1 control-label"> כמות</label>

               
                <div class="col-md-2">
                    <asp:TextBox ID="TextBox2" ReadOnly = true class="form-control" runat="server"></asp:TextBox>
                </div>
                <label for="inputValue" class="col-md-1 control-label">שם מוצר</label>
                 
                
                <div class="col-md-2">
                    <asp:TextBox ID="TextBox3" class="form-control" AutoPostBack="True" OnTextChanged="textBox3_Leave"  runat="server" >0</asp:TextBox>
                   <%--<input ID="TextBox3" class="form-control" onchange="check()" ></input>--%>
                </div>
                <label for="inputValue" class="col-md-1 control-label">ברקוד</label>



                <div class="form-group row">
                    <%--   <asp:Button ID="Button3" class="btn btn-primary" runat="server" OnClick="Button3_Click" Text="בחר" />--%>
               
                <div class="col-md-2">
                    <asp:TextBox ID="TextBox4" class="form-control" runat="server">0</asp:TextBox>
                </div> 
                <label for="inputKey" class="col-md-1 control-label"> כמות</label>
               
                <div class="col-md-2">
                   <asp:TextBox ID="TextBox5" class="form-control" ReadOnly = true  runat="server"></asp:TextBox>
                </div>
                <label for="inputValue" class="col-md-1 control-label">שם מוצר</label>
                   
                
                <div class="col-md-2">
                   <asp:TextBox ID="TextBox6" class="form-control" AutoPostBack="True" OnTextChanged="textBox6_Leave" runat="server"></asp:TextBox>
                </div>
                <label for="inputValue" class="col-md-1 control-label">ברקוד</label>
            </div>




                <div class="form-group row">
                   <%-- <asp:Button ID="Button4" class="btn btn-primary" runat="server" OnClick="Button4_Click" Text="בחר" />--%>
               
                <div class="col-md-2">
                    <asp:TextBox ID="TextBox7" class="form-control" runat="server">0</asp:TextBox>
                </div> 
                <label for="inputKey" class="col-md-1 control-label"> כמות</label>
               
                <div class="col-md-2">
                   <asp:TextBox ID="TextBox8" class="form-control" ReadOnly = true runat="server"></asp:TextBox>
                </div>
                <label for="inputValue" class="col-md-1 control-label">שם מוצר</label>
                      
                
                <div class="col-md-2">
                  <asp:TextBox ID="TextBox9" class="form-control" AutoPostBack="True" OnTextChanged="textBox9_Leave" runat="server"></asp:TextBox>
                </div>
                <label for="inputValue" class="col-md-1 control-label">ברקוד</label>
            </div>



                <div class="form-group row">
                    <%--<asp:Button ID="Button5" class="btn btn-primary" runat="server" OnClick="Button5_Click" Text="בחר" />--%>
               
                <div class="col-md-2">
                  <asp:TextBox ID="TextBox10" class="form-control" runat="server">0</asp:TextBox>
                </div> 
                <label for="inputKey" class="col-md-1 control-label"> כמות</label>
               
                <div class="col-md-2">
                   <asp:TextBox ID="TextBox11" class="form-control" ReadOnly = true runat="server"></asp:TextBox>
                </div>
                <label for="inputValue" class="col-md-1 control-label">שם מוצר</label>
                      
                
                <div class="col-md-2">
                   <asp:TextBox ID="TextBox12" class="form-control" AutoPostBack="True" OnTextChanged="textBox12_Leave" runat="server"></asp:TextBox>
                </div>
                <label for="inputValue" class="col-md-1 control-label">ברקוד</label>
            </div>



                <div class="form-group row">
                     <%--<asp:Button ID="Button6" class="btn btn-primary" runat="server" OnClick="Button6_Click" Text="בחר" />--%>
               
                <div class="col-md-2">
                  <asp:TextBox ID="TextBox13" class="form-control" runat="server">0</asp:TextBox>
                </div> 
                <label for="inputKey" class="col-md-1 control-label"> כמות</label>
               
                <div class="col-md-2">
                    <asp:TextBox ID="TextBox14" class="form-control" ReadOnly = true runat="server"></asp:TextBox>
                </div>
                <label for="inputValue" class="col-md-1 control-label">שם מוצר</label>
                     
                
                <div class="col-md-2">
                 <asp:TextBox ID="TextBox15" class="form-control" AutoPostBack="True" OnTextChanged="textBox15_Leave" runat="server"></asp:TextBox>
                </div>
                <label for="inputValue" class="col-md-1 control-label">ברקוד</label>
            </div>



                <div class="form-group row">
                     <%--<asp:Button ID="Button7" class="btn btn-primary" runat="server" OnClick="Button7_Click" Text="בחר" />--%>
               
                <div class="col-md-2">
                 <asp:TextBox ID="TextBox16" class="form-control" runat="server">0</asp:TextBox>
                </div> 
                <label for="inputKey" class="col-md-1 control-label"> כמות</label>
               
                <div class="col-md-2">
                    <asp:TextBox ID="TextBox17" class="form-control" ReadOnly = true runat="server"></asp:TextBox>
                </div>
                <label for="inputValue" class="col-md-1 control-label">שם מוצר</label>
                     
                
                <div class="col-md-2">
                    <asp:TextBox ID="TextBox18" class="form-control" AutoPostBack="True" OnTextChanged="textBox18_Leave" runat="server"></asp:TextBox>
                </div>
                <label for="inputValue" class="col-md-1 control-label">ברקוד</label>
            </div>



                <div class="form-group row">
                    <%-- <asp:Button ID="Button8" class="btn btn-primary" runat="server" OnClick="Button8_Click" Text="בחר" />--%>
               
                <div class="col-md-2">
                   <asp:TextBox ID="TextBox19" class="form-control" runat="server">0</asp:TextBox>
                </div> 
                <label for="inputKey" class="col-md-1 control-label"> כמות</label>
               
                <div class="col-md-2">
                  <asp:TextBox ID="TextBox20" class="form-control" ReadOnly = true runat="server"></asp:TextBox>
                </div>
                <label for="inputValue" class="col-md-1 control-label">שם מוצר</label>
                     
                
                <div class="col-md-2">
                   <asp:TextBox ID="TextBox21" class="form-control" AutoPostBack="True" OnTextChanged="textBox21_Leave" runat="server"></asp:TextBox>
                </div>
                <label for="inputValue" class="col-md-1 control-label">ברקוד</label>
            </div>
            </div>
            <h2>  <asp:Button ID="Button3" class="btn btn-primary" runat="server" OnClick="Button3_Click" Text="שלם" Visible="False" />
                <asp:Button ID="Button2" class="btn btn-primary" runat="server" OnClick="Button2_Click" Text="חשב הזמנה" />
              <%--  <asp:Button ID="Button9" class="btn btn-primary" runat="server" OnClick="Button8_Click" Text="בצע הזמנה" />--%>
                <asp:Label ID="Label1" runat="server" Text="0.00"></asp:Label>
                :מחיר</h2>

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

        <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js" type="text/javascript"></script>
  <script>
      $("#TextBox3").change(function (e) {
          e.preventDefault();
          $.ajax({
              type: "POST",
              url: "/Order.aspx/textBox3_Leaved",
              data: JSON.stringify({
                  id: $(this).val(),
                  msg_cell: $("#msg").val();
              }),
              contentType: "application/json; charset=utf-8",
              dataType: "json",
              success: function (res) {
                  alert(res);
              },
              error: function (res) {
                  alert("eror");
              }
          });

      });

  </script>
    </form>
</body>

</html>

</html>
