<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentsAndTeachers.aspx.cs" Inherits="WebClient.StudentsAndTeachers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.min.js"></script>
</head>

<body style="background-color:floralwhite">
    <form id="form1" runat="server">
        <h1 class="h1 card-header" style="color: white; background-color: #000000">Admin Page
                    <div class="float-end">
                        <asp:Button ID="Button3" CssClass="btn btn-primary" runat="server" Text="Back" OnClick="Button3_Click" />
                        <asp:Button ID="Button4" CssClass="btn btn-danger" runat="server" Text="Logout" OnClick="Button4_Click" />
                    </div>
        </h1>
        <center>

       
        <div class="col-md-10 col  justify-content-center">

            <asp:Label ID="Label1" CssClass="form-control alert-danger" runat="server" Text=""></asp:Label>
            <div class="mt-3 card" style="background-color:navajowhite">


                <div class="card-header rounded text-white bg-dark  ">

                    <div >
                        <span class="h1 float-start">

                        Students List
                        </span>
                        <div class="float-end h3">
                            Select Class
                <asp:DropDownList class="col padding" ID="sclass" AutoPostBack="true" OnSelectedIndexChanged="sclass_SelectedIndexChanged"
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
                        </div>
                    </div>

                </div>

                <div style="max-height: 40vh; overflow-y: auto; overflow-x: hidden" class="card-body">
                    <asp:GridView CssClass="auto-style1" ID="GridViewStudent" runat="server" BackColor="White" BorderColor="#999999"
                        BorderStyle="Solid" BorderWidth="1px" Style="max-height: fit-content; width: 100%;" CellPadding="3"
                        AutoGenerateColumns="False" OnRowEditing="GridViewStudent_RowEditing" OnRowDeleting="OnDeleteStudent">
                        <AlternatingRowStyle BackColor="#CCCCCC" />
                        <Columns>
                            <asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="true">
                                <ItemStyle BorderWidth="2px" BorderStyle="Groove" BorderColor="Black" HorizontalAlign="Center"></ItemStyle>
                            </asp:BoundField>
                            <asp:BoundField DataField="Name" HeaderText="Name">
                                <ItemStyle BorderWidth="2px" BorderStyle="Groove" BorderColor="Black" HorizontalAlign="Center"></ItemStyle>
                            </asp:BoundField>
                            <asp:BoundField DataField="Class" HeaderText="Class">
                                <ItemStyle BorderWidth="2px" BorderStyle="Groove" BorderColor="Black" HorizontalAlign="Center"></ItemStyle>
                            </asp:BoundField>
                            <asp:BoundField DataField="RollNo" HeaderText="RollNo">
                                <ItemStyle BorderWidth="2px" BorderStyle="Groove" BorderColor="Black" HorizontalAlign="Center"></ItemStyle>
                            </asp:BoundField>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:LinkButton Text="Edit" CssClass="btn btn-success mx-2" runat="server" CommandName="Edit" />
                                    <asp:LinkButton Text="Delete" CssClass="btn btn-danger mx-2" runat="server" OnClick="OnDeleteStudent" />
                                    <asp:LinkButton Text="Attendance" CssClass="btn btn-info mx-2" runat="server" OnClick="ViewAttendanceStudent" />

                                </ItemTemplate>
                                <EditItemTemplate>
                                    <asp:LinkButton Text="Update" CssClass="btn btn-primary" runat="server" OnClick="OnUpdateStudent" />
                                    <asp:LinkButton Text="Cancel" CssClass="btn btn-danger" runat="server" OnClick="OnCancelStudent" />
                                </EditItemTemplate>
                                <ItemStyle BorderWidth="2px" BorderStyle="Groove" BorderColor="Black" HorizontalAlign="Center"></ItemStyle>
                            </asp:TemplateField>
                        </Columns>
                        <FooterStyle BackColor="#CCCCCC" />
                        <HeaderStyle HorizontalAlign="Center" BackColor="Black" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F1F1F1" />
                        <SortedAscendingHeaderStyle BackColor="#808080" />
                        <SortedDescendingCellStyle BackColor="#CAC9C9" />
                        <SortedDescendingHeaderStyle BackColor="#383838" />
                    </asp:GridView>
                </div>
            </div>
           
            <div class="mt-5 card" style="background-color:navajowhite">
                <div class="card-header rounded text-white bg-dark ">

                    <div>
                        <span class="h1 float-start">

                        Teachers List
                        </span>
                        <div class="float-end h3">
                            Select Class
                 <asp:DropDownList class="col padding" ID="tclass"
                     runat="server" AutoPostBack="true" OnSelectedIndexChanged="tclass_SelectedIndexChanged">
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
                    </div>

                </div>
                <div style="max-height: 40vh; overflow-y: auto; overflow-x: hidden" class="card-body">
                    <asp:GridView CssClass="auto-style1" ID="GridViewTeacher" runat="server" BackColor="White" BorderColor="#999999"
                        BorderStyle="Solid" BorderWidth="1px" Style="max-height: fit-content; width: 100%;" CellPadding="3"
                        AutoGenerateColumns="False" OnRowEditing="GridViewTeacher_RowEditing" OnRowDeleting="OnDeleteTeacher">
                        <AlternatingRowStyle BackColor="#CCCCCC" />
                        <Columns>
                            <asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="true">
                                <ItemStyle BorderWidth="2px" BorderStyle="Groove" BorderColor="Black" HorizontalAlign="Center"></ItemStyle>
                            </asp:BoundField>
                            <asp:BoundField DataField="Name" HeaderText="Name">
                                <ItemStyle BorderWidth="2px" BorderStyle="Groove" BorderColor="Black" HorizontalAlign="Center"></ItemStyle>
                            </asp:BoundField>
                            <asp:BoundField DataField="Class" HeaderText="Class">
                                <ItemStyle BorderWidth="2px" BorderStyle="Groove" BorderColor="Black" HorizontalAlign="Center"></ItemStyle>
                            </asp:BoundField>
                            <asp:BoundField DataField="Subject" HeaderText="Subject">
                                <ItemStyle BorderWidth="2px" BorderStyle="Groove" BorderColor="Black" HorizontalAlign="Center"></ItemStyle>
                            </asp:BoundField>
                            <asp:BoundField DataField="Password" HeaderText="Password">
                                <ItemStyle BorderWidth="2px" BorderStyle="Groove" BorderColor="Black" HorizontalAlign="Center"></ItemStyle>
                            </asp:BoundField>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:LinkButton Text="Edit" CssClass="btn btn-success mx-2" runat="server" CommandName="Edit" />
                                    <asp:LinkButton Text="Delete" CssClass="btn btn-danger mx-2" runat="server" OnClick="OnDeleteTeacher" />
                                    <asp:LinkButton Text="Attendance" CssClass="btn btn-info mx-2" runat="server" OnClick="ViewAttendanceTeacher" />
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <asp:LinkButton Text="Update" CssClass="btn btn-primary" runat="server" OnClick="OnUpdateTeacher" />
                                    <asp:LinkButton Text="Cancel" CssClass="btn btn-danger" runat="server" OnClick="OnCancelTeacher" />
                                </EditItemTemplate>
                                <ItemStyle BorderWidth="2px" BorderStyle="Groove" BorderColor="Black" HorizontalAlign="Center"></ItemStyle>
                            </asp:TemplateField>
                        </Columns>
                        <FooterStyle BackColor="#CCCCCC" />
                        <HeaderStyle HorizontalAlign="Center" BackColor="Black" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F1F1F1" />
                        <SortedAscendingHeaderStyle BackColor="#808080" />
                        <SortedDescendingCellStyle BackColor="#CAC9C9" />
                        <SortedDescendingHeaderStyle BackColor="#383838" />
                    </asp:GridView>
                </div>

            </div>
        </div>
             </center>
    </form>
</body>
</html>
