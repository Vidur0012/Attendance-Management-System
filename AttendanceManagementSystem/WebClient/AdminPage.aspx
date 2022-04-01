<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminPage.aspx.cs" Inherits="WebClient.AdminPage" %>

    <!DOCTYPE html>

    <html xmlns="http://www.w3.org/1999/xhtml">

    <head runat="server">
        <title></title>
        <link href="Content/bootstrap.min.css" rel="stylesheet" />
        <link href="Content/bootstrap-grid.min.css" rel="stylesheet" />
        <script src="Scripts/bootstrap.min.js"></script>
    </head>

    <body>
        <h1 class="h1" align="center" style="color: white; background-color: #000000">Admin Page</h1>
        <asp:Label ID="Label1" runat="server" class="form-control alert-success" Text=""></asp:Label>
        <form id="form1" runat="server">
            <div class="page-content page-container" id="page-content">
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
                                        ControlToValidate="Tname" runat="server" ValidationGroup="teacher" ErrorMessage="RequiredFieldValidator">
                                    </asp:RequiredFieldValidator>
                                    <br />
                                    <label class="col-form-label-lg">Class:</label>
                                    <asp:DropDownList class="form-control form-input padding" ID="tclass"
                                        runat="server">
                                        <asp:ListItem>1</asp:ListItem>
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
                                        ForeColor="Red" runat="server" ValidationGroup="teacher" ErrorMessage="RequiredFieldValidator">
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
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="Sname" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red" Text="Name required" ValidationGroup="student"></asp:RequiredFieldValidator>
                                    <br />
                                    <label class="col-form-label-lg">Roll No:</label>
                                    <asp:TextBox TextMode="Number" CssClass="form-control" class="form-input padding" ID="rollno"
                                        runat="server"></asp:TextBox>
                                    <br />
                                    <label class="col-form-label-lg">Class:</label>
                                    

                                    <asp:DropDownList class="form-control form-input padding" ID="DropDownList1"
                                        runat="server">
                                        <asp:ListItem>1</asp:ListItem>
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
            <br />
            <hr style="border: 5px solid black" />
            <div class="card">
                <div class="mx-4 card-header d-flex justify-content-between">
                    <asp:Button ID="Button3" CssClass="btn btn-primary col-md-4" runat="server" Text="Teachers"
                        OnClick="Button3_Click" />
                </div>
            </div>
        </form>
        <script src="Scripts/bootstrap.bundle.js"></script>
    </body>

    </html>