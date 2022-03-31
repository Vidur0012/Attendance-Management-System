<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentsAndTeachers.aspx.cs" Inherits="WebClient.StudentsAndTeachers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.min.js"></script>
</head>

<body class="container">
    <form id="form1" runat="server">
        <div class="mt-3">
            <div class="card-header rounded text-white bg-primary">
                <center>
                    <h3>Students</h3>
                </center>
            </div>
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
        <div class="mt-5">
            <div class="card-header rounded text-white bg-primary">
                <center>
                    <h3>Teachers</h3>
                </center>
            </div>
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
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton Text="Edit" CssClass="btn btn-success mx-2" runat="server" CommandName="Edit" />
                            <asp:LinkButton Text="Delete" CssClass="btn btn-danger mx-2" runat="server" OnClick="OnDeleteTeacher" />
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
    </form>
</body>
</html>
