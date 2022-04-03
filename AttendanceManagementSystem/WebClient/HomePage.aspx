<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="WebClient.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title>Attendance System</title>
    <link href="Content/bootstrap-grid.min.css" rel="stylesheet" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" class="mx-3" runat="server">
        <div>
            <div>
                <div class="page-content page-container" id="page-content p-3">
                    <div class="padding">
                        <div class="card">
                            <div class="row">
                                <div class="col-md-6">
                                    <h3 class="card-header text-white bg-dark">Attendance Management System
                                    </h3>
                                    <div class="card p-3">
                                        <div class="card-card-header">
                                            <label class="form-control bg-info text-black">Admin Login</label>
                                        </div>
                                        <div class="card-body">
                                            <asp:Label ID="Label1" runat="server" class="form-control alert-danger" Text=""></asp:Label>
                                            <div class="col-md-6 row form-inline">
                                                <label class="col-md-6 col-form-label-lg">Username :</label>
                                                <asp:TextBox ID="TextBox1" TextMode="SingleLine" CssClass="col-md-6 form-control" runat="server"></asp:TextBox>

                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ValidationGroup="admin" Display="Dynamic" runat="server" ForeColor="red" ErrorMessage="RequiredFieldValidator" Text="Username is Required" ControlToValidate="TextBox1"></asp:RequiredFieldValidator>

                                            </div>
                                            <div class="col-md-6 row">
                                                <label class="col-md-6 col-form-label-lg">Password :</label>
                                                <asp:TextBox ID="TextBox2" CssClass="col-md-6 form-control " runat="server" TextMode="Password"></asp:TextBox>
                                                <asp:RequiredFieldValidator Display="Dynamic" ControlToValidate="TextBox2" ID="RequiredFieldValidator2" ValidationGroup="admin" ForeColor="red" runat="server" Text="Password is Required" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>

                                                <asp:Button ID="Button1" ValidationGroup="admin" class="btn btn-primary col-md-6 mt-2" runat="server" Text="Admin Login" OnClick="Button1_Click" />
                                            </div>
                                        </div>
                                    </div>
                                    <div class="card mt-2 p-3">
                                        <div class="card-card-header">
                                            <label class="form-control bg-info text-black">Teacher Login</label>
                                        </div>
                                        <asp:Label ID="Label2" runat="server" class="form-control alert-danger" Text=""></asp:Label>

                                        <div class="row">
                                            <label class="col-md-2 col-form-label-lg">Class :</label>
                                            <asp:DropDownList class="col-md-4 mt-2" ID="tclass"
                                                runat="server" Width="200px" Height="35px">
                                                <asp:ListItem Selected="True">1</asp:ListItem>
                                                <asp:ListItem>2</asp:ListItem>
                                                <asp:ListItem>3</asp:ListItem>
                                                <asp:ListItem>4</asp:ListItem>
                                                <asp:ListItem>5</asp:ListItem>
                                                <asp:ListItem>6</asp:ListItem>
                                                <asp:ListItem>7</asp:ListItem>
                                                <asp:ListItem>8</asp:ListItem>
                                                <asp:ListItem>9</asp:ListItem>
                                                <asp:ListItem>10</asp:ListItem>
                                                <asp:ListItem>11</asp:ListItem>
                                                <asp:ListItem>12</asp:ListItem>
                                            </asp:DropDownList>
                                        </div>

                                        <div class="col-md-6 mt-2 row form-inline">
                                            <label class="col-md-6 col-form-label-lg py-0">Subject :</label>
                                            <asp:TextBox ID="TextBox3" TextMode="SingleLine" CssClass="col-md-6 mx-3 form-control" runat="server"></asp:TextBox>
                                            <asp:RequiredFieldValidator Display="Dynamic" ID="RequiredFieldValidator3" ValidationGroup="teacher" runat="server" ForeColor="red" ErrorMessage="RequiredFieldValidator" Text="Subject is Required" ControlToValidate="TextBox3"></asp:RequiredFieldValidator>
                                        </div>

                                        <div class="col-md-6 row form-inline">
                                            <label class="col-md-6 col-form-label-lg py-0">Password :</label>
                                            <asp:TextBox ID="TextBox4" CssClass="col-md-6 mx-3 form-control" runat="server" TextMode="Password"></asp:TextBox>
                                            <asp:RequiredFieldValidator Display="Dynamic" ControlToValidate="TextBox4" ValidationGroup="teacher" ID="RequiredFieldValidator4" ForeColor="red" runat="server" Text="Password is Required" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
                                        </div>

                                        <asp:Button ID="Button2" class="btn btn-primary col-md-3 mb-2 mt-2" runat="server" ValidationGroup="teacher" Text="Teacher Login" OnClick="Button2_Click" />
                                    </div>
                                </div>
                                <div class="col-md-6 text-right">
                                    <img src="assets/img/home.png" class="img-fluid" alt="Sample image" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
    <script type="text/javascript">
        var style = document.getElementById("Label1").offsetLeft;
        if (style >= 0) {
            setTimeout(function () {
                document.getElementById("Label1").style.display = 'none';
            }, 3000);

        }
    </script>
    <script src="Scripts/bootstrap.min.js"></script>
</body>
</html>
