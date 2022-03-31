<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="WebClient.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title>Attendance System</title>
    <link href="Content/bootstrap-grid.min.css" rel="stylesheet" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                <div class="page-content page-container" id="page-content">
                    <div class="padding">
                        <div class="card">
                            <div class="row">
                                <div class="col-md-6">
                                    <h3 class="card-header text-white bg-dark">Attendance Management System
                                    </h3>
                                    <div class="card">
                                        <div class="card-card-header">
                                            <label class="form-control bg-info text-black">Admin Login</label>
                                        </div>
                                        <div class="card-body">
                                            <asp:Label ID="Label1" runat="server" class="form-control alert-danger" Text=""></asp:Label>
                                            <div class="col-md-6 row form-inline">
                                                <label class="col-md-6 col-form-label-lg">Username :</label>
                                                <asp:TextBox ID="TextBox1" TextMode="SingleLine" CssClass="col-md-6 form-control" runat="server"></asp:TextBox>

                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ForeColor="red" ErrorMessage="RequiredFieldValidator" Text="Username is Required" ControlToValidate="TextBox1"></asp:RequiredFieldValidator>

                                            </div>
                                            <div class="col-md-6 row">
                                                <label class="col-md-6 col-form-label-lg">Password :</label>
                                                <asp:TextBox ID="TextBox2" CssClass="col-md-6 form-control " runat="server" TextMode="Password"></asp:TextBox>
                                                <asp:RequiredFieldValidator ControlToValidate="TextBox2" ID="RequiredFieldValidator2" ForeColor="red" runat="server" Text="Password is Required" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>

                                                <asp:Button ID="Button1" class="btn btn-primary col-md-4 mt-3" runat="server" Text="Login" OnClick="Button1_Click" />
                                            </div>
                                        </div>
                                    </div>
                                     <div class="card-footer">
                                        <label class="form-control card-header table bg-info text-black">Teacher Panel</label>
                                        <br />
                                        <label class="col-md-5 col-form-label-lg">Teacher</label>
                                        <asp:DropDownList  class="col-md-5 btn btn-outline-info dropdown-toggle" type="button" data-toggle="dropdown"  
                                            ID="teacherlist" runat="server">
                                          </asp:DropDownList>
                                       
                                         <asp:Button ID="Button2" class="btn btn-primary col-md-4 mt-3" runat="server" Text="Enter  " OnClick="Button2_Click"  />

                                    </div>
                                </div>
                                <div class="col-md-6 text-right">
                                    <img src="https://mdbootstrap.com/img/Photos/new-templates/bootstrap-registration/draw1.png" class="img-fluid" alt="Sample image" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
    <script src="Scripts/bootstrap.min.js"></script>
</body>
    </html>