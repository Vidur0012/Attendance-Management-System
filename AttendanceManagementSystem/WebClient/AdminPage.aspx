<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminPage.aspx.cs" Inherits="WebClient.AdminPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title>Admin Panel</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/bootstrap-grid.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.min.js"></script>
</head>

<body>
    <form id="form1" runat="server">
        <h1 class="h1 card-header" style="color: white; background-color: #000000">Admin Page
            <div class="float-end">
                <asp:Button ID="Button3" CssClass="btn btn-primary" runat="server" Text="Show List" OnClick="Button3_Click" />
                <asp:Button ID="Button4" CssClass="btn btn-danger" runat="server" Text="Logout" OnClick="Button4_Click" />
            </div>
        </h1>
        <asp:Label ID="Label1" runat="server" class="form-control alert-success" Text=""></asp:Label>
        <div class="page-content page-container card-body" id="page-content" style="background-color:antiquewhite">
            <div class="padding">
                <div class="row">

                    <div class="col-md-6">
                        <div class="card p-3">
                            <div class="card-header text-white bg-dark rounded">
                                <h3>Add Teacher</h3>
                            </div>
                            <div class="card-body">
                                <label class="col-form-label-lg">Name:</label>
                                <asp:TextBox CssClass="form-control" TextMode="SingleLine"
                                    class="form-input padding" ID="Tname" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ForeColor="Red"
                                    ControlToValidate="Tname" runat="server" ValidationGroup="teacher" ErrorMessage="Name is required.">
                                </asp:RequiredFieldValidator>
                                <br />
                                <label class="col-form-label-lg">Class:</label>
                                <asp:DropDownList class="form-control form-input padding" ID="tclass"
                                    runat="server">
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
                                <br />
                                <label class="col-form-label-lg">Subject:</label>
                                <asp:TextBox CssClass="form-control" TextMode="SingleLine"
                                    class="form-input padding" ID="subject" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="subject"
                                    ForeColor="Red" runat="server" ValidationGroup="teacher" ErrorMessage="Subject is required.">
                                </asp:RequiredFieldValidator>
                                <br />
                                <label class="col-form-label-lg">Password:</label>
                                <asp:TextBox CssClass="form-control" TextMode="SingleLine"
                                    class="form-input padding" ID="password" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ControlToValidate="password"
                                    ForeColor="Red" runat="server" ValidationGroup="teacher" ErrorMessage="Password is required.">
                                </asp:RequiredFieldValidator>
                                <br />
                                <br />
                                <center>
                                    <asp:Button ID="Button1" CssClass="btn btn-dark col-md-6 mb-2" runat="server"
                                        Text="Add" OnClick="Button1_Click" ValidationGroup="teacher" />
                                </center>

                            </div>
                        </div>

                    </div>


                    <div class="col-md-6 text-right ">
                        <div class="card p-3">
                            <div class="card-header text-white bg-dark rounded">
                                <h3>Add Student</h3>
                            </div>
                            <div class="card-body">
                                <label class="col-form-label-lg">Name:</label>
                                <asp:TextBox CssClass="form-control" class="form-input padding" ID="Sname"
                                    runat="server" TextMode="SingleLine"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="Sname" runat="server" ErrorMessage="Name is required." ForeColor="Red" Text="Name required" ValidationGroup="student"></asp:RequiredFieldValidator>
                                <br />
                                <label class="col-form-label-lg">Roll No:</label>
                                <asp:TextBox TextMode="Number" CssClass="form-control" class="form-input padding" ID="rollno"
                                    runat="server"></asp:TextBox>
                                <br />
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" ControlToValidate="rollno" runat="server" ErrorMessage="RollNo is required." ForeColor="Red" Text="Name required" ValidationGroup="student"></asp:RequiredFieldValidator>
                                <br />
                                <label class="col-form-label-lg">Class:</label>


                                <asp:DropDownList class="form-control form-input padding" ID="sclass"
                                    runat="server">
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
                                <br />
                                <br />
                                <center>
                                    <asp:Button ID="Button2" CssClass="btn btn-dark col-md-6 mb-2" runat="server"
                                        Text="Add" OnClick="Button2_Click" ValidationGroup="student" />
                                </center>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
    <script src="Scripts/bootstrap.bundle.js"></script>
    <script type="text/javascript">
        var style = document.getElementById("Label1").offsetLeft;
        if (style >= 0) {
            setTimeout(function () {
                document.getElementById("Label1").style.display = 'none';
            }, 3000);

        }
    </script>
</body>
</html>